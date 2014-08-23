Imports CapaDatos
Public Class Seguridad
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery(String.Format("update seguridad set cod_empleado_eliminacion='{0}',fecha_eliminacion='{1:MM-dd-yyyy HH:mm}',estatus='0' where cve_seguridad={2}", vcod_empleado_eliminacion, vfecha_eliminacion, vcve_seguridad))
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


    Private vAcumulado_Retorno As Integer
    Public Property Acumulado_Retorno() As Integer
        Get
            Return vAcumulado_Retorno
        End Get
        Set(ByVal value As Integer)
            vAcumulado_Retorno = value
        End Set
    End Property

    Private vCve_Seguridad_Acumulado As Long
    Public Property Cve_Seguridad_Acumulado() As Long
        Get
            Return vCve_Seguridad_Acumulado
        End Get
        Set(ByVal value As Long)
            vCve_Seguridad_Acumulado = value
        End Set
    End Property


    Private vAcumulado_Final As Integer
    Public Property Acumulado_Final() As Integer
        Get
            Return vAcumulado_Final
        End Get
        Set(ByVal value As Integer)
            vAcumulado_Final = value
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
                vDR = oBD.ObtenerRenglon(String.Format("select top 1 (cve_equipo), dia_asignado, acumulado from h_seguridad_equipo_linea_dia where dia_asignado < '{0:MM/dd/yyyy}' and cve_equipo={1} and cve_linea={2} order by dia_asignado DESC", fecha_puntero, cve_equipo, cve_linea), "seguridad")

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



#Region "Validacion Captura de Nuevas y Resueltas"

    Public Function Validacion_Exitosa_Condicion_Agregar(ByVal vAcum_Anterior As Integer, ByVal vNuevas_Actuales As Integer, ByVal vResueltas_Actuales As Integer, ByVal vCant_Condicion_Agregar As Integer, ByVal vEsNueva As Boolean) As Boolean
        'Dim vAcumulado_Final As Integer = 0

        If vEsNueva = True Then
            vNuevas_Actuales = vNuevas_Actuales + vCant_Condicion_Agregar
        Else
            vResueltas_Actuales = vResueltas_Actuales + vCant_Condicion_Agregar
        End If

        vAcumulado_Final = vAcum_Anterior + vNuevas_Actuales - vResueltas_Actuales

        If vAcumulado_Final < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Valida que exista un registro en la tabla Seguridad_Acumulado, NOTA: Si Existe_Registro then Retorna TRUE and GUARDA Acumulado_Retorno=Acumulado, Cve_Seguridad_Acumulado= identity
    ''' </summary>
    ''' <param name="vFecha"></param>
    ''' <param name="vCve_Equipo"></param>
    ''' <param name="vCve_Linea"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Existe_Registro_Actual_Acumulado(ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long) As Boolean
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select acumulado, cve_seguridad_acumulado from seguridad_acumulado where cve_equipo = {0} and cve_linea= {1} and fecha= '{2}'", vCve_Equipo, vCve_Linea, vFecha), "Seguridad_Acumulado")

            If vDR IsNot Nothing Then
                vAcumulado_Retorno = vDR("acumulado")
                vCve_Seguridad_Acumulado = vDR("cve_seguridad_acumulado")
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
            MsgBox("Lo sentimos, no existe registro")
        End Try
    End Function

    Public Sub Agregar_Seguridad_Acumulado(ByVal vIdentity As Long, ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long, ByVal vValor_Acumulado As Integer)
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_SEGURIDAD_ACUMULADO"}
                With cmd.Parameters
                    .Add("cve_seguridad_acumulado", SqlDbType.BigInt).Value = vIdentity
                    .Add("cve_equipo", SqlDbType.BigInt).Value = vCve_Equipo
                    .Add("cve_linea", SqlDbType.BigInt).Value = vCve_Linea
                    .Add("fecha", SqlDbType.DateTime).Value = vFecha
                    .Add("acumulado", SqlDbType.Int).Value = vValor_Acumulado
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                'Me.vcve_linea = obj.Rows(0)(0) 'ID               
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub


    Public Function Obtener_Acumulado_Anterior(ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long) As Integer
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select top 1 (fecha) as fecha, acumulado from seguridad_acumulado where cve_equipo = " & vCve_Equipo & " and cve_linea= " & vCve_Linea & " and fecha< '" & vFecha & "' order by fecha desc"), "Seguridad_Acumulado")

            If vDR IsNot Nothing Then             
                Return vDR("acumulado")
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox("Lo sentimos, no existe registro acumulado anterior")
        End Try
    End Function


#End Region




#End Region
End Class
