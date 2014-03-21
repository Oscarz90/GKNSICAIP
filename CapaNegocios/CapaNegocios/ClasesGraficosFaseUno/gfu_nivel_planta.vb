Imports CapaDatos
Public Class gfu_nivel_planta
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return 1
        End Get
        Set(ByVal value As Long)
            value = 1
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Metodos Graficos Fase Uno"
    'Cadena Valor
    Public Function nivel_planta_cadena_valor() As DataTable
        Dim dt_cadena_valor As New DataTable
        Try
            dt_cadena_valor = oBD.ObtenerTabla("select cv.cve_cadena_valor,cv.cadena from cadena_valor cv")
        Catch ex As Exception
            MsgBox("Error al obtener cadena valor. Cgfu_nivel_planta_ERROR", vbCritical + vbOKOnly, "Error")
            dt_cadena_valor = Nothing
        End Try
        Return dt_cadena_valor
    End Function
    Public Function nivel_planta_componente() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select c.cve_componente,c.componente from componente c")
        Catch ex As Exception
            MsgBox("Error al obtener componente. Cgfu_nivel_planta_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_planta_equipos() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select e.cve_equipo,e.equipo from equipo e order by e.equipo asc")
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_planta_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_planta_linea() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l")
        Catch ex As Exception
            MsgBox("Error al obtener linea. Cgfu_nivel_planta_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
#End Region
End Class
