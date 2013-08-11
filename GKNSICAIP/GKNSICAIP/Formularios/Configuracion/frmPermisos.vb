Imports CapaNegocios

Public Class FrmPermisos
    Dim oUsuario As SEGURIDAD_USUARIO

    Private Sub FrmPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oUsuario = New SEGURIDAD_USUARIO        
        Cargar_Usuarios(oUsuario, 0, Nothing)
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

    Private Sub Carga_Permisos_Usuario()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TreeView_Usuarios_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView_Usuarios.NodeMouseClick

        '(e.Node.Text)
    End Sub
End Class
