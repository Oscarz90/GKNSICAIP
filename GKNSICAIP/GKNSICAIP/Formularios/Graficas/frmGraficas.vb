Imports CapaNegocios
Public Class frmGraficas    
    ''Dim oGraficas As New CapaNegocios.Graficas
    Private vIdEquipo As Integer = 4


#Region "LLENADO DE COMBOBOXS USUARIO/LET"

    Private Sub llena_cbx_Equipos()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGraficas.Obtener_Nombre_Equipo_Usuarios(vIdEquipo)
        cbxEquipo.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Lineas()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oGraficas.Obtener_Lineas_Equipo_Usuarios(vIdEquipo)
        cbxLinea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Areas()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxArea.ValueMember = "cve_componente"
        cbxArea.DisplayMember = "componente"
        cbxArea.DataSource = oGraficas.Obtener_Area_Usuarios(vIdEquipo)
        cbxArea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_CadenaValor()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxUN.ValueMember = "cve_cadena_valor"
        cbxUN.DisplayMember = "cadena"
        cbxUN.DataSource = oGraficas.Obtener_CadenaValor_Usuarios(vIdEquipo)
        cbxUN.SelectedIndex = 0
    End Sub

#End Region
#Region "LLENADO DE COMBOBOXS LG"

    Private Sub llena_cbx_Equipos_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGraficas.Obtener_Nombre_Equipo_Usuarios(vIdEquipo)
        cbxEquipo.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Lineas_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oGraficas.Obtener_Lineas_Equipo_Usuarios(vIdEquipo)
        cbxLinea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Areas_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxArea.ValueMember = "cve_componente"
        cbxArea.DisplayMember = "componente"
        cbxArea.DataSource = oGraficas.Obtener_Area_Usuarios(vIdEquipo)
        cbxArea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_CadenaValor_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxUN.ValueMember = "cve_cadena_valor"
        cbxUN.DisplayMember = "cadena"
        cbxUN.DataSource = oGraficas.Obtener_CadenaValor_Usuarios(vIdEquipo)
        cbxUN.SelectedIndex = 0
    End Sub

#End Region
#Region "LLENADO DE COMBOBOXS GERENTE"

#End Region
#Region "DIRECTOR"

#End Region
#Region "LLENADO DE COMBOBOXS SUPERVISOR LIDER"

#End Region
#Region "LLENADO DE COMBOBOXS DIRECTOR"

#End Region

#Region "INICIALIZACION DEL FORMULARIO"
    Private Sub Graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oGraficas.Obtener_IdEquipo(vIdEquipo)
        llena_cbx_Equipos()
        llena_cbx_Lineas()
        llena_cbx_Areas()
        llena_cbx_CadenaValor()

        'llena_colores()
        cbxUN.Enabled = True
        cbxArea.Enabled = True
        cbxLinea.Enabled = True
        cbxEquipo.Enabled = True

        dtpDesde.Value = DateSerial(Now.Year, Now.Month, 1) ''Muestra el primer dia del mes actual
        dtpHasta.Value = Today

        cmdGraficar.Enabled = False
        rbtDia.Checked = True
        rbtOEE.Checked = True
        rbtLineas.Checked = True
        'banderacbx = 0
        'banderaArea = 0
        'banderaCheck = 0
        'banderaDate = 0
        'bandera_load = True
    End Sub
#End Region
#Region "EVENTOS DE COMBOBOX"
    Private Sub cbxUN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUN.SelectedIndexChanged

    End Sub

    Private Sub cbxArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxArea.SelectedIndexChanged

    End Sub

    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged

    End Sub

    Private Sub cbxEquipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEquipo.SelectedIndexChanged

    End Sub

#End Region
#Region "EVENTOS DE CALENDARIO"
    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged

    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged

    End Sub
#End Region

    Private Sub frmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSalir.Click
        Me.Close()
    End Sub
    
End Class