Public Class frmLineaClasificacion
#Region "Objetos Utilizados"
    Private oLineaClasificacion As CapaNegocios.Linea_Clasificacion
#End Region
#Region "Atributos"
    'Operaciones Constantes No modificar su valor!!
    Private Const vInsertar As Long = 1
    Private vActualizar As Long = 2
    'Operacion 1=Insertar, 2=Actualizar
    Private voperacion = 1
    'LLave primaria para cargar datos del grid para operacion Actualizar
    Private vcve_linea_clasificacion As Long
#End Region
#Region "Propiedades"
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
    Public Property cve_linea_clasificacion() As Long
        Get
            Return vcve_linea_clasificacion
        End Get
        Set(ByVal value As Long)
            vcve_linea_clasificacion = value
        End Set
    End Property
    Public Property operacion() As Long
        Get
            Return vOperacion
        End Get
        Set(ByVal value As Long)
            vOperacion = value
        End Set
    End Property
#End Region
#Region "Funciones Iniciales"
    Private Sub frmLineaClasificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa_formulario_valores()
        error_provider_mensajes()
    End Sub
    'Inicializa el formulario
    Private Sub inicializa_formulario_valores()
        If voperacion = 1 Then 'Insertar
            cbxEstatus.SelectedIndex = 0
        ElseIf voperacion = 2 Then 'Actualizar
            'Carga datos del registro a actualizar para llenar controles
            oLineaClasificacion = New CapaNegocios.Linea_Clasificacion
            oLineaClasificacion.cve_line_clasificacion = vcve_linea_clasificacion
            oLineaClasificacion.Cargar()
            txtNombre.Text = oLineaClasificacion.nombre
            If oLineaClasificacion.estatus = "1" Then
                cbxEstatus.SelectedIndex = 0
            ElseIf oLineaClasificacion.estatus = "0" Then
                cbxEstatus.SelectedIndex = 1
            End If
            txtDescripcion.Text = oLineaClasificacion.descripcion
            'Cambio Texto mostrado por el boton
            btnRegistrar.Text = "Actualizar"
        End If
    End Sub
#End Region
#Region "Validaciones"
    'Valida los campos a llenar para habilitar el boton de Registrar
    Private Sub valida_captura()
        error_provider_mensajes()
        If txtNombre.Text <> "" And cbxEstatus.SelectedIndex <> -1 And txtDescripcion.Text <> "" Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
    'Muestra mensajes en error provider
    Private Sub error_provider_mensajes()
        If txtNombre.Text <> "" Then
            errorProvClasfLineas.SetError(Me.txtNombre, "")
        Else
            errorProvClasfLineas.SetError(Me.txtNombre, "Escribe un nombre para la clasificación de Línea")
        End If
        If txtDescripcion.Text <> "" Then
            errorProvClasfLineas.SetError(Me.txtDescripcion, "")
        Else
            errorProvClasfLineas.SetError(Me.txtDescripcion, "Escribe una descripción para la clasificación de Línea")
        End If
        If cbxEstatus.SelectedIndex <> -1 Then
            errorProvClasfLineas.SetError(Me.cbxEstatus, "")
        Else
            errorProvClasfLineas.SetError(Me.cbxEstatus, "Selecciona el estatus del registro.")
        End If

    End Sub
#End Region
#Region "Eventos Controles"
    'Control Text Nombre
    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        valida_captura()
    End Sub
    'Control ComboBox Estatus
    Private Sub cbxEstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxEstatus.SelectedIndexChanged
        valida_captura()
    End Sub
    'Control Text Descripcion
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        valida_captura()
    End Sub
    'Evento Boton Registrar
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim msgoperacion As String
        If voperacion = Insertar Then
            msgoperacion = "crear"
        ElseIf voperacion = Actualizar Then
            msgoperacion = "actualizar"
        Else
            msgoperacion = "crear"
        End If
        If MsgBox("¿Estas seguro que deseas " & msgoperacion & " el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If voperacion = Insertar Then
                registra_clasificacion_linea()
            ElseIf voperacion = Actualizar Then
                actualizar_clasificacion_linea()
            End If
            Me.Close()
        End If
    End Sub
    'Evento Boton Salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region
#Region "Funciones Generales"
    'Inserta en base de datos la clasificacion de linea
    Private Sub registra_clasificacion_linea()
        oLineaClasificacion = New CapaNegocios.Linea_Clasificacion
        oLineaClasificacion.nombre = txtNombre.Text
        oLineaClasificacion.descripcion = txtDescripcion.Text
        'cbxEstatus=0 Activado, Activado=1, cbxEstatus=1 Desactivado, Desactivado=0
        If cbxEstatus.SelectedIndex = 0 Then
            oLineaClasificacion.estatus = "1"
        ElseIf cbxEstatus.SelectedIndex = 1 Then
            oLineaClasificacion.estatus = "0"
        End If
        oLineaClasificacion.Registrar()
    End Sub
    Private Sub actualizar_clasificacion_linea()
        oLineaClasificacion = New CapaNegocios.Linea_Clasificacion
        oLineaClasificacion.cve_line_clasificacion = vcve_linea_clasificacion
        oLineaClasificacion.nombre = txtNombre.Text
        oLineaClasificacion.descripcion = txtDescripcion.Text
        'cbxEstatus=0 Activado, Activado=1, cbxEstatus=1 Desactivado, Desactivado=0
        If cbxEstatus.SelectedIndex = 0 Then
            oLineaClasificacion.estatus = "1"
        ElseIf cbxEstatus.SelectedIndex = 1 Then
            oLineaClasificacion.estatus = "0"
        End If
        oLineaClasificacion.Actualizar()
    End Sub
#End Region   
End Class