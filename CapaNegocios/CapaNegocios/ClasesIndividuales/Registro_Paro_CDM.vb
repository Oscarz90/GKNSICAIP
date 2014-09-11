Imports CapaDatos
Public Class Registro_Paro_CDM
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from Registro_paro_CDM where cve_reg_paros_CDM = " & vCve_Reg_Paros_CDM, "Registro_paro_CDM")
        If vDR IsNot Nothing Then
            vCve_Reg_Paros_CDM = vDR("cve_reg_paros_CDM")
            vRegistro_Paro_Principal = vDR("Registro_Paro_Principal")
            vRegistro_Paro_Secundario = vDR("Registro_Paro_Secundario")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM Registro_paro_CDM where cve_reg_paros_CDM= " & vCve_Reg_Paros_CDM)
        Catch ex As Exception

        End Try
    End Sub


    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("Select cve_reg_paros_CDM from Registro_paro_CDM where registro_paro_principal=" & vCadena, "")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_reg_paros_CDM")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_Registro_Paro_CDM"}
                cmd.Parameters.Add("@Cve_Reg_Paros_CDM", SqlDbType.BigInt).Value = Me.vCve_Reg_Paros_CDM
                cmd.Parameters.Add("@Registro_Paro_Principal", SqlDbType.BigInt).Value = Me.vRegistro_Paro_Principal
                cmd.Parameters.Add("@Registro_Paro_Secundario", SqlDbType.BigInt).Value = Me.vRegistro_Paro_Secundario

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_Reg_Paros_CDM = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vCve_Reg_Paros_CDM As Long
    Private vRegistro_Paro_Principal As Long
    Private vRegistro_Paro_Secundario As Long
#End Region
#Region "Propiedades"

    Public Property Cve_Reg_Paros_CDM As Long Implements IIndividual.Id
        Get
            Return vCve_Reg_Paros_CDM
        End Get
        Set(ByVal value As Long)
            vCve_Reg_Paros_CDM = value
        End Set
    End Property

    Public Property Registro_Paro_Principal() As Long
        Get
            Return vRegistro_Paro_Principal
        End Get
        Set(ByVal value As Long)
            vRegistro_Paro_Principal = value
        End Set
    End Property

    Public Property Registro_Paro_Secundario() As Long
        Get
            Return vRegistro_Paro_Secundario
        End Get
        Set(ByVal value As Long)
            vRegistro_Paro_Secundario = value
        End Set
    End Property



#End Region
End Class
