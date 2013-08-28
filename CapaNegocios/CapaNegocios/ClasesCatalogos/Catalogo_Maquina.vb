Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Maquina
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)


        Public Function Obtener_Maquinas() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("SELECT cve_maquina, clave_maquina, maquina, linea " & _
                                   " FROM Maquina m JOIN linea l ON m.cve_linea= l.cve_linea " & _
                                   " WHERE m.Estatus= '1'")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function


    End Class
End Namespace
