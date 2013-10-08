Public Class frmReportes
    Dim vFecha_Inicio As DateTime = Date.Now
    Dim vFecha_Fin As DateTime = Date.Now
    Dim fechaFormateada_Inicio As String
    Dim fechaFormateada_Fin As String


    Private Sub frmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GKN_SICAIP_V2DataSet.obtiene_cincos_cadena_mes' Puede moverla o quitarla según sea necesario.
        'Me.obtiene_cincos_cadena_mesTableAdapter.Fill(Me.GKN_SICAIP_V2DataSet.obtiene_cincos_cadena_mes)
        'TODO: esta línea de código carga datos en la tabla 'GKN_SICAIP_V2DataSet.obtiene_cincos_cadena_mes' Puede moverla o quitarla según sea necesario.
        
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        vFecha_Inicio = dtpFecha_Inicio.Value
        vFecha_Fin = dtpFecha_Fin.Value

        fechaFormateada_Inicio = vFecha_Inicio.ToString("dd/MM/yyyy")
        fechaFormateada_Fin = vFecha_Fin.ToString("dd/MM/yyyy")

        Me.obtiene_cincos_cadena_mesTableAdapter.Fill(Me.GKN_SICAIP_V2DataSet.obtiene_cincos_cadena_mes, Long.Parse(txtCve.Text), fechaFormateada_Inicio, fechaFormateada_Fin)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class