Imports CapaNegocios
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Public Class FrmGraficasfaseuno
#Region "Variables globales"
    Private nivel_lets As Boolean = False
    Private nivel_lgs As Boolean = False
    Private nivel_componentes As Boolean = False
    Private nivel_cadena_valors As Boolean = False
    Private nivel_planta_gkn As Boolean = False
#End Region
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tipo_nivel_let()
        'tipo_nivel_lg()
        'tipo_nivel_componente()
        'tipo_nivel_cadena_valor()
        'tipo_nivel_planta()
        'Dim user_maq As String
        'user_maq = Environment.UserName
        'MsgBox(user_maq)
        inicializa_formulario()
    End Sub
#Region "Inicializa formulario"
    Private Sub inicializa_formulario()
        dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    End Sub
#End Region
#Region "Validaciones"
    'GroupBox Indicador
    Private Function valida_rdbtn_indicador() As Boolean
        If rdbtnOee.IsChecked Then
            Return True
        ElseIf rdbtnNrfti.IsChecked Then
            Return True
        ElseIf rdbtnCosto.IsChecked Then
            Return True
        ElseIf rdbtnCosto.IsChecked Then
            Return True
        ElseIf rdbtnSeguridad.IsChecked Then
            Return True
        ElseIf rdbtnCincoS.IsChecked Then
            Return True
        ElseIf rdbtnGente.IsChecked Then
            Return True
        Else
            Return False
        End If
    End Function
    'GroupBox Niveles
    Private Function valida_rdbtn_niveles() As Boolean
        If rdbtnPlanta.IsChecked Then
            Return True
        ElseIf rdbtnCadenaValor.IsChecked Then
            If cbxCadenaValor.SelectedIndex <> -1 Then
                Return True
            Else
                Return False
            End If
        ElseIf rdbtnComponente.IsChecked Then
            If cbxComponente.SelectedIndex <> -1 Then
                Return True
            Else
                Return False
            End If
        ElseIf rdbtnLinea.IsChecked Then
            If cbxLinea.SelectedIndex <> -1 Or chkTodasLineas.Checked = True Then
                Return True
            Else
                Return False
            End If
        ElseIf rdbtnEquipo.IsChecked Then
            If cbxEquipo.SelectedIndex <> -1 Or chkTodosEquipos.Checked = True Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'GroupBox Fecha rangos
    Private Function valida_rdbtn_rango_fechas() As Boolean
        If rdbtnDias.IsChecked Then
            Return valida_dtp_rango_fechas_dia()
        ElseIf rdbtnMeses.IsChecked Then
            Return valida_dtp_rango_fechas_meses()
        Else
            Return False
        End If
    End Function
    'Dias valida
    Private Function valida_dtp_rango_fechas_dia() As Boolean
        If dtpFechaFinal.Value >= dtpFechaInicial.Value Then
            Dim Diasdiferencia As Long = DateDiff(DateInterval.Day, dtpFechaInicial.Value, dtpFechaFinal.Value)
            If Diasdiferencia > 30 Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function
    'Meses valida
    Private Function valida_dtp_rango_fechas_meses() As Boolean
        If dtpFechaFinal.Value >= dtpFechaInicial.Value Then
            Dim Diasdiferencia As Long = DateDiff(DateInterval.Month, dtpFechaInicial.Value, dtpFechaFinal.Value)
            If Diasdiferencia > 12 Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function
    'Valida boton graficar
    Private Sub valida_btn_graficar()
        If valida_rdbtn_indicador() And valida_rdbtn_niveles() And valida_rdbtn_rango_fechas() Then
            btnGraficar.Enabled = True
        Else
            btnGraficar.Enabled = False
        End If
    End Sub
#End Region
#Region "Habilitar Niveles Graficos- Categorias"
    'Lets
    Private Sub tipo_nivel_let()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        rdbtnEquipo.Enabled = False
        nivel_lets = True
    End Sub
    'LG
    Private Sub tipo_nivel_lg()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        rdbtnLinea.Enabled = False
        nivel_lgs = True
    End Sub
    'Componente
    Private Sub tipo_nivel_componente()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        nivel_componentes = True
    End Sub
    'Cadena Valor
    Private Sub tipo_nivel_cadena_valor()
        rdbtnPlanta.Enabled = False
        nivel_cadena_valors = True
    End Sub
    'Planta
    Private Sub tipo_nivel_planta()
        nivel_planta_gkn = True
    End Sub
