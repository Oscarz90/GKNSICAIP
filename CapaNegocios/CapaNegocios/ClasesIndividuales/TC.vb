﻿Imports CapaDatos
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
End Class