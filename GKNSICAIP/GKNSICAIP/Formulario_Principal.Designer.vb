﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario_Principal
    Inherits Telerik.WinControls.UI.RadRibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario_Principal))
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.btnUsuario = New Telerik.WinControls.UI.RadButtonElement()
        Me.btnTipoUsuario = New Telerik.WinControls.UI.RadButtonElement()
        Me.btnPermisos = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibbonTab2 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.btnLinea = New Telerik.WinControls.UI.RadButtonElement()
        Me.btnMaquina = New Telerik.WinControls.UI.RadButtonElement()
        Me.btnModelo = New Telerik.WinControls.UI.RadButtonElement()
        Me.btnTiempo_Ciclo = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadRibbonBarGroup3 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.btnEquipo_Linea = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibbonTab3 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup4 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.btnSICAIP = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadOffice2007ScreenTipElement1 = New Telerik.WinControls.UI.RadOffice2007ScreenTipElement()
        Me.RadPanel_Registros = New Telerik.WinControls.UI.RadPanel()
        Me.dgvRegistros = New Telerik.WinControls.UI.RadGridView()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.Barra_Tool_Registros = New Telerik.WinControls.UI.RadCommandBar()
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.btnAdd = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnModificar = New Telerik.WinControls.UI.CommandBarButton()
        Me.btnEliminar = New Telerik.WinControls.UI.CommandBarButton()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel_Registros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel_Registros.SuspendLayout()
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barra_Tool_Registros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar3
        '
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.RibbonTab1, Me.RibbonTab2, Me.RibbonTab3})
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.RadRibbonBar1.Size = New System.Drawing.Size(1016, 158)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "SICAIP"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.AccessibleDescription = "Configuración"
        Me.RibbonTab1.AccessibleName = "Configuración"
        Me.RibbonTab1.IsSelected = True
        Me.RibbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup1})
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Configuración"
        Me.RibbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.AccessibleDescription = "Configuracion"
        Me.RadRibbonBarGroup1.AccessibleName = "Configuracion"
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnUsuario, Me.btnTipoUsuario, Me.btnPermisos})
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Configuracion"
        Me.RadRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnUsuario
        '
        Me.btnUsuario.AccessibleDescription = "Usuarios"
        Me.btnUsuario.AccessibleName = "Usuarios"
        Me.btnUsuario.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnUsuario.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnTipoUsuario
        '
        Me.btnTipoUsuario.AccessibleDescription = "Tipo de Usuario"
        Me.btnTipoUsuario.AccessibleName = "Tipo de Usuario"
        Me.btnTipoUsuario.Name = "btnTipoUsuario"
        Me.btnTipoUsuario.Text = "Tipo de Usuario"
        Me.btnTipoUsuario.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnPermisos
        '
        Me.btnPermisos.AccessibleDescription = "Permisos"
        Me.btnPermisos.AccessibleName = "Permisos"
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Text = "Permisos"
        Me.btnPermisos.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RibbonTab2
        '
        Me.RibbonTab2.AccessibleDescription = "Catalogos"
        Me.RibbonTab2.AccessibleName = "Catalogos"
        Me.RibbonTab2.IsSelected = False
        Me.RibbonTab2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup2, Me.RadRibbonBarGroup3})
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Catalogos"
        Me.RibbonTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup2
        '
        Me.RadRibbonBarGroup2.AccessibleDescription = "Catalogos"
        Me.RadRibbonBarGroup2.AccessibleName = "Catalogos"
        Me.RadRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnLinea, Me.btnMaquina, Me.btnModelo, Me.btnTiempo_Ciclo})
        Me.RadRibbonBarGroup2.Name = "RadRibbonBarGroup2"
        Me.RadRibbonBarGroup2.Text = "Catalogos"
        Me.RadRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnLinea
        '
        Me.btnLinea.AccessibleDescription = "Linea"
        Me.btnLinea.AccessibleName = "Linea"
        Me.btnLinea.Name = "btnLinea"
        Me.btnLinea.Text = "Linea"
        Me.btnLinea.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnMaquina
        '
        Me.btnMaquina.AccessibleDescription = "Maquina"
        Me.btnMaquina.AccessibleName = "Maquina"
        Me.btnMaquina.Name = "btnMaquina"
        Me.btnMaquina.Text = "Maquina"
        Me.btnMaquina.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnModelo
        '
        Me.btnModelo.AccessibleDescription = "Modelo"
        Me.btnModelo.AccessibleName = "Modelo"
        Me.btnModelo.Name = "btnModelo"
        Me.btnModelo.Text = "Modelo"
        Me.btnModelo.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnTiempo_Ciclo
        '
        Me.btnTiempo_Ciclo.AccessibleDescription = "Tiempo Ciclo"
        Me.btnTiempo_Ciclo.AccessibleName = "Tiempo Ciclo"
        Me.btnTiempo_Ciclo.Name = "btnTiempo_Ciclo"
        Me.btnTiempo_Ciclo.Text = "Tiempo Ciclo"
        Me.btnTiempo_Ciclo.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup3
        '
        Me.RadRibbonBarGroup3.AccessibleDescription = "Asignaciones"
        Me.RadRibbonBarGroup3.AccessibleName = "Asignaciones"
        Me.RadRibbonBarGroup3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnEquipo_Linea})
        Me.RadRibbonBarGroup3.Name = "RadRibbonBarGroup3"
        Me.RadRibbonBarGroup3.Text = "Asignaciones"
        Me.RadRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnEquipo_Linea
        '
        Me.btnEquipo_Linea.AccessibleDescription = "Equipo_Linea"
        Me.btnEquipo_Linea.AccessibleName = "Equipo_Linea"
        Me.btnEquipo_Linea.Name = "btnEquipo_Linea"
        Me.btnEquipo_Linea.Text = "Equipo_Linea"
        Me.btnEquipo_Linea.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RibbonTab3
        '
        Me.RibbonTab3.AccessibleDescription = "SICAIP"
        Me.RibbonTab3.AccessibleName = "SICAIP"
        Me.RibbonTab3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup4})
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Text = "SICAIP"
        Me.RibbonTab3.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup4
        '
        Me.RadRibbonBarGroup4.AccessibleDescription = "SICAIP"
        Me.RadRibbonBarGroup4.AccessibleName = "SICAIP"
        Me.RadRibbonBarGroup4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btnSICAIP})
        Me.RadRibbonBarGroup4.Name = "RadRibbonBarGroup4"
        Me.RadRibbonBarGroup4.Text = "SICAIP"
        Me.RadRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnSICAIP
        '
        Me.btnSICAIP.AccessibleDescription = "SICAIP"
        Me.btnSICAIP.AccessibleName = "SICAIP"
        Me.btnSICAIP.AutoSize = True
        Me.btnSICAIP.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
        Me.btnSICAIP.Image = Nothing
        Me.btnSICAIP.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSICAIP.Name = "btnSICAIP"
        Me.btnSICAIP.Text = "SICAIP"
        Me.btnSICAIP.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadOffice2007ScreenTipElement1
        '
        Me.RadOffice2007ScreenTipElement1.Description = "Override this property and provide custom screentip template description in Desig" & _
            "nTime."
        Me.RadOffice2007ScreenTipElement1.Name = "RadOffice2007ScreenTipElement1"
        Me.RadOffice2007ScreenTipElement1.TemplateType = Nothing
        Me.RadOffice2007ScreenTipElement1.TipSize = New System.Drawing.Size(210, 50)
        Me.RadOffice2007ScreenTipElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.RadOffice2007ScreenTipElement1.GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Maquinas 1"
        CType(Me.RadOffice2007ScreenTipElement1.GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadLabelElement).Text = "Maquinas 2"
        CType(Me.RadOffice2007ScreenTipElement1.GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.RadLineItem).Text = "Maquinas 3"
        CType(Me.RadOffice2007ScreenTipElement1.GetChildAt(2).GetChildAt(3), Telerik.WinControls.UI.RadLabelElement).Text = "Maquinas 4"
        '
        'RadPanel_Registros
        '
        Me.RadPanel_Registros.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_gkn_driveline
        Me.RadPanel_Registros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RadPanel_Registros.Controls.Add(Me.dgvRegistros)
        Me.RadPanel_Registros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel_Registros.Location = New System.Drawing.Point(0, 188)
        Me.RadPanel_Registros.Name = "RadPanel_Registros"
        Me.RadPanel_Registros.Size = New System.Drawing.Size(1016, 535)
        Me.RadPanel_Registros.TabIndex = 1
        '
        'dgvRegistros
        '
        Me.dgvRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistros.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Fade
        Me.dgvRegistros.Location = New System.Drawing.Point(3, 3)
        '
        'dgvRegistros
        '
        Me.dgvRegistros.MasterTemplate.AllowAddNewRow = False
        Me.dgvRegistros.MasterTemplate.AllowDeleteRow = False
        Me.dgvRegistros.MasterTemplate.AllowRowReorder = True
        Me.dgvRegistros.MasterTemplate.AllowRowResize = False
        Me.dgvRegistros.MasterTemplate.EnableAlternatingRowColor = True
        Me.dgvRegistros.MasterTemplate.EnableFiltering = True
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.ReadOnly = True
        Me.dgvRegistros.Size = New System.Drawing.Size(1010, 508)
        Me.dgvRegistros.TabIndex = 0
        Me.dgvRegistros.Text = "RadGridView1"
        Me.dgvRegistros.UseScrollbarsInHierarchy = True
        Me.dgvRegistros.Visible = False
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 699)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        '
        '
        '
        Me.RadStatusStrip1.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RadStatusStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "ControlDefault"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Mensaje: "
        Me.RadLabelElement1.AccessibleName = "Mensaje: "
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Mensaje: "
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Barra_Tool_Registros
        '
        Me.Barra_Tool_Registros.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Tool_Registros.Location = New System.Drawing.Point(0, 158)
        Me.Barra_Tool_Registros.Name = "Barra_Tool_Registros"
        Me.Barra_Tool_Registros.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement2})
        Me.Barra_Tool_Registros.Size = New System.Drawing.Size(1016, 30)
        Me.Barra_Tool_Registros.TabIndex = 2
        Me.Barra_Tool_Registros.Text = "RadCommandBar2"
        Me.Barra_Tool_Registros.Visible = False
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement2})
        '
        'CommandBarStripElement2
        '
        Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
        Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.btnAdd, Me.btnModificar, Me.btnEliminar})
        Me.CommandBarStripElement2.Name = "CommandBarStripElement2"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleDescription = "btnAdd"
        Me.btnAdd.AccessibleName = "CommandBarButton1"
        Me.btnAdd.AutoToolTip = True
        Me.btnAdd.ClipDrawing = False
        Me.btnAdd.ClipText = False
        Me.btnAdd.DisplayName = "Nuevo"
        Me.btnAdd.DrawText = False
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Text = "CommandBarButton1"
        Me.btnAdd.TextWrap = False
        Me.btnAdd.ToolTipText = "Nuevo"
        Me.btnAdd.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleDescription = "btnModificar"
        Me.btnModificar.AccessibleName = "CommandBarButton2"
        Me.btnModificar.AutoToolTip = True
        Me.btnModificar.DisplayName = "Modificar"
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Text = "CommandBarButton2"
        Me.btnModificar.ToolTipText = "Modificar"
        Me.btnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleDescription = "btnEliminar"
        Me.btnEliminar.AccessibleName = "CommandBarButton3"
        Me.btnEliminar.AutoToolTip = True
        Me.btnEliminar.DisplayName = "Eliminar"
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Text = "CommandBarButton3"
        Me.btnEliminar.ToolTipText = "Eliminar"
        Me.btnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Formulario_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 723)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadPanel_Registros)
        Me.Controls.Add(Me.Barra_Tool_Registros)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "Formulario_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(1366, 768)
        Me.Text = "SICAIP"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel_Registros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel_Registros.ResumeLayout(False)
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barra_Tool_Registros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RibbonTab2 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RibbonTab3 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadOffice2007ScreenTipElement1 As Telerik.WinControls.UI.RadOffice2007ScreenTipElement
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents btnUsuario As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents btnMaquina As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents btnModelo As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents btnLinea As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents btnTiempo_Ciclo As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup3 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents btnEquipo_Linea As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents btnPermisos As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadPanel_Registros As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dgvRegistros As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadRibbonBarGroup4 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents btnSICAIP As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Barra_Tool_Registros As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement2 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents btnAdd As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnModificar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents btnEliminar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents btnTipoUsuario As Telerik.WinControls.UI.RadButtonElement

End Class