#End Region
#Region "Eventos RadioButton Niveles"
    Private Sub rdbtnNiveles_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rdbtnCadenaValor.ToggleStateChanged, rdbtnComponente.ToggleStateChanged, rdbtnLinea.ToggleStateChanged, rdbtnEquipo.ToggleStateChanged
        'Cadena valor
        If rdbtnCadenaValor.IsChecked Then
            habilita_combobox_niveles(cbxCadenaValor)
        Else
            deshabilita_combobox_niveles(cbxCadenaValor)
        End If
        'Componente
        If rdbtnComponente.IsChecked Then
            habilita_combobox_niveles(cbxComponente)
        Else
            deshabilita_combobox_niveles(cbxComponente)
        End If
        'Linea
        If rdbtnLinea.IsChecked Then
            'Lets.
            If nivel_lets Then
                habilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = True
            Else
                'Otros
                habilita_combobox_niveles(cbxLinea)
            End If

        Else
            'Lets
            If nivel_lets Then
                deshabilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = False
            Else
                'Otros
                If Not rdbtnEquipo.IsChecked Then
                    deshabilita_combobox_niveles(cbxLinea)
                    deshabilita_combobox_niveles(cbxEquipo)
                    'chkTodosEquipos.Visible = False
                End If
                'chkTodosEquipos.Visible = False
            End If
        End If

        'Equipo
        If rdbtnEquipo.IsChecked Then
            habilita_combobox_niveles(cbxLinea)
            habilita_combobox_niveles(cbxEquipo)
            chkTodasLineas.Visible = True
        Else
            'Otros
            deshabilita_combobox_niveles(cbxEquipo)
                chkTodasLineas.Visible = False
        End If
        valida_btn_graficar()
    End Sub
    Private Sub rdbtnPlanta_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rdbtnPlanta.ToggleStateChanged
        valida_btn_graficar()
    End Sub
    Private Sub rdbtnOee_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rdbtnOee.ToggleStateChanged, rdbtnNrfti.ToggleStateChanged, rdbtnCosto.ToggleStateChanged, rdbtnSeguridad.ToggleStateChanged, rdbtnGente.ToggleStateChanged, rdbtnCincoS.ToggleStateChanged
        valida_btn_graficar()
    End Sub
#End Region
#Region "Eventos Date time Picker"
    Private Sub dtpFecha_Inicial_Final_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicial.ValueChanged, dtpFechaFinal.ValueChanged
        valida_btn_graficar()
    End Sub
#End Region
#Region "(des)Habilita Combobox"
    Private Sub habilita_combobox_niveles(ByRef combo_box As Telerik.WinControls.UI.RadDropDownList)
        combo_box.Enabled = True
    End Sub
    Private Sub deshabilita_combobox_niveles(ByRef combo_box As Telerik.WinControls.UI.RadDropDownList)
        combo_box.Enabled = False
    End Sub
#End Region
#Region "Eventos DateTimePicker"
    Private Sub rdbtnDias_Meses_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rdbtnDias.ToggleStateChanged, rdbtnMeses.ToggleStateChanged
        If rdbtnDias.IsChecked Then
            dtpFechaInicial.CustomFormat = "dd MMMM yyy"
            dtpFechaFinal.CustomFormat = "dd MMMM yyy"
        ElseIf rdbtnMeses.IsChecked Then
            dtpFechaInicial.CustomFormat = "MMMM yyy"
            dtpFechaFinal.CustomFormat = "MMMM yyy"
        End If
        valida_btn_graficar()
    End Sub
