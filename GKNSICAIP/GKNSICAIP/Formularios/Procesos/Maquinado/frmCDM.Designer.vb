<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCDM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCDM))
        Me.imgBanner = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxModeloinicial = New System.Windows.Forms.ComboBox()
        Me.cbxModelofinal = New System.Windows.Forms.ComboBox()
        Me.txtModeloinicial = New System.Windows.Forms.TextBox()
        Me.txtModelofinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMinutosTotales = New System.Windows.Forms.TextBox()
        Me.chkL = New System.Windows.Forms.CheckBox()
        Me.chkM = New System.Windows.Forms.CheckBox()
        Me.chkN = New System.Windows.Forms.CheckBox()
        Me.chkO = New System.Windows.Forms.CheckBox()
        Me.chkQ = New System.Windows.Forms.CheckBox()
        Me.chkT = New System.Windows.Forms.CheckBox()
        Me.txtParoL = New System.Windows.Forms.TextBox()
        Me.txtParoM = New System.Windows.Forms.TextBox()
        Me.txtParoN = New System.Windows.Forms.TextBox()
        Me.txtParoO = New System.Windows.Forms.TextBox()
        Me.txtParoQ = New System.Windows.Forms.TextBox()
        Me.txtParoT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComents = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.paro_descr = New System.Windows.Forms.Label()
        Me.chkS = New System.Windows.Forms.CheckBox()
        Me.txtParoS = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdParoL = New System.Windows.Forms.Button()
        Me.cmdParoM = New System.Windows.Forms.Button()
        Me.cmdParoN = New System.Windows.Forms.Button()
        Me.cmdParoO = New System.Windows.Forms.Button()
        Me.cmdParoQ = New System.Windows.Forms.Button()
        Me.cmdParoT = New System.Windows.Forms.Button()
        Me.cmdParoS = New System.Windows.Forms.Button()
        Me.cmdAgregaComent = New System.Windows.Forms.Button()
        Me.lblAgregarComent = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdParoU7 = New System.Windows.Forms.Button()
        Me.txtParoU7 = New System.Windows.Forms.TextBox()
        Me.chkU7 = New System.Windows.Forms.CheckBox()
        Me.cmdParoA3 = New System.Windows.Forms.Button()
        Me.txtParoA3 = New System.Windows.Forms.TextBox()
        Me.chkA3 = New System.Windows.Forms.CheckBox()
        Me.lblcosto = New System.Windows.Forms.Label()
        Me.lblmejora = New System.Windows.Forms.Label()
        Me.cmdCDM = New System.Windows.Forms.Button()
        CType(Me.imgBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgBanner
        '
        Me.imgBanner.BackgroundImage = CType(resources.GetObject("imgBanner.BackgroundImage"), System.Drawing.Image)
        Me.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBanner.Location = New System.Drawing.Point(0, 0)
        Me.imgBanner.Name = "imgBanner"
        Me.imgBanner.Size = New System.Drawing.Size(504, 52)
        Me.imgBanner.TabIndex = 150
        Me.imgBanner.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Modelo Salida"
        '
        'cbxModeloinicial
        '
        Me.cbxModeloinicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloinicial.FormattingEnabled = True
        Me.cbxModeloinicial.Location = New System.Drawing.Point(141, 69)
        Me.cbxModeloinicial.Name = "cbxModeloinicial"
        Me.cbxModeloinicial.Size = New System.Drawing.Size(160, 21)
        Me.cbxModeloinicial.TabIndex = 153
        '
        'cbxModelofinal
        '
        Me.cbxModelofinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModelofinal.FormattingEnabled = True
        Me.cbxModelofinal.Location = New System.Drawing.Point(141, 101)
        Me.cbxModelofinal.Name = "cbxModelofinal"
        Me.cbxModelofinal.Size = New System.Drawing.Size(160, 21)
        Me.cbxModelofinal.TabIndex = 154
        '
        'txtModeloinicial
        '
        Me.txtModeloinicial.Location = New System.Drawing.Point(318, 69)
        Me.txtModeloinicial.Name = "txtModeloinicial"
        Me.txtModeloinicial.ReadOnly = True
        Me.txtModeloinicial.Size = New System.Drawing.Size(148, 20)
        Me.txtModeloinicial.TabIndex = 155
        '
        'txtModelofinal
        '
        Me.txtModelofinal.Location = New System.Drawing.Point(318, 101)
        Me.txtModelofinal.Name = "txtModelofinal"
        Me.txtModelofinal.ReadOnly = True
        Me.txtModelofinal.Size = New System.Drawing.Size(148, 20)
        Me.txtModelofinal.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Hora Inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Hora Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Minutos Totales:"
        '
        'txtMinutosTotales
        '
        Me.txtMinutosTotales.Location = New System.Drawing.Point(356, 157)
        Me.txtMinutosTotales.Name = "txtMinutosTotales"
        Me.txtMinutosTotales.ReadOnly = True
        Me.txtMinutosTotales.Size = New System.Drawing.Size(119, 20)
        Me.txtMinutosTotales.TabIndex = 162
        '
        'chkL
        '
        Me.chkL.AutoSize = True
        Me.chkL.Location = New System.Drawing.Point(15, 54)
        Me.chkL.Name = "chkL"
        Me.chkL.Size = New System.Drawing.Size(184, 17)
        Me.chkL.TabIndex = 163
        Me.chkL.Text = "L. Falta de Herramientas de Corte"
        Me.chkL.UseVisualStyleBackColor = True
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.Location = New System.Drawing.Point(15, 80)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(185, 17)
        Me.chkM.TabIndex = 164
        Me.chkM.Text = "M. Herramentales sin certificación"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'chkN
        '
        Me.chkN.AutoSize = True
        Me.chkN.Location = New System.Drawing.Point(15, 106)
        Me.chkN.Name = "chkN"
        Me.chkN.Size = New System.Drawing.Size(128, 17)
        Me.chkN.TabIndex = 165
        Me.chkN.Text = "N. Falta de Calibrador"
        Me.chkN.UseVisualStyleBackColor = True
        '
        'chkO
        '
        Me.chkO.AutoSize = True
        Me.chkO.Location = New System.Drawing.Point(16, 132)
        Me.chkO.Name = "chkO"
        Me.chkO.Size = New System.Drawing.Size(180, 17)
        Me.chkO.TabIndex = 166
        Me.chkO.Text = "O. Documentación de Presetting"
        Me.chkO.UseVisualStyleBackColor = True
        '
        'chkQ
        '
        Me.chkQ.AutoSize = True
        Me.chkQ.Location = New System.Drawing.Point(15, 158)
        Me.chkQ.Name = "chkQ"
        Me.chkQ.Size = New System.Drawing.Size(132, 17)
        Me.chkQ.TabIndex = 167
        Me.chkQ.Text = "Q. Inductor Falta/Falla"
        Me.chkQ.UseVisualStyleBackColor = True
        '
        'chkT
        '
        Me.chkT.AutoSize = True
        Me.chkT.Location = New System.Drawing.Point(15, 214)
        Me.chkT.Name = "chkT"
        Me.chkT.Size = New System.Drawing.Size(207, 17)
        Me.chkT.TabIndex = 168
        Me.chkT.Text = "T. Esperando liberación PAP por CDM"
        Me.chkT.UseVisualStyleBackColor = True
        '
        'txtParoL
        '
        Me.txtParoL.Location = New System.Drawing.Point(294, 52)
        Me.txtParoL.Name = "txtParoL"
        Me.txtParoL.Size = New System.Drawing.Size(106, 20)
        Me.txtParoL.TabIndex = 169
        Me.txtParoL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParoM
        '
        Me.txtParoM.Location = New System.Drawing.Point(294, 78)
        Me.txtParoM.Name = "txtParoM"
        Me.txtParoM.Size = New System.Drawing.Size(106, 20)
        Me.txtParoM.TabIndex = 170
        Me.txtParoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParoN
        '
        Me.txtParoN.Location = New System.Drawing.Point(294, 104)
        Me.txtParoN.Name = "txtParoN"
        Me.txtParoN.Size = New System.Drawing.Size(106, 20)
        Me.txtParoN.TabIndex = 171
        Me.txtParoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParoO
        '
        Me.txtParoO.Location = New System.Drawing.Point(294, 130)
        Me.txtParoO.Name = "txtParoO"
        Me.txtParoO.Size = New System.Drawing.Size(106, 20)
        Me.txtParoO.TabIndex = 172
        Me.txtParoO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParoQ
        '
        Me.txtParoQ.Location = New System.Drawing.Point(294, 156)
        Me.txtParoQ.Name = "txtParoQ"
        Me.txtParoQ.Size = New System.Drawing.Size(106, 20)
        Me.txtParoQ.TabIndex = 173
        Me.txtParoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtParoT
        '
        Me.txtParoT.Location = New System.Drawing.Point(293, 212)
        Me.txtParoT.Name = "txtParoT"
        Me.txtParoT.Size = New System.Drawing.Size(106, 20)
        Me.txtParoT.TabIndex = 174
        Me.txtParoT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Minutos:"
        '
        'txtComents
        '
        Me.txtComents.Location = New System.Drawing.Point(15, 279)
        Me.txtComents.Multiline = True
        Me.txtComents.Name = "txtComents"
        Me.txtComents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComents.Size = New System.Drawing.Size(356, 69)
        Me.txtComents.TabIndex = 177
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Comentarios:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Modelo Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 22)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "Cambio de Modelo"
        '
        'paro_descr
        '
        Me.paro_descr.AutoSize = True
        Me.paro_descr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paro_descr.Location = New System.Drawing.Point(218, 33)
        Me.paro_descr.Name = "paro_descr"
        Me.paro_descr.Size = New System.Drawing.Size(0, 19)
        Me.paro_descr.TabIndex = 183
        '
        'chkS
        '
        Me.chkS.AutoSize = True
        Me.chkS.Location = New System.Drawing.Point(15, 186)
        Me.chkS.Name = "chkS"
        Me.chkS.Size = New System.Drawing.Size(118, 17)
        Me.chkS.TabIndex = 184
        Me.chkS.Text = "S. Ajustes por CDM"
        Me.chkS.UseVisualStyleBackColor = True
        '
        'txtParoS
        '
        Me.txtParoS.Location = New System.Drawing.Point(293, 184)
        Me.txtParoS.Name = "txtParoS"
        Me.txtParoS.Size = New System.Drawing.Size(106, 20)
        Me.txtParoS.TabIndex = 185
        Me.txtParoS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdGuardar
        '
        Me.cmdGuardar.BackColor = System.Drawing.Color.White
        Me.cmdGuardar.BackgroundImage = CType(resources.GetObject("cmdGuardar.BackgroundImage"), System.Drawing.Image)
        Me.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdGuardar.Enabled = False
        Me.cmdGuardar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(114, 554)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(104, 62)
        Me.cmdGuardar.TabIndex = 186
        Me.cmdGuardar.UseVisualStyleBackColor = False
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.Color.White
        Me.cmdSalir.BackgroundImage = CType(resources.GetObject("cmdSalir.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSalir.Location = New System.Drawing.Point(283, 554)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(104, 61)
        Me.cmdSalir.TabIndex = 187
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 619)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 18)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Guardar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(316, 618)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 18)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Salir"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(24, 157)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(160, 20)
        Me.dtpInicio.TabIndex = 190
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(190, 157)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(160, 20)
        Me.dtpFinal.TabIndex = 191
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(328, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 192
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'cmdParoL
        '
        Me.cmdParoL.Image = CType(resources.GetObject("cmdParoL.Image"), System.Drawing.Image)
        Me.cmdParoL.Location = New System.Drawing.Point(415, 50)
        Me.cmdParoL.Name = "cmdParoL"
        Me.cmdParoL.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoL.TabIndex = 194
        Me.cmdParoL.UseVisualStyleBackColor = True
        '
        'cmdParoM
        '
        Me.cmdParoM.Image = CType(resources.GetObject("cmdParoM.Image"), System.Drawing.Image)
        Me.cmdParoM.Location = New System.Drawing.Point(415, 76)
        Me.cmdParoM.Name = "cmdParoM"
        Me.cmdParoM.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoM.TabIndex = 195
        Me.cmdParoM.UseVisualStyleBackColor = True
        '
        'cmdParoN
        '
        Me.cmdParoN.Image = CType(resources.GetObject("cmdParoN.Image"), System.Drawing.Image)
        Me.cmdParoN.Location = New System.Drawing.Point(415, 102)
        Me.cmdParoN.Name = "cmdParoN"
        Me.cmdParoN.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoN.TabIndex = 196
        Me.cmdParoN.UseVisualStyleBackColor = True
        '
        'cmdParoO
        '
        Me.cmdParoO.Image = CType(resources.GetObject("cmdParoO.Image"), System.Drawing.Image)
        Me.cmdParoO.Location = New System.Drawing.Point(415, 128)
        Me.cmdParoO.Name = "cmdParoO"
        Me.cmdParoO.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoO.TabIndex = 197
        Me.cmdParoO.UseVisualStyleBackColor = True
        '
        'cmdParoQ
        '
        Me.cmdParoQ.Image = CType(resources.GetObject("cmdParoQ.Image"), System.Drawing.Image)
        Me.cmdParoQ.Location = New System.Drawing.Point(415, 154)
        Me.cmdParoQ.Name = "cmdParoQ"
        Me.cmdParoQ.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoQ.TabIndex = 198
        Me.cmdParoQ.UseVisualStyleBackColor = True
        '
        'cmdParoT
        '
        Me.cmdParoT.Image = CType(resources.GetObject("cmdParoT.Image"), System.Drawing.Image)
        Me.cmdParoT.Location = New System.Drawing.Point(414, 210)
        Me.cmdParoT.Name = "cmdParoT"
        Me.cmdParoT.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoT.TabIndex = 199
        Me.cmdParoT.UseVisualStyleBackColor = True
        '
        'cmdParoS
        '
        Me.cmdParoS.Image = CType(resources.GetObject("cmdParoS.Image"), System.Drawing.Image)
        Me.cmdParoS.Location = New System.Drawing.Point(415, 182)
        Me.cmdParoS.Name = "cmdParoS"
        Me.cmdParoS.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoS.TabIndex = 200
        Me.cmdParoS.UseVisualStyleBackColor = True
        '
        'cmdAgregaComent
        '
        Me.cmdAgregaComent.Image = CType(resources.GetObject("cmdAgregaComent.Image"), System.Drawing.Image)
        Me.cmdAgregaComent.Location = New System.Drawing.Point(389, 279)
        Me.cmdAgregaComent.Name = "cmdAgregaComent"
        Me.cmdAgregaComent.Size = New System.Drawing.Size(47, 47)
        Me.cmdAgregaComent.TabIndex = 201
        Me.cmdAgregaComent.UseVisualStyleBackColor = True
        '
        'lblAgregarComent
        '
        Me.lblAgregarComent.AutoSize = True
        Me.lblAgregarComent.Location = New System.Drawing.Point(391, 335)
        Me.lblAgregarComent.Name = "lblAgregarComent"
        Me.lblAgregarComent.Size = New System.Drawing.Size(44, 13)
        Me.lblAgregarComent.TabIndex = 202
        Me.lblAgregarComent.Text = "Agregar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdParoU7)
        Me.GroupBox1.Controls.Add(Me.txtParoU7)
        Me.GroupBox1.Controls.Add(Me.chkU7)
        Me.GroupBox1.Controls.Add(Me.cmdParoA3)
        Me.GroupBox1.Controls.Add(Me.txtParoA3)
        Me.GroupBox1.Controls.Add(Me.chkA3)
        Me.GroupBox1.Controls.Add(Me.chkL)
        Me.GroupBox1.Controls.Add(Me.lblAgregarComent)
        Me.GroupBox1.Controls.Add(Me.chkM)
        Me.GroupBox1.Controls.Add(Me.cmdAgregaComent)
        Me.GroupBox1.Controls.Add(Me.chkN)
        Me.GroupBox1.Controls.Add(Me.cmdParoS)
        Me.GroupBox1.Controls.Add(Me.chkO)
        Me.GroupBox1.Controls.Add(Me.cmdParoT)
        Me.GroupBox1.Controls.Add(Me.chkQ)
        Me.GroupBox1.Controls.Add(Me.cmdParoQ)
        Me.GroupBox1.Controls.Add(Me.chkT)
        Me.GroupBox1.Controls.Add(Me.cmdParoO)
        Me.GroupBox1.Controls.Add(Me.txtParoL)
        Me.GroupBox1.Controls.Add(Me.cmdParoN)
        Me.GroupBox1.Controls.Add(Me.txtParoM)
        Me.GroupBox1.Controls.Add(Me.cmdParoM)
        Me.GroupBox1.Controls.Add(Me.txtParoN)
        Me.GroupBox1.Controls.Add(Me.cmdParoL)
        Me.GroupBox1.Controls.Add(Me.txtParoO)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtParoQ)
        Me.GroupBox1.Controls.Add(Me.txtParoT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtComents)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkS)
        Me.GroupBox1.Controls.Add(Me.txtParoS)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 365)
        Me.GroupBox1.TabIndex = 203
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paros "
        '
        'cmdParoU7
        '
        Me.cmdParoU7.Image = CType(resources.GetObject("cmdParoU7.Image"), System.Drawing.Image)
        Me.cmdParoU7.Location = New System.Drawing.Point(414, 236)
        Me.cmdParoU7.Name = "cmdParoU7"
        Me.cmdParoU7.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoU7.TabIndex = 208
        Me.cmdParoU7.UseVisualStyleBackColor = True
        '
        'txtParoU7
        '
        Me.txtParoU7.Location = New System.Drawing.Point(293, 238)
        Me.txtParoU7.Name = "txtParoU7"
        Me.txtParoU7.Size = New System.Drawing.Size(106, 20)
        Me.txtParoU7.TabIndex = 207
        Me.txtParoU7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkU7
        '
        Me.chkU7.AutoSize = True
        Me.chkU7.Location = New System.Drawing.Point(15, 240)
        Me.chkU7.Name = "chkU7"
        Me.chkU7.Size = New System.Drawing.Size(150, 17)
        Me.chkU7.TabIndex = 206
        Me.chkU7.Text = "U.7. Surtimiento de Piezas"
        Me.chkU7.UseVisualStyleBackColor = True
        '
        'cmdParoA3
        '
        Me.cmdParoA3.Image = CType(resources.GetObject("cmdParoA3.Image"), System.Drawing.Image)
        Me.cmdParoA3.Location = New System.Drawing.Point(414, 24)
        Me.cmdParoA3.Name = "cmdParoA3"
        Me.cmdParoA3.Size = New System.Drawing.Size(22, 22)
        Me.cmdParoA3.TabIndex = 205
        Me.cmdParoA3.UseVisualStyleBackColor = True
        '
        'txtParoA3
        '
        Me.txtParoA3.Location = New System.Drawing.Point(294, 26)
        Me.txtParoA3.Name = "txtParoA3"
        Me.txtParoA3.Size = New System.Drawing.Size(106, 20)
        Me.txtParoA3.TabIndex = 204
        Me.txtParoA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkA3
        '
        Me.chkA3.AutoSize = True
        Me.chkA3.Location = New System.Drawing.Point(15, 28)
        Me.chkA3.Name = "chkA3"
        Me.chkA3.Size = New System.Drawing.Size(237, 17)
        Me.chkA3.TabIndex = 203
        Me.chkA3.Text = "A.3 Intervención Mantto. Por mala operación"
        Me.chkA3.UseVisualStyleBackColor = True
        '
        'lblcosto
        '
        Me.lblcosto.AutoSize = True
        Me.lblcosto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcosto.Location = New System.Drawing.Point(37, 577)
        Me.lblcosto.Name = "lblcosto"
        Me.lblcosto.Size = New System.Drawing.Size(41, 16)
        Me.lblcosto.TabIndex = 204
        Me.lblcosto.Text = "costo"
        Me.lblcosto.Visible = False
        '
        'lblmejora
        '
        Me.lblmejora.AutoSize = True
        Me.lblmejora.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmejora.Location = New System.Drawing.Point(422, 578)
        Me.lblmejora.Name = "lblmejora"
        Me.lblmejora.Size = New System.Drawing.Size(53, 16)
        Me.lblmejora.TabIndex = 205
        Me.lblmejora.Text = "mejora"
        Me.lblmejora.Visible = False
        '
        'cmdCDM
        '
        Me.cmdCDM.Image = CType(resources.GetObject("cmdCDM.Image"), System.Drawing.Image)
        Me.cmdCDM.Location = New System.Drawing.Point(472, 82)
        Me.cmdCDM.Name = "cmdCDM"
        Me.cmdCDM.Size = New System.Drawing.Size(22, 22)
        Me.cmdCDM.TabIndex = 203
        Me.cmdCDM.UseVisualStyleBackColor = True
        '
        'frmCDM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(504, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCDM)
        Me.Controls.Add(Me.lblmejora)
        Me.Controls.Add(Me.lblcosto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.paro_descr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMinutosTotales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtModelofinal)
        Me.Controls.Add(Me.txtModeloinicial)
        Me.Controls.Add(Me.cbxModelofinal)
        Me.Controls.Add(Me.cbxModeloinicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgBanner)
        Me.Name = "frmCDM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CDM"
        CType(Me.imgBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBanner As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxModeloinicial As System.Windows.Forms.ComboBox
    Friend WithEvents cbxModelofinal As System.Windows.Forms.ComboBox
    Friend WithEvents txtModeloinicial As System.Windows.Forms.TextBox
    Friend WithEvents txtModelofinal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMinutosTotales As System.Windows.Forms.TextBox
    Friend WithEvents chkL As System.Windows.Forms.CheckBox
    Friend WithEvents chkM As System.Windows.Forms.CheckBox
    Friend WithEvents chkN As System.Windows.Forms.CheckBox
    Friend WithEvents chkO As System.Windows.Forms.CheckBox
    Friend WithEvents chkQ As System.Windows.Forms.CheckBox
    Friend WithEvents chkT As System.Windows.Forms.CheckBox
    Friend WithEvents txtParoL As System.Windows.Forms.TextBox
    Friend WithEvents txtParoM As System.Windows.Forms.TextBox
    Friend WithEvents txtParoN As System.Windows.Forms.TextBox
    Friend WithEvents txtParoO As System.Windows.Forms.TextBox
    Friend WithEvents txtParoQ As System.Windows.Forms.TextBox
    Friend WithEvents txtParoT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtComents As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents paro_descr As System.Windows.Forms.Label
    Friend WithEvents chkS As System.Windows.Forms.CheckBox
    Friend WithEvents txtParoS As System.Windows.Forms.TextBox
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdParoL As System.Windows.Forms.Button
    Friend WithEvents cmdParoM As System.Windows.Forms.Button
    Friend WithEvents cmdParoN As System.Windows.Forms.Button
    Friend WithEvents cmdParoO As System.Windows.Forms.Button
    Friend WithEvents cmdParoQ As System.Windows.Forms.Button
    Friend WithEvents cmdParoT As System.Windows.Forms.Button
    Friend WithEvents cmdParoS As System.Windows.Forms.Button
    Friend WithEvents cmdAgregaComent As System.Windows.Forms.Button
    Friend WithEvents lblAgregarComent As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcosto As System.Windows.Forms.Label
    Friend WithEvents lblmejora As System.Windows.Forms.Label
    Friend WithEvents cmdCDM As System.Windows.Forms.Button
    Friend WithEvents cmdParoA3 As System.Windows.Forms.Button
    Friend WithEvents txtParoA3 As System.Windows.Forms.TextBox
    Friend WithEvents chkA3 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdParoU7 As System.Windows.Forms.Button
    Friend WithEvents txtParoU7 As System.Windows.Forms.TextBox
    Friend WithEvents chkU7 As System.Windows.Forms.CheckBox
End Class
