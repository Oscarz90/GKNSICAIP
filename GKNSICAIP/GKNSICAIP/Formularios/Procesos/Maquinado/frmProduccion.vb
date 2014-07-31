Imports CapaNegocios
Imports System.Threading

Public Class frmProduccion
#Region "Objetos"
    Dim ofrmMensaje_Turno As msg_Dialogo
    Dim ofrmMensaje_Descanso_Equipo As msg_Dialogo_Descanso_All_Lineas
    Dim oModificaciones_permiso As Modificacion_Permiso
    Dim oModificaciones_permiso_log As Modificacion_Permiso_Log
#End Region
#Region "Atributos"
    'Globales
    Private vcve_equipo As Integer
    Private vnombre_equipo As String
    Private vnombre_empleado As String
    Private vcodigo_empleado As String
    Private vCve_Linea_CBX As Integer
    Private vLogModifPermDes As String
    'Temporal de desarrollo
    Private vcve_registro_turno As Long
    Private vcve_turno As Long
    'Banderas
    Private flgBanderacbxLineas As Boolean = False
    Private flgBanderacbxModelos As Boolean = False
    Private flgBanderacbxModelosDesecho As Boolean = False
    Private flgBanderacbxTurnos As Boolean = False
    Private flgBanderacbxMaquinas As Boolean = False
    Private flgBanderacbxParos As Boolean = False
    Private flgBanderaModificacionPermiso As Boolean = False
    'CDM
    Private contenedor_CDM As CDM_Class
    Private obtenedor_CDM As frmCDM
    'Fecha inicio y termino del turno
    Dim ini_aux As DateTime
    Dim fin_aux As DateTime
    'Notificaciones
    Dim body_notificacion As String
    Dim subject_notificacion As String
#End Region
#Region "Propiedades"
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
        End Set
    End Property
    'Public Property Cve_Linea_CBX() As Integer
    '    Get
    '        Return vCve_Linea_CBX
    '    End Get
    '    Set(ByVal value As Integer)
    '        vCve_Linea_CBX = cbxLinea.SelectedValue
    '    End Set
    'End Property
#End Region
#Region "Inicializando formulario"
    'Load
    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'inicializa_formulario()
        accion_btnTerminar()
    End Sub

    'Establece variables globales
    Public Sub set_Datos_Equipo(ByVal idEq As Integer, ByVal NomEquipo As String, ByVal Empleado As String, ByVal CodEmpleado As String)
        vcve_equipo = idEq
        vnombre_equipo = NomEquipo
        vcodigo_empleado = CodEmpleado
        vnombre_empleado = Empleado
        lblNombreEquipo.Text = NomEquipo
        lblCodigoEmpleado.Text = CodEmpleado
        lblNombreEmpleado.Text = Empleado
    End Sub
    'Llena toda la info del formulario
    Private Sub inicializa_formulario()
        get_Imagen_Equipo()
        define_calendario_descanso()
        'Descansos
        llena_Descanso_gridview()
        'lineas turnos
        llena_lineas_No_gridview()
        llena_lineas_Si_gridview()
        'General
        llena_cbx_Turnos()
        llena_cbx_Lineas()
        'CDM
        contenedor_CDM = New CDM_Class
        contenedor_CDM.set_not_used()
        obtenedor_CDM = New frmCDM(contenedor_CDM)
        establece_dia_descanso()
        'valida_dia_modificaciones()
    End Sub
    'Llena info del formulario
    Private Sub llena_informacion_tabs_formulario()
        llena_cbx_Modelos()
        'Productividad
        llena_productividad_gridview()
        llena_desecho_gridview()
        'Rechazos
        llena_cbx_Tipo_Rechazos()
        llena_rechazo_gridview()
        'Paros
        llena_cbx_Maquinas()
        llena_cbx_Paros()
        llena_paro_gridview()
        'Gente
        llena_cbx_Detalle_Gente()
        llena_gente_gridview()
        'Seguridad
        llena_cbx_cond_inseg()
        llena_cbx_accidentes()
        llena_cond_inseg_gridview()
        llena_accidentes_gridview()
        'Productividad
        actualiza_tabla_turno_minutos()
        calcula_Productividad()
        calcula_NRFTI()
        '5S
        llena_cinco_S()
        'Costo
        verifica_costo()
        'comentarios_generales
        llena_comentarios_generales_gridview()
    End Sub
