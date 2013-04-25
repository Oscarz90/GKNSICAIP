<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraficas))
        Me.Exportar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.groupTipo = New System.Windows.Forms.GroupBox()
        Me.rbtStock = New System.Windows.Forms.RadioButton()
        Me.rbtBarras = New System.Windows.Forms.RadioButton()
        Me.rbtLineas = New System.Windows.Forms.RadioButton()
        Me.frmSalir = New System.Windows.Forms.Button()
        Me.grp3 = New System.Windows.Forms.GroupBox()
        Me.rbtCosto = New System.Windows.Forms.RadioButton()
        Me.rbtOEE = New System.Windows.Forms.RadioButton()
        Me.rbtSeg = New System.Windows.Forms.RadioButton()
        Me.rbt5s = New System.Windows.Forms.RadioButton()
        Me.rbtNRFTi = New System.Windows.Forms.RadioButton()
        Me.rbtGente = New System.Windows.Forms.RadioButton()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdGraficar = New System.Windows.Forms.Button()
        Me.grp2 = New System.Windows.Forms.GroupBox()
        Me.rbtAnos = New System.Windows.Forms.RadioButton()
        Me.rbtDia = New System.Windows.Forms.RadioButton()
        Me.rbtMeses = New System.Windows.Forms.RadioButton()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.cbxLinea = New System.Windows.Forms.ComboBox()
        Me.cbxEquipo = New System.Windows.Forms.ComboBox()
        Me.cbxUN = New System.Windows.Forms.ComboBox()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        Me.lblInstrucciones1 = New System.Windows.Forms.Label()
        Me.lblInstrucciones2 = New System.Windows.Forms.Label()
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.swfGrafica = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTodasLineas = New System.Windows.Forms.CheckBox()
        Me.groupTipo.SuspendLayout()
        Me.grp3.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.grp1.SuspendLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.swfGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exportar
        '
        Me.Exportar.AutoSize = True
        Me.Exportar.BackColor = System.Drawing.Color.White
        Me.Exportar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exportar.Location = New System.Drawing.Point(1059, 227)
        Me.Exportar.Name = "Exportar"
        Me.Exportar.Size = New System.Drawing.Size(98, 19)
        Me.Exportar.TabIndex = 93
        Me.Exportar.Text = "EXPORTAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(919, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "GRAFICAR"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1175, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 26)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Salir"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupTipo
        '
        Me.groupTipo.BackColor = System.Drawing.SystemColors.Window
        Me.groupTipo.Controls.Add(Me.rbtStock)
        Me.groupTipo.Controls.Add(Me.rbtBarras)
        Me.groupTipo.Controls.Add(Me.rbtLineas)
        Me.groupTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupTipo.Location = New System.Drawing.Point(895, 64)
        Me.groupTipo.Name = "groupTipo"
        Me.groupTipo.Size = New System.Drawing.Size(270, 61)
        Me.groupTipo.TabIndex = 88
        Me.groupTipo.TabStop = False
        Me.groupTipo.Text = "Tipo de gráfica"
        '
        'rbtStock
        '
        Me.rbtStock.AutoSize = True
        Me.rbtStock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStock.Location = New System.Drawing.Point(168, 25)
        Me.rbtStock.Name = "rbtStock"
        Me.rbtStock.Size = New System.Drawing.Size(61, 20)
        Me.rbtStock.TabIndex = 2
        Me.rbtStock.TabStop = True
        Me.rbtStock.Text = "Stock"
        Me.rbtStock.UseVisualStyleBackColor = True
        '
        'rbtBarras
        '
        Me.rbtBarras.AutoSize = True
        Me.rbtBarras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtBarras.Location = New System.Drawing.Point(98, 25)
        Me.rbtBarras.Name = "rbtBarras"
        Me.rbtBarras.Size = New System.Drawing.Size(67, 20)
        Me.rbtBarras.TabIndex = 1
        Me.rbtBarras.TabStop = True
        Me.rbtBarras.Text = "Barras"
        Me.rbtBarras.UseVisualStyleBackColor = True
        '
        'rbtLineas
        '
        Me.rbtLineas.AutoSize = True
        Me.rbtLineas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtLineas.Location = New System.Drawing.Point(28, 25)
        Me.rbtLineas.Name = "rbtLineas"
        Me.rbtLineas.Size = New System.Drawing.Size(68, 20)
        Me.rbtLineas.TabIndex = 0
        Me.rbtLineas.TabStop = True
        Me.rbtLineas.Text = "Líneas"
        Me.rbtLineas.UseVisualStyleBackColor = True
        '
        'frmSalir
        '
        Me.frmSalir.BackColor = System.Drawing.Color.White
        Me.frmSalir.BackgroundImage = CType(resources.GetObject("frmSalir.BackgroundImage"), System.Drawing.Image)
        Me.frmSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.frmSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmSalir.Location = New System.Drawing.Point(1179, 45)
        Me.frmSalir.Name = "frmSalir"
        Me.frmSalir.Size = New System.Drawing.Size(65, 74)
        Me.frmSalir.TabIndex = 85
        Me.frmSalir.UseVisualStyleBackColor = False
        '
        'grp3
        '
        Me.grp3.BackColor = System.Drawing.Color.White
        Me.grp3.Controls.Add(Me.rbtCosto)
        Me.grp3.Controls.Add(Me.rbtOEE)
        Me.grp3.Controls.Add(Me.rbtSeg)
        Me.grp3.Controls.Add(Me.rbt5s)
        Me.grp3.Controls.Add(Me.rbtNRFTi)
        Me.grp3.Controls.Add(Me.rbtGente)
        Me.grp3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp3.Location = New System.Drawing.Point(719, 66)
        Me.grp3.Name = "grp3"
        Me.grp3.Size = New System.Drawing.Size(170, 180)
        Me.grp3.TabIndex = 90
        Me.grp3.TabStop = False
        Me.grp3.Text = "Concepto"
        '
        'rbtCosto
        '
        Me.rbtCosto.AutoSize = True
        Me.rbtCosto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCosto.Location = New System.Drawing.Point(37, 75)
        Me.rbtCosto.Name = "rbtCosto"
        Me.rbtCosto.Size = New System.Drawing.Size(67, 20)
        Me.rbtCosto.TabIndex = 30
        Me.rbtCosto.TabStop = True
        Me.rbtCosto.Text = "Costo"
        Me.rbtCosto.UseVisualStyleBackColor = True
        '
        'rbtOEE
        '
        Me.rbtOEE.AutoSize = True
        Me.rbtOEE.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtOEE.Location = New System.Drawing.Point(37, 25)
        Me.rbtOEE.Name = "rbtOEE"
        Me.rbtOEE.Size = New System.Drawing.Size(55, 20)
        Me.rbtOEE.TabIndex = 25
        Me.rbtOEE.TabStop = True
        Me.rbtOEE.Text = "OEE"
        Me.rbtOEE.UseVisualStyleBackColor = True
        '
        'rbtSeg
        '
        Me.rbtSeg.AutoSize = True
        Me.rbtSeg.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSeg.Location = New System.Drawing.Point(37, 99)
        Me.rbtSeg.Name = "rbtSeg"
        Me.rbtSeg.Size = New System.Drawing.Size(98, 20)
        Me.rbtSeg.TabIndex = 26
        Me.rbtSeg.TabStop = True
        Me.rbtSeg.Text = "Seguridad"
        Me.rbtSeg.UseVisualStyleBackColor = True
        '
        'rbt5s
        '
        Me.rbt5s.AutoSize = True
        Me.rbt5s.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt5s.Location = New System.Drawing.Point(37, 147)
        Me.rbt5s.Name = "rbt5s"
        Me.rbt5s.Size = New System.Drawing.Size(45, 20)
        Me.rbt5s.TabIndex = 29
        Me.rbt5s.TabStop = True
        Me.rbt5s.Text = "5's"
        Me.rbt5s.UseVisualStyleBackColor = True
        '
        'rbtNRFTi
        '
        Me.rbtNRFTi.AutoSize = True
        Me.rbtNRFTi.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNRFTi.Location = New System.Drawing.Point(37, 51)
        Me.rbtNRFTi.Name = "rbtNRFTi"
        Me.rbtNRFTi.Size = New System.Drawing.Size(67, 20)
        Me.rbtNRFTi.TabIndex = 27
        Me.rbtNRFTi.TabStop = True
        Me.rbtNRFTi.Text = "NRFTi"
        Me.rbtNRFTi.UseVisualStyleBackColor = True
        '
        'rbtGente
        '
        Me.rbtGente.AutoSize = True
        Me.rbtGente.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtGente.Location = New System.Drawing.Point(37, 123)
        Me.rbtGente.Name = "rbtGente"
        Me.rbtGente.Size = New System.Drawing.Size(69, 20)
        Me.rbtGente.TabIndex = 28
        Me.rbtGente.TabStop = True
        Me.rbtGente.Text = "Gente"
        Me.rbtGente.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.BackColor = System.Drawing.Color.White
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(1035, 127)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(130, 98)
        Me.cmdImprimir.TabIndex = 84
        Me.cmdImprimir.UseVisualStyleBackColor = False
        '
        'cmdGraficar
        '
        Me.cmdGraficar.BackColor = System.Drawing.Color.White
        Me.cmdGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraficar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGraficar.Image = CType(resources.GetObject("cmdGraficar.Image"), System.Drawing.Image)
        Me.cmdGraficar.Location = New System.Drawing.Point(895, 127)
        Me.cmdGraficar.Name = "cmdGraficar"
        Me.cmdGraficar.Size = New System.Drawing.Size(130, 97)
        Me.cmdGraficar.TabIndex = 83
        Me.cmdGraficar.UseVisualStyleBackColor = False
        '
        'grp2
        '
        Me.grp2.BackColor = System.Drawing.Color.White
        Me.grp2.Controls.Add(Me.rbtAnos)
        Me.grp2.Controls.Add(Me.rbtDia)
        Me.grp2.Controls.Add(Me.rbtMeses)
        Me.grp2.Controls.Add(Me.dtpDesde)
        Me.grp2.Controls.Add(Me.lblAviso)
        Me.grp2.Controls.Add(Me.lblDesde)
        Me.grp2.Controls.Add(Me.lblHasta)
        Me.grp2.Controls.Add(Me.dtpHasta)
        Me.grp2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp2.Location = New System.Drawing.Point(346, 76)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(367, 161)
        Me.grp2.TabIndex = 86
        Me.grp2.TabStop = False
        Me.grp2.Text = "Selección de fechas"
        '
        'rbtAnos
        '
        Me.rbtAnos.AutoSize = True
        Me.rbtAnos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnos.Location = New System.Drawing.Point(15, 98)
        Me.rbtAnos.Name = "rbtAnos"
        Me.rbtAnos.Size = New System.Drawing.Size(82, 20)
        Me.rbtAnos.TabIndex = 31
        Me.rbtAnos.TabStop = True
        Me.rbtAnos.Text = "Por años"
        Me.rbtAnos.UseVisualStyleBackColor = True
        '
        'rbtDia
        '
        Me.rbtDia.AutoSize = True
        Me.rbtDia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDia.Location = New System.Drawing.Point(15, 31)
        Me.rbtDia.Name = "rbtDia"
        Me.rbtDia.Size = New System.Drawing.Size(78, 20)
        Me.rbtDia.TabIndex = 4
        Me.rbtDia.TabStop = True
        Me.rbtDia.Text = "Por días"
        Me.rbtDia.UseVisualStyleBackColor = True
        '
        'rbtMeses
        '
        Me.rbtMeses.AutoSize = True
        Me.rbtMeses.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMeses.Location = New System.Drawing.Point(15, 64)
        Me.rbtMeses.Name = "rbtMeses"
        Me.rbtMeses.Size = New System.Drawing.Size(92, 20)
        Me.rbtMeses.TabIndex = 5
        Me.rbtMeses.TabStop = True
        Me.rbtMeses.Text = "Por meses"
        Me.rbtMeses.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpDesde.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDesde.Location = New System.Drawing.Point(174, 27)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(155, 22)
        Me.dtpDesde.TabIndex = 7
        Me.dtpDesde.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'lblAviso
        '
        Me.lblAviso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.Color.Red
        Me.lblAviso.Location = New System.Drawing.Point(57, 127)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(276, 20)
        Me.lblAviso.TabIndex = 26
        Me.lblAviso.Text = "La primera fecha debe ser inferior a la segunda"
        Me.lblAviso.Visible = False
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(119, 32)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(51, 16)
        Me.lblDesde.TabIndex = 17
        Me.lblDesde.Text = "Desde:"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(122, 91)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(47, 16)
        Me.lblHasta.TabIndex = 18
        Me.lblHasta.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpHasta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(178, 86)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(155, 22)
        Me.dtpHasta.TabIndex = 19
        Me.dtpHasta.Value = New Date(2013, 3, 31, 0, 0, 0, 0)
        '
        'grp1
        '
        Me.grp1.BackColor = System.Drawing.Color.White
        Me.grp1.Controls.Add(Me.cbxTodasLineas)
        Me.grp1.Controls.Add(Me.Label5)
        Me.grp1.Controls.Add(Me.Label4)
        Me.grp1.Controls.Add(Me.Label3)
        Me.grp1.Controls.Add(Me.Label2)
        Me.grp1.Controls.Add(Me.cbxLinea)
        Me.grp1.Controls.Add(Me.cbxEquipo)
        Me.grp1.Controls.Add(Me.cbxUN)
        Me.grp1.Controls.Add(Me.cbxArea)
        Me.grp1.Controls.Add(Me.lblInstrucciones1)
        Me.grp1.Controls.Add(Me.lblInstrucciones2)
        Me.grp1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.Location = New System.Drawing.Point(12, 75)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(326, 162)
        Me.grp1.TabIndex = 87
        Me.grp1.TabStop = False
        Me.grp1.Text = "Selección de equipo(s)"
        '
        'cbxLinea
        '
        Me.cbxLinea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLinea.FormattingEnabled = True
        Me.cbxLinea.Location = New System.Drawing.Point(72, 97)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(146, 24)
        Me.cbxLinea.TabIndex = 75
        Me.cbxLinea.Text = "Línea"
        '
        'cbxEquipo
        '
        Me.cbxEquipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEquipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxEquipo.FormattingEnabled = True
        Me.cbxEquipo.Location = New System.Drawing.Point(72, 123)
        Me.cbxEquipo.Name = "cbxEquipo"
        Me.cbxEquipo.Size = New System.Drawing.Size(243, 24)
        Me.cbxEquipo.TabIndex = 1
        Me.cbxEquipo.Text = "Equipo"
        '
        'cbxUN
        '
        Me.cbxUN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUN.FormattingEnabled = True
        Me.cbxUN.Location = New System.Drawing.Point(72, 45)
        Me.cbxUN.Name = "cbxUN"
        Me.cbxUN.Size = New System.Drawing.Size(243, 24)
        Me.cbxUN.TabIndex = 2
        Me.cbxUN.Text = "Cadena de valor"
        '
        'cbxArea
        '
        Me.cbxArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(72, 71)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(243, 24)
        Me.cbxArea.TabIndex = 3
        Me.cbxArea.Text = "Área"
        '
        'lblInstrucciones1
        '
        Me.lblInstrucciones1.AutoSize = True
        Me.lblInstrucciones1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones1.ForeColor = System.Drawing.Color.Navy
        Me.lblInstrucciones1.Location = New System.Drawing.Point(5, 23)
        Me.lblInstrucciones1.Name = "lblInstrucciones1"
        Me.lblInstrucciones1.Size = New System.Drawing.Size(133, 15)
        Me.lblInstrucciones1.TabIndex = 21
        Me.lblInstrucciones1.Text = "Selecciona Cadena de"
        '
        'lblInstrucciones2
        '
        Me.lblInstrucciones2.AutoSize = True
        Me.lblInstrucciones2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones2.ForeColor = System.Drawing.Color.Navy
        Me.lblInstrucciones2.Location = New System.Drawing.Point(135, 23)
        Me.lblInstrucciones2.Name = "lblInstrucciones2"
        Me.lblInstrucciones2.Size = New System.Drawing.Size(154, 15)
        Me.lblInstrucciones2.TabIndex = 22
        Me.lblInstrucciones2.Text = "valor, Área, Línea y Equipo"
        '
        'ofdBuscar
        '
        Me.ofdBuscar.FileName = "OpenFileDialog1"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-2, -1)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(1262, 44)
        Me.banner_formulario.TabIndex = 105
        Me.banner_formulario.TabStop = False
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(40, 25)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(307, 32)
        Me.titulo_banner_formulario.TabIndex = 106
        Me.titulo_banner_formulario.Text = "Gráficos de Resultados."
        '
        'swfGrafica
        '
        Me.swfGrafica.Enabled = True
        Me.swfGrafica.Location = New System.Drawing.Point(16, 276)
        Me.swfGrafica.Name = "swfGrafica"
        Me.swfGrafica.OcxState = CType(resources.GetObject("swfGrafica.OcxState"), System.Windows.Forms.AxHost.State)
        Me.swfGrafica.Size = New System.Drawing.Size(1226, 415)
        Me.swfGrafica.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "CAD VALOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "ÁREA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "LÍNEA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 14)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "EQUIPO"
        '
        'cbxTodasLineas
        '
        Me.cbxTodasLineas.AutoSize = True
        Me.cbxTodasLineas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTodasLineas.Location = New System.Drawing.Point(243, 101)
        Me.cbxTodasLineas.Name = "cbxTodasLineas"
        Me.cbxTodasLineas.Size = New System.Drawing.Size(72, 20)
        Me.cbxTodasLineas.TabIndex = 80
        Me.cbxTodasLineas.Text = "TODAS"
        Me.cbxTodasLineas.UseVisualStyleBackColor = True
        '
        'frmGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1254, 722)
        Me.Controls.Add(Me.swfGrafica)
        Me.Controls.Add(Me.titulo_banner_formulario)
        Me.Controls.Add(Me.banner_formulario)
        Me.Controls.Add(Me.Exportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.groupTipo)
        Me.Controls.Add(Me.frmSalir)
        Me.Controls.Add(Me.grp3)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdGraficar)
        Me.Controls.Add(Me.grp2)
        Me.Controls.Add(Me.grp1)
        Me.Name = "frmGraficas"
        Me.Text = "Graficas"
        Me.groupTipo.ResumeLayout(False)
        Me.groupTipo.PerformLayout()
        Me.grp3.ResumeLayout(False)
        Me.grp3.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.swfGrafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Exportar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents groupTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbtStock As System.Windows.Forms.RadioButton
    Friend WithEvents rbtBarras As System.Windows.Forms.RadioButton
    Friend WithEvents rbtLineas As System.Windows.Forms.RadioButton
    Friend WithEvents frmSalir As System.Windows.Forms.Button
    Friend WithEvents grp3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCosto As System.Windows.Forms.RadioButton
    Friend WithEvents rbt5s As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNRFTi As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSeg As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOEE As System.Windows.Forms.RadioButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmdGraficar As System.Windows.Forms.Button
    Friend WithEvents grp2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtAnos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDia As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMeses As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAviso As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxUN As System.Windows.Forms.ComboBox
    Friend WithEvents cbxArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstrucciones1 As System.Windows.Forms.Label
    Friend WithEvents lblInstrucciones2 As System.Windows.Forms.Label
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents swfGrafica As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxTodasLineas As System.Windows.Forms.CheckBox
End Class
