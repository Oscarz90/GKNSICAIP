Imports CapaDatos
Public Class Graficas
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "Atributos"
    ''Private vIdEquipo As Integer = 4

#End Region

#Region "Propiedades"

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
    Public Function Obtener_Nombre_Equipo_Usuarios(ByVal vIdEquipo As String) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select cve_equipo, equipo from equipo where cve_equipo = " & vIdEquipo, "equipo")
            If vDR IsNot Nothing Then
                vRetorno = vDR("equipo")
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
    Public Function Obtener_Lineas_Equipo(ByVal vIdEquipo As String) As DataTable
        Dim vDT As DataTable = Nothing
        Try
            vDT = oBD.ObtenerTabla("select linea from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo" & _
                                   " join linea l on el.cve_linea=l.cve_linea" & _
                                   " where e.cve_equipo = " & vIdEquipo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return vDT
    End Function

    ''' <summary>
    ''' Obtener el área a la que pertenece el equipo mediante el id del equipo
    ''' </summary>
    ''' <param name="vIdEquipo">idequipo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener_Area_Usuarios(ByVal vIdEquipo As String) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select distinct componente from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo " & _
                                     "join linea l on el.cve_linea=l.cve_linea " & _
                                     "join componente c on l.cve_componente=c.cve_componente " & _
                                     "where e.cve_equipo = " & vIdEquipo, "componente")

            If vDR IsNot Nothing Then
                vRetorno = vDR("componente")
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
    Public Function Obtener_CadenaValor_Usuarios(ByVal vIdEquipo As String) As Integer
        Dim vRetorno As Integer = 0
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select distinct cadena from equipo e join equipo_linea el on e.cve_equipo=el.cve_equipo " & _
                                     "join linea l on el.cve_linea=l.cve_linea join componente c on l.cve_componente=c.cve_componente " & _
                                     "join cadena_valor cad on c.cve_cadena_valor=cad.cve_cadena_valor where e.cve_equipo = " & vIdEquipo, "cadena_valor")

            If vDR IsNot Nothing Then
                vRetorno = vDR("cadena_valor")
            End If
        Catch ex As Exception

        End Try
        Return vRetorno
    End Function

#End Region

#Region "OBTENER EQUIPO, LINEAS, AREA, CADENA DE VALOR LG"
    ''Cambiar la consulta!! para nivel=LG
    Public Function Obtener_Nombre_Equipo_LG(ByVal vIdArea As String) As Integer
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
End Class
