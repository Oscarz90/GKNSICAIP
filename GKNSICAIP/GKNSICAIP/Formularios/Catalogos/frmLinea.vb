﻿Imports CapaNegocios
Public Class frmLinea

    Public vId_Publico As Long
    Public vId_Retorno As Long
    Dim oLinea As Linea
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''La Siguiente Linea solo es para hacer pruebas sobre una Linea de Prueba(El cual se agrego y se modifico de forma Exitosa)
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 80
        Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        If Convert.ToInt64(vId_Publico) <> 0 Then
            oLinea = New Linea
            oLinea.cve_linea = vId_Publico
            oLinea.Cargar()
            Controles_Registro_Nuevo(False)
        Else
            oLinea = New Linea
            Controles_Registro_Nuevo(True)
        End If

        SetBindings()        
        Me.Show()
        Me.txtNombre_Linea.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ofrmImportador_Componente As New frmImportador_Componente
        ofrmImportador_Componente.ShowDialog()
        oLinea.cve_componente = ofrmImportador_Componente.vRetorno_CVE_Componente
        txtComponente.Text = oLinea.Nombre_Componente
    End Sub

    Private Sub btnDarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarBaja.Click
        If MsgBox("¿Esta seguro de Dar de Baja la Linea?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oLinea.Eliminar()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("¿Esta seguro de registrar la nueva Linea?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oLinea.cve_linea = 0
            oLinea.linea = txtNombre_Linea.Text
            oLinea.tpcdm = nudTPCM.Value
            oLinea.Estatus = "1"
            Try
                oLinea.Registrar()
                vId_Retorno = oLinea.cve_linea
                MsgBox("Se registro correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios a la Linea?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oLinea.linea = txtNombre_Linea.Text
            oLinea.tpcdm = nudTPCM.Value            
            Try
                oLinea.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub SetBindings()
        Me.txtNombre_Linea.DataBindings.Clear()
        Me.txtComponente.DataBindings.Clear()        
        Me.nudTPCM.DataBindings.Clear()


        Me.txtNombre_Linea.DataBindings.Add("Text", oLinea, "linea")
        Me.txtComponente.DataBindings.Add("Text", oLinea, "Nombre_Componente")
        Me.nudTPCM.DataBindings.Add("Value", oLinea, "tpcdm")
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            btnDarBaja.Enabled = False
            btnImportar.Enabled = True
        Else
            btnRegistrar.Visible = False
            btnModificar.Visible = True
            btnDarBaja.Enabled = True

            btnImportar.Enabled = False
        End If
    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnRegistrar.Enabled = True
            Me.btnModificar.Enabled = True
            txtNombre_Linea.ReadOnly = False
            nudTPCM.ReadOnly = False
        Else
            Me.btnRegistrar.Enabled = False
            Me.btnModificar.Enabled = False
            txtNombre_Linea.ReadOnly = True
            nudTPCM.ReadOnly = True
            btnImportar.Enabled = False
        End If
        If vDelete = True Then
            Me.btnDarBaja.Enabled = True
            txtNombre_Linea.ReadOnly = True
            nudTPCM.ReadOnly = True
            btnImportar.Enabled = False
        Else
            Me.btnDarBaja.Enabled = False
        End If
        If vAdd = False And vDelete = False Then
            txtNombre_Linea.ReadOnly = True
            nudTPCM.ReadOnly = True
            btnImportar.Enabled = False
        End If
        If vAdd = True And vDelete = True Then
            txtNombre_Linea.ReadOnly = False
            nudTPCM.ReadOnly = False
            btnImportar.Enabled = False
        End If
    End Sub
End Class