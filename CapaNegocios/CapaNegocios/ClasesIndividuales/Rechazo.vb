Imports CapaDatos
Public Class Rechazo
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
        Dim queryLlenagridview As String = "select d.cve_desecho,m.np_gkn,m.descripcion,d.cantidad from desecho d " &
            "join modelo m on d.cve_modelo=m.cve_modelo " &
            "where d.cve_registro_turno=" & vcve_registro_turno & " and d.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de Desechos. CDesecho_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class
