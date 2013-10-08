﻿Imports CapaNegocios
Public Class frmImportador_Modelo
    Public vRetorno_CVE_Modelo As Long
    Dim oModelo As Modelo
    'Dim vRowSeleccionada As Integer = 0

#Region "Eventos Controles"
    Private Sub frmImportador_Individual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Tabla(False)
        btnImportar.Enabled = False
    End Sub

    Private Sub dgvDatos_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
                hit = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                'vRowSeleccionada = hit.RowIndex
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
                btnImportar.Enabled = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                Dim hit As System.Windows.Forms.DataGridView.HitTestInfo
                hit = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                'vRowSeleccionada = hit.RowIndex
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Modelo").Value)
                btnImportar.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        vRetorno_CVE_Modelo = oModelo.cve_modelo
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If rbtFiltro_Nombre.Checked = True Then

        ElseIf rbtTodos.Checked = True Then

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"
    Private Sub Cargar_Tabla(Optional ByVal vTiene_Filtro As Boolean = False, Optional ByVal vFiltro As String = "")
        oModelo = New Modelo
        If vTiene_Filtro = True Then
            Me.dgvDatos.DataSource = oModelo.Obtener_Modelos(vFiltro)
        Else
            Me.dgvDatos.DataSource = oModelo.Obtener_Modelos
        End If
        If dgvDatos.RowCount = 0 Then
            btnImportar.Enabled = False
        Else
            btnImportar.Enabled = True
        End If

        ''// Da el formato al DGV(fondo de color para cada tupla)
        With Me.dgvDatos
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With
    End Sub
    Private Sub CargarElementoSeleccionado(ByVal vIndice_Fila_Seleccioada As Integer)
        oModelo = New Modelo
        oModelo.cve_modelo = vIndice_Fila_Seleccioada
        oModelo.Cargar()
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


    Private Sub txtParametro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyUp
        If rbtFiltro_Nombre.Checked = True Then
            Cargar_Tabla(True, txtParametro.Text)
            btnImportar.Enabled = False
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim ofrmModelo As New frmModelo
        ofrmModelo.vId_Publico = 0
        ofrmModelo.ShowDialog()
        vRetorno_CVE_Modelo = ofrmModelo.vId_Retorno
        Me.Close()
    End Sub
End Class