Imports CapaDatos
Public Class Detalle_Seguridad
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
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_detalle_seguridad
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_detalle_seguridad As Long
    Private vdescripcion As String
    Private vtipo As Long
#End Region
#Region "Propiedades"


    Public Property cve_detalle_seguridad() As Long
        Get
            Return vcve_detalle_seguridad
        End Get
        Set(ByVal value As Long)
            vcve_detalle_seguridad = value
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


    Public Property tipo() As Long
        Get
            Return vtipo
        End Get
        Set(ByVal value As Long)
            vtipo = value
        End Set
    End Property

#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_combo_seguridad_cond_inseg() As DataTable
        Dim dtDetalle As New DataTable
        Try
            dtDetalle = oBD.ObtenerTabla("Select cve_detalle_seguridad,descripcion from detalle_seguridad where tipo=0")
        Catch ex As Exception
            MsgBox("Error al obtener Detalle Seguridad Condiciones Inseguras. CDetalle_Seguridad_ERROR", vbCritical + vbOKOnly, "Error")
            dtDetalle = Nothing
        End Try
        Return dtDetalle
    End Function
    Public Function llena_combo_seguridad_accidentes() As DataTable
        Dim dtDetalle As New DataTable
        Try
            dtDetalle = oBD.ObtenerTabla("Select cve_detalle_seguridad,descripcion from detalle_seguridad where tipo=1")
        Catch ex As Exception
            MsgBox("Error al obtener Detalle Seguridad Condiciones Inseguras. CDetalle_Seguridad_ERROR", vbCritical + vbOKOnly, "Error")
            dtDetalle = Nothing
        End Try
        Return dtDetalle
    End Function
#End Region
End Class
