Imports CapaDatos
Public Class Desecho
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

    End Sub
#End Region
#Region "Atributos"
    Private vcve_desecho As Long
    Private vcve_registro_turno As Long
    Private cod_empleado As String
    Private vcantidad As Long
#End Region
#Region "Propiedades"
    Public Property cve_desecho() As Long
        Get
            Return vcve_desecho
        End Get
        Set(ByVal value As Long)
            vcve_desecho = value
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
    Public Property vcod_empleado() As String
        Get
            Return cod_empleado
        End Get
        Set(ByVal value As String)
            cod_empleado = value
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
#End Region
#Region "Metodos formulario de produccion"

#End Region
End Class
