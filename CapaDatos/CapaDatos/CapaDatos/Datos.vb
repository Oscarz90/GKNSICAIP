Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Datos
    Dim oBD As Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase
    Public Sub New(ByVal vCadena_Conexion As String)
        oBD = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(vCadena_Conexion)
    End Sub
#Region "Metodos"
    Public Sub EjecutarQuery(ByVal vConsulta As String)
        Try
            Dim oSqlComando As New SqlClient.SqlCommand(vConsulta)
            oBD.ExecuteNonQuery(oSqlComando)
        Catch
            Throw New Exception(String.Format("Error al ejecutar la siguiente consulta: {0} {1}", vConsulta, Err.Description))
        End Try

    End Sub
    Public Function EjecutaCommando(ByVal oSQL_Comando As System.Data.Common.DbCommand) As DataTable
        Try
            Dim vDS As DataSet = oBD.ExecuteDataSet(oSQL_Comando)
            If vDS.Tables.Count > 0 Then
                Return vDS.Tables(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception("Error al crear una tabla " & Err.Description)
        End Try
    End Function
    Public Function ObtenerTabla(ByVal vConsulta_SQL As String) As DataTable
        Try
            Dim oSqlComando As New SqlClient.SqlCommand(vConsulta_SQL)
            Dim ds As DataSet = oBD.ExecuteDataSet(oSqlComando)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        Catch
            Throw New Exception(String.Format("Error al crear una tabla con la siguente sentencia: {0} {1}", vConsulta_SQL, Err.Description))
        End Try
    End Function
    ''' <summary>
    ''' Se obtien un solo registro dentro de un objeto tipo DataRow
    ''' </summary>
    ''' <param name="vConsulta_SQL">Consulta SQL</param>
    ''' <param name="Nombre">Nombre de Tabla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function ObtenerRenglon(ByVal vConsulta_SQL As String, ByVal Nombre As String) As DataRow
        Dim oSQL_Adt As New SqlClient.SqlDataAdapter
        Dim vDT_Temp As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand(vConsulta_SQL)
            oSQL_Adt.SelectCommand = cmd
            vDT_Temp = New DataTable(Nombre)
            Dim ds As DataSet = oBD.ExecuteDataSet(cmd)
            vDT_Temp = ds.Tables(0)
            If vDT_Temp.Rows.Count > 0 Then
                ObtenerRenglon = vDT_Temp.Rows(0)
            Else
                ObtenerRenglon = Nothing
            End If
        Catch
            Throw New Exception(String.Format("Error al crear un renglon con la siguente sentencia: {0} {1}", vConsulta_SQL, Err.Description))
        End Try
    End Function
    Public Sub EjecutaProcedimientos(ByVal oSQL_Comando As System.Data.Common.DbCommand)
        Try
            Dim vDS As DataSet = oBD.ExecuteDataSet(oSQL_Comando)
        Catch ex As Exception
            Throw New Exception("Error al ejecutar Operacion " & Err.Description)
        End Try
    End Sub
#End Region
End Class
