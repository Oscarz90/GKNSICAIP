Imports CapaNegocios
Public Class msg_ModificacionesPermiso
#Region "Variables"
    Public vRespuesta As Boolean = False
#End Region
#Region "Objetos"
    Private oModificacionesPermiso As CapaNegocios.Modificacion_Permiso
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
#Region "Funciones"
    Public Sub inicializa_valores(ByVal usuario As String, ByVal dia_modificacion As Date, ByVal f_inicio As Date, ByVal f_fin As Date)
        lblUsuario.Text = usuario
        lblDiaModificacion.Text = dia_modificacion.ToString("dddd, dd-MMMM-yyyy")
        lblFechaInicio.Text = f_inicio.ToString("dddd, dd-MMMM-yyyy HH:mm")
        lblFechaFin.Text = f_fin.ToString("dddd, dd-MMMM-yyyy HH:mm")
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
End Class