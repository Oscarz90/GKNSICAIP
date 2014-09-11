Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Tipo_Usuario
        Dim cadena_conexion As New conexiones


        Private vL_Tipo_Usuario As List(Of Tipo_Usuario)
        Public Property L_Tipo_Usuario() As List(Of Tipo_Usuario)
            Get
                If vL_Tipo_Usuario Is Nothing Then
                    'Cargo TIPO_USUARIO
                    Me.L_Tipo_Usuario = New List(Of Tipo_Usuario)
                    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
                    Dim oEq As DataTable = oBD.ObtenerTabla("SELECT CVE_Tipo_Usuario FROM SEGURIDAD_TIPO_USUARIO")
                    If oEq IsNot Nothing Then
                        Dim oTipo_Usuario As Tipo_Usuario = Nothing
                        For Each row As DataRow In oEq.Rows
                            oTipo_Usuario = New Tipo_Usuario
                            oTipo_Usuario.CVE_Tipo_Usuario = row("CVE_Tipo_Usuario")
                            oTipo_Usuario.Cargar()
                            Me.vL_Tipo_Usuario.Add(oTipo_Usuario)
                        Next
                    End If
                End If
                Return Me.vL_Tipo_Usuario
            End Get
            Set(ByVal value As List(Of Tipo_Usuario))
                Me.vL_Tipo_Usuario = value
            End Set
        End Property
    End Class
End Namespace

