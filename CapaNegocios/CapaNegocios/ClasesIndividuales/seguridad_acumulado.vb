Imports CapaDatos
Public Class seguridad_acumulado
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
    Public vErrorRegistro As Boolean = False

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from seguridad_acumulado where cve_seguridad_acumulado= " & vcve_seguridad_acumulado)
        Catch ex As Exception
            MsgBox("Error al eliminar seguridad. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_seguridad_acumulado
        End Get
        Set(ByVal value As Long)
            vcve_seguridad_acumulado = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_seguridad_acumulado
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_SEGURIDAD_ACUMULADO"}
                cmd.Parameters.Add("@cve_seguridad_acumulado", SqlDbType.BigInt).Value = Me.vcve_seguridad_acumulado
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vCve_equipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vCve_linea
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vFecha
                cmd.Parameters.Add("@acumulado", SqlDbType.BigInt).Value = Me.vAcumulado

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_seguridad_acumulado = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
                vErrorRegistro = True
            End Try
        End Using

    End Sub
#End Region

#Region "Atributos"
    Private vcve_seguridad_acumulado As Long
    Private vCve_equipo As Long
    Private vCve_linea As Long
    Private vFecha As DateTime
    Private vAcumulado As Long
#End Region

#Region "Propiedades"

    Public Property cve_seguridad_acumulado() As Long
        Get
            Return vcve_seguridad_acumulado
        End Get
        Set(ByVal value As Long)
            vcve_seguridad_acumulado = value
        End Set
    End Property

    Public Property cve_equipo() As Long
        Get
            Return vCve_equipo
        End Get
        Set(ByVal value As Long)
            vCve_equipo = value
        End Set
    End Property

    Public Property cve_linea() As Long
        Get
            Return vCve_linea
        End Get
        Set(ByVal value As Long)
            vCve_linea = value
        End Set
    End Property

    Public Property fecha() As DateTime
        Get
            Return vFecha
        End Get
        Set(ByVal value As DateTime)
            vFecha = value
        End Set
    End Property

    Public Property acumulado() As Long
        Get
            Return vAcumulado
        End Get
        Set(ByVal value As Long)
            vAcumulado = value
        End Set
    End Property

#End Region

#Region "Validación eliminar nuevas o resueltas"
    ''Parte para el boton quitar (nuevas o resueltas)

#End Region

End Class
