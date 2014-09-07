Imports CapaNegocios
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.Charting
Public Class FrmGraficasfaseuno
#Region "Variables globales"
    Private cod_empleado As String
    Private cve_usuario As Long
    Private cve_equipo As Long
    'Banderas
    Private nivel_lets As Boolean = False
    Private nivel_lgs As Boolean = False
    Private nivel_componentes As Boolean = False
    Private nivel_cadena_valors As Boolean = False
    Private nivel_planta_gkn As Boolean = False
    Private bandera_graficos As Integer
    'Variables validar rango datetime sql server 2005
    '01-01-1753
    Dim minDatetime As New DateTime(1753, 1, 1)
    '12-31-9999 23:59:59:997
    Dim maxDatetime As New DateTime(9999, 12, 31, 23, 59, 59, 997)
    Dim oG_Fase2 As G_Fase2
    Dim vFormato_Resultado As Integer = 0
    Dim vDatos_Obtenidos As DataTable
    Dim vIndicador_Seleccionado As String = ""
    Dim vIndicador_A_CALCULAR As String = ""
   


#End Region
#Region "Inicializa formulario"
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        obtiene_nivel_graficos()
        dtpFechaInicial.Format = DateTimePickerFormat.Custom
        dtpFechaFinal.Format = DateTimePickerFormat.Custom
    End Sub
    Public Sub inicializa_formulario(Optional ByVal codempleado As String = "", Optional ByVal cveequipo As Long = 0)
        cve_equipo = cveequipo
        cod_empleado = codempleado
    End Sub
    'Nivel Grafico
    Private Sub obtiene_nivel_graficos()
        'Obtiene nombre de Usuario-PC
        Dim oGraficasfaseuno As New Graficasfaseuno() With {.usuario = Environment.UserName}
        'Valida si el codigo de empleado es nulo
        If cod_empleado Is Nothing Then
            oGraficasfaseuno.cod_empleado = ""
        Else
            oGraficasfaseuno.cod_empleado = cod_empleado
        End If
        'Llama el Procedimiento Almacenado obtiene_nivel_graficos_usuario
        oGraficasfaseuno.obtiene_nivel_graficos()
        Dim value As String = oGraficasfaseuno.nivel_grafico
        cve_usuario = oGraficasfaseuno.cve_usuario
        Select Case value
            Case "Planta"
                llena_formulario_Nivel_Planta()
                tipo_nivel_planta()
                nivel_planta_gkn = True
            Case "Champion"
                llena_formulario_Nivel_Planta()
                tipo_nivel_planta()
                tipo_nivel_champion()
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
                If cve_equipo <> 0 And cve_usuario = 0 Then
                    llena_formulario_Nivel_LET()
                    tipo_nivel_let()
                    nivel_lets = True
                ElseIf cve_usuario <> 0 Then
                    llena_formulario_Nivel_LET_Equipos()
                    tipo_nivel_let()
                    nivel_lets = True
                End If

            Case Else

        End Select
        set_bandera_graficos(1)
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
    'Champion
    Private Sub tipo_nivel_champion()
        Dim oUsuario_indicador As New usuario_indicador() With {.cve_usuario = cve_usuario}
        oUsuario_indicador.obtiene_indicador()
        If Not IsNothing(oUsuario_indicador.indicador) Then
            If oUsuario_indicador.indicador <> "oee" Then
                deshabilita_radiobutton_niveles(rdbtnOee)
            End If
            If oUsuario_indicador.indicador <> "nrft" Then
                deshabilita_radiobutton_niveles(rdbtnNrfti)
            End If

            If oUsuario_indicador.indicador <> "costo" Then
                deshabilita_radiobutton_niveles(rdbtnCosto)
            End If
            If oUsuario_indicador.indicador <> "seguridad" Then
                deshabilita_radiobutton_niveles(rdbtnSeguridad)
            End If
            If oUsuario_indicador.indicador <> "gente" Then
                deshabilita_radiobutton_niveles(rdbtnGente)
            End If
            If oUsuario_indicador.indicador <> "cincos" Then
                deshabilita_radiobutton_niveles(rdbtnCincoS)
            End If
        End If
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
    Private Sub llena_cbx_Nivel_Planta_Lineas()
        Dim oNivel_Planta As New gfu_nivel_planta
        llena_cbx_Linea(oNivel_Planta.nivel_planta_linea)
    End Sub
    Private Sub llena_formulario_Nivel_Cadena_Valor()
        Dim oNivel_CadenaValor As New gfu_nivel_cadena_valor() With {.cve_usuario = cve_usuario}
        llena_cbx_CadenaValor(oNivel_CadenaValor.nivel_cadena_valor_CV)
        llena_cbx_Componente(oNivel_CadenaValor.nivel_cadena_valor_componente)
        llena_cbx_Equipo(oNivel_CadenaValor.nivel_cadena_valor_equipos)
    End Sub
    Private Sub llena_cbx_Nivel_Cadena_Valor_Lineas()
        Dim oNivel_CadenaValor As New gfu_nivel_cadena_valor() With {.cve_usuario = cve_usuario}
        llena_cbx_Linea(oNivel_CadenaValor.nivel_cadena_valor_linea)
    End Sub
    Private Sub llena_formulario_Nivel_Componente()
        Dim oNivel_Componente As New gfu_nivel_componente() With {.cve_usuario = cve_usuario}
        llena_cbx_Componente(oNivel_Componente.nivel_componente_componente)
        llena_cbx_Equipo(oNivel_Componente.nivel_componente_equipos)
    End Sub
    Private Sub llena_cbx_Nivel_Componente_Lineas()
        Dim oNivel_Componente As New gfu_nivel_componente() With {.cve_usuario = cve_usuario}
        llena_cbx_Linea(oNivel_Componente.nivel_componente_linea)
    End Sub
    Private Sub llena_formulario_Nivel_LG()
        Dim oNivel_lg As New gfu_nivel_lg() With {.cve_lider = cve_usuario}
        llena_cbx_Equipo(oNivel_lg.nivel_lg_equipos)
    End Sub
    Private Sub llena_formulario_Nivel_LET()
        Dim oGfu_nivel_let As New gfu_nivel_let() With {.cve_equipo = cve_equipo}
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGfu_nivel_let.llena_combo_equipo
        cbxEquipo.SelectedIndex = -1
        llena_cbx_equipo_linea()
    End Sub
    Private Sub llena_formulario_Nivel_LET_Equipos()
        Dim oGfu_nivel_let As New gfu_nivel_let() With {.cve_usuario = cve_usuario}
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGfu_nivel_let.llena_combo_equipo_let
        cbxEquipo.SelectedIndex = -1
        llena_cbx_equipo_linea()
    End Sub
    'Llena cbx Linea segun Nivel: Planta, Cadena_Valor, Componente
    Private Sub llena_cbx_lineas()
        If nivel_planta_gkn Then
            llena_cbx_Nivel_Planta_Lineas()
        ElseIf nivel_cadena_valors Then
            llena_cbx_Nivel_Cadena_Valor_Lineas()
        ElseIf nivel_componentes Then
            llena_cbx_Nivel_Componente_Lineas()
        End If
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
            Dim oEquipoLinea As New EquipoLinea() With {.cve_equipo = cbxEquipo.SelectedValue}
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
            vIndicador_Seleccionado = "OEE"
            Return True
        ElseIf rdbtnNrfti.IsChecked Then
            vIndicador_Seleccionado = "NRFTI"
            Return True
        ElseIf rdbtnCosto.IsChecked Then
            vIndicador_Seleccionado = "COSTO"
            Return True
        ElseIf rdbtnSeguridad.IsChecked Then
            vIndicador_Seleccionado = "SEGURIDAD"
            Return True
        ElseIf rdbtnCincoS.IsChecked Then
            vIndicador_Seleccionado = "CINCOS"
            Return True
        ElseIf rdbtnGente.IsChecked Then
            vIndicador_Seleccionado = "GENTE"
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
    'Valida Rango fecha valido sql server 2005
    Private Function valida_fecha_rango_max_min() As Boolean
        If dtpFechaInicial.Value >= minDatetime.Date And dtpFechaInicial.Value <= maxDatetime.Date And dtpFechaFinal.Value >= minDatetime.Date And dtpFechaFinal.Value <= maxDatetime.Date Then
            Return True
        Else
            Return False
        End If
    End Function
    'Valida boton graficar
    Private Sub valida_btn_graficar()
        If valida_rdbtn_indicador() And valida_rdbtn_niveles() And valida_rdbtn_rango_fechas() And valida_cinco_S_mes() And valida_fecha_rango_max_min() Then
            btnGraficar.Enabled = True
        Else
            btnGraficar.Enabled = False
        End If
    End Sub
