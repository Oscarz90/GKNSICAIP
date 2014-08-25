Imports CapaNegocios
Imports Telerik.WinControls.UI

Public Class pruebaGRID



    Dim oClasePrueba As clase_prueba_seguridad
    Dim vRowSeleccionada As Integer = 0

    
    Dim vCellSeleccionada As String = ""
    Dim ofrmImportador_Equipo As FrmImportador_Equipo
    Dim oEquipo As Equipo




    Private Sub pruebaGRID_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        oClasePrueba = New clase_prueba_seguridad

        Dim oCve_Captura As New GridViewDecimalColumn() With {.Name = "cve", .HeaderText = "cve", .IsVisible = False}

        Dim oCve_Equipo As New GridViewDecimalColumn() With {.Name = "cve_Equipo", .HeaderText = "cve_Equipo", .IsVisible = False}

        Dim oNombre_Equipo As New GridViewCommandColumn() With {.Name = "Nombre_Equipo", .HeaderText = "Nombre_Equipo", .Width = 250}
        Dim oMes_Afectado As New GridViewDateTimeColumn() With {.Name = "Mes_Afectado", .HeaderText = "Mes_Afectado", .Format = DateTimePickerFormat.Custom, .CustomFormat = "d", .FormatString = "{0: MMMM.yyyy}", .Width = 300}

        Me.dgvDatos.Columns.Add(oCve_Captura)
        Me.dgvDatos.Columns.Add(oCve_Equipo)
        Me.dgvDatos.Columns.Add(oNombre_Equipo)
        Me.dgvDatos.Columns.Add(oMes_Afectado)

        Dim oCve_Captura_Windows As New DataGridViewTextBoxColumn() With {.Name = "cve", .HeaderText = "cve", .Visible = False}

        Dim oCve_Equipo_Windows As New DataGridViewTextBoxColumn() With {.Name = "cve_Equipo", .HeaderText = "cve_Equipo", .Visible = False}

        Dim oNombre_Equipo_Windows As New DataGridViewButtonColumn() With {.Name = "Nombre_Equipo", .HeaderText = "Nombre_Equipo", .Width = 250}

        Dim oMes_Afectado_Windows As New DataGridViewTextBoxColumn() With {.Name = "Mes_Afectado", .HeaderText = "Mes_Afectado"}


        Me.dgvDatosWindows.Columns.Add(oCve_Captura_Windows)
        Me.dgvDatosWindows.Columns.Add(oCve_Equipo_Windows)
        Me.dgvDatosWindows.Columns.Add(oNombre_Equipo_Windows)
        Me.dgvDatosWindows.Columns.Add(oMes_Afectado_Windows)


        Dim vDTTipos_Incidentes As DataTable = oClasePrueba.Obtener_Tipos_Incidentes


        If IsNothing(vDTTipos_Incidentes) = False Then
            For Each oDR As DataRow In vDTTipos_Incidentes.Rows
                Dim oDescripcion_Incidente As New GridViewDecimalColumn() With {.Name = oDR("descripcion"), .HeaderText = oDR("descripcion"), .Width = 150}
                Me.dgvDatos.Columns.Add(oDescripcion_Incidente)
            Next

        End If


        '---------------------------------- Buscar Datos Detalle Registros Seguridad
        Dim vDTCapturas As DataTable = oClasePrueba.Obtener_Registros_Seguridad
        Dim vDTDetalleCaptura As DataTable
        Dim vRecorrido As Integer = 0

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

    Private Sub dgvDatos_CellEndEdit(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles dgvDatos.CellEndEdit
        If vRowSeleccionada = 0 Then
            vRowSeleccionada = e.RowIndex
        End If
    End Sub




    Private Sub dgvDatos_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvDatos.MouseClick
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


       




    End Sub

    Private Sub dgvDatos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvDatos.MouseUp
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

    Private Sub dgvDatos_CellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles dgvDatos.CellClick

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

    Private Sub dgvDatos_CreateRow(ByVal sender As Object, ByVal e As GridViewCreateRowEventArgs) Handles dgvDatos.CreateRow
        vRowSeleccionada = e.RowInfo.Index
    End Sub

    Private Sub dgvDatos_CreateRowInfo(ByVal sender As Object, ByVal e As GridViewCreateRowInfoEventArgs) Handles dgvDatos.CreateRowInfo
        vRowSeleccionada = e.RowInfo.Index
    End Sub
End Class