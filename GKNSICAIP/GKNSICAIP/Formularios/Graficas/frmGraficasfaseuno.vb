Public Class FrmGraficasfaseuno
#Region "Variables globales"
    Private nivel_let As Boolean = False
    Private nivel_lgs As Boolean = False
    Private nivel_componentes As Boolean = False
    Private nivel_cadenas_valor As Boolean = False
    Private nivel_planta_gkn As Boolean = False
#End Region
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nivel_lg()
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
        If nivel_let Then

        End If
        Return True
    End Function
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
        nivel_componentes = True
    End Sub
    'Cadena Valor
    Private Sub nivel_cadena_valor()
        rdbtnPlanta.Enabled = False
        nivel_cadenas_valor = True
    End Sub
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
                MsgBox("habilita esta madre")
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
    End Sub
#End Region
#Region "Metodos para graficar"
    Private Sub graficos_gerente()

    End Sub
    Private Sub graficos_scil()

    End Sub
    Private Sub graficos_supervisor_lider()

    End Sub
    Private Sub graficos_lider_grupo()

    End Sub
    Private Sub graficos_lider_equipo_tlatoani()

    End Sub

#End Region
End Class
