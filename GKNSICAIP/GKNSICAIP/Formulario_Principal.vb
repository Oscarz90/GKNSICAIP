Imports CapaNegocios
Imports CapaNegocios.Clases_Catalogos


Public Class Formulario_Principal

    Dim vRowSeleccionada As Integer = 0    

#Region "Variables Identificador Opciones Menu"
    Dim vLinea As String = ""    
    Dim vMaquina As Boolean = False
    Dim vModelo As Boolean = False
    Dim vTiempo_Ciclo As Boolean = False
    Dim vUsuario As Boolean = False '---------------
    Dim vTipo_Usuario As Boolean = False '-----------
    Dim vPermisos As Boolean = False '--------------
#End Region

#Region "Declaracion de Objetos_Clases_Catalogos"
    Dim oCatalogo_Linea As Catalogo_Linea
    Dim oCatalogo_Maquina As Catalogo_Maquina
    Dim oCatalogo_Modelo As Catalogo_Modelo
    Dim oCatalogo_Tiempo_Ciclo As Catalogo_Tiempo_Ciclo
    Dim oCatalogo_Tipo_Usuario As Catalogo_Tipo_Usuario '--------
    Dim oCatalogo_Usuario As Catalogo_Usuario '--------
#End Region

#Region "Declaracion de Objetos_Clases_Individiduales"
    Dim oLinea As Linea
    Dim oMaquina As Maquina
    Dim oModelo As Modelo
    Dim oTiempo_Ciclo As TC
    Dim oEquipo_Linea As EquipoLinea
    Dim oUsuario As SEGURIDAD_USUARIO
    Dim oTipo_Usuario As Tipo_Usuario
#End Region

#Region "Declaracion de Objetos de Formularios"
    Dim ofrmLinea As frmLinea
    Dim ofrmMaquina As frmMaquina
    Dim ofrmModelo As frmModelo
    Dim ofrmTiempo_Ciclo As frmTiempo_Ciclo
    Dim ofrmEquipo_Linea As frmEquipo_Linea
    Dim ofrmUsuario As FrmUsuarios
    Dim ofrmTipo_Usuario As FrmTipo_Usuario
    Dim ofrmPermisos As FrmPermisos
#End Region

