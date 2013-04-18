Imports CapaDatos
Public Class Nivel_Usuario
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from nivel_usuario where cve_nivel_usuario = " & vCve_nivel_usuario, "nivel_usuario")
        If vDR IsNot Nothing Then
            vCve_nivel_usuario = vDR("cve_nivel_usuario")
            vNivel = vDR("nivel")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from nivel_usuario where cve_nivel_usuario = " & vCve_nivel_usuario)
        Catch ex As Exception

        End Try
    End Sub
   

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("select cve_nivel_usuario from nivel_usuario where nivel = " & vCadena, "nivel_usuario")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_nivel_usuario")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_nivel_usuario"
                cmd.Parameters.Add("@cve_nivel_usuario", SqlDbType.Int).Value = Me.vCve_nivel_usuario
                cmd.Parameters.Add("@nivel", SqlDbType.VarChar).Value = Me.vNivel

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_nivel_usuario = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
            End Try
        End Using

    End Sub
#End Region

#Region "Atributos"
    Private vCve_nivel_usuario As Long
    Private vNivel As String
#End Region

#Region "Propiedades"

    Public Property Cve_nivel_usuario As Long Implements IIndividual.Id
        Get
            Return vCve_nivel_usuario
        End Get
        Set(ByVal value As Long)
            vCve_nivel_usuario = value
        End Set
    End Property

    Public Property Nivel() As String
        Get
            Return vNivel
        End Get
        Set(ByVal value As String)
            vNivel = value
        End Set
    End Property

#End Region
End Class
