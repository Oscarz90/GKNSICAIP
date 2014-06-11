Public Class Relacion_Linea_Clasificacion
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oComponente As Componente
    Dim oEquipo_Linea As EquipoLinea

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from relacion_linea_clasificacion rlc where rlc.cve_relacion_linea_clasificacion=" & vcve_relacion_linea_clasificacion, "Relacion_Linea_Clasificacion")
        If vDR IsNot Nothing Then
            If Not IsDBNull(vDR("cve_relacion_linea_clasificacion")) Then
                Me.vcve_relacion_linea_clasificacion = vDR("cve_relacion_linea_clasificacion")
            End If
            If Not IsDBNull(vDR("cve_linea")) Then
                Me.vcve_linea = vDR("cve_linea")
            End If
            If Not IsDBNull(vDR("cve_linea_clasificacion")) Then
                Me.vcve_linea_clasificacion = vDR("cve_linea_clasificacion")
            End If
            If Not IsDBNull(vDR("cve_linea_clasificacion")) Then
                Me.vcve_linea_clasificacion = vDR("cve_linea_clasificacion")
            End If
            If Not IsDBNull(vDR("fecha_inicio")) Then
                Me.vfecha_inicio = vDR("fecha_inicio")
            End If
            If Not IsDBNull(vDR("fecha_final")) Then
                Me.vfecha_final = vDR("fecha_final")
            End If
        End If
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
        Using scope As New TransactionScope()
            
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_relacion_linea_clasificacion As Long
    Private vcve_linea As Long
    Private vcve_linea_clasificacion As Long
    Private vfecha_inicio As DateTime
    Private vfecha_final As Long
#End Region
#Region "Propiedades"
    Public Property cve_relacion_linea_clasificacion() As Long
        Get
            Return vcve_relacion_linea_clasificacion
        End Get
        Set(ByVal value As Long)
            vcve_relacion_linea_clasificacion = value
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
    Public Property cve_line_clasificacion() As Long
        Get
            Return vcve_linea_clasificacion
        End Get
        Set(ByVal value As Long)
            vcve_linea_clasificacion = value
        End Set
    End Property
    Public Property fecha_inicio() As DateTime
        Get
            Return vfecha_inicio
        End Get
        Set(ByVal value As DateTime)
            vfecha_inicio = value
        End Set
    End Property
    Public Property fecha_final() As Long
        Get
            Return vfecha_final
        End Get
        Set(ByVal value As Long)
            vfecha_final = value
        End Set
    End Property   
#End Region
#Region "Catalogos"
    Public Function obtiene_tabla() As DataTable
        Dim oCLT As DataTable
        Using scope As New TransactionScope()
            Try
                oCLT = oBD.ObtenerTabla("select * from relacion_linea_clasificacion")
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar obtener asignación clasificación de linea. CRelacion_Linea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
                oCLT = Nothing
            End Try
            Return oCLT
        End Using
    End Function
    Public Function obtiene_asignacion_linea_clasificacion() As DataTable
        Dim oCLT As DataTable
        Using scope As New TransactionScope()
            Try
                oCLT = oBD.ObtenerTabla("select rlc.cve_relacion_linea_clasificacion,l.linea,lc.nombre,rlc.fecha_inicio,rlc.fecha_final" &
                                        " from relacion_linea_clasificacion rlc" &
                                        " join linea l on rlc.cve_linea=l.cve_linea" &
                                        " join linea_clasificacion lc on rlc.cve_linea_clasificacion=lc.cve_linea_clasificacion" &
                                        " order by rlc.cve_linea,rlc.fecha_inicio")
            Catch ex As Exception
                MsgBox("Surgió un problema al intentar obtener asignación clasificación de linea. CRelacion_Linea_Clasificacion", vbExclamation + vbOKOnly, "Warning")
                oCLT = Nothing
            End Try
            Return oCLT
        End Using
    End Function
#End Region
End Class
