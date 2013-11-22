<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportar_Modelo
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
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.txtRuta_Archivo = New Telerik.WinControls.UI.RadTextBox()
        Me.btnCargar = New Telerik.WinControls.UI.RadButton()
        Me.txtIncidentes = New Telerik.WinControls.UI.RadTextBox()
        Me.btnValidar_Archivo = New Telerik.WinControls.UI.RadButton()
        Me.btnSeleccion_Archivo = New Telerik.WinControls.UI.RadButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.txtRuta_Archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIncidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnValidar_Archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeleccion_Archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 27)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(213, 32)
        Me.titulo_banner_formulario.TabIndex = 107
        Me.titulo_banner_formulario.Text = "Importar Modelo"
        '
        'banner_formulario
        '
        Me.banner_formulario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(608, 44)
        Me.banner_formulario.TabIndex = 106
        Me.banner_formulario.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 73)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(72, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Ruta Archivo:"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(486, 158)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 24)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.btnSalir)
        Me.RadPanel1.Controls.Add(Me.txtRuta_Archivo)
        Me.RadPanel1.Controls.Add(Me.btnCargar)
        Me.RadPanel1.Controls.Add(Me.txtIncidentes)
        Me.RadPanel1.Controls.Add(Me.btnValidar_Archivo)
        Me.RadPanel1.Controls.Add(Me.btnSeleccion_Archivo)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(608, 361)
        Me.RadPanel1.TabIndex = 8
        '
        'txtRuta_Archivo
        '
        Me.txtRuta_Archivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuta_Archivo.Location = New System.Drawing.Point(12, 97)
        Me.txtRuta_Archivo.Name = "txtRuta_Archivo"
        Me.txtRuta_Archivo.Size = New System.Drawing.Size(584, 20)
        Me.txtRuta_Archivo.TabIndex = 1
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargar.Location = New System.Drawing.Point(370, 158)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(110, 24)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar"
        '
        'txtIncidentes
        '
        Me.txtIncidentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIncidentes.AutoSize = False
        Me.txtIncidentes.Location = New System.Drawing.Point(12, 205)
        Me.txtIncidentes.Multiline = True
        Me.txtIncidentes.Name = "txtIncidentes"
        Me.txtIncidentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIncidentes.Size = New System.Drawing.Size(584, 142)
        Me.txtIncidentes.TabIndex = 2
        '
        'btnValidar_Archivo
        '
        Me.btnValidar_Archivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValidar_Archivo.Location = New System.Drawing.Point(254, 158)
        Me.btnValidar_Archivo.Name = "btnValidar_Archivo"
        Me.btnValidar_Archivo.Size = New System.Drawing.Size(110, 24)
        Me.btnValidar_Archivo.TabIndex = 4
        Me.btnValidar_Archivo.Text = "Validar Archivo"
        '
        'btnSeleccion_Archivo
        '
        Me.btnSeleccion_Archivo.Location = New System.Drawing.Point(12, 123)
        Me.btnSeleccion_Archivo.Name = "btnSeleccion_Archivo"
        Me.btnSeleccion_Archivo.Size = New System.Drawing.Size(110, 24)
        Me.btnSeleccion_Archivo.TabIndex = 3
        Me.btnSeleccion_Archivo.Text = "Seleccionar Archivo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmImportar_Modelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 361)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "FrmImportar_Modelo"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Importar Modelo"
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.txtRuta_Archivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIncidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnValidar_Archivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeleccion_Archivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txtRuta_Archivo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnCargar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtIncidentes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnValidar_Archivo As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSeleccion_Archivo As Telerik.WinControls.UI.RadButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

