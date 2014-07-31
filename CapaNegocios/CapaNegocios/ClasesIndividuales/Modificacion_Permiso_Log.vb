Imports CapaDatos
Public Class Modificacion_Permiso_Log
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from modificacion_permiso_log mpl where mpl.cve_modificacion_permiso_log=" & vcve_modificacion_permiso_log, "modificacion_permiso")
        If vDR IsNot Nothing Then
            vcve_modificacion_permiso_log = vDR("cve_modificacion_permiso_log")
            vcve_equipo = vDR("cve_equipo")
            vmaquina = vDR("maquina")
            vmaquina_usuario = vDR("maquina_usuario")
            vcod_empleado = vDR("cod_empleado")
            vdia_modificacion = vDR("dia_modificacion")
            vfecha_captura = vDR("fecha_captura")
            vdescripcion = vDR("descripcion")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Dim queryInsert As String = "delete modificacion_permiso_log" &
            " where cve_modificacion_permiso_log=" & vcve_modificacion_permiso_log
        Try
            oBD.EjecutarQuery(queryInsert)
            MsgBox("Se eliminó correctamente", vbInformation + vbOKOnly, "Log Permiso Modificación de Captura")
        Catch ex As Exception
            MsgBox("Problema al eliminar Log Modificacion Permiso. CModificacion_Permiso_Log_ERROR", vbExclamation + vbOKOnly, "Problema")
        End Try
    End Sub
    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_modificacion_permiso_log
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso_log = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into modificacion_permiso_log" &
            " values(" & vcve_equipo & ",'" & vmaquina & "','" & vmaquina_usuario & "','" & vcod_empleado & "','" & vdia_modificacion.ToString("MM-dd-yyyy HH:mm") & "','" & vfecha_captura.ToString("MM-dd-yyyy HH:mm") & "','" & vdescripcion & "')"
        Try
            oBD.EjecutarQuery(queryInsert)
            MsgBox("Se registro correctamente", vbInformation + vbOKOnly, "Log Permiso Modificación de Captura")
        Catch ex As Exception
            MsgBox("Problema al Registrar Log Permiso Modificacion. CModificacion_Permiso_Log_ERROR", vbExclamation + vbOKOnly, "Problema")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_registro_turno As Long
    Private vcve_modificacion_permiso_log As Long
    Private vcve_equipo As Long
    Private vmaquina As String
    Private vmaquina_usuario As String
    Private vcod_empleado As String
    Private vdia_modificacion As DateTime
    Private vfecha_captura As DateTime
    Private vdescripcion As String
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
    Public Property cve_modificacion_permiso_log() As Long
        Get
            Return vcve_modificacion_permiso_log
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso_log = value
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
    Public Property maquina() As String
        Get
            Return vmaquina
        End Get
        Set(ByVal value As String)
            vmaquina = value
        End Set
    End Property
    Public Property maquina_usuario() As String
        Get
            Return vmaquina_usuario
        End Get
        Set(ByVal value As String)
            vmaquina_usuario = value
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
    Public Property dia_modificacion() As DateTime
        Get
            Return vdia_modificacion
        End Get
        Set(ByVal value As Date)
            vdia_modificacion = value
        End Set
    End Property
    Public Property fecha_captura() As DateTime
        Get
            Return vfecha_captura
        End Get
        Set(ByVal value As Date)
            vfecha_captura = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return vdescripcion
        End Get
        Set(ByVal value As String)
            vdescripcion = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function obtiene_registros_catalogo() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla("select mpl.cve_modificacion_permiso_log,e.equipo,mpl.maquina,mpl.maquina_usuario,mpl.cod_empleado,convert(varchar,  mpl.dia_modificacion, 103) as dia_modificacion,mpl.fecha_captura,mpl.descripcion" &
                                       " from modificacion_permiso_log mpl" &
                                       " join equipo e on mpl.cve_equipo=e.cve_equipo" &
                                       " order by mpl.fecha_captura desc")
            Catch
                MsgBox("Problema al Obtener Catalogo Log Permiso Modificacion. CModificacion_Permiso_Log_ERROR", vbExclamation + vbOKOnly, "Problema")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    'Valida antes de hacer un registro en modificacion_permiso
    Public Sub registra_modificacion_permiso_log()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "registra_modificacion_permiso_log"
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                cmd.Parameters.Add("@maquina", SqlDbType.VarChar).Value = Me.vmaquina
                cmd.Parameters.Add("@maquina_usuario", SqlDbType.VarChar).Value = Me.vmaquina_usuario
                cmd.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vcod_empleado
                cmd.Parameters.Add("@fecha_captura", SqlDbType.DateTime).Value = Me.vfecha_captura.ToString("dd-MM-yyyy HH:mm:ss")
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Me.vdescripcion
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                'vResponse = obj.Rows(0)(0)
                'Me.vcve_registro_turno = obj.Rows(0)(1)
                'Me.vcve_turno = obj.Rows(0)(2)
                scope.Complete()
                'If vResponse = "OK" Then
                '    Return True
                'Else
                '    Return False
                'End If
            Catch
                MsgBox("Problema al registrar Modificacion Permiso Log. CModificacion_Permiso_Log_ERROR", vbExclamation + vbOKOnly, "Problema")
            End Try
        End Using
    End Sub
#End Region

End Class
