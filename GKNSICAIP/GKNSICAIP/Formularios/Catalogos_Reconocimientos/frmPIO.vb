Imports System.Drawing.Color

Public Class frmPIO

    Private Sub frmPIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grupos("Hola", 100, 100)
    End Sub

    Private Sub grupos(ByVal todo As String, ByVal lado As Integer, ByVal altura As Integer)

        Dim nombre As New GroupBox
        nombre.Name = todo
        nombre.Height = 50
        nombre.Width = 200
        nombre.Top = altura
        nombre.Left = lado
        nombre.Visible = True
        nombre.Enabled = True
        'nombre.BackColor = Chocolate
        nombre.Text = "Indicador"
        'nombre.ForeColor = Aqua
        Panel1.Controls.Add(nombre)
    End Sub


End Class