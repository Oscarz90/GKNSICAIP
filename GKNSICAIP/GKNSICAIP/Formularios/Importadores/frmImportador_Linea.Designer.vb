﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportador_Linea
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
        Me.cve_Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cve_componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpcdm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Componente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbtFiltro_Nombre = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(309, 62)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(309, 91)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(50, 390)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(334, 20)
        Me.txtParametro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 393)
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cve_Linea, Me.Estatus, Me.cve_componente, Me.Linea, Me.tpcdm, Me.Nombre_Componente})
        Me.dgvDatos.Location = New System.Drawing.Point(12, 62)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(291, 315)
        Me.dgvDatos.TabIndex = 4
        '
        'cve_Linea
        '
        Me.cve_Linea.DataPropertyName = "cve_Linea"
        Me.cve_Linea.HeaderText = "cve_Linea"
        Me.cve_Linea.Name = "cve_Linea"
        Me.cve_Linea.ReadOnly = True
        Me.cve_Linea.Visible = False
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Visible = False
        '
        'cve_componente
        '
        Me.cve_componente.DataPropertyName = "cve_componente"
        Me.cve_componente.HeaderText = "cve_componente"
        Me.cve_componente.Name = "cve_componente"
        Me.cve_componente.ReadOnly = True
        Me.cve_componente.Visible = False
        '
        'Linea
        '
        Me.Linea.DataPropertyName = "Linea"
        Me.Linea.HeaderText = "Linea"
        Me.Linea.Name = "Linea"
        Me.Linea.ReadOnly = True
        Me.Linea.Width = 200
        '
        'tpcdm
        '
        Me.tpcdm.DataPropertyName = "tpcdm"
        Me.tpcdm.HeaderText = "tpcdm"
        Me.tpcdm.Name = "tpcdm"
        Me.tpcdm.ReadOnly = True
        Me.tpcdm.Visible = False
        '
        'Nombre_Componente
        '
        Me.Nombre_Componente.DataPropertyName = "Nombre_Componente"
        Me.Nombre_Componente.HeaderText = "Nombre_Componente"
        Me.Nombre_Componente.Name = "Nombre_Componente"
        Me.Nombre_Componente.ReadOnly = True
        Me.Nombre_Componente.Visible = False
        '
        'rbtFiltro_Nombre
        '
        Me.rbtFiltro_Nombre.AutoSize = True
        Me.rbtFiltro_Nombre.Checked = True
        Me.rbtFiltro_Nombre.Enabled = False
        Me.rbtFiltro_Nombre.Location = New System.Drawing.Point(121, 419)
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
        Me.btnFiltrar.Location = New System.Drawing.Point(309, 416)
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
        Me.rbtTodos.Location = New System.Drawing.Point(50, 419)
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
        Me.Label2.Location = New System.Drawing.Point(309, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Si no Existe:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(309, 175)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(396, 44)
        Me.banner_formulario.TabIndex = 110
        Me.banner_formulario.TabStop = False
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
        Me.Panel1.Controls.Add(Me.btnImportar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvDatos)
        Me.Panel1.Controls.Add(Me.txtParametro)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 451)
        Me.Panel1.TabIndex = 111
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(190, 32)
        Me.titulo_banner_formulario.TabIndex = 111
        Me.titulo_banner_formulario.Text = "Importar Línea"
        '
        'frmImportador_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 451)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(412, 489)
        Me.Name = "frmImportador_Linea"
        Me.Text = "Importar Línea"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents cve_Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cve_componente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpcdm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Componente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
