Imports CapaNegocios

Public Class FrmMenu
    Public user_maq As String
    Public oUsuario_Login As SEGURIDAD_USUARIO

#Region "Opciones De Menu"
    Private Sub btnOpSICAIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpSICAIP.Click
        Dim ofrmLogin As New frmLogin
        ofrmLogin.ShowDialog()
    End Sub

    Private Sub btnOpCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpCalculadora.Click
        Try            
            Process.Start("\\celsr014\gknsicaip$\CALCULADORA\calculadorPrestaciones.exe")
        Catch ex As Exception
            MsgBox("No se encontro la ruta de la aplicacion. Error 0001")
        End Try
    End Sub
#End Region
    
    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario_Login = New SEGURIDAD_USUARIO
        user_maq = Environment.UserName       
        Dim ofrmFormulario_Principal As New Formulario_Principal

        If oUsuario_Login.Usuario_NO_Sindicalizado(user_maq) = True Then
            oUsuario_Login.Cargar()
            ofrmFormulario_Principal.oUsuario_Login = oUsuario_Login
            ofrmFormulario_Principal.ShowDialog()


            Me.Close()
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

End Class
