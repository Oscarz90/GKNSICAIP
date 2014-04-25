<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msg_Dialogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg_Dialogo))
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckbAcuerdo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_Entrada = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSi
        '
        Me.btnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Location = New System.Drawing.Point(507, 166)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(94, 29)
        Me.btnSi.TabIndex = 0
        Me.btnSi.TabStop = False
        Me.btnSi.Text = "Aceptar"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(607, 166)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(94, 29)
        Me.btnNo.TabIndex = 1
        Me.btnNo.TabStop = False
        Me.btnNo.Text = "Cancelar"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(12, 9)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(437, 24)
        Me.lbMensaje.TabIndex = 2
        Me.lbMensaje.Text = "¿Estás seguro del horario y línea(s) elegidos?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(82, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Advertencia:"
        '
        'ckbAcuerdo
        '
        Me.ckbAcuerdo.AutoSize = True
        Me.ckbAcuerdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbAcuerdo.Location = New System.Drawing.Point(12, 166)
        Me.ckbAcuerdo.Name = "ckbAcuerdo"
        Me.ckbAcuerdo.Size = New System.Drawing.Size(156, 24)
        Me.ckbAcuerdo.TabIndex = 5
        Me.ckbAcuerdo.TabStop = False
        Me.ckbAcuerdo.Text = "Estoy de acuerdo."
        Me.ckbAcuerdo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Una vez registrado el turno ya no se podra modificar."
        '
        'lb_Entrada
        '
        Me.lb_Entrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Entrada.AutoSize = True
        Me.lb_Entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Entrada.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lb_Entrada.Location = New System.Drawing.Point(12, 45)
        Me.lb_Entrada.Name = "lb_Entrada"
        Me.lb_Entrada.Size = New System.Drawing.Size(429, 36)
        Me.lb_Entrada.TabIndex = 8
        Me.lb_Entrada.Text = "(Linea_Seleccion) es (Turno)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'msg_Dialogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(714, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lb_Entrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckbAcuerdo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Name = "msg_Dialogo"
        Me.Text = "Confirmación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lbMensaje As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckbAcuerdo As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_Entrada As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
