Imports CapaNegocios
Imports CapaNegocios.Clases_Catalogos
Imports Telerik.WinControls.UI


Public Class Formulario_Principal
    Public oUsuario_Login As New SEGURIDAD_USUARIO
    Dim vRowSeleccionada As Integer = 0
    Dim vPermiso_Add As Boolean = True
    Dim vPermiso_Delete As Boolean = True

#Region "Variables Identificador Opciones Menu"
    Dim vLinea As String = ""
    Dim vMaquina As Boolean = False
    Dim vModelo As Boolean = False
    Dim vTiempo_Ciclo As Boolean = False
    Dim vUsuario As Boolean = False '---------------
    Dim vTipo_Usuario As Boolean = False '-----------
    Dim vPermisos As Boolean = False '--------------
    Dim vEquipo As Boolean = False '--------------
    Dim vMatch_Equipos As Boolean = False
    Dim vLineaClasificacion As Boolean = False
    Dim vRelacionLineaClasificacion As Boolean = False
#End Region

#Region "Declaracion de Objetos_Clases_Catalogos"
    Dim oCatalogo_Linea As Catalogo_Linea
    Dim oCatalogo_Maquina As Catalogo_Maquina
    Dim oCatalogo_Modelo As Catalogo_Modelo
    Dim oCatalogo_Tiempo_Ciclo As Catalogo_Tiempo_Ciclo
    Dim oCatalogo_Tipo_Usuario As Catalogo_Tipo_Usuario '--------
    Dim oCatalogo_Usuario As Catalogo_Usuario '--------
    Dim oCatalogo_Equipo As Catalogo_Equipo '--------
#End Region

#Region "Declaracion de Objetos_Clases_Individiduales"
    Dim oLinea As Linea
    Dim oMaquina As Maquina
    Dim oModelo As Modelo
    Dim oTiempo_Ciclo As TC
    Dim oEquipo_Linea As EquipoLinea
    Dim oUsuario As SEGURIDAD_USUARIO
    Dim oTipo_Usuario As Tipo_Usuario
    Dim oEquipo As Equipo '--------
    Dim oLineaClasificacion As Linea_Clasificacion
    Dim oRelacionLineaClasificacion As Relacion_Linea_Clasificacion
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
    Dim ofrmImportar_TC As FrmImportar_TC
    Dim ofrmGraficas As FrmGraficasfaseuno
    Dim ofrmImportar_Modelo As FrmImportar_Modelo
    Dim ofrmAcceso_Sistema_SICAIP As frmLogin
    Dim ofrmEquipo As frmEquipo
    Dim ofrmMatch_Equipos As frmMatch_Equipos_Kronos_SICAIP
    Dim ofrmLineaClasificacion As frmLineaClasificacion
    Dim ofrmRelacionLineaClasificacion As frmRelacionLineaClasificacion
#End Region

