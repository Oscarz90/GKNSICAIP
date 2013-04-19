Imports CapaDatos
Public Class Registro_Paro
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from registro_paro where cve_registro_paro = " & vCve_registro_paro, "registro_paro")
        If vDR IsNot Nothing Then
            vCve_registro_paro = vDR("cve_registro_paro")
            vCve_registro_turno = vDR("cve_registro_turno")
            vCod_empleado_registro = vDR("cod_empleado_registro")
            vFecha_registro = vDR("fecha_registro")
            vCve_paro = vDR("cve_paro")
            vCve_maquina = vDR("cve_maquina")
            vMinutos = vDR("minutos")
            vDetalles = vDR("detalles")
            vCod_empleado_eliminacion = vDR("cod_empleado_eliminacion")
            vFecha_eliminacion = vDR("fecha_eliminacion")
            vEstatus = vDR("estatus")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from registro_paro where cve_registro_paro = " & vCve_registro_paro)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("select cve_registro_paro from registro_paro where cve_registro_turno = " & vCadena, "registro_paro")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_registro_paro")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_Registro_paro"
                cmd.Parameters.Add("@cve_registro_paro", SqlDbType.BigInt).Value = Me.vCve_registro_paro
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vCve_registro_turno
                cmd.Parameters.Add("@cod_empleado_registro", SqlDbType.VarChar).Value = Me.vCod_empleado_registro
                cmd.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Me.vFecha_registro
                cmd.Parameters.Add("@cve_paro", SqlDbType.BigInt).Value = Me.vCve_paro
                cmd.Parameters.Add("@cve_maquina", SqlDbType.BigInt).Value = Me.vCve_maquina
                cmd.Parameters.Add("@minutos", SqlDbType.Int).Value = Me.vMinutos
                cmd.Parameters.Add("@detalles", SqlDbType.VarChar).Value = Me.vDetalles
                cmd.Parameters.Add("@cod_empleado_eliminacion", SqlDbType.VarChar).Value = Me.vCod_empleado_eliminacion
                cmd.Parameters.Add("@fecha_eliminacion", SqlDbType.DateTime).Value = Me.vFecha_eliminacion
                cmd.Parameters.Add("@estatus", SqlDbType.VarChar).Value = Me.vEstatus

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_registro_paro = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
            End Try
        End Using
    End Sub
#End Region

#Region "Atributos"
    Private vCve_registro_paro As Long
    Private vCve_registro_turno As Long
    Private vCod_empleado_registro As String
    Private vFecha_registro As DateTime
    Private vCve_paro As Long
    Private vCve_maquina As Long
    Private vMinutos As Long
    Private vDetalles As String
    Private vCod_empleado_eliminacion As String
    Private vFecha_eliminacion As DateTime
    Private vEstatus As String

#End Region

#Region "Propiedades"

    Public Property Cve_registro_paro As Long Implements IIndividual.Id
        Get
            Return vCve_registro_paro
        End Get
        Set(ByVal value As Long)
            vCve_registro_paro = value
        End Set
    End Property

    Public Property Cve_registro_turno() As Long
        Get
            Return vCve_registro_turno
        End Get
        Set(ByVal value As Long)
            vCve_registro_turno = value
        End Set
    End Property

    Public Property Cod_empleado_registro() As String
        Get
            Return vCod_empleado_registro
        End Get
        Set(ByVal value As String)
            vCod_empleado_registro = value
        End Set
    End Property

    Public Property Fecha_registro() As DateTime
        Get
            Return vFecha_registro
        End Get
        Set(ByVal value As DateTime)
            vFecha_registro = value
        End Set
    End Property

    Public Property Cve_paro() As Long
        Get
            Return vCve_paro
        End Get
        Set(ByVal value As Long)
            vCve_paro = value
        End Set
    End Property

    Public Property Cve_maquina() As Long
        Get
            Return vCve_maquina
        End Get
        Set(ByVal value As Long)
            vCve_maquina = value
        End Set
    End Property


    Public Property Minutos() As Long
        Get
            Return vMinutos
        End Get
        Set(ByVal value As Long)
            vMinutos = value
        End Set
    End Property


    Public Property Detalles() As String
        Get
            Return vDetalles
        End Get
        Set(ByVal value As String)
            vDetalles = value
        End Set
    End Property

    
    Public Property Cod_empleado_eliminacion() As String
        Get
            Return vCod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vCod_empleado_eliminacion = value
        End Set
    End Property


    Public Property Fecha_eliminacion() As DateTime
        Get
            Return vFecha_eliminacion
        End Get
        Set(ByVal value As DateTime)
            vFecha_eliminacion = value
        End Set
    End Property


    Public Property Estatus() As String
        Get
            Return vEstatus
        End Get
        Set(ByVal value As String)
            vEstatus = value
        End Set
    End Property

#End Region

End Class
