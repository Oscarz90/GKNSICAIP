Imports Microsoft.Office.Interop
Imports CapaNegocios
Imports System.Transactions

Public Class FrmImportar_TC

    Dim vRuta_Fichero As String
    Private Exl As New Excel.Application 'creacion de objeto de clase excel
    Dim vSiguienteRegistro As Long
    Dim oTC As TC
    'Dim oBD As New BD

    Private Sub FrmImportar_TC_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        btnCargar.Enabled = False
        btnValidar_Archivo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCargar.Click
        Exl.Workbooks.Open(vRuta_Fichero)
        Dim vRecorrido As Long = 2
        oTC = New TC
        Dim vPzas_por_Hora As Integer = 0
        Dim vCve_linea As Long = 0
        Dim vCve_Modelo As Long = 0
        Dim vCod_Empleado As String = ""
        Dim vFecha As DateTime = Date.Now
        Dim vEstatus As String = ""


        vSiguienteRegistro = Obten_Ultimo_Registro(Exl, 2)
        Using scope As New TransactionScope()
            Try
                While vRecorrido <= vSiguienteRegistro
                    Try
                        Format(vFecha, "yyyy/MM/dd")
                        vPzas_por_Hora = Exl.Range("A" & vRecorrido).Value
                        vCve_linea = Exl.Range("B" & vRecorrido).Value
                        vCve_Modelo = Exl.Range("C" & vRecorrido).Value
                        vCod_Empleado = Exl.Range("D" & vRecorrido).Value
                        vFecha = Exl.Range("E" & vRecorrido).Value
                        vEstatus = Exl.Range("F" & vRecorrido).Value

                        Me.Set_Indicentes(String.Format("Select * from TC Where cve_linea={0} and cve_modelo={1}", vCve_linea, vCve_Modelo))
                        If oTC.Validar_Exixtencia_LINEA_MODELO_EN_TC(vCve_linea, vCve_Modelo) = True Then
                            ''Cargo el TC existente para registrarlo como Inactivo
                            oTC.cve_TC = oTC.vCve_TC_Existe
                            oTC.Cargar()
                            oTC.Estatus = "0"
                            oTC.Registrar()

                            ''Cargo el Objeto oTC con los Datos Obtenidos de Excel para registrar el TC Nuevo
                            oTC.cve_TC = 0
                            oTC.piezas_por_hora = vPzas_por_Hora
                            oTC.cve_linea = vCve_linea
                            oTC.cve_modelo = vCve_Modelo
                            oTC.Codigo_Empleado = vCod_Empleado
                            oTC.Fecha = vFecha
                            oTC.Estatus = "1"
                            oTC.Registrar()
                        Else
                            oTC.cve_TC = 0
                            oTC.piezas_por_hora = vPzas_por_Hora
                            oTC.cve_linea = vCve_linea
                            oTC.cve_modelo = vCve_Modelo
                            oTC.Codigo_Empleado = vCod_Empleado
                            oTC.Fecha = vFecha
                            oTC.Estatus = "1"
                            oTC.Registrar()
                        End If
                    Catch ex As Exception
                        Me.Set_Indicentes("Ocurrio un error en la lectura del archivo")
                    End Try

                    vRecorrido = vRecorrido + 1
                End While
                scope.Complete()
            Catch ex As Exception
                Me.Set_Indicentes("Ocurrio un error en la lectura del archivo, No se registraran Cambios")
            End Try
        End Using
        Exl.Workbooks.Close()
        Me.btnSeleccion_Archivo.Enabled = False
        Me.btnValidar_Archivo.Enabled = False
        Me.btnCargar.Enabled = False
        Me.Set_Indicentes("Carga de TC Exitosa")
    End Sub

    Private Sub btnValidar_Archivo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnValidar_Archivo.Click
        If Valida_Archivo_TC() = True Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Private Sub btnSeleccion_Archivo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSeleccion_Archivo.Click
        OpenFileDialog1.Filter =
          "Archivos de Excel 97-2003 (*.xls)|*.xls|" & _
          "Archivos de Excel 2007-2010 (*.xlsx)|*.xlsx"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.CheckFileExists = False
        OpenFileDialog1.Title = "Selección de fichero"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            vRuta_Fichero = OpenFileDialog1.FileName
            txtRuta_Archivo.Text = vRuta_Fichero
            btnValidar_Archivo.Enabled = True
            Me.Set_Indicentes("Archivo seleccionado: " & vRuta_Fichero)
        End If
    End Sub

    Public Sub Set_Indicentes(ByVal Incidente As String) 'agrega un incidente al cuadro de incidentes
        txtIncidentes.Text = String.Format("{0}{1} {2}", txtIncidentes.Text, Incidente, vbCrLf)
        Me.Refresh()
    End Sub

    Public Function Valida_Archivo_TC() As Boolean
        Dim hoja_correcta As Boolean
        Try

            Exl.Workbooks.Open(vRuta_Fichero)
            Dim vNombreHoja As String = Exl.Sheets(1).Name()
            hoja_correcta = True
        Catch
            Me.Set_Indicentes("El nombre de la hoja no es el correcto, debe ser 'Hoja1'")
            hoja_correcta = False
            Return False
        End Try
        If hoja_correcta Then

            If Exl.ActiveSheet.range("A1").value <> "piezas_por_hora" Then
                Me.Set_Indicentes("No esta bien el encabezado de la columna A1, debe ser piezas_por_hora")
                Return False
            Else
                If Exl.ActiveSheet.range("B1").value <> "cve_linea" Then
                    Me.Set_Indicentes("No esta bien el encabezado de la columna B1, debe ser cve_linea")
                    Return False
                Else
                    If Exl.ActiveSheet.range("C1").value <> "cve_modelo" Then
                        Me.Set_Indicentes("No esta bien el encabezado de la columna C1, debe ser cve_modelo")
                        Return False
                    Else
                        If Exl.ActiveSheet.range("D1").value <> "cod_empleado" Then
                            Me.Set_Indicentes("No esta bien el encabezado de la columna D1, debe ser cod_empleado")
                            Return False
                        Else
                            If Exl.ActiveSheet.range("E1").value <> "fecha" Then
                                Me.Set_Indicentes("No esta bien el encabezado de la columna E1, debe ser fecha")
                                Return False
                            Else
                                If Exl.ActiveSheet.range("F1").value <> "estatus" Then
                                    Me.Set_Indicentes("No esta bien el encabezado de la columna F1, debe ser estatus")
                                    Return False
                                Else
                                    Me.Set_Indicentes("Archivo validado CORRECTAMENTE")
                                    Exl.Workbooks.Close()
                                    Return True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            Return False
        End If
    End Function

    Private Function Obten_Ultimo_Registro(ByVal oArchivo As Excel.Application, Optional ByVal vComenzar_Registro As Long = 1) As Long
        Dim vIndice As Long = vComenzar_Registro
        Dim vFinal As Boolean = False
        While vFinal = False
            If oArchivo.Range("B" & vIndice).Value <> Nothing Then
                vIndice = vIndice + 1
            Else
                vFinal = True
                vIndice = vIndice - 1
            End If
        End While
        oArchivo = Nothing
        Return vIndice
    End Function


End Class
