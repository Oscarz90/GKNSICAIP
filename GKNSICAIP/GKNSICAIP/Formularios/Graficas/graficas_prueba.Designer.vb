Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficas_prueba
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
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim CategoricalAxis1 As Telerik.WinControls.UI.CategoricalAxis = New Telerik.WinControls.UI.CategoricalAxis()
        Dim LinearAxis1 As Telerik.WinControls.UI.LinearAxis = New Telerik.WinControls.UI.LinearAxis()
        Dim BarSeries1 As Telerik.WinControls.UI.BarSeries = New Telerik.WinControls.UI.BarSeries()
        Dim CategoricalDataPoint1 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint2 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint3 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint4 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Dim CategoricalDataPoint5 As Telerik.Charting.CategoricalDataPoint = New Telerik.Charting.CategoricalDataPoint()
        Me.RadChartView1 = New Telerik.WinControls.UI.RadChartView()
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadChartView1
        '
        CartesianArea1.GridDesign.AlternatingHorizontalColor = False
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.GridDesign.DrawHorizontalFills = False
        CartesianArea1.GridDesign.DrawVerticalFills = False
        CartesianArea1.GridDesign.DrawVerticalStripes = False
        CartesianArea1.ShowGrid = True
        Me.RadChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.IsPrimary = True
        CategoricalAxis1.LabelRotationAngle = 300.0R
        CategoricalAxis1.Title = ""
        LinearAxis1.AxisType = Telerik.Charting.AxisType.Second
        LinearAxis1.IsPrimary = True
        LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Title = ""
        Me.RadChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() {CategoricalAxis1, LinearAxis1})
        Me.RadChartView1.ForeColor = System.Drawing.Color.Maroon
        Me.RadChartView1.Location = New System.Drawing.Point(12, 12)
        Me.RadChartView1.Name = "RadChartView1"
        CategoricalDataPoint1.Category = "A"
        CategoricalDataPoint1.Label = 24.0R
        CategoricalDataPoint1.Value = 24.0R
        CategoricalDataPoint2.Category = "B"
        CategoricalDataPoint2.Label = 29.0R
        CategoricalDataPoint2.Value = 29.0R
        CategoricalDataPoint3.Category = "C"
        CategoricalDataPoint3.Label = 26.0R
        CategoricalDataPoint3.Value = 26.0R
        CategoricalDataPoint4.Category = "D"
        CategoricalDataPoint4.Label = 41.0R
        CategoricalDataPoint4.Value = 41.0R
        CategoricalDataPoint5.Category = "E"
        CategoricalDataPoint5.Label = 45.0R
        CategoricalDataPoint5.Value = 45.0R
        BarSeries1.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint1, CategoricalDataPoint2, CategoricalDataPoint3, CategoricalDataPoint4, CategoricalDataPoint5})
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries1.LegendTitle = "oscarmartez"
        BarSeries1.VerticalAxis = LinearAxis1
        Me.RadChartView1.Series.AddRange(New Telerik.WinControls.UI.ChartSeries() {BarSeries1})
        Me.RadChartView1.ShowLegend = True
        Me.RadChartView1.ShowToolTip = True
        Me.RadChartView1.ShowTrackBall = True
        Me.RadChartView1.Size = New System.Drawing.Size(894, 449)
        Me.RadChartView1.TabIndex = 0
        Me.RadChartView1.Text = "RadChartView1"
        '
        'Graficas_prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 473)
        Me.Controls.Add(Me.RadChartView1)
        Me.Name = "Graficas_prueba"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Graficas_prueba"
        CType(Me.RadChartView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadChartView1 As Telerik.WinControls.UI.RadChartView
End Class

