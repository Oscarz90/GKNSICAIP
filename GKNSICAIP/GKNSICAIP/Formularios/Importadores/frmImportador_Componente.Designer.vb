<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportador_Componente
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
        Me.cve_Componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_cadena_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(309, 54)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(309, 83)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(50, 333)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(334, 20)
        Me.txtParametro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 336)
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cve_Componente, Me.cve_cadena_valor, Me.componente, Me.precio})
        Me.dgvDatos.Location = New System.Drawing.Point(12, 12)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(291, 315)
        Me.dgvDatos.TabIndex = 4
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.AutoSize = True
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(121, 362)
        Me.rbtFiltro_Nombre.Name = "rbtFiltro_Nombre"
        Me.rbtFiltro_Nombre.Size = New System.Drawing.Size(108, 17)
        Me.rbtFiltro_Nombre.TabIndex = 5
        Me.rbtFiltro_Nombre.Text = "Filtrar por Nombre"
        Me.rbtFiltro_Nombre.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(309, 359)
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
        Me.rbtTodos.Checked = True
        Me.rbtTodos.Location = New System.Drawing.Point(50, 362)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(65, 17)
        Me.rbtTodos.TabIndex = 7
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Sin Filtro"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'cve_Componente
        '
        Me.cve_Componente.DataPropertyName = "cve_Componente"
        Me.cve_Componente.HeaderText = "cve_Componente"
        Me.cve_Componente.Name = "cve_Componente"
        Me.cve_Componente.ReadOnly = True
        Me.cve_Componente.Visible = False
        Me.cve_Componente.Width = 200
        '
        'cve_cadena_valor
        '
        Me.cve_cadena_valor.DataPropertyName = "cve_cadena_valor"
        Me.cve_cadena_valor.HeaderText = "cve_cadena_valor"
        Me.cve_cadena_valor.Name = "cve_cadena_valor"
        Me.cve_cadena_valor.ReadOnly = True
        Me.cve_cadena_valor.Visible = False
        '
        'componente
        '
        Me.componente.DataPropertyName = "componente"
        Me.componente.HeaderText = "Componente"
        Me.componente.Name = "componente"
        Me.componente.ReadOnly = True
        Me.componente.Width = 200
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Visible = False
        '
        'frmImportador_Componente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 418)
        Me.Controls.Add(Me.rbtTodos)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.rbtFiltro_Nombre)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImportar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportador_Componente"
        Me.Text = "Importar Componente"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtParametro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents rbtFiltro_Nombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents cve_Componente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_cadena_valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents componente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
