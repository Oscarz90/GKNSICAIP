Imports CapaNegocios
Public Class frmProduccion

#Region "Atributos"
    Private vcve_equipo As Integer = 4
    Private vnombre_equipo As String
    Private vnombre_empleado As String
    Private vcodigo_empleado As String
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
    End Sub

#End Region

#Region "LLenado de comboBoxs"
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

#Region "Eventos de ComboBox"
    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        llena_cbx_Modelos()
    End Sub
#End Region

#Region "Eventos de TextBox"
    Private Sub txtMinutos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinutos.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_Quitar_modelo()
    End Sub
    Private Sub txtPiezasProducidas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiezasProducidas.TextChanged
        valida_sea_numero(sender)
        valida_botones_productividad()
        deshabilitar_btn_Quitar_modelo()
    End Sub
#End Region

#Region "eventos botones"
    Private Sub btnAgregarModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarModelo.Click

    End Sub
#End Region

#Region "eventos listviews"
    Private Sub lstProductividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        habilita_btn_Quitar_modelo()
    End Sub
#End Region

#Region "validaciones"
    Private Sub valida_botones_productividad()
        If cbxModeloProductividad.SelectedIndex <> -1 And txtMinutos.Text <> "" And txtPiezasProducidas.Text <> "" And txtPiezasProducidas.Text <> "0" And txtMinutos.Text <> "0" Then
            If cbxTurno.SelectedIndex <> -1 Then
                btnAgregarModelo.Enabled = True
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
        txtMinutos.Text = ""
        txtPiezasProducidas.Text = "0"
        cbxModeloProductividad.SelectedIndex = -1
        btnQuitarModelo.Enabled = True
    End Sub
#End Region

End Class
