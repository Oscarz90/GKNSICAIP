Imports CapaDatos
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
#Region "Atributos"
    Private vcve_produccion As Integer
    Private vcve_registro_turno As Integer
    Private vcod_empleado_registro As String
    Private vfecha_registro As String
    Private vcve_modelo As Integer
    Private vpzas_ok As Integer
    Private vtom As Integer
    Private vadeudo As Integer
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion
    Private vstatus As String
#End Region
#Region "Propiedades"

    Public Property cve_produccion As Integer
        Get
            Return vcve_produccion
        End Get
        Set(ByVal value As Integer)
            vcve_produccion = value
        End Set
    End Property
    Public Property cve_registro_turno As Integer
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Integer)
            vcve_registro_turno = value
        End Set
    End Property
    Public Property cod_empleado_registro As String
        Get
            Return vcod_empleado_registro
        End Get
        Set(ByVal value As String)
            vcod_empleado_registro = value
        End Set
    End Property
    Public Property fecha_registro As String
        Get
            Return vfecha_registro
        End Get
        Set(ByVal value As String)
            vfecha_registro = value
        End Set
    End Property
    Public Property cve_modelo As Integer
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Integer)
            vcve_modelo = value
        End Set
    End Property

    Public Property pzas_ok As Integer
        Get
            Return vpzas_ok
        End Get
        Set(ByVal value As Integer)
            vpzas_ok = value
        End Set
    End Property

    Public Property tom As Integer
        Get
            Return vtom
        End Get
        Set(ByVal value As Integer)
            vtom = value
        End Set
    End Property

    Public Property adeudo As Integer
        Get
            Return vadeudo
        End Get
        Set(ByVal value As Integer)
            vadeudo = value
        End Set
    End Property

    Public Property cod_empleado_eliminacion As String
        Get
            Return vcod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vcod_empleado_eliminacion = value
        End Set
    End Property

    Property fecha_eliminacion



#End Region

End Class
