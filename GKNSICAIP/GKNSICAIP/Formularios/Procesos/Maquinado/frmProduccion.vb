Imports CapaNegocios
Public Class frmProduccion
#Region "Atributos"
    'Globales
    Private vcve_equipo As Integer
    Private vnombre_equipo As String
    Private vnombre_empleado As String
    Private vcodigo_empleado As String
    'Temporal de desarrollo
    Private vcve_registro_turno As Integer = 1
    'Banderas
    Private flgBanderacbxLineas As Boolean = False
    Private flgBanderacbxModelos As Boolean = False
    Private flgBanderacbxTurnos As Boolean = False
    Private flgBanderacbxMaquinas As Boolean = False
    Private flgBanderacbxParos As Boolean = False
    'CDM
    Private contenedor_CDM As CDM_Class
    Private obtenedor_CDM As frmCDM
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
        For Each row As DataGridViewRow In grdDetalleProductividad.Rows
            oTC.cve_linea = Val(row.Cells(1).Value)
            oTC.cve_modelo = Val(row.Cells(2).Value)
            produccion_d += (oTC.obtener_tiempo_ciclo() * Val(row.Cells(5).Value))
        Next
        For Each row As DataGridViewRow In grdDetalleDesecho.Rows
            oTC.cve_linea = Val(row.Cells(1).Value)
            oTC.cve_modelo = Val(row.Cells(2).Value)
            desechos_d += (oTC.obtener_tiempo_ciclo() * Val(row.Cells(5).Value))
        Next
        desempeno = ((produccion_d + desechos_d) / tiempo_operacion) * 100
        If tiempo_operacion <> 0 Then
            If desempeno <= 100 And desempeno >= 0 Then
                lblDesempeno.Text = Format(desempeno, "##0.00")
            ElseIf desempeno < 0 Then
                lblDesempeno.Text = "0.00"
            Else
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
            Dim resultado As Double = (((get_suma_piezas_producidas() - (get_suma_rechazos() + get_suma_adeudos())) / varvalida) * 100)
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
#End Region
#Region "Inicializando formulario"
    'Load
    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa_formulario()
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
        set_Datos_Equipo(4, "Tlatoanis", "Oscar Mtz S", "118737")
        'General
        llena_cbx_Turnos()
        llena_cbx_Lineas()
        llena_cbx_Modelos()
        'Productividad
        llena_productividad_gridview()
        llena_desecho_gridview()
        'Rechazos
        llena_cbx_tipo_rechazos()
        llena_rechazo_gridview()
        'Paros
        llena_cbx_Maquinas()
        llena_cbx_Paros()
        llena_paro_gridview()
        'CDM
        contenedor_CDM = New CDM_Class
        contenedor_CDM.set_not_used()
        obtenedor_CDM = New frmCDM(contenedor_CDM)
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
    End Sub
