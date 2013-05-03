Imports CapaDatos
Public Class Turno
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM turno WHERE cve_turno=" & vcve_turno, "turno")
            If rDatos IsNot Nothing Then
                If rDatos("cve_turno") IsNot DBNull.Value Then
                    Me.vcve_turno = rDatos("cve_turno")
                    Me.vminutos = rDatos("minutos")
                    Me.vcomedor = rDatos("comedor")
                    Me.vturno = rDatos("turno")
                    Me.vinicio = rDatos("inicio")
                    Me.vfin = rDatos("fin")
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
    Private vcve_turno As Long
    Private vminutos As Long
    Private vcomedor As Long
    Private vturno As String
    Private vinicio As String
    Private vfin As String
    'auxiliar
    Private vfecha_registro As String
#End Region
#Region "Propiedades"
    Public Property cve_turno() As Long
        Get
            Return vcve_turno
        End Get
        Set(ByVal value As Long)
            vcve_turno = value
        End Set
    End Property

    Public Property minutos() As Long
        Get
            Return vminutos
        End Get
        Set(ByVal value As Long)
            vminutos = value
        End Set
    End Property

    Public Property comedor() As Long
        Get
            Return vcomedor
        End Get
        Set(ByVal value As Long)
            vcomedor = value
        End Set
    End Property

    Public Property turno() As String
        Get
            Return vturno
        End Get
        Set(ByVal value As String)
            vturno = value
        End Set
    End Property

    Public Property inicio() As String
        Get
            Return vinicio
        End Get
        Set(ByVal value As String)
            vinicio = value
        End Set
    End Property

    Public Property fin() As String
        Get
            Return vfin
        End Get
        Set(ByVal value As String)
            vfin = value
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

#End Region

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_turnos() As DataTable
        Dim dtTurnos As New DataTable
        Try
            dtTurnos = oBD.ObtenerTabla("Select cve_turno,turno from turno")
        Catch ex As Exception
            MsgBox("Error al obtener turnos. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
            dtTurnos = Nothing
        End Try
        Return dtTurnos
    End Function
#End Region
    Public Sub fecha_inicio_fin()
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("select * from fecha_inicio_fin (" & vcve_turno & ",'" & vfecha_registro & "');", "turno")
            If rDatos IsNot Nothing Then
                If rDatos("inicio") IsNot DBNull.Value Then
                    Me.vinicio = rDatos("inicio")
                    Me.vfin = rDatos("fin")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Class
