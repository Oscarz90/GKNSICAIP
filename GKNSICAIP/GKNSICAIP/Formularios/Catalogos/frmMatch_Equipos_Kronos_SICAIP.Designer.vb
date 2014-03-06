<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatch_Equipos_Kronos_SICAIP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatch_Equipos_Kronos_SICAIP))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.btnMatch = New Telerik.WinControls.UI.RadButton()
        Me.txtIndicentes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnMatch)
        Me.Panel1.Controls.Add(Me.txtIndicentes)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 402)
        Me.Panel1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 114)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel1.TabIndex = 157
        Me.RadLabel1.Text = "EVENTOS:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(693, 91)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 41)
        Me.btnSalir.TabIndex = 156
        Me.btnSalir.Text = "Salir"
        '
        'btnMatch
        '
        Me.btnMatch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMatch.Image = CType(resources.GetObject("btnMatch.Image"), System.Drawing.Image)
        Me.btnMatch.Location = New System.Drawing.Point(564, 91)
        Me.btnMatch.Name = "btnMatch"
        Me.btnMatch.Size = New System.Drawing.Size(123, 41)
        Me.btnMatch.TabIndex = 155
        Me.btnMatch.Text = "Match"
        '
        'txtIndicentes
        '
        Me.txtIndicentes.BackColor = System.Drawing.Color.White
        Me.txtIndicentes.Location = New System.Drawing.Point(12, 138)
        Me.txtIndicentes.Multiline = True
        Me.txtIndicentes.Name = "txtIndicentes"
        Me.txtIndicentes.ReadOnly = True
        Me.txtIndicentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIndicentes.Size = New System.Drawing.Size(823, 251)
        Me.txtIndicentes.TabIndex = 154
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(48, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(419, 32)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Match Equipos KRONOS-SICAIP"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(847, 54)
        Me.PictureBox2.TabIndex = 152
        Me.PictureBox2.TabStop = False
        '
        'frmMatch_Equipos_Kronos_SICAIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 402)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(863, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(863, 440)
        Me.Name = "frmMatch_Equipos_Kronos_SICAIP"
        Me.Text = "Match Equipos KRONOS-SICAIP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtIndicentes As System.Windows.Forms.TextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnMatch As Telerik.WinControls.UI.RadButton
End Class
