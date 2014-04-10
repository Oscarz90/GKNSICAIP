﻿Public Class msg_Dialogo

    Public vRespuesta As Boolean = False
    Public vEntrada As String = ""


    Private Sub msg_Dialogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ckbAcuerdo.Checked = True
        Me.ckbAcuerdo.Checked = False
        Me.btnNo.Enabled = False
        Me.btnSi.Enabled = False
        Me.btnNo.TabStop = False
        Me.btnSi.TabStop = False
        Me.lb_Entrada.Focus()

        Me.ControlBox = False

        Me.lb_Entrada.Text = vEntrada
    End Sub

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        vRespuesta = True
        Me.Close()
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        vRespuesta = False
        Me.Close()
    End Sub

    Private Sub ckbAcuerdo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbAcuerdo.CheckedChanged
        If ckbAcuerdo.Checked = True Then
            Me.btnNo.Enabled = True
            Me.btnSi.Enabled = True
        ElseIf ckbAcuerdo.Checked = False Then
            Me.btnNo.Enabled = False
            Me.btnSi.Enabled = False
        End If
    End Sub
End Class