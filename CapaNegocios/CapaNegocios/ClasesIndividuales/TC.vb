Imports CapaDatos
Public Class TC
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

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

    End Sub
#End Region
#Region "Atributos"
    Private vcve_TC As Long
    Private vpiezas_por_hora As Long
    Private vcve_linea As Long
    Private vcve_modelo As Long
#End Region
#Region "Propiedades"
    Public Property cve_TC() As Long
        Get
            Return vcve_TC
        End Get
        Set(ByVal value As Long)
            vcve_TC = value
        End Set
    End Property
    Public Property piezas_por_hora() As Long
        Get
            Return vpiezas_por_hora
        End Get
        Set(ByVal value As Long)
            vpiezas_por_hora = value
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
    Public Property cve_modelo() As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function obtener_tiempo_ciclo() As Double
        Dim Tiempo_ciclo As Double = 0
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("select cast(60 as float)/t.piezas_por_hora as tiempo_ciclo from TC t where cve_linea=" & vcve_linea & " and cve_modelo=" & vcve_modelo, "TC")
            If rDatos IsNot Nothing Then
                If rDatos("tiempo_ciclo") IsNot DBNull.Value Then
                    Tiempo_ciclo = rDatos("tiempo_ciclo")
                End If
            End If
            Return Tiempo_ciclo
        Catch 'ex As Exception
            MsgBox("Error al obtener Tiempo Ciclo. CTC_ERROR", vbCritical + vbOKOnly, "Error")
            Return Tiempo_ciclo
        End Try
    End Function

    '
    Public Sub obtener_piezas_por_hora()
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select t.piezas_por_hora from TC t where t.cve_linea=" & vcve_linea & " and t.cve_modelo=" & vcve_modelo, "paro")
            If vDR IsNot Nothing Then
                vpiezas_por_hora = vDR("piezas_por_hora")
            End If
        Catch
            MsgBox("Error al obtener piezas por hora!. CTC_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
        
    End Sub
    
#End Region
End Class
