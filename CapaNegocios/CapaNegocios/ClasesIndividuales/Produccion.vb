Imports CapaDatos
Public Class Produccion
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "Metodos IIndividual"

    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from produccion p where p.cve_produccion=" & vcve_produccion, "produccion")
        If vDR IsNot Nothing Then
            Me.vcve_produccion = vDR("cve_produccion")
            Me.vcve_registro_turno = vDR("cve_registro_turno")
            Me.vcod_empleado_registro = vDR("cod_empleado_registro")
            Me.vfecha_registro = vDR("fecha_registro")
            Me.vcve_modelo = vDR("cve_modelo")
            If vDR("cve_TC") IsNot DBNull.Value Then
                Me.vcve_TC = vDR("cve_TC")
            Else
                Me.vcve_TC = Nothing
            End If
            Me.vpzas_ok = vDR("pzas_ok")
            Me.vtom = vDR("tom")
            If vDR("cod_empleado_eliminacion") IsNot DBNull.Value Then
                Me.vcod_empleado_eliminacion = vDR("cod_empleado_eliminacion")
            Else
                Me.vcod_empleado_eliminacion = ""
            End If
            If vDR("fecha_eliminacion") IsNot DBNull.Value Then
                Me.vfecha_eliminacion = vDR("fecha_eliminacion")
            Else
                Me.vcod_empleado_eliminacion = ""
            End If
            vestatus = vDR("estatus")
        End If
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "remueve_produccion"}
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
                Dim vComando As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "registra_produccion"}
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@codempleado", SqlDbType.VarChar).Value = Me.vcod_empleado_registro
                vComando.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vfecha_registro)
                vComando.Parameters.Add("@cve_modelo", SqlDbType.BigInt).Value = Me.vcve_modelo
                vComando.Parameters.Add("@cve_TC", SqlDbType.BigInt).Value = Me.vcve_TC
                vComando.Parameters.Add("@pzas_ok", SqlDbType.Int).Value = Me.vpzas_ok
                vComando.Parameters.Add("@tiempo_operacion", SqlDbType.Int).Value = Me.vtom
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al insertar produccion. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub

    Public Function obtener_datos() As DataTable
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
    Private vcve_TC As Long
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
    Public Property cve_TC() As Long
        Get
            Return vcve_TC
        End Get
        Set(ByVal value As Long)
            vcve_TC = value
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
                Dim vComando As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "obtener_registros_produccion"}
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                obj = oBD.EjecutaCommando(vComando)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class
