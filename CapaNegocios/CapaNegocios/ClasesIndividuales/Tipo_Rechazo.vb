Imports CapaDatos

Public Class Tipo_Rechazo
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from tipo_rechazo where cve_tipo_rechazo = " & vcve_tipo_rechazo, "tipo_rechazo")
        If vDR IsNot Nothing Then
            vcve_tipo_rechazo = vDR("cve_tipo_rechazo")
            vTipo = vDR("tipo")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from tipo_rechazo where cve_tipo_rechazo=" & vcve_tipo_rechazo)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("select cve_tipo_rechazo from tipo_rechazo where tipo = " & vCadena, "tipo_rechazo")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_tipo_rechazo")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_Tipo_Rechazo"}
                cmd.Parameters.Add("@cve_tipo_rechazo", SqlDbType.Int).Value = Me.vcve_tipo_rechazo
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = Me.vTipo

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_tipo_rechazo = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception
            End Try
        End Using

    End Sub

#End Region
#Region "Atributos"
    Private vcve_tipo_rechazo As Long
    Private vTipo As String
#End Region
#Region "Propiedades"

    Public Property cve_tipo_rechazo As Long Implements IIndividual.Id
        Get
            Return vcve_tipo_rechazo
        End Get
        Set(ByVal value As Long)
            vcve_tipo_rechazo = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal value As String)
            vTipo = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_combo_tipo_rechazo() As DataTable
        Dim dtTipoRechazo As New DataTable
        Try
            dtTipoRechazo = oBD.ObtenerTabla("select cve_tipo_rechazo,tipo from tipo_rechazo")
        Catch ex As Exception
            MsgBox("Error al obtener Tipo de Rechazos. CTipo_Rechazo_ERROR", vbCritical + vbOKOnly, "Error")
            dtTipoRechazo = Nothing
        End Try
        Return dtTipoRechazo
    End Function
#End Region
End Class