#End Region
#Region "Eventos RadioButton Combobox Niveles"
    Private Sub rdbtnNiveles_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rdbtnCadenaValor.ToggleStateChanged, rdbtnComponente.ToggleStateChanged, rdbtnLinea.ToggleStateChanged, rdbtnEquipo.ToggleStateChanged
        'Cadena valor
        If rdbtnCadenaValor.IsChecked Then
            habilita_combobox_niveles(cbxCadenaValor)
        Else
            deshabilita_combobox_niveles(cbxCadenaValor)
            cbxCadenaValor.SelectedIndex = -1
        End If
        'Componente
        If rdbtnComponente.IsChecked Then
            habilita_combobox_niveles(cbxComponente)
        Else
            deshabilita_combobox_niveles(cbxComponente)
            cbxComponente.SelectedIndex = -1
        End If
        'Linea
        If rdbtnLinea.IsChecked Then
            'Lets.
            If nivel_lets Then
                habilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = True
            Else
                'Otros
                llena_cbx_lineas()
                habilita_combobox_niveles(cbxLinea)
            End If

        Else
            'Lets
            If nivel_lets Then
                deshabilita_combobox_niveles(cbxLinea)
                chkTodasLineas.Visible = False
                cbxLinea.SelectedIndex = -1
            ElseIf Not rdbtnEquipo.IsChecked Then
                deshabilita_combobox_niveles(cbxLinea)
                deshabilita_combobox_niveles(cbxEquipo)
                cbxLinea.SelectedIndex = -1
            End If
            cbxLinea.DataSource = Nothing
        End If

        'Equipo
        If rdbtnEquipo.IsChecked Then
            habilita_combobox_niveles(cbxLinea)
            habilita_combobox_niveles(cbxEquipo)
            chkTodasLineas.Visible = True
        Else
            'Otros
            deshabilita_combobox_niveles(cbxEquipo)
            cbxEquipo.SelectedIndex = -1
            chkTodasLineas.Checked = False
            chkTodasLineas.Visible = False
        End If
        valida_btn_graficar()
    End Sub
    Private Sub rdbtnPlanta_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rdbtnPlanta.ToggleStateChanged
        valida_btn_graficar()
    End Sub
    Private Sub rdbtnOee_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rdbtnOee.ToggleStateChanged, rdbtnNrfti.ToggleStateChanged, rdbtnCosto.ToggleStateChanged, rdbtnSeguridad.ToggleStateChanged, rdbtnGente.ToggleStateChanged, rdbtnCincoS.ToggleStateChanged
        valida_btn_graficar()


    End Sub
    Private Sub cbxNiveles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxCadenaValor.SelectedIndexChanged, cbxComponente.SelectedIndexChanged, cbxLinea.SelectedIndexChanged
        valida_btn_graficar()
    End Sub
    Private Sub cbxEquipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxEquipo.SelectedIndexChanged
        If rdbtnEquipo.IsChecked And cbxEquipo.SelectedIndex <> -1 Then
            llena_cbx_equipo_linea()
        End If
        valida_btn_graficar()
    End Sub
#End Region
#Region "Eventos checkbox"
    Private Sub chkTodasLineas_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles chkTodasLineas.ToggleStateChanged
        If chkTodasLineas.Checked Then
            cbxLinea.SelectedIndex = -1
            cbxLinea.Enabled = False
        Else
            cbxLinea.Enabled = True
        End If
        valida_btn_graficar()
    End Sub
#End Region
#Region "Eventos Date time Picker"
    Private Sub dtpFecha_Inicial_Final_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpFechaInicial.ValueChanged, dtpFechaFinal.ValueChanged
        valida_btn_graficar()
    End Sub
#End Region
#Region "Eventos DateTimePicker"
    Private Sub rdbtnDias_Meses_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rdbtnDias.ToggleStateChanged, rdbtnMeses.ToggleStateChanged
        If rdbtnDias.IsChecked Then
            dtpFechaInicial.CustomFormat = "dd MMMM yyy"
            dtpFechaFinal.CustomFormat = "dd MMMM yyy"
            vFormato_Resultado = 0
        ElseIf rdbtnMeses.IsChecked Then
            dtpFechaInicial.CustomFormat = "MMMM yyy"
            dtpFechaFinal.CustomFormat = "MMMM yyy"
            vFormato_Resultado = 1
        End If
        valida_btn_graficar()
    End Sub
#End Region
#Region "(des)Habilita Combobox & Radio Button"
    Private Sub habilita_combobox_niveles(ByRef combo_box As ComboBox)
        combo_box.Enabled = True
    End Sub
    Private Sub deshabilita_combobox_niveles(ByRef combo_box As ComboBox)
        combo_box.Enabled = False
    End Sub
    
    Private Sub deshabilita_radiobutton_niveles(ByRef rdbtn As RadRadioButton)
        rdbtn.Enabled = False
    End Sub
#End Region

