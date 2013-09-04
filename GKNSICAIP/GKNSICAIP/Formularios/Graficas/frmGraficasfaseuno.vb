Imports CapaNegocios
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Public Class FrmGraficasfaseuno
#Region "Variables globales"
    Private nivel_let As Boolean = False
    Private nivel_lgs As Boolean = False
    Private nivel_sl As Boolean = False
    Private nivel_scil As Boolean = False
    Private nivel_planta_gkn As Boolean = False
#End Region
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'nivel_lg()
        dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    End Sub
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
    Private Sub nivel_lets()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        rdbtnEquipo.Enabled = False
        nivel_let = True
    End Sub
    'LG
    Private Sub nivel_lg()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        nivel_lgs = True
    End Sub
    'Componente
    Private Sub nivel_componente()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        nivel_sl = True
    End Sub
    'Cadena Valor
    Private Sub nivel_cadena_valor()
        rdbtnPlanta.Enabled = False
        nivel_scil = True
    End Sub
    'Planta
    Private Sub nivel_planta()
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
            'Lets
            If nivel_let Then
                habilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = True
            Else
                'Otros
                habilita_combobox_niveles(cbxLinea)
                habilita_combobox_niveles(cbxEquipo)
                chkTodosEquipos.Visible = True
            End If

        Else
            'Lets
            If nivel_let Then
                deshabilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = False
            Else
                'Otros
                If Not rdbtnEquipo.IsChecked Then
                    deshabilita_combobox_niveles(cbxLinea)
                    deshabilita_combobox_niveles(cbxEquipo)
                    chkTodosEquipos.Visible = False
                End If
                chkTodosEquipos.Visible = False
            End If
        End If
        'Equipo
        If rdbtnEquipo.IsChecked Then
            habilita_combobox_niveles(cbxLinea)
            habilita_combobox_niveles(cbxEquipo)
            chkTodasLineas.Visible = True
        Else
            'Otros
            If Not nivel_let Then
                If Not rdbtnLinea.IsChecked Then
                    deshabilita_combobox_niveles(cbxLinea)
                    deshabilita_combobox_niveles(cbxEquipo)
                    chkTodasLineas.Visible = False
                End If
                chkTodasLineas.Visible = False
            End If
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
    Private Sub dibuja_grafica()
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.fecha_inicial = dtpFechaInicial.Value
        oObtiene_oee.fecha_final = dtpFechaFinal.Value
        Dim BarSeries1 As New BarSeries()
        Dim Barseries2 As New BarSeries
        Dim vDT As DataTable = oObtiene_oee.obtiene_oee_planta_dia

        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        For Each vDR As DataRow In vDT.Rows
            If vContador = vTotal Then
                Barseries2.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
            End If
            '            If vContador = 1 Then
            'vOEE_Acumulado_Final = vDR("oee")
            'ElseIf vContador > 1 Then
            'oee = vDR("oee")
            'cadenaXML += "<set value='" & oee & "' />"
            'End If
            vContador = vContador + 1
        Next

        'Dim series As New LineSeries()
        'series.DataPoints.Add(New CategoricalDataPoint(500, "Jan"))
        'series.DataPoints.Add(New CategoricalDataPoint(300, "Apr"))
        'series.DataPoints.Add(New CategoricalDataPoint(400, "Jul"))
        'series.DataPoints.Add(New CategoricalDataPoint(250, "Oct"))



        'Serie.ShowLabels = True
        'BarSeries1.ValueMember = "oee"
        'BarSeries1.CategoryMember = "dia_asignado"
        'BarSeries1.DataSource = oObtiene_oee.obtiene_oee_planta_dia
        'inicio
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis() 
        'listo
        CartesianArea1.GridDesign.AlternatingVerticalColor = False
        CartesianArea1.GridDesign.DrawVerticalFills = False
        CartesianArea1.ShowGrid = True
        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.IsPrimary = True
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        CategoricalAxis1.LabelRotationAngle = 270.0R
        CategoricalAxis1.LastLabelVisibility = AxisLastLabelVisibility.Hidden
        'CategoricalAxis1.Title = "Dias"
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.IsPrimary = True
        LinearAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        LinearAxis1.LabelRotationAngle = 300.0R
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        'LinearAxis1.Title = ""
        Me.radChartView1.Axes.AddRange(New Telerik.WinControls.UI.Axis() {CategoricalAxis1, LinearAxis1})
        Me.radChartView1.Location = New System.Drawing.Point(17, 213)
        Me.radChartView1.Name = "radChartView1"
        'BarSeries1.DataPoints.AddRange(New Telerik.Charting.DataPoint() {CategoricalDataPoint1, CategoricalDataPoint2, CategoricalDataPoint3, CategoricalDataPoint4, CategoricalDataPoint5})
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.LabelFormat = "{0:##.##}"
        BarSeries1.LabelMode = Telerik.WinControls.UI.BarLabelModes.Top
        BarSeries1.ShowLabels = True
        BarSeries1.VerticalAxis = LinearAxis1
        'lineSeria.Palette = new PaletteEntry(Color.Yellow, Color.Red);
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(249, 177, 41))
        Me.radChartView1.Series.AddRange(New Telerik.WinControls.UI.ChartSeries() {BarSeries1})
        'Me.radChartView1.Size = New System.Drawing.Size(1225, 456)
        'Me.radChartView1.TabIndex = 9
        'final
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(Barseries2)
    End Sub
#Region "Metodos para graficar"
    'GERENTE
    Private Sub graficos_gerente()
        'oee
        If rdbtnOee.IsChecked Then
            'Planta
            If rdbtnPlanta.IsChecked Then
                If rdbtnDias.IsChecked Then
                    dibuja_grafica()
                    

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
        graficos_gerente()
    End Sub
End Class
