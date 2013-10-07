<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportador_Modelo
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
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.rbtFiltro_Nombre = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.cve_Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_clasificacion_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np_gkn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(351, 61)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(351, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(50, 391)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(376, 20)
        Me.txtParametro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtro:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cve_Modelo, Me.cve_componente, Me.cve_clasificacion_modelo, Me.np_gkn, Me.descripcion, Me.cve_linea, Me.cve_registro, Me.Nombre_Componente, Me.Nombre_Clasificacion, Me.estatus})
        Me.dgvDatos.Location = New System.Drawing.Point(12, 62)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(333, 315)
        Me.dgvDatos.TabIndex = 4
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.AutoSize = True
        Me.rbtFiltro_Nombre.Checked = True
        Me.rbtFiltro_Nombre.Enabled = False
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(121, 420)
        Me.rbtFiltro_Nombre.Name = "rbtFiltro_Nombre"
        Me.rbtFiltro_Nombre.Size = New System.Drawing.Size(108, 17)
        Me.rbtFiltro_Nombre.TabIndex = 5
        Me.rbtFiltro_Nombre.TabStop = True
        Me.rbtFiltro_Nombre.Text = "Filtrar por Nombre"
        Me.rbtFiltro_Nombre.UseVisualStyleBackColor = True
        Me.rbtFiltro_Nombre.Visible = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(351, 417)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        Me.btnFiltrar.Visible = False
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Enabled = False
        Me.rbtTodos.Location = New System.Drawing.Point(50, 420)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(65, 17)
        Me.rbtTodos.TabIndex = 7
        Me.rbtTodos.Text = "Sin Filtro"
        Me.rbtTodos.UseVisualStyleBackColor = True
        Me.rbtTodos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Si no Existe:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(351, 174)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.titulo_banner_formulario)
        Me.Panel1.Controls.Add(Me.rbtTodos)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnFiltrar)
        Me.Panel1.Controls.Add(Me.banner_formulario)
        Me.Panel1.Controls.Add(Me.rbtFiltro_Nombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvDatos)
        Me.Panel1.Controls.Add(Me.txtParametro)
        Me.Panel1.Controls.Add(Me.btnImportar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 452)
        Me.Panel1.TabIndex = 10
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(213, 32)
        Me.titulo_banner_formulario.TabIndex = 112
        Me.titulo_banner_formulario.Text = "Importar Modelo"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(441, 44)
        Me.banner_formulario.TabIndex = 111
        Me.banner_formulario.TabStop = False
        '
        'cve_Modelo
        '
        Me.cve_Modelo.DataPropertyName = "cve_Modelo"
        Me.cve_Modelo.HeaderText = "cve_Modelo"
        Me.cve_Modelo.Name = "cve_Modelo"
        Me.cve_Modelo.ReadOnly = True
        Me.cve_Modelo.Visible = False
        '
        'cve_componente
        '
        Me.cve_componente.DataPropertyName = "cve_componente"
        Me.cve_componente.HeaderText = "cve_componente"
        Me.cve_componente.Name = "cve_componente"
        Me.cve_componente.ReadOnly = True
        Me.cve_componente.Visible = False
        '
        'cve_clasificacion_modelo
        '
        Me.cve_clasificacion_modelo.DataPropertyName = "cve_clasificacion_modelo"
        Me.cve_clasificacion_modelo.HeaderText = "cve_clasificacion_modelo"
        Me.cve_clasificacion_modelo.Name = "cve_clasificacion_modelo"
        Me.cve_clasificacion_modelo.ReadOnly = True
        Me.cve_clasificacion_modelo.Visible = False
        '
        'np_gkn
        '
        Me.np_gkn.DataPropertyName = "np_gkn"
        Me.np_gkn.HeaderText = "NP_GKN"
        Me.np_gkn.Name = "np_gkn"
        Me.np_gkn.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'cve_linea
        '
        Me.cve_linea.DataPropertyName = "cve_linea"
        Me.cve_linea.HeaderText = "cve_linea"
        Me.cve_linea.Name = "cve_linea"
        Me.cve_linea.ReadOnly = True
        Me.cve_linea.Visible = False
        '
        'cve_registro
        '
        Me.cve_registro.DataPropertyName = "cve_registro"
        Me.cve_registro.HeaderText = "cve_registro"
        Me.cve_registro.Name = "cve_registro"
        Me.cve_registro.ReadOnly = True
        Me.cve_registro.Visible = False
        '
        'Nombre_Componente
        '
        Me.Nombre_Componente.DataPropertyName = "Nombre_Componente"
        Me.Nombre_Componente.HeaderText = "Nombre_Componente"
        Me.Nombre_Componente.Name = "Nombre_Componente"
        Me.Nombre_Componente.ReadOnly = True
        Me.Nombre_Componente.Visible = False
        '
        'Nombre_Clasificacion
        '
        Me.Nombre_Clasificacion.DataPropertyName = "Nombre_Clasificacion"
        Me.Nombre_Clasificacion.HeaderText = "Nombre_Clasificacion"
        Me.Nombre_Clasificacion.Name = "Nombre_Clasificacion"
        Me.Nombre_Clasificacion.ReadOnly = True
        Me.Nombre_Clasificacion.Visible = False
        '
        'estatus
        '
        Me.estatus.DataPropertyName = "estatus"
        Me.estatus.HeaderText = "estatus"
        Me.estatus.Name = "estatus"
        Me.estatus.ReadOnly = True
        Me.estatus.Visible = False
        '
        'frmImportador_Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 452)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(457, 490)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(457, 490)
        Me.Name = "frmImportador_Modelo"
        Me.Text = "Importar Modelo"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtParametro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents rbtFiltro_Nombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents cve_Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_componente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_clasificacion_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_registro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Componente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Clasificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
