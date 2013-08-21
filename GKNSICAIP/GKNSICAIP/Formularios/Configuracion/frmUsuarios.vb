Imports CapaNegocios
Public Class FrmUsuarios
    Dim oUsuario As SEGURIDAD_USUARIO
    Public vId_Publico As Long = 0
    Public vId_Retorno As Long = 0


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If MsgBox("¿Esta seguro de Dar de Baja al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oUsuario.Eliminar()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        If MsgBox("¿Esta seguro de Dar de Alta al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oUsuario.Estatus = "1"
                oUsuario.Registrar()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ofrmImportar_Tipo_Usuario As New FrmImportador_TipoUsuario
        ofrmImportar_Tipo_Usuario.ShowDialog()
        oUsuario.CVE_TIPO_USUARIO = ofrmImportar_Tipo_Usuario.vRetorno_CVE_TIPO_USUARIO
        txtTipo_Usuario.Text = oUsuario.Descripcion_Tipo_Usuario
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oUsuario.Id_Usuario = txtId_Usuario.Text
            oUsuario.Pass = txtPass.Text
            oUsuario.Nombre = txtNombre.Text
            oUsuario.Email = txtEmail.Text
            Try
                oUsuario.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("¿Esta seguro de registrar el nuevo Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oUsuario.CVE_Usuario = 0
            oUsuario.Id_Usuario = txtId_Usuario.Text
            oUsuario.Pass = txtPass.Text
            oUsuario.Nombre = txtNombre.Text
            oUsuario.Email = txtEmail.Text            

            Try
                oUsuario.Registrar()
                vId_Retorno = oUsuario.CVE_Usuario
                MsgBox("Se registro correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''La Siguiente Linea solo es para hacer pruebas sobre un SEGURIDAD_USUARIO de Prueba(El cual se agrego y se modifico de forma Exitosa)
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 936

        If Convert.ToInt64(vId_Publico) <> 0 Then
            oUsuario = New SEGURIDAD_USUARIO
            oUsuario.CVE_Usuario = vId_Publico
            oUsuario.Cargar()
            Controles_Registro_Nuevo(False)
            If oUsuario.Estatus = "INACTIVO" Then
                Controles_Registro_Inactivo(True)
            Else
                Controles_Registro_Inactivo(False)
            End If
        Else
            oUsuario = New SEGURIDAD_USUARIO
            oUsuario.Estatus = "1"
            Controles_Registro_Nuevo(True)
        End If
        SetBindings()
        Me.Show()
        Me.txtId_Usuario.Focus()
    End Sub

    Private Sub SetBindings()
        Me.txtId_Usuario.DataBindings.Clear()
        Me.txtPass.DataBindings.Clear()
        Me.txtNombre.DataBindings.Clear()
        Me.txtEmail.DataBindings.Clear()
        Me.txtTipo_Usuario.DataBindings.Clear()

        Me.txtId_Usuario.DataBindings.Add("Text", oUsuario, "Id_Usuario")
        Me.txtPass.DataBindings.Add("Text", oUsuario, "Pass")
        Me.txtNombre.DataBindings.Add("Text", oUsuario, "Nombre")
        Me.txtEmail.DataBindings.Add("Text", oUsuario, "Email")
        Me.txtTipo_Usuario.DataBindings.Add("Text", oUsuario, "Descripcion_Tipo_Usuario")
        Me.txtEstatus.DataBindings.Add("Text", oUsuario, "Estatus")
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            btnBaja.Enabled = False
        Else
            btnRegistrar.Visible = False
            btnModificar.Visible = True
            btnBaja.Enabled = True
        End If
    End Sub

    Private Sub Controles_Registro_Inactivo(ByVal vEs_Registro_Inactivo As Boolean)
        If vEs_Registro_Inactivo = True Then
            btnRegistrar.Enabled = False
            btnModificar.Enabled = False
            btnBaja.Enabled = False
            btnBaja.Visible = False
            btnImportar.Enabled = False
            btnAlta.Visible = True
            btnAlta.Enabled = True


            txtId_Usuario.ReadOnly = True
            txtEmail.ReadOnly = True
            txtNombre.ReadOnly = True
        Else
            btnAlta.Visible = False
            btnAlta.Enabled = False
            btnBaja.Visible = True
            btnBaja.Enabled = True
        End If
    End Sub


    Private Sub txtId_Usuario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId_Usuario.Validated
        Me.txtEmail.Text = txtId_Usuario.Text & "@gkndriveline.com"
    End Sub

    Private Sub txtEmail_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Validated
        Me.txtEmail.Text = txtId_Usuario.Text & "@gkndriveline.com"
    End Sub

   
End Class
