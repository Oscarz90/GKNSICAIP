Imports CapaDatos
Public Class seguridad_acumulado
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
    Public vErrorRegistro As Boolean = False

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select cve_equipo, cve_linea, fecha, acumulado from seguridad_acumulado where cve_equipo = {0}", vcve_seguridad_acumulado), "Seguridad_Acumulado")

            If vDR IsNot Nothing Then
                If Not IsDBNull(vDR("cve_equipo")) Then
                    Me.vCve_equipo = vDR("cve_equipo")
                Else
                    Me.vCve_equipo = 0
                End If

                If Not IsDBNull(vDR("cve_linea")) Then
                    Me.vCve_linea = vDR("cve_linea")
                Else
                    Me.vCve_linea = 0
                End If

                If Not IsDBNull(vDR("fecha")) Then
                    Me.vFecha = vDR("fecha")
                Else
                    Me.vFecha = DateTime.Now
                End If

                If Not IsDBNull(vDR("acumulado")) Then
                    Me.vAcumulado = vDR("acumulado")
                Else
                    Me.vAcumulado = 0
                End If
            End If

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from seguridad_acumulado where cve_seguridad_acumulado= " & vcve_seguridad_acumulado)
        Catch ex As Exception
            MsgBox("Error al eliminar seguridad. CSeguridad_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_seguridad_acumulado
    End Function

    Public Function Obtener_Id(ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long, ByVal vFecha As DateTime) As Long
        Dim vDR As DataRow
        Dim vRetorno As Long = 0
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select cve_seguridad_acumulado from seguridad_acumulado where cve_equipo = {0} and cve_linea= {1} and fecha= '{2}'", vCve_Equipo, vCve_Linea, Dar_Formato_FECHA(vFecha)), "Seguridad_Acumulado")

            If vDR IsNot Nothing Then
                vRetorno = vDR("cve_seguridad_acumulado")
            Else
                vRetorno = 0
            End If
        Catch ex As Exception
            vRetorno = 0
        End Try

        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_SEGURIDAD_ACUMULADO"}
                cmd.Parameters.Add("cve_seguridad_acumulado", SqlDbType.BigInt).Value = Me.vcve_seguridad_acumulado
                cmd.Parameters.Add("cve_equipo", SqlDbType.BigInt).Value = Me.vCve_equipo
                cmd.Parameters.Add("cve_linea", SqlDbType.BigInt).Value = Me.vCve_linea
                cmd.Parameters.Add("fecha", SqlDbType.DateTime).Value = Me.vFecha
                cmd.Parameters.Add("acumulado", SqlDbType.BigInt).Value = Me.vAcumulado

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                'Me.vcve_seguridad_acumulado = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
                vErrorRegistro = True
            End Try
        End Using

    End Sub
#End Region

#Region "Atributos"
    Private vcve_seguridad_acumulado As Long
    Private vCve_equipo As Long
    Private vCve_linea As Long
    Private vFecha As DateTime
    Private vAcumulado As Long
#End Region

#Region "Propiedades"

    Public Property Cve_seguridad_acumulado As Long Implements IIndividual.Id
        Get
            Return vcve_seguridad_acumulado
        End Get
        Set(ByVal value As Long)
            vcve_seguridad_acumulado = value
        End Set
    End Property

    Public Property cve_equipo() As Long
        Get
            Return vCve_equipo
        End Get
        Set(ByVal value As Long)
            vCve_equipo = value
        End Set
    End Property

    Public Property cve_linea() As Long
        Get
            Return vCve_linea
        End Get
        Set(ByVal value As Long)
            vCve_linea = value
        End Set
    End Property

    Public Property fecha() As DateTime
        Get
            Return vFecha
        End Get
        Set(ByVal value As DateTime)
            vFecha = value
        End Set
    End Property

    Public Property acumulado() As Long
        Get
            Return vAcumulado
        End Get
        Set(ByVal value As Long)
            vAcumulado = value
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

#Region "Validación eliminar nuevas o resueltas"
    ''Parte para el boton quitar (nuevas o resueltas)

    Private Function Dar_Formato_FECHA(ByVal vEntrada As DateTime) As String
        Dim vRetorno As String = String.Format("{0}/{1}/{2}", vEntrada.Year, vEntrada.Month, vEntrada.Day)
        Return vRetorno
    End Function


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
    ''' Valida que exista un registro en la tabla Seguridad_Acumulado, NOTA: Si Existe_Registro then Retorna TRUE
    ''' </summary>
    ''' <param name="vFecha"></param>
    ''' <param name="vCve_Equipo"></param>
    ''' <param name="vCve_Linea"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Existe_Registro_Actual_Acumulado(ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long) As Boolean
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select acumulado, cve_seguridad_acumulado from seguridad_acumulado where cve_equipo = {0} and cve_linea= {1} and fecha= '{2}'", vCve_Equipo, vCve_Linea, Dar_Formato_FECHA(vFecha)), "Seguridad_Acumulado")

            If vDR IsNot Nothing Then
                'vAcumulado_Retorno = vDR("acumulado")
                'vCve_Seguridad_Acumulado = vDR("cve_seguridad_acumulado")
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
            MsgBox("Lo sentimos, no existe registro")
        End Try
    End Function

    'Public Sub Agregar_Seguridad_Acumulado(ByVal vIdentity As Long, ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long, ByVal vValor_Acumulado As Integer)
    '    'Using scope As New TransactionScope()
    '    Try
    '        Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_SEGURIDAD_ACUMULADO"} ''REGISTRAR_SEGURIDAD_ACUMULADO
    '        With cmd.Parameters
    '            .Add("cve_seguridad_acumulado", SqlDbType.BigInt).Value = vIdentity
    '            .Add("cve_equipo", SqlDbType.BigInt).Value = vCve_Equipo
    '            .Add("cve_linea", SqlDbType.BigInt).Value = vCve_Linea
    '            .Add("fecha", SqlDbType.DateTime).Value = Dar_Formato_FECHA(vFecha)
    '            .Add("acumulado", SqlDbType.Int).Value = vValor_Acumulado
    '        End With
    '        Dim obj As DataTable = oBD.EjecutaCommando(cmd)
    '        'Me.vcve_linea = obj.Rows(0)(0) 'ID               
    '        'scope.Complete()
    '    Catch ex As Exception
    '        '    Throw New Exception(ex.Message)
    '    End Try
    '    'End Using
    'End Sub

    Public Function Obtener_Acumulado_Anterior(ByVal vFecha As DateTime, ByVal vCve_Equipo As Long, ByVal vCve_Linea As Long) As Integer
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon(String.Format("Select top 1 (fecha) as fecha, acumulado from seguridad_acumulado where cve_equipo = {0} and cve_linea={1} and fecha < '{2}' order by fecha desc", vCve_Equipo, vCve_Linea, Dar_Formato_FECHA(vFecha)), "Seguridad_Acumulado")

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

End Class
