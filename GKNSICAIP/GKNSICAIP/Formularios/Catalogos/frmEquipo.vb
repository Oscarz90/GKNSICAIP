﻿Imports CapaNegocios
Public Class frmEquipo

    Public vId_Publico As Long
    Public vId_Retorno As Long
    Dim oEquipo As Equipo
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True
    Dim vValida_Tlatoani As Integer = 0
    Dim vT_Tlatoani As Boolean = True
    Dim vLG As Boolean = True
    Dim vLET As Boolean = True
    Dim vImagen As Boolean = True

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Eventos de controles"
    Private Sub frmEquipo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Convert.ToInt64(vId_Publico) <> 0 Then
            oEquipo = New Equipo() With {.Cve_Equipo = vId_Publico}
            oEquipo.Cargar()
        End If
        Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        SetBindings()
        Me.Show()
        Me.btnImportar.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportar.Click
        'Importar Tipo Tlatoani
        Dim ofrmImportador_TipoTlatoani As New frmImportador_TipoTlatoani
        ofrmImportador_TipoTlatoani.ShowDialog()
        oEquipo.Cve_Detalle = ofrmImportador_TipoTlatoani.vRetorno_CVE_Detalle
        txtTipo_Tlatoani.Text = oEquipo.Nombre_Detalle
        If oEquipo.Cve_Detalle = 0 Then
            vT_Tlatoani = False
        Else
            vT_Tlatoani = True
        End If
        Validar_Datos_Completos(vT_Tlatoani, vLG, vLET, vImagen)
    End Sub

    Private Sub btnImportar_LG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportar_LG.Click
        'Importar Lider
        Dim ofrmImportador_LG As New frmImportador_LG
        ofrmImportador_LG.ShowDialog()
        oEquipo.Cve_Lider = ofrmImportador_LG.vRetorno_CVE_Lider
        txtLG.Text = oEquipo.Nombre_Lider
        If oEquipo.Cve_Lider = 0 Then
            vLG = False
        Else
            vLG = True
        End If
        Validar_Datos_Completos(vT_Tlatoani, vLG, vLET, vImagen)
    End Sub

    Private Sub btnImportar_Imagen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportar_Imagen.Click
        'Cargar una imagen
        If ofdImagen.ShowDialog() = DialogResult.OK Then
            Try
                If Validar_Imagen_Correcta() = True Then
                    vImagen = True
                Else
                    vImagen = False
                End If
                Validar_Datos_Completos(vT_Tlatoani, vLG, vLET, vImagen)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModificar.Click
        If Validar_Datos_Completos(vT_Tlatoani, vLG, vLET, vImagen) = True And Existe_Imagen() = True And txtLet.Text <> "" Then
            If MsgBox("¿Esta seguro de realizar los cambios al equipo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oEquipo.LETT = txtLet.Text
                oEquipo.Imagen = oEquipo.ImageToByteArray(pbImagen.Image)
                Try
                    oEquipo.Registrar()
                    MsgBox("Se modifico correctamente")
                Catch ex As Exception

                End Try
                Me.Close()
            End If
        Else
            MsgBox("Faltan campos por llenar.")
        End If
    End Sub

    Private Sub txtLet_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtLet.KeyUp
        vValida_Tlatoani = txtTipo_Tlatoani.Text.Count
        If vValida_Tlatoani > 0 And txtLet.Text <> "" Then
            btnModificar.Enabled = True
            vLET = True
        Else
            vLET = False
            btnModificar.Enabled = False
        End If
        Validar_Datos_Completos(vT_Tlatoani, vLG, vLET, vImagen)
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
        Me.txtImagen.Text = ""
        Me.pbImagen.Image = oEquipo.ByteArrayToImage(oEquipo.Imagen)
    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
        If vAdd = True Then
            Me.btnModificar.Enabled = True
        Else
            Me.btnModificar.Enabled = False
        End If
    End Sub

    Private Function Validar_Datos_Completos(ByVal vTipo_Tlatoani As Boolean, ByVal vLG As Boolean, ByVal vLET As Boolean, ByVal vImagen As Boolean) As Boolean
        Dim vRetorno As Boolean = False

        

        If vTipo_Tlatoani = True And vLG = True And vLET = True And vImagen = True Then
            vRetorno = True
            If vAdd_Registrar = True Then
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
            End If
        Else
            If vAdd_Registrar = True Then
                btnModificar.Enabled = False
            Else
                btnModificar.Enabled = False
            End If
            vRetorno = False
        End If
        Return vRetorno
    End Function

    Private Function Validar_Imagen_Correcta() As Boolean
        Dim vRetorno As Boolean = False
        'validar formato y tamaño de imagen
        Dim opb As New PictureBox() 'Creamos un objeto pb


        Dim vExtencion As String = Obtener_Extencion_Imagen(ofdImagen.FileName)

        If vExtencion = "jpg" Or vExtencion = "JPG" Or vExtencion = "png" Or vExtencion = "PNG" Then
            opb.Image = Image.FromFile(ofdImagen.FileName) 'Asignamos la imagen
            opb.SizeMode = PictureBoxSizeMode.AutoSize 'Dejamos su propiedad en autosize para tener el tamaño original de la misma

            If opb.Size.Width <> 250 Or opb.Size.Height <> 170 Then
                MsgBox("ERROR, La imagen debe tener un tamaño de de 250px,170px, FAVOR DE SELECCIONAR OTRA IMAGEN", MsgBoxStyle.Exclamation, "")
                vRetorno = False
            Else
                pbImagen.ImageLocation = ofdImagen.FileName
                pbImagen.Refresh()
                txtImagen.Text = ofdImagen.FileName
                vRetorno = True
            End If
        Else
            MsgBox("ERROR formato no valido, el archivo debe tener una extencion valida de imagen como '.jpg' o '.png', por favor verifique")
            vRetorno = False
        End If

        Return vRetorno
    End Function

    Private Function Existe_Imagen() As Boolean
        Dim vRetorno As Boolean = False
        If pbImagen.Image Is Nothing Then
            vRetorno = False
        Else
            vRetorno = True
        End If
        Return vRetorno
    End Function

    Private Function Obtener_Extencion_Imagen(ByVal vNombre_Imagen_Con_Extencion As String) As String
        Dim vRetorno As String = ""
        Dim aText As String() = Split(vNombre_Imagen_Con_Extencion, ".")

        vRetorno = aText(UBound(aText))
        Return vRetorno
    End Function



#End Region

End Class