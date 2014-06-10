<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportador_Equipo
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
        Me.rbtFiltro_Nombre = New Telerik.WinControls.UI.RadRadioButton()
        Me.dgvDatos = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnNuevo = New Telerik.WinControls.UI.RadButton()
        Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnImportar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnFiltrar = New Telerik.WinControls.UI.RadButton()
        Me.rbtTodos = New Telerik.WinControls.UI.RadRadioButton()
        Me.txtParametro = New Telerik.WinControls.UI.RadTextBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.rbtFiltro_Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParametro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.rbtFiltro_Nombre)
        Me.RadPanel1.Controls.Add(Me.dgvDatos)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.btnNuevo)
        Me.RadPanel1.Controls.Add(Me.btnCancelar)
        Me.RadPanel1.Controls.Add(Me.btnImportar)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.btnFiltrar)
        Me.RadPanel1.Controls.Add(Me.rbtTodos)
        Me.RadPanel1.Controls.Add(Me.txtParametro)
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(427, 459)
        Me.RadPanel1.TabIndex = 0
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.Enabled = False
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(355, 315)
        Me.rbtFiltro_Nombre.Name = "rbtFiltro_Nombre"
        Me.rbtFiltro_Nombre.Size = New System.Drawing.Size(114, 18)
        Me.rbtFiltro_Nombre.TabIndex = 128
        Me.rbtFiltro_Nombre.TabStop = True
        Me.rbtFiltro_Nombre.Text = "Filtrar por Nombre"
        Me.rbtFiltro_Nombre.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        Me.rbtFiltro_Nombre.Visible = False
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoScroll = True
        Me.dgvDatos.BackColor = System.Drawing.Color.White
        Me.dgvDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDatos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvDatos.ForeColor = System.Drawing.Color.Black
        Me.dgvDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvDatos.Location = New System.Drawing.Point(68, 107)
        '
        'dgvDatos
        '
        Me.dgvDatos.MasterTemplate.AllowColumnReorder = False
        Me.dgvDatos.MasterTemplate.AllowDragToGroup = False
        Me.dgvDatos.MasterTemplate.EnableGrouping = False
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvDatos.ShowGroupPanel = False
        Me.dgvDatos.Size = New System.Drawing.Size(291, 316)
        Me.dgvDatos.TabIndex = 135
        Me.dgvDatos.Text = "RadGridView1"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(3, 291)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 134
        Me.RadLabel2.Text = "Si no Exixte"
        Me.RadLabel2.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(3, 315)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(59, 24)
        Me.btnNuevo.TabIndex = 133
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(265, 429)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 24)
        Me.btnCancelar.TabIndex = 132
        Me.btnCancelar.Text = "Salir"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(68, 429)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(94, 24)
        Me.btnImportar.TabIndex = 131
        Me.btnImportar.Text = "Importar"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(65, 62)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel1.TabIndex = 130
        Me.RadLabel1.Text = "Filtrar por:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(365, 384)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(40, 24)
        Me.btnFiltrar.TabIndex = 129
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.Visible = False
        '
        'rbtTodos
        '
        Me.rbtTodos.Enabled = False
        Me.rbtTodos.Location = New System.Drawing.Point(350, 360)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(64, 18)
        Me.rbtTodos.TabIndex = 127
        Me.rbtTodos.Text = "Sin Filtro"
        Me.rbtTodos.Visible = False
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(68, 81)
        Me.txtParametro.Modified = True
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(291, 20)
        Me.txtParametro.TabIndex = 126
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(116, 32)
        Me.titulo_banner_formulario.TabIndex = 125
        Me.titulo_banner_formulario.Text = "Importar"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(427, 44)
        Me.banner_formulario.TabIndex = 124
        Me.banner_formulario.TabStop = False
        '
        'FrmImportador_Equipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 459)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(435, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(435, 489)
        Me.Name = "FrmImportador_Equipo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.Text = "Importador"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.rbtFiltro_Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParametro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dgvDatos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnNuevo As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnImportar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnFiltrar As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbtFiltro_Nombre As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rbtTodos As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents txtParametro As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
End Class

