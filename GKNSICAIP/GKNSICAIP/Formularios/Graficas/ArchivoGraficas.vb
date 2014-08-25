Imports Microsoft.Office.Interop 'referencia para leer excel
Imports System.Security.Principal

Public Class ArchivoGraficas
    Dim usuario As String = ""
    Private Exl As Excel.Application 'creacion de objeto de clase excel

    Public Sub Genera_EXL()
        Exl = New Excel.Application 'instancia del la clase excel
    End Sub

    Public Sub Abre_Graficas()
        usuario = Mid(WindowsIdentity.GetCurrent.Name, 11).ToUpper
        Exl = New Excel.Application
        Exl.Workbooks.Open("C:\Users\Patricia\Documents\Graficador\PDFGrafica.xlsm")
        Exl.Visible = False
    End Sub
    Public Sub Cierra_Graficas()
        Try
            Exl.Workbooks("PDFGrafica.xlsm").Close(False)
        Catch
            MsgBox("no cerro el archivo")
        End Try
    End Sub
    Public Sub Exporta_Graficas_PDF(ByVal ruta As String)
        Try
            Exl.Run("convierte_2", "C:\Users\Patricia\Documents\Graficador", ruta)
        Catch
        End Try
    End Sub
    Public Sub Inserta_datos_grafica(ByVal celda As String, ByVal texto As String)
        Exl.Workbooks("PDFGrafica.xlsm").Sheets("Hoja1").activate()
        Exl.Workbooks("PDFGrafica.xlsm").ActiveSheet.range(celda).value = texto
    End Sub
End Class