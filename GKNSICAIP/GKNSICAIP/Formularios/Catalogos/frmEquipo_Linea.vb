Imports CapaNegocios
Public Class frmEquipo_Linea
    Dim oEquipo_Linea As New EquipoLinea


    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim vfrmImportador_Linea As New frmImportador_Linea
        vfrmImportador_Linea.ShowDialog()
        oEquipo_Linea.cve_linea = vfrmImportador_Linea.vRetorno_CVE_Linea
        txtLinea.Text = oEquipo_Linea.Nombre_Linea        
        lbLibres.DataSource = oEquipo_Linea.ObtenerElementosNoAsignados(oEquipo_Linea.cve_linea)
        lbLibres.ValueMember = "cve_equipo"
        lbLibres.DisplayMember = "Equipo"
        lbAsignados.DataSource = oEquipo_Linea.ObtenerElementosAsignados(oEquipo_Linea.cve_linea)
        lbAsignados.ValueMember = "cve_equipo"
        lbAsignados.DisplayMember = "Equipo"        

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAsignar_ITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar_ITEM.Click
        lbAsignados.Items.Add(lbLibres.SelectedValue)
        lbLibres.Items.Remove(lbLibres.SelectedValue)
    End Sub

    Private Sub btnLiberar_ITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar_ITEM.Click

    End Sub

    Private Sub btnAsignar_Todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar_Todos.Click

    End Sub

    Private Sub btnLiberar_Todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar_Todos.Click

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub
End Class