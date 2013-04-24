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

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "registra_produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@codempleado", SqlDbType.VarChar).Value = Me.vcod_empleado_registro
                vComando.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vfecha_registro)
                vComando.Parameters.Add("@cve_modelo", SqlDbType.BigInt).Value = Me.vcve_modelo
                vComando.Parameters.Add("@pzas_ok", SqlDbType.Int).Value = Me.vpzas_ok
                vComando.Parameters.Add("@tiempo_operacion", SqlDbType.Int).Value = Me.vtom
                'Dim obj As DataTable = oBD.EjecutaCommando(vComando)
                oBD.EjecutaProcedimientos(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al insertar produccion. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                'Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub

    Public Function obtener_datos() As DataTable
        'Dim dt As DataTable = oBD.ObtenerTabla("Select cve_turno,turno from laboratorio")
        Dim dt As DataTable
        Try
            dt = oBD.ObtenerTabla("Select cve_turno,turno from turno")
        Catch ex As Exception
            MsgBox("Error al obtener datos. ERROR_CProduccion", vbCritical + vbOKOnly, "Error")
            dt = Nothing
        End Try
        Return dt
    End Function
#End Region
#Region "Atributos"
    Private vcve_produccion As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As String
    Private vcve_modelo As Long
    Private vpzas_ok As Long
    Private vtom As Long
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As String
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_produccion As Long
        Get
            Return vcve_produccion
        End Get
        Set(ByVal value As Long)
            vcve_produccion = value
        End Set
    End Property
    Public Property cve_registro_turno As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
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
    Public Property cve_modelo As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
        End Set
    End Property
    Public Property pzas_ok As Long
        Get
            Return vpzas_ok
        End Get
        Set(ByVal value As Long)
            vpzas_ok = value
        End Set
    End Property
    Public Property tom As Long
        Get
            Return vtom
        End Get
        Set(ByVal value As Long)
            vtom = value
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
    Public Property fecha_eliminacion() As String
        Get
            Return vfecha_eliminacion
        End Get
        Set(ByVal value As String)
            vfecha_eliminacion = value
        End Set
    End Property
    Public Property estatus() As String
        Get
            Return vestatus
        End Get
        Set(ByVal value As String)
            vestatus = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_productividad_gridview() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtener_registros_produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Sub elimina_fila_productividad_gridview()
        'Dim oBD As New CapaDatos.CapaDatos("Data Source= Oscar-PC\SQLExpress; initial Catalog=GKNSICAIP; Integrated Security = True")
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "remueve_produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cve_produccion", SqlDbType.BigInt).Value = Me.vcve_produccion
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado_eliminacion
                vComando.Parameters.Add("@fecha_eliminacion", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vfecha_eliminacion)
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al eliminar produccion. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
End Class
