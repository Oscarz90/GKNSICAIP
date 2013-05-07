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
        Me.grdDetalleDesecho = New System.Windows.Forms.DataGridView()
        Me.colcve_desecho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col__cve_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cve_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnp_gkn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmodelodescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesechocantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cbxModeloDesecho = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAgregarDesecho = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnQuitarDesecho = New System.Windows.Forms.Button()
        Me.txtModeloDesecho = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesechosCantidad = New System.Windows.Forms.TextBox()
        Me.grpProductividad = New System.Windows.Forms.GroupBox()
        Me.grdDetalleProductividad = New System.Windows.Forms.DataGridView()
        Me.colcve_produccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcve_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcve_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.np_gkn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpzas_ok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCapacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdeudo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtPzasPorHora = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtModeloDescripcionProductividad = New System.Windows.Forms.TextBox()
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
        Me.txtTiempoOperacion = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
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
        Me.txtPiezasOkProducidas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAgregarModelo = New System.Windows.Forms.Button()
        Me.btnQuitarModelo = New System.Windows.Forms.Button()
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
        Me.grdDetalleParo = New System.Windows.Forms.DataGridView()
        Me.colcve_registro_paro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcve_lineab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcve_maquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcve_paro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcod_paro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colminutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colclave_maquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmaquina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldetalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtParosDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMaquinaDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMinutosParo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnQuitarParo = New System.Windows.Forms.Button()
        Me.btnAgregarParo = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDetallesParo = New System.Windows.Forms.TextBox()
        Me.cbxTipoParo = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbxMaquina = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tabPageRechazos = New System.Windows.Forms.TabPage()
        Me.grp5s = New System.Windows.Forms.GroupBox()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtManttoAutonomo = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txt5s = New System.Windows.Forms.TextBox()
        Me.txtAdmonVisual = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.grpRechazos = New System.Windows.Forms.GroupBox()
        Me.grdDetalleRechazo = New System.Windows.Forms.DataGridView()
        Me.colcve_rechazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_np_gkn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltipo_rechazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtModeloRechazo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoRechazo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxModeloRechazo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAgregarRechazo = New System.Windows.Forms.Button()
        Me.btnQuitarRechazo = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRechazoMotivo = New System.Windows.Forms.TextBox()
        Me.txtRechazosCantidad = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpAccidentes = New System.Windows.Forms.GroupBox()
        Me.grdDetalleAccidente = New System.Windows.Forms.DataGridView()
        Me.col_cve_seguridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentarios_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarAccidente = New System.Windows.Forms.Button()
        Me.btnAgregarAccidente = New System.Windows.Forms.Button()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtDetallesAccidentes = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtAccidenteCantidad = New System.Windows.Forms.TextBox()
        Me.cbxTipoAccidente = New System.Windows.Forms.ComboBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.grpCondInseg = New System.Windows.Forms.GroupBox()
        Me.grdDetalleCondInseg = New System.Windows.Forms.DataGridView()
        Me.colcve_seguridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescripciondetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcantidaddetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcomentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarCondInseg = New System.Windows.Forms.Button()
        Me.btnAgregarCondInseg = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDetallesCondInseg = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCondInsegCantidad = New System.Windows.Forms.TextBox()
        Me.cbxTipoCondInseg = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpGente = New System.Windows.Forms.GroupBox()
        Me.grdDetalleGente = New System.Windows.Forms.DataGridView()
        Me.colcve_gente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colgdescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colgcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarGente = New System.Windows.Forms.Button()
        Me.btnAgregarGente = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDetallesGente = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtGenteCantidad = New System.Windows.Forms.TextBox()
        Me.cbxTipoDetalleGente = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Turnos_Lineas = New System.Windows.Forms.TabPage()
        Me.cbxTurnosLineas = New System.Windows.Forms.ComboBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.btnLineaUnica = New System.Windows.Forms.Button()
        Me.btnLineasTodas = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.grdLineasRegistradas = New System.Windows.Forms.DataGridView()
        Me.col_cve_registro_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_dia_asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdLineasNoRegistradas = New System.Windows.Forms.DataGridView()
        Me.col_cve_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.grpCalidad = New System.Windows.Forms.GroupBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.lblNRFTi = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.lblFechaRegistro = New System.Windows.Forms.Label()
        Me.lblFechaRegistrodescripcion = New System.Windows.Forms.Label()
        Me.TabContenido.SuspendLayout()
        Me.tabPageProductividad.SuspendLayout()
        Me.grpDesechos.SuspendLayout()
        CType(Me.grdDetalleDesecho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProductividad.SuspendLayout()
        CType(Me.grdDetalleProductividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageParos.SuspendLayout()
        Me.grpCosto.SuspendLayout()
        Me.grpParos.SuspendLayout()
        CType(Me.grdDetalleParo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageRechazos.SuspendLayout()
        Me.grp5s.SuspendLayout()
        Me.grpRechazos.SuspendLayout()
        CType(Me.grdDetalleRechazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.grpAccidentes.SuspendLayout()
        CType(Me.grdDetalleAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondInseg.SuspendLayout()
        CType(Me.grdDetalleCondInseg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grpGente.SuspendLayout()
        CType(Me.grdDetalleGente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Turnos_Lineas.SuspendLayout()
        CType(Me.grdLineasRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLineasNoRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCalidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabContenido
        '
        Me.TabContenido.Controls.Add(Me.tabPageProductividad)
        Me.TabContenido.Controls.Add(Me.tabPageParos)
        Me.TabContenido.Controls.Add(Me.tabPageRechazos)
        Me.TabContenido.Controls.Add(Me.TabPage1)
        Me.TabContenido.Controls.Add(Me.TabPage2)
        Me.TabContenido.Controls.Add(Me.Turnos_Lineas)
        Me.TabContenido.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabContenido.Location = New System.Drawing.Point(12, 248)
        Me.TabContenido.Name = "TabContenido"
        Me.TabContenido.SelectedIndex = 0
        Me.TabContenido.Size = New System.Drawing.Size(1230, 462)
        Me.TabContenido.TabIndex = 1
        Me.TabContenido.Tag = ""
        '
        'tabPageProductividad
        '
        Me.tabPageProductividad.Controls.Add(Me.grpDesechos)
        Me.tabPageProductividad.Controls.Add(Me.grpProductividad)
        Me.tabPageProductividad.Location = New System.Drawing.Point(4, 27)
        Me.tabPageProductividad.Name = "tabPageProductividad"
        Me.tabPageProductividad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageProductividad.Size = New System.Drawing.Size(1222, 431)
        Me.tabPageProductividad.TabIndex = 0
        Me.tabPageProductividad.Text = "Productividad"
        Me.tabPageProductividad.UseVisualStyleBackColor = True
        '
        'grpDesechos
        '
        Me.grpDesechos.Controls.Add(Me.grdDetalleDesecho)
        Me.grpDesechos.Controls.Add(Me.Label59)
        Me.grpDesechos.Controls.Add(Me.cbxModeloDesecho)
        Me.grpDesechos.Controls.Add(Me.Label60)
        Me.grpDesechos.Controls.Add(Me.Label17)
        Me.grpDesechos.Controls.Add(Me.btnAgregarDesecho)
        Me.grpDesechos.Controls.Add(Me.Label19)
        Me.grpDesechos.Controls.Add(Me.btnQuitarDesecho)
        Me.grpDesechos.Controls.Add(Me.txtModeloDesecho)
        Me.grpDesechos.Controls.Add(Me.Label46)
        Me.grpDesechos.Controls.Add(Me.Label6)
        Me.grpDesechos.Controls.Add(Me.txtDesechosCantidad)
        Me.grpDesechos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDesechos.Location = New System.Drawing.Point(759, 6)
        Me.grpDesechos.Name = "grpDesechos"
        Me.grpDesechos.Size = New System.Drawing.Size(448, 408)
        Me.grpDesechos.TabIndex = 326
        Me.grpDesechos.TabStop = False
        Me.grpDesechos.Text = "Desecho"
        '
        'grdDetalleDesecho
        '
        Me.grdDetalleDesecho.AllowUserToAddRows = False
        Me.grdDetalleDesecho.AllowUserToDeleteRows = False
        Me.grdDetalleDesecho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleDesecho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_desecho, Me.col__cve_linea, Me.col_cve_modelo, Me.colnp_gkn, Me.colmodelodescripcion, Me.coldesechocantidad})
        Me.grdDetalleDesecho.Location = New System.Drawing.Point(6, 237)
        Me.grdDetalleDesecho.Name = "grdDetalleDesecho"
        Me.grdDetalleDesecho.ReadOnly = True
        Me.grdDetalleDesecho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleDesecho.Size = New System.Drawing.Size(436, 165)
        Me.grdDetalleDesecho.TabIndex = 327
        '
        'colcve_desecho
        '
        Me.colcve_desecho.DataPropertyName = "cve_desecho"
        Me.colcve_desecho.HeaderText = "cve_desecho"
        Me.colcve_desecho.Name = "colcve_desecho"
        Me.colcve_desecho.ReadOnly = True
        '
        'col__cve_linea
        '
        Me.col__cve_linea.DataPropertyName = "cve_linea"
        Me.col__cve_linea.HeaderText = "cve_linea"
        Me.col__cve_linea.Name = "col__cve_linea"
        Me.col__cve_linea.ReadOnly = True
        '
        'col_cve_modelo
        '
        Me.col_cve_modelo.DataPropertyName = "cve_modelo"
        Me.col_cve_modelo.HeaderText = "cve_modelo"
        Me.col_cve_modelo.Name = "col_cve_modelo"
        Me.col_cve_modelo.ReadOnly = True
        '
        'colnp_gkn
        '
        Me.colnp_gkn.DataPropertyName = "np_gkn"
        Me.colnp_gkn.HeaderText = "No.Parte GKN"
        Me.colnp_gkn.Name = "colnp_gkn"
        Me.colnp_gkn.ReadOnly = True
        '
        'colmodelodescripcion
        '
        Me.colmodelodescripcion.DataPropertyName = "descripcion"
        Me.colmodelodescripcion.HeaderText = "Modelo"
        Me.colmodelodescripcion.Name = "colmodelodescripcion"
        Me.colmodelodescripcion.ReadOnly = True
        '
        'coldesechocantidad
        '
        Me.coldesechocantidad.DataPropertyName = "cantidad"
        Me.coldesechocantidad.HeaderText = "Cantidad"
        Me.coldesechocantidad.Name = "coldesechocantidad"
        Me.coldesechocantidad.ReadOnly = True
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(372, 178)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(50, 18)
        Me.Label59.TabIndex = 326
        Me.Label59.Text = "Quitar"
        '
        'cbxModeloDesecho
        '
        Me.cbxModeloDesecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxModeloDesecho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloDesecho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloDesecho.FormattingEnabled = True
        Me.cbxModeloDesecho.Location = New System.Drawing.Point(116, 25)
        Me.cbxModeloDesecho.Name = "cbxModeloDesecho"
        Me.cbxModeloDesecho.Size = New System.Drawing.Size(217, 26)
        Me.cbxModeloDesecho.TabIndex = 323
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(291, 178)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(65, 18)
        Me.Label60.TabIndex = 325
        Me.Label60.Text = "Agregar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 18)
        Me.Label17.TabIndex = 325
        Me.Label17.Text = "Descripcion:"
        '
        'btnAgregarDesecho
        '
        Me.btnAgregarDesecho.BackColor = System.Drawing.Color.White
        Me.btnAgregarDesecho.BackgroundImage = CType(resources.GetObject("btnAgregarDesecho.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDesecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarDesecho.Enabled = False
        Me.btnAgregarDesecho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDesecho.Location = New System.Drawing.Point(293, 116)
        Me.btnAgregarDesecho.Name = "btnAgregarDesecho"
        Me.btnAgregarDesecho.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarDesecho.TabIndex = 323
        Me.btnAgregarDesecho.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(46, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 18)
        Me.Label19.TabIndex = 322
        Me.Label19.Text = "Modelo:"
        '
        'btnQuitarDesecho
        '
        Me.btnQuitarDesecho.BackColor = System.Drawing.Color.White
        Me.btnQuitarDesecho.BackgroundImage = CType(resources.GetObject("btnQuitarDesecho.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarDesecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarDesecho.Enabled = False
        Me.btnQuitarDesecho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDesecho.Location = New System.Drawing.Point(367, 116)
        Me.btnQuitarDesecho.Name = "btnQuitarDesecho"
        Me.btnQuitarDesecho.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarDesecho.TabIndex = 324
        Me.btnQuitarDesecho.UseVisualStyleBackColor = False
        '
        'txtModeloDesecho
        '
        Me.txtModeloDesecho.Location = New System.Drawing.Point(116, 68)
        Me.txtModeloDesecho.Name = "txtModeloDesecho"
        Me.txtModeloDesecho.ReadOnly = True
        Me.txtModeloDesecho.Size = New System.Drawing.Size(217, 26)
        Me.txtModeloDesecho.TabIndex = 324
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(183, 115)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(68, 18)
        Me.Label46.TabIndex = 309
        Me.Label46.Text = "cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Desechos:"
        '
        'txtDesechosCantidad
        '
        Me.txtDesechosCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDesechosCantidad.Location = New System.Drawing.Point(116, 112)
        Me.txtDesechosCantidad.Name = "txtDesechosCantidad"
        Me.txtDesechosCantidad.Size = New System.Drawing.Size(61, 26)
        Me.txtDesechosCantidad.TabIndex = 9
        Me.txtDesechosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpProductividad
        '
        Me.grpProductividad.Controls.Add(Me.grdDetalleProductividad)
        Me.grpProductividad.Controls.Add(Me.Label54)
        Me.grpProductividad.Controls.Add(Me.txtPzasPorHora)
        Me.grpProductividad.Controls.Add(Me.Label53)
        Me.grpProductividad.Controls.Add(Me.txtModeloDescripcionProductividad)
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
        Me.grpProductividad.Controls.Add(Me.txtTiempoOperacion)
        Me.grpProductividad.Controls.Add(Me.Label29)
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
        Me.grpProductividad.Controls.Add(Me.txtPiezasOkProducidas)
        Me.grpProductividad.Controls.Add(Me.Label9)
        Me.grpProductividad.Controls.Add(Me.Label10)
        Me.grpProductividad.Controls.Add(Me.btnAgregarModelo)
        Me.grpProductividad.Controls.Add(Me.btnQuitarModelo)
        Me.grpProductividad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProductividad.Location = New System.Drawing.Point(3, 3)
        Me.grpProductividad.Name = "grpProductividad"
        Me.grpProductividad.Size = New System.Drawing.Size(750, 413)
        Me.grpProductividad.TabIndex = 1
        Me.grpProductividad.TabStop = False
        Me.grpProductividad.Text = "Productividad"
        '
        'grdDetalleProductividad
        '
        Me.grdDetalleProductividad.AllowUserToAddRows = False
        Me.grdDetalleProductividad.AllowUserToDeleteRows = False
        Me.grdDetalleProductividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleProductividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_produccion, Me.colcve_linea, Me.colcve_modelo, Me.np_gkn, Me.coldescripcion, Me.colpzas_ok, Me.coltom, Me.colCapacidad, Me.colAdeudo})
        Me.grdDetalleProductividad.Location = New System.Drawing.Point(3, 277)
        Me.grdDetalleProductividad.Name = "grdDetalleProductividad"
        Me.grdDetalleProductividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleProductividad.Size = New System.Drawing.Size(741, 130)
        Me.grdDetalleProductividad.TabIndex = 322
        '
        'colcve_produccion
        '
        Me.colcve_produccion.DataPropertyName = "cve_produccion"
        Me.colcve_produccion.HeaderText = "cve_produccion"
        Me.colcve_produccion.Name = "colcve_produccion"
        Me.colcve_produccion.ReadOnly = True
        '
        'colcve_linea
        '
        Me.colcve_linea.DataPropertyName = "cve_linea"
        Me.colcve_linea.HeaderText = "cve_linea"
        Me.colcve_linea.Name = "colcve_linea"
        Me.colcve_linea.ReadOnly = True
        '
        'colcve_modelo
        '
        Me.colcve_modelo.DataPropertyName = "cve_modelo"
        Me.colcve_modelo.HeaderText = "cve_modelo"
        Me.colcve_modelo.Name = "colcve_modelo"
        Me.colcve_modelo.ReadOnly = True
        '
        'np_gkn
        '
        Me.np_gkn.DataPropertyName = "np_gkn"
        Me.np_gkn.HeaderText = "No. Parte GKN"
        Me.np_gkn.Name = "np_gkn"
        Me.np_gkn.ReadOnly = True
        Me.np_gkn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.np_gkn.Width = 140
        '
        'coldescripcion
        '
        Me.coldescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldescripcion.DataPropertyName = "descripcion"
        Me.coldescripcion.HeaderText = "Modelo"
        Me.coldescripcion.Name = "coldescripcion"
        Me.coldescripcion.ReadOnly = True
        Me.coldescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldescripcion.Width = 85
        '
        'colpzas_ok
        '
        Me.colpzas_ok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colpzas_ok.DataPropertyName = "pzas_ok"
        Me.colpzas_ok.HeaderText = "Piezas Ok"
        Me.colpzas_ok.Name = "colpzas_ok"
        Me.colpzas_ok.ReadOnly = True
        Me.colpzas_ok.Width = 97
        '
        'coltom
        '
        Me.coltom.DataPropertyName = "tom"
        Me.coltom.HeaderText = "Tiempo Operacion"
        Me.coltom.Name = "coltom"
        Me.coltom.ReadOnly = True
        Me.coltom.Width = 160
        '
        'colCapacidad
        '
        Me.colCapacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCapacidad.DataPropertyName = "capacidad"
        Me.colCapacidad.HeaderText = "Capacidad"
        Me.colCapacidad.Name = "colCapacidad"
        Me.colCapacidad.ReadOnly = True
        Me.colCapacidad.Width = 111
        '
        'colAdeudo
        '
        Me.colAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAdeudo.DataPropertyName = "adeudo"
        Me.colAdeudo.HeaderText = "Adeudo"
        Me.colAdeudo.Name = "colAdeudo"
        Me.colAdeudo.ReadOnly = True
        Me.colAdeudo.Width = 88
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label54.Location = New System.Drawing.Point(511, 174)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(63, 17)
        Me.Label54.TabIndex = 321
        Me.Label54.Text = "cantidad"
        '
        'txtPzasPorHora
        '
        Me.txtPzasPorHora.BackColor = System.Drawing.SystemColors.Control
        Me.txtPzasPorHora.Location = New System.Drawing.Point(449, 170)
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
        Me.Label53.Location = New System.Drawing.Point(6, 204)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(96, 18)
        Me.Label53.TabIndex = 319
        Me.Label53.Text = "Descripcion:"
        '
        'txtModeloDescripcionProductividad
        '
        Me.txtModeloDescripcionProductividad.Location = New System.Drawing.Point(108, 201)
        Me.txtModeloDescripcionProductividad.Name = "txtModeloDescripcionProductividad"
        Me.txtModeloDescripcionProductividad.ReadOnly = True
        Me.txtModeloDescripcionProductividad.Size = New System.Drawing.Size(217, 26)
        Me.txtModeloDescripcionProductividad.TabIndex = 318
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(334, 175)
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
        Me.Label44.Location = New System.Drawing.Point(511, 205)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(63, 17)
        Me.Label44.TabIndex = 308
        Me.Label44.Text = "cantidad"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label42.Location = New System.Drawing.Point(265, 240)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(60, 17)
        Me.Label42.TabIndex = 307
        Me.Label42.Text = "minutos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(669, 232)
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
        Me.Label35.Location = New System.Drawing.Point(18, 135)
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
        'txtTiempoOperacion
        '
        Me.txtTiempoOperacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtTiempoOperacion.Location = New System.Drawing.Point(198, 236)
        Me.txtTiempoOperacion.Name = "txtTiempoOperacion"
        Me.txtTiempoOperacion.Size = New System.Drawing.Size(61, 26)
        Me.txtTiempoOperacion.TabIndex = 156
        Me.txtTiempoOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Label29.Location = New System.Drawing.Point(61, 240)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(132, 17)
        Me.Label29.TabIndex = 155
        Me.Label29.Text = "Tiempo Operación:"
        '
        'cbxModeloProductividad
        '
        Me.cbxModeloProductividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxModeloProductividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloProductividad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloProductividad.FormattingEnabled = True
        Me.cbxModeloProductividad.Location = New System.Drawing.Point(108, 170)
        Me.cbxModeloProductividad.Name = "cbxModeloProductividad"
        Me.cbxModeloProductividad.Size = New System.Drawing.Size(217, 26)
        Me.cbxModeloProductividad.TabIndex = 154
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(38, 173)
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
        Me.Label4.Location = New System.Drawing.Point(359, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Piezas OK:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(588, 232)
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
        'txtPiezasOkProducidas
        '
        Me.txtPiezasOkProducidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPiezasOkProducidas.Location = New System.Drawing.Point(449, 201)
        Me.txtPiezasOkProducidas.Name = "txtPiezasOkProducidas"
        Me.txtPiezasOkProducidas.Size = New System.Drawing.Size(61, 26)
        Me.txtPiezasOkProducidas.TabIndex = 7
        Me.txtPiezasOkProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'btnAgregarModelo
        '
        Me.btnAgregarModelo.BackColor = System.Drawing.Color.White
        Me.btnAgregarModelo.BackgroundImage = CType(resources.GetObject("btnAgregarModelo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarModelo.Enabled = False
        Me.btnAgregarModelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarModelo.Location = New System.Drawing.Point(590, 170)
        Me.btnAgregarModelo.Name = "btnAgregarModelo"
        Me.btnAgregarModelo.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarModelo.TabIndex = 149
        Me.btnAgregarModelo.UseVisualStyleBackColor = False
        '
        'btnQuitarModelo
        '
        Me.btnQuitarModelo.BackColor = System.Drawing.Color.White
        Me.btnQuitarModelo.BackgroundImage = CType(resources.GetObject("btnQuitarModelo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarModelo.Enabled = False
        Me.btnQuitarModelo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarModelo.Location = New System.Drawing.Point(664, 170)
        Me.btnQuitarModelo.Name = "btnQuitarModelo"
        Me.btnQuitarModelo.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarModelo.TabIndex = 150
        Me.btnQuitarModelo.UseVisualStyleBackColor = False
        '
        'tabPageParos
        '
        Me.tabPageParos.Controls.Add(Me.grpCalidad)
        Me.tabPageParos.Controls.Add(Me.grpCosto)
        Me.tabPageParos.Controls.Add(Me.grpParos)
        Me.tabPageParos.Location = New System.Drawing.Point(4, 27)
        Me.tabPageParos.Name = "tabPageParos"
        Me.tabPageParos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageParos.Size = New System.Drawing.Size(1222, 431)
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
        Me.grpCosto.Location = New System.Drawing.Point(848, 6)
        Me.grpCosto.Name = "grpCosto"
        Me.grpCosto.Size = New System.Drawing.Size(368, 161)
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
        Me.grpParos.Controls.Add(Me.grdDetalleParo)
        Me.grpParos.Controls.Add(Me.txtParosDescripcion)
        Me.grpParos.Controls.Add(Me.txtMaquinaDescripcion)
        Me.grpParos.Controls.Add(Me.txtMinutosParo)
        Me.grpParos.Controls.Add(Me.Label25)
        Me.grpParos.Controls.Add(Me.Label15)
        Me.grpParos.Controls.Add(Me.Label13)
        Me.grpParos.Controls.Add(Me.btnQuitarParo)
        Me.grpParos.Controls.Add(Me.btnAgregarParo)
        Me.grpParos.Controls.Add(Me.Label32)
        Me.grpParos.Controls.Add(Me.txtDetallesParo)
        Me.grpParos.Controls.Add(Me.cbxTipoParo)
        Me.grpParos.Controls.Add(Me.Label26)
        Me.grpParos.Controls.Add(Me.cbxMaquina)
        Me.grpParos.Controls.Add(Me.Label24)
        Me.grpParos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParos.Location = New System.Drawing.Point(6, 6)
        Me.grpParos.Name = "grpParos"
        Me.grpParos.Size = New System.Drawing.Size(836, 408)
        Me.grpParos.TabIndex = 15
        Me.grpParos.TabStop = False
        Me.grpParos.Text = "Paros"
        '
        'grdDetalleParo
        '
        Me.grdDetalleParo.AllowUserToAddRows = False
        Me.grdDetalleParo.AllowUserToDeleteRows = False
        Me.grdDetalleParo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleParo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_registro_paro, Me.colcve_lineab, Me.colcve_maquina, Me.colcve_paro, Me.colcod_paro, Me.paro, Me.colminutos, Me.colclave_maquina, Me.colmaquina, Me.coldetalles})
        Me.grdDetalleParo.Location = New System.Drawing.Point(6, 171)
        Me.grdDetalleParo.Name = "grdDetalleParo"
        Me.grdDetalleParo.ReadOnly = True
        Me.grdDetalleParo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleParo.Size = New System.Drawing.Size(824, 231)
        Me.grdDetalleParo.TabIndex = 324
        '
        'colcve_registro_paro
        '
        Me.colcve_registro_paro.DataPropertyName = "cve_registro_paro"
        Me.colcve_registro_paro.HeaderText = "cve_registro_paro"
        Me.colcve_registro_paro.Name = "colcve_registro_paro"
        Me.colcve_registro_paro.ReadOnly = True
        '
        'colcve_lineab
        '
        Me.colcve_lineab.DataPropertyName = "cve_linea"
        Me.colcve_lineab.HeaderText = "cve_linea"
        Me.colcve_lineab.Name = "colcve_lineab"
        Me.colcve_lineab.ReadOnly = True
        '
        'colcve_maquina
        '
        Me.colcve_maquina.DataPropertyName = "cve_maquina"
        Me.colcve_maquina.HeaderText = "cve_maquina"
        Me.colcve_maquina.Name = "colcve_maquina"
        Me.colcve_maquina.ReadOnly = True
        '
        'colcve_paro
        '
        Me.colcve_paro.DataPropertyName = "cve_paro"
        Me.colcve_paro.HeaderText = "cve_paro"
        Me.colcve_paro.Name = "colcve_paro"
        Me.colcve_paro.ReadOnly = True
        '
        'colcod_paro
        '
        Me.colcod_paro.DataPropertyName = "cod_paro"
        Me.colcod_paro.HeaderText = "Paro"
        Me.colcod_paro.Name = "colcod_paro"
        Me.colcod_paro.ReadOnly = True
        '
        'paro
        '
        Me.paro.DataPropertyName = "paro"
        Me.paro.HeaderText = "Descripcion"
        Me.paro.Name = "paro"
        Me.paro.ReadOnly = True
        '
        'colminutos
        '
        Me.colminutos.DataPropertyName = "minutos"
        Me.colminutos.HeaderText = "Minutos"
        Me.colminutos.Name = "colminutos"
        Me.colminutos.ReadOnly = True
        '
        'colclave_maquina
        '
        Me.colclave_maquina.DataPropertyName = "clave_maquina"
        Me.colclave_maquina.HeaderText = "Clave Maquina"
        Me.colclave_maquina.Name = "colclave_maquina"
        Me.colclave_maquina.ReadOnly = True
        '
        'colmaquina
        '
        Me.colmaquina.DataPropertyName = "maquina"
        Me.colmaquina.HeaderText = "Maquina"
        Me.colmaquina.Name = "colmaquina"
        Me.colmaquina.ReadOnly = True
        '
        'coldetalles
        '
        Me.coldetalles.DataPropertyName = "detalles"
        Me.coldetalles.HeaderText = "Detalles"
        Me.coldetalles.Name = "coldetalles"
        Me.coldetalles.ReadOnly = True
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
        Me.txtMaquinaDescripcion.Location = New System.Drawing.Point(22, 55)
        Me.txtMaquinaDescripcion.Name = "txtMaquinaDescripcion"
        Me.txtMaquinaDescripcion.ReadOnly = True
        Me.txtMaquinaDescripcion.Size = New System.Drawing.Size(299, 25)
        Me.txtMaquinaDescripcion.TabIndex = 322
        '
        'txtMinutosParo
        '
        Me.txtMinutosParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtMinutosParo.Location = New System.Drawing.Point(422, 21)
        Me.txtMinutosParo.Name = "txtMinutosParo"
        Me.txtMinutosParo.Size = New System.Drawing.Size(161, 26)
        Me.txtMinutosParo.TabIndex = 141
        Me.txtMinutosParo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(339, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 18)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "Minutos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(752, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 18)
        Me.Label15.TabIndex = 139
        Me.Label15.Text = "Quitar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(672, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 18)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Agregar"
        '
        'btnQuitarParo
        '
        Me.btnQuitarParo.BackColor = System.Drawing.Color.White
        Me.btnQuitarParo.BackgroundImage = CType(resources.GetObject("btnQuitarParo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarParo.Enabled = False
        Me.btnQuitarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarParo.Location = New System.Drawing.Point(743, 42)
        Me.btnQuitarParo.Name = "btnQuitarParo"
        Me.btnQuitarParo.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarParo.TabIndex = 119
        Me.btnQuitarParo.UseVisualStyleBackColor = False
        '
        'btnAgregarParo
        '
        Me.btnAgregarParo.BackColor = System.Drawing.Color.White
        Me.btnAgregarParo.BackgroundImage = CType(resources.GetObject("btnAgregarParo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarParo.Enabled = False
        Me.btnAgregarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarParo.Location = New System.Drawing.Point(671, 42)
        Me.btnAgregarParo.Name = "btnAgregarParo"
        Me.btnAgregarParo.Size = New System.Drawing.Size(66, 59)
        Me.btnAgregarParo.TabIndex = 118
        Me.btnAgregarParo.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(339, 78)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(69, 18)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Detalles:"
        '
        'txtDetallesParo
        '
        Me.txtDetallesParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDetallesParo.Location = New System.Drawing.Point(422, 78)
        Me.txtDetallesParo.Multiline = True
        Me.txtDetallesParo.Name = "txtDetallesParo"
        Me.txtDetallesParo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesParo.Size = New System.Drawing.Size(211, 75)
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
        Me.cbxMaquina.Location = New System.Drawing.Point(99, 21)
        Me.cbxMaquina.Name = "cbxMaquina"
        Me.cbxMaquina.Size = New System.Drawing.Size(222, 26)
        Me.cbxMaquina.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 21)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Maquina:"
        '
        'tabPageRechazos
        '
        Me.tabPageRechazos.Controls.Add(Me.grp5s)
        Me.tabPageRechazos.Controls.Add(Me.grpRechazos)
        Me.tabPageRechazos.Location = New System.Drawing.Point(4, 27)
        Me.tabPageRechazos.Name = "tabPageRechazos"
        Me.tabPageRechazos.Size = New System.Drawing.Size(1222, 431)
        Me.tabPageRechazos.TabIndex = 2
        Me.tabPageRechazos.Text = "Rechazos / 5'S"
        Me.tabPageRechazos.UseVisualStyleBackColor = True
        '
        'grp5s
        '
        Me.grp5s.Controls.Add(Me.txtPromedio)
        Me.grp5s.Controls.Add(Me.Label68)
        Me.grp5s.Controls.Add(Me.txtManttoAutonomo)
        Me.grp5s.Controls.Add(Me.Label69)
        Me.grp5s.Controls.Add(Me.txt5s)
        Me.grp5s.Controls.Add(Me.txtAdmonVisual)
        Me.grp5s.Controls.Add(Me.Label70)
        Me.grp5s.Controls.Add(Me.Label71)
        Me.grp5s.Location = New System.Drawing.Point(640, 12)
        Me.grp5s.Name = "grp5s"
        Me.grp5s.Size = New System.Drawing.Size(511, 358)
        Me.grp5s.TabIndex = 337
        Me.grp5s.TabStop = False
        Me.grp5s.Text = "5'S"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(190, 184)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.ReadOnly = True
        Me.txtPromedio.Size = New System.Drawing.Size(100, 26)
        Me.txtPromedio.TabIndex = 160
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(103, 187)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(73, 18)
        Me.Label68.TabIndex = 159
        Me.Label68.Text = "Promedio:"
        '
        'txtManttoAutonomo
        '
        Me.txtManttoAutonomo.Location = New System.Drawing.Point(190, 137)
        Me.txtManttoAutonomo.Name = "txtManttoAutonomo"
        Me.txtManttoAutonomo.Size = New System.Drawing.Size(100, 26)
        Me.txtManttoAutonomo.TabIndex = 157
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(47, 140)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(137, 18)
        Me.Label69.TabIndex = 158
        Me.Label69.Text = "Mantto. Autónomo:"
        '
        'txt5s
        '
        Me.txt5s.Location = New System.Drawing.Point(190, 91)
        Me.txt5s.Name = "txt5s"
        Me.txt5s.Size = New System.Drawing.Size(100, 26)
        Me.txt5s.TabIndex = 156
        '
        'txtAdmonVisual
        '
        Me.txtAdmonVisual.Location = New System.Drawing.Point(190, 45)
        Me.txtAdmonVisual.Name = "txtAdmonVisual"
        Me.txtAdmonVisual.Size = New System.Drawing.Size(100, 26)
        Me.txtAdmonVisual.TabIndex = 154
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(25, 51)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(159, 18)
        Me.Label70.TabIndex = 155
        Me.Label70.Text = "Administración visual:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(151, 94)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(33, 18)
        Me.Label71.TabIndex = 153
        Me.Label71.Text = "5 s:"
        '
        'grpRechazos
        '
        Me.grpRechazos.Controls.Add(Me.grdDetalleRechazo)
        Me.grpRechazos.Controls.Add(Me.txtModeloRechazo)
        Me.grpRechazos.Controls.Add(Me.Label2)
        Me.grpRechazos.Controls.Add(Me.cbxTipoRechazo)
        Me.grpRechazos.Controls.Add(Me.Label3)
        Me.grpRechazos.Controls.Add(Me.cbxModeloRechazo)
        Me.grpRechazos.Controls.Add(Me.Label5)
        Me.grpRechazos.Controls.Add(Me.Label7)
        Me.grpRechazos.Controls.Add(Me.Label11)
        Me.grpRechazos.Controls.Add(Me.btnAgregarRechazo)
        Me.grpRechazos.Controls.Add(Me.btnQuitarRechazo)
        Me.grpRechazos.Controls.Add(Me.Label12)
        Me.grpRechazos.Controls.Add(Me.Label16)
        Me.grpRechazos.Controls.Add(Me.txtRechazoMotivo)
        Me.grpRechazos.Controls.Add(Me.txtRechazosCantidad)
        Me.grpRechazos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRechazos.Location = New System.Drawing.Point(3, 3)
        Me.grpRechazos.Name = "grpRechazos"
        Me.grpRechazos.Size = New System.Drawing.Size(631, 414)
        Me.grpRechazos.TabIndex = 0
        Me.grpRechazos.TabStop = False
        Me.grpRechazos.Text = "Rechazos"
        '
        'grdDetalleRechazo
        '
        Me.grdDetalleRechazo.AllowUserToAddRows = False
        Me.grdDetalleRechazo.AllowUserToDeleteRows = False
        Me.grdDetalleRechazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleRechazo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_rechazo, Me.col_np_gkn, Me.col_descripcion, Me.colcantidad, Me.coltipo_rechazo, Me.colmotivo})
        Me.grdDetalleRechazo.Location = New System.Drawing.Point(10, 234)
        Me.grdDetalleRechazo.Name = "grdDetalleRechazo"
        Me.grdDetalleRechazo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleRechazo.Size = New System.Drawing.Size(609, 174)
        Me.grdDetalleRechazo.TabIndex = 337
        '
        'colcve_rechazo
        '
        Me.colcve_rechazo.DataPropertyName = "cve_rechazo"
        Me.colcve_rechazo.HeaderText = "cve_rechazo"
        Me.colcve_rechazo.Name = "colcve_rechazo"
        Me.colcve_rechazo.ReadOnly = True
        '
        'col_np_gkn
        '
        Me.col_np_gkn.DataPropertyName = "np_gkn"
        Me.col_np_gkn.HeaderText = "No. Parte GKN"
        Me.col_np_gkn.Name = "col_np_gkn"
        Me.col_np_gkn.ReadOnly = True
        '
        'col_descripcion
        '
        Me.col_descripcion.DataPropertyName = "descripcion"
        Me.col_descripcion.HeaderText = "Modelo"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        '
        'colcantidad
        '
        Me.colcantidad.DataPropertyName = "cantidad"
        Me.colcantidad.HeaderText = "Cantidad"
        Me.colcantidad.Name = "colcantidad"
        Me.colcantidad.ReadOnly = True
        '
        'coltipo_rechazo
        '
        Me.coltipo_rechazo.DataPropertyName = "tipo"
        Me.coltipo_rechazo.HeaderText = "Rechazo"
        Me.coltipo_rechazo.Name = "coltipo_rechazo"
        Me.coltipo_rechazo.ReadOnly = True
        '
        'colmotivo
        '
        Me.colmotivo.DataPropertyName = "motivo"
        Me.colmotivo.HeaderText = "motivo"
        Me.colmotivo.Name = "colmotivo"
        Me.colmotivo.ReadOnly = True
        '
        'txtModeloRechazo
        '
        Me.txtModeloRechazo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloRechazo.Location = New System.Drawing.Point(113, 64)
        Me.txtModeloRechazo.Name = "txtModeloRechazo"
        Me.txtModeloRechazo.ReadOnly = True
        Me.txtModeloRechazo.Size = New System.Drawing.Size(198, 26)
        Me.txtModeloRechazo.TabIndex = 336
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 335
        Me.Label2.Text = "Descripcion"
        '
        'cbxTipoRechazo
        '
        Me.cbxTipoRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoRechazo.FormattingEnabled = True
        Me.cbxTipoRechazo.Location = New System.Drawing.Point(421, 65)
        Me.cbxTipoRechazo.Name = "cbxTipoRechazo"
        Me.cbxTipoRechazo.Size = New System.Drawing.Size(198, 26)
        Me.cbxTipoRechazo.TabIndex = 334
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(373, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Tipo"
        '
        'cbxModeloRechazo
        '
        Me.cbxModeloRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloRechazo.FormattingEnabled = True
        Me.cbxModeloRechazo.Location = New System.Drawing.Point(113, 25)
        Me.cbxModeloRechazo.Name = "cbxModeloRechazo"
        Me.cbxModeloRechazo.Size = New System.Drawing.Size(198, 26)
        Me.cbxModeloRechazo.TabIndex = 331
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 330
        Me.Label5.Text = "Motivo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(561, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 329
        Me.Label7.Text = "Quitar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(476, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 328
        Me.Label11.Text = "Agregar"
        '
        'btnAgregarRechazo
        '
        Me.btnAgregarRechazo.BackColor = System.Drawing.Color.White
        Me.btnAgregarRechazo.BackgroundImage = CType(resources.GetObject("btnAgregarRechazo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRechazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarRechazo.Enabled = False
        Me.btnAgregarRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRechazo.Location = New System.Drawing.Point(478, 131)
        Me.btnAgregarRechazo.Name = "btnAgregarRechazo"
        Me.btnAgregarRechazo.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarRechazo.TabIndex = 326
        Me.btnAgregarRechazo.UseVisualStyleBackColor = False
        '
        'btnQuitarRechazo
        '
        Me.btnQuitarRechazo.BackColor = System.Drawing.Color.White
        Me.btnQuitarRechazo.BackgroundImage = CType(resources.GetObject("btnQuitarRechazo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarRechazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarRechazo.Enabled = False
        Me.btnQuitarRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarRechazo.Location = New System.Drawing.Point(555, 131)
        Me.btnQuitarRechazo.Name = "btnQuitarRechazo"
        Me.btnQuitarRechazo.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarRechazo.TabIndex = 327
        Me.btnQuitarRechazo.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(43, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 18)
        Me.Label12.TabIndex = 325
        Me.Label12.Text = "Modelo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 324
        Me.Label16.Text = "Cantidad"
        '
        'txtRechazoMotivo
        '
        Me.txtRechazoMotivo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRechazoMotivo.Location = New System.Drawing.Point(10, 131)
        Me.txtRechazoMotivo.Multiline = True
        Me.txtRechazoMotivo.Name = "txtRechazoMotivo"
        Me.txtRechazoMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRechazoMotivo.Size = New System.Drawing.Size(301, 78)
        Me.txtRechazoMotivo.TabIndex = 323
        '
        'txtRechazosCantidad
        '
        Me.txtRechazosCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtRechazosCantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRechazosCantidad.Location = New System.Drawing.Point(421, 25)
        Me.txtRechazosCantidad.Name = "txtRechazosCantidad"
        Me.txtRechazosCantidad.Size = New System.Drawing.Size(198, 26)
        Me.txtRechazosCantidad.TabIndex = 322
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpAccidentes)
        Me.TabPage1.Controls.Add(Me.grpCondInseg)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1222, 431)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Seguridad"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpAccidentes
        '
        Me.grpAccidentes.Controls.Add(Me.grdDetalleAccidente)
        Me.grpAccidentes.Controls.Add(Me.btnQuitarAccidente)
        Me.grpAccidentes.Controls.Add(Me.btnAgregarAccidente)
        Me.grpAccidentes.Controls.Add(Me.Label63)
        Me.grpAccidentes.Controls.Add(Me.Label64)
        Me.grpAccidentes.Controls.Add(Me.txtDetallesAccidentes)
        Me.grpAccidentes.Controls.Add(Me.Label65)
        Me.grpAccidentes.Controls.Add(Me.txtAccidenteCantidad)
        Me.grpAccidentes.Controls.Add(Me.cbxTipoAccidente)
        Me.grpAccidentes.Controls.Add(Me.Label66)
        Me.grpAccidentes.Controls.Add(Me.Label67)
        Me.grpAccidentes.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccidentes.Location = New System.Drawing.Point(612, 6)
        Me.grpAccidentes.Name = "grpAccidentes"
        Me.grpAccidentes.Size = New System.Drawing.Size(600, 419)
        Me.grpAccidentes.TabIndex = 1
        Me.grpAccidentes.TabStop = False
        Me.grpAccidentes.Text = "Accidentes"
        '
        'grdDetalleAccidente
        '
        Me.grdDetalleAccidente.AllowUserToAddRows = False
        Me.grdDetalleAccidente.AllowUserToDeleteRows = False
        Me.grdDetalleAccidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleAccidente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_seguridad, Me.col_descripcion_, Me.Cantidad, Me.col_comentarios_})
        Me.grdDetalleAccidente.Location = New System.Drawing.Point(6, 242)
        Me.grdDetalleAccidente.Name = "grdDetalleAccidente"
        Me.grdDetalleAccidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleAccidente.Size = New System.Drawing.Size(588, 171)
        Me.grdDetalleAccidente.TabIndex = 348
        '
        'col_cve_seguridad
        '
        Me.col_cve_seguridad.DataPropertyName = "cve_seguridad"
        Me.col_cve_seguridad.HeaderText = "cve_seguridad"
        Me.col_cve_seguridad.Name = "col_cve_seguridad"
        Me.col_cve_seguridad.ReadOnly = True
        '
        'col_descripcion_
        '
        Me.col_descripcion_.DataPropertyName = "descripcion"
        Me.col_descripcion_.HeaderText = "Descripcion"
        Me.col_descripcion_.Name = "col_descripcion_"
        Me.col_descripcion_.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'col_comentarios_
        '
        Me.col_comentarios_.DataPropertyName = "comentarios"
        Me.col_comentarios_.HeaderText = "Comentarios"
        Me.col_comentarios_.Name = "col_comentarios_"
        Me.col_comentarios_.ReadOnly = True
        '
        'btnQuitarAccidente
        '
        Me.btnQuitarAccidente.BackColor = System.Drawing.Color.White
        Me.btnQuitarAccidente.BackgroundImage = CType(resources.GetObject("btnQuitarAccidente.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarAccidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarAccidente.Enabled = False
        Me.btnQuitarAccidente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarAccidente.Location = New System.Drawing.Point(521, 22)
        Me.btnQuitarAccidente.Name = "btnQuitarAccidente"
        Me.btnQuitarAccidente.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarAccidente.TabIndex = 342
        Me.btnQuitarAccidente.UseVisualStyleBackColor = False
        '
        'btnAgregarAccidente
        '
        Me.btnAgregarAccidente.BackColor = System.Drawing.Color.White
        Me.btnAgregarAccidente.BackgroundImage = CType(resources.GetObject("btnAgregarAccidente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarAccidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarAccidente.Enabled = False
        Me.btnAgregarAccidente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAccidente.Location = New System.Drawing.Point(444, 22)
        Me.btnAgregarAccidente.Name = "btnAgregarAccidente"
        Me.btnAgregarAccidente.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarAccidente.TabIndex = 341
        Me.btnAgregarAccidente.UseVisualStyleBackColor = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(10, 147)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(69, 18)
        Me.Label63.TabIndex = 346
        Me.Label63.Text = "Detalles:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(527, 84)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(50, 18)
        Me.Label64.TabIndex = 344
        Me.Label64.Text = "Quitar"
        '
        'txtDetallesAccidentes
        '
        Me.txtDetallesAccidentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDetallesAccidentes.Location = New System.Drawing.Point(93, 144)
        Me.txtDetallesAccidentes.Multiline = True
        Me.txtDetallesAccidentes.Name = "txtDetallesAccidentes"
        Me.txtDetallesAccidentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesAccidentes.Size = New System.Drawing.Size(348, 75)
        Me.txtDetallesAccidentes.TabIndex = 345
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(442, 84)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(65, 18)
        Me.Label65.TabIndex = 343
        Me.Label65.Text = "Agregar"
        '
        'txtAccidenteCantidad
        '
        Me.txtAccidenteCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAccidenteCantidad.Location = New System.Drawing.Point(93, 93)
        Me.txtAccidenteCantidad.Name = "txtAccidenteCantidad"
        Me.txtAccidenteCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtAccidenteCantidad.TabIndex = 340
        '
        'cbxTipoAccidente
        '
        Me.cbxTipoAccidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoAccidente.FormattingEnabled = True
        Me.cbxTipoAccidente.Location = New System.Drawing.Point(93, 44)
        Me.cbxTipoAccidente.Name = "cbxTipoAccidente"
        Me.cbxTipoAccidente.Size = New System.Drawing.Size(181, 29)
        Me.cbxTipoAccidente.TabIndex = 339
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(11, 96)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(76, 18)
        Me.Label66.TabIndex = 338
        Me.Label66.Text = "Cantidad:"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(45, 47)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(42, 18)
        Me.Label67.TabIndex = 337
        Me.Label67.Text = "Tipo:"
        '
        'grpCondInseg
        '
        Me.grpCondInseg.Controls.Add(Me.grdDetalleCondInseg)
        Me.grpCondInseg.Controls.Add(Me.btnQuitarCondInseg)
        Me.grpCondInseg.Controls.Add(Me.btnAgregarCondInseg)
        Me.grpCondInseg.Controls.Add(Me.Label20)
        Me.grpCondInseg.Controls.Add(Me.Label22)
        Me.grpCondInseg.Controls.Add(Me.txtDetallesCondInseg)
        Me.grpCondInseg.Controls.Add(Me.Label27)
        Me.grpCondInseg.Controls.Add(Me.txtCondInsegCantidad)
        Me.grpCondInseg.Controls.Add(Me.cbxTipoCondInseg)
        Me.grpCondInseg.Controls.Add(Me.Label30)
        Me.grpCondInseg.Controls.Add(Me.Label62)
        Me.grpCondInseg.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondInseg.Location = New System.Drawing.Point(6, 6)
        Me.grpCondInseg.Name = "grpCondInseg"
        Me.grpCondInseg.Size = New System.Drawing.Size(600, 419)
        Me.grpCondInseg.TabIndex = 0
        Me.grpCondInseg.TabStop = False
        Me.grpCondInseg.Text = "Condiciones Inseguras"
        '
        'grdDetalleCondInseg
        '
        Me.grdDetalleCondInseg.AllowUserToAddRows = False
        Me.grdDetalleCondInseg.AllowUserToDeleteRows = False
        Me.grdDetalleCondInseg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleCondInseg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_seguridad, Me.coldescripciondetalle, Me.colcantidaddetalle, Me.colcomentarios})
        Me.grdDetalleCondInseg.Location = New System.Drawing.Point(6, 242)
        Me.grdDetalleCondInseg.Name = "grdDetalleCondInseg"
        Me.grdDetalleCondInseg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleCondInseg.Size = New System.Drawing.Size(588, 171)
        Me.grdDetalleCondInseg.TabIndex = 347
        '
        'colcve_seguridad
        '
        Me.colcve_seguridad.DataPropertyName = "cve_seguridad"
        Me.colcve_seguridad.HeaderText = "cve_seguridad"
        Me.colcve_seguridad.Name = "colcve_seguridad"
        Me.colcve_seguridad.ReadOnly = True
        '
        'coldescripciondetalle
        '
        Me.coldescripciondetalle.DataPropertyName = "descripcion"
        Me.coldescripciondetalle.HeaderText = "Descripcion"
        Me.coldescripciondetalle.Name = "coldescripciondetalle"
        Me.coldescripciondetalle.ReadOnly = True
        '
        'colcantidaddetalle
        '
        Me.colcantidaddetalle.DataPropertyName = "cantidad"
        Me.colcantidaddetalle.HeaderText = "Cantidad"
        Me.colcantidaddetalle.Name = "colcantidaddetalle"
        Me.colcantidaddetalle.ReadOnly = True
        '
        'colcomentarios
        '
        Me.colcomentarios.DataPropertyName = "comentarios"
        Me.colcomentarios.HeaderText = "Comentarios"
        Me.colcomentarios.Name = "colcomentarios"
        Me.colcomentarios.ReadOnly = True
        '
        'btnQuitarCondInseg
        '
        Me.btnQuitarCondInseg.BackColor = System.Drawing.Color.White
        Me.btnQuitarCondInseg.BackgroundImage = CType(resources.GetObject("btnQuitarCondInseg.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarCondInseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarCondInseg.Enabled = False
        Me.btnQuitarCondInseg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarCondInseg.Location = New System.Drawing.Point(524, 23)
        Me.btnQuitarCondInseg.Name = "btnQuitarCondInseg"
        Me.btnQuitarCondInseg.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarCondInseg.TabIndex = 342
        Me.btnQuitarCondInseg.UseVisualStyleBackColor = False
        '
        'btnAgregarCondInseg
        '
        Me.btnAgregarCondInseg.BackColor = System.Drawing.Color.White
        Me.btnAgregarCondInseg.BackgroundImage = CType(resources.GetObject("btnAgregarCondInseg.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCondInseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCondInseg.Enabled = False
        Me.btnAgregarCondInseg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCondInseg.Location = New System.Drawing.Point(447, 23)
        Me.btnAgregarCondInseg.Name = "btnAgregarCondInseg"
        Me.btnAgregarCondInseg.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarCondInseg.TabIndex = 341
        Me.btnAgregarCondInseg.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 18)
        Me.Label20.TabIndex = 346
        Me.Label20.Text = "Detalles:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(530, 85)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 18)
        Me.Label22.TabIndex = 344
        Me.Label22.Text = "Quitar"
        '
        'txtDetallesCondInseg
        '
        Me.txtDetallesCondInseg.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDetallesCondInseg.Location = New System.Drawing.Point(96, 145)
        Me.txtDetallesCondInseg.Multiline = True
        Me.txtDetallesCondInseg.Name = "txtDetallesCondInseg"
        Me.txtDetallesCondInseg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesCondInseg.Size = New System.Drawing.Size(348, 75)
        Me.txtDetallesCondInseg.TabIndex = 345
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(445, 85)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 18)
        Me.Label27.TabIndex = 343
        Me.Label27.Text = "Agregar"
        '
        'txtCondInsegCantidad
        '
        Me.txtCondInsegCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtCondInsegCantidad.Location = New System.Drawing.Point(96, 94)
        Me.txtCondInsegCantidad.Name = "txtCondInsegCantidad"
        Me.txtCondInsegCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtCondInsegCantidad.TabIndex = 340
        '
        'cbxTipoCondInseg
        '
        Me.cbxTipoCondInseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCondInseg.FormattingEnabled = True
        Me.cbxTipoCondInseg.Location = New System.Drawing.Point(96, 45)
        Me.cbxTipoCondInseg.Name = "cbxTipoCondInseg"
        Me.cbxTipoCondInseg.Size = New System.Drawing.Size(181, 29)
        Me.cbxTipoCondInseg.TabIndex = 339
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(14, 97)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 18)
        Me.Label30.TabIndex = 338
        Me.Label30.Text = "Cantidad:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(48, 48)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(42, 18)
        Me.Label62.TabIndex = 337
        Me.Label62.Text = "Tipo:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpGente)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1222, 431)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Gente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpGente
        '
        Me.grpGente.Controls.Add(Me.grdDetalleGente)
        Me.grpGente.Controls.Add(Me.btnQuitarGente)
        Me.grpGente.Controls.Add(Me.btnAgregarGente)
        Me.grpGente.Controls.Add(Me.Label61)
        Me.grpGente.Controls.Add(Me.Label33)
        Me.grpGente.Controls.Add(Me.txtDetallesGente)
        Me.grpGente.Controls.Add(Me.Label45)
        Me.grpGente.Controls.Add(Me.txtGenteCantidad)
        Me.grpGente.Controls.Add(Me.cbxTipoDetalleGente)
        Me.grpGente.Controls.Add(Me.Label50)
        Me.grpGente.Controls.Add(Me.Label55)
        Me.grpGente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGente.Location = New System.Drawing.Point(6, 6)
        Me.grpGente.Name = "grpGente"
        Me.grpGente.Size = New System.Drawing.Size(615, 408)
        Me.grpGente.TabIndex = 335
        Me.grpGente.TabStop = False
        Me.grpGente.Text = "Gente"
        '
        'grdDetalleGente
        '
        Me.grdDetalleGente.AllowUserToAddRows = False
        Me.grdDetalleGente.AllowUserToDeleteRows = False
        Me.grdDetalleGente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleGente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_gente, Me.colgdescripcion, Me.colgcantidad, Me.comentarios})
        Me.grdDetalleGente.Location = New System.Drawing.Point(14, 242)
        Me.grdDetalleGente.Name = "grdDetalleGente"
        Me.grdDetalleGente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleGente.Size = New System.Drawing.Size(580, 150)
        Me.grdDetalleGente.TabIndex = 337
        '
        'colcve_gente
        '
        Me.colcve_gente.DataPropertyName = "cve_gente"
        Me.colcve_gente.HeaderText = "cve_gente"
        Me.colcve_gente.Name = "colcve_gente"
        '
        'colgdescripcion
        '
        Me.colgdescripcion.DataPropertyName = "descripcion"
        Me.colgdescripcion.HeaderText = "descripcion"
        Me.colgdescripcion.Name = "colgdescripcion"
        Me.colgdescripcion.ReadOnly = True
        '
        'colgcantidad
        '
        Me.colgcantidad.DataPropertyName = "cantidad"
        Me.colgcantidad.HeaderText = "cantidad"
        Me.colgcantidad.Name = "colgcantidad"
        Me.colgcantidad.ReadOnly = True
        '
        'comentarios
        '
        Me.comentarios.DataPropertyName = "comentarios"
        Me.comentarios.HeaderText = "comentarios"
        Me.comentarios.Name = "comentarios"
        Me.comentarios.ReadOnly = True
        '
        'btnQuitarGente
        '
        Me.btnQuitarGente.BackColor = System.Drawing.Color.White
        Me.btnQuitarGente.BackgroundImage = CType(resources.GetObject("btnQuitarGente.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarGente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarGente.Enabled = False
        Me.btnQuitarGente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarGente.Location = New System.Drawing.Point(530, 25)
        Me.btnQuitarGente.Name = "btnQuitarGente"
        Me.btnQuitarGente.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarGente.TabIndex = 331
        Me.btnQuitarGente.UseVisualStyleBackColor = False
        '
        'btnAgregarGente
        '
        Me.btnAgregarGente.BackColor = System.Drawing.Color.White
        Me.btnAgregarGente.BackgroundImage = CType(resources.GetObject("btnAgregarGente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarGente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarGente.Enabled = False
        Me.btnAgregarGente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGente.Location = New System.Drawing.Point(453, 25)
        Me.btnAgregarGente.Name = "btnAgregarGente"
        Me.btnAgregarGente.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarGente.TabIndex = 330
        Me.btnAgregarGente.UseVisualStyleBackColor = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(19, 150)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(69, 18)
        Me.Label61.TabIndex = 336
        Me.Label61.Text = "Detalles:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(536, 87)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(50, 18)
        Me.Label33.TabIndex = 333
        Me.Label33.Text = "Quitar"
        '
        'txtDetallesGente
        '
        Me.txtDetallesGente.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDetallesGente.Location = New System.Drawing.Point(102, 147)
        Me.txtDetallesGente.Multiline = True
        Me.txtDetallesGente.Name = "txtDetallesGente"
        Me.txtDetallesGente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesGente.Size = New System.Drawing.Size(348, 75)
        Me.txtDetallesGente.TabIndex = 335
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(451, 87)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(65, 18)
        Me.Label45.TabIndex = 332
        Me.Label45.Text = "Agregar"
        '
        'txtGenteCantidad
        '
        Me.txtGenteCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtGenteCantidad.Location = New System.Drawing.Point(102, 96)
        Me.txtGenteCantidad.Name = "txtGenteCantidad"
        Me.txtGenteCantidad.Size = New System.Drawing.Size(181, 26)
        Me.txtGenteCantidad.TabIndex = 153
        '
        'cbxTipoDetalleGente
        '
        Me.cbxTipoDetalleGente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDetalleGente.FormattingEnabled = True
        Me.cbxTipoDetalleGente.Location = New System.Drawing.Point(102, 47)
        Me.cbxTipoDetalleGente.Name = "cbxTipoDetalleGente"
        Me.cbxTipoDetalleGente.Size = New System.Drawing.Size(181, 26)
        Me.cbxTipoDetalleGente.TabIndex = 152
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(20, 99)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 18)
        Me.Label50.TabIndex = 151
        Me.Label50.Text = "Cantidad:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(54, 50)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(42, 18)
        Me.Label55.TabIndex = 8
        Me.Label55.Text = "Tipo:"
        '
        'Turnos_Lineas
        '
        Me.Turnos_Lineas.Controls.Add(Me.cbxTurnosLineas)
        Me.Turnos_Lineas.Controls.Add(Me.Label76)
        Me.Turnos_Lineas.Controls.Add(Me.Label75)
        Me.Turnos_Lineas.Controls.Add(Me.Label74)
        Me.Turnos_Lineas.Controls.Add(Me.Label73)
        Me.Turnos_Lineas.Controls.Add(Me.btnLineaUnica)
        Me.Turnos_Lineas.Controls.Add(Me.btnLineasTodas)
        Me.Turnos_Lineas.Controls.Add(Me.Label72)
        Me.Turnos_Lineas.Controls.Add(Me.grdLineasRegistradas)
        Me.Turnos_Lineas.Controls.Add(Me.grdLineasNoRegistradas)
        Me.Turnos_Lineas.Location = New System.Drawing.Point(4, 27)
        Me.Turnos_Lineas.Name = "Turnos_Lineas"
        Me.Turnos_Lineas.Padding = New System.Windows.Forms.Padding(3)
        Me.Turnos_Lineas.Size = New System.Drawing.Size(1222, 431)
        Me.Turnos_Lineas.TabIndex = 5
        Me.Turnos_Lineas.Text = "Turnos/lineas"
        Me.Turnos_Lineas.UseVisualStyleBackColor = True
        '
        'cbxTurnosLineas
        '
        Me.cbxTurnosLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurnosLineas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurnosLineas.FormattingEnabled = True
        Me.cbxTurnosLineas.Location = New System.Drawing.Point(497, 114)
        Me.cbxTurnosLineas.Name = "cbxTurnosLineas"
        Me.cbxTurnosLineas.Size = New System.Drawing.Size(234, 26)
        Me.cbxTurnosLineas.TabIndex = 311
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(754, 41)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(106, 18)
        Me.Label76.TabIndex = 318
        Me.Label76.Text = "Lineas - Turno"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(14, 41)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(142, 18)
        Me.Label75.TabIndex = 317
        Me.Label75.Text = "Lineas Disponibles"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(584, 354)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(72, 18)
        Me.Label74.TabIndex = 316
        Me.Label74.Text = "Registrar"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(558, 226)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(118, 18)
        Me.Label73.TabIndex = 315
        Me.Label73.Text = "Registrar Todas"
        '
        'btnLineaUnica
        '
        Me.btnLineaUnica.Location = New System.Drawing.Point(518, 311)
        Me.btnLineaUnica.Name = "btnLineaUnica"
        Me.btnLineaUnica.Size = New System.Drawing.Size(189, 40)
        Me.btnLineaUnica.TabIndex = 314
        Me.btnLineaUnica.Text = ">"
        Me.btnLineaUnica.UseVisualStyleBackColor = True
        '
        'btnLineasTodas
        '
        Me.btnLineasTodas.Location = New System.Drawing.Point(518, 183)
        Me.btnLineasTodas.Name = "btnLineasTodas"
        Me.btnLineasTodas.Size = New System.Drawing.Size(189, 40)
        Me.btnLineasTodas.TabIndex = 313
        Me.btnLineasTodas.Text = ">>"
        Me.btnLineasTodas.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(494, 93)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(50, 18)
        Me.Label72.TabIndex = 312
        Me.Label72.Text = "Turno:"
        '
        'grdLineasRegistradas
        '
        Me.grdLineasRegistradas.AllowUserToAddRows = False
        Me.grdLineasRegistradas.AllowUserToDeleteRows = False
        Me.grdLineasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLineasRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_registro_turno, Me.col_linea, Me.col_turno, Me.col_dia_asignado})
        Me.grdLineasRegistradas.Location = New System.Drawing.Point(757, 62)
        Me.grdLineasRegistradas.Name = "grdLineasRegistradas"
        Me.grdLineasRegistradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLineasRegistradas.Size = New System.Drawing.Size(447, 334)
        Me.grdLineasRegistradas.TabIndex = 1
        '
        'col_cve_registro_turno
        '
        Me.col_cve_registro_turno.DataPropertyName = "cve_registro_turno"
        Me.col_cve_registro_turno.HeaderText = "cve_registro_turno"
        Me.col_cve_registro_turno.Name = "col_cve_registro_turno"
        Me.col_cve_registro_turno.ReadOnly = True
        '
        'col_linea
        '
        Me.col_linea.DataPropertyName = "linea"
        Me.col_linea.HeaderText = "linea"
        Me.col_linea.Name = "col_linea"
        Me.col_linea.ReadOnly = True
        '
        'col_turno
        '
        Me.col_turno.DataPropertyName = "turno"
        Me.col_turno.HeaderText = "Turno"
        Me.col_turno.Name = "col_turno"
        Me.col_turno.ReadOnly = True
        '
        'col_dia_asignado
        '
        Me.col_dia_asignado.DataPropertyName = "dia_asignado"
        Me.col_dia_asignado.HeaderText = "Dia Registro"
        Me.col_dia_asignado.Name = "col_dia_asignado"
        Me.col_dia_asignado.ReadOnly = True
        Me.col_dia_asignado.Width = 200
        '
        'grdLineasNoRegistradas
        '
        Me.grdLineasNoRegistradas.AllowUserToAddRows = False
        Me.grdLineasNoRegistradas.AllowUserToDeleteRows = False
        Me.grdLineasNoRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLineasNoRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_linea, Me.collinea})
        Me.grdLineasNoRegistradas.Location = New System.Drawing.Point(17, 62)
        Me.grdLineasNoRegistradas.Name = "grdLineasNoRegistradas"
        Me.grdLineasNoRegistradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLineasNoRegistradas.Size = New System.Drawing.Size(447, 334)
        Me.grdLineasNoRegistradas.TabIndex = 0
        '
        'col_cve_linea
        '
        Me.col_cve_linea.DataPropertyName = "cve_linea"
        Me.col_cve_linea.HeaderText = "cve_linea"
        Me.col_cve_linea.Name = "col_cve_linea"
        Me.col_cve_linea.ReadOnly = True
        '
        'collinea
        '
        Me.collinea.DataPropertyName = "linea"
        Me.collinea.HeaderText = "linea"
        Me.collinea.Name = "collinea"
        Me.collinea.ReadOnly = True
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
        Me.PictureBox1.Location = New System.Drawing.Point(976, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 172)
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.Enabled = False
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
        Me.Label58.Location = New System.Drawing.Point(8, 184)
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
        Me.cbxLinea.Location = New System.Drawing.Point(65, 181)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(234, 26)
        Me.cbxLinea.TabIndex = 309
        '
        'grpCalidad
        '
        Me.grpCalidad.Controls.Add(Me.Label77)
        Me.grpCalidad.Controls.Add(Me.lblNRFTi)
        Me.grpCalidad.Controls.Add(Me.Label78)
        Me.grpCalidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCalidad.Location = New System.Drawing.Point(848, 177)
        Me.grpCalidad.Name = "grpCalidad"
        Me.grpCalidad.Size = New System.Drawing.Size(368, 237)
        Me.grpCalidad.TabIndex = 17
        Me.grpCalidad.TabStop = False
        Me.grpCalidad.Text = "3.-CALIDAD"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(210, 53)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(59, 19)
        Me.Label77.TabIndex = 14
        Me.Label77.Text = "PPM'S"
        '
        'lblNRFTi
        '
        Me.lblNRFTi.AutoSize = True
        Me.lblNRFTi.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRFTi.Location = New System.Drawing.Point(94, 50)
        Me.lblNRFTi.Name = "lblNRFTi"
        Me.lblNRFTi.Size = New System.Drawing.Size(22, 24)
        Me.lblNRFTi.TabIndex = 13
        Me.lblNRFTi.Text = "0"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(27, 53)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(57, 19)
        Me.Label78.TabIndex = 12
        Me.Label78.Text = "NRFTi"
        '
        'lblFechaRegistro
        '
        Me.lblFechaRegistro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegistro.Location = New System.Drawing.Point(440, 184)
        Me.lblFechaRegistro.Name = "lblFechaRegistro"
        Me.lblFechaRegistro.Size = New System.Drawing.Size(165, 19)
        Me.lblFechaRegistro.TabIndex = 311
        Me.lblFechaRegistro.Text = "NombreEquipo"
        Me.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaRegistrodescripcion
        '
        Me.lblFechaRegistrodescripcion.AutoSize = True
        Me.lblFechaRegistrodescripcion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegistrodescripcion.Location = New System.Drawing.Point(325, 184)
        Me.lblFechaRegistrodescripcion.Name = "lblFechaRegistrodescripcion"
        Me.lblFechaRegistrodescripcion.Size = New System.Drawing.Size(119, 18)
        Me.lblFechaRegistrodescripcion.TabIndex = 312
        Me.lblFechaRegistrodescripcion.Text = "Fecha Registro:"
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1254, 722)
        Me.Controls.Add(Me.lblFechaRegistrodescripcion)
        Me.Controls.Add(Me.lblFechaRegistro)
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
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 768)
        Me.MinimumSize = New System.Drawing.Size(1270, 736)
        Me.Name = "frmProduccion"
        Me.Text = "frmProduccion"
        Me.TabContenido.ResumeLayout(False)
        Me.tabPageProductividad.ResumeLayout(False)
        Me.grpDesechos.ResumeLayout(False)
        Me.grpDesechos.PerformLayout()
        CType(Me.grdDetalleDesecho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProductividad.ResumeLayout(False)
        Me.grpProductividad.PerformLayout()
        CType(Me.grdDetalleProductividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageParos.ResumeLayout(False)
        Me.grpCosto.ResumeLayout(False)
        Me.grpCosto.PerformLayout()
        Me.grpParos.ResumeLayout(False)
        Me.grpParos.PerformLayout()
        CType(Me.grdDetalleParo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageRechazos.ResumeLayout(False)
        Me.grp5s.ResumeLayout(False)
        Me.grp5s.PerformLayout()
        Me.grpRechazos.ResumeLayout(False)
        Me.grpRechazos.PerformLayout()
        CType(Me.grdDetalleRechazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.grpAccidentes.ResumeLayout(False)
        Me.grpAccidentes.PerformLayout()
        CType(Me.grdDetalleAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondInseg.ResumeLayout(False)
        Me.grpCondInseg.PerformLayout()
        CType(Me.grdDetalleCondInseg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grpGente.ResumeLayout(False)
        Me.grpGente.PerformLayout()
        CType(Me.grdDetalleGente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Turnos_Lineas.ResumeLayout(False)
        Me.Turnos_Lineas.PerformLayout()
        CType(Me.grdLineasRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLineasNoRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCalidad.ResumeLayout(False)
        Me.grpCalidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabContenido As System.Windows.Forms.TabControl
    Friend WithEvents tabPageProductividad As System.Windows.Forms.TabPage
    Friend WithEvents grpDesechos As System.Windows.Forms.GroupBox
    Friend WithEvents cbxModeloDesecho As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtModeloDesecho As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesechosCantidad As System.Windows.Forms.TextBox
    Friend WithEvents grpProductividad As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtPzasPorHora As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtModeloDescripcionProductividad As System.Windows.Forms.TextBox
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
    Friend WithEvents txtTiempoOperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
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
    Friend WithEvents txtPiezasOkProducidas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarModelo As System.Windows.Forms.Button
    Friend WithEvents btnQuitarModelo As System.Windows.Forms.Button
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnQuitarParo As System.Windows.Forms.Button
    Friend WithEvents btnAgregarParo As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesParo As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoParo As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbxMaquina As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tabPageRechazos As System.Windows.Forms.TabPage
    Friend WithEvents grpRechazos As System.Windows.Forms.GroupBox
    Friend WithEvents txtModeloRechazo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoRechazo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxModeloRechazo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarRechazo As System.Windows.Forms.Button
    Friend WithEvents btnQuitarRechazo As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRechazoMotivo As System.Windows.Forms.TextBox
    Friend WithEvents txtRechazosCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpGente As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarGente As System.Windows.Forms.Button
    Friend WithEvents btnQuitarGente As System.Windows.Forms.Button
    Friend WithEvents txtGenteCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoDetalleGente As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
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
    Friend WithEvents grdDetalleProductividad As System.Windows.Forms.DataGridView
    Friend WithEvents colcve_produccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpzas_ok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCapacidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAdeudo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDetalleDesecho As System.Windows.Forms.DataGridView
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarDesecho As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDesecho As System.Windows.Forms.Button
    Friend WithEvents grdDetalleRechazo As System.Windows.Forms.DataGridView
    Friend WithEvents colcve_rechazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_np_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltipo_rechazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_desecho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col__cve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnp_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmodelodescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesechocantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDetalleParo As System.Windows.Forms.DataGridView
    Friend WithEvents colcve_registro_paro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_lineab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_maquina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_paro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcod_paro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colminutos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colclave_maquina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmaquina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldetalles As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesGente As System.Windows.Forms.TextBox
    Friend WithEvents grdDetalleGente As System.Windows.Forms.DataGridView
    Friend WithEvents colcve_gente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colgdescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colgcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpAccidentes As System.Windows.Forms.GroupBox
    Friend WithEvents grpCondInseg As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitarAccidente As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAccidente As System.Windows.Forms.Button
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesAccidentes As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtAccidenteCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoAccidente As System.Windows.Forms.ComboBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents btnQuitarCondInseg As System.Windows.Forms.Button
    Friend WithEvents btnAgregarCondInseg As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesCondInseg As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCondInsegCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbxTipoCondInseg As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents grdDetalleAccidente As System.Windows.Forms.DataGridView
    Friend WithEvents grdDetalleCondInseg As System.Windows.Forms.DataGridView
    Friend WithEvents colcve_seguridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescripciondetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcantidaddetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcomentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_seguridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_comentarios_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grp5s As System.Windows.Forms.GroupBox
    Friend WithEvents txtPromedio As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtManttoAutonomo As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txt5s As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmonVisual As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Turnos_Lineas As System.Windows.Forms.TabPage
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents btnLineaUnica As System.Windows.Forms.Button
    Friend WithEvents btnLineasTodas As System.Windows.Forms.Button
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents grdLineasRegistradas As System.Windows.Forms.DataGridView
    Friend WithEvents grdLineasNoRegistradas As System.Windows.Forms.DataGridView
    Friend WithEvents cbxTurnosLineas As System.Windows.Forms.ComboBox
    Friend WithEvents col_cve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_registro_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_dia_asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpCalidad As System.Windows.Forms.GroupBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents lblNRFTi As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents lblFechaRegistro As System.Windows.Forms.Label
    Friend WithEvents lblFechaRegistrodescripcion As System.Windows.Forms.Label
End Class