#Region "Opciones de Menu"
    Private Sub btnLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinea.Click
        oCatalogo_Linea = New Catalogo_Linea
        oLinea = New Linea

        MapaUbicacion.Text = "Catalogo Linea"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()
        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True
        Me.btnEliminar.VisibleInStrip = False
        Try
            'Dim bs As New BindingSource(oCatalogo_Linea, "L_Linea")
            Me.dgvRegistros.DataSource = oCatalogo_Linea.Obtener_Lineas
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("cve_linea").HeaderText = "cve_linea"
        Me.dgvRegistros.Columns("cve_linea").IsVisible = False
        Me.dgvRegistros.Columns("cve_linea").Name = "CVE"

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
        oCatalogo_Maquina = New Catalogo_Maquina
        oMaquina = New Maquina

        MapaUbicacion.Text = "Catalogo Maquina"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()

        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True
        Me.btnEliminar.VisibleInStrip = False
        Try
            Me.dgvRegistros.DataSource = oCatalogo_Maquina.Obtener_Maquinas
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("cve_maquina").HeaderText = "cve_maquina"
        Me.dgvRegistros.Columns("cve_maquina").IsVisible = False
        Me.dgvRegistros.Columns("cve_maquina").Name = "CVE"

        Me.dgvRegistros.Columns("clave_maquina").HeaderText = "clave_maquina"
        Me.dgvRegistros.Columns("clave_maquina").Width = 150

        Me.dgvRegistros.Columns("maquina").HeaderText = "Nombre Maquina"
        Me.dgvRegistros.Columns("maquina").Width = 250

        Me.dgvRegistros.Columns("linea").HeaderText = " Linea"
        Me.dgvRegistros.Columns("linea").Width = 250

        dgvRegistros.Visible = True
        Activar_Formulario("frmMaquina")
    End Sub

    Private Sub btnModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelo.Click
        oCatalogo_Modelo = New Catalogo_Modelo
        oModelo = New Modelo

        MapaUbicacion.Text = "Catalogo Modelo"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()

        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True
        Me.btnEliminar.VisibleInStrip = False
        Try
            Me.dgvRegistros.DataSource = oCatalogo_Modelo.Obtener_Modelos
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("cve_modelo").HeaderText = "cve_modelo"
        Me.dgvRegistros.Columns("cve_modelo").IsVisible = False
        Me.dgvRegistros.Columns("cve_modelo").Name = "CVE"

        Me.dgvRegistros.Columns("Modelo").HeaderText = "Modelo"
        Me.dgvRegistros.Columns("Modelo").Width = 250

        Me.dgvRegistros.Columns("np_gkn").HeaderText = "NP GKN"
        Me.dgvRegistros.Columns("np_gkn").Width = 250

        Me.dgvRegistros.Columns("componente").HeaderText = " componente"
        Me.dgvRegistros.Columns("componente").Width = 250

        Me.dgvRegistros.Columns("Clasificacion_Modelo").HeaderText = " Clasificacion Modelo"
        Me.dgvRegistros.Columns("Clasificacion_Modelo").Width = 250

        dgvRegistros.Visible = True
        Activar_Formulario("frmModelo")
    End Sub

    Private Sub btnTiempo_Ciclo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiempo_Ciclo.Click
        oCatalogo_Tiempo_Ciclo = New Catalogo_Tiempo_Ciclo
        oTiempo_Ciclo = New TC

        MapaUbicacion.Text = "Catalogo Tiempo Ciclo"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()

        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True        
        Me.btnEliminar.VisibleInStrip = False
        Try
            Me.dgvRegistros.DataSource = oCatalogo_Tiempo_Ciclo.L_TC

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("cve_TC").HeaderText = "cve_TC"
        Me.dgvRegistros.Columns("cve_TC").IsVisible = False
        Me.dgvRegistros.Columns("cve_TC").Name = "CVE"

        Me.dgvRegistros.Columns("fecha").HeaderText = "fecha"
        Me.dgvRegistros.Columns("fecha").IsVisible = False

        Me.dgvRegistros.Columns("Codigo_Empleado").HeaderText = "Codigo_Empleado"
        Me.dgvRegistros.Columns("Codigo_Empleado").IsVisible = False

        Me.dgvRegistros.Columns("Nombre_Linea").HeaderText = "Nombre_Linea"
        Me.dgvRegistros.Columns("Nombre_Linea").Width = 250

        Me.dgvRegistros.Columns("Nombre_Modelo").HeaderText = "Nombre_Modelo"
        Me.dgvRegistros.Columns("Nombre_Modelo").Width = 250

        Me.dgvRegistros.Columns("piezas_por_hora").HeaderText = "Piezas X Hora"
        Me.dgvRegistros.Columns("piezas_por_hora").Width = 250

        Me.dgvRegistros.Columns("cve_linea").HeaderText = "cve_linea"
        Me.dgvRegistros.Columns("cve_linea").IsVisible = False        

        Me.dgvRegistros.Columns("cve_modelo").HeaderText = " cve_modelo"
        Me.dgvRegistros.Columns("cve_modelo").IsVisible = False

        Me.dgvRegistros.Columns("estatus").HeaderText = "estatus"
        Me.dgvRegistros.Columns("estatus").Width = 250

        dgvRegistros.Visible = True
        Activar_Formulario("frmTiempo_Ciclo")
    End Sub

    Private Sub btnEquipo_Linea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipo_Linea.Click
        Me.dgvRegistros.Visible = False
        Me.Barra_Tool_Registros.Visible = False

        MapaUbicacion.Text = "Catalogo Equipo_Linea"

        ofrmEquipo_Linea = New frmEquipo_Linea
        ofrmEquipo_Linea.ShowDialog()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        oCatalogo_Usuario = New Catalogo_Usuario
        oUsuario = New SEGURIDAD_USUARIO

        MapaUbicacion.Text = "Catalogo Usuario"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()

        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True
        Me.btnEliminar.VisibleInStrip = True
        Try
            Me.dgvRegistros.DataSource = oCatalogo_Usuario.L_Usuario
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("CVE_Usuario").HeaderText = "CVE_Usuario"
        Me.dgvRegistros.Columns("CVE_Usuario").IsVisible = False
        Me.dgvRegistros.Columns("CVE_Usuario").Name = "CVE"

        Me.dgvRegistros.Columns("Id_Usuario").HeaderText = "Usuario"
        Me.dgvRegistros.Columns("Id_Usuario").Width = 250

        Me.dgvRegistros.Columns("Pass").HeaderText = "Pass"
        Me.dgvRegistros.Columns("Pass").IsVisible = False

        Me.dgvRegistros.Columns("Nombre").HeaderText = "Nombre"
        Me.dgvRegistros.Columns("Nombre").Width = 250

        Me.dgvRegistros.Columns("Email").HeaderText = "Email"
        Me.dgvRegistros.Columns("Email").Width = 250

        Me.dgvRegistros.Columns("Estatus").HeaderText = "Estatus"
        Me.dgvRegistros.Columns("Estatus").Width = 250

        Me.dgvRegistros.Columns("CVE_TIPO_USUARIO").HeaderText = "CVE_TIPO_USUARIO"
        Me.dgvRegistros.Columns("CVE_TIPO_USUARIO").IsVisible = False

        Me.dgvRegistros.Columns("Descripcion_Tipo_Usuario").HeaderText = "Tipo de Usuario"
        Me.dgvRegistros.Columns("Descripcion_Tipo_Usuario").Width = 250

        Me.dgvRegistros.Columns("L_USUARIO_PERMISOS").HeaderText = "L_USUARIO_PERMISOS"
        Me.dgvRegistros.Columns("L_USUARIO_PERMISOS").IsVisible = False

        dgvRegistros.Visible = True
        Activar_Formulario("frmUsuario")
    End Sub

    Private Sub btnTipoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoUsuario.Click
        oCatalogo_Tipo_Usuario = New Catalogo_Tipo_Usuario
        oTipo_Usuario = New Tipo_Usuario

        MapaUbicacion.Text = "Catalogo Tipo de Usuario"

        Me.dgvRegistros.DataSource = Nothing
        Me.dgvRegistros.Columns.Clear()

        Me.dgvRegistros.Visible = True
        Me.Barra_Tool_Registros.Visible = True
        Me.btnEliminar.VisibleInStrip = True
        Try
            Me.dgvRegistros.DataSource = oCatalogo_Tipo_Usuario.L_Tipo_Usuario
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dgvRegistros.Columns("CVE_Tipo_Usuario").HeaderText = "CVE_Tipo_Usuario"
        Me.dgvRegistros.Columns("CVE_Tipo_Usuario").IsVisible = False
        Me.dgvRegistros.Columns("CVE_Tipo_Usuario").Name = "CVE"

        Me.dgvRegistros.Columns("Nombre_Tipo_Usuario").HeaderText = "Tipo de Usuario"
        Me.dgvRegistros.Columns("Nombre_Tipo_Usuario").Width = 250

        dgvRegistros.Visible = True
        Activar_Formulario("FrmTipo_Usuario")        
    End Sub

    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click
        Me.dgvRegistros.Visible = False
        Me.Barra_Tool_Registros.Visible = False

        MapaUbicacion.Text = "Catalogo Permisos"

        ofrmPermisos = New FrmPermisos
        ofrmPermisos.ShowDialog()
    End Sub
