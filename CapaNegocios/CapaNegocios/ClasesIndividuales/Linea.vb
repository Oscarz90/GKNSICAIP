Imports CapaDatos
Public Class Linea
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oComponente As Componente

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from Linea where cve_Linea=" & vcve_linea, "Linea")
        If vDR IsNot Nothing Then
            If Not IsDBNull(vDR("cve_Linea")) Then
                Me.vcve_linea = vDR("cve_Linea")
            End If
            If Not IsDBNull(vDR("cve_componente")) Then
                Me.vcve_componente = vDR("cve_componente")
            End If
            If Not IsDBNull(vDR("linea")) Then
                Me.vlinea = vDR("linea")
            End If
            If Not IsDBNull(vDR("tpcdm")) Then
                Me.vtpcdm = vDR("tpcdm")
            End If
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

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
                cmd.CommandText = "REGISTRAR_LINEA"
                With cmd.Parameters
                    .Add("cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                    .Add("cve_componente", SqlDbType.BigInt).Value = Me.vcve_componente
                    .Add("linea", SqlDbType.VarChar).Value = Me.vlinea
                    .Add("tpcdm", SqlDbType.Int).Value = Me.vtpcdm                   
                End With
                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_linea = obj.Rows(0)(0) 'ID               
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_linea As Long
    Private vcve_componente As Long
    Private vlinea As String
    Private vtpcdm As Long
#End Region
#Region "Propiedades"
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_componente() As Long
        Get
            Return vcve_componente
        End Get
        Set(ByVal value As Long)
            vcve_componente = value
        End Set
    End Property
    Public Property linea() As String
        Get
            Return vlinea
        End Get
        Set(ByVal value As String)
            vlinea = value
        End Set
    End Property
    Public Property tpcdm() As Long
        Get
            Return vtpcdm
        End Get
        Set(ByVal value As Long)
            vtpcdm = value
        End Set
    End Property

    Public ReadOnly Property Nombre_Componente() As String
        Get
            If cve_componente <> 0 Then
                oComponente = New Componente
                oComponente.cve_componente = cve_componente
                oComponente.Cargar()
                Return oComponente.componente
            Else
                Return ""
            End If
        End Get
    End Property

#End Region

#Region "Metodos Generales"
    Public Function Obtener_Lineas() As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from Linea")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Lineas(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from Linea where linea LIKE '%" & vFiltro & "%'")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function
#End Region

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_lineas() As DataTable
        Dim dtTurnos As New DataTable
        Try
            dtTurnos = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where el.cve_equipo="& vcve_linea)
        Catch ex As Exception
            MsgBox("Error al eliminar produccion. CLineas_ERROR", vbCritical + vbOKOnly, "Error")
            dtTurnos = Nothing
        End Try
        Return dtTurnos
    End Function
#End Region
End Class