#End Region
#Region "Metodos graficar Oee"
    'Oee planta
    Private Sub obtiene_oee_planta_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_planta_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_planta_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Cadena Valor
    Private Sub obtiene_oee_cadena_valor_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_cadena_valor = 1
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_cadena_valor_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_cadena_valor_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Componente
    Private Sub obtiene_oee_componente_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_componente = 1
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_componente_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_componente_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Linea
    Private Sub obtiene_oee_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_linea = 1
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_linea_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Equipo
    Private Sub obtiene_oee_equipo_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_equipo = 1
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_equipo_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_equipo_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Equipo-Linea
    Private Sub obtiene_oee_equipo_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_equipo = 1
        oObtiene_oee.cve_linea = 54
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_equipo_linea_dia()
            vTotal = vDT.Rows.Count
            For Each vDR As DataRow In vDT.Rows
                If vContador = 1 Then
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
                Else
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
                End If
                vContador = vContador + 1
            Next
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_oee.obtiene_oee_equipo_linea_mes()
            vTotal = vDT.Rows.Count
            For Each vDR As DataRow In vDT.Rows
                If vContador = vTotal Then
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), "Acumulado"))
                Else
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
                End If
                vContador = vContador + 1
            Next
        End If



        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "Oee"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries2.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    
#End Region
#Region "Metodos graficar NRFTi"
    'NRNFTi planta
    Private Sub obtiene_nrfti_planta_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_planta_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_planta_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##,###}"
        BarSeries2.LabelFormat = "{0:##,##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRNFTi Cadena Valor
    Private Sub obtiene_nrfti_cadena_valor_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_cadena_valor = 1
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_cadena_valor_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_cadena_valor_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        'LinearAxis1.MajorStep = 10.0R
        'LinearAxis1.Maximum = 100
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##,###}"
        BarSeries2.LabelFormat = "{0:##,###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Componente
    Private Sub obtiene_nrfti_componente_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_componente = 1
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_componente_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_componente_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        'LinearAxis1.MajorStep = 10.0R
        'LinearAxis1.Maximum = 100
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:#,###}"
        BarSeries2.LabelFormat = "{0:#,###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Linea
    Private Sub obtiene_nrfti_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_linea = 1
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_linea_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        'LinearAxis1.MajorStep = 10.0R
        'LinearAxis1.Maximum = 100
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:#,###}"
        BarSeries2.LabelFormat = "{0:#,###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Equipo
    Private Sub obtiene_nrfti_equipo_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_equipo = 2
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_equipo_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_equipo_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        'LinearAxis1.MajorStep = 10.0R
        'LinearAxis1.Maximum = 100
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:#,###}"
        BarSeries2.LabelFormat = "{0:#,###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Equipo-Linea
    Private Sub obtiene_nrfti_equipo_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_equipo = 2
        oObtiene_nrfti.cve_linea = 54
        oObtiene_nrfti.fecha_inicial = dtpFechaInicial.Value
        oObtiene_nrfti.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        'Obtencion Datos Oee
        Dim vDT As New DataTable
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_equipo_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_nrfti.obtiene_nrfti_equipo_linea_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next

        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        'LinearAxis1.LabelRotationAngle = 300.0R
        'LinearAxis1.MajorStep = 10.0R
        'LinearAxis1.Maximum = 100
        LinearAxis1.Title = "NRFTi"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries1.LabelFormat = "{0:#,###}"
        BarSeries2.LabelFormat = "{0:#,###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
#End Region
#Region "Metodos graficar cincoS"
    '5s planta
    Private Sub obtiene_cincoS_planta_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_planta_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
    '5s cadena valor
    Private Sub obtiene_cincoS_cadena_valor_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.cve_cadena_valor = 1
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_cadena_valor_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
    '5s componente
    Private Sub obtiene_cincoS_componente_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.cve_componente = 1
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_componente_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
    '5s linea
    Private Sub obtiene_cincoS_linea_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.cve_linea = 1
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_linea_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
    '5s equipo
    Private Sub obtiene_cincoS_equipo_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.cve_equipo = 1
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_equipo_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
    '5s equipo-linea
    Private Sub obtiene_cincoS_equipo_linea_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_cincoS As New obtiene_cincoS
        oObtiene_cincoS.cve_equipo = 1
        oObtiene_cincoS.cve_linea = 54
        oObtiene_cincoS.fecha_inicial = dtpFechaInicial.Value
        oObtiene_cincoS.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        'Obtencion Datos
        BarSeries1.ValueMember = "promedio"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = oObtiene_cincoS.obtiene_cincos_equipo_linea_mes()
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
    End Sub
