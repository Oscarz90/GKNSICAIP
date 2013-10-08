<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitacoraParos
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rdbForja = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rdbForja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadRadioButton2)
        Me.RadGroupBox1.Controls.Add(Me.RadRadioButton1)
        Me.RadGroupBox1.Controls.Add(Me.rdbForja)
        Me.RadGroupBox1.HeaderText = "DIRECTOR DE PLANTA"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        '
        '
        '
        Me.RadGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox1.Size = New System.Drawing.Size(267, 60)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "DIRECTOR DE PLANTA"
        '
        'rdbForja
        '
        Me.rdbForja.Location = New System.Drawing.Point(5, 35)
        Me.rdbForja.Name = "rdbForja"
        Me.rdbForja.Size = New System.Drawing.Size(52, 18)
        Me.rdbForja.TabIndex = 1
        Me.rdbForja.Text = "FORJA"
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.Location = New System.Drawing.Point(73, 35)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(89, 18)
        Me.RadRadioButton1.TabIndex = 2
        Me.RadRadioButton1.Text = "MAQUINADO"
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.Location = New System.Drawing.Point(168, 35)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(75, 18)
        Me.RadRadioButton2.TabIndex = 3
        Me.RadRadioButton2.Text = "ENSAMBLE"
        '
        'BitacoraParos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1272, 706)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MinimumSize = New System.Drawing.Size(1280, 736)
        Me.Name = "BitacoraParos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "BitacoraParos"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rdbForja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbForja As Telerik.WinControls.UI.RadRadioButton
End Class

