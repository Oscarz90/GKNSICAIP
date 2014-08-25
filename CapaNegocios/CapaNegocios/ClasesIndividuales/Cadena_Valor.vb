Imports CapaDatos
Public Class Cadena_Valor
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from cadena_valor where cve_cadena_valor = " & vCve_cadena_valor, "cadena_valor")
        If vDR IsNot Nothing Then
            vCve_cadena_valor = vDR("cve_cadena_valor")
            vCadena = vDR("cadena")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from cadena_valor where cve_cadena_valor = " & vCve_cadena_valor)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("select cve_cadena_valor from cadena_valor where cadena = " & vCadena, "cadena_valor")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_cadena_valor")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_cadena_valor"}
                cmd.Parameters.Add("@cve_cadena_valor", SqlDbType.Int).Value = Me.vCve_cadena_valor
                cmd.Parameters.Add("@cadena", SqlDbType.VarChar).Value = Me.vCadena

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_cadena_valor = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
            End Try
        End Using
    End Sub
#End Region

#Region "Atributos"
    Private vCve_cadena_valor As Long
    Private vCadena As String
#End Region
#Region "Propiedades"

    Public Property Cve_cadena_valor() As Long Implements IIndividual.Id
        Get
            Return vCve_cadena_valor
        End Get
        Set(ByVal value As Long)
            vCve_cadena_valor = value
        End Set
    End Property


    Public Property Cadena() As String
        Get
            Return vCadena
        End Get
        Set(ByVal value As String)
            vCadena = value
        End Set
    End Property

#End Region

    Public Function Obtener_Cadenas_Valor() As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla("Select * From cadena_valor")

        Return vDT_Retorno
    End Function

    Public Function Obtener_CV_Usuario(ByVal vCve_Usuario As Long) As DataTable
        Dim vRetorno As DataTable = oBD.ObtenerTabla("SELECT * FROM USUARIO_CADENA_VALOR WHERE CVE_Usuario=" & vCve_Usuario)


        Return vRetorno
    End Function
End Class
