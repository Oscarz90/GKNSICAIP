Imports CapaNegocios
Public Class frmGraficas    
#Region "VARIABLES GLOBALES"
    Dim oGraficas As Graficas
    'Private vIdEquipo As Integer = 4
    Private vIdEquipo As Integer = 76
    Dim colores(12) As String
    Dim rutaGrafica As String
    Dim cadenaXML As String
    Dim banderacbx As Integer
    Dim banderaCheck As Integer
    Dim banderaRadio As Integer
    Dim banderaDate As Integer
    Dim sQuery As String = ""
    Dim cadenaWHERE As String = ""
    Dim group As String = ""
    Dim contorno_anchor As String = "000000" 'negro
    Dim radio_anchor As String = "5"
#End Region
#Region "LLENADO DE COMBOBOXS USUARIO/LET"
    Private Sub llena_cbx_Equipos()
        oGraficas = New Graficas
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGraficas.Obtener_Nombre_Equipo_Usuarios(vIdEquipo)
        cbxEquipo.SelectedIndex = 0
    End Sub
    Private Sub llena_cbx_Lineas()
        oGraficas = New Graficas
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oGraficas.Obtener_Lineas_Equipo_Usuarios(vIdEquipo)
        cbxLinea.SelectedIndex = 0
    End Sub
    Private Sub llena_cbx_Areas()
        oGraficas = New Graficas
        cbxArea.ValueMember = "cve_componente"
        cbxArea.DisplayMember = "componente"
        cbxArea.DataSource = oGraficas.Obtener_Area_Usuarios(vIdEquipo)
        cbxArea.SelectedIndex = 0
    End Sub
    Private Sub llena_cbx_CadenaValor()
        oGraficas = New Graficas
        cbxUN.ValueMember = "cve_cadena_valor"
        cbxUN.DisplayMember = "cadena"
        cbxUN.DataSource = oGraficas.Obtener_CadenaValor_Usuarios(vIdEquipo)
        cbxUN.SelectedIndex = 0
    End Sub
#End Region
#Region "LLENADO DE COMBOBOXS LG"

    Private Sub llena_cbx_Equipos_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxEquipo.ValueMember = "cve_equipo"
        cbxEquipo.DisplayMember = "equipo"
        cbxEquipo.DataSource = oGraficas.Obtener_Nombre_Equipo_Usuarios(vIdEquipo)
        cbxEquipo.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Lineas_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxLinea.ValueMember = "cve_linea"
        cbxLinea.DisplayMember = "linea"
        cbxLinea.DataSource = oGraficas.Obtener_Lineas_Equipo_Usuarios(vIdEquipo)
        cbxLinea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_Areas_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxArea.ValueMember = "cve_componente"
        cbxArea.DisplayMember = "componente"
        cbxArea.DataSource = oGraficas.Obtener_Area_Usuarios(vIdEquipo)
        cbxArea.SelectedIndex = 0
    End Sub

    Private Sub llena_cbx_CadenaValor_LG()
        Dim oGraficas As New CapaNegocios.Graficas
        cbxUN.ValueMember = "cve_cadena_valor"
        cbxUN.DisplayMember = "cadena"
        cbxUN.DataSource = oGraficas.Obtener_CadenaValor_Usuarios(vIdEquipo)
        cbxUN.SelectedIndex = 0
    End Sub

#End Region
#Region "LLENADO DE COMBOBOXS GERENTE"

#End Region
#Region "LLENADO DE COMBOBOXS SUPERVISOR LIDER"

#End Region
#Region "LLENADO DE COMBOBOXS DIRECTOR"

#End Region