#Region "Metodos graficar Oee"

    ''Metodo para la obtencion y proceso de Grafico OEE para todos los niveles
    Private Sub Obtiene_Grafico_OEE()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos
        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If
        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_OEE(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vFormato_Resultado, vNivel)


        'Creacion series
        Dim BarSeries1 As New BarSeries() With {.LegendTitle = "Oee"}
        Dim BarSeries2 As New BarSeries() With {.LegendTitle = "Acumulado"}
        Dim LineSeries1 As New LineSeries()

        ''El nivel Planta no lleva esta serie
        If vNivel <> 5 Then
            LineSeries1.LegendTitle = "Objetivo Oee"
        End If


        Me.radChartView1.ShowLegend = True
        Me.radChartView1.ShowSmartLabels = True
        BarSeries1.DrawLinesToLabels = True
        BarSeries1.SyncLinesToLabelsColor = True

        'Obtencion Datos Oee
        Dim vDT As New DataTable
        vDT = vDatos_Obtenidos

        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        If vTotal = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("Oee {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "Oee " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "Oee " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "Oee " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "Oee " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "Oee Planta GKN Driveline México"
            End If
        End If
        Dim vOEE_Acumulado As Double = 0


        For Each vDR As DataRow In vDT.Rows
            If vContador = 1 Then
                If IsDBNull(vDR("dia_asignado")) Then
                    vOEE_Acumulado = vDR("oee")
                Else
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
                    vOEE_Acumulado = vDR("oee")
                End If

            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("oee"), vDR("dia_asignado")))
                If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
                    If Not IsDBNull(vDR("objetivo")) Then
                        LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                    End If
                End If

            End If
            vContador = vContador + 1
        Next
        ''Acumulado
        BarSeries2.DataPoints.Add(New CategoricalDataPoint(vOEE_Acumulado, "Acumulado"))

        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_productividad.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 10.0R
        LinearAxis1.Maximum = 100
        LinearAxis1.Title = "% Oee"

        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True

        BarSeries1.LabelFormat = "{0:##}" ' & " %"
        BarSeries2.LabelFormat = "{0:##}" '& " %"
        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            LineSeries1.LabelFormat = "{0:##.#}" '& " %"
        End If


        BarSeries1.Font = New Font("Segoe UI", 11)
        BarSeries2.Font = New Font("Segoe UI", 11)

        BarSeries1.HorizontalAxis = CategoricalAxis1
        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            LineSeries1.HorizontalAxis = CategoricalAxis1
        End If


        BarSeries1.VerticalAxis = LinearAxis1
        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            LineSeries1.VerticalAxis = LinearAxis1
        End If


        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(255, 205, 47))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(246, 172, 38))

        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            LineSeries1.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries1.BorderColor = Color.FromArgb(202, 0, 0)
        End If


        Me.radChartView1.ShowToolTip = True

        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            radChartView1.Series.Add(LineSeries1)
        End If

        If vNivel <> 5 Then ''El nivel Planta no lleva esta serie
            BarSeries1.CombineMode = ChartSeriesCombineMode.None
            BarSeries2.CombineMode = ChartSeriesCombineMode.None
            LineSeries1.CombineMode = ChartSeriesCombineMode.None
        End If

        BarSeries1.LabelMode = BarLabelModes.Top
        BarSeries2.LabelMode = BarLabelModes.Top

    End Sub

    ''Metodo para Obtener Reportes
    Private Sub Obtiene_Reporte_OEE(ByVal vEsResumen As Boolean)
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()
        Me.dgvTabla.DataSource = vDatos_Obtenidos

        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("disponibilidad").HeaderText = "DISPONIBILIDAD"
        Me.dgvTabla.Columns("disponibilidad").Width = 80
        Me.dgvTabla.Columns("disponibilidad").Name = "disponibilidad"

        Me.dgvTabla.Columns("desempeno").HeaderText = "DESEMPEÑO"
        Me.dgvTabla.Columns("desempeno").Width = 80
        Me.dgvTabla.Columns("desempeno").Name = "desempeno"

        Me.dgvTabla.Columns("calidad").HeaderText = "CALIDAD"
        Me.dgvTabla.Columns("calidad").Width = 80
        Me.dgvTabla.Columns("calidad").Name = "calidad"

        Me.dgvTabla.Columns("oee").HeaderText = "OEE"
        Me.dgvTabla.Columns("oee").Width = 80
        Me.dgvTabla.Columns("oee").Name = "oee"

        Me.dgvTabla.Columns("pzas_ok").HeaderText = "PZAS OK"
        Me.dgvTabla.Columns("pzas_ok").Width = 80
        Me.dgvTabla.Columns("pzas_ok").Name = "pzas_ok"

        Me.dgvTabla.Columns("pzas_desecho").HeaderText = "PZAS DESECHO"
        Me.dgvTabla.Columns("pzas_desecho").Width = 80
        Me.dgvTabla.Columns("pzas_desecho").Name = "pzas_desecho"

        Me.dgvTabla.Columns("pzas_rechazo").HeaderText = "PZAS RECHAZO"
        Me.dgvTabla.Columns("pzas_rechazo").Width = 80
        Me.dgvTabla.Columns("pzas_rechazo").Name = "pzas_rechazo"

        Me.dgvTabla.Columns("desecho_aplicable").HeaderText = "DESECHO APLICABLE"
        Me.dgvTabla.Columns("desecho_aplicable").Width = 80
        Me.dgvTabla.Columns("desecho_aplicable").Name = "desecho_aplicable"

        Me.dgvTabla.Columns("adeudo").HeaderText = "ADEUDO"
        Me.dgvTabla.Columns("adeudo").Width = 80
        Me.dgvTabla.Columns("adeudo").Name = "adeudo"

        Me.dgvTabla.Columns("p_planeado").HeaderText = "PARO PLANEADO"
        Me.dgvTabla.Columns("p_planeado").Width = 80
        Me.dgvTabla.Columns("p_planeado").Name = "p_planeado"

        Me.dgvTabla.Columns("p_no_planeado").HeaderText = "PARO NO PLANEADO"
        Me.dgvTabla.Columns("p_no_planeado").Width = 80
        Me.dgvTabla.Columns("p_no_planeado").Name = "p_no_planeado"

        Me.dgvTabla.Columns("t_turno").HeaderText = "TIEMPO TURNO"
        Me.dgvTabla.Columns("t_turno").Width = 80
        Me.dgvTabla.Columns("t_turno").Name = "t_turno"

        Me.dgvTabla.Columns("t_comedor").HeaderText = "TIEMPO COMEDOR"
        Me.dgvTabla.Columns("t_comedor").Width = 80
        Me.dgvTabla.Columns("t_comedor").Name = "t_comedor"

        Me.dgvTabla.Columns("t_carga").HeaderText = "TIEMPO CARGA"
        Me.dgvTabla.Columns("t_carga").Width = 80
        Me.dgvTabla.Columns("t_carga").Name = "t_carga"

        Me.dgvTabla.Columns("t_operacion").HeaderText = "TIEMPO OPERACION"
        Me.dgvTabla.Columns("t_operacion").Width = 80
        Me.dgvTabla.Columns("t_operacion").Name = "t_operacion"

        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"



        If vEsResumen = True Then
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("disponibilidad").IsVisible = True
            Me.dgvTabla.Columns("desempeno").IsVisible = True
            Me.dgvTabla.Columns("calidad").IsVisible = True
            Me.dgvTabla.Columns("oee").IsVisible = True
            Me.dgvTabla.Columns("pzas_ok").IsVisible = False
            Me.dgvTabla.Columns("pzas_desecho").IsVisible = False
            Me.dgvTabla.Columns("pzas_rechazo").IsVisible = False
            Me.dgvTabla.Columns("desecho_aplicable").IsVisible = False
            Me.dgvTabla.Columns("adeudo").IsVisible = False
            Me.dgvTabla.Columns("p_planeado").IsVisible = False
            Me.dgvTabla.Columns("p_no_planeado").IsVisible = False
            Me.dgvTabla.Columns("t_turno").IsVisible = False
            Me.dgvTabla.Columns("t_comedor").IsVisible = False
            Me.dgvTabla.Columns("t_carga").IsVisible = False
            Me.dgvTabla.Columns("t_operacion").IsVisible = False
            Me.dgvTabla.Columns("objetivo").IsVisible = True
        Else
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("disponibilidad").IsVisible = True
            Me.dgvTabla.Columns("desempeno").IsVisible = True
            Me.dgvTabla.Columns("calidad").IsVisible = True
            Me.dgvTabla.Columns("oee").IsVisible = True
            Me.dgvTabla.Columns("pzas_ok").IsVisible = True
            Me.dgvTabla.Columns("pzas_desecho").IsVisible = True
            Me.dgvTabla.Columns("pzas_rechazo").IsVisible = True
            Me.dgvTabla.Columns("desecho_aplicable").IsVisible = True
            Me.dgvTabla.Columns("adeudo").IsVisible = True
            Me.dgvTabla.Columns("p_planeado").IsVisible = True
            Me.dgvTabla.Columns("p_no_planeado").IsVisible = True
            Me.dgvTabla.Columns("t_turno").IsVisible = True
            Me.dgvTabla.Columns("t_comedor").IsVisible = True
            Me.dgvTabla.Columns("t_carga").IsVisible = True
            Me.dgvTabla.Columns("t_operacion").IsVisible = True
            Me.dgvTabla.Columns("objetivo").IsVisible = True
        End If

    End Sub
#End Region

