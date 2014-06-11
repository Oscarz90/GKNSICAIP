Public Class Relacion_Linea_Clasificacion
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oComponente As Componente
    Dim oEquipo_Linea As EquipoLinea

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from linea_clasificacion lc where lc.cve_linea_clasificacion=" & vcve_linea_clasificacion, "Linea_Clasificacion")
        If vDR IsNot Nothing Then
            If Not IsDBNull(vDR("cve_linea_clasificacion")) Then
                Me.vcve_linea_clasificacion = vDR("cve_linea_clasificacion")
            End If
            If Not IsDBNull(vDR("nombre")) Then
                Me.vnombre = vDR("nombre")
            End If
            If Not IsDBNull(vDR("descripcion")) Then
                Me.vdescripcion = vDR("descripcion")
            End If
            If Not IsDBNull(vDR("estatus")) Then
                Me.estatus = vDR("estatus")
            End If
        End If
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Using scope As New TransactionScope()
            Try
                oBD.EjecutarQuery("update linea_clasificacion set estatus='0' where cve_linea_clasificacion=" & Me.vcve_linea_clasificacion)
                MsgBox("La Baja de clasificacion Linea se realizo correctamente")
                scope.Complete()
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar eliminar clasificación de linea. CLinea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
            End Try
        End Using
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
        Using scope As New TransactionScope()
            Try
                oBD.EjecutarQuery("insert into linea_clasificacion(nombre,descripcion,estatus) values('" & vnombre & "','" & vdescripcion & "','" & vestatus & "')")
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar registrar clasificación de linea. CLinea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_linea_clasificacion As Long
    Private vnombre As String
    Private vdescripcion As String
    Private vestatus As String

#End Region
#Region "Propiedades"
    Public Property cve_line_clasificacion() As Long
        Get
            Return vcve_linea_clasificacion
        End Get
        Set(ByVal value As Long)
            vcve_linea_clasificacion = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return vnombre
        End Get
        Set(ByVal value As String)
            vnombre = value
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
    Public Property estatus() As String
        Get
            Return vestatus
        End Get
        Set(ByVal value As String)
            vestatus = value
        End Set
    End Property
#End Region
#Region "Catalogos"
    Public Function obtiene_tabla() As DataTable
        Dim oCLT As DataTable
        Using scope As New TransactionScope()
            Try
                oCLT = oBD.ObtenerTabla("select * from linea_clasificacion")
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar obtener clasificación de linea. CLinea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
                oCLT = Nothing
            End Try
            Return oCLT
        End Using
    End Function
    Public Function obtiene_linea_clasificacion_activos() As DataTable
        Dim oCLT As DataTable
        Using scope As New TransactionScope()
            Try
                oCLT = oBD.ObtenerTabla("select * from linea_clasificacion" &
                                        " where estatus='1'")
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar obtener clasificación de linea. CLinea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
                oCLT = Nothing
            End Try
            Return oCLT
        End Using
    End Function
#End Region
End Class
