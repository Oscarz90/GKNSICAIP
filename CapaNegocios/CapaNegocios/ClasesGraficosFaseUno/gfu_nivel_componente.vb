Imports CapaDatos
Public Class gfu_nivel_componente
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
    Public Function nivel_componente_componente() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select c.cve_componente,c.componente from USUARIO_COMPONENTE uc " &
                                             "join componente c ON uc.CVE_Componente=c.cve_componente " &
                                             "where(uc.CVE_Usuario = " & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener componente. Cgfu_nivel_componente_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_componente_linea() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select l.cve_linea,l.linea from USUARIO_COMPONENTE uc " &
                                             "join componente c ON uc.CVE_Componente=c.cve_componente " &
                                             "join linea l on c.cve_componente=l.cve_componente " &
                                             "where l.Estatus='1' and uc.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener linea. Cgfu_nivel_componente_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_componente_equipos() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select DISTINCT e.cve_equipo,e.equipo from USUARIO_COMPONENTE uc " &
                                             "join componente c ON uc.CVE_Componente=c.cve_componente " &
                                             "join linea l on c.cve_componente=l.cve_componente " &
                                             "join equipo_linea el on l.cve_linea=el.cve_linea " &
                                             "join equipo e on el.cve_equipo=e.cve_equipo " &
                                             "where l.Estatus='1' and uc.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_componente_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function

#End Region
End Class