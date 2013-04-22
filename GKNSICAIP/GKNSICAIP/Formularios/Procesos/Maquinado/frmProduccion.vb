Imports CapaNegocios
Public Class frmProduccion
#Region "Atributos"
    Private vcve_equipo As Integer = 4
    Private vnombre_equipo As String
    Private vnombre_empleado As String
    Private vcodigo_empleado As String
    'Banderas
    Private flgBanderacbxLineas As Boolean = False
    Private flgBanderacbxModelos As Boolean = False
#End Region
#Region "Calculo de OEE"
    Private Sub calcula_Disponibilidad()
        If lblTiempoTurno.Text <> "0" And lblTiempoCarga.Text = lblParosNoPlaneados.Text Then
            lblDisponibilidad.Text = "0"
        ElseIf lblTiempoCarga.Text <> "0" And lblTiempoOperacion.Text <> "0" Then
            If ((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100) <= 100 Then
                lblDisponibilidad.Text = Format((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100, "##0.00")
            ElseIf ((Convert.ToDouble(lblTiempoOperacion.Text) / Convert.ToDouble(lblTiempoCarga.Text)) * 100) > 100 Then
                lblDisponibilidad.Text = "100.00"
            Else
                lblDisponibilidad.Text = "0.00"
            End If
        Else
            lblDisponibilidad.Text = 0
        End If
    End Sub
    Private Sub calcula_Desempeno()

    End Sub
#End Region
#Region "Inicializando formulario"
    'Establece variables globales
    Public Sub set_Datos_Equipo(ByVal idEq As Integer, ByVal NomEquipo As String, ByVal Empleado As String, ByVal CodEmpleado As String)
        vcve_equipo = idEq
        vnombre_equipo = NomEquipo
        vnombre_empleado = Empleado
        vcodigo_empleado = CodEmpleado
        lblNombreEquipo.Text = vnombre_equipo

    End Sub
    'Load
    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_cbx_Turnos()
        llena_cbx_Lineas()
        llena_cbx_Modelos()
        llena_cbx_tipo_rechazos()
        llena_productividad_gridview()
        llena_desecho_gridview()
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
    End Sub
    'Lineas
    Private Sub llena_cbx_Lineas()
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas
        cbxLinea.SelectedIndex = -1
        flgBanderacbxLineas = True
    End Sub
    'Modelos (por Linea)
    Private Sub llena_cbx_Modelos()
        flgBanderacbxModelos = False
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            Dim oModelo As New CapaNegocios.Modelo
            cbxModeloProductividad.ValueMember = "cve_modelo"
            cbxModeloProductividad.DisplayMember = "np_gkn"
            cbxModeloProductividad.DataSource = oModelo.llena_combo_Modelos_Linea(cbxLinea.SelectedValue)
            cbxModeloProductividad.SelectedIndex = -1

            cbxModeloDesecho.ValueMember = "cve_modelo"
            cbxModeloDesecho.DisplayMember = "np_gkn"
            cbxModeloDesecho.DataSource = oModelo.llena_combo_Modelos_Linea(cbxLinea.SelectedValue)
            cbxModeloDesecho.SelectedIndex = -1


            cbxModeloRechazo.ValueMember = "cve_modelo"
            cbxModeloRechazo.DisplayMember = "np_gkn"
            cbxModeloRechazo.DataSource = oModelo.llena_combo_Modelos_Linea(cbxLinea.SelectedValue)
            cbxModeloRechazo.SelectedIndex = -1



            flgBanderacbxModelos = True
        End If
    End Sub
    'Rechazos
    Private Sub llena_cbx_tipo_rechazos()
        Dim oTipoRechazo As New Tipo_Rechazo
        cbxTipoRechazo.ValueMember = "cve_tipo_rechazo"
        cbxTipoRechazo.DisplayMember = "tipo"
        cbxTipoRechazo.DataSource = oTipoRechazo.llena_combo_tipo_rechazo
        cbxModeloRechazo.SelectedIndex = -1
    End Sub
#End Region
#Region "Llenado Labels - Textbox"
    'General
    Private Sub obten_descripcion_modelo(ByRef txtmodelodesc As TextBox, ByRef cbxmodelodesc As ComboBox)
        If flgBanderacbxModelos Then
            Dim oModelo As New Modelo
            oModelo.cve_modelo = cbxmodelodesc.SelectedValue
            oModelo.obtener_descripcion_modelo()
            txtmodelodesc.Text = oModelo.descripcion
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
#End Region
#Region "Eventos ComboBox"
    'General
    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        llena_cbx_Modelos()
    End Sub
    'Productividad
    Private Sub cbxModeloProductividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloProductividad.SelectedIndexChanged
        If cbxModeloProductividad.SelectedIndex <> -1 Then
            valida_botones_productividad()
            obten_descripcion_modelo(txtModeloDescripcionProductividad, cbxModeloProductividad)
            deshabilitar_btn_quitar_modelo()
        End If
    End Sub
    'Desechos
    Private Sub cbxModeloDesecho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloDesecho.SelectedIndexChanged
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
#End Region
#Region "Eventos TextBox"
    'Productividad
    Private Sub txtMinutos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTiempoOperacion.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_quitar_modelo()
    End Sub
    Private Sub txtPiezasProducidas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiezasOkProducidas.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_quitar_modelo()
    End Sub
    'Desechos
    Private Sub txtDesechosCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesechosCantidad.TextChanged
        valida_sea_numero(sender)
        valida_botones_desecho()
        deshabilitar_btn_quitar_desecho()
    End Sub
    'Rechazos
    Private Sub txtRechazosCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRechazosCantidad.TextChanged
        valida_sea_numero(sender)
        valida_botones_rechazos()
        deshabilitar_btn_quitar_rechazo()
    End Sub
#End Region
#Region "Eventos Botones"
    'Productividad
    Private Sub btnAgregarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarModelo.Click
        add_modelo_producido()
        limpia_productividad()
        llena_productividad_gridview()
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
#End Region
#Region "Validaciones"
    'Generales
    Private Sub valida_sea_numero(ByRef cajaDeTexto As TextBox)
        If cajaDeTexto.Text <> "" And Not IsNumeric(cajaDeTexto.Text) Then
            cajaDeTexto.Text = "0"
        End If
    End Sub
    'Productividad
    Private Sub valida_botones_productividad()
        If cbxModeloProductividad.SelectedIndex <> -1 And txtTiempoOperacion.Text <> "" And txtPiezasOkProducidas.Text <> "" And txtPiezasOkProducidas.Text <> "0" And txtTiempoOperacion.Text <> "0" Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarModelo.Enabled = True
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
    Private Sub valida_botones_desecho()
        If cbxModeloDesecho.SelectedIndex <> -1 And txtDesechosCantidad.Text <> "" And txtDesechosCantidad.Text <> "0" Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarDesecho.Enabled = True
            End If
        Else
            btnAgregarDesecho.Enabled = False
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
    Private Sub valida_botones_rechazos()
        If cbxModeloRechazo.SelectedIndex <> -1 And txtRechazosCantidad.Text <> "" And txtRechazosCantidad.Text <> "0" And cbxTipoRechazo.SelectedIndex <> -1 Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarRechazo.Enabled = True
            End If
        Else
            btnAgregarRechazo.Enabled = False
        End If
    End Sub
    Private Sub habilita_btn_Quitar_desecho()
        limpia_desechos()
        btnQuitarDesecho.Enabled = True
    End Sub
    Private Sub deshabilitar_btn_quitar_desecho()
        btnQuitarDesecho.Enabled = False
    End Sub
#End Region
#Region "Limpia formularios"
    'Productividad
    Private Sub limpia_productividad()
        cbxModeloProductividad.SelectedIndex = -1
        txtPiezasOkProducidas.Text = "0"
        txtTiempoOperacion.Text = ""
        txtModeloDescripcionProductividad.Text = ""
    End Sub
    'Desechos
    Private Sub limpia_desechos()
        cbxModeloDesecho.SelectedIndex = -1
        txtDesechosCantidad.Text = ""
        txtModeloDesecho.Text = ""
    End Sub
    'Rechazos
    Private Sub limpia_rechazos()
        cbxModeloRechazo.SelectedIndex = -1
        cbxTipoRechazo.SelectedIndex = -1
        txtRechazosCantidad.Text = ""
        txtRechazoMotivo.Text = ""
    End Sub
#End Region
#Region "Funciones para modulo Productividad"
    'Productividad
    Private Sub add_modelo_producido()
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = 1
        oProduccion.cod_empleado_registro = "118737"
        oProduccion.fecha_registro = Now.ToString("dd-MM-yyyy HH:mm")
        oProduccion.cve_modelo = cbxModeloProductividad.SelectedValue
        oProduccion.pzas_ok = Long.Parse(txtPiezasOkProducidas.Text)
        oProduccion.tom = Long.Parse(txtTiempoOperacion.Text)
        oProduccion.estatus = "1"
        oProduccion.Registrar()
    End Sub
    Private Sub remove_modelo_producido()
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = 1
        oProduccion.cve_produccion = grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
        oProduccion.estatus = "0"
        oProduccion.elimina_fila_productividad_gridview()
    End Sub
    'Desechos
    Private Sub add_desecho()
        Dim oDesecho As New Desecho
        oDesecho.cve_registro_turno = 1
        oDesecho.cod_empleado = "118737"
        oDesecho.cve_modelo = cbxModeloDesecho.SelectedValue
        oDesecho.cantidad = Long.Parse(txtDesechosCantidad.Text)
        oDesecho.estatus = "1"
        oDesecho.Registrar()
    End Sub
    Private Sub remove_desecho()
        Dim oDesecho As New Desecho
        oDesecho.cve_desecho = grdDetalleDesecho.Item("colcve_desecho", grdDetalleDesecho.CurrentRow.Index).Value
        oDesecho.elimina_fila_desecho_gridview()
    End Sub
#End Region
End Class
