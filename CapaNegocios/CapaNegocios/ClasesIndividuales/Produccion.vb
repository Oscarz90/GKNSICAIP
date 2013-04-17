Imports CapaDatos
Imports System.Transactions
Public Class Produccion
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "Metodos IIndividual"

    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vId
        End Get
        Set(ByVal value As Long)
            vId = value
        End Set
    End Property

    Private vNombre As String
    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim oBD As New CapaDatos.CapaDatos("Data Source= Oscar-PC\SQLExpress; initial Catalog=GKNSICAIP; User Id= sa; Password= sistemas")
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "registra_prueba"
                vComando.Parameters.Add("@Laboratorio_Id", SqlDbType.Int).Value = Me.vId
                vComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Me.vNombre
                Dim obj As DataTable = oBD.EjecutaCommando(vComando)
                Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
    Public Function obtener_datos() As DataTable
        'Dim dt As DataTable = oBD.ObtenerTabla("Select cve_turno,turno from laboratorio")
        Dim dt As DataTable
        Try
            dt = oBD.ObtenerTabla("Select cve_turno,turno from turno")
        Catch ex As Exception
            MsgBox("ERROR_01")
            dt = Nothing
        End Try
        Return dt
    End Function
#End Region

End Class
