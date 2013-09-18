Imports CapaNegocios
Imports System.Transactions

Public Class frmTiempo_Ciclo
    Dim vAdd_Registrar As Boolean = True
    Dim vCve_User As String = ""

    Sub New(Optional ByVal vRegistrar As Boolean = True, Optional ByVal cve_Usuario_registro As String = "")
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vAdd_Registrar = vRegistrar
        vCve_User = cve_Usuario_registro
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

#Region "Variables y Objetos"
    Public vId_Publico As Long = 0
    Dim oTiempo_Ciclo As TC ''objeto con datos nuevos, El TC es nuevo dentro de la BD
    Dim oTiempo_Ciclo_A_MODIFICAR As TC
    Dim oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES As TC '' Objeto con datos en el que La linea y el modelo en TC ya exixte, este cambia a estatus=0

    Dim vEmpleado As String = ""
    Dim vFecha As DateTime = Date.Now
    Dim vSeleccion_Modelo As Boolean = False
    Dim vSeleccion_Linea As Boolean = False
    Dim vValidado_Modelo_En_Linea As Boolean = False
    Dim vValidado_Modelo_Y_Linea_En_TC As Boolean = False
    Dim vModelo_Seleccionado As String = "0"
#End Region

#Region "Validaciones"
    Private Sub Controles_Registro_Nuevo(ByVal vEs_Registro_Nuevo As Boolean)
        If vEs_Registro_Nuevo = True Then
            'btnRegistrar.Visible = True
            btnImportar_Linea.Enabled = True
            btnImportar_Modelo.Enabled = True
            'btnModificar.Visible = False
            'btnDarBaja.Enabled = False
        Else
            'btnRegistrar.Visible = False
            btnImportar_Linea.Enabled = False
            btnImportar_Modelo.Enabled = False
            'btnModificar.Visible = True
            'btnDarBaja.Enabled = True
        End If
    End Sub

    Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar.Click


        'If oModelo.Validar_Exixtencia_De_Modelo_En_Linea(oTiempo_Ciclo.cve_modelo, oTiempo_Ciclo.cve_linea) = True Then
        '    MsgBox("El modelo en Linea ya exixte")
        '    vValidado_Modelo_En_Linea = False
        'Else
        '    MsgBox("El modelo en Linea No exixte")
        '    vValidado_Modelo_En_Linea = True
        'End If
        'If oTiempo_Ciclo.Validar_Exixtencia_LINEA_MODELO_EN_TC(oTiempo_Ciclo.cve_linea, oTiempo_Ciclo.cve_modelo) = True Then
        '    MsgBox("La linea y el modelo en TC ya exixte")
        '    vValidado_Modelo_Y_Linea_En_TC = False
        '    'oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES = New TC
        '    oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES.Cargar_TC(oTiempo_Ciclo.cve_linea, oTiempo_Ciclo.cve_modelo)
        'Else
        '    MsgBox("La linea y el modelo en TC no exixte")
        '    vValidado_Modelo_Y_Linea_En_TC = True
        'End If
        'btnRegistrar.Enabled = True

        'If vValidado_Modelo_En_Linea = True And vValidado_Modelo_Y_Linea_En_TC = True Then
        '    btnRegistrar.Enabled = True
        'Else
        '    btnRegistrar.Enabled = False
        'End If
    End Sub

    Private Sub Controles_Permisos(ByVal vAdd As Boolean)
        If vAdd = True Then
            Me.btnRegistrar.Enabled = True
            'Me.btnModifica.Enabled = True
        Else
            Me.btnRegistrar.Enabled = False            
            nudPiezas_Hora.ReadOnly = True
            btnImportar_Linea.Enabled = False
            btnImportar_Modelo.Enabled = False
            btnRegistrar.Enabled = False
        End If       
        'If vAdd = False Then
        '    nudPiezas_Hora.ReadOnly = True
        '    btnImportar_Linea.Enabled = False
        '    btnImportar_Modelo.Enabled = False
        '    btnRegistrar.Enabled = False
        'End If
    End Sub

#End Region

#Region "Importadores"
    Private Sub btnImportar_Modelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Modelo.Click
        Dim vfrmImportador_Modelo As New frmImportador_Modelo
        vfrmImportador_Modelo.ShowDialog()
        If vfrmImportador_Modelo.vRetorno_CVE_Modelo <> 0 Then
            oTiempo_Ciclo.cve_modelo = vfrmImportador_Modelo.vRetorno_CVE_Modelo
            txtModelo.Text = oTiempo_Ciclo.Nombre_Modelo
            vModelo_Seleccionado = oTiempo_Ciclo.cve_modelo
            vSeleccion_Modelo = True
        End If
    End Sub

    Private Sub btnImportar_Linea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar_Linea.Click
        Dim vfrmImportador_Linea As New frmImportador_Linea(Long.Parse(vModelo_Seleccionado))
        vfrmImportador_Linea.ShowDialog()
        If vfrmImportador_Linea.vRetorno_CVE_Linea <> 0 Then
            oTiempo_Ciclo.cve_linea = vfrmImportador_Linea.vRetorno_CVE_Linea
            txtLinea.Text = oTiempo_Ciclo.Nombre_Linea
            vSeleccion_Linea = True
        End If
        If vSeleccion_Modelo = True And vSeleccion_Linea = True Then
            btnValidar.Enabled = True
            'btnValidar_Modelo_Linea_En_TC.Enabled = True
        End If

    End Sub
#End Region

