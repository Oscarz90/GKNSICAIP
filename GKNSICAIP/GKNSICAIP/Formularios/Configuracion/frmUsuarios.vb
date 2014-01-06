Imports CapaNegocios
Imports System.Transactions

Public Class FrmUsuarios
    Dim oUsuario As SEGURIDAD_USUARIO
    Public vId_Publico As Long = 0
    Public vId_Retorno As Long = 0
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True
    Dim oCadena_Valor As New Cadena_Valor
    Dim oComponente As New Componente
    Dim oLista_Componentes As New List(Of String)
    Dim oLista_CV As New List(Of String)
    Dim vValida_Usuario_Red As Integer = 0
    Dim vValida_Nombre As Integer = 0
    Dim vValida_Tipo_Usuario As Integer = 0
    Dim vEmail_Respaldo As String = ""


    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        If MsgBox("¿Esta seguro de Desactivar al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oUsuario.Eliminar()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        If MsgBox("¿Esta seguro de Activar al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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
        vValida_Tipo_Usuario = txtTipo_Usuario.Text.Count
        If vValida_Usuario_Red > 0 And vValida_Nombre > 0 And vValida_Tipo_Usuario > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If        
        Call opActivar_Nivel_ToggleStateChanged(Nothing, Nothing)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oUsuario.Id_Usuario = txtId_Usuario.Text
            oUsuario.Pass = txtPass.Text
            oUsuario.Nombre = txtNombre.Text
            'oUsuario.Email = txtEmail.Text
            oUsuario.Email = vEmail_Respaldo
            Try
                oUsuario.Registrar()
                If opActivar_Nivel.Checked = True Then
                    oUsuario.Eliminar_Nivel_Usuario(oUsuario.CVE_Usuario)                    
                    If radUsuario_Componente.IsChecked = True Then
                        For Each vElemento As String In oLista_Componentes
                            oUsuario.Registrar_Nivel_Usuario(True, Long.Parse(vElemento), oUsuario.CVE_Usuario)
                        Next
                    Else
                        For Each vElemento As String In oLista_CV
                            oUsuario.Registrar_Nivel_Usuario(False, Long.Parse(vElemento), oUsuario.CVE_Usuario)
                        Next
                    End If

                Else
                    oUsuario.Eliminar_Nivel_Usuario(oUsuario.CVE_Usuario)
                End If
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If vValida_Usuario_Red > 0 And vValida_Nombre > 0 And vValida_Tipo_Usuario > 0 Then
            btnRegistrar.Enabled = True
            If MsgBox("¿Esta seguro de registrar el nuevo Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oUsuario.CVE_Usuario = 0
                oUsuario.Id_Usuario = txtId_Usuario.Text
                oUsuario.Pass = txtPass.Text
                oUsuario.Nombre = txtNombre.Text
                'oUsuario.Email = txtEmail.Text
                oUsuario.Email = vEmail_Respaldo
                Using scope As New TransactionScope()
                    Try
                        oUsuario.Registrar()
                        If opActivar_Nivel.Checked = True Then
                            oUsuario.Eliminar_Nivel_Usuario(oUsuario.CVE_Usuario)
                            If radUsuario_Componente.IsChecked = True Then
                                For Each vElemento As String In oLista_Componentes
                                    oUsuario.Registrar_Nivel_Usuario(True, Long.Parse(vElemento), oUsuario.CVE_Usuario)
                                Next
                            Else
                                For Each vElemento As String In oLista_CV
                                    oUsuario.Registrar_Nivel_Usuario(False, Long.Parse(vElemento), oUsuario.CVE_Usuario)
                                Next
                            End If
                        End If
                        vId_Retorno = oUsuario.CVE_Usuario
                        MsgBox("Se registro correctamente")
                        scope.Complete()
                    Catch ex As Exception

                    End Try
                End Using

                Me.Close()
            End If
        Else
            btnRegistrar.Enabled = False
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
            Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)

            Call opActivar_Nivel_ToggleStateChanged(Nothing, Nothing)

            If oUsuario.Cve_Componente <> 0 Then
                radUsuario_Componente.IsChecked = True
                'ddlComponente_W.Enabled = True
                btnComponente.Enabled = True
            Else
                'ddlComponente_W.Enabled = False
                btnComponente.Enabled = False
            End If
            If oUsuario.Cve_CV <> 0 Then
                radUsuario_CV.IsChecked = True
                'ddlCadena_Valor_W.Enabled = True
                btnCadena_Valor.Enabled = True                
            Else
                'ddlCadena_Valor_W.Enabled = False
                btnCadena_Valor.Enabled = False
            End If

            If oUsuario.Cve_CV = 0 And oUsuario.Cve_Componente = 0 Then
                opActivar_Nivel.Checked = False
            Else
                opActivar_Nivel.Checked = True
            End If


            If oUsuario.Estatus = "INACTIVO" Then
                Controles_Registro_Inactivo(True)
            Else
                Controles_Registro_Inactivo(False)
            End If
        Else
            oUsuario = New SEGURIDAD_USUARIO
            oUsuario.Estatus = "1"
            Controles_Registro_Nuevo(True)
            Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
            opActivar_Nivel.Checked = False
        End If
        'LlenaCombos()
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
        'Me.ddlCadena_Valor_W.DataBindings.Clear()
        'Me.ddlComponente_W.DataBindings.Clear()

        'If oUsuario.Cve_Componente <> 0 Then            
        '    Me.ddlComponente_W.DataBindings.Add("SelectedValue", oUsuario, "Cve_Componente")
        'End If
        'If oUsuario.Cve_CV <> 0 Then
        '    Me.ddlCadena_Valor_W.DataBindings.Add("SelectedValue", oUsuario, "Cve_CV")
        'End If
        Me.txtId_Usuario.DataBindings.Add("Text", oUsuario, "Id_Usuario")
        Me.txtPass.DataBindings.Add("Text", oUsuario, "Pass")
        Me.txtNombre.DataBindings.Add("Text", oUsuario, "Nombre")
        Me.txtEmail.DataBindings.Add("Text", oUsuario, "Email")
        Me.txtTipo_Usuario.DataBindings.Add("Text", oUsuario, "Descripcion_Tipo_Usuario")
        Me.txtEstatus.DataBindings.Add("Text", oUsuario, "Estatus")
    End Sub

    'Private Sub LlenaCombos()
    '    Me.ddlCadena_Valor_W.DisplayMember = "cadena"
    '    Me.ddlCadena_Valor_W.ValueMember = "cve_cadena_valor"
    '    Me.ddlCadena_Valor_W.DataSource = oCadena_Valor.Obtener_Cadenas_Valor

    '    Me.ddlComponente_W.DisplayMember = "componente"
    '    Me.ddlComponente_W.ValueMember = "cve_componente"
    '    Me.ddlComponente_W.DataSource = oComponente.Obtener_Componentes

    'End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            btnBaja.Enabled = False
            btnAlta.Enabled = False
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

            rgbGrupo_Nivel.Enabled = False
            opActivar_Nivel.Enabled = False

            txtId_Usuario.ReadOnly = True
            txtEmail.ReadOnly = True
            txtNombre.ReadOnly = True
        Else
            btnAlta.Visible = False
            'btnAlta.Enabled = False
            btnBaja.Visible = True
            'btnBaja.Enabled = True
            rgbGrupo_Nivel.Enabled = True
            opActivar_Nivel.Enabled = True
        End If
    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnRegistrar.Enabled = True
            Me.btnModificar.Enabled = True
        Else
            Me.btnRegistrar.Enabled = False
            Me.btnModificar.Enabled = False
            txtId_Usuario.ReadOnly = False
            txtNombre.ReadOnly = False
            btnImportar.Enabled = True
            btnAlta.Enabled = True
        End If
        If vDelete = True Then
            Me.btnBaja.Enabled = True
            txtId_Usuario.ReadOnly = True
            txtNombre.ReadOnly = True
            btnImportar.Enabled = False
        Else
            Me.btnBaja.Enabled = False
        End If
        If vAdd = False And vDelete = False Then
            txtId_Usuario.ReadOnly = True
            txtNombre.ReadOnly = True
            btnImportar.Enabled = False
        End If
        If vAdd = True And vDelete = True Then
            txtId_Usuario.ReadOnly = False
            txtNombre.ReadOnly = False
            btnImportar.Enabled = True
        End If
    End Sub

    Private Sub txtId_Usuario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId_Usuario.Validated
        vValida_Usuario_Red = txtId_Usuario.Text.Count
        Me.txtEmail.Text = txtId_Usuario.Text & "@gkndriveline.com"
        vEmail_Respaldo = Me.txtEmail.Text

        If vValida_Usuario_Red > 0 And vValida_Nombre > 0 And vValida_Tipo_Usuario > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If

    End Sub

    Private Sub txtNombre_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.Validated
        vValida_Nombre = txtNombre.Text.Count

        If vValida_Usuario_Red > 0 And vValida_Nombre > 0 And vValida_Tipo_Usuario > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub


    Private Sub txtEmail_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Validated
        If txtEmail.Text <> "" Then
            Me.txtEmail.Text = txtId_Usuario.Text & "@gkndriveline.com"
            vEmail_Respaldo = Me.txtEmail.Text
        Else
            Me.txtEmail.Text = vEmail_Respaldo
        End If
        'Me.txtEmail.Text = txtId_Usuario.Text & "@gkndriveline.com"
        'vEmail_Respaldo = Me.txtEmail.Text
    End Sub

    Private Sub radUsuario_Componente_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radUsuario_Componente.ToggleStateChanged
        If radUsuario_Componente.IsChecked = True Then
            ddlComponente_W.Enabled = True
            ddlCadena_Valor_W.Enabled = False

            btnComponente.Enabled = True
            btnCadena_Valor.Enabled = False
        Else
            ddlComponente_W.Enabled = False
            ddlCadena_Valor_W.Enabled = True

            btnComponente.Enabled = False
            btnCadena_Valor.Enabled = True
        End If
    End Sub

    Private Sub opActivar_Nivel_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles opActivar_Nivel.ToggleStateChanged
        If opActivar_Nivel.Checked = True Then
            radUsuario_CV.IsChecked = True
            rgbGrupo_Nivel.Enabled = True
        Else
            rgbGrupo_Nivel.Enabled = False
        End If
        If oUsuario IsNot Nothing Then
            'opActivar_Nivel.Enabled = True
            If oUsuario.Descripcion_Tipo_Usuario = "LET" Then
                radUsuario_Componente.Enabled = True
                radUsuario_CV.Enabled = False
                radUsuario_CV.IsChecked = True ''Solo es para que se active el boton de Select correspondiente
                radUsuario_Componente.IsChecked = True
            ElseIf oUsuario.Descripcion_Tipo_Usuario.ToUpper = "SUPERVISOR LIDER" Then
                radUsuario_Componente.Enabled = True
                radUsuario_CV.Enabled = False
                radUsuario_CV.IsChecked = True ''Solo es para que se active el boton de Select correspondiente
                radUsuario_Componente.IsChecked = True
            ElseIf oUsuario.Descripcion_Tipo_Usuario = "LIDER DE GRUPO" Then
                radUsuario_Componente.Enabled = True
                radUsuario_CV.Enabled = False
                radUsuario_CV.IsChecked = True ''Solo es para que se active el boton de Select correspondiente
                radUsuario_Componente.IsChecked = True

            ElseIf oUsuario.Descripcion_Tipo_Usuario = "ADMINISTRADOR" Then
                radUsuario_Componente.Enabled = True
                radUsuario_CV.Enabled = True
                radUsuario_Componente.IsChecked = True
                radUsuario_CV.IsChecked = True
            ElseIf oUsuario.Descripcion_Tipo_Usuario = "ADMINISTRADOR GENERA" Then
                radUsuario_Componente.Enabled = True
                radUsuario_CV.Enabled = True
                radUsuario_Componente.IsChecked = True
                radUsuario_CV.IsChecked = True
            ElseIf oUsuario.Descripcion_Tipo_Usuario = "GERENTE" Then
                radUsuario_Componente.Enabled = False
                radUsuario_CV.Enabled = True
                radUsuario_Componente.IsChecked = True
                radUsuario_CV.IsChecked = True
            Else
                radUsuario_Componente.Enabled = False
                radUsuario_CV.Enabled = True
                radUsuario_Componente.IsChecked = True
                radUsuario_CV.IsChecked = True
            End If
            'Else
            '    opActivar_Nivel.Enabled = False
        End If
        
    End Sub

    Private Sub btnComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComponente.Click
        Dim ofrmSeleccion_Componente As New FrmSeleccion_Componentes(oUsuario.CVE_Usuario.ToString)
        ofrmSeleccion_Componente.ShowDialog()
        oLista_Componentes = ofrmSeleccion_Componente.oRetorno
    End Sub

    Private Sub btnCadena_Valor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadena_Valor.Click
        Dim ofrmSeleccion_CV As New FrmSeleccion_CV(oUsuario.CVE_Usuario.ToString)
        ofrmSeleccion_CV.ShowDialog()
        oLista_CV = ofrmSeleccion_CV.oRetorno
    End Sub

 
    'Private Sub btnImportar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnImportar.MouseClick
    '    vEmail_Respaldo = Me.txtEmail.Text
    'End Sub
End Class
