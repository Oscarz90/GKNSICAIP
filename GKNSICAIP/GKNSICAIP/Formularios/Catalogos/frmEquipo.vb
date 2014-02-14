Imports CapaNegocios
Public Class frmEquipo
    Public vId_Publico As Long
    Public vId_Retorno As Long
    Dim oEquipo As Equipo
    Dim vAdd_Registrar As Boolean = True
    Dim vDelete_Eliminar As Boolean = True
    Dim vValida_Nombre As Integer = 0

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal vEliminar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vDelete_Eliminar = vEliminar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Convert.ToInt64(vId_Publico) <> 0 Then
            oEquipo = New Equipo
            oEquipo.Cve_Equipo = vId_Publico
            oEquipo.Cargar()
            Controles_Registro_Nuevo(False) ''------hacer codigo
            'vValida_Nombre = oLinea.linea.Count
            'If vValida_Nombre > 0 Then
            '    btnRegistrar.Enabled = True
            '    btnModificar.Enabled = True
            'Else
            '    btnRegistrar.Enabled = False
            '    btnModificar.Enabled = False
            'End If
        Else
            oEquipo = New Equipo
            oEquipo.Equipo = ""
            Controles_Registro_Nuevo(True) ''------hacer codigo
            'If vValida_Nombre > 0 Then
            '    btnRegistrar.Enabled = True
            '    btnModificar.Enabled = True
            'Else
            '    btnRegistrar.Enabled = False
            '    btnModificar.Enabled = False
            'End If
        End If
        vValida_Nombre = oEquipo.Equipo.Count
        If vValida_Nombre > 0 Then
            'btnRegistrar.Enabled = True
            btnModificar.Enabled = True
        Else
            'btnRegistrar.Enabled = False
            btnModificar.Enabled = False
        End If
        'Controles_Permisos(vAdd_Registrar, vDelete_Eliminar)
        SetBindings()
        Me.Show()
        Me.txtEquipo.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ofrmImportador_TipoTlatoani As New frmImportador_TipoTlatoani
        ofrmImportador_TipoTlatoani.ShowDialog()
        ''oEquipo.Cve_Equipo = ofrmImportador_TipoTlatoani.vRetorno_CVE_Equipo
        txtEquipo.Text = oEquipo.Equipo

        'txtComponente.Text = oLinea.Nombre_Componente
    End Sub

    Private Sub btnImportar_LG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_LG.Click

    End Sub

    Private Sub btnImportar_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Imagen.Click

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

    End Sub

    ''---------------
    Private Sub SetBindings()
        Me.txtEquipo.DataBindings.Clear()
        Me.txtTipo_Tlatoani.DataBindings.Clear()
        Me.txtLG.DataBindings.Clear()
        Me.txtLet.DataBindings.Clear()
        'img?

        Me.txtEquipo.DataBindings.Add("Text", oEquipo, "equipo")
        Me.txtTipo_Tlatoani.DataBindings.Add("Text", oEquipo, "Tipo tlatoani")
        'Me.nudTPCM.DataBindings.Add("Value", oEquipo, "tpcdm")
    End Sub

    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            'btnRegistrar.Visible = True
            btnModificar.Visible = False
            'btnDarBaja.Enabled = False
            btnImportar.Enabled = True
            txtEquipo.ReadOnly = False
            'nudTPCM.ReadOnly = False
        Else
            'btnRegistrar.Visible = False
            btnModificar.Visible = True
            'btnDarBaja.Visible = True
            'btnDarBaja.Enabled = True

            btnImportar.Enabled = False
            'txtNombre_Linea.ReadOnly = False
            'nudTPCM.ReadOnly = False

        End If
    End Sub

    'Private Sub Controles_Permisos(ByVal vAdd As Boolean, ByVal vDelete As Boolean)
    '    If vAdd = True Then
    '        'Me.btnRegistrar.Enabled = True
    '        Me.btnModificar.Enabled = True
    '        'Me.btnDarBaja.Enabled = False
    '        'txtNombre_Linea.ReadOnly = False
    '        'nudTPCM.ReadOnly = False
    '    Else
    '        'Me.btnRegistrar.Enabled = False
    '        Me.btnModificar.Enabled = False
    '        'Me.btnDarBaja.Enabled = True
    '        'txtNombre_Linea.ReadOnly = True
    '        'nudTPCM.ReadOnly = True
    '        'btnImportar.Enabled = False
    '    End If
    '    If vDelete = True Then
    '        'Me.btnDarBaja.Enabled = True
    '        'Me.btnRegistrar.Enabled = False
    '        'Me.btnModificar.Enabled = False
    '        'txtNombre_Linea.ReadOnly = True
    '        'nudTPCM.ReadOnly = True
    '        'btnImportar.Enabled = False
    '    Else
    '        'Me.btnDarBaja.Enabled = False
    '        'Me.btnRegistrar.Enabled = True
    '        Me.btnModificar.Enabled = True
    '    End If
    '    If vAdd = False And vDelete = False Then
    '        'txtNombre_Linea.ReadOnly = True
    '        'nudTPCM.ReadOnly = True
    '        'btnImportar.Enabled = False
    '        Me.btnDarBaja.Enabled = False
    '        Me.btnRegistrar.Enabled = False
    '        Me.btnModificar.Enabled = False
    '    End If
    '    If vAdd = True And vDelete = True Then
    '        'txtNombre_Linea.ReadOnly = False
    '        'nudTPCM.ReadOnly = False
    '        'btnImportar.Enabled = False
    '        Me.btnDarBaja.Enabled = True
    '        Me.btnRegistrar.Enabled = True
    '        Me.btnModificar.Enabled = True
    '    End If
    'End Sub
    ''----------------
End Class