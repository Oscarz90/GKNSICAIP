Imports CapaNegocios
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Public Class FrmGraficasfaseuno
#Region "Variables globales"
    Private cod_empleado As String
    Private cve_usuario As Long
    Private cve_equipo As Long = 7
    'Banderas
    Private nivel_lets As Boolean = False
    Private nivel_lgs As Boolean = False
    Private nivel_componentes As Boolean = False
    Private nivel_cadena_valors As Boolean = False
    Private nivel_planta_gkn As Boolean = False
#End Region
#Region "Inicializa formulario"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa_formulario()
        obtiene_nivel_graficos()
    End Sub
    Private Sub inicializa_formulario()
        dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    End Sub
    'Nivel Grafico
    Private Sub obtiene_nivel_graficos()
        Dim oGraficasfaseuno As New Graficasfaseuno
        oGraficasfaseuno.usuario = Environment.UserName
        If cod_empleado Is Nothing Then
            oGraficasfaseuno.cod_empleado = ""
        Else
            oGraficasfaseuno.cod_empleado = cod_empleado
        End If
        oGraficasfaseuno.obtiene_nivel_graficos()
        Dim value As String = oGraficasfaseuno.nivel_grafico
        cve_usuario = oGraficasfaseuno.cve_usuario
        Select Case value
            Case "Planta"
                llena_formulario_Nivel_Planta()
                tipo_nivel_planta()
                nivel_planta_gkn = True
            Case "CadenaValor"
                llena_formulario_Nivel_Cadena_Valor()
                tipo_nivel_cadena_valor()
                nivel_cadena_valors = True
            Case "Componente"
                llena_formulario_Nivel_Componente()
                tipo_nivel_componente()
                nivel_componentes = True
            Case "LG"
                llena_formulario_Nivel_LG()
                tipo_nivel_lg()
                nivel_lgs = True
            Case "LET"
                llena_formulario_Nivel_LET()
                tipo_nivel_let()
                nivel_lets = True
            Case Else
                'MsgBox("no se q pedo")
        End Select
    End Sub
#End Region
#Region "Habilitar Niveles Graficos- Categorias"
    'Lets
    Private Sub tipo_nivel_let()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        rdbtnEquipo.Enabled = False
        rdbtnLinea.Enabled = False
        cbxEquipo.Enabled = False
        rdbtnEquipo.IsChecked = True
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
#Region "Llena formulario segun el Nivel"
    Private Sub llena_formulario_Nivel_Planta()
        Dim oNivel_Planta As New gfu_nivel_planta
        llena_cbx_CadenaValor(oNivel_Planta.nivel_planta_cadena_valor)
        llena_cbx_Componente(oNivel_Planta.nivel_planta_componente)
        llena_cbx_Equipo(oNivel_Planta.nivel_planta_equipos)
    End Sub
    Private Sub llena_formulario_Nivel_Cadena_Valor()
        Dim oNivel_CadenaValor As New gfu_nivel_cadena_valor
        oNivel_CadenaValor.cve_usuario = cve_usuario
        llena_cbx_CadenaValor(oNivel_CadenaValor.nivel_cadena_valor_CV)
        llena_cbx_Componente(oNivel_CadenaValor.nivel_cadena_valor_componente)
        llena_cbx_Equipo(oNivel_CadenaValor.nivel_cadena_valor_equipos)
    End Sub
    Private Sub llena_formulario_Nivel_Componente()
        Dim oNivel_Componente As New gfu_nivel_componente
        oNivel_Componente.cve_usuario = cve_usuario
        llena_cbx_Componente(oNivel_Componente.nivel_componente_componente)
        llena_cbx_Equipo(oNivel_Componente.nivel_componente_equipos)
    End Sub
    Private Sub llena_formulario_Nivel_LG()
        Dim oNivel_lg As New gfu_nivel_lg
        oNivel_lg.cve_lider = cve_usuario
        llena_cbx_Equipo(oNivel_lg.nivel_lg_equipos)
    End Sub
    Private Sub llena_formulario_Nivel_LET()
        Dim oGfu_nivel_let As New gfu_nivel_let
        oGfu_nivel_let.cve_equipo = cve_equipo
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGfu_nivel_let.llena_combo_equipo
        llena_cbx_equipo_linea()
    End Sub
