Imports CapaDatos
Public Class SEGURIDAD_PERMISOS
    Implements IIndividual

    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)




#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_PERMISOS WHERE CVE_Permiso=" & vCve_Permiso, "SEGURIDAD_PERMISOS")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Permiso")) Then
                    Me.vCve_Permiso = rDatos("CVE_Permiso")
                Else
                    Me.vCve_Permiso = 0
                End If
                If Not IsDBNull(rDatos("Descripcion")) Then
                    Me.vDescripcion = rDatos("Descripcion")
                Else
                    Me.vDescripcion = ""
                End If
                If Not IsDBNull(rDatos("Nombre_Corto")) Then
                    Me.vNombre_Corto = rDatos("Nombre_Corto")
                Else
                    Me.vNombre_Corto = ""
                End If
                If Not IsDBNull(rDatos("CVE_CATEGORIA_PERMISO")) Then
                    Me.vCVE_CATEGORIA_PERMISO = rDatos("CVE_CATEGORIA_PERMISO")
                Else
                    Me.vCVE_CATEGORIA_PERMISO = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        
    End Sub
#End Region


#Region "Atributos"
    Private vCve_Permiso As Long
    Private vDescripcion As String
    Private vNombre_Corto As String
    Private vCVE_CATEGORIA_PERMISO As Integer
#End Region


#Region "Propiedades"
    Public Property Cve_Permiso() As Long Implements IIndividual.Id
        Get
            Return vCve_Permiso
        End Get
        Set(ByVal value As Long)
            vCve_Permiso = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Public Property Nombre_Corto() As String
        Get
            Return vNombre_Corto
        End Get
        Set(ByVal value As String)
            vNombre_Corto = value
        End Set
    End Property

    Public Property CVE_CATEGORIA_PERMISO() As Integer
        Get
            Return vCVE_CATEGORIA_PERMISO
        End Get
        Set(ByVal value As Integer)
            vCVE_CATEGORIA_PERMISO = value
        End Set
    End Property
#End Region
End Class
