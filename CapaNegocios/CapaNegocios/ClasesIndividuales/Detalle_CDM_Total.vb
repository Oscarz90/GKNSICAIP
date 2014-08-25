
Public Class Detalle_CDM_Total
    Implements IIndividual
    
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
    Private vcve_detalle_CDM As Long
    Private vcve_registro_turno As Long
    Private vcve_CDM As Long
    Private vmejora As Double
    Private vcosto As Double
    Private vfecha_inicial As DateTime
    Private vfecha_final As DateTime
#End Region
#Region "Propiedades"

    Public Property cve_detalle_CDM() As Long
        Get
            Return vcve_detalle_CDM
        End Get
        Set(ByVal value As Long)
            vcve_detalle_CDM = value
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
    Public Property cve_CDM() As Long
        Get
            Return vcve_CDM
        End Get
        Set(ByVal value As Long)
            vcve_CDM = value
        End Set
    End Property
    Public Property mejora() As Double
        Get
            Return vmejora
        End Get
        Set(ByVal value As Double)
            vmejora = value
        End Set
    End Property
    Public Property costo() As Double
        Get
            Return vcosto
        End Get
        Set(ByVal value As Double)
            vcosto = value
        End Set
    End Property
    Public Property fecha_inicial() As DateTime
        Get
            Return vfecha_inicial
        End Get
        Set(ByVal value As DateTime)
            vfecha_inicial = value
        End Set
    End Property
    Public Property fecha_final() As DateTime
        Get
            Return vfecha_final
        End Get
        Set(ByVal value As DateTime)
            vfecha_final = value
        End Set
    End Property







#End Region
End Class
