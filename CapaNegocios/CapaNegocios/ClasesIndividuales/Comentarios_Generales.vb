Imports CapaDatos
Public Class Comentarios_Generales
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"


    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery(String.Format("update comentarios_generales set cod_empleado_eliminacion='{0}',fecha_eliminacion='{1:MM-dd-yyyy HH:mm}',estatus='0' where cve_comentarios_generales={2}", vcod_empleado_eliminacion, vfecha_eliminacion, vcve_comentarios_generales))
        Catch ex As Exception
            MsgBox("Error al eliminar comentario. CComentarios_Generales_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_comentarios_generales
        End Get
        Set(ByVal value As Long)
            vcve_comentarios_generales = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return vcve_comentarios_generales
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into comentarios_generales(cve_registro_turno,cod_empleado_registro,fecha_registro,comentarios,estatus) " &
                            "values(" & vcve_registro_turno & ",'" & vcod_empleado_registro & "','" & vfecha_registro.ToString("MM-dd-yyyy HH:mm") & "','" & vcomentarios & "','1')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al insertar comentario_General. CComentarios_Generales_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"

    Private vcve_comentarios_generales As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As DateTime
    Private vcomentarios As String
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As DateTime
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_comentarios_generales() As Long
        Get
            Return vcve_comentarios_generales
        End Get
        Set(ByVal value As Long)
            vcve_comentarios_generales = value
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
    Public Function llena_comentarios_generales_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select cg.cve_comentarios_generales,cg.comentarios from comentarios_generales cg " &
            "where cg.estatus='1' and cg.cve_registro_turno=" & vcve_registro_turno
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de comentarios_generales. CComentarios_Generales_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class
