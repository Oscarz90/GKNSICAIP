Imports CapaDatos
Public Class Modificacion_Permiso
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from modificacion_permiso mp where mp.cve_modificacion_permiso=" & vcve_modificacion_permiso, "modificacion_permiso")
        If vDR IsNot Nothing Then
            vcve_modificacion_permiso = vDR("cve_modificacion_permiso")
            vcve_usuario = vDR("cve_usuario")
            vdia_modificacion = vDR("dia_modificacion")
            vfecha_inicio = vDR("fecha_inicio")
            vfecha_final = vDR("fecha_final")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub
    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_modificacion_permiso
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Dim queryInsert As String = "insert into modificacion_permiso " &
            "values (" & vcve_usuario & ",'" & vdia_modificacion.ToString("MM-dd-yyyy") & "','" & vfecha_inicio.ToString("MM-dd-yyyy") & "','" & vfecha_final.ToString("MM-dd-yyyy") & "')"
        Using scope As New TransactionScope
            Try
                oBD.EjecutarQuery(queryInsert)
            Catch ex As Exception
                MsgBox("Problema al Registrar Permiso Modificacion. CModificacion_Permiso_ERROR", vbExclamation + vbOKOnly, "Problema")
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_modificacion_permiso As Long
    Private vcve_usuario As Long
    Private vdia_modificacion As DateTime
    Private vfecha_inicio As DateTime
    Private vfecha_final As DateTime
#End Region
#Region "Propiedades"
    Public Property cve_modificacion_permiso() As Long
        Get
            Return vcve_modificacion_permiso
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso = value
        End Set
    End Property
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property
    Public Property dia_modificacion() As DateTime
        Get
            Return vdia_modificacion
        End Get
        Set(ByVal value As Date)
            vdia_modificacion = value
        End Set
    End Property
    Public Property fecha_inicio() As DateTime
        Get
            Return vfecha_inicio
        End Get
        Set(ByVal value As Date)
            vfecha_inicio = value
        End Set
    End Property
    Public Property fecha_final() As DateTime
        Get
            Return vfecha_final
        End Get
        Set(ByVal value As DateTime)
            vfecha_final = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"

#End Region

End Class
