Imports CapaDatos
Public Class Detalle_Seguridad
    Implements IIndividual
#Region "Iindividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad=Long
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_detalle_seguridad
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_detalle_seguridad As Long
    Private vdescripcion As String
    Private vtipo As Long
#End Region
#Region "Propiedades"


    Public Property cve_detalle_seguridad() As Long
        Get
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return vdescripcion
        End Get
        Set(ByVal value As String)
            vdescripcion = value
        End Set
    End Property


    Public Property tipo() As Long
        Get
            Return vtipo
        End Get
        Set(ByVal value As Long)
            vtipo = value
        End Set
    End Property

#End Region
#Region "Metodos formulario de produccion"

#End Region
End Class
