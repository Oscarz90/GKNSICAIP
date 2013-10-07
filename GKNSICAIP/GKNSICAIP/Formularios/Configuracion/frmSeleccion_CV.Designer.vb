<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccion_CV
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.Lista_Datos_W = New System.Windows.Forms.ListView()
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.btnRegistrar = New Telerik.WinControls.UI.RadButton()
        Me.Lista_Datos = New Telerik.WinControls.UI.RadListView()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lista_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.Lista_Datos_W)
        Me.RadPanel1.Controls.Add(Me.btnSalir)
        Me.RadPanel1.Controls.Add(Me.btnRegistrar)
        Me.RadPanel1.Controls.Add(Me.Lista_Datos)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(454, 474)
        Me.RadPanel1.TabIndex = 0
        '
        'Lista_Datos_W
        '
        Me.Lista_Datos_W.CheckBoxes = True
        Me.Lista_Datos_W.Location = New System.Drawing.Point(12, 12)
        Me.Lista_Datos_W.Name = "Lista_Datos_W"
        Me.Lista_Datos_W.Size = New System.Drawing.Size(314, 450)
        Me.Lista_Datos_W.TabIndex = 5
        Me.Lista_Datos_W.UseCompatibleStateImageBehavior = False
        Me.Lista_Datos_W.View = System.Windows.Forms.View.List
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(332, 52)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 24)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(332, 12)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 24)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Guardar"
        '
        'Lista_Datos
        '
        Me.Lista_Datos.Location = New System.Drawing.Point(341, 324)
        Me.Lista_Datos.Name = "Lista_Datos"
        Me.Lista_Datos.ShowCheckBoxes = True
        Me.Lista_Datos.Size = New System.Drawing.Size(101, 138)
        Me.Lista_Datos.TabIndex = 1
        Me.Lista_Datos.Text = "RadListView1"
        Me.Lista_Datos.Visible = False
        '
        'FrmSeleccion_CV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 474)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(462, 504)
        Me.MinimumSize = New System.Drawing.Size(462, 504)
        Me.Name = "FrmSeleccion_CV"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(462, 504)
        Me.Text = "Seleccion CV"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lista_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Lista_Datos As Telerik.WinControls.UI.RadListView
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRegistrar As Telerik.WinControls.UI.RadButton
    Friend WithEvents Lista_Datos_W As System.Windows.Forms.ListView
End Class

