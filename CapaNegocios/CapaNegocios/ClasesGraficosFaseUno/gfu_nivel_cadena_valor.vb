Imports CapaDatos
Public Class gfu_nivel_cadena_valor
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "Propiedades"

    Private vcve_usuario As Long
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property

#End Region
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
    Public Function nivel_cadena_valor_CV() As DataTable
        Dim dt_cadena_valor As New DataTable
        Try
            dt_cadena_valor = oBD.ObtenerTabla("select cv.cve_cadena_valor,cv.cadena from USUARIO_CADENA_VALOR ucv " &
                                               "join cadena_valor cv on ucv.CVE_Cadena_Valor=cv.cve_cadena_valor " &
                                               "where ucv.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener cadena valor. Cgfu_nivel_cadena_valor_ERROR", vbCritical + vbOKOnly, "Error")
            dt_cadena_valor = Nothing
        End Try
        Return dt_cadena_valor
    End Function
    Public Function nivel_cadena_valor_componente() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select c.cve_componente,c.componente from USUARIO_CADENA_VALOR ucv " &
                                             "join cadena_valor cv on ucv.CVE_Cadena_Valor=cv.cve_cadena_valor " &
                                             "join componente c on cv.cve_cadena_valor=c.cve_cadena_valor " &
                                             "where ucv.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener componente. Cgfu_nivel_cadena_valor_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_cadena_valor_linea() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select l.cve_linea,l.linea from USUARIO_CADENA_VALOR ucv " &
                                             "join cadena_valor cv on ucv.CVE_Cadena_Valor=cv.cve_cadena_valor " &
                                             "join componente c on cv.cve_cadena_valor=c.cve_cadena_valor " &
                                             "join linea l on c.cve_componente=l.cve_componente " &
                                             "where l.Estatus='1' and ucv.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener linea. Cgfu_nivel_cadena_valor_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
    Public Function nivel_cadena_valor_equipos() As DataTable
        Dim dt_componente As New DataTable
        Try
            dt_componente = oBD.ObtenerTabla("select DISTINCT e.cve_equipo,e.equipo from USUARIO_CADENA_VALOR ucv " &
                                             "join cadena_valor cv on ucv.CVE_Cadena_Valor=cv.cve_cadena_valor " &
                                             "join componente c on cv.cve_cadena_valor=c.cve_cadena_valor " &
                                             "join linea l on c.cve_componente=l.cve_componente " &
                                             "join equipo_linea el on l.cve_linea=el.cve_linea " &
                                             "join equipo e on el.cve_equipo=e.cve_equipo " &
                                             "where l.Estatus='1' and ucv.CVE_Usuario=" & vcve_usuario)
        Catch ex As Exception
            MsgBox("Error al obtener equipo. Cgfu_nivel_cadena_valor_ERROR", vbCritical + vbOKOnly, "Error")
            dt_componente = Nothing
        End Try
        Return dt_componente
    End Function
#End Region
End Class
