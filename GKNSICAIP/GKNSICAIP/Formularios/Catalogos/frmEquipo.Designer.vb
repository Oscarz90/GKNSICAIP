<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipo
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnImportar_Imagen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImportar_LG = New System.Windows.Forms.Button()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.txtLet = New System.Windows.Forms.TextBox()
        Me.txtLG = New System.Windows.Forms.TextBox()
        Me.txtTipo_Tlatoani = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEquipo = New System.Windows.Forms.TextBox()
        Me.txtCve_Kronos = New System.Windows.Forms.TextBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(374, 436)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 147
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(292, 436)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 146
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnImportar_Imagen
        '
        Me.btnImportar_Imagen.Location = New System.Drawing.Point(351, 207)
        Me.btnImportar_Imagen.Name = "btnImportar_Imagen"
        Me.btnImportar_Imagen.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar_Imagen.TabIndex = 4
        Me.btnImportar_Imagen.Text = "Importar"
        Me.btnImportar_Imagen.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-80, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Imagen:"
        '
        'btnImportar_LG
        '
        Me.btnImportar_LG.Location = New System.Drawing.Point(351, 154)
        Me.btnImportar_LG.Name = "btnImportar_LG"
        Me.btnImportar_LG.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar_LG.TabIndex = 2
        Me.btnImportar_LG.Text = "Importar"
        Me.btnImportar_LG.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(351, 127)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 1
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-80, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Let:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-80, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "LG:"
        '
        'txtImagen
        '
        Me.txtImagen.Location = New System.Drawing.Point(98, 209)
        Me.txtImagen.MaxLength = 30
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.ReadOnly = True
        Me.txtImagen.Size = New System.Drawing.Size(242, 20)
        Me.txtImagen.TabIndex = 138
        '
        'txtLet
        '
        Me.txtLet.Location = New System.Drawing.Point(98, 182)
        Me.txtLet.MaxLength = 30
        Me.txtLet.Name = "txtLet"
        Me.txtLet.Size = New System.Drawing.Size(242, 20)
        Me.txtLet.TabIndex = 3
        '
        'txtLG
        '
        Me.txtLG.Location = New System.Drawing.Point(98, 156)
        Me.txtLG.MaxLength = 30
        Me.txtLG.Name = "txtLG"
        Me.txtLG.ReadOnly = True
        Me.txtLG.Size = New System.Drawing.Size(242, 20)
        Me.txtLG.TabIndex = 136
        '
        'txtTipo_Tlatoani
        '
        Me.txtTipo_Tlatoani.Location = New System.Drawing.Point(98, 129)
        Me.txtTipo_Tlatoani.MaxLength = 30
        Me.txtTipo_Tlatoani.Name = "txtTipo_Tlatoani"
        Me.txtTipo_Tlatoani.ReadOnly = True
        Me.txtTipo_Tlatoani.Size = New System.Drawing.Size(242, 20)
        Me.txtTipo_Tlatoani.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-80, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Tipo tlatoani:"
        '
        'txtEquipo
        '
        Me.txtEquipo.Enabled = False
        Me.txtEquipo.Location = New System.Drawing.Point(98, 103)
        Me.txtEquipo.MaxLength = 30
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.Size = New System.Drawing.Size(242, 20)
        Me.txtEquipo.TabIndex = 133
        '
        'txtCve_Kronos
        '
        Me.txtCve_Kronos.Enabled = False
        Me.txtCve_Kronos.Location = New System.Drawing.Point(98, 75)
        Me.txtCve_Kronos.MaxLength = 30
        Me.txtCve_Kronos.Name = "txtCve_Kronos"
        Me.txtCve_Kronos.Size = New System.Drawing.Size(86, 20)
        Me.txtCve_Kronos.TabIndex = 132
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(-83, -59)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(99, 32)
        Me.titulo_banner_formulario.TabIndex = 131
        Me.titulo_banner_formulario.Text = "Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-80, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Equipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-80, -16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Cve_Kronos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Imagen:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 154
        Me.Label8.Text = "Let:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "LG:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "Tipo tlatoani:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 32)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Equipo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 150
        Me.Label12.Text = "Equipo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Cve_Kronos:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(469, 54)
        Me.PictureBox2.TabIndex = 148
        Me.PictureBox2.TabStop = False
        '
        'pbImagen
        '
        Me.pbImagen.Location = New System.Drawing.Point(90, 237)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(250, 170)
        Me.pbImagen.TabIndex = 145
        Me.pbImagen.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-92, -101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 54)
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'ofdImagen
        '
        Me.ofdImagen.FileName = "OpenFileDialog1"
        '
        'frmEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 477)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnImportar_Imagen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnImportar_LG)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtImagen)
        Me.Controls.Add(Me.txtLet)
        Me.Controls.Add(Me.txtLG)
        Me.Controls.Add(Me.txtTipo_Tlatoani)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEquipo)
        Me.Controls.Add(Me.txtCve_Kronos)
        Me.Controls.Add(Me.titulo_banner_formulario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmEquipo"
        Me.Text = "Equipo"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnImportar_Imagen As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImportar_LG As System.Windows.Forms.Button
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents txtLet As System.Windows.Forms.TextBox
    Friend WithEvents txtLG As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo_Tlatoani As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEquipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCve_Kronos As System.Windows.Forms.TextBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
End Class
