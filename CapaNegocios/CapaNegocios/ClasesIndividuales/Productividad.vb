Imports CapaDatos
Public Class Productividad
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
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

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "Captura_productividad_Produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                vComando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vfecha
                vComando.Parameters.Add("@disponibilidad", SqlDbType.Float).Value = Me.vdisponibilidad
                vComando.Parameters.Add("@desempeno", SqlDbType.Float).Value = Me.vdesempeno
                vComando.Parameters.Add("@calidad", SqlDbType.Float).Value = Me.vcalidad
                vComando.Parameters.Add("@oee", SqlDbType.Float).Value = Me.voee
                vComando.Parameters.Add("@tipo_registro", SqlDbType.VarChar).Value = Me.vtipo_registro
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al insertar productividad. CProductividad_ERROR", vbCritical + vbOKOnly, "Error")
                'Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_productividad As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado As String
    Private vfecha As DateTime
    Private vdisponibilidad As Double
    Private vdesempeno As Double
    Private vcalidad As Double
    Private voee As Double
    Private vtipo_registro As String
#End Region
#Region "Propiedades"
    Public Property cve_productividad() As Long
        Get
            Return vcve_productividad
        End Get
        Set(ByVal value As Long)
            vcve_productividad = value
        End Set
    End Property
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
        End Set
    End Property
    Public Property cod_empleado() As String
        Get
            Return vcod_empleado
        End Get
        Set(ByVal value As String)
            vcod_empleado = value
        End Set
    End Property
    Public Property fecha() As DateTime
        Get
            Return vfecha
        End Get
        Set(ByVal value As DateTime)
            vfecha = value
        End Set
    End Property
    Public Property disponibilidad() As Double
        Get
            Return vdisponibilidad
        End Get
        Set(ByVal value As Double)
            vdisponibilidad = value
        End Set
    End Property
    Public Property desempeno() As Double
        Get
            Return vdesempeno
        End Get
        Set(ByVal value As Double)
            vdesempeno = value
        End Set
    End Property
    Public Property calidad() As Double
        Get
            Return vcalidad
        End Get
        Set(ByVal value As Double)
            vcalidad = value
        End Set
    End Property
    Public Property oee() As Double
        Get
            Return voee
        End Get
        Set(ByVal value As Double)
            voee = value
        End Set
    End Property
    Public Property tipo_registro() As String
        Get
            Return vtipo_registro
        End Get
        Set(ByVal value As String)
            vtipo_registro = value
        End Set
    End Property
#End Region
End Class
