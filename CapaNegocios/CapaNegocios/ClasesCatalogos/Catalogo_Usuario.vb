Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Usuario
        Dim cadena_conexion As New conexiones


        Private vL_Usuario As List(Of SEGURIDAD_USUARIO)
        Public Property L_Usuario() As List(Of SEGURIDAD_USUARIO)
            Get
                If vL_Usuario Is Nothing Then
                    'Cargo TIPO_USUARIO
                    Me.L_Usuario = New List(Of SEGURIDAD_USUARIO)
                    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
                    Dim oEq As DataTable = oBD.ObtenerTabla("SELECT CVE_Usuario FROM SEGURIDAD_USUARIO")
                    If oEq IsNot Nothing Then
                        Dim oUsuario As SEGURIDAD_USUARIO = Nothing
                        For Each row As DataRow In oEq.Rows
                            oUsuario = New SEGURIDAD_USUARIO
                            oUsuario.Cve_usuario = row("CVE_Usuario")
                            oUsuario.Cargar()
                            Me.vL_Usuario.Add(oUsuario)
                        Next
                    End If
                End If
                Return Me.vL_Usuario
            End Get
            Set(ByVal value As List(Of SEGURIDAD_USUARIO))
                Me.vL_Usuario = value
            End Set
        End Property
    End Class
End Namespace
