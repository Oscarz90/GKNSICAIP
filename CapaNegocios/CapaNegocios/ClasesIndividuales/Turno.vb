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
    Private vinicio As DateTime
    Private vfin As DateTime
    'auxiliar
    Private vfecha_registro As DateTime
    Private vbandera_registro As Integer
    Private vcve_registro_turno As Long
   

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

    Public Property inicio() As DateTime
        Get
            Return vinicio
        End Get
        Set(ByVal value As DateTime)
            vinicio = value
        End Set
    End Property

    Public Property fin() As DateTime
        Get
            Return vfin
        End Get
        Set(ByVal value As DateTime)
            vfin = value
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

    Public Property bandera_registro() As Integer
        Get
            Return vbandera_registro
        End Get
        Set(ByVal value As Integer)
            vbandera_registro = value
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
            rDatos = oBD.ObtenerRenglon("select * from fecha_inicio_fin (" & vcve_turno & ",'" & vfecha_registro.ToString("MM-dd-yyyy HH:mm:ss") & "');", "turno")
            If rDatos IsNot Nothing Then
                If rDatos("inicio") IsNot DBNull.Value Then
                    Me.vinicio = rDatos("inicio")
                    Me.vfin = rDatos("fin")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al obtener inicio_fin. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
    Public Sub valida_inicio_fin()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "valida_inicio_fin"
                cmd.Parameters.Add("@turno", SqlDbType.BigInt).Value = Me.vcve_turno
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vfecha_registro.ToString("yyyy-MM-dd HH:mm")
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                'Me.vinicio = obj.Rows(0)(0)
                Me.vbandera_registro = obj.Rows(0)(0)
                Me.vinicio = obj.Rows(0)(1)
                Me.vfin = obj.Rows(0)(2)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al validar inicio_fin. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
    Public Sub valida_inicio_fin_produccion()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "valida_inicio_fin_produccion"
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno  
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vinicio = obj.Rows(0)(0)
                Me.vfin = obj.Rows(0)(1)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al validar valida_inicio_fin_produccion. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub

End Class
