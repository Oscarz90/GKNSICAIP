﻿Imports CapaDatos
Public Class usuario_indicador
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from USUARIO_INDICADOR where cve_usuario_indicador =" & vcve_usuario_indicador, "usuario_indicador")
        If vDR IsNot Nothing Then
            vcve_usuario_indicador = vDR("cve_usuario_indicador")
            vcve_usuario = vDR("cve_usuario")
            vcve_indicador = vDR("cve_indicador")
        End If
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery("delete from USUARIO_INDICADOR where cve_usuario_indicador =" & vcve_usuario_indicador)
        Catch ex As Exception

        End Try
    End Sub
    Public Property Id As Long Implements IIndividual.Id
        Get
            Return vcve_usuario_indicador
        End Get
        Set(ByVal value As Long)
            vcve_usuario_indicador = value
        End Set
    End Property
    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Dim vDR As DataRow = oBD.ObtenerRenglon("select cve_usuario_indicador from USUARIO_INDICADOR where cve_usuario_indicador= " & vcve_usuario_indicador, "usuario_indicador")
        Dim vRetorno As Long
        If vDR IsNot Nothing Then
            vcve_usuario_indicador = vDR("cve_usuario_indicador")
        Else
            Return 0
        End If
        Return vRetorno
    End Function
    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_usuario_indicador As Long
    Private vcve_usuario As Long
    Private vcve_indicador As Long
    Private vindicador As String

#End Region
#Region "Propiedades"
    Public Property cve_usuario_indicador() As Long
        Get
            Return vcve_usuario_indicador
        End Get
        Set(ByVal value As Long)
            vcve_usuario_indicador = value
        End Set
    End Property
    Public Property cve_usuario() As Long
        Get
            Return vcve_usuario
        End Get
        Set(ByVal value As Long)
            vcve_usuario = value
        End Set
    End Property
    Public Property cve_indicador() As Long
        Get
            Return vcve_indicador
        End Get
        Set(ByVal value As Long)
            vcve_indicador = value
        End Set
    End Property
    Public Property indicador() As String
        Get
            Return vindicador
        End Get
        Set(ByVal value As String)
            vindicador = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub obtiene_indicador()
        Dim vDR As DataRow
        Dim query As String = String.Format("select i.indicador from USUARIO_INDICADOR ui join indicador i on ui.cve_indicador=i.cve_indicador where ui.cve_usuario ={0}", vcve_usuario)
        vDR = oBD.ObtenerRenglon(query, "usuario_indicador")
        If vDR IsNot Nothing Then
            vindicador = vDR("indicador")
        End If
    End Sub
#End Region
End Class



