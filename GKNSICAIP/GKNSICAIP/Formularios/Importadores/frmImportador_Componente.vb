﻿Imports CapaNegocios
Public Class frmImportador_Componente
    Public vRetorno_CVE_Componente As Long
    Dim oComponente As Componente

#Region "Eventos Controles"
    Private Sub frmImportador_Individual_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Cargar_Tabla(False)
        btnImportar.Enabled = False
    End Sub

    Private Sub dgvDatos_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvDatos.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim hit As DataGridView.HitTestInfo = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells(0).Value)
                btnImportar.Enabled = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                Dim hit As DataGridView.HitTestInfo = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells(0).Value)
                btnImportar.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportar.Click
        vRetorno_CVE_Componente = oComponente.cve_componente
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFiltrar.Click
        If rbtFiltro_Nombre.Checked = True Then

        ElseIf rbtTodos.Checked = True Then

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"
    Private Sub Cargar_Tabla(Optional ByVal vTiene_Filtro As Boolean = False, Optional ByVal vFiltro As String = "")
        oComponente = New Componente
        If vTiene_Filtro = True Then
            Me.dgvDatos.DataSource = oComponente.Obtener_Componentes(vFiltro)
        Else
            Me.dgvDatos.DataSource = oComponente.Obtener_Componentes
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
        oComponente = New Componente() With {.cve_componente = vIndice_Fila_Seleccioada}
        oComponente.Cargar()
    End Sub
#End Region


    Private Sub txtParametro_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtParametro.KeyUp
        If rbtFiltro_Nombre.Checked = True Then
            Cargar_Tabla(True, txtParametro.Text)
            btnImportar.Enabled = False
        End If

    End Sub
End Class