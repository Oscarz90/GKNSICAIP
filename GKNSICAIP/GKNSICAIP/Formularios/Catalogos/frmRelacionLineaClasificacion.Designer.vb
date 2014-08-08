<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacionLineaClasificacion
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxClasificacionLinea = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dtpFechaClasificacionLinea = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.cbxLinea = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaClasificacionLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxLinea.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxLinea.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-8, -6)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(422, 44)
        Me.banner_formulario.TabIndex = 109
        Me.banner_formulario.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(0, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 26)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Asignar clasificación a Línea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 19)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Clasificación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Línea:"
        '
        'cbxClasificacionLinea
        '
        Me.cbxClasificacionLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClasificacionLinea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClasificacionLinea.FormattingEnabled = True
        Me.cbxClasificacionLinea.Location = New System.Drawing.Point(112, 108)
        Me.cbxClasificacionLinea.Name = "cbxClasificacionLinea"
        Me.cbxClasificacionLinea.Size = New System.Drawing.Size(228, 27)
        Me.cbxClasificacionLinea.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Fecha Inicial:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(115, 207)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(101, 28)
        Me.btnRegistrar.TabIndex = 124
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(239, 207)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 28)
        Me.btnSalir.TabIndex = 123
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dtpFechaClasificacionLinea
        '
        Me.dtpFechaClasificacionLinea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaClasificacionLinea.Location = New System.Drawing.Point(112, 155)
        Me.dtpFechaClasificacionLinea.Name = "dtpFechaClasificacionLinea"
        Me.dtpFechaClasificacionLinea.Size = New System.Drawing.Size(228, 25)
        Me.dtpFechaClasificacionLinea.TabIndex = 125
        Me.dtpFechaClasificacionLinea.TabStop = False
        Me.dtpFechaClasificacionLinea.Value = New Date(CType(0, Long))
        '
        'cbxLinea
        '
        Me.cbxLinea.AutoSizeDropDownToBestFit = True
        Me.cbxLinea.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'cbxLinea.NestedRadGridView
        '
        Me.cbxLinea.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cbxLinea.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxLinea.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbxLinea.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxLinea.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxLinea.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'cbxLinea.NestedRadGridView
        '
        Me.cbxLinea.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cbxLinea.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cbxLinea.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cbxLinea.EditorControl.MasterTemplate.AllowDeleteRow = False
        Me.cbxLinea.EditorControl.MasterTemplate.AllowEditRow = False
        Me.cbxLinea.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cbxLinea.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cbxLinea.EditorControl.Name = "NestedRadGridView"
        Me.cbxLinea.EditorControl.ReadOnly = True
        Me.cbxLinea.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxLinea.EditorControl.ShowGroupPanel = False
        Me.cbxLinea.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cbxLinea.EditorControl.TabIndex = 0
        Me.cbxLinea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLinea.Location = New System.Drawing.Point(112, 65)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(228, 27)
        Me.cbxLinea.TabIndex = 126
        Me.cbxLinea.TabStop = False
        '
        'frmRelacionLineaClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 256)
        Me.Controls.Add(Me.cbxLinea)
        Me.Controls.Add(Me.dtpFechaClasificacionLinea)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxClasificacionLinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.banner_formulario)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(388, 295)
        Me.MinimumSize = New System.Drawing.Size(388, 295)
        Me.Name = "frmRelacionLineaClasificacion"
        Me.Text = "Clasificación de Línea"
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaClasificacionLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxLinea.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxLinea.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxClasificacionLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dtpFechaClasificacionLinea As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents cbxLinea As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class