#End Region
#Region "LLenado ComboBoxs"
    'Turnos
    Private Sub llena_cbx_Turnos()
        Dim oTurnos As New CapaNegocios.Turno
        cbxTurno.ValueMember = "cve_turno"
        cbxTurno.DisplayMember = "turno"
        cbxTurno.DataSource = oTurnos.llena_combo_turnos
        'cbxTurno.SelectedIndex = -1
        flgBanderacbxTurnos = True
    End Sub
    'Lineas
    Private Sub llena_cbx_Lineas()
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas
        'cbxLinea.SelectedIndex = -1
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

            cbxModeloDesecho.ValueMember = "cve_modelo"
            cbxModeloDesecho.DisplayMember = "np_gkn"
            cbxModeloDesecho.DataSource = oModelo.llena_combo_Modelos_Linea()
            cbxModeloDesecho.SelectedIndex = -1


            cbxModeloRechazo.ValueMember = "cve_modelo"
            cbxModeloRechazo.DisplayMember = "np_gkn"
            cbxModeloRechazo.DataSource = oModelo.llena_combo_Modelos_Linea()
            cbxModeloRechazo.SelectedIndex = -1



            flgBanderacbxModelos = True
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
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = 1
        grdDetalleProductividad.DataSource = oProduccion.llena_productividad_gridview()
    End Sub
    'Desechos
    Private Sub llena_desecho_gridview()
        Dim oDesecho As New Desecho
        oDesecho.cve_registro_turno = 1
        grdDetalleDesecho.DataSource = oDesecho.llena_desecho_gridview()
    End Sub
    'Rechazos
    Private Sub llena_rechazo_gridview()
        Dim oRechazo As New Rechazo
        oRechazo.cve_registro_turno = 1
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
#End Region
#Region "Eventos ComboBox"
    'General
    Private Sub cbxTurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTurno.SelectedIndexChanged
        actualiza_tabla_turno_minutos()
    End Sub
    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        llena_cbx_Modelos()
        llena_cbx_Maquinas()
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
#End Region
#Region "Eventos Botones"
    'Productividad
    Private Sub btnAgregarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarModelo.Click
        add_modelo_producido()
        limpia_productividad()
        llena_productividad_gridview()
        calcula_Productividad()
    End Sub
    Private Sub btnQuitarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarModelo.Click
        remove_modelo_producido()
        llena_productividad_gridview()
        deshabilitar_btn_quitar_modelo()
    End Sub
    'Desechos
    Private Sub btnAgregarDesecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDesecho.Click
        add_desecho()
        limpia_desechos()
        llena_desecho_gridview()
    End Sub
    Private Sub btnQuitarDesecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDesecho.Click
        remove_desecho()
        llena_desecho_gridview()
        deshabilitar_btn_quitar_desecho()
    End Sub
    'Rechazos
    Private Sub btnAgregarRechazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRechazo.Click
        add_rechazo()
        limpia_rechazos()
        llena_rechazo_gridview()
        llena_productividad_gridview()
    End Sub
    Private Sub btnQuitarRechazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarRechazo.Click
        remove_rechazo()
        llena_rechazo_gridview()
        deshabilitar_btn_quitar_rechazo()
        llena_productividad_gridview()
    End Sub
    'Paros
    Private Sub btnAgregarParo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarParo.Click
        add_paro()
        limpia_paros()
        llena_paro_gridview()
        actualiza_tabla_turno_minutos()
        calcula_Productividad()
    End Sub
    Private Sub btnQuitarParo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarParo.Click
        remove_paro()
        limpia_paros()
        deshabilitar_btn_quitar_paro()
        llena_paro_gridview()
        actualiza_tabla_turno_minutos()
        calcula_Productividad()
    End Sub
    'Gente
    Private Sub btnAgregarGente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGente.Click
        add_gente()
        limpia_gente()
        llena_gente_gridview()
    End Sub
    Private Sub btnQuitarGente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGente.Click
        remove_gente()
        limpia_gente()
        deshabilitar_btn_quitar_gente()
        llena_gente_gridview()
    End Sub
    'Seguridad Condiciones Inseguras
    Private Sub btnAgregarCondInseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCondInseg.Click
        add_cond_inseg()
        limpia_cond_inseg()
        llena_cond_inseg_gridview()
    End Sub
    Private Sub btnQuitarCondInseg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCondInseg.Click
        remove_cond_inseg()
        limpia_cond_inseg()
        deshabilitar_btn_quitar_cond_inseg()
        llena_cond_inseg_gridview()
    End Sub
    'Seguridad Accidentes
    Private Sub btnAgregarAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAccidente.Click
        add_accidentes()
        limpia_accidentes()
        llena_accidentes_gridview()
    End Sub
    Private Sub btnQuitarAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarAccidente.Click
        remove_accidentes()
        limpia_accidentes()
        deshabilitar_btn_quitar_accidentes()
        llena_accidentes_gridview()
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
#End Region
#Region "Validaciones"
    'Generales
    Private Sub valida_sea_numero(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTiempoOperacion.KeyPress, txtPiezasOkProducidas.KeyPress, txtDesechosCantidad.KeyPress, txtMinutosParo.KeyPress, txtRechazosCantidad.KeyPress, txtGenteCantidad.KeyPress, txtCondInsegCantidad.KeyPress, txtAccidenteCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'Productividad
    Private Sub valida_botones_productividad()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloProductividad.SelectedIndex <> -1 And txtTiempoOperacion.Text <> "" And txtPiezasOkProducidas.Text <> "" Then
            If Convert.ToInt64(txtTiempoOperacion.Text) <> 0 And Convert.ToInt64(txtPiezasOkProducidas.Text) <> 0 Then
                btnAgregarModelo.Enabled = True
            Else
                btnAgregarModelo.Enabled = False
            End If
        Else
            btnAgregarModelo.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_modelo()
        limpia_productividad()
        btnQuitarModelo.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_modelo()
        btnQuitarModelo.Enabled = False
    End Sub
    'Rechazo
    Private Sub valida_botones_rechazos()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloRechazo.SelectedIndex <> -1 And cbxTipoRechazo.SelectedIndex <> -1 And txtRechazosCantidad.Text <> "" Then
            If Convert.ToInt64(txtRechazosCantidad.Text) <> 0 Then
                btnAgregarRechazo.Enabled = True
            Else
                btnAgregarRechazo.Enabled = False
            End If
        Else
            btnAgregarRechazo.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_rechazo()
        limpia_rechazos()
        btnQuitarRechazo.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_rechazo()
        btnQuitarRechazo.Enabled = False
    End Sub
    'Desecho
    Private Sub valida_botones_desecho()
        If cbxTurno.SelectedIndex <> -1 And cbxModeloDesecho.SelectedIndex <> -1 And txtDesechosCantidad.Text <> "" Then
            If Convert.ToInt64(txtDesechosCantidad.Text) <> 0 Then
                    btnAgregarDesecho.Enabled = True
            Else
                btnAgregarDesecho.Enabled = False
            End If
        Else
            btnAgregarDesecho.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_desecho()
        limpia_desechos()
        btnQuitarDesecho.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_desecho()
        btnQuitarDesecho.Enabled = False
    End Sub
    'Paro
    Private Sub valida_botones_paro()
        If cbxTurno.SelectedIndex <> -1 And cbxMaquina.SelectedIndex <> -1 And cbxTipoParo.SelectedIndex <> -1 And txtMinutosParo.Text <> "" Then
            If Convert.ToInt64(txtMinutosParo.Text) <> 0 Then
                btnAgregarParo.Enabled = True
            Else
                btnAgregarParo.Enabled = False
            End If
        Else
            btnAgregarParo.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_paro()
        limpia_paros()
        btnQuitarParo.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_paro()
        btnQuitarParo.Enabled = False
    End Sub
    'Gente
    Private Sub valida_botones_gente()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoDetalleGente.SelectedIndex <> -1 And txtGenteCantidad.Text <> "" Then
            If Convert.ToInt64(txtGenteCantidad.Text) <> 0 Then
                btnAgregarGente.Enabled = True
            Else
                btnAgregarGente.Enabled = False
            End If
        Else
            btnAgregarGente.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_gente()
        limpia_gente()
        btnQuitarGente.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_gente()
        btnQuitarGente.Enabled = False
    End Sub
    'Seguridad Condiciones Inseguras
    Private Sub valida_botones_cond_inseg()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoCondInseg.SelectedIndex <> -1 And txtCondInsegCantidad.Text <> "" Then
            If Convert.ToInt64(txtCondInsegCantidad.Text) <> 0 Then
                btnAgregarCondInseg.Enabled = True
            Else
                btnAgregarCondInseg.Enabled = False
            End If
        Else
            btnAgregarCondInseg.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_cond_inseg()
        limpia_cond_inseg()
        btnQuitarCondInseg.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_cond_inseg()
        btnQuitarCondInseg.Enabled = False
    End Sub
    'Seguridad Acccidentes
    Private Sub valida_botones_accidentes()
        If cbxTurno.SelectedIndex <> -1 And cbxTipoAccidente.SelectedIndex <> -1 And txtAccidenteCantidad.Text <> "" Then
            If Convert.ToInt64(txtAccidenteCantidad.Text) <> 0 Then
                btnAgregarAccidente.Enabled = True
            Else
                btnAgregarAccidente.Enabled = False
            End If
        Else
            btnAgregarAccidente.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_accidentes()
        limpia_accidentes()
        btnQuitarAccidente.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_accidentes()
        btnQuitarAccidente.Enabled = False
    End Sub
#End Region
#Region "Limpia formularios"
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
#End Region
#Region "Funciones Generales"
    Private Function get_registro_del_turno() As Long
        Return vcve_registro_turno
    End Function
    Private Function valida_hora_de_captura(ByVal hora_actual As DateTime) As Boolean
        Dim fecha_inicio As DateTime
        Dim fecha_final As DateTime
        'fecha_inicio = ini_aux
        'fecha_final = fin_aux
        If hora_actual >= fecha_inicio And hora_actual <= fecha_final Then
            Return True
        Else
            'bandera_guardado = True
            Return False
        End If
    End Function
#End Region
#Region "Funciones para modulo Productividad"
    'Productividad
    Private Sub add_modelo_producido()
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = get_registro_del_turno()
        oProduccion.cod_empleado_registro = vcodigo_empleado
        oProduccion.fecha_registro = Now.ToString("dd-MM-yyyy HH:mm")
        oProduccion.cve_modelo = cbxModeloProductividad.SelectedValue
        oProduccion.pzas_ok = Long.Parse(txtPiezasOkProducidas.Text)
        oProduccion.tom = Long.Parse(txtTiempoOperacion.Text)
        oProduccion.Registrar()
    End Sub
    Private Sub remove_modelo_producido()
        If grdDetalleProductividad.Rows.Count <> 0 Then
            Dim oProduccion As New Produccion
            oProduccion.cve_registro_turno = get_registro_del_turno()
            oProduccion.cve_produccion = grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
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
            Return False
        ElseIf min <= get_minutos_disponibles() Then
            Return True
        Else
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
        Dim oDesecho As New Desecho
        oDesecho.cve_registro_turno = get_registro_del_turno()
        oDesecho.cod_empleado_registro = vcodigo_empleado
        oDesecho.fecha_registro = Now.ToString("MM-dd-yyyy HH:mm")
        oDesecho.cve_modelo = cbxModeloDesecho.SelectedValue
        oDesecho.cantidad = Long.Parse(txtDesechosCantidad.Text)
        oDesecho.estatus = "1"
        oDesecho.Registrar()
    End Sub
    Private Sub remove_desecho()
        If grdDetalleDesecho.Rows.Count <> 0 Then
            Dim oDesecho As New Desecho
            oDesecho.cod_empleado_eliminacion = vcodigo_empleado
            oDesecho.fecha_eliminacion = Now.ToString("MM-dd-yyyy HH:mm")
            oDesecho.cve_desecho = grdDetalleDesecho.Item("colcve_desecho", grdDetalleDesecho.CurrentRow.Index).Value
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
            oRegistro_Paro.Cve_registro_paro = grdDetalleParo.Item("colcve_registro_paro", grdDetalleParo.CurrentRow.Index).Value
            oRegistro_Paro.Cod_empleado_eliminacion = vcodigo_empleado
            oRegistro_Paro.Fecha_eliminacion = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oRegistro_Paro.Eliminar()
        Else
            btnQuitarParo.Enabled = False
        End If
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
            oRechazo.cve_rechazo = grdDetalleRechazo.Item("colcve_rechazo", grdDetalleRechazo.CurrentRow.Index).Value
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
            add_Paro_CDM()
            llena_paro_gridview()
            actualiza_tabla_turno_minutos()
            calcula_Productividad()
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
        oRegistro_Paro.Detalles = contenedor_CDM.comentarios(8, 0)
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
        oGente.fecha_registro = Now.ToString("MM-dd-yyyy HH:mm")
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
            oGente.cve_gente = grdDetalleGente.Item("colcve_gente", grdDetalleGente.CurrentRow.Index).Value
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
        oSeguridad.fecha_registro = Now.ToString("MM-dd-yyyy HH:mm")
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
            oSeguridad.fecha_eliminacion = Now.ToString("dd-MM-yyyy HH:mm")
            oSeguridad.cve_seguridad = grdDetalleCondInseg.Item("colcve_seguridad", grdDetalleCondInseg.CurrentRow.Index).Value
            oSeguridad.Eliminar()
        Else
            btnQuitarCondInseg.Enabled = False
        End If
    End Sub
    Private Sub add_accidentes()
        Dim oSeguridad As New Seguridad
        oSeguridad.cve_registro_turno = get_registro_del_turno()
        oSeguridad.cod_empleado_registro = vcodigo_empleado
        oSeguridad.fecha_registro = Now.ToString("MM-dd-yyyy HH:mm")
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
            oSeguridad.fecha_eliminacion = Now.ToString("dd-MM-yyyy HH:mm")
            oSeguridad.cve_seguridad = grdDetalleAccidente.Item("col_cve_seguridad", grdDetalleAccidente.CurrentRow.Index).Value
            oSeguridad.Eliminar()
        Else
            btnQuitarAccidente.Enabled = False
        End If
    End Sub
#End Region

 
End Class
