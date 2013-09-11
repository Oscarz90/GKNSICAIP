Imports CapaNegocios
Public Class FrmSeleccion_Componentes
    Dim oComponente As Componente
    Dim vCve_User As String = ""
    Dim oUsuario As SEGURIDAD_USUARIO

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmSeleccion_Componentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oComponente = New Componente
        oUsuario = New SEGURIDAD_USUARIO
        oUsuario.CVE_Usuario = oUsuario.Obtener_Id(vCve_User)

        Lista_Datos.DataSource = oComponente.Obtener_Componentes
        Lista_Datos.ValueMember = "cve_componente"
        Lista_Datos.DisplayMember = "componente"

        If oComponente.Obtener_Componente_Usuario(oUsuario.CVE_Usuario) IsNot Nothing Then

        End If
    End Sub








End Class
