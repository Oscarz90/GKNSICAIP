Public Class FrmGraficasfaseuno
    Private Sub FrmGraficasfaseuno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nivel_planta()
    End Sub
#Region "Habilitar Niveles Graficos- Categorias"
    'Lets
    Private Sub nivel_lets()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        rdbtnEquipo.Enabled = False
        chkTodasLineas.Enabled = True
        chkTodosEquipos.Visible = False
    End Sub
    'LG
    Private Sub nivel_lg()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        rdbtnComponente.Enabled = False
        chkTodasLineas.Visible = False
        chkTodosEquipos.Enabled = True
    End Sub
    'Componente
    Private Sub nivel_componente()
        rdbtnPlanta.Enabled = False
        rdbtnCadenaValor.Enabled = False
        chkTodasLineas.Enabled = True
        chkTodosEquipos.Enabled = True
    End Sub
    'Cadena Valor
    Private Sub nivel_cadena_valor()
        rdbtnPlanta.Enabled = False
        chkTodasLineas.Enabled = True
        chkTodosEquipos.Enabled = True
    End Sub
    Private Sub nivel_planta()
        chkTodasLineas.Enabled = True
        chkTodosEquipos.Enabled = True
    End Sub
#End Region
#Region "Eventos RadioButton Niveles"
    Private Sub rdbtnNiveles_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rdbtnCadenaValor.ToggleStateChanged, rdbtnComponente.ToggleStateChanged, rdbtnLinea.ToggleStateChanged, rdbtnEquipo.ToggleStateChanged
        If rdbtnCadenaValor.IsChecked Then
            habilita_combobox_niveles(cbxCadenaValor)
        Else
            deshabilita_combobox_niveles(cbxCadenaValor)
        End If
        If rdbtnComponente.IsChecked Then
            habilita_combobox_niveles(cbxComponente)
        Else
            deshabilita_combobox_niveles(cbxComponente)
        End If
        If rdbtnLinea.IsChecked Then
            habilita_combobox_niveles(cbxLinea)
            habilita_combobox_niveles(cbxEquipo)
            chkTodosEquipos.Visible = True
        Else
            If Not rdbtnEquipo.IsChecked Then
                deshabilita_combobox_niveles(cbxLinea)
                deshabilita_combobox_niveles(cbxEquipo)
                chkTodosEquipos.Visible = False
            End If
            chkTodosEquipos.Visible = False
            
        End If
        If rdbtnEquipo.IsChecked Then
            habilita_combobox_niveles(cbxLinea)
            habilita_combobox_niveles(cbxEquipo)
            chkTodasLineas.Visible = True
        Else
            If Not rdbtnLinea.IsChecked Then
                deshabilita_combobox_niveles(cbxLinea)
                deshabilita_combobox_niveles(cbxEquipo)
                chkTodasLineas.Visible = False
            End If
            chkTodasLineas.Visible = False
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
End Class
