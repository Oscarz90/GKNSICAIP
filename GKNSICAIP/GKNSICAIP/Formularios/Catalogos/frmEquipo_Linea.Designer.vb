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
        Me.btnAsignar_Todos = New System.Windows.Forms.Button()
        Me.btnAsignar_ITEM = New System.Windows.Forms.Button()
        Me.btnLiberar_ITEM = New System.Windows.Forms.Button()
        Me.btnLiberar_Todos = New System.Windows.Forms.Button()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbLibres
        '
        Me.lbLibres.FormattingEnabled = True
        Me.lbLibres.Location = New System.Drawing.Point(12, 98)
        Me.lbLibres.Name = "lbLibres"
        Me.lbLibres.Size = New System.Drawing.Size(259, 290)
        Me.lbLibres.TabIndex = 0
        '
        'lbAsignados
        '
        Me.lbAsignados.FormattingEnabled = True
        Me.lbAsignados.Location = New System.Drawing.Point(381, 98)
        Me.lbAsignados.Name = "lbAsignados"
        Me.lbAsignados.Size = New System.Drawing.Size(259, 290)
        Me.lbAsignados.TabIndex = 1
        '
        'btnAsignar_Todos
        '
        Me.btnAsignar_Todos.Location = New System.Drawing.Point(295, 124)
        Me.btnAsignar_Todos.Name = "btnAsignar_Todos"
        Me.btnAsignar_Todos.Size = New System.Drawing.Size(66, 39)
        Me.btnAsignar_Todos.TabIndex = 2
        Me.btnAsignar_Todos.Text = ">>"
        Me.btnAsignar_Todos.UseVisualStyleBackColor = True
        '
        'btnAsignar_ITEM
        '
        Me.btnAsignar_ITEM.Location = New System.Drawing.Point(295, 169)
        Me.btnAsignar_ITEM.Name = "btnAsignar_ITEM"
        Me.btnAsignar_ITEM.Size = New System.Drawing.Size(66, 39)
        Me.btnAsignar_ITEM.TabIndex = 3
        Me.btnAsignar_ITEM.Text = ">"
        Me.btnAsignar_ITEM.UseVisualStyleBackColor = True
        '
        'btnLiberar_ITEM
        '
        Me.btnLiberar_ITEM.Location = New System.Drawing.Point(295, 214)
        Me.btnLiberar_ITEM.Name = "btnLiberar_ITEM"
        Me.btnLiberar_ITEM.Size = New System.Drawing.Size(66, 39)
        Me.btnLiberar_ITEM.TabIndex = 4
        Me.btnLiberar_ITEM.Text = "<"
        Me.btnLiberar_ITEM.UseVisualStyleBackColor = True
        '
        'btnLiberar_Todos
        '
        Me.btnLiberar_Todos.Location = New System.Drawing.Point(295, 259)
        Me.btnLiberar_Todos.Name = "btnLiberar_Todos"
        Me.btnLiberar_Todos.Size = New System.Drawing.Size(66, 39)
        Me.btnLiberar_Todos.TabIndex = 5
        Me.btnLiberar_Todos.Text = "<<"
        Me.btnLiberar_Todos.UseVisualStyleBackColor = True
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(110, 25)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(312, 20)
        Me.txtLinea.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seleccione Linea:"
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(428, 23)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 8
        Me.btnImportar.Text = "Seleccionar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(484, 404)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(565, 404)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Equipos Asignados A Linea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Equipos No Asignados A Linea"
        '
        'frmEquipo_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 439)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.btnLiberar_Todos)
        Me.Controls.Add(Me.btnLiberar_ITEM)
        Me.Controls.Add(Me.btnAsignar_ITEM)
        Me.Controls.Add(Me.btnAsignar_Todos)
        Me.Controls.Add(Me.lbAsignados)
        Me.Controls.Add(Me.lbLibres)
        Me.Name = "frmEquipo_Linea"
        Me.Text = "Asignar Equipos a Lineas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLibres As System.Windows.Forms.ListBox
    Friend WithEvents lbAsignados As System.Windows.Forms.ListBox
    Friend WithEvents btnAsignar_Todos As System.Windows.Forms.Button
    Friend WithEvents btnAsignar_ITEM As System.Windows.Forms.Button
    Friend WithEvents btnLiberar_ITEM As System.Windows.Forms.Button
    Friend WithEvents btnLiberar_Todos As System.Windows.Forms.Button
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
