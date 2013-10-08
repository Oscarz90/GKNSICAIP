Imports CapaDatos
Namespace Clases_Catalogos

    Public Class Catalogo_Modelo
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)


        Public Function Obtener_Modelos() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("SELECT cve_modelo, np_gkn, m.descripcion AS Modelo, componente, cm.descripcion AS Clasificacion_Modelo " & _
                                   "FROM modelo m JOIN componente c ON m.cve_componente=c.cve_componente " & _
                                   "JOIN clasificacion_modelo cm ON cm.cve_clasificacion_modelo=m.cve_clasificacion_modelo " & _
                                   "WHERE m.Estatus= '1'")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function

    End Class
End Namespace
