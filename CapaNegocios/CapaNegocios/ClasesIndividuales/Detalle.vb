Imports CapaDatos
Public Class Detalle
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from detalle where cve_detalle = " & vCve_Detalle, "detalle")
        If vDR IsNot Nothing Then
            vCve_Detalle = vDR("cve_detalle")
            vTipo = vDR("tipo")
            vDescripcion = vDR("descripcion")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM detalle where Cve_Detalle= " & vCve_Detalle)
        Catch ex As Exception

        End Try
    End Sub
    
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("Select cve_detalle from destalle where descripcion=" & vCadena, "")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_detalle")
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
                cmd.CommandText = "REGISTRAR_Detalle"
                cmd.Parameters.Add("@cve_detalle", SqlDbType.BigInt).Value = Me.vCve_Detalle
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Me.vTipo
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Me.vDescripcion

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_Detalle = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vCve_Detalle As Long
    Private vTipo As String
    Private vDescripcion As String
#End Region
#Region "Propiedades"

    Public Property Cve_Detalle As Long Implements IIndividual.Id
        Get
            Return vCve_Detalle
        End Get
        Set(ByVal value As Long)
            vCve_Detalle = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal value As String)
            vTipo = value
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

#Region "Metodos generales"
    Public Function Obtener_Detalles() As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from detalle")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Detalles(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from detalle where descripcion LIKE '%" & vFiltro & "%'")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

#End Region

End Class
