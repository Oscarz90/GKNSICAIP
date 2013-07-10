<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLinea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComponente = New System.Windows.Forms.TextBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre_Linea = New System.Windows.Forms.TextBox()
        Me.nudTPCM = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnDarBaja = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.nudTPCM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Componente:"
        '
        'txtComponente
        '
        Me.txtComponente.Location = New System.Drawing.Point(109, 57)
        Me.txtComponente.Name = "txtComponente"
        Me.txtComponente.ReadOnly = True
        Me.txtComponente.Size = New System.Drawing.Size(242, 20)
        Me.txtComponente.TabIndex = 1
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(357, 57)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 2
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre de Linea:"
        '
        'txtNombre_Linea
        '
        Me.txtNombre_Linea.Location = New System.Drawing.Point(109, 31)
        Me.txtNombre_Linea.MaxLength = 30
        Me.txtNombre_Linea.Name = "txtNombre_Linea"
        Me.txtNombre_Linea.Size = New System.Drawing.Size(242, 20)
        Me.txtNombre_Linea.TabIndex = 4
        '
        'nudTPCM
        '
        Me.nudTPCM.Location = New System.Drawing.Point(201, 83)
        Me.nudTPCM.Name = "nudTPCM"
        Me.nudTPCM.Size = New System.Drawing.Size(150, 20)
        Me.nudTPCM.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tiempo Promedio Cambio de Modelo:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(196, 133)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(196, 133)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnDarBaja
        '
        Me.btnDarBaja.Location = New System.Drawing.Point(277, 133)
        Me.btnDarBaja.Name = "btnDarBaja"
        Me.btnDarBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnDarBaja.TabIndex = 9
        Me.btnDarBaja.Text = "Dar Baja"
        Me.btnDarBaja.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(358, 133)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 169)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDarBaja)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudTPCM)
        Me.Controls.Add(Me.txtNombre_Linea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.txtComponente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLinea"
        Me.Text = "Linea"
        CType(Me.nudTPCM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComponente As System.Windows.Forms.TextBox
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre_Linea As System.Windows.Forms.TextBox
    Friend WithEvents nudTPCM As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnDarBaja As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
