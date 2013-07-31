Imports CapaDatos
Namespace Clases_Catalogos

    Public Class Catalogo_Tiempo_Ciclo
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

        Public Function Obtener_Tiempos_Ciclos() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("Select cve_TC, piezas_por_hora, linea, descripcion as Modelo, TiemCiclo.estatus " & _
                                   "FROM TC TiemCiclo JOIN linea l ON l.cve_linea=TiemCiclo.cve_linea " & _
                                   "JOIN modelo m on m.cve_modelo=TiemCiclo.cve_modelo")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function
    End Class
End Namespace