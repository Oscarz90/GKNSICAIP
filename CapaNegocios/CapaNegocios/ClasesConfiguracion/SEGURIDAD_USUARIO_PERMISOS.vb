Imports CapaDatos

Public Class SEGURIDAD_USUARIO_PERMISOS
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
    Dim oPermisos As SEGURIDAD_PERMISOS
    Public vRetorno_nombreCorto As String

#Region "Atributos"
    Private vCVE_Usuario_Permisos As Long
    Private vCVE_USUARIO As Long
    Private vCVE_PERMISO As Long
#End Region

#Region "Propiedades"
    Public Property CVE_Usuario_Permisos() As Long Implements IIndividual.Id
        Get
            Return vCVE_Usuario_Permisos
        End Get
        Set(ByVal value As Long)
            vCVE_Usuario_Permisos = value
        End Set
    End Property

    Public Property CVE_USUARIO() As Long
        Get
            Return vCVE_USUARIO
        End Get
        Set(ByVal value As Long)
            vCVE_USUARIO = value
        End Set
    End Property

    Public Property CVE_PERMISO() As Long
        Get
            Return vCVE_PERMISO
        End Get
        Set(ByVal value As Long)
            vCVE_PERMISO = value
        End Set
    End Property

    Public ReadOnly Property Nombre_Corto_Permiso() As String
        Get
            If vCVE_PERMISO <> 0 Then
                oPermisos = New SEGURIDAD_PERMISOS() With {.Cve_Permiso = vCVE_PERMISO}
                oPermisos.Cargar()
                Return oPermisos.Nombre_Corto
            Else
                Return ""
            End If
        End Get
    End Property


    Private vNombre_Short As String
    Public Property Nombre_Short() As String
        Get
            If vCVE_PERMISO <> 0 Then
                oPermisos = New SEGURIDAD_PERMISOS() With {.Cve_Permiso = vCVE_PERMISO}
                oPermisos.Cargar()
                Return oPermisos.Nombre_Corto
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            vNombre_Short = value
        End Set
    End Property



#End Region

#Region "IIndividual"


    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_USUARIO_PERMISOS WHERE CVE_Usuario_Permisos=" & vCVE_Usuario_Permisos, "SEGURIDAD_USUARIO_PERMISOS")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Usuario_Permisos")) Then
                    Me.vCVE_Usuario_Permisos = rDatos("CVE_Usuario_Permisos")
                Else
                    Me.vCVE_Usuario_Permisos = 0
                End If
                If Not IsDBNull(rDatos("CVE_USUARIO")) Then
                    Me.vCVE_USUARIO = rDatos("CVE_USUARIO")
                Else
                    Me.vCVE_USUARIO = 0
                End If
                If Not IsDBNull(rDatos("CVE_PERMISO")) Then
                    Me.vCVE_PERMISO = rDatos("CVE_PERMISO")
                Else
                    Me.vCVE_PERMISO = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("DELETE SEGURIDAD_USUARIO_PERMISOS where CVE_USUARIO =" & vCVE_USUARIO)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 0
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_USUARIO_PERMISOS"}
                With cmd.Parameters
                    .Add("CVE_Usuario_Permisos", SqlDbType.BigInt).Value = Me.vCVE_Usuario_Permisos
                    .Add("CVE_USUARIO", SqlDbType.BigInt).Value = Me.vCVE_USUARIO
                    .Add("CVE_PERMISO", SqlDbType.BigInt).Value = Me.vCVE_PERMISO
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCVE_USUARIO = obj.Rows(0)(0) 'ID
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region



End Class
