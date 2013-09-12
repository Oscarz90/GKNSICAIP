Imports CapaDatos
Public Class gfu_nivel_lg
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "Propiedades"

    Private vcve_lider As Long
    Public Property cve_lider() As Long
        Get
            Return vcve_lider
        End Get
        Set(ByVal value As Long)
            vcve_lider = value
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
    Public Function nivel_lg_equipos() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select e.cve_equipo,e.equipo from equipo e " &
                                             "join lider l on e.cve_lider=l.cve_lider " &
                                             "where(l.cve_lider =" & vcve_lider)
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_componente_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function

#End Region
End Class