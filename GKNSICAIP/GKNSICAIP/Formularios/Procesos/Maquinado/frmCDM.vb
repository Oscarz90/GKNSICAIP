﻿Imports CapaNegocios
Public Class frmCDM
#Region "Atributos"

#End Region
#Region "Otros atributos"
    Private contenedor As CDM_Class
    Private bandera_modelo As Boolean = False
    Private bandera_modelo_salida As Boolean = False
    'valores para inicializar el formulario
    Private linea As String
    Private paro_detalle(8, 1) As String
    Private paro_comentarios(9, 0) As String
    Private indice_x As Integer
    Private indice_y As Integer
    Private id_CDM As Integer
    Private tiempo_CDM As Integer
    Private minutosDetParos As Double = 0
    Private minutosdisponibles As Double
    Private min_H_CDM As Double
    Private costo As Double = 0
    Private mejora As Double = 0
    Private bandera_horas_inicio_fin As Boolean = False
    Private bandera_agrega_coment As Boolean = True
#End Region
#Region "Inicializando formulario"
    Public Sub New(ByRef obje As CDM_Class)
        InitializeComponent()
        contenedor = obje
    End Sub
    Private Sub frmCDM_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        bandera_modelo = False
        bandera_modelo_salida = False
        inicializa_form()
    End Sub
    Public Sub inicializa_form()
        txtParoL.Enabled = False
        txtParoM.Enabled = False
        txtParoN.Enabled = False
        txtParoO.Enabled = False
        txtParoQ.Enabled = False
        txtParoT.Enabled = False
        txtParoS.Enabled = False
        txtParoA3.Enabled = False
        txtParoU7.Enabled = False
        cmdParoL.Enabled = False
        cmdParoM.Enabled = False
        cmdParoN.Enabled = False
        cmdParoO.Enabled = False
        cmdParoQ.Enabled = False
        cmdParoT.Enabled = False
        cmdParoS.Enabled = False
        cmdParoA3.Enabled = False
        cmdParoU7.Enabled = False
        GroupBox1.Enabled = False
        dtpInicio.Enabled = False
        dtpFinal.Enabled = False
        cmdAgregaComent.Enabled = False
        txtComents.Enabled = False
        llena_lista_modelos_entrada()
    End Sub
    Public Sub inicializa_valores(ByVal line As String, ByVal turno As String, ByVal min_disp As Integer, ByVal paro_desc As String, ByVal fecha_actual As DateTime)
        paro_descr.Text = paro_desc
        minutosdisponibles = min_disp
        linea = line
        inicializa_Horas_inicio_fin(turno, fecha_actual)
    End Sub
    '<<<<<<< HEAD
    '    Public Sub inicializa_Horas_inicio_fin(ByVal inicio As DateTime, ByVal final As DateTime)
    Public Sub inicializa_Horas_inicio_fin(ByVal turno As Integer, ByVal fecha_actual As DateTime)
        Dim oTurno As New Turno
        oTurno.cve_turno = turno
        'oTurno.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
        oTurno.fecha_registro = fecha_actual
        '=======

        '    Public Sub inicializa_Horas_inicio_fin(ByVal turno As Integer)
        '        Dim oTurno As New Turno() With {.cve_turno = turno, .fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))}
        '        '>>>>>>> GraficasVerifid
        oTurno.valida_inicio_fin()
        If oTurno.bandera_registro = 1 Then
            'oTurno.fecha_registro = Convert.ToDateTime(Now.ToString("dd-MM-yyyy HH:mm"))
            oTurno.fecha_registro = fecha_actual
            oTurno.fecha_inicio_fin()

            Dim ini As DateTime = oTurno.inicio
            Dim fin As DateTime = oTurno.fin

            dtpInicio.MinDate = ini
            dtpInicio.MaxDate = fin
            dtpInicio.Value = ini
            dtpFinal.MinDate = ini
            dtpFinal.MaxDate = fin
            dtpFinal.Value = fin
            dtpInicio.CustomFormat = "HH:mm:ss dd/MM"
            dtpInicio.Format = DateTimePickerFormat.Custom
            dtpFinal.CustomFormat = "HH:mm:ss dd/MM"
            dtpFinal.Format = DateTimePickerFormat.Custom
            bandera_horas_inicio_fin = True
        Else
            cbxModeloinicial.Enabled = False
            cbxModelofinal.Enabled = False
            MsgBox("Error! No debes acceder antes del inicio o final del turno", vbCritical + vbOKOnly, "Error")
            bandera_horas_inicio_fin = False

        End If

    End Sub
