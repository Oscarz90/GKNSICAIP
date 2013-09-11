<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.btnOpSICAIP = New System.Windows.Forms.Button()
        Me.btnOpCalculadora = New System.Windows.Forms.Button()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpSICAIP
        '
        Me.btnOpSICAIP.BackColor = System.Drawing.Color.White
        Me.btnOpSICAIP.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.TLATOANI_IMAGOTIPO_REV0a
        Me.btnOpSICAIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOpSICAIP.ForeColor = System.Drawing.Color.Black
        Me.btnOpSICAIP.Location = New System.Drawing.Point(93, 251)
        Me.btnOpSICAIP.Name = "btnOpSICAIP"
        Me.btnOpSICAIP.Size = New System.Drawing.Size(516, 315)
        Me.btnOpSICAIP.TabIndex = 3
        Me.btnOpSICAIP.UseVisualStyleBackColor = False
        '
        'btnOpCalculadora
        '
        Me.btnOpCalculadora.BackColor = System.Drawing.Color.White
        Me.btnOpCalculadora.BackgroundImage = CType(resources.GetObject("btnOpCalculadora.BackgroundImage"), System.Drawing.Image)
        Me.btnOpCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpCalculadora.Location = New System.Drawing.Point(663, 251)
        Me.btnOpCalculadora.Name = "btnOpCalculadora"
        Me.btnOpCalculadora.Size = New System.Drawing.Size(516, 315)
        Me.btnOpCalculadora.TabIndex = 4
        Me.btnOpCalculadora.UseVisualStyleBackColor = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1272, 698)
        Me.Controls.Add(Me.btnOpCalculadora)
        Me.Controls.Add(Me.btnOpSICAIP)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 726)
        Me.Name = "FrmMenu"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.Text = "INICIO SICAIP"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpSICAIP As System.Windows.Forms.Button
    Friend WithEvents btnOpCalculadora As System.Windows.Forms.Button
End Class

