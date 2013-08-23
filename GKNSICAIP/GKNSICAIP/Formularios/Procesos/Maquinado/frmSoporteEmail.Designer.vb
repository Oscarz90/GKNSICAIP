<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoporteEmail
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoporteEmail))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.wbarEnviarEmail = New Telerik.WinControls.UI.RadWaitingBar()
        Me.txtPara = New Telerik.WinControls.UI.RadAutoCompleteBox()
        Me.txtAsunto = New Telerik.WinControls.UI.RadTextBox()
        Me.txtMensaje = New Telerik.WinControls.UI.RadTextBox()
        Me.txtAddEmail = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.btnAddEmail = New Telerik.WinControls.UI.RadButton()
        Me.btnCancelaEmail = New Telerik.WinControls.UI.RadButton()
        Me.btnEnviaEmail = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wbarEnviarEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAsunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelaEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEnviaEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(30, 79)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(42, 24)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Para:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(30, 163)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(60, 24)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "Asunto:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(30, 248)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(70, 24)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Mensaje:"
        '
        'wbarEnviarEmail
        '
        Me.wbarEnviarEmail.Location = New System.Drawing.Point(88, 504)
        Me.wbarEnviarEmail.Name = "wbarEnviarEmail"
        Me.wbarEnviarEmail.Size = New System.Drawing.Size(325, 24)
        Me.wbarEnviarEmail.TabIndex = 5
        Me.wbarEnviarEmail.Text = "Enviando e-mail ...."
        Me.wbarEnviarEmail.Visible = False
        '
        'txtPara
        '
        Me.txtPara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtPara.BackColor = System.Drawing.Color.White
        Me.txtPara.Location = New System.Drawing.Point(30, 109)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(455, 48)
        Me.txtPara.TabIndex = 7
        '
        'txtAsunto
        '
        Me.txtAsunto.AutoSize = False
        Me.txtAsunto.BackColor = System.Drawing.Color.White
        Me.txtAsunto.Location = New System.Drawing.Point(30, 193)
        Me.txtAsunto.Multiline = True
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(455, 49)
        Me.txtAsunto.TabIndex = 8
        '
        'txtMensaje
        '
        Me.txtMensaje.AutoSize = False
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.Location = New System.Drawing.Point(30, 278)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(455, 155)
        Me.txtMensaje.TabIndex = 9
        '
        'txtAddEmail
        '
        Me.txtAddEmail.BackColor = System.Drawing.Color.White
        Me.txtAddEmail.Location = New System.Drawing.Point(30, 53)
        Me.txtAddEmail.MaskType = Telerik.WinControls.UI.MaskType.EMail
        Me.txtAddEmail.Name = "txtAddEmail"
        Me.txtAddEmail.Size = New System.Drawing.Size(291, 20)
        Me.txtAddEmail.TabIndex = 10
        Me.txtAddEmail.TabStop = False
        '
        'btnAddEmail
        '
        Me.btnAddEmail.Enabled = False
        Me.btnAddEmail.Image = Global.GKNSICAIP.My.Resources.Resources.frmEnviarEmailAddTo
        Me.btnAddEmail.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddEmail.Location = New System.Drawing.Point(361, 43)
        Me.btnAddEmail.Name = "btnAddEmail"
        Me.btnAddEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddEmail.Size = New System.Drawing.Size(124, 42)
        Me.btnAddEmail.TabIndex = 4
        Me.btnAddEmail.Text = "Agregar Email"
        Me.btnAddEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddEmail.UseMnemonic = False
        '
        'btnCancelaEmail
        '
        Me.btnCancelaEmail.Image = Global.GKNSICAIP.My.Resources.Resources.frmEnvioEmailCancel
        Me.btnCancelaEmail.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelaEmail.Location = New System.Drawing.Point(268, 452)
        Me.btnCancelaEmail.Name = "btnCancelaEmail"
        Me.btnCancelaEmail.Size = New System.Drawing.Size(127, 46)
        Me.btnCancelaEmail.TabIndex = 4
        Me.btnCancelaEmail.Text = "Salir"
        Me.btnCancelaEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnEnviaEmail
        '
        Me.btnEnviaEmail.Enabled = False
        Me.btnEnviaEmail.Image = Global.GKNSICAIP.My.Resources.Resources.frmSoporteEmail1
        Me.btnEnviaEmail.Location = New System.Drawing.Point(107, 452)
        Me.btnEnviaEmail.Name = "btnEnviaEmail"
        Me.btnEnviaEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEnviaEmail.Size = New System.Drawing.Size(127, 46)
        Me.btnEnviaEmail.TabIndex = 3
        Me.btnEnviaEmail.Text = "Envia Email"
        Me.btnEnviaEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviaEmail.UseMnemonic = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(30, 23)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(150, 24)
        Me.RadLabel4.TabIndex = 2
        Me.RadLabel4.Text = "Agrega destinatarios:"
        '
        'FrmSoporteEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(518, 536)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.btnAddEmail)
        Me.Controls.Add(Me.txtAddEmail)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.wbarEnviarEmail)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.btnCancelaEmail)
        Me.Controls.Add(Me.btnEnviaEmail)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(526, 566)
        Me.MinimumSize = New System.Drawing.Size(526, 566)
        Me.Name = "FrmSoporteEmail"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(526, 566)
        Me.Text = "FrmSoporteEmail"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wbarEnviarEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAsunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelaEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEnviaEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnEnviaEmail As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancelaEmail As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents wbarEnviarEmail As Telerik.WinControls.UI.RadWaitingBar
    Friend WithEvents txtPara As Telerik.WinControls.UI.RadAutoCompleteBox
    Friend WithEvents txtAsunto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtMensaje As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtAddEmail As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents btnAddEmail As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
End Class

