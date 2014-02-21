Imports CapaNegocios
Public Class frmMatch_Equipos_Kronos_SICAIP

    Dim oMatch As Match_Equipos_KRONOS_SICAIP


    Private Sub btnMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatch.Click
        Dim vInformacion As String = ""
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmMatch_Equipos_Kronos_SICAIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

End Class