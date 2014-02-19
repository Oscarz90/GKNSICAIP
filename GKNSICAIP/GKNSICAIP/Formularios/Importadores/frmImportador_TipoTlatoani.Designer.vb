<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportador_TipoTlatoani
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
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.cve_detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.rbtFiltro_Nombre = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-8, -1)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(398, 44)
        Me.banner_formulario.TabIndex = 113
        Me.banner_formulario.TabStop = False
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(10, 23)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(264, 32)
        Me.titulo_banner_formulario.TabIndex = 115
        Me.titulo_banner_formulario.Text = "Importar tipo tlatoani"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cve_detalle, Me.tipo, Me.descripcion})
        Me.dgvDatos.Location = New System.Drawing.Point(6, 60)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(291, 315)
        Me.dgvDatos.TabIndex = 114
        '
        'cve_detalle
        '
        Me.cve_detalle.HeaderText = "cve_detalle"
        Me.cve_detalle.Name = "cve_detalle"
        Me.cve_detalle.ReadOnly = True
        Me.cve_detalle.Visible = False
        '
        'tipo
        '
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'btnImportar
        '
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(303, 60)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 116
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(303, 89)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 117
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Enabled = False
        Me.rbtTodos.Location = New System.Drawing.Point(43, 413)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(65, 17)
        Me.rbtTodos.TabIndex = 122
        Me.rbtTodos.Text = "Sin Filtro"
        Me.rbtTodos.UseVisualStyleBackColor = True
        Me.rbtTodos.Visible = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(302, 410)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 121
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        Me.btnFiltrar.Visible = False
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.AutoSize = True
        Me.rbtFiltro_Nombre.Checked = True
        Me.rbtFiltro_Nombre.Enabled = False
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(114, 413)
        Me.rbtFiltro_Nombre.Name = "rbtFiltro_Nombre"
        Me.rbtFiltro_Nombre.Size = New System.Drawing.Size(108, 17)
        Me.rbtFiltro_Nombre.TabIndex = 120
        Me.rbtFiltro_Nombre.TabStop = True
        Me.rbtFiltro_Nombre.Text = "Filtrar por Nombre"
        Me.rbtFiltro_Nombre.UseVisualStyleBackColor = True
        Me.rbtFiltro_Nombre.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Filtro:"
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(43, 384)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(334, 20)
        Me.txtParametro.TabIndex = 118
        '
        'frmImportador_TipoTlatoani
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 439)
        Me.Controls.Add(Me.rbtTodos)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.rbtFiltro_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.titulo_banner_formulario)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.banner_formulario)
        Me.Name = "frmImportador_TipoTlatoani"
        Me.Text = "frmImportador_TipoTlatoani"
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents cve_detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents rbtFiltro_Nombre As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtParametro As System.Windows.Forms.TextBox
End Class
