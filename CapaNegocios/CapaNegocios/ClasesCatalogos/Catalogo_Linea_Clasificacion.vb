Imports CapaDatos
Namespace Clases_Catalogos
    Public Class Catalogo_Linea_Clasificacion
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
        Dim oClasificacion_Linea As New Linea_Clasificacion

        Private vL_Linea As List(Of Linea_Clasificacion)
        Public Property L_Linea() As List(Of Linea_Clasificacion)
            Get
                If vL_Linea Is Nothing Then
                    'Cargo documentos
                    Me.L_Linea = New List(Of Linea_Clasificacion)

                    Dim oEq As DataTable = oClasificacion_Linea.obtiene_tabla

                    If oEq IsNot Nothing Then
                        Dim oLinea As Linea_Clasificacion = Nothing
                        For Each row As DataRow In oEq.Rows
                            oLinea = New Linea_Clasificacion
                            oLinea.cve_line_clasificacion = row("cve_linea_clasificacion")
                            oLinea.nombre = row("nombre")
                            oLinea.descripcion = row("descripcion")
                            oLinea.estatus = row("estatus")
                            oLinea.Cargar()
                            Me.vL_Linea.Add(oLinea)
                        Next
                    End If

                End If
                Return Me.vL_Linea
            End Get
            Set(ByVal value As List(Of Linea_Clasificacion))
                Me.vL_Linea = value
            End Set
        End Property
        Public Function Obtener_Lineas() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("select * from linea_clasificacion " &
                                   " where estatus='1'")
            If vDT IsNot Nothing Then
            Else
                vDT = Nothing
            End If
            Return vDT
        End Function
    End Class
End Namespace

