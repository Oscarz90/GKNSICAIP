Imports CapaNegocios
Public Class frmTiempo_Ciclo
    Public vId_Publico As Long = 0
    Dim oTiempo_Ciclo As TC
    Dim oTiempo_Ciclo_A_MODIFICAR As TC

    Private Sub btnImportar_Modelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Modelo.Click
        Dim vfrmImportador_Modelo As New frmImportador_Modelo
        vfrmImportador_Modelo.ShowDialog()
        oTiempo_Ciclo.cve_modelo = vfrmImportador_Modelo.vRetorno_CVE_Modelo
        txtModelo.Text = oTiempo_Ciclo.Nombre_Modelo
    End Sub

    Private Sub frmTiempo_Ciclo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''La Siguiente Linea solo es para hacer pruebas sobre un Tiempo_Ciclo()
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 936

        If Convert.ToInt64(vId_Publico) <> 0 Then
            oTiempo_Ciclo = New TC
            oTiempo_Ciclo_A_MODIFICAR = New TC

            oTiempo_Ciclo.cve_TC = vId_Publico
            oTiempo_Ciclo_A_MODIFICAR.cve_TC = vId_Publico

            oTiempo_Ciclo.Cargar()
            oTiempo_Ciclo_A_MODIFICAR.Cargar()

            Controles_Registro_Nuevo(False)
        Else
            oTiempo_Ciclo = New TC
            oTiempo_Ciclo.Estatus = "ACTIVO"
            Controles_Registro_Nuevo(True)
        End If
        SetBindings()        
        Me.Show()
        Me.nudPiezas_Hora.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios al Tiempo Ciclo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oTiempo_Ciclo.cve_TC = 0
            oTiempo_Ciclo.Estatus = "ACTIVO"
            oTiempo_Ciclo.piezas_por_hora = nudPiezas_Hora.Value

            oTiempo_Ciclo_A_MODIFICAR.Estatus = "INACTIVO"
            Try
                oTiempo_Ciclo.Registrar()
                oTiempo_Ciclo_A_MODIFICAR.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("¿Esta seguro de registrar el nuevo Tiempo Ciclo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oTiempo_Ciclo.cve_TC = 0
            oTiempo_Ciclo.piezas_por_hora = nudPiezas_Hora.Value
            oTiempo_Ciclo.Estatus = "ACTIVO"
            Try
                oTiempo_Ciclo.Registrar()                
                MsgBox("Se registro correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub SetBindings()
        Me.nudPiezas_Hora.DataBindings.Clear()
        Me.txtLinea.DataBindings.Clear()
        Me.txtModelo.DataBindings.Clear()
        Me.txtEmpleado.DataBindings.Clear()
        Me.dtpFecha.DataBindings.Clear()
        Me.txtEstatus.DataBindings.Clear()

        Me.nudPiezas_Hora.DataBindings.Add("Value", oTiempo_Ciclo, "piezas_por_hora")
        Me.txtLinea.DataBindings.Add("Text", oTiempo_Ciclo, "Nombre_Linea")
        Me.txtModelo.DataBindings.Add("Text", oTiempo_Ciclo, "Nombre_Modelo")
        Me.txtEmpleado.DataBindings.Add("Text", oTiempo_Ciclo, "Codigo_Empleado")
        Me.dtpFecha.DataBindings.Add("Value", oTiempo_Ciclo, "fecha")
        Me.txtEstatus.DataBindings.Add("Text", oTiempo_Ciclo, "Estatus")
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            'btnDarBaja.Enabled = False
        Else
            btnRegistrar.Visible = False
            btnModificar.Visible = True
            'btnDarBaja.Enabled = True
        End If
    End Sub

    Private Sub btnImportar_Linea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Linea.Click
        Dim vfrmImportador_Linea As New frmImportador_Linea
        vfrmImportador_Linea.ShowDialog()
        oTiempo_Ciclo.cve_linea = vfrmImportador_Linea.vRetorno_CVE_Linea
        txtLinea.Text = oTiempo_Ciclo.Nombre_Linea
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click

    End Sub
End Class