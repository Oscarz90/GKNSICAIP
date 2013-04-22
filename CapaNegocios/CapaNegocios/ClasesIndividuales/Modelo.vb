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
    Private vcve_modelo As Long
    Private vcve_componente As Long
    Private vcve_clasificacion_modelo As Long
    Private vnp_gkn As String
    Private vdescripcion As String

#End Region
#Region "Propiedades"

    Public Property cve_modelo() As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
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
    Public Property cve_clasificacion_modelo() As Long
        Get
            Return vcve_clasificacion_modelo
        End Get
        Set(ByVal value As Long)
            vcve_clasificacion_modelo = value
        End Set
    End Property
    Public Property np_gkn() As String
        Get
            Return vnp_gkn
        End Get
        Set(ByVal value As String)
            vnp_gkn = value
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
    Public Sub obtener_descripcion_modelo()
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("Select descripcion from modelo where cve_modelo=" & Me.vcve_modelo, "modelos")
            If rDatos IsNot Nothing Then
                If rDatos("descripcion") IsNot DBNull.Value Then
                    Me.vdescripcion = rDatos("descripcion")
                    'Me.vidCalendario = rDatos("idCalendario")
                    'Me.vNombreActividad = rDatos("NombreActividad")
                    'Me.vTipoActividad = rDatos("TipoActividad")
                    'Me.vdescripcion = rDatos("Descripcion")
                    'Me.FechaInicio = rDatos("FechaInicio")
                    'Me.FechaFin = rDatos("FechaFin")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
End Class
