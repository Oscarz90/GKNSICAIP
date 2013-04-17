<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduccion))
        Me.TabContenido = New System.Windows.Forms.TabControl()
        Me.tabPageProductividad = New System.Windows.Forms.TabPage()
        Me.grpDesechos = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesechos = New System.Windows.Forms.TextBox()
        Me.grpProductividad = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtPzasPorHora = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtModeloDescripcion = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblParosComedor = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblTiempoOperacion = New System.Windows.Forms.Label()
        Me.lblParosNoPlaneados = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lblTiempoTurno = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblTiempoCarga = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblParosPlaneados = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lstModelos = New System.Windows.Forms.ListView()
        Me.colModelo_Productividad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPzasProducidas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDesechos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTiempoOperacio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCapacidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdeudo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdLinea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdIndicador1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cbxModeloProductividad = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblOEE = New System.Windows.Forms.Label()
        Me.lblCalidad = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDesempeno = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblDisponibilidad = New System.Windows.Forms.Label()
        Me.txtPiezasProducidas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdAgregarModelo = New System.Windows.Forms.Button()
        Me.cmdQuitarModelo = New System.Windows.Forms.Button()
        Me.tabPageParos = New System.Windows.Forms.TabPage()
        Me.grpCosto = New System.Windows.Forms.GroupBox()
        Me.lblMinReal = New System.Windows.Forms.Label()
        Me.lblMinProgramados = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.grpParos = New System.Windows.Forms.GroupBox()
        Me.txtParosDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMaquinaDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMinutosParo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lstParos = New System.Windows.Forms.ListView()
        Me.colTipo_Paros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMinutos_Paro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCveMaquina = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMaquina = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetalles = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIdTipo_Paros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIdLinea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIdMaquina = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCodRegParo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdQuitarParo = New System.Windows.Forms.Button()
        Me.cmdAgregarParo = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDetallesParo = New System.Windows.Forms.TextBox()
        Me.cbxTipoParo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbxMaquina = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tabPageRechazos = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescripcionModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTipoRechazo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMotivo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colIdRechazo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.grpSeguridad = New System.Windows.Forms.GroupBox()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEquipo = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cbxLinea = New System.Windows.Forms.ComboBox()
        Me.TabContenido.SuspendLayout()
        Me.tabPageProductividad.SuspendLayout()
        Me.grpDesechos.SuspendLayout()
        Me.grpProductividad.SuspendLayout()
        Me.tabPageParos.SuspendLayout()
        Me.grpCosto.SuspendLayout()
        Me.grpParos.SuspendLayout()
        Me.tabPageRechazos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpSeguridad.SuspendLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabContenido
        '
        Me.TabContenido.Controls.Add(Me.tabPageProductividad)
        Me.TabContenido.Controls.Add(Me.tabPageParos)
        Me.TabContenido.Controls.Add(Me.tabPageRechazos)
        Me.TabContenido.Controls.Add(Me.TabPage1)
        Me.TabContenido.Controls.Add(Me.TabPage2)
        Me.TabContenido.Location = New System.Drawing.Point(12, 264)
        Me.TabContenido.Name = "TabContenido"
        Me.TabContenido.SelectedIndex = 0
        Me.TabContenido.Size = New System.Drawing.Size(1230, 446)
        Me.TabContenido.TabIndex = 1
        '
        'tabPageProductividad
        '
        Me.tabPageProductividad.Controls.Add(Me.grpDesechos)
        Me.tabPageProductividad.Controls.Add(Me.grpProductividad)
        Me.tabPageProductividad.Location = New System.Drawing.Point(4, 22)
        Me.tabPageProductividad.Name = "tabPageProductividad"
        Me.tabPageProductividad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageProductividad.Size = New System.Drawing.Size(1222, 420)
        Me.tabPageProductividad.TabIndex = 0
        Me.tabPageProductividad.Text = "Productividad"
        Me.tabPageProductividad.UseVisualStyleBackColor = True
        '
        'grpDesechos
        '
        Me.grpDesechos.Controls.Add(Me.ListView2)
        Me.grpDesechos.Controls.Add(Me.ComboBox2)
        Me.grpDesechos.Controls.Add(Me.Label17)
        Me.grpDesechos.Controls.Add(Me.Label19)
        Me.grpDesechos.Controls.Add(Me.TextBox2)
        Me.grpDesechos.Controls.Add(Me.Label46)
        Me.grpDesechos.Controls.Add(Me.Label6)
        Me.grpDesechos.Controls.Add(Me.txtDesechos)
        Me.grpDesechos.Location = New System.Drawing.Point(759, 6)
        Me.grpDesechos.Name = "grpDesechos"
        Me.grpDesechos.Size = New System.Drawing.Size(467, 408)
        Me.grpDesechos.TabIndex = 326
        Me.grpDesechos.TabStop = False
        Me.grpDesechos.Text = "GroupBox2"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(7, 282)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(453, 119)
        Me.ListView2.TabIndex = 322
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Modelo"
        Me.ColumnHeader1.Width = 170
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Piezas OK"
        Me.ColumnHeader2.Width = 96
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Desechos"
        Me.ColumnHeader3.Width = 96
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tiempo Operación"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Capacidad"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Adeudo"
        Me.ColumnHeader6.Width = 82
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Id_modelo"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "colIdLinea"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "colIdIndicador1"
        Me.ColumnHeader9.Width = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(124, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(217, 26)
        Me.ComboBox2.TabIndex = 323
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 18)
        Me.Label17.TabIndex = 325
        Me.Label17.Text = "Descripcion:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(54, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 18)
        Me.Label19.TabIndex = 322
        Me.Label19.Text = "Modelo:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(217, 20)
        Me.TextBox2.TabIndex = 324
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label46.Location = New System.Drawing.Point(185, 125)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(63, 17)
        Me.Label46.TabIndex = 309
        Me.Label46.Text = "cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(33, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Desechos:"
        '
        'txtDesechos
        '
        Me.txtDesechos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDesechos.Location = New System.Drawing.Point(123, 121)
        Me.txtDesechos.Name = "txtDesechos"
        Me.txtDesechos.Size = New System.Drawing.Size(61, 20)
        Me.txtDesechos.TabIndex = 9
        Me.txtDesechos.Text = "0"
        Me.txtDesechos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpProductividad
        '
        Me.grpProductividad.Controls.Add(Me.Label54)
        Me.grpProductividad.Controls.Add(Me.txtPzasPorHora)
        Me.grpProductividad.Controls.Add(Me.Label53)
        Me.grpProductividad.Controls.Add(Me.txtModeloDescripcion)
        Me.grpProductividad.Controls.Add(Me.Label52)
        Me.grpProductividad.Controls.Add(Me.Label51)
        Me.grpProductividad.Controls.Add(Me.Label49)
        Me.grpProductividad.Controls.Add(Me.Label48)
        Me.grpProductividad.Controls.Add(Me.Label47)
        Me.grpProductividad.Controls.Add(Me.Label44)
        Me.grpProductividad.Controls.Add(Me.Label42)
        Me.grpProductividad.Controls.Add(Me.Label1)
        Me.grpProductividad.Controls.Add(Me.lblParosComedor)
        Me.grpProductividad.Controls.Add(Me.Label36)
        Me.grpProductividad.Controls.Add(Me.lblTiempoOperacion)
        Me.grpProductividad.Controls.Add(Me.lblParosNoPlaneados)
        Me.grpProductividad.Controls.Add(Me.Label21)
        Me.grpProductividad.Controls.Add(Me.Label43)
        Me.grpProductividad.Controls.Add(Me.lblTiempoTurno)
        Me.grpProductividad.Controls.Add(Me.Label41)
        Me.grpProductividad.Controls.Add(Me.lblTiempoCarga)
        Me.grpProductividad.Controls.Add(Me.Label39)
        Me.grpProductividad.Controls.Add(Me.lblParosPlaneados)
        Me.grpProductividad.Controls.Add(Me.Label35)
        Me.grpProductividad.Controls.Add(Me.Label34)
        Me.grpProductividad.Controls.Add(Me.Label37)
        Me.grpProductividad.Controls.Add(Me.txtMinutos)
        Me.grpProductividad.Controls.Add(Me.Label29)
        Me.grpProductividad.Controls.Add(Me.lstModelos)
        Me.grpProductividad.Controls.Add(Me.cbxModeloProductividad)
        Me.grpProductividad.Controls.Add(Me.Label28)
        Me.grpProductividad.Controls.Add(Me.lblOEE)
        Me.grpProductividad.Controls.Add(Me.lblCalidad)
        Me.grpProductividad.Controls.Add(Me.Label14)
        Me.grpProductividad.Controls.Add(Me.lblDesempeno)
        Me.grpProductividad.Controls.Add(Me.Label8)
        Me.grpProductividad.Controls.Add(Me.Label4)
        Me.grpProductividad.Controls.Add(Me.Label23)
        Me.grpProductividad.Controls.Add(Me.lblDisponibilidad)
        Me.grpProductividad.Controls.Add(Me.txtPiezasProducidas)
        Me.grpProductividad.Controls.Add(Me.Label9)
        Me.grpProductividad.Controls.Add(Me.Label10)
        Me.grpProductividad.Controls.Add(Me.cmdAgregarModelo)
        Me.grpProductividad.Controls.Add(Me.cmdQuitarModelo)
        Me.grpProductividad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProductividad.Location = New System.Drawing.Point(3, 3)
        Me.grpProductividad.Name = "grpProductividad"
        Me.grpProductividad.Size = New System.Drawing.Size(750, 413)
        Me.grpProductividad.TabIndex = 1
        Me.grpProductividad.TabStop = False
        Me.grpProductividad.Text = "1.-PRODUCTIVIDAD"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label54.Location = New System.Drawing.Point(530, 183)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(63, 17)
        Me.Label54.TabIndex = 321
        Me.Label54.Text = "cantidad"
        '
        'txtPzasPorHora
        '
        Me.txtPzasPorHora.BackColor = System.Drawing.SystemColors.Control
        Me.txtPzasPorHora.Location = New System.Drawing.Point(468, 179)
        Me.txtPzasPorHora.Name = "txtPzasPorHora"
        Me.txtPzasPorHora.ReadOnly = True
        Me.txtPzasPorHora.Size = New System.Drawing.Size(61, 26)
        Me.txtPzasPorHora.TabIndex = 320
        Me.txtPzasPorHora.Text = "0"
        Me.txtPzasPorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(3, 213)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 18)
        Me.Label53.TabIndex = 319
        Me.Label53.Text = "Descripcion:"
        '
        'txtModeloDescripcion
        '
        Me.txtModeloDescripcion.Location = New System.Drawing.Point(105, 210)
        Me.txtModeloDescripcion.Name = "txtModeloDescripcion"
        Me.txtModeloDescripcion.ReadOnly = True
        Me.txtModeloDescripcion.Size = New System.Drawing.Size(217, 26)
        Me.txtModeloDescripcion.TabIndex = 318
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(353, 184)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(109, 18)
        Me.Label52.TabIndex = 316
        Me.Label52.Text = "Piezas x Hora:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(641, 128)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(29, 24)
        Me.Label51.TabIndex = 314
        Me.Label51.Text = "%"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(631, 102)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(22, 18)
        Me.Label49.TabIndex = 312
        Me.Label49.Text = "%"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(631, 76)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(22, 18)
        Me.Label48.TabIndex = 311
        Me.Label48.Text = "%"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(631, 51)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(22, 18)
        Me.Label47.TabIndex = 310
        Me.Label47.Text = "%"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label44.Location = New System.Drawing.Point(530, 214)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(63, 17)
        Me.Label44.TabIndex = 308
        Me.Label44.Text = "cantidad"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label42.Location = New System.Drawing.Point(262, 249)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(60, 17)
        Me.Label42.TabIndex = 307
        Me.Label42.Text = "minutos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(680, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Quitar"
        '
        'lblParosComedor
        '
        Me.lblParosComedor.AutoSize = True
        Me.lblParosComedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosComedor.Location = New System.Drawing.Point(395, 77)
        Me.lblParosComedor.Name = "lblParosComedor"
        Me.lblParosComedor.Size = New System.Drawing.Size(17, 18)
        Me.lblParosComedor.TabIndex = 170
        Me.lblParosComedor.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(240, 76)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(146, 18)
        Me.Label36.TabIndex = 169
        Me.Label36.Text = "Paros de Comedor:"
        '
        'lblTiempoOperacion
        '
        Me.lblTiempoOperacion.AutoSize = True
        Me.lblTiempoOperacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoOperacion.Location = New System.Drawing.Point(192, 102)
        Me.lblTiempoOperacion.Name = "lblTiempoOperacion"
        Me.lblTiempoOperacion.Size = New System.Drawing.Size(17, 18)
        Me.lblTiempoOperacion.TabIndex = 168
        Me.lblTiempoOperacion.Text = "0"
        '
        'lblParosNoPlaneados
        '
        Me.lblParosNoPlaneados.AutoSize = True
        Me.lblParosNoPlaneados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosNoPlaneados.Location = New System.Drawing.Point(395, 102)
        Me.lblParosNoPlaneados.Name = "lblParosNoPlaneados"
        Me.lblParosNoPlaneados.Size = New System.Drawing.Size(17, 18)
        Me.lblParosNoPlaneados.TabIndex = 166
        Me.lblParosNoPlaneados.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(23, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 18)
        Me.Label21.TabIndex = 167
        Me.Label21.Text = "Tiempo de operación:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(234, 102)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(152, 18)
        Me.Label43.TabIndex = 165
        Me.Label43.Text = "Paros no planeados:"
        '
        'lblTiempoTurno
        '
        Me.lblTiempoTurno.AutoSize = True
        Me.lblTiempoTurno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoTurno.Location = New System.Drawing.Point(193, 51)
        Me.lblTiempoTurno.Name = "lblTiempoTurno"
        Me.lblTiempoTurno.Size = New System.Drawing.Size(17, 18)
        Me.lblTiempoTurno.TabIndex = 164
        Me.lblTiempoTurno.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(58, 51)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(124, 18)
        Me.Label41.TabIndex = 163
        Me.Label41.Text = "Tiempo de turno:"
        '
        'lblTiempoCarga
        '
        Me.lblTiempoCarga.AutoSize = True
        Me.lblTiempoCarga.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoCarga.Location = New System.Drawing.Point(192, 76)
        Me.lblTiempoCarga.Name = "lblTiempoCarga"
        Me.lblTiempoCarga.Size = New System.Drawing.Size(17, 18)
        Me.lblTiempoCarga.TabIndex = 162
        Me.lblTiempoCarga.Text = "0"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(53, 76)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(130, 18)
        Me.Label39.TabIndex = 161
        Me.Label39.Text = "Tiempo de carga:"
        '
        'lblParosPlaneados
        '
        Me.lblParosPlaneados.AutoSize = True
        Me.lblParosPlaneados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosPlaneados.Location = New System.Drawing.Point(395, 51)
        Me.lblParosPlaneados.Name = "lblParosPlaneados"
        Me.lblParosPlaneados.Size = New System.Drawing.Size(17, 18)
        Me.lblParosPlaneados.TabIndex = 160
        Me.lblParosPlaneados.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(20, 133)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(186, 19)
        Me.Label35.TabIndex = 158
        Me.Label35.Text = "Resultados por Modelo"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(20, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(177, 19)
        Me.Label34.TabIndex = 157
        Me.Label34.Text = "Resultados Generales"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(255, 51)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(131, 18)
        Me.Label37.TabIndex = 159
        Me.Label37.Text = "Paros planeados:"
        '
        'txtMinutos
        '
        Me.txtMinutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMinutos.Location = New System.Drawing.Point(195, 245)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(61, 26)
        Me.txtMinutos.TabIndex = 156
        Me.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(58, 249)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(132, 17)
        Me.Label29.TabIndex = 155
        Me.Label29.Text = "Tiempo Operación:"
        '
        'lstModelos
        '
        Me.lstModelos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colModelo_Productividad, Me.colPzasProducidas, Me.colDesechos, Me.colTiempoOperacio, Me.colCapacidad, Me.colAdeudo, Me.IdModelo, Me.IdLinea, Me.IdIndicador1})
        Me.lstModelos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstModelos.FullRowSelect = True
        Me.lstModelos.GridLines = True
        Me.lstModelos.Location = New System.Drawing.Point(10, 283)
        Me.lstModelos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstModelos.Name = "lstModelos"
        Me.lstModelos.Size = New System.Drawing.Size(729, 119)
        Me.lstModelos.TabIndex = 147
        Me.lstModelos.UseCompatibleStateImageBehavior = False
        Me.lstModelos.View = System.Windows.Forms.View.Details
        '
        'colModelo_Productividad
        '
        Me.colModelo_Productividad.Text = "Modelo"
        Me.colModelo_Productividad.Width = 170
        '
        'colPzasProducidas
        '
        Me.colPzasProducidas.Text = "Piezas OK"
        Me.colPzasProducidas.Width = 96
        '
        'colDesechos
        '
        Me.colDesechos.Text = "Desechos"
        Me.colDesechos.Width = 96
        '
        'colTiempoOperacio
        '
        Me.colTiempoOperacio.Text = "Tiempo Operación"
        Me.colTiempoOperacio.Width = 150
        '
        'colCapacidad
        '
        Me.colCapacidad.Text = "Capacidad"
        Me.colCapacidad.Width = 130
        '
        'colAdeudo
        '
        Me.colAdeudo.Text = "Adeudo"
        Me.colAdeudo.Width = 82
        '
        'IdModelo
        '
        Me.IdModelo.Text = "Id_modelo"
        Me.IdModelo.Width = 0
        '
        'IdLinea
        '
        Me.IdLinea.Text = "colIdLinea"
        Me.IdLinea.Width = 0
        '
        'IdIndicador1
        '
        Me.IdIndicador1.Text = "colIdIndicador1"
        Me.IdIndicador1.Width = 0
        '
        'cbxModeloProductividad
        '
        Me.cbxModeloProductividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxModeloProductividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloProductividad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloProductividad.FormattingEnabled = True
        Me.cbxModeloProductividad.Location = New System.Drawing.Point(105, 179)
        Me.cbxModeloProductividad.Name = "cbxModeloProductividad"
        Me.cbxModeloProductividad.Size = New System.Drawing.Size(217, 26)
        Me.cbxModeloProductividad.TabIndex = 154
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(35, 182)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 18)
        Me.Label28.TabIndex = 153
        Me.Label28.Text = "Modelo:"
        '
        'lblOEE
        '
        Me.lblOEE.AutoSize = True
        Me.lblOEE.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOEE.Location = New System.Drawing.Point(565, 128)
        Me.lblOEE.Name = "lblOEE"
        Me.lblOEE.Size = New System.Drawing.Size(22, 24)
        Me.lblOEE.TabIndex = 13
        Me.lblOEE.Text = "0"
        '
        'lblCalidad
        '
        Me.lblCalidad.AutoSize = True
        Me.lblCalidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidad.Location = New System.Drawing.Point(566, 102)
        Me.lblCalidad.Name = "lblCalidad"
        Me.lblCalidad.Size = New System.Drawing.Size(17, 18)
        Me.lblCalidad.TabIndex = 12
        Me.lblCalidad.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(494, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 24)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "OEE"
        '
        'lblDesempeno
        '
        Me.lblDesempeno.AutoSize = True
        Me.lblDesempeno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesempeno.Location = New System.Drawing.Point(566, 77)
        Me.lblDesempeno.Name = "lblDesempeno"
        Me.lblDesempeno.Size = New System.Drawing.Size(17, 18)
        Me.lblDesempeno.TabIndex = 12
        Me.lblDesempeno.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Calidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(378, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Piezas OK:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(599, 250)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 18)
        Me.Label23.TabIndex = 151
        Me.Label23.Text = "Agregar"
        '
        'lblDisponibilidad
        '
        Me.lblDisponibilidad.AutoSize = True
        Me.lblDisponibilidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponibilidad.Location = New System.Drawing.Point(566, 51)
        Me.lblDisponibilidad.Name = "lblDisponibilidad"
        Me.lblDisponibilidad.Size = New System.Drawing.Size(17, 18)
        Me.lblDisponibilidad.TabIndex = 11
        Me.lblDisponibilidad.Text = "0"
        '
        'txtPiezasProducidas
        '
        Me.txtPiezasProducidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPiezasProducidas.Location = New System.Drawing.Point(468, 210)
        Me.txtPiezasProducidas.Name = "txtPiezasProducidas"
        Me.txtPiezasProducidas.Size = New System.Drawing.Size(61, 26)
        Me.txtPiezasProducidas.TabIndex = 7
        Me.txtPiezasProducidas.Text = "0"
        Me.txtPiezasProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(434, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Disponibilidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Desempeño:"
        '
        'cmdAgregarModelo
        '
        Me.cmdAgregarModelo.BackColor = System.Drawing.Color.White
        Me.cmdAgregarModelo.BackgroundImage = CType(resources.GetObject("cmdAgregarModelo.BackgroundImage"), System.Drawing.Image)
        Me.cmdAgregarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAgregarModelo.Enabled = False
        Me.cmdAgregarModelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarModelo.Location = New System.Drawing.Point(601, 188)
        Me.cmdAgregarModelo.Name = "cmdAgregarModelo"
        Me.cmdAgregarModelo.Size = New System.Drawing.Size(63, 59)
        Me.cmdAgregarModelo.TabIndex = 149
        Me.cmdAgregarModelo.UseVisualStyleBackColor = False
        '
        'cmdQuitarModelo
        '
        Me.cmdQuitarModelo.BackColor = System.Drawing.Color.White
        Me.cmdQuitarModelo.BackgroundImage = CType(resources.GetObject("cmdQuitarModelo.BackgroundImage"), System.Drawing.Image)
        Me.cmdQuitarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdQuitarModelo.Enabled = False
        Me.cmdQuitarModelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitarModelo.Location = New System.Drawing.Point(675, 188)
        Me.cmdQuitarModelo.Name = "cmdQuitarModelo"
        Me.cmdQuitarModelo.Size = New System.Drawing.Size(64, 59)
        Me.cmdQuitarModelo.TabIndex = 150
        Me.cmdQuitarModelo.UseVisualStyleBackColor = False
        '
        'tabPageParos
        '
        Me.tabPageParos.Controls.Add(Me.grpCosto)
        Me.tabPageParos.Controls.Add(Me.grpParos)
        Me.tabPageParos.Location = New System.Drawing.Point(4, 22)
        Me.tabPageParos.Name = "tabPageParos"
        Me.tabPageParos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageParos.Size = New System.Drawing.Size(1232, 420)
        Me.tabPageParos.TabIndex = 1
        Me.tabPageParos.Text = "Paros"
        Me.tabPageParos.UseVisualStyleBackColor = True
        '
        'grpCosto
        '
        Me.grpCosto.Controls.Add(Me.lblMinReal)
        Me.grpCosto.Controls.Add(Me.lblMinProgramados)
        Me.grpCosto.Controls.Add(Me.lblCosto)
        Me.grpCosto.Controls.Add(Me.Label40)
        Me.grpCosto.Controls.Add(Me.lblPrecio)
        Me.grpCosto.Controls.Add(Me.Label38)
        Me.grpCosto.Controls.Add(Me.Label18)
        Me.grpCosto.Controls.Add(Me.Label31)
        Me.grpCosto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCosto.Location = New System.Drawing.Point(892, 6)
        Me.grpCosto.Name = "grpCosto"
        Me.grpCosto.Size = New System.Drawing.Size(334, 158)
        Me.grpCosto.TabIndex = 16
        Me.grpCosto.TabStop = False
        Me.grpCosto.Text = "2.-COSTO"
        '
        'lblMinReal
        '
        Me.lblMinReal.AutoSize = True
        Me.lblMinReal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinReal.Location = New System.Drawing.Point(186, 62)
        Me.lblMinReal.Name = "lblMinReal"
        Me.lblMinReal.Size = New System.Drawing.Size(17, 18)
        Me.lblMinReal.TabIndex = 316
        Me.lblMinReal.Text = "0"
        '
        'lblMinProgramados
        '
        Me.lblMinProgramados.AutoSize = True
        Me.lblMinProgramados.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinProgramados.Location = New System.Drawing.Point(186, 29)
        Me.lblMinProgramados.Name = "lblMinProgramados"
        Me.lblMinProgramados.Size = New System.Drawing.Size(17, 18)
        Me.lblMinProgramados.TabIndex = 315
        Me.lblMinProgramados.Text = "0"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(186, 120)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(17, 18)
        Me.lblCosto.TabIndex = 314
        Me.lblCosto.Text = "0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(19, 29)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(137, 18)
        Me.Label40.TabIndex = 308
        Me.Label40.Text = "Min Programados:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(186, 90)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(17, 18)
        Me.lblPrecio.TabIndex = 312
        Me.lblPrecio.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(19, 62)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(73, 18)
        Me.Label38.TabIndex = 310
        Me.Label38.Text = "Min Real:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 18)
        Me.Label18.TabIndex = 313
        Me.Label18.Text = "Costo:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(19, 90)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(58, 18)
        Me.Label31.TabIndex = 311
        Me.Label31.Text = "Precio:"
        '
        'grpParos
        '
        Me.grpParos.Controls.Add(Me.txtParosDescripcion)
        Me.grpParos.Controls.Add(Me.txtMaquinaDescripcion)
        Me.grpParos.Controls.Add(Me.txtMinutosParo)
        Me.grpParos.Controls.Add(Me.Label25)
        Me.grpParos.Controls.Add(Me.lstParos)
        Me.grpParos.Controls.Add(Me.Label15)
        Me.grpParos.Controls.Add(Me.Label13)
        Me.grpParos.Controls.Add(Me.cmdQuitarParo)
        Me.grpParos.Controls.Add(Me.cmdAgregarParo)
        Me.grpParos.Controls.Add(Me.Label32)
        Me.grpParos.Controls.Add(Me.txtDetallesParo)
        Me.grpParos.Controls.Add(Me.cbxTipoParo)
        Me.grpParos.Controls.Add(Me.Label26)
        Me.grpParos.Controls.Add(Me.cbxMaquina)
        Me.grpParos.Controls.Add(Me.Label24)
        Me.grpParos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParos.Location = New System.Drawing.Point(6, 6)
        Me.grpParos.Name = "grpParos"
        Me.grpParos.Size = New System.Drawing.Size(880, 408)
        Me.grpParos.TabIndex = 15
        Me.grpParos.TabStop = False
        Me.grpParos.Text = "PAROS"
        Me.grpParos.Visible = False
        '
        'txtParosDescripcion
        '
        Me.txtParosDescripcion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParosDescripcion.Location = New System.Drawing.Point(6, 128)
        Me.txtParosDescripcion.Name = "txtParosDescripcion"
        Me.txtParosDescripcion.ReadOnly = True
        Me.txtParosDescripcion.Size = New System.Drawing.Size(294, 25)
        Me.txtParosDescripcion.TabIndex = 323
        '
        'txtMaquinaDescripcion
        '
        Me.txtMaquinaDescripcion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaquinaDescripcion.Location = New System.Drawing.Point(6, 56)
        Me.txtMaquinaDescripcion.Name = "txtMaquinaDescripcion"
        Me.txtMaquinaDescripcion.ReadOnly = True
        Me.txtMaquinaDescripcion.Size = New System.Drawing.Size(294, 25)
        Me.txtMaquinaDescripcion.TabIndex = 322
        '
        'txtMinutosParo
        '
        Me.txtMinutosParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMinutosParo.Location = New System.Drawing.Point(410, 26)
        Me.txtMinutosParo.Name = "txtMinutosParo"
        Me.txtMinutosParo.Size = New System.Drawing.Size(161, 26)
        Me.txtMinutosParo.TabIndex = 141
        Me.txtMinutosParo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(340, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 18)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "Minutos:"
        '
        'lstParos
        '
        Me.lstParos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTipo_Paros, Me.colMinutos_Paro, Me.colCveMaquina, Me.colMaquina, Me.colDetalles, Me.colIdTipo_Paros, Me.colIdLinea, Me.colIdMaquina, Me.colCodRegParo})
        Me.lstParos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstParos.FullRowSelect = True
        Me.lstParos.GridLines = True
        Me.lstParos.Location = New System.Drawing.Point(6, 186)
        Me.lstParos.Margin = New System.Windows.Forms.Padding(4)
        Me.lstParos.Name = "lstParos"
        Me.lstParos.Size = New System.Drawing.Size(861, 215)
        Me.lstParos.TabIndex = 117
        Me.lstParos.UseCompatibleStateImageBehavior = False
        Me.lstParos.View = System.Windows.Forms.View.Details
        '
        'colTipo_Paros
        '
        Me.colTipo_Paros.Text = "Tipo paro"
        Me.colTipo_Paros.Width = 130
        '
        'colMinutos_Paro
        '
        Me.colMinutos_Paro.Text = "Minutos"
        Me.colMinutos_Paro.Width = 90
        '
        'colCveMaquina
        '
        Me.colCveMaquina.Text = "Maquina"
        Me.colCveMaquina.Width = 130
        '
        'colMaquina
        '
        Me.colMaquina.Text = "Maquina"
        Me.colMaquina.Width = 130
        '
        'colDetalles
        '
        Me.colDetalles.Text = "Detalles"
        Me.colDetalles.Width = 130
        '
        'colIdTipo_Paros
        '
        Me.colIdTipo_Paros.Text = "Id_Tipo_Paros"
        Me.colIdTipo_Paros.Width = 0
        '
        'colIdLinea
        '
        Me.colIdLinea.Text = "colId_Linea_Actual"
        Me.colIdLinea.Width = 0
        '
        'colIdMaquina
        '
        Me.colIdMaquina.Text = "colIdMaquina"
        Me.colIdMaquina.Width = 0
        '
        'colCodRegParo
        '
        Me.colCodRegParo.Text = "colCodRegParo"
        Me.colCodRegParo.Width = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(812, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 18)
        Me.Label15.TabIndex = 139
        Me.Label15.Text = "Quitar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(732, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 18)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Agregar"
        '
        'cmdQuitarParo
        '
        Me.cmdQuitarParo.BackColor = System.Drawing.Color.White
        Me.cmdQuitarParo.BackgroundImage = CType(resources.GetObject("cmdQuitarParo.BackgroundImage"), System.Drawing.Image)
        Me.cmdQuitarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdQuitarParo.Enabled = False
        Me.cmdQuitarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitarParo.Location = New System.Drawing.Point(803, 78)
        Me.cmdQuitarParo.Name = "cmdQuitarParo"
        Me.cmdQuitarParo.Size = New System.Drawing.Size(64, 59)
        Me.cmdQuitarParo.TabIndex = 119
        Me.cmdQuitarParo.UseVisualStyleBackColor = False
        '
        'cmdAgregarParo
        '
        Me.cmdAgregarParo.BackColor = System.Drawing.Color.White
        Me.cmdAgregarParo.BackgroundImage = CType(resources.GetObject("cmdAgregarParo.BackgroundImage"), System.Drawing.Image)
        Me.cmdAgregarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAgregarParo.Enabled = False
        Me.cmdAgregarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarParo.Location = New System.Drawing.Point(731, 78)
        Me.cmdAgregarParo.Name = "cmdAgregarParo"
        Me.cmdAgregarParo.Size = New System.Drawing.Size(66, 59)
        Me.cmdAgregarParo.TabIndex = 118
        Me.cmdAgregarParo.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(340, 81)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 18)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Detalles:"
        '
        'txtDetallesParo
        '
        Me.txtDetallesParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDetallesParo.Location = New System.Drawing.Point(410, 78)
        Me.txtDetallesParo.Multiline = True
        Me.txtDetallesParo.Name = "txtDetallesParo"
        Me.txtDetallesParo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesParo.Size = New System.Drawing.Size(300, 75)
        Me.txtDetallesParo.TabIndex = 5
        '
        'cbxTipoParo
        '
        Me.cbxTipoParo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoParo.FormattingEnabled = True
        Me.cbxTipoParo.Location = New System.Drawing.Point(111, 95)
        Me.cbxTipoParo.MaxDropDownItems = 5
        Me.cbxTipoParo.Name = "cbxTipoParo"
        Me.cbxTipoParo.Size = New System.Drawing.Size(189, 26)
        Me.cbxTipoParo.TabIndex = 15
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 98)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 18)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Tipo de Paro:"
        '
        'cbxMaquina
        '
        Me.cbxMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMaquina.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMaquina.FormattingEnabled = True
        Me.cbxMaquina.Location = New System.Drawing.Point(78, 21)
        Me.cbxMaquina.Name = "cbxMaquina"
        Me.cbxMaquina.Size = New System.Drawing.Size(222, 26)
        Me.cbxMaquina.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Maquina:"
        '
        'tabPageRechazos
        '
        Me.tabPageRechazos.Controls.Add(Me.GroupBox1)
        Me.tabPageRechazos.Location = New System.Drawing.Point(4, 22)
        Me.tabPageRechazos.Name = "tabPageRechazos"
        Me.tabPageRechazos.Size = New System.Drawing.Size(1232, 420)
        Me.tabPageRechazos.TabIndex = 2
        Me.tabPageRechazos.Text = "Rechazos"
        Me.tabPageRechazos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxTipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtMotivo)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RECHAZOS"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(109, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(198, 26)
        Me.TextBox1.TabIndex = 336
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 335
        Me.Label2.Text = "Descripcion"
        '
        'cbxTipo
        '
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(109, 131)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(198, 26)
        Me.cbxTipo.TabIndex = 334
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Tipo"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colModelo, Me.colDescripcionModelo, Me.colTipoRechazo, Me.colCantidad, Me.colMotivo, Me.colIdRechazo})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(7, 271)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(617, 136)
        Me.ListView1.TabIndex = 332
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colModelo
        '
        Me.colModelo.Text = "Modelo"
        Me.colModelo.Width = 140
        '
        'colDescripcionModelo
        '
        Me.colDescripcionModelo.Text = "Descripcion"
        Me.colDescripcionModelo.Width = 135
        '
        'colTipoRechazo
        '
        Me.colTipoRechazo.Text = "Tipo"
        Me.colTipoRechazo.Width = 190
        '
        'colCantidad
        '
        Me.colCantidad.Text = "Cantidad"
        Me.colCantidad.Width = 50
        '
        'colMotivo
        '
        Me.colMotivo.Text = "Motivo"
        Me.colMotivo.Width = 258
        '
        'colIdRechazo
        '
        Me.colIdRechazo.Width = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 26)
        Me.ComboBox1.TabIndex = 331
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 330
        Me.Label5.Text = "Motivo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(508, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 329
        Me.Label7.Text = "Quitar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(423, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 328
        Me.Label11.Text = "Agregar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 59)
        Me.Button1.TabIndex = 326
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(502, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 59)
        Me.Button2.TabIndex = 327
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(39, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 18)
        Me.Label12.TabIndex = 325
        Me.Label12.Text = "Modelo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(27, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 324
        Me.Label16.Text = "Cantidad"
        '
        'txtMotivo
        '
        Me.txtMotivo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.Location = New System.Drawing.Point(6, 186)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivo.Size = New System.Drawing.Size(618, 78)
        Me.txtMotivo.TabIndex = 323
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(109, 95)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(198, 26)
        Me.txtCantidad.TabIndex = 322
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1232, 420)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.grpSeguridad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1232, 420)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView4)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(616, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 408)
        Me.GroupBox2.TabIndex = 335
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEGURIDAD"
        Me.GroupBox2.Visible = False
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13})
        Me.ListView4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(11, 202)
        Me.ListView4.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(518, 177)
        Me.ListView4.TabIndex = 334
        Me.ListView4.UseCompatibleStateImageBehavior = False
        Me.ListView4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Tipo paro"
        Me.ColumnHeader12.Width = 130
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Minutos"
        Me.ColumnHeader13.Width = 90
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(484, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(50, 18)
        Me.Label33.TabIndex = 333
        Me.Label33.Text = "Quitar"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(399, 136)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(65, 18)
        Me.Label45.TabIndex = 332
        Me.Label45.Text = "Agregar"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(401, 74)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(63, 59)
        Me.Button5.TabIndex = 330
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(478, 74)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 59)
        Me.Button6.TabIndex = 331
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(186, 114)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(181, 26)
        Me.TextBox4.TabIndex = 153
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(186, 60)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(181, 26)
        Me.ComboBox4.TabIndex = 152
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(104, 117)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 18)
        Me.Label50.TabIndex = 151
        Me.Label50.Text = "Cantidad:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(8, 63)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(172, 18)
        Me.Label55.TabIndex = 8
        Me.Label55.Text = "Condiciones inseguras:"
        '
        'grpSeguridad
        '
        Me.grpSeguridad.Controls.Add(Me.ListView3)
        Me.grpSeguridad.Controls.Add(Me.Label22)
        Me.grpSeguridad.Controls.Add(Me.Label30)
        Me.grpSeguridad.Controls.Add(Me.Button3)
        Me.grpSeguridad.Controls.Add(Me.Button4)
        Me.grpSeguridad.Controls.Add(Me.TextBox3)
        Me.grpSeguridad.Controls.Add(Me.ComboBox3)
        Me.grpSeguridad.Controls.Add(Me.Label20)
        Me.grpSeguridad.Controls.Add(Me.Label27)
        Me.grpSeguridad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeguridad.Location = New System.Drawing.Point(6, 6)
        Me.grpSeguridad.Name = "grpSeguridad"
        Me.grpSeguridad.Size = New System.Drawing.Size(604, 408)
        Me.grpSeguridad.TabIndex = 7
        Me.grpSeguridad.TabStop = False
        Me.grpSeguridad.Text = "SEGURIDAD"
        Me.grpSeguridad.Visible = False
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(11, 202)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(518, 177)
        Me.ListView3.TabIndex = 334
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Tipo paro"
        Me.ColumnHeader10.Width = 130
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Minutos"
        Me.ColumnHeader11.Width = 90
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(484, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 18)
        Me.Label22.TabIndex = 333
        Me.Label22.Text = "Quitar"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(399, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 18)
        Me.Label30.TabIndex = 332
        Me.Label30.Text = "Agregar"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(401, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 59)
        Me.Button3.TabIndex = 330
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(478, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 59)
        Me.Button4.TabIndex = 331
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(186, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(181, 26)
        Me.TextBox3.TabIndex = 153
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(186, 60)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(181, 26)
        Me.ComboBox3.TabIndex = 152
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(104, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 18)
        Me.Label20.TabIndex = 151
        Me.Label20.Text = "Cantidad:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 63)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(172, 18)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Condiciones inseguras:"
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(4, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(476, 32)
        Me.titulo_banner_formulario.TabIndex = 103
        Me.titulo_banner_formulario.Text = "Captura de Resultados de Producción"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-6, -1)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(1262, 44)
        Me.banner_formulario.TabIndex = 104
        Me.banner_formulario.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(963, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 172)
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Location = New System.Drawing.Point(65, 149)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(234, 26)
        Me.cbxTurno.TabIndex = 143
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(9, 152)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(50, 18)
        Me.Label56.TabIndex = 142
        Me.Label56.Text = "Turno:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(9, 116)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(90, 18)
        Me.Label57.TabIndex = 146
        Me.Label57.Text = "Bienvenido:"
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(98, 116)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(115, 19)
        Me.lblCodigoEmpleado.TabIndex = 145
        Me.lblCodigoEmpleado.Text = "codEmpleado"
        Me.lblCodigoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(213, 116)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(86, 19)
        Me.lblNombreEmpleado.TabIndex = 144
        Me.lblNombreEmpleado.Text = "Empleado"
        '
        'lblNombreEquipo
        '
        Me.lblNombreEquipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEquipo.Location = New System.Drawing.Point(8, 85)
        Me.lblNombreEquipo.Name = "lblNombreEquipo"
        Me.lblNombreEquipo.Size = New System.Drawing.Size(241, 19)
        Me.lblNombreEquipo.TabIndex = 308
        Me.lblNombreEquipo.Text = "NombreEquipo"
        Me.lblNombreEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(9, 192)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(51, 18)
        Me.Label58.TabIndex = 310
        Me.Label58.Text = "Linea:"
        '
        'cbxLinea
        '
        Me.cbxLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLinea.FormattingEnabled = True
        Me.cbxLinea.Location = New System.Drawing.Point(66, 189)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(234, 26)
        Me.cbxLinea.TabIndex = 309
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1254, 722)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.cbxLinea)
        Me.Controls.Add(Me.lblNombreEquipo)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.lblCodigoEmpleado)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.titulo_banner_formulario)
        Me.Controls.Add(Me.banner_formulario)
        Me.Controls.Add(Me.TabContenido)
        Me.MaximumSize = New System.Drawing.Size(1280, 768)
        Me.MinimumSize = New System.Drawing.Size(1270, 736)
        Me.Name = "frmProduccion"
        Me.Text = "frmProduccion"
        Me.TabContenido.ResumeLayout(False)
        Me.tabPageProductividad.ResumeLayout(False)
        Me.grpDesechos.ResumeLayout(False)
        Me.grpDesechos.PerformLayout()
        Me.grpProductividad.ResumeLayout(False)
        Me.grpProductividad.PerformLayout()
        Me.tabPageParos.ResumeLayout(False)
        Me.grpCosto.ResumeLayout(False)
        Me.grpCosto.PerformLayout()
        Me.grpParos.ResumeLayout(False)
        Me.grpParos.PerformLayout()
        Me.tabPageRechazos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpSeguridad.ResumeLayout(False)
        Me.grpSeguridad.PerformLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabContenido As System.Windows.Forms.TabControl
    Friend WithEvents tabPageProductividad As System.Windows.Forms.TabPage
    Friend WithEvents grpDesechos As System.Windows.Forms.GroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesechos As System.Windows.Forms.TextBox
    Friend WithEvents grpProductividad As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtPzasPorHora As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtModeloDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblParosComedor As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblTiempoOperacion As System.Windows.Forms.Label
    Friend WithEvents lblParosNoPlaneados As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents lblTiempoTurno As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblTiempoCarga As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblParosPlaneados As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtMinutos As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lstModelos As System.Windows.Forms.ListView
    Friend WithEvents colModelo_Productividad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPzasProducidas As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDesechos As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTiempoOperacio As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCapacidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAdeudo As System.Windows.Forms.ColumnHeader
    Friend WithEvents IdModelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents IdLinea As System.Windows.Forms.ColumnHeader
    Friend WithEvents IdIndicador1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cbxModeloProductividad As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblOEE As System.Windows.Forms.Label
    Friend WithEvents lblCalidad As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblDesempeno As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblDisponibilidad As System.Windows.Forms.Label
    Friend WithEvents txtPiezasProducidas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarModelo As System.Windows.Forms.Button
    Friend WithEvents cmdQuitarModelo As System.Windows.Forms.Button
    Friend WithEvents tabPageParos As System.Windows.Forms.TabPage
    Friend WithEvents grpCosto As System.Windows.Forms.GroupBox
    Friend WithEvents lblMinReal As System.Windows.Forms.Label
    Friend WithEvents lblMinProgramados As System.Windows.Forms.Label
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents grpParos As System.Windows.Forms.GroupBox
    Friend WithEvents txtParosDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMaquinaDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutosParo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lstParos As System.Windows.Forms.ListView
    Friend WithEvents colTipo_Paros As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMinutos_Paro As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCveMaquina As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMaquina As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDetalles As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIdTipo_Paros As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIdLinea As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIdMaquina As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCodRegParo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdQuitarParo As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarParo As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesParo As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoParo As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbxMaquina As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tabPageRechazos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colModelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDescripcionModelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTipoRechazo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCantidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMotivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colIdRechazo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents grpSeguridad As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEquipo As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cbxLinea As System.Windows.Forms.ComboBox
End Class
