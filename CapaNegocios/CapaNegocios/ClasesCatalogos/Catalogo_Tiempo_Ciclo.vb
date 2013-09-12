Imports CapaDatos
Namespace Clases_Catalogos

    Public Class Catalogo_Tiempo_Ciclo
        Dim cadena_conexion As New CapaDatos.conexiones
        Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

        Private vL_TC As List(Of TC)
        Public Property L_TC() As List(Of TC)
            Get
                If vL_TC Is Nothing Then
                    'Cargo documentos
                    Me.L_TC = New List(Of TC)
                    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
                    Dim oEq As DataTable = oBD.ObtenerTabla("SELECT cve_TC  FROM TC WHERE estatus='1'")
                    If oEq IsNot Nothing Then
                        Dim oTC As TC = Nothing
                        For Each row As DataRow In oEq.Rows
                            oTC = New TC
                            oTC.cve_TC = row("cve_TC")
                            oTC.Cargar()
                            Me.vL_TC.Add(oTC)
                        Next
                    End If
                End If
                Return Me.vL_TC
            End Get
            Set(ByVal value As List(Of TC))
                Me.vL_TC = value
            End Set
        End Property




        Public Function Obtener_Tiempos_Ciclos() As DataTable
            Dim vDT As DataTable
            vDT = oBD.ObtenerTabla("Select cve_TC, piezas_por_hora, linea as Nombre_Linea, descripcion as Nombre_Modelo, " & _
                                   "TiemCiclo.estatus, fecha, cod_empleado as Codigo_Empleado,TiemCiclo.cve_linea,TiemCiclo.cve_modelo, m.np_gkn as NumParte " & _
                                   "FROM TC TiemCiclo JOIN linea l ON l.cve_linea=TiemCiclo.cve_linea " & _
                                   "JOIN modelo m on m.cve_modelo=TiemCiclo.cve_modelo " & _
                                   "WHERE TiemCiclo.estatus='1'")
            If vDT IsNot Nothing Then

            Else
                vDT = Nothing
            End If
            Return vDT
        End Function
    End Class
End Namespace