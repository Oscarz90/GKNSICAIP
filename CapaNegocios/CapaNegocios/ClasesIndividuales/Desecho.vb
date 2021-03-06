﻿Imports CapaDatos
Public Class Desecho
    Implements IIndividual
    Dim cadena_conexion As New conexiones
    Dim oBD As New Datos(cadena_conexion.CadenaSicaip)
#Region "Metodos IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim vDR As DataRow = oBD.ObtenerRenglon("select * from desecho d where d.cve_desecho=" & vcve_desecho, "desecho")
        If vDR IsNot Nothing Then
            Me.vcve_desecho = vDR("cve_desecho")
            Me.vcve_registro_turno = vDR("cve_registro_turno")
            Me.vcod_empleado_registro = vDR("cod_empleado_registro")
            Me.vfecha_registro = vDR("fecha_registro")
            Me.vcve_modelo = vDR("cve_modelo")
            If vDR("cve_TC") IsNot DBNull.Value Then
                Me.vcve_TC = vDR("cve_TC")
            Else
                Me.vcve_TC = Nothing
            End If
            Me.vcantidad = vDR("cantidad")
            If vDR("comentarios") IsNot DBNull.Value Then
                Me.vcomentarios = vDR("comentarios")
            Else
                Me.vcomentarios = ""
            End If
            If vDR("cod_empleado_eliminacion") IsNot DBNull.Value Then
                Me.vcod_empleado_eliminacion = vDR("cod_empleado_eliminacion")
            Else
                Me.vcod_empleado_eliminacion = ""
            End If
            If vDR("fecha_eliminacion") IsNot DBNull.Value Then
                Me.vfecha_eliminacion = vDR("fecha_eliminacion")
            Else
                Me.vcod_empleado_eliminacion = ""
            End If
            vestatus = vDR("estatus")
        End If
    End Sub
    Public Sub Eliminar() Implements IIndividual.Eliminar
        Try
            oBD.EjecutarQuery(String.Format("update desecho set cod_empleado_eliminacion='{0}',fecha_eliminacion='{1}',estatus='0' where cve_desecho={2}", vcod_empleado_eliminacion, vfecha_eliminacion, vcve_desecho))
        Catch ex As Exception
            MsgBox("Error al eliminar desecho. CDesecho_ERROR", vbCritical + vbOKOnly, "Error")
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
        Dim queryInsert As String = "insert into desecho(cve_registro_turno,cod_empleado_registro,fecha_registro,cve_modelo,cve_TC,cantidad,comentarios,estatus) " &
                              "values(" & vcve_registro_turno & ",'" & vcod_empleado_registro & "','" & vfecha_registro & "'," & vcve_modelo & "," & vcve_TC & "," & vcantidad & ",'" & vcomentarios & "','" & vestatus & "')"
        Try
            oBD.EjecutarQuery(queryInsert)
        Catch
            MsgBox("Error al insertar desecho. CDesecho_ERROR", vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
#End Region
#Region "Atributos"
    Private vcve_desecho As Long
    Private vcve_registro_turno As Long
    Private vcod_empleado_registro As String
    Private vfecha_registro As String
    Private vcve_modelo As Long
    Private vcve_TC As Long
    Private vcantidad As Long
    Private vcomentarios As String
    Private vcod_empleado_eliminacion As String
    Private vfecha_eliminacion As String
    Private vestatus As String
#End Region
#Region "Propiedades"
    Public Property cve_desecho() As Long
        Get
            Return vcve_desecho
        End Get
        Set(ByVal value As Long)
            vcve_desecho = value
        End Set
    End Property
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
        End Set
    End Property
    Public Property cod_empleado_registro() As String
        Get
            Return vcod_empleado_registro
        End Get
        Set(ByVal value As String)
            vcod_empleado_registro = value
        End Set
    End Property
    Public Property fecha_registro() As String
        Get
            Return vfecha_registro
        End Get
        Set(ByVal value As String)
            vfecha_registro = value
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
    Public Property cve_TC() As Long
        Get
            Return vcve_TC
        End Get
        Set(ByVal value As Long)
            vcve_TC = value
        End Set
    End Property
    Public Property cantidad() As Long
        Get
            Return vcantidad
        End Get
        Set(ByVal value As Long)
            vcantidad = value
        End Set
    End Property
    Public Property comentarios() As String
        Get
            Return vcomentarios
        End Get
        Set(ByVal value As String)
            vcomentarios = value
        End Set
    End Property
    Public Property cod_empleado_eliminacion() As String
        Get
            Return vcod_empleado_eliminacion
        End Get
        Set(ByVal value As String)
            vcod_empleado_eliminacion = value
        End Set
    End Property
    Public Property fecha_eliminacion() As String
        Get
            Return vfecha_eliminacion
        End Get
        Set(ByVal value As String)
            vfecha_eliminacion = value
        End Set
    End Property
    Public Property estatus() As String
        Get
            Return vestatus
        End Get
        Set(ByVal value As String)
            vestatus = value
        End Set
    End Property
#End Region
#Region "Metodos formulario de produccion"
    Public Function llena_desecho_gridview() As DataTable
        Dim obj As DataTable
        Dim queryLlenagridview As String = "select d.cve_desecho,rt.cve_linea,m.cve_modelo,m.np_gkn,m.descripcion,d.cantidad,d.comentarios from desecho d " &
            "join modelo m on d.cve_modelo=m.cve_modelo " &
            "join registro_turno rt on rt.cve_registro_turno=d.cve_registro_turno " &
            "where d.cve_registro_turno=" & vcve_registro_turno & " and d.estatus='1'"
        Using scope As New TransactionScope
            Try
                obj = oBD.ObtenerTabla(queryLlenagridview)
                scope.Complete()
            Catch
                MsgBox("Error al obtener detalle de Desechos. CDesecho_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
            Return obj
        End Using
    End Function

#End Region
End Class