#End Region
#Region "LLenado ComboBoxs"
    Private Sub llena_lista_modelos_entrada()
        bandera_modelo = False
        Dim oModelo As New Modelo() With {.cve_linea = linea}
        cbxModeloinicial.ValueMember = "cve_modelo"
        cbxModeloinicial.DisplayMember = "np_gkn"
        cbxModeloinicial.DataSource = oModelo.llena_combo_Modelos_Linea()
        cbxModeloinicial.SelectedIndex = -1
        bandera_modelo = True
    End Sub
    Private Sub llena_lista_modelos_salida(ByVal idModelo As String)

        If cbxModeloinicial.SelectedIndex <> -1 Then
            bandera_modelo_salida = False
            Dim oModelo As New Modelo() With {.cve_linea = linea, .cve_modelo = idModelo}
            cbxModelofinal.ValueMember = "cve_modelo"
            cbxModelofinal.DisplayMember = "np_gkn"
            cbxModelofinal.DataSource = oModelo.llena_combo_Modelos_Linea_Salida()
            cbxModelofinal.SelectedIndex = -1
            bandera_modelo_salida = True
        End If
    End Sub
#End Region
#Region "Validaciones"
    Private Function se_puede_añadir_paro(ByVal min As Integer) As Boolean
        If Convert.ToInt16(txtMinutosTotales.Text) = 0 Then
            Return False
        ElseIf Convert.ToInt16(txtMinutosTotales.Text) <= min Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub valida_sea_numero(ByRef cajaDeTexto As TextBox)
        If cajaDeTexto.Text <> "" And Not IsNumeric(cajaDeTexto.Text) Then
            cajaDeTexto.Text = "0"
        End If
    End Sub
    Private Sub valida_boton_guardar()
        If cbxModeloinicial.SelectedIndex <> -1 And cbxModelofinal.SelectedIndex <> -1 And txtMinutosTotales.Text <> "" Then 'tiempo_CDM <> Nothing Then
            calcula_min_paros()
            If Convert.ToInt16(txtMinutosTotales.Text) <= minutosdisponibles Then
                GroupBox1.Enabled = True
                cmdGuardar.Enabled = True
                cmdGuardar.BackColor = Color.FromArgb(107, 198, 223)
            Else
                cmdGuardar.Enabled = False
                cmdGuardar.BackColor = Color.Transparent
                GroupBox1.Enabled = False
            End If
        Else
            cmdGuardar.Enabled = False
            cmdGuardar.BackColor = Color.Transparent
            GroupBox1.Enabled = False
        End If
        If txtMinutosTotales.Text <> "" Then
            If minutosDetParos > Convert.ToDouble(txtMinutosTotales.Text) Then
                cmdGuardar.Enabled = False
                cmdGuardar.BackColor = Color.Transparent
            End If
        End If
    End Sub
    Private Sub valida_guardar_det_paros()
        If txtMinutosTotales.Text <> "" Or txtMinutosTotales.Text = "0" Then
            calcula_min_paros()
            If minutosDetParos > Convert.ToInt32(txtMinutosTotales.Text) Then
                cmdGuardar.Enabled = False
            Else
                cmdGuardar.Enabled = True
            End If
        End If

    End Sub
