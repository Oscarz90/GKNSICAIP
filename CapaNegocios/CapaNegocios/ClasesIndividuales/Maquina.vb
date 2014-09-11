Imports CapaDatos
Public Class Maquina
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
    Dim oLinea As Linea

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM maquina WHERE cve_maquina=" & vcve_maquina, "turno")
            If rDatos IsNot Nothing Then
                If rDatos("cve_maquina") IsNot DBNull.Value Then
                    Me.vcve_maquina = rDatos("cve_maquina")
                    Me.vcve_linea = rDatos("cve_linea")
                    Me.vclave_maquina = rDatos("clave_maquina")
                    Me.vmaquina = rDatos("maquina")
                    If Not IsDBNull(rDatos("Estatus")) Then
                        Me.vEstatus = rDatos("Estatus")
                    Else
                        Me.vEstatus = ""
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("UPDATE Maquina SET Estatus='0' WHERE cve_maquina=" & Me.cve_maquina)
            MsgBox("La Baja de Maquina se realizo correctamente")
        Catch ex As Exception

        End Try
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
                Dim cmd As New SqlClient.SqlCommand() With {.CommandType = CommandType.StoredProcedure, .CommandText = "REGISTRAR_MAQUINA"}

                With cmd.Parameters
                    .Add("cve_maquina", SqlDbType.BigInt).Value = Me.vcve_maquina
                    .Add("cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                    .Add("clave_maquina", SqlDbType.VarChar).Value = Me.vclave_maquina
                    .Add("maquina", SqlDbType.VarChar).Value = Me.vmaquina
                    .Add("Estatus", SqlDbType.VarChar).Value = Me.vEstatus
                End With

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_maquina = obj.Rows(0)(0) 'ID
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_maquina As Long
    Private vcve_linea As Long
    Private vmaquina As String
    Private vclave_maquina As String
#End Region
#Region "Propiedades"
    Public Property cve_maquina() As Long
        Get
            Return vcve_maquina
        End Get
        Set(ByVal value As Long)
            vcve_maquina = value
        End Set
    End Property
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property clave_maquina() As String
        Get
            Return vclave_maquina
        End Get
        Set(ByVal value As String)
            vclave_maquina = value
        End Set
    End Property
    Public Property maquina() As String
        Get
            Return vmaquina
        End Get
        Set(ByVal value As String)
            vmaquina = value
        End Set
    End Property
    Private vEstatus As String
    Public Property Estatus() As String
        Get
            If vEstatus = "1" Then
                Return "ACTIVO"
            ElseIf vEstatus = "0" Then
                Return "INACTIVO"
            Else
                Return ""
            End If
            Return vEstatus
        End Get
        Set(ByVal value As String)
            vEstatus = value
        End Set
    End Property


    Public ReadOnly Property Nombre_Linea() As String
        Get
            If vcve_linea <> 0 Then
                oLinea = New Linea() With {.cve_linea = vcve_linea}
                oLinea.Cargar()
                Return oLinea.linea
            Else
                Return ""
            End If
        End Get
    End Property

#End Region
#Region "Metodos Generales"
    Public Function Valida_Existe_Clave_Maquina(ByVal vCve_Maquina_Validar As String) As Boolean
        Dim vRetorno As Boolean = False
        Dim vTotal As Integer = 0
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon(String.Format("SELECT sum(cve_maquina) as Total FROM maquina WHERE clave_maquina='{0}' and estatus='1'", vCve_Maquina_Validar), "turno")
            If rDatos IsNot Nothing Then
                If rDatos("Total") IsNot DBNull.Value Then
                    vTotal = rDatos("Total")
                    If vTotal > 0 Then
                        vRetorno = True
                    Else
                        vRetorno = False
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            vRetorno = False
        End Try
        Return vRetorno
    End Function
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_combo_maquina() As DataTable
        Dim dtMaquina As New DataTable
        Try
            dtMaquina = oBD.ObtenerTabla("select m.cve_maquina,m.clave_maquina from maquina m where m.estatus='1' and m.cve_linea=" & vcve_linea)
        Catch ex As Exception
            MsgBox("Error al obtener Maquinas. CMaquina_ERROR", vbCritical + vbOKOnly, "Error")
            dtMaquina = Nothing
        End Try
        Return dtMaquina
    End Function
#End Region
End Class
