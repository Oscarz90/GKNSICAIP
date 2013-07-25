Imports CapaNegocios
Imports CapaNegocios.Clases_Catalogos


Public Class Formulario_Principal

    Dim vRowSeleccionada As Integer = 0

#Region "Variables Identificador Opciones Menu"
    Dim vLinea As String = ""    
    Dim vMaquina As Boolean = False
    Dim vModelo As Boolean = False
    Dim vTiempo_Ciclo As Boolean = False    
#End Region

#Region "Declaracion de Objetos_Clases_Catalogos"
    Dim oCatalogo_Linea As Catalogo_Linea
    Dim oCatalogo_Maquina As Catalogo_Maquina
    Dim oCatalogo_Modelo As Catalogo_Modelo
    Dim oCatalogo_Tiempo_Ciclo As Catalogo_Tiempo_Ciclo
    Dim oCatalogo_Equipo_Linea As Catalogo_Equipo_Linea
#End Region

#Region "Declaracion de Objetos_Clases_Individiduales"
    Dim oLinea As Linea
    Dim oMaquina As Maquina
    Dim oModelo As Modelo
    Dim oTiempo_Ciclo As TC
    Dim oEquipo_Linea As EquipoLinea
#End Region

#Region "Declaracion de Objetos de Formularios"
    Dim ofrmLinea As frmLinea
    Dim ofrmMaquina As frmMaquina
    Dim ofrmModelo As frmModelo
    Dim ofrmTiempo_Ciclo As frmTiempo_Ciclo
    Dim ofrmEquipo_Linea As frmEquipo_Linea
#End Region


    Private Sub btnLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinea.Click
        oCatalogo_Linea = New Catalogo_Linea
        oLinea = New Linea

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()
        Me.dgvRegistros.Visible = True

        Try
            'Dim bs As New BindingSource(oCatalogo_Linea, "L_Linea")
            Me.dgvRegistros.DataSource = oCatalogo_Linea.Obtener_Lineas
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
        Me.dgvRegistros.Columns("cve_linea").HeaderText = "cve_linea"
        Me.dgvRegistros.Columns("cve_linea").IsVisible = False        

        Me.dgvRegistros.Columns("linea").HeaderText = "Linea"
        Me.dgvRegistros.Columns("linea").Width = 250

        Me.dgvRegistros.Columns("componente").HeaderText = "Nombre Componente"
        Me.dgvRegistros.Columns("componente").Width = 250

        Me.dgvRegistros.Columns("tpcdm").HeaderText = " TPCDM"
        Me.dgvRegistros.Columns("tpcdm").Width = 150

        dgvRegistros.Visible = True
        Activar_Formulario("frmLinea")

    End Sub

    Private Sub btnMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaquina.Click

    End Sub

    Private Sub btnModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelo.Click

    End Sub

    Private Sub btnTiempo_Ciclo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiempo_Ciclo.Click

    End Sub

    Private Sub btnEquipo_Linea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipo_Linea.Click
        ofrmEquipo_Linea = New frmEquipo_Linea
        ofrmEquipo_Linea.ShowDialog()
    End Sub

    Private Sub dgvRegistros_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Index
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Index
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try
    End Sub

    Private Sub dgvRegistros_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseDoubleClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Index
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Index
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try
        ''-----------------------------------------------------------------------------------------------------------------
        If vLinea = True Then
            ofrmLinea = New frmLinea
            Try
                ofrmLinea.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
            Catch ex As Exception
                If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                    ofrmLinea.vId_Publico = 0
                End If
            End Try
            ofrmLinea.Show()
            dgvRegistros.Refresh()
        ElseIf vMaquina = True Then
            'oFrmEmpresa = New frmEmpresa
            'Try
            '    oFrmEmpresa.oEmpresa.CVE_Empresa = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
            'Catch ex As Exception
            '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
            '        oFrmEmpresa.oEmpresa.CVE_Empresa = 0
            '    End If
            'End Try
            'oFrmEmpresa.Show()
            'dgvRegistros.Refresh()

        ElseIf vModelo = True Then
            'oFrmMotivo_Baja = New frmMotivoBaja
            'Try
            '    oFrmMotivo_Baja.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
            'Catch ex As Exception
            '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
            '        oFrmMotivo_Baja.vId_Publico = 0
            '    End If
            'End Try
            'oFrmMotivo_Baja.Show()
            'dgvRegistros.Refresh()

        ElseIf vTiempo_Ciclo = True Then
            'oFrmTipo_Telefono = New frmTipoTelefono
            'Try
            '    oFrmTipo_Telefono.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
            'Catch ex As Exception
            '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
            '        oFrmTipo_Telefono.vId_Publico = 0
            '    End If
            'End Try
            'oFrmTipo_Telefono.Show()
            'dgvRegistros.Refresh()
        End If
        ''-----------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub Activar_Formulario(ByVal vNombre_De_Formulario As String)
        If vNombre_De_Formulario = "frmLinea" Then
            vLinea = True
            '--
            vModelo = False
            vMaquina = False
            vTiempo_Ciclo = False            
        ElseIf vNombre_De_Formulario = "frmModelo" Then
            vModelo = True
            '--
            vLinea = False
            vMaquina = False
            vTiempo_Ciclo = False            
        ElseIf vNombre_De_Formulario = "frmMaquina" Then
            vMaquina = True
            '--
            vLinea = False
            vModelo = False
            vTiempo_Ciclo = False
        ElseIf vNombre_De_Formulario = "frmTiempo_Ciclo" Then
            vTiempo_Ciclo = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
        End If
    End Sub


End Class
