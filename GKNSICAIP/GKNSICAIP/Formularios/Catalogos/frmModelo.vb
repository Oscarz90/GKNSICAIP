﻿Imports CapaNegocios
Public Class frmModelo
    Public vId_Publico As Long = 0
    Public vId_Retorno As Long = 0
    Dim oModelo As Modelo
    Dim oClasificacion_Modelo As Clasificacion_Modelo

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''La Siguiente Linea solo es para hacer pruebas sobre un modelo de Prueba(El cual se agrego y se modifico de forma Exitosa)
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 936


        If Convert.ToInt64(vId_Publico) <> 0 Then
            oModelo = New Modelo
            oModelo.cve_modelo = vId_Publico
            oModelo.Cargar()
            LlenaCombos()
            Controles_Registro_Nuevo(False)
        Else
            oModelo = New Modelo
            LlenaCombos()
            Controles_Registro_Nuevo(True)
        End If
        SetBindings()
        If vId_Publico = 0 Then
            cbxClasificacion.SelectedIndex = 0
        End If
        Me.Show()
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub btnDarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarBaja.Click

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios al Modelo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oModelo.descripcion = txtDescripcion.Text
            oModelo.np_gkn = txtNumero_Parte.Text
            oModelo.cve_clasificacion_modelo = cbxClasificacion.SelectedValue
            Try
                oModelo.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("¿Esta seguro de registrar el nuevo Modelo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oModelo.cve_modelo = 0
            oModelo.descripcion = txtDescripcion.Text
            oModelo.np_gkn = txtNumero_Parte.Text
            oModelo.cve_clasificacion_modelo = cbxClasificacion.SelectedValue
            Try
                oModelo.Registrar()
                vId_Retorno = oModelo.cve_modelo
                MsgBox("Se registro correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ofrmImportador_Componente As New frmImportador_Componente
        ofrmImportador_Componente.ShowDialog()
        oModelo.cve_componente = ofrmImportador_Componente.vRetorno_CVE_Componente
        txtComponente.Text = oModelo.Nombre_Componente
    End Sub

    Private Sub SetBindings()
        Me.txtDescripcion.DataBindings.Clear()
        Me.txtNumero_Parte.DataBindings.Clear()
        Me.txtComponente.DataBindings.Clear()
        Me.cbxClasificacion.DataBindings.Clear()

        Me.txtDescripcion.DataBindings.Add("Text", oModelo, "Descripcion")
        Me.txtNumero_Parte.DataBindings.Add("Text", oModelo, "np_gkn")
        Me.txtComponente.DataBindings.Add("Text", oModelo, "Nombre_Componente")
        Me.cbxClasificacion.DataBindings.Add("SelectedValue", oModelo, "cve_clasificacion_modelo")
    End Sub

    Private Sub LlenaCombos()
        oClasificacion_Modelo = New Clasificacion_Modelo
        Me.cbxClasificacion.DisplayMember = "descripcion"
        Me.cbxClasificacion.ValueMember = "cve_clasificacion_modelo"
        Me.cbxClasificacion.DataSource = oClasificacion_Modelo.Obtener_Modelos
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            btnDarBaja.Enabled = False
        Else
            btnRegistrar.Visible = False
            btnModificar.Visible = True
            btnDarBaja.Enabled = True
        End If
    End Sub

End Class