<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportador_TipoUsuario
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
        Me.dgvDatos = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnNuevo = New Telerik.WinControls.UI.RadButton()
        Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
        Me.btnImportar = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnFiltrar = New Telerik.WinControls.UI.RadButton()
        Me.rbtFiltro_Nombre = New Telerik.WinControls.UI.RadRadioButton()
        Me.rbtTodos = New Telerik.WinControls.UI.RadRadioButton()
        Me.txtParametro = New Telerik.WinControls.UI.RadTextBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtFiltro_Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParametro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.dgvDatos)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.btnNuevo)
        Me.RadPanel1.Controls.Add(Me.btnCancelar)
        Me.RadPanel1.Controls.Add(Me.btnImportar)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.btnFiltrar)
        Me.RadPanel1.Controls.Add(Me.rbtFiltro_Nombre)
        Me.RadPanel1.Controls.Add(Me.rbtTodos)
        Me.RadPanel1.Controls.Add(Me.txtParametro)
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(404, 460)
        Me.RadPanel1.TabIndex = 0
        '
        'dgvDatos
        '
        Me.dgvDatos.Location = New System.Drawing.Point(11, 62)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(281, 316)
        Me.dgvDatos.TabIndex = 123
        Me.dgvDatos.Text = "RadGridView1"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(314, 195)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 122
        Me.RadLabel2.Text = "Si no Exixte"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(298, 219)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 24)
        Me.btnNuevo.TabIndex = 121
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(298, 125)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 24)
        Me.btnCancelar.TabIndex = 120
        Me.btnCancelar.Text = "Salir"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(298, 79)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(94, 24)
        Me.btnImportar.TabIndex = 119
        Me.btnImportar.Text = "Importar"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(11, 394)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(34, 18)
        Me.RadLabel1.TabIndex = 118
        Me.RadLabel1.Text = "Filtro:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(298, 418)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(94, 24)
        Me.btnFiltrar.TabIndex = 117
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.Visible = False
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.Enabled = False
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(162, 418)
        Me.rbtFiltro_Nombre.Name = "rbtFiltro_Nombre"
        Me.rbtFiltro_Nombre.Size = New System.Drawing.Size(114, 18)
        Me.rbtFiltro_Nombre.TabIndex = 116
        Me.rbtFiltro_Nombre.TabStop = True
        Me.rbtFiltro_Nombre.Text = "Filtrar por Nombre"
        Me.rbtFiltro_Nombre.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        Me.rbtFiltro_Nombre.Visible = False
        '
        'rbtTodos
        '
        Me.rbtTodos.Enabled = False
        Me.rbtTodos.Location = New System.Drawing.Point(48, 418)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(64, 18)
        Me.rbtTodos.TabIndex = 115
        Me.rbtTodos.Text = "Sin Filtro"
        Me.rbtTodos.Visible = False
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(48, 392)
        Me.txtParametro.Modified = True
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(278, 20)
        Me.txtParametro.TabIndex = 114
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(314, 32)
        Me.titulo_banner_formulario.TabIndex = 113
        Me.titulo_banner_formulario.Text = "Importar Tipo de Usuario"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(404, 44)
        Me.banner_formulario.TabIndex = 112
        Me.banner_formulario.TabStop = False
        '
        'FrmImportador_TipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 460)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(412, 490)
        Me.Name = "FrmImportador_TipoUsuario"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Importar Tipo de Usuario"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFiltrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtFiltro_Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParametro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
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
End Class

