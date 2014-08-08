Imports Telerik.WinControls.Data
Public Class frmRelacionLineaClasificacion
#Region "Objetos Utilizados"
    Private oRelacionLineaClasificacion As CapaNegocios.Relacion_Linea_Clasificacion
    Private oLinea As CapaNegocios.Linea
    Private oLineaClasificacion As CapaNegocios.Linea_Clasificacion
#End Region
#Region "Atributos"
    'Operaciones Constantes No modificar su valor!!
    Private Const vInsertar As Long = 1
    Private vActualizar As Long = 2
    'Operacion 1=Insertar, 2=Actualizar
    Private voperacion = 1
    'LLave primaria para cargar datos del grid para operacion Actualizar
    Private vcve_relacion_linea_clasificacion As Long
    'Banderas
    Private flgcbxlinea As Boolean = False
    Private flgcbxlineaclasificacion As Boolean = False
#End Region
#Region "Propiedades"
    'Propiedades para las operaciones Insertar y Actualizar
    Public ReadOnly Property Actualizar() As Long
        Get
            Return vActualizar
        End Get
    End Property
    Public ReadOnly Property Insertar() As Long
        Get
            Return vInsertar
        End Get
    End Property
    Public Property cve_relacion_linea_clasificacion() As Long
        Get
            Return vcve_relacion_linea_clasificacion
        End Get
        Set(ByVal value As Long)
            vcve_relacion_linea_clasificacion = value
        End Set
    End Property
    Public Property operacion() As Long
        Get
            Return voperacion
        End Get
        Set(ByVal value As Long)
            voperacion = value
        End Set
    End Property
#End Region
#Region "Funciones Iniciales"
    Private Sub frmRelacionLineaClasificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iniciliza_formulario_valores()
    End Sub
    Private Sub iniciliza_formulario_valores()
        'Llena controles combobox
        llena_cbx_lineas()
        llena_cbx_clasificacion_linea()
        'Formato de control de fecha
        Me.dtpFechaClasificacionLinea.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaClasificacionLinea.DateTimePickerElement.CustomFormat = "dddd, dd/MMMM/yyyy"
        'Operacion
        If voperacion = 1 Then 'Insertar
            'cbxEstatus.SelectedIndex = 0
        ElseIf voperacion = 2 Then 'Actualizar
            'Carga datos del registro a actualizar para llenar controles
            oRelacionLineaClasificacion = New CapaNegocios.Relacion_Linea_Clasificacion
            oRelacionLineaClasificacion.cve_relacion_linea_clasificacion = vcve_relacion_linea_clasificacion
            oRelacionLineaClasificacion.Cargar()
            'Cambio Texto mostrado por el boton
            btnRegistrar.Text = "Actualizar"
        End If
    End Sub
