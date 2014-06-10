Imports CapaNegocios
Imports Telerik.WinControls.UI

Public Class pruebaGRID

    Dim oEquipos As Clases_Catalogos.Catalogo_Equipo

    Dim oClasePrueba As clase_prueba_seguridad
    Dim vRowSeleccionada As Integer = 0

    Dim vValorX As Integer = 0
    Dim vValorY As Integer = 0
    Dim vCellSeleccionada As String = ""
    Dim ofrmImportador_Equipo As FrmImportador_Equipo
    Dim oEquipo As Equipo




    Private Sub pruebaGRID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oClasePrueba = New clase_prueba_seguridad

        Dim oCve_Captura As New GridViewDecimalColumn()
        oCve_Captura.Name = "cve"
        oCve_Captura.HeaderText = "cve"
        oCve_Captura.IsVisible = False

        Dim oCve_Equipo As New GridViewDecimalColumn()
        oCve_Equipo.Name = "cve_Equipo"
        oCve_Equipo.HeaderText = "cve_Equipo"
        oCve_Equipo.IsVisible = False

        Dim oNombre_Equipo As New GridViewCommandColumn
        oNombre_Equipo.Name = "Nombre_Equipo"
        oNombre_Equipo.HeaderText = "Nombre_Equipo"
        oNombre_Equipo.Width = 250
        Dim oMes_Afectado As New GridViewDateTimeColumn()
        oMes_Afectado.Name = "Mes_Afectado"
        oMes_Afectado.HeaderText = "Mes_Afectado"

        oMes_Afectado.Format = DateTimePickerFormat.Custom
        oMes_Afectado.CustomFormat = "d"
        oMes_Afectado.FormatString = "{0: MMMM.yyyy}" ';   / / mes name.year day.long
        oMes_Afectado.Width = 300

        Me.dgvDatos.Columns.Add(oCve_Captura)
        Me.dgvDatos.Columns.Add(oCve_Equipo)
        Me.dgvDatos.Columns.Add(oNombre_Equipo)
        Me.dgvDatos.Columns.Add(oMes_Afectado)

        Dim oCve_Captura_Windows As New DataGridViewTextBoxColumn
        oCve_Captura_Windows.Name = "cve"
        oCve_Captura_Windows.HeaderText = "cve"
        oCve_Captura_Windows.Visible = False

        Dim oCve_Equipo_Windows As New DataGridViewTextBoxColumn()
        oCve_Equipo_Windows.Name = "cve_Equipo"
        oCve_Equipo_Windows.HeaderText = "cve_Equipo"
        oCve_Equipo_Windows.Visible = False

        Dim oNombre_Equipo_Windows As New DataGridViewButtonColumn
        oNombre_Equipo_Windows.Name = "Nombre_Equipo"
        oNombre_Equipo_Windows.HeaderText = "Nombre_Equipo"
        oNombre_Equipo_Windows.Width = 250

        Dim oMes_Afectado_Windows As New DataGridViewTextBoxColumn()
        oMes_Afectado_Windows.Name = "Mes_Afectado"
        oMes_Afectado_Windows.HeaderText = "Mes_Afectado"


        Me.dgvDatosWindows.Columns.Add(oCve_Captura_Windows)
        Me.dgvDatosWindows.Columns.Add(oCve_Equipo_Windows)
        Me.dgvDatosWindows.Columns.Add(oNombre_Equipo_Windows)
        Me.dgvDatosWindows.Columns.Add(oMes_Afectado_Windows)


        Dim vDTTipos_Incidentes As DataTable
        vDTTipos_Incidentes = oClasePrueba.Obtener_Tipos_Incidentes


        If IsNothing(vDTTipos_Incidentes) = False Then
            For Each oDR As DataRow In vDTTipos_Incidentes.Rows
                Dim oDescripcion_Incidente As New GridViewDecimalColumn()

                oDescripcion_Incidente.Name = oDR("descripcion")
                oDescripcion_Incidente.HeaderText = oDR("descripcion")
                oDescripcion_Incidente.Width = 150
                Me.dgvDatos.Columns.Add(oDescripcion_Incidente)
            Next

        End If
        

        '---------------------------------- Buscar Datos Detalle Registros Seguridad
        Dim vDTCapturas As DataTable
        Dim vDTDetalleCaptura As DataTable
        Dim vRecorrido As Integer = 0
        vDTCapturas = oClasePrueba.Obtener_Registros_Seguridad

        If IsNothing(vDTCapturas) = False Then
            If IsNothing(vDTTipos_Incidentes) = False Then
                Dim vValores(vDTTipos_Incidentes.Rows.Count - 1) As Integer

                For Each vdr As DataRow In vDTCapturas.Rows
                    vDTDetalleCaptura = oClasePrueba.Obtener_Detalle_Registros_Seguridad(vdr("cve"))
                    If vDTDetalleCaptura.Rows.Count > 0 Then
                        For Each vDR_Detalle As DataRow In vDTDetalleCaptura.Rows
                            vRecorrido = 0
                            For Each vDR_Tipo_Incidente As DataRow In vDTTipos_Incidentes.Rows
                                If vDR_Tipo_Incidente("descripcion") = vDR_Detalle("Incidente") Then
                                    vValores(vRecorrido) = vDR_Detalle("cantidad")
                                Else
                                    If vValores(vRecorrido) = 0 Or IsNothing(vValores(vRecorrido)) Then
                                        vValores(vRecorrido) = 0
                                    End If
                                End If
                                vRecorrido = vRecorrido + 1
                            Next
                        Next
                    Else
                        For vcon As Integer = 0 To (vValores.Length - 1)
                            vValores(vcon) = 0
                        Next vcon
                    End If


                    Dim vObjeto(4 + (vValores.Length - 1)) As Object
                    Dim vCont_Detalle As Integer = 0

                    vObjeto(0) = vdr("cve")
                    vObjeto(1) = vdr("cve_equipo")
                    vObjeto(2) = vdr("equipo")
                    vObjeto(3) = vdr("mes_afectado")

                    For vcon As Integer = 4 To (4 + (vValores.Length - 1))
                        vObjeto(vcon) = vValores(vCont_Detalle)
                        vCont_Detalle = vCont_Detalle + 1
                    Next vcon
                    '---------------------------------- Agregar Datos al DataGrid
                    dgvDatos.Rows.Add(vObjeto)

                Next
            End If
        End If



    End Sub




    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

    End Sub

    Private Sub dgvDatos_CellEndEdit(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvDatos.CellEndEdit
        If vRowSeleccionada = 0 Then
            vRowSeleccionada = e.RowIndex
        End If
    End Sub




    Private Sub dgvDatos_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                vRowSeleccionada = 0
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                vRowSeleccionada = dgvDatos.CurrentRow.Cells("CVE").Value
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try


        If vRowSeleccionada <> 0 Then


        Else

        End If




    End Sub

    Private Sub dgvDatos_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvDatos.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                vRowSeleccionada = dgvDatos.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
                vRowSeleccionada = dgvDatos.CurrentRow.Cells("CVE").Value 'dgvRegistros.CurrentRow.Index
            End If
        Catch ex As Exception
            If ex.TargetSite.MetadataToken.ToString = "100670847" Then
                vRowSeleccionada = 0
            End If
        End Try
    End Sub

    Private Sub dgvDatos_CellClick(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvDatos.CellClick

        Try

            vCellSeleccionada = dgvDatos.Rows(vRowSeleccionada).Cells("Nombre_Equipo").ColumnInfo.Name
            If e.ColumnIndex = dgvDatos.Rows(vRowSeleccionada).Cells("Nombre_Equipo").ColumnInfo.Index Then
                ofrmImportador_Equipo = New FrmImportador_Equipo
                oEquipo = New Equipo
                ofrmImportador_Equipo.ShowDialog()
                oEquipo.Cve_Equipo = ofrmImportador_Equipo.vRetorno_CVE_TIPO_USUARIO
                oEquipo.Cargar()

                If vRowSeleccionada = 0 Then
                    dgvDatos.Rows(e.RowIndex).Cells("cve_Equipo").Value = oEquipo.Cve_Equipo
                    dgvDatos.Rows(e.RowIndex).Cells("Nombre_Equipo").Value = oEquipo.Equipo

                Else
                    dgvDatos.Rows(vRowSeleccionada - 1).Cells("cve_Equipo").Value = oEquipo.Cve_Equipo
                    dgvDatos.Rows(vRowSeleccionada - 1).Cells("Nombre_Equipo").Value = oEquipo.Equipo
                End If


                'MsgBox("Celda seleccionada: " & vCellSeleccionada)
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDatos_RowValidated(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.RowValidatedEventArgs) Handles dgvDatos.RowValidated

    End Sub

    Private Sub dgvDatos_CreateRow(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCreateRowEventArgs) Handles dgvDatos.CreateRow
        vRowSeleccionada = e.RowInfo.Index
    End Sub

    Private Sub dgvDatos_CreateRowInfo(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCreateRowInfoEventArgs) Handles dgvDatos.CreateRowInfo
        vRowSeleccionada = e.RowInfo.Index
    End Sub
End Class