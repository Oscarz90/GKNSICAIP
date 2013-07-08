Imports CapaDatos
Public Class Componente
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select * from Componente where cve_componente=" & vcve_componente, "Componente")
        If vDR IsNot Nothing Then
            If Not IsDBNull(vDR("cve_componente")) Then
                Me.vcve_componente = vDR("cve_componente")
            End If
            If Not IsDBNull(vDR("cve_cadena_Valor")) Then
                Me.vcve_cadena_valor = vDR("cve_cadena_Valor")
            End If
            If Not IsDBNull(vDR("componente")) Then
                Me.vcomponente = vDR("componente")
            End If
            If Not IsDBNull(vDR("precio")) Then
                Me.vprecio = vDR("precio")
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

    End Sub
#End Region
#Region "Atributos"
    Private vcve_componente As Long
    Private vcve_cadena_valor As Long
    Private vcomponente As String
    Private vprecio As Double
    'Auxiliar
    Private vcve_linea As Long
#End Region
#Region "Propiedades"
    Public Property cve_componente() As Long
        Get
            Return vcve_componente
        End Get
        Set(ByVal value As Long)
            vcve_componente = value
        End Set
    End Property
    Public Property cve_cadena_valor() As Long
        Get
            Return vcve_cadena_valor
        End Get
        Set(ByVal value As Long)
            vcve_cadena_valor = value
        End Set
    End Property
    Public Property componente() As String
        Get
            Return vcomponente
        End Get
        Set(ByVal value As String)
            vcomponente = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return vprecio
        End Get
        Set(ByVal value As Double)
            vprecio = value
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

#End Region

#Region "Metodos Generales"
    Public Function Obtener_Componentes() As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from componente")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Componentes(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from componente where componente LIKE '%" & vFiltro & "%'")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function
#End Region

#Region "Metodos Formulario de CDM Cambio de Modelo"
    Public Sub obtiene_precio_componente_linea()
        Dim vDR As DataRow
        vDR = oBD.ObtenerRenglon("select c.precio from linea l join componente c on l.cve_componente=c.cve_componente where l.cve_linea=" & vcve_linea, "paro")
        If vDR IsNot Nothing Then
            vprecio = vDR("precio")
        End If
    End Sub
#End Region

End Class
