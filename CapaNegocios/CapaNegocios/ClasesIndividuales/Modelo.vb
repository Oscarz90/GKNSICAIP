﻿Imports CapaDatos
Public Class Modelo
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oComponente As Componente
    Dim oClasificacion_Modelo As Clasificacion_Modelo
#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM modelo WHERE cve_modelo=" & vcve_modelo, "modelo")
            If rDatos IsNot Nothing Then
                If rDatos("cve_modelo") IsNot DBNull.Value Then
                    Me.vcve_modelo = rDatos("cve_modelo")
                    Me.vcve_componente = rDatos("cve_componente")
                    Me.vcve_clasificacion_modelo = rDatos("cve_clasificacion_modelo")
                    Me.vnp_gkn = rDatos("np_gkn")
                    Me.vdescripcion = rDatos("descripcion")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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
        'Validacion
        'If ValidacionesName.ValidacionesGenerales.ValidaNombre("DEPARTAMENTO", "Nombre", Me.m_Nombre, "Departamento_Id", Me.m_Departamento_Id) Then
        '    Throw New CustomException(Errores.Mismo_Nombre)
        '    Exit Sub
        'End If

        'If Me.m_Departamento_Id = 0 Then
        '    'Nuevo Registro
        '    Me.CargaDatosNvoRegistro()
        'End If
        'Me.CargaDatosNvoModificacion()
        'vEmpleado_Registro = "07044800"
        'vEmpleado_Modifico = "07044800"
        'vFecha_Registro = "30/05/2013"
        'vFecha_Modifico = "30/05/2013"
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_MODELO"

                With cmd.Parameters
                    .Add("cve_modelo", SqlDbType.BigInt).Value = Me.vcve_modelo
                    .Add("Descripcion", SqlDbType.VarChar).Value = Me.descripcion
                    .Add("cve_componente", SqlDbType.BigInt).Value = Me.vcve_componente
                    .Add("cve_clasificacion_modelo", SqlDbType.Int).Value = Me.vcve_clasificacion_modelo
                    .Add("np_gkn", SqlDbType.VarChar).Value = Me.vnp_gkn
                End With

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vcve_modelo = obj.Rows(0)(0) 'ID
                'Me.RegistraDatos("DEPARTAMENTO", "Departamento_Id", Me.m_Departamento_Id)
                'Dim oBitacora As Bitacora = Bitacora.ObtenInstancia
                'oBitacora.RegistrarEnBitacora("DEPARTAMENTO.REGISTRAR", "Se registró el departamento: " & Me.m_Nombre)
                scope.Complete()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Using
    End Sub
#End Region
#Region "Atributos"
    Private vcve_modelo As Long
    Private vcve_componente As Long
    Private vcve_clasificacion_modelo As Long
    Private vnp_gkn As String
    Private vdescripcion As String
    'Auxiliares
    Private vcve_linea As Long
    Private vcve_registro_turno As Long

#End Region
#Region "Propiedades"

    Public Property cve_modelo() As Long
        Get
            Return vcve_modelo
        End Get
        Set(ByVal value As Long)
            vcve_modelo = value
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
    Public Property cve_clasificacion_modelo() As Long
        Get
            Return vcve_clasificacion_modelo
        End Get
        Set(ByVal value As Long)
            vcve_clasificacion_modelo = value
        End Set
    End Property
    Public Property np_gkn() As String
        Get
            Return vnp_gkn
        End Get
        Set(ByVal value As String)
            vnp_gkn = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return vdescripcion
        End Get
        Set(ByVal value As String)
            vdescripcion = value
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
    Public Property cve_registro_turno() As Long
        Get
            Return vcve_registro_turno
        End Get
        Set(ByVal value As Long)
            vcve_registro_turno = value
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

    Public ReadOnly Property Nombre_Clasificacion_Modelo() As String
        Get
            If vcve_clasificacion_modelo <> 0 Then
                oClasificacion_Modelo = New Clasificacion_Modelo
                oClasificacion_Modelo.Cve_clasificacion_modelo = vcve_clasificacion_modelo
                oClasificacion_Modelo.Cargar()
                Return oClasificacion_Modelo.Descripcion
            Else
                Return ""
            End If
        End Get
    End Property



#End Region

#Region "Metodos Generales"
    Public Function Obtener_Modelos() As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from Modelo")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Modelos(ByVal vFiltro As String) As DataTable
        Dim vDT As DataTable
        vDT = oBD.ObtenerTabla("select * from Modelo where descripcion LIKE '%" & vFiltro & "%'")
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function
#End Region


#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_Modelos_Linea() As DataTable
        Dim dtModelos As New DataTable
        Try
            dtModelos = oBD.ObtenerTabla("select m.cve_modelo,m.np_gkn from linea l " &
                                         "join TC tc on l.cve_linea=tc.cve_linea " &
                                         "join modelo m on tc.cve_modelo=m.cve_modelo " &
                                         "where l.cve_linea=" & vcve_linea)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_MODELOS_DE_LINEA_CModelo")
            dtModelos = Nothing
        End Try
        Return dtModelos
    End Function
    Public Function llena_combo_Modelos_Desecho_Linea() As DataTable
        Dim dtModelos As New DataTable
        Dim query As String = "select m.cve_modelo,m.np_gkn from registro_turno rt " &
            "join linea l on rt.cve_linea=l.cve_linea " &
            "join TC t on t.cve_linea=l.cve_linea " &
            "join modelo m on t.cve_modelo=m.cve_modelo " &
            "where rt.cve_registro_turno=" & vcve_registro_turno & " and " &
            "m.cve_modelo in (select p.cve_modelo from produccion p " &
            "where p.cve_registro_turno=" & vcve_registro_turno & " and p.estatus='1')"
        Try
            dtModelos = oBD.ObtenerTabla(query)
        Catch ex As Exception
            MsgBox("ERROR_AL_OBTENER_MODELOS_DESECHO_DE_LINEA_CModelo")
            dtModelos = Nothing
        End Try
        Return dtModelos
    End Function
    Public Function llena_combo_Modelos_Linea_Salida() As DataTable
        Using scope As New TransactionScope
            Try
                Dim vComando As New SqlClient.SqlCommand
                vComando.CommandType = CommandType.StoredProcedure
                vComando.CommandText = "get_lista_modelos_salida"
                vComando.Parameters.Add("@cve_linea", SqlDbType.BigInt).Value = Me.vcve_linea
                vComando.Parameters.Add("@cve_modelo", SqlDbType.VarChar).Value = Me.vcve_modelo
                Dim obj As DataTable = oBD.EjecutaCommando(vComando)            
                scope.Complete()
                Return obj
            Catch
                MsgBox("Error al obtener modelos de salida. CModelo_ERROR", vbCritical + vbOKOnly, "Error")
                Return Nothing
            End Try
        End Using
    End Function
    Public Sub obtener_descripcion_modelo()
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("Select descripcion from modelo where cve_modelo=" & Me.vcve_modelo, "modelos")
            If rDatos IsNot Nothing Then
                If rDatos("descripcion") IsNot DBNull.Value Then
                    Me.vdescripcion = rDatos("descripcion")
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region
End Class
