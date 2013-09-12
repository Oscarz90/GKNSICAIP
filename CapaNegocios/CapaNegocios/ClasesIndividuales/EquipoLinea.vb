Imports CapaDatos
Public Class EquipoLinea
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oLinea As Linea
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        For Each vDR As DataRow In ObtenerElementosAsignados(vcve_linea).Rows
            Try
                oBD.EjecutarQuery("DELETE FROM equipo_linea WHERE cve_equipo_linea=" & vDR("cve_equipo_linea"))
            Catch ex As Exception

            End Try
        Next
    End Sub
    Dim vId As Long
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vId
        End Get
        Set(ByVal value As Long)
            vId = value
        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_EQUIPO_LINEA"
                With cmd.Parameters
                    .Add("cve_equipo_linea", SqlDbType.BigInt).Value = Me.vcve_equipo_linea
                    .Add("cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                    .Add("cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_equipo_linea = obj.Rows(0)(0) 'ID               
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_equipo_linea As Long
    Private vcve_equipo As Long
    Private vcve_linea As Long
#End Region
#Region "Propiedades"
    Public Property cve_equipo_linea As Long
        Get
            Return vcve_equipo_linea
        End Get
        Set(ByVal value As Long)
            vcve_equipo_linea = value
        End Set
    End Property
    Public Property cve_linea As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_equipo As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property

    Public ReadOnly Property Nombre_Linea() As String
        Get
            If cve_linea <> 0 Then
                oLinea = New Linea
                oLinea.cve_linea = cve_linea
                oLinea.Cargar()
                Return oLinea.linea
            Else
                Return ""
            End If
        End Get
    End Property
#End Region
#Region "Metodos Generales"
    Public Function ObtenerElementosNoAsignados(ByVal vIdLinea As Long) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("SELECT DISTINCT E.Equipo as Equipo, E.cve_equipo  from Equipo_Linea EL join Equipo E on EL.cve_Equipo=E.cve_Equipo Where EL.cve_linea <>" & vIdLinea)
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function ObtenerElementosAsignados(ByVal vIdLinea As Long) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select EL.cve_equipo_linea AS cve_equipo_linea  From Equipo_Linea EL join Equipo E on EL.cve_Equipo=E.cve_Equipo Where EL.cve_linea =" & vIdLinea)
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

#End Region
#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_lineas() As DataTable
        Dim dtEquipoLinea As New DataTable
        Try
            dtEquipoLinea = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where el.cve_equipo=" & vcve_equipo)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_Equipo_Lineas_CLineas")
            dtEquipoLinea = Nothing
        End Try
        Return dtEquipoLinea
    End Function
#End Region
End Class
