Imports CapaDatos
Public Class Linea
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
    Private vcve_linea As Long
    Private vcve_componente As Long
    Private vlinea As String
    Private vtpcdm As Long
#End Region
#Region "Propiedades"
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_componente() As Long
        Get
            Return vcve_componente
        End Get
        Set(ByVal value As Long)
            vcve_componente = value
        End Set
    End Property
    Public Property linea() As String
        Get
            Return vlinea
        End Get
        Set(ByVal value As String)
            vlinea = value
        End Set
    End Property
    Public Property tpcdm() As Long
        Get
            Return vtpcdm
        End Get
        Set(ByVal value As Long)
            vtpcdm = value
        End Set
    End Property



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
