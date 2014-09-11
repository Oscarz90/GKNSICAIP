
Imports CapaDatos

Public Class G_Fase2

    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)

    Private Function Dar_Formato_FECHA(ByVal vEntrada As DateTime) As String
        Dim vRetorno As String = String.Format("{0}/{1}/{2}", vEntrada.Year, vEntrada.Month, vEntrada.Day)
        Return vRetorno
    End Function

    Public Function Obten_Cinco_S(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_cincos_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vNivel))
        Return vDT_Retorno
    End Function

    Public Function Obten_Costo(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_costo_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6} , {7}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vFormato, vNivel))
        Return vDT_Retorno
    End Function

    Public Function Obten_Gente(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_gente_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6} , {7}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vFormato, vNivel))
        Return vDT_Retorno
    End Function

    Public Function Obten_NRFT(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_nrfti_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6} , {7}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vFormato, vNivel))
        Return vDT_Retorno
    End Function

    Public Function Obten_OEE(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_oee_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6} , {7}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vFormato, vNivel))
        Return vDT_Retorno
    End Function

    Public Function Obten_Seguridad(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer) As DataTable
        Dim vDT_Retorno As DataTable = oBD.ObtenerTabla(String.Format("EXEC obtiene_seguridad_verifid '{0}', '{1}', {2} , {3} , {4} , {5} , {6} , {7}", Dar_Formato_FECHA(vFecha_Inicial), Dar_Formato_FECHA(vFecha_Final), vCve_Equipo, vCve_Linea, vCve_Componente, vCve_Cadena_Valor, vFormato, vNivel))
        Return vDT_Retorno
    End Function


End Class
