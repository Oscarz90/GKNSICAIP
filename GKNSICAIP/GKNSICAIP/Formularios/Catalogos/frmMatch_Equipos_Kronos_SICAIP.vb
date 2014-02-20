Imports CapaNegocios
Public Class frmMatch_Equipos_Kronos_SICAIP

    Dim oMatch As Match_Equipos_KRONOS_SICAIP


    Private Sub btnMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatch.Click





    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmMatch_Equipos_Kronos_SICAIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Set_Indicentes(ByVal Incidente As String) 'agrega un incidente al cuadro de incidentes
        txtIndicentes.Text = txtIndicentes.Text & Incidente & "............................." & vbCrLf
        Me.Refresh()
    End Sub

End Class