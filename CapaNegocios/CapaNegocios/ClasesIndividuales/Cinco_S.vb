Imports CapaDatos
Public Class Cinco_S
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
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
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "Captura_cinco_S_Produccion"}
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                vComando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vfecha
                vComando.Parameters.Add("@mantto_autto", SqlDbType.Float).Value = Me.vmantto_autto
                vComando.Parameters.Add("@admon_visual", SqlDbType.Float).Value = Me.vadmon_visual
                vComando.Parameters.Add("@cincoS", SqlDbType.Float).Value = Me.vcincoS
                vComando.Parameters.Add("@promedio", SqlDbType.Float).Value = Me.vpromedio
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al insertar cinco_S. CCalidad_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_cinco_S As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado As String
    Private vfecha As DateTime
    Private vmantto_autto As Double
    Private vadmon_visual As Double
    Private vcincoS As Double
    Private vpromedio As Double
    'Auxiliares
    Private vbandera_cinco_S As Long

#End Region
#Region "Propiedades"
    Public Property cve_cinco_S() As Long
        Get
            Return vcve_cinco_S
        End Get
        Set(ByVal value As Long)
            vcve_cinco_S = value
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


    Public Property fecha() As DateTime
        Get
            Return vfecha
        End Get
        Set(ByVal value As DateTime)
            vfecha = value
        End Set
    End Property

    Public Property mantto_autto() As Double
        Get
            Return vmantto_autto
        End Get
        Set(ByVal value As Double)
            vmantto_autto = value
        End Set
    End Property
    Public Property admon_visual() As Double
        Get
            Return vadmon_visual
        End Get
        Set(ByVal value As Double)
            vadmon_visual = value
        End Set
    End Property
    Public Property cincoS() As Double
        Get
            Return vcincoS
        End Get
        Set(ByVal value As Double)
            vcincoS = value
        End Set
    End Property
    Public Property promedio() As Double
        Get
            Return vpromedio
        End Get
        Set(ByVal value As Double)
            vpromedio = value
        End Set
    End Property
    Public Property bandera_cinco_S() As Long
        Get
            Return vbandera_cinco_S
        End Get
        Set(ByVal value As Long)
            vbandera_cinco_S = value
        End Set
    End Property
#End Region

    Public Sub verifica_cinco_S()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "verifica_cinco_S"}
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vmantto_autto = obj.Rows(0)(0)
                Me.vadmon_visual = obj.Rows(0)(1)
                Me.vcincoS = obj.Rows(0)(2)
                Me.vpromedio = obj.Rows(0)(3)
                Me.vbandera_cinco_S = obj.Rows(0)(4)
                scope.Complete()
            Catch
                MsgBox("Error al obtener 5S. CCinco_S_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub

End Class
