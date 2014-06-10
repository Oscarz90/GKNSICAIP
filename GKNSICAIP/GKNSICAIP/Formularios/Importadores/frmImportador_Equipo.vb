Imports CapaNegocios

Public Class FrmImportador_Equipo

    Public vRetorno_CVE_TIPO_USUARIO As Long
    Dim oEquipo As Equipo



    Private Sub FrmImportador_Equipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Tabla(False)
        btnImportar.Enabled = False
    End Sub


#Region "Metodos"
    Private Sub Cargar_Tabla(Optional ByVal vTiene_Filtro As Boolean = False, Optional ByVal vFiltro As String = "")
        oEquipo = New Equipo
        If vTiene_Filtro = True Then
            Me.dgvDatos.DataSource = oEquipo.Obtener_Equipos(vFiltro)
        Else
            Me.dgvDatos.DataSource = oEquipo.Obtener_Equipos
        End If
        If dgvDatos.RowCount = 0 Then
            btnImportar.Enabled = False
        Else
            btnImportar.Enabled = True
        End If

        Me.dgvDatos.Columns("CVE_Equipo").HeaderText = "CVE_Equipo"
        Me.dgvDatos.Columns("CVE_Equipo").IsVisible = False

        Me.dgvDatos.Columns("Descripcion").HeaderText = "Descripción"
        Me.dgvDatos.Columns("Descripcion").Width = 250

        Me.dgvDatos.EnableAlternatingRowColor = True
       
    End Sub
    Private Sub CargarElementoSeleccionado(ByVal vIndice_Fila_Seleccioada As Integer)
        oEquipo = New Equipo
        oEquipo.Cve_Equipo = vIndice_Fila_Seleccioada
        oEquipo.Cargar()
       
    End Sub
#End Region

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        vRetorno_CVE_TIPO_USUARIO = oEquipo.Cve_Equipo
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        If rbtFiltro_Nombre.IsChecked = True Then

        ElseIf rbtTodos.IsChecked = True Then

        End If
    End Sub

    Private Sub txtParametro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametro.KeyUp
        If rbtFiltro_Nombre.IsChecked = True Then
            Cargar_Tabla(True, txtParametro.Text)
            btnImportar.Enabled = False
        End If
    End Sub

    Private Sub dgvDatos_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
              
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                oEquipo = New Equipo
                oEquipo.Cve_Equipo = dgvDatos.CurrentRow.Cells("Cve_Equipo").Value
                oEquipo.Cargar()
                btnImportar.Enabled = True
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                'vRowSeleccionada = 0
            End If
        End Try
    End Sub

   
End Class