#Region "COLORES"
    Private Sub llena_colores()
        colores(0) = "0C1089" 'Azul Oscuro
        colores(1) = "9D080D" 'Rojo
        colores(2) = "C9198D" 'Rosa oscuro
        colores(3) = "58D3F7" 'AzulPastelClaro
        colores(4) = "FAAC58" 'NaranjaClaro
        colores(5) = "FFFF00" 'AmarilloOscuro
        colores(6) = "0101DF" 'AzulOscuro
        colores(7) = "01A9DB" 'AzulPastelOscuro
        colores(8) = "FF8000" 'NaranjaOscuro
        colores(9) = "81DAF5" 'Azul
        colores(10) = "FAAC58" 'NaranjaClaro
        colores(11) = "0B0B61" 'AzulOscuro
        colores(12) = "F3F781" 'AmarilloClaro
    End Sub

#End Region
#Region "VALIDAR HABILITAR BOTON GRAFICAR"
    Private Sub Habilita_Graficar()
        ''DEBE HABER UN VALOR SELECCIONADO EN LOS 4 COMBOBOX CADENA VALOR, COMPONENTE (AREA), LINEA Y EQUIPO
        If cbxUN.SelectedIndex >= 0 And cbxArea.SelectedIndex >= 0 And cbxLinea.SelectedIndex >= 0 And cbxEquipo.SelectedIndex >= 0 Then
            banderacbx = 1
        Else
            banderacbx = 0
        End If
        ''MOSTRAR EL AVISO PARA SELECCIONAR FECHAS
        Advertencia()
        ''DEBE HABER AL MENOS UN CONCEPTO DE INDICADOR SELECCIONADO
        If (rbtOEE.Checked Or rbtSeg.Checked Or rbtNRFTi.Checked Or rbtGente.Checked Or rbt5s.Checked Or rbtCosto.Checked) Then
            banderaCheck = 1
        Else
            banderaCheck = 0
        End If
        ''DEBE HABER AL MENOS UN TIPO DE GRAFICO SELECCIONADO
        If (rbtLineas.Checked Or rbtBarras.Checked Or rbtStock.Checked) Then
            banderaRadio = 1
        Else
            banderaRadio = 0
        End If
        ''SI SE HAN SELECCIONADO LOS COMBOBOXS, RADIO BUTTONS, CALENDARIOS HABILITAR BOTON GRAFICAR
        If banderacbx = 1 And banderaCheck = 1 And banderaRadio = 1 And banderaDate = 1 Then
            cmdGraficar.Enabled = True
        Else
            cmdGraficar.Enabled = False
            cmdImprimir.Enabled = False
        End If
    End Sub

    Private Sub Advertencia()
        ''VALIDACION DE LAS FECHAS DESDE, HASTA DE LA SELECCION DE FECHA = DIA
        If rbtDia.Checked Then
            If dtpDesde.Value.Date.CompareTo(dtpHasta.Value.Date) > 0 Then
                lblAviso.Visible = True
                banderaDate = 0
            Else
                lblAviso.Visible = False
                banderaDate = 1
            End If
        Else ''VALIDACION DE LAS FECHAS DESDE, HASTA DE LA SELECCION DE FECHA = MESES
            If rbtMeses.Checked Then
                If dtpDesde.Value.Year.CompareTo(dtpHasta.Value.Year) >= 0 Then ''Si el año (desde) es mayor que el año (hasta)
                    If dtpDesde.Value.Month.CompareTo(dtpHasta.Value.Month) >= 0 Then ''Si el mes (desde) es mayor que el mes (hasta)
                        lblAviso.Visible = True
                        banderaDate = 0
                    Else
                        lblAviso.Visible = False
                        banderaDate = 1
                    End If
                Else
                    lblAviso.Visible = False
                    banderaDate = 1
                End If
            Else ''VALIDACION DE LAS FECHAS DESDE, HASTA DE LA SELECCION DE FECHA = AÑOS
                If rbtAnos.Checked Then
                    If dtpDesde.Value.Year.CompareTo(dtpHasta.Value.Year) >= 0 Then
                        lblAviso.Visible = True
                        banderaDate = 0
                    Else
                        lblAviso.Visible = False
                        banderaDate = 1
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "ESTABLECE CONDICION WHERE USUARIOS"
    Private Sub Condicion_WHERE(ByVal vTodas As Boolean)
        cadenaWHERE = "where "
        cadenaWHERE = cadenaWHERE & "cadena ='" & cbxUN.Text & "' and "
        cadenaWHERE = cadenaWHERE & "componente ='" & cbxArea.Text & "' and "
        If vTodas = False Then
            cadenaWHERE = cadenaWHERE & "Linea ='" & cbxLinea.Text & "' and "
        End If        
        cadenaWHERE = cadenaWHERE & "Equipo ='" & Replace(cbxEquipo.Text, "'", "''") & "' and "
        cadenaWHERE = cadenaWHERE & "dia_asignado between '" & dtpDesde.Value.Year.ToString & "-" & dtpDesde.Value.Month.ToString & "-" &
            dtpDesde.Value.Day.ToString & "' and '" & dtpHasta.Value.Year.ToString & "-" &
            dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Day.ToString & "'"
        group = "dia_asignado"
        ''---------------------------------------------  C H E C A R ----------------------------------------------------------
        ''--------------------------------------------------------------------------------------------------------------------------
        If rbtMeses.Checked Then
            Dim desde As String = "01/" & dtpDesde.Value.Month.ToString & "/" & dtpDesde.Value.Year.ToString
            Dim hasta As String = DateTime.DaysInMonth(dtpHasta.Value.Year, dtpHasta.Value.Month) & "/" & dtpHasta.Value.Month.ToString & "/" & dtpDesde.Value.Year.ToString
            cadenaWHERE = cadenaWHERE & "fecha between '" & desde & "' and '" & hasta & "'"
            group = "datepart(year,fecha),datepart(month,fecha)"
        End If

        If rbtAnos.Checked Then
            cadenaWHERE = cadenaWHERE & "fecha between '01/01/" & dtpDesde.Value.Year.ToString & "' and '31/12/" & dtpHasta.Value.Year.ToString & "'"
            group = "datepart(year,fecha)"
        End If

        cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, oee, TIPO_REGISTRO, " & group & " order by " & group
    End Sub

