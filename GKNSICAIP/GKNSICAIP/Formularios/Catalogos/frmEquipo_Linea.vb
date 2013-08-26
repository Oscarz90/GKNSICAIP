Imports CapaNegocios
Imports System.Transactions
Public Class frmEquipo_Linea
    Dim oEquipo_Linea As New EquipoLinea
    Dim oLinea As New Linea
    Dim vId_Linea_Importada As Long = 0
    Dim vAdd_Registrar As Boolean = True

    Sub New(Optional ByVal vRegistrar As Boolean = True)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub frmEquipo_Linea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAsignar_ITEM.Enabled = False
        Me.btnLiberar_ITEM.Enabled = False
        Me.btnGuardar.Enabled = False
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim vfrmImportador_Linea As New frmImportador_Linea
        vfrmImportador_Linea.ShowDialog()        
        vId_Linea_Importada = vfrmImportador_Linea.vRetorno_CVE_Linea ''--------------Se guarda el Id de la Linea Importada
        oEquipo_Linea.cve_linea = vId_Linea_Importada
        txtLinea.Text = oEquipo_Linea.Nombre_Linea
        Cargar_Listas()
        Me.btnAsignar_ITEM.Enabled = True
        Me.btnLiberar_ITEM.Enabled = True
        If vAdd_Registrar = True Then
            Me.btnGuardar.Enabled = True
        Else
            Me.btnGuardar.Enabled = False
            MsgBox("El Usuario no tiene los privilegios para poder Registrar")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAsignar_ITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar_ITEM.Click
        lbAsignados.Items.Add(lbLibres.SelectedItem)
        lbLibres.Items.Remove(lbLibres.SelectedItem)
    End Sub

    Private Sub btnLiberar_ITEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberar_ITEM.Click
        lbLibres.Items.Add(lbAsignados.SelectedItem)
        lbAsignados.Items.Remove(lbAsignados.SelectedItem)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ''--------Se debe eliminar los equipos asignados a la linea Importada
        ''--------para despues Guardar los equipos actuales en la lista de Asignacion.
        If MsgBox("¿Esta seguro de registrar los Equipos en la Linea Seleccionada?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Using scope As New TransactionScope()
                Try
                    oEquipo_Linea.cve_linea = vId_Linea_Importada
                    oEquipo_Linea.Eliminar()

                    For Each vObjeto As Equipo In lbAsignados.Items
                        oEquipo_Linea.cve_equipo_linea = 0
                        oEquipo_Linea.cve_equipo = vObjeto.Cve_Equipo
                        oEquipo_Linea.cve_linea = vId_Linea_Importada
                        oEquipo_Linea.Registrar()
                    Next
                    scope.Complete()
                    MsgBox("Se registro con Exito")
                Catch ex As Exception
                    MsgBox("No se pudo registrar la Asignacion")
                End Try
            End Using
        End If
    End Sub

#Region "LLenar Listas"
    Private Sub Cargar_Listas()

        oLinea.LEquipos_Linea_Asignados = Nothing
        oLinea.LEquipos_Linea_NO_Asignados = Nothing
        Me.lbAsignados.Items.Clear()
        Me.lbLibres.Items.Clear()
        oLinea.cve_linea = vId_Linea_Importada ''--------------------Asignacion de Linea Seleccionada(Importada)

        For Each vEquipo As Equipo In oLinea.LEquipos_Linea_Asignados            
            lbAsignados.Items.Add(vEquipo)
            lbAsignados.ValueMember = "cve_equipo"
            lbAsignados.DisplayMember = "Equipo"
        Next

        For Each vEquipo As Equipo In oLinea.LEquipos_Linea_NO_Asignados
            lbLibres.Items.Add(vEquipo)
            lbLibres.ValueMember = "cve_equipo"
            lbLibres.DisplayMember = "Equipo"
        Next

    End Sub
#End Region



    
End Class