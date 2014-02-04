Imports CapaDatos
Public Class usuario_equipo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from USUARIO_EQUIPO where CVE_USUARIO_EQUIPO =" & vcve_usuario_equipo, "usuario_indicador")
        If vDR IsNot Nothing Then
            vcve_usuario_equipo = vDR("CVE_USUARIO_EQUIPO")
            vcve_usuario = vDR("CVE_Usuario")
            vcve_equipo = vDR("CVE_Equipo")
        End If
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from USUARIO_EQUIPO where CVE_USUARIO_EQUIPO =" & vcve_usuario_equipo)
        Catch ex As Exception

        End Try
    End Sub
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_usuario_equipo
        End Get
        Set(ByVal value As Long)
            vcve_usuario_equipo = value
        End Set
    End Property
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("select CVE_USUARIO_EQUIPO from USUARIO_EQUIPO where CVE_USUARIO_EQUIPO= " & vcve_usuario_equipo, "usuario_equipo")
        If vDR IsNot Nothing Then
            vcve_usuario_equipo = vDR("CVE_USUARIO_EQUIPO")
        Else
            Return 0
        End If
        Return vRetorno
    End Function
    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_usuario_equipo As Long
    Private vcve_usuario As Long
    Private vcve_equipo As Long
#End Region
#Region "Propiedades"
    Public Property cve_usuario_equipo() As Long
        Get
            Return vcve_usuario_equipo
        End Get
        Set(ByVal value As Long)
            vcve_usuario_equipo = value
        End Set
    End Property
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property
    Public Property cve_equipo() As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property
#End Region
#Region "Metodos"
   
#End Region
End Class