#End Region
#Region "Llena combobox"
    Private Sub llena_cbx_CadenaValor(ByVal source As DataTable)
        cbxCadenaValor.ValueMember = "cve_cadena_valor"
        cbxCadenaValor.DisplayMember = "cadena"
        cbxCadenaValor.DataSource = source
        cbxCadenaValor.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_Componente(ByVal source As DataTable)
        cbxComponente.ValueMember = "cve_componente"
        cbxComponente.DisplayMember = "componente"
        cbxComponente.DataSource = source
        cbxComponente.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_Equipo(ByVal source As DataTable)
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = source
        cbxEquipo.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_Linea(ByVal source As DataTable)
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = source
        cbxLinea.SelectedIndex = -1
    End Sub
    Private Sub llena_cbx_equipo_linea()
        If cbxEquipo.SelectedIndex <> -1 Then
            Dim oEquipoLinea As New CapaNegocios.EquipoLinea
            oEquipoLinea.cve_equipo = cbxEquipo.SelectedValue
            cbxLinea.ValueMember = "cve_linea"
            cbxLinea.DisplayMember = "linea"
            cbxLinea.DataSource = oEquipoLinea.llena_combo_lineas()
            cbxLinea.SelectedIndex = -1
        End If
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
            If cbxLinea.SelectedIndex <> -1 Then
                Return True
            Else
                Return False
            End If
        ElseIf rdbtnEquipo.IsChecked Then
            If cbxEquipo.SelectedIndex <> -1 And (cbxLinea.SelectedIndex <> -1 Or chkTodasLineas.Checked) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    'Valida 5S q no sea por dias
    Private Function valida_cinco_S_mes() As Boolean
        If rdbtnCincoS.IsChecked And rdbtnDias.IsChecked Then
            Return False
        Else
            Return True
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
            If Diasdiferencia > 31 Then
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
        If valida_rdbtn_indicador() And valida_rdbtn_niveles() And valida_rdbtn_rango_fechas() And valida_cinco_S_mes() Then
            btnGraficar.Enabled = True
        Else
            btnGraficar.Enabled = False
        End If
    End Sub
#End Region
#Region "Eventos RadioButton Combobox Niveles"
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
    Private Sub cbxNiveles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCadenaValor.SelectedIndexChanged, cbxComponente.SelectedIndexChanged, cbxLinea.SelectedIndexChanged
        valida_btn_graficar()
    End Sub
    Private Sub cbxEquipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEquipo.SelectedIndexChanged
        If rdbtnEquipo.IsChecked And cbxEquipo.SelectedIndex <> -1 Then
            llena_cbx_equipo_linea()
        End If
    End Sub
#End Region
#Region "Eventos checkbox"
    Private Sub chkTodasLineas_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkTodasLineas.ToggleStateChanged
        If chkTodasLineas.Checked Then
            cbxLinea.SelectedIndex = -1
            cbxLinea.Enabled = False
        Else
            cbxLinea.Enabled = True
        End If
    End Sub
#End Region
#Region "Eventos Date time Picker"
    Private Sub dtpFecha_Inicial_Final_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicial.ValueChanged, dtpFechaFinal.ValueChanged
        valida_btn_graficar()
    End Sub
