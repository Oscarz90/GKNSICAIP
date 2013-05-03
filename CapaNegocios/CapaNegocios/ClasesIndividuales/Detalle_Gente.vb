Imports CapaDatos
Public Class Detalle_Gente
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "Iindividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_detalle_gente
        End Get
        Set(ByVal value As Long)
            vcve_detalle_gente = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_detalle_gente
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
    End Sub
#End Region
#Region "Atributos"
    Private vcve_detalle_gente As Long
    Private vdescripcion As String
#End Region
#Region "Propiedades"
    Public Property cve_detalle_gente() As Long
        Get
            Return vcve_detalle_gente
        End Get
        Set(ByVal value As Long)
            vcve_detalle_gente = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return vdescripcion
        End Get
        Set(ByVal value As String)
            vdescripcion = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_combo_detalle_gente() As DataTable
        Dim dtDetalle As New DataTable
        Try
            dtDetalle = oBD.ObtenerTabla("Select cve_detalle_gente,descripcion from detalle_gente")
        Catch ex As Exception
            MsgBox("Error al obtener Detalle Gente. CDetalle_Gente_ERROR", vbCritical + vbOKOnly, "Error")
            dtDetalle = Nothing
        End Try
        Return dtDetalle
    End Function
#End Region   
End Class
