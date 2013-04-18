Imports CapaDatos
Public Class Maquina
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
    Private vcve_maquina As Long
    Private vcve_linea As Long
    Private vmaquina As String
    Private vclave_maquina As String
#End Region
#Region "Propiedades"
    Public Property cve_maquina() As Long
        Get
            Return vcve_maquina
        End Get
        Set(ByVal value As Long)
            vcve_maquina = value
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
    Public Property clave_maquina() As String
        Get
            Return vclave_maquina
        End Get
        Set(ByVal value As String)
            vclave_maquina = value
        End Set
    End Property
    Public Property maquina() As String
        Get
            Return vmaquina
        End Get
        Set(ByVal value As String)
            vmaquina = value
        End Set
    End Property


#End Region
End Class
