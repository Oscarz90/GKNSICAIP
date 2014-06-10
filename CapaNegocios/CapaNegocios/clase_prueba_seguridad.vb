Imports CapaDatos
Public Class clase_prueba_seguridad
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)


    Public Function Obtener_Tipos_Incidentes() As DataTable
        Dim vDT As DataTable

        vDT = oBD.ObtenerTabla("Select cve_incidente, descripcion from Incidentes ORDER BY descripcion")

        Return vDT
    End Function


    Public Function Obtener_Registros_Seguridad() As DataTable
        Dim vDT As DataTable

        vDT = oBD.ObtenerTabla("Select cs.cve_captura_seguridad as cve, e.equipo, cs.cve_equipo, cs.mes_afectado from captura_Seguridad cs join equipo e on e.cve_equipo=cs.cve_equipo")

        Return vDT

    End Function

    Public Function Obtener_Detalle_Registros_Seguridad(ByVal vcve_Registro_Seguridad As Long) As DataTable
        Dim vDT As DataTable

        vDT = oBD.ObtenerTabla("Select dcs.cve_detalle_captura_seguridad, dcs.cve_captura_seguridad, dcs.cve_incidente, i.descripcion as Incidente, dcs.cantidad_incidentes as cantidad  from detalle_captura_Seguridad dcs join incidentes i on dcs.cve_incidente= i.cve_incidente where cve_captura_seguridad=" & vcve_Registro_Seguridad)

        Return vDT

    End Function



End Class
