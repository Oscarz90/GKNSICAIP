Imports CapaDatos
Public Class Maquina
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM maquina WHERE cve_maquina=" & vcve_maquina, "turno")
            If rDatos IsNot Nothing Then
                If rDatos("cve_maquina") IsNot DBNull.Value Then
                    Me.vcve_maquina = rDatos("cve_maquina")
                    Me.vcve_linea = rDatos("cve_linea")
                    Me.vclave_maquina = rDatos("clave_maquina")
                    Me.vmaquina = rDatos("maquina")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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
#Region "Metodos formulario de produccion"
    Public Function llena_combo_maquina() As DataTable
        Dim dtMaquina As New DataTable
        Try
            dtMaquina = oBD.ObtenerTabla("	select m.cve_maquina,m.clave_maquina from maquina m where m.cve_linea=" & vcve_linea)
        Catch ex As Exception
            MsgBox("Error al obtener Maquinas. CMaquina_ERROR", vbCritical + vbOKOnly, "Error")
            dtMaquina = Nothing
        End Try
        Return dtMaquina
    End Function
#End Region
End Class
