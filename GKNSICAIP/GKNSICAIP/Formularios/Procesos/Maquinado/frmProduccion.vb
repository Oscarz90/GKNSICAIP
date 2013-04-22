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
    Public Sub set_Datos_Equipo(ByVal idEq As Integer, ByVal NomEquipo As String, ByVal Empleado As String, ByVal CodEmpleado As String)
        vcve_equipo = idEq
        vnombre_equipo = NomEquipo
        vnombre_empleado = Empleado
        vcodigo_empleado = CodEmpleado
        lblNombreEquipo.Text = vnombre_equipo

    End Sub

    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_cbx_Turnos()
        llena_cbx_Lineas()
        llena_cbx_Modelos()
        llena_productividad_gridview()
    End Sub

#End Region
#Region "LLenado ComboBoxs"
    Private Sub llena_cbx_Turnos()
        Dim oTurnos As New CapaNegocios.Turno
        cbxTurno.ValueMember = "cve_turno"
        cbxTurno.DisplayMember = "turno"
        cbxTurno.DataSource = oTurnos.llena_combo_turnos
        cbxTurno.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_Lineas()
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas
        cbxLinea.SelectedIndex = -1
        flgBanderacbxLineas = True
    End Sub
    Private Sub llena_cbx_Modelos()
        flgBanderacbxModelos = False
        If cbxLinea.SelectedIndex <> -1 And flgBanderacbxLineas Then
            Dim oModelo As New CapaNegocios.Modelo
            cbxModeloProductividad.ValueMember = "cve_modelo"
            cbxModeloProductividad.DisplayMember = "np_gkn"
            cbxModeloProductividad.DataSource = oModelo.llena_combo_Modelos_Linea(cbxLinea.SelectedValue)
            cbxModeloRechazo.ValueMember = "cve_modelo"
            cbxModeloRechazo.DisplayMember = "np_gkn"
            cbxModeloRechazo.DataSource = oModelo.llena_combo_Modelos_Linea(cbxLinea.SelectedValue)
            cbxModeloProductividad.SelectedIndex = -1
            cbxModeloRechazo.SelectedIndex = -1
            flgBanderacbxModelos = True
        End If
    End Sub
#End Region
#Region "Llenado Labels - Textbox"
    Private Sub obten_descripcion_modelo(ByRef txtmodelodesc As TextBox)
        If flgBanderacbxModelos Then
            Dim oModelo As New Modelo
            oModelo.cve_modelo = cbxModeloProductividad.SelectedValue
            oModelo.obtener_descripcion_modelo()
            txtModeloDescripcionProductividad.Text = oModelo.descripcion
        End If
    End Sub
#End Region
#Region "Llenado Gridsviews"
    Private Sub llena_productividad_gridview()
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = 1
        grdDetalleProductividad.DataSource = oProduccion.llena_productividad_gridview()
    End Sub
    Private Sub llena_desecho_gridview()

    End Sub
#End Region
#Region "Eventos ComboBox"
    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        llena_cbx_Modelos()
    End Sub
    Private Sub cbxModeloProductividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloProductividad.SelectedIndexChanged
        If cbxModeloProductividad.SelectedIndex <> -1 Then
            obten_descripcion_modelo(txtModeloDescripcionProductividad)
            deshabilitar_btn_Quitar_modelo()
        End If
    End Sub
    Private Sub cbxModeloRechazo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxModeloRechazo.SelectedIndexChanged
        obten_descripcion_modelo(txtModeloRechazo)
    End Sub
#End Region
#Region "Eventos TextBox"
    Private Sub txtMinutos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTiempoOperacion.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_Quitar_modelo()
    End Sub
    Private Sub txtPiezasProducidas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiezasOkProducidas.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_Quitar_modelo()
    End Sub
#End Region
#Region "Eventos Botones"
    Private Sub btnAgregarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarModelo.Click
        add_modelo_producido()
        limpia_productividad()
        llena_productividad_gridview()
    End Sub
    Private Sub btnQuitarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarModelo.Click
        remove_modelo_producido()
        llena_productividad_gridview()
        deshabilitar_btn_Quitar_modelo()
    End Sub
#End Region
#Region "Eventos Gridviews"
    Private Sub grdDetalleProductividad_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleProductividad.CellClick
        'Dim cve_produccion As Long = grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
        habilita_btn_Quitar_modelo()
    End Sub
    Private Sub grdDetalleDesecho_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDetalleDesecho.CellClick
        habilita_btn_Quitar_desecho()
    End Sub
#End Region
#Region "Validaciones"
    Private Sub valida_botones_productividad()
        If cbxModeloProductividad.SelectedIndex <> -1 And txtTiempoOperacion.Text <> "" And txtPiezasOkProducidas.Text <> "" And txtPiezasOkProducidas.Text <> "0" And txtTiempoOperacion.Text <> "0" Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarModelo.Enabled = True
            End If
        Else
            btnAgregarModelo.Enabled = False
        End If
    End Sub
    Private Sub valida_botones_desecho()
        If cbxModeloRechazo.SelectedIndex <> -1 And txtDesechosCantidad.Text <> "" And txtDesechosCantidad.Text <> "0" Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarDesecho.Enabled = True
            End If
        Else
            btnAgregarModelo.Enabled = False
        End If

    End Sub
    Private Sub valida_sea_numero(ByRef cajaDeTexto As TextBox)
        If cajaDeTexto.Text <> "" And Not IsNumeric(cajaDeTexto.Text) Then
            cajaDeTexto.Text = "0"
        End If
    End Sub
    Private Sub deshabilitar_btn_Quitar_modelo()
        btnQuitarModelo.Enabled = False
    End Sub
    Private Sub habilita_btn_Quitar_modelo()
        limpia_productividad()
        btnQuitarModelo.Enabled = True
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
    Private Sub limpia_productividad()
        cbxModeloProductividad.SelectedIndex = -1
        txtPiezasOkProducidas.Text = "0"
        txtTiempoOperacion.Text = ""
    End Sub
    Private Sub limpia_desechos()
        cbxModeloRechazo.SelectedIndex = -1
        txtDesechosCantidad.Text = ""
    End Sub
#End Region
#Region "Funciones para modulo Productividad"
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
        MsgBox(grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value)
        Dim oProduccion As New Produccion
        oProduccion.cve_registro_turno = 1
        oProduccion.cve_produccion = grdDetalleProductividad.Item("colcve_produccion", grdDetalleProductividad.CurrentRow.Index).Value
        oProduccion.estatus = "0"
        oProduccion.elimina_fila_productividad_gridview()
    End Sub
#End Region
End Class