#End Region

#Region "Opciones de Registros"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If vLinea = True Then
            ofrmLinea = New frmLinea
            ofrmLinea.vId_Publico = 0
            ofrmLinea.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnLinea.PerformClick()
        ElseIf vMaquina = True Then
            ofrmMaquina = New frmMaquina
            ofrmMaquina.vId_Publico = 0
            ofrmMaquina.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnMaquina.PerformClick()
        ElseIf vModelo = True Then
            ofrmModelo = New frmModelo
            ofrmModelo.vId_Publico = 0
            ofrmModelo.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnModelo.PerformClick()
        ElseIf vTiempo_Ciclo = True Then
            ofrmTiempo_Ciclo = New frmTiempo_Ciclo
            ofrmTiempo_Ciclo.vId_Publico = 0
            ofrmTiempo_Ciclo.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnTiempo_Ciclo.PerformClick()
        ElseIf vUsuario = True Then
            ofrmUsuario = New FrmUsuarios
            ofrmUsuario.vId_Publico = 0
            ofrmUsuario.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnUsuario.PerformClick()
        ElseIf vTipo_Usuario = True Then
            ofrmTipo_Usuario = New FrmTipo_Usuario
            ofrmTipo_Usuario.vId_Publico = 0
            ofrmTipo_Usuario.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnTipoUsuario.PerformClick()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If vLinea = True Then
            ofrmLinea = New frmLinea
            ofrmLinea.vId_Publico = vRowSeleccionada
            ofrmLinea.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnLinea.PerformClick()
        ElseIf vMaquina = True Then
            ofrmMaquina = New frmMaquina
            ofrmMaquina.vId_Publico = vRowSeleccionada
            ofrmMaquina.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnMaquina.PerformClick()
        ElseIf vModelo = True Then
            ofrmModelo = New frmModelo
            ofrmModelo.vId_Publico = vRowSeleccionada
            ofrmModelo.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnModelo.PerformClick()
        ElseIf vTiempo_Ciclo = True Then
            ofrmTiempo_Ciclo = New frmTiempo_Ciclo
            ofrmTiempo_Ciclo.vId_Publico = vRowSeleccionada
            ofrmTiempo_Ciclo.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnTiempo_Ciclo.PerformClick()
        ElseIf vUsuario = True Then
            ofrmUsuario = New FrmUsuarios
            ofrmUsuario.vId_Publico = vRowSeleccionada
            ofrmUsuario.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnUsuario.PerformClick()
        ElseIf vTipo_Usuario = True Then
            ofrmTipo_Usuario = New FrmTipo_Usuario
            ofrmTipo_Usuario.vId_Publico = vRowSeleccionada
            ofrmTipo_Usuario.ShowDialog()
            ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
            btnTipoUsuario.PerformClick()
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If vLinea = True Then
            If MsgBox("¿Esta seguro de Dar de Baja la Linea?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oLinea = New Linea
                Try
                    oLinea.cve_linea = vRowSeleccionada
                    oLinea.Eliminar()
                    btnLinea.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                Catch ex As Exception

                End Try
            End If
        ElseIf vMaquina = True Then
            If MsgBox("¿Esta seguro de Dar de Baja la Maquina?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oMaquina = New Maquina
                Try
                    oMaquina.cve_maquina = vRowSeleccionada
                    oMaquina.Eliminar()
                    btnMaquina.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                Catch ex As Exception

                End Try
            End If
        ElseIf vModelo = True Then
            If MsgBox("¿Esta seguro de Dar de Baja el Modelo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oModelo = New Modelo
                Try
                    oModelo.cve_modelo = vRowSeleccionada
                    oModelo.Eliminar()
                    btnModelo.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                Catch ex As Exception

                End Try
            End If
        ElseIf vTiempo_Ciclo = True Then
            'oLinea = New Linea
            'oLinea.cve_linea = vRowSeleccionada
            'oLinea.Eliminar()
            'btnLinea.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
        ElseIf vUsuario = True Then
            If MsgBox("¿Esta seguro de Dar de Baja al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oUsuario = New SEGURIDAD_USUARIO
                Try
                    oUsuario.CVE_Usuario = vRowSeleccionada
                    oUsuario.Eliminar()
                    btnUsuario.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                Catch ex As Exception

                End Try
            End If
        ElseIf vTipo_Usuario = True Then
            If MsgBox("¿Esta seguro de Eliminar el Tipo de Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                oTipo_Usuario = New Tipo_Usuario
                Try
                    oTipo_Usuario.CVE_Tipo_Usuario = vRowSeleccionada
                    oTipo_Usuario.Eliminar()
                    btnTipoUsuario.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                Catch ex As Exception

                End Try
            End If           
        End If
    End Sub
#End Region
    

    Private Sub dgvRegistros_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseDown
        'Try
        '    If e.Button = Windows.Forms.MouseButtons.Right Then
        '        vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
        '    ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
        '        vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
        '    End If
        'Catch ex As Exception
        '    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
        '        vRowSeleccionada = 0
        '    End If
        'End Try
    End Sub

    Private Sub dgvRegistros_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseDoubleClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                'vRowSeleccionada = dgvRegistros.CurrentRow.Index
                'vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
                vRowSeleccionada = 0
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                'If Windows.Forms.Cursor.Position.X <> 0 Then
                'End If
                'vRowSeleccionada = dgvRegistros.CurrentRow.Index
                vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try
        ''-----------------------------------------------------------------------------------------------------------------
        If vRowSeleccionada <> 0 Then
            If vLinea = True Then
                ofrmLinea = New frmLinea
                Try
                    'ofrmLinea.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmLinea.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmLinea.vId_Publico = 0
                    End If
                End Try
                ofrmLinea.ShowDialog()
                btnLinea.PerformClick()
            ElseIf vMaquina = True Then
                ofrmMaquina = New frmMaquina
                Try
                    'ofrmMaquina.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmMaquina.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmMaquina.vId_Publico = 0
                    End If
                End Try
                ofrmMaquina.ShowDialog()
                btnMaquina.PerformClick()
            ElseIf vModelo = True Then
                ofrmModelo = New frmModelo
                Try
                    'ofrmModelo.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmModelo.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmModelo.vId_Publico = 0
                    End If
                End Try
                ofrmModelo.ShowDialog()
                btnModelo.PerformClick()
            ElseIf vTiempo_Ciclo = True Then
                ofrmTiempo_Ciclo = New frmTiempo_Ciclo
                Try
                    'ofrmTiempo_Ciclo.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmTiempo_Ciclo.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmTiempo_Ciclo.vId_Publico = 0
                    End If
                End Try
                ofrmTiempo_Ciclo.ShowDialog()
                btnTiempo_Ciclo.PerformClick()                
            ElseIf vUsuario = True Then
                ofrmUsuario = New FrmUsuarios
                Try
                    'ofrmTiempo_Ciclo.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmUsuario.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmUsuario.vId_Publico = 0
                    End If
                End Try
                ofrmUsuario.ShowDialog()
                btnUsuario.PerformClick()
            ElseIf vTipo_Usuario = True Then
                ofrmTipo_Usuario = New FrmTipo_Usuario
                Try
                    'ofrmTiempo_Ciclo.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                    ofrmTipo_Usuario.vId_Publico = vRowSeleccionada
                Catch ex As Exception
                    If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                        ofrmTipo_Usuario.vId_Publico = 0
                    End If
                End Try
                ofrmTipo_Usuario.ShowDialog()
                btnTipoUsuario.PerformClick()
            End If
        Else

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
            vUsuario = False
            vTipo_Usuario = False
        ElseIf vNombre_De_Formulario = "frmModelo" Then
            vModelo = True
            '--
            vLinea = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
        ElseIf vNombre_De_Formulario = "frmMaquina" Then
            vMaquina = True
            '--
            vLinea = False
            vModelo = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
        ElseIf vNombre_De_Formulario = "frmTiempo_Ciclo" Then
            vTiempo_Ciclo = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
            vUsuario = False
            vTipo_Usuario = False
        ElseIf vNombre_De_Formulario = "frmUsuario" Then
            vUsuario = True

            vTiempo_Ciclo = False
            vLinea = False
            vModelo = False
            vMaquina = False
            vTipo_Usuario = False
        ElseIf vNombre_De_Formulario = "FrmTipo_Usuario" Then
            vTipo_Usuario = True

            vTiempo_Ciclo = False
            vLinea = False
            vModelo = False
            vMaquina = False
            vUsuario = False
        End If
    End Sub

    Private Sub dgvRegistros_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                vRowSeleccionada = dgvRegistros.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try
    End Sub
End Class
