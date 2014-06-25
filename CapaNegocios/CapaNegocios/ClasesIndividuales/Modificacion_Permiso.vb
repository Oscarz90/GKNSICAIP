Imports CapaDatos
Public Class Modificacion_Permiso
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from modificacion_permiso mp where mp.cve_modificacion_permiso=" & vcve_modificacion_permiso, "modificacion_permiso")
        If vDR IsNot Nothing Then
            vcve_modificacion_permiso = vDR("cve_modificacion_permiso")
            vcve_usuario = vDR("cve_usuario")
            vdia_modificacion = vDR("dia_modificacion")
            vfecha_inicio = vDR("fecha_inicio")
            vfecha_final = vDR("fecha_final")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Dim queryInsert As String = "delete modificacion_permiso" &
            " where cve_modificacion_permiso=" & vcve_modificacion_permiso
        Try
            oBD.EjecutarQuery(queryInsert)
            MsgBox("Se eliminó correctamente", vbInformation + vbOKOnly, "Permiso Modificación de Captura")
        Catch ex As Exception
            MsgBox("Problema al eliminar Modificacion Permiso. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
        End Try
    End Sub
    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_modificacion_permiso
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into modificacion_permiso " &
            "values (" & vcve_usuario & ",'" & vdia_modificacion.ToString("MM-dd-yyyy") & "','" & vfecha_inicio.ToString("MM-dd-yyyy HH:mm") & "','" & vfecha_final.ToString("MM-dd-yyyy HH:mm") & "')"
        Try
            oBD.EjecutarQuery(queryInsert)
            MsgBox("Se registro correctamente", vbInformation + vbOKOnly, "Permiso Modificación de Captura")
        Catch ex As Exception
            MsgBox("Problema al Registrar Permiso Modificacion. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_modificacion_permiso As Long
    Private vcve_usuario As Long
    Private vdia_modificacion As DateTime
    Private vfecha_inicio As DateTime
    Private vfecha_final As DateTime
    'Variables para catalogo de admon.
    Private vusuario As String
    Private voperacion As String
#End Region
#Region "Propiedades"
    Public Property cve_modificacion_permiso() As Long
        Get
            Return vcve_modificacion_permiso
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso = value
        End Set
    End Property
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
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
    Public Property fecha_inicio() As DateTime
        Get
            Return vfecha_inicio
        End Get
        Set(ByVal value As Date)
            vfecha_inicio = value
        End Set
    End Property
    Public Property fecha_final() As DateTime
        Get
            Return vfecha_final
        End Get
        Set(ByVal value As DateTime)
            vfecha_final = value
        End Set
    End Property
    Public Property usuario() As String
        Get
            Return vusuario
        End Get
        Set(ByVal value As String)
            vusuario = value
        End Set
    End Property
    Public Property operacion() As String
        Get
            Return voperacion
        End Get
        Set(ByVal value As String)
            voperacion = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function obtiene_registros_catalogo() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla("select mp.cve_modificacion_permiso,su.Id_Usuario,su.Nombre,mp.dia_modificacion,mp.fecha_inicio,mp.fecha_final" &
                                 " from modificacion_permiso mp" &
                                 " join seguridad_usuario su on mp.cve_usuario=su.CVE_Usuario" &
                                 " order by mp.dia_modificacion desc")
            Catch
                MsgBox("Problema al Obtener Catalogo Permiso Modificacion. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function valida_registro_modificacion_permiso() As Boolean
        Dim vResponse As String
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "valida_registro_modificacion_permiso"
                cmd.Parameters.Add("@cve_modificacion_permiso", SqlDbType.BigInt).Value = Me.vcve_modificacion_permiso
                cmd.Parameters.Add("@cve_usuario", SqlDbType.BigInt).Value = Me.vcve_usuario
                cmd.Parameters.Add("@fecha_modificacion", SqlDbType.DateTime).Value = Me.vdia_modificacion
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = Me.vfecha_inicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                cmd.Parameters.Add("@operacion", SqlDbType.VarChar).Value = Me.voperacion
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                vResponse = obj.Rows(0)(0)
                'Me.vcve_registro_turno = obj.Rows(0)(1)
                'Me.vcve_turno = obj.Rows(0)(2)
                scope.Complete()
                If vResponse = "OK" Then
                    Return True
                Else
                    Return False
                End If
            Catch
                MsgBox("Problema al validar Modificacion Permiso. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
                Return False
            End Try
        End Using
    End Function
    Public Sub actualizar_registro()
        Dim queryInsert As String = "UPDATE modificacion_permiso  SET" &
            " cve_usuario=" & vcve_usuario & "," &
            " dia_modificacion='" & vdia_modificacion.ToString("MM-dd-yyyy") & "'," &
            " fecha_inicio='" & vfecha_inicio.ToString("MM-dd-yyyy HH:mm") & "'," &
            " fecha_final ='" & vfecha_final.ToString("MM-dd-yyyy HH:mm") & "' " &
            " WHERE cve_modificacion_permiso =" & vcve_modificacion_permiso
        Try
            oBD.EjecutarQuery(queryInsert)
            MsgBox("Se actualizó correctamente", vbInformation + vbOKOnly, "Permiso Modificación de Captura")
        Catch ex As Exception
            MsgBox("Problema al actualizar Modificacion Permiso. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
        End Try
    End Sub
#End Region

End Class