#End Region
#Region "(des)Habilita Combobox"
    Private Sub habilita_combobox_niveles(ByRef combo_box As ComboBox)
        combo_box.Enabled = True
    End Sub
    Private Sub deshabilita_combobox_niveles(ByRef combo_box As ComboBox)
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Cadena Valor
    Private Sub obtiene_oee_cadena_valor_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Componente
    Private Sub obtiene_oee_componente_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_componente = cbxComponente.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Linea
    Private Sub obtiene_oee_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_linea = cbxLinea.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Equipo
    Private Sub obtiene_oee_equipo_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_equipo = cbxEquipo.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'Oee Equipo-Linea
    Private Sub obtiene_oee_equipo_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_oee As New obtiene_oee
        oObtiene_oee.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_oee.cve_linea = cbxLinea.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRNFTi Cadena Valor
    Private Sub obtiene_nrfti_cadena_valor_dia_mes()
        'Objeto obtiene_nrfti Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Componente
    Private Sub obtiene_nrfti_componente_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_componente = cbxComponente.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Linea
    Private Sub obtiene_nrfti_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_linea = cbxLinea.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Equipo
    Private Sub obtiene_nrfti_equipo_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_equipo = cbxEquipo.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
        Me.radChartView1.ShowToolTip = True
        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
    End Sub
    'NRFTi Equipo-Linea
    Private Sub obtiene_nrfti_equipo_linea_dia_mes()
        'Objeto obtiene_oee Clase
        Dim oObtiene_nrfti As New obtiene_NRFTi
        oObtiene_nrfti.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_nrfti.cve_linea = cbxLinea.SelectedValue
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
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(194, 247, 24))
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
        oObtiene_cincoS.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        oObtiene_cincoS.cve_componente = cbxComponente.SelectedValue
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
        oObtiene_cincoS.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_cincoS.cve_equipo = cbxEquipo.SelectedValue
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
        oObtiene_cincoS.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_cincoS.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_gente.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        oObtiene_gente.cve_componente = cbxComponente.SelectedValue
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
        oObtiene_gente.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_gente.cve_equipo = cbxEquipo.SelectedValue
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
        oObtiene_gente.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_gente.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_seguridad.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        oObtiene_seguridad.cve_componente = cbxComponente.SelectedValue
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
        oObtiene_seguridad.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_seguridad.cve_equipo = cbxEquipo.SelectedValue
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
        oObtiene_seguridad.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_seguridad.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_costo.cve_cadena_valor = cbxCadenaValor.SelectedValue
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
        oObtiene_costo.cve_componente = cbxComponente.SelectedValue
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
        oObtiene_costo.cve_linea = cbxLinea.SelectedValue
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
        oObtiene_costo.cve_equipo = cbxEquipo.SelectedValue
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
        oObtiene_costo.cve_equipo = cbxEquipo.SelectedValue
        oObtiene_costo.cve_linea = cbxLinea.SelectedValue
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
#Region "Graficar "
    Private Sub obtener_grafica()
        If rdbtnOee.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_oee_planta_dia_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_oee_cadena_valor_dia_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_oee_componente_dia_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_oee_linea_dia_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_oee_equipo_dia_mes()
                Else
                    obtiene_oee_equipo_linea_dia_mes()
                End If
            End If
        ElseIf rdbtnNrfti.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_nrfti_planta_dia_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_nrfti_cadena_valor_dia_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_nrfti_componente_dia_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_nrfti_linea_dia_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_nrfti_equipo_dia_mes()
                Else
                    obtiene_nrfti_equipo_linea_dia_mes()
                End If
            End If
        ElseIf rdbtnCosto.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_costo_planta_dia_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_costo_cadena_valor_dia_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_costo_componente_dia_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_costo_linea_dia_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_costo_equipo_dia_mes()
                Else
                    obtiene_costo_equipo_linea_dia_mes()
                End If
            End If
        ElseIf rdbtnSeguridad.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_seguridad_planta_dia_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_seguridad_cadena_valor_dia_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_seguridad_componente_dia_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_seguridad_linea_dia_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_seguridad_equipo_dia_mes()
                Else
                    obtiene_seguridad_equipo_linea_dia_mes()
                End If
            End If
        ElseIf rdbtnCincoS.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_cincoS_planta_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_cincoS_cadena_valor_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_cincoS_componente_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_cincoS_linea_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_cincoS_equipo_mes()
                Else
                    obtiene_cincoS_equipo_linea_mes()
                End If
            End If
        ElseIf rdbtnGente.IsChecked Then
            If rdbtnPlanta.IsChecked Then
                obtiene_gente_planta_dia_mes()
            ElseIf rdbtnCadenaValor.IsChecked Then
                obtiene_gente_cadena_valor_dia_mes()
            ElseIf rdbtnComponente.IsChecked Then
                obtiene_gente_componente_dia_mes()
            ElseIf rdbtnLinea.IsChecked Then
                obtiene_gente_linea_dia_mes()
            ElseIf rdbtnEquipo.IsChecked Then
                If chkTodasLineas.Checked Then
                    obtiene_gente_equipo_dia_mes()
                Else
                    obtiene_gente_equipo_linea_dia_mes()
                End If
            End If
        End If
    End Sub
#End Region
    Private Sub btnGraficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficar.Click
        obtener_grafica()
    End Sub
End Class