#Region "Metodos graficar NRFTi"

    Private Sub Obtiene_Grafica_NRFT()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos
        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If

        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_NRFT(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vFormato_Resultado, vNivel)

        'Creacion series
        Dim BarSeries1 As New BarSeries() With {.LegendTitle = "nrfti"}
        Dim BarSeries2 As New BarSeries() With {.LegendTitle = "Acumulado"}
        Dim LineSeries1 As New LineSeries()

        If vNivel <> 5 Then
            LineSeries1.LegendTitle = "Objetivo NRFTi"
        End If

        Me.radChartView1.ShowLegend = True
        Me.radChartView1.ShowSmartLabels = True
        BarSeries1.DrawLinesToLabels = True
        BarSeries1.SyncLinesToLabelsColor = True
        BarSeries1.Font = New Font("Segoe UI", 11)
        BarSeries2.Font = New Font("Segoe UI", 11)

        'Obtencion Datos Oee
        Dim vDT As New DataTable
        vDT = vDatos_Obtenidos

        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count
        If vTotal = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("NRFTi ( PPM'S ) {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "NRFTi ( PPM'S ) " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "NRFTi ( PPM'S ) " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "NRFTi ( PPM'S ) " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "NRFTi ( PPM'S ) " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "NRFTi ( PPM'S ) Planta GKN Driveline México"
            End If
        End If
        If vNivel = 0 Or vNivel = 1 Then
            For Each vDR As DataRow In vDT.Rows
                If rdbtnDias.IsChecked Then
                    If vContador = 1 Then
                        BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
                    Else
                        BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
                        If Not IsDBNull(vDR("objetivo")) Then
                            LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                        End If
                    End If
                ElseIf rdbtnMeses.IsChecked Then
                    If vContador = 1 Then
                        BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
                    Else
                        BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
                        If Not IsDBNull(vDR("objetivo")) Then
                            LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                        End If
                    End If
                End If
                vContador = vContador + 1
            Next
        ElseIf vNivel = 2 Or vNivel = 3 Or vNivel = 4 Then

            For Each vDR As DataRow In vDT.Rows
                If vContador = 1 Then
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
                Else
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
                    If Not IsDBNull(vDR("objetivo")) Then
                        LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                    End If
                End If
                vContador = vContador + 1
            Next
        ElseIf vNivel = 5 Then
            For Each vDR As DataRow In vDT.Rows
                If vContador = 1 Then
                    BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), "Acumulado"))
                Else
                    BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("nrfti"), vDR("dia_asignado")))
                End If
                vContador = vContador + 1
            Next
        End If
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_calidad.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.Title = "NRFTi (PPM'S)"
        BarSeries1.ShowLabels = True
        BarSeries2.ShowLabels = True

        BarSeries1.LabelFormat = "{0:#,###}"
        BarSeries2.LabelFormat = "{0:#,###}"

        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(55, 96, 146))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(37, 64, 97))

        Me.radChartView1.ShowToolTip = True
        Me.radChartView1.Series.Add(BarSeries1)
        Me.radChartView1.Series.Add(BarSeries2)

        If vNivel <> 5 Then
            LineSeries1.LabelFormat = "{0:##,###}"
            LineSeries1.HorizontalAxis = CategoricalAxis1
            LineSeries1.VerticalAxis = LinearAxis1
            LineSeries1.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries1.BorderColor = Color.FromArgb(202, 0, 0)
            radChartView1.Series.Add(LineSeries1)
            LineSeries1.CombineMode = ChartSeriesCombineMode.None
        End If

        If vNivel <> 5 Then
            BarSeries1.CombineMode = ChartSeriesCombineMode.None
            BarSeries2.CombineMode = ChartSeriesCombineMode.None
        End If

        BarSeries1.LabelMode = BarLabelModes.Top
        BarSeries2.LabelMode = BarLabelModes.Top

        If (LinearAxis1.ActualRange.Maximum = 0) Then
            LinearAxis1.Maximum = 5
        End If

        For Each controller As ChartViewController In Me.radChartView1.Controllers
            Dim control As SmartLabelsController = TryCast(controller, SmartLabelsController)
            If control IsNot Nothing Then
                control.Strategy.DistanceToLabel = CInt(Fix(25.0))
                Me.radChartView1.View.PerformRefresh(Me.radChartView1.View, False)
            End If
        Next controller

    End Sub

    Private Sub Obtiene_Reporte_NRFT(ByVal vEsResumen As Boolean)
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()
        Me.dgvTabla.DataSource = vDatos_Obtenidos

        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("nrfti").HeaderText = "NRFTi"
        Me.dgvTabla.Columns("nrfti").Width = 80
        Me.dgvTabla.Columns("nrfti").Name = "nrfti"

        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"

        Me.dgvTabla.Columns("pzas_ok").HeaderText = "PZAS_OK"
        Me.dgvTabla.Columns("pzas_ok").Width = 80
        Me.dgvTabla.Columns("pzas_ok").Name = "pzas_ok"

        Me.dgvTabla.Columns("pzas_desecho").HeaderText = "PZAS_DESECHO"
        Me.dgvTabla.Columns("pzas_desecho").Width = 80
        Me.dgvTabla.Columns("pzas_desecho").Name = "pzas_desecho"

        Me.dgvTabla.Columns("desecho_aplicable").HeaderText = "DESECHO APLICABLE"
        Me.dgvTabla.Columns("desecho_aplicable").Width = 80
        Me.dgvTabla.Columns("desecho_aplicable").Name = "desecho_aplicable"

        Me.dgvTabla.Columns("adeudos").HeaderText = "ADEUDO"
        Me.dgvTabla.Columns("adeudos").Width = 80
        Me.dgvTabla.Columns("adeudos").Name = "adeudos"

        Me.dgvTabla.Columns("comentarios").HeaderText = "COMENTARIOS"
        Me.dgvTabla.Columns("comentarios").Width = 300
        Me.dgvTabla.Columns("comentarios").Name = "comentarios"

        If vEsResumen = True Then
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("nrfti").IsVisible = True
            Me.dgvTabla.Columns("objetivo").IsVisible = True
            Me.dgvTabla.Columns("desecho_aplicable").IsVisible = False
            Me.dgvTabla.Columns("pzas_ok").IsVisible = False
            Me.dgvTabla.Columns("pzas_desecho").IsVisible = False
            Me.dgvTabla.Columns("adeudos").IsVisible = False
            Me.dgvTabla.Columns("comentarios").IsVisible = False
        Else
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("nrfti").IsVisible = True
            Me.dgvTabla.Columns("objetivo").IsVisible = True
            Me.dgvTabla.Columns("desecho_aplicable").IsVisible = True
            Me.dgvTabla.Columns("pzas_ok").IsVisible = True
            Me.dgvTabla.Columns("pzas_desecho").IsVisible = True
            Me.dgvTabla.Columns("adeudos").IsVisible = True
            Me.dgvTabla.Columns("comentarios").IsVisible = True
        End If

    End Sub

#End Region

#Region "Metodos graficar cincoS"

    Private Sub Obtiene_Grafica_CincoS()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos
        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If

        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_Cinco_S(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vNivel)

        'Creacion series
        Dim BarSeries1 As New BarSeries() With {.LegendTitle = "Admon Visual"}
        Dim BarSeries2 As New BarSeries() With {.LegendTitle = "5's"} 'mantto_autto
        Dim BarSeries3 As New BarSeries() With {.LegendTitle = "Mantto Autto"} 'admon_visual
        Dim BarSeries4 As New BarSeries() With {.LegendTitle = "Promedio 5's"} 'cincoS
        Dim LineSeries1 As New LineSeries()
        If vNivel <> 5 Then
            LineSeries1.LegendTitle = "Objetivo 5's"
        End If

        Me.radChartView1.ShowLegend = True
        'Obtencion Datos
        Dim vDT As DataTable = vDatos_Obtenidos

        If vDT.Rows.Count = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("5's {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "5's " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "5's " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "5's " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "5's " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "5's Planta GKN Driveline México"
            End If
        End If

        BarSeries1.ValueMember = "administracion_visual"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "cinco_S"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "mantenimiento_autonomo"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        BarSeries4.ValueMember = "promedio"
        BarSeries4.CategoryMember = "dia_asignado"
        BarSeries4.DataSource = vDT
        If vNivel <> 5 Then
            LineSeries1.ValueMember = "objetivo"
            LineSeries1.CategoryMember = "dia_asignado"
            LineSeries1.DataSource = vDT
        End If
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_cincos.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.MajorStep = 1.0R
        LinearAxis1.Maximum = 5
        LinearAxis1.Title = "5's"
        'serie1
        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:##.#}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        BarSeries1.VerticalAxis = LinearAxis1
        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(217, 217, 217))
        'serie2
        BarSeries2.ShowLabels = True
        BarSeries2.LabelFormat = "{0:##.#}"
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(255, 192, 0))
        'serie3
        BarSeries3.ShowLabels = True
        BarSeries3.LabelFormat = "{0:##.#}"
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(37, 64, 97))
        'serie4
        BarSeries4.ShowLabels = True
        BarSeries4.LabelFormat = "{0:##.#}"
        BarSeries4.Palette = New PaletteEntry(Color.FromArgb(127, 127, 127))


        If vNivel <> 5 Then
            LineSeries1.LabelFormat = "{0:##.#}"
            LineSeries1.HorizontalAxis = CategoricalAxis1
            LineSeries1.VerticalAxis = LinearAxis1
            LineSeries1.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries1.BorderColor = Color.FromArgb(202, 0, 0)
        End If
        Me.radChartView1.ShowToolTip = True

        radChartView1.Series.Add(BarSeries1)
        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        radChartView1.Series.Add(BarSeries4)

        If vNivel <> 5 Then
            radChartView1.Series.Add(LineSeries1)
        End If

        If vNivel <> 5 Then
            LineSeries1.CombineMode = ChartSeriesCombineMode.None
            BarSeries1.CombineMode = ChartSeriesCombineMode.Cluster
            BarSeries2.CombineMode = ChartSeriesCombineMode.Cluster
            BarSeries3.CombineMode = ChartSeriesCombineMode.Cluster
            BarSeries4.CombineMode = ChartSeriesCombineMode.Cluster
        End If

    End Sub

    Private Sub Obtiene_Reporte_CincoS()
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()
        Me.dgvTabla.DataSource = vDatos_Obtenidos

        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("mantenimiento_autonomo").HeaderText = "MANTENIMIENTO AUTONOMO"
        Me.dgvTabla.Columns("mantenimiento_autonomo").Width = 80
        Me.dgvTabla.Columns("mantenimiento_autonomo").Name = "mantenimiento_autonomo"

        Me.dgvTabla.Columns("administracion_visual").HeaderText = "ADMINISTRACION VISUAL"
        Me.dgvTabla.Columns("administracion_visual").Width = 80
        Me.dgvTabla.Columns("administracion_visual").Name = "administracion_visual"

        Me.dgvTabla.Columns("cinco_S").HeaderText = "CINCO_S"
        Me.dgvTabla.Columns("cinco_S").Width = 80
        Me.dgvTabla.Columns("cinco_S").Name = "cinco_S"

        Me.dgvTabla.Columns("promedio").HeaderText = "PROMEDIO"
        Me.dgvTabla.Columns("promedio").Width = 80
        Me.dgvTabla.Columns("promedio").Name = "promedio"

        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"

        'Me.dgvTabla.Columns("comentarios").HeaderText = "COMENTARIOS"
        'Me.dgvTabla.Columns("comentarios").Width = 300
        'Me.dgvTabla.Columns("comentarios").Name = "comentarios"



        Me.dgvTabla.Columns("planta").IsVisible = True
        Me.dgvTabla.Columns("cadena_valor").IsVisible = True
        Me.dgvTabla.Columns("componente").IsVisible = True
        Me.dgvTabla.Columns("equipo").IsVisible = True
        Me.dgvTabla.Columns("linea").IsVisible = True
        Me.dgvTabla.Columns("dia_asignado").IsVisible = True
        Me.dgvTabla.Columns("mantenimiento_autonomo").IsVisible = True
        Me.dgvTabla.Columns("administracion_visual").IsVisible = True
        Me.dgvTabla.Columns("cinco_S").IsVisible = True
        Me.dgvTabla.Columns("promedio").IsVisible = True
        Me.dgvTabla.Columns("objetivo").IsVisible = True
        'Me.dgvTabla.Columns("comentarios").IsVisible = True
    End Sub
