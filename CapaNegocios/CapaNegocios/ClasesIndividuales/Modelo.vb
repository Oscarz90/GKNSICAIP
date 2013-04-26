Imports CapaDatos
Public Class Modelo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM modelo WHERE cve_modelo=" & vcve_modelo, "modelo")
            If rDatos IsNot Nothing Then
                If rDatos("cve_modelo") IsNot DBNull.Value Then
                    Me.vcve_modelo = rDatos("cve_modelo")
                    Me.vcve_componente = rDatos("cve_componente")
                    Me.vcve_clasificacion_modelo = rDatos("cve_clasificacion_modelo")
                    Me.vnp_gkn = rDatos("np_gkn")
                    Me.vdescripcion = rDatos("descripcion")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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
    'Auxiliares
    Private vcve_linea As Long

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



    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property





#End Region
#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_Modelos_Linea() As DataTable
        Dim dtModelos As New DataTable
        Try
            dtModelos = oBD.ObtenerTabla("select m.cve_modelo,m.np_gkn from linea l " &
                                         "join TC tc on l.cve_linea=tc.cve_linea " &
                                         "join modelo m on tc.cve_modelo=m.cve_modelo " &
                                         "where l.cve_linea=" & vcve_linea)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_MODELOS_DE_LINEA_CModelo")
            dtModelos = Nothing
        End Try
        Return dtModelos
    End Function
    Public Function llena_combo_Modelos_Linea_Salida() As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "get_lista_modelos_salida"
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@cve_modelo", SqlDbType.VarChar).Value = Me.vcve_modelo
                Dim obj As DataTable = oBD.EjecutaCommando(vComando)
                'oBD.EjecutaProcedimientos(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
                Return obj
            Catch 'ex As Exception
                MsgBox("Error al obtener modelos de salida. CModelo_ERROR", vbCritical + vbOKOnly, "Error")
                'Throw New Exception(ex.Message)
                Return Nothing
            End Try
        End Using
    End Function
    Public Sub obtener_descripcion_modelo()
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("Select descripcion from modelo where cve_modelo=" & Me.vcve_modelo, "modelos")
            If rDatos IsNot Nothing Then
                If rDatos("descripcion") IsNot DBNull.Value Then
                    Me.vdescripcion = rDatos("descripcion")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
End Class