#Region "Opciones de Menu"
    Private Sub btnLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinea.Click
        If Permiso_Asignado("CATALOGOLINEA") = True Then
            oCatalogo_Linea = New Catalogo_Linea
            oLinea = New Linea
            MapaUbicacion.Text = "Catalogo Linea"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()
            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            'Me.btnEliminar.VisibleInStrip = False

            If Permiso_Asignado("CATALOGOLINEA.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("CATALOGOLINEA.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If


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

            Me.dgvRegistros.EnableGrouping = True           
            Me.dgvRegistros.GroupDescriptors.Clear()
            Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("componente")))
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Linea'")
        End If
    End Sub

    Private Sub btnMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaquina.Click
        If Permiso_Asignado("CATALOGOMAQUINA") = True Then
            oCatalogo_Maquina = New Catalogo_Maquina
            oMaquina = New Maquina

            MapaUbicacion.Text = "Catalogo Maquina"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()

            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            'Me.btnEliminar.VisibleInStrip = False

            If Permiso_Asignado("CATALOGOMAQUINA.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If


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

            Me.dgvRegistros.EnableGrouping = True
            Me.dgvRegistros.GroupDescriptors.Clear()
            Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("linea")))

            dgvRegistros.Visible = True
            Activar_Formulario("frmMaquina")
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Maquina'")
        End If
    End Sub

    Private Sub btnModelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModelo.Click
        If Permiso_Asignado("CATALOGOMODELO") = True Then
            oCatalogo_Modelo = New Catalogo_Modelo
            oModelo = New Modelo

            MapaUbicacion.Text = "Catalogo Modelo"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()

            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            'Me.btnEliminar.VisibleInStrip = False

            If Permiso_Asignado("CATALOGOMODELO.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("CATALOGOMODELO.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If



            Try
                Me.dgvRegistros.DataSource = oCatalogo_Modelo.Obtener_Modelos
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.dgvRegistros.Columns("cve_modelo").HeaderText = "cve_modelo"
            Me.dgvRegistros.Columns("cve_modelo").IsVisible = False
            Me.dgvRegistros.Columns("cve_modelo").Name = "CVE"

            Me.dgvRegistros.Columns("np_gkn").HeaderText = "NP GKN"
            Me.dgvRegistros.Columns("np_gkn").Width = 250


            Me.dgvRegistros.Columns("Modelo").HeaderText = "Modelo"
            Me.dgvRegistros.Columns("Modelo").Width = 250

           
            Me.dgvRegistros.Columns("componente").HeaderText = " componente"
            Me.dgvRegistros.Columns("componente").Width = 250

            Me.dgvRegistros.Columns("Clasificacion_Modelo").HeaderText = " Clasificacion Modelo"
            Me.dgvRegistros.Columns("Clasificacion_Modelo").IsVisible = False
            'Me.dgvRegistros.Columns("Clasificacion_Modelo").Width = 250

            Me.dgvRegistros.EnableGrouping = True
            Me.dgvRegistros.GroupDescriptors.Clear()
            Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("componente")))

            dgvRegistros.Visible = True
            Activar_Formulario("frmModelo")
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Modelo'")
        End If
    End Sub

    Private Sub btnTiempo_Ciclo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTiempo_Ciclo.Click
        If Permiso_Asignado("CATALOGOTC") = True Then
            oCatalogo_Tiempo_Ciclo = New Catalogo_Tiempo_Ciclo
            oTiempo_Ciclo = New TC

            MapaUbicacion.Text = "Catalogo Tiempo Ciclo"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()

            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            Me.btnEliminar.VisibleInStrip = False

            If Permiso_Asignado("CATALOGOTC.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("CATALOGOTC.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If
            Try
                Me.dgvRegistros.DataSource = oCatalogo_Tiempo_Ciclo.Obtener_Tiempos_Ciclos

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

            Me.dgvRegistros.Columns("NumParte").HeaderText = "Numero de Parte"
            Me.dgvRegistros.Columns("NumParte").Width = 250

            Me.dgvRegistros.Columns("estatus").HeaderText = "estatus"
            Me.dgvRegistros.Columns("estatus").IsVisible = False


            Me.dgvRegistros.EnableGrouping = True
            Me.dgvRegistros.GroupDescriptors.Clear()
            Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("Nombre_Linea")))

            dgvRegistros.Visible = True
            Activar_Formulario("frmTiempo_Ciclo")
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Tiempo Ciclo'")
        End If
    End Sub

    Private Sub btnImportar_TC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_TC.Click
        If Permiso_Asignado("IMPORTAR_TC") = True Then
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False
            MapaUbicacion.Text = "Catalogo Tiempo Ciclo"
            ofrmImportar_TC = New FrmImportar_TC
            ofrmImportar_TC.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'Importar TC'")
        End If
    End Sub

    Private Sub btnEquipo_Linea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipo_Linea.Click
        If Permiso_Asignado("EQUIPOLINEA") = True Then
            If Permiso_Asignado("EQUIPOLINEA.REGISTRAR") = True Then
                ofrmEquipo_Linea = New frmEquipo_Linea(True)
            Else
                ofrmEquipo_Linea = New frmEquipo_Linea(False)
            End If
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False

            MapaUbicacion.Text = "Equipo_Linea"
            ofrmEquipo_Linea.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'Asignacion Equipo_Linea'")
        End If
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        If Permiso_Asignado("USUARIOS") = True Then
            oCatalogo_Usuario = New Catalogo_Usuario
            oUsuario = New SEGURIDAD_USUARIO

            MapaUbicacion.Text = "Catalogo Usuario"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()

            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            Me.btnEliminar.VisibleInStrip = True

            If Permiso_Asignado("USUARIOS.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("USUARIOS.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If
            'If Permiso_Asignado("USUARIOS.VER") = True Then
            '    Me.dgvRegistros.ReadOnly = True            
            'End If
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

            Me.dgvRegistros.Columns("Cve_CV").HeaderText = "Cve_CV"
            Me.dgvRegistros.Columns("Cve_CV").IsVisible = False
            Me.dgvRegistros.Columns("Cve_Componente").HeaderText = "Cve_Componente"
            Me.dgvRegistros.Columns("Cve_Componente").IsVisible = False

            'Me.dgvRegistros.EnableGrouping = True
            'Me.dgvRegistros.GroupDescriptors.Clear()
            'Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("Descripcion_Tipo_Usuario")))

            dgvRegistros.Visible = True
            Activar_Formulario("frmUsuario")
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en el Catalogo 'Usuarios'")
        End If
    End Sub

    Private Sub btnTipoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipoUsuario.Click
        If Permiso_Asignado("TIPOUSUARIO") = True Then
            oCatalogo_Tipo_Usuario = New Catalogo_Tipo_Usuario
            oTipo_Usuario = New Tipo_Usuario

            MapaUbicacion.Text = "Catalogo Tipo de Usuario"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()

            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            Me.btnEliminar.VisibleInStrip = True

            If Permiso_Asignado("TIPOUSUARIO.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("TIPOUSUARIO.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = True
            Else
                Me.btnEliminar.Enabled = False
            End If


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
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en el Catalogo 'Tipo de Usuarios'")
        End If
    End Sub

    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click
        If Permiso_Asignado("PERMISOS") = True Then
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False
            MapaUbicacion.Text = "Catalogo Permisos"

            If Permiso_Asignado("PERMISOS.REGISTRAR") = True Then
                ofrmPermisos = New FrmPermisos(oUsuario_Login, True)
            Else
                ofrmPermisos = New FrmPermisos(oUsuario_Login, False)
            End If
            ofrmPermisos.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'Asignacion de Permisos'")
        End If
    End Sub

    Private Sub btnGraficas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficas.Click
        'If Permiso_Asignado("GRAFICAS") = True Then
        Me.dgvRegistros.Visible = False
        Me.Barra_Tool_Registros.Visible = False
        MapaUbicacion.Text = "Graficas"

        ofrmGraficas = New FrmGraficasfaseuno
        ofrmGraficas.ShowDialog()
        'Else
        'MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'GRAFICAS'")
        'End If
    End Sub

    Private Sub btnImportar_Modelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Modelo.Click
        If Permiso_Asignado("IMPORTAR_MODELO") = True Then
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False
            MapaUbicacion.Text = "Catalogo IMPORTAR MODELO"
            ofrmImportar_Modelo = New FrmImportar_Modelo
            ofrmImportar_Modelo.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'Importar Modelo'")
        End If
    End Sub

    Private Sub btnAcceso_Sistema_Captura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceso_Sistema_Captura.Click
        If Permiso_Asignado("ACCESO_CAPTURA_SICAIP") = True Then
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False
            MapaUbicacion.Text = "Acceso Captura SICAIP"
            ofrmAcceso_Sistema_SICAIP = New frmLogin
            ofrmAcceso_Sistema_SICAIP.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'Acceso Captura SICAIP'")
        End If
    End Sub
    ''Abrir gridview con la informacion de los equipos
    Private Sub btnEquipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquipo.Click
        If Permiso_Asignado("CATALOGOEQUIPO") = True Then
            oCatalogo_Equipo = New Catalogo_Equipo
            oEquipo = New Equipo
            MapaUbicacion.Text = "Catalogo Equipo"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()
            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            'Me.btnEliminar.VisibleInStrip = False

            If Permiso_Asignado("CATALOGOEQUIPO.REGISTRAR") = True Then
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If
            If Permiso_Asignado("CATALOGOEQUIPO.ELIMINAR") = True Then
                Me.btnEliminar.Enabled = False
            Else
                Me.btnEliminar.Enabled = False
            End If


            Try
                Dim vDT As DataTable
                vDT = oCatalogo_Equipo.Obtener_Equipos()
                Me.dgvRegistros.DataSource = vDT

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.dgvRegistros.Columns("cve_equipo").HeaderText = "cve_equipo"
            Me.dgvRegistros.Columns("cve_equipo").IsVisible = False
            Me.dgvRegistros.Columns("cve_equipo").Name = "CVE"

            Me.dgvRegistros.Columns("equipo").HeaderText = "equipo"
            Me.dgvRegistros.Columns("equipo").Width = 250

            Me.dgvRegistros.Columns("LET").HeaderText = "Nombre Let"
            Me.dgvRegistros.Columns("LET").Width = 250

            Me.dgvRegistros.Columns("LG").HeaderText = "Nombre LG"
            Me.dgvRegistros.Columns("LG").Width = 150

            Me.dgvRegistros.Columns("descripcion").HeaderText = "Tipo tlatoani"
            Me.dgvRegistros.Columns("descripcion").Width = 150

            dgvRegistros.Visible = True
            Activar_Formulario("frmEquipo")

            Me.dgvRegistros.EnableGrouping = True
            Me.dgvRegistros.GroupDescriptors.Clear()
            Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("descripcion")))
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Equipo'")
        End If
    End Sub

    Private Sub btnMatch_Equipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatch_Equipos.Click
        If Permiso_Asignado("MATCH_EQUIPOS") = True Then
            Me.dgvRegistros.Visible = False
            Me.Barra_Tool_Registros.Visible = False
            MapaUbicacion.Text = "Match Equipos KRONOS_SICAIP"
            ofrmMatch_Equipos = New frmMatch_Equipos_Kronos_SICAIP
            ofrmMatch_Equipos.ShowDialog()
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar en 'MATCH_EQUIPOS'")
        End If
    End Sub

#End Region

#Region "Opciones de Registros"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If vLinea = True Then
            If Permiso_Asignado("CATALOGOLINEA.VER") = True Then
                If Permiso_Asignado("CATALOGOLINEA.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("CATALOGOLINEA.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmLinea = New frmLinea(vPermiso_Add, vPermiso_Delete)
                ofrmLinea.vId_Publico = 0
                ofrmLinea.ShowDialog()
                ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                btnLinea.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vMaquina = True Then
            If Permiso_Asignado("CATALOGOMAQUINA.VER") = True Then
                If Permiso_Asignado("CATALOGOMAQUINA.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmMaquina = New frmMaquina(vPermiso_Add, vPermiso_Delete)
                ofrmMaquina.vId_Publico = 0
                ofrmMaquina.ShowDialog()
                ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                btnMaquina.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vModelo = True Then
            If Permiso_Asignado("CATALOGOMODELO.VER") = True Then
                If Permiso_Asignado("CATALOGOMODELO.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("CATALOGOMODELO.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmModelo = New frmModelo(vPermiso_Add, vPermiso_Delete)
                ofrmModelo.vId_Publico = 0
                ofrmModelo.ShowDialog()
                btnModelo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vTiempo_Ciclo = True Then
            If Permiso_Asignado("CATALOGOTC.VER") = True Then
                If Permiso_Asignado("CATALOGOTC.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                ofrmTiempo_Ciclo = New frmTiempo_Ciclo(vPermiso_Add, oUsuario_Login.CVE_Usuario)
                ofrmTiempo_Ciclo.vId_Publico = 0
                ofrmTiempo_Ciclo.ShowDialog()
                btnTiempo_Ciclo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vUsuario = True Then
            If Permiso_Asignado("USUARIO.VER") = True Then
                If Permiso_Asignado("USUARIOS.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("USUARIOS.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmUsuario = New FrmUsuarios(vPermiso_Add, vPermiso_Delete)
                ofrmUsuario.vId_Publico = 0
                ofrmUsuario.ShowDialog()
                btnUsuario.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vTipo_Usuario = True Then
            If Permiso_Asignado("TIPOUSUARIO.VER") = True Then
                If Permiso_Asignado("TIPOUSUARIO.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("TIPOUSUARIO.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmTipo_Usuario = New FrmTipo_Usuario(vPermiso_Add, vPermiso_Delete)
                ofrmTipo_Usuario.vId_Publico = 0
                ofrmTipo_Usuario.ShowDialog()
                btnTipoUsuario.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vEquipo = True Then
            If Permiso_Asignado("CATALOGOEQUIPO.VER") = True Then
                If Permiso_Asignado("CATALOGOEQUIPO.REGISTRAR") = True Then
                    vPermiso_Add = False
                Else
                    vPermiso_Add = False
                End If
                'If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                '    vPermiso_Delete = True
                'Else
                '    vPermiso_Delete = False
                'End If
                ofrmEquipo = New frmEquipo(vPermiso_Add, vPermiso_Delete)
                ofrmEquipo.vId_Publico = 0
                ofrmEquipo.ShowDialog()
                ''Se realiza la llamada al evento clic del btnEquipo para actualizar el dgvRegistros
                btnEquipo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vLineaClasificacion = True Then
            If Permiso_Asignado("CLASF_LINEAS.VER") = True Then
                If Permiso_Asignado("CLASF_LINEAS.REGISTRAR") = True Then
                    'vPermiso_Add = False
                    ofrmLineaClasificacion = New frmLineaClasificacion
                    ofrmLineaClasificacion.operacion = ofrmLineaClasificacion.Insertar
                    ofrmLineaClasificacion.ShowDialog()
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
                btnClasf_Lineas.PerformClick()
                vRowSeleccionada = 0
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vRelacionLineaClasificacion = True Then
            If Permiso_Asignado("REL_CLASF_LINEAS.VER") = True Then
                If Permiso_Asignado("REL_CLASF_LINEAS.REGISTRAR") = True Then
                    'vPermiso_Add = False
                    ofrmRelacionLineaClasificacion = New frmRelacionLineaClasificacion
                    ofrmRelacionLineaClasificacion.operacion = ofrmRelacionLineaClasificacion.Insertar
                    ofrmRelacionLineaClasificacion.ShowDialog()
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
                btnRel_Clasf_Lineas.PerformClick()
                vRowSeleccionada = 0
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        End If
    End Sub

    'ofrmLinea.vId_Publico = vRowSeleccionada
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If vLinea = True Then
            If Permiso_Asignado("CATALOGOLINEA.VER") = True Then
                If Permiso_Asignado("CATALOGOLINEA.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("CATALOGOLINEA.ELIMINAR") = True Then
                    vPermiso_Delete = True
                Else
                    vPermiso_Delete = False
                End If
                ofrmLinea = New frmLinea(vPermiso_Add, vPermiso_Delete)
                ofrmLinea.vId_Publico = vRowSeleccionada
                ofrmLinea.ShowDialog()
                ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                btnLinea.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vMaquina = True Then
            If Permiso_Asignado("CATALOGOMAQUINA.VER") = True Then
                If Permiso_Asignado("CATALOGOMAQUINA.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                    vPermiso_Delete = True
                Else
                    vPermiso_Delete = False
                End If
                ofrmMaquina = New frmMaquina(vPermiso_Add, vPermiso_Delete)
                ofrmMaquina.vId_Publico = vRowSeleccionada
                ofrmMaquina.ShowDialog()
                ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                btnMaquina.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vModelo = True Then
            If Permiso_Asignado("CATALOGOMODELO.VER") = True Then
                If Permiso_Asignado("CATALOGOMODELO.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("CATALOGOMODELO.ELIMINAR") = True Then
                    vPermiso_Delete = True
                Else
                    vPermiso_Delete = False
                End If
                ofrmModelo = New frmModelo(vPermiso_Add, vPermiso_Delete)
                ofrmModelo.vId_Publico = vRowSeleccionada
                ofrmModelo.ShowDialog()
                btnModelo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vTiempo_Ciclo = True Then
            If Permiso_Asignado("CATALOGOTC.VER") = True Then
                If Permiso_Asignado("CATALOGOTC.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                ofrmTiempo_Ciclo = New frmTiempo_Ciclo(vPermiso_Add, oUsuario_Login.CVE_Usuario)
                ofrmTiempo_Ciclo.vId_Publico = vRowSeleccionada
                ofrmTiempo_Ciclo.ShowDialog()
                btnTiempo_Ciclo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vUsuario = True Then
            If Permiso_Asignado("USUARIO.VER") = True Then
                If Permiso_Asignado("USUARIOS.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("USUARIOS.ELIMINAR") = True Then
                    vPermiso_Delete = True
                Else
                    vPermiso_Delete = False
                End If
                ofrmUsuario = New FrmUsuarios(vPermiso_Add, vPermiso_Delete)
                ofrmUsuario.vId_Publico = vRowSeleccionada
                ofrmUsuario.ShowDialog()
                btnUsuario.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vTipo_Usuario = True Then
            If Permiso_Asignado("TIPOUSUARIO.VER") = True Then
                If Permiso_Asignado("TIPOUSUARIO.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("TIPOUSUARIO.ELIMINAR") = True Then
                    vPermiso_Delete = True
                Else
                    vPermiso_Delete = False
                End If
                ofrmTipo_Usuario = New FrmTipo_Usuario(vPermiso_Add, vPermiso_Delete)
                ofrmTipo_Usuario.vId_Publico = vRowSeleccionada
                ofrmTipo_Usuario.ShowDialog()
                btnTipoUsuario.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
            ''Codigo para Modificar catalogo equipo
        ElseIf vEquipo = True Then
            If Permiso_Asignado("CATALOGOEQUIPO.VER") = True Then
                If Permiso_Asignado("CATALOGOEQUIPO.REGISTRAR") = True Then
                    vPermiso_Add = True
                Else
                    vPermiso_Add = False
                End If
                If Permiso_Asignado("CATALOGOEQUIPO.ELIMINAR") = True Then
                    vPermiso_Delete = False
                Else
                    vPermiso_Delete = False
                End If
                ofrmEquipo = New frmEquipo(vPermiso_Add, vPermiso_Delete)
                ofrmEquipo.vId_Publico = vRowSeleccionada
                ofrmEquipo.ShowDialog()
                ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                btnEquipo.PerformClick()
            Else
                MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
            End If
        ElseIf vLineaClasificacion = True Then
            If vRowSeleccionada <> 0 Then
                If Permiso_Asignado("CLASF_LINEAS.VER") = True Then
                    If Permiso_Asignado("CLASF_LINEAS.REGISTRAR") = True Then
                        ofrmLineaClasificacion = New frmLineaClasificacion
                        ofrmLineaClasificacion.operacion = frmLineaClasificacion.Actualizar
                        ofrmLineaClasificacion.cve_linea_clasificacion = vRowSeleccionada
                        ofrmLineaClasificacion.ShowDialog()
                    Else
                        MsgBox("El Usuario no tiene los privilegios para registrar")
                    End If
                    btnClasf_Lineas.PerformClick()
                    vRowSeleccionada = 0
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            Else
                MsgBox("No has seleccionado ningun registro", vbInformation + vbOKOnly, "Clasificación Linea")
            End If
        ElseIf vRelacionLineaClasificacion = True Then
            If vRowSeleccionada <> 0 Then
                If Permiso_Asignado("REL_CLASF_LINEAS.VER") = True Then
                    If Permiso_Asignado("REL_CLASF_LINEAS.REGISTRAR") = True Then
                        oRelacionLineaClasificacion = New CapaNegocios.Relacion_Linea_Clasificacion
                        oRelacionLineaClasificacion.cve_relacion_linea_clasificacion = vRowSeleccionada
                        oRelacionLineaClasificacion.Cargar()
                        If oRelacionLineaClasificacion.fecha_final <> Nothing Then
                            MsgBox("Este registro no se puede actualizar ya que tiene establecida su fecha de Inicio y Fin.", vbInformation + vbOKOnly, "Asignación de Clasificación Linea")
                        Else
                            ofrmRelacionLineaClasificacion = New frmRelacionLineaClasificacion
                            ofrmRelacionLineaClasificacion.operacion = ofrmRelacionLineaClasificacion.Actualizar
                            ofrmRelacionLineaClasificacion.cve_relacion_linea_clasificacion = vRowSeleccionada
                            ofrmRelacionLineaClasificacion.ShowDialog()
                        End If
                    Else
                        MsgBox("El Usuario no tiene los privilegios para registrar")
                    End If
                    btnRel_Clasf_Lineas.PerformClick()
                    vRowSeleccionada = 0
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            Else
                MsgBox("No has seleccionado ningun registro", vbInformation + vbOKOnly, "Clasificación Linea")
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If vLinea = True Then
            If Permiso_Asignado("CATALOGOLINEA.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Dar de Baja la Linea?, se daran de baja los TC relacionados con esta linea", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oLinea = New Linea
                    Try
                        oLinea.cve_linea = vRowSeleccionada
                        oLinea.Eliminar()
                        btnLinea.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If
        ElseIf vMaquina = True Then
            If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Dar de Baja la Maquina?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oMaquina = New Maquina
                    Try
                        oMaquina.cve_maquina = vRowSeleccionada
                        oMaquina.Eliminar()
                        btnMaquina.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If
        ElseIf vModelo = True Then
            If Permiso_Asignado("CATALOGOMODELO.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Dar de Baja el Modelo?, se daran de baja los TC relacionados con este Modelo", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oModelo = New Modelo
                    Try
                        oModelo.cve_modelo = vRowSeleccionada
                        oModelo.Eliminar()
                        btnModelo.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If
        ElseIf vTiempo_Ciclo = True Then
            'oLinea = New Linea
            'oLinea.cve_linea = vRowSeleccionada
            'oLinea.Eliminar()
            'btnLinea.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
        ElseIf vUsuario = True Then
            If Permiso_Asignado("USUARIOS.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Dar de Baja al Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oUsuario = New SEGURIDAD_USUARIO
                    Try
                        oUsuario.CVE_Usuario = vRowSeleccionada
                        oUsuario.Eliminar()
                        btnUsuario.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If

        ElseIf vTipo_Usuario = True Then
            If Permiso_Asignado("TIPOUSUARIO.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Eliminar el Tipo de Usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oTipo_Usuario = New Tipo_Usuario
                    Try
                        oTipo_Usuario.CVE_Tipo_Usuario = vRowSeleccionada
                        oTipo_Usuario.Eliminar()
                        btnTipoUsuario.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If
            ''--------
        ElseIf vEquipo = True Then
            If Permiso_Asignado("CATALOGOEQUIPO.ELIMINAR") = True Then
                If MsgBox("¿Esta seguro de Dar de Baja el Equipo?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oEquipo = New Equipo
                    Try
                        oEquipo.Cve_Equipo = vRowSeleccionada
                        oEquipo.Eliminar()
                        btnEquipo.PerformClick() ''Se realiza la llamada al evento clic del btnLinea para actualizar el dgvRegistros
                    Catch ex As Exception

                    End Try
                End If
            Else
                MsgBox("El Usuario no tiene los privilegios para Eliminar o Dar Baja")
            End If
            ''--------
        End If
    End Sub
#End Region

#Region "Eventos para Registro Principal"

    Private Sub dgvRegistros_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRegistros.MouseDoubleClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then                
                vRowSeleccionada = 0
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then                
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
                If Permiso_Asignado("CATALOGOLINEA.VER") = True Then
                    If Permiso_Asignado("CATALOGOLINEA.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("CATALOGOLINEA.ELIMINAR") = True Then
                        vPermiso_Delete = True
                    Else
                        vPermiso_Delete = False
                    End If

                    ofrmLinea = New frmLinea(vPermiso_Add, vPermiso_Delete)

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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            ElseIf vMaquina = True Then
                If Permiso_Asignado("CATALOGOMAQUINA.VER") = True Then
                    If Permiso_Asignado("CATALOGOMAQUINA.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("CATALOGOMAQUINA.ELIMINAR") = True Then
                        vPermiso_Delete = True
                    Else
                        vPermiso_Delete = False
                    End If

                    ofrmMaquina = New frmMaquina(vPermiso_Add, vPermiso_Delete)

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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            ElseIf vModelo = True Then
                If Permiso_Asignado("CATALOGOMODELO.VER") = True Then
                    If Permiso_Asignado("CATALOGOMODELO.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("CATALOGOMODELO.ELIMINAR") = True Then
                        vPermiso_Delete = True
                    Else
                        vPermiso_Delete = False
                    End If

                    ofrmModelo = New frmModelo(vPermiso_Add, vPermiso_Delete)
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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            ElseIf vTiempo_Ciclo = True Then
                If Permiso_Asignado("CATALOGOTC.VER") = True Then
                    If Permiso_Asignado("CATALOGOTC.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    ofrmTiempo_Ciclo = New frmTiempo_Ciclo(vPermiso_Add, oUsuario_Login.CVE_Usuario)

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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            ElseIf vUsuario = True Then
                If Permiso_Asignado("USUARIO.VER") = True Then
                    If Permiso_Asignado("USUARIOS.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("USUARIOS.ELIMINAR") = True Then
                        vPermiso_Delete = True
                    Else
                        vPermiso_Delete = False
                    End If
                    ofrmUsuario = New FrmUsuarios(vPermiso_Add, vPermiso_Delete)
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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
            ElseIf vTipo_Usuario = True Then
                If Permiso_Asignado("TIPOUSUARIO.VER") = True Then
                    If Permiso_Asignado("TIPOUSUARIO.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("TIPOUSUARIO.ELIMINAR") = True Then
                        vPermiso_Delete = True
                    Else
                        vPermiso_Delete = False
                    End If
                    ofrmTipo_Usuario = New FrmTipo_Usuario(vPermiso_Add, vPermiso_Delete)

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
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If
                '------------------
            ElseIf vEquipo = True Then
                If Permiso_Asignado("CATALOGOEQUIPO.VER") = True Then
                    If Permiso_Asignado("CATALOGOEQUIPO.REGISTRAR") = True Then
                        vPermiso_Add = True
                    Else
                        vPermiso_Add = False
                    End If
                    If Permiso_Asignado("CATALOGOEQUIPO.ELIMINAR") = True Then
                        vPermiso_Delete = False
                    Else
                        vPermiso_Delete = False
                    End If
                    ofrmEquipo = New frmEquipo(vPermiso_Add, vPermiso_Delete)

                    Try
                        'ofrmTiempo_Ciclo.vId_Publico = dgvRegistros.Rows(vRowSeleccionada).Cells(0).Value
                        ofrmEquipo.vId_Publico = vRowSeleccionada
                    Catch ex As Exception
                        If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                            ofrmEquipo.vId_Publico = 0
                        End If
                    End Try
                    ofrmEquipo.ShowDialog()
                    btnEquipo.PerformClick()
                Else
                    MsgBox("El Usuario no tiene los privilegios para ver los Detalles")
                End If

                '---------------
            End If
        Else
        End If
        ''-----------------------------------------------------------------------------------------------------------------
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
#End Region

#Region "Validaciones"
    Private Sub Activar_Formulario(ByVal vNombre_De_Formulario As String)
        If vNombre_De_Formulario = "frmLinea" Then
            vLinea = True
            '--
            vModelo = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmModelo" Then
            vModelo = True
            '--
            vLinea = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmMaquina" Then
            vMaquina = True
            '--
            vLinea = False
            vModelo = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmTiempo_Ciclo" Then
            vTiempo_Ciclo = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmUsuario" Then
            vUsuario = True

            vTiempo_Ciclo = False
            vLinea = False
            vModelo = False
            vMaquina = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "FrmTipo_Usuario" Then
            vTipo_Usuario = True

            vTiempo_Ciclo = False
            vLinea = False
            vModelo = False
            vMaquina = False
            vUsuario = False
            vEquipo = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmEquipo" Then
            vEquipo = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vLineaClasificacion = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmLineaClasificacion" Then
            vLineaClasificacion = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vRelacionLineaClasificacion = False
        ElseIf vNombre_De_Formulario = "frmRelacionLineaClasificacion" Then
            vRelacionLineaClasificacion = True
            '--
            vLinea = False
            vModelo = False
            vMaquina = False
            vTiempo_Ciclo = False
            vUsuario = False
            vTipo_Usuario = False
            vEquipo = False
            vLineaClasificacion = False
        End If
    End Sub

    Private Function Permiso_Asignado(ByVal vNombre_Corto_Permiso As String) As Boolean
        Dim vRetorno As Boolean = False
        If oUsuario_Login.L_USUARIO_PERMISOS.Count <> 0 Then
            For Each vSeg_User_Perm As SEGURIDAD_USUARIO_PERMISOS In oUsuario_Login.L_USUARIO_PERMISOS
                If vSeg_User_Perm.Nombre_Corto_Permiso = vNombre_Corto_Permiso Then
                    vRetorno = True
                    Exit For
                End If
            Next
        End If
        Return vRetorno
    End Function
#End Region

    Private Sub Formulario_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        RadLabel_Usuario_Login.Text = RadLabel_Usuario_Login.Text & oUsuario_Login.Nombre
    End Sub


    Private Sub MapaUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapaUbicacion.Click

    End Sub

    Private Sub btnClasf_Lineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClasf_Lineas.Click
        If Permiso_Asignado("CLASF_LINEAS") = True Then
            'oCatalogo_Linea = New Catalogo_Linea
            oLineaClasificacion = New Linea_Clasificacion

            MapaUbicacion.Text = "Catalogo Clasificacion Linea"

            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()
            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            Me.btnEliminar.Enabled = False
            If Permiso_Asignado("CLASF_LINEAS.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
                Me.btnModificar.Enabled = True
            Else
                Me.btnAdd.Enabled = False
                Me.btnModificar.Enabled = False
            End If

            Try
                Me.dgvRegistros.DataSource = oLineaClasificacion.obtiene_linea_clasificacion_activos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.dgvRegistros.Columns("cve_linea_clasificacion").HeaderText = "cve_linea_clasificacion"
            Me.dgvRegistros.Columns("cve_linea_clasificacion").IsVisible = False
            Me.dgvRegistros.Columns("cve_linea_clasificacion").Name = "CVE"

            Me.dgvRegistros.Columns("nombre").HeaderText = "Nombre"
            Me.dgvRegistros.Columns("nombre").Width = 250

            Me.dgvRegistros.Columns("descripcion").HeaderText = "Descripcion"
            Me.dgvRegistros.Columns("descripcion").Width = 250

            Me.dgvRegistros.Columns("estatus").HeaderText = " estatus"
            Me.dgvRegistros.Columns("estatus").IsVisible = False

            dgvRegistros.Visible = True
            Activar_Formulario("frmLineaClasificacion")

            Me.dgvRegistros.EnableGrouping = True
            Me.dgvRegistros.GroupDescriptors.Clear()
            'Me.dgvRegistros.GroupDescriptors.Add(New GridGroupByExpression(Me.dgvRegistros.Columns("componente")))
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo de Clasificación de Línea'")
        End If
    End Sub

    Private Sub btnAsig_Clasf_Lineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRel_Clasf_Lineas.Click
        If Permiso_Asignado("REL_CLASF_LINEAS") = True Then
            'oCatalogo_Linea = New Catalogo_Linea
            oRelacionLineaClasificacion = New Relacion_Linea_Clasificacion
            MapaUbicacion.Text = "Catalogo Relacion Clasificacion Linea"
            Me.dgvRegistros.DataSource = Nothing
            Me.dgvRegistros.Columns.Clear()
            Me.dgvRegistros.Visible = True
            Me.Barra_Tool_Registros.Visible = True
            If Permiso_Asignado("REL_CLASF_LINEAS.REGISTRAR") = True Then
                Me.btnAdd.Enabled = True
            Else
                Me.btnAdd.Enabled = False
            End If
            If Permiso_Asignado("REL_CLASF_LINEAS.REGISTRAR") = True Then
                Me.btnModificar.Enabled = True
            Else
                Me.btnModificar.Enabled = False
            End If
            'No ser permite eliminar por cuestiones de confiabilidad de información
            Me.btnEliminar.Enabled = False
            'If Permiso_Asignado("CLASF_LINEAS.ELIMINAR") = True Then
            '    Me.btnEliminar.Enabled = True
            'Else
            '    Me.btnEliminar.Enabled = False
            'End If
            Try
                Me.dgvRegistros.DataSource = oRelacionLineaClasificacion.obtiene_asignacion_linea_clasificacion()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Me.dgvRegistros.Columns("cve_relacion_linea_clasificacion").HeaderText = "cve_relacion_linea_clasificacion"
            Me.dgvRegistros.Columns("cve_relacion_linea_clasificacion").IsVisible = False
            Me.dgvRegistros.Columns("cve_relacion_linea_clasificacion").Name = "CVE"

            Me.dgvRegistros.Columns("linea").HeaderText = "Linea"
            Me.dgvRegistros.Columns("linea").Width = 250

            Me.dgvRegistros.Columns("nombre").HeaderText = "Clasificacion"
            Me.dgvRegistros.Columns("nombre").Width = 250

            Me.dgvRegistros.Columns("fecha_inicio").HeaderText = "Fecha Inicio"
            Me.dgvRegistros.Columns("fecha_inicio").Width = 250

            Me.dgvRegistros.Columns("fecha_final").HeaderText = "Fecha Final"
            Me.dgvRegistros.Columns("fecha_final").Width = 250
            Me.dgvRegistros.Columns("fecha_final").Name = "FECHA"


            dgvRegistros.Visible = True
            Activar_Formulario("frmRelacionLineaClasificacion")
        Else
            MsgBox("El Usuario no cuenta con los permisos suficientes para entrar al 'Catalogo Asignacion de Clasificación de Línea'")
        End If
    End Sub
End Class