#End Region
#Region "Metodos graficar gente"
    'Gente planta
    Private Sub obtiene_gente_planta_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_planta_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_planta_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente cadena valor
    Private Sub obtiene_gente_cadena_valor_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.cve_cadena_valor = 1
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_cadena_valor_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_cadena_valor_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente componente
    Private Sub obtiene_gente_componente_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.cve_componente = 1
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_componente_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_componente_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente linea
    Private Sub obtiene_gente_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.cve_linea = 54
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_linea_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente equipo
    Private Sub obtiene_gente_equipo_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.cve_equipo = 3
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_equipo_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_equipo_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente equipo-linea
    Private Sub obtiene_gente_equipo_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_gente As New obtiene_gente
        oObtiene_gente.cve_equipo = 3
        oObtiene_gente.cve_linea = 54
        oObtiene_gente.fecha_inicial = dtpFechaInicial.Value
        oObtiene_gente.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_equipo_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_gente.obtiene_gente_equipo_linea_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "faltas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "retardos"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
#End Region
#Region "Metodos graficar seguridad"
    'Gente planta
    Private Sub obtiene_seguridad_planta_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_planta_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_planta_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente Cadena Valor
    Private Sub obtiene_seguridad_cadena_valor_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.cve_cadena_valor = 1
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_cadena_valor_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_cadena_valor_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente Componente
    Private Sub obtiene_seguridad_componente_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.cve_componente = 1
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_componente_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_componente_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente linea
    Private Sub obtiene_seguridad_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.cve_linea = 1
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_linea_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente equipo
    Private Sub obtiene_seguridad_equipo_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.cve_equipo = 1
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_equipo_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_equipo_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
    'Gente equipo-linea
    Private Sub obtiene_seguridad_equipo_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_seguridad As New obtiene_seguridad
        oObtiene_seguridad.cve_equipo = 1
        oObtiene_seguridad.cve_linea = 54
        oObtiene_seguridad.fecha_inicial = dtpFechaInicial.Value
        oObtiene_seguridad.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim BarSeries3 As New BarSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_equipo_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_seguridad.obtiene_seguridad_equipo_linea_mes()
        End If
        BarSeries1.ValueMember = "total"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        'LinearAxis1.MajorStep = 1.0R
        'LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        BarSeries1.ShowLabels = True
        'BarSeries2.ShowLabels = True
        'BarSeries3.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(0, 255, 126))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        For i As Integer = 0 To Me.radChartView1.Series.Count - 1
            Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
        Next i
    End Sub
