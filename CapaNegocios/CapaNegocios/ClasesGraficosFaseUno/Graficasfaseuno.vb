Imports CapaDatos
Public Class Graficasfaseuno
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "Propiedades"
    Private vusuario As String
    Public Property usuario() As String
        Get
            Return vusuario
        End Get
        Set(ByVal value As String)
            vusuario = value
        End Set
    End Property
    Private vcod_empleado As String
    Public Property cod_empleado() As String
        Get
            Return vcod_empleado
        End Get
        Set(ByVal value As String)
            vcod_empleado = value
        End Set
    End Property
    Private vnivel_grafico As String
    Public Property nivel_grafico() As String
        Get
            Return vnivel_grafico
        End Get
        Set(ByVal value As String)
            vnivel_grafico = value
        End Set
    End Property
    Private vcve_usuario As Long
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property
#End Region
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
    End Sub
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return 1
        End Get
        Set(ByVal value As Long)
            value = 1
        End Set
    End Property
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function
    Public Sub Registrar() Implements IIndividual.Registrar
    End Sub
#End Region
#Region "Metodos Graficos Fase Uno"
    Public Sub obtiene_nivel_graficos()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "obtiene_nivel_graficos_usuario"}
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Me.vusuario
                cmd.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vnivel_grafico = obj.Rows(0)(0)
                If obj.Rows(0)(1) IsNot Nothing Then
                    Me.vcve_usuario = obj.Rows(0)(1)
                Else
                    Me.vcve_usuario = 0
                End If
                scope.Complete()
            Catch
                MsgBox("Error al validar nive_grafico. CGraficasfaseuno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
End Class