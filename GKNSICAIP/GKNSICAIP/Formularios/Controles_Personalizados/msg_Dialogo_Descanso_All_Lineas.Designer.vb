<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msg_Dialogo_Descanso_All_Lineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg_Dialogo_Descanso_All_Lineas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ckbAcuerdo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_Entrada = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "No se podrá modificar el descanso después de la fecha indicada."
        '
        'ckbAcuerdo
        '
        Me.ckbAcuerdo.AutoSize = True
        Me.ckbAcuerdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbAcuerdo.Location = New System.Drawing.Point(10, 166)
        Me.ckbAcuerdo.Name = "ckbAcuerdo"
        Me.ckbAcuerdo.Size = New System.Drawing.Size(156, 24)
        Me.ckbAcuerdo.TabIndex = 14
        Me.ckbAcuerdo.TabStop = False
        Me.ckbAcuerdo.Text = "Estoy de acuerdo."
        Me.ckbAcuerdo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(80, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Advertencia:"
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(10, 9)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(508, 24)
        Me.lbMensaje.TabIndex = 12
        Me.lbMensaje.Text = "¿Estás seguro de registrar el descanso de tu equipo?"
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(560, 164)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(94, 29)
        Me.btnNo.TabIndex = 11
        Me.btnNo.TabStop = False
        Me.btnNo.Text = "Cancelar"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnSi
        '
        Me.btnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Location = New System.Drawing.Point(460, 164)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(94, 29)
        Me.btnSi.TabIndex = 10
        Me.btnSi.TabStop = False
        Me.btnSi.Text = "Aceptar"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lb_Entrada
        '
        Me.lb_Entrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Entrada.AutoSize = True
        Me.lb_Entrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Entrada.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lb_Entrada.Location = New System.Drawing.Point(135, 45)
        Me.lb_Entrada.Name = "lb_Entrada"
        Me.lb_Entrada.Size = New System.Drawing.Size(177, 36)
        Me.lb_Entrada.TabIndex = 17
        Me.lb_Entrada.Text = "25/03/2014"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 36)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha: "
        '
        'msg_Dialogo_Descanso_All_Lineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 205)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_Entrada)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckbAcuerdo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnSi)
        Me.Name = "msg_Dialogo_Descanso_All_Lineas"
        Me.Text = "Confirmación"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbAcuerdo As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbMensaje As System.Windows.Forms.Label
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents lb_Entrada As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
