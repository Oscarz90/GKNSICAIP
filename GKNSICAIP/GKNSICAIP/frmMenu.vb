Imports CapaNegocios


Public Class FrmMenu
    Public user_maq As String
    Public oUsuario_Login As Login
    Dim ofrmLogin As New frmLogin

#Region "Opciones De Menu"
    Private Sub btnOpSICAIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSICAIP.Click
        ofrmLogin.ShowDialog()
    End Sub

    Private Sub btnOpCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpCalculadora.Click
        'Process.Start("exe")
    End Sub
#End Region
    

    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario_Login = New Login
        user_maq = Environment.UserName
        Dim ofrmFormulario_Principal As New Formulario_Principal

        If oUsuario_Login.Usuario_NO_Sindicalizado(user_maq) = True Then
            ofrmFormulario_Principal.Show()
        End If
    End Sub

End Class