#End Region
    Private Sub guardar()
        If se_puede_añadir_paro(minutosdisponibles) Then
            contenedor.set_used()
            If id_CDM = 0 Then
                id_CDM = Nothing
            End If
            contenedor.set_Values(id_CDM, dtpInicio.Value.ToString("dd-MM-yyyy HH:mm"), dtpFinal.Value.ToString("dd-MM-yyyy HH:mm"), Convert.ToInt32(txtMinutosTotales.Text) - minutosDetParos, paro_detalle, paro_comentarios, mejora, costo)
            salir()
        Else
            MsgBox("Los minutos disponibles son insuficientes o esta tratando de insertar un paro con 0 minutos.", vbCritical + vbOKOnly, "Error")
        End If

    End Sub
    Private Sub salir()
        Me.Close()
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSalir.Click
        If cmdGuardar.Enabled <> True Then
            contenedor.set_not_used()
            salir()
        Else
            If MsgBox("¿Deseas Guardar antes de salir?", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
                guardar()
            Else
                contenedor.set_not_used()
                salir()
            End If
        End If

    End Sub
    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click
        guardar()
    End Sub
    Private Sub cbxModeloinicial_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxModeloinicial.SelectedIndexChanged
        If bandera_modelo And cbxModeloinicial.SelectedIndex <> -1 Then
            valida_boton_guardar()
            bandera_modelo_salida = False
            txtModelofinal.Text = ""
            Dim oModelo As New Modelo() With {.cve_modelo = cbxModeloinicial.SelectedValue}
            oModelo.Cargar()

            txtModeloinicial.Text = oModelo.descripcion
            llena_lista_modelos_salida(cbxModeloinicial.SelectedValue)
            If bandera_modelo_salida And cbxModelofinal.SelectedIndex <> -1 Then
                Dim oCDM As New CDM() With {.cve_linea = linea, .cve_modelo_inicial = cbxModeloinicial.SelectedValue, .cve_modelo_final = cbxModelofinal.SelectedValue}
                oCDM.obtiene_tiempo_de_cdm()
                id_CDM = oCDM.cve_CDM
                tiempo_CDM = oCDM.tiempo
                calcula_costo()
                calcula_mejora()
            End If
        End If
        If bandera_modelo And cbxModeloinicial.SelectedIndex <> -1 And bandera_modelo_salida And cbxModelofinal.SelectedIndex <> -1 Then
            dtpInicio.Enabled = True
            dtpFinal.Enabled = True
            GroupBox1.Enabled = True
            calcula_costo()
            calcula_mejora()
        Else
            dtpInicio.Enabled = False
            dtpFinal.Enabled = False
            GroupBox1.Enabled = False

        End If
        valida_boton_guardar()
    End Sub
    Private Sub cbxModelofinal_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxModelofinal.SelectedIndexChanged

        If bandera_modelo_salida And cbxModelofinal.SelectedIndex <> -1 Then
            valida_boton_guardar()
            'sustituye
            Dim oModelo As New Modelo() With {.cve_modelo = cbxModelofinal.SelectedValue}
            oModelo.Cargar()
            txtModelofinal.Text = oModelo.descripcion
            If cbxModelofinal.SelectedIndex <> -1 Then
                Dim oCDM As New CDM() With {.cve_linea = linea, .cve_modelo_inicial = cbxModeloinicial.SelectedValue, .cve_modelo_final = cbxModelofinal.SelectedValue}
                oCDM.obtiene_tiempo_de_cdm()
                id_CDM = oCDM.cve_CDM
                tiempo_CDM = oCDM.tiempo
                calcula_costo()
                calcula_mejora()
                valida_boton_guardar()
            End If

        End If
        If bandera_modelo And cbxModeloinicial.SelectedIndex <> -1 And bandera_modelo_salida And cbxModelofinal.SelectedIndex <> -1 Then
            dtpInicio.Enabled = True
            dtpFinal.Enabled = True
            GroupBox1.Enabled = True
            calcula_costo()
            calcula_mejora()
        Else
            dtpInicio.Enabled = False
            dtpFinal.Enabled = False
            GroupBox1.Enabled = False
        End If
        valida_boton_guardar()
    End Sub
#Region "Valida checkbox Detalles Paros"
    Private Sub valida_chk_paros_detalle(ByRef chk As CheckBox, ByRef txt As TextBox, ByRef btn As Button, ByVal mindice As Integer)
        If chk.Checked = True Then
            btn.Enabled = True
            txt.Enabled = True
            calcula_min_paros()
        Else
            btn.Enabled = False
            txt.Enabled = False
            paro_detalle(mindice, 0) = Nothing
            paro_detalle(mindice, 1) = Nothing
            calcula_min_paros()
        End If
    End Sub
    Private Sub chkA3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkA3.CheckedChanged
        valida_chk_paros_detalle(chkA3, txtParoA3, cmdParoA3, 0)
    End Sub
    Private Sub chkL_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkL.CheckedChanged
        valida_chk_paros_detalle(chkL, txtParoL, cmdParoL, 1)
    End Sub
    Private Sub chkM_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkM.CheckedChanged
        valida_chk_paros_detalle(chkM, txtParoM, cmdParoM, 2)
    End Sub
    Private Sub chkN_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkN.CheckedChanged
        valida_chk_paros_detalle(chkN, txtParoN, cmdParoN, 3)
    End Sub
    Private Sub chkO_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkO.CheckedChanged
        valida_chk_paros_detalle(chkO, txtParoO, cmdParoO, 4)
    End Sub
    Private Sub chkQ_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkQ.CheckedChanged
        valida_chk_paros_detalle(chkQ, txtParoQ, cmdParoQ, 5)
    End Sub
    Private Sub chkS_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkS.CheckedChanged
        valida_chk_paros_detalle(chkS, txtParoS, cmdParoS, 6)
    End Sub
    Private Sub chkT_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkT.CheckedChanged
        valida_chk_paros_detalle(chkT, txtParoT, cmdParoT, 7)
    End Sub
    Private Sub chkU7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkU7.CheckedChanged
        valida_chk_paros_detalle(chkU7, txtParoU7, cmdParoU7, 8)
    End Sub
#End Region
#Region "Valida Minutos Detalles Paros"
    Private Sub valida_txt_paros_detalle(ByRef txtTxtBox As TextBox, ByVal mindice As Integer)
        valida_sea_numero(txtTxtBox)
        valida_minutos_Totales(txtTxtBox)
        If txtTxtBox.Text = "0" Then
            paro_detalle(mindice, 0) = Nothing
            paro_detalle(mindice, 1) = Nothing
        Else
            calcula_min_paros()
            valida_guardar_det_paros()
        End If
    End Sub
    Private Sub txtParoA3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoA3.TextChanged
        valida_txt_paros_detalle(txtParoA3, 0)
    End Sub
    Private Sub txtParoL_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoL.TextChanged
        valida_txt_paros_detalle(txtParoL, 1)
    End Sub
    Private Sub txtParoM_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoM.TextChanged
        valida_txt_paros_detalle(txtParoM, 2)
    End Sub
    Private Sub txtParoN_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoN.TextChanged
        valida_txt_paros_detalle(txtParoN, 3)
    End Sub
    Private Sub txtParoO_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoO.TextChanged
        valida_txt_paros_detalle(txtParoO, 4)
    End Sub
    Private Sub txtParoQ_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoQ.TextChanged
        valida_txt_paros_detalle(txtParoQ, 5)
    End Sub
    Private Sub txtParoS_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoS.TextChanged
        valida_txt_paros_detalle(txtParoS, 6)
    End Sub
    Private Sub txtParoT_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoT.TextChanged
        valida_txt_paros_detalle(txtParoT, 7)
    End Sub
    Private Sub txtParoU7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParoU7.TextChanged
        valida_txt_paros_detalle(txtParoU7, 8)
    End Sub
#End Region
#Region "Modulo de Paros-Comentarios"
    Private Sub valida_guardar_comentario(ByVal x As Integer, ByVal y As Integer)
        If String.Compare(paro_comentarios(indice_x, indice_y), txtComents.Text) = 0 Then
            bandera_agrega_coment = True
            detalle_comentario_paro(x, y)
        Else
            If MsgBox("Se han realizado cambios en el comentario ¿Desea guardar estos cambios?", vbQuestion + vbYesNo, "Confirmación") = vbYes Then
                guardar_comentario()
                cmdAgregaComent.Enabled = True
                detalle_comentario_paro(x, y)
            Else
                bandera_agrega_coment = True
                detalle_comentario_paro(x, y)
            End If
        End If
    End Sub
    Private Sub detalle_comentario_paro(ByVal x As Integer, ByVal y As Integer)
        txtComents.Enabled = True
        If txtComents.Text = "" Then
            bandera_agrega_coment = True
        End If

        If bandera_agrega_coment = False Then
            valida_guardar_comentario(x, y)
        Else
            If paro_comentarios(x, y) <> Nothing Then
                lblAgregarComent.Text = "Guardar"
            Else
                lblAgregarComent.Text = "Agregar"
            End If
            txtComents.Text = ""
            txtComents.Text = paro_comentarios(x, y)
            indice_x = x
            indice_y = y
            cmdAgregaComent.Enabled = True
            bandera_agrega_coment = False
        End If
    End Sub
    Private Sub guardar_comentario()
        paro_comentarios(indice_x, indice_y) = txtComents.Text
        indice_x = Nothing
        indice_y = Nothing
        txtComents.Text = ""
        cmdAgregaComent.Enabled = False
        bandera_agrega_coment = True
    End Sub
#End Region
#Region "Eventos Boton Comentarios Detalle Paros"
    Private Sub cmdCDM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCDM.Click
        detalle_comentario_paro(9, 0)
    End Sub
    Private Sub cmdParoA3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoA3.Click
        detalle_comentario_paro(0, 0)
    End Sub
    Private Sub cmdParoL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoL.Click
        detalle_comentario_paro(1, 0)
    End Sub
    Private Sub cmdParoM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoM.Click
        detalle_comentario_paro(2, 0)
    End Sub
    Private Sub cmdParoN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoN.Click
        detalle_comentario_paro(3, 0)
    End Sub
    Private Sub cmdParoO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoO.Click
        detalle_comentario_paro(4, 0)
    End Sub
    Private Sub cmdParoQ_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoQ.Click
        detalle_comentario_paro(5, 0)
    End Sub
    Private Sub cmdParoS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoS.Click
        detalle_comentario_paro(6, 0)
    End Sub
    Private Sub cmdParoT_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoT.Click
        detalle_comentario_paro(7, 0)
    End Sub
    Private Sub cmdParoU7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdParoU7.Click
        detalle_comentario_paro(8, 0)
    End Sub
#End Region
#Region "Minutos totaldes de Paros de CDM"
    Private Sub total_min_paros(ByRef chk As CheckBox, ByRef txt As TextBox, ByVal code_paro As String, ByVal mindice As Integer)
        If (chk.Checked And txt.Text <> "" And txt.Text <> "0") Then
            paro_detalle(mindice, 0) = code_paro
            paro_detalle(mindice, 1) = txt.Text
            minutosDetParos = minutosDetParos + Convert.ToDouble(txt.Text)
        End If
    End Sub
    Private Sub calcula_min_paros()
        minutosDetParos = 0
        total_min_paros(chkA3, txtParoA3, "A.3", 0)
        total_min_paros(chkL, txtParoL, "L", 1)
        total_min_paros(chkM, txtParoM, "M", 2)
        total_min_paros(chkN, txtParoN, "N", 3)
        total_min_paros(chkO, txtParoO, "O", 4)
        total_min_paros(chkQ, txtParoQ, "Q", 5)
        total_min_paros(chkS, txtParoS, "S", 6)
        total_min_paros(chkT, txtParoT, "T", 7)
        total_min_paros(chkU7, txtParoU7, "U.7", 8)
        Label12.Text = minutosDetParos
        calcula_costo()
        calcula_mejora()
    End Sub
#End Region
#Region "Hora final y inicial y minutos totales"
    Private Sub calcula_minutos_totales()
        txtMinutosTotales.Text = DateDiff(DateInterval.Minute, dtpInicio.Value, dtpFinal.Value)
    End Sub
    Private Sub dtpInicio_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpInicio.ValueChanged
        If bandera_horas_inicio_fin Then
            If dtpInicio.Value > dtpFinal.Value Then
                txtMinutosTotales.Text = "0"
            Else
                calcula_minutos_totales()
            End If
        End If
    End Sub
    Private Sub dtpFinal_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtpFinal.ValueChanged
        If bandera_horas_inicio_fin Then
            If dtpInicio.Value > dtpFinal.Value Then 'Or txtMinutosTotales.Text = "0" Then
                txtMinutosTotales.Text = "0"
            Else
                calcula_minutos_totales()
            End If
        End If
    End Sub
#End Region
    Private Sub txtMinutosTotales_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMinutosTotales.TextChanged
        valida_boton_guardar()
        If minutosDetParos <= Convert.ToDouble(txtMinutosTotales.Text) Then
            calcula_costo()
            calcula_mejora()
        Else
            costo = 0
            mejora = 0
        End If

    End Sub
    Private Sub cmdAgregaComent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAgregaComent.Click
        guardar_comentario()
    End Sub
#Region "Calculo costo-Mejora"
    Private Sub calcula_costo()
        Dim costocomponente As Double
        costo = 0
        If bandera_modelo And bandera_modelo_salida And cbxModeloinicial.SelectedIndex <> -1 And cbxModelofinal.SelectedIndex <> -1 And txtMinutosTotales.Text <> "" And txtMinutosTotales.Text <> "0" Then
            If Convert.ToDouble(txtMinutosTotales.Text) > tiempo_CDM Then
                Dim oComponente As New Componente() With {.cve_linea = linea}
                oComponente.obtiene_precio_componente_linea()
                costocomponente = oComponente.precio
                costo = (Convert.ToDouble(txtMinutosTotales.Text) - tiempo_CDM) * costocomponente
                lblcosto.Text = costo
            Else
                costo = 0
                lblcosto.Text = costo
            End If
        End If
    End Sub
    Private Sub calcula_mejora()
        Dim porcentaje As Double
        If bandera_modelo And bandera_modelo_salida And cbxModeloinicial.SelectedIndex <> -1 And cbxModelofinal.SelectedIndex <> -1 And txtMinutosTotales.Text <> "" And txtMinutosTotales.Text <> "0" Then
            min_H_CDM = Convert.ToDouble(txtMinutosTotales.Text) - minutosDetParos
            porcentaje = (min_H_CDM / tiempo_CDM)
            If porcentaje < 0.9 Then
                mejora = 1 - porcentaje
                lblmejora.Text = mejora
            Else
                mejora = 0
                lblmejora.Text = mejora
            End If
        End If
    End Sub
#End Region
    Private Sub valida_minutos_Totales(ByRef mintxtbox As TextBox)
        If mintxtbox.Text <> "" And txtMinutosTotales.Text <> "" Then
            calcula_min_paros()
            If minutosDetParos > Convert.ToDouble(txtMinutosTotales.Text) Then
                mintxtbox.Text = "0"
            End If
        End If
    End Sub

    
End Class