﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineaClasificacion
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cbxEstatus = New System.Windows.Forms.ComboBox()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.errorProvClasfLineas = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvClasfLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Estatus:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 19)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Descripción:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(96, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 27)
        Me.txtNombre.TabIndex = 112
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(16, 157)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(342, 84)
        Me.txtDescripcion.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Clasificación de Líneas"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(268, 256)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 28)
        Me.btnSalir.TabIndex = 115
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(163, 256)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(90, 28)
        Me.btnRegistrar.TabIndex = 116
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cbxEstatus
        '
        Me.cbxEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEstatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEstatus.FormattingEnabled = True
        Me.cbxEstatus.Items.AddRange(New Object() {"Activado", "Desactivado"})
        Me.cbxEstatus.Location = New System.Drawing.Point(96, 97)
        Me.cbxEstatus.Name = "cbxEstatus"
        Me.cbxEstatus.Size = New System.Drawing.Size(262, 27)
        Me.cbxEstatus.TabIndex = 117
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(-18, 0)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(407, 44)
        Me.banner_formulario.TabIndex = 108
        Me.banner_formulario.TabStop = False
        '
        'errorProvClasfLineas
        '
        Me.errorProvClasfLineas.ContainerControl = Me
        '
        'frmLineaClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(381, 298)
        Me.Controls.Add(Me.cbxEstatus)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.banner_formulario)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(397, 337)
        Me.MinimumSize = New System.Drawing.Size(397, 337)
        Me.Name = "frmLineaClasificacion"
        Me.Text = "Clasificación de Líneas"
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvClasfLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cbxEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents errorProvClasfLineas As System.Windows.Forms.ErrorProvider
End Class
