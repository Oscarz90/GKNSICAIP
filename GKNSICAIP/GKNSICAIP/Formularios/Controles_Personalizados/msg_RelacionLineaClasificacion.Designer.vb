<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msg_RelacionLineaClasificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg_RelacionLineaClasificacion))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lblLinea = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.chkbxAcuerdo = New System.Windows.Forms.CheckBox()
        Me.lblClasif = New System.Windows.Forms.Label()
        Me.lblFecAux = New System.Windows.Forms.Label()
        Me.lblFechaAuxiliar = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdvertencia = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lbldescripcion = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbltitulo.Location = New System.Drawing.Point(108, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(286, 19)
        Me.lbltitulo.TabIndex = 0
        Me.lbltitulo.Text = "¿Está seguro que desea crear el registro?"
        '
        'lblLinea
        '
        Me.lblLinea.AutoSize = True
        Me.lblLinea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinea.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblLinea.Location = New System.Drawing.Point(233, 81)
        Me.lblLinea.Name = "lblLinea"
        Me.lblLinea.Size = New System.Drawing.Size(42, 19)
        Me.lblLinea.TabIndex = 2
        Me.lblLinea.Text = "linea"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(113, 81)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 19)
        Me.lbl2.TabIndex = 18
        Me.lbl2.Text = "Línea:"
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasificacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblClasificacion.Location = New System.Drawing.Point(233, 122)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(91, 19)
        Me.lblClasificacion.TabIndex = 19
        Me.lblClasificacion.Text = "clasificacion"
        '
        'chkbxAcuerdo
        '
        Me.chkbxAcuerdo.AutoSize = True
        Me.chkbxAcuerdo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxAcuerdo.Location = New System.Drawing.Point(27, 225)
        Me.chkbxAcuerdo.Name = "chkbxAcuerdo"
        Me.chkbxAcuerdo.Size = New System.Drawing.Size(152, 23)
        Me.chkbxAcuerdo.TabIndex = 20
        Me.chkbxAcuerdo.Text = "Estoy de Acuerdo."
        Me.chkbxAcuerdo.UseVisualStyleBackColor = True
        '
        'lblClasif
        '
        Me.lblClasif.AutoSize = True
        Me.lblClasif.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasif.ForeColor = System.Drawing.Color.Black
        Me.lblClasif.Location = New System.Drawing.Point(113, 122)
        Me.lblClasif.Name = "lblClasif"
        Me.lblClasif.Size = New System.Drawing.Size(96, 19)
        Me.lblClasif.TabIndex = 21
        Me.lblClasif.Text = "Clasificación:"
        '
        'lblFecAux
        '
        Me.lblFecAux.AutoSize = True
        Me.lblFecAux.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAux.ForeColor = System.Drawing.Color.Black
        Me.lblFecAux.Location = New System.Drawing.Point(113, 100)
        Me.lblFecAux.Name = "lblFecAux"
        Me.lblFecAux.Size = New System.Drawing.Size(114, 19)
        Me.lblFecAux.TabIndex = 23
        Me.lblFecAux.Text = "Fecha de Inicio:"
        '
        'lblFechaAuxiliar
        '
        Me.lblFechaAuxiliar.AutoSize = True
        Me.lblFechaAuxiliar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAuxiliar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblFechaAuxiliar.Location = New System.Drawing.Point(233, 100)
        Me.lblFechaAuxiliar.Name = "lblFechaAuxiliar"
        Me.lblFechaAuxiliar.Size = New System.Drawing.Size(46, 19)
        Me.lblFechaAuxiliar.TabIndex = 24
        Me.lblFechaAuxiliar.Text = "fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(23, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Advertencia:"
        '
        'txtAdvertencia
        '
        Me.txtAdvertencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdvertencia.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvertencia.Location = New System.Drawing.Point(125, 168)
        Me.txtAdvertencia.Multiline = True
        Me.txtAdvertencia.Name = "txtAdvertencia"
        Me.txtAdvertencia.Size = New System.Drawing.Size(345, 51)
        Me.txtAdvertencia.TabIndex = 28
        Me.txtAdvertencia.Text = "Una vez creado solo se podrá modificar su FECHA FINAL."
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(272, 225)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 28)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(384, 225)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 28)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lbldescripcion
        '
        Me.lbldescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbldescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.Location = New System.Drawing.Point(112, 27)
        Me.lbldescripcion.Multiline = True
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(358, 51)
        Me.lbldescripcion.TabIndex = 32
        Me.lbldescripcion.Text = "Se asignará la  siguiente clasificación a la Línea:"
        '
        'msg_RelacionLineaClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 265)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtAdvertencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblFechaAuxiliar)
        Me.Controls.Add(Me.lblFecAux)
        Me.Controls.Add(Me.lblClasif)
        Me.Controls.Add(Me.chkbxAcuerdo)
        Me.Controls.Add(Me.lblClasificacion)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLinea)
        Me.Controls.Add(Me.lbltitulo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 304)
        Me.MinimumSize = New System.Drawing.Size(509, 304)
        Me.Name = "msg_RelacionLineaClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación de Líneas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblLinea As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblClasificacion As System.Windows.Forms.Label
    Friend WithEvents chkbxAcuerdo As System.Windows.Forms.CheckBox
    Friend WithEvents lblClasif As System.Windows.Forms.Label
    Friend WithEvents lblFecAux As System.Windows.Forms.Label
    Friend WithEvents lblFechaAuxiliar As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdvertencia As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lbldescripcion As System.Windows.Forms.TextBox
End Class
