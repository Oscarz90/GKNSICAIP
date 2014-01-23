Imports CapaDatos
Public Class gfu_nivel_let
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "Propiedades"

    Private vcve_usuario As Long
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property

    Private vcve_equipo As Long
    Public Property cve_equipo() As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property

#End Region
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
    End Sub
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return 1
        End Get
        Set(ByVal value As Long)
            value = 1
        End Set
    End Property
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function
    Public Sub Registrar() Implements IIndividual.Registrar
    End Sub
#End Region
#Region "Metodos Graficos Fase Uno"
    Public Function llena_combo_equipo() As DataTable
        Dim dtEquipoLinea As New DataTable
        Try
            dtEquipoLinea = oBD.ObtenerTabla("select e.cve_equipo,e.equipo from equipo e where e.cve_equipo=" & vcve_equipo)
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_let_ERROR", vbCritical + vbOKOnly, "Error")
            dtEquipoLinea = Nothing
        End Try
        Return dtEquipoLinea
    End Function

    Public Function llena_combo_equipo_let() As DataTable
        Dim dtEquipoLinea As New DataTable
        Try
            dtEquipoLinea = oBD.ObtenerTabla("select e.cve_equipo,e.equipo from USUARIO_EQUIPO ue " &
                                             "join equipo e on ue.CVE_Equipo=e.cve_equipo " &
                                             "where ue.CVE_Usuario = " & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_let_ERROR", vbCritical + vbOKOnly, "Error")
            dtEquipoLinea = Nothing
        End Try
        Return dtEquipoLinea
    End Function
#End Region
End Class