#End Region

#Region "Metodos graficar gente"

    Private Sub Obtiene_Grafica_Gente()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos
        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If

        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_Gente(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vFormato_Resultado, vNivel)


        'Creacion series

        Dim BarSeries2 As New BarSeries() With {.LegendTitle = "faltas"}
        Dim BarSeries3 As New BarSeries() With {.LegendTitle = "retardos"}

        Dim BarSeries4 As New BarSeries() With {.LegendTitle = "Faltas_Acumulado"}
        Dim BarSeries5 As New BarSeries() With {.LegendTitle = "Retardos_Acumulado"}

        Dim LineSeries1 As New LineSeries()
        If vNivel <> 5 Then
            LineSeries1.LegendTitle = "Objetivo Gente"
        End If
        Me.radChartView1.ShowLegend = True
        'Obtencion Datos
        Dim vDT As DataTable = vDatos_Obtenidos

        If vDT.Rows.Count = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else

            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("Gente {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "Gente " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "Gente " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "Gente " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "Gente " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "Gente Planta GKN Driveline México"
            End If
        End If

        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        Dim vFaltas_Aux As Integer = 0
        Dim vRetardos_Aux As Integer = 0

        vTotal = vDT.Rows.Count

        For Each vDR As DataRow In vDT.Rows
            If vContador = 1 Then
                vFaltas_Aux = vDR("faltas")
                vRetardos_Aux = vDR("retardos")
            Else
                BarSeries2.DataPoints.Add(New CategoricalDataPoint(vDR("faltas"), vDR("dia_asignado")))
                BarSeries3.DataPoints.Add(New CategoricalDataPoint(vDR("retardos"), vDR("dia_asignado")))
                If vNivel <> 5 Then
                    If Not IsDBNull(vDR("objetivo")) Then
                        LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                    End If
                End If
            End If
            vContador = vContador + 1
        Next

        BarSeries4.DataPoints.Add(New CategoricalDataPoint(vFaltas_Aux, "Acumulado"))
        BarSeries5.DataPoints.Add(New CategoricalDataPoint(vRetardos_Aux, "Acumulado"))

        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_gente.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - dd}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If


        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second

        LinearAxis1.Title = "Gente"

        If vNivel <> 3 Or vNivel <> 5 Then
            BarSeries2.ShowLabels = True
            BarSeries3.ShowLabels = True
        End If
        BarSeries4.ShowLabels = True
        BarSeries5.ShowLabels = True


        BarSeries2.LabelFormat = "{0:###}"
        If vNivel <> 0 Or vNivel <> 5 Then
            LineSeries1.LabelFormat = "{0:###}"
        End If

        BarSeries3.HorizontalAxis = CategoricalAxis1
        BarSeries3.VerticalAxis = LinearAxis1
        BarSeries2.HorizontalAxis = CategoricalAxis1
        BarSeries2.VerticalAxis = LinearAxis1

        If vNivel <> 5 Then
            LineSeries1.HorizontalAxis = CategoricalAxis1
            LineSeries1.VerticalAxis = LinearAxis1
        End If

        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(233, 37, 43))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(255, 191, 0))

        BarSeries4.Palette = New PaletteEntry(Color.FromArgb(233, 37, 43))
        BarSeries5.Palette = New PaletteEntry(Color.FromArgb(255, 191, 0))

        If vNivel <> 5 Then
            LineSeries1.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries1.BorderColor = Color.FromArgb(202, 0, 0)
        End If

        Me.radChartView1.ShowTrackBall = True
        Me.radChartView1.ShowToolTip = True


        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)

        radChartView1.Series.Add(BarSeries4)
        radChartView1.Series.Add(BarSeries5)

        If vNivel <> 5 Then
            radChartView1.Series.Add(LineSeries1)
        End If

        If vNivel <> 5 Then
            LineSeries1.CombineMode = ChartSeriesCombineMode.None
            BarSeries2.CombineMode = ChartSeriesCombineMode.Stack
            BarSeries3.CombineMode = ChartSeriesCombineMode.Stack

            BarSeries4.CombineMode = ChartSeriesCombineMode.Stack
            BarSeries5.CombineMode = ChartSeriesCombineMode.Stack
        End If
        If vNivel = 5 Then
            For i As Integer = 0 To Me.radChartView1.Series.Count - 1
                Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
            Next i
        End If

        If (LinearAxis1.ActualRange.Maximum = 0) Then
            LinearAxis1.Maximum = 5
        End If
    End Sub

    Private Sub Obtiene_Reporte_Gente()
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()

        Me.dgvTabla.DataSource = vDatos_Obtenidos


        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").IsVisible = True
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").IsVisible = True
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").IsVisible = True
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").IsVisible = True
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").IsVisible = True
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").IsVisible = True
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("faltas").HeaderText = "FALTA"
        Me.dgvTabla.Columns("faltas").IsVisible = True
        Me.dgvTabla.Columns("faltas").Width = 80
        Me.dgvTabla.Columns("faltas").Name = "faltas"

        Me.dgvTabla.Columns("retardos").HeaderText = "RETARDOS"
        Me.dgvTabla.Columns("retardos").IsVisible = True
        Me.dgvTabla.Columns("retardos").Width = 80
        Me.dgvTabla.Columns("retardos").Name = "retardos"

        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").IsVisible = True
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"

        Me.dgvTabla.Columns("comentarios_faltas").HeaderText = "COMENTARIOS FALTAS"
        Me.dgvTabla.Columns("comentarios_faltas").IsVisible = True
        Me.dgvTabla.Columns("comentarios_faltas").Width = 300
        Me.dgvTabla.Columns("comentarios_faltas").Name = "comentarios_faltas"

        Me.dgvTabla.Columns("comentarios_retardos").HeaderText = "COMENTARIOS RETARDOS"
        Me.dgvTabla.Columns("comentarios_retardos").IsVisible = True
        Me.dgvTabla.Columns("comentarios_retardos").Width = 300
        Me.dgvTabla.Columns("comentarios_retardos").Name = "comentarios_retardos"

    End Sub

#End Region

