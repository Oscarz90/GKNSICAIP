Imports CapaNegocios.SEGURIDAD_USUARIO
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class frmModificacionPermiso
#Region "Objetos Clases"
    Dim oSeguridad_Usuario As CapaNegocios.SEGURIDAD_USUARIO
    Dim oModificacionPermiso As CapaNegocios.Modificacion_Permiso
    Dim omsg_Modificacion_Permiso As msg_ModificacionesPermiso
#End Region
#Region "Variables"
    Dim flgcbxUsuarios As Boolean = False
    Public voperacion As String
#End Region
#Region "Propiedades"
    Public Property operacion() As String
        Get
            Return voperacion
        End Get
        Set(ByVal value As String)
            voperacion = value
        End Set
    End Property
#End Region
#Region "Metodos Iniciales"
    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    'Load
    Private Sub frmModificacionPermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        establece_controles()
        llena_combo_usuarios()
    End Sub
    'Establece controles
    Private Sub establece_controles()
        'Establece calendario solo por dias
        Me.dtpDiaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDiaModificacion.DateTimePickerElement.CustomFormat = "dddd, dd/MMMM/yyyy"
        'Calendario Inicial
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicial.DateTimePickerElement.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm" ' tt"
        'Calendario Final
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFinal.DateTimePickerElement.CustomFormat = "dddd, dd/MMMM/yyyy HH:mm" ' tt"
        If voperacion = "INSERT" Then
            btnRegistrar.Text = "Registrar"
        ElseIf voperacion = "UPDATE" Then
            btnRegistrar.Text = "Actualizar"
        End If

    End Sub
#End Region
#Region "Llenado controles"
    Private Sub llena_combo_usuarios()
        'Filtros
        

        oSeguridad_Usuario = New CapaNegocios.SEGURIDAD_USUARIO
        cbxUsuarios.DataSource = oSeguridad_Usuario.obtener_usuarios_activos
        'CVE_Usuario
        cbxUsuarios.MultiColumnComboBoxElement.Columns("CVE_Usuario").HeaderText = "CVE"
        cbxUsuarios.MultiColumnComboBoxElement.Columns("CVE_Usuario").IsVisible = False
        cbxUsuarios.MultiColumnComboBoxElement.Columns("CVE_Usuario").Name = "CVE"
        'Id_Usuario
        cbxUsuarios.MultiColumnComboBoxElement.Columns("Id_Usuario").HeaderText = "Usuario"
        'Nombre Usuario
        cbxUsuarios.MultiColumnComboBoxElement.Columns("Nombre").HeaderText = "Nombre"

        Me.cbxUsuarios.AutoFilter = True
        Me.cbxUsuarios.DisplayMember = "Id_Usuario"
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.cbxUsuarios.DisplayMember
        filter.Operator = FilterOperator.Contains
        Me.cbxUsuarios.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)

        cbxUsuarios.SelectedIndex = -1

        flgcbxUsuarios = True

    End Sub
#End Region
#Region "Validaciones"
    'Valida todo para la captura
    Private Function valida_captura() As Boolean
        If cbxUsuarios.SelectedIndex <> -1 And valida_fecha_inicio_fin() And valida_traslape_fecha_inicio_fin() Then
            Return True
        Else
            Return False
        End If
    End Function
    'Valida la fecha final e inicial
    Private Function valida_fecha_inicio_fin() As Boolean
        'Valida fecha inicio y fin de captura
        If dtpFechaInicial.Value >= Now.ToString("dd-MM-yyyy HH:mm") And dtpFechaFinal.Value > dtpFechaInicial.Value Then
            Return True
        Else
            Return False
        End If
    End Function
    'Valida que no se traslape la fecha de inicio o fin con otro registro para el mismo usuario
    Private Function valida_traslape_fecha_inicio_fin() As Boolean
        If dtpDiaModificacion.Text <> "" And dtpFechaInicial.Text <> "" And dtpFechaFinal.Text <> "" Then
            obtiene_valores_frmModificacionPermiso()
            Return oModificacionPermiso.valida_registro_modificacion_permiso
        Else
            Return False
        End If
    End Function
#End Region
#Region "Eventos"
    'Evento DatetimePicker Dia_Modificacion,Fecha_Inicial,Fecha_Final
    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDiaModificacion.ValueChanged, dtpFechaInicial.ValueChanged, dtpFechaFinal.ValueChanged
        'Valida boton Registrar
        If flgcbxUsuarios Then
            valida_btn_Registrar()
        End If
    End Sub
    'Evento CBX Usuarios
    Private Sub cbxUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUsuarios.SelectedIndexChanged
        If flgcbxUsuarios Then
            valida_btn_Registrar()
        End If
    End Sub
    'Boton Salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    'Boton Registrar
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If voperacion = "INSERT" Then
            confirmacion_registro()
        ElseIf voperacion = "UPDATE" Then

        End If
    End Sub
#End Region
#Region "Funciones"
    'Asigna valores formulario a objeto de ModificacionPermiso
    Private Sub obtiene_valores_frmModificacionPermiso()
        oModificacionPermiso = New CapaNegocios.Modificacion_Permiso
        oModificacionPermiso.cve_usuario = Long.Parse(String.Format(cbxUsuarios.EditorControl.Rows(cbxUsuarios.SelectedIndex).Cells("CVE").Value))
        oModificacionPermiso.dia_modificacion = dtpDiaModificacion.Value
        oModificacionPermiso.fecha_inicio = dtpFechaInicial.Value
        oModificacionPermiso.fecha_final = dtpFechaFinal.Value
    End Sub
    'Valida Boton Registrar
    Private Sub valida_btn_Registrar()
        If valida_captura() Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
    'Registrar Datos
    Private Sub confirmacion_registro()
        omsg_Modificacion_Permiso = New msg_ModificacionesPermiso
        obtiene_valores_frmModificacionPermiso()
        omsg_Modificacion_Permiso.inicializa_valores(cbxUsuarios.SelectedValue, oModificacionPermiso.dia_modificacion, oModificacionPermiso.fecha_inicio, oModificacionPermiso.fecha_final)
        omsg_Modificacion_Permiso.ShowDialog()
        If omsg_Modificacion_Permiso.vRespuesta Then
            oModificacionPermiso.Registrar()
            Me.Close()
        End If

    End Sub
#End Region
End Class