Imports CapaNegocios
Public Class frmMaquina
    Public vId_Publico As Long = 0
    Dim oMaquina As Maquina
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmMaquina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''La Siguiente Linea solo es para hacer pruebas sobre una Maquina()
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 936

        If Convert.ToInt64(vId_Publico) <> 0 Then
            oMaquina = New Maquina
            oMaquina.cve_maquina = vId_Publico
            oMaquina.Cargar()
            Controles_Registro_Nuevo(False)
        Else
            oMaquina = New Maquina            
            Controles_Registro_Nuevo(True)
        End If
        Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        SetBindings()
        Me.Show()
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim vfrmImportador_Linea As New frmImportador_Linea        
        vfrmImportador_Linea.ShowDialog()
        oMaquina.cve_linea = vfrmImportador_Linea.vRetorno_CVE_Linea
        txtLinea.Text = oMaquina.Nombre_Linea
    End Sub

    Private Sub btnDar_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDar_Baja.Click
        If MsgBox("¿Esta seguro de Dar de Baja la Maquina?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Try
                oMaquina.Eliminar()
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("¿Esta seguro de registrar la nueva Maquina?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oMaquina.cve_maquina = 0
            oMaquina.clave_maquina = txtCve_Maquina.Text
            oMaquina.maquina = txtNombre.Text
            Try
                oMaquina.Registrar()
                MsgBox("Se registro correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If MsgBox("¿Esta seguro de realizar los cambios a la Maquina?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oMaquina.clave_maquina = txtCve_Maquina.Text
            oMaquina.maquina = txtNombre.Text            
            Try
                oMaquina.Registrar()
                MsgBox("Se modifico correctamente")
            Catch ex As Exception

            End Try
            Me.Close()
        End If
    End Sub

    Private Sub SetBindings()
        Me.txtCve_Maquina.DataBindings.Clear()
        Me.txtLinea.DataBindings.Clear()
        Me.txtNombre.DataBindings.Clear()      

        Me.txtLinea.DataBindings.Add("Text", oMaquina, "Nombre_Linea")
        Me.txtNombre.DataBindings.Add("Text", oMaquina, "maquina")
        Me.txtCve_Maquina.DataBindings.Add("Text", oMaquina, "clave_maquina")
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            btnRegistrar.Visible = True
            btnModificar.Visible = False
            btnDar_Baja.Enabled = False
        Else
            btnRegistrar.Visible = False
            btnModificar.Visible = True
            btnDar_Baja.Enabled = True
            txtNombre.ReadOnly = False
            txtCve_Maquina.ReadOnly = True
            btnImportar.Enabled = True
        End If
    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnRegistrar.Enabled = True
            Me.btnModificar.Enabled = True
        Else
            Me.btnRegistrar.Enabled = False
            Me.btnModificar.Enabled = False
            txtNombre.ReadOnly = False
            txtCve_Maquina.ReadOnly = True
            btnImportar.Enabled = True
        End If
        If vDelete = True Then
            Me.btnDar_Baja.Enabled = True
            txtNombre.ReadOnly = True
            txtCve_Maquina.ReadOnly = True
            btnImportar.Enabled = False
        Else
            Me.btnDar_Baja.Enabled = False
        End If
        If vAdd = False And vDelete = False Then
            txtNombre.ReadOnly = True
            txtCve_Maquina.ReadOnly = True
            btnImportar.Enabled = False
        End If
        If vAdd = True And vDelete = True Then
            txtNombre.ReadOnly = False
            txtCve_Maquina.ReadOnly = True
            btnImportar.Enabled = True
        End If

    End Sub

End Class