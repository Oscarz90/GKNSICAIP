Imports CapaNegocios
Public Class frmMatch_Equipos_Kronos_SICAIP

    Dim oMatch As Match_Equipos_KRONOS_SICAIP


    Private Sub btnMatch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMatch.Click

        oMatch = New Match_Equipos_KRONOS_SICAIP()
        btnSalir.Enabled = False
        Try
            txtIndicentes.Text = "Espere...Realizando Match"
            oMatch.Hacer_Match()
            txtIndicentes.Text = oMatch.oMensajes_Text
            btnSalir.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class