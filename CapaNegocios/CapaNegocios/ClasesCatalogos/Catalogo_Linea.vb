Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Linea
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

        Private vL_Linea As List(Of Linea)
        Public Property L_Linea() As List(Of Linea)
            Get
                If vL_Linea Is Nothing Then
                    'Cargo documentos
                    Me.L_Linea = New List(Of Linea)
                    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
                    Dim oEq As DataTable = oBD.ObtenerTabla("SELECT cve_linea FROM Linea")
                    If oEq IsNot Nothing Then
                        Dim oLinea As Linea = Nothing
                        For Each row As DataRow In oEq.Rows
                            oLinea = New Linea
                            oLinea.cve_linea = row("cve_linea")
                            oLinea.Cargar()
                            Me.vL_Linea.Add(oLinea)
                        Next
                    End If
                End If
                Return Me.vL_Linea
            End Get
            Set(ByVal value As List(Of Linea))
                Me.vL_Linea = value
            End Set
        End Property


        Public Function Obtener_Lineas() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("select cve_linea, linea, componente,tpcdm from Linea l join componente c on l.cve_componente= c.cve_componente")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function
    End Class
End Namespace
