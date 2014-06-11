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
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportarLinea = New System.Windows.Forms.Button()
        Me.txtClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaInicioFin = New Telerik.WinControls.UI.RadCalendar()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicioFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-25, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(499, 44)
        Me.banner_formulario.TabIndex = 109
        Me.banner_formulario.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Clasificación de Líneas"
        '
        'txtLinea
        '
        Me.txtLinea.BackColor = System.Drawing.Color.White
        Me.txtLinea.Location = New System.Drawing.Point(127, 62)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.ReadOnly = True
        Me.txtLinea.Size = New System.Drawing.Size(228, 20)
        Me.txtLinea.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Clasificación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Línea:"
        '
        'btnImportarLinea
        '
        Me.btnImportarLinea.Location = New System.Drawing.Point(375, 60)
        Me.btnImportarLinea.Name = "btnImportarLinea"
        Me.btnImportarLinea.Size = New System.Drawing.Size(75, 23)
        Me.btnImportarLinea.TabIndex = 119
        Me.btnImportarLinea.Text = "Importar"
        Me.btnImportarLinea.UseVisualStyleBackColor = True
        '
        'txtClasificacion
        '
        Me.txtClasificacion.FormattingEnabled = True
        Me.txtClasificacion.Location = New System.Drawing.Point(127, 115)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(228, 21)
        Me.txtClasificacion.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Fecha Inicial:"
        '
        'dtpFechaInicioFin
        '
        Me.dtpFechaInicioFin.Location = New System.Drawing.Point(149, 161)
        Me.dtpFechaInicioFin.Name = "dtpFechaInicioFin"
        Me.dtpFechaInicioFin.Size = New System.Drawing.Size(180, 134)
        Me.dtpFechaInicioFin.TabIndex = 122
        Me.dtpFechaInicioFin.Text = "RadCalendar1"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(257, 318)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 124
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(361, 318)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 123
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmRelacionLineaClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(471, 364)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtpFechaInicioFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClasificacion)
        Me.Controls.Add(Me.btnImportarLinea)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.banner_formulario)
        Me.MaximumSize = New System.Drawing.Size(487, 403)
        Me.MinimumSize = New System.Drawing.Size(487, 403)
        Me.Name = "frmRelacionLineaClasificacion"
        Me.Text = "Clasificación de Línea"
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicioFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImportarLinea As System.Windows.Forms.Button
    Friend WithEvents txtClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicioFin As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
