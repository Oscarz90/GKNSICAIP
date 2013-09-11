Imports CapaNegocios
Public Class FrmSeleccion_Componentes
    Dim oComponente As Componente
    Dim vCve_User As String = ""
    Dim oUsuario As SEGURIDAD_USUARIO
    Public oRetorno As New List(Of String)

    Public Sub New(ByVal vCVE_Usuario As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vCve_User = vCVE_Usuario
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmSeleccion_Componentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim vIndex As Integer
        oComponente = New Componente
        oUsuario = New SEGURIDAD_USUARIO
        oUsuario.CVE_Usuario = vCve_User
        Dim vItems As ListViewItem = Nothing

        For Each vDR As DataRow In oComponente.Obtener_Componentes.Rows
            vItems = New ListViewItem
            vItems.Text = vDR("componente")
            vItems.Tag = vDR("cve_componente")
            Lista_Datos_W.Items.Add(vItems)
        Next

        'Lista_Datos.DataSource = oComponente.Obtener_Componentes
        'Lista_Datos.ValueMember = "cve_componente"
        'Lista_Datos.DisplayMember = "componente"        

        If oComponente.Obtener_Componente_Usuario(oUsuario.CVE_Usuario) IsNot Nothing Then

            For vIndex = 0 To Lista_Datos_W.Items.Count
                For Each vdr As DataRow In oComponente.Obtener_Componente_Usuario(oUsuario.CVE_Usuario).Rows
                    If Lista_Datos_W.Items.Item(vIndex).Tag = vdr("cve_componente") Then
                        Lista_Datos_W.Items.Item(vIndex).Checked = True
                        Exit For
                    End If
                Next
            Next vIndex
        End If
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim vIndice As Integer
        For vIndice = 0 To Lista_Datos_W.Items.Count - 1
            If Lista_Datos_W.Items.Item(vIndice).Checked = True Then
                oRetorno.Add(Lista_Datos_W.Items.Item(vIndice).Tag.ToString)
            End If
        Next vIndice
        Me.Close()
    End Sub
End Class
