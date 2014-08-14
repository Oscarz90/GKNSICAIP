Imports CapaDatos

Public Class G_Fase2

    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

    Private Function Dar_Formato_FECHA(ByVal vEntrada As DateTime) As String
        Dim vRetorno As String
        vRetorno = vEntrada.Year & "/" & vEntrada.Month & "/" & vEntrada.Day
        Return vRetorno
    End Function

    Public Function Obten_Cinco_S(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC obtiene_cincos_verifid '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vNivel)
        Return vDT_Retorno
    End Function

    Public Function Obten_Costo(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_Costo_verifid '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
        Return vDT_Retorno
    End Function

    Public Function Obten_Gente(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC obtiene_gente_verifid '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
        Return vDT_Retorno
    End Function

    Public Function Obten_NRFT(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC obtiene_nrfti_verifid '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
        Return vDT_Retorno
    End Function

    Public Function Obten_OEE(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_OEE_prueba '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
        Return vDT_Retorno
    End Function

    Public Function Obten_Seguridad(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable
        vDT_Retorno = oBD.ObtenerTabla("EXEC obtiene_seguridad_verifid '" & Dar_Formato_FECHA(vFecha_Inicial) & "', '" & Dar_Formato_FECHA(vFecha_Final) & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
        Return vDT_Retorno
    End Function


End Class