#Region "Eventos Load, Salir y Registrar"
    Private Sub frmTiempo_Ciclo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''La Siguiente Linea solo es para hacer pruebas sobre un Tiempo_Ciclo()
        ''Borrar si requiere hacer registro nuevo
        'vId_Publico = 0
        Controles_Permisos(vAdd_Registrar)
        If Convert.ToInt64(vId_Publico) <> 0 Then
            oTiempo_Ciclo = New TC
            oTiempo_Ciclo_A_MODIFICAR = New TC
            oTiempo_Ciclo.cve_TC = vId_Publico
            oTiempo_Ciclo_A_MODIFICAR.cve_TC = vId_Publico
            oTiempo_Ciclo.Cargar()
            oTiempo_Ciclo_A_MODIFICAR.Cargar()
            Controles_Registro_Nuevo(False)
            If oTiempo_Ciclo_A_MODIFICAR.Estatus = "INACTIVO" Then
                Controles_Registro_Inactivo(True)
            End If
        Else
            oTiempo_Ciclo = New TC
            oTiempo_Ciclo.Estatus = "1"
            oTiempo_Ciclo.Fecha = vFecha
            vEmpleado = vCve_User
            oTiempo_Ciclo.Codigo_Empleado = vEmpleado
            Controles_Registro_Nuevo(True)
            'btnRegistrar.Visible = True
            'btnRegistrar.Enabled = True
        End If

        SetBindings()
        Me.Show()       
        Me.nudPiezas_Hora.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If MsgBox("El Tiempo Ciclo se remplazara con los Datos Capturados, ¿Desea Continuar?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES = New TC
            oTiempo_Ciclo.cve_TC = 0
            oTiempo_Ciclo.Estatus = "1"
            oTiempo_Ciclo.piezas_por_hora = nudPiezas_Hora.Value
            Using scope As New TransactionScope()
                Try

                    If oTiempo_Ciclo.Validar_MODELO_LINEA_EN_TC_COMPONENTE(oTiempo_Ciclo.cve_linea, oTiempo_Ciclo.cve_modelo) = False Then
                        MsgBox("La Linea y el Modelo no son del mismo Componente, Verifique.")
                    Else
                        'If MsgBox("La Linea y el Modelo no son del mismo Componente, ¿Desea Continuar?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                        If oTiempo_Ciclo.Validar_Exixtencia_LINEA_MODELO_EN_TC(oTiempo_Ciclo.cve_linea, oTiempo_Ciclo.cve_modelo) = True Then
                            'MsgBox("La linea y el modelo en TC ya exixte")
                            vValidado_Modelo_Y_Linea_En_TC = False
                            'oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES = New TC
                            oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES.Cargar_TC(oTiempo_Ciclo.cve_linea, oTiempo_Ciclo.cve_modelo)
                        Else
                            'MsgBox("La linea y el modelo en TC no exixte")
                            vValidado_Modelo_Y_Linea_En_TC = True
                        End If
                        'btnRegistrar.Enabled = True
                        oTiempo_Ciclo.Registrar()
                        If vValidado_Modelo_Y_Linea_En_TC = False Then
                            'If MsgBox("El Tiempo Ciclo se remplazara con los Datos Capturados, ¿Desea Continuar?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                            If oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES IsNot Nothing Then
                                oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES.Estatus = "0"
                                oTiempo_Ciclo_A_MODIFICAR_ENCONTRADO_VALIDACIONES.Registrar()
                                MsgBox("Se Registro correctamente")
                            Else
                                oTiempo_Ciclo_A_MODIFICAR.Estatus = "0"
                                oTiempo_Ciclo_A_MODIFICAR.Registrar()
                                MsgBox("Se Registro correctamente")
                            End If
                            'End If
                        Else
                            'oTiempo_Ciclo_A_MODIFICAR.Estatus = "0"
                            'oTiempo_Ciclo_A_MODIFICAR.Registrar()
                            MsgBox("Se Registro correctamente")
                        End If
                        'Else

                        'End If
                    End If
                    scope.Complete()
                Catch ex As Exception

                End Try
            End Using
            Me.Close()
        End If
    End Sub
#End Region

#Region "Metodos"
    Private Sub Controles_Registro_Inactivo(ByVal vEs_Registro_Inactivo As Boolean)
        If vEs_Registro_Inactivo = True Then
            btnRegistrar.Enabled = False
            nudPiezas_Hora.ReadOnly = True
        End If
    End Sub
#End Region
    
#Region "SetBindings"
    Private Sub SetBindings()
        Me.nudPiezas_Hora.DataBindings.Clear()
        Me.txtLinea.DataBindings.Clear()
        Me.txtModelo.DataBindings.Clear()
        Me.txtEmpleado.DataBindings.Clear()
        Me.dtpFecha.DataBindings.Clear()
        Me.txtEstatus.DataBindings.Clear()

        Me.nudPiezas_Hora.DataBindings.Add("Value", oTiempo_Ciclo, "piezas_por_hora")
        Me.txtLinea.DataBindings.Add("Text", oTiempo_Ciclo, "Nombre_Linea")
        Me.txtModelo.DataBindings.Add("Text", oTiempo_Ciclo, "Nombre_Modelo")
        Me.txtEmpleado.DataBindings.Add("Text", oTiempo_Ciclo, "Codigo_Empleado")
        Me.dtpFecha.DataBindings.Add("Value", oTiempo_Ciclo, "fecha")
        Me.txtEstatus.DataBindings.Add("Text", oTiempo_Ciclo, "Estatus")
    End Sub
#End Region

    


End Class