#End Region
#Region "Validaciones"
    'Muestra mensajes en error provider
    'Private Sub error_provider_mensajes()
    '    If txtNombre.Text <> "" Then
    '        errorProvClasfLineas.SetError(Me.txtNombre, "")
    '    Else
    '        errorProvClasfLineas.SetError(Me.txtNombre, "Escribe un nombre para la clasificación de Línea")
    '    End If
    '    If txtDescripcion.Text <> "" Then
    '        errorProvClasfLineas.SetError(Me.txtDescripcion, "")
    '    Else
    '        errorProvClasfLineas.SetError(Me.txtDescripcion, "Escribe una descripción para la clasificación de Línea")
    '    End If
    '    If cbxEstatus.SelectedIndex <> -1 Then
    '        errorProvClasfLineas.SetError(Me.cbxEstatus, "")
    '    Else
    '        errorProvClasfLineas.SetError(Me.cbxEstatus, "Selecciona el estatus del registro.")
    '    End If

    '    '//////////////


    '    Dim flgFechaInicioFin As Boolean = False
    '    Dim auxString As String = ""
    '    'Selecciona un usuario
    '    If cbxUsuarios.SelectedIndex <> -1 Then
    '        auxString = String.Format(cbxUsuarios.EditorControl.Rows(cbxUsuarios.SelectedIndex).Cells("Id_Usuario").Value)
    '        If auxString <> cbxUsuarios.Text Then
    '            errorProv.SetError(Me.cbxUsuarios, "Selecciona un usuario")
    '        Else
    '            errorProv.SetError(Me.cbxUsuarios, "")
    '        End If
    '    Else
    '        errorProv.SetError(Me.cbxUsuarios, "Selecciona un usuario.")
    '    End If
    '    'Valida Fecha Inicial y Final
    '    If dtpFechaInicial.Text <> "" And dtpFechaFinal.Text <> "" Then
    '        'Fecha Inicial debe ser menor a Fecha Final
    '        If Not dtpFechaFinal.Value > dtpFechaInicial.Value Then
    '            errorProv.SetError(Me.dtpFechaInicial, "La fecha Inicial debe ser menor a la Fecha Final!.")
    '            errorProv.SetError(Me.dtpFechaFinal, "La fecha Final debe ser mayor a la Fecha Inicial!.")
    '        Else
    '            'Fecha Inicial mayor a fecha actual
    '            If Not dtpFechaInicial.Value >= Now.ToString("dd-MM-yyyy HH:mm") Then
    '                errorProv.SetError(Me.dtpFechaInicial, "La fecha Inicial debe mayor a la Fecha y Hora Actual!.")
    '            Else
    '                errorProv.SetError(Me.dtpFechaInicial, "")
    '                flgFechaInicioFin = True
    '            End If
    '            errorProv.SetError(Me.dtpFechaFinal, "")
    '        End If
    '    Else
    '        If dtpFechaInicial.Text <> "" Then
    '            errorProv.SetError(Me.dtpFechaInicial, "")
    '        Else
    '            errorProv.SetError(Me.dtpFechaInicial, "Selecciona la fecha inicial.")
    '        End If
    '        If dtpFechaFinal.Text <> "" Then
    '            errorProv.SetError(Me.dtpFechaFinal, "")
    '        Else
    '            errorProv.SetError(Me.dtpFechaFinal, "Selecciona la fecha final.")
    '        End If
    '    End If
    '    'Valida traslape
    '    If dtpDiaModificacion.Text <> "" Then
    '        If flgFechaInicioFin = True And cbxUsuarios.SelectedIndex <> -1 Then
    '            If valida_traslape_fecha_inicio_fin() Then
    '                errorProv.SetError(Me.dtpDiaModificacion, "")
    '            Else
    '                errorProv.SetError(Me.dtpDiaModificacion, "La Fecha Inicial y Final se traslapan con un permiso de modificaciones " & vbCr & "existente para el usuario seleccionado. No puede haber traslapes!.")
    '            End If
    '        Else
    '            errorProv.SetError(Me.dtpDiaModificacion, "Llena los demas campos correctamente.")
    '        End If
    '    Else
    '        errorProv.SetError(Me.dtpDiaModificacion, "Selecciona un dia de modificación.")
    '    End If
    '    '/////////////



    'End Sub
#End Region
#Region "Eventos Controles"
    'Boton de Registrar
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

    End Sub
    'Boton Salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region
#Region "Funciones Generales"

#End Region
#Region "Llena Controles"
    'Combo de Lineas
    Private Sub llena_cbx_lineas()
        oLinea = New CapaNegocios.Linea
        cbxLinea.DataSource = oLinea.Obtener_Lineas
        Try
            'cve_linea
            cbxLinea.MultiColumnComboBoxElement.Columns("cve_linea").HeaderText = "CVE"
            cbxLinea.MultiColumnComboBoxElement.Columns("cve_linea").IsVisible = False
            cbxLinea.MultiColumnComboBoxElement.Columns("cve_linea").Name = "CVE"
            'cve_componente
            cbxLinea.MultiColumnComboBoxElement.Columns("cve_componente").IsVisible = False
            'linea
            cbxLinea.MultiColumnComboBoxElement.Columns("linea").HeaderText = "Linea"
            'tpcdm
            cbxLinea.MultiColumnComboBoxElement.Columns("tpcdm").IsVisible = False
            'estatus
            cbxLinea.MultiColumnComboBoxElement.Columns("estatus").IsVisible = False

            'Filtro
            Me.cbxLinea.AutoFilter = True
            Me.cbxLinea.ValueMember = "cve_linea"
            Me.cbxLinea.DisplayMember = "linea"
            Dim filter As New FilterDescriptor()
            filter.PropertyName = Me.cbxLinea.DisplayMember
            filter.Operator = FilterOperator.Contains
            Me.cbxLinea.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
            cbxLinea.SelectedIndex = -1
            flgcbxlinea = True
        Catch
            MsgBox("Surgio un problema al obtener las lineas", vbExclamation + vbOKOnly, "Problema")
            flgcbxlinea = False
        End Try
    End Sub
    'Combo de Tipos de Lineas
    Private Sub llena_cbx_clasificacion_linea()
        oLineaClasificacion = New CapaNegocios.Linea_Clasificacion
        cbxClasificacionLinea.ValueMember = "cve_linea_clasificacion"
        cbxClasificacionLinea.DisplayMember = "nombre"
        cbxClasificacionLinea.DataSource = oLineaClasificacion.obtiene_linea_clasificacion_activos
        cbxClasificacionLinea.SelectedIndex = -1
        flgcbxlineaclasificacion = True
    End Sub
#End Region
End Class