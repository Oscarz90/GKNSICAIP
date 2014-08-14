Imports CapaNegocios
Public Class msg_RelacionLineaClasificacion
#Region "Variables"
    Public vRespuesta As Boolean = False
    Private voperacion As Long = 1
    'Operaciones Constantes No modificar su valor!!
    Private Const vInsertar As Long = 1
    Private Const vActualizar As Long = 2
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
    Public Property operacion() As Long
        Get
            Return voperacion
        End Get
        Set(ByVal value As Long)
            voperacion = value
        End Set
    End Property
#End Region
#Region "Inicial"
    Private Sub msg_ModificacionesPermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicializa_etiquetas()
    End Sub
#End Region
#Region "Validaciones"
    'Valida boton aceptar
    Private Sub valida_btn_Aceptar()
        If chkbxAcuerdo.Checked Then
            btnAceptar.Enabled = True
        Else
            btnAceptar.Enabled = False
        End If
    End Sub
#End Region
#Region "Eventos"
    'Evento Checkbox
    Private Sub chkbxAcuerdo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxAcuerdo.CheckedChanged
        valida_btn_Aceptar()
    End Sub
    'Boton Aceptar
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        vRespuesta = True
        Me.Close()
    End Sub
    'Boton Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        vRespuesta = False
        Me.Close()
    End Sub
#End Region
#Region "Funciones"
    'Inicializa valores
    Public Sub inicializa_valores(ByVal linea As String, ByVal fecha_auxiliar As Date, Optional ByVal clasificacion As String = "")
        lblLinea.Text = linea
        lblFechaAuxiliar.Text = fecha_auxiliar.ToString("dddd, dd-MMMM-yyyy")
        lblClasificacion.Text = clasificacion
    End Sub
    'Inicializa etiquetas
    Private Sub inicializa_etiquetas()
        If voperacion = Insertar Then
            lbltitulo.Text = "¿Está seguro que desea crear el registro?"
            txtAdvertencia.Text = "Una vez creado solo se podrá modificar su FECHA FINAL."
        ElseIf voperacion = Actualizar Then
            lbltitulo.Text = "¿Está seguro que desea actualizar el registro?"
            lbldescripcion.Text = "Si actualiza el registro debe asignarle una nueva clasificacion a esta linea."
            lblFecAux.Text = "Fecha Final:"
            lblClasif.Visible = False
            lblClasificacion.Visible = False
            txtAdvertencia.Text = "Una vez modificado ya no se podrá revertir el cambio."
        End If
    End Sub
#End Region


End Class