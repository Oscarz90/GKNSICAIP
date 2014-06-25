<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificacionPermiso
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dtpDiaModificacion = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpFechaInicial = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpFechaFinal = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxUsuarios = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDiaModificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarios.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(460, 54)
        Me.PictureBox2.TabIndex = 149
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Usuario Maquina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 19)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Día Modificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Fecha Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Fecha Final:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(222, 284)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(88, 28)
        Me.btnRegistrar.TabIndex = 154
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(339, 284)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 28)
        Me.btnSalir.TabIndex = 155
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dtpDiaModificacion
        '
        Me.dtpDiaModificacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDiaModificacion.Location = New System.Drawing.Point(160, 128)
        Me.dtpDiaModificacion.Name = "dtpDiaModificacion"
        Me.dtpDiaModificacion.Size = New System.Drawing.Size(267, 25)
        Me.dtpDiaModificacion.TabIndex = 157
        Me.dtpDiaModificacion.TabStop = False
        Me.dtpDiaModificacion.Value = New Date(CType(0, Long))
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicial.Location = New System.Drawing.Point(160, 175)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(267, 25)
        Me.dtpFechaInicial.TabIndex = 158
        Me.dtpFechaInicial.TabStop = False
        Me.dtpFechaInicial.Value = New Date(CType(0, Long))
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Location = New System.Drawing.Point(160, 222)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(267, 25)
        Me.dtpFechaFinal.TabIndex = 159
        Me.dtpFechaFinal.TabStop = False
        Me.dtpFechaFinal.Value = New Date(CType(0, Long))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(21, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 26)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Modificaciones"
        '
        'cbxUsuarios
        '
        Me.cbxUsuarios.AutoFilter = True
        Me.cbxUsuarios.AutoSizeDropDownToBestFit = True
        Me.cbxUsuarios.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxUsuarios.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'cbxUsuarios.NestedRadGridView
        '
        Me.cbxUsuarios.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.cbxUsuarios.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUsuarios.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxUsuarios.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.cbxUsuarios.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.cbxUsuarios.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.cbxUsuarios.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.cbxUsuarios.EditorControl.MasterTemplate.EnableFiltering = True
        Me.cbxUsuarios.EditorControl.MasterTemplate.EnableGrouping = False
        Me.cbxUsuarios.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.cbxUsuarios.EditorControl.Name = "NestedRadGridView"
        Me.cbxUsuarios.EditorControl.ReadOnly = True
        Me.cbxUsuarios.EditorControl.ShowGroupPanel = False
        Me.cbxUsuarios.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.cbxUsuarios.EditorControl.TabIndex = 0
        Me.cbxUsuarios.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUsuarios.Location = New System.Drawing.Point(160, 84)
        Me.cbxUsuarios.Name = "cbxUsuarios"
        Me.cbxUsuarios.Size = New System.Drawing.Size(267, 26)
        Me.cbxUsuarios.TabIndex = 161
        Me.cbxUsuarios.TabStop = False
        '
        'frmModificacionPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 333)
        Me.Controls.Add(Me.cbxUsuarios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.dtpDiaModificacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(472, 372)
        Me.MinimumSize = New System.Drawing.Size(472, 372)
        Me.Name = "frmModificacionPermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso Modificaciones"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDiaModificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dtpDiaModificacion As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpFechaInicial As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents dtpFechaFinal As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxUsuarios As Telerik.WinControls.UI.RadMultiColumnComboBox
End Class
