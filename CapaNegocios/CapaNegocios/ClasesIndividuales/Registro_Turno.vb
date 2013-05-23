Imports CapaDatos
Public Class Registro_Turno
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from registro_turno where cve_registro_turno = " & vcve_registro_turno, "registro_turno")
        If vDR IsNot Nothing Then
            vcve_registro_turno = vDR("cve_registro_turno")
            vcve_equipo = vDR("cve_equipo")
            vcve_linea = vDR("cve_linea")
            vcve_turno = vDR("cve_turno")
            vdia_asignado = vDR("dia_asignado")
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
        Dim queryInsert As String = "insert into registro_turno(cve_equipo,cve_linea,cve_turno,dia_asignado,adeudo) " &
                              "values(" & vcve_equipo & "," & vcve_linea & "," & vcve_turno & ",'" & vdia_asignado.ToString("MM-dd-yyyy") & "',0)"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al Registrar_Linea_turno. CREgistro_Turno_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_registro_turno As Long
    Private vcve_equipo As Long
    Private vcve_linea As Long
    Private vcve_turno As Long
    Private vdia_asignado As DateTime
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
    Public Sub verifica_registro_turno()
        Using scope As New TransactionScope

            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "verifica_registro_turno"
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
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "verifica_registro_turno_produccion"
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
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "lineas_registradas"
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

#End Region
End Class
