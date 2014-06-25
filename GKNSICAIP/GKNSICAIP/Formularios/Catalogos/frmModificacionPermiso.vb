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
    Private voperacion As String = "INSERT"
    Private vcve_modificacion_permiso As Long = 0
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
    Public Property cve_modificacion_permiso() As Long
        Get
            Return vcve_modificacion_permiso
        End Get
        Set(ByVal value As Long)
            vcve_modificacion_permiso = value
        End Set
    End Property
#End Region
#Region "Metodos Iniciales"
    'Load
    Private Sub frmModificacionPermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        establece_controles()
        llena_combo_usuarios()
        establece_operacion()
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
        ElseIf voperacion = "UPDATE" And vcve_modificacion_permiso <> 0 Then
            btnRegistrar.Text = "Actualizar"
        End If

    End Sub
    'EStablece la operacion
    Private Sub establece_operacion()
        If voperacion = "UPDATE" And vcve_modificacion_permiso <> 0 Then
            oModificacionPermiso = New CapaNegocios.Modificacion_Permiso
            oModificacionPermiso.cve_modificacion_permiso = vcve_modificacion_permiso
            oModificacionPermiso.Cargar()
            'cbxUsuarios.SelectedItem = oModificacionPermiso.cve_usuario
            cbxUsuarios.SelectedValue = oModificacionPermiso.cve_usuario
            dtpDiaModificacion.Value = oModificacionPermiso.dia_modificacion
            dtpFechaInicial.Value = oModificacionPermiso.fecha_inicio
            dtpFechaFinal.Value = oModificacionPermiso.fecha_final
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
        Me.cbxUsuarios.ValueMember = "CVE_Usuario"
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
        If dtpDiaModificacion.Text <> "" And dtpFechaInicial.Text <> "" And dtpFechaFinal.Text <> "" And cbxUsuarios.SelectedIndex <> -1 Then
            obtiene_valores_frmModificacionPermiso()
            oModificacionPermiso.cve_modificacion_permiso = vcve_modificacion_permiso
            oModificacionPermiso.operacion = voperacion
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
        confirmacion_registro()
    End Sub
#End Region
#Region "Funciones"
    'Asigna valores formulario a objeto de ModificacionPermiso
    Private Sub obtiene_valores_frmModificacionPermiso()
        oModificacionPermiso = New CapaNegocios.Modificacion_Permiso
        oModificacionPermiso.cve_modificacion_permiso = vcve_modificacion_permiso
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
        omsg_Modificacion_Permiso.inicializa_valores(cbxUsuarios.Text, oModificacionPermiso.dia_modificacion, oModificacionPermiso.fecha_inicio, oModificacionPermiso.fecha_final)
        omsg_Modificacion_Permiso.operacion = voperacion
        omsg_Modificacion_Permiso.ShowDialog()
        If omsg_Modificacion_Permiso.vRespuesta And voperacion = "INSERT" Then
            oModificacionPermiso.Registrar()
            Me.Close()
        ElseIf omsg_Modificacion_Permiso.vRespuesta And voperacion = "UPDATE" Then
            oModificacionPermiso.actualizar_registro()
            Me.Close()
        End If

    End Sub
#End Region
End Class