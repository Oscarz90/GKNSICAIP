Imports CapaDatos
Public Class Graficas
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oBD_Kronos As New CapaDatos.CapaDatos(cadena_conexion.CadenaKronos)

#Region "Atributos"
    Private vIdEquipo As Long
    Private vFechaInicio As DateTime
    Private vFechaFinal As DateTime

#End Region
#Region "Propiedades"
    Public Property IdEquipo As Long
        Get
            Return vIdEquipo
        End Get
        Set(ByVal value As Long)
            vIdEquipo = value
        End Set
    End Property

    Public Property FechaInicio() As DateTime
        Get
            Return vFechaInicio
        End Get
        Set(ByVal value As DateTime)
            vFechaInicio = value
        End Set
    End Property

    Public Property FechaFinal() As DateTime
        Get
            Return vFechaFinal
        End Get
        Set(ByVal value As DateTime)
            vFechaFinal = value
        End Set
    End Property
#End Region
#Region "OBTENER EQUIPO, LINEA(S), AREA, CADENA DE VALOR NIVEL USUARIO"
    ''' <summary>
    ''' Obtener Id del equipo desde formulario de captura producción
    ''' </summary>
    ''' <param name="IdEquipo">idEquipo</param>
    ''' <remarks></remarks>
    Public Sub Obtener_IdEquipo(ByVal IdEquipo As Integer)
        'vIdEquipo = IdEquipo
    End Sub

    ''' <summary>
    ''' Obtener el nombre del equipo mediante el id del equipo
    ''' </summary>
    ''' <param name="vIdEquipo">id equuipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Nombre_Equipo_Usuarios(ByVal vIdEquipo As String) As DataTable
        Dim vRetorno As DataTable = Nothing
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("select cve_equipo, equipo from equipo where cve_equipo = " & vIdEquipo)
            If vDT IsNot Nothing Then
                vRetorno = vDT
            Else
                vRetorno = Nothing
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    ''' <summary>
    '''Obtener la línea(s) del equipo mediante el id del equipo
    ''' </summary>
    ''' <param name="vIdEquipo"> idequipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Lineas_Equipo_Usuarios(ByVal vIdEquipo As String) As DataTable
        Dim vRetorno As DataTable = Nothing
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("select l.cve_linea, linea from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo" & _
                                   " join linea l on el.cve_linea=l.cve_linea" & _
                                   " where e.cve_equipo = " & vIdEquipo)
            If vDT IsNot Nothing Then
                vRetorno = vDT
            Else
                vRetorno = Nothing
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    ''' <summary>
    ''' Obtener el área a la que pertenece el equipo mediante el id del equipo
    ''' </summary>
    ''' <param name="vIdEquipo">idequipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Area_Usuarios(ByVal vIdEquipo As String) As DataTable
        Dim vRetorno As DataTable = Nothing
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("select distinct c.cve_componente, componente from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo " & _
                                     "join linea l on el.cve_linea=l.cve_linea " & _
                                     "join componente c on l.cve_componente=c.cve_componente " & _
                                     "where e.cve_equipo = " & vIdEquipo)
            If vDT IsNot Nothing Then
                vRetorno = vDT
            Else
                vRetorno = Nothing
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    ''' <summary>
    ''' Obtener la cadena de valor a la que pertenece el equipo mediante el id del equipo
    ''' </summary>
    ''' <param name="vIdEquipo">idequipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_CadenaValor_Usuarios(ByVal vIdEquipo As String) As DataTable
        Dim vRetorno As DataTable = Nothing
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("select distinct c.cve_cadena_valor, cadena from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo " & _
                                     "join linea l on el.cve_linea=l.cve_linea join componente c on l.cve_componente=c.cve_componente " & _
                                     "join cadena_valor cad on c.cve_cadena_valor=cad.cve_cadena_valor where e.cve_equipo = " & vIdEquipo)
            If vDT IsNot Nothing Then
                vRetorno = vDT
            Else
                vRetorno = Nothing
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

#End Region
#Region "OBTENER EQUIPO, LINEAS, AREA, CADENA DE VALOR DIRECTOR"

    Public Function Obtener_Nombre_Equipo_Director(ByVal vIdArea As String) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, equipo from equipo where cve_equipo = " & vIdArea, "equipo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("equipo")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

#End Region
    ''USO SOLAMENTE PARA 5S Y POSIBLEMENTE DE COSTO
#Region "EJECUTAR VISTAS"
    Public Function ejecutarVista(ByVal cadena As String, ByVal cadenaWHERE As String) As DataTable
        Dim vRetorno As DataTable = Nothing
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("" & cadena & " " & cadenaWHERE)
            If vDT IsNot Nothing Then
                vRetorno = vDT
            Else
                vRetorno = Nothing
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function
#End Region

#Region "OBTENER OEE"
    Public Function obtener_Oee_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_oee"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener valores de Oee Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Oee(ByVal videquipo As Integer, ByVal vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_oee_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener valores de Oee Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function

    ''PENDIENTE DE HACER LOS PROCEDIMIENTOS X MESES Y SUS RESPECTIVOS METODOS!!!

#End Region

#Region "OBTENER NRFTI"
    Public Function obtener_Nrfti_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_nrft_interno"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener valores de Nrft Interno. Graficas, capa de negocios", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Nrfti(ByVal videquipo As Integer, ByVal vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_nrft_interno_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener valores de Nrft Interno. Graficas, capa de negocios", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region

#Region "MANDAR OBJETIVOS"

    Public Function obtener_Objetivo_Productividad(ByVal vIdEquipo As Integer) As Double
        Dim vRetorno As Double = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, productividad from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("productividad")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    Public Function obtener_Objetivo_Calidad(ByVal vIdEquipo As Integer) As Double
        Dim vRetorno As Double = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, calidad from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("calidad")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    Public Function obtener_Objetivo_Costo(ByVal vIdEquipo As Integer) As Double
        Dim vRetorno As Double = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, costo from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("costo")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    Public Function obtener_Objetivo_Seguridad(ByVal vIdEquipo As Integer) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, seguridad from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("seguridad")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    Public Function obtener_Objetivo_Gente(ByVal vIdEquipo As Integer) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, gente from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("gente")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

    Public Function obtener_Objetivo_CincoS(ByVal vIdEquipo As Integer) As Double
        Dim vRetorno As Double = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, cincoS from objetivo where estatus=1 and cve_equipo = " & vIdEquipo, "objetivo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("cincoS")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

#End Region

#Region "OBTENER SEGURIDAD"
    Public Function obtener_Seguridad_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_seguridad"  ''-----------------
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Seguridad(ByVal videquipo As Integer, ByVal vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_seguridad_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Seguridad_por_mes_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_seguridad_por_mes"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Seguridad_por_mes_por_linea(ByVal videquipo As Integer, ByVal Vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_seguridad_por_mes_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
#Region "OBTENER GENTE 1LINEA/NLINEAS/X MESES"
    Public Function obtener_Gente_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_gente"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Gente(ByVal videquipo As Integer, ByVal vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_gente_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Gente_por_meses_acumulado(ByVal videquipo As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_gente_por_mes"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
    Public Function obtener_Gente_por_meses_por_linea(ByVal videquipo As Integer, ByVal vidlinea As Integer, ByVal vfechainicio As DateTime, ByVal vfechafinal As DateTime) As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "obtiene_gente_por_mes_por_linea"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = videquipo
                cmd.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = vidlinea
                cmd.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = vfechainicio
                cmd.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = vfechafinal
                obj = oBD.EjecutaCommando(cmd)
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al obtener detalle de Productivdad. CProduccion_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region

End Class
