﻿Imports CapaNegocios
Imports CapaNegocios.Configuracion
Imports System.Security.Principal
Imports System.IO
Public Class frmGraficas
#Region "VARIABLES GLOBALES"
    Dim oGraficas As Graficas
    Dim oFile As Manejo_Archivos
    Dim usuario As String = ""
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
    Dim vFecha_Now_Control As DateTime

#End Region
#Region "PASAR ID EQUIPO"
    Public Sub Set_IdEquipo(ByVal idEq As Integer)
        vIdEquipo = idEq
    End Sub
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
        colores(0) = "FFA500" '---------------AMARILLO FUERTE -->OEE
        colores(1) = "9D080D" '---------------ROJO   -->NUEVAS(SEGURIDAD), FALTAS(GENTE)
        colores(2) = "585858" '---------------GRIS -->COSTO
        colores(3) = "58D3F7" 'AzulPastelClaro
        colores(4) = "FAAC58" 'NaranjaClaro
        colores(5) = "FFFF00" 'AmarilloOscuro
        colores(6) = "0101DF" '---------------AZUL OSCURO -->NRFTI
        colores(7) = "8A0808" 'AzulPastelOscuro gente **
        colores(8) = "FF8000" 'NaranjaOscuro
        colores(9) = "FFBF00" '----------------AMARILLO -->TOTAL(SEGURIDAD), RETARDOS
        colores(10) = "045FB4" '---------------AZUL --GENTE
        colores(11) = "0B0B61" 'AzulOscuro
        colores(12) = "006400" '---------------VERDE -->5S, SEGURIDAD(RESUELTAS)
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

        If rbtOEE.Checked Then
            cadenaWHERE = cadenaWHERE & " and cve_turno <> 9 group by cadena, componente, linea, equipo, oee, tipo_registro, cve_turno, " & cadenaGroup & " order by " & cadenaGroup
        ElseIf rbtNRFTi.Checked Then

        ElseIf rbtCosto.Checked Then
            cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, costo, " & cadenaGroup & " order by " & cadenaGroup
        ElseIf rbtSeg.Checked Then

        ElseIf rbt5s.Checked Then
            cadenaWHERE = cadenaWHERE & " group by cadena, componente, linea, equipo, PROMEDIO, " & cadenaGroup & " order by " & cadenaGroup
        ElseIf rbtGente.Checked Then

        End If

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
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True ''Mensaje de error
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each vDR As DataRow In vDT.Rows
                    fechaGraficos = vDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 1, 5)
                    cadenaXML += "<category name='" & fechaGraficos & "' />"
                Next
                banderaPromedio = True
            End If

        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True ''Mensaje de error
                    lblError.Enabled = True
                Else
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            fechaGraficos = vDR("Dia_Asignado")
                            fechaGraficos = Mid(fechaGraficos, 4, 2)
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
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True ''Mensaje de error
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True ''Mensaje de error
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each vDR As DataRow In vDT.Rows
                        fechaGraficos = vDR("Dia_Asignado")
                        fechaGraficos = Mid(fechaGraficos, 4, 2)
                        mes = getMeses(fechaGraficos)
                        cadenaXML += "<category name='" & mes & "' />"
                    Next
                End If
            End If
        End If
        cadenaXML += "</categories>"
    End Sub
#End Region

