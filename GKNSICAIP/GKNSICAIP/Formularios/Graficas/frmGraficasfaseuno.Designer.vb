<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGraficasfaseuno
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rdbtnGente = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnCincoS = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnSeguridad = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnCosto = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnNrfti = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnOee = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cbxLinea = New System.Windows.Forms.ComboBox()
        Me.cbxEquipo = New System.Windows.Forms.ComboBox()
        Me.cbxComponente = New System.Windows.Forms.ComboBox()
        Me.cbxCadenaValor = New System.Windows.Forms.ComboBox()
        Me.chkTodasLineas = New Telerik.WinControls.UI.RadCheckBox()
        Me.rdbtnLinea = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnComponente = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnEquipo = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnCadenaValor = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnPlanta = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dtpFechaFinal = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.dtpFechaInicial = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.rdbtnMeses = New Telerik.WinControls.UI.RadRadioButton()
        Me.rdbtnDias = New Telerik.WinControls.UI.RadRadioButton()
        Me.radChartView1 = New Telerik.WinControls.UI.RadChartView()
        Me.btnGraficar = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rdbtnGente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnCincoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnNrfti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnOee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.chkTodasLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnComponente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnCadenaValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnPlanta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdbtnDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGraficar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.rdbtnGente)
        Me.RadGroupBox1.Controls.Add(Me.rdbtnCincoS)
        Me.RadGroupBox1.Controls.Add(Me.rdbtnSeguridad)
        Me.RadGroupBox1.Controls.Add(Me.rdbtnCosto)
        Me.RadGroupBox1.Controls.Add(Me.rdbtnNrfti)
        Me.RadGroupBox1.Controls.Add(Me.rdbtnOee)
        Me.RadGroupBox1.HeaderText = "Indicador:"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        '
        '
        '
        Me.RadGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox1.Size = New System.Drawing.Size(99, 178)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "Indicador:"
        Me.RadGroupBox1.ThemeName = "RadThemeManager"
        '
        'rdbtnGente
        '
        Me.rdbtnGente.Location = New System.Drawing.Point(5, 141)
        Me.rdbtnGente.Name = "rdbtnGente"
        Me.rdbtnGente.Size = New System.Drawing.Size(50, 18)
        Me.rdbtnGente.TabIndex = 3
        Me.rdbtnGente.Text = "Gente"
        '
        'rdbtnCincoS
        '
        Me.rdbtnCincoS.Location = New System.Drawing.Point(5, 117)
        Me.rdbtnCincoS.Name = "rdbtnCincoS"
        Me.rdbtnCincoS.Size = New System.Drawing.Size(34, 18)
        Me.rdbtnCincoS.TabIndex = 3
        Me.rdbtnCincoS.Text = "5's"
        '
        'rdbtnSeguridad
        '
        Me.rdbtnSeguridad.Location = New System.Drawing.Point(5, 93)
        Me.rdbtnSeguridad.Name = "rdbtnSeguridad"
        Me.rdbtnSeguridad.Size = New System.Drawing.Size(71, 18)
        Me.rdbtnSeguridad.TabIndex = 2
        Me.rdbtnSeguridad.Text = "Seguridad"
        '
        'rdbtnCosto
        '
        Me.rdbtnCosto.Location = New System.Drawing.Point(5, 69)
        Me.rdbtnCosto.Name = "rdbtnCosto"
        Me.rdbtnCosto.Size = New System.Drawing.Size(49, 18)
        Me.rdbtnCosto.TabIndex = 2
        Me.rdbtnCosto.Text = "Costo"
        '
        'rdbtnNrfti
        '
        Me.rdbtnNrfti.Location = New System.Drawing.Point(5, 45)
        Me.rdbtnNrfti.Name = "rdbtnNrfti"
        Me.rdbtnNrfti.Size = New System.Drawing.Size(50, 18)
        Me.rdbtnNrfti.TabIndex = 2
        Me.rdbtnNrfti.Text = "NRFTi"
        '
        'rdbtnOee
        '
        Me.rdbtnOee.Location = New System.Drawing.Point(5, 21)
        Me.rdbtnOee.Name = "rdbtnOee"
        Me.rdbtnOee.Size = New System.Drawing.Size(40, 18)
        Me.rdbtnOee.TabIndex = 1
        Me.rdbtnOee.Text = "OEE"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.cbxLinea)
        Me.RadGroupBox2.Controls.Add(Me.cbxEquipo)
        Me.RadGroupBox2.Controls.Add(Me.cbxComponente)
        Me.RadGroupBox2.Controls.Add(Me.cbxCadenaValor)
        Me.RadGroupBox2.Controls.Add(Me.chkTodasLineas)
        Me.RadGroupBox2.Controls.Add(Me.rdbtnLinea)
        Me.RadGroupBox2.Controls.Add(Me.rdbtnComponente)
        Me.RadGroupBox2.Controls.Add(Me.rdbtnEquipo)
        Me.RadGroupBox2.Controls.Add(Me.rdbtnCadenaValor)
        Me.RadGroupBox2.Controls.Add(Me.rdbtnPlanta)
        Me.RadGroupBox2.HeaderText = "Selecciona:"
        Me.RadGroupBox2.Location = New System.Drawing.Point(117, 12)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        '
        '
        '
        Me.RadGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox2.Size = New System.Drawing.Size(424, 178)
        Me.RadGroupBox2.TabIndex = 4
        Me.RadGroupBox2.Text = "Selecciona:"
        Me.RadGroupBox2.ThemeName = "RadThemeManager"
        '
        'cbxLinea
        '
        Me.cbxLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinea.Enabled = False
        Me.cbxLinea.FormattingEnabled = True
        Me.cbxLinea.Location = New System.Drawing.Point(112, 130)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(241, 21)
        Me.cbxLinea.TabIndex = 13
        '
        'cbxEquipo
        '
        Me.cbxEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEquipo.Enabled = False
        Me.cbxEquipo.FormattingEnabled = True
        Me.cbxEquipo.Location = New System.Drawing.Point(112, 106)
        Me.cbxEquipo.Name = "cbxEquipo"
        Me.cbxEquipo.Size = New System.Drawing.Size(241, 21)
        Me.cbxEquipo.TabIndex = 12
        '
        'cbxComponente
        '
        Me.cbxComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxComponente.Enabled = False
        Me.cbxComponente.FormattingEnabled = True
        Me.cbxComponente.Location = New System.Drawing.Point(112, 82)
        Me.cbxComponente.Name = "cbxComponente"
        Me.cbxComponente.Size = New System.Drawing.Size(241, 21)
        Me.cbxComponente.TabIndex = 11
        '
        'cbxCadenaValor
        '
        Me.cbxCadenaValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCadenaValor.Enabled = False
        Me.cbxCadenaValor.FormattingEnabled = True
        Me.cbxCadenaValor.Location = New System.Drawing.Point(112, 58)
        Me.cbxCadenaValor.Name = "cbxCadenaValor"
        Me.cbxCadenaValor.Size = New System.Drawing.Size(241, 21)
        Me.cbxCadenaValor.TabIndex = 10
        '
        'chkTodasLineas
        '
        Me.chkTodasLineas.Location = New System.Drawing.Point(359, 133)
        Me.chkTodasLineas.Name = "chkTodasLineas"
        Me.chkTodasLineas.Size = New System.Drawing.Size(50, 18)
        Me.chkTodasLineas.TabIndex = 7
        Me.chkTodasLineas.Text = "Todas"
        Me.chkTodasLineas.Visible = False
        '
        'rdbtnLinea
        '
        Me.rdbtnLinea.Location = New System.Drawing.Point(5, 133)
        Me.rdbtnLinea.Name = "rdbtnLinea"
        Me.rdbtnLinea.Size = New System.Drawing.Size(49, 18)
        Me.rdbtnLinea.TabIndex = 3
        Me.rdbtnLinea.Text = "Linea:"
        '
        'rdbtnComponente
        '
        Me.rdbtnComponente.Location = New System.Drawing.Point(5, 85)
        Me.rdbtnComponente.Name = "rdbtnComponente"
        Me.rdbtnComponente.Size = New System.Drawing.Size(88, 18)
        Me.rdbtnComponente.TabIndex = 2
        Me.rdbtnComponente.Text = "Componente:"
        '
        'rdbtnEquipo
        '
        Me.rdbtnEquipo.Location = New System.Drawing.Point(5, 109)
        Me.rdbtnEquipo.Name = "rdbtnEquipo"
        Me.rdbtnEquipo.Size = New System.Drawing.Size(57, 18)
        Me.rdbtnEquipo.TabIndex = 2
        Me.rdbtnEquipo.Text = "Equipo:"
        '
        'rdbtnCadenaValor
        '
        Me.rdbtnCadenaValor.Location = New System.Drawing.Point(5, 61)
        Me.rdbtnCadenaValor.Name = "rdbtnCadenaValor"
        Me.rdbtnCadenaValor.Size = New System.Drawing.Size(89, 18)
        Me.rdbtnCadenaValor.TabIndex = 2
        Me.rdbtnCadenaValor.Text = "Cadena Valor:"
        '
        'rdbtnPlanta
        '
        Me.rdbtnPlanta.Location = New System.Drawing.Point(5, 37)
        Me.rdbtnPlanta.Name = "rdbtnPlanta"
        Me.rdbtnPlanta.Size = New System.Drawing.Size(51, 18)
        Me.rdbtnPlanta.TabIndex = 1
        Me.rdbtnPlanta.Text = "Planta"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.dtpFechaFinal)
        Me.RadGroupBox3.Controls.Add(Me.dtpFechaInicial)
        Me.RadGroupBox3.Controls.Add(Me.rdbtnMeses)
        Me.RadGroupBox3.Controls.Add(Me.rdbtnDias)
        Me.RadGroupBox3.HeaderText = "Seleccion Fecha:"
        Me.RadGroupBox3.Location = New System.Drawing.Point(547, 12)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        '
        '
        '
        Me.RadGroupBox3.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.RadGroupBox3.Size = New System.Drawing.Size(306, 178)
        Me.RadGroupBox3.TabIndex = 7
        Me.RadGroupBox3.Text = "Seleccion Fecha:"
        Me.RadGroupBox3.ThemeName = "RadThemeManager"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(22, 103)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel2.TabIndex = 11
        Me.RadLabel2.Text = "Fecha Final:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(17, 69)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(69, 18)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Fecha Inicial:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(118, 101)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(164, 20)
        Me.dtpFechaFinal.TabIndex = 9
        Me.dtpFechaFinal.TabStop = False
        Me.dtpFechaFinal.Text = "miércoles, 28 de agosto de 2013"
        Me.dtpFechaFinal.Value = New Date(2013, 8, 28, 13, 5, 45, 983)
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(118, 67)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(164, 20)
        Me.dtpFechaInicial.TabIndex = 8
        Me.dtpFechaInicial.TabStop = False
        Me.dtpFechaInicial.Text = "miércoles, 28 de agosto de 2013"
        Me.dtpFechaInicial.Value = New Date(2013, 8, 28, 13, 5, 45, 983)
        '
        'rdbtnMeses
        '
        Me.rdbtnMeses.Location = New System.Drawing.Point(182, 33)
        Me.rdbtnMeses.Name = "rdbtnMeses"
        Me.rdbtnMeses.Size = New System.Drawing.Size(72, 18)
        Me.rdbtnMeses.TabIndex = 2
        Me.rdbtnMeses.Text = "Por Meses"
        '
        'rdbtnDias
        '
        Me.rdbtnDias.Location = New System.Drawing.Point(43, 33)
        Me.rdbtnDias.Name = "rdbtnDias"
        Me.rdbtnDias.Size = New System.Drawing.Size(61, 18)
        Me.rdbtnDias.TabIndex = 1
        Me.rdbtnDias.TabStop = True
        Me.rdbtnDias.Text = "Por Días"
        Me.rdbtnDias.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'radChartView1
        '
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.GridDesign.DrawVerticalFills = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        Me.radChartView1.Location = New System.Drawing.Point(3, 213)
        Me.radChartView1.Name = "radChartView1"
        Me.radChartView1.Size = New System.Drawing.Size(1257, 481)
        Me.radChartView1.TabIndex = 9
        CType(Me.radChartView1.GetChildAt(0), Telerik.WinControls.UI.RadChartElement).DrawText = False
        CType(Me.radChartView1.GetChildAt(0), Telerik.WinControls.UI.RadChartElement).DrawFill = True
        '
        'btnGraficar
        '
        Me.btnGraficar.Enabled = False
        Me.btnGraficar.Image = Global.GKNSICAIP.My.Resources.Resources.frmGraficas_graficar1
        Me.btnGraficar.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.btnGraficar.Location = New System.Drawing.Point(873, 124)
        Me.btnGraficar.Name = "btnGraficar"
        Me.btnGraficar.Size = New System.Drawing.Size(99, 66)
        Me.btnGraficar.TabIndex = 8
        Me.btnGraficar.Text = "Graficar"
        Me.btnGraficar.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGraficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmGraficasfaseuno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1272, 706)
        Me.Controls.Add(Me.radChartView1)
        Me.Controls.Add(Me.btnGraficar)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MaximumSize = New System.Drawing.Size(1280, 768)
        Me.MinimumSize = New System.Drawing.Size(1280, 736)
        Me.Name = "FrmGraficasfaseuno"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(1280, 768)
        Me.Text = "RadThemeManager"
        Me.ThemeName = "RadThemeManager"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rdbtnGente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnCincoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnNrfti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnOee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.chkTodasLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnComponente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnCadenaValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnPlanta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnMeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdbtnDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radChartView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGraficar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rdbtnSeguridad As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnCosto As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnNrfti As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnOee As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnGente As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnCincoS As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rdbtnLinea As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnEquipo As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnComponente As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnCadenaValor As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnPlanta As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents dtpFechaInicial As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents rdbtnMeses As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rdbtnDias As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dtpFechaFinal As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents btnGraficar As Telerik.WinControls.UI.RadButton
    Friend WithEvents chkTodasLineas As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents radChartView1 As Telerik.WinControls.UI.RadChartView
    Friend WithEvents cbxCadenaValor As System.Windows.Forms.ComboBox
    Friend WithEvents cbxLinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxComponente As System.Windows.Forms.ComboBox
End Class