#End Region
#Region "Calculo de OEE"
    Private Sub calcula_Productividad()
        calcula_Disponibilidad()
        calcula_Desempeno()
        calcula_Calidad()
        calcula_OEE()
    End Sub
    Private Sub calcula_Disponibilidad()
        If lblTiempoTurno.Text <> "0" And lblTiempoCarga.Text = lblParosNoPlaneados.Text Then
            lblDisponibilidad.Text = "0.00"
        ElseIf lblTiempoCarga.Text <> "0" And lblTiempoOperacion.Text <> "0" Then
            If ((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100) <= 100 Then
                lblDisponibilidad.Text = Format((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100, "##0.00")
            ElseIf ((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100) > 100 Then
                lblDisponibilidad.Text = "100.00"
            Else
                lblDisponibilidad.Text = "0.00"
            End If
        Else
            lblDisponibilidad.Text = "0.00"
        End If
    End Sub
    Private Sub calcula_Desempeno()
        Dim produccion_d As Double
        Dim desechos_d As Double
        Dim tiempo_operacion As Double = Convert.ToDouble(lblTiempoOperacion.Text)
        Dim desempeno As Double
        Dim oTC As New TC
        Dim oProduccion As New Produccion
        Dim oDesecho As New Desecho

        For Each row As DataGridViewRow In grdDetalleProductividad.Rows
            oProduccion.cve_produccion = Val(row.Cells(0).Value)
            oProduccion.Cargar()
            oTC.cve_TC = oProduccion.cve_TC
            produccion_d += (oTC.obtener_tiempo_ciclo() * Val(row.Cells(5).Value))
        Next
        For Each row As DataGridViewRow In grdDetalleDesecho.Rows
            oDesecho.cve_desecho = Val(row.Cells(0).Value)
            oDesecho.Cargar()
            oTC.cve_TC = oDesecho.cve_TC
            desechos_d += (oTC.obtener_tiempo_ciclo() * Val(row.Cells(5).Value))
        Next
        desempeno = ((produccion_d + desechos_d) / tiempo_operacion) * 100
        If tiempo_operacion <> 0 Then
            If desempeno <= 100 And desempeno >= 0 Then
                lblDesempeno.Text = Format(desempeno, "##0.00")
            ElseIf desempeno < 0 Then
                lblDesempeno.Text = "0.00"
            Else
                If cbxModeloProductividad.SelectedIndex <> -1 Then
                    'MsgBox("Entre a enviar email")
                    get_body_notificacion(desempeno)
                    Dim newThread As New System.Threading.Thread(AddressOf envia_notificacion_sobreproduccion)

                End If
                lblDesempeno.Text = "100.00"
            End If
        Else
            lblDesempeno.Text = "0.00"
        End If
    End Sub
    Private Sub calcula_Calidad()
        Dim varvalida As Double = (get_suma_desechos() + get_suma_piezas_producidas())
        If lblTiempoTurno.Text <> "0" And get_suma_piezas_producidas() = 0 Then
            lblCalidad.Text = "0.00"
        ElseIf varvalida <> 0 And get_suma_piezas_producidas() <> 0 Then
            Dim resultado As Double = ((((get_suma_piezas_producidas() + get_suma_desechos()) - get_suma_desechos_aplicables()) / varvalida) * 100)
            If resultado <= 100 And resultado >= 0 Then
                lblCalidad.Text = Format(resultado, "##0.00")
            ElseIf resultado < 0 Then
                lblCalidad.Text = "0.00"
            Else
                lblCalidad.Text = "100.00"
            End If
        Else
            lblCalidad.Text = "0.00"
        End If
    End Sub
    Private Sub calcula_OEE()
        lblOEE.Text = Format((Convert.ToDouble(lblCalidad.Text) / 100) * (Convert.ToDouble(lblDisponibilidad.Text) / 100) * (Convert.ToDouble(lblDesempeno.Text) / 100) * 100, "##0.00")
    End Sub
    Private Sub calcula_NRFTI()
        Dim varvalida As Double = (get_suma_piezas_producidas() + get_suma_desechos())
        If varvalida <> 0 And get_suma_desechos_aplicables() <> 0 Then
            Dim resultado As Double = (get_suma_desechos_aplicables() / varvalida) * 1000000
            If resultado < 0 Then
                lblNRFTi.Text = "0.00"
            Else
                lblNRFTi.Text = Format(Decimal.Round(resultado), "##,##0.00")
            End If
        Else
            lblNRFTi.Text = "0.00"
        End If
    End Sub
#End Region
#Region "LLenado ComboBoxs"
    'Turnos
    Private Sub llena_cbx_Turnos()
        Dim oTurnos As New CapaNegocios.Turno
        cbxTurno.ValueMember = "cve_turno"
        cbxTurno.DisplayMember = "turno"
        cbxTurno.DataSource = oTurnos.llena_combo_turnos
        cbxTurno.SelectedIndex = -1

        'turnos de Linea Registro
        cbxTurnosLineas.ValueMember = "cve_turno"
        cbxTurnosLineas.DisplayMember = "turno"
        cbxTurnosLineas.DataSource = oTurnos.llena_combo_turnos
        cbxTurnosLineas.SelectedIndex = -1

        flgBanderacbxTurnos = True
    End Sub
    'Lineas
    Private Sub llena_cbx_Lineas()
        flgBanderacbxLineas = False
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas()
        cbxLinea.SelectedIndex = -1
        flgBanderacbxLineas = True
    End Sub
    'Modelos (por Linea)
    Private Sub llena_cbx_Modelos()
        flgBanderacbxModelos = False
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            Dim oModelo As New CapaNegocios.Modelo
            oModelo.cve_linea = cbxLinea.SelectedValue
            cbxModeloProductividad.ValueMember = "cve_modelo"
            cbxModeloProductividad.DisplayMember = "np_gkn"
            cbxModeloProductividad.DataSource = oModelo.llena_combo_Modelos_Linea()
            cbxModeloProductividad.SelectedIndex = -1

            cbxModeloRechazo.ValueMember = "cve_modelo"
            cbxModeloRechazo.DisplayMember = "np_gkn"
            cbxModeloRechazo.DataSource = oModelo.llena_combo_Modelos_Linea()
            cbxModeloRechazo.SelectedIndex = -1



            flgBanderacbxModelos = True
        End If
    End Sub
    Private Sub llena_cbx_Modelos_Desecho()
        flgBanderacbxModelosDesecho = False
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            Dim oModelo As New CapaNegocios.Modelo
            oModelo.cve_registro_turno = get_registro_del_turno()
            cbxModeloDesecho.ValueMember = "cve_modelo"
            cbxModeloDesecho.DisplayMember = "np_gkn"
            cbxModeloDesecho.DataSource = oModelo.llena_combo_Modelos_Desecho_Linea()
            cbxModeloDesecho.SelectedIndex = -1
            flgBanderacbxModelosDesecho = True
        End If
    End Sub
    'Rechazos
    Private Sub llena_cbx_Tipo_Rechazos()
        Dim oTipoRechazo As New Tipo_Rechazo
        cbxTipoRechazo.ValueMember = "cve_tipo_rechazo"
        cbxTipoRechazo.DisplayMember = "tipo"
        cbxTipoRechazo.DataSource = oTipoRechazo.llena_combo_tipo_rechazo()
        cbxTipoRechazo.SelectedIndex = -1
    End Sub
    'Paros
    Private Sub llena_cbx_Maquinas()
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            Dim oMaquina As New Maquina
            oMaquina.cve_linea = cbxLinea.SelectedValue
            cbxMaquina.ValueMember = "cve_maquina"
            cbxMaquina.DisplayMember = "clave_maquina"
            cbxMaquina.DataSource = oMaquina.llena_combo_maquina()
            cbxMaquina.SelectedIndex = -1
            flgBanderacbxMaquinas = True
        End If
    End Sub

    Private Sub llena_cbx_Paros()
        Dim oParo As New Paro
        cbxTipoParo.ValueMember = "cve_paro"
        cbxTipoParo.DisplayMember = "cod_paro"
        cbxTipoParo.DataSource = oParo.llena_combo_paros()
        cbxTipoParo.SelectedIndex = -1
        flgBanderacbxParos = True
    End Sub
    'Gente
    Private Sub llena_cbx_Detalle_Gente()
        Dim oDetalle_Gente As New Detalle_Gente
        cbxTipoDetalleGente.ValueMember = "cve_detalle_gente"
        cbxTipoDetalleGente.DisplayMember = "descripcion"
        cbxTipoDetalleGente.DataSource = oDetalle_Gente.llena_combo_detalle_gente()
        cbxTipoDetalleGente.SelectedIndex = -1
    End Sub
    'Seguridad - Condiciones Inseguras
    Private Sub llena_cbx_cond_inseg()
        Dim oDetalleSeguridad As New Detalle_Seguridad
        cbxTipoCondInseg.ValueMember = "cve_detalle_seguridad"
        cbxTipoCondInseg.DisplayMember = "descripcion"
        cbxTipoCondInseg.DataSource = oDetalleSeguridad.llena_combo_seguridad_cond_inseg()
        cbxTipoCondInseg.SelectedIndex = -1
    End Sub
    'Seguridad- Accidentes
    Private Sub llena_cbx_accidentes()
        Dim oDetalleSeguridad As New Detalle_Seguridad
        cbxTipoAccidente.ValueMember = "cve_detalle_seguridad"
        cbxTipoAccidente.DisplayMember = "descripcion"
        cbxTipoAccidente.DataSource = oDetalleSeguridad.llena_combo_seguridad_accidentes()
        cbxTipoAccidente.SelectedIndex = -1
    End Sub
#End Region
#Region "Llenado Labels - Textbox"
    'General
    Private Sub obten_descripcion_modelo(ByRef txtmodelodesc As TextBox, ByRef cbxmodelodesc As ComboBox)
        txtmodelodesc.Text = ""
        If flgBanderacbxModelos And cbxmodelodesc.SelectedIndex <> -1 Then
            Dim oModelo As New Modelo
            oModelo.cve_modelo = cbxmodelodesc.SelectedValue
            oModelo.obtener_descripcion_modelo()
            txtmodelodesc.Text = oModelo.descripcion
        End If
    End Sub
    'Paros
    Private Sub obten_descripcion_maquina(ByRef txtmaquinadesc As TextBox, ByRef cbxmaquinadesc As ComboBox)
        txtmaquinadesc.Text = ""
        If flgBanderacbxMaquinas And cbxmaquinadesc.SelectedIndex <> -1 Then
            Dim oMaquina As New Maquina
            oMaquina.cve_maquina = cbxmaquinadesc.SelectedValue
            oMaquina.Cargar()
            txtmaquinadesc.Text = oMaquina.maquina
        End If
    End Sub
    Private Sub obten_descripcion_paro(ByRef txtparodesc As TextBox, ByRef cbxtipoparosdesc As ComboBox)
        txtparodesc.Text = ""
        If flgBanderacbxParos And cbxtipoparosdesc.SelectedIndex <> -1 Then
            Dim oParo As New Paro
            oParo.cve_Paro = cbxtipoparosdesc.SelectedValue
            oParo.obten_descripcion_paro()
            txtparodesc.Text = oParo.paro
        End If
    End Sub
#End Region
#Region "Llenado Gridsviews"
    'Productividad
    Private Sub llena_productividad_gridview()
        grdDetalleProductividad.AutoGenerateColumns = False
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = get_registro_del_turno()
        grdDetalleProductividad.DataSource = oProduccion.llena_productividad_gridview()
    End Sub
    'Desechos
    Private Sub llena_desecho_gridview()
        Dim oDesecho As New Desecho
        oDesecho.cve_registro_turno = get_registro_del_turno()
        grdDetalleDesecho.DataSource = oDesecho.llena_desecho_gridview()
    End Sub
    'Rechazos
    Private Sub llena_rechazo_gridview()
        Dim oRechazo As New Rechazo
        oRechazo.cve_registro_turno = get_registro_del_turno()
        grdDetalleRechazo.DataSource = oRechazo.llena_rechazo_gridview()
    End Sub
    'Paros
    Private Sub llena_paro_gridview()
        Dim oRegistro_Paro As New Registro_Paro
        oRegistro_Paro.Cve_registro_turno = get_registro_del_turno()
        grdDetalleParo.DataSource = oRegistro_Paro.llena_paro_gridview()
    End Sub
    'Gente
    Private Sub llena_gente_gridview()
        Dim oGente As New Gente
        oGente.cve_registro_turno = get_registro_del_turno()
        grdDetalleGente.DataSource = oGente.llena_gente_gridview()
    End Sub
    'Seguridad - Condiciones Inseguras
    Private Sub llena_cond_inseg_gridview()
        Dim oSeguridad As New Seguridad
        oSeguridad.cve_registro_turno = get_registro_del_turno()
        grdDetalleCondInseg.DataSource = oSeguridad.llena_cond_inseg_gridview()
    End Sub
    'Seguridad - Accidentes
    Private Sub llena_accidentes_gridview()
        Dim oSeguridad As New Seguridad
        oSeguridad.cve_registro_turno = get_registro_del_turno()
        grdDetalleAccidente.DataSource = oSeguridad.llena_accidentes_gridview()
    End Sub
    'Linea Turno
    Private Sub llena_lineas_No_gridview()
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        grdLineasNoRegistradas.DataSource = oEquipoLinea.llena_combo_lineas()
    End Sub
    Private Sub llena_lineas_Si_gridview()
        Dim oRegistro_Turno As New Registro_Turno
        oRegistro_Turno.cve_equipo = vcve_equipo
        'oRegistro_Turno.dia_asignado = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm:ss")) Modificacion Permiso
        oRegistro_Turno.dia_asignado = obtiene_fecha_actual.ToString("dd-MM-yyyy HH:mm:ss")
        grdLineasRegistradas.DataSource = oRegistro_Turno.llena_lineas_registradas_hoy()
    End Sub
    'Descansos
    Private Sub llena_Descanso_gridview()
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_equipo = vcve_equipo
        'oRegistro_turno.dia_asignado = Convert.ToDateTime(Now.ToString("dd-MM-yyyy")) Modificacion Permiso
        oRegistro_turno.dia_asignado = obtiene_fecha_actual.ToString("dd-MM-yyyy")
        grdDetalleDescansos.DataSource = oRegistro_turno.llena_Descanso_gridview()
    End Sub
    '5S
    Private Sub llena_cinco_S()
        Dim oCinco_S As New Cinco_S
        oCinco_S.cve_registro_turno = get_registro_del_turno()
        oCinco_S.verifica_cinco_S()
        txtAdmon.Text = oCinco_S.admon_visual
        txtcinco_S.Text = oCinco_S.cincoS
        txtManto.Text = oCinco_S.mantto_autto
        txtprom.Text = oCinco_S.promedio
        If oCinco_S.bandera_cinco_S = 0 Then
            lblAlertaCincoS.Visible = True
        Else
            lblAlertaCincoS.Visible = False
        End If
    End Sub
    'Comentarios Generales
    Private Sub llena_comentarios_generales_gridview()
        Dim oComentariosGenerales As New Comentarios_Generales
        oComentariosGenerales.cve_registro_turno = get_registro_del_turno()
        grdDetalleComentario.DataSource = oComentariosGenerales.llena_comentarios_generales_gridview
    End Sub
#End Region
#Region "Eventos ComboBox"
    'General
    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        Dim flgModifValida As Boolean = False
        vCve_Linea_CBX = cbxLinea.SelectedValue
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            'If verifica_registro_turno_produccion(cbxLinea.SelectedValue, Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))) Then Modificacion Permiso
            If verifica_registro_turno_produccion(cbxLinea.SelectedValue, obtiene_fecha_actual.ToString("dd-MM-yyyy HH:mm")) Then
                MsgBox("No has registrado Turno para la Linea: " & cbxLinea.Text)
                establece_dia_descanso()
            Else
                cbxTurno.SelectedIndex = vcve_turno - 1
                If cbxTurno.Text = "Descanso" Then
                    establece_dia_descanso()
                    establece_label_fecha_captura()
                Else
                    'If solo para modificaciones
                    If flgBanderaModificacionPermiso Then
                        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                            establece_dia_laboral()
                            establece_hora_inicio_fin_captura()
                            llena_cbx_Modelos()
                            llena_cbx_Modelos_Desecho()
                            llena_cbx_Maquinas()
                            llena_informacion_tabs_formulario()
                            establece_label_fecha_captura()
                        End If
                    Else
                        establece_dia_laboral()
                        establece_hora_inicio_fin_captura()
                        llena_cbx_Modelos()
                        llena_cbx_Modelos_Desecho()
                        llena_cbx_Maquinas()
                        llena_informacion_tabs_formulario()
                        establece_label_fecha_captura()
                    End If

                End If
            End If
        End If

    End Sub
    'Productividad
    Private Sub cbxModeloProductividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloProductividad.SelectedIndexChanged
        txtModeloDescripcionProductividad.Text = ""
        If cbxModeloProductividad.SelectedIndex <> -1 Then
            valida_botones_productividad()
            obten_descripcion_modelo(txtModeloDescripcionProductividad, cbxModeloProductividad)
            piezas_por_hora_modelo()
            deshabilitar_btn_quitar_modelo()
        End If
    End Sub
    'Desechos
    Private Sub cbxModeloDesecho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloDesecho.SelectedIndexChanged
        txtModeloDesecho.Text = ""
        If cbxModeloDesecho.SelectedIndex <> -1 Then
            valida_botones_desecho()
            obten_descripcion_modelo(txtModeloDesecho, cbxModeloDesecho)
            deshabilitar_btn_quitar_desecho()
        End If
    End Sub
    'Rechazos
    Private Sub cbxModeloRechazo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloRechazo.SelectedIndexChanged
        If cbxModeloRechazo.SelectedIndex <> -1 Then
            valida_botones_rechazos()
            obten_descripcion_modelo(txtModeloRechazo, cbxModeloRechazo)
            deshabilitar_btn_quitar_rechazo()
        End If
    End Sub
    Private Sub cbxTipoRechazo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoRechazo.SelectedIndexChanged
        If cbxTipoRechazo.SelectedIndex <> -1 Then
            valida_botones_rechazos()
            deshabilitar_btn_quitar_rechazo()
        End If
    End Sub
    'Paros
    Private Sub cbxMaquina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMaquina.SelectedIndexChanged
        txtMaquinaDescripcion.Text = ""
        If cbxMaquina.SelectedIndex <> -1 Then
            valida_botones_paro()
            obten_descripcion_maquina(txtMaquinaDescripcion, cbxMaquina)
            deshabilitar_btn_quitar_paro()
        End If
    End Sub
    Private Sub cbxTipoParo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoParo.SelectedIndexChanged
        If cbxTipoParo.Text = "H.1" Or cbxTipoParo.Text = "H.2" Or cbxTipoParo.Text = "H.3" Then
            If cbxMaquina.SelectedIndex <> -1 Then
                txtMinutosParo.Enabled = False
                txtDetallesParo.Enabled = False
                activa_captura_CDM()
            Else
                cbxTipoParo.SelectedIndex = -1
            End If
        Else
            valida_botones_paro()
            obten_descripcion_paro(txtParosDescripcion, cbxTipoParo)
            deshabilitar_btn_quitar_paro()
        End If
    End Sub
    'Gente
    Private Sub cbxTipoDetalleGente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoDetalleGente.SelectedIndexChanged
        If cbxTipoDetalleGente.SelectedIndex <> -1 Then
            valida_botones_gente()
            deshabilitar_btn_quitar_gente()
        End If
    End Sub
    'Seguridad - Condiciones Inseguras
    Private Sub cbxTipoCondInseg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoCondInseg.SelectedIndexChanged
        If cbxTipoCondInseg.SelectedIndex <> -1 Then
            valida_botones_cond_inseg()
            deshabilitar_btn_quitar_cond_inseg()
        End If
    End Sub
    'Seguridad - Accidentes
    Private Sub cbxTipoAccidente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoAccidente.SelectedIndexChanged
        If cbxTipoAccidente.SelectedIndex <> -1 Then
            valida_botones_accidentes()
            deshabilitar_btn_quitar_accidentes()
        End If
    End Sub
    'Turno-Lineas
    Private Sub cbxTurnosLineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTurnosLineas.SelectedIndexChanged
        valida_botones_Turno_linea()
    End Sub
#End Region
#Region "Eventos TextBox"
    'Productividad
    Private Sub txtMinutos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTiempoOperacion.TextChanged
        valida_botones_productividad()
        deshabilitar_btn_quitar_modelo()
    End Sub
    Private Sub txtPiezasProducidas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiezasOkProducidas.TextChanged
        valida_botones_productividad()
        deshabilitar_btn_quitar_modelo()
    End Sub
    'Desechos
    Private Sub txtDesechosCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesechosCantidad.TextChanged
        valida_botones_desecho()
        deshabilitar_btn_quitar_desecho()
    End Sub
    'Rechazos
    Private Sub txtRechazosCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRechazosCantidad.TextChanged
        valida_botones_rechazos()
        deshabilitar_btn_quitar_rechazo()
    End Sub
    'Paros
    Private Sub txtMinutosParo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinutosParo.TextChanged
        valida_botones_paro()
        deshabilitar_btn_quitar_paro()
    End Sub
    'Gente
    Private Sub txtGenteCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGenteCantidad.TextChanged
        valida_botones_gente()
        deshabilitar_btn_quitar_gente()
    End Sub
    'Seguridad - Condiciones Inseguras
    Private Sub txtCondInsegCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCondInsegCantidad.TextChanged
        valida_botones_cond_inseg()
        deshabilitar_btn_quitar_cond_inseg()
    End Sub
    'Seguridad - Accidentes
    Private Sub txtAccidenteCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccidenteCantidad.TextChanged
        valida_botones_accidentes()
        deshabilitar_btn_quitar_accidentes()
    End Sub
    '5s
    Private Sub txtAdmonVisual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdmonVisual.TextChanged

        'valida_botones_cinco_s()
        calcula_promedio_cinco_S()


    End Sub
    Private Sub txt5s_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt5s.TextChanged

        'valida_botones_cinco_s()
        calcula_promedio_cinco_S()


    End Sub

    Private Sub txtManttoAutonomo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManttoAutonomo.TextChanged
        'valida_botones_cinco_s()
        calcula_promedio_cinco_S()
    End Sub
    'Comentarios generales
    Private Sub txtDetallesComentario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDetallesComentario.TextChanged
        valida_botones_comentarios_generales()
        deshabilitar_btn_Quitar_comentario()
    End Sub
#End Region
#Region "Eventos Botones"
    'Productividad
    Private Sub btnAgregarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarModelo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If se_puede_añadir_produccion(Convert.ToInt64(txtTiempoOperacion.Text)) Then
                If flgBanderaModificacionPermiso Then
                    vLogModifPermDes = "Registro Producción - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                    " Modelo: " & cbxModeloProductividad.Text & "-(" & cbxModeloProductividad.SelectedValue & ")" &
                    " Cantidad: " & txtPiezasOkProducidas.Text &
                    " Tiempo Operacion: " & txtTiempoOperacion.Text &
                    " #cve: " & get_registro_del_turno()
                End If
                add_modelo_producido()
                log_modificaciones_permiso(vLogModifPermDes)
                llena_productividad_gridview()
                calcula_Productividad()
                limpia_productividad()
                calcula_NRFTI()
                add_productividad()
                add_Nrfti()
                llena_cbx_Modelos_Desecho()

            End If
        End If
    End Sub
    Private Sub btnQuitarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarModelo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Producción - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Modelo: " & grdDetalleProductividad.Item(4, grdDetalleProductividad.CurrentRow.Index).Value &
               "-(" & grdDetalleProductividad.Item(3, grdDetalleProductividad.CurrentRow.Index).Value & ")" &
               " Cantidad: " & grdDetalleProductividad.Item(5, grdDetalleProductividad.CurrentRow.Index).Value &
               " Tiempo Operacion: " & grdDetalleProductividad.Item(6, grdDetalleProductividad.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_modelo_producido()
            log_modificaciones_permiso(vLogModifPermDes)
            llena_productividad_gridview()
            deshabilitar_btn_quitar_modelo()
            calcula_Productividad()
            calcula_NRFTI()
            add_productividad()
            add_Nrfti()
            llena_cbx_Modelos_Desecho()
        End If
    End Sub
    'Desechos
    Private Sub btnAgregarDesecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDesecho.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Desecho - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " Modelo: " & cbxModeloDesecho.Text & "-(" & cbxModeloDesecho.SelectedValue & ")" &
                " Cantidad: " & txtDesechosCantidad.Text &
                " #cve: " & get_registro_del_turno()
            End If
            add_desecho()
            log_modificaciones_permiso(vLogModifPermDes)
            calcula_adeudo()
            limpia_desechos()
            llena_desecho_gridview()
            calcula_Productividad()
            calcula_NRFTI()
            add_productividad()
            add_Nrfti()
        End If
    End Sub
    Private Sub btnQuitarDesecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDesecho.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Desecho - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Modelo: " & grdDetalleDesecho.Item(4, grdDetalleDesecho.CurrentRow.Index).Value &
               "-(" & grdDetalleDesecho.Item(2, grdDetalleDesecho.CurrentRow.Index).Value & ")" &
               " Cantidad: " & grdDetalleDesecho.Item(5, grdDetalleDesecho.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_desecho()
            log_modificaciones_permiso(vLogModifPermDes)
            calcula_adeudo()
            llena_desecho_gridview()
            deshabilitar_btn_quitar_desecho()
            calcula_Productividad()
            calcula_NRFTI()
            add_productividad()
            add_Nrfti()
        End If
    End Sub
    'Rechazos
    Private Sub btnAgregarRechazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRechazo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Rechazo - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " Modelo: " & cbxModeloRechazo.Text & "-(" & cbxModeloRechazo.SelectedValue & ")" &
                " Cantidad: " & txtRechazosCantidad.Text &
                " Tipo: " & cbxTipoRechazo.Text &
                " #cve: " & get_registro_del_turno()
            End If
            add_rechazo()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_rechazos()
            llena_rechazo_gridview()
            llena_productividad_gridview()
            calcula_Productividad()
            calcula_NRFTI()
            add_productividad()
            add_Nrfti()
        End If
    End Sub
    Private Sub btnQuitarRechazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarRechazo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Desecho - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Modelo: " & grdDetalleRechazo.Item(2, grdDetalleRechazo.CurrentRow.Index).Value &
               "-(" & grdDetalleRechazo.Item(1, grdDetalleRechazo.CurrentRow.Index).Value & ")" &
               " Cantidad: " & grdDetalleRechazo.Item(3, grdDetalleRechazo.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_rechazo()
            log_modificaciones_permiso(vLogModifPermDes)
            deshabilitar_btn_quitar_rechazo()
            llena_rechazo_gridview()
            llena_productividad_gridview()
            calcula_NRFTI()
            calcula_Productividad()
            add_productividad()
            add_Nrfti()
        End If
    End Sub
    'Paros
    Private Sub btnAgregarParo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarParo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If se_puede_añadir_produccion_o_paro(Convert.ToInt64(txtMinutosParo.Text)) Then
                If flgBanderaModificacionPermiso Then
                    vLogModifPermDes = "Registro Paro - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                        " Paro: " & cbxTipoParo.Text &
                        " Minutos: " & txtMinutosParo.Text &
                        " Maquina: " & cbxMaquina.Text & "-(" & cbxMaquina.SelectedValue & ")" &
                        " #cve: " & get_registro_del_turno()
                End If
                add_paro()
                log_modificaciones_permiso(vLogModifPermDes)
                limpia_paros()
                llena_paro_gridview()
                actualiza_tabla_turno_minutos()
                calcula_Productividad()
                add_productividad()
                verifica_costo()
                add_costo()
            End If
        End If
    End Sub
    Private Sub btnQuitarParo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarParo.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Paro - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Paro: " & grdDetalleParo.Item(4, grdDetalleParo.CurrentRow.Index).Value &
               " Minutos: " & grdDetalleParo.Item(6, grdDetalleParo.CurrentRow.Index).Value &
               " Maquina: " & grdDetalleParo.Item(7, grdDetalleParo.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_paro()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_paros()
            deshabilitar_btn_quitar_paro()
            llena_paro_gridview()
            actualiza_tabla_turno_minutos()
            calcula_Productividad()
            add_productividad()
            verifica_costo()
            add_costo()
        End If
    End Sub
    'Gente
    Private Sub btnAgregarGente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGente.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Gente - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " Tipo Gente: " & cbxTipoDetalleGente.Text & "-(" & cbxTipoDetalleGente.SelectedValue & ")" &
                " Cantidad: " & txtGenteCantidad.Text &
                " #cve: " & get_registro_del_turno()
            End If
            add_gente()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_gente()
            llena_gente_gridview()
        End If
    End Sub
    Private Sub btnQuitarGente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGente.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Gente - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Descripcion: " & grdDetalleGente.Item(1, grdDetalleGente.CurrentRow.Index).Value &
               " Cantidad: " & grdDetalleGente.Item(2, grdDetalleGente.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_gente()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_gente()
            deshabilitar_btn_quitar_gente()
            llena_gente_gridview()
        End If
    End Sub
    'Seguridad Condiciones Inseguras
    Private Sub btnAgregarCondInseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCondInseg.Click
        Dim acumulado As Integer = 0
        Dim ci_nuevas As Integer = 0
        Dim ci_resueltas As Integer = 0
        Dim vMaximo_Resueltas As Integer = 0
        Dim oObtieneSeguridad As obtiene_seguridad
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Cond. Insegura - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " Tipo Condicion Insegura: " & cbxTipoCondInseg.Text & "-(" & cbxTipoCondInseg.SelectedValue & ")" &
                " Cantidad: " & txtCondInsegCantidad.Text &
                " #cve: " & get_registro_del_turno()
            End If
            If cbxTipoCondInseg.SelectedValue = 1 Then ''SI SON NUEVAS
                add_cond_inseg()
                log_modificaciones_permiso(vLogModifPermDes)
                limpia_cond_inseg()
                llena_cond_inseg_gridview()
            ElseIf cbxTipoCondInseg.SelectedValue = 2 Then ''SI SON RESUELTAS
                '------------------------------------------
                oObtieneSeguridad = New obtiene_seguridad
                oObtieneSeguridad.cve_equipo = vcve_equipo
                oObtieneSeguridad.cve_linea = vCve_Linea_CBX
                oObtieneSeguridad.fecha_inicial = Date.Now.AddDays(-5) '-----restarle unos 3 dias
                oObtieneSeguridad.fecha_final = Date.Now
                oObtieneSeguridad.bandera = 2
                oObtieneSeguridad.obtiene_seguridad_equipo_linea_dia()

                'Exec proc para actualixar historico

                '------------------------------------------
                acumulado = acumulado_dia_anterior()
                ci_nuevas = obtener_nuevas_hoy()
                ci_resueltas = obtener_resueltas_hoy()
                'OBTENER MAXIMO VALOR PARA RESUELTAS
                vMaximo_Resueltas = (acumulado + ci_nuevas) - ci_resueltas
                If txtCondInsegCantidad.Text <= vMaximo_Resueltas Then
                    add_cond_inseg()
                    log_modificaciones_permiso(vLogModifPermDes)
                    limpia_cond_inseg()
                    llena_cond_inseg_gridview()
                Else
                    MsgBox("El valor maximo permitido para registrar RESUELTAS es: " & vMaximo_Resueltas & ", VERIFIQUE")
                    limpia_cond_inseg()
                End If
            End If
        End If
    End Sub
    Private Sub btnQuitarCondInseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCondInseg.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Cond. Insegura - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Descripcion: " & grdDetalleCondInseg.Item(1, grdDetalleCondInseg.CurrentRow.Index).Value &
               " Cantidad: " & grdDetalleCondInseg.Item(2, grdDetalleCondInseg.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_cond_inseg()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_cond_inseg()
            deshabilitar_btn_quitar_cond_inseg()
            llena_cond_inseg_gridview()
        End If
    End Sub
    'Seguridad Accidentes
    Private Sub btnAgregarAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAccidente.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Accidente - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " Tipo Accidente: " & cbxTipoAccidente.Text & "-(" & cbxTipoAccidente.SelectedValue & ")" &
                " Cantidad: " & txtAccidenteCantidad.Text &
                " #cve: " & get_registro_del_turno()
            End If
            add_accidentes()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_accidentes()
            llena_accidentes_gridview()
        End If
    End Sub
    Private Sub btnQuitarAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarAccidente.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Accidente - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " Descripcion: " & grdDetalleAccidente.Item(1, grdDetalleAccidente.CurrentRow.Index).Value &
               " Cantidad: " & grdDetalleAccidente.Item(2, grdDetalleAccidente.CurrentRow.Index).Value &
               " #cve: " & get_registro_del_turno()
            End If
            remove_accidentes()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_accidentes()
            deshabilitar_btn_quitar_accidentes()
            llena_accidentes_gridview()
        End If
    End Sub
    'Turnos Lineas
    Private Sub btnLineasTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineasTodas.Click
        registra_todas_lineas()
    End Sub
    Private Sub btnLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineaUnica.Click
        registra_linea()
    End Sub
    '5s
    Private Sub btnAgregarCincoS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCincoS.Click
        If valida_insercion_cinco_s() Then
            If valida_hora_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                If flgBanderaModificacionPermiso Then
                    vLogModifPermDes = "Registro 5s - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                    " - Tipo Mantto. Autonomo: " & txtManttoAutonomo.Text &
                    " - Tipo Admon. Visual: " & txtAdmonVisual.Text &
                    " - Tipo 5s: " & txt5s.Text &
                    " - Promedio: " & txtPromedio.Text &
                    " #cve: " & get_registro_del_turno()
                End If
                add_cinco_s()
                log_modificaciones_permiso(vLogModifPermDes)
                limpia_cinco_s()
                llena_cinco_S()
            End If
        Else
            MsgBox("Datos No validos para registrar.Revisa tu Formato de evaluacion de 5's Mannto., Auto, Admon. Visual, los resultados no pueden ser enteros ni mayor a 5.", vbExclamation + vbOKOnly, "Aviso!")
        End If
    End Sub
    'Descanso
    Private Sub btnAgregarDescanso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDescanso.Click
        'If dtpDescanso.Value >= Now.ToString("dd-MM-yyy") Then
        If dtpDescanso.Value >= obtiene_fecha_actual.ToString("dd-MM-yyyy") Then
            registra_descanso()
            limpia_descanso()
            llena_Descanso_gridview()
        Else
            limpia_descanso()
            MsgBox("¡Solo puedes registrar descansos con fecha a partir del dia de hoy!", vbExclamation, "Error")
        End If
    End Sub
    Private Sub btnQuitarDescanso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDescanso.Click
        Dim Fecha As Date = grdDetalleDescansos.Item("dia_asignado", grdDetalleDescansos.CurrentRow.Index).Value
        'If Fecha >= Now.ToString("dd-MM-yyy") Then
        If Fecha >= obtiene_fecha_actual.ToString("dd-MM-yyy") Then
            remove_descanso()
            limpia_descanso()
            deshabilitar_btn_quitar_descanso()
            llena_lineas_Si_gridview()
            llena_Descanso_gridview()
        Else
            limpia_descanso()
            deshabilitar_btn_quitar_descanso()
            MsgBox("¡Solo puedes borrar descansos con fecha a partir del dia de hoy!", vbExclamation, "Error")
        End If
    End Sub
    'Comentarios Generales
    Private Sub btnAgregarComentario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComentario.Click
        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Registro Comentario General - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                " - Comentario: " & txtDetallesComentario.Text &
                " #cve: " & get_registro_del_turno()
            End If
            add_comentario()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_comentarios_generales()
            llena_comentarios_generales_gridview()
        End If
    End Sub
    Private Sub btnQuitarComentario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarComentario.Click
        If valida_hora_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
            If flgBanderaModificacionPermiso Then
                vLogModifPermDes = "Elimino Comentario General - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
               " - Comentario: " & grdDetalleComentario.Item(1, grdDetalleComentario.CurrentRow.Index).Value &
               " - (" & grdDetalleComentario.Item(0, grdDetalleComentario.CurrentRow.Index).Value & ")" &
               " #cve: " & get_registro_del_turno()
            End If
            remove_comentario()
            log_modificaciones_permiso(vLogModifPermDes)
            limpia_comentarios_generales()
            deshabilitar_btn_Quitar_comentario()
            llena_comentarios_generales_gridview()
        End If
    End Sub
    'Graficas
    Private Sub cmdGraficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraficar.Click
        AbrirGraficos()
    End Sub
    'Modificaciones
    'Evento al presionar boton para iniciar Modificaciones
    Private Sub btnModModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModModificar.Click
        'If valida_modificacion_permiso() Then
        btnModTerminar.Enabled = True
        cldrModificaciones.Enabled = False
        btnModModificar.Enabled = False
        flgBanderaModificacionPermiso = True
        If flgBanderaModificacionPermiso Then
            establece_hora_inicio_fin_captura()
        End If
        inicializa_formulario()
        'End If
    End Sub
    'Evento al presionar boton para terminar Modificaciones
    Private Sub btnModTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModTerminar.Click
        accion_btnTerminar()
    End Sub
#End Region
#Region "Eventos Gridviews"
    'Productividad
    Private Sub grdDetalleProductividad_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleProductividad.CellClick
        'Dim cve_produccion As Long = grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
        habilita_btn_Quitar_modelo()
    End Sub
    'Desechos
    Private Sub grdDetalleDesecho_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleDesecho.CellClick
        habilita_btn_Quitar_desecho()
    End Sub
    'Rechazos
    Private Sub grdDetalleRechazo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleRechazo.CellClick
        habilita_btn_Quitar_rechazo()
    End Sub
    'Paros
    Private Sub grdDetalleParo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleParo.CellClick
        habilita_btn_Quitar_paro()
    End Sub
    'Gente
    Private Sub grdDetalleGente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleGente.CellClick
        habilita_btn_Quitar_gente()
    End Sub
    'Seguridad - Condiciones Inseguras
    Private Sub grdDetalleCondInseg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleCondInseg.CellClick
        habilita_btn_Quitar_cond_inseg()
    End Sub
    'Seguridad - Accidentes
    Private Sub grdDetalleAccidente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleAccidente.CellClick
        habilita_btn_Quitar_accidentes()
    End Sub
    'Descansos
    Private Sub grdDetalleDescansos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleDescansos.CellClick
        habilita_btn_quitar_descanso()
        'limpia_descanso()
    End Sub
    'Comentarios Generales
    Private Sub grdDetalleComentario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleComentario.CellClick
        habilita_btn_Quitar_comentario()
    End Sub
#End Region
#Region "Eventos DateTimePicker"
    Private Sub dtpDescanso_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDescanso.ValueChanged
        valida_botones_Descansos()
        deshabilitar_btn_quitar_descanso()
    End Sub
    'Valida el calendario de mOdificaciones y (des)Habilita el boton de modificar.
    Private Sub cldrModificaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cldrModificaciones.SelectionChanged
        oModificaciones_permiso = New Modificacion_Permiso
        oModificaciones_permiso.usuario = Environment.UserName
        oModificaciones_permiso.dia_modificacion = cldrModificaciones.SelectedDate
        oModificaciones_permiso.bandera = 2
        If oModificaciones_permiso.valida_dia_modificacion_permiso Then
            btnModModificar.Enabled = True
        Else
            btnModModificar.Enabled = False
        End If
    End Sub
#End Region
#Region "Validaciones"
    'Generales
    Private Function valida_hora_captura(ByVal hora_actual As DateTime) As Boolean
        Dim fecha_inicio As DateTime
        Dim fecha_final As DateTime
        fecha_inicio = ini_aux
        fecha_final = fin_aux
        If fecha_inicio <= hora_actual And hora_actual <= fecha_final And ini_aux <> Nothing And fin_aux <> Nothing Then
            Return True
        ElseIf flgBanderaModificacionPermiso Then
            MsgBox("Ha finalizado el permiso de modificación de captura. Se restablecerá la pantalla de captura al día actual.", vbExclamation + vbOKOnly, "Aviso!")
            btnModTerminar.PerformClick()
            Return False
        Else
            MsgBox("Ha finalizado el turno ya no puedes capturar. Para elegir un nuevo turno y dia Da Click en la pestaña Turnos-Lineas", vbExclamation + vbOKOnly, "Aviso!")
            Return False
        End If
    End Function
    Private Sub valida_sea_numero(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempoOperacion.KeyPress, txtPiezasOkProducidas.KeyPress, txtDesechosCantidad.KeyPress, txtMinutosParo.KeyPress, txtRechazosCantidad.KeyPress, txtGenteCantidad.KeyPress, txtCondInsegCantidad.KeyPress, txtAccidenteCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Function valida_cinco_s(ByRef txtbox As TextBox) As Boolean
        Dim a As Integer() = {1, 2, 3, 4}
        Dim flgvalidacincos As Boolean = True
        If Convert.ToDouble(txtbox.Text) = Int(Convert.ToDouble(txtbox.Text)) Then

            If Convert.ToDouble(txtbox.Text) > 5 Then
                flgvalidacincos = False
            Else
                For x = 0 To a.Length - 1
                    If flgvalidacincos And a(x) = Convert.ToDouble(txtbox.Text) Then
                        flgvalidacincos = False
                    End If
                Next
            End If
            Return flgvalidacincos
        Else
            Return flgvalidacincos
        End If
    End Function
    'Productividad
    Private Sub valida_botones_productividad()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloProductividad.SelectedIndex <> -1 And txtTiempoOperacion.Text <> "" And txtPiezasOkProducidas.Text <> "" Then
            ' If Convert.ToInt64(txtTiempoOperacion.Text) <> 0 And Convert.ToInt64(txtPiezasOkProducidas.Text) <> 0 Then
            btnAgregarModelo.Enabled = True
            btnAgregarModelo.BackColor = Color.FromArgb(107, 198, 223)
            'Else
            '  btnAgregarModelo.Enabled = False
            ' End If
        Else
            btnAgregarModelo.Enabled = False
            btnAgregarModelo.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_modelo()
        limpia_productividad()
        btnQuitarModelo.Enabled = True
        btnQuitarModelo.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_modelo()
        btnQuitarModelo.Enabled = False
        btnQuitarModelo.BackColor = Color.Transparent
    End Sub
    'Rechazo
    Private Sub valida_botones_rechazos()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloRechazo.SelectedIndex <> -1 And cbxTipoRechazo.SelectedIndex <> -1 And txtRechazosCantidad.Text <> "" Then
            If Convert.ToInt64(txtRechazosCantidad.Text) <> 0 Then
                btnAgregarRechazo.Enabled = True
                btnAgregarRechazo.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarRechazo.Enabled = False
                btnAgregarRechazo.BackColor = Color.Transparent
            End If
        Else
            btnAgregarRechazo.Enabled = False
            btnAgregarRechazo.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_rechazo()
        limpia_rechazos()
        btnQuitarRechazo.Enabled = True
        btnQuitarRechazo.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_rechazo()
        btnQuitarRechazo.Enabled = False
        btnQuitarRechazo.BackColor = Color.Transparent
    End Sub
    'Desecho
    Private Sub valida_botones_desecho()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloDesecho.SelectedIndex <> -1 And txtDesechosCantidad.Text <> "" Then
            If Convert.ToInt64(txtDesechosCantidad.Text) <> 0 Then
                btnAgregarDesecho.Enabled = True
                btnAgregarDesecho.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarDesecho.Enabled = False
                btnAgregarDesecho.BackColor = Color.Transparent
            End If
        Else
            btnAgregarDesecho.Enabled = False
            btnAgregarDesecho.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_desecho()
        limpia_desechos()
        btnQuitarDesecho.Enabled = True
        btnQuitarDesecho.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_desecho()
        btnQuitarDesecho.Enabled = False
        btnQuitarDesecho.BackColor = Color.Transparent
    End Sub
    'Paro
    Private Sub valida_botones_paro()
        If cbxTurno.SelectedIndex <> -1 And cbxMaquina.SelectedIndex <> -1 And cbxTipoParo.SelectedIndex <> -1 And txtMinutosParo.Text <> "" Then
            If Convert.ToInt64(txtMinutosParo.Text) <> 0 Then
                btnAgregarParo.Enabled = True
                btnAgregarParo.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarParo.Enabled = False
                btnAgregarParo.BackColor = Color.Transparent
            End If
        Else
            btnAgregarParo.Enabled = False
            btnAgregarParo.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_paro()
        limpia_paros()
        btnQuitarParo.Enabled = True
        btnQuitarParo.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_paro()
        btnQuitarParo.Enabled = False
        btnQuitarParo.BackColor = Color.Transparent
    End Sub
    'Gente
    Private Sub valida_botones_gente()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoDetalleGente.SelectedIndex <> -1 And txtGenteCantidad.Text <> "" Then
            If Convert.ToInt64(txtGenteCantidad.Text) <> 0 Then
                btnAgregarGente.Enabled = True
                btnAgregarGente.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarGente.Enabled = False
                btnAgregarGente.BackColor = Color.Transparent
            End If
        Else
            btnAgregarGente.Enabled = False
            btnAgregarGente.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_gente()
        limpia_gente()
        btnQuitarGente.Enabled = True
        btnQuitarGente.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_gente()
        btnQuitarGente.Enabled = False
        btnQuitarGente.BackColor = Color.Transparent
    End Sub
    'Comentarios Genrales
    Private Sub valida_botones_comentarios_generales()
        If cbxTurno.SelectedIndex <> -1 And txtDetallesComentario.Text <> "" Then
            btnAgregarComentario.Enabled = True
            btnAgregarComentario.BackColor = Color.FromArgb(107, 198, 223)
        Else
            btnAgregarComentario.Enabled = False
            btnAgregarComentario.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_comentario()
        limpia_comentarios_generales()
        btnQuitarComentario.Enabled = True
        btnQuitarComentario.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_Quitar_comentario()
        btnQuitarComentario.Enabled = False
        btnQuitarComentario.BackColor = Color.Transparent
    End Sub
    'Seguridad Condiciones Inseguras
    Private Sub valida_botones_cond_inseg()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoCondInseg.SelectedIndex <> -1 And txtCondInsegCantidad.Text <> "" Then
            If Convert.ToInt64(txtCondInsegCantidad.Text) <> 0 Then
                btnAgregarCondInseg.Enabled = True
                btnAgregarCondInseg.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarCondInseg.Enabled = False
                btnAgregarCondInseg.BackColor = Color.Transparent
            End If
        Else
            btnAgregarCondInseg.Enabled = False
            btnAgregarCondInseg.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_cond_inseg()
        limpia_cond_inseg()
        btnQuitarCondInseg.Enabled = True
        btnQuitarCondInseg.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_cond_inseg()
        btnQuitarCondInseg.Enabled = False
        btnQuitarCondInseg.BackColor = Color.Transparent
    End Sub
    'Seguridad Acccidentes
    Private Sub valida_botones_accidentes()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoAccidente.SelectedIndex <> -1 And txtAccidenteCantidad.Text <> "" Then
            If Convert.ToInt64(txtAccidenteCantidad.Text) <> 0 Then
                btnAgregarAccidente.Enabled = True
                btnAgregarAccidente.BackColor = Color.FromArgb(107, 198, 223)
            Else
                btnAgregarAccidente.Enabled = False
                btnAgregarAccidente.BackColor = Color.Transparent
            End If
        Else
            btnAgregarAccidente.Enabled = False
            btnAgregarAccidente.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_Quitar_accidentes()
        limpia_accidentes()
        btnQuitarAccidente.Enabled = True
        btnQuitarAccidente.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_accidentes()
        btnQuitarAccidente.Enabled = False
        btnQuitarAccidente.BackColor = Color.Transparent
    End Sub
    'Turno - Lineas
    Private Sub valida_botones_Turno_linea()
        If cbxTurnosLineas.SelectedIndex <> -1 And grdLineasNoRegistradas.CurrentRow IsNot Nothing Then
            btnLineasTodas.Enabled = True
            btnLineaUnica.Enabled = True
        Else
            btnLineasTodas.Enabled = False
            btnLineaUnica.Enabled = False
        End If
    End Sub
    Private Sub deshabilitar_btn_Turno_linea()
        btnLineasTodas.Enabled = False
        btnLineaUnica.Enabled = False
    End Sub
    '5s
    Private Sub valida_botones_cinco_s()
        If cbxTurno.SelectedValue <> -1 And txtAdmonVisual.Text <> "" And txtManttoAutonomo.Text <> "" And txt5s.Text <> "" Then
            If Convert.ToDouble(txtAdmonVisual.Text) <> 0 And Convert.ToDouble(txtManttoAutonomo.Text) <> 0 And Convert.ToDouble(txt5s.Text) <> 0 Then
                If valida_cinco_s(txtAdmonVisual) And valida_cinco_s(txtManttoAutonomo) And valida_cinco_s(txt5s) Then
                    btnAgregarCincoS.Enabled = True
                Else
                    btnAgregarCincoS.Enabled = False
                End If

            Else
                btnAgregarCincoS.Enabled = False
            End If
        Else
            btnAgregarCincoS.Enabled = False
        End If
    End Sub
    Private Function valida_insercion_cinco_s() As Boolean
        If cbxTurno.SelectedValue <> -1 And txtAdmonVisual.Text <> "" And txtManttoAutonomo.Text <> "" And txt5s.Text <> "" Then
            If Convert.ToDouble(txtAdmonVisual.Text) <> 0 And Convert.ToDouble(txtManttoAutonomo.Text) <> 0 And Convert.ToDouble(txt5s.Text) <> 0 Then
                If valida_cinco_s(txtAdmonVisual) And valida_cinco_s(txtManttoAutonomo) And valida_cinco_s(txt5s) Then
                    Return True
                Else
                    Return False
                End If

            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'Descansos
    Private Sub valida_botones_Descansos()
        If dtpDescanso.Checked Then
            btnAgregarDescanso.Enabled = True
            btnAgregarDescanso.BackColor = Color.FromArgb(107, 198, 223)
        Else
            btnAgregarDescanso.Enabled = False
            btnAgregarDescanso.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub habilita_btn_quitar_descanso()
        limpia_descanso()
        btnQuitarDescanso.Enabled = True
        btnQuitarDescanso.BackColor = Color.FromArgb(107, 198, 223)
    End Sub
    Private Sub deshabilitar_btn_quitar_descanso()
        btnQuitarDescanso.Enabled = False
        btnQuitarDescanso.BackColor = Color.Transparent
    End Sub
#End Region
#Region "Limpia formularios"
    'Descanso Limpia todo
    Private Sub establece_dia_descanso()
        If cbxTurno.Text <> "Descanso" Then
            cbxLinea.SelectedIndex = -1
            cbxTurno.SelectedIndex = -1
        End If

        lblFechaRegistro.Visible = False
        lblFechaRegistrodescripcion.Visible = False
        grdDetalleProductividad.DataSource = Nothing
        grdDetalleDesecho.DataSource = Nothing
        grdDetalleParo.DataSource = Nothing
        grdDetalleRechazo.DataSource = Nothing
        grdDetalleCondInseg.DataSource = Nothing
        grdDetalleAccidente.DataSource = Nothing
        grdDetalleGente.DataSource = Nothing
        grdDetalleComentario.DataSource = Nothing

        grpProductividad.Enabled = False
        grpDesechos.Enabled = False
        grpParos.Enabled = False
        grpRechazos.Enabled = False
        grp5s.Enabled = False
        grpCondInseg.Enabled = False
        grpAccidentes.Enabled = False
        grpGente.Enabled = False
        grpCosto.Enabled = False
        grpComentarios.Enabled = False


        limpia_productividad()
        limpia_desechos()
        limpia_rechazos()
        limpia_paros()
        limpia_gente()
        limpia_cond_inseg()
        limpia_accidentes()
        limpia_turno_linea()
        limpia_comentarios_generales()
    End Sub
    'Dia Laboral
    Private Sub establece_dia_laboral()

        grpProductividad.Enabled = True
        grpDesechos.Enabled = True
        grpParos.Enabled = True
        grpRechazos.Enabled = True
        grp5s.Enabled = True
        grpCondInseg.Enabled = True
        grpAccidentes.Enabled = True
        grpGente.Enabled = True
        grpCosto.Enabled = True
        grpComentarios.Enabled = True

        limpia_productividad()
        limpia_desechos()
        limpia_rechazos()
        limpia_paros()
        limpia_gente()
        limpia_cond_inseg()
        limpia_accidentes()
        limpia_turno_linea()
        limpia_comentarios_generales()
    End Sub
    'Productividad
    Private Sub limpia_productividad()
        cbxModeloProductividad.SelectedIndex = -1
        txtPzasPorHora.Text = ""
        txtPiezasOkProducidas.Text = ""
        txtTiempoOperacion.Text = ""
    End Sub
    'Desechos
    Private Sub limpia_desechos()
        cbxModeloDesecho.SelectedIndex = -1
        txtDesechosCantidad.Text = ""
        txtDetalleDesecho.Text = ""
    End Sub
    'Rechazos
    Private Sub limpia_rechazos()
        cbxModeloRechazo.SelectedIndex = -1
        cbxTipoRechazo.SelectedIndex = -1
        txtModeloRechazo.Text = ""
        txtRechazosCantidad.Text = ""
        txtRechazoMotivo.Text = ""
    End Sub
    'Paros
    Private Sub limpia_paros()
        txtMinutosParo.Text = ""
        txtDetallesParo.Text = ""
        cbxMaquina.SelectedIndex = -1
        txtMaquinaDescripcion.Text = ""
        cbxTipoParo.SelectedIndex = -1
    End Sub
    'Gente
    Private Sub limpia_gente()
        cbxTipoDetalleGente.SelectedIndex = -1
        txtGenteCantidad.Text = ""
        txtDetallesGente.Text = ""
    End Sub
    'Seguridad Condiciones Inseguras
    Private Sub limpia_cond_inseg()
        cbxTipoCondInseg.SelectedIndex = -1
        txtCondInsegCantidad.Text = ""
        txtDetallesCondInseg.Text = ""
    End Sub
    'Seguridad Accidente
    Private Sub limpia_accidentes()
        cbxTipoAccidente.SelectedIndex = -1
        txtAccidenteCantidad.Text = ""
        txtDetallesAccidentes.Text = ""
    End Sub
    'Turno - Linea
    Private Sub limpia_turno_linea()
        cbxTurnosLineas.SelectedIndex = -1
    End Sub
    '5's
    Private Sub limpia_cinco_s()
        txtAdmonVisual.Text = ""
        txtManttoAutonomo.Text = ""
        txt5s.Text = ""
        txtPromedio.Text = ""
    End Sub
    'Descanso
    Private Sub limpia_descanso()
        dtpDescanso.Checked = False
        dtpDescanso.Value = obtiene_fecha_actual()
    End Sub
    'Comentarios Generales
    Private Sub limpia_comentarios_generales()
        txtDetallesComentario.Text = ""
    End Sub

#End Region
#Region "Funciones Generales"
    Private Sub define_calendario_descanso()
        'Lineas de codigo antes de modificaciones permiso
        'Dim diafinal As Date = DateSerial(Year(Now.ToString("yyyy-MM-dd")), Month(Now.ToString("yyyy-MM-dd")) + 1, 0)
        'diafinal = diafinal.AddDays(5)
        'dtpDescanso.MinDate = DateSerial(Year(Now.ToString("yyyy-MM-dd")), Month(Now.ToString("yyyy-MM-dd")), 1)
        'dtpDescanso.MaxDate = diafinal
        'Lineas de codigo antes de modificaciones permiso
        Dim diainicial As DateTime = DateSerial(obtiene_fecha_actual.Year, obtiene_fecha_actual.Month, 1)
        Dim diafinal As DateTime = DateSerial(obtiene_fecha_actual.Year, obtiene_fecha_actual.Month + 1, 0)
        diafinal = diafinal.AddDays(5)
        If diainicial >= dtpDescanso.MaxDate Then
            dtpDescanso.MaxDate = diafinal
            dtpDescanso.MinDate = diainicial
        Else
            dtpDescanso.MinDate = diainicial
            dtpDescanso.MaxDate = diafinal
        End If
    End Sub
    Private Sub get_Imagen_Equipo()
        Dim oEquipo As New Equipo
        oEquipo.Cve_Equipo = vcve_equipo
        oEquipo.Cargar()
        'imgEscudo.ImageLocation = Application.StartupPath & oEquipo.Ruta_Imagen
        Me.imgEscudo.Image = oEquipo.ByteArrayToImage(oEquipo.Imagen)
    End Sub 'Obtiene el escudo del equipo
    'Cve_RegistroTurno
    Private Function get_registro_del_turno() As Long
        Return vcve_registro_turno
    End Function
    'Valida la hora de captura segun el horario asignado
    Private Function valida_hora_de_captura(ByVal hora_actual As DateTime) As Boolean
        Dim fecha_inicio As DateTime
        Dim fecha_final As DateTime
        fecha_inicio = ini_aux
        fecha_final = fin_aux
        If hora_actual >= fecha_inicio And hora_actual <= fecha_final Then
            Return True
        ElseIf flgBanderaModificacionPermiso Then
            vLogModifPermDes = "Finalizo permiso de Modificacion - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
            " #cve: " & get_registro_del_turno()
            MsgBox("Ha finalizado el permiso de modificación de captura. Se restablecerá la pantalla de captura al día actual.", vbExclamation + vbOKOnly, "Aviso!")
            log_modificaciones_permiso(vLogModifPermDes)
            btnModTerminar.PerformClick()
            Return False
        Else
            MsgBox("Ha finalizado el turno ya no puedes capturar. Para elegir un nuevo turno y dia Da Click en la pestaña Turnos-Lineas", vbExclamation + vbOKOnly, "Aviso!")
            cbxLinea.SelectedIndex = -1
            cbxTurno.SelectedIndex = -1
            establece_dia_descanso()
            Return False
        End If
    End Function
    'Establece la hora de inicio y fin validas para capturar
    Private Sub establece_hora_inicio_fin_captura()
        ini_aux = Nothing
        fin_aux = Nothing
        If flgBanderaModificacionPermiso Then
            oModificaciones_permiso = New Modificacion_Permiso
            oModificaciones_permiso.usuario = Environment.UserName
            oModificaciones_permiso.dia_modificacion = cldrModificaciones.SelectedDate
            oModificaciones_permiso.bandera = 2
            If oModificaciones_permiso.valida_dia_modificacion_permiso Then
                oModificaciones_permiso.Cargar()
                ini_aux = oModificaciones_permiso.fecha_inicio
                fin_aux = oModificaciones_permiso.fecha_final
            Else
                btnModTerminar.PerformClick()
            End If
        Else
            Dim oTurno As New Turno
            oTurno.cve_registro_turno = vcve_registro_turno
            oTurno.valida_inicio_fin_produccion()
            ini_aux = oTurno.inicio
            fin_aux = oTurno.fin
        End If
    End Sub
    'Obtiene y muestra la fecha a la cual pertenece la captura
    Private Sub establece_label_fecha_captura()
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_registro_turno = get_registro_del_turno()
        oRegistro_turno.Cargar()
        lblFechaRegistro.Text = oRegistro_turno.dia_asignado
        lblFechaRegistro.Visible = True
        lblFechaRegistrodescripcion.Visible = True
    End Sub
    'Valida si actualmente tiene permisos para modificar y habilita el modulo de modificaciones
    Private Sub valida_dia_modificaciones()
        oModificaciones_permiso = New Modificacion_Permiso
        oModificaciones_permiso.usuario = Environment.UserName
        'bandera en 1 solo para ver si tiene permisos hoy
        oModificaciones_permiso.bandera = 1
        If oModificaciones_permiso.valida_dia_modificacion_permiso Then
            grpModificaciones.Visible = True
        End If
    End Sub
    Private Function valida_modificacion_permiso() As Boolean
        oModificaciones_permiso = New Modificacion_Permiso
        oModificaciones_permiso.usuario = Environment.UserName
        'bandera en 1 solo para ver si tiene permisos hoy con la hora y fecha actual
        oModificaciones_permiso.bandera = 1
        If oModificaciones_permiso.valida_dia_modificacion_permiso Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#Region "Funciones para modulo Productividad"
    'Metodo Enviar notificaciones de sobreproduccion
    Private Sub envia_notificacion_sobreproduccion(ByVal desempeno As Double)
        'vbCrLf 
        Dim Message As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        SMTP.Credentials = New System.Net.NetworkCredential("Sicaip.Soporte@gkndriveline.com", "Password32704")
        SMTP.Host = "GKNAUBEXH01.gkn.com"
        SMTP.Port = 25
        SMTP.EnableSsl = True
        ' CONFIGURACION DEL MENSAJE
        Message.[To].Add("madai.ortiz@gkndriveline.com") 'Cuenta de Correo al que se le quiere enviar el e-mail
        Message.From = New System.Net.Mail.MailAddress("Sicaip.Soporte@gkndriveline.com", "Soporte SICAIP", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.Subject = subject_notificacion 'Sujeto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = body_notificacion 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False
        'ENVIO
        Try
            SMTP.Send(Message)
            'MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error al enviar email!", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub get_body_notificacion(ByVal desempeno As Double)
        body_notificacion = Nothing
        body_notificacion = "Buen día." & vbCrLf & vbCrLf
        body_notificacion += "Se detectó un incremento en el Desempeño de la linea: " & cbxLinea.Text & " de " & (desempeno - 100) & "%" & vbCrLf & vbCrLf
        body_notificacion += "Detalle del incremento: " & vbCrLf & "-Modelo: " & cbxModeloProductividad.Text & " - " & txtModeloDescripcionProductividad.Text & vbCrLf & "-Piezas por hora: " & txtPzasPorHora.Text & vbCrLf
        body_notificacion += "-Pzas. Programadas: " & Convert.ToInt64(((Convert.ToDouble(txtPzasPorHora.Text) * Convert.ToDouble(txtTiempoOperacion.Text)) / 60)) & vbCrLf & "-Tiempo de Operacion: " & txtTiempoOperacion.Text & vbCrLf
        body_notificacion += "-Pzas. OK: " & txtPiezasOkProducidas.Text & vbCrLf & "-Nombre del Equipo: " & lblNombreEquipo.Text & vbCrLf & "-Nombre del Empleado: " & lblNombreEmpleado.Text & vbCrLf
        body_notificacion += "-Codigo del Empleado: " & lblCodigoEmpleado.Text & vbCrLf & "-Fecha del Registro: " & Now.ToString("dd-MM-yyyy HH:mm") & vbCrLf & vbCrLf
        body_notificacion += "Este documento es informativo para que se realice el análisis pertinente, y si es necesario hacer alguna actualización se reporta de manera oportuna con la persona correspondiente." & vbCrLf & vbCrLf
        body_notificacion += "SISTEMA SICAIP v2.0"

        subject_notificacion = "Incremento el Desempeño de la Linea " & cbxLinea.Text & " . Equipo: " & lblNombreEquipo.Text & ". Desempeño: " & (desempeno - 100)
    End Sub

    'Calcula adeudo y desecho_aplicable
    Private Sub calcula_adeudo()
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_registro_turno = get_registro_del_turno()
        oRegistro_turno.calcula_adeudo_desecho_aplicable()
    End Sub
    'Registra Productividad
    Private Sub add_productividad()
        Dim oProductividad As New Productividad
        oProductividad.cve_registro_turno = get_registro_del_turno()
        oProductividad.cod_empleado = vcodigo_empleado
        oProductividad.fecha = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oProductividad.disponibilidad = Convert.ToDouble(lblDisponibilidad.Text) / 100
        oProductividad.desempeno = Convert.ToDouble(lblDesempeno.Text) / 100
        oProductividad.calidad = Convert.ToDouble(lblCalidad.Text) / 100
        oProductividad.oee = Convert.ToDouble(lblOEE.Text) / 100
        Dim planeado As Double = get_suma_paros_planeados()
        Dim tcargasinpplaneados As Double = Convert.ToDouble(lblTiempoTurno.Text) - Convert.ToDouble(lblParosComedor.Text)
        If planeado = tcargasinpplaneados Then
            oProductividad.tipo_registro = "Z"
        ElseIf planeado <> tcargasinpplaneados Then
            oProductividad.tipo_registro = "P"
        End If
        oProductividad.Registrar()
    End Sub
    'Registra Nrfti
    Private Sub add_Nrfti()
        Dim oCalidad As New Calidad
        oCalidad.cve_registro_turno = get_registro_del_turno()
        oCalidad.cod_empleado = vcodigo_empleado
        oCalidad.fecha = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oCalidad.pzas_ok = get_suma_piezas_producidas()
        oCalidad.pzas_desecho = get_suma_desechos()
        oCalidad.nrfti = Convert.ToDouble(lblNRFTi.Text)
        oCalidad.Registrar()
    End Sub
    'Productividad
    Private Sub add_modelo_producido()
        Dim oTC As New TC
        oTC.cve_linea = cbxLinea.SelectedValue
        oTC.cve_modelo = cbxModeloProductividad.SelectedValue
        oTC.obtener_piezas_por_hora()
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = get_registro_del_turno()
        oProduccion.cod_empleado_registro = vcodigo_empleado
        oProduccion.fecha_registro = Now.ToString("dd-MM-yyyy HH:mm")
        oProduccion.cve_modelo = cbxModeloProductividad.SelectedValue
        oProduccion.cve_TC = oTC.cve_TC
        oProduccion.pzas_ok = Long.Parse(txtPiezasOkProducidas.Text)
        oProduccion.tom = Long.Parse(txtTiempoOperacion.Text)
        oProduccion.Registrar()
    End Sub
    Private Sub remove_modelo_producido()
        If grdDetalleProductividad.Rows.Count <> 0 Then
            Dim oProduccion As New Produccion
            oProduccion.cve_registro_turno = get_registro_del_turno()
            oProduccion.cve_produccion = grdDetalleProductividad.Item("cve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
            oProduccion.cod_empleado_eliminacion = vcodigo_empleado
            oProduccion.fecha_eliminacion = Now.ToString("dd-MM-yyyy HH:mm")
            oProduccion.Eliminar()
        Else
            btnQuitarModelo.Enabled = False
        End If
    End Sub
    Private Function get_suma_piezas_producidas() As Double
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleProductividad.Rows
            Total += Val(row.Cells(5).Value)
        Next
        Return Total
    End Function
    Private Function get_suma_adeudos() As Double
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_registro_turno = get_registro_del_turno()
        oRegistro_turno.Cargar()
        Return oRegistro_turno.adeudo
    End Function
    Private Function get_suma_desechos_aplicables() As Double
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_registro_turno = get_registro_del_turno()
        oRegistro_turno.Cargar()
        Return oRegistro_turno.desecho_aplicable
    End Function
    Private Function get_minutos_disponibles() As Double
        Dim mindisponibles As Integer = Convert.ToDouble(lblTiempoOperacion.Text)
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleProductividad.Rows
            Total += Val(row.Cells(6).Value)
        Next
        Return mindisponibles - Total
    End Function
    Private Function se_puede_añadir_produccion_o_paro(ByVal min As Integer) As Boolean
        If get_minutos_disponibles() = 0 Then
            MsgBox("Los minutos disponibles son insuficientes .", vbCritical + vbOKOnly, "Error")
            Return False
        ElseIf min <= get_minutos_disponibles() Then
            Return True
        Else
            MsgBox("Los minutos disponibles son insuficientes .", vbCritical + vbOKOnly, "Error")
            Return False
        End If
    End Function
    Private Function se_puede_añadir_produccion(ByVal min As Integer) As Boolean
        If get_minutos_disponibles() = 0 Then
            'MsgBox("Los minutos disponibles son insuficientes .", vbCritical + vbOKOnly, "Error")
            Return True
        ElseIf min <= get_minutos_disponibles() Then
            Return True
        Else
            MsgBox("Los minutos disponibles son insuficientes .", vbCritical + vbOKOnly, "Error")
            Return False
        End If
    End Function
    Private Sub piezas_por_hora_modelo()
        txtPzasPorHora.Text = "0"
        Dim PzasporHora As Double = 0
        If cbxModeloProductividad.SelectedIndex <> -1 And cbxLinea.SelectedIndex <> -1 And flgBanderacbxModelos And flgBanderacbxLineas Then
            Dim oTC As New TC
            oTC.cve_linea = cbxLinea.SelectedValue
            oTC.cve_modelo = cbxModeloProductividad.SelectedValue
            oTC.obtener_piezas_por_hora()
            txtPzasPorHora.Text = oTC.piezas_por_hora
        End If
    End Sub
    'Desechos
    Private Sub add_desecho()
        Dim oTC As New TC
        oTC.cve_linea = cbxLinea.SelectedValue
        oTC.cve_modelo = cbxModeloDesecho.SelectedValue
        oTC.obtener_piezas_por_hora()
        Dim oDesecho As New Desecho
        oDesecho.cve_registro_turno = get_registro_del_turno()
        oDesecho.cod_empleado_registro = vcodigo_empleado
        oDesecho.fecha_registro = Now.ToString("MM-dd-yyyy HH:mm")
        oDesecho.cve_modelo = cbxModeloDesecho.SelectedValue
        oDesecho.cve_TC = oTC.cve_TC
        oDesecho.cantidad = Long.Parse(txtDesechosCantidad.Text)
        oDesecho.comentarios = txtDetalleDesecho.Text
        oDesecho.estatus = "1"
        oDesecho.Registrar()
    End Sub
    Private Sub remove_desecho()
        If grdDetalleDesecho.Rows.Count <> 0 Then
            Dim oDesecho As New Desecho
            oDesecho.cod_empleado_eliminacion = vcodigo_empleado
            oDesecho.fecha_eliminacion = Now.ToString("MM-dd-yyyy HH:mm")
            oDesecho.cve_desecho = grdDetalleDesecho.Item("cve_desecho", grdDetalleDesecho.CurrentRow.Index).Value
            oDesecho.Eliminar()
        Else
            btnQuitarDesecho.Enabled = False
        End If

    End Sub
    Private Function get_suma_desechos() As Double
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleDesecho.Rows
            Total += Val(row.Cells(5).Value)
        Next
        Return Total
    End Function
    'Tabla Turno Minutos
    Private Sub actualiza_tabla_turno_minutos()
        If cbxTurno.SelectedIndex <> -1 And flgBanderacbxTurnos Then
            Dim oTurno As New Turno
            oTurno.cve_turno = cbxTurno.SelectedValue
            oTurno.Cargar()
            lblTiempoTurno.Text = oTurno.minutos
            lblParosComedor.Text = oTurno.comedor
            lblParosPlaneados.Text = get_suma_paros_planeados()
            lblTiempoCarga.Text = oTurno.minutos - (get_suma_paros_planeados() + oTurno.comedor)
            lblParosNoPlaneados.Text = get_suma_paros_no_planeados()
            lblTiempoOperacion.Text = Convert.ToDouble(lblTiempoCarga.Text) - get_suma_paros_no_planeados()
        End If
    End Sub
#End Region
#Region "Funciones para modulo de Paros"
    'Suma Paros planeados y no planeados
    Private Function get_suma_paros_planeados() As Double
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleParo.Rows
            If Convert.ToString(row.Cells(4).Value) = "Z" Then
                Total += Convert.ToDouble(Val(row.Cells(6).Value))
            End If
        Next
        Return Total
    End Function
    Private Function get_suma_paros_no_planeados() As Double
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleParo.Rows
            If Convert.ToString(row.Cells(4).Value).ToString <> "Z" Then
                Total += Convert.ToDouble(Val(row.Cells(6).Value))
            End If
        Next
        Return Total
    End Function
    'Paros
    Private Sub add_paro()
        Dim oParo As New Registro_Paro
        oParo.Cve_registro_turno = get_registro_del_turno()
        oParo.Cod_empleado_registro = vcodigo_empleado
        oParo.Fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oParo.Cve_paro = cbxTipoParo.SelectedValue
        oParo.Cve_maquina = cbxMaquina.SelectedValue
        oParo.Minutos = Long.Parse(txtMinutosParo.Text)
        oParo.Detalles = txtDetallesParo.Text
        oParo.Estatus = "1"
        oParo.Registrar()
    End Sub
    Private Sub remove_paro()
        If grdDetalleParo.Rows.Count <> 0 Then
            Dim oRegistro_Paro As New Registro_Paro
            oRegistro_Paro.Cve_registro_paro = grdDetalleParo.Item("cve_registro_paro", grdDetalleParo.CurrentRow.Index).Value
            oRegistro_Paro.Cod_empleado_eliminacion = vcodigo_empleado
            oRegistro_Paro.Fecha_eliminacion = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oRegistro_Paro.Eliminar()
        Else
            btnQuitarParo.Enabled = False
        End If
    End Sub
    'Costo
    Private Sub verifica_costo()
        Dim oCosto As New Costo
        oCosto.cve_registro_turno = get_registro_del_turno()
        oCosto.verifica_costo_produccion()
        lblMinProgramados.Text = oCosto.min_programados
        lblMinReal.Text = oCosto.min_reales
        lblPrecio.Text = oCosto.precio
        lblCosto.Text = oCosto.costo
    End Sub
    Private Sub add_costo()

        Dim oCosto As New Costo
        oCosto.cve_registro_turno = get_registro_del_turno()
        oCosto.cod_empleado = vcodigo_empleado
        oCosto.fecha = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oCosto.min_programados = Convert.ToInt64(lblMinProgramados.Text)
        oCosto.min_reales = Convert.ToInt64(lblMinReal.Text)
        oCosto.precio = Convert.ToDouble(lblPrecio.Text)
        oCosto.costo = Convert.ToDouble(lblCosto.Text)
        oCosto.Registrar()
    End Sub
#End Region
#Region "Funciones para modulo Rechazos"
    'Rechazo
    Private Sub add_rechazo()
        Dim oRechazo As New Rechazo
        oRechazo.cve_registro_turno = get_registro_del_turno()
        oRechazo.cod_empleado_registro = vcodigo_empleado
        oRechazo.fecha_registro = Now.ToString("dd-MM-yyyy HH:mm")
        oRechazo.cve_modelo = cbxModeloRechazo.SelectedValue
        oRechazo.cve_tipo_rechazo = cbxTipoRechazo.SelectedValue
        oRechazo.cantidad = Long.Parse(txtRechazosCantidad.Text)
        oRechazo.motivo = txtRechazoMotivo.Text
        oRechazo.Registrar()
    End Sub
    Private Sub remove_rechazo()
        If grdDetalleRechazo.Rows.Count <> 0 Then
            Dim oRechazo As New Rechazo
            oRechazo.cve_registro_turno = get_registro_del_turno()
            oRechazo.cve_rechazo = grdDetalleRechazo.Item("cve_rechazo", grdDetalleRechazo.CurrentRow.Index).Value
            oRechazo.cod_empleado_elimino = "118737"
            oRechazo.fecha_eliminacion = Now.ToString("dd-MM-yyyy HH:mm")
            oRechazo.Eliminar()
        Else
            btnQuitarRechazo.Enabled = False
        End If

    End Sub
    Private Function get_suma_rechazos() As Double
        Dim Total As Double
        For Each row As DataGridViewRow In grdDetalleRechazo.Rows
            Total += Val(row.Cells(3).Value)
        Next
        Return Total
    End Function
#End Region
#Region "Funciones para modulo de CDM"
    Private Sub activa_captura_CDM()
        obtenedor_CDM.inicializa_valores(cbxLinea.SelectedValue, cbxTurno.SelectedValue, get_minutos_disponibles(), cbxTipoParo.Text)
        obtenedor_CDM.ShowDialog()
        obtenedor_CDM.Dispose()
        If contenedor_CDM.get_if_it_was_used() Then
            If valida_hora_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                add_Paro_CDM()
                llena_paro_gridview()
                actualiza_tabla_turno_minutos()
                calcula_Productividad()
                verifica_costo()
                add_costo()
            End If
        End If
        contenedor_CDM = Nothing
        contenedor_CDM = New CDM_Class
        obtenedor_CDM = New frmCDM(contenedor_CDM)
        txtMinutosParo.Enabled = True
        txtDetallesParo.Enabled = True
        limpia_paros()

    End Sub
    Private Sub add_Paro_CDM()
        Dim cve_registro_paro As Long
        Dim oRegistro_Paro As Registro_Paro
        oRegistro_Paro = New Registro_Paro
        Dim oDetalle_CDM_total As Detalle_CDM_Total
        oDetalle_CDM_total = New Detalle_CDM_Total
        'Registro_Paro
        oRegistro_Paro.Cve_registro_turno = get_registro_del_turno()
        oRegistro_Paro.Cod_empleado_registro = vcodigo_empleado
        oRegistro_Paro.Fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oRegistro_Paro.Cve_paro = cbxTipoParo.SelectedValue
        oRegistro_Paro.Cve_maquina = cbxMaquina.SelectedValue
        oRegistro_Paro.Minutos = contenedor_CDM.minutosTotales
        oRegistro_Paro.Detalles = contenedor_CDM.comentarios(9, 0)
        'Detalle_CDM_Total
        oDetalle_CDM_total.cve_CDM = contenedor_CDM.CDM
        oDetalle_CDM_total.mejora = contenedor_CDM.mejora
        oDetalle_CDM_total.costo = contenedor_CDM.costo
        oDetalle_CDM_total.fecha_inicial = Convert.ToDateTime(contenedor_CDM.fecha_inicio)
        oDetalle_CDM_total.fecha_final = Convert.ToDateTime(contenedor_CDM.fecha_final)
        oRegistro_Paro.captura_CDM(oDetalle_CDM_total)
        cve_registro_paro = oRegistro_Paro.Cve_registro_paro
        oRegistro_Paro = Nothing

        Dim i As Integer
        For i = 0 To contenedor_CDM.paros_detalle.GetUpperBound(0)
            If contenedor_CDM.paros_detalle(i, 0) <> Nothing Then
                oRegistro_Paro = New Registro_Paro
                oRegistro_Paro.Cve_registro_paro = cve_registro_paro
                oRegistro_Paro.Cve_registro_turno = get_registro_del_turno()
                oRegistro_Paro.Cod_empleado_registro = vcodigo_empleado
                oRegistro_Paro.Fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
                oRegistro_Paro.cod_paro = contenedor_CDM.paros_detalle(i, 0)
                oRegistro_Paro.Cve_maquina = cbxMaquina.SelectedValue
                oRegistro_Paro.Minutos = contenedor_CDM.paros_detalle(i, 1)
                oRegistro_Paro.Detalles = contenedor_CDM.comentarios(i, 0)
                oRegistro_Paro.captura_detalle_CDM()
                oRegistro_Paro = Nothing
            End If
        Next
    End Sub
#End Region
#Region "Funciones para modulo de Gente"
    Private Sub add_gente()
        Dim oGente As New Gente
        oGente.cve_registro_turno = get_registro_del_turno()
        oGente.cod_empleado_registro = vcodigo_empleado
        oGente.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oGente.cve_detalle_gente = cbxTipoDetalleGente.SelectedValue
        oGente.cantidad = Long.Parse(txtGenteCantidad.Text)
        oGente.comentarios = txtDetallesGente.Text
        oGente.estatus = "1"
        oGente.Registrar()
    End Sub
    Private Sub remove_gente()
        If grdDetalleGente.Rows.Count <> 0 Then
            Dim oGente As New Gente
            oGente.cod_empleado_eliminacion = vcodigo_empleado
            oGente.fecha_eliminacion = Now.ToString("dd-MM-yyyy HH:mm")
            oGente.cve_gente = grdDetalleGente.Item("cve_gente", grdDetalleGente.CurrentRow.Index).Value
            oGente.Eliminar()
        Else
            btnQuitarGente.Enabled = False
        End If
    End Sub
#End Region
#Region "Funciones para modulo Seguridad"
    Private Sub add_cond_inseg()
        Dim oSeguridad As New Seguridad
        oSeguridad.cve_registro_turno = get_registro_del_turno()
        oSeguridad.cod_empleado_registro = vcodigo_empleado
        oSeguridad.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oSeguridad.cve_detalle_seguridad = cbxTipoCondInseg.SelectedValue
        oSeguridad.cantidad = Long.Parse(txtCondInsegCantidad.Text)
        oSeguridad.comentarios = txtDetallesCondInseg.Text
        oSeguridad.estatus = "1"
        oSeguridad.Registrar()
    End Sub
    Private Sub remove_cond_inseg()
        If grdDetalleCondInseg.Rows.Count <> 0 Then
            Dim oSeguridad As New Seguridad
            oSeguridad.cod_empleado_eliminacion = vcodigo_empleado
            oSeguridad.fecha_eliminacion = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oSeguridad.cve_seguridad = grdDetalleCondInseg.Item("cve_seguridad", grdDetalleCondInseg.CurrentRow.Index).Value
            oSeguridad.Eliminar()
        Else
            btnQuitarCondInseg.Enabled = False
        End If
    End Sub
    Private Sub add_accidentes()
        Dim oSeguridad As New Seguridad
        oSeguridad.cve_registro_turno = get_registro_del_turno()
        oSeguridad.cod_empleado_registro = vcodigo_empleado
        oSeguridad.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oSeguridad.cve_detalle_seguridad = cbxTipoAccidente.SelectedValue
        oSeguridad.cantidad = Long.Parse(txtAccidenteCantidad.Text)
        oSeguridad.comentarios = txtDetallesAccidentes.Text
        oSeguridad.estatus = "1"
        oSeguridad.Registrar()
    End Sub
    Private Sub remove_accidentes()
        If grdDetalleAccidente.Rows.Count <> 0 Then
            Dim oSeguridad As New Seguridad
            oSeguridad.cod_empleado_eliminacion = vcodigo_empleado
            oSeguridad.fecha_eliminacion = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oSeguridad.cve_seguridad = grdDetalleAccidente.Item("cve_seguridadd", grdDetalleAccidente.CurrentRow.Index).Value
            oSeguridad.Eliminar()
        Else
            btnQuitarAccidente.Enabled = False
        End If
    End Sub
    Private Function acumulado_dia_anterior() As Integer
        Dim AdA As Integer
        Dim oSeguridad As New Seguridad
        AdA = oSeguridad.obtener_acum_dia_anterior(Date.Now.ToString("dd-MM-yyyy"), vcve_equipo, vCve_Linea_CBX)
        Return AdA
    End Function
    Private Function obtener_nuevas_hoy()
        Dim oSeguridad As New Seguridad
        Dim nuevas As Integer
        nuevas = oSeguridad.obtener_nuevas_seguridad(vcve_equipo, vCve_Linea_CBX, Date.Now.ToString("dd-MM-yyyy"))
        Return nuevas
    End Function
    Private Function obtener_resueltas_hoy()
        Dim oSeguridad As New Seguridad
        Dim resueltas As Integer
        resueltas = oSeguridad.obtener_resueltas_seguridad(vcve_equipo, vCve_Linea_CBX, Date.Now.ToString("dd-MM-yyyy"))
        Return resueltas
    End Function
#End Region
#Region "Funciones para modulo Turnos-Lineas"
    'Registra todas las Lineas
    Private Sub registra_todas_lineas()
        Dim line_aux As Long
        If cbxTurnosLineas.Text <> "Descanso" Then
            ofrmMensaje_Turno = New msg_Dialogo
            ofrmMensaje_Turno.vEntrada = "Turno: " & cbxTurnosLineas.Text & " --- Lineas: Todas"
            ofrmMensaje_Turno.ShowDialog()

            If ofrmMensaje_Turno.vRespuesta = True Then
                If valida_registro_linea() Then
                    If flgBanderaModificacionPermiso Then
                        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                            For Each row As DataGridViewRow In grdLineasNoRegistradas.Rows
                                line_aux = Val(row.Cells(0).Value)
                                If verifica_registro_turno(line_aux, obten_dia_asignado_registro_turno()) Then
                                    Registra_Turno_Linea(line_aux)
                                End If
                                line_aux = Nothing
                            Next
                            vLogModifPermDes = "Registro turno todas las lineas - Equipo: " & vnombre_equipo &
                                " - Turno: " & cbxTurnosLineas.Text & "-(" & cbxTurnosLineas.SelectedValue & ")" &
                                " #cve: " & get_registro_del_turno()
                            log_modificaciones_permiso(vLogModifPermDes)
                        End If
                    Else
                        For Each row As DataGridViewRow In grdLineasNoRegistradas.Rows
                            line_aux = Val(row.Cells(0).Value)
                            If verifica_registro_turno(line_aux, obten_dia_asignado_registro_turno()) Then
                                Registra_Turno_Linea(line_aux)
                            End If
                            line_aux = Nothing
                        Next
                    End If
                    limpia_turno_linea()
                    deshabilitar_btn_Turno_linea()
                    llena_lineas_Si_gridview()
                End If
            End If
            'If MsgBox("¿Estas seguro que el horario para las lineas (todas/restantes) es: " & cbxTurnosLineas.Text & "?. Una vez registrado el horario ya no lo podrás modificar.", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
            '    If valida_registro_linea() Then
            '        For Each row As DataGridViewRow In grdLineasNoRegistradas.Rows
            '            line_aux = Val(row.Cells(0).Value)
            '            If verifica_registro_turno(line_aux, obten_dia_asignado_registro_turno()) Then
            '                Registra_Turno_Linea(line_aux)
            '            End If

            '            line_aux = Nothing
            '        Next
            '        limpia_turno_linea()
            '        deshabilitar_btn_Turno_linea()
            '        llena_lineas_Si_gridview()
            '    End If
            'End If
        Else
            MsgBox("Para Registrar todas lineas con descanso dirijase a la pestaña 'Descansos' ", vbCritical + vbOKOnly, "Error")
            limpia_turno_linea()
            deshabilitar_btn_Turno_linea()
        End If

    End Sub
    'Registra una Linea
    Private Sub registra_linea()
        Dim line_aux As Long = grdLineasNoRegistradas.Item("cve_linea", grdLineasNoRegistradas.CurrentRow.Index).Value
        Dim nom_aux As String = grdLineasNoRegistradas.Item("linea", grdLineasNoRegistradas.CurrentRow.Index).Value
        If valida_registro_linea() Then
            If verifica_registro_turno(line_aux, obten_dia_asignado_registro_turno()) Then
                ofrmMensaje_Turno = New msg_Dialogo
                ofrmMensaje_Turno.vEntrada = "Turno: " & cbxTurnosLineas.Text & " --- Linea: " & nom_aux
                ofrmMensaje_Turno.ShowDialog()

                If ofrmMensaje_Turno.vRespuesta = True Then
                    'MsgBox("Registro exitoso", vbOKOnly, "Aviso")
                    If flgBanderaModificacionPermiso Then
                        If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                            vLogModifPermDes = "Registro turno - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                                " - Linea: " & grdLineasNoRegistradas.Item(1, grdLineasNoRegistradas.CurrentRow.Index).Value &
                                "-(" & grdLineasNoRegistradas.Item(0, grdLineasNoRegistradas.CurrentRow.Index).Value & ")" &
                                " - Turno: " & cbxTurnosLineas.Text & "-(" & cbxTurnosLineas.SelectedValue & ")" &
                                " #cve: " & get_registro_del_turno()
                            Registra_Turno_Linea(line_aux)
                            log_modificaciones_permiso(vLogModifPermDes)
                        End If
                    Else
                        Registra_Turno_Linea(line_aux)
                    End If
                    limpia_turno_linea()
                    deshabilitar_btn_Turno_linea()
                    llena_lineas_Si_gridview()
                End If

                'If MsgBox("¿Estas seguro que el horario para la linea: " & nom_aux & " es " & cbxTurnosLineas.Text & "?. Una vez registrado ya no lo podrás modificar.", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
                '    'MsgBox("Registro exitoso", vbOKOnly, "Aviso")
                '    Registra_Turno_Linea(line_aux)
                '    limpia_turno_linea()
                '    deshabilitar_btn_Turno_linea()
                '    llena_lineas_Si_gridview()
                'End If
            Else
                limpia_turno_linea()
                MsgBox("Esta Linea ya ha sido registrada.", vbExclamation, "Error")

            End If
        End If
    End Sub
    '1 Verifica la hora de registro
    Private Function valida_registro_linea() As Boolean
        Dim oTurno As New Turno
        oTurno.cve_turno = cbxTurnosLineas.SelectedValue
        'oTurno.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm")) Modificaciones Permiso
        oTurno.fecha_registro = obtiene_fecha_actual.ToString("dd-MM-yyyy HH:mm")
        oTurno.valida_inicio_fin()
        If oTurno.bandera_registro = 1 Then
            Return True
        Else
            MsgBox("Error! No puedes registrar linea antes del inicio o despues final del turno", vbCritical + vbOKOnly, "Error")
            limpia_turno_linea()
            deshabilitar_btn_Turno_linea()
            Return False
        End If
    End Function
    '2 Verifica si hay ya registro
    Private Function verifica_registro_turno(ByVal line As Long, ByVal dateinicio As Date) As Boolean
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_equipo = vcve_equipo
        oRegistro_turno.cve_linea = line
        oRegistro_turno.dia_asignado = dateinicio
        oRegistro_turno.verifica_registro_turno()
        If oRegistro_turno.bandera_registro_turno = 0 Then
            Return True
        Else
            vcve_registro_turno = oRegistro_turno.cve_registro_turno
            vcve_turno = oRegistro_turno.cve_turno
            Return False
        End If
    End Function
    '3Dia Asignado solo requiere el cbx de Turno
    Private Function obten_dia_asignado_registro_turno() As Date
        Dim oTurno As New Turno
        oTurno.cve_turno = cbxTurnosLineas.SelectedValue
        'oTurno.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oTurno.fecha_registro = obtiene_fecha_actual.ToString("dd-MM-yyyy HH:mm")
        oTurno.valida_inicio_fin()
        ' MsgBox(oTurno.inicio)
        Return oTurno.inicio
    End Function
    '4 Registra 1 Linea Metodo
    Private Sub Registra_Turno_Linea(ByVal line As Long)
        Dim oRegistro_Turno As New Registro_Turno
        oRegistro_Turno.cve_equipo = vcve_equipo
        oRegistro_Turno.cve_linea = line
        oRegistro_Turno.cve_turno = cbxTurnosLineas.SelectedValue
        oRegistro_Turno.dia_asignado = obten_dia_asignado_registro_turno()
        oRegistro_Turno.Registrar()
    End Sub
    'para produccion
    Private Function verifica_registro_turno_produccion(ByVal line As Long, ByVal dateinicio As Date) As Boolean
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_equipo = vcve_equipo
        oRegistro_turno.cve_linea = line
        oRegistro_turno.dia_asignado = dateinicio
        oRegistro_turno.verifica_registro_turno_produccion()
        If oRegistro_turno.bandera_registro_turno = 0 Then
            Return True
        Else
            vcve_registro_turno = oRegistro_turno.cve_registro_turno
            vcve_turno = oRegistro_turno.cve_turno
            Return False
        End If
    End Function
#End Region
#Region "Funciones para modulo 5S"
    Private Sub calcula_promedio_cinco_S()
        Dim num As Double = 0
        Dim suma As Double = 0
        Dim multi As Double = Math.Pow(10D, 1.0)
        Dim resultado As Double = 0
        If txtAdmonVisual.Text <> Nothing And txt5s.Text <> Nothing And txtManttoAutonomo.Text <> Nothing Then
            num = ((Convert.ToDouble(txtAdmonVisual.Text) + Convert.ToDouble(txtManttoAutonomo.Text) + Convert.ToDouble(txt5s.Text)) / 3)
            resultado = (Int(((num * multi)))) / multi 'Soluciono el problema de solo tomar 1 decimal sin redonder y truncar
            txtPromedio.Text = resultado
        Else
            txtPromedio.Text = "0.0"
        End If
    End Sub
    Private Sub add_cinco_s()
        Dim oCinco_S As New Cinco_S
        oCinco_S.cve_registro_turno = get_registro_del_turno()
        oCinco_S.cod_empleado = vcodigo_empleado
        oCinco_S.fecha = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oCinco_S.mantto_autto = Convert.ToDouble(txtManttoAutonomo.Text)
        oCinco_S.admon_visual = Convert.ToDouble(txtAdmonVisual.Text)
        oCinco_S.cincoS = Convert.ToDouble(txt5s.Text)
        oCinco_S.promedio = Convert.ToDouble(txtPromedio.Text)
        oCinco_S.Registrar()
    End Sub
    Private Sub valida_numero_cinco_s(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtManttoAutonomo.KeyPress, txtAdmonVisual.KeyPress, txt5s.KeyPress
        Dim cajatexto As TextBox
        cajatexto = sender
        Dim esDec As Boolean
        If Char.IsNumber(e.KeyChar) Then
            'asfdasdf
            ' e.Handled = False
            Dim a, esDecimal, NumDecimales As Integer
            Dim dig As Integer = Len(cajatexto.Text & e.KeyChar)
            For a = 0 To dig - 1
                Dim car As String = CStr(cajatexto.Text & e.KeyChar)
                If car.Substring(a, 1) = "." And esDec <> True Then
                    esDecimal = esDecimal + 1
                    esDec = True
                ElseIf esDec Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales
            Next
            If NumDecimales > 1 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
            'asdfsdf
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf UCase(e.KeyChar) Like "[.]" Then
            If InStr(sender.Text, ".") > 0 Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If


    End Sub
#End Region
#Region "Funciones para modulo Descanso"
    Private Sub registra_descanso()
        If valida_captura_descanso() Then
            'ofrmMensaje_Descanso_Equipo = New msg_Dialogo_Descanso_All_Lineas
            'ofrmMensaje_Descanso_Equipo.vEntrada = dtpDescanso.Value.Day & "/" & dtpDescanso.Value.Month & "/" & dtpDescanso.Value.Year
            'ofrmMensaje_Descanso_Equipo.ShowDialog()

            'If ofrmMensaje_Descanso_Equipo.vRespuesta = True Then
            '    add_descanso()
            '    llena_Descanso_gridview()
            '    llena_lineas_Si_gridview()
            'End If
            If MsgBox("¿Seguro que desea guardar dia descanso?", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
                If flgBanderaModificacionPermiso Then
                    If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                        vLogModifPermDes = "Registro Descanso de todas las lineas - Equipo: " & vnombre_equipo &
                   " - Dia: " & dtpDescanso.Value &
                   " #cve: " & get_registro_del_turno()
                        add_descanso()
                        log_modificaciones_permiso(vLogModifPermDes)
                    End If
                Else
                    add_descanso()
                End If
                llena_Descanso_gridview()
                llena_lineas_Si_gridview()
            End If
        End If
    End Sub
    Private Sub add_descanso()
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_equipo = vcve_equipo
        oRegistro_turno.dia_asignado = dtpDescanso.Value
        oRegistro_turno.registra_dia_descanso()
    End Sub
    Private Sub remove_descanso()
        If grdDetalleDescansos.Rows.Count <> 0 Then
            If MsgBox("¿Seguro que desea guardar dia descanso?", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
                Dim oRegistro_Turno As New Registro_Turno
                oRegistro_Turno.cve_equipo = vcve_equipo
                oRegistro_Turno.dia_asignado = Convert.ToDateTime(grdDetalleDescansos.Item(0, grdDetalleDescansos.CurrentRow.Index).Value)
                If flgBanderaModificacionPermiso Then
                    If valida_hora_de_captura(Now.ToString("dd-MM-yyyy HH:mm:ss")) Then
                        vLogModifPermDes = "Elimino Descanso de todas las lineas - Equipo: " & vnombre_equipo & " Linea: " & cbxLinea.Text &
                   " Dia: " & grdDetalleDescansos.Item("dia_asignado", grdDetalleDescansos.CurrentRow.Index).Value &
                   " #cve: " & get_registro_del_turno()
                        oRegistro_Turno.borra_dia_descanso()
                        log_modificaciones_permiso(vLogModifPermDes)
                    End If
                Else
                    oRegistro_Turno.borra_dia_descanso()
                End If
            End If
        Else
            btnQuitarDescanso.Enabled = False
        End If
    End Sub
    Private Function valida_captura_descanso() As Boolean
        Dim oRegistro_turno As New Registro_Turno
        oRegistro_turno.cve_equipo = vcve_equipo
        oRegistro_turno.dia_asignado = dtpDescanso.Value
        oRegistro_turno.valida_dia_descanso()
        If oRegistro_turno.bandera_registro_turno = 0 Then
            Return True
        Else
            MsgBox("No se puede Capturar Descanso ya ha sido registrado o alguna de sus lineas ha sido registrada con produccion", vbCritical + vbOKOnly, "Error")
            Return False
        End If
    End Function
#End Region
#Region "Funciones para modulo Comentarios Generales"
    Private Sub add_comentario()
        Dim oComentariosGenerales As New Comentarios_Generales
        oComentariosGenerales.cve_registro_turno = get_registro_del_turno()
        oComentariosGenerales.cod_empleado_registro = vcodigo_empleado
        oComentariosGenerales.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oComentariosGenerales.comentarios = txtDetallesComentario.Text
        oComentariosGenerales.Registrar()
    End Sub
    Private Sub remove_comentario()
        If grdDetalleComentario.Rows.Count <> 0 Then
            Dim oComentariosGenerales As New Comentarios_Generales
            oComentariosGenerales.cod_empleado_eliminacion = vcodigo_empleado
            oComentariosGenerales.fecha_eliminacion = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oComentariosGenerales.cve_comentarios_generales = grdDetalleComentario.Item("cve_comentarios_generales", grdDetalleComentario.CurrentRow.Index).Value
            oComentariosGenerales.Eliminar()
        Else
            btnQuitarCondInseg.Enabled = False
        End If
    End Sub

#End Region
#Region "Funciones para módulo GRÁFICAS "
    Private Sub AbrirGraficos()
        Dim GFU As New FrmGraficasfaseuno
        GFU.inicializa_formulario(vcodigo_empleado, vcve_equipo)
        GFU.ShowDialog()
        GFU.Dispose()
        'frmGraficas.Set_IdEquipo(vcve_equipo)
        'frmGraficas.ShowDialog()
        'frmGraficas.Dispose()
    End Sub
#End Region
#Region "Funciones para modulo de Modificaciones"
    Private Function obtiene_fecha_actual() As DateTime
        Dim cldrHora As DateTime
        If flgBanderaModificacionPermiso = True Then
            cldrHora = cldrModificaciones.SelectedDate
            cldrHora = cldrHora.AddHours(23)
            cldrHora = cldrHora.AddMinutes(59)
            Return cldrHora
        ElseIf flgBanderaModificacionPermiso = False Then
            Return Convert.ToDateTime(Now)
        Else
            Return Convert.ToDateTime(Now)
        End If
    End Function
    Private Sub log_modificaciones_permiso(ByVal descripcion As String)
        If flgBanderaModificacionPermiso = True Then
            oModificaciones_permiso_log = New Modificacion_Permiso_Log
            oModificaciones_permiso_log.cve_registro_turno = get_registro_del_turno()
            oModificaciones_permiso_log.maquina = My.Computer.Name
            oModificaciones_permiso_log.maquina_usuario = Environment.UserName
            oModificaciones_permiso_log.cod_empleado = vcodigo_empleado
            oModificaciones_permiso_log.fecha_captura = Now.ToString("dd-MM-yyyy HH:mm:ss")
            oModificaciones_permiso_log.descripcion = descripcion
            oModificaciones_permiso_log.registra_modificacion_permiso_log()
            vLogModifPermDes = ""
        End If
    End Sub
    Private Sub accion_btnTerminar()
        flgBanderaModificacionPermiso = False
        btnModTerminar.Enabled = False
        btnModModificar.Enabled = True
        cldrModificaciones.Enabled = True
        cldrModificaciones.SelectedDate = Now
        'cbxLinea.SelectedIndex = -1
        'cbxTurno.SelectedIndex = -1
        'establece_dia_descanso()
        inicializa_formulario()
    End Sub
#End Region
End Class
