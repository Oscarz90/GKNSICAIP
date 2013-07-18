<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipo_Linea
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
        Me.lbLibres = New System.Windows.Forms.ListBox()
        Me.lbAsignados = New System.Windows.Forms.ListBox()
        Me.btnAsignar_ITEM = New System.Windows.Forms.Button()
        Me.btnLiberar_ITEM = New System.Windows.Forms.Button()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.titulo_banner_formulario = New System.Windows.Forms.Label()
        Me.banner_formulario = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLibres
        '
        Me.lbLibres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbLibres.FormattingEnabled = True
        Me.lbLibres.Location = New System.Drawing.Point(13, 142)
        Me.lbLibres.Name = "lbLibres"
        Me.lbLibres.Size = New System.Drawing.Size(259, 316)
        Me.lbLibres.TabIndex = 0
        '
        'lbAsignados
        '
        Me.lbAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbAsignados.FormattingEnabled = True
        Me.lbAsignados.Location = New System.Drawing.Point(373, 142)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(259, 316)
        Me.lbAsignados.TabIndex = 1
        '
        'btnAsignar_ITEM
        '
        Me.btnAsignar_ITEM.Location = New System.Drawing.Point(293, 163)
        Me.btnAsignar_ITEM.Name = "btnAsignar_ITEM"
        Me.btnAsignar_ITEM.Size = New System.Drawing.Size(66, 39)
        Me.btnAsignar_ITEM.TabIndex = 3
        Me.btnAsignar_ITEM.Text = ">"
        Me.btnAsignar_ITEM.UseVisualStyleBackColor = True
        '
        'btnLiberar_ITEM
        '
        Me.btnLiberar_ITEM.Location = New System.Drawing.Point(293, 208)
        Me.btnLiberar_ITEM.Name = "btnLiberar_ITEM"
        Me.btnLiberar_ITEM.Size = New System.Drawing.Size(66, 39)
        Me.btnLiberar_ITEM.TabIndex = 4
        Me.btnLiberar_ITEM.Text = "<"
        Me.btnLiberar_ITEM.UseVisualStyleBackColor = True
        '
        'txtLinea
        '
        Me.txtLinea.BackColor = System.Drawing.Color.White
        Me.txtLinea.Location = New System.Drawing.Point(108, 90)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.ReadOnly = True
        Me.txtLinea.Size = New System.Drawing.Size(312, 20)
        Me.txtLinea.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seleccione Linea:"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(426, 88)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 8
        Me.btnImportar.Text = "Seleccionar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(483, 476)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(564, 476)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Equipos Asignados A Línea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Equipos No Asignados A Línea"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.titulo_banner_formulario)
        Me.Panel1.Controls.Add(Me.banner_formulario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbLibres)
        Me.Panel1.Controls.Add(Me.lbAsignados)
        Me.Panel1.Controls.Add(Me.btnLiberar_ITEM)
        Me.Panel1.Controls.Add(Me.btnAsignar_ITEM)
        Me.Panel1.Controls.Add(Me.txtLinea)
        Me.Panel1.Controls.Add(Me.btnImportar)
        Me.Panel1.Location = New System.Drawing.Point(1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 511)
        Me.Panel1.TabIndex = 13
        '
        'titulo_banner_formulario
        '
        Me.titulo_banner_formulario.AutoSize = True
        Me.titulo_banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.titulo_banner_formulario.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_banner_formulario.ForeColor = System.Drawing.Color.SteelBlue
        Me.titulo_banner_formulario.Location = New System.Drawing.Point(11, 30)
        Me.titulo_banner_formulario.Name = "titulo_banner_formulario"
        Me.titulo_banner_formulario.Size = New System.Drawing.Size(403, 32)
        Me.titulo_banner_formulario.TabIndex = 106
        Me.titulo_banner_formulario.Text = "Asignación de Equipos a Líneas"
        '
        'banner_formulario
        '
        Me.banner_formulario.BackColor = System.Drawing.Color.Transparent
        Me.banner_formulario.BackgroundImage = Global.GKNSICAIP.My.Resources.Resources.banner_03
        Me.banner_formulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.banner_formulario.Location = New System.Drawing.Point(0, 3)
        Me.banner_formulario.Name = "banner_formulario"
        Me.banner_formulario.Size = New System.Drawing.Size(651, 44)
        Me.banner_formulario.TabIndex = 105
        Me.banner_formulario.TabStop = False
        '
        'frmEquipo_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 520)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(668, 720)
        Me.MinimumSize = New System.Drawing.Size(668, 558)
        Me.Name = "frmEquipo_Linea"
        Me.Text = "Asignar Equipos a Líneas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.banner_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbLibres As System.Windows.Forms.ListBox
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents btnAsignar_ITEM As System.Windows.Forms.Button
    Friend WithEvents btnLiberar_ITEM As System.Windows.Forms.Button
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents banner_formulario As System.Windows.Forms.PictureBox
    Friend WithEvents titulo_banner_formulario As System.Windows.Forms.Label
End Class
