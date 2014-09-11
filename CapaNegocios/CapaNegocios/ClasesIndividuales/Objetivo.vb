Imports CapaDatos
Public Class Objetivo
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from objetivo where cve_objetivo = " & vCve_Objetivo, "objetivo")
        If vDR IsNot Nothing Then
            vCve_Objetivo = vDR("cve_objetivo")
            vCve_Equipo = vDR("cve_equipo")
            vFecha_Objetivo = vDR("fecha_objetivo")
            vSeguridad = vDR("seguridad")
            vCalidad = vDR("calidad")
            vGente = vDR("gente")
            vProductividad = vDR("Productividad")
            vCosto = vDR("costo")
            vCincoS = vDR("CincoS")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM objetivo where cve_objetivo= " & vCve_Objetivo)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("Select cve_objetivo from objetivo where cve_equipo=" & vCadena, "")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_objetivo")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_Objetivo"}
                cmd.Parameters.Add("@Cve_Objetivo", SqlDbType.BigInt).Value = Me.vCve_Objetivo
                cmd.Parameters.Add("@Cve_Equipo", SqlDbType.BigInt).Value = Me.vCve_Equipo
                cmd.Parameters.Add("@Fecha_Objetivo", SqlDbType.VarChar).Value = Me.vFecha_Objetivo
                cmd.Parameters.Add("@Seguridad", SqlDbType.Int).Value = Me.vSeguridad
                cmd.Parameters.Add("@Calidad", SqlDbType.Float).Value = Me.vCalidad
                cmd.Parameters.Add("@Gente", SqlDbType.Int).Value = Me.vGente
                cmd.Parameters.Add("@Productividad", SqlDbType.Float).Value = Me.vProductividad
                cmd.Parameters.Add("@Costo", SqlDbType.Float).Value = Me.vCosto
                cmd.Parameters.Add("@CincoS", SqlDbType.Float).Value = Me.vCincoS

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_Objetivo = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vCve_Objetivo As Long
    Private vCve_Equipo As Long
    Private vFecha_Objetivo As String
    Private vSeguridad As Integer
    Private vCalidad As Double
    Private vGente As Integer
    Private vProductividad As Double
    Private vCosto As Double
    Private vCincoS As Double
#End Region
#Region "Propiedades"

    Public Property Cve_Objetivo As Long Implements IIndividual.Id
        Get
            Return vCve_Objetivo
        End Get
        Set(ByVal value As Long)
            vCve_Objetivo = value
        End Set
    End Property

    Public Property Cve_Equipo() As Long
        Get
            Return vCve_Equipo
        End Get
        Set(ByVal value As Long)
            vCve_Equipo = value
        End Set
    End Property

    Public Property Fecha_Objetivo() As String
        Get
            Return vFecha_Objetivo
        End Get
        Set(ByVal value As String)
            vFecha_Objetivo = value
        End Set
    End Property

    Public Property Seguridad() As Integer
        Get
            Return vSeguridad
        End Get
        Set(ByVal value As Integer)
            vSeguridad = value
        End Set
    End Property

    Public Property Calidad() As Double
        Get
            Return vCalidad
        End Get
        Set(ByVal value As Double)
            vCalidad = value
        End Set
    End Property

    Public Property Gente() As Integer
        Get
            Return vGente
        End Get
        Set(ByVal value As Integer)
            vGente = value
        End Set
    End Property

    Public Property Productividad() As Double
        Get
            Return vProductividad
        End Get
        Set(ByVal value As Double)
            vProductividad = value
        End Set
    End Property

    Public Property Costo() As Double
        Get
            Return vCosto
        End Get
        Set(ByVal value As Double)
            vCosto = value
        End Set
    End Property

    Public Property CincoS() As Double
        Get
            Return vCincoS
        End Get
        Set(ByVal value As Double)
            vCincoS = value
        End Set
    End Property


#End Region
End Class