#End Region
#Region "Metodos graficar costo"
    'Costo Planta
    Private Sub obtiene_costo_planta_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_planta_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_planta_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else
                If rdbtnDias.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                ElseIf rdbtnMeses.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                End If
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
    'Costo Cadena Valor
    Private Sub obtiene_costo_cadena_valor_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.cve_cadena_valor = 1
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_cadena_valor_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_cadena_valor_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else
                If rdbtnDias.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), Format(vDR("dia_asignado"), "{MMM-dd}") & " " & vDR("componente")))
                ElseIf rdbtnMeses.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), Format(vDR("dia_asignado"), "{yyyy - MMMM}") & " " & vDR("componente")))
                End If
                
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
    'Costo Componente
    Private Sub obtiene_costo_componente_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.cve_componente = 1
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_componente_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_componente_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else

                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), vDR("dia_asignado")))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), vDR("dia_asignado")))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
    'Costo Linea
    Private Sub obtiene_costo_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.cve_linea = 55
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_linea_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else

                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), vDR("dia_asignado")))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), vDR("dia_asignado")))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
    'Costo Equipo
    Private Sub obtiene_costo_equipo_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.cve_equipo = 4
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_equipo_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_equipo_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else

                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), vDR("dia_asignado")))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), vDR("dia_asignado")))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado")))
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
    'Costo equipo-linea
    Private Sub obtiene_costo_equipo_linea_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_costo As New obtiene_costo
        oObtiene_costo.cve_equipo = 4
        oObtiene_costo.cve_linea = 55
        oObtiene_costo.fecha_inicial = dtpFechaInicial.Value
        oObtiene_costo.fecha_final = dtpFechaFinal.Value
        'Creacion series
        Dim BarSeries1 As New BarSeries()
        Dim BarSeries2 As New BarSeries()
        Dim LineSeries1 As New LineSeries()
        'Obtencion Datos
        Dim vDT As DataTable = Nothing
        If rdbtnDias.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_equipo_linea_dia()
        ElseIf rdbtnMeses.IsChecked Then
            vDT = oObtiene_costo.obtiene_costo_equipo_linea_mes()
        End If
        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vTotal = vContador Then
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), "acumulado"))
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), "acumulado"))
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), "acumulado"))
            Else
                If rdbtnDias.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), vDR("dia_asignado") & " " & vContador))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), vDR("dia_asignado") & " " & vContador))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado") & " " & vContador))
                ElseIf rdbtnMeses.IsChecked Then
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("min_programados"), vDR("dia_asignado")))
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("min_excedentes"), vDR("dia_asignado")))
                    LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado")))
                End If
                
            End If
            vContador = vContador + 1
        Next
        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelRotationAngle = 270.0R

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        Dim LinearAxis2 As LinearAxis = New LinearAxis()
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis2.AxisType = AxisType.Second
        LinearAxis2.HorizontalLocation = AxisHorizontalLocation.Right
        LinearAxis1.Title = "Minutos"
        LinearAxis2.Title = "Costo $$"
        'Personalizacion
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:yyyy - MMMM}"
        End If
        'LinearAxis1.MajorStep = 10.0R
        'Series
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True
        LineSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        LineSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        LineSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries2.VerticalAxis = LinearAxis1
        LineSeries1.VerticalAxis = LinearAxis2
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(24, 134, 205))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 0, 102))
        LineSeries1.PointSize = New SizeF(10, 10)
        'Chartview
        Me.radChartView1.ShowToolTip = True
        'Me.radChartView1.ShowGrid = True
        'Me.radChartView1.ShowSmartLabels = True
        radChartView1.Series.Add(LineSeries1)
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
    End Sub
#End Region
#Region "Metodos Niveles"
    'GERENTE
    Private Sub graficos_gerente()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then
                    obtiene_oee_planta_dia_mes()
                ElseIf rdbtnMeses.IsChecked Then
                    obtiene_oee_planta_dia_mes()
                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Nrfti
        If rdbtnNrfti.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Costo
        If rdbtnCosto.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Seguridad
        If rdbtnSeguridad.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Gente
        If rdbtnGente.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        '5s
        If rdbtnCincoS.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
    End Sub
    'SCIL
    Private Sub graficos_scil()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Nrfti
        If rdbtnNrfti.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Costo
        If rdbtnCosto.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Seguridad
        If rdbtnSeguridad.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Gente
        If rdbtnGente.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        '5s
        If rdbtnCincoS.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
    End Sub
    'SL
    Private Sub graficos_supervisor_lider()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Nrfti
        If rdbtnNrfti.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Costo
        If rdbtnCosto.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Seguridad
        If rdbtnSeguridad.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Gente
        If rdbtnGente.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        '5s
        If rdbtnCincoS.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
    End Sub
    'LG
    Private Sub graficos_lider_grupo()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Nrfti
        If rdbtnNrfti.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Costo
        If rdbtnCosto.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Seguridad
        If rdbtnSeguridad.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Gente
        If rdbtnGente.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        '5s
        If rdbtnCincoS.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
    End Sub
    'LET
    Private Sub graficos_lider_equipo_tlatoani()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Nrfti
        If rdbtnNrfti.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Costo
        If rdbtnCosto.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Seguridad
        If rdbtnSeguridad.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        'Gente
        If rdbtnGente.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
        '5s
        If rdbtnCincoS.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Cadena Valor
            If rdbtnCadenaValor.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Componente
            If rdbtnComponente.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Linea
            If rdbtnLinea.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
            'Equipo
            If rdbtnEquipo.IsChecked Then
                If rdbtnDias.IsChecked Then

                ElseIf rdbtnMeses.IsChecked Then

                End If
            End If
        End If
    End Sub
#End Region
    Private Sub btnGraficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficar.Click
        obtiene_costo_planta_dia_mes()
    End Sub
End Class
