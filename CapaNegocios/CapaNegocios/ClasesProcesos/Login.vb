Imports CapaDatos
Public Class Login
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD_Kronos As New CapaDatos.CapaDatos(cadena_conexion.CadenaKronos)
    Dim oBD_SICAIP As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "Propiedades de Empleado Kronos"   

    Private vEquipo_Empleado As String
    ''' <summary>
    ''' Nombre del Equipo del Empleado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Equipo_Empleado() As String
        Get
            Return vEquipo_Empleado
        End Get
        Set(ByVal value As String)
            vEquipo_Empleado = value
        End Set
    End Property

    Private vNombre_Empleado As String
    ''' <summary>
    ''' Nombre del Empleado
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Nombre_Empleado() As String
        Get
            Return vNombre_Empleado
        End Get
        Set(ByVal value As String)
            vNombre_Empleado = value
        End Set
    End Property

#End Region

    Public Function Obtener_Cve_Empleado(ByVal vCodigo_Barras As String) As String
        Dim vRetorno As String = ""
        vRetorno = Mid(vCodigo_Barras, 6, 6)
        Return vRetorno
    End Function

    ''' <summary>
    ''' Obtiene si el empleado esta Activo desde BD Kronos
    ''' </summary>
    ''' <param name="vCve_Empleado">Cve del Empleado(Son solo 6 Caracteres</param>
    ''' <returns>Retorna True si el Empleado esta activo</returns>
    ''' <remarks></remarks>
    Public Function Empleado_Valido(ByVal vCve_Empleado As String) As Boolean
        Dim vDR As DataRow
        Dim vRetorno As Boolean
        Try
            vDR = oBD_Kronos.ObtenerRenglon("select employmentstatus from vp_employee where personnum ='" & vCve_Empleado & "'", "Empleados")
            If vDR("employmentstatus") = "Active" Then
                vRetorno = True
            Else
                vRetorno = False
            End If
        Catch ex As Exception
            MsgBox("El empleado no está activo en KRONOS. Clave del Error: LIN_001", vbCritical + vbOKOnly, "Error")
        End Try

        Return vRetorno
    End Function

    ''' <summary>
    ''' Carga las propiedades de Nombre_Empleado y Nombre del Equipo
    ''' </summary>
    ''' <param name="vCve_Empleado">Cve del Empleado(Son solo 6 Caracteres</param>
    ''' <remarks></remarks>
    Public Sub Cargar_Empleado(ByVal vCve_Empleado As String)
        Dim vDR As DataRow
        vDR = oBD_Kronos.ObtenerRenglon("select personfullname, homelaborleveldsc7 from vp_employee where personnum = '" & vCve_Empleado & "'", "Login")
        If vDR IsNot Nothing Then            
            vNombre_Empleado = vDR("personfullname")
            vEquipo_Empleado = vDR("homelaborleveldsc7")
        End If
    End Sub

    ''' <summary>
    ''' Obtener el Id del Equipo mediante su nombre del equipo
    ''' </summary>
    ''' <param name="vNombre_Equipo">Nombre del Equipo</param>
    ''' <returns>Id del Equipo</returns>
    ''' <remarks></remarks>
    Public Function Obtener_Id_Equipo(ByVal vNombre_Equipo As String) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD_SICAIP.ObtenerRenglon("select cve_equipo from equipo where equipo = '" & Replace(vNombre_Equipo, "'", "''") & "'", "Login")
            If vDR IsNot Nothing Then
                vRetorno = vDR("cve_equipo")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    ''' <summary>
    ''' Este metodo se utilizara para Validar el Acceso a los equipos piloto
    ''' </summary>
    ''' <param name="vNombre_Equipo">Nombre del Equipo</param>
    ''' <returns>Retorna 1=>Equipo con Acceso; 0=>Equipo sin Acceso</returns>
    ''' <remarks></remarks>
    Public Function Valida_Equipo_Piloto(ByVal vNombre_Equipo As String) As Integer
        Dim vRetorno As Integer = 0
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "validar_equipo_piloto"
                cmd.Parameters.Add("@nombre_equipo", SqlDbType.VarChar).Value = Replace(vNombre_Equipo, "'", "''")
                Dim obj As DataTable = oBD_SICAIP.EjecutaCommando(cmd)
                vRetorno = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
        Return vRetorno
    End Function

    ''' <summary>
    ''' Obtiene un Id que esta vinculado un Tlatoani a una pantalla de captura
    ''' </summary>
    ''' <param name="vNombre_Equipo">Nombre del Equipo</param>
    ''' <returns>Id_Vinculo entre Tlatoani y Pantalla_Captura</returns>
    ''' <remarks></remarks>
    Public Function Obtener_Tipo_Tlatoani(ByVal vNombre_Equipo As String) As Integer
        Dim vRetorno As Integer = 0
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "get_Tipo_Tlatoani"
                cmd.Parameters.Add("@nombre_equipo", SqlDbType.VarChar).Value = vNombre_Equipo
                Dim obj As DataTable = oBD_SICAIP.EjecutaCommando(cmd)
                vRetorno = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
        Return vRetorno
    End Function

End Class