#Region "Metodos graficar seguridad"

    Private Sub Obtiene_Grafica_Seguridad()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos

        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If

        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_Seguridad(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vFormato_Resultado, vNivel)


        'Creacion series
        Dim BarSeries1 As New BarSeries() With {.LegendTitle = "acumulado"}
        Dim BarSeries2 As New BarSeries() With {.LegendTitle = "nuevas"}
        Dim BarSeries3 As New BarSeries() With {.LegendTitle = "resueltas"}
        Dim LineSeries1 As New LineSeries()
        If vNivel <> 5 Then
            LineSeries1.LegendTitle = "Objetivo Seguridad"
        End If
        Me.radChartView1.ShowLegend = True
        'Obtencion Datos
        Dim vDT As DataTable = vDatos_Obtenidos

        If vDT.Rows.Count = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("Seguridad {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "Seguridad " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "Seguridad " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "Seguridad " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "Seguridad " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "Seguridad Planta GKN Driveline México"
            End If

        End If

        BarSeries1.ValueMember = "acumulado"
        BarSeries1.CategoryMember = "dia_asignado"
        BarSeries1.DataSource = vDT
        BarSeries2.ValueMember = "nuevas"
        BarSeries2.CategoryMember = "dia_asignado"
        BarSeries2.DataSource = vDT
        BarSeries3.ValueMember = "resueltas"
        BarSeries3.CategoryMember = "dia_asignado"
        BarSeries3.DataSource = vDT
        If vNivel <> 5 Then
            LineSeries1.ValueMember = "objetivo"
            LineSeries1.CategoryMember = "dia_asignado"
            LineSeries1.DataSource = vDT
        End If
        'Cartesian Area, CategoricalAxis, LinearAxis
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis()
        Dim LinearAxis1 As LinearAxis = New LinearAxis()
        'Personalizacion

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_seguridad.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        Me.radChartView1.AreaDesign = CartesianArea1
        CategoricalAxis1.LabelFitMode = AxisLabelFitMode.Rotate
        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        CategoricalAxis1.LabelRotationAngle = 270.0R
        LinearAxis1.AxisType = AxisType.Second
        LinearAxis1.Title = "CI"
        BarSeries1.LabelFormat = "{0:###}"
        BarSeries2.LabelFormat = "{0:###}"
        BarSeries1.HorizontalAxis = CategoricalAxis1
        If vNivel <> 5 Then
            LineSeries1.LabelFormat = "{0:###}"
            LineSeries1.HorizontalAxis = CategoricalAxis1
            LineSeries1.VerticalAxis = LinearAxis1
            LineSeries1.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries1.BorderColor = Color.FromArgb(202, 0, 0)
        End If

        BarSeries1.VerticalAxis = LinearAxis1

        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(255, 191, 0))
        BarSeries2.Palette = New PaletteEntry(Color.FromArgb(233, 37, 43))
        BarSeries3.Palette = New PaletteEntry(Color.FromArgb(36, 177, 22))

        Me.radChartView1.ShowTrackBall = True
        Me.radChartView1.ShowToolTip = True
        If vNivel <> 5 Then
            radChartView1.Series.Add(LineSeries1)
        End If

        radChartView1.Series.Add(BarSeries2)
        radChartView1.Series.Add(BarSeries3)
        radChartView1.Series.Add(BarSeries1)

        If vNivel <> 5 Then
            LineSeries1.CombineMode = ChartSeriesCombineMode.None
        End If

        If (LinearAxis1.ActualRange.Maximum = 0) Then
            LinearAxis1.Maximum = 5
        End If
    End Sub

    Private Sub Obtiene_Reporte_Seguridad(ByVal vEsResumen As Boolean)
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()
        Me.dgvTabla.DataSource = vDatos_Obtenidos

        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("nuevas").HeaderText = "NUEVAS"
        Me.dgvTabla.Columns("nuevas").Width = 80
        Me.dgvTabla.Columns("nuevas").Name = "nuevas"

        Me.dgvTabla.Columns("resueltas").HeaderText = "RESUELTAS"
        Me.dgvTabla.Columns("resueltas").Width = 80
        Me.dgvTabla.Columns("resueltas").Name = "resueltas"

        Me.dgvTabla.Columns("acumulado").HeaderText = "ACUMULADO"
        Me.dgvTabla.Columns("acumulado").Width = 80
        Me.dgvTabla.Columns("acumulado").Name = "acumulado"


        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"

        Me.dgvTabla.Columns("comentarios_nuevas").HeaderText = "COMENTARIOS NUEVAS"
        Me.dgvTabla.Columns("comentarios_nuevas").Width = 300
        Me.dgvTabla.Columns("comentarios_nuevas").Name = "comentarios_nuevas"

        Me.dgvTabla.Columns("comentarios_resueltas").HeaderText = "COMENTARIOS RESUELTAS"
        Me.dgvTabla.Columns("comentarios_resueltas").Width = 300
        Me.dgvTabla.Columns("comentarios_resueltas").Name = "comentarios_resueltas"

        If vEsResumen = True Then
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("nuevas").IsVisible = True
            Me.dgvTabla.Columns("resueltas").IsVisible = True
            Me.dgvTabla.Columns("acumulado").IsVisible = True
            Me.dgvTabla.Columns("objetivo").IsVisible = True
            Me.dgvTabla.Columns("comentarios_nuevas").IsVisible = False
            Me.dgvTabla.Columns("comentarios_resueltas").IsVisible = False
        Else
            Me.dgvTabla.Columns("planta").IsVisible = True
            Me.dgvTabla.Columns("cadena_valor").IsVisible = True
            Me.dgvTabla.Columns("componente").IsVisible = True
            Me.dgvTabla.Columns("equipo").IsVisible = True
            Me.dgvTabla.Columns("linea").IsVisible = True
            Me.dgvTabla.Columns("dia_asignado").IsVisible = True
            Me.dgvTabla.Columns("nuevas").IsVisible = True
            Me.dgvTabla.Columns("resueltas").IsVisible = True
            Me.dgvTabla.Columns("acumulado").IsVisible = True
            Me.dgvTabla.Columns("objetivo").IsVisible = True
            Me.dgvTabla.Columns("comentarios_nuevas").IsVisible = True
            Me.dgvTabla.Columns("comentarios_resueltas").IsVisible = True
        End If

    End Sub

#End Region

