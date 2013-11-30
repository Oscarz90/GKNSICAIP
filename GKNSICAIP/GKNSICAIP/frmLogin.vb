Imports CapaNegocios

Public Class frmLogin
    Dim oLogin As Login


#Region "ATRIBUTOS"
    Private vCodEmpleado As String ''----Mantiene el Cve del Empleado(Solo los 6 caracteres)
    Private vIdEquipo As Integer ''----Id del Equipo del Empleado
    Private vTipoTlatoani As Integer    
#End Region

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp        
        Validar_Ingreso_Empleado(e)
    End Sub

    ''' <summary>
    ''' En caso de que el usuario sea valido, abre el tlatoani correspondiente
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Validar_Ingreso_Empleado(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            oLogin = New Login
            Try
                vCodEmpleado = oLogin.Obtener_Cve_Empleado(txtCode.Text)
                If oLogin.Empleado_Valido(vCodEmpleado) = True Then
                    txtCode.Text = ""
                    oLogin.Cargar_Empleado(vCodEmpleado)
                    vIdEquipo = oLogin.Obtener_Id_Equipo(oLogin.Equipo_Empleado)
                    ''VALIDAR LAS LINEAS PILOTO QUE SOLO PARTICIPARAN
                    vTipoTlatoani = Nothing
                    'If oLogin.Valida_Equipo_Piloto(oLogin.Equipo_Empleado) = 1 Then
                    vTipoTlatoani = oLogin.Obtener_Tipo_Tlatoani(oLogin.Equipo_Empleado)
                    'Else
                    '    MsgBox("EL SISTEMA ESTA DISPONIBLE SOLO PARA LINEAS PILOTO!!!")
                    'End If

                    'aqui seleccionar el form que se debe abrir
                    Select Case vTipoTlatoani
                        Case 1 'Almacen de Forja'
                            'frmCapturaAlmacenForja.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaAlmacenForja.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para ALMACEN FORJA")
                        Case 2 'Carburizado'
                            'frmCapturaCarburizado.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaCarburizado.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para CARBURIZADO")
                        Case 3 'CDM'
                            'frmCapturaCDM.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaCDM.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para CDM")
                        Case 4 'Calidad Forja'
                            'frmCapturaCalidadForja.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaCalidadForja.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para CALIDAD FORJA")
                        Case 5 'Ensamble'
                            frmProduccion.set_Datos_Equipo(vIdEquipo, oLogin.Equipo_Empleado, oLogin.Nombre_Empleado, vCodEmpleado)
                            frmProduccion.ShowDialog()
                            frmProduccion.Dispose()
                        Case 6 'Mantto. Correctivo'
                            'frmCapturaManttoCorrectivo.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaManttoCorrectivo.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para MANTTO. CORRECTIVO")
                        Case 7 'Mantto. Forja'
                            'frmCapturaManttoForja.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaManttoForja.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para MANTTO. FORJA")
                        Case 8 'Mantto.Predictivo'
                            ''frmCapturaManttoPredictivo.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            ''frmCapturaManttoPredictivo.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para MANTTO. PREDICTIVO")
                        Case 9 'Mantto.Preventivo'
                            'frmCapturaManttoPreventivo.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaManttoPreventivo.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para MANTTO. PREVENTIVO")
                        Case 10 'Produccion'
                            frmProduccion.set_Datos_Equipo(vIdEquipo, oLogin.Equipo_Empleado, oLogin.Nombre_Empleado, vCodEmpleado)
                            frmProduccion.ShowDialog()
                            frmProduccion.Dispose()
                        Case 11 'Paletizado Ensamble'
                            'frmCapturaPaletizado.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaPaletizado.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para PALETIZADO")
                        Case 12 'Presseting'
                            ''detalle = 19 SG Servicios Generales 
                            'frmCapturaPresetting.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaPresetting.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para PRESETTING")
                        Case 13 'Refacciones Ensamble'
                            'frmCapturaRefacciones.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaRefacciones.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para REFACCIONES")
                        Case 14 'Subemsambles'
                            'frmCapturaSubensambles.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaSubensambles.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para SUBENSAMBLES")
                        Case 15 'Servicios Generales'
                            'frmCapturaCasadeMaquinas.set_Datos_Equipo(idEquipo, equipo_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaCasadeMaquinas.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para CASA DE MAQUINAS (SG)")
                        Case 16 'Taller Herramental'
                            'frmCapturaTallerHerramental.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaTallerHerramental.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para TALLER HERRAMENTAL")
                        Case 17 'Taller Inductores'
                            'frmCapturaTallerInductores.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaTallerInductores.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para TALLER INDUCTORES")
                        Case 18 'Tool Room'
                            'frmCapturaToolRoom.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaToolRoom.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para TOOL ROOM")
                        Case 19 'Forja'
                            frmProduccion.set_Datos_Equipo(vIdEquipo, oLogin.Equipo_Empleado, oLogin.Nombre_Empleado, vCodEmpleado)
                            frmProduccion.ShowDialog()
                            frmProduccion.Dispose()
                        Case 20 'Embolado'
                            'frmCapturaEmbolado.set_Datos_Equipo(idEquipo, cod_empleado, nombre_empleado, cod_empleado)
                            'frmCapturaEmbolado.ShowDialog()
                            MsgBox("Aún no está disponible el formulario de captura para EMBOLADO")
                        Case Else
                            ''MsgBox("Error")
                            MsgBox("EL EMPLEADO NO ES VALIDO ", vbCritical + vbOKOnly, "Error")
                    End Select
                Else
                    MsgBox("EL EMPLEADO NO ES VALIDO", vbExclamation + vbOKOnly + vbDefaultButton1, "Error")
                    txtCode.Text = ""
                    ''Pendiente
                    ''Mandar focus al botón aceptar---------------------------------------------------------------------------------------                    
                End If
            Catch
                MsgBox("EL EMPLEADO NO ES VALIDO ", vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class