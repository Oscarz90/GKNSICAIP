﻿Imports CapaDatos
Public Class obtiene_seguridad
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar

    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Property Id As Long Implements IIndividual.Id
        Get
            Return 1
        End Get
        Set(ByVal value As Long)

        End Set
    End Property

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar

    End Sub
#End Region
#Region "Atributos"
    Private vcve_cadena_valor As Long
    Private vcve_componente As Long
    Private vcve_linea As Long
    Private vcve_equipo As Long
    Private vfecha_inicial As DateTime
    Private vfecha_final As DateTime
#End Region
#Region "Propiedades"
    Public Property cve_cadena_valor() As Long
        Get
            Return vcve_cadena_valor
        End Get
        Set(ByVal value As Long)
            vcve_cadena_valor = value
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
    Public Property cve_linea() As Long
        Get
            Return vcve_linea
        End Get
        Set(ByVal value As Long)
            vcve_linea = value
        End Set
    End Property
    Public Property cve_equipo() As Long
        Get
            Return vcve_equipo
        End Get
        Set(ByVal value As Long)
            vcve_equipo = value
        End Set
    End Property
    Public Property fecha_inicial() As DateTime
        Get
            Return vfecha_inicial
        End Get
        Set(ByVal value As DateTime)
            vfecha_inicial = value
        End Set
    End Property
    Public Property fecha_final() As DateTime
        Get
            Return vfecha_final
        End Get
        Set(ByVal value As DateTime)
            vfecha_final = value
        End Set
    End Property
#End Region
#Region "Metodos obtener oee"
    'Planta
    Public Function obtiene_seguridad_planta_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_planta_dia"
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener seguridad. CObtiene_seguridad_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_planta_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_planta_mes"
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    'Cadena Valor
    Public Function obtiene_seguridad_cadena_valor_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_cadena_valor_dia"
                vComando.Parameters.Add("@cve_cadena_valor", SqlDbType.BigInt).Value = Me.vcve_cadena_valor
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_cadena_valor_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_cadena_valor_mes"
                vComando.Parameters.Add("@cve_cadena_valor", SqlDbType.BigInt).Value = Me.vcve_cadena_valor
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    'Componente
    Public Function obtiene_seguridad_componente_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_componente_dia"
                vComando.Parameters.Add("@cve_componente", SqlDbType.BigInt).Value = Me.vcve_componente
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_componente_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_componente_mes"
                vComando.Parameters.Add("@cve_componente", SqlDbType.BigInt).Value = Me.vcve_componente
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    'Linea
    Public Function obtiene_seguridad_linea_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_seguridad_linea_dia"
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_linea_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_gente_linea_mes"
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    'Equipo
    Public Function obtiene_seguridad_equipo_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_gente_equipo_dia"
                vComando.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_equipo_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_gente_equipo_mes"
                vComando.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_equipo_linea_dia() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_gente_equipo_linea_dia"
                vComando.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
    Public Function obtiene_seguridad_equipo_linea_mes() As DataTable
        Dim obj As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "obtiene_gente_equipo_linea_mes"
                vComando.Parameters.Add("@cve_equipo", SqlDbType.BigInt).Value = Me.vcve_equipo
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = Me.vfecha_inicial
                vComando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = Me.vfecha_final
                obj = oBD.EjecutaCommando(vComando)
                'Me.vId = obj.Rows(0)(0)
                scope.Complete()
            Catch 'ex As Exception
                MsgBox("Error al obtener gente. CObtiene_gente_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
                'Throw New Exception(ex.Message)
            End Try
            Return obj
        End Using
    End Function
#End Region
End Class

