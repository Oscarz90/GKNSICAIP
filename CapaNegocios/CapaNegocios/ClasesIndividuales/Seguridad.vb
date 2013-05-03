Imports CapaDatos
Public Class Seguridad
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_seguridad = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        'meter codigo aqui
        Return vcve_seguridad
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_seguridad As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As DateTime
    Private vcve_detalle_seguridad As Long
    Private vcantidad As Long
    Private vcomentarios As String
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As DateTime
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_seguridad() As Long
        Get
            Return vcve_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_seguridad = value
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
    Public Property fecha_registro() As DateTime
        Get
            Return vfecha_registro
        End Get
        Set(ByVal value As DateTime)
            vfecha_registro = value
        End Set
    End Property
    Public Property cve_detalle_seguridad() As Long
        Get
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad = value
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
    Public Property comentarios() As String
        Get
            Return vcomentarios
        End Get
        Set(ByVal value As String)
            vcomentarios = value
        End Set
    End Property
    Public Property cod_empleado_eliminacion() As String
        Get
            Return vcod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vcod_empleado_eliminacion = value
        End Set
    End Property
    Public Property fecha_eliminacion() As DateTime
        Get
            Return vfecha_eliminacion
        End Get
        Set(ByVal value As DateTime)
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

#End Region
End Class
