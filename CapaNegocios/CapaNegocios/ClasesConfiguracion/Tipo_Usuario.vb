Imports CapaDatos
Imports System.Data.SqlClient

Public Class Tipo_Usuario
    Implements IIndividual

    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_TIPO_USUARIO WHERE CVE_Tipo_Usuario=" & vCVE_Tipo_Usuario, "SEGURIDAD_TIPO_USUARIO")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Tipo_Usuario")) Then
                    Me.vCVE_Tipo_Usuario = rDatos("CVE_Tipo_Usuario")
                Else
                    Me.vCVE_Tipo_Usuario = 0
                End If
                If Not IsDBNull(rDatos("Nombre_Tipo_Usuario")) Then
                    Me.vNombre_Tipo_Usuario = rDatos("Nombre_Tipo_Usuario")
                Else
                    Me.vNombre_Tipo_Usuario = ""
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("DELETE SEGURIDAD_TIPO_USUARIO WHERE CVE_Tipo_Usuario=" & Me.vCVE_Tipo_Usuario)
            MsgBox("Se elimino correctamente el Tipo de Usuario")
        Catch ex As Exception
            MsgBox("No se puede eliminar este registro, el Tipo de Usuario se encuentra asignado en un Usuario")
        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_SEGURIDAD_TIPO_USUARIO"}
                With cmd.Parameters
                    .Add("CVE_Tipo_Usuario", SqlDbType.BigInt).Value = Me.vCVE_Tipo_Usuario
                    .Add("Nombre_Tipo_Usuario", SqlDbType.VarChar).Value = Me.vNombre_Tipo_Usuario
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCVE_Tipo_Usuario = obj.Rows(0)(0) 'ID
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region

#Region "Atributos"
    Private vNombre_Tipo_Usuario As String
    Dim vCVE_Tipo_Usuario As Long
#End Region

#Region "Propiedades"
    Public Property Nombre_Tipo_Usuario() As String
        Get
            Return vNombre_Tipo_Usuario
        End Get
        Set(ByVal value As String)
            vNombre_Tipo_Usuario = value
        End Set
    End Property

    Public Property CVE_Tipo_Usuario As Long Implements IIndividual.Id
        Get
            Return vCVE_Tipo_Usuario
        End Get
        Set(ByVal value As Long)
            vCVE_Tipo_Usuario = value
        End Set
    End Property
#End Region

#Region "Metodos Generales"
    Public Function Obtener_Tipos_Usuarios() As DataTable
        Dim vDT As DataTable = oBD.ObtenerTabla("select CVE_Tipo_Usuario, Nombre_Tipo_Usuario as Descripcion from SEGURIDAD_TIPO_USUARIO")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Tipos_Usuarios(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable = oBD.ObtenerTabla(String.Format("select CVE_Tipo_Usuario, Nombre_Tipo_Usuario as Descripcion from SEGURIDAD_TIPO_USUARIO where Nombre_Tipo_Usuario LIKE '%{0}%'", vFiltro))
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function
#End Region
End Class
