Imports CapaDatos
Public Class Calidad
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
                vComando.CommandText = "Captura_Calidad_Produccion"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                vComando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vfecha
                vComando.Parameters.Add("@pzas_ok", SqlDbType.BigInt).Value = Me.vpzas_ok
                vComando.Parameters.Add("@pzas_desecho", SqlDbType.Int).Value = Me.vpzas_desecho
                vComando.Parameters.Add("@nrfti", SqlDbType.Int).Value = Me.vnrfti
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al insertar calidad. CCalidad_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_calidad As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado As String
    Private vfecha As DateTime
    Private vpzas_ok As Long
    Private vpzas_desecho As Long
    Private vnrfti As Double
#End Region
#Region "Propiedades"
    Public Property cve_calidad() As Long
        Get
            Return vcve_calidad
        End Get
        Set(ByVal value As Long)
            vcve_calidad = value
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
    Public Property pzas_ok() As Long
        Get
            Return vpzas_ok
        End Get
        Set(ByVal value As Long)
            vpzas_ok = value
        End Set
    End Property
    Public Property pzas_desecho() As Long
        Get
            Return vpzas_desecho
        End Get
        Set(ByVal value As Long)
            vpzas_desecho = value
        End Set
    End Property
    Public Property nrfti() As Double
        Get
            Return vnrfti
        End Get
        Set(ByVal value As Double)
            vnrfti = value
        End Set
    End Property
#End Region

End Class
