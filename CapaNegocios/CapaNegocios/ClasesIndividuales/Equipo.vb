Imports CapaDatos
Public Class Equipo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from equipo where cve_equipo = " & vCve_Equipo, "equipo")
        If vDR IsNot Nothing Then
            vCve_Equipo = vDR("cve_equipo")
            vCve_Equipo_Kronos = vDR("Cve_Equipo_Kronos")
            If Not IsDBNull(vDR("cve_lider")) Then
                vCve_Lider = vDR("cve_Lider")
            Else
                vCve_Lider = 0
            End If
            vCve_Detalle = vDR("cve_detalle")
            vEquipo = vDR("equipo")
            vLET = vDR("LET")
            vRuta_Imagen = vDR("rutaImagen")
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("Delete FROM equipo where cve_equipo= " & vCve_Equipo)
        Catch ex As Exception

        End Try
    End Sub


    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow
        Dim vRetorno As Long
        vDR = oBD.ObtenerRenglon("Select cve_equipo from equipo where cve_equipo_kronos=" & vCadena, "")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_equipo")
        Else
            vRetorno = 0
        End If
        Return vRetorno
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_Equipo"
                cmd.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vCve_Equipo
                cmd.Parameters.Add("@cve_equipo_kronos", SqlDbType.VarChar).Value = Me.vCve_Equipo_Kronos
                cmd.Parameters.Add("@cve_lider", SqlDbType.BigInt).Value = Me.vCve_Lider
                cmd.Parameters.Add("@cve_detalle", SqlDbType.BigInt).Value = Me.vCve_Detalle
                cmd.Parameters.Add("@equipo", SqlDbType.VarChar).Value = Me.vEquipo
                cmd.Parameters.Add("@LET", SqlDbType.VarChar).Value = Me.vLET
                cmd.Parameters.Add("@rutaImagen", SqlDbType.VarChar).Value = Me.vRuta_Imagen

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCve_Equipo = obj.Rows(0)(0)
                scope.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vCve_Equipo As Long
    Private vCve_Equipo_Kronos As String
    Private vCve_Lider As Long
    Private vCve_Detalle As Long
    Private vEquipo As String
    Private vLET As String
    Private vRuta_Imagen As String
#End Region
#Region "Propiedades"

    Public Property Cve_Equipo As Long Implements IIndividual.Id
        Get
            Return vCve_Equipo
        End Get
        Set(ByVal value As Long)
            vCve_Equipo = value
        End Set
    End Property

    Public Property Cve_Equipo_Kronos() As String
        Get
            Return vCve_Equipo_Kronos
        End Get
        Set(ByVal value As String)
            vCve_Equipo_Kronos = value
        End Set
    End Property

    Public Property Cve_Lider() As Long
        Get
            Return vCve_Lider
        End Get
        Set(ByVal value As Long)
            vCve_Lider = value
        End Set
    End Property

    Public Property Cve_Detalle() As Long
        Get
            Return vCve_Detalle
        End Get
        Set(ByVal value As Long)
            vCve_Detalle = value
        End Set
    End Property

    Public Property Equipo() As String
        Get
            Return vEquipo
        End Get
        Set(ByVal value As String)
            vEquipo = value
        End Set
    End Property

    Public Property LETT() As String
        Get
            Return vLET
        End Get
        Set(ByVal value As String)
            vLET = value
        End Set
    End Property


    Public Property Ruta_Imagen() As String
        Get
            Return vRuta_Imagen
        End Get
        Set(ByVal value As String)
            vRuta_Imagen = value
        End Set
    End Property

#End Region
End Class
