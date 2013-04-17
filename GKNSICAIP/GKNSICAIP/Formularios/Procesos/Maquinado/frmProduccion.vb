Imports CapaNegocios

Public Class frmProduccion

#Region "Atributos"
    Private vcve_equipo As Integer = 7
    Private vnombre_equipo As String
    Private vnombre_empleado As String
    Private vcodigo_empleado As String
#End Region

#Region "Inicializando formulario"
    Public Sub set_Datos_Equipo(ByVal idEq As Integer, ByVal NomEquipo As String, ByVal Empleado As String, ByVal CodEmpleado As String)
        vcve_equipo = idEq
        vnombre_equipo = NomEquipo
        vnombre_empleado = Empleado
        vcodigo_empleado = CodEmpleado
    End Sub
    Private Sub frmProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena_cbx_Turnos()
        llena_cbx_Lineas()
    End Sub
    Private Sub llena_cbx_Turnos()
        Dim oTurnos As New CapaNegocios.Turno
        cbxTurno.ValueMember = "Id"
        cbxTurno.DisplayMember = "turno"
        cbxTurno.DataSource = oTurnos.llena_combo_turnos
        cbxTurno.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_Lineas()
        Dim oEquipoLinea As New CapaNegocios.EquipoLinea
        oEquipoLinea.cve_equipo = vcve_equipo
        cbxLinea.ValueMember = "Id"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas
        'oEquipoLinea.

    End Sub
#End Region

End Class
