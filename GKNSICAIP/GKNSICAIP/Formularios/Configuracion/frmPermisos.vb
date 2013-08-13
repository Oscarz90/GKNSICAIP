Imports CapaNegocios

Public Class FrmPermisos
    Dim oUsuario As SEGURIDAD_USUARIO

    Private Sub FrmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario = New SEGURIDAD_USUARIO        
        Cargar_Usuarios(oUsuario, 0, Nothing)      
        Carga_Permisos_Usuario(oUsuario, 0, Nothing)
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

    Private Sub Carga_Permisos_Usuario(ByRef User As SEGURIDAD_USUARIO, ByVal vIndicePadre_Permisos_Usuarios As Integer, ByVal vNodePadre_Permisos_Usuarios As TreeNode)
        Dim vDV_Hijos As DataView
        'Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro
        vDV_Hijos = New DataView(User.Obtener_Arbol_Permisos)

        vDV_Hijos.RowFilter = User.Obtener_Arbol_Permisos.Columns("IdentificadorPadre").ColumnName + "=" + vIndicePadre_Permisos_Usuarios.ToString
        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.      

        For Each dataRowCurrent As DataRowView In vDV_Hijos
            Dim nuevoNodo_Permisos_Usuarios As New TreeNode
            nuevoNodo_Permisos_Usuarios.Text = dataRowCurrent("NombreNodo").ToString().Trim() ' + " " + "-->" + dataRowCurrent("estatus").ToString().Trim()            
            nuevoNodo_Permisos_Usuarios.Tag = dataRowCurrent("CVE_TABLA").ToString().Trim()
            nuevoNodo_Permisos_Usuarios.Checked = True
            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If vNodePadre_Permisos_Usuarios Is Nothing Then
                TreeView_Permisos.Nodes.Add(nuevoNodo_Permisos_Usuarios)
            Else
                '' se añade el nuevo nodo al nodo padre.                
                vNodePadre_Permisos_Usuarios.Nodes.Add(nuevoNodo_Permisos_Usuarios)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            Carga_Permisos_Usuario(User, dataRowCurrent("IdentificadorNodo"), nuevoNodo_Permisos_Usuarios)
        Next dataRowCurrent
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TreeView_Usuarios_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView_Usuarios.NodeMouseClick
        'e.Node.Tag
        '(e.Node.Text)
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
   
End Class