#Region "ESTABLECE OEE 1 EQUIPO 1 LINEA"
    Private Sub establece_fechas_oee(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable = Nothing
        Dim banderaAcumulado As Boolean
        Dim vYearInicio As String = ""
        cadenaXML += "<categories>"
        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Oee_Dia_Linea(idEquipo, idLinea, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                Try
                    Dim vTotal As Integer = 1
                    Dim vContador As Integer = 1
                    vTotal = vDT.Rows.Count
                    For Each VDR As DataRow In vDT.Rows
                        If vContador = 1 Then

                        ElseIf vContador > 1 Then
                            fechaGraficos = VDR("DIA_ASIGNADO")
                            fechaGraficos = Mid(fechaGraficos, 1, 5)
                            cadenaXML += "<category name='" & fechaGraficos & "' />"
                        Else
                            'MsgBox("Este no se grafica" & VDR("OEE"))
                        End If
                        vContador = vContador + 1
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                banderaAcumulado = True
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Oee_Mes_Linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    Try
                        Dim vTotal As Integer = 1
                        Dim vContador As Integer = 1
                        vTotal = vDT.Rows.Count

                        For Each vDR As DataRow In vDT.Rows
                            If vTotal <> vContador Then
                                fechaGraficos = vDR("Dia_Asignado")
                                fechaGraficos = Mid(fechaGraficos, 4, 2)
                                mes = getMeses(fechaGraficos)
                                cadenaXML += "<category name='" & mes & "  " & vYearInicio & " ' />"
                            Else

                            End If
                            vContador = vContador + 1
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    banderaAcumulado = True
                End If
            End If
        End If
        If banderaAcumulado = True Then
            cadenaXML += "<category name ='ACUMULADO OEE' />"
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_OEE(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        Dim oeeAcumuladoFinal As Double = 0
        Dim vOEE_Acumulado_Final As Double = 0
        Dim banderaAcumulado As Boolean
        Dim oee As Double = 0
        cadenaXML += "<dataset seriesName='OEE' color='" & colores(0) & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFA500' anchorRadius='" & radio_anchor & "'>"
        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Oee_Dia_Linea(idEquipo, idLinea, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                Dim vTotal As Integer = 1
                Dim vContador As Integer = 1
                vTotal = vDT.Rows.Count
                For Each vDR As DataRow In vDT.Rows
                    If vContador = 1 Then
                        vOEE_Acumulado_Final = vDR("oee")
                    ElseIf vContador > 1 Then
                        oee = vDR("oee")
                        cadenaXML += "<set value='" & oee & "' />"
                    End If
                    vContador = vContador + 1
                Next
            End If
            banderaAcumulado = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Oee_Mes_Linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False

                    Dim vTotal As Integer = 1
                    Dim vContador As Integer = 1
                    vTotal = vDT.Rows.Count

                    For Each vDR As DataRow In vDT.Rows
                        If vTotal <> vContador Then
                            oee = vDR("oee")
                            cadenaXML += "<set value='" & oee & "' />"
                        Else
                            vOEE_Acumulado_Final = vDR("oee")
                        End If
                        vContador = vContador + 1
                    Next
                End If
                banderaAcumulado = True
            End If

        End If

        If banderaAcumulado = True Then
            cadenaXML += " <set value='" & vOEE_Acumulado_Final & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE OEE 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece_fechas_oee_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vYearInicio As String = ""
        Dim vDT As DataTable
        Dim banderaAcumulado As Boolean
        cadenaXML += "<categories>"
        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Oee_Dia(idEquipo, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                Dim vTotal As Integer = 1
                Dim vContador As Integer = 1
                vTotal = vDT.Rows.Count
                For Each VDR As DataRow In vDT.Rows
                    If vContador = 1 Then

                    ElseIf vContador > 1 Then
                        fechaGraficos = VDR("DIA_ASIGNADO")
                        fechaGraficos = Mid(fechaGraficos, 1, 5)
                        cadenaXML += "<category name='" & fechaGraficos & "' />"
                    Else
                        'MsgBox("Este no se grafica" & VDR("OEE"))
                    End If
                    vContador = vContador + 1
                Next
                banderaAcumulado = True
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Oee_Mes(idEquipo, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    Try
                        Dim vTotal As Integer = 1
                        Dim vContador As Integer = 1
                        vTotal = vDT.Rows.Count

                        For Each vDR As DataRow In vDT.Rows
                            If vTotal <> vContador Then
                                fechaGraficos = vDR("Dia_Asignado")
                                fechaGraficos = Mid(fechaGraficos, 4, 2)
                                mes = getMeses(fechaGraficos)
                                cadenaXML += "<category name='" & mes & "  " & vYearInicio & " ' />"
                            Else

                            End If
                            vContador = vContador + 1
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    banderaAcumulado = True
                End If
            End If
        End If
        If banderaAcumulado = True Then
            cadenaXML += "<category name ='ACUMULADO OEE' />"
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_OEE_Acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim vDT As DataTable
        Dim vYearInicio As String = ""
        Dim mes As String = ""
        Dim banderaAcumulado As Boolean = False
        Dim oee As Double = 0
        Dim vOEE_Acumulado_Final As Double = 0
        cadenaXML += "<dataset seriesName='OEE' color='" & colores(0) & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & colores(0) & "' anchorRadius='" & radio_anchor & "'>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Oee_Dia(idEquipo, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                Dim vTotal As Integer = 1
                Dim vContador As Integer = 1
                vTotal = vDT.Rows.Count
                For Each vDR As DataRow In vDT.Rows
                    If vContador = 1 Then
                        vOEE_Acumulado_Final = vDR("oee")
                    ElseIf vContador > 1 Then
                        oee = vDR("oee")
                        cadenaXML += "<set value='" & oee & "' />"
                    End If
                    vContador = vContador + 1
                Next
            End If
            banderaAcumulado = True
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Oee_Mes(idEquipo, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False

                    Dim vTotal As Integer = 1
                    Dim vContador As Integer = 1
                    vTotal = vDT.Rows.Count

                    For Each vDR As DataRow In vDT.Rows
                        If vTotal <> vContador Then
                            oee = vDR("oee")
                            cadenaXML += "<set value='" & oee & "' />"
                        Else
                            vOEE_Acumulado_Final = vDR("oee")
                        End If
                        vContador = vContador + 1
                    Next
                End If
                banderaAcumulado = True
            End If
        End If
        If banderaAcumulado = True Then
            cadenaXML += " <set value='" & vOEE_Acumulado_Final & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region

#Region "ESTABLECE NRFTI 1 EQUIPO 1 LINEA"
    Private Sub establece_fechas_nrfti(ByVal idEquipo As Integer, ByVal idLinea As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable = Nothing
        Dim banderaPromedio As Boolean
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        cadenaXML += "<categories>"
        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Nrfti(idEquipo, idLinea, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 1, 5)
                    cadenaXML += "<category name='" & fechaGraficos & "' />"
                Next
                banderaPromedio = True
            End If
        Else

            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Nrfti(idEquipo, idLinea, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            fechaGraficos = vDR("Dia_Asignado")
                            fechaGraficos = Mid(fechaGraficos, 4, 2)
                            mes = getMeses(fechaGraficos)
                        Else
                            cadenaXML += "<category name='" & mes & "  " & vYearInicio & " ' />"
                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        End If
                    Next
                    banderaPromedio = True
                End If
                cadenaXML += "<category name='" & mes & "   " & vYearInicio & "' />"
            End If
            ''fin por meses
        End If
        If banderaPromedio = True Then
            cadenaXML += "<category name ='ACUMULADO' />"
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_NRFTi(ByVal idEquipo, ByVal idLinea, ByVal fechaInicio, ByVal fechaFinal)
        Dim sumaPzasOK As Double = 0
        Dim sumaPzasDes As Double = 0
        Dim sumaRechazos As Double = 0
        Dim ppms As Double = 0 ''calcular el nrft por día
        Dim totalPzasOk As Double = 0
        Dim totalPzasDes As Double = 0
        Dim totalRechazos As Double = 0
        Dim NrftiAcumulado As Double = 0 ''nrft acumulado de un rango entre fechas
        Dim numerador As Double = 0
        Dim denominador As Double = 0
        Dim numeradorAcum As Double = 0
        Dim denominadorAcum As Double = 0
        ''NRFTI=((DESECHOS+RECHAZOS)/(DESDECHOS+RECHAZOS+PZAS.OK))*1,000,000
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='NRFTi' color='" & colores(6) & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & colores(6) & "' anchorRadius='" & radio_anchor & "'>"
        Dim nrfti As Double = 0
        Dim pzasOK As Double = 0
        Dim pzasDes As Double = 0
        Dim rechazos As Double = 0
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim banderaPromedio As Boolean

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Nrfti(idEquipo, idLinea, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each vDR As DataRow In vDT.Rows
                    If vDR("NRFTI") <> 0 Then
                        nrfti = vDR("NRFTI")
                        pzasOK = vDR("PZAS_OK")
                        pzasDes = vDR("PZAS_DESECHO")
                        rechazos = vDR("rechazos")
                        numerador = pzasDes + rechazos
                        denominador = pzasDes + rechazos + pzasOK
                        If numerador <> 0 And denominador <> 0 Then
                            ppms = (numerador / denominador) * 1000000
                        Else
                            ppms = 0
                        End If
                        cadenaXML += " <set value='" & ppms.ToString & "'/>"
                        ''Sacar el total para graficar el acumulado al final
                        totalPzasOk = totalPzasOk + pzasOK
                        totalPzasDes = totalPzasDes + pzasDes
                        totalRechazos = totalRechazos + rechazos
                    ElseIf vDR("NRFTI") = 0 Then
                        nrfti = vDR("NRFTI")
                        pzasOK = vDR("PZAS_OK")
                        pzasDes = vDR("PZAS_DESECHO")
                        rechazos = vDR("rechazos")
                        numerador = pzasDes + rechazos
                        denominador = pzasDes + rechazos + pzasOK
                        If numerador <> 0 And denominador <> 0 Then
                            ppms = (numerador / denominador) * 1000000
                        Else
                            ppms = 0
                        End If
                        cadenaXML += " <set value='" & ppms.ToString & "' />"
                        ''Sacar el total para graficar el acumulado al final
                        totalPzasOk = totalPzasOk + pzasOK
                        totalPzasDes = totalPzasDes + pzasDes
                        totalRechazos = totalRechazos + rechazos
                    End If
                    numeradorAcum = totalPzasDes + totalRechazos
                    denominadorAcum = totalPzasDes + totalRechazos + totalPzasOk
                    If numeradorAcum <> 0 And denominadorAcum <> 0 Then
                        NrftiAcumulado = (numeradorAcum / denominadorAcum) * 1000000
                    Else
                        NrftiAcumulado = 0
                    End If
                    banderaPromedio = True
                Next
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Nrfti(idEquipo, idLinea, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            nrfti = vDR("NRFTI")
                            pzasOK = vDR("PZAS_OK")
                            pzasDes = vDR("PZAS_DESECHO")
                            rechazos = vDR("rechazos")
                            sumaPzasOK = sumaPzasOK + pzasOK
                            sumaPzasDes = sumaPzasDes + pzasDes
                            sumaRechazos = sumaRechazos + rechazos
                            numerador = sumaPzasDes + sumaRechazos
                            denominador = sumaPzasDes + sumaRechazos + sumaPzasOK
                            If numerador <> 0 And denominador <> 0 Then
                                ppms = (numerador / denominador) * 1000000
                            Else
                                ppms = 0
                            End If
                            ''Sacar el total para graficar el acumulado al final
                            totalPzasOk = totalPzasOk + pzasOK
                            totalPzasDes = totalPzasDes + pzasDes
                            totalRechazos = totalRechazos + rechazos
                        Else
                            ''NRFTI=((DESECHOS+RECHAZOS)/(DESDECHOS+RECHAZOS+PZAS.OK))*1,000,000
                            cadenaXML += " <set value='" & ppms.ToString & "' />" ''nrfti x mes
                            pzasOK = 0
                            pzasDes = 0
                            rechazos = 0
                            sumaPzasOK = 0
                            sumaPzasDes = 0
                            sumaRechazos = 0

                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            pzasOK = vDR("PZAS_OK")
                            pzasDes = vDR("PZAS_DESECHO")
                            rechazos = vDR("rechazos")
                            sumaPzasOK = sumaPzasOK + pzasOK
                            sumaPzasDes = sumaPzasDes + pzasDes
                            sumaRechazos = sumaRechazos + rechazos
                            numerador = sumaPzasDes + sumaRechazos
                            denominador = sumaPzasDes + sumaRechazos + sumaPzasOK
                            If numerador <> 0 And denominador <> 0 Then
                                ppms = (numerador / denominador) * 1000000
                            Else
                                ppms = 0
                            End If
                            ''Sacar el total para graficar el acumulado al final
                            totalPzasOk = totalPzasOk + pzasOK
                            totalPzasDes = totalPzasDes + pzasDes
                            totalRechazos = totalRechazos + rechazos
                        End If

                        numeradorAcum = totalPzasDes + totalRechazos
                        denominadorAcum = totalPzasDes + totalRechazos + totalPzasOk
                        If numeradorAcum <> 0 And denominadorAcum <> 0 Then
                            NrftiAcumulado = (numeradorAcum / denominadorAcum) * 1000000
                        Else
                            NrftiAcumulado = 0
                        End If
                        banderaPromedio = True

                    Next
                    cadenaXML += " <set value='" & ppms.ToString & "' />"
                End If

            End If

        End If ''dia/mes
        NrftiAcumulado = Math.Round(NrftiAcumulado)
        NrftiAcumulado = Math.Truncate(NrftiAcumulado)
        If banderaPromedio = True Then
            cadenaXML += " <set value='" & NrftiAcumulado.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"

    End Sub
#End Region
#Region "ESTABLECE NRFTI 1 EQUIPO LINEAS ACUMULADAS"
    Private Sub establece_fechas_nrfti_acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim fechaGraficos As String = ""
        Dim mes As String = ""
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim vDT As DataTable
        Dim banderaPromedio As Boolean
        'Dim vFecha_Actual As DateTime
        cadenaXML += "<categories>"

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Nrfti_acumulado(idEquipo, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True ''Mensaje de error
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("DIA_ASIGNADO")
                    fechaGraficos = Mid(fechaGraficos, 1, 5)
                    cadenaXML += "<category name='" & fechaGraficos & "' />"
                Next
                banderaPromedio = True
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Nrfti_acumulado(idEquipo, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            fechaGraficos = vDR("Dia_Asignado")
                            fechaGraficos = Mid(fechaGraficos, 4, 2)
                            mes = getMeses(fechaGraficos)
                        Else
                            cadenaXML += "<category name='" & mes & "  " & vYearInicio & " ' />"
                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                        End If
                    Next
                    banderaPromedio = True
                End If
                cadenaXML += "<category name='" & mes & "   " & vYearInicio & "' />"
            End If
        End If
        If banderaPromedio = True Then
            cadenaXML += "<category name ='ACUMULADO' />"
        End If
        cadenaXML += "</categories>"
    End Sub
    Private Sub establece_NRFTi_Acumulado(ByVal idEquipo As Integer, ByVal fechaInicio As DateTime, ByVal fechaFinal As DateTime)
        Dim sumaPzasOK As Double = 0
        Dim sumaPzasDes As Double = 0
        Dim sumaRechazos As Double = 0
        Dim ppms As Double = 0 ''calcular el nrft por día
        Dim totalPzasOk As Double = 0
        Dim totalPzasDes As Double = 0
        Dim totalRechazos As Double = 0
        Dim NrftiAcumulado As Double = 0 ''nrft acumulado de un rango entre fechas
        Dim numerador As Double = 0
        Dim denominador As Double = 0
        Dim numeradorAcum As Double = 0
        Dim denominadorAcum As Double = 0
        Dim vDT As DataTable
        cadenaXML += "<dataset seriesName='NRFTi' color='" & colores(6) & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & colores(6) & "' anchorRadius='" & radio_anchor & "'>"
        Dim nrfti As Double = 0
        Dim pzasOK As Double = 0
        Dim pzasDes As Double = 0
        Dim rechazos As Integer = 0
        Dim vFecha_Actual As DateTime
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim banderaPromedio As Boolean

        If rbtDia.Checked Then
            vDT = oGraficas.obtener_Nrfti_acumulado(idEquipo, fechaInicio, fechaFinal)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each vDR As DataRow In vDT.Rows
                    Try
                        If IsDBNull(vDR("pzas_ok")) Then
                            pzasOK = 0
                        Else
                            pzasOK = vDR("pzas_ok")
                        End If
                        If IsDBNull(vDR("pzas_desecho")) Then
                            pzasDes = 0
                        Else
                            pzasDes = vDR("pzas_desecho")
                        End If
                        If IsDBNull(vDR("rechazos")) Then
                            rechazos = 0
                        Else
                            rechazos = vDR("rechazos")
                        End If
                    Catch ex As Exception

                    End Try
                    numerador = pzasDes + rechazos
                    denominador = pzasDes + rechazos + pzasOK
                    If numerador <> 0 And denominador <> 0 Then
                        ppms = (numerador / denominador) * 1000000
                    Else
                        ppms = 0
                    End If
                    cadenaXML += " <set value='" & ppms.ToString & "'/>"
                    ''Sacar el total para graficar el acumulado al final
                    totalPzasOk = totalPzasOk + pzasOK
                    totalPzasDes = totalPzasDes + pzasDes
                    totalRechazos = totalRechazos + rechazos
                Next
                numeradorAcum = totalPzasDes + totalRechazos
                denominadorAcum = totalPzasDes + totalRechazos + totalPzasOk
                If numeradorAcum <> 0 And denominadorAcum <> 0 Then
                    NrftiAcumulado = (numeradorAcum / denominadorAcum) * 1000000
                Else
                    NrftiAcumulado = 0
                End If
                banderaPromedio = True
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Nrfti_acumulado(idEquipo, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            pzasOK = vDR("pzas_ok")
                            pzasDes = vDR("pzas_desecho")
                            rechazos = vDR("rechazos")
                            sumaPzasOK = sumaPzasOK + pzasOK
                            sumaPzasDes = sumaPzasDes + pzasDes
                            sumaRechazos = sumaRechazos + rechazos
                            numerador = sumaPzasDes + sumaRechazos
                            denominador = sumaPzasDes + sumaRechazos + sumaPzasOK
                            If numerador <> 0 And denominador <> 0 Then
                                ppms = (numerador / denominador) * 1000000
                            Else
                                ppms = 0
                            End If
                            ''Sacar el total para graficar el acumulado al final
                            totalPzasOk = totalPzasOk + pzasOK
                            totalPzasDes = totalPzasDes + pzasDes
                            totalRechazos = totalRechazos + rechazos
                        Else
                            ''NRFTI=((DESECHOS+RECHAZOS)/(DESDECHOS+RECHAZOS+PZAS.OK))*1,000,000
                            cadenaXML += " <set value='" & ppms.ToString & "' />" ''nrfti x mes
                            pzasOK = 0
                            pzasDes = 0
                            rechazos = 0
                            sumaPzasOK = 0
                            sumaPzasDes = 0
                            sumaRechazos = 0

                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            pzasOK = vDR("pzas_ok")
                            pzasDes = vDR("pzas_desecho")
                            rechazos = vDR("rechazos")
                            sumaPzasOK = sumaPzasOK + pzasOK
                            sumaPzasDes = sumaPzasDes + pzasDes
                            sumaRechazos = sumaRechazos + rechazos
                            numerador = sumaPzasDes + sumaRechazos
                            denominador = sumaPzasDes + sumaRechazos + sumaPzasOK
                            If numerador <> 0 And denominador <> 0 Then
                                ppms = (numerador / denominador) * 1000000
                            Else
                                ppms = 0
                            End If
                            ''Sacar el total para graficar el acumulado al final
                            totalPzasOk = totalPzasOk + pzasOK
                            totalPzasDes = totalPzasDes + pzasDes
                            totalRechazos = totalRechazos + rechazos
                        End If
                        numeradorAcum = totalPzasDes + totalRechazos
                        denominadorAcum = totalPzasDes + totalRechazos + totalPzasOk
                        If numeradorAcum <> 0 And denominadorAcum <> 0 Then
                            NrftiAcumulado = (numeradorAcum / denominadorAcum) * 1000000
                        Else
                            NrftiAcumulado = 0
                        End If
                        banderaPromedio = True
                    Next
                    cadenaXML += " <set value='" & ppms.ToString & "' />"
                End If
            End If
        End If
        NrftiAcumulado = Math.Round(NrftiAcumulado)
        NrftiAcumulado = Math.Truncate(NrftiAcumulado)
        If banderaPromedio = True Then
            cadenaXML += " <set value='" & NrftiAcumulado.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region

#Region "ESTABLECE COSTO 1 EQUIPO 1 LINEA"
    Private Sub establece_Costo(ByVal cadena As String, ByVal color As String)
        Dim promedio As Double = 0
        Dim contador As Integer = 0
        Dim fechaGraficos As String = ""
        Dim vMesInicio As String = ""
        Dim vYearInicio As String = ""
        Dim mes As String = ""
        Dim vDT As DataTable
        Dim banderaPromedio As Boolean


        cadenaXML += "<dataset seriesName='Costo' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim costo As Double = 0
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each vDR As DataRow In vDT.Rows
                    costo = vDR("costo")
                    If costo = 0 Then
                        cadenaXML += " <set value='" & costo.ToString & "'/>"
                    Else
                        promedio = promedio + costo
                        contador = contador + 1
                        cadenaXML += " <set value='" & costo.ToString & "'/>"
                    End If
                Next
                banderaPromedio = True
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            costo = vDR("costo")
                            If costo <> 0 Then
                                promedio = promedio + costo
                                contador = contador + 1
                            Else
                                promedio = 0
                            End If
                        Else
                            banderaPromedio = False
                            If promedio <> 0 Then
                                promedio = promedio / contador
                            Else
                                promedio = 0
                            End If
                            'promedio = promedio / contador
                            cadenaXML += " <set value='" & promedio.ToString & "'/>"
                            promedio = 0
                            costo = 0
                            contador = 0
                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            costo = vDR("costo")
                            If costo <> 0 Then
                                promedio = promedio + costo
                                contador = contador + 1
                            Else
                                promedio = 0
                            End If
                        End If
                    Next
                    'promedio = promedio / contador
                    If promedio <> 0 Then
                        promedio = promedio / contador
                    Else
                        promedio = 0
                    End If
                    cadenaXML += " <set value='" & promedio.ToString & "'/>"
                End If


            End If
        End If
        ''validar que en el promedio no halla valores cero 0
        If rbtDia.Checked And promedio <> 0 Then
            promedio = promedio / contador
        ElseIf rbtMeses.Checked Then
            ''nada
        Else
            promedio = 0
        End If
        If banderaPromedio = True Then
            cadenaXML += " <set value='" & promedio.ToString & "' color='" & colores(1) & "'/>"
        End If
        cadenaXML += " </dataset>"
    End Sub
#End Region
#Region "ESTABLECE COSTO 1 EQUIPO N LINEAS"
    Private Sub establece_Costo_Acumulado(ByVal cadena As String, ByVal color As String)
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


        cadenaXML += "<dataset seriesName='COSTO' color='" & color & "' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='" & color & "' anchorRadius='" & radio_anchor & "'>"
        Dim costo As Double = 0
        Dim vFecha_Actual As DateTime
        If rbtDia.Checked Then
            vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
                For Each vDR As DataRow In vDT.Rows
                    If vDR("costo") <> 0 And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                        costo = vDR("costo")
                        promDia = promDia + costo
                        contador = contador + 1
                    ElseIf vDR("costo") = 0 And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                        costo = 0
                    Else
                        If promDia <> 0 Then
                            vContador_Dias = vContador_Dias + 1
                            promDia = promDia / contador
                            promAcumulado = promAcumulado + promDia
                        Else
                            promDia = 0
                            promAcumulado = 0
                        End If
                        cadenaXML += " <set value='" & promDia.ToString & "'/>"
                        vFecha_Actual = vDR("DIA_ASIGNADO")
                        costo = 0
                        promDia = 0
                        contador = 0
                        If vDR("costo") <> 0 And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                            costo = vDR("costo")
                            promDia = promDia + costo
                            contador = contador + 1
                        ElseIf vDR("costo") = 0 And vFecha_Actual = vDR("DIA_ASIGNADO") Then
                            costo = 0
                        Else


                        End If


                    End If
                Next
                cadenaXML += " <set value='" & promDia.ToString & "'/>"
                vContador_Dias = vContador_Dias + 1
                promAcumulado = promAcumulado + promDia
                banderaPromedio = False
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.ejecutarVista(cadena, cadenaWHERE)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += " <set value='" & 0 & "'/>"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    vFecha_Actual = vDT.Rows(0).Item("DIA_ASIGNADO").ToString
                    vMesInicio = Month(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    vYearInicio = Year(DateTime.Parse(vDT.Rows(0).Item("Dia_Asignado"))).ToString
                    For Each vDR As DataRow In vDT.Rows
                        If (Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vMesInicio And Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString = vYearInicio) Then
                            costo = vDR("costo")
                            If vDR("costo") <> 0 Then
                                promAcumulado = promAcumulado + costo
                                contador = contador + 1
                            Else
                                costo = 0
                            End If
                        Else
                            banderaPromedio = False
                            If promAcumulado <> 0 Then
                                promAcumulado = promAcumulado / contador
                                cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
                            Else
                                promAcumulado = 0
                                cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
                            End If
                            vMesInicio = Month(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vYearInicio = Year(DateTime.Parse(vDR("Dia_Asignado"))).ToString
                            vFecha_Actual = vDR("DIA_ASIGNADO")
                            costo = 0
                            promAcumulado = 0
                            contador = 0


                            costo = vDR("costo")
                            If vDR("costo") <> 0 Then
                                promAcumulado = promAcumulado + costo
                                contador = contador + 1
                            Else
                                costo = 0
                            End If
                        End If
                    Next
                    If promAcumulado <> 0 Then
                        promAcumulado = promAcumulado / contador
                    Else
                        promAcumulado = 0
                    End If
                    cadenaXML += " <set value='" & promAcumulado.ToString & "'/>"
                End If

            End If
        End If
        If rbtDia.Checked And banderaPromedio = True Then
            promFinal = promAcumulado / vContador_Dias
            cadenaXML += " <set value='" & promFinal.ToString & "' color='" & colores(1) & "'/>"
        ElseIf rbtMeses.Checked Then
            ''nada
        Else
            promFinal = 0
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
            If vDT.Rows.Count = 0 Then
                lblError.Enabled = True
                lblError.Visible = True
                cadenaXML += " <set value='" & promedio5S.ToString & "'/>"
            Else
                lblError.Enabled = False
                lblError.Visible = False
                For Each vDR As DataRow In vDT.Rows
                    promedio5S = vDR("PROMEDIO")
                    cadenaXML += " <set value='" & promedio5S.ToString & "'/>"
                Next
            End If
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
            If vDT.Rows.Count = 0 Then
                lblError.Enabled = True
                lblError.Visible = True
                cadenaXML += " <set value='" & 0 & "'/>"
            Else
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
            End If
            promAnual = promMes / contador
            cadenaXML += " <set value='" & promAnual.ToString & "'/>"
            cadenaXML += " </dataset>"
        End If
        'promAnual = promMes / contador
        'cadenaXML += " <set value='" & promAnual.ToString & "' color='" & colores(1) & "'/>"
        'cadenaXML += " </dataset>"
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
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 1, 5)
                    cadenaXML += "<category name='" & fechaGraficos & "' />"
                Next
            End If
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    For Each VDR As DataRow In vDT.Rows
                        fechaGraficos = VDR("Dia_Asignado")
                        fechaGraficos = Mid(fechaGraficos, 4, 2)
                        mes = getMeses(fechaGraficos)
                        cadenaXML += "<category name='" & mes & "' />"
                    Next
                End If

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
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
            End If
            cadenaXML += " </dataset>"

            cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vFaltas = VDR("faltas")
                    cadenaXML += "<set value='" & vFaltas & "' />"
                Next
            End If
            cadenaXML += " </dataset>"

            cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente_acumulado(idEquipo, fechaInicio, fechaFinal)
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vRetardos = VDR("retardos")
                    cadenaXML += "<set value='" & vRetardos & "' />"
                Next
            End If

        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vTotalMes = VDR("total")
                        cadenaXML += "<set value='" & vTotalMes & "' />"
                    Next
                End If
                cadenaXML += " </dataset>"

                cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vFaltas = VDR("faltas")
                        cadenaXML += "<set value='" & vFaltas & "' />"
                    Next
                End If
                cadenaXML += " </dataset>"

                cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_acumulado(idEquipo, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vRetardos = VDR("retardos")
                        cadenaXML += "<set value='" & vRetardos & "' />"
                    Next
                End If

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
            If vDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In vDT.Rows
                    fechaGraficos = VDR("Dia_Asignado")
                    fechaGraficos = Mid(fechaGraficos, 1, 5)
                    cadenaXML += "<category name='" & fechaGraficos & "' />"
                Next
            End If

        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If vDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In vDT.Rows
                        fechaGraficos = VDR("Dia_Asignado")
                        fechaGraficos = Mid(fechaGraficos, 4, 2)
                        mes = getMeses(fechaGraficos)
                        cadenaXML += "<category name='" & mes & "' />"
                    Next
                End If

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
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vTotalMes = VDR("total")
                    cadenaXML += "<set value='" & vTotalMes & "' />"
                Next
            End If
            cadenaXML += " </dataset>"

            cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vFaltas = VDR("faltas")
                    cadenaXML += "<set value='" & vFaltas & "' />"
                Next
            End If
            cadenaXML += " </dataset>"

            cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
            VDT = oGraficas.obtener_Gente(idEquipo, idLinea, fechaInicio, fechaFinal)
            If VDT.Rows.Count = 0 Then
                lblError.Visible = True
                lblError.Enabled = True
                cadenaXML += "<set value='" & 0 & "' />"
            Else
                lblError.Visible = False
                lblError.Enabled = False
                For Each VDR As DataRow In VDT.Rows
                    vRetardos = VDR("retardos")
                    cadenaXML += "<set value='" & vRetardos & "' />"
                Next
            End If

        Else
            If rbtMeses.Checked Then
                cadenaXML += "<dataset seriesName='INCIDENCIAS' color='045FB4' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='045FB4' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vTotalMes = VDR("total")
                        cadenaXML += "<set value='" & vTotalMes & "' />"
                    Next
                End If
                cadenaXML += " </dataset>"

                cadenaXML += "<dataset seriesName='FALTAS' color='9D080D' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='9D080D' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vFaltas = VDR("faltas")
                        cadenaXML += "<set value='" & vFaltas & "' />"
                    Next
                End If
                cadenaXML += " </dataset>"

                cadenaXML += "<dataset seriesName='RETARDOS' color='FFBF00' anchorBorderColor='" & contorno_anchor & "' anchorBgColor='FFBF00' anchorRadius='" & radio_anchor & "'>"
                VDT = oGraficas.obtener_Gente_por_meses_por_linea(idEquipo, idLinea, fechaInicio, fechaFinal)
                If VDT.Rows.Count = 0 Then
                    lblError.Visible = True
                    lblError.Enabled = True
                    cadenaXML += "<set value='" & 0 & "' />"
                Else
                    lblError.Visible = False
                    lblError.Enabled = False
                    For Each VDR As DataRow In VDT.Rows
                        vRetardos = VDR("retardos")
                        cadenaXML += "<set value='" & vRetardos & "' />"
                    Next
                End If

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
        Else
            If rbtMeses.Checked Then
                vDT = oGraficas.obtener_Seguridad_por_mes_acumulado(idEquipo, fechaInicio, fechaFinal)
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
        cadenaXML += "</categories>"
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
            ''corregir
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

#Region "OBTENER OBJETIVO"
    Public Function obtener_Objetivo(ByVal idEquipo As Integer, ByVal indicador As Integer) As Double
        oGraficas = New Graficas
        Dim indicadorSeleccionado As Integer = indicador
        Dim obj As Double = 0
        Dim objGS As Integer = 0
        Select Case indicadorSeleccionado
            Case 1
                obj = oGraficas.obtener_Objetivo_Productividad(idEquipo)
                Return obj * 100
            Case 2
                obj = oGraficas.obtener_Objetivo_Calidad(idEquipo)
                Return obj
            Case 3
                obj = oGraficas.obtener_Objetivo_Costo(idEquipo)
                Return obj
            Case 4
                objGS = oGraficas.obtener_Objetivo_Seguridad(idEquipo)
                Return objGS
            Case 5
                objGS = oGraficas.obtener_Objetivo_Gente(idEquipo)
                Return objGS
            Case 6
                obj = oGraficas.obtener_Objetivo_CincoS(idEquipo)
                Return obj
            Case Else
                Return "error!"
        End Select
    End Function
#End Region

#Region "GUARDAR GRAFICO EN EXCEL"

    ''Método para copiar la carpeta graficador que contiene la img.jpg y el macro graficador.xmls
    Private Sub copiarCarpeta()
        oFile = New Manejo_Archivos
        Dim existeDir, existeFile1, existeFile2 As Boolean
        usuario = Mid(WindowsIdentity.GetCurrent.Name, 11).ToUpper
        ''Dim rutaDirectorio As String = "C:\Users\'" & usuario & "'\Documents\Graficador"
        Dim rutaDirectorio As String = "C:\Users\Patricia\Documents\Graficador"
        existeDir = oFile.Existe_Directorio(rutaDirectorio)
        existeFile1 = oFile.Existe_Archivo("C:\Users\Patricia\Documents\Graficador\PDFGrafica.xlsm")
        existeFile2 = oFile.Existe_Archivo("C:\Users\Patricia\Documents\Graficador\grafica.jpeg")
        If existeDir Then
            If existeFile1 And existeFile2 Then
                'MsgBox("existe el directorio!!!!!!!yeah")
                guardarGrafica()
            Else
                oFile.CopiarArchivo(Application.StartupPath & "\Graficador\grafica.jpeg", "C:\Users\Patricia\Documents\Graficador\grafica.jpeg")
                oFile.CopiarArchivo(Application.StartupPath & "\Graficador\PDFGrafica.xlsm", "C:\Users\Patricia\Documents\Graficador\PDFGrafica.xlsm")
            End If
        Else
            'MsgBox("no esta el directorio!! Buuh")
            Directory.CreateDirectory("C:\Users\Patricia\Documents\Graficador") ''si funciona crea la carpeta
            oFile.CopiarArchivo(Application.StartupPath & "\Graficador\grafica.jpeg", "C:\Users\Patricia\Documents\Graficador\grafica.jpeg")
            oFile.CopiarArchivo(Application.StartupPath & "\Graficador\PDFGrafica.xlsm", "C:\Users\Patricia\Documents\Graficador\PDFGrafica.xlsm")
            guardarGrafica()
        End If
    End Sub

    Function capturaPantalla(ByVal locX As Integer, ByVal locY As Integer, ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim NewImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(NewImage)
            g.CopyFromScreen(locX, locY, 0, 0, NewImage.Size)
        End Using
        Return NewImage
    End Function

    Private Sub guardarGrafica()
        Dim screenPos As Point = Me.PointToScreen(New Point(0, 0))
        Dim bit As Bitmap
        bit = capturaPantalla(screenPos.X + swfGrafica.Location.X, screenPos.Y + swfGrafica.Location.Y, swfGrafica.Width, swfGrafica.Height)
        Dim bit2 As New Bitmap(bit)
        Try
            'bit2.Save(Application.StartupPath & "\Graficador\grafica.jpeg", Imaging.ImageFormat.Jpeg)
            bit2.Save("C:\Users\Patricia\Documents\Graficador\grafica.jpeg", Imaging.ImageFormat.Jpeg)
            bit.Dispose()
            bit2.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
        cbxArea.Enabled = True
        cbxLinea.Enabled = True
        cbxEquipo.Enabled = False
        ''INICIALIZACION DE LAS FECHAS DE LOS CALENDARIOS
        dtpDesde.Value = DateSerial(Now.Year, Now.Month, 1) 'MUESTRA EL PRIMER DIA DEL MES
        dtpHasta.Value = DateSerial(Now.Year, Now.Month + 1, 1) ''Today 'MUESTRA LA FECHA ACTUAL
        ''INICIALIZACION BOTON GRAFICAR Y RADIO BUTTONS
        cmdGraficar.Enabled = False
        rbtDia.Checked = True
        rbtOEE.Checked = True
        rbtBarras.Checked = True
        lblError.Visible = False
        lblError.Enabled = False
        rbtCosto.Enabled = True
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
        Try
            If rbtDia.Checked Then
                Dim vDia As Integer = dtpDesde.Value.Day
                Dim vMes As Integer = dtpDesde.Value.Month
                Dim vYear As Integer = dtpDesde.Value.Year
                Dim vCadena_Fecha_Max As DateTime = Date.Now
                Dim vUltimo_Dia_Mes As Date = Date.Now
                vCadena_Fecha_Max = vDia & "/" & vMes & "/" & vYear
                vCadena_Fecha_Max = vCadena_Fecha_Max.AddDays(30)
                'If vCadena_Fecha_Max.Year < vFecha_Now_Control.Year Then
                '    If vMes = 12 Then
                '        vYear = vYear + 1
                '        vMes = 1
                '        vUltimo_Dia_Mes = vDia & "/" & vMes & "/" & vYear
                '        vUltimo_Dia_Mes = vUltimo_Dia_Mes.AddDays(-vUltimo_Dia_Mes.Day + 1).AddMonths(1).AddDays(-1)
                '        vCadena_Fecha_Max = vUltimo_Dia_Mes.Day & "/" & vMes & "/" & vYear
                '    End If
                'ElseIf vCadena_Fecha_Max > vFecha_Now_Control Then
                '    If vMes = 12 Then
                '        vYear = vYear + 1
                '        vMes = 1
                '    End If
                '    vUltimo_Dia_Mes = vDia & "/" & vMes & "/" & vYear
                '    vUltimo_Dia_Mes = vUltimo_Dia_Mes.AddDays(-vUltimo_Dia_Mes.Day + 1).AddMonths(1).AddDays(-1)
                '    vCadena_Fecha_Max = vUltimo_Dia_Mes.Day & "/" & vMes + 1 & "/" & vYear
                'Else
                '    vUltimo_Dia_Mes = vDia & "/" & vMes + 1 & "/" & vYear
                '    vUltimo_Dia_Mes = vUltimo_Dia_Mes.AddDays(-vUltimo_Dia_Mes.Day + 1).AddMonths(1).AddDays(-1)
                '    vCadena_Fecha_Max = vUltimo_Dia_Mes.Day & "/" & vMes + 1 & "/" & vYear
                'End If
                dtpHasta.MaxDate = vCadena_Fecha_Max
            End If
        Catch ex As Exception

        End Try

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
        dtpHasta.MaxDate = "12/9998"
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
        Dim Indicador As Integer = 0
        Dim valorObj As Double = 0
        Dim valorObjGS As Integer = 0
        Dim tipoGrafico As String = ""
        Dim decimales As String = ""
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
            decimales = "1"
        ElseIf rbtNRFTi.Checked Then
            maxEjeY = 1000
            numberSuffix = ""
            subcaption = "NRFTi"
            decimales = "0"
        ElseIf rbtCosto.Checked Then
            maxEjeY = 100
            numberSuffix = "$"
            subcaption = "COSTO"
            decimales = "1"
        ElseIf rbtSeg.Checked Then
            maxEjeY = 15
            numberSuffix = ""
            subcaption = "SEGURIDAD"
            decimales = "0"
        ElseIf rbt5s.Checked Then
            maxEjeY = 5
            numberSuffix = ""
            subcaption = "5s"
            decimales = "1"
        ElseIf rbtGente.Checked Then
            maxEjeY = 15
            numberSuffix = ""
            subcaption = "GENTE"
            decimales = "0"
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
        cadenaXML = rutaGrafica + "&dataXML=<graph YAxisMinValue='0' YAxisMaxValue='" & maxEjeY & "' numberSuffix='" & numberSuffix & "' caption='REPORTE DE RESULTADOS' subcaption='" & subcaption & "' YAxisName= '" & ejeY & "' xAxisName='F E C H A (s)' labeldisplay='rotate' decimalPrecision='" & decimales & "' rotateNames='1' formatNumberScale='0' thousandSeparator=',' bgcolor='ffffff' bgalpha='000000' showColumnShadow='1' showAlternateHGridColor='1' AlternateHGridColor='ff5904' divLineColor='ff5904' divLineAlpha='20' alternateHGridAlpha='5' baseFontColor='000000' baseFontSize='10' outCnvBaseFontSze='8' outCnvBaseFontColor='000000'>"

        Condicion_WHERE(cbxTodasLineas.Checked)
        '' O E E -- P R O D U C C I O N --
        If rbtOEE.Checked Then
            Indicador = 1
            If cbxTodasLineas.Checked Then
                establece_fechas_oee_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_OEE_Acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else
                establece_fechas_oee(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_OEE(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If
            valorObj = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObj & "' color='FF0000' displayValue='" & valorObj & "' showOnTop='1'/> </trendlines>"
            ''N R F T I -- C A L I D A D --
        ElseIf rbtNRFTi.Checked Then
            Indicador = 2
            If cbxTodasLineas.Checked Then
                establece_fechas_nrfti_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_NRFTi_Acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else
                establece_fechas_nrfti(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_NRFTi(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If
            valorObj = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObj & "' color='FF0000' displayValue='" & valorObj & "' showOnTop='1'/> </trendlines>"
            '' C O S T O
        ElseIf rbtCosto.Checked Then
            Indicador = 3
            If cbxTodasLineas.Checked Then
                cadenaSELECT = "SELECT DISTINCT DIA_ASIGNADO FROM VISTA_SELECCION_INDICADOR3"
                establece_fechas(cadenaSELECT)
                cadenaSELECT = "SELECT DIA_ASIGNADO, COSTO FROM VISTA_SELECCION_INDICADOR3"
                establece_Costo_Acumulado(cadenaSELECT, colores(2))
            Else
                cadenaSELECT = "SELECT DIA_ASIGNADO, COSTO FROM VISTA_SELECCION_INDICADOR3"
                establece_fechas(cadenaSELECT)
                establece_Costo(cadenaSELECT, colores(2))
            End If
            valorObj = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObj & "' color='FF0000' displayValue='OBJETIVO' showOnTop='1'/> </trendlines>"
            '' S E G U R I D A D
        ElseIf rbtSeg.Checked Then
            Indicador = 4
            If cbxTodasLineas.Checked Then
                establece_fechas_seguridad_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_seguridad_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else ''x linea
                establece_fechas_seguridad(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_seguridad(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If
            valorObjGS = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObjGS & "' color='FF0000' displayValue='" & valorObjGS & "' showOnTop='1'/> </trendlines>"
            ''G E N T E
        ElseIf rbtGente.Checked Then
            Indicador = 5
            If cbxTodasLineas.Checked Then
                establece_fechas_gente_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_gente_acumulado(vIdEquipo, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            Else ''x linea
                establece_fechas_gente(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
                establece_gente(vIdEquipo, cbxLinea.SelectedValue, dtpDesde.Value.ToString("dd-MM-yyyy"), dtpHasta.Value.ToString("dd-MM-yyyy"))
            End If
            valorObjGS = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObjGS & "' color='FF0000' displayValue='" & valorObjGS & "' showOnTop='1'/> </trendlines>"
            '' 5 S
        ElseIf rbt5s.Checked Then
            Indicador = 6
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
            End If
            valorObj = obtener_Objetivo(vIdEquipo, Indicador)
            cadenaXML += "<trendlines> <line startValue='" & valorObj & "' color='FF0000' displayValue='" & valorObj & "' showOnTop='1'/> </trendlines>"
        End If
        cadenaXML += " </graph>"
        swfGrafica.Movie = 1 'hace que el control actualice o se refresque
        swfGrafica.Movie = cadenaXML 'carga la pelicula flash
        cmdImprimir.Enabled = True ''modificado ya que no funciona!!! 31mayo13

    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        copiarCarpeta()
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
            If rbtOEE.Checked Then
                arch.Inserta_datos_grafica("F13", rbtOEE.Text)
            ElseIf rbtNRFTi.Checked Then
                arch.Inserta_datos_grafica("F13", rbtNRFTi.Text)
            ElseIf rbtCosto.Checked Then
                arch.Inserta_datos_grafica("F13", rbtCosto.Text)
            ElseIf rbtSeg.Checked Then
                arch.Inserta_datos_grafica("F13", rbtSeg.Text)
            ElseIf rbtGente.Checked Then
                arch.Inserta_datos_grafica("F13", rbtGente.Text)
            ElseIf rbt5s.Checked Then
                arch.Inserta_datos_grafica("F13", rbt5s.Text)
            End If


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
    Private Sub dtpDesde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDesde.KeyDown
        vFecha_Now_Control = dtpDesde.Value
    End Sub
End Class