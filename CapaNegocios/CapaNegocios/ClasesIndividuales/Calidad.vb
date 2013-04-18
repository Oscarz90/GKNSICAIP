Imports CapaDatos
Public Class Calidad
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
    Private vcve_calidad As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado As String
    Private vpzas_ok As Long
    Private vpzas_desecho As Long
    Private vnrfti As Double
#End Region
#Region "Propiedades"
    Public Property cve_calidad() As Long
        Get
            Return vcve_calidad
        End Get
        Set(ByVal value As Long)
            vcve_calidad = value
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
    Public Property pzas_ok() As Long
        Get
            Return vpzas_ok
        End Get
        Set(ByVal value As Long)
            vpzas_ok = value
        End Set
    End Property
    Public Property pzas_desecho() As Long
        Get
            Return vpzas_desecho
        End Get
        Set(ByVal value As Long)
            vpzas_desecho = value
        End Set
    End Property
    Public Property nrfti() As Double
        Get
            Return vnrfti
        End Get
        Set(ByVal value As Double)
            vnrfti = value
        End Set
    End Property



#End Region

End Class
