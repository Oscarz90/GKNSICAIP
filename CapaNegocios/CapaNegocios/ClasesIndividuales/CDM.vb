Imports CapaDatos
Public Class CDM
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
    Private vcve_CDM As Long
    Private vcve_modelo_inicial As Long
    Private vcve_modelo_final As Long
    Private vcve_linea As Long
    Private vtiempo As Long

#End Region
#Region "Propiedades"
    Public Property cve_CDM() As Long
        Get
            Return vcve_CDM
        End Get
        Set(ByVal value As Long)
            vcve_CDM = value
        End Set
    End Property
    Public Property cve_modelo_inicial() As Long
        Get
            Return vcve_modelo_inicial
        End Get
        Set(ByVal value As Long)
            vcve_modelo_inicial = value
        End Set
    End Property
    Public Property cve_modelo_final() As Long
        Get
            Return vcve_modelo_final
        End Get
        Set(ByVal value As Long)
            vcve_modelo_final = value
        End Set
    End Property
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property tiempo() As Long
        Get
            Return vtiempo
        End Get
        Set(ByVal value As Long)
            vtiempo = value
        End Set
    End Property
#End Region
End Class
