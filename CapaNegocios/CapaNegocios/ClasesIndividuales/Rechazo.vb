Imports CapaDatos
Public Class Rechazo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "remueve_rechazo"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cve_rechazo", SqlDbType.BigInt).Value = Me.vcve_rechazo
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado_elimino
                vComando.Parameters.Add("@fecha_eliminacion", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vfecha_eliminacion)
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al eliminar rechazo. CRechazo_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
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
                vComando.CommandText = "registra_rechazo"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@codempleado", SqlDbType.VarChar).Value = Me.vcod_empleado_registro
                vComando.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vfecha_registro)
                vComando.Parameters.Add("@cve_modelo", SqlDbType.BigInt).Value = Me.vcve_modelo
                vComando.Parameters.Add("@cve_tipo_rechazo", SqlDbType.Int).Value = Me.vcve_tipo_rechazo
                vComando.Parameters.Add("@cantidad", SqlDbType.Int).Value = Me.vcantidad
                vComando.Parameters.Add("@motivo", SqlDbType.VarChar).Value = Me.vmotivo
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al insertar rechazo. CRechazo_ERROR", vbCritical + vbOKOnly, "Error")
                'Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_rechazo As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As String
    Private vcve_modelo As Long
    Private vcve_tipo_rechazo As Long
    Private vcantidad As Long
    Private vmotivo As String
    Private vcod_empleado_elimino As String
    Private vfecha_eliminacion As String
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_rechazo() As Long
        Get
            Return vcve_rechazo
        End Get
        Set(ByVal value As Long)
            vcve_rechazo = value
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
    Public Property cod_empleado_registro() As String
        Get
            Return vcod_empleado_registro
        End Get
        Set(ByVal value As String)
            vcod_empleado_registro = value
        End Set
    End Property
    Public Property fecha_registro() As String
        Get
            Return vfecha_registro
        End Get
        Set(ByVal value As String)
            vfecha_registro = value
        End Set
    End Property
    Public Property cve_modelo() As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
        End Set
    End Property
    Public Property cve_tipo_rechazo() As Long
        Get
            Return vcve_tipo_rechazo
        End Get
        Set(ByVal value As Long)
            vcve_tipo_rechazo = value
        End Set
    End Property
    Public Property cantidad() As Long
        Get
            Return vcantidad
        End Get
        Set(ByVal value As Long)
            vcantidad = value
        End Set
    End Property
    Public Property motivo() As String
        Get
            Return vmotivo
        End Get
        Set(ByVal value As String)
            vmotivo = value
        End Set
    End Property
    Public Property cod_empleado_elimino() As String
        Get
            Return vcod_empleado_elimino
        End Get
        Set(ByVal value As String)
            vcod_empleado_elimino = value
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
    Public Function llena_rechazo_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select r.cve_rechazo,m.np_gkn,m.descripcion,r.cantidad,tr.tipo,r.motivo from rechazo r " &
            "join tipo_rechazo tr on r.cve_tipo_rechazo=tr.cve_tipo_rechazo " &
            "join modelo m on r.cve_modelo=m.cve_modelo " &
            "where r.cve_registro_turno=" & vcve_registro_turno & " and r.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de Rechazos. CDesecho_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class
