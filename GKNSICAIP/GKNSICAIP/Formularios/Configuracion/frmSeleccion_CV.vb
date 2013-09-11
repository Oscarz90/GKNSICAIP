Imports CapaNegocios
Public Class FrmSeleccion_CV
    Dim oCV As Cadena_Valor

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmSeleccion_CV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oCV = New Cadena_Valor
        Lista_Datos.DataSource = oCV.Obtener_Cadenas_Valor
        Lista_Datos.ValueMember = "cve_cadena_valor"
        Lista_Datos.DisplayMember = "cadena"
    End Sub
End Class
