Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Maquina
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)


        Public Function Obtener_Maquinas() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("select cve_maquina, clave_maquina, maquina, linea from Maquina m join linea l on m.cve_linea= l.cve_linea")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function


    End Class
End Namespace
