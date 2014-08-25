Imports CapaDatos
Public Class Registro_Turno
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from registro_turno where cve_registro_turno = " & vcve_registro_turno, "registro_turno")
        If vDR IsNot Nothing Then
            vcve_registro_turno = vDR("cve_registro_turno")
            vcve_equipo = vDR("cve_equipo")
            vcve_linea = vDR("cve_linea")
            vcve_turno = vDR("cve_turno")
            vdia_asignado = vDR("dia_asignado")
            vdesecho_aplicable = vDR("desecho_aplicable")
            vadeudo = vDR("adeudo")
        End If
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
        Dim queryInsert As String = "insert into registro_turno(cve_equipo,cve_linea,cve_turno,dia_asignado,desecho_aplicable,adeudo) " &
                              "values(" & vcve_equipo & "," & vcve_linea & "," & vcve_turno & ",'" & vdia_asignado.ToString("MM-dd-yyyy") & "'," & vdesecho_aplicable & ",0)"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al Registrar_Registro_turno. CREgistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_registro_turno As Long
    Private vcve_equipo As Long
    Private vcve_linea As Long
    Private vcve_turno As Long
    Private vdia_asignado As DateTime
    Private vdesecho_aplicable As Long
    Private vadeudo As Long
    'auxiliares
    Private vbandera_registro_turno As Long
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
    Public Property cve_equipo() As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_turno() As Long
        Get
            Return vcve_turno
        End Get
        Set(ByVal value As Long)
            vcve_turno = value
        End Set
    End Property
    Public Property dia_asignado() As DateTime
        Get
            Return vdia_asignado
        End Get
        Set(ByVal value As DateTime)
            vdia_asignado = value
        End Set
    End Property
    Public Property adeudo() As Long
        Get
            Return vadeudo
        End Get
        Set(ByVal value As Long)
            vadeudo = value
        End Set
    End Property
    Public Property desecho_aplicable() As Long
        Get
            Return vdesecho_aplicable
        End Get
        Set(ByVal value As Long)
            vdesecho_aplicable = value
        End Set
    End Property
    Public Property bandera_registro_turno() As Long
        Get
            Return vbandera_registro_turno
        End Get
        Set(ByVal value As Long)
            vbandera_registro_turno = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Sub calcula_adeudo_desecho_aplicable()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "calcula_adeudo"}
                cmd.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vcve_registro_turno
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch
                MsgBox("CRegistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
    Public Sub verifica_registro_turno()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "verifica_registro_turno"}
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vdia_asignado.ToString("dd-MM-yyyy")
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vbandera_registro_turno = obj.Rows(0)(0)
                Me.vcve_registro_turno = obj.Rows(0)(1)
                Me.vcve_turno = obj.Rows(0)(2)
                scope.Complete()
            Catch
                MsgBox("Error al validar verifica_registro_turno. CRegistro_Turno_ERROR1", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
    Public Sub verifica_registro_turno_produccion()
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "verifica_registro_turno_produccion"}
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vdia_asignado.ToString("dd-MM-yyyy HH:mm")
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vbandera_registro_turno = obj.Rows(0)(0)
                Me.vcve_registro_turno = obj.Rows(0)(1)
                Me.vcve_turno = obj.Rows(0)(2)
                scope.Complete()
            Catch
                MsgBox("Error al validar verifica_registro_turno_produccion. CRegistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
    Public Function llena_lineas_registradas_hoy() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "lineas_registradas"}
                vComando.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                vComando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Me.vdia_asignado
                obj = oBD.EjecutaCommando(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al obtener Lineas Registradas. CRegistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    'Descansos
    Public Sub registra_dia_descanso()
        Dim queryInsert As String = String.Format("insert into registro_turno select el.cve_equipo,l.cve_linea,(Select t.cve_turno from turno t where turno='Descanso'),'{0:MM-dd-yyyy}',0,0 from linea l join equipo_linea el on l.cve_linea=el.cve_linea where l.Estatus='1' and el.cve_equipo={1}", vdia_asignado, cve_equipo)
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al Registrar_Descanso. CREgistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
    Public Sub borra_dia_descanso()
        Dim queryInsert As String = "delete from registro_turno " &
            "where cve_equipo=" & vcve_equipo & " and cve_turno=(select t.cve_turno from turno t where t.turno='Descanso') and " &
            "day(dia_asignado)=day('" & vdia_asignado.ToString("MM-dd-yyyy") & "') and " &
            "month(dia_asignado)=month('" & vdia_asignado.ToString("MM-dd-yyyy") & "') and " &
            "year(dia_asignado)=year('" & vdia_asignado.ToString("MM-dd-yyyy") & "')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al Registrar_Descanso. CREgistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
    Public Sub valida_dia_descanso()
        Dim vDR As DataRow
        Dim query As String = "select count(*) as contador from registro_turno rt where " &
            "rt.cve_equipo=" & vcve_equipo & " and " &
            "day(rt.dia_asignado)=day('" & vdia_asignado.ToString("MM-dd-yyyy") & "') and " &
            "month(rt.dia_asignado)=month('" & vdia_asignado.ToString("MM-dd-yyyy") & "') and " &
            "year(rt.dia_asignado)=year('" & vdia_asignado.ToString("MM-dd-yyyy") & "') and " &
            "rt.cve_linea in (select l.cve_linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where l.Estatus='1' and el.cve_equipo=" & vcve_equipo & ")"
        vDR = oBD.ObtenerRenglon(query, "registro_turno")
        If vDR IsNot Nothing Then
            vbandera_registro_turno = vDR("contador")
        End If
    End Sub
    Public Function llena_Descanso_gridview() As DataTable
        Dim dtDescanso As New DataTable
        Dim date_inicio = vdia_asignado
        date_inicio = date_inicio.AddDays(-Convert.ToDouble(vdia_asignado.ToString("dd")) + 1)
        Dim date_fin As DateTime = date_inicio.AddDays(4)
        date_fin = date_fin.AddMonths(1)
        Dim query As String = "select rts.dia_asignado as dia_asignado,'Descanso Todas Lineas' as descripcion from (" &
            "select rt.dia_asignado,count(rt.cve_linea) as contador_lineas from registro_turno rt " &
            "join equipo_linea el on rt.cve_equipo=el.cve_equipo and rt.cve_linea=el.cve_linea " &
            "where rt.cve_turno=(select t.cve_turno from turno t where t.turno='Descanso') and rt.cve_equipo=" & vcve_equipo & " and " &
            "rt.dia_asignado>='" & date_inicio.ToString("MM-dd-yyyy") & "' and " &
            "rt.dia_asignado<='" & date_fin.ToString("MM-dd-yyyy") & "' " &
            "group by rt.dia_asignado) as rts " &
            "where rts.contador_lineas=(select count(l.cve_linea) from linea l join equipo_linea el on l.cve_linea=el.cve_linea where l.Estatus='1' and el.cve_equipo=" & vcve_equipo & ")"
        Try
            dtDescanso = oBD.ObtenerTabla(query)
        Catch ex As Exception
            MsgBox("Error al obtener_Descansos. CRegistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
            dtDescanso = Nothing
        End Try
        Return dtDescanso
    End Function
#End Region
End Class
