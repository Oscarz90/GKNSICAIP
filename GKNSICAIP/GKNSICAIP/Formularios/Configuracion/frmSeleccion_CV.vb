﻿Imports CapaNegocios
Public Class FrmSeleccion_CV
    Dim oCV As Cadena_Valor
    Dim vCve_User As String = ""
    Dim oUsuario As SEGURIDAD_USUARIO
    Public oRetorno As New List(Of String)

    Public Sub New(ByVal vCVE_Usuario As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vCve_User = vCVE_Usuario
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmSeleccion_CV_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        oCV = New Cadena_Valor
        Dim vIndex As Integer
        oUsuario = New SEGURIDAD_USUARIO() With {.CVE_Usuario = vCve_User}
        Dim vItems As ListViewItem = Nothing

        For Each vDR As DataRow In oCV.Obtener_Cadenas_Valor.Rows
            vItems = New ListViewItem
            vItems.Text = vDR("cadena")
            vItems.Tag = vDR("cve_cadena_valor")
            Lista_Datos_W.Items.Add(vItems)
        Next

        If oCV.Obtener_CV_Usuario(oUsuario.CVE_Usuario) IsNot Nothing Then
            For vIndex = 0 To Lista_Datos_W.Items.Count - 1
                For Each vdr As DataRow In oCV.Obtener_CV_Usuario(oUsuario.CVE_Usuario).Rows
                    If Lista_Datos_W.Items.Item(vIndex).Tag = vdr("CVE_Cadena_Valor") Then
                        Lista_Datos_W.Items.Item(vIndex).Checked = True
                        Exit For
                    End If
                Next
            Next vIndex
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        Dim vIndice As Integer
        For vIndice = 0 To Lista_Datos_W.Items.Count - 1
            If Lista_Datos_W.Items.Item(vIndice).Checked = True Then
                oRetorno.Add(Lista_Datos_W.Items.Item(vIndice).Tag.ToString)
            End If
        Next vIndice
        Me.Close()
    End Sub
End Class
