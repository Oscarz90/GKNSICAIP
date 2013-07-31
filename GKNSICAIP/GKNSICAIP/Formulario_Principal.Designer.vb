<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.RadRibbonBar3 = New Telerik.WinControls.UI.RadRibbonBar()
        CType(Me.RadRibbonBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar3
        '
        Me.RadRibbonBar3.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar3.Name = "RadRibbonBar3"
        Me.RadRibbonBar3.Size = New System.Drawing.Size(292, 144)
        Me.RadRibbonBar3.TabIndex = 0
        '
        'Formulario_Principal
        '
        Me.ClientSize = New System.Drawing.Size(292, 295)
        Me.Controls.Add(Me.RadRibbonBar3)
        Me.Name = "Formulario_Principal"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        CType(Me.RadRibbonBar3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dgvRegistros As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadRibbonBarGroup4 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents btnSICAIP As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBar2 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RadRibbonBar3 As Telerik.WinControls.UI.RadRibbonBar

End Class
