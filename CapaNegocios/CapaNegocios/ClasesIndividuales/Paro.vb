Imports CapaDatos
Public Class Paro
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from paro where cve_paro = " & vCve_Paro, "paro")
        If vDR IsNot Nothing Then
            vCve_Paro = vDR("cve_paro")
            vCod_Paro = vDR("Cod_paro")
            vParo = vDR("paro")
            vAfecta_CDM = vDR("Afecta_CDM")
            vCve_Detalle = vDR("Cve_Detalle")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM paro where cve_paro= " & vCve_Paro)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("Select cve_paro from paro where cod_paro=" & vCadena, "")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_paro")
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
                cmd.CommandText = "REGISTRAR_Paro"
                cmd.Parameters.Add("@cve_paro", SqlDbType.BigInt).Value = Me.vCve_Paro
                cmd.Parameters.Add("@cod_paro", SqlDbType.VarChar).Value = Me.vCod_Paro
                cmd.Parameters.Add("@paro", SqlDbType.VarChar).Value = Me.vParo
                cmd.Parameters.Add("@Afecta_CDM", SqlDbType.Int).Value = Me.vAfecta_CDM
                cmd.Parameters.Add("@Cve_Detalle", SqlDbType.BigInt).Value = Me.vCve_Detalle
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_Paro = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vCve_Paro As Long
    Private vCod_Paro As String
    Private vParo As String
    Private vAfecta_CDM As Integer
    Private vCve_Detalle As Long
#End Region
#Region "Propiedades"

    Public Property Cve_Paro As Long Implements IIndividual.Id
        Get
            Return vCve_Paro
        End Get
        Set(ByVal value As Long)
            vCve_Paro = value
        End Set
    End Property

    Public Property Cod_Paro() As String
        Get
            Return vCod_Paro
        End Get
        Set(ByVal value As String)
            vCod_Paro = value
        End Set
    End Property

    Public Property Paro() As String
        Get
            Return vParo
        End Get
        Set(ByVal value As String)
            vParo = value
        End Set
    End Property

    Public Property Afecta_CDM() As Integer
        Get
            Return vAfecta_CDM
        End Get
        Set(ByVal value As Integer)
            vAfecta_CDM = value
        End Set
    End Property


    Public Property Cve_Detalle() As Long
        Get
            Return vCve_Detalle
        End Get
        Set(ByVal value As Long)
            vCve_Detalle = value
        End Set
    End Property



#End Region
End Class
