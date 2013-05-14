Imports CapaNegocios
Imports Microsoft.Office.Interop 'referencia para leer excel

Public Class ArchivoGraficas
    Private Exl As Excel.Application 'creacion de objeto de clase excel
    'Private BDat As ClaseBD

    Public Sub Genera_EXL()
        Exl = New Excel.Application 'instancia del la clase excel
    End Sub

    Public Sub Abre_Graficas()
        Exl = New Excel.Application
        Exl.Workbooks.Open(Application.StartupPath & "\Graficador\PDFGrafica.xlsm")
        Exl.Visible = False
    End Sub
    Public Sub Cierra_Graficas()
        Try
            Exl.Workbooks("PDFGrafica.xlsm").Close(False)
        Catch
        End Try
    End Sub
    Public Sub Exporta_Graficas_PDF(ByVal ruta As String)
        Try
            Exl.Run("convierte_2", Application.StartupPath & "\Graficador", ruta)
        Catch
        End Try
    End Sub
    Public Sub Inserta_datos_grafica(ByVal celda As String, ByVal texto As String)
        Exl.Workbooks("PDFGrafica.xlsm").Sheets("Hoja1").activate()
        Exl.Workbooks("PDFGrafica.xlsm").ActiveSheet.range(celda).value = texto
    End Sub
End Class
