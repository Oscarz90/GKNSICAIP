Imports CapaDatos
Public Class Clasificacion_Modelo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from clasificacion_modelo where cve_clasificacion_modelo =" & vCve_clasificacion_modelo, "clasificacion_modelo")
        If vDR IsNot Nothing Then
            vCve_clasificacion_modelo = vDR("cve_clasificacion_modelo")
            vDescripcion = vDR("descripcion")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from clasificacion_modelo where cve_clasificacion_modelo =" & vCve_clasificacion_modelo)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("select cve_clasificacion_modelo from clasificacion_modelo where descripcion= " & vCadena, "clasificacion_modelo")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_clasificacion_modelo")
        Else
            Return 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_clasificacion_modelo"
                cmd.Parameters.Add("@cve_clasificacion_modelo", SqlDbType.Int).Value = Me.vCve_clasificacion_modelo
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Me.vCve_clasificacion_modelo

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_clasificacion_modelo = obj.Rows(0)(0)
                scope.Complete()

            Catch ex As Exception

            End Try
        End Using
    End Sub

    Public Function Obtener_Modelos() As DataTable
        Dim vRetorno As DataTable
        vRetorno = oBD.ObtenerTabla("select * from clasificacion_modelo")        
        If vRetorno IsNot Nothing Then

        Else
            vRetorno = Nothing
        End If
        Return vRetorno
    End Function

#End Region

#Region "Atributos"
    Private vCve_clasificacion_modelo As Long
    Private vDescripcion As String
#End Region
#Region "Propiedades"

    Public Property Cve_clasificacion_modelo() As Long Implements IIndividual.Id
        Get
            Return vCve_clasificacion_modelo
        End Get
        Set(ByVal value As Long)
            vCve_clasificacion_modelo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property


#End Region
End Class
