Imports CapaDatos
Public Class Registro_Turno
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from registro_turno where cve_registro_turno = " & vcve_registro_turno, "registro_turno")
        If vDR IsNot Nothing Then
            vcve_registro_turno = vDR("cve_registro_turno")
            vcve_equipo = vDR("cve_equipo")
            vcve_linea = vDR("cve_linea")
            vcve_turno = vDR("cve_turno")
            vdia_asignado = vDR("dia_asignado")
            vadeudo = vDR("adeudo")
        End If
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
    Private vcve_registro_turno As Long
    Private vcve_equipo As Long
    Private vcve_linea As Long
    Private vcve_turno As Long
    Private vdia_asignado As String
    Private vadeudo As Long
#End Region
#Region "Propiedades"
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
        End Set
    End Property
    Public Property cve_equipo() As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
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
    Public Property cve_turno() As Long
        Get
            Return vcve_turno
        End Get
        Set(ByVal value As Long)
            vcve_turno = value
        End Set
    End Property
    Public Property dia_asignado() As String
        Get
            Return vdia_asignado
        End Get
        Set(ByVal value As String)
            vdia_asignado = value
        End Set
    End Property
    Public Property adeudo() As Long
        Get
            Return vadeudo
        End Get
        Set(ByVal value As Long)
            vadeudo = value
        End Set
    End Property
#End Region
End Class
