Imports CapaDatos
Public Class TC
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oLinea As Linea
    Dim oModelo As Modelo
    Public vCve_TC_Existe As Long = 0

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM TC WHERE cve_TC=" & vcve_TC, "TC")
            If rDatos IsNot Nothing Then
                If rDatos("cve_TC") IsNot DBNull.Value Then
                    Me.vcve_TC = rDatos("cve_TC")
                    Me.vpiezas_por_hora = rDatos("piezas_por_hora")
                    Me.vcve_linea = rDatos("cve_linea")
                    Me.vcve_modelo = rDatos("cve_modelo")
                    If rDatos("cod_empleado") IsNot DBNull.Value Then
                        Me.vCodigo_Empleado = rDatos("cod_empleado")
                    Else
                        Me.vCodigo_Empleado = ""
                    End If
                    If rDatos("fecha") IsNot DBNull.Value Then
                        Me.vFecha = rDatos("fecha")
                    Else
                        Me.vFecha = Date.Now
                    End If
                    If rDatos("estatus") IsNot DBNull.Value Then
                        Me.vEstatus = rDatos("estatus")
                    Else
                        Me.vEstatus = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub
    'Dim vId As Long
    'Public Property Id As Long Implements IIndividual.Id
    '    Get
    '        Return vId
    '    End Get
    '    Set(ByVal value As Long)
    '        vId = value
    '    End Set
    'End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_TC"
                With cmd.Parameters
                    .Add("cve_TC", SqlDbType.BigInt).Value = Me.vcve_TC
                    .Add("piezas_por_hora", SqlDbType.Int).Value = Me.vpiezas_por_hora
                    .Add("cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                    .Add("cve_modelo", SqlDbType.BigInt).Value = Me.vcve_modelo
                    .Add("cod_empleado", SqlDbType.VarChar).Value = Me.vCodigo_Empleado
                    .Add("fecha", SqlDbType.DateTime).Value = Me.vFecha
                    .Add("estatus", SqlDbType.VarChar).Value = Me.vEstatus
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_TC = obj.Rows(0)(0) 'ID               
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_TC As Long
    Private vpiezas_por_hora As Long
    Private vcve_linea As Long
    Private vcve_modelo As Long
    Private vEstatus As String
    Private vFecha As DateTime
    Private vCodigo_Empleado As String
#End Region
#Region "Propiedades"
    Public Property cve_TC() As Long Implements IIndividual.Id
        Get
            Return vcve_TC
        End Get
        Set(ByVal value As Long)
            vcve_TC = value
        End Set
    End Property
    Public Property piezas_por_hora() As Long
        Get
            Return vpiezas_por_hora
        End Get
        Set(ByVal value As Long)
            vpiezas_por_hora = value
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
    Public Property cve_modelo() As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
        End Set
    End Property

    
    Public Property Fecha() As DateTime
        Get
            Return vFecha
        End Get
        Set(ByVal value As DateTime)
            vFecha = value
        End Set
    End Property
    Public Property Codigo_Empleado() As String
        Get
            Return vCodigo_Empleado
        End Get
        Set(ByVal value As String)
            vCodigo_Empleado = value
        End Set
    End Property
    Public ReadOnly Property Nombre_Linea() As String
        Get
            If cve_linea <> 0 Then
                oLinea = New Linea
                oLinea.cve_linea = cve_linea
                oLinea.Cargar()
                Return oLinea.linea
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property Nombre_Modelo() As String
        Get
            If cve_modelo <> 0 Then
                oModelo = New Modelo
                oModelo.cve_modelo = cve_modelo
                oModelo.Cargar()
                Return oModelo.descripcion
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property Estatus() As String
        Get
            If vEstatus = "0" Then
                Return "INACTIVO"
            ElseIf vEstatus = "1" Then
                Return "ACTIVO"
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            vEstatus = value
        End Set
    End Property
#End Region

    Sub New()
        vFecha = Date.Now
    End Sub


#Region "Metodos Generales"

    Public Function Validar_Exixtencia_LINEA_MODELO_EN_TC(ByVal vID_Linea As Long, ByVal vID_Modelo As Long) As Boolean
        Dim vRetorno As Boolean = False
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("SELECT cve_TC FROM TC WHERE estatus !='0' and cve_linea=" & vID_Linea & " AND cve_modelo=" & vID_Modelo)
        If vDT.Rows.Count > 0 Then
            vCve_TC_Existe = vDT.Rows(0).Item("cve_TC")
            vRetorno = True
        Else
            vRetorno = False
        End If
        Return vRetorno
    End Function

    Public Function Validar_MODELO_LINEA_EN_TC_COMPONENTE(ByVal vID_Linea As Long, ByVal vID_Modelo As Long) As Boolean
        Dim vRetorno As Boolean = False
        Dim vDR_Linea As DataRow = Nothing
        Dim vDR_Modelo As DataRow = Nothing
        Dim vComponente_Linea As Long = 0
        Dim vComponente_Modelo As Long = 0
        Try
            vDR_Linea = oBD.ObtenerRenglon("SELECT cve_componente FROM linea where Estatus='1' and cve_linea= " & vID_Linea, "linea")
            vDR_Modelo = oBD.ObtenerRenglon("SELECT cve_componente FROM modelo where Estatus='1' and cve_modelo= " & vID_Modelo, "modelo")
        Catch ex As Exception
            MsgBox("ERROR:Validar_MODELO_LINEA_EN_TC_COMPONENTE")
        End Try

        If vDR_Linea IsNot Nothing Then
            vComponente_Linea = vDR_Linea("cve_componente")
        End If
        If vDR_Modelo IsNot Nothing Then
            vComponente_Linea = vDR_Modelo("cve_componente")
        End If

        If vComponente_Linea <> 0 And vComponente_Modelo <> 0 Then
            If vComponente_Linea = vComponente_Modelo Then
                vRetorno = True
            Else
                vRetorno = False
            End If
        Else
            vRetorno = False
        End If
        Return vRetorno
    End Function



    Public Sub Cargar_TC(ByVal vID_Linea As Long, ByVal vID_Modelo As Long)
        Dim rDatos As DataRow
        rDatos = oBD.ObtenerRenglon("SELECT cve_TC FROM TC WHERE estatus !='0' and cve_linea=" & vID_Linea & " AND cve_modelo=" & vID_Modelo, "TC")
        If rDatos IsNot Nothing Then
            vcve_TC = rDatos("cve_TC")
            Cargar()
        Else

        End If
    End Sub



#End Region

#Region "Metodos formulario de produccion"
    Public Function obtener_tiempo_ciclo() As Double
        Dim Tiempo_ciclo As Double = 0
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("select top(1)t.cve_TC,cast(60 as float)/t.piezas_por_hora as tiempo_ciclo from TC t where t.cve_TC=" & vcve_TC, "TC")
            If rDatos IsNot Nothing Then
                If rDatos("tiempo_ciclo") IsNot DBNull.Value Then
                    cve_TC = rDatos("cve_TC")
                    Tiempo_ciclo = rDatos("tiempo_ciclo")
                End If
            End If
            Return Tiempo_ciclo
        Catch 'ex As Exception
            MsgBox("Error al obtener Tiempo Ciclo. CTC_ERROR", vbCritical + vbOKOnly, "Error")
            Return Tiempo_ciclo
        End Try
    End Function

    '
    Public Sub obtener_piezas_por_hora()
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select top(1)t.cve_TC,t.piezas_por_hora from TC t where t.cve_linea=" & vcve_linea & " and t.cve_modelo=" & vcve_modelo & " and estatus='1' order by fecha desc", "paro")
            If vDR IsNot Nothing Then
                vcve_TC = vDR("cve_TC")
                vpiezas_por_hora = vDR("piezas_por_hora")
            End If
        Catch
            MsgBox("Error al obtener piezas por hora!. CTC_ERROR", vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

#End Region
End Class
