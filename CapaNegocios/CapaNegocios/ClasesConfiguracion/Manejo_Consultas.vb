Imports CapaDatos
Public Class Manejo_Consultas

    Dim cadena_conexion As New conexiones
    Private vL_Componente As List(Of Componente)
    Public Property L_Componente() As List(Of Componente)
        Get
            If vL_Componente Is Nothing Then
                'Cargo documentos
                Me.vL_Componente = New List(Of Componente)
                Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
                Dim oEq As DataTable = oBD.ObtenerTabla("SELECT cve_TC  FROM TC WHERE estatus='1'")
                If oEq IsNot Nothing Then
                    Dim oTC As Componente = Nothing
                    For Each row As DataRow In oEq.Rows
                        oTC = New Componente
                        oTC.cve_componente = row("cve_TC")
                        oTC.Cargar()
                        Me.vL_Componente.Add(oTC)
                    Next
                End If
            End If
            Return Me.vL_Componente
        End Get
        Set(ByVal value As List(Of Componente))
            Me.vL_Componente = value
        End Set
    End Property



End Class
