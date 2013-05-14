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
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "delete_registro_paro"
                vComando.Parameters.Add("@cve_registro_paro", SqlDbType.BigInt).Value = Me.vCve_registro_paro
                vComando.Parameters.Add("@cod_empleado_eliminacion", SqlDbType.VarChar).Value = Me.vCod_empleado_eliminacion
                vComando.Parameters.Add("@fecha_eliminacion", SqlDbType.DateTime).Value = Me.vFecha_eliminacion
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al eliminar paro. CRegistro_Paro_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
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
        Dim queryInsert As String = "insert into registro_paro(cve_registro_turno,cod_empleado_registro,fecha_registro,cve_paro,cve_maquina,minutos,detalles,estatus) " &
                              "values(" & vCve_registro_turno & ",'" & vCod_empleado_registro & "','" & vFecha_registro.ToString("MM-dd-yyyy HH:mm") & "'," & vCve_paro & "," & vCve_maquina & "," & vMinutos & ",'" & vDetalles & "','" & vEstatus & "')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al insertar Paro. CRegistro_Paro_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
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
    'Atributos auxiliares
    Private vcod_paro As String
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

    Public Property cod_paro() As String
        Get
            Return vcod_paro
        End Get
        Set(ByVal value As String)
            vcod_paro = value
        End Set
    End Property


#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_paro_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select rp.cve_registro_paro,rt.cve_linea,rp.cve_maquina,rp.cve_paro,p.cod_paro,p.paro,rp.minutos,mq.clave_maquina,mq.maquina,rp.detalles " &
            "from registro_paro rp " &
            "join maquina mq on rp.cve_maquina=mq.cve_maquina " &
            "join registro_turno rt on rp.cve_registro_turno=rt.cve_registro_turno " &
            "join paro p on rp.cve_paro=p.cve_paro " &
            "where rp.cve_registro_turno=" & vCve_registro_turno & " and rp.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de Paro. CRegistro_Paro_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Sub captura_CDM(ByRef oDDetalle_CDM_total As Detalle_CDM_Total)
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "captura_Paros_CDM"
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.Int).Value = Me.vCve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vCod_empleado_registro
                vComando.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vFecha_registro)
                vComando.Parameters.Add("@cve_paro", SqlDbType.Int).Value = Me.vCve_paro
                vComando.Parameters.Add("@cve_maquina", SqlDbType.Int).Value = Me.vCve_maquina
                vComando.Parameters.Add("@minutos", SqlDbType.Int).Value = Me.vMinutos
                If Me.vDetalles = Nothing Then
                    Me.vDetalles = ""
                End If
                vComando.Parameters.Add("@detalles", SqlDbType.VarChar).Value = Me.vDetalles
                vComando.Parameters.Add("@cve_CDM", SqlDbType.Int).Value = oDDetalle_CDM_total.cve_CDM
                vComando.Parameters.Add("@mejora", SqlDbType.Float).Value = oDDetalle_CDM_total.mejora
                vComando.Parameters.Add("@costo", SqlDbType.Float).Value = oDDetalle_CDM_total.costo
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = oDDetalle_CDM_total.fecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = oDDetalle_CDM_total.fecha_final
                'oBD.EjecutaProcedimientos(vComando)
                Dim obj As DataTable = oBD.EjecutaCommando(vComando)
                Me.vCve_registro_paro = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                'Throw New Exception(ex.Message)
                MsgBox("Error al insertar CDM. CRegistro_Paro_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
    Public Sub captura_detalle_CDM()
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "captura_Paros_detalles_CDM"
                vComando.Parameters.Add("@cve_registro_paro", SqlDbType.BigInt).Value = Me.vCve_registro_paro
                vComando.Parameters.Add("@cve_registro_turno", SqlDbType.BigInt).Value = Me.vCve_registro_turno
                vComando.Parameters.Add("@cod_empleado", SqlDbType.VarChar).Value = Me.vCod_empleado_registro
                vComando.Parameters.Add("@fecha_registro", SqlDbType.DateTime).Value = Convert.ToDateTime(Me.vFecha_registro)
                vComando.Parameters.Add("@cod_paro", SqlDbType.VarChar).Value = Me.vcod_paro
                vComando.Parameters.Add("@cve_maquina", SqlDbType.BigInt).Value = Me.vCve_maquina
                vComando.Parameters.Add("@minutos", SqlDbType.Int).Value = Me.vMinutos
                If Me.vDetalles = Nothing Then
                    Me.vDetalles = ""
                End If
                vComando.Parameters.Add("@detalles", SqlDbType.VarChar).Value = Me.vDetalles
                oBD.EjecutaProcedimientos(vComando)
                scope.Complete()
            Catch
                MsgBox("Error al insertar detalle CDM. CRegistro_Paro_ERROR", vbCritical + vbOKOnly, "Error")
            End Try
        End Using
    End Sub
#End Region
End Class
