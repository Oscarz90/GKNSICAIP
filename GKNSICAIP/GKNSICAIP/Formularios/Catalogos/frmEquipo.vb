Imports CapaNegocios
Public Class frmEquipo

    Public vId_Publico As Long
    Public vId_Retorno As Long
    Dim oEquipo As Equipo
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True
    Dim vValida_Tlatoani As Integer = 0

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Eventos de controles"
    Private Sub frmEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Convert.ToInt64(vId_Publico) <> 0 Then
            oEquipo = New Equipo
            oEquipo.Cve_Equipo = vId_Publico
            oEquipo.Cargar()
        Else

        End If
        Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        SetBindings()
        Me.Show()
        Me.btnImportar.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        'Importar Tipo Tlatoani
        Dim ofrmImportador_TipoTlatoani As New frmImportador_TipoTlatoani
        ofrmImportador_TipoTlatoani.ShowDialog()
        oEquipo.Cve_Detalle = ofrmImportador_TipoTlatoani.vRetorno_CVE_Detalle
        txtTipo_Tlatoani.Text = oEquipo.Nombre_Detalle
    End Sub

    Private Sub btnImportar_LG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_LG.Click
        'Importar Lider
        Dim ofrmImportador_LG As New frmImportador_LG
        ofrmImportador_LG.ShowDialog()
        oEquipo.Cve_Lider = ofrmImportador_LG.vRetorno_CVE_Lider
        txtLG.Text = oEquipo.Nombre_Lider
    End Sub

    Private Sub btnImportar_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Imagen.Click
        'Cargar una imagen
        Try
            ofdImagen.ShowDialog()
            pbImagen.ImageLocation = ofdImagen.FileName
            pbImagen.Refresh()
            'validar tamaño de imagen
            'pbImagen.Image.Width

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If vValida_Tlatoani > 0 Then
            If MsgBox("¿Esta seguro de realizar los cambios al equipo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Dim ofrmImportador_TipoTlatoani As New frmImportador_TipoTlatoani
                Dim ofrmImportador_LG As New frmImportador_LG
                oEquipo.Cve_Detalle = ofrmImportador_TipoTlatoani.vRetorno_CVE_Detalle
                oEquipo.Cve_Lider = ofrmImportador_LG.vRetorno_CVE_Lider
                oEquipo.LETT = txtLet.Text
                oEquipo.Imagen = oEquipo.ImageToByteArray(pbImagen.Image)
                'img?
                Try
                    oEquipo.Registrar()
                    MsgBox("Se modifico correctamente")
                Catch ex As Exception

                End Try
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtTipo_Tlatoani_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipo_Tlatoani.KeyUp
        vValida_Tlatoani = txtTipo_Tlatoani.Text.Count

        If vValida_Tlatoani > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
#End Region

#Region "Metodos"
    Private Sub SetBindings()
        Me.txtCve_Kronos.DataBindings.Clear()
        Me.txtEquipo.DataBindings.Clear()
        Me.txtTipo_Tlatoani.DataBindings.Clear()
        Me.txtLG.DataBindings.Clear()
        Me.txtLet.DataBindings.Clear()
        Me.txtImagen.DataBindings.Clear()
        Me.pbImagen.DataBindings.Clear()

        Me.txtCve_Kronos.DataBindings.Add("Text", oEquipo, "cve_equipo_kronos")
        Me.txtEquipo.DataBindings.Add("Text", oEquipo, "equipo")
        Me.txtTipo_Tlatoani.DataBindings.Add("Text", oEquipo, "Nombre_Detalle")
        Me.txtLG.DataBindings.Add("Text", oEquipo, "Nombre_Lider")
        Me.txtLet.DataBindings.Add("Text", oEquipo, "LETT")
        Me.txtImagen.DataBindings.Add("Text", oEquipo, "Ruta_Imagen")
        Me.pbImagen.Image = oEquipo.ByteArrayToImage(oEquipo.Imagen)


    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnModificar.Enabled = True
        Else
            Me.btnModificar.Enabled = False
        End If

    End Sub
#End Region

End Class