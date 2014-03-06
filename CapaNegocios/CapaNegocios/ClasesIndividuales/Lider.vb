Imports CapaDatos
Public Class Lider
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from lider where cve_lider = " & vcve_lider, "lider")
        If vDR IsNot Nothing Then
            vcve_lider = vDR("cve_lider")
            vLG = vDR("LG")
            vCodigo_LG = vDR("Codigo_LG")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM lider where cve_lider= " & vcve_lider)
        Catch ex As Exception

        End Try
    End Sub
    
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("Select cve_lider from lider where codigo_LG='" & vCadena & "'", "")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_lider")
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
                cmd.CommandText = "REGISTRAR_Lider"
                cmd.Parameters.Add("@cve_lider", SqlDbType.BigInt).Value = Me.vcve_lider
                cmd.Parameters.Add("@LG", SqlDbType.VarChar).Value = Me.vLG
                cmd.Parameters.Add("@Codigo_LG", SqlDbType.VarChar).Value = Me.vCodigo_LG

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_lider = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Dim vcve_lider As Long
    Private vLG As String
    Private vCodigo_LG As String
#End Region
#Region "Propiedades"
    Public Property cve_lider As Long Implements IIndividual.Id
        Get
            Return vcve_lider
        End Get
        Set(ByVal value As Long)
            vcve_lider = value
        End Set
    End Property

    Public Property LG() As String
        Get
            Return vLG
        End Get
        Set(ByVal value As String)
            vLG = value
        End Set
    End Property

    Public Property Codigo_LG() As String
        Get
            Return vCodigo_LG
        End Get
        Set(ByVal value As String)
            vCodigo_LG = value
        End Set
    End Property

#End Region
#Region "Metodos generales"

    Public Function Obtener_Lineas() As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from lider")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Lineas(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from lider where LG LIKE '%" & vFiltro & "%'")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

#End Region
End Class
