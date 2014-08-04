Imports CapaDatos

Public Class G_NRFT
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

    Public Function Obten_NRFT(ByVal vFecha_Inicial As DateTime, ByVal vFecha_Final As DateTime, ByVal vCve_Equipo As Integer, ByVal vCve_Linea As Integer, ByVal vCve_Componente As Integer, ByVal vCve_Cadena_Valor As Integer, ByVal vFormato As Integer, ByVal vNivel As Integer, Optional ByVal vEsGrafica As Boolean = False, Optional ByVal vEsResumen As Boolean = False) As DataTable
        Dim vDT_Retorno As DataTable

        If vNivel = 0 Then 'Equipo_Linea
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        ElseIf vNivel = 1 Then 'Equipo
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        ElseIf vNivel = 2 Then 'Linea
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        ElseIf vNivel = 3 Then 'Componente
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        ElseIf vNivel = 4 Then 'Cadena Valor
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        Else 'Planta
            If vEsGrafica = True Then
                vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
            Else
                If vEsResumen = True Then
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                Else
                    vDT_Retorno = oBD.ObtenerTabla("EXEC Obtiene_NRFT '" & vFecha_Inicial & "', '" & vFecha_Final & "', " & vCve_Equipo & " , " & vCve_Linea & " , " & vCve_Componente & " , " & vCve_Cadena_Valor & " , " & vFormato & " , " & vNivel)
                End If
            End If
        End If
        Return vDT_Retorno
    End Function
End Class
