<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msg_ModificacionesPermiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(msg_ModificacionesPermiso))
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblDiaModificacion = New System.Windows.Forms.Label()
        Me.chkbxAcuerdo = New System.Windows.Forms.CheckBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAdvertencia = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblDelete = New System.Windows.Forms.Label()
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
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(108, 41)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(236, 19)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Se asignará el permiso al usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblUsuario.Location = New System.Drawing.Point(108, 59)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(60, 19)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "usuario"
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
        Me.lbl2.Location = New System.Drawing.Point(108, 78)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(154, 19)
        Me.lbl2.TabIndex = 18
        Me.lbl2.Text = "Para modificar el día:"
        '
        'lblDiaModificacion
        '
        Me.lblDiaModificacion.AutoSize = True
        Me.lblDiaModificacion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaModificacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblDiaModificacion.Location = New System.Drawing.Point(268, 78)
        Me.lblDiaModificacion.Name = "lblDiaModificacion"
        Me.lblDiaModificacion.Size = New System.Drawing.Size(60, 19)
        Me.lblDiaModificacion.TabIndex = 19
        Me.lblDiaModificacion.Text = "usuario"
        '
        'chkbxAcuerdo
        '
        Me.chkbxAcuerdo.AutoSize = True
        Me.chkbxAcuerdo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbxAcuerdo.Location = New System.Drawing.Point(12, 230)
        Me.chkbxAcuerdo.Name = "chkbxAcuerdo"
        Me.chkbxAcuerdo.Size = New System.Drawing.Size(152, 23)
        Me.chkbxAcuerdo.TabIndex = 20
        Me.chkbxAcuerdo.Text = "Estoy de Acuerdo."
        Me.chkbxAcuerdo.UseVisualStyleBackColor = True
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(108, 97)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(321, 19)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "Con permiso de modificación entre las fechas."
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(108, 135)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(97, 19)
        Me.lbl5.TabIndex = 22
        Me.lbl5.Text = "Fecha de Fin:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(108, 116)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(114, 19)
        Me.lbl4.TabIndex = 23
        Me.lbl4.Text = "Fecha de Inicio:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblFechaInicio.Location = New System.Drawing.Point(228, 116)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(60, 19)
        Me.lblFechaInicio.TabIndex = 24
        Me.lblFechaInicio.Text = "usuario"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblFechaFin.Location = New System.Drawing.Point(228, 135)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(60, 19)
        Me.lblFechaFin.TabIndex = 25
        Me.lblFechaFin.Text = "usuario"
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
        Me.txtAdvertencia.Text = "Una vez creado solo se podrá modificar o borrar antes de la FECHA DE INICIO."
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
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDelete.Location = New System.Drawing.Point(121, 78)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(344, 23)
        Me.lblDelete.TabIndex = 31
        Me.lblDelete.Text = "¿Está seguro que desea borrar el registro?"
        Me.lblDelete.Visible = False
        '
        'msg_ModificacionesPermiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 265)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtAdvertencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.chkbxAcuerdo)
        Me.Controls.Add(Me.lblDiaModificacion)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbltitulo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 304)
        Me.MinimumSize = New System.Drawing.Size(509, 304)
        Me.Name = "msg_ModificacionesPermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "msg_ModificacionesPermiso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblDiaModificacion As System.Windows.Forms.Label
    Friend WithEvents chkbxAcuerdo As System.Windows.Forms.CheckBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdvertencia As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblDelete As System.Windows.Forms.Label
End Class
