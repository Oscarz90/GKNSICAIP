﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempo_Ciclo
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
        Me.nudPiezas_Hora = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImportar_Linea = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnImportar_Modelo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.nudPiezas_Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudPiezas_Hora
        '
        Me.nudPiezas_Hora.Location = New System.Drawing.Point(104, 50)
        Me.nudPiezas_Hora.Name = "nudPiezas_Hora"
        Me.nudPiezas_Hora.Size = New System.Drawing.Size(120, 20)
        Me.nudPiezas_Hora.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Piezas Por Hora:"
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(104, 76)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(214, 20)
        Me.txtLinea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Linea:"
        '
        'btnImportar_Linea
        '
        Me.btnImportar_Linea.Location = New System.Drawing.Point(324, 74)
        Me.btnImportar_Linea.Name = "btnImportar_Linea"
        Me.btnImportar_Linea.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar_Linea.TabIndex = 4
        Me.btnImportar_Linea.Text = "Importar"
        Me.btnImportar_Linea.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(104, 102)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(214, 20)
        Me.txtModelo.TabIndex = 6
        '
        'btnImportar_Modelo
        '
        Me.btnImportar_Modelo.Location = New System.Drawing.Point(324, 100)
        Me.btnImportar_Modelo.Name = "btnImportar_Modelo"
        Me.btnImportar_Modelo.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar_Modelo.TabIndex = 7
        Me.btnImportar_Modelo.Text = "Importar"
        Me.btnImportar_Modelo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estatus:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(104, 154)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(295, 20)
        Me.dtpFecha.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 180)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(120, 20)
        Me.TextBox3.TabIndex = 12
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(104, 128)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(295, 20)
        Me.txtEmpleado.TabIndex = 13
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(261, 222)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 14
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(261, 222)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(342, 222)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmTiempo_Ciclo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 257)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnImportar_Modelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImportar_Linea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudPiezas_Hora)
        Me.Name = "frmTiempo_Ciclo"
        Me.Text = "Tiempo Ciclo"
        CType(Me.nudPiezas_Hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudPiezas_Hora As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImportar_Linea As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents btnImportar_Modelo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class