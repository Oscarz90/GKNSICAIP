Imports CapaNegocios
Imports System.Transactions

Public Class FrmPermisos
    Public oUsuario_Login As SEGURIDAD_USUARIO
    Dim oUsuario As SEGURIDAD_USUARIO
    Dim oUsuario_Permisos As SEGURIDAD_USUARIO_PERMISOS
    Private vId_Nodo As Integer = 0
    Private vTipo_Nodo As String = ""
    Private vUsuario_Seleccionado_Global As Integer = 0

    Public Sub New(ByRef oUser_Login As SEGURIDAD_USUARIO, Optional ByVal vRegistrar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.oUsuario_Login = oUser_Login
        If vRegistrar = False Then
            btnGuardar.Enabled = False            
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FrmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario = New SEGURIDAD_USUARIO
        Cargar_Usuarios(oUsuario, 0, Nothing)
        Carga_Permisos_Usuario(oUsuario, 0, Nothing)        
        btnGuardar.Enabled = False
        RadLabel1.Visible = False
    End Sub

    Private Sub Cargar_Usuarios(ByRef User As SEGURIDAD_USUARIO, ByVal vIndicePadre As Integer, ByVal vNodePadre As TreeNode)
        Dim vDV_Hijos As DataView
        'Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro
        vDV_Hijos = New DataView(User.Obtener_Arbol_Usuarios)

        vDV_Hijos.RowFilter = User.Obtener_Arbol_Usuarios.Columns("IdentificadorPadre").ColumnName + "=" + vIndicePadre.ToString
        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.      

        For Each dataRowCurrent As DataRowView In vDV_Hijos
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("NombreNodo").ToString().Trim() ' + " " + "-->" + dataRowCurrent("estatus").ToString().Trim()            
            nuevoNodo.Tag = dataRowCurrent("CVE_TABLA").ToString().Trim()
            nuevoNodo.Checked = True
            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If vNodePadre Is Nothing Then
                TreeView_Usuarios.Nodes.Add(nuevoNodo)
            Else
                '' se añade el nuevo nodo al nodo padre.                
                vNodePadre.Nodes.Add(nuevoNodo)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            Cargar_Usuarios(User, dataRowCurrent("IdentificadorNodo"), nuevoNodo)
        Next dataRowCurrent
    End Sub

    Private Sub Carga_Permisos_Usuario(ByRef User As SEGURIDAD_USUARIO, ByVal vIndicePadre_Permisos_Usuarios As Integer, ByVal vNodePadre_Permisos_Usuarios As TreeNode, Optional ByVal vAsignacion_Permisos As Boolean = False, Optional ByVal vId_Usuario As Long = 0)
        Dim vDV_Hijos As DataView
        'Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro
        vDV_Hijos = New DataView(User.Obtener_Arbol_Permisos)

        vDV_Hijos.RowFilter = User.Obtener_Arbol_Permisos.Columns("IdentificadorPadre").ColumnName + "=" + vIndicePadre_Permisos_Usuarios.ToString
        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.   

        For Each dataRowCurrent As DataRowView In vDV_Hijos
            Dim nuevoNodo_Permisos_Usuarios As New TreeNode
            nuevoNodo_Permisos_Usuarios.Text = dataRowCurrent("NombreNodo").ToString().Trim() ' + " " + "-->" + dataRowCurrent("estatus").ToString().Trim()            
            nuevoNodo_Permisos_Usuarios.Tag = dataRowCurrent("CVE_TABLA").ToString().Trim()
            ''-------------------------------------------------------------------------------------------------------------------------------
            If vAsignacion_Permisos = True Then
                Dim vDV_Permisos As DataView

                Dim vTipo_Id As String = Obtener_Tipo_ID(nuevoNodo_Permisos_Usuarios.Tag)
                Dim vId_Per_Libre As Long = 0
                If vTipo_Id = "P" Then
                    vId_Per_Libre = Obtener_Id_Libre(nuevoNodo_Permisos_Usuarios.Tag)
                    vDV_Permisos = New DataView(User.Obtener_Permisos_Usuario(vId_Usuario))
                    If vDV_Permisos.Count > 0 Then
                        vDV_Permisos.RowFilter = User.Obtener_Permisos_Usuario(vId_Usuario).Columns("CVE_PERMISO").ColumnName + "=" + vId_Per_Libre.ToString
                        If vDV_Permisos.Count > 0 Then
                            nuevoNodo_Permisos_Usuarios.Checked = True
                        Else
                            nuevoNodo_Permisos_Usuarios.Checked = False
                        End If
                    End If
                End If
            Else
                nuevoNodo_Permisos_Usuarios.Checked = False
            End If
            ''-------------------------------------------------------------------------------------------------------------------------------

            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If vNodePadre_Permisos_Usuarios Is Nothing Then
                TreeView_Permisos.Nodes.Add(nuevoNodo_Permisos_Usuarios)
            Else
                '' se añade el nuevo nodo al nodo padre.                
                vNodePadre_Permisos_Usuarios.Nodes.Add(nuevoNodo_Permisos_Usuarios)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            Carga_Permisos_Usuario(User, dataRowCurrent("IdentificadorNodo"), nuevoNodo_Permisos_Usuarios, vAsignacion_Permisos, vId_Usuario)
        Next dataRowCurrent
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TreeView_Usuarios_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView_Usuarios.NodeMouseClick
        Cargar_Permisos_Usuario_Seleccionado(e.Node.Tag)
        If Obtener_Tipo_ID(e.Node.Tag) = "U" Then
            lbUsuario_Seleccionado.Text = e.Node.Text
            lbUsuario_Seleccionado.Visible = True
            btnGuardar.Enabled = True
            RadLabel1.Visible = True
            TreeView_Permisos.Enabled = True
            TreeView_Permisos.ExpandAll()
        Else
            btnGuardar.Enabled = False
            RadLabel1.Visible = False
            lbUsuario_Seleccionado.Visible = False
            TreeView_Permisos.Enabled = False
        End If
    End Sub

#Region "Metodo y Evento para Activar/Desactivar Casillas Con/Sin hijos"
    ' Updates all child tree nodes recursively.
    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode, ByVal nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub

    Private Sub TreeView_Permisos_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView_Permisos.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                ' Calls the CheckAllChildNodes method, passing in the current 
                ' Checked value of the TreeNode whose checked state changed. 
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If
    End Sub
#End Region

#Region "Metodos que obtienen el Id de Usuario y el Tipo de Nodo('Tipo Usuario / Usuario')"

    Private Function Obtener_Id_Libre(ByVal vTag_Nodo As String) As Integer
        Dim vRetorno As Integer
        Dim cadena As String = vTag_Nodo 'para capturar una cadena
        Dim resultado As String = "" 'para y recogiendo los caracteres de la cadena
        Dim x As Integer 'para pasar la posicion de la cadena
        Dim vPosicionPunto As Integer = 0

        For x = 0 To cadena.Length - 1
            If cadena.Chars(x) = "." Then
                vPosicionPunto = x
                Exit For
            End If
        Next

        vRetorno = Integer.Parse(vTag_Nodo.Substring(0, (vPosicionPunto)))
        Return vRetorno
    End Function

    Private Function Obtener_Tipo_ID(ByVal vTag_Nodo As String) As String
        Dim vRetorno As String = ""
        Dim cadena As String = vTag_Nodo 'para capturar una cadena
        Dim resultado As String = "" 'para y recogiendo los caracteres de la cadena
        Dim x As Integer 'para pasar la posicion de la cadena
        Dim vPosicionPunto As Integer = 0

        For x = 0 To cadena.Length - 1
            If cadena.Chars(x) = "." Then
                vPosicionPunto = x + 1
                Exit For
            End If
        Next

        vRetorno = vTag_Nodo.Substring(vPosicionPunto)
        Return vRetorno
    End Function
#End Region

    Private Sub Cargar_Permisos_Usuario_Seleccionado(ByVal vTag As String)
        vTipo_Nodo = Obtener_Tipo_ID(vTag)

        If vTipo_Nodo = "U" Then
            ''Se busca el Id, siempre y cuando sea un Usuario, esto para optimizar recurso(no sirve de nada cargar un TU("Tipo Usuario") ya que no requerimos esto.
            vId_Nodo = Obtener_Id_Libre(vTag)
            vUsuario_Seleccionado_Global = vId_Nodo
            'If oUsuario.Obtener_Permisos_Usuario(vId_Nodo) IsNot Nothing Then             
            oUsuario = New SEGURIDAD_USUARIO
            TreeView_Permisos.Nodes.Clear()
            Carga_Permisos_Usuario(oUsuario, 0, Nothing, True, vId_Nodo)
            'End If
        End If
    End Sub

    Private Sub RecorrerNodos(ByVal treeNode As TreeNode, ByRef vCVE_Permiso As Long)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá            
            For Each tn As TreeNode In treeNode.Nodes
                If Obtener_Tipo_ID(tn.Tag) = "P" Then
                    If Obtener_Id_Libre(tn.Tag) = vCVE_Permiso Then
                        tn.Checked = True
                        Exit Sub
                    Else
                        tn.Checked = False
                    End If
                End If
                'Ahora hago verificacion a los hijos del nodo actual            
                'Esta iteración no acabara hasta llegar al ultimo nodo principal
                RecorrerNodos(tn, vCVE_Permiso)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub RecorrerNodos_PARA_GUARDAR(ByVal treeNode As TreeNode)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá para luego verificar si esta o no checado
            For Each tn As TreeNode In treeNode.Nodes
                'Se Verifica si esta marcado...
                'If tn.Checked = True Then
                If Obtener_Tipo_ID(tn.Tag) = "P" Then
                    If tn.Checked = True Then
                        vId_Nodo = Obtener_Id_Libre(tn.Tag)
                        oUsuario_Permisos = New SEGURIDAD_USUARIO_PERMISOS
                        oUsuario_Permisos.CVE_PERMISO = vId_Nodo
                        oUsuario_Permisos.CVE_USUARIO = vUsuario_Seleccionado_Global
                        oUsuario.CVE_Usuario = vUsuario_Seleccionado_Global
                        oUsuario.L_USUARIO_PERMISOS.Add(oUsuario_Permisos)
                    End If
                End If
                'End If
                'Ahora hago verificacion a los hijos del nodo actual. Esta iteración no acabara hasta llegar al ultimo nodo principal
                RecorrerNodos_PARA_GUARDAR(tn)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Se Declara una colección de nodos apartir de tu Treeview del que se va a recorrer
        Dim nodes As TreeNodeCollection = TreeView_Permisos.Nodes
        'Se recorren los nodos principales
        oUsuario = New SEGURIDAD_USUARIO
        oUsuario_Permisos = New SEGURIDAD_USUARIO_PERMISOS

        If vUsuario_Seleccionado_Global > 0 Then
            Using scope As New TransactionScope()
                Try
                    oUsuario_Permisos.CVE_USUARIO = vUsuario_Seleccionado_Global
                    oUsuario_Permisos.Eliminar()
                    oUsuario.L_USUARIO_PERMISOS.Clear()
                    oUsuario.L_USUARIO_PERMISOS = Nothing
                    For Each n As TreeNode In nodes
                        'Se Declara un metodo para que recorra los hijos de los principales Y los hijos de los hijos....Recorrido Total en pocas palabras
                        'Para ello se envía el nodo actual para evaluar si tiene hijos            
                        RecorrerNodos_PARA_GUARDAR(n)
                    Next
                    oUsuario.Registrar_Permisos()
                Catch ex As Exception

                End Try
                oUsuario_Login.L_USUARIO_PERMISOS = Nothing
                scope.Complete()
            End Using
            MsgBox("Se registro correctamente")
        Else
            MsgBox("Seleccione un Usuario para Asignar la lista actual de Permisos cargada")
        End If
    End Sub
End Class
