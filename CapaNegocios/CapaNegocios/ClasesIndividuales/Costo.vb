Imports CapaDatos
Public Class Costo
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
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "Captura_costo_Produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                vComando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.fecha
                vComando.Parameters.Add("@min_programados", SqlDbType.Float).Value = Me.vmin_programados
                vComando.Parameters.Add("@min_reales", SqlDbType.Float).Value = Me.vmin_reales
                vComando.Parameters.Add("@precio", SqlDbType.Float).Value = Me.vprecio
                vComando.Parameters.Add("@costo", SqlDbType.Float).Value = Me.vcosto
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al registrar costo. CCalidad_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_costo As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado As String
    Private vfecha As DateTime
    Private vmin_programados As Long
    Private vmin_reales As Long
    Private vprecio As Double
    Private vcosto As Double
#End Region
#Region "Propiedades"
    Public Property cve_costo() As Long
        Get
            Return vcve_costo
        End Get
        Set(ByVal value As Long)
            vcve_costo = value
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

    Public Property min_programados() As Long
        Get
            Return vmin_programados
        End Get
        Set(ByVal value As Long)
            vmin_programados = value
        End Set
    End Property
    Public Property min_reales() As Long
        Get
            Return vmin_reales
        End Get
        Set(ByVal value As Long)
            vmin_reales = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return vprecio
        End Get
        Set(ByVal value As Double)
            vprecio = value
        End Set
    End Property
    Public Property costo() As Double
        Get
            Return vcosto
        End Get
        Set(ByVal value As Double)
            vcosto = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Sub verifica_costo_produccion()
        Using scope As New TransactionScope

            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "verifica_costo_produccion"
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vmin_programados = obj.Rows(0)(0)
                Me.vmin_reales = obj.Rows(0)(1)
                Me.vprecio = obj.Rows(0)(2)
                Me.vcosto = obj.Rows(0)(3)
                scope.Complete()
            Catch
                MsgBox("Error al validar verifica_costo_produccion. CCosto_ERROR1", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
End Class
