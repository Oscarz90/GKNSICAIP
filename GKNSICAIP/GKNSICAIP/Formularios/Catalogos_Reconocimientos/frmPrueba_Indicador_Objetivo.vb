Imports Telerik.WinControls.UI
Imports System.Drawing.Color
Imports System
Imports Microsoft

Public Class FrmPrueba_Indicador_Objetivo

    Private Sub FrmPrueba_Indicador_Objetivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vIndice As Integer = 0
        Dim vLado As Integer = 12
        Dim vAltura As Integer = 77

        For vIndice = 0 To 3
            Dim vGrupo_Indicador As New RadGroupBox
            vGrupo_Indicador = GrupoRAD_Indicador("GrupoIndicador1", vLado, vAltura, "Indicador1", 140, 200)
            EtiquetasRAD("Etiqueta_Sup_" & vIndice, 60, 15, "Valores entre:", vGrupo_Indicador)
            NumeradorRAD("nudDesde_" & vIndice, 20, 40, vGrupo_Indicador)
            EtiquetasRAD("Etiqueta_Separador_" & vIndice, 80, 40, "--------", vGrupo_Indicador)
            NumeradorRAD("nudDesde_" & vIndice, 130, 40, vGrupo_Indicador)
            EtiquetasRAD("Etiqueta_Rango_" & vIndice, 15, 75, "Rango:", vGrupo_Indicador)
            TextBoxRAD("txtRango1_" & vIndice, 70, 75, vGrupo_Indicador)
            BtnRAD("btn_" & vIndice, 60, 110, vIndice, vGrupo_Indicador)
            vAltura = vAltura + 150
        Next vIndice

        For vIndice = 0 To 1
            Dim vGrupo_Indicador As New RadGroupBox
            vGrupo_Indicador = GrupoRAD_Indicador("GrupoObjetivos" & vIndice, 400, 77, "Indicador" & vIndice, 140, 350)
            EtiquetasRAD("Etiqueta_Mejora" & vIndice, 5, 21, "Mejora del:", vGrupo_Indicador)
            NumeradorRAD("nudMejora_" & vIndice, 73, 21, vGrupo_Indicador)
            EtiquetasRAD("Etiqueta_Sostenida" & vIndice, 139, 21, "sostenida por:", vGrupo_Indicador)
            NumeradorRAD("nudSostenida_" & vIndice, 222, 21, vGrupo_Indicador)
            EtiquetasRAD("Etiqueta_Meses" & vIndice, 288, 21, "meses.", vGrupo_Indicador)
            'vAltura = vAltura + 150
        Next vIndice


    End Sub

#Region "Generar Grupos"
    'Private Sub CrearIndicador(ByVal lado As Integer, ByVal altura As Integer)
    '    Dim vGrupo_Indicador As New RadGroupBox
    '    vGrupo_Indicador = GrupoRAD_Indicador("GrupoIndicador1", lado, altura, "Indicador1")
    '    EtiquetasRAD("Etiqueta_Sup", 60, 15, "Valores entre:", vGrupo_Indicador)
    '    NumeradorRAD("nudDesde", 20, 40, vGrupo_Indicador)
    '    EtiquetasRAD("Etiqueta_Separador", 80, 40, "--------", vGrupo_Indicador)
    '    NumeradorRAD("nudDesde", 130, 40, vGrupo_Indicador)
    '    EtiquetasRAD("Etiqueta_Rango", 15, 75, "Rango:", vGrupo_Indicador)
    '    TextBoxRAD("txtRango1", 70, 75, vGrupo_Indicador)
    'End Sub
#End Region

    

#Region "Codigo Generar Controles"

    Private Function GrupoRAD_Indicador(ByVal Name As String, ByVal lado As Integer, ByVal altura As Integer, ByVal vText As String, ByVal TamAltura As Integer, ByVal TamAncho As Integer) As RadGroupBox
        Dim oRGroupBox As New RadGroupBox
        oRGroupBox.Name = Name
        oRGroupBox.Height = TamAltura
        oRGroupBox.Width = TamAncho
        oRGroupBox.Top = altura
        oRGroupBox.Left = lado
        oRGroupBox.Text = vText
        Panel1.Controls.Add(oRGroupBox)
        Return oRGroupBox
    End Function

    Private Sub EtiquetasRAD(ByVal Name As String, ByVal lado As Integer, ByVal altura As Integer, ByVal vText As String, ByRef oPanel As RadGroupBox)
        Dim oRLb As New RadLabel
        oRLb.Name = Name
        oRLb.Text = vText
        oRLb.Top = altura
        oRLb.Left = lado
        oPanel.Controls.Add(oRLb)
    End Sub

    Private Sub NumeradorRAD(ByVal Name As String, ByVal lado As Integer, ByVal altura As Integer, ByRef oPanel As RadGroupBox)
        Dim oRSpin As New RadSpinEditor
        oRSpin.Name = Name
        oRSpin.Top = altura
        oRSpin.Left = lado
        oRSpin.Size = New System.Drawing.Size(50, 15)
        oRSpin.Visible = True
        oPanel.Controls.Add(oRSpin)
    End Sub

    Private Sub TextBoxRAD(ByVal Name As String, ByVal lado As Integer, ByVal altura As Integer, ByRef oPanel As RadGroupBox)
        Dim oRTextBox As New RadTextBox
        oRTextBox.Name = Name
        oRTextBox.Top = altura
        oRTextBox.Left = lado
        oRTextBox.Size = New System.Drawing.Size(80, 15)
        oRTextBox.Visible = True
        oPanel.Controls.Add(oRTextBox)
    End Sub

    Private Sub BtnRAD(ByVal Name As String, ByVal lado As Integer, ByVal altura As Integer, ByVal vTag As Integer, ByRef oPanel As RadGroupBox)
        Dim oRBtn As New RadButton
        oRBtn.Name = Name
        oRBtn.Text = "Modificar"
        oRBtn.Top = altura
        oRBtn.Left = lado
        oRBtn.Size = New System.Drawing.Size(80, 25)
        oRBtn.Visible = True
        oPanel.Controls.Add(oRBtn)
    End Sub

#End Region

   

    'Private Sub GrupoWIN(ByVal todo As String, ByVal lado As Integer, ByVal altura As Integer)
    '    Dim nombre As New GroupBox
    '    nombre.Name = todo
    '    nombre.Height = 50
    '    nombre.Width = 200
    '    nombre.Top = altura
    '    nombre.Left = lado
    '    nombre.Visible = True
    '    nombre.Enabled = True
    '    nombre.Text = "Indicador111111111111"
    '    Panel1.Controls.Add(nombre)
    'End Sub



End Class
