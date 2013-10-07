<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.obtiene_cincos_cadena_mesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GKN_SICAIP_V2DataSet = New GKNSICAIP.GKN_SICAIP_V2DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCve = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha_Fin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.obtiene_cincos_cadena_mesTableAdapter = New GKNSICAIP.GKN_SICAIP_V2DataSetTableAdapters.obtiene_cincos_cadena_mesTableAdapter()
        CType(Me.obtiene_cincos_cadena_mesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GKN_SICAIP_V2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'obtiene_cincos_cadena_mesBindingSource
        '
        Me.obtiene_cincos_cadena_mesBindingSource.DataMember = "obtiene_cincos_cadena_mes"
        Me.obtiene_cincos_cadena_mesBindingSource.DataSource = Me.GKN_SICAIP_V2DataSet
        '
        'GKN_SICAIP_V2DataSet
        '
        Me.GKN_SICAIP_V2DataSet.DataSetName = "GKN_SICAIP_V2DataSet"
        Me.GKN_SICAIP_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCve)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha_Fin)
        Me.GroupBox1.Controls.Add(Me.dtpFecha_Inicio)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros Ejemplo"
        '
        'txtCve
        '
        Me.txtCve.Location = New System.Drawing.Point(77, 65)
        Me.txtCve.Name = "txtCve"
        Me.txtCve.Size = New System.Drawing.Size(100, 20)
        Me.txtCve.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cve_Filtro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha entre:"
        '
        'dtpFecha_Fin
        '
        Me.dtpFecha_Fin.Location = New System.Drawing.Point(301, 25)
        Me.dtpFecha_Fin.Name = "dtpFecha_Fin"
        Me.dtpFecha_Fin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha_Fin.TabIndex = 2
        '
        'dtpFecha_Inicio
        '
        Me.dtpFecha_Inicio.Location = New System.Drawing.Point(77, 25)
        Me.dtpFecha_Inicio.Name = "dtpFecha_Inicio"
        Me.dtpFecha_Inicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha_Inicio.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(691, 71)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(162, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 384)
        Me.Panel1.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.obtiene_cincos_cadena_mesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GKNSICAIP.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(859, 384)
        Me.ReportViewer1.TabIndex = 0
        '
        'obtiene_cincos_cadena_mesTableAdapter
        '
        Me.obtiene_cincos_cadena_mesTableAdapter.ClearBeforeFill = True
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        CType(Me.obtiene_cincos_cadena_mesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GKN_SICAIP_V2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCve As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents obtiene_cincos_cadena_mesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GKN_SICAIP_V2DataSet As GKNSICAIP.GKN_SICAIP_V2DataSet
    Friend WithEvents obtiene_cincos_cadena_mesTableAdapter As GKNSICAIP.GKN_SICAIP_V2DataSetTableAdapters.obtiene_cincos_cadena_mesTableAdapter
End Class
