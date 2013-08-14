<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPermisos))
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.TreeView_Permisos = New System.Windows.Forms.TreeView()
        Me.TreeView_Usuarios = New System.Windows.Forms.TreeView()
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.btnGuardar)
        Me.RadPanel1.Controls.Add(Me.TreeView_Permisos)
        Me.RadPanel1.Controls.Add(Me.TreeView_Usuarios)
        Me.RadPanel1.Controls.Add(Me.btnSalir)
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.MaximumSize = New System.Drawing.Size(578, 768)
        Me.RadPanel1.MinimumSize = New System.Drawing.Size(578, 502)
        Me.RadPanel1.Name = "RadPanel1"
        '
        '
        '
        Me.RadPanel1.RootElement.MaxSize = New System.Drawing.Size(578, 768)
        Me.RadPanel1.RootElement.MinSize = New System.Drawing.Size(578, 502)
        Me.RadPanel1.Size = New System.Drawing.Size(578, 502)
        Me.RadPanel1.TabIndex = 107
        '
        'TreeView_Permisos
        '
        Me.TreeView_Permisos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView_Permisos.CheckBoxes = True
        Me.TreeView_Permisos.Location = New System.Drawing.Point(277, 97)
        Me.TreeView_Permisos.Name = "TreeView_Permisos"
        Me.TreeView_Permisos.Size = New System.Drawing.Size(289, 333)
        Me.TreeView_Permisos.TabIndex = 115
        '
        'TreeView_Usuarios
        '
        Me.TreeView_Usuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView_Usuarios.Location = New System.Drawing.Point(12, 97)
        Me.TreeView_Usuarios.Name = "TreeView_Usuarios"
        Me.TreeView_Usuarios.Size = New System.Drawing.Size(242, 333)
        Me.TreeView_Usuarios.TabIndex = 114
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(477, 459)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 31)
        Me.btnSalir.TabIndex = 113
        Me.btnSalir.Text = "Salir"
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(306, 32)
        Me.titulo_banner_formulario.TabIndex = 112
        Me.titulo_banner_formulario.Text = "Asignación de Permisos"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(1, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(577, 44)
        Me.banner_formulario.TabIndex = 111
        Me.banner_formulario.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(382, 459)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 31)
        Me.btnGuardar.TabIndex = 116
        Me.btnGuardar.Text = "Guardar"
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 502)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximumSize = New System.Drawing.Size(578, 768)
        Me.MinimumSize = New System.Drawing.Size(578, 502)
        Me.Name = "FrmPermisos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.Text = "Asignación de Permisos"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents TreeView_Usuarios As System.Windows.Forms.TreeView
    Friend WithEvents TreeView_Permisos As System.Windows.Forms.TreeView
    Friend WithEvents btnGuardar As Telerik.WinControls.UI.RadButton
End Class