#Region "Metodos graficar costo"

    Private Sub Obtiene_Grafica_Costo()
        Dim vCve_Equipo As Integer = 0
        Dim vCve_Linea As Integer = 0
        Dim vCve_Componente As Integer = 0
        Dim vCve_CadenaValor As Integer = 0
        Dim vNivel As Integer = 0
        Dim vF_Inicial As DateTime = Date.Now
        Dim vF_Final As DateTime = Date.Now

        ''Obtencion de Datos
        vF_Inicial = dtpFechaInicial.Value
        vF_Final = dtpFechaFinal.Value
        oG_Fase2 = New G_Fase2

        ''Revicion de Nivel Elegido
        If rdbtnEquipo.IsChecked = True Then
            If chkTodasLineas.Checked = False Then ''---Nivel Equipo_Linea
                vCve_Equipo = cbxEquipo.SelectedValue
                vCve_Linea = cbxLinea.SelectedValue
                vNivel = 0
            Else ''---Nivel Equipo
                vCve_Equipo = cbxEquipo.SelectedValue
                vNivel = 1
            End If
        End If
        If rdbtnLinea.IsChecked = True Then ''---Nivel Linea
            vCve_Linea = cbxLinea.SelectedValue
            vNivel = 2
        ElseIf rdbtnComponente.IsChecked = True Then ''---Nivel Componente
            vCve_Componente = cbxComponente.SelectedValue
            vNivel = 3
        ElseIf rdbtnCadenaValor.IsChecked = True Then ''---Nivel Cadena Valor
            vCve_CadenaValor = cbxCadenaValor.SelectedValue
            vNivel = 4
        ElseIf rdbtnPlanta.IsChecked = True Then ''---Nivel Planta
            vNivel = 5
        End If

        ''Obtencion de Informacion
        vDatos_Obtenidos = oG_Fase2.Obten_Costo(vF_Inicial, vF_Final, vCve_Equipo, vCve_Linea, vCve_Componente, vCve_CadenaValor, vFormato_Resultado, vNivel)

        Grafica_Minutos(vNivel, vDatos_Obtenidos)
        Grafica_Costo(vNivel, vDatos_Obtenidos)

    End Sub

    Private Sub Grafica_Minutos(ByVal vNivel As Integer, ByVal vDatos_Obtenidos As DataTable)
        'Creacion series
        Dim BarSeries1 As New BarSeries() With {.LegendTitle = "Min. Reales"}
        Dim LineSeries3 As New LineSeries()
        If vNivel <> 5 Then
            LineSeries3.LegendTitle = "Objetivo mins"
            Me.radChartView1.ShowLegend = True
        End If

        'Obtencion Datos
        Dim vDT As DataTable = vDatos_Obtenidos

        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        If vTotal = 0 Then
            habilita_etiqueta_datos()
            Me.radChartView1.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("Costo {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "Costo " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "Costo " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "Costo " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "Costo " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "Costo Planta GKN Driveline México"
            End If
        End If
        Dim vMin_Program_Aux As Integer = 0
        Dim vObjetivo_tcdm_Aux As Integer = 0

        For Each vDR As DataRow In vDT.Rows
            If 1 = vContador Then
                vMin_Program_Aux = vDR("mins_reales")
                vObjetivo_tcdm_Aux = vDR("objetivo_tcdm")
            Else
                BarSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("mins_reales"), vDR("dia_asignado")))
                If vNivel <> 5 Then
                    If Not IsDBNull(vDR("objetivo_tcdm")) Then
                        LineSeries3.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo_tcdm"), vDR("dia_asignado")))
                    End If
                End If
            End If
            vContador = vContador + 1
        Next

        BarSeries1.DataPoints.Add(New CategoricalDataPoint(vMin_Program_Aux, "acumulado"))

        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Me.radChartView1.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis() With {.LabelFitMode = AxisLabelFitMode.Rotate, .LabelRotationAngle = 270.0R}

        'LinearAxis
        Dim LinearAxis1 As LinearAxis = New LinearAxis() With {.AxisType = AxisType.Second, .Title = "Minutos"}
        'Personalizacion

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_costo.jpg"

        'Legend & Position
        Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Bottom

        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        'Series
        BarSeries1.ForeColor = Color.White

        BarSeries1.ShowLabels = True
        BarSeries1.LabelFormat = "{0:###}"

        If vNivel <> 5 Then
            LineSeries3.LabelFormat = "{0:###}"
        End If
        BarSeries1.HorizontalAxis = CategoricalAxis1
        If vNivel <> 5 Then
            LineSeries3.HorizontalAxis = CategoricalAxis1
        End If

        BarSeries1.VerticalAxis = LinearAxis1

        If vNivel <> 5 Then
            LineSeries3.VerticalAxis = LinearAxis1
        End If

        BarSeries1.Palette = New PaletteEntry(Color.FromArgb(62, 105, 157))

        If vNivel <> 5 Then
            LineSeries3.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries3.BorderColor = Color.FromArgb(202, 0, 0)
        End If

        Me.radChartView1.ShowTrackBall = True
        Me.radChartView1.ShowToolTip = True

        'Chartview

        radChartView1.Series.Add(BarSeries1)

        If vNivel <> 5 Then
            radChartView1.Series.Add(LineSeries3)
        End If
        'BarSeries1.CombineMode = ChartSeriesCombineMode.Stack
        If vNivel <> 5 Then
            LineSeries3.CombineMode = ChartSeriesCombineMode.None
        End If

        If (LinearAxis1.ActualRange.Maximum = 0) Then
            LinearAxis1.Maximum = 5
        End If
    End Sub

    Private Sub Grafica_Costo(ByVal vNivel As Integer, ByVal vDatos_Obtenidos As DataTable)
        'Creacion series
        Dim LineSeries1 As New LineSeries() With {.LegendTitle = "Costo"}
        Dim LineSeries3 As New LineSeries()
        If vNivel <> 5 Then
            LineSeries3.LegendTitle = "Objetivo Costo"
            Me.CharSecundario.ShowLegend = True
        End If

        'Obtencion Datos
        Dim vDT As DataTable = vDatos_Obtenidos

        'Llenado de las series
        Dim vTotal As Integer = 1
        Dim vContador As Integer = 1
        vTotal = vDT.Rows.Count

        If vTotal = 0 Then
            habilita_etiqueta_datos()
            Me.CharSecundario.Title = ""
        Else
            If vNivel = 0 Then
                Me.radChartView1.Title = String.Format("Costo {0} - {1}", cbxEquipo.Text, cbxLinea.Text)
            ElseIf vNivel = 1 Then
                Me.radChartView1.Title = "Costo " & cbxEquipo.Text
            ElseIf vNivel = 2 Then
                Me.radChartView1.Title = "Costo " & cbxLinea.Text
            ElseIf vNivel = 3 Then
                Me.radChartView1.Title = "Costo " & cbxComponente.Text
            ElseIf vNivel = 4 Then
                Me.radChartView1.Title = "Costo " & cbxCadenaValor.Text
            ElseIf vNivel = 5 Then
                Me.radChartView1.Title = "Costo Planta GKN Driveline México"
            End If

        End If
        Dim vMin_Program_Aux As Integer = 0
        Dim vMin_Excedentes_Aux As Integer = 0
        Dim vCosto_Aux As Integer = 0
        Dim vObjetivo_tcdm_Aux As Integer = 0

        For Each vDR As DataRow In vDT.Rows
            If 1 = vContador Then
                vMin_Program_Aux = vDR("mins_programados")
                vMin_Excedentes_Aux = vDR("mins_excedentes")
                vCosto_Aux = vDR("costo")
                vObjetivo_tcdm_Aux = vDR("objetivo_tcdm")
            Else
                LineSeries1.DataPoints.Add(New CategoricalDataPoint(vDR("costo"), vDR("dia_asignado")))
                If vNivel <> 5 Then
                    If Not IsDBNull(vDR("objetivo")) Then
                        LineSeries3.DataPoints.Add(New CategoricalDataPoint(vDR("objetivo"), vDR("dia_asignado")))
                    End If
                End If
            End If
            vContador = vContador + 1
        Next

        LineSeries1.DataPoints.Add(New CategoricalDataPoint(vCosto_Aux, "acumulado"))

        'Cartesian Area
        Dim CartesianArea1 As CartesianArea = New CartesianArea()
        Me.CharSecundario.AreaDesign = CartesianArea1
        'Categorical axis
        Dim CategoricalAxis1 As CategoricalAxis = New CategoricalAxis() With {.LabelFitMode = AxisLabelFitMode.Rotate, .LabelRotationAngle = 270.0R}

        'LinearAxis
        Dim LinearAxis2 As LinearAxis = New LinearAxis() With {.AxisType = AxisType.Second, .HorizontalLocation = AxisHorizontalLocation.Left, .Title = "Costo $$"}
        'Personalizacion

        'Logo Indicador
        picboxIndicador.ImageLocation = Application.StartupPath & "\graficas_fase_uno\logo_indicador_costo.jpg"

        Me.CharSecundario.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
        Me.CharSecundario.ChartElement.LegendPosition = LegendPosition.Bottom

        If rdbtnDias.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:dd - MMM}"
        ElseIf rdbtnMeses.IsChecked Then
            CategoricalAxis1.LabelFormat = "{0:MMM - yyyy}"
        End If
        'Series
        LineSeries1.ShowLabels = True

        If vNivel <> 5 Then
            LineSeries3.LabelFormat = "{0:###}"
        End If
        LineSeries1.LabelFormat = "$ " & "{0:##.##}"
        LineSeries1.HorizontalAxis = CategoricalAxis1

        If vNivel <> 5 Then
            LineSeries3.HorizontalAxis = CategoricalAxis1
        End If

        LineSeries1.VerticalAxis = LinearAxis2

        LineSeries1.Palette = New PaletteEntry(Color.FromArgb(127, 127, 127))

        If vNivel <> 5 Then
            LineSeries3.Palette = New PaletteEntry(Color.FromArgb(202, 0, 0))
            LineSeries3.BorderColor = Color.FromArgb(202, 0, 0)
        End If

        LineSeries1.BorderColor = Color.FromArgb(127, 127, 127)

        LineSeries1.PointSize = New SizeF(10, 10)
        Me.CharSecundario.ShowTrackBall = True
        Me.CharSecundario.ShowToolTip = True

        'Chartview
        CharSecundario.Series.Add(LineSeries1)

        If vNivel <> 5 Then
            CharSecundario.Series.Add(LineSeries3)
        End If

        LineSeries1.CombineMode = ChartSeriesCombineMode.None
        If vNivel <> 5 Then
            LineSeries3.CombineMode = ChartSeriesCombineMode.None
        End If
    End Sub

    Private Sub Obtiene_Reporte_Costo()
        Me.dgvTabla.DataSource = Nothing
        Me.dgvTabla.Columns.Clear()
        Me.dgvTabla.DataSource = vDatos_Obtenidos

        Me.dgvTabla.Columns("planta").HeaderText = "PLANTA"
        Me.dgvTabla.Columns("planta").Width = 150
        Me.dgvTabla.Columns("planta").Name = "planta"

        Me.dgvTabla.Columns("cadena_valor").HeaderText = "CADENA VALOR"
        Me.dgvTabla.Columns("cadena_valor").Width = 150
        Me.dgvTabla.Columns("cadena_valor").Name = "cadena_valor"

        Me.dgvTabla.Columns("componente").HeaderText = "COMPONENTE"
        Me.dgvTabla.Columns("componente").Width = 150
        Me.dgvTabla.Columns("componente").Name = "componente"

        Me.dgvTabla.Columns("equipo").HeaderText = "EQUIPO"
        Me.dgvTabla.Columns("equipo").Width = 170
        Me.dgvTabla.Columns("equipo").Name = "equipo"

        Me.dgvTabla.Columns("linea").HeaderText = "LINEA"
        Me.dgvTabla.Columns("linea").Width = 150
        Me.dgvTabla.Columns("linea").Name = "linea"

        Me.dgvTabla.Columns("dia_asignado").HeaderText = "FECHA"
        Me.dgvTabla.Columns("dia_asignado").Width = 170
        Me.dgvTabla.Columns("dia_asignado").Name = "dia_asignado"

        Me.dgvTabla.Columns("objetivo_tcdm").HeaderText = "OBJETIVO TCDM"
        Me.dgvTabla.Columns("objetivo_tcdm").Width = 80
        Me.dgvTabla.Columns("objetivo_tcdm").Name = "objetivo_tcdm"

        Me.dgvTabla.Columns("mins_reales").HeaderText = "MINS REALES"
        Me.dgvTabla.Columns("mins_reales").Width = 80
        Me.dgvTabla.Columns("mins_reales").Name = "mins_reales"

        Me.dgvTabla.Columns("mins_programados").HeaderText = "MINS PROGRAMADOS"
        Me.dgvTabla.Columns("mins_programados").Width = 80
        Me.dgvTabla.Columns("mins_programados").Name = "mins_programados"

        Me.dgvTabla.Columns("mins_excedentes").HeaderText = "MINS EXCEDENTES"
        Me.dgvTabla.Columns("mins_excedentes").Width = 80
        Me.dgvTabla.Columns("mins_excedentes").Name = "mins_excedentes"

        Me.dgvTabla.Columns("costo").HeaderText = "COSTO"
        Me.dgvTabla.Columns("costo").Width = 80
        Me.dgvTabla.Columns("costo").Name = "costo"

        Me.dgvTabla.Columns("precio").HeaderText = "PRECIO"
        Me.dgvTabla.Columns("precio").Width = 80
        Me.dgvTabla.Columns("precio").Name = "precio"

        Me.dgvTabla.Columns("objetivo").HeaderText = "OBJETIVO"
        Me.dgvTabla.Columns("objetivo").Width = 80
        Me.dgvTabla.Columns("objetivo").Name = "objetivo"

        Me.dgvTabla.Columns("comentarios").HeaderText = "COMENTARIOS"
        Me.dgvTabla.Columns("comentarios").Width = 300
        Me.dgvTabla.Columns("comentarios").Name = "comentarios"

        Me.dgvTabla.Columns("planta").IsVisible = True
        Me.dgvTabla.Columns("cadena_valor").IsVisible = True
        Me.dgvTabla.Columns("componente").IsVisible = True
        Me.dgvTabla.Columns("equipo").IsVisible = True
        Me.dgvTabla.Columns("linea").IsVisible = True
        Me.dgvTabla.Columns("dia_asignado").IsVisible = True
        Me.dgvTabla.Columns("objetivo_tcdm").IsVisible = True
        Me.dgvTabla.Columns("mins_reales").IsVisible = True
        Me.dgvTabla.Columns("mins_programados").IsVisible = True
        Me.dgvTabla.Columns("mins_excedentes").IsVisible = True
        Me.dgvTabla.Columns("costo").IsVisible = True
        Me.dgvTabla.Columns("precio").IsVisible = True
        Me.dgvTabla.Columns("objetivo").IsVisible = True
        Me.dgvTabla.Columns("comentarios").IsVisible = True
    End Sub

    
