Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Equipo
        Dim cadena_conexion As New conexiones
        Dim oBD As New Datos(cadena_conexion.CadenaSicaip)


        Public Function Obtener_Equipos() As DataTable
            Dim vDT As DataTable = oBD.ObtenerTabla("SELECT cve_equipo, equipo, LET, LG, descripcion " & _
                                   " FROM lider l join equipo e on l.cve_lider=e.cve_lider " & _
                                   " join detalle d on e.cve_detalle=d.cve_detalle order by d.descripcion asc")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function

    End Class
End Namespace

