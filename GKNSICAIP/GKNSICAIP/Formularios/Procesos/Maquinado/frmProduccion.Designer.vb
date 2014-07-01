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
        Me.tabPageContenido = New System.Windows.Forms.TabControl()
        Me.tabPageTurnosLineas = New System.Windows.Forms.TabPage()
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
        Me.tabPageProductividad = New System.Windows.Forms.TabPage()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
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
        Me.tabPageRechazos5s = New System.Windows.Forms.TabPage()
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
        Me.grpDesechos = New System.Windows.Forms.GroupBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.lblNRFTi = New System.Windows.Forms.Label()
        Me.txtDetalleDesecho = New System.Windows.Forms.TextBox()
        Me.grdDetalleDesecho = New System.Windows.Forms.DataGridView()
        Me.colcve_desecho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col__cve_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cve_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnp_gkn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmodelodescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesechocantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentarios_desecho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cbxModeloDesecho = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAgregarDesecho = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnQuitarDesecho = New System.Windows.Forms.Button()
        Me.txtModeloDesecho = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesechosCantidad = New System.Windows.Forms.TextBox()
        Me.tabPageCondInsegAccidentes = New System.Windows.Forms.TabPage()
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
        Me.tabPageGente = New System.Windows.Forms.TabPage()
        Me.grp5s = New System.Windows.Forms.GroupBox()
        Me.prom = New System.Windows.Forms.Label()
        Me.lblAlertaCincoS = New System.Windows.Forms.Label()
        Me.txtprom = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtManto = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtcinco_S = New System.Windows.Forms.TextBox()
        Me.txtAdmon = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.btnAgregarCincoS = New System.Windows.Forms.Button()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtManttoAutonomo = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txt5s = New System.Windows.Forms.TextBox()
        Me.txtAdmonVisual = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
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
        Me.tabPageComentarios = New System.Windows.Forms.TabPage()
        Me.grpComentarios = New System.Windows.Forms.GroupBox()
        Me.grdDetalleComentario = New System.Windows.Forms.DataGridView()
        Me.col_cve_comentarios_generales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.txtDetallesComentario = New System.Windows.Forms.TextBox()
        Me.btnQuitarComentario = New System.Windows.Forms.Button()
        Me.btnAgregarComentario = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.tabPageDescansos = New System.Windows.Forms.TabPage()
        Me.btnQuitarDescanso = New System.Windows.Forms.Button()
        Me.btnAgregarDescanso = New System.Windows.Forms.Button()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.grdDetalleDescansos = New System.Windows.Forms.DataGridView()
        Me.col_fecha_descanso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Descanso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.dtpDescanso = New System.Windows.Forms.DateTimePicker()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEquipo = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cbxLinea = New System.Windows.Forms.ComboBox()
        Me.lblFechaRegistro = New System.Windows.Forms.Label()
        Me.lblFechaRegistrodescripcion = New System.Windows.Forms.Label()
        Me.imgEscudo = New System.Windows.Forms.PictureBox()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.cmdGraficar = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnModModificar = New System.Windows.Forms.Button()
        Me.btnModTerminar = New System.Windows.Forms.Button()
        Me.grpModificaciones = New System.Windows.Forms.GroupBox()
        Me.cldrModificaciones = New Telerik.WinControls.UI.RadCalendar()
        Me.tabPageContenido.SuspendLayout()
        Me.tabPageTurnosLineas.SuspendLayout()
        CType(Me.grdLineasRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLineasNoRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageProductividad.SuspendLayout()
        Me.grpProductividad.SuspendLayout()
        CType(Me.grdDetalleProductividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageParos.SuspendLayout()
        Me.grpCosto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpParos.SuspendLayout()
        CType(Me.grdDetalleParo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageRechazos5s.SuspendLayout()
        Me.grpRechazos.SuspendLayout()
        CType(Me.grdDetalleRechazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDesechos.SuspendLayout()
        CType(Me.grdDetalleDesecho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageCondInsegAccidentes.SuspendLayout()
        Me.grpAccidentes.SuspendLayout()
        CType(Me.grdDetalleAccidente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondInseg.SuspendLayout()
        CType(Me.grdDetalleCondInseg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageGente.SuspendLayout()
        Me.grp5s.SuspendLayout()
        Me.grpGente.SuspendLayout()
        CType(Me.grdDetalleGente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageComentarios.SuspendLayout()
        Me.grpComentarios.SuspendLayout()
        CType(Me.grdDetalleComentario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageDescansos.SuspendLayout()
        CType(Me.grdDetalleDescansos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEscudo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpModificaciones.SuspendLayout()
        CType(Me.cldrModificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPageContenido
        '
        Me.tabPageContenido.Controls.Add(Me.tabPageTurnosLineas)
        Me.tabPageContenido.Controls.Add(Me.tabPageProductividad)
        Me.tabPageContenido.Controls.Add(Me.tabPageParos)
        Me.tabPageContenido.Controls.Add(Me.tabPageRechazos5s)
        Me.tabPageContenido.Controls.Add(Me.tabPageCondInsegAccidentes)
        Me.tabPageContenido.Controls.Add(Me.tabPageGente)
        Me.tabPageContenido.Controls.Add(Me.tabPageComentarios)
        Me.tabPageContenido.Controls.Add(Me.tabPageDescansos)
        Me.tabPageContenido.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageContenido.Location = New System.Drawing.Point(12, 248)
        Me.tabPageContenido.Name = "tabPageContenido"
        Me.tabPageContenido.SelectedIndex = 0
        Me.tabPageContenido.Size = New System.Drawing.Size(1230, 462)
        Me.tabPageContenido.TabIndex = 0
        Me.tabPageContenido.Tag = ""
        '
        'tabPageTurnosLineas
        '
        Me.tabPageTurnosLineas.Controls.Add(Me.cbxTurnosLineas)
        Me.tabPageTurnosLineas.Controls.Add(Me.Label76)
        Me.tabPageTurnosLineas.Controls.Add(Me.Label75)
        Me.tabPageTurnosLineas.Controls.Add(Me.Label74)
        Me.tabPageTurnosLineas.Controls.Add(Me.Label73)
        Me.tabPageTurnosLineas.Controls.Add(Me.btnLineaUnica)
        Me.tabPageTurnosLineas.Controls.Add(Me.btnLineasTodas)
        Me.tabPageTurnosLineas.Controls.Add(Me.Label72)
        Me.tabPageTurnosLineas.Controls.Add(Me.grdLineasRegistradas)
        Me.tabPageTurnosLineas.Controls.Add(Me.grdLineasNoRegistradas)
        Me.tabPageTurnosLineas.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageTurnosLineas.Location = New System.Drawing.Point(4, 28)
        Me.tabPageTurnosLineas.Name = "tabPageTurnosLineas"
        Me.tabPageTurnosLineas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageTurnosLineas.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageTurnosLineas.TabIndex = 5
        Me.tabPageTurnosLineas.Text = "Turnos - Lineas"
        Me.tabPageTurnosLineas.UseVisualStyleBackColor = True
        '
        'cbxTurnosLineas
        '
        Me.cbxTurnosLineas.BackColor = System.Drawing.Color.White
        Me.cbxTurnosLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurnosLineas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurnosLineas.FormattingEnabled = True
        Me.cbxTurnosLineas.Location = New System.Drawing.Point(458, 101)
        Me.cbxTurnosLineas.Name = "cbxTurnosLineas"
        Me.cbxTurnosLineas.Size = New System.Drawing.Size(234, 26)
        Me.cbxTurnosLineas.TabIndex = 102
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(733, 38)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(223, 21)
        Me.Label76.TabIndex = 0
        Me.Label76.Text = "Horarios Registrados por Linea"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(13, 38)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(130, 21)
        Me.Label75.TabIndex = 317
        Me.Label75.Text = "Lineas del Equipo"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(482, 363)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(210, 21)
        Me.Label74.TabIndex = 0
        Me.Label74.Text = "Registrar solo para esta linea"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(454, 216)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(245, 21)
        Me.Label73.TabIndex = 0
        Me.Label73.Text = "Registrar Lineas Todas / Restantes"
        '
        'btnLineaUnica
        '
        Me.btnLineaUnica.Image = Global.GKNSICAIP.My.Resources.Resources._next
        Me.btnLineaUnica.Location = New System.Drawing.Point(537, 289)
        Me.btnLineaUnica.Name = "btnLineaUnica"
        Me.btnLineaUnica.Size = New System.Drawing.Size(92, 71)
        Me.btnLineaUnica.TabIndex = 104
        Me.btnLineaUnica.UseVisualStyleBackColor = True
        '
        'btnLineasTodas
        '
        Me.btnLineasTodas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLineasTodas.Image = Global.GKNSICAIP.My.Resources.Resources.next_next
        Me.btnLineasTodas.Location = New System.Drawing.Point(537, 142)
        Me.btnLineasTodas.Name = "btnLineasTodas"
        Me.btnLineasTodas.Size = New System.Drawing.Size(92, 71)
        Me.btnLineasTodas.TabIndex = 103
        Me.btnLineasTodas.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(454, 77)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(131, 21)
        Me.Label72.TabIndex = 0
        Me.Label72.Text = "Selecciona Turno:"
        '
        'grdLineasRegistradas
        '
        Me.grdLineasRegistradas.AllowUserToAddRows = False
        Me.grdLineasRegistradas.AllowUserToDeleteRows = False
        Me.grdLineasRegistradas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdLineasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLineasRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_registro_turno, Me.col_linea, Me.col_turno, Me.col_dia_asignado})
        Me.grdLineasRegistradas.Location = New System.Drawing.Point(737, 62)
        Me.grdLineasRegistradas.Name = "grdLineasRegistradas"
        Me.grdLineasRegistradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLineasRegistradas.Size = New System.Drawing.Size(467, 334)
        Me.grdLineasRegistradas.TabIndex = 0
        '
        'col_cve_registro_turno
        '
        Me.col_cve_registro_turno.DataPropertyName = "cve_registro_turno"
        Me.col_cve_registro_turno.HeaderText = "cve_registro_turno"
        Me.col_cve_registro_turno.Name = "col_cve_registro_turno"
        Me.col_cve_registro_turno.ReadOnly = True
        Me.col_cve_registro_turno.Visible = False
        '
        'col_linea
        '
        Me.col_linea.DataPropertyName = "linea"
        Me.col_linea.HeaderText = "linea"
        Me.col_linea.Name = "col_linea"
        Me.col_linea.ReadOnly = True
        Me.col_linea.Width = 120
        '
        'col_turno
        '
        Me.col_turno.DataPropertyName = "turno"
        Me.col_turno.HeaderText = "Turno"
        Me.col_turno.Name = "col_turno"
        Me.col_turno.ReadOnly = True
        Me.col_turno.Width = 150
        '
        'col_dia_asignado
        '
        Me.col_dia_asignado.DataPropertyName = "dia_asignado"
        Me.col_dia_asignado.HeaderText = "Dia Registro"
        Me.col_dia_asignado.Name = "col_dia_asignado"
        Me.col_dia_asignado.ReadOnly = True
        Me.col_dia_asignado.Width = 150
        '
        'grdLineasNoRegistradas
        '
        Me.grdLineasNoRegistradas.AllowUserToAddRows = False
        Me.grdLineasNoRegistradas.AllowUserToDeleteRows = False
        Me.grdLineasNoRegistradas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdLineasNoRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLineasNoRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_linea, Me.collinea})
        Me.grdLineasNoRegistradas.Location = New System.Drawing.Point(17, 62)
        Me.grdLineasNoRegistradas.Name = "grdLineasNoRegistradas"
        Me.grdLineasNoRegistradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdLineasNoRegistradas.Size = New System.Drawing.Size(396, 334)
        Me.grdLineasNoRegistradas.TabIndex = 0
        '
        'col_cve_linea
        '
        Me.col_cve_linea.DataPropertyName = "cve_linea"
        Me.col_cve_linea.HeaderText = "cve_linea"
        Me.col_cve_linea.Name = "col_cve_linea"
        Me.col_cve_linea.ReadOnly = True
        Me.col_cve_linea.Visible = False
        '
        'collinea
        '
        Me.collinea.DataPropertyName = "linea"
        Me.collinea.HeaderText = "linea"
        Me.collinea.Name = "collinea"
        Me.collinea.ReadOnly = True
        Me.collinea.Width = 350
        '
        'tabPageProductividad
        '
        Me.tabPageProductividad.Controls.Add(Me.grpProductividad)
        Me.tabPageProductividad.Location = New System.Drawing.Point(4, 28)
        Me.tabPageProductividad.Name = "tabPageProductividad"
        Me.tabPageProductividad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageProductividad.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageProductividad.TabIndex = 0
        Me.tabPageProductividad.Text = "Productividad"
        Me.tabPageProductividad.UseVisualStyleBackColor = True
        '
        'grpProductividad
        '
        Me.grpProductividad.BackColor = System.Drawing.Color.Transparent
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
        Me.grpProductividad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProductividad.Location = New System.Drawing.Point(3, 3)
        Me.grpProductividad.Name = "grpProductividad"
        Me.grpProductividad.Size = New System.Drawing.Size(750, 413)
        Me.grpProductividad.TabIndex = 0
        Me.grpProductividad.TabStop = False
        Me.grpProductividad.Text = "Productividad"
        '
        'grdDetalleProductividad
        '
        Me.grdDetalleProductividad.AllowUserToAddRows = False
        Me.grdDetalleProductividad.AllowUserToDeleteRows = False
        Me.grdDetalleProductividad.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleProductividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleProductividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_produccion, Me.colcve_linea, Me.colcve_modelo, Me.np_gkn, Me.coldescripcion, Me.colpzas_ok, Me.coltom, Me.colCapacidad, Me.colAdeudo})
        Me.grdDetalleProductividad.Location = New System.Drawing.Point(3, 257)
        Me.grdDetalleProductividad.Name = "grdDetalleProductividad"
        Me.grdDetalleProductividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleProductividad.Size = New System.Drawing.Size(741, 150)
        Me.grdDetalleProductividad.TabIndex = 0
        '
        'colcve_produccion
        '
        Me.colcve_produccion.DataPropertyName = "cve_produccion"
        Me.colcve_produccion.HeaderText = "cve_produccion"
        Me.colcve_produccion.Name = "colcve_produccion"
        Me.colcve_produccion.ReadOnly = True
        Me.colcve_produccion.Visible = False
        '
        'colcve_linea
        '
        Me.colcve_linea.DataPropertyName = "cve_linea"
        Me.colcve_linea.HeaderText = "cve_linea"
        Me.colcve_linea.Name = "colcve_linea"
        Me.colcve_linea.ReadOnly = True
        Me.colcve_linea.Visible = False
        '
        'colcve_modelo
        '
        Me.colcve_modelo.DataPropertyName = "cve_modelo"
        Me.colcve_modelo.HeaderText = "cve_modelo"
        Me.colcve_modelo.Name = "colcve_modelo"
        Me.colcve_modelo.ReadOnly = True
        Me.colcve_modelo.Visible = False
        '
        'np_gkn
        '
        Me.np_gkn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.np_gkn.DataPropertyName = "np_gkn"
        Me.np_gkn.HeaderText = "No. Parte GKN"
        Me.np_gkn.Name = "np_gkn"
        Me.np_gkn.ReadOnly = True
        Me.np_gkn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.np_gkn.Width = 123
        '
        'coldescripcion
        '
        Me.coldescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldescripcion.DataPropertyName = "descripcion"
        Me.coldescripcion.HeaderText = "Modelo"
        Me.coldescripcion.Name = "coldescripcion"
        Me.coldescripcion.ReadOnly = True
        Me.coldescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldescripcion.Width = 89
        '
        'colpzas_ok
        '
        Me.colpzas_ok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colpzas_ok.DataPropertyName = "pzas_ok"
        Me.colpzas_ok.HeaderText = "Piezas Ok"
        Me.colpzas_ok.Name = "colpzas_ok"
        Me.colpzas_ok.ReadOnly = True
        Me.colpzas_ok.Width = 93
        '
        'coltom
        '
        Me.coltom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coltom.DataPropertyName = "tom"
        Me.coltom.HeaderText = "Tiempo Operación"
        Me.coltom.Name = "coltom"
        Me.coltom.ReadOnly = True
        Me.coltom.Width = 148
        '
        'colCapacidad
        '
        Me.colCapacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCapacidad.DataPropertyName = "capacidad"
        Me.colCapacidad.HeaderText = "Capacidad"
        Me.colCapacidad.Name = "colCapacidad"
        Me.colCapacidad.ReadOnly = True
        Me.colCapacidad.Width = 106
        '
        'colAdeudo
        '
        Me.colAdeudo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAdeudo.DataPropertyName = "adeudo"
        Me.colAdeudo.HeaderText = "Adeudo"
        Me.colAdeudo.Name = "colAdeudo"
        Me.colAdeudo.ReadOnly = True
        Me.colAdeudo.Width = 89
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(510, 155)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(69, 21)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "cantidad"
        '
        'txtPzasPorHora
        '
        Me.txtPzasPorHora.BackColor = System.Drawing.SystemColors.Control
        Me.txtPzasPorHora.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPzasPorHora.Location = New System.Drawing.Point(448, 151)
        Me.txtPzasPorHora.Name = "txtPzasPorHora"
        Me.txtPzasPorHora.ReadOnly = True
        Me.txtPzasPorHora.Size = New System.Drawing.Size(61, 28)
        Me.txtPzasPorHora.TabIndex = 0
        Me.txtPzasPorHora.Text = "0"
        Me.txtPzasPorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(6, 185)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(95, 21)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Descripción:"
        '
        'txtModeloDescripcionProductividad
        '
        Me.txtModeloDescripcionProductividad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloDescripcionProductividad.Location = New System.Drawing.Point(106, 182)
        Me.txtModeloDescripcionProductividad.Name = "txtModeloDescripcionProductividad"
        Me.txtModeloDescripcionProductividad.ReadOnly = True
        Me.txtModeloDescripcionProductividad.Size = New System.Drawing.Size(217, 28)
        Me.txtModeloDescripcionProductividad.TabIndex = 0
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(335, 155)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(107, 21)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "Piezas x Hora:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(669, 115)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(22, 21)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "%"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(669, 82)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(22, 21)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "%"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(669, 56)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(22, 21)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "%"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(669, 31)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(22, 21)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "%"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(510, 219)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(69, 21)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "cantidad"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(254, 219)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 21)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "minutos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(669, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quitar"
        '
        'lblParosComedor
        '
        Me.lblParosComedor.AutoSize = True
        Me.lblParosComedor.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosComedor.Location = New System.Drawing.Point(405, 57)
        Me.lblParosComedor.Name = "lblParosComedor"
        Me.lblParosComedor.Size = New System.Drawing.Size(19, 21)
        Me.lblParosComedor.TabIndex = 0
        Me.lblParosComedor.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(250, 56)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(143, 21)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Paros de Comedor:"
        '
        'lblTiempoOperacion
        '
        Me.lblTiempoOperacion.AutoSize = True
        Me.lblTiempoOperacion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoOperacion.Location = New System.Drawing.Point(183, 82)
        Me.lblTiempoOperacion.Name = "lblTiempoOperacion"
        Me.lblTiempoOperacion.Size = New System.Drawing.Size(19, 21)
        Me.lblTiempoOperacion.TabIndex = 0
        Me.lblTiempoOperacion.Text = "0"
        '
        'lblParosNoPlaneados
        '
        Me.lblParosNoPlaneados.AutoSize = True
        Me.lblParosNoPlaneados.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosNoPlaneados.Location = New System.Drawing.Point(405, 82)
        Me.lblParosNoPlaneados.Name = "lblParosNoPlaneados"
        Me.lblParosNoPlaneados.Size = New System.Drawing.Size(19, 21)
        Me.lblParosNoPlaneados.TabIndex = 0
        Me.lblParosNoPlaneados.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(161, 21)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Tiempo de operación:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(244, 82)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(151, 21)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Paros no planeados:"
        '
        'lblTiempoTurno
        '
        Me.lblTiempoTurno.AutoSize = True
        Me.lblTiempoTurno.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoTurno.Location = New System.Drawing.Point(183, 31)
        Me.lblTiempoTurno.Name = "lblTiempoTurno"
        Me.lblTiempoTurno.Size = New System.Drawing.Size(19, 21)
        Me.lblTiempoTurno.TabIndex = 0
        Me.lblTiempoTurno.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(35, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(131, 21)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Tiempo de turno:"
        '
        'lblTiempoCarga
        '
        Me.lblTiempoCarga.AutoSize = True
        Me.lblTiempoCarga.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoCarga.Location = New System.Drawing.Point(183, 56)
        Me.lblTiempoCarga.Name = "lblTiempoCarga"
        Me.lblTiempoCarga.Size = New System.Drawing.Size(19, 21)
        Me.lblTiempoCarga.TabIndex = 0
        Me.lblTiempoCarga.Text = "0"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(37, 56)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(129, 21)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Tiempo de carga:"
        '
        'lblParosPlaneados
        '
        Me.lblParosPlaneados.AutoSize = True
        Me.lblParosPlaneados.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParosPlaneados.Location = New System.Drawing.Point(405, 31)
        Me.lblParosPlaneados.Name = "lblParosPlaneados"
        Me.lblParosPlaneados.Size = New System.Drawing.Size(19, 21)
        Me.lblParosPlaneados.TabIndex = 0
        Me.lblParosPlaneados.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 125)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(175, 21)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Resultados por Modelo"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(264, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(129, 21)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Paros planeados:"
        '
        'txtTiempoOperacion
        '
        Me.txtTiempoOperacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTiempoOperacion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoOperacion.Location = New System.Drawing.Point(187, 216)
        Me.txtTiempoOperacion.Name = "txtTiempoOperacion"
        Me.txtTiempoOperacion.Size = New System.Drawing.Size(61, 28)
        Me.txtTiempoOperacion.TabIndex = 202
        Me.txtTiempoOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(39, 219)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(142, 21)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Tiempo Operación:"
        '
        'cbxModeloProductividad
        '
        Me.cbxModeloProductividad.BackColor = System.Drawing.Color.White
        Me.cbxModeloProductividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloProductividad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloProductividad.FormattingEnabled = True
        Me.cbxModeloProductividad.Location = New System.Drawing.Point(106, 151)
        Me.cbxModeloProductividad.Name = "cbxModeloProductividad"
        Me.cbxModeloProductividad.Size = New System.Drawing.Size(217, 29)
        Me.cbxModeloProductividad.TabIndex = 201
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(31, 154)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 21)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Modelo:"
        '
        'lblOEE
        '
        Me.lblOEE.AutoSize = True
        Me.lblOEE.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOEE.Location = New System.Drawing.Point(605, 115)
        Me.lblOEE.Name = "lblOEE"
        Me.lblOEE.Size = New System.Drawing.Size(19, 21)
        Me.lblOEE.TabIndex = 0
        Me.lblOEE.Text = "0"
        '
        'lblCalidad
        '
        Me.lblCalidad.AutoSize = True
        Me.lblCalidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalidad.Location = New System.Drawing.Point(605, 82)
        Me.lblCalidad.Name = "lblCalidad"
        Me.lblCalidad.Size = New System.Drawing.Size(19, 21)
        Me.lblCalidad.TabIndex = 0
        Me.lblCalidad.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(542, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "OEE"
        '
        'lblDesempeno
        '
        Me.lblDesempeno.AutoSize = True
        Me.lblDesempeno.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesempeno.Location = New System.Drawing.Point(605, 57)
        Me.lblDesempeno.Name = "lblDesempeno"
        Me.lblDesempeno.Size = New System.Drawing.Size(19, 21)
        Me.lblDesempeno.TabIndex = 0
        Me.lblDesempeno.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(519, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Calidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Piezas OK:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(589, 232)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 21)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Agregar"
        '
        'lblDisponibilidad
        '
        Me.lblDisponibilidad.AutoSize = True
        Me.lblDisponibilidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponibilidad.Location = New System.Drawing.Point(605, 30)
        Me.lblDisponibilidad.Name = "lblDisponibilidad"
        Me.lblDisponibilidad.Size = New System.Drawing.Size(19, 21)
        Me.lblDisponibilidad.TabIndex = 0
        Me.lblDisponibilidad.Text = "0"
        '
        'txtPiezasOkProducidas
        '
        Me.txtPiezasOkProducidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPiezasOkProducidas.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiezasOkProducidas.Location = New System.Drawing.Point(448, 216)
        Me.txtPiezasOkProducidas.Name = "txtPiezasOkProducidas"
        Me.txtPiezasOkProducidas.Size = New System.Drawing.Size(61, 28)
        Me.txtPiezasOkProducidas.TabIndex = 203
        Me.txtPiezasOkProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(470, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Disponibilidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(484, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 21)
        Me.Label10.TabIndex = 0
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
        Me.btnAgregarModelo.TabIndex = 204
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
        Me.btnQuitarModelo.TabIndex = 205
        Me.btnQuitarModelo.UseVisualStyleBackColor = False
        '
        'tabPageParos
        '
        Me.tabPageParos.Controls.Add(Me.grpCosto)
        Me.tabPageParos.Controls.Add(Me.grpParos)
        Me.tabPageParos.Location = New System.Drawing.Point(4, 28)
        Me.tabPageParos.Name = "tabPageParos"
        Me.tabPageParos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageParos.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageParos.TabIndex = 1
        Me.tabPageParos.Text = "Paros / Costo"
        Me.tabPageParos.UseVisualStyleBackColor = True
        '
        'grpCosto
        '
        Me.grpCosto.Controls.Add(Me.GroupBox2)
        Me.grpCosto.Controls.Add(Me.lblMinReal)
        Me.grpCosto.Controls.Add(Me.lblMinProgramados)
        Me.grpCosto.Controls.Add(Me.lblCosto)
        Me.grpCosto.Controls.Add(Me.Label40)
        Me.grpCosto.Controls.Add(Me.lblPrecio)
        Me.grpCosto.Controls.Add(Me.Label38)
        Me.grpCosto.Controls.Add(Me.Label18)
        Me.grpCosto.Controls.Add(Me.Label31)
        Me.grpCosto.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCosto.Location = New System.Drawing.Point(848, 6)
        Me.grpCosto.Name = "grpCosto"
        Me.grpCosto.Size = New System.Drawing.Size(368, 161)
        Me.grpCosto.TabIndex = 0
        Me.grpCosto.TabStop = False
        Me.grpCosto.Text = "2.-COSTO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label98)
        Me.GroupBox2.Controls.Add(Me.Label99)
        Me.GroupBox2.Controls.Add(Me.Label100)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 103)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "3.-CALIDAD"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(210, 53)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(59, 19)
        Me.Label98.TabIndex = 0
        Me.Label98.Text = "PPM'S"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(94, 50)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(22, 24)
        Me.Label99.TabIndex = 13
        Me.Label99.Text = "0"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(27, 53)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(57, 19)
        Me.Label100.TabIndex = 0
        Me.Label100.Text = "NRFTi"
        '
        'lblMinReal
        '
        Me.lblMinReal.AutoSize = True
        Me.lblMinReal.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinReal.Location = New System.Drawing.Point(250, 62)
        Me.lblMinReal.Name = "lblMinReal"
        Me.lblMinReal.Size = New System.Drawing.Size(19, 21)
        Me.lblMinReal.TabIndex = 0
        Me.lblMinReal.Text = "0"
        '
        'lblMinProgramados
        '
        Me.lblMinProgramados.AutoSize = True
        Me.lblMinProgramados.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinProgramados.Location = New System.Drawing.Point(250, 29)
        Me.lblMinProgramados.Name = "lblMinProgramados"
        Me.lblMinProgramados.Size = New System.Drawing.Size(19, 21)
        Me.lblMinProgramados.TabIndex = 0
        Me.lblMinProgramados.Text = "0"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(250, 120)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(19, 21)
        Me.lblCosto.TabIndex = 0
        Me.lblCosto.Text = "0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(19, 29)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(218, 21)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Minutos Programados CDM:  "
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(250, 87)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(19, 21)
        Me.lblPrecio.TabIndex = 0
        Me.lblPrecio.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(64, 62)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(164, 21)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Minutos Reales CDM:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(173, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Costo:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(169, 93)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 21)
        Me.Label31.TabIndex = 0
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
        Me.grpParos.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParos.Location = New System.Drawing.Point(3, 3)
        Me.grpParos.Name = "grpParos"
        Me.grpParos.Size = New System.Drawing.Size(839, 411)
        Me.grpParos.TabIndex = 0
        Me.grpParos.TabStop = False
        Me.grpParos.Text = "Paros"
        '
        'grdDetalleParo
        '
        Me.grdDetalleParo.AllowUserToAddRows = False
        Me.grdDetalleParo.AllowUserToDeleteRows = False
        Me.grdDetalleParo.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleParo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleParo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_registro_paro, Me.colcve_lineab, Me.colcve_maquina, Me.colcve_paro, Me.colcod_paro, Me.paro, Me.colminutos, Me.colclave_maquina, Me.colmaquina, Me.coldetalles})
        Me.grdDetalleParo.Location = New System.Drawing.Point(6, 171)
        Me.grdDetalleParo.Name = "grdDetalleParo"
        Me.grdDetalleParo.ReadOnly = True
        Me.grdDetalleParo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleParo.Size = New System.Drawing.Size(824, 231)
        Me.grdDetalleParo.TabIndex = 0
        '
        'colcve_registro_paro
        '
        Me.colcve_registro_paro.DataPropertyName = "cve_registro_paro"
        Me.colcve_registro_paro.HeaderText = "cve_registro_paro"
        Me.colcve_registro_paro.Name = "colcve_registro_paro"
        Me.colcve_registro_paro.ReadOnly = True
        Me.colcve_registro_paro.Visible = False
        '
        'colcve_lineab
        '
        Me.colcve_lineab.DataPropertyName = "cve_linea"
        Me.colcve_lineab.HeaderText = "cve_linea"
        Me.colcve_lineab.Name = "colcve_lineab"
        Me.colcve_lineab.ReadOnly = True
        Me.colcve_lineab.Visible = False
        '
        'colcve_maquina
        '
        Me.colcve_maquina.DataPropertyName = "cve_maquina"
        Me.colcve_maquina.HeaderText = "cve_maquina"
        Me.colcve_maquina.Name = "colcve_maquina"
        Me.colcve_maquina.ReadOnly = True
        Me.colcve_maquina.Visible = False
        '
        'colcve_paro
        '
        Me.colcve_paro.DataPropertyName = "cve_paro"
        Me.colcve_paro.HeaderText = "cve_paro"
        Me.colcve_paro.Name = "colcve_paro"
        Me.colcve_paro.ReadOnly = True
        Me.colcve_paro.Visible = False
        '
        'colcod_paro
        '
        Me.colcod_paro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colcod_paro.DataPropertyName = "cod_paro"
        Me.colcod_paro.HeaderText = "Cod. Paro"
        Me.colcod_paro.Name = "colcod_paro"
        Me.colcod_paro.ReadOnly = True
        Me.colcod_paro.Width = 102
        '
        'paro
        '
        Me.paro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.paro.DataPropertyName = "paro"
        Me.paro.HeaderText = "Descripción"
        Me.paro.Name = "paro"
        Me.paro.ReadOnly = True
        Me.paro.Width = 115
        '
        'colminutos
        '
        Me.colminutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colminutos.DataPropertyName = "minutos"
        Me.colminutos.HeaderText = "Minutos"
        Me.colminutos.Name = "colminutos"
        Me.colminutos.ReadOnly = True
        Me.colminutos.Width = 94
        '
        'colclave_maquina
        '
        Me.colclave_maquina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colclave_maquina.DataPropertyName = "clave_maquina"
        Me.colclave_maquina.HeaderText = "Clave Maquina"
        Me.colclave_maquina.Name = "colclave_maquina"
        Me.colclave_maquina.ReadOnly = True
        Me.colclave_maquina.Width = 138
        '
        'colmaquina
        '
        Me.colmaquina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colmaquina.DataPropertyName = "maquina"
        Me.colmaquina.HeaderText = "Maquina"
        Me.colmaquina.Name = "colmaquina"
        Me.colmaquina.ReadOnly = True
        Me.colmaquina.Width = 97
        '
        'coldetalles
        '
        Me.coldetalles.DataPropertyName = "detalles"
        Me.coldetalles.HeaderText = "Detalles"
        Me.coldetalles.Name = "coldetalles"
        Me.coldetalles.ReadOnly = True
        Me.coldetalles.Width = 140
        '
        'txtParosDescripcion
        '
        Me.txtParosDescripcion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParosDescripcion.Location = New System.Drawing.Point(6, 128)
        Me.txtParosDescripcion.Name = "txtParosDescripcion"
        Me.txtParosDescripcion.ReadOnly = True
        Me.txtParosDescripcion.Size = New System.Drawing.Size(354, 28)
        Me.txtParosDescripcion.TabIndex = 0
        '
        'txtMaquinaDescripcion
        '
        Me.txtMaquinaDescripcion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaquinaDescripcion.Location = New System.Drawing.Point(6, 55)
        Me.txtMaquinaDescripcion.Name = "txtMaquinaDescripcion"
        Me.txtMaquinaDescripcion.ReadOnly = True
        Me.txtMaquinaDescripcion.Size = New System.Drawing.Size(354, 28)
        Me.txtMaquinaDescripcion.TabIndex = 0
        '
        'txtMinutosParo
        '
        Me.txtMinutosParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMinutosParo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutosParo.Location = New System.Drawing.Point(461, 20)
        Me.txtMinutosParo.Name = "txtMinutosParo"
        Me.txtMinutosParo.Size = New System.Drawing.Size(161, 28)
        Me.txtMinutosParo.TabIndex = 203
        Me.txtMinutosParo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(381, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 21)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Minutos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(775, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 21)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Quitar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(695, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Agregar"
        '
        'btnQuitarParo
        '
        Me.btnQuitarParo.BackColor = System.Drawing.Color.White
        Me.btnQuitarParo.BackgroundImage = CType(resources.GetObject("btnQuitarParo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarParo.Enabled = False
        Me.btnQuitarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarParo.Location = New System.Drawing.Point(766, 52)
        Me.btnQuitarParo.Name = "btnQuitarParo"
        Me.btnQuitarParo.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarParo.TabIndex = 206
        Me.btnQuitarParo.UseVisualStyleBackColor = False
        '
        'btnAgregarParo
        '
        Me.btnAgregarParo.BackColor = System.Drawing.Color.White
        Me.btnAgregarParo.BackgroundImage = CType(resources.GetObject("btnAgregarParo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarParo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarParo.Enabled = False
        Me.btnAgregarParo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarParo.Location = New System.Drawing.Point(694, 52)
        Me.btnAgregarParo.Name = "btnAgregarParo"
        Me.btnAgregarParo.Size = New System.Drawing.Size(66, 59)
        Me.btnAgregarParo.TabIndex = 205
        Me.btnAgregarParo.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(385, 84)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 21)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Detalles:"
        '
        'txtDetallesParo
        '
        Me.txtDetallesParo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDetallesParo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallesParo.Location = New System.Drawing.Point(461, 81)
        Me.txtDetallesParo.Multiline = True
        Me.txtDetallesParo.Name = "txtDetallesParo"
        Me.txtDetallesParo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesParo.Size = New System.Drawing.Size(211, 75)
        Me.txtDetallesParo.TabIndex = 204
        '
        'cbxTipoParo
        '
        Me.cbxTipoParo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoParo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoParo.FormattingEnabled = True
        Me.cbxTipoParo.Location = New System.Drawing.Point(132, 96)
        Me.cbxTipoParo.MaxDropDownItems = 5
        Me.cbxTipoParo.Name = "cbxTipoParo"
        Me.cbxTipoParo.Size = New System.Drawing.Size(145, 29)
        Me.cbxTipoParo.TabIndex = 202
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(24, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 21)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Tipo de Paro:"
        '
        'cbxMaquina
        '
        Me.cbxMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMaquina.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMaquina.FormattingEnabled = True
        Me.cbxMaquina.Location = New System.Drawing.Point(132, 21)
        Me.cbxMaquina.Name = "cbxMaquina"
        Me.cbxMaquina.Size = New System.Drawing.Size(189, 29)
        Me.cbxMaquina.TabIndex = 201
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(49, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 21)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Máquina:"
        '
        'tabPageRechazos5s
        '
        Me.tabPageRechazos5s.Controls.Add(Me.grpRechazos)
        Me.tabPageRechazos5s.Controls.Add(Me.grpDesechos)
        Me.tabPageRechazos5s.Location = New System.Drawing.Point(4, 28)
        Me.tabPageRechazos5s.Name = "tabPageRechazos5s"
        Me.tabPageRechazos5s.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageRechazos5s.TabIndex = 2
        Me.tabPageRechazos5s.Text = "Calidad"
        Me.tabPageRechazos5s.UseVisualStyleBackColor = True
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
        Me.grpRechazos.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRechazos.Location = New System.Drawing.Point(591, 3)
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
        Me.grdDetalleRechazo.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleRechazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleRechazo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_rechazo, Me.col_np_gkn, Me.col_descripcion, Me.colcantidad, Me.coltipo_rechazo, Me.colmotivo})
        Me.grdDetalleRechazo.Location = New System.Drawing.Point(10, 234)
        Me.grdDetalleRechazo.Name = "grdDetalleRechazo"
        Me.grdDetalleRechazo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleRechazo.Size = New System.Drawing.Size(609, 174)
        Me.grdDetalleRechazo.TabIndex = 0
        '
        'colcve_rechazo
        '
        Me.colcve_rechazo.DataPropertyName = "cve_rechazo"
        Me.colcve_rechazo.HeaderText = "cve_rechazo"
        Me.colcve_rechazo.Name = "colcve_rechazo"
        Me.colcve_rechazo.ReadOnly = True
        Me.colcve_rechazo.Visible = False
        '
        'col_np_gkn
        '
        Me.col_np_gkn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_np_gkn.DataPropertyName = "np_gkn"
        Me.col_np_gkn.HeaderText = "No. Parte GKN"
        Me.col_np_gkn.Name = "col_np_gkn"
        Me.col_np_gkn.ReadOnly = True
        Me.col_np_gkn.Width = 135
        '
        'col_descripcion
        '
        Me.col_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_descripcion.DataPropertyName = "descripcion"
        Me.col_descripcion.HeaderText = "Modelo"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.ReadOnly = True
        Me.col_descripcion.Width = 89
        '
        'colcantidad
        '
        Me.colcantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colcantidad.DataPropertyName = "cantidad"
        Me.colcantidad.HeaderText = "Cantidad"
        Me.colcantidad.Name = "colcantidad"
        Me.colcantidad.ReadOnly = True
        Me.colcantidad.Width = 96
        '
        'coltipo_rechazo
        '
        Me.coltipo_rechazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coltipo_rechazo.DataPropertyName = "tipo"
        Me.coltipo_rechazo.HeaderText = "Rechazo"
        Me.coltipo_rechazo.Name = "coltipo_rechazo"
        Me.coltipo_rechazo.ReadOnly = True
        Me.coltipo_rechazo.Width = 92
        '
        'colmotivo
        '
        Me.colmotivo.DataPropertyName = "motivo"
        Me.colmotivo.HeaderText = "motivo"
        Me.colmotivo.Name = "colmotivo"
        Me.colmotivo.ReadOnly = True
        Me.colmotivo.Width = 140
        '
        'txtModeloRechazo
        '
        Me.txtModeloRechazo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloRechazo.Location = New System.Drawing.Point(113, 64)
        Me.txtModeloRechazo.Name = "txtModeloRechazo"
        Me.txtModeloRechazo.ReadOnly = True
        Me.txtModeloRechazo.Size = New System.Drawing.Size(198, 28)
        Me.txtModeloRechazo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripción:"
        '
        'cbxTipoRechazo
        '
        Me.cbxTipoRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoRechazo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoRechazo.FormattingEnabled = True
        Me.cbxTipoRechazo.Location = New System.Drawing.Point(421, 65)
        Me.cbxTipoRechazo.Name = "cbxTipoRechazo"
        Me.cbxTipoRechazo.Size = New System.Drawing.Size(198, 29)
        Me.cbxTipoRechazo.TabIndex = 403
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo:"
        '
        'cbxModeloRechazo
        '
        Me.cbxModeloRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloRechazo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloRechazo.FormattingEnabled = True
        Me.cbxModeloRechazo.Location = New System.Drawing.Point(113, 25)
        Me.cbxModeloRechazo.Name = "cbxModeloRechazo"
        Me.cbxModeloRechazo.Size = New System.Drawing.Size(198, 29)
        Me.cbxModeloRechazo.TabIndex = 401
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Motivo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(533, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Quitar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(448, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Agregar"
        '
        'btnAgregarRechazo
        '
        Me.btnAgregarRechazo.BackColor = System.Drawing.Color.White
        Me.btnAgregarRechazo.BackgroundImage = CType(resources.GetObject("btnAgregarRechazo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRechazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarRechazo.Enabled = False
        Me.btnAgregarRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRechazo.Location = New System.Drawing.Point(450, 128)
        Me.btnAgregarRechazo.Name = "btnAgregarRechazo"
        Me.btnAgregarRechazo.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarRechazo.TabIndex = 405
        Me.btnAgregarRechazo.UseVisualStyleBackColor = False
        '
        'btnQuitarRechazo
        '
        Me.btnQuitarRechazo.BackColor = System.Drawing.Color.White
        Me.btnQuitarRechazo.BackgroundImage = CType(resources.GetObject("btnQuitarRechazo.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarRechazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarRechazo.Enabled = False
        Me.btnQuitarRechazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarRechazo.Location = New System.Drawing.Point(527, 128)
        Me.btnQuitarRechazo.Name = "btnQuitarRechazo"
        Me.btnQuitarRechazo.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarRechazo.TabIndex = 406
        Me.btnQuitarRechazo.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Modelo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 21)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Cantidad:"
        '
        'txtRechazoMotivo
        '
        Me.txtRechazoMotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtRechazoMotivo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRechazoMotivo.Location = New System.Drawing.Point(10, 131)
        Me.txtRechazoMotivo.Multiline = True
        Me.txtRechazoMotivo.Name = "txtRechazoMotivo"
        Me.txtRechazoMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRechazoMotivo.Size = New System.Drawing.Size(301, 78)
        Me.txtRechazoMotivo.TabIndex = 404
        '
        'txtRechazosCantidad
        '
        Me.txtRechazosCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtRechazosCantidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRechazosCantidad.Location = New System.Drawing.Point(421, 25)
        Me.txtRechazosCantidad.Name = "txtRechazosCantidad"
        Me.txtRechazosCantidad.Size = New System.Drawing.Size(198, 28)
        Me.txtRechazosCantidad.TabIndex = 402
        '
        'grpDesechos
        '
        Me.grpDesechos.Controls.Add(Me.Label87)
        Me.grpDesechos.Controls.Add(Me.Label77)
        Me.grpDesechos.Controls.Add(Me.lblNRFTi)
        Me.grpDesechos.Controls.Add(Me.txtDetalleDesecho)
        Me.grpDesechos.Controls.Add(Me.grdDetalleDesecho)
        Me.grpDesechos.Controls.Add(Me.Label59)
        Me.grpDesechos.Controls.Add(Me.cbxModeloDesecho)
        Me.grpDesechos.Controls.Add(Me.Label78)
        Me.grpDesechos.Controls.Add(Me.Label60)
        Me.grpDesechos.Controls.Add(Me.Label17)
        Me.grpDesechos.Controls.Add(Me.btnAgregarDesecho)
        Me.grpDesechos.Controls.Add(Me.Label19)
        Me.grpDesechos.Controls.Add(Me.btnQuitarDesecho)
        Me.grpDesechos.Controls.Add(Me.txtModeloDesecho)
        Me.grpDesechos.Controls.Add(Me.Label46)
        Me.grpDesechos.Controls.Add(Me.Label6)
        Me.grpDesechos.Controls.Add(Me.txtDesechosCantidad)
        Me.grpDesechos.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDesechos.Location = New System.Drawing.Point(3, 3)
        Me.grpDesechos.Name = "grpDesechos"
        Me.grpDesechos.Size = New System.Drawing.Size(579, 414)
        Me.grpDesechos.TabIndex = 0
        Me.grpDesechos.TabStop = False
        Me.grpDesechos.Text = "Desecho"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(32, 147)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(70, 21)
        Me.Label87.TabIndex = 0
        Me.Label87.Text = "Detalles:"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(235, 373)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(55, 21)
        Me.Label77.TabIndex = 0
        Me.Label77.Text = "PPM'S"
        '
        'lblNRFTi
        '
        Me.lblNRFTi.AutoSize = True
        Me.lblNRFTi.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRFTi.Location = New System.Drawing.Point(119, 373)
        Me.lblNRFTi.Name = "lblNRFTi"
        Me.lblNRFTi.Size = New System.Drawing.Size(19, 21)
        Me.lblNRFTi.TabIndex = 13
        Me.lblNRFTi.Text = "0"
        '
        'txtDetalleDesecho
        '
        Me.txtDetalleDesecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDetalleDesecho.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleDesecho.Location = New System.Drawing.Point(107, 144)
        Me.txtDetalleDesecho.Multiline = True
        Me.txtDetalleDesecho.Name = "txtDetalleDesecho"
        Me.txtDetalleDesecho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalleDesecho.Size = New System.Drawing.Size(281, 65)
        Me.txtDetalleDesecho.TabIndex = 208
        '
        'grdDetalleDesecho
        '
        Me.grdDetalleDesecho.AllowUserToAddRows = False
        Me.grdDetalleDesecho.AllowUserToDeleteRows = False
        Me.grdDetalleDesecho.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleDesecho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleDesecho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_desecho, Me.col__cve_linea, Me.col_cve_modelo, Me.colnp_gkn, Me.colmodelodescripcion, Me.coldesechocantidad, Me.col_comentarios_desecho})
        Me.grdDetalleDesecho.Location = New System.Drawing.Point(6, 215)
        Me.grdDetalleDesecho.Name = "grdDetalleDesecho"
        Me.grdDetalleDesecho.ReadOnly = True
        Me.grdDetalleDesecho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleDesecho.Size = New System.Drawing.Size(567, 144)
        Me.grdDetalleDesecho.TabIndex = 0
        '
        'colcve_desecho
        '
        Me.colcve_desecho.DataPropertyName = "cve_desecho"
        Me.colcve_desecho.HeaderText = "cve_desecho"
        Me.colcve_desecho.Name = "colcve_desecho"
        Me.colcve_desecho.ReadOnly = True
        Me.colcve_desecho.Visible = False
        '
        'col__cve_linea
        '
        Me.col__cve_linea.DataPropertyName = "cve_linea"
        Me.col__cve_linea.HeaderText = "cve_linea"
        Me.col__cve_linea.Name = "col__cve_linea"
        Me.col__cve_linea.ReadOnly = True
        Me.col__cve_linea.Visible = False
        '
        'col_cve_modelo
        '
        Me.col_cve_modelo.DataPropertyName = "cve_modelo"
        Me.col_cve_modelo.HeaderText = "cve_modelo"
        Me.col_cve_modelo.Name = "col_cve_modelo"
        Me.col_cve_modelo.ReadOnly = True
        Me.col_cve_modelo.Visible = False
        '
        'colnp_gkn
        '
        Me.colnp_gkn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colnp_gkn.DataPropertyName = "np_gkn"
        Me.colnp_gkn.HeaderText = "No.Parte GKN"
        Me.colnp_gkn.Name = "colnp_gkn"
        Me.colnp_gkn.ReadOnly = True
        Me.colnp_gkn.Width = 131
        '
        'colmodelodescripcion
        '
        Me.colmodelodescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colmodelodescripcion.DataPropertyName = "descripcion"
        Me.colmodelodescripcion.HeaderText = "Modelo"
        Me.colmodelodescripcion.Name = "colmodelodescripcion"
        Me.colmodelodescripcion.ReadOnly = True
        Me.colmodelodescripcion.Width = 89
        '
        'coldesechocantidad
        '
        Me.coldesechocantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldesechocantidad.DataPropertyName = "cantidad"
        Me.coldesechocantidad.HeaderText = "Cantidad"
        Me.coldesechocantidad.Name = "coldesechocantidad"
        Me.coldesechocantidad.ReadOnly = True
        Me.coldesechocantidad.Width = 96
        '
        'col_comentarios_desecho
        '
        Me.col_comentarios_desecho.DataPropertyName = "comentarios"
        Me.col_comentarios_desecho.HeaderText = "Comentarios"
        Me.col_comentarios_desecho.Name = "col_comentarios_desecho"
        Me.col_comentarios_desecho.ReadOnly = True
        Me.col_comentarios_desecho.Width = 140
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(514, 84)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(54, 21)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Quitar"
        '
        'cbxModeloDesecho
        '
        Me.cbxModeloDesecho.BackColor = System.Drawing.Color.White
        Me.cbxModeloDesecho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModeloDesecho.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModeloDesecho.FormattingEnabled = True
        Me.cbxModeloDesecho.Location = New System.Drawing.Point(107, 25)
        Me.cbxModeloDesecho.Name = "cbxModeloDesecho"
        Me.cbxModeloDesecho.Size = New System.Drawing.Size(217, 29)
        Me.cbxModeloDesecho.TabIndex = 206
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(13, 373)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(51, 21)
        Me.Label78.TabIndex = 0
        Me.Label78.Text = "NRFTi"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(433, 84)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(64, 21)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "Agregar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 21)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Descripción:"
        '
        'btnAgregarDesecho
        '
        Me.btnAgregarDesecho.BackColor = System.Drawing.Color.White
        Me.btnAgregarDesecho.BackgroundImage = CType(resources.GetObject("btnAgregarDesecho.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDesecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarDesecho.Enabled = False
        Me.btnAgregarDesecho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDesecho.Location = New System.Drawing.Point(435, 22)
        Me.btnAgregarDesecho.Name = "btnAgregarDesecho"
        Me.btnAgregarDesecho.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarDesecho.TabIndex = 209
        Me.btnAgregarDesecho.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 21)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Modelo:"
        '
        'btnQuitarDesecho
        '
        Me.btnQuitarDesecho.BackColor = System.Drawing.Color.White
        Me.btnQuitarDesecho.BackgroundImage = CType(resources.GetObject("btnQuitarDesecho.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarDesecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarDesecho.Enabled = False
        Me.btnQuitarDesecho.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDesecho.Location = New System.Drawing.Point(509, 22)
        Me.btnQuitarDesecho.Name = "btnQuitarDesecho"
        Me.btnQuitarDesecho.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarDesecho.TabIndex = 210
        Me.btnQuitarDesecho.UseVisualStyleBackColor = False
        '
        'txtModeloDesecho
        '
        Me.txtModeloDesecho.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloDesecho.Location = New System.Drawing.Point(107, 65)
        Me.txtModeloDesecho.Name = "txtModeloDesecho"
        Me.txtModeloDesecho.ReadOnly = True
        Me.txtModeloDesecho.Size = New System.Drawing.Size(217, 28)
        Me.txtModeloDesecho.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(174, 106)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(69, 21)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Desechos:"
        '
        'txtDesechosCantidad
        '
        Me.txtDesechosCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDesechosCantidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesechosCantidad.Location = New System.Drawing.Point(107, 103)
        Me.txtDesechosCantidad.Name = "txtDesechosCantidad"
        Me.txtDesechosCantidad.Size = New System.Drawing.Size(61, 28)
        Me.txtDesechosCantidad.TabIndex = 207
        Me.txtDesechosCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabPageCondInsegAccidentes
        '
        Me.tabPageCondInsegAccidentes.Controls.Add(Me.grpAccidentes)
        Me.tabPageCondInsegAccidentes.Controls.Add(Me.grpCondInseg)
        Me.tabPageCondInsegAccidentes.Location = New System.Drawing.Point(4, 28)
        Me.tabPageCondInsegAccidentes.Name = "tabPageCondInsegAccidentes"
        Me.tabPageCondInsegAccidentes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageCondInsegAccidentes.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageCondInsegAccidentes.TabIndex = 3
        Me.tabPageCondInsegAccidentes.Text = "Seguridad"
        Me.tabPageCondInsegAccidentes.UseVisualStyleBackColor = True
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
        Me.grpAccidentes.Location = New System.Drawing.Point(612, 3)
        Me.grpAccidentes.Name = "grpAccidentes"
        Me.grpAccidentes.Size = New System.Drawing.Size(600, 422)
        Me.grpAccidentes.TabIndex = 0
        Me.grpAccidentes.TabStop = False
        Me.grpAccidentes.Text = "Accidentes"
        '
        'grdDetalleAccidente
        '
        Me.grdDetalleAccidente.AllowUserToAddRows = False
        Me.grdDetalleAccidente.AllowUserToDeleteRows = False
        Me.grdDetalleAccidente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleAccidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleAccidente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_seguridad, Me.col_descripcion_, Me.Cantidad, Me.col_comentarios_})
        Me.grdDetalleAccidente.Location = New System.Drawing.Point(6, 242)
        Me.grdDetalleAccidente.Name = "grdDetalleAccidente"
        Me.grdDetalleAccidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleAccidente.Size = New System.Drawing.Size(588, 171)
        Me.grdDetalleAccidente.TabIndex = 0
        '
        'col_cve_seguridad
        '
        Me.col_cve_seguridad.DataPropertyName = "cve_seguridad"
        Me.col_cve_seguridad.HeaderText = "cve_seguridad"
        Me.col_cve_seguridad.Name = "col_cve_seguridad"
        Me.col_cve_seguridad.ReadOnly = True
        Me.col_cve_seguridad.Visible = False
        '
        'col_descripcion_
        '
        Me.col_descripcion_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_descripcion_.DataPropertyName = "descripcion"
        Me.col_descripcion_.HeaderText = "Descripción"
        Me.col_descripcion_.Name = "col_descripcion_"
        Me.col_descripcion_.ReadOnly = True
        Me.col_descripcion_.Width = 115
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.DataPropertyName = "cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 96
        '
        'col_comentarios_
        '
        Me.col_comentarios_.DataPropertyName = "comentarios"
        Me.col_comentarios_.HeaderText = "Comentarios"
        Me.col_comentarios_.Name = "col_comentarios_"
        Me.col_comentarios_.ReadOnly = True
        Me.col_comentarios_.Width = 140
        '
        'btnQuitarAccidente
        '
        Me.btnQuitarAccidente.BackColor = System.Drawing.Color.White
        Me.btnQuitarAccidente.BackgroundImage = CType(resources.GetObject("btnQuitarAccidente.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarAccidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarAccidente.Enabled = False
        Me.btnQuitarAccidente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarAccidente.Location = New System.Drawing.Point(518, 45)
        Me.btnQuitarAccidente.Name = "btnQuitarAccidente"
        Me.btnQuitarAccidente.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarAccidente.TabIndex = 515
        Me.btnQuitarAccidente.UseVisualStyleBackColor = False
        '
        'btnAgregarAccidente
        '
        Me.btnAgregarAccidente.BackColor = System.Drawing.Color.White
        Me.btnAgregarAccidente.BackgroundImage = CType(resources.GetObject("btnAgregarAccidente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarAccidente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarAccidente.Enabled = False
        Me.btnAgregarAccidente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAccidente.Location = New System.Drawing.Point(441, 45)
        Me.btnAgregarAccidente.Name = "btnAgregarAccidente"
        Me.btnAgregarAccidente.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarAccidente.TabIndex = 514
        Me.btnAgregarAccidente.UseVisualStyleBackColor = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(20, 144)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(70, 21)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Detalles:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(524, 107)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(54, 21)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Quitar"
        '
        'txtDetallesAccidentes
        '
        Me.txtDetallesAccidentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDetallesAccidentes.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallesAccidentes.Location = New System.Drawing.Point(93, 144)
        Me.txtDetallesAccidentes.Multiline = True
        Me.txtDetallesAccidentes.Name = "txtDetallesAccidentes"
        Me.txtDetallesAccidentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesAccidentes.Size = New System.Drawing.Size(489, 75)
        Me.txtDetallesAccidentes.TabIndex = 513
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(439, 107)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 21)
        Me.Label65.TabIndex = 0
        Me.Label65.Text = "Agregar"
        '
        'txtAccidenteCantidad
        '
        Me.txtAccidenteCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAccidenteCantidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccidenteCantidad.Location = New System.Drawing.Point(93, 93)
        Me.txtAccidenteCantidad.Name = "txtAccidenteCantidad"
        Me.txtAccidenteCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtAccidenteCantidad.TabIndex = 512
        '
        'cbxTipoAccidente
        '
        Me.cbxTipoAccidente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoAccidente.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoAccidente.FormattingEnabled = True
        Me.cbxTipoAccidente.Location = New System.Drawing.Point(93, 44)
        Me.cbxTipoAccidente.Name = "cbxTipoAccidente"
        Me.cbxTipoAccidente.Size = New System.Drawing.Size(181, 29)
        Me.cbxTipoAccidente.TabIndex = 511
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(14, 96)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(76, 21)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "Cantidad:"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(45, 47)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 21)
        Me.Label67.TabIndex = 0
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
        Me.grpCondInseg.Location = New System.Drawing.Point(3, 3)
        Me.grpCondInseg.Name = "grpCondInseg"
        Me.grpCondInseg.Size = New System.Drawing.Size(603, 422)
        Me.grpCondInseg.TabIndex = 0
        Me.grpCondInseg.TabStop = False
        Me.grpCondInseg.Text = "Condiciones Inseguras"
        '
        'grdDetalleCondInseg
        '
        Me.grdDetalleCondInseg.AllowUserToAddRows = False
        Me.grdDetalleCondInseg.AllowUserToDeleteRows = False
        Me.grdDetalleCondInseg.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleCondInseg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleCondInseg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_seguridad, Me.coldescripciondetalle, Me.colcantidaddetalle, Me.colcomentarios})
        Me.grdDetalleCondInseg.Location = New System.Drawing.Point(6, 242)
        Me.grdDetalleCondInseg.Name = "grdDetalleCondInseg"
        Me.grdDetalleCondInseg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleCondInseg.Size = New System.Drawing.Size(591, 171)
        Me.grdDetalleCondInseg.TabIndex = 0
        '
        'colcve_seguridad
        '
        Me.colcve_seguridad.DataPropertyName = "cve_seguridad"
        Me.colcve_seguridad.HeaderText = "cve_seguridad"
        Me.colcve_seguridad.Name = "colcve_seguridad"
        Me.colcve_seguridad.ReadOnly = True
        Me.colcve_seguridad.Visible = False
        '
        'coldescripciondetalle
        '
        Me.coldescripciondetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldescripciondetalle.DataPropertyName = "descripcion"
        Me.coldescripciondetalle.HeaderText = "Descripción"
        Me.coldescripciondetalle.Name = "coldescripciondetalle"
        Me.coldescripciondetalle.ReadOnly = True
        Me.coldescripciondetalle.Width = 115
        '
        'colcantidaddetalle
        '
        Me.colcantidaddetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colcantidaddetalle.DataPropertyName = "cantidad"
        Me.colcantidaddetalle.HeaderText = "Cantidad"
        Me.colcantidaddetalle.Name = "colcantidaddetalle"
        Me.colcantidaddetalle.ReadOnly = True
        Me.colcantidaddetalle.Width = 96
        '
        'colcomentarios
        '
        Me.colcomentarios.DataPropertyName = "comentarios"
        Me.colcomentarios.HeaderText = "Comentarios"
        Me.colcomentarios.Name = "colcomentarios"
        Me.colcomentarios.ReadOnly = True
        Me.colcomentarios.Width = 140
        '
        'btnQuitarCondInseg
        '
        Me.btnQuitarCondInseg.BackColor = System.Drawing.Color.White
        Me.btnQuitarCondInseg.BackgroundImage = CType(resources.GetObject("btnQuitarCondInseg.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarCondInseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarCondInseg.Enabled = False
        Me.btnQuitarCondInseg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarCondInseg.Location = New System.Drawing.Point(521, 44)
        Me.btnQuitarCondInseg.Name = "btnQuitarCondInseg"
        Me.btnQuitarCondInseg.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarCondInseg.TabIndex = 505
        Me.btnQuitarCondInseg.UseVisualStyleBackColor = False
        '
        'btnAgregarCondInseg
        '
        Me.btnAgregarCondInseg.BackColor = System.Drawing.Color.White
        Me.btnAgregarCondInseg.BackgroundImage = CType(resources.GetObject("btnAgregarCondInseg.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCondInseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCondInseg.Enabled = False
        Me.btnAgregarCondInseg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCondInseg.Location = New System.Drawing.Point(444, 44)
        Me.btnAgregarCondInseg.Name = "btnAgregarCondInseg"
        Me.btnAgregarCondInseg.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarCondInseg.TabIndex = 504
        Me.btnAgregarCondInseg.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 144)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 21)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Detalles:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(527, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 21)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Quitar"
        '
        'txtDetallesCondInseg
        '
        Me.txtDetallesCondInseg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDetallesCondInseg.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallesCondInseg.Location = New System.Drawing.Point(96, 145)
        Me.txtDetallesCondInseg.Multiline = True
        Me.txtDetallesCondInseg.Name = "txtDetallesCondInseg"
        Me.txtDetallesCondInseg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesCondInseg.Size = New System.Drawing.Size(485, 75)
        Me.txtDetallesCondInseg.TabIndex = 503
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(442, 106)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 21)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Agregar"
        '
        'txtCondInsegCantidad
        '
        Me.txtCondInsegCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCondInsegCantidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondInsegCantidad.Location = New System.Drawing.Point(96, 94)
        Me.txtCondInsegCantidad.Name = "txtCondInsegCantidad"
        Me.txtCondInsegCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtCondInsegCantidad.TabIndex = 502
        '
        'cbxTipoCondInseg
        '
        Me.cbxTipoCondInseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCondInseg.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCondInseg.FormattingEnabled = True
        Me.cbxTipoCondInseg.Location = New System.Drawing.Point(96, 45)
        Me.cbxTipoCondInseg.Name = "cbxTipoCondInseg"
        Me.cbxTipoCondInseg.Size = New System.Drawing.Size(181, 29)
        Me.cbxTipoCondInseg.TabIndex = 501
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(14, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 21)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Cantidad:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(45, 48)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(45, 21)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "Tipo:"
        '
        'tabPageGente
        '
        Me.tabPageGente.Controls.Add(Me.grp5s)
        Me.tabPageGente.Controls.Add(Me.grpGente)
        Me.tabPageGente.Location = New System.Drawing.Point(4, 28)
        Me.tabPageGente.Name = "tabPageGente"
        Me.tabPageGente.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageGente.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageGente.TabIndex = 4
        Me.tabPageGente.Text = "Gente / 5'S"
        Me.tabPageGente.UseVisualStyleBackColor = True
        '
        'grp5s
        '
        Me.grp5s.Controls.Add(Me.prom)
        Me.grp5s.Controls.Add(Me.lblAlertaCincoS)
        Me.grp5s.Controls.Add(Me.txtprom)
        Me.grp5s.Controls.Add(Me.Label83)
        Me.grp5s.Controls.Add(Me.txtManto)
        Me.grp5s.Controls.Add(Me.Label80)
        Me.grp5s.Controls.Add(Me.txtcinco_S)
        Me.grp5s.Controls.Add(Me.txtAdmon)
        Me.grp5s.Controls.Add(Me.Label81)
        Me.grp5s.Controls.Add(Me.Label82)
        Me.grp5s.Controls.Add(Me.Label79)
        Me.grp5s.Controls.Add(Me.btnAgregarCincoS)
        Me.grp5s.Controls.Add(Me.txtPromedio)
        Me.grp5s.Controls.Add(Me.Label68)
        Me.grp5s.Controls.Add(Me.txtManttoAutonomo)
        Me.grp5s.Controls.Add(Me.Label69)
        Me.grp5s.Controls.Add(Me.txt5s)
        Me.grp5s.Controls.Add(Me.txtAdmonVisual)
        Me.grp5s.Controls.Add(Me.Label70)
        Me.grp5s.Controls.Add(Me.Label71)
        Me.grp5s.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp5s.Location = New System.Drawing.Point(627, 3)
        Me.grp5s.Name = "grp5s"
        Me.grp5s.Size = New System.Drawing.Size(579, 414)
        Me.grp5s.TabIndex = 0
        Me.grp5s.TabStop = False
        Me.grp5s.Text = "5'S"
        '
        'prom
        '
        Me.prom.AutoSize = True
        Me.prom.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prom.Location = New System.Drawing.Point(256, 175)
        Me.prom.Name = "prom"
        Me.prom.Size = New System.Drawing.Size(83, 21)
        Me.prom.TabIndex = 415
        Me.prom.Text = "Promedio:"
        '
        'lblAlertaCincoS
        '
        Me.lblAlertaCincoS.AutoSize = True
        Me.lblAlertaCincoS.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertaCincoS.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaCincoS.Location = New System.Drawing.Point(221, 228)
        Me.lblAlertaCincoS.Name = "lblAlertaCincoS"
        Me.lblAlertaCincoS.Size = New System.Drawing.Size(176, 21)
        Me.lblAlertaCincoS.TabIndex = 0
        Me.lblAlertaCincoS.Text = "No se ha Capturado 5'S."
        Me.lblAlertaCincoS.Visible = False
        '
        'txtprom
        '
        Me.txtprom.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprom.Location = New System.Drawing.Point(260, 348)
        Me.txtprom.Name = "txtprom"
        Me.txtprom.ReadOnly = True
        Me.txtprom.Size = New System.Drawing.Size(100, 28)
        Me.txtprom.TabIndex = 0
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(173, 351)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(83, 21)
        Me.Label83.TabIndex = 0
        Me.Label83.Text = "Promedio:"
        '
        'txtManto
        '
        Me.txtManto.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManto.Location = New System.Drawing.Point(260, 252)
        Me.txtManto.Name = "txtManto"
        Me.txtManto.ReadOnly = True
        Me.txtManto.Size = New System.Drawing.Size(100, 28)
        Me.txtManto.TabIndex = 0
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(106, 255)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(150, 21)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "Mantto. Autónomo:"
        '
        'txtcinco_S
        '
        Me.txtcinco_S.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcinco_S.Location = New System.Drawing.Point(260, 316)
        Me.txtcinco_S.Name = "txtcinco_S"
        Me.txtcinco_S.ReadOnly = True
        Me.txtcinco_S.Size = New System.Drawing.Size(100, 28)
        Me.txtcinco_S.TabIndex = 0
        '
        'txtAdmon
        '
        Me.txtAdmon.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmon.Location = New System.Drawing.Point(260, 284)
        Me.txtAdmon.Name = "txtAdmon"
        Me.txtAdmon.ReadOnly = True
        Me.txtAdmon.Size = New System.Drawing.Size(100, 28)
        Me.txtAdmon.TabIndex = 0
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(91, 287)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(165, 21)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "Administración visual:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(221, 319)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(35, 21)
        Me.Label82.TabIndex = 0
        Me.Label82.Text = "5 s:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(395, 114)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(67, 21)
        Me.Label79.TabIndex = 330
        Me.Label79.Text = "Guardar"
        '
        'btnAgregarCincoS
        '
        Me.btnAgregarCincoS.BackColor = System.Drawing.Color.White
        Me.btnAgregarCincoS.BackgroundImage = CType(resources.GetObject("btnAgregarCincoS.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCincoS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCincoS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCincoS.Location = New System.Drawing.Point(397, 52)
        Me.btnAgregarCincoS.Name = "btnAgregarCincoS"
        Me.btnAgregarCincoS.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarCincoS.TabIndex = 414
        Me.btnAgregarCincoS.UseVisualStyleBackColor = False
        '
        'txtPromedio
        '
        Me.txtPromedio.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromedio.Location = New System.Drawing.Point(260, 132)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.ReadOnly = True
        Me.txtPromedio.Size = New System.Drawing.Size(100, 28)
        Me.txtPromedio.TabIndex = 0
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(173, 134)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(83, 21)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Promedio:"
        '
        'txtManttoAutonomo
        '
        Me.txtManttoAutonomo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtManttoAutonomo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManttoAutonomo.Location = New System.Drawing.Point(260, 36)
        Me.txtManttoAutonomo.Name = "txtManttoAutonomo"
        Me.txtManttoAutonomo.Size = New System.Drawing.Size(100, 28)
        Me.txtManttoAutonomo.TabIndex = 411
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(106, 39)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(150, 21)
        Me.Label69.TabIndex = 0
        Me.Label69.Text = "Mantto. Autónomo:"
        '
        'txt5s
        '
        Me.txt5s.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt5s.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5s.Location = New System.Drawing.Point(260, 100)
        Me.txt5s.Name = "txt5s"
        Me.txt5s.Size = New System.Drawing.Size(100, 28)
        Me.txt5s.TabIndex = 413
        '
        'txtAdmonVisual
        '
        Me.txtAdmonVisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAdmonVisual.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmonVisual.Location = New System.Drawing.Point(260, 68)
        Me.txtAdmonVisual.Name = "txtAdmonVisual"
        Me.txtAdmonVisual.Size = New System.Drawing.Size(100, 28)
        Me.txtAdmonVisual.TabIndex = 412
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(91, 71)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(165, 21)
        Me.Label70.TabIndex = 0
        Me.Label70.Text = "Administración visual:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(221, 103)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(35, 21)
        Me.Label71.TabIndex = 0
        Me.Label71.Text = "5 s:"
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
        Me.grpGente.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGente.Location = New System.Drawing.Point(3, 3)
        Me.grpGente.Name = "grpGente"
        Me.grpGente.Size = New System.Drawing.Size(618, 411)
        Me.grpGente.TabIndex = 0
        Me.grpGente.TabStop = False
        Me.grpGente.Text = "Gente"
        '
        'grdDetalleGente
        '
        Me.grdDetalleGente.AllowUserToAddRows = False
        Me.grdDetalleGente.AllowUserToDeleteRows = False
        Me.grdDetalleGente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleGente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleGente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcve_gente, Me.colgdescripcion, Me.colgcantidad, Me.comentarios})
        Me.grdDetalleGente.Location = New System.Drawing.Point(14, 242)
        Me.grdDetalleGente.Name = "grdDetalleGente"
        Me.grdDetalleGente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleGente.Size = New System.Drawing.Size(580, 150)
        Me.grdDetalleGente.TabIndex = 0
        '
        'colcve_gente
        '
        Me.colcve_gente.DataPropertyName = "cve_gente"
        Me.colcve_gente.HeaderText = "cve_gente"
        Me.colcve_gente.Name = "colcve_gente"
        Me.colcve_gente.Visible = False
        '
        'colgdescripcion
        '
        Me.colgdescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colgdescripcion.DataPropertyName = "descripcion"
        Me.colgdescripcion.HeaderText = "descripcion"
        Me.colgdescripcion.Name = "colgdescripcion"
        Me.colgdescripcion.ReadOnly = True
        Me.colgdescripcion.Width = 114
        '
        'colgcantidad
        '
        Me.colgcantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colgcantidad.DataPropertyName = "cantidad"
        Me.colgcantidad.HeaderText = "cantidad"
        Me.colgcantidad.Name = "colgcantidad"
        Me.colgcantidad.ReadOnly = True
        Me.colgcantidad.Width = 94
        '
        'comentarios
        '
        Me.comentarios.DataPropertyName = "comentarios"
        Me.comentarios.HeaderText = "comentarios"
        Me.comentarios.Name = "comentarios"
        Me.comentarios.ReadOnly = True
        Me.comentarios.Width = 140
        '
        'btnQuitarGente
        '
        Me.btnQuitarGente.BackColor = System.Drawing.Color.White
        Me.btnQuitarGente.BackgroundImage = CType(resources.GetObject("btnQuitarGente.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarGente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarGente.Enabled = False
        Me.btnQuitarGente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarGente.Location = New System.Drawing.Point(530, 47)
        Me.btnQuitarGente.Name = "btnQuitarGente"
        Me.btnQuitarGente.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarGente.TabIndex = 605
        Me.btnQuitarGente.UseVisualStyleBackColor = False
        '
        'btnAgregarGente
        '
        Me.btnAgregarGente.BackColor = System.Drawing.Color.White
        Me.btnAgregarGente.BackgroundImage = CType(resources.GetObject("btnAgregarGente.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarGente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarGente.Enabled = False
        Me.btnAgregarGente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarGente.Location = New System.Drawing.Point(453, 47)
        Me.btnAgregarGente.Name = "btnAgregarGente"
        Me.btnAgregarGente.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarGente.TabIndex = 604
        Me.btnAgregarGente.UseVisualStyleBackColor = False
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(29, 147)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(70, 21)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "Detalles:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(536, 109)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 21)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Quitar"
        '
        'txtDetallesGente
        '
        Me.txtDetallesGente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDetallesGente.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallesGente.Location = New System.Drawing.Point(102, 147)
        Me.txtDetallesGente.Multiline = True
        Me.txtDetallesGente.Name = "txtDetallesGente"
        Me.txtDetallesGente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesGente.Size = New System.Drawing.Size(492, 75)
        Me.txtDetallesGente.TabIndex = 603
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(451, 109)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 21)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Agregar"
        '
        'txtGenteCantidad
        '
        Me.txtGenteCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGenteCantidad.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenteCantidad.Location = New System.Drawing.Point(102, 96)
        Me.txtGenteCantidad.Name = "txtGenteCantidad"
        Me.txtGenteCantidad.Size = New System.Drawing.Size(181, 28)
        Me.txtGenteCantidad.TabIndex = 602
        '
        'cbxTipoDetalleGente
        '
        Me.cbxTipoDetalleGente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDetalleGente.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoDetalleGente.FormattingEnabled = True
        Me.cbxTipoDetalleGente.Location = New System.Drawing.Point(102, 47)
        Me.cbxTipoDetalleGente.Name = "cbxTipoDetalleGente"
        Me.cbxTipoDetalleGente.Size = New System.Drawing.Size(181, 29)
        Me.cbxTipoDetalleGente.TabIndex = 601
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(23, 99)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 21)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "Cantidad:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(54, 50)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(45, 21)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Tipo:"
        '
        'tabPageComentarios
        '
        Me.tabPageComentarios.Controls.Add(Me.grpComentarios)
        Me.tabPageComentarios.Location = New System.Drawing.Point(4, 28)
        Me.tabPageComentarios.Name = "tabPageComentarios"
        Me.tabPageComentarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageComentarios.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageComentarios.TabIndex = 7
        Me.tabPageComentarios.Text = "Comentarios Generales"
        Me.tabPageComentarios.UseVisualStyleBackColor = True
        '
        'grpComentarios
        '
        Me.grpComentarios.Controls.Add(Me.grdDetalleComentario)
        Me.grpComentarios.Controls.Add(Me.Label90)
        Me.grpComentarios.Controls.Add(Me.txtDetallesComentario)
        Me.grpComentarios.Controls.Add(Me.btnQuitarComentario)
        Me.grpComentarios.Controls.Add(Me.btnAgregarComentario)
        Me.grpComentarios.Controls.Add(Me.Label88)
        Me.grpComentarios.Controls.Add(Me.Label89)
        Me.grpComentarios.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpComentarios.Location = New System.Drawing.Point(3, 3)
        Me.grpComentarios.Name = "grpComentarios"
        Me.grpComentarios.Size = New System.Drawing.Size(636, 410)
        Me.grpComentarios.TabIndex = 0
        Me.grpComentarios.TabStop = False
        Me.grpComentarios.Text = "Comentarios"
        '
        'grdDetalleComentario
        '
        Me.grdDetalleComentario.AllowUserToAddRows = False
        Me.grdDetalleComentario.AllowUserToDeleteRows = False
        Me.grdDetalleComentario.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleComentario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleComentario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cve_comentarios_generales, Me.col_comentarios})
        Me.grdDetalleComentario.Location = New System.Drawing.Point(11, 202)
        Me.grdDetalleComentario.Name = "grdDetalleComentario"
        Me.grdDetalleComentario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleComentario.Size = New System.Drawing.Size(606, 189)
        Me.grdDetalleComentario.TabIndex = 0
        '
        'col_cve_comentarios_generales
        '
        Me.col_cve_comentarios_generales.DataPropertyName = "cve_comentarios_generales"
        Me.col_cve_comentarios_generales.HeaderText = "cve_comentarios_generales"
        Me.col_cve_comentarios_generales.Name = "col_cve_comentarios_generales"
        Me.col_cve_comentarios_generales.ReadOnly = True
        Me.col_cve_comentarios_generales.Visible = False
        '
        'col_comentarios
        '
        Me.col_comentarios.DataPropertyName = "comentarios"
        Me.col_comentarios.HeaderText = "Comentario"
        Me.col_comentarios.Name = "col_comentarios"
        Me.col_comentarios.ReadOnly = True
        Me.col_comentarios.Width = 560
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(8, 41)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(70, 21)
        Me.Label90.TabIndex = 0
        Me.Label90.Text = "Detalles:"
        '
        'txtDetallesComentario
        '
        Me.txtDetallesComentario.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDetallesComentario.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetallesComentario.Location = New System.Drawing.Point(11, 62)
        Me.txtDetallesComentario.Multiline = True
        Me.txtDetallesComentario.Name = "txtDetallesComentario"
        Me.txtDetallesComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetallesComentario.Size = New System.Drawing.Size(437, 115)
        Me.txtDetallesComentario.TabIndex = 701
        '
        'btnQuitarComentario
        '
        Me.btnQuitarComentario.BackColor = System.Drawing.Color.White
        Me.btnQuitarComentario.BackgroundImage = CType(resources.GetObject("btnQuitarComentario.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarComentario.Enabled = False
        Me.btnQuitarComentario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarComentario.Location = New System.Drawing.Point(553, 74)
        Me.btnQuitarComentario.Name = "btnQuitarComentario"
        Me.btnQuitarComentario.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarComentario.TabIndex = 703
        Me.btnQuitarComentario.UseVisualStyleBackColor = False
        '
        'btnAgregarComentario
        '
        Me.btnAgregarComentario.BackColor = System.Drawing.Color.White
        Me.btnAgregarComentario.BackgroundImage = CType(resources.GetObject("btnAgregarComentario.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarComentario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarComentario.Enabled = False
        Me.btnAgregarComentario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarComentario.Location = New System.Drawing.Point(476, 74)
        Me.btnAgregarComentario.Name = "btnAgregarComentario"
        Me.btnAgregarComentario.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarComentario.TabIndex = 702
        Me.btnAgregarComentario.UseVisualStyleBackColor = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(559, 136)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(54, 21)
        Me.Label88.TabIndex = 0
        Me.Label88.Text = "Quitar"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(474, 136)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(64, 21)
        Me.Label89.TabIndex = 0
        Me.Label89.Text = "Agregar"
        '
        'tabPageDescansos
        '
        Me.tabPageDescansos.Controls.Add(Me.btnQuitarDescanso)
        Me.tabPageDescansos.Controls.Add(Me.btnAgregarDescanso)
        Me.tabPageDescansos.Controls.Add(Me.Label85)
        Me.tabPageDescansos.Controls.Add(Me.Label86)
        Me.tabPageDescansos.Controls.Add(Me.grdDetalleDescansos)
        Me.tabPageDescansos.Controls.Add(Me.Label84)
        Me.tabPageDescansos.Controls.Add(Me.dtpDescanso)
        Me.tabPageDescansos.Location = New System.Drawing.Point(4, 28)
        Me.tabPageDescansos.Name = "tabPageDescansos"
        Me.tabPageDescansos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageDescansos.Size = New System.Drawing.Size(1222, 430)
        Me.tabPageDescansos.TabIndex = 6
        Me.tabPageDescansos.Text = "Descansos"
        Me.tabPageDescansos.UseVisualStyleBackColor = True
        '
        'btnQuitarDescanso
        '
        Me.btnQuitarDescanso.BackColor = System.Drawing.Color.White
        Me.btnQuitarDescanso.BackgroundImage = CType(resources.GetObject("btnQuitarDescanso.BackgroundImage"), System.Drawing.Image)
        Me.btnQuitarDescanso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarDescanso.Enabled = False
        Me.btnQuitarDescanso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarDescanso.Location = New System.Drawing.Point(431, 33)
        Me.btnQuitarDescanso.Name = "btnQuitarDescanso"
        Me.btnQuitarDescanso.Size = New System.Drawing.Size(64, 59)
        Me.btnQuitarDescanso.TabIndex = 803
        Me.btnQuitarDescanso.UseVisualStyleBackColor = False
        '
        'btnAgregarDescanso
        '
        Me.btnAgregarDescanso.BackColor = System.Drawing.Color.White
        Me.btnAgregarDescanso.BackgroundImage = CType(resources.GetObject("btnAgregarDescanso.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDescanso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarDescanso.Enabled = False
        Me.btnAgregarDescanso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDescanso.Location = New System.Drawing.Point(354, 33)
        Me.btnAgregarDescanso.Name = "btnAgregarDescanso"
        Me.btnAgregarDescanso.Size = New System.Drawing.Size(63, 59)
        Me.btnAgregarDescanso.TabIndex = 802
        Me.btnAgregarDescanso.UseVisualStyleBackColor = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(437, 95)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(54, 21)
        Me.Label85.TabIndex = 0
        Me.Label85.Text = "Quitar"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(352, 95)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(64, 21)
        Me.Label86.TabIndex = 0
        Me.Label86.Text = "Agregar"
        '
        'grdDetalleDescansos
        '
        Me.grdDetalleDescansos.AllowUserToAddRows = False
        Me.grdDetalleDescansos.AllowUserToDeleteRows = False
        Me.grdDetalleDescansos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdDetalleDescansos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleDescansos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha_descanso, Me.col_Descanso})
        Me.grdDetalleDescansos.Location = New System.Drawing.Point(17, 154)
        Me.grdDetalleDescansos.Name = "grdDetalleDescansos"
        Me.grdDetalleDescansos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleDescansos.Size = New System.Drawing.Size(478, 257)
        Me.grdDetalleDescansos.TabIndex = 0
        '
        'col_fecha_descanso
        '
        Me.col_fecha_descanso.DataPropertyName = "dia_asignado"
        Me.col_fecha_descanso.HeaderText = "Fecha Descanso"
        Me.col_fecha_descanso.Name = "col_fecha_descanso"
        Me.col_fecha_descanso.ReadOnly = True
        Me.col_fecha_descanso.Width = 217
        '
        'col_Descanso
        '
        Me.col_Descanso.DataPropertyName = "descripcion"
        Me.col_Descanso.HeaderText = "Descripcion"
        Me.col_Descanso.Name = "col_Descanso"
        Me.col_Descanso.ReadOnly = True
        Me.col_Descanso.Width = 218
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(13, 33)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(196, 21)
        Me.Label84.TabIndex = 0
        Me.Label84.Text = "Calendario del Mes Actual:"
        '
        'dtpDescanso
        '
        Me.dtpDescanso.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDescanso.Location = New System.Drawing.Point(17, 57)
        Me.dtpDescanso.Name = "dtpDescanso"
        Me.dtpDescanso.Size = New System.Drawing.Size(304, 28)
        Me.dtpDescanso.TabIndex = 801
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
        Me.titulo_banner_formulario.TabIndex = 0
        Me.titulo_banner_formulario.Text = "Captura de Resultados de Producción"
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxTurno.Enabled = False
        Me.cbxTurno.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Location = New System.Drawing.Point(110, 150)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(234, 29)
        Me.cbxTurno.TabIndex = 0
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(36, 153)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(68, 21)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "Horario:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(12, 115)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(92, 21)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "Bienvenido:"
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(110, 116)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(115, 19)
        Me.lblCodigoEmpleado.TabIndex = 0
        Me.lblCodigoEmpleado.Text = "codEmpleado"
        Me.lblCodigoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(231, 116)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(80, 21)
        Me.lblNombreEmpleado.TabIndex = 0
        Me.lblNombreEmpleado.Text = "Empleado"
        '
        'lblNombreEquipo
        '
        Me.lblNombreEquipo.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEquipo.Location = New System.Drawing.Point(6, 81)
        Me.lblNombreEquipo.Name = "lblNombreEquipo"
        Me.lblNombreEquipo.Size = New System.Drawing.Size(241, 19)
        Me.lblNombreEquipo.TabIndex = 0
        Me.lblNombreEquipo.Text = "NombreEquipo"
        Me.lblNombreEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(53, 187)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(51, 21)
        Me.Label58.TabIndex = 0
        Me.Label58.Text = "Linea:"
        '
        'cbxLinea
        '
        Me.cbxLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLinea.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLinea.FormattingEnabled = True
        Me.cbxLinea.Location = New System.Drawing.Point(110, 184)
        Me.cbxLinea.Name = "cbxLinea"
        Me.cbxLinea.Size = New System.Drawing.Size(234, 29)
        Me.cbxLinea.TabIndex = 0
        '
        'lblFechaRegistro
        '
        Me.lblFechaRegistro.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegistro.Location = New System.Drawing.Point(848, 47)
        Me.lblFechaRegistro.Name = "lblFechaRegistro"
        Me.lblFechaRegistro.Size = New System.Drawing.Size(121, 19)
        Me.lblFechaRegistro.TabIndex = 0
        Me.lblFechaRegistro.Text = "FechaRegistro"
        Me.lblFechaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaRegistrodescripcion
        '
        Me.lblFechaRegistrodescripcion.AutoSize = True
        Me.lblFechaRegistrodescripcion.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRegistrodescripcion.Location = New System.Drawing.Point(726, 46)
        Me.lblFechaRegistrodescripcion.Name = "lblFechaRegistrodescripcion"
        Me.lblFechaRegistrodescripcion.Size = New System.Drawing.Size(122, 21)
        Me.lblFechaRegistrodescripcion.TabIndex = 0
        Me.lblFechaRegistrodescripcion.Text = "Registro del día:"
        '
        'imgEscudo
        '
        Me.imgEscudo.Location = New System.Drawing.Point(972, 70)
        Me.imgEscudo.Name = "imgEscudo"
        Me.imgEscudo.Size = New System.Drawing.Size(266, 172)
        Me.imgEscudo.TabIndex = 105
        Me.imgEscudo.TabStop = False
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
        'cmdGraficar
        '
        Me.cmdGraficar.BackColor = System.Drawing.Color.White
        Me.cmdGraficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGraficar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraficar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGraficar.Image = CType(resources.GetObject("cmdGraficar.Image"), System.Drawing.Image)
        Me.cmdGraficar.Location = New System.Drawing.Point(836, 116)
        Me.cmdGraficar.Name = "cmdGraficar"
        Me.cmdGraficar.Size = New System.Drawing.Size(130, 97)
        Me.cmdGraficar.TabIndex = 318
        Me.cmdGraficar.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(862, 216)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 21)
        Me.Label34.TabIndex = 318
        Me.Label34.Text = "Ir a gráficas"
        '
        'btnModModificar
        '
        Me.btnModModificar.Enabled = False
        Me.btnModModificar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModModificar.Location = New System.Drawing.Point(229, 53)
        Me.btnModModificar.Name = "btnModModificar"
        Me.btnModModificar.Size = New System.Drawing.Size(103, 27)
        Me.btnModModificar.TabIndex = 319
        Me.btnModModificar.Text = "Modificar"
        Me.btnModModificar.UseVisualStyleBackColor = True
        '
        'btnModTerminar
        '
        Me.btnModTerminar.Enabled = False
        Me.btnModTerminar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModTerminar.Location = New System.Drawing.Point(229, 105)
        Me.btnModTerminar.Name = "btnModTerminar"
        Me.btnModTerminar.Size = New System.Drawing.Size(103, 27)
        Me.btnModTerminar.TabIndex = 320
        Me.btnModTerminar.Text = "Terminar"
        Me.btnModTerminar.UseVisualStyleBackColor = True
        '
        'grpModificaciones
        '
        Me.grpModificaciones.Controls.Add(Me.cldrModificaciones)
        Me.grpModificaciones.Controls.Add(Me.btnModModificar)
        Me.grpModificaciones.Controls.Add(Me.btnModTerminar)
        Me.grpModificaciones.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpModificaciones.Location = New System.Drawing.Point(492, 76)
        Me.grpModificaciones.Name = "grpModificaciones"
        Me.grpModificaciones.Size = New System.Drawing.Size(338, 166)
        Me.grpModificaciones.TabIndex = 321
        Me.grpModificaciones.TabStop = False
        Me.grpModificaciones.Text = "Módulo de Modificaciones"
        '
        'cldrModificaciones
        '
        Me.cldrModificaciones.Location = New System.Drawing.Point(6, 19)
        Me.cldrModificaciones.Name = "cldrModificaciones"
        Me.cldrModificaciones.Size = New System.Drawing.Size(204, 141)
        Me.cldrModificaciones.TabIndex = 321
        Me.cldrModificaciones.Text = "RadCalendar1"
        '
        'frmProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1254, 722)
        Me.Controls.Add(Me.grpModificaciones)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.cmdGraficar)
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
        Me.Controls.Add(Me.imgEscudo)
        Me.Controls.Add(Me.titulo_banner_formulario)
        Me.Controls.Add(Me.banner_formulario)
        Me.Controls.Add(Me.tabPageContenido)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1280, 768)
        Me.MinimumSize = New System.Drawing.Size(1270, 736)
        Me.Name = "frmProduccion"
        Me.Text = "Producción"
        Me.tabPageContenido.ResumeLayout(False)
        Me.tabPageTurnosLineas.ResumeLayout(False)
        Me.tabPageTurnosLineas.PerformLayout()
        CType(Me.grdLineasRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLineasNoRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageProductividad.ResumeLayout(False)
        Me.grpProductividad.ResumeLayout(False)
        Me.grpProductividad.PerformLayout()
        CType(Me.grdDetalleProductividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageParos.ResumeLayout(False)
        Me.grpCosto.ResumeLayout(False)
        Me.grpCosto.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpParos.ResumeLayout(False)
        Me.grpParos.PerformLayout()
        CType(Me.grdDetalleParo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageRechazos5s.ResumeLayout(False)
        Me.grpRechazos.ResumeLayout(False)
        Me.grpRechazos.PerformLayout()
        CType(Me.grdDetalleRechazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDesechos.ResumeLayout(False)
        Me.grpDesechos.PerformLayout()
        CType(Me.grdDetalleDesecho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageCondInsegAccidentes.ResumeLayout(False)
        Me.grpAccidentes.ResumeLayout(False)
        Me.grpAccidentes.PerformLayout()
        CType(Me.grdDetalleAccidente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondInseg.ResumeLayout(False)
        Me.grpCondInseg.PerformLayout()
        CType(Me.grdDetalleCondInseg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageGente.ResumeLayout(False)
        Me.grp5s.ResumeLayout(False)
        Me.grp5s.PerformLayout()
        Me.grpGente.ResumeLayout(False)
        Me.grpGente.PerformLayout()
        CType(Me.grdDetalleGente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageComentarios.ResumeLayout(False)
        Me.grpComentarios.ResumeLayout(False)
        Me.grpComentarios.PerformLayout()
        CType(Me.grdDetalleComentario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageDescansos.ResumeLayout(False)
        Me.tabPageDescansos.PerformLayout()
        CType(Me.grdDetalleDescansos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEscudo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpModificaciones.ResumeLayout(False)
        CType(Me.cldrModificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabPageContenido As System.Windows.Forms.TabControl
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
    Friend WithEvents tabPageRechazos5s As System.Windows.Forms.TabPage
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
    Friend WithEvents tabPageCondInsegAccidentes As System.Windows.Forms.TabPage
    Friend WithEvents tabPageGente As System.Windows.Forms.TabPage
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
    Friend WithEvents imgEscudo As System.Windows.Forms.PictureBox
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents lblCodigoEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEquipo As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cbxLinea As System.Windows.Forms.ComboBox
    Friend WithEvents grdDetalleProductividad As System.Windows.Forms.DataGridView
    Friend WithEvents grdDetalleDesecho As System.Windows.Forms.DataGridView
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarDesecho As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDesecho As System.Windows.Forms.Button
    Friend WithEvents grdDetalleRechazo As System.Windows.Forms.DataGridView
    Friend WithEvents grdDetalleParo As System.Windows.Forms.DataGridView
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesGente As System.Windows.Forms.TextBox
    Friend WithEvents grdDetalleGente As System.Windows.Forms.DataGridView
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
    Friend WithEvents grp5s As System.Windows.Forms.GroupBox
    Friend WithEvents txtPromedio As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtManttoAutonomo As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents txt5s As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmonVisual As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents tabPageTurnosLineas As System.Windows.Forms.TabPage
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
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents lblNRFTi As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents lblFechaRegistro As System.Windows.Forms.Label
    Friend WithEvents lblFechaRegistrodescripcion As System.Windows.Forms.Label
    Friend WithEvents txtManto As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtcinco_S As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmon As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarCincoS As System.Windows.Forms.Button
    Friend WithEvents txtprom As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents lblAlertaCincoS As System.Windows.Forms.Label
    Friend WithEvents tabPageDescansos As System.Windows.Forms.TabPage
    Friend WithEvents btnQuitarDescanso As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDescanso As System.Windows.Forms.Button
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents grdDetalleDescansos As System.Windows.Forms.DataGridView
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents dtpDescanso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDetalleDesecho As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents tabPageComentarios As System.Windows.Forms.TabPage
    Friend WithEvents grpComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalleComentario As System.Windows.Forms.DataGridView
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents txtDetallesComentario As System.Windows.Forms.TextBox
    Friend WithEvents btnQuitarComentario As System.Windows.Forms.Button
    Friend WithEvents btnAgregarComentario As System.Windows.Forms.Button
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents col_cve_comentarios_generales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_registro_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_turno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_dia_asignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_desecho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col__cve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cve_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnp_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmodelodescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesechocantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_comentarios_desecho As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_rechazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_np_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltipo_rechazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colmotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_gente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colgdescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colgcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents col_fecha_descanso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_Descanso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_produccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents np_gkn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpzas_ok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCapacidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAdeudo As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents col_cve_seguridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_comentarios_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcve_seguridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescripciondetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcantidaddetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcomentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdGraficar As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents prom As System.Windows.Forms.Label
    Friend WithEvents btnModModificar As System.Windows.Forms.Button
    Friend WithEvents btnModTerminar As System.Windows.Forms.Button
    Friend WithEvents grpModificaciones As System.Windows.Forms.GroupBox
    Friend WithEvents cldrModificaciones As Telerik.WinControls.UI.RadCalendar
End Class
