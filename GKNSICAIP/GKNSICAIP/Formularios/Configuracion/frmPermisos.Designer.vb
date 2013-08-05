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
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.RadTreeView1 = New Telerik.WinControls.UI.RadTreeView()
        Me.RadTreeView2 = New Telerik.WinControls.UI.RadTreeView()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadCommandBar2 = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnModificar = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnEliminar = New Telerik.WinControls.UI.CommandBarButton()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadTreeView1.SuspendLayout()
        CType(Me.RadTreeView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadTreeView2.SuspendLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.btnSalir)
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Controls.Add(Me.RadTreeView1)
        Me.RadPanel1.Controls.Add(Me.RadTreeView2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(568, 502)
        Me.RadPanel1.TabIndex = 107
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(461, 426)
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
        'RadTreeView1
        '
        Me.RadTreeView1.Controls.Add(Me.RadCommandBar2)
        Me.RadTreeView1.Location = New System.Drawing.Point(295, 97)
        Me.RadTreeView1.Name = "RadTreeView1"
        Me.RadTreeView1.Size = New System.Drawing.Size(255, 296)
        Me.RadTreeView1.SpacingBetweenNodes = -1
        Me.RadTreeView1.TabIndex = 107
        Me.RadTreeView1.Text = "RadTreeView1"
        '
        'RadTreeView2
        '
        Me.RadTreeView2.Controls.Add(Me.RadCommandBar1)
        Me.RadTreeView2.Location = New System.Drawing.Point(14, 97)
        Me.RadTreeView2.Name = "RadTreeView2"
        Me.RadTreeView2.Size = New System.Drawing.Size(255, 296)
        Me.RadTreeView2.SpacingBetweenNodes = -1
        Me.RadTreeView2.TabIndex = 108
        Me.RadTreeView2.Text = "RadTreeView2"
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(255, 30)
        Me.RadCommandBar1.TabIndex = 0
        Me.RadCommandBar1.Text = "RadCommandBar1"
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnAdd, Me.btnModificar, Me.btnEliminar})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'RadCommandBar2
        '
        Me.RadCommandBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadCommandBar2.Location = New System.Drawing.Point(0, 0)
        Me.RadCommandBar2.Name = "RadCommandBar2"
        Me.RadCommandBar2.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement2})
        Me.RadCommandBar2.Size = New System.Drawing.Size(255, 30)
        Me.RadCommandBar2.TabIndex = 0
        Me.RadCommandBar2.Text = "RadCommandBar2"
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement2})
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(1, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(559, 44)
        Me.banner_formulario.TabIndex = 111
        Me.banner_formulario.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "CommandBarButton1"
        Me.btnAdd.AccessibleName = "CommandBarButton1"
        Me.btnAdd.DisplayName = "CommandBarButton1"
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Text = "CommandBarButton1"
        Me.btnAdd.ToolTipText = "Nuevo"
        Me.btnAdd.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleDescription = "CommandBarButton2"
        Me.btnModificar.AccessibleName = "CommandBarButton2"
        Me.btnModificar.DisplayName = "CommandBarButton2"
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Text = "CommandBarButton2"
        Me.btnModificar.ToolTipText = "Modificar"
        Me.btnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleDescription = "CommandBarButton3"
        Me.btnEliminar.AccessibleName = "CommandBarButton3"
        Me.btnEliminar.DisplayName = "CommandBarButton3"
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Text = "CommandBarButton3"
        Me.btnEliminar.ToolTipText = "Eliminar"
        Me.btnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 502)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmPermisos"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Asignación de Permisos"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadTreeView1.ResumeLayout(False)
        Me.RadTreeView1.PerformLayout()
        CType(Me.RadTreeView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadTreeView2.ResumeLayout(False)
        Me.RadTreeView2.PerformLayout()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadTreeView1 As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents RadTreeView2 As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadCommandBar2 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.CommandBarButton
End Class

