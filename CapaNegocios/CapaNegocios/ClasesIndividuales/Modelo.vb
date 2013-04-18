Imports CapaDatos
Public Class Modelo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub
    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vId
        End Get
        Set(ByVal value As Long)
            vId = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"

#End Region
#Region "Propiedades"

#End Region

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_Modelos_Linea(ByVal mcve_linea As String) As DataTable
        Dim dtModelos As New DataTable
        Try
            dtModelos = oBD.ObtenerTabla("select m.cve_modelo,m.np_gkn from linea l " &
                                         "join TC tc on l.cve_linea=tc.cve_linea " &
                                         "join modelo m on tc.cve_modelo=m.cve_modelo " &
                                         "where l.cve_linea=" & mcve_linea)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_MODELOS_DE_LINEA_CModelo")
            dtModelos = Nothing
        End Try
        Return dtModelos
    End Function
#End Region
End Class
