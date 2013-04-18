Imports CapaDatos
Public Class EquipoLinea
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
    Private vcve_equipo_linea As Long
    Private vcve_equipo As Long
    Private vcve_linea As Long
#End Region
#Region "Propiedades"
    Public Property cve_equipo_linea As Long
        Get
            Return vcve_equipo_linea
        End Get
        Set(ByVal value As Long)
            vcve_equipo_linea = value
        End Set
    End Property
    Public Property cve_linea As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_equipo As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property
#End Region

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_lineas() As DataTable
        Dim dtEquipoLinea As New DataTable
        Try
            dtEquipoLinea = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where el.cve_equipo=" & vcve_equipo)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_Equipo_Lineas_CLineas")
            dtEquipoLinea = Nothing
        End Try
        Return dtEquipoLinea
    End Function
#End Region
End Class
