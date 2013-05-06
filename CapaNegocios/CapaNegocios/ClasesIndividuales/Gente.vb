Imports CapaDatos
Public Class Gente
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("update gente set cod_empleado_eliminacion='" & vcod_empleado_eliminacion & "',fecha_eliminacion='" & vfecha_eliminacion.ToString("MM-dd-yyyy HH:mm") & "',estatus='0' where cve_gente=" & vcve_gente)
        Catch ex As Exception
            MsgBox("Error al eliminar desecho. CGente_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_gente
        End Get
        Set(ByVal value As Long)
            vcve_gente = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_gente
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into gente(cve_registro_turno,cod_empleado_registro,fecha_registro,cve_detalle_gente,cantidad,comentarios,estatus) " &
                              "values(" & vcve_registro_turno & ",'" & vcod_empleado_registro & "','" & vfecha_registro.ToString("MM-dd-yyyy HH:mm") & "'," & vcve_detalle_gente & "," & vcantidad & ",'" & vcomentarios & "','1')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al insertar gente. CGente_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_gente As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As DateTime
    Private vcve_detalle_gente As Long
    Private vcantidad As Long
    Private vcomentarios As String
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As DateTime
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_gente() As Long
        Get
            Return vcve_gente
        End Get
        Set(ByVal value As Long)
            vcve_gente = value
        End Set
    End Property
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
        End Set
    End Property
    Public Property cod_empleado_registro() As String
        Get
            Return vcod_empleado_registro
        End Get
        Set(ByVal value As String)
            vcod_empleado_registro = value
        End Set
    End Property
    Public Property fecha_registro() As DateTime
        Get
            Return vfecha_registro
        End Get
        Set(ByVal value As DateTime)
            vfecha_registro = value
        End Set
    End Property
    Public Property cve_detalle_gente() As Long
        Get
            Return vcve_detalle_gente
        End Get
        Set(ByVal value As Long)
            vcve_detalle_gente = value
        End Set
    End Property
    Public Property cantidad() As Long
        Get
            Return vcantidad
        End Get
        Set(ByVal value As Long)
            vcantidad = value
        End Set
    End Property
    Public Property comentarios() As String
        Get
            Return vcomentarios
        End Get
        Set(ByVal value As String)
            vcomentarios = value
        End Set
    End Property
    Public Property cod_empleado_eliminacion() As String
        Get
            Return vcod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vcod_empleado_eliminacion = value
        End Set
    End Property
    Public Property fecha_eliminacion() As DateTime
        Get
            Return vfecha_eliminacion
        End Get
        Set(ByVal value As DateTime)
            vfecha_eliminacion = value
        End Set
    End Property
    Public Property estatus() As String
        Get
            Return vestatus
        End Get
        Set(ByVal value As String)
            vestatus = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_gente_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select g.cve_gente,dg.descripcion,g.cantidad,g.comentarios " &
            "from gente g join detalle_gente dg on g.cve_detalle_gente=dg.cve_detalle_gente " &
            "where g.cve_registro_turno=" & vcve_registro_turno & " and g.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de gente. CGente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class
