﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btnRegistrar = New Telerik.WinControls.UI.RadButton()
        Me.opActivar_Nivel = New Telerik.WinControls.UI.RadCheckBox()
        Me.rgbGrupo_Nivel = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnCadena_Valor = New Telerik.WinControls.UI.RadButton()
        Me.btnComponente = New Telerik.WinControls.UI.RadButton()
        Me.ddlComponente_W = New System.Windows.Forms.ComboBox()
        Me.ddlCadena_Valor_W = New System.Windows.Forms.ComboBox()
        Me.radUsuario_Componente = New Telerik.WinControls.UI.RadRadioButton()
        Me.radUsuario_CV = New Telerik.WinControls.UI.RadRadioButton()
        Me.btnAlta = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txtEstatus = New Telerik.WinControls.UI.RadTextBox()
        Me.btnModificar = New Telerik.WinControls.UI.RadButton()
        Me.btnImportar = New Telerik.WinControls.UI.RadButton()
        Me.txtPass = New Telerik.WinControls.UI.RadTextBox()
        Me.btnBaja = New Telerik.WinControls.UI.RadButton()
        Me.btnSalir = New Telerik.WinControls.UI.RadButton()
        Me.txtTipo_Usuario = New Telerik.WinControls.UI.RadTextBox()
        Me.txtEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
        Me.txtId_Usuario = New Telerik.WinControls.UI.RadTextBox()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opActivar_Nivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgbGrupo_Nivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rgbGrupo_Nivel.SuspendLayout()
        CType(Me.btnCadena_Valor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnComponente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radUsuario_Componente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radUsuario_CV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.btnRegistrar)
        Me.RadPanel1.Controls.Add(Me.opActivar_Nivel)
        Me.RadPanel1.Controls.Add(Me.rgbGrupo_Nivel)
        Me.RadPanel1.Controls.Add(Me.btnAlta)
        Me.RadPanel1.Controls.Add(Me.RadLabel6)
        Me.RadPanel1.Controls.Add(Me.txtEstatus)
        Me.RadPanel1.Controls.Add(Me.btnModificar)
        Me.RadPanel1.Controls.Add(Me.btnImportar)
        Me.RadPanel1.Controls.Add(Me.txtPass)
        Me.RadPanel1.Controls.Add(Me.btnBaja)
        Me.RadPanel1.Controls.Add(Me.btnSalir)
        Me.RadPanel1.Controls.Add(Me.txtTipo_Usuario)
        Me.RadPanel1.Controls.Add(Me.txtEmail)
        Me.RadPanel1.Controls.Add(Me.txtNombre)
        Me.RadPanel1.Controls.Add(Me.txtId_Usuario)
        Me.RadPanel1.Controls.Add(Me.titulo_banner_formulario)
        Me.RadPanel1.Controls.Add(Me.banner_formulario)
        Me.RadPanel1.Controls.Add(Me.RadLabel5)
        Me.RadPanel1.Controls.Add(Me.RadLabel4)
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(396, 397)
        Me.RadPanel1.TabIndex = 5
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(122, 361)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(88, 24)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar"
        '
        'opActivar_Nivel
        '
        Me.opActivar_Nivel.Location = New System.Drawing.Point(18, 184)
        Me.opActivar_Nivel.Name = "opActivar_Nivel"
        Me.opActivar_Nivel.Size = New System.Drawing.Size(83, 18)
        Me.opActivar_Nivel.TabIndex = 129
        Me.opActivar_Nivel.Text = "Activar Nivel"
        Me.opActivar_Nivel.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rgbGrupo_Nivel
        '
        Me.rgbGrupo_Nivel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.rgbGrupo_Nivel.Controls.Add(Me.btnCadena_Valor)
        Me.rgbGrupo_Nivel.Controls.Add(Me.btnComponente)
        Me.rgbGrupo_Nivel.Controls.Add(Me.ddlComponente_W)
        Me.rgbGrupo_Nivel.Controls.Add(Me.ddlCadena_Valor_W)
        Me.rgbGrupo_Nivel.Controls.Add(Me.radUsuario_Componente)
        Me.rgbGrupo_Nivel.Controls.Add(Me.radUsuario_CV)
        Me.rgbGrupo_Nivel.HeaderText = "Nivel"
        Me.rgbGrupo_Nivel.Location = New System.Drawing.Point(12, 208)
        Me.rgbGrupo_Nivel.Name = "rgbGrupo_Nivel"
        '
        '
        '
        Me.rgbGrupo_Nivel.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
        Me.rgbGrupo_Nivel.Size = New System.Drawing.Size(365, 80)
        Me.rgbGrupo_Nivel.TabIndex = 128
        Me.rgbGrupo_Nivel.Text = "Nivel"
        '
        'btnCadena_Valor
        '
        Me.btnCadena_Valor.Location = New System.Drawing.Point(99, 21)
        Me.btnCadena_Valor.Name = "btnCadena_Valor"
        Me.btnCadena_Valor.Size = New System.Drawing.Size(157, 20)
        Me.btnCadena_Valor.TabIndex = 5
        Me.btnCadena_Valor.Text = "Seleccionar"
        '
        'btnComponente
        '
        Me.btnComponente.Location = New System.Drawing.Point(99, 48)
        Me.btnComponente.Name = "btnComponente"
        Me.btnComponente.Size = New System.Drawing.Size(157, 20)
        Me.btnComponente.TabIndex = 130
        Me.btnComponente.Text = "Seleccionar"
        '
        'ddlComponente_W
        '
        Me.ddlComponente_W.FormattingEnabled = True
        Me.ddlComponente_W.Location = New System.Drawing.Point(334, 47)
        Me.ddlComponente_W.Name = "ddlComponente_W"
        Me.ddlComponente_W.Size = New System.Drawing.Size(26, 21)
        Me.ddlComponente_W.TabIndex = 130
        Me.ddlComponente_W.Visible = False
        '
        'ddlCadena_Valor_W
        '
        Me.ddlCadena_Valor_W.FormattingEnabled = True
        Me.ddlCadena_Valor_W.Location = New System.Drawing.Point(334, 20)
        Me.ddlCadena_Valor_W.Name = "ddlCadena_Valor_W"
        Me.ddlCadena_Valor_W.Size = New System.Drawing.Size(26, 21)
        Me.ddlCadena_Valor_W.TabIndex = 129
        Me.ddlCadena_Valor_W.Visible = False
        '
        'radUsuario_Componente
        '
        Me.radUsuario_Componente.Location = New System.Drawing.Point(6, 45)
        Me.radUsuario_Componente.Name = "radUsuario_Componente"
        Me.radUsuario_Componente.Size = New System.Drawing.Size(85, 18)
        Me.radUsuario_Componente.TabIndex = 126
        Me.radUsuario_Componente.Text = "Componente"
        '
        'radUsuario_CV
        '
        Me.radUsuario_CV.Location = New System.Drawing.Point(6, 21)
        Me.radUsuario_CV.Name = "radUsuario_CV"
        Me.radUsuario_CV.Size = New System.Drawing.Size(87, 18)
        Me.radUsuario_CV.TabIndex = 125
        Me.radUsuario_CV.Text = "Cadena Valor"
        '
        'btnAlta
        '
        Me.btnAlta.Image = CType(resources.GetObject("btnAlta.Image"), System.Drawing.Image)
        Me.btnAlta.Location = New System.Drawing.Point(219, 361)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(89, 24)
        Me.btnAlta.TabIndex = 10
        Me.btnAlta.Text = "Activar"
        Me.btnAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(12, 296)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel6.TabIndex = 124
        Me.RadLabel6.Text = "Estatus"
        '
        'txtEstatus
        '
        Me.txtEstatus.Location = New System.Drawing.Point(103, 294)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.ReadOnly = True
        Me.txtEstatus.Size = New System.Drawing.Size(202, 20)
        Me.txtEstatus.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(125, 361)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(88, 24)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(311, 160)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(66, 20)
        Me.btnImportar.TabIndex = 4
        Me.btnImportar.Text = "Importar"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(30, 365)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(23, 20)
        Me.txtPass.TabIndex = 115
        Me.txtPass.Visible = False
        '
        'btnBaja
        '
        Me.btnBaja.Image = CType(resources.GetObject("btnBaja.Image"), System.Drawing.Image)
        Me.btnBaja.Location = New System.Drawing.Point(222, 361)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(89, 24)
        Me.btnBaja.TabIndex = 9
        Me.btnBaja.Text = "Desactivar"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(317, 361)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 24)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'txtTipo_Usuario
        '
        Me.txtTipo_Usuario.Location = New System.Drawing.Point(103, 160)
        Me.txtTipo_Usuario.Name = "txtTipo_Usuario"
        Me.txtTipo_Usuario.ReadOnly = True
        Me.txtTipo_Usuario.Size = New System.Drawing.Size(202, 20)
        Me.txtTipo_Usuario.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(103, 134)
        Me.txtEmail.MaxLength = 200
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(274, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 108)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(274, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtId_Usuario
        '
        Me.txtId_Usuario.Location = New System.Drawing.Point(103, 82)
        Me.txtId_Usuario.MaxLength = 50
        Me.txtId_Usuario.Name = "txtId_Usuario"
        Me.txtId_Usuario.Size = New System.Drawing.Size(182, 20)
        Me.txtId_Usuario.TabIndex = 1
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(12, 30)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(256, 32)
        Me.titulo_banner_formulario.TabIndex = 113
        Me.titulo_banner_formulario.Text = "Registro de Usuario"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 3)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(396, 44)
        Me.banner_formulario.TabIndex = 112
        Me.banner_formulario.TabStop = False
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(12, 160)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(90, 18)
        Me.RadLabel5.TabIndex = 9
        Me.RadLabel5.Text = "*Tipo de Usuario"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 134)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel4.TabIndex = 8
        Me.RadLabel4.Text = "*Email:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 108)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel3.TabIndex = 7
        Me.RadLabel3.Text = "*Nombre:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(3, 367)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(28, 18)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "Pass"
        Me.RadLabel2.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 82)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(87, 18)
        Me.RadLabel1.TabIndex = 5
        Me.RadLabel1.Text = "*Usuario de Red"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 397)
        Me.Controls.Add(Me.RadPanel1)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(404, 267)
        Me.Name = "FrmUsuarios"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(0, 0)
        Me.Text = "Registro de Usuario"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.btnRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opActivar_Nivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgbGrupo_Nivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rgbGrupo_Nivel.ResumeLayout(False)
        Me.rgbGrupo_Nivel.PerformLayout()
        CType(Me.btnCadena_Valor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnComponente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radUsuario_Componente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radUsuario_CV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAlta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
    Friend WithEvents btnModificar As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBaja As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRegistrar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtTipo_Usuario As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtId_Usuario As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnImportar As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtEstatus As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnAlta As Telerik.WinControls.UI.RadButton
    Friend WithEvents rgbGrupo_Nivel As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents radUsuario_Componente As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents radUsuario_CV As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents opActivar_Nivel As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ddlComponente_W As System.Windows.Forms.ComboBox
    Friend WithEvents ddlCadena_Valor_W As System.Windows.Forms.ComboBox
    Friend WithEvents btnComponente As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCadena_Valor As Telerik.WinControls.UI.RadButton
End Class