#End Region
#Region "FECHAS PARA LOS GRÁFICOS EJE X "
    Private Sub establece_fechas(ByVal indicador As Integer)
        Dim fechaGraficos As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(indicador, cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                fechaGraficos = vDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
        Else

        End If
        cadenaXML += "<category name ='PROMEDIO OEE' />"
        cadenaXML += "</categories>"
    End Sub

#End Region
#Region "ESTABLECE OEE 1 EQUIPO 1 LINEA"
    Private Sub establece_OEE(ByVal color As String)
        Dim promedio As Double = 0
        Dim contador As Integer = 0
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='OEE' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim oee As Double = 0
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVistaOEE(cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                If vDR("TIPO_REGISTRO") = "P" Then
                    oee = vDR(("oee")) * 100
                    promedio = promedio + oee
                    contador = contador + 1
                    cadenaXML += " <set value='" & oee.ToString & "'/>"
                ElseIf vDR("TIPO_REGISTRO") = "D" Then
                    oee = 0
                    promedio = promedio + oee
                    cadenaXML += " <set value='" & oee.ToString & "' />"
                End If
            Next
        Else

        End If
        If contador > 0 Then
            promedio = promedio / contador
        Else
            promedio = 0
        End If
        cadenaXML += " <set value='" & promedio.ToString & "' color='" & colores(1) & "'/>"
        cadenaXML += " </dataset>"

    End Sub

#End Region

#Region "ESTABLECE OEE 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece_OEE_Acumulado(ByVal color As String)
        Dim promDia As Double = 0
        Dim promAcumulado As Double = 0
        Dim promFinal As Double = 0
        Dim contador As Integer = 0
        Dim vContador_Dias As Integer = 0
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='OEE' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim oee As Double = 0
        Dim vFecha_Actual As DateTime
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVistaOEE(cadenaWHERE)
            vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
            For Each vDR As DataRow In vDT.Rows
                If vDR("TIPO_REGISTRO") = "P" And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                    oee = vDR(("oee")) * 100
                    promDia = promDia + oee
                    contador = contador + 1                    
                    'ElseIf vDR("TIPO_REGISTRO") = "D" Then
                ElseIf vDR("TIPO_REGISTRO") = "P" And vFecha_Actual <> vDR("DIA_ASIGNADO") Then
                    vContador_Dias = vContador_Dias + 1
                    promDia = promDia / contador
                    promAcumulado = promAcumulado + promDia
                    cadenaXML += " <set value='" & promDia.ToString & "'/>"
                    vFecha_Actual = vDR("DIA_ASIGNADO")
                    promDia = 0
                    contador = 0
                    If vDR("TIPO_REGISTRO") <> "D" Then
                        oee = vDR(("oee")) * 100
                        promDia = promDia + oee
                        contador = contador + 1
                        promDia = promDia / contador
                    End If
                End If
            Next
            vContador_Dias = vContador_Dias + 1            
            promDia = promDia / contador
            promAcumulado = promAcumulado + promDia
            cadenaXML += " <set value='" & promDia.ToString & "'/>"            
        End If
        promFinal = promAcumulado / vContador_Dias
        cadenaXML += " <set value='" & promFinal.ToString & "' color='" & colores(1) & "'/>"
        cadenaXML += " </dataset>"
    End Sub
#End Region

#Region "INICIALIZACION DEL FORMULARIO"
    Private Sub Graficas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oGraficas.Obtener_IdEquipo(vIdEquipo)
        llena_cbx_Equipos()
        llena_cbx_Lineas()
        llena_cbx_Areas()
        llena_cbx_CadenaValor()
        llena_colores()
        ''INICIALIZACION DE CONTROLES COMBOBOXS
        cbxUN.Enabled = True
        cbxArea.Enabled = True
        cbxLinea.Enabled = True
        cbxEquipo.Enabled = True
        ''INICIALIZACION DE LAS FECHAS DE LOS CALENDARIOS
        dtpDesde.Value = DateSerial(Now.Year, Now.Month, 1) 'MUESTRA EL PRIMER DIA DEL MES
        dtpHasta.Value = Today 'MUESTRA LA FECHA ACTUAL
        ''INICIALIZACION BOTON GRAFICAR Y RADIO BUTTONS
        cmdGraficar.Enabled = False
        rbtDia.Checked = True
        rbtOEE.Checked = True
        rbtLineas.Checked = True
        ''USO DE BANDERAS
        'banderacbx = 0
        'banderaArea = 0
        'banderaCheck = 0
        'banderaDate = 0
        'bandera_load = True        
    End Sub
#End Region
#Region "EVENTOS DE COMBOBOX"
    Private Sub cbxUN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUN.SelectedIndexChanged
        Habilita_Graficar()
    End Sub

    Private Sub cbxArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxArea.SelectedIndexChanged
        Habilita_Graficar()
    End Sub

    Private Sub cbxLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxLinea.SelectedIndexChanged
        Habilita_Graficar()
    End Sub

    Private Sub cbxEquipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEquipo.SelectedIndexChanged
        Habilita_Graficar()
    End Sub

#End Region
#Region "EVENTOS DE CALENDARIO"
    Private Sub dtpDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDesde.ValueChanged
        Habilita_Graficar()
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged
        Habilita_Graficar()
    End Sub
#End Region
#Region "EVENTOS RADIO BUTTONS DIA/MES/AÑO"
    Private Sub rbtDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDia.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtMeses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMeses.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtAnos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAnos.CheckedChanged
        Habilita_Graficar()
    End Sub
#End Region
#Region "EVENTOS RADIO BUTTONS TIPOS DE GRAFICOS"
    Private Sub rbtLineas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtLineas.CheckedChanged
        Habilita_Graficar()
    End Sub
    Private Sub rbtBarras_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtBarras.CheckedChanged
        Habilita_Graficar()
    End Sub
    Private Sub rbtStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtStock.CheckedChanged
        Habilita_Graficar()
    End Sub
#End Region
#Region "EVENTOS RADIO BUTTONS TIPO INDICADOR"
    Private Sub rbtOEE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOEE.CheckedChanged
        Habilita_Graficar()
    End Sub
    Private Sub rbtNRFTi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNRFTi.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCosto.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtSeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSeg.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtGente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGente.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbt5s_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt5s.CheckedChanged
        Habilita_Graficar()
    End Sub

#End Region
#Region "EVENTOS BOTONES GRAFICAR/EXPORTAR/SALIR"
    Private Sub cmdGraficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraficar.Click
        swfGrafica.Visible = True
        Dim tipoGrafico As String = ""
        Dim ejeY As String = "R E S U L T A D O S "
        If rbtLineas.Checked Then
            tipoGrafico = "FCF_MSLine.swf"
        End If
        If rbtBarras.Checked Then
            tipoGrafico = "FCF_MSColumn2D.swf"
        End If
        If rbtStock.Checked Then
            tipoGrafico = "FCF_StackedColumn2D.swf"
        End If

        rutaGrafica = "file://" & Application.StartupPath & "/FusionChartsFree/Charts/" & tipoGrafico & "?chartWidth=1240&chartHeight=400"
        cadenaXML = rutaGrafica + "&dataXML=<graph YAxisMinValue='0' YAxisMaxValue='100' numberSuffix='%25' caption='REPORTE DE RESULTADOS' subcaption='SICAIP' YAxisName= '" & ejeY & "' xAxisName='F E C H A (s)' labeldisplay='rotate' decimalPrecision='2' rotateNames='1' formatNumberScale='0' thousandSeparator=',' bgcolor='ffffff' bgalpha='000000' showColumnShadow='1' showAlternateHGridColor='1' AlternateHGridColor='ff5904' divLineColor='ff5904' divLineAlpha='20' alternateHGridAlpha='5' canvasBorderColor='666666' baseFontColor='666666'>"

        Condicion_WHERE(cbxTodasLineas.Checked)
        If rbtOEE.Checked Then
            If cbxTodasLineas.Checked Then
                establece_fechas(1)
                establece_OEE_Acumulado(colores(0)) ''FALTA sacar el acumulado 
            Else
                establece_fechas(1) '---Este Id esta bien. 1--> OEE
                establece_OEE(colores(0))
            End If
        ElseIf rbtNRFTi.Checked Then
            establece_fechas(2)
            establece_OEE(colores(3))
        ElseIf rbtCosto.Checked Then
            establece_fechas(3)
            establece_OEE(colores(2))
        ElseIf rbtSeg.Checked Then
            establece_fechas(4)
            establece_OEE(colores(3))
        ElseIf rbtGente.Checked Then
            establece_fechas(5)
            establece_OEE(colores(4))
        ElseIf rbt5s.Checked Then
            establece_fechas(6)
            establece_OEE(colores(5))
        End If
        cadenaXML += "<trendlines> <line startValue='85.00' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
        cadenaXML += " </graph>"
        swfGrafica.Movie = 1 'hace que el control actualice o se refresque
        swfGrafica.Movie = cadenaXML 'carga la pelicula flash
        cmdImprimir.Enabled = True

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click

    End Sub

    Private Sub frmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSalir.Click
        Me.Close()
    End Sub
#End Region
#Region "EVENTO CHECKBOX TODAS LAS LINEAS"
    Private Sub cbxTodasLineas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTodasLineas.CheckedChanged
        If cbxTodasLineas.Checked Then
            cbxLinea.Enabled = False
        Else
            cbxLinea.Enabled = True
        End If
    End Sub
#End Region

End Class