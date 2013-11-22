Imports Microsoft.Office.Interop
Imports CapaNegocios
Imports System.Transactions

Public Class FrmImportar_Modelo


    Dim vRuta_Fichero As String
    Private Exl As New Excel.Application 'creacion de objeto de clase excel
    Dim vSiguienteRegistro As Long
    Dim oModelo As Modelo

    Private Sub FrmImportar_Modelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCargar.Enabled = False
        btnValidar_Archivo.Enabled = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSeleccion_Archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccion_Archivo.Click
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

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        Exl.Workbooks.Open(vRuta_Fichero)
        Dim vEncontrado As Boolean = False
        Dim vRecorrido As Long = 2
        oModelo = New Modelo

        Dim vCve_componente As Long = 0
        Dim vCve_clasificacion_modelo As Integer = 2
        Dim vNP_gkn As String = ""
        Dim vDescripcion As String = ""
        Dim vEstatus As String = "1"


        vSiguienteRegistro = Obten_Ultimo_Registro(Exl, 2)
        Using scope As New TransactionScope()
            Try
                While vRecorrido <= vSiguienteRegistro
                    Try

                        vCve_componente = Exl.Range("A" & vRecorrido).Value
                        vNP_gkn = Exl.Range("B" & vRecorrido).Value
                        vDescripcion = Exl.Range("C" & vRecorrido).Value

                        If oModelo.Validar_Existencia_De_Modelo_En_BD(vNP_gkn) = True Then                           
                            Me.Set_Indicentes("El modelo con NP= " & vNP_gkn & " ya existe")
                        Else
                            oModelo.cve_modelo = 0
                            oModelo.cve_componente = vCve_componente
                            oModelo.cve_clasificacion_modelo = vCve_clasificacion_modelo
                            oModelo.np_gkn = vNP_gkn
                            oModelo.descripcion = vDescripcion
                            oModelo.Estatus = vEstatus

                            oModelo.Registrar()
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

    Private Sub btnValidar_Archivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidar_Archivo.Click
        If Valida_Archivo_TC() = True Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Public Sub Set_Indicentes(ByVal Incidente As String) 'agrega un incidente al cuadro de incidentes
        txtIncidentes.Text = txtIncidentes.Text & Incidente & " " & vbCrLf
        Me.Refresh()
    End Sub

    Public Function Valida_Archivo_TC() As Boolean
        Dim hoja_correcta As Boolean
        Try
            Exl.Workbooks.Open(vRuta_Fichero)
            Dim vNombreHoja As String
            vNombreHoja = Exl.Sheets(1).Name()
            hoja_correcta = True
        Catch
            Me.Set_Indicentes("El nombre de la hoja no es el correcto, debe ser 'Hoja1'")
            hoja_correcta = False
            Return False
        End Try
        If hoja_correcta Then
            If Exl.ActiveSheet.range("A1").value <> "cve_componente" Then
                Me.Set_Indicentes("No esta bien el encabezado de la columna A1, debe ser cve_componente")
                Return False
            Else
                If Exl.ActiveSheet.range("B1").value <> "numero_parte" Then
                    Me.Set_Indicentes("No esta bien el encabezado de la columna B1, debe ser numero_parte")
                    Return False
                Else
                    If Exl.ActiveSheet.range("C1").value <> "descripcion" Then
                        Me.Set_Indicentes("No esta bien el encabezado de la columna C1, debe ser descripcion")
                        Return False
                    Else
                        Me.Set_Indicentes("Archivo validado CORRECTAMENTE")
                        Exl.Workbooks.Close()
                        Return True
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
            If oArchivo.Range("A" & vIndice).Value <> Nothing Then
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
