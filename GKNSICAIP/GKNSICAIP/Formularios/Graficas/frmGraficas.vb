Imports CapaNegocios
Public Class frmGraficas    
#Region "VARIABLES GLOBALES"
    Dim oGraficas As Graficas
    'Private vIdEquipo As Integer = 4, 76
    Private vIdLinea As Integer
    Private vIdEquipo As Integer
    Dim colores(12) As String
    Dim rutaGrafica As String
    Dim cadenaXML As String
    Dim cadenaSELECT As String = ""
    Dim banderacbx As Integer
    Dim banderaCheck As Integer
    Dim banderaRadio As Integer
    Dim banderaDate As Integer
    Dim sQuery As String = ""
    Dim cadenaWHERE As String = ""
    Dim cadenaGroup As String = ""
    Dim contorno_anchor As String = "000000" 'negro
    Dim radio_anchor As String = "5"
#End Region
#Region "PASAR ID EQUIPO"

    Public Sub Set_IdEquipo(ByVal idEq As Integer)
        vIdEquipo = idEq
    End Sub

    'Public Function Set_IdLinea(ByVal idLinea As Integer) As Integer
    '    vIdLinea = cbxLinea.SelectedValue
    '    Return vIdLinea
    'End Function

#End Region
#Region "MESES"
    Private Function getMeses(ByVal numero As String) As String
        Dim mes As String = ""
        Select Case numero
            Case "01"
                mes = "ENERO"
            Case "02"
                mes = "FEBRERO"
            Case "03"
                mes = "MARZO"
            Case "04"
                mes = "ABRIL"
            Case "05"
                mes = "MAYO"
            Case "06"
                mes = "JUNIO"
            Case "07"
                mes = "JULIO"
            Case "08"
                mes = "AGOSTO"
            Case "09"
                mes = "SEPTIEMBRE"
            Case "10"
                mes = "OCTUBRE"
            Case "11"
                mes = "NOVIEMBRE"
            Case "12"
                mes = "DICIEMBRE"
        End Select
        Return mes
    End Function
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
        colores(0) = "FFA500" 'Azul Oscuro = 0C1089  amarillo fuerte=FFA500 oee**
        colores(1) = "9D080D" 'Rojo **
        colores(2) = "C9198D" 'Rosa oscuro
        colores(3) = "58D3F7" 'AzulPastelClaro
        colores(4) = "FAAC58" 'NaranjaClaro
        colores(5) = "FFFF00" 'AmarilloOscuro
        colores(6) = "0101DF" 'AzulOscuro
        colores(7) = "8A0808" 'AzulPastelOscuro gente **
        colores(8) = "FF8000" 'NaranjaOscuro
        colores(9) = "FFBF00" 'Azul=81DAF5  amarillo FFBF00 gente**
        colores(10) = "045FB4" 'NaranjaClaro=FAAC58 azul gente = 045FB4 **
        colores(11) = "0B0B61" 'AzulOscuro
        colores(12) = "006400" 'F3F781=AmarilloClaro verde =006400  5s**
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
        If rbtDia.Checked Or rbtMeses.Checked Then
            If dtpHasta.Value < dtpDesde.Value Then
                lblAviso.Visible = True
                cmdGraficar.Enabled = False
                banderaDate = 0
            Else
                lblAviso.Visible = False
                cmdGraficar.Enabled = True
                banderaDate = 1
            End If
        End If
    End Sub
#End Region
#Region "HABILITAR TIPO DE GRAFICOS"
    Private Sub HabilitarTipoGrafico()
        ''HABILITAR LOS RADIO BUTTONS DE LOS TIPOS DE GRÁFICOS PARA OEE, NRFTI Y 5´S
        If rbtDia.Checked And (rbtOEE.Checked Or rbtNRFTi.Checked) Then
            rbtLineas.Enabled = True
            rbtBarras.Enabled = True
            rbtBarras.Checked = True
            rbtStock.Enabled = False
            rbtStock.Checked = False
            dtpDesde.CustomFormat = "dd/MMMM/yyyy"
            dtpHasta.CustomFormat = "dd/MMMM/yyyy"
            Habilita_Graficar()
        ElseIf rbtMeses.Checked And (rbtOEE.Checked Or rbtNRFTi.Checked Or rbt5s.Checked) Then
            rbtLineas.Enabled = True
            rbtBarras.Enabled = True
            rbtBarras.Checked = True
            rbtStock.Enabled = False
            rbtStock.Checked = False
            dtpDesde.CustomFormat = "MMMM/yyyy"
            dtpHasta.CustomFormat = "MMMM/yyyy"
            Habilita_Graficar()
        End If
    End Sub
    Private Sub HabilitarTipoGraficoStock()
        ''HABILITAR LOS RADIO BUTTONS DE LOS TIPOS DE GRÁFICOS PARA GENTE Y SEGURIDAD
        If rbtDia.Checked And (rbtSeg.Checked Or rbtGente.Checked) Then
            rbtLineas.Enabled = False
            rbtBarras.Enabled = False
            rbtStock.Enabled = True
            rbtStock.Checked = True
            dtpDesde.CustomFormat = "dd/MMMM/yyyy"
            dtpHasta.CustomFormat = "dd/MMMM/yyyy"
            Habilita_Graficar()
        ElseIf rbtMeses.Checked And (rbtSeg.Checked Or rbtGente.Checked) Then
            rbtLineas.Enabled = False
            rbtBarras.Enabled = False
            rbtStock.Enabled = True
            rbtStock.Checked = True
            dtpDesde.CustomFormat = "MMMM/yyyy"
            dtpHasta.CustomFormat = "MMMM/yyyy"
            Habilita_Graficar()
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

        If rbtDia.Checked Then
            cadenaWHERE = cadenaWHERE & "dia_asignado between '" & dtpDesde.Value.Year.ToString & "-" & dtpDesde.Value.Month.ToString & "-" &
            dtpDesde.Value.Day.ToString & "' and '" & dtpHasta.Value.Year.ToString & "-" &
            dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Day.ToString & "'"
            cadenaGroup = "dia_asignado"
        End If

        If rbtMeses.Checked Then
            Dim desde As String = dtpDesde.Value.Year.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & "01"
            Dim hasta As String = dtpDesde.Value.Year.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & DateTime.DaysInMonth(dtpHasta.Value.Year, dtpHasta.Value.Month)
            cadenaWHERE = cadenaWHERE & "dia_asignado between '" & desde & "' and '" & hasta & "'"
            ''cadenaGroup = "datepart(year,dia_asignado), datepart(month,dia_asignado)"
            cadenaGroup = "dia_asignado"
        End If

        'If rbtOEE.Checked Then
        '    cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, oee, tipo_registro, " & cadenaGroup & " order by " & cadenaGroup
        'ElseIf rbtNRFTi.Checked Then

        'ElseIf rbtCosto.Checked Then

        'ElseIf rbtSeg.Checked Then

        'ElseIf rbt5s.Checked Then
        '    cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, PROMEDIO, " & cadenaGroup & " order by " & cadenaGroup
        'ElseIf rbtGente.Checked Then

        'End If

    End Sub

#End Region
#Region "FECHAS PARA LOS GRÁFICOS EJE X --OEE--"
    Private Sub establece_fechas(ByVal cadena As String)
        Dim fechaGraficos As String = ""
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        Dim banderaPromedio As Boolean
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                fechaGraficos = vDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
            banderaPromedio = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                For Each vDR As DataRow In vDT.Rows
                    If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                        fechaGraficos = vDR("Dia_Asignado")
                        fechaGraficos = Mid(fechaGraficos, 4, 2) ''05=MAYO
                        mes = getMeses(fechaGraficos)
                    Else
                        banderaPromedio = False
                        cadenaXML += "<category name='" & mes & "  " & vYearInicio & " ' />"
                        vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                    End If

                Next
                cadenaXML += "<category name='" & mes & "   " & vYearInicio & "' />"
            End If

        End If
        If banderaPromedio = True Then
            cadenaXML += "<category name ='PROMEDIO' />"
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_fechas_5s(ByVal cadena As String)
        Dim fechaGraficos As String = ""
        Dim vDT As DataTable
        Dim mes As String = ""
        cadenaXML += "<categories>"

        If rbtMeses.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                fechaGraficos = vDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 4, 2)
                mes = getMeses(fechaGraficos)
                cadenaXML += "<category name='" & mes & "' />"
            Next

        End If
        cadenaXML += "</categories>"
    End Sub
#End Region
#Region "ESTABLECE OEE 1 EQUIPO 1 LINEA"
    Private Sub establece_OEE(ByVal cadena As String, ByVal color As String)
        Dim promedio As Double = 0
        Dim contador As Integer = 0
        Dim fechaGraficos As String = ""
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        Dim banderaPromedio As Boolean

        cadenaXML += "<dataset seriesName='OEE' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim oee As Double = 0
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
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
            banderaPromedio = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                For Each vDR As DataRow In vDT.Rows
                    If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                        If vDR("TIPO_REGISTRO") = "P" Then
                            oee = vDR(("oee")) * 100
                            promedio = promedio + oee
                            contador = contador + 1
                        ElseIf vDR("TIPO_REGISTRO") = "D" Then
                            oee = 0
                            promedio = promedio + oee
                        End If

                    Else
                        banderaPromedio = True
                        If contador > 0 Then
                            promedio = promedio / contador
                        Else
                            promedio = 0
                        End If
                        cadenaXML += " <set value='" & promedio.ToString & "'/>"
                        promedio = 0
                        oee = 0
                        contador = 0
                        vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        If vDR("TIPO_REGISTRO") = "P" Then
                            oee = vDR(("oee")) * 100
                            promedio = promedio + oee
                            contador = contador + 1
                        ElseIf vDR("TIPO_REGISTRO") = "D" Then
                            oee = 0
                            promedio = promedio + oee
                        End If
                    End If
                Next
                If contador > 0 Then
                    promedio = promedio / contador
                Else
                    promedio = 0
                End If
                cadenaXML += " <set value='" & promedio.ToString & "'/>"
            End If
        End If

        If contador > 0 Then
            promedio = promedio / contador
        Else
            promedio = 0
        End If

        If banderaPromedio = True Then
            cadenaXML += " <set value='" & promedio.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE OEE 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece_OEE_Acumulado(ByVal cadena As String, ByVal color As String)
        Dim promDia As Double = 0
        Dim promAcumulado As Double = 0
        Dim promFinal As Double = 0
        Dim contador As Integer = 0
        Dim vContador_Dias As Integer = 0
        Dim vDT As DataTable
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim mes As String = ""
        Dim banderaPromedio As Boolean = False

        cadenaXML += "<dataset seriesName='OEE' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim oee As Double = 0
        Dim vFecha_Actual As DateTime
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
            For Each vDR As DataRow In vDT.Rows
                If vDR("TIPO_REGISTRO") = "P" And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                    oee = vDR(("oee")) * 100
                    promDia = promDia + oee
                    contador = contador + 1
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
            banderaPromedio = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
                vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                For Each vDR As DataRow In vDT.Rows
                    If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                        If vDR("TIPO_REGISTRO") = "P" And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                            oee = vDR(("oee")) * 100
                            promDia = promDia + oee
                            contador = contador + 1
                        ElseIf vDR("TIPO_REGISTRO") = "P" And vFecha_Actual <> vDR("DIA_ASIGNADO") Then
                            vContador_Dias = vContador_Dias + 1
                            promDia = promDia / contador
                            promAcumulado = promAcumulado + promDia
                            'cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
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
                    Else
                        banderaPromedio = True
                        cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
                        vFecha_Actual = vDR("DIA_ASIGNADO")
                        promDia = 0
                        contador = 0
                        vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        If vDR("TIPO_REGISTRO") = "P" And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                            oee = vDR(("oee")) * 100
                            promDia = promDia + oee
                            contador = contador + 1
                        ElseIf vDR("TIPO_REGISTRO") = "P" And vFecha_Actual <> vDR("DIA_ASIGNADO") Then
                            vContador_Dias = vContador_Dias + 1
                            promDia = promDia / contador
                            promAcumulado = promAcumulado + promDia
                            'cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
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
                    End If
                Next
                vContador_Dias = vContador_Dias + 1
                promDia = promDia / contador
                promAcumulado = promAcumulado + promDia
                promFinal = promAcumulado / vContador_Dias
                cadenaXML += " <set value='" & promFinal.ToString & "'/>"
            End If
        End If
        If banderaPromedio = True Then
            promFinal = promAcumulado / vContador_Dias
            cadenaXML += " <set value='" & promFinal.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE 5S 1 EQUIPO 1 LINEA"
    Private Sub establece_5S(ByVal cadena As String, ByVal color As String)
        Dim promedio5S As Double = 0
        Dim contador As Integer = 0
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='5s' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        If rbtMeses.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                promedio5S = vDR("PROMEDIO")
                cadenaXML += " <set value='" & promedio5S.ToString & "'/>"
            Next
        Else

        End If
        'cadenaXML += " <set value='" & promedio.ToString & "' color='" & colores(1) & "'/>"
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE 5S 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece5S_Acumulado(ByVal cadena As String, ByVal color As String)
        Dim vResultado5s As Double = 0
        Dim vFecha_Actual As DateTime
        Dim promMes As Double = 0
        Dim promAnual As Double = 0
        Dim contador As Integer = 0
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='5S' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"

        If rbtMeses.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
            For Each vDR As DataRow In vDT.Rows
                If vFecha_Actual = vDR("DIA_ASIGNADO") Then
                    vResultado5s = vDR("PROMEDIO")
                    promMes = promMes + vResultado5s
                    contador = contador + 1
                ElseIf vFecha_Actual <> vDR("DIA_ASIGNADO") Then
                    promAnual = promMes / contador
                    cadenaXML += " <set value='" & promAnual.ToString & "'/>"
                    promAnual = 0
                    contador = 0
                    promMes = 0
                    vResultado5s = vDR("PROMEDIO")
                    promMes = promMes + vResultado5s
                    contador = contador + 1
                    vFecha_Actual = vDR("DIA_ASIGNADO")
                End If
                'vResultado5s = vDR("PROMEDIO")
                'promMes = promMes + vResultado5s
                'contador = contador + 1
            Next
            promAnual = promMes / contador
            cadenaXML += " <set value='" & promAnual.ToString & "'/>"
            cadenaXML += " </dataset>"
        End If
        'promAnual = promMes / contador
        'cadenaXML += " <set value='" & promAnual.ToString & "' color='" & colores(1) & "'/>"
        'cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE NRFTI 1 EQUIPO 1 LINEA"
    Private Sub establece_NRFTi(ByVal cadena As String, ByVal color As String)
        Dim sumaPzasOK As Double = 0
        Dim sumaPzasDes As Double = 0
        Dim promNrfti As Double = 0  ''Promedio NRFTi se vuelve a calcular NRFTi = (PZAS.DES/(PZAS.DES + PZAS. OK))*1,000,000
        'Dim contador As Integer = 0
        Dim vDT As DataTable

        cadenaXML += "<dataset seriesName='NRFTi' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim nrfti As Double = 0
        Dim pzasOK As Double = 0
        Dim pzasDes As Double = 0
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim banderaPromedio As Boolean

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            For Each vDR As DataRow In vDT.Rows
                If vDR("NRFTI") <> 0 Then
                    nrfti = vDR(("NRFTI"))
                    pzasOK = vDR(("PZAS_OK"))
                    pzasDes = vDR(("PZAS_DESECHO"))
                    sumaPzasOK = sumaPzasOK + pzasOK
                    sumaPzasDes = sumaPzasDes + pzasDes
                    promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                    cadenaXML += " <set value='" & nrfti.ToString & "'/>"
                ElseIf vDR("NRFTI") = 0 Then
                    nrfti = 0
                    cadenaXML += " <set value='" & nrfti.ToString & "' />"
                End If
                banderaPromedio = True
            Next
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                For Each vDR As DataRow In vDT.Rows
                    If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                        pzasOK = vDR(("PZAS_OK"))
                        pzasDes = vDR(("PZAS_DESECHO"))
                        sumaPzasOK = sumaPzasOK + pzasOK
                        sumaPzasDes = sumaPzasDes + pzasDes
                        promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                    Else
                        banderaPromedio = True
                        'promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                        cadenaXML += " <set value='" & promNrfti.ToString & "' />"
                        pzasOK = 0
                        pzasDes = 0
                        sumaPzasOK = 0
                        sumaPzasDes = 0
                        vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        pzasOK = vDR(("PZAS_OK"))
                        pzasDes = vDR(("PZAS_DESECHO"))
                        sumaPzasOK = sumaPzasOK + pzasOK
                        sumaPzasDes = sumaPzasDes + pzasDes

                    End If

                Next
                cadenaXML += " <set value='" & promNrfti.ToString & "' />"
            End If ''dia/mes

        End If
        promNrfti = Math.Round(promNrfti)
        promNrfti = Math.Truncate(promNrfti)
        If banderaPromedio = True Then
            cadenaXML += " <set value='" & promNrfti.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"

    End Sub
#End Region
#Region "ESTABLECE NRFTI 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece_NRFTi_Acumulado(ByVal cadena As String, ByVal color As String)
        Dim sumaPzasOK As Double = 0
        Dim sumaPzasDes As Double = 0
        Dim promNrfti As Double = 0
        Dim sumaPzasOKFinal As Double = 0 ''*
        Dim sumaPzasDesFinal As Double = 0  ''*
        Dim promNrftiFinal As Double = 0  ''*
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='NRFTi' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim nrfti As Double = 0
        Dim pzasOK As Double = 0
        Dim pzasDes As Double = 0
        Dim vFecha_Actual As DateTime
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim banderaPromedio As Boolean

        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
            For Each vDR As DataRow In vDT.Rows
                If vFecha_Actual = vDR("DIA_ASIGNADO") Then
                    pzasOK = vDR(("PZAS_OK"))
                    pzasDes = vDR(("PZAS_DESECHO"))
                    sumaPzasOK = sumaPzasOK + pzasOK
                    sumaPzasDes = sumaPzasDes + pzasDes
                    promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                    ''PROMEDIO FINAL NRFTI BARRA ROJA
                    sumaPzasOKFinal = sumaPzasOKFinal + pzasOK
                    sumaPzasDesFinal = sumaPzasDesFinal + pzasDes
                    promNrftiFinal = (sumaPzasDesFinal / (sumaPzasDesFinal + sumaPzasOKFinal)) * 1000000
                ElseIf vFecha_Actual <> vDR("DIA_ASIGNADO") Then
                    cadenaXML += " <set value='" & promNrfti.ToString & "'/>"
                    pzasOK = vDR(("PZAS_OK"))
                    pzasDes = vDR(("PZAS_DESECHO"))
                    sumaPzasOK = 0
                    sumaPzasDes = 0
                    promNrfti = 0
                    sumaPzasOK = sumaPzasOK + pzasOK
                    sumaPzasDes = sumaPzasDes + pzasDes
                    promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                    ''PROMEDIO FINAL NRFTI BARRA ROJA
                    sumaPzasOKFinal = sumaPzasOKFinal + pzasOK
                    sumaPzasDesFinal = sumaPzasDesFinal + pzasDes
                    promNrftiFinal = (sumaPzasDesFinal / (sumaPzasDesFinal + sumaPzasOKFinal)) * 1000000
                    vFecha_Actual = vDR("DIA_ASIGNADO")
                    pzasOK = 0
                    pzasDes = 0
                End If
            Next
            cadenaXML += " <set value='" & promNrfti.ToString & "'/>"
            banderaPromedio = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
                vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                For Each vDR As DataRow In vDT.Rows
                    If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                        pzasOK = vDR(("PZAS_OK"))
                        pzasDes = vDR(("PZAS_DESECHO"))
                        sumaPzasOK = sumaPzasOK + pzasOK
                        sumaPzasDes = sumaPzasDes + pzasDes
                        promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                        sumaPzasOKFinal = sumaPzasOKFinal + pzasOK
                        sumaPzasDesFinal = sumaPzasDesFinal + pzasDes
                        promNrftiFinal = (sumaPzasDesFinal / (sumaPzasDesFinal + sumaPzasOKFinal)) * 1000000

                    Else
                        banderaPromedio = True
                        cadenaXML += " <set value='" & promNrftiFinal.ToString & "'/>"
                        pzasOK = vDR(("PZAS_OK"))
                        pzasDes = vDR(("PZAS_DESECHO"))
                        sumaPzasOK = 0
                        sumaPzasDes = 0
                        promNrfti = 0
                        sumaPzasOKFinal = 0
                        sumaPzasDesFinal = 0
                        promNrftiFinal = 0
                        vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        sumaPzasOK = sumaPzasOK + pzasOK
                        sumaPzasDes = sumaPzasDes + pzasDes
                        promNrfti = (sumaPzasDes / (sumaPzasDes + sumaPzasOK)) * 1000000
                        sumaPzasOKFinal = sumaPzasOKFinal + pzasOK
                        sumaPzasDesFinal = sumaPzasDesFinal + pzasDes
                        promNrftiFinal = (sumaPzasDesFinal / (sumaPzasDesFinal + sumaPzasOKFinal)) * 1000000
                        vFecha_Actual = vDR("DIA_ASIGNADO")
                        pzasOK = 0
                        pzasDes = 0
                    End If
                Next
                cadenaXML += " <set value='" & promNrftiFinal.ToString & "' />"
            End If
        End If
        promNrftiFinal = Math.Round(promNrftiFinal)
        promNrftiFinal = Math.Truncate(promNrftiFinal)
        If banderaPromedio = True Then
            cadenaXML += " <set value='" & promNrftiFinal.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"

    End Sub
#End Region
#Region "ESTABLECE GENTE 1 EQUIPO N LINEAS"
    Private Sub establece_fechas_gente_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In vDT.Rows
                fechaGraficos = VDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 4, 2)
                    mes = getMeses(fechaGraficos)
                    cadenaXML += "<category name='" & mes & "' />"
                Next
            End If
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_gente_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim vTotalMes As Integer
        Dim vFaltas As Integer
        Dim vRetardos As Integer
        Dim VDT As DataTable

        If rbtDia.Checked Then
            cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vTotalMes = VDR("total")
                cadenaXML += "<set value='" & vTotalMes & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vFaltas = VDR("faltas")
                cadenaXML += "<set value='" & vFaltas & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vRetardos = VDR("retardos")
                cadenaXML += "<set value='" & vRetardos & "' />"
            Next

        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vFaltas = VDR("faltas")
                    cadenaXML += "<set value='" & vFaltas & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vRetardos = VDR("retardos")
                    cadenaXML += "<set value='" & vRetardos & "' />"
                Next
            End If
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE GENTE 1 EQUIPO 1 LINEA"
    Private Sub establece_fechas_gente(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In vDT.Rows
                fechaGraficos = VDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
            cadenaXML += "</categories>"
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 4, 2)
                    mes = getMeses(fechaGraficos)
                    cadenaXML += "<category name='" & mes & "' />"
                Next
            End If
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_gente(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim vTotalMes As Integer
        Dim vFaltas As Integer
        Dim vRetardos As Integer
        Dim VDT As DataTable

        If rbtDia.Checked Then
            cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vTotalMes = VDR("total")
                cadenaXML += "<set value='" & vTotalMes & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vFaltas = VDR("faltas")
                cadenaXML += "<set value='" & vFaltas & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vRetardos = VDR("retardos")
                cadenaXML += "<set value='" & vRetardos & "' />"
            Next
        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vFaltas = VDR("faltas")
                    cadenaXML += "<set value='" & vFaltas & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vRetardos = VDR("retardos")
                    cadenaXML += "<set value='" & vRetardos & "' />"
                Next
            End If
        End If
        cadenaXML += " </dataset>"
    End Sub

#End Region

#Region "ESTABLECE SEGURIDAD 1 EQUIPO N LINEAS"
    Private Sub establece_fechas_seguridad_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Seguridad_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In vDT.Rows
                fechaGraficos = VDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
            cadenaXML += "</categories>"

            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 4, 2)
                    mes = getMeses(fechaGraficos)
                    cadenaXML += "<category name='" & mes & "' />"
                Next
            End If
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_seguridad_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim vTotalMes As Integer
        Dim vResueltas As Integer
        Dim vNuevas As Integer
        Dim VDT As DataTable
        If rbtDia.Checked Then
            cadenaXML += "<dataset seriesName='TOTAL DEL MES' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Seguridad_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vTotalMes = VDR("total")
                cadenaXML += "<set value='" & vTotalMes & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='CI.RESUELTAS' color='006400' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='006400' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Seguridad_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vResueltas = VDR("resueltas")
                cadenaXML += "<set value='" & vResueltas & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='CI.NUEVAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"

            VDT = oGraficas.obtener_Seguridad_acumulado(idEquipo, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vNuevas = VDR("nuevas")
                cadenaXML += "<set value='" & vNuevas & "' />"
            Next
        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='TOTAL DEL MES' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Seguridad_por_mes_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='CI.RESUELTAS' color='006400' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='006400' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Seguridad_por_mes_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vResueltas = VDR("resueltas")
                    cadenaXML += "<set value='" & vResueltas & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='CI.NUEVAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"

                VDT = oGraficas.obtener_Seguridad_por_mes_acumulado(idEquipo, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vNuevas = VDR("nuevas")
                    cadenaXML += "<set value='" & vNuevas & "' />"
                Next

            End If
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region

#Region "ESTABLECE SEGURIDAD 1 EQUIPO 1 LINEA"
    Private Sub establece_fechas_seguridad(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Seguridad(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In vDT.Rows
                fechaGraficos = VDR("Dia_Asignado")
                fechaGraficos = Mid(fechaGraficos, 1, 5)
                cadenaXML += "<category name='" & fechaGraficos & "' />"
            Next
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Seguridad_por_mes_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 4, 2)
                    mes = getMeses(fechaGraficos)
                    cadenaXML += "<category name='" & mes & "' />"
                Next
            End If
        End If
        cadenaXML += " </dataset>"
    End Sub
    Private Sub establece_seguridad(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim vTotalMes As Integer
        Dim vResueltas As Integer
        Dim vNuevas As Integer
        Dim VDT As DataTable

        If rbtDia.Checked Then
            cadenaXML += "<dataset seriesName='TOTAL DEL MES' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Seguridad(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vTotalMes = VDR("total")
                cadenaXML += "<set value='" & vTotalMes & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='CI.RESUELTAS' color='006400' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='006400' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Seguridad(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vResueltas = VDR("resueltas")
                cadenaXML += "<set value='" & vResueltas & "' />"
            Next
            cadenaXML += " </dataset>"
            cadenaXML += "<dataset seriesName='CI.NUEVAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"

            VDT = oGraficas.obtener_Seguridad(idEquipo, idLinea, fechaInicio, fechaFinal)
            For Each VDR As DataRow In VDT.Rows
                vNuevas = VDR("nuevas")
                cadenaXML += "<set value='" & vNuevas & "' />"
            Next

        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='TOTAL DEL MES' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Seguridad_por_mes_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='CI.RESUELTAS' color='006400' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='006400' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Seguridad_por_mes_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vResueltas = VDR("resueltas")
                    cadenaXML += "<set value='" & vResueltas & "' />"
                Next
                cadenaXML += " </dataset>"
                cadenaXML += "<dataset seriesName='CI.NUEVAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"

                VDT = oGraficas.obtener_Seguridad_por_mes_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                For Each VDR As DataRow In VDT.Rows
                    vNuevas = VDR("nuevas")
                    cadenaXML += "<set value='" & vNuevas & "' />"
                Next

            End If

        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "GUARDAR GRAFICO EN EXCEL"

    Function capturaPantalla(ByVal locX As Integer, ByVal locY As Integer, ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim NewImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(NewImage)
            g.CopyFromScreen(locX, locY, 0, 0, NewImage.Size)
        End Using
        Return NewImage
    End Function

    Private Sub guardarGrafica()
        Dim screenPos As Point = Me.PointToScreen(New Point(0, 0))
        Dim bit As Bitmap = capturaPantalla(screenPos.X + swfGrafica.Location.X, screenPos.Y + swfGrafica.Location.Y, swfGrafica.Width, swfGrafica.Height)
        bit.Save(Application.StartupPath & "\Graficador\grafica.jpeg", Imaging.ImageFormat.Jpeg)
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
        cbxUN.Enabled = False
        cbxArea.Enabled = False
        cbxLinea.Enabled = True
        cbxEquipo.Enabled = True
        ''INICIALIZACION DE LAS FECHAS DE LOS CALENDARIOS
        dtpDesde.Value = DateSerial(Now.Year, Now.Month, 1) 'MUESTRA EL PRIMER DIA DEL MES
        dtpHasta.Value = Today 'MUESTRA LA FECHA ACTUAL
        ''INICIALIZACION BOTON GRAFICAR Y RADIO BUTTONS
        cmdGraficar.Enabled = False
        rbtDia.Checked = True
        rbtOEE.Checked = True
        rbtBarras.Checked = True
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
        dtpDesde.CustomFormat = "dd/MMMM/yyyy"
        dtpHasta.CustomFormat = "dd/MMMM/yyyy"
        Advertencia()
        Habilita_Graficar()
    End Sub

    Private Sub rbtMeses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMeses.CheckedChanged
        dtpDesde.CustomFormat = "MMMM/yyyy"
        dtpHasta.CustomFormat = "MMMM/yyyy"
        Advertencia()
        Habilita_Graficar()
    End Sub

    Private Sub rbtAnos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAnos.CheckedChanged
        dtpDesde.CustomFormat = "yyyy"
        dtpHasta.CustomFormat = "yyyy"
        Advertencia()
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
        rbtDia.Enabled = True
        rbtDia.Checked = True
        rbtMeses.Enabled = True
        rbtMeses.Checked = False
        HabilitarTipoGrafico()
    End Sub
    Private Sub rbtNRFTi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNRFTi.CheckedChanged
        rbtDia.Enabled = True
        rbtDia.Checked = True
        rbtMeses.Enabled = True
        rbtMeses.Checked = False
        HabilitarTipoGrafico()
    End Sub
    Private Sub rbtCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCosto.CheckedChanged
        'Habilita_Graficar()
        'rbtLineas.Enabled = False
        'rbtBarras.Enabled = False
        'rbtStock.Enabled = False
    End Sub

    Private Sub rbtSeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSeg.CheckedChanged
        rbtDia.Enabled = True
        rbtDia.Checked = True
        rbtMeses.Enabled = True
        rbtMeses.Checked = False
        HabilitarTipoGraficoStock()
    End Sub
    Private Sub rbtGente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGente.CheckedChanged
        rbtDia.Enabled = True
        rbtDia.Checked = True
        rbtMeses.Enabled = True
        rbtMeses.Checked = False
        HabilitarTipoGraficoStock()
    End Sub
    Private Sub rbt5s_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt5s.CheckedChanged
        If rbt5s.Checked Then
            rbtLineas.Enabled = True
            rbtBarras.Enabled = True
            rbtBarras.Checked = True
            rbtStock.Enabled = False
            rbtStock.Checked = False
            rbtDia.Enabled = False
            rbtMeses.Enabled = True
            rbtMeses.Checked = True
            HabilitarTipoGrafico()
        End If
    End Sub

#End Region
#Region "EVENTOS BOTONES GRAFICAR/EXPORTAR/SALIR"
    Private Sub cmdGraficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGraficar.Click
        swfGrafica.Visible = True
        Dim tipoGrafico As String = ""
        Dim ejeY As String = "R E S U L T A D O S "
        ''VALORES QUE CAMBIARAN DEPENDIENDO DEL INDICADOR SELECCIONADO
        '' 1. OEE           2. CALIDAD   3. COSTO    4. SEGURIDAD     5. 5'S       6. GENTE
        Dim maxEjeY As Integer = 0
        Dim numberSuffix As String = ""
        Dim subcaption As String = ""
        If rbtOEE.Checked Then
            maxEjeY = 100
            numberSuffix = "%25"
            subcaption = "OEE"
        ElseIf rbtNRFTi.Checked Then
            maxEjeY = 32000
            numberSuffix = ""
            subcaption = "NRFTi"
        ElseIf rbtCosto.Checked Then
            maxEjeY = 100 ''checar ??
            numberSuffix = ""
            subcaption = "COSTO"
        ElseIf rbtSeg.Checked Then
            maxEjeY = 15
            numberSuffix = ""
            subcaption = "SEGURIDAD"
        ElseIf rbt5s.Checked Then
            maxEjeY = 5
            numberSuffix = ""
            subcaption = "5s"
        ElseIf rbtGente.Checked Then
            maxEjeY = 15
            numberSuffix = ""
            subcaption = "GENTE"
        End If
        ''SELECCION DEL TIPO DE GRAFICA LINEA/BARRA/STOCK
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
        cadenaXML = rutaGrafica + "&dataXML=<graph YAxisMinValue='0' YAxisMaxValue='" & maxEjeY & "' numberSuffix='" & numberSuffix & "' caption='REPORTE DE RESULTADOS' subcaption='" & subcaption & "' YAxisName= '" & ejeY & "' xAxisName='F E C H A (s)' labeldisplay='rotate' decimalPrecision='2' rotateNames='1' formatNumberScale='0' thousandSeparator=',' bgcolor='ffffff' bgalpha='000000' showColumnShadow='1' showAlternateHGridColor='1' AlternateHGridColor='ff5904' divLineColor='ff5904' divLineAlpha='20' alternateHGridAlpha='5' canvasBorderColor='666666' baseFontColor='666666'>"

        Condicion_WHERE(cbxTodasLineas.Checked)
        '' O E E -- P R O D U C C I O N --
        If rbtOEE.Checked Then
            If cbxTodasLineas.Checked Then
                cadenaSELECT = "SELECT DISTINCT DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR1"
                establece_fechas(cadenaSELECT) ''establece_fechas(1)
                cadenaSELECT = "SELECT OEE, TIPO_REGISTRO, DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR1"
                establece_OEE_Acumulado(cadenaSELECT, colores(0))
            Else
                cadenaSELECT = "SELECT DIA_ASIGNADO, OEE, TIPO_REGISTRO FROM VISTA_SELECCION_INDICADOR1"
                establece_fechas(cadenaSELECT)
                establece_OEE(cadenaSELECT, colores(0))
            End If
            cadenaXML += "<trendlines> <line startValue='85.0' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
            ''N R F T I -- C A L I D A D --
        ElseIf rbtNRFTi.Checked Then
            If cbxTodasLineas.Checked Then
                cadenaSELECT = "SELECT DISTINCT DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR2"
                establece_fechas(cadenaSELECT) ''establece_fechas(1)
                cadenaSELECT = "SELECT DIA_ASIGNADO, PZAS_OK, PZAS_DESECHO, NRFTI FROM VISTA_SELECCION_INDICADOR2"
                establece_NRFTi_Acumulado(cadenaSELECT, colores(6))
            Else
                cadenaSELECT = "SELECT DIA_ASIGNADO, PZAS_OK, PZAS_DESECHO, NRFTI FROM VISTA_SELECCION_INDICADOR2"
                establece_fechas(cadenaSELECT)
                establece_NRFTi(cadenaSELECT, colores(6))
            End If
            cadenaXML += "<trendlines> <line startValue='12000' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
        ElseIf rbtCosto.Checked Then
            'establece_fechas(3)
            'establece_OEE(colores(2))

        ElseIf rbtSeg.Checked Then
            If cbxTodasLineas.Checked Then
                establece_fechas_seguridad_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_seguridad_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else ''x linea
                establece_fechas_seguridad(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_seguridad(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If

            ''G E N T E
        ElseIf rbtGente.Checked Then
            If cbxTodasLineas.Checked Then
                establece_fechas_gente_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_gente_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else ''x linea
                establece_fechas_gente(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_gente(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If

            '' 5 S
        ElseIf rbt5s.Checked Then
            If cbxTodasLineas.Checked Then
                cadenaSELECT = "SELECT DISTINCT DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR5"
                'establece_fechas(cadenaSELECT) CON PROMEDIO
                establece_fechas_5s(cadenaSELECT) 'SIN PROMEDIO
                cadenaSELECT = "SELECT PROMEDIO, DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR5"
                establece5S_Acumulado(cadenaSELECT, colores(12))
            Else
                cadenaSELECT = "SELECT PROMEDIO, DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR5"
                establece_fechas_5s(cadenaSELECT)
                establece_5S(cadenaSELECT, colores(12))
                cadenaXML += "<trendlines> <line startValue='3' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
            End If
        End If
        'cadenaXML += "<trendlines> <line startValue='1.5' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
        cadenaXML += " </graph>"
        swfGrafica.Movie = 1 'hace que el control actualice o se refresque
        swfGrafica.Movie = cadenaXML 'carga la pelicula flash
        cmdImprimir.Enabled = True

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        guardarGrafica()
        Dim ruta As String
        ruta = ""
        fbdBuscar.ShowNewFolderButton = True
        fbdBuscar.SelectedPath = ""
        fbdBuscar.ShowDialog()
        ruta = fbdBuscar.SelectedPath
        If ruta <> "" Then
            ruta = ruta & "\"
            Dim arch As ArchivoGraficas
            arch = New ArchivoGraficas
            Dim cadena_Conceptos As String = ""

            arch.Abre_Graficas()
            arch.Inserta_datos_grafica("C11", cbxUN.Text)
            arch.Inserta_datos_grafica("C12", cbxArea.Text)
            arch.Inserta_datos_grafica("C13", cbxLinea.Text)
            arch.Inserta_datos_grafica("C14", cbxEquipo.Text)
            'arch.Inserta_datos_grafica("F13", cbxEquipo.Text) 'CONCEPTO

            If rbtDia.Checked Then
                arch.Inserta_datos_grafica("F11", dtpDesde.Value.Day.ToString & "/" & dtpDesde.Value.Month.ToString & "/" & dtpDesde.Value.Year.ToString & " a " & dtpHasta.Value.Day.ToString & "/" & dtpHasta.Value.Month.ToString & "/" & dtpHasta.Value.Year.ToString)
            End If
            If rbtMeses.Checked Then
                arch.Inserta_datos_grafica("F11", dtpDesde.Value.Month.ToString & "/" & dtpDesde.Value.Year.ToString & " a " & dtpHasta.Value.Month.ToString & "/" & dtpHasta.Value.Year.ToString)
            End If
            
            arch.Exporta_Graficas_PDF(ruta)
            arch.Cierra_Graficas()
            MsgBox("El PDF fue guardado exitosamente en " & ruta, vbInformation)
        Else
        End If
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