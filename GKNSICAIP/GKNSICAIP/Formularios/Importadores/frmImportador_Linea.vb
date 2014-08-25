Imports CapaNegocios
Public Class frmImportador_Linea

    Public vRetorno_CVE_Linea As Long
    Dim oLinea As New Linea
    Dim oModelo As Modelo
    Dim vCVE_Modelo_FILTRO As Long

    Sub New(Optional ByVal vFiltro_Modelo As Long = 0)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vCVE_Modelo_FILTRO = vFiltro_Modelo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Eventos Controles"
    Private Sub frmImportador_Individual_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        oModelo = New Modelo
        If vCVE_Modelo_FILTRO = 0 Then
            Cargar_Tabla(False)
        Else
            oModelo.cve_modelo = vCVE_Modelo_FILTRO
            oModelo.Cargar()
            Cargar_Tabla(False)
        End If

        Me.btnImportar.Enabled = False
    End Sub

    Private Sub dgvDatos_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvDatos.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim hit As DataGridView.HitTestInfo = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Linea").Value)
                btnImportar.Enabled = True
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                Dim hit As DataGridView.HitTestInfo = dgvDatos.HitTest(e.X, e.Y)
                Me.dgvDatos.ClearSelection()
                Me.dgvDatos.Rows(hit.RowIndex).Selected = True
                CargarElementoSeleccionado(dgvDatos.Rows(hit.RowIndex).Cells("cve_Linea").Value)
                btnImportar.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportar.Click
        vRetorno_CVE_Linea = oLinea.cve_linea
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
        oLinea = New Linea
        If vTiene_Filtro = True Then
            Me.dgvDatos.DataSource = oLinea.Obtener_Lineas(vFiltro, vCVE_Modelo_FILTRO)
        Else
            Me.dgvDatos.DataSource = oLinea.Obtener_Lineas(oModelo.cve_componente)
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
        oLinea.cve_linea = vIndice_Fila_Seleccioada
        oLinea.Cargar()
    End Sub
#End Region


    Private Sub txtParametro_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtParametro.KeyUp
        If rbtFiltro_Nombre.Checked = True Then
            Cargar_Tabla(True, txtParametro.Text)
            Me.btnImportar.Enabled = False
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNuevo.Click
        Dim ofrmLinea As New frmLinea() With {.vId_Publico = 0}
        ofrmLinea.ShowDialog()
        vRetorno_CVE_Linea = ofrmLinea.vId_Retorno
        Me.Close()
    End Sub
End Class