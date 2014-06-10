<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pruebaGRID
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
        Me.dgvDatos = New Telerik.WinControls.UI.RadGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dgvDatosWindows = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDatosWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.BackColor = System.Drawing.SystemColors.Control
        Me.dgvDatos.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDatos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvDatos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvDatos.Location = New System.Drawing.Point(12, 48)
        '
        'dgvDatos
        '
        Me.dgvDatos.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvDatos.Size = New System.Drawing.Size(1202, 252)
        Me.dgvDatos.TabIndex = 0
        Me.dgvDatos.Text = "RadGridView1"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(1066, 306)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(148, 23)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dgvDatosWindows
        '
        Me.dgvDatosWindows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosWindows.Location = New System.Drawing.Point(12, 335)
        Me.dgvDatosWindows.Name = "dgvDatosWindows"
        Me.dgvDatosWindows.Size = New System.Drawing.Size(1202, 228)
        Me.dgvDatosWindows.TabIndex = 2
        Me.dgvDatosWindows.Visible = False
        '
        'pruebaGRID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 575)
        Me.Controls.Add(Me.dgvDatosWindows)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "pruebaGRID"
        Me.Text = "pruebaGRID"
        CType(Me.dgvDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDatosWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDatos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents dgvDatosWindows As System.Windows.Forms.DataGridView
End Class
