Imports CapaNegocios
Public Class frmGraficas    
    Dim oGraficas As Graficas
#Region "VARIABLES GLOBALES"
    Private vIdEquipo As Integer = 4
    Dim colores(12) As String
    Dim rutaGrafica As String
    Dim cadenaXML As String
    Dim banderacbx As Integer
    Dim banderaCheck As Integer
    Dim banderaRadio As Integer
    Dim banderaDate As Integer
    Dim sQuery As String=""
    Dim cadenaWHERE As String = ""
    Dim group As String = ""
    Dim contorno_anchor As String = "000000"
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
        colores(0) = "0C1089" 'VerdeClaro
        colores(1) = "F4FA58" 'AmarilloClaro
        colores(2) = "5858FA" 'AzulClaro
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
    Private Sub Condicion_WHERE()
        cadenaWHERE = "where "
        '' If cbxUN.SelectedIndex = 0 Then
        cadenaWHERE = cadenaWHERE & "cadena ='" & cbxUN.Text & "' and "
        ''End If

        'If cbxArea.SelectedIndex = 0 Then
        cadenaWHERE = cadenaWHERE & "componente ='" & cbxArea.Text & "' and "
        'End If

        'If cbxLinea.SelectedIndex = 0 Then
        cadenaWHERE = cadenaWHERE & "Linea ='" & cbxLinea.Text & "' and "
        'End If

        'If cbxEquipo.SelectedIndex = 0 Then
        cadenaWHERE = cadenaWHERE & "Equipo ='" & Replace(cbxEquipo.Text, "'", "''") & "' and "
        ''End If

        ''If rbtDia.Checked Then
        cadenaWHERE = cadenaWHERE & "dia_asignado between '" & dtpDesde.Value.Year.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Day.ToString & "' and '" & dtpHasta.Value.Year.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Day.ToString & "'"
        group = "dia_asignado"
        'End If
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

        cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, oee," & group & " order by " & group
    End Sub

#End Region
#Region "FECHAS PARA LOS GRÁFICOS EJE X "
    Private Sub establece_fechas(ByVal indicador As Integer)
        Dim fechaG As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(indicador, cadenaWHERE)
            'While lee.Read()
            '    fechaG = lee.Item(0).ToString
            '    fechaG = Mid(fechaG, 1, 5)
            '    cadenaXML += "<category name='" & fechaG & "' />"
            'End While
            For Each vDR As DataRow In vDT.Rows
                fechaG = vDR("Dia_Asignado")
                fechaG = Mid(fechaG, 1, 5)
                cadenaXML += "<category name='" & fechaG & "' />"
            Next
        Else

        End If
        cadenaXML += "<category name='PROMEDIO' />"
        cadenaXML += "</categories>"
    End Sub

#End Region
#Region "ESTABLECE TOTAL DE OEE"
    Private Sub establece_OEE(ByVal color As String)
        Dim promedio As Single = 0
        Dim contador As Integer = 0
        Dim vDT As DataTable
        'Dim fechaG As String = ""
        cadenaXML += "<dataset seriesName='OEE' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        'sQuery = "select total from indicador1view " & cadenaWHERE
        Dim oee As Single = 0

        'While lee.Read()
        '    oee = CSng(lee.Item(0)) * 100
        '    promedio = promedio + oee
        '    contador = contador + 1
        '    ''cadena_xml += " <set value='" & oee.ToString & "' value=oee.ToString />"
        '    ''<set name='Jan' value='462' color='AFD8F8' />
        '    cadena_xml += " <set value='" & oee.ToString & "'/>"
        'End While

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVistaOEE(cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                oee = vDR(("oee")) * 100
                promedio = promedio + oee
                contador = contador + 1
                cadenaXML += " <set value='" & oee.ToString & "'/>"
            Next
        Else

        End If
        promedio = promedio / contador
        cadenaXML += " <set value='" & promedio.ToString & "'/>"
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
#Region "EVENTOS BOTONES"
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

        rutaGrafica = "file://" & Application.StartupPath & "/FusionChartsFree/Charts/" & tipoGrafico & "?chartWidth=1240&chartHeight=380"
        cadenaXML = rutaGrafica + "&dataXML=<graph YAxisMinValue='0' YAxisMaxValue='100' numberSuffix='%25' caption='REPORTE DE RESULTADOS' subcaption='SICAIP' YAxisName= '" & ejeY & "' xAxisName='F E C H A (s)' labeldisplay='rotate' decimalPrecision='2' rotateNames='1' formatNumberScale='0' thousandSeparator=',' bgcolor='ffffff' bgalpha='000000' showColumnShadow='1' showAlternateHGridColor='1' AlternateHGridColor='ff5904' divLineColor='ff5904' divLineAlpha='20' alternateHGridAlpha='5' canvasBorderColor='666666' baseFontColor='666666'>"


        Condicion_WHERE()

        If rbtOEE.Checked Then
            establece_fechas(1) '---Este Id esta bien. 1--> OEE
            establece_OEE(colores(0))
        ElseIf rbtNRFTi.Checked Then
            establece_fechas(2)
            establece_OEE(colores(1))
        ElseIf rbtCosto.Checked Then
            establece_fechas(3)
            establece_OEE(colores(2))
        ElseIf rbtGente.Checked Then
            establece_fechas(4)
            establece_OEE(colores(3))
        ElseIf rbt5s.Checked Then
            establece_fechas(5)
            establece_OEE(colores(4))
        ElseIf rbtSeg.Checked Then
            establece_fechas(6)
            establece_OEE(colores(5))
        End If
        cadenaXML += "<trendlines> <line startValue='32.50' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"

        cadenaXML += " </graph>"

        swfGrafica.Movie = 1       'hace que el control actualice o se refresque

        swfGrafica.Movie = cadenaXML   'carga la pelicula flash
        cmdImprimir.Enabled = True

    End Sub
    Private Sub frmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmSalir.Click
        Me.Close()
    End Sub
#End Region


    Private Sub rbtDia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDia.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtOEE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOEE.CheckedChanged
        Habilita_Graficar()
    End Sub

    Private Sub rbtLineas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtLineas.CheckedChanged
        Habilita_Graficar()
    End Sub
End Class