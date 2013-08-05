<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
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
        Me.RadTreeView1 = New Telerik.WinControls.UI.RadTreeView()
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTreeView1
        '
        Me.RadTreeView1.Location = New System.Drawing.Point(310, 12)
        Me.RadTreeView1.Name = "RadTreeView1"
        Me.RadTreeView1.Size = New System.Drawing.Size(309, 454)
        Me.RadTreeView1.SpacingBetweenNodes = -1
        Me.RadTreeView1.TabIndex = 0
        Me.RadTreeView1.Text = "RadTreeView1"
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 478)
        Me.Controls.Add(Me.RadTreeView1)
        Me.Name = "frmPermisos"
        Me.Text = "frmPermisos"
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTreeView1 As Telerik.WinControls.UI.RadTreeView
End Class
