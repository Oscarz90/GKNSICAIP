Imports CapaDatos
Public Class Usuario
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)

#Region "IIndividual"

    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from usuario where cve_usuario = " & vCve_usuario, "usuario")
        If vDR IsNot Nothing Then
            vCve_usuario = vDR("cve_usuario")
            vNombre = vDR("nombre")
            vPass = vDR("pass")
            vCve_nivel_usuario = vDR("cve_nivel_usuario")
            vUN = vDR("UN")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from usuario where cve_usuario = " & vCve_usuario)
        Catch ex As Exception

        End Try
    End Sub


    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("select cve_usuario from usuario where nombre = " & vCadena, "usuario")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_usuario")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_Usuario"}
                cmd.Parameters.Add("@cve_usuario", SqlDbType.BigInt).Value = Me.vCve_usuario
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Me.vNombre
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = Me.vPass
                cmd.Parameters.Add("@cve_nivel_usuario", SqlDbType.Int).Value = Me.vCve_nivel_usuario
                cmd.Parameters.Add("@UN", SqlDbType.VarChar).Value = Me.vUN

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_usuario = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
            End Try
        End Using
    End Sub
#End Region

#Region "Atributos"

    Private vCve_usuario As Long
    Private vNombre As String
    Private vPass As String
    Private vCve_nivel_usuario As Long
    Private vUN As String

#End Region

#Region "Propiedades"

    Public Property Cve_usuario As Long Implements IIndividual.Id
        Get
            Return vCve_usuario
        End Get
        Set(ByVal value As Long)
            vCve_usuario = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Public Property Pass() As String
        Get
            Return vPass
        End Get
        Set(ByVal value As String)
            vPass = value
        End Set
    End Property

    Public Property Cve_nivel_usuario() As Long
        Get
            Return vCve_nivel_usuario
        End Get
        Set(ByVal value As Long)
            vCve_nivel_usuario = value
        End Set
    End Property


    Public Property UN() As String
        Get
            Return vUN
        End Get
        Set(ByVal value As String)
            vUN = value
        End Set
    End Property


#End Region

End Class
