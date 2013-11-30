Imports CapaDatos
Public Class Seguridad
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("update seguridad set cod_empleado_eliminacion='" & vcod_empleado_eliminacion & "',fecha_eliminacion='" & vfecha_eliminacion.ToString("MM-dd-yyyy HH:mm") & "',estatus='0' where cve_seguridad=" & vcve_seguridad)
        Catch ex As Exception
            MsgBox("Error al eliminar seguridad. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_seguridad = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        'meter codigo aqui
        Return vcve_seguridad
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into seguridad(cve_registro_turno,cod_empleado_registro,fecha_registro,cve_detalle_seguridad,cantidad,comentarios,estatus) " &
                            "values(" & vcve_registro_turno & ",'" & vcod_empleado_registro & "','" & vfecha_registro.ToString("MM-dd-yyyy HH:mm") & "'," & vcve_detalle_seguridad & "," & vcantidad & ",'" & vcomentarios & "','1')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al insertar Seguridad. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_seguridad As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As DateTime
    Private vcve_detalle_seguridad As Long
    Private vcantidad As Long
    Private vcomentarios As String
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As DateTime
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_seguridad() As Long
        Get
            Return vcve_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_seguridad = value
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
    Public Property cod_empleado_registro() As String
        Get
            Return vcod_empleado_registro
        End Get
        Set(ByVal value As String)
            vcod_empleado_registro = value
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
    Public Property cve_detalle_seguridad() As Long
        Get
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad = value
        End Set
    End Property
    Public Property cantidad() As Long
        Get
            Return vcantidad
        End Get
        Set(ByVal value As Long)
            vcantidad = value
        End Set
    End Property
    Public Property comentarios() As String
        Get
            Return vcomentarios
        End Get
        Set(ByVal value As String)
            vcomentarios = value
        End Set
    End Property
    Public Property cod_empleado_eliminacion() As String
        Get
            Return vcod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vcod_empleado_eliminacion = value
        End Set
    End Property
    Public Property fecha_eliminacion() As DateTime
        Get
            Return vfecha_eliminacion
        End Get
        Set(ByVal value As DateTime)
            vfecha_eliminacion = value
        End Set
    End Property
    Public Property estatus() As String
        Get
            Return vestatus
        End Get
        Set(ByVal value As String)
            vestatus = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_cond_inseg_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select s.cve_seguridad,ds.descripcion,s.cantidad,s.comentarios from seguridad s " &
            "join detalle_seguridad ds on s.cve_detalle_seguridad=ds.cve_detalle_seguridad " &
            "where ds.tipo=0 and s.cve_registro_turno=" & vcve_registro_turno & " and s.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de seguridad-condiciones inseguras. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function llena_accidentes_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select s.cve_seguridad,ds.descripcion,s.cantidad,s.comentarios from seguridad s " &
            "join detalle_seguridad ds on s.cve_detalle_seguridad=ds.cve_detalle_seguridad " &
            "where ds.tipo=1 and s.cve_registro_turno=" & vcve_registro_turno & " and s.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de seguridad-Accidentes. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    ''Obtener el acumulado del dia anterior para seguridad
    Public Function obtener_acum_dia_anterior(ByVal fecha_puntero As DateTime, ByVal cve_equipo As Integer, ByVal cve_linea As Integer) As Integer
        Dim Adeudo_dia_anterior As Integer
        Dim vDR As DataRow = Nothing
        Using scope As New TransactionScope
            Try
                vDR = oBD.ObtenerRenglon("select top 1 (cve_equipo), dia_asignado, acumulado from h_seguridad_equipo_linea_dia where dia_asignado < '" & fecha_puntero.ToString("MM/dd/yyyy") & "' and cve_equipo=" & cve_equipo & " and cve_linea=" & cve_linea & " order by dia_asignado DESC", "seguridad")

                If vDR IsNot Nothing Then
                    If vDR("acumulado") IsNot DBNull.Value Then
                        Adeudo_dia_anterior = vDR("acumulado")
                    End If
                End If

            Catch ex As Exception
                MsgBox("Error al validar obtener_acum_dia_anterior. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
            Return Adeudo_dia_anterior
        End Using
    End Function
    ''Obtener las condiciones inseguras nuevas en seguridad    
    Public Function obtener_nuevas_seguridad(ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vFecha As DateTime) As Integer
        Dim nuevas As Integer
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("select sum(s.cantidad) as cantidad " & _
                                        " from registro_turno rt join seguridad s on rt.cve_registro_turno=s.cve_registro_turno " & _
                                        " where s.estatus='1' and s.cve_detalle_seguridad=1 and rt.cve_equipo=" & vCve_Equipo & " and rt.cve_linea=" & vCve_Linea & "" & _
                                        " and rt.dia_asignado='" & vFecha.ToString("MM/dd/yyyy") & "'", "seguridad")
            If rDatos IsNot Nothing Then
                If rDatos("cantidad") IsNot DBNull.Value Then
                    nuevas = rDatos("cantidad")
                Else
                    nuevas = 0
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al obtener nuevas en seguridad. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
        Return nuevas
    End Function
    ''Obtener las condiciones inseguras resueltas en seguridad    
    Public Function obtener_resueltas_seguridad(ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vFecha As DateTime) As Integer
        Dim resueltas As Integer
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("select sum(s.cantidad) as cantidad " & _
                                        "from registro_turno rt join seguridad s on rt.cve_registro_turno=s.cve_registro_turno " & _
                                        " where s.estatus='1' and s.cve_detalle_seguridad=2 and rt.cve_equipo=" & vCve_Equipo & "and rt.cve_linea= " & vCve_Linea & " " & _
                                        " and rt.dia_asignado='" & vFecha.ToString("MM/dd/yyyy") & "'", "seguridad")
            If rDatos IsNot Nothing Then
                If rDatos("cantidad") IsNot DBNull.Value Then
                    resueltas = rDatos("cantidad")
                Else
                    resueltas = 0
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al obtener resueltas en seguridad. CTurno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
        Return resueltas
    End Function
#End Region
End Class
