Public Class msg_ModificacionesPermiso
#Region "Variables"
    Public vRespuesta As Boolean = False
    Private voperacion As String
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
#Region "Objetos"

#End Region
#Region "Inicial"
    Private Sub msg_ModificacionesPermiso_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    Private Sub chkbxAcuerdo_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkbxAcuerdo.CheckedChanged
        valida_btn_Aceptar()
    End Sub
    'Boton Aceptar
    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        vRespuesta = True
        Me.Close()
    End Sub
    'Boton Cancelar
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        vRespuesta = False
        Me.Close()
    End Sub
#End Region
#Region "Funciones"
    'Inicializa valores
    Public Sub inicializa_valores(ByVal usuario As String, ByVal dia_modificacion As Date, ByVal f_inicio As Date, ByVal f_fin As Date)
        lblUsuario.Text = usuario
        lblDiaModificacion.Text = dia_modificacion.ToString("dddd, dd-MMMM-yyyy")
        lblFechaInicio.Text = f_inicio.ToString("dddd, dd-MMMM-yyyy HH:mm")
        lblFechaFin.Text = f_fin.ToString("dddd, dd-MMMM-yyyy HH:mm")
    End Sub
    'Inicializa etiquetas
    Private Sub inicializa_etiquetas()
        If voperacion = "INSERT" Then
            lbltitulo.Text = "¿Está seguro que desea crear el registro?"
            txtAdvertencia.Text = "Una vez creado solo se podrá modificar o borrar antes de la FECHA DE INICIO."
        ElseIf voperacion = "UPDATE" Then
            lbltitulo.Text = "¿Está seguro que desea actualizar el registro?"
            txtAdvertencia.Text = "Una vez modificado solo se podrá modificar o borrar antes de la FECHA DE INICIO."
        ElseIf operacion = "DELETE" Then
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbl4.Visible = False
            lbl5.Visible = False
            lbltitulo.Visible = False
            lblUsuario.Visible = False
            lblDiaModificacion.Visible = False
            lblFechaInicio.Visible = False
            lblFechaFin.Visible = False
            lblDelete.Visible = True
            txtAdvertencia.Text = "Una vez borrado el registro no se podrá revertir los cambios."
        End If
    End Sub
#End Region
End Class