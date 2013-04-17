Imports CapaDatos
Imports System.Transactions
Public Class Linea
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "Metodos IIndividual"

    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub
    Dim vId
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

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_lineas() As DataTable
        Dim dtTurnos As New DataTable
        Try
            'dtTurnos = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where el.cve_equipo=" & vcve_equipo)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_Lineas_CLineas")
            dtTurnos = Nothing
        End Try
        Return dtTurnos
    End Function
#End Region
End Class
