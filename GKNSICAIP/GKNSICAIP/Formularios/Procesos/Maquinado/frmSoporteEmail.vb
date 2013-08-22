Imports System.Net.Mail
Imports System.ComponentModel
Public Class FrmSoporteEmail
    Private bw As BackgroundWorker = New BackgroundWorker
#Region "Load"
    Private Sub FrmSoporteEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
    End Sub
#End Region
#Region "validaciones"
    Private Sub valida_btnEnviarEmail()
        If txtPara.Text <> "" And txtAsunto.Text <> "" And txtMensaje.Text <> "" Then
            habilita_btnEnviarEmail()
        Else
            deshabilita_btnEnviarEmail()
        End If
    End Sub
#End Region
#Region "(des)habilitar botones"
    Private Sub deshabilita_frmSoporteEmail()
        txtAddEmail.Enabled = False
        txtPara.Enabled = False
        txtAsunto.Enabled = False
        txtMensaje.Enabled = False
    End Sub
    Private Sub habilita_btnEnviarEmail()
        btnEnviaEmail.Enabled = True
    End Sub
    Private Sub deshabilita_btnEnviarEmail()
        btnEnviaEmail.Enabled = False
    End Sub
    Private Sub habilita_btnCancelarEmail()
        btnCancelaEmail.Enabled = True
    End Sub
    Private Sub deshabilita_btnCancelarEmail()
        btnCancelaEmail.Enabled = False
    End Sub
    Private Sub habilita_btnAddEmail()
        btnAddEmail.Enabled = True
    End Sub
    Private Sub deshabilita_btnAddEmail()
        btnAddEmail.Enabled = False
    End Sub
#End Region
#Region "Eventos textboxs"
    Private Sub txtPara_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPara.TextChanged
        valida_btnEnviarEmail()
    End Sub
    Private Sub txtAsunto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAsunto.TextChanged
        valida_btnEnviarEmail()
    End Sub
    Private Sub txtMensaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMensaje.TextChanged
        valida_btnEnviarEmail()
    End Sub
#End Region
#Region "Eventos botones"
    Private Sub txtAddEmail_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddEmail.KeyUp
        If txtAddEmail.Text <> "" Then
            Try
                Dim testAddress = New MailAddress(txtAddEmail.Text)
                habilita_btnAddEmail()
            Catch ex As FormatException
                deshabilita_btnAddEmail()
            End Try
        End If
    End Sub
    Private Sub txtPara_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPara.KeyPress
        e.Handled = True
    End Sub
    Private Sub btnAddEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmail.Click
        add_Email()
        txtAddEmail.Text = ""
        deshabilita_btnAddEmail()
    End Sub
    Private Sub btnEnviaEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviaEmail.Click
        deshabilita_frmSoporteEmail()
        habilita_waitingbar()
        deshabilita_btnEnviarEmail()
        deshabilita_btnCancelarEmail()
        Dim newThread As New System.Threading.Thread(AddressOf envia_email)
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub
    Private Sub btnCancelaEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelaEmail.Click
        Me.Close()
    End Sub
#End Region
#Region "funciones y metodos"
    Private Sub add_Email()
        txtPara.Text = txtPara.Text & txtAddEmail.Text & ";"
    End Sub
    Private Sub envia_email()
        Dim Message As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient
        'CONFIGURACIÓN DEL STMP
        SMTP.Credentials = New System.Net.NetworkCredential("iomsz90@gmail.com", "90111915")
        SMTP.Host = "smtp.gmail.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True
        ' CONFIGURACION DEL MENSAJE
        'Ingresa los destinatarios
        If txtPara.Text <> "" Then
            Dim LineOfText As String
            Dim i As Integer
            Dim aryTextFile() As String
            LineOfText = txtPara.Text
            aryTextFile = LineOfText.Split(";")
            For i = 0 To UBound(aryTextFile) - 1
                Message.[To].Add(aryTextFile(i))
            Next i
        End If
        'Message.[To].Add("omsz90@live.com.mx") 'Cuenta de Correo al que se le quiere enviar el e-mail
        Message.From = New System.Net.Mail.MailAddress("omsz90@live.com.mx", "Oscar Martinez Sanchez", System.Text.Encoding.UTF8) 'Quien lo envía
        Message.Subject = txtAsunto.Text 'Sujeto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = txtMensaje.Text 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False
        'ENVIO
        Try
            SMTP.Send(Message)
            'MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
            wbarEnviarEmail.Text = "e-amil enviado correctamente"
            deshabilia_waitingbar()
            If bw.WorkerSupportsCancellation = True Then
                bw.CancelAsync()
            End If
        Catch ex As System.Net.Mail.SmtpException
            'MessageBox.Show(ex.ToString, "Error al enviar email!", MessageBoxButtons.OK)
            wbarEnviarEmail.Text = "error al enviar e-amil"
            If bw.WorkerSupportsCancellation = True Then
                bw.CancelAsync()
            End If
        End Try
    End Sub
    Private Sub habilita_waitingbar()
        wbarEnviarEmail.WaitingSpeed = 50
        wbarEnviarEmail.WaitingStep = 5
        wbarEnviarEmail.ShowText = True
        wbarEnviarEmail.Visible = True
        wbarEnviarEmail.StartWaiting()
    End Sub
    Private Sub deshabilita_waitingbar()
        wbarEnviarEmail.StopWaiting()
        wbarEnviarEmail.Text = "Enviado Correctamente"
    End Sub
    Private Sub deshabilia_waitingbar()
        wbarEnviarEmail.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash
        wbarEnviarEmail.StopWaiting()
        wbarEnviarEmail.ResetWaiting()
    End Sub
#End Region
#Region "backgroundprocces"
    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        envia_email()
    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        habilita_btnCancelarEmail()
        If e.Cancelled = True Then
            deshabilia_waitingbar()
        ElseIf e.Error IsNot Nothing Then
            'Me.tbProgress.Text = "Error: " & e.Error.Message
        Else
            'Me.tbProgress.Text = "Done!"
        End If
    End Sub
    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        'Me.tbProgress.Text = e.ProgressPercentage.ToString() & "%"
    End Sub
#End Region
End Class