#End Region

#Region "Graficar "
    Private Sub habilita_etiqueta_datos()
        lblError.Visible = True
    End Sub
    Private Sub deshabilita_etiqueta_datos()
        lblError.Visible = False
    End Sub
    'Bandera Graficos
    Private Sub set_bandera_graficos(ByVal valor As Integer)
        bandera_graficos = valor
    End Sub
    Private Sub obtener_grafica()
        If rdbtnOee.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = False
            vIndicador_A_CALCULAR = "OEE"
            Obtiene_Grafico_OEE()
        ElseIf rdbtnNrfti.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = False
            vIndicador_A_CALCULAR = "NRFTI"
            Obtiene_Grafica_NRFT()
        ElseIf rdbtnCosto.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = True
            vIndicador_A_CALCULAR = "COSTO"
            Obtiene_Grafica_Costo()
        ElseIf rdbtnSeguridad.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = False
            vIndicador_A_CALCULAR = "SEGURIDAD"
            Obtiene_Grafica_Seguridad()
        ElseIf rdbtnCincoS.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = False
            vIndicador_A_CALCULAR = "CINCOS"
            Obtiene_Grafica_CincoS()
        ElseIf rdbtnGente.IsChecked Then
            Me.PageGrafica_Secundaria.Enabled = False
            vIndicador_A_CALCULAR = "GENTE"
            Obtiene_Grafica_Gente()
        End If
    End Sub
#End Region
    Private Sub btnGraficar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGraficar.Click
        Me.radChartView1.ShowTrackBall = False
        picboxIndicador.Image = Nothing
        deshabilita_etiqueta_datos()
        btnDetalle.Enabled = True
        btnResumen.Enabled = True
        obtener_grafica()
    End Sub
    Private Sub radChartView1_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs) Handles radChartView1.LabelFormatting
        e.LabelElement.BackColor = Color.Transparent
        e.LabelElement.BorderColor = Color.Transparent
    End Sub

#Region "Metodos para Tablas_Reportes"
    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        If vIndicador_A_CALCULAR = vIndicador_Seleccionado Then
            btnDetalle.Enabled = True
            btnResumen.Enabled = True

            If rdbtnOee.IsChecked = True Then
                Obtiene_Reporte_OEE(True)
            ElseIf rdbtnNrfti.IsChecked = True Then
                Obtiene_Reporte_NRFT(True)
            ElseIf rdbtnCosto.IsChecked = True Then
                Obtiene_Reporte_Costo()
            ElseIf rdbtnSeguridad.IsChecked = True Then
                Obtiene_Reporte_Seguridad(True)
            ElseIf rdbtnCincoS.IsChecked = True Then
                Obtiene_Reporte_CincoS()
            ElseIf rdbtnGente.IsChecked = True Then
                Obtiene_Reporte_Gente()
            End If
        Else
            MsgBox("El indicador actualmente seleccionado no fue el que calculo. De clic en el boton 'Calcular' para recalcular el indicador seleccionado")
            btnDetalle.Enabled = False
            btnResumen.Enabled = False
        End If
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If vIndicador_A_CALCULAR = vIndicador_Seleccionado Then
            btnDetalle.Enabled = True
            btnResumen.Enabled = True

            If rdbtnOee.IsChecked = True Then
                Obtiene_Reporte_OEE(False)
            ElseIf rdbtnNrfti.IsChecked = True Then
                Obtiene_Reporte_NRFT(False)
            ElseIf rdbtnCosto.IsChecked = True Then
                Obtiene_Reporte_Costo()
            ElseIf rdbtnSeguridad.IsChecked = True Then
                Obtiene_Reporte_Seguridad(False)
            ElseIf rdbtnCincoS.IsChecked = True Then
                Obtiene_Reporte_CincoS()
            ElseIf rdbtnGente.IsChecked = True Then
                Obtiene_Reporte_Gente()
            End If
        Else
            MsgBox("El indicador actualmente seleccionado no fue el que calculo. De clic en el boton 'Calcular' para recalcular el indicador seleccionado")
            btnDetalle.Enabled = False
            btnResumen.Enabled = False
        End If

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim exporter As ExportToExcelML = New ExportToExcelML(Me.dgvTabla)
        exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport
        sfdExportaExcel.Filter = "Excel |*.xls"
        sfdExportaExcel.Title = "Guarda documento de Excel."
        sfdExportaExcel.ShowDialog()
        If sfdExportaExcel.FileName <> "" Then
            Try
                exporter.RunExport(sfdExportaExcel.FileName)
                MsgBox("Se exportó exitosamente los datos a la ubicación:  " & sfdExportaExcel.FileName, vbInformation + vbOKOnly, "Información")
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                sfdExportaExcel.FileName = ""
            End Try
        End If
    End Sub
#End Region

 
End Class
