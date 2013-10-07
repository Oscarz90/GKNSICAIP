Imports CapaNegocios
Public Class FrmImportador_TipoUsuario
    Public vRetorno_CVE_TIPO_USUARIO As Long
    Dim oTIPO_USUARIO As Tipo_Usuario

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        vRetorno_CVE_TIPO_USUARIO = oTIPO_USUARIO.CVE_Tipo_Usuario
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim ofrmTipo_Usuario As New FrmTipo_Usuario
        ofrmTipo_Usuario.vId_Publico = 0
        ofrmTipo_Usuario.ShowDialog()
        vRetorno_CVE_TIPO_USUARIO = ofrmTipo_Usuario.vId_Retorno
        Me.Close()
    End Sub

    Private Sub txtParametro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyUp
        If rbtFiltro_Nombre.IsChecked = True Then
            Cargar_Tabla(True, txtParametro.Text)
            btnImportar.Enabled = False
        End If
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If rbtFiltro_Nombre.IsChecked = True Then

        ElseIf rbtTodos.IsChecked = True Then

        End If
    End Sub

    Private Sub FrmImportador_TipoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Tabla(False)
        btnImportar.Enabled = False
    End Sub

#Region "Metodos"
    Private Sub Cargar_Tabla(Optional ByVal vTiene_Filtro As Boolean = False, Optional ByVal vFiltro As String = "")
        oTIPO_USUARIO = New Tipo_Usuario
        If vTiene_Filtro = True Then
            Me.dgvDatos.DataSource = oTIPO_USUARIO.Obtener_Tipos_Usuarios(vFiltro)
        Else
            Me.dgvDatos.DataSource = oTIPO_USUARIO.Obtener_Tipos_Usuarios
        End If
        If dgvDatos.RowCount = 0 Then
            btnImportar.Enabled = False
        Else
            btnImportar.Enabled = True
        End If

        Me.dgvDatos.Columns("CVE_Tipo_Usuario").HeaderText = "CVE_Tipo_Usuario"
        Me.dgvDatos.Columns("CVE_Tipo_Usuario").IsVisible = False        

        Me.dgvDatos.Columns("Descripcion").HeaderText = "Descripcion"
        Me.dgvDatos.Columns("Descripcion").Width = 250

        Me.dgvDatos.EnableAlternatingRowColor = True
        ' ''// Da el formato al DGV(fondo de color para cada tupla)
        'With Me.dgvDatos
        '    .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        'End With
    End Sub
    Private Sub CargarElementoSeleccionado(ByVal vIndice_Fila_Seleccioada As Integer)
        oTIPO_USUARIO = New Tipo_Usuario
        oTIPO_USUARIO.CVE_Tipo_Usuario = vIndice_Fila_Seleccioada
        oTIPO_USUARIO.Cargar()
        'oTipo_Telefono.CVE_Tipo_Telefono = oContacto_Interno.Tipo_Telefono_CVE
        'oTipo_Telefono.Cargar()
        'LlenaCombos()
        'SetBindings()
        'If oContacto_Interno.CVE_Contacto_Interno <> 0 Then
        '    btnModificar.Visible = True
        '    btnRegistrar.Visible = False
        '    btnEliminar.Enabled = True
        'Else
        '    btnModificar.Visible = False
        '    btnRegistrar.Visible = True
        '    btnEliminar.Enabled = False
        'End If
    End Sub
#End Region

    'Private Sub dgvDatos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseDown
    '    Try
    '        If e.Button = Windows.Forms.MouseButtons.Right Then
    '            'Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
    '            'hit = dgvDatos.HitTest(e.X, e.Y)
    '            'Me.dgvDatos.ClearSelection()
    '            'Me.dgvDatos.Rows(hit.RowIndex).Selected = True
    '            ''vRowSeleccionada = hit.RowIndex
    '            'CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
    '            'btnImportar.Enabled = True
    '        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
    '            'Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
    '            'hit = dgvDatos.HitTest(e.X, e.Y)
    '            'Me.dgvDatos.ClearSelection()
    '            'Me.dgvDatos.Rows(hit.RowIndex).Selected = True
    '            ''vRowSeleccionada = hit.RowIndex
    '            'CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
    '            'btnImportar.Enabled = True
    '            oTIPO_USUARIO = New Tipo_Usuario
    '            oTIPO_USUARIO.CVE_Tipo_Usuario = dgvDatos.CurrentRow.Cells("CVE_Tipo_Usuario").Value
    '            oTIPO_USUARIO.Cargar()
    '        End If
    '    Catch ex As Exception
    '        If ex.TargetSite.MetadataToken.ToString = "100670847" Then
    '            'vRowSeleccionada = 0
    '        End If
    '    End Try

    '    'Try
    '    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '    '        'vRowSeleccionada = dgvRegistros.CurrentRow.Index
    '    '        'vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
    '    '        'vRowSeleccionada = 0
    '    '    ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
    '    '        If Windows.Forms.Cursor.Position.X <> 0 Then

    '    '        End If
    '    '        'vRowSeleccionada = dgvRegistros.CurrentRow.Index
    '    '        vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
    '    '    End If
    '    'Catch ex As Exception
    '    '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
    '    '        vRowSeleccionada = 0
    '    '    End If
    '    'End Try

    'End Sub

    Private Sub dgvDatos_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                'Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
                'hit = dgvDatos.HitTest(e.X, e.Y)
                'Me.dgvDatos.ClearSelection()
                'Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                ''vRowSeleccionada = hit.RowIndex
                'CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
                'btnImportar.Enabled = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                'Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
                'hit = dgvDatos.HitTest(e.X, e.Y)
                'Me.dgvDatos.ClearSelection()
                'Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                ''vRowSeleccionada = hit.RowIndex
                'CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
                'btnImportar.Enabled = True
                oTIPO_USUARIO = New Tipo_Usuario
                oTIPO_USUARIO.CVE_Tipo_Usuario = dgvDatos.CurrentRow.Cells("CVE_Tipo_Usuario").Value
                oTIPO_USUARIO.Cargar()
                btnImportar.Enabled = True
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                'vRowSeleccionada = 0
            End If
        End Try

        'Try
        '    If e.Button = Windows.Forms.MouseButtons.Right Then
        '        'vRowSeleccionada = dgvRegistros.CurrentRow.Index
        '        'vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
        '        'vRowSeleccionada = 0
        '    ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
        '        If Windows.Forms.Cursor.Position.X <> 0 Then

        '        End If
        '        'vRowSeleccionada = dgvRegistros.CurrentRow.Index
        '        vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
        '    End If
        'Catch ex As Exception
        '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
        '        vRowSeleccionada = 0
        '    End If
        'End Try

    End Sub
End Class
