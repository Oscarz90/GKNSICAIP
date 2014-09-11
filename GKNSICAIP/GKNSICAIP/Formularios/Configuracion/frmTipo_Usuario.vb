Imports CapaNegocios
Public Class FrmTipo_Usuario
    Dim oTipo_Usuario As Tipo_Usuario
    Public vId_Publico As Long = 0
    Public vId_Retorno As Long = 0
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True
    Dim vValida_Descripcion As Integer = 0


    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar        
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBaja_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBaja.Click
        If MsgBox("¿Esta seguro de Eliminar al Tipo de Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oTipo_Usuario.Eliminar()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios al Tipo de Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oTipo_Usuario.Nombre_Tipo_Usuario = txtDescripcion.Text
            Try
                oTipo_Usuario.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        If vValida_Descripcion > 0 Then
            If MsgBox("¿Esta seguro de registrar el nuevo Tipo de Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oTipo_Usuario.CVE_Tipo_Usuario = 0
                oTipo_Usuario.Nombre_Tipo_Usuario = txtDescripcion.Text
                Try
                    oTipo_Usuario.Registrar()
                    vId_Retorno = oTipo_Usuario.CVE_Tipo_Usuario
                    MsgBox("Se registro correctamente")
                Catch ex As Exception

                End Try
                Me.Close()
            End If
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub FrmTipo_Usuario_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Convert.ToInt64(vId_Publico) <> 0 Then
            oTipo_Usuario = New Tipo_Usuario() With {.CVE_Tipo_Usuario = vId_Publico}
            oTipo_Usuario.Cargar()
            Controles_Registro_Nuevo(False)
        Else
            oTipo_Usuario = New Tipo_Usuario
            Controles_Registro_Nuevo(True)
        End If
        Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        SetBindings()
        Me.Show()
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub SetBindings()
        Me.txtDescripcion.DataBindings.Clear()
        Me.txtDescripcion.DataBindings.Add("Text", oTipo_Usuario, "Nombre_Tipo_Usuario")
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

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnRegistrar.Enabled = True
            Me.btnModificar.Enabled = True
        Else
            Me.btnRegistrar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.txtDescripcion.ReadOnly = False
        End If
        If vDelete = True Then
            Me.btnBaja.Enabled = True
            Me.txtDescripcion.ReadOnly = True
        Else
            Me.btnBaja.Enabled = False
        End If
        If vAdd = False And vDelete = False Then
            txtDescripcion.ReadOnly = True
        End If
        If vAdd = True And vDelete = True Then
            txtDescripcion.ReadOnly = False
        End If
    End Sub

    Private Sub txtDescripcion_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles txtDescripcion.Validated
        vValida_Descripcion = txtDescripcion.Text.Count
        If vValida_Descripcion > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If

    End Sub

    Private Sub txtDescripcion_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDescripcion.KeyUp
        vValida_Descripcion = txtDescripcion.Text.Count
        If vValida_Descripcion > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
End Class
