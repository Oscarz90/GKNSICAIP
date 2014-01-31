Imports CapaDatos
Public Class Linea
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oComponente As Componente
    Dim oEquipo_Linea As EquipoLinea

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
            If Not IsDBNull(vDR("Estatus")) Then
                Me.vEstatus = vDR("Estatus")
            End If
        End If
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar              
        Dim oTC As New TC
        Dim vDT_TC_CON_Lineas_Para_Baja As DataTable

        Using scope As New TransactionScope()
            Try
                oBD.EjecutarQuery("UPDATE LINEA SET Estatus='0' WHERE cve_linea=" & Me.vcve_linea)
                vDT_TC_CON_Lineas_Para_Baja = oTC.Obtener_TC_con_Linea(vcve_linea) ''---Obtiene los TC relacionados con la linea, para darlos de baja

                If IsNothing(vDT_TC_CON_Lineas_Para_Baja) = False Then
                    For Each vDR As DataRow In vDT_TC_CON_Lineas_Para_Baja.Rows
                        oTC.cve_TC = vDR("cve_TC")
                        oTC.Eliminar()
                    Next
                End If

                MsgBox("La Baja de Linea se realizo correctamente")
               
                scope.Complete()
            Catch ex As Exception
               
            End Try
        End Using          
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
                    .Add("Estatus", SqlDbType.VarChar).Value = Me.vEstatus
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
    Private vEstatus As String
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
    Public Property Estatus() As String
        Get
            If vEstatus = "1" Then
                Return "ACTIVO"
            ElseIf vEstatus = "0" Then
                Return "INACTIVO"
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            vEstatus = value
        End Set
    End Property
    'Private vLEquipo_Linea As List(Of EquipoLinea)
    'Public Property LEquipo_Linea_Asignados() As List(Of EquipoLinea)
    '    Get
    '        If vLEquipo_Linea Is Nothing Then
    '            'Cargo documentos
    '            Me.LEquipo_Linea_Asignados = New List(Of EquipoLinea)
    '            Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    '            Dim oEq As DataTable = oBD.ObtenerTabla("SELECT EL.cve_equipo_linea FROM Equipo_Linea EL join Equipo E on EL.cve_Equipo=E.cve_Equipo WHERE EL.cve_linea =" & Me.vcve_linea)
    '            If oEq IsNot Nothing Then
    '                Dim oEquipoLinea As EquipoLinea = Nothing
    '                For Each row As DataRow In oEq.Rows
    '                    oEquipoLinea = New EquipoLinea
    '                    oEquipoLinea.cve_equipo_linea = row("cve_equipo_linea")
    '                    oEquipoLinea.Cargar()
    '                    Me.vLEquipo_Linea.Add(oEquipoLinea)
    '                Next
    '            End If
    '        End If
    '        Return Me.vLEquipo_Linea
    '    End Get
    '    Set(ByVal value As List(Of EquipoLinea))
    '        Me.vLEquipo_Linea = value
    '    End Set
    'End Property

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

    Private vLEquipos_Linea_NO_Asignados As List(Of Equipo)
    Public Property LEquipos_Linea_NO_Asignados() As List(Of Equipo)
        Get
            If vLEquipos_Linea_NO_Asignados Is Nothing Then
                'Cargo documentos
                Me.LEquipos_Linea_NO_Asignados = New List(Of Equipo)
                Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
                Dim oEq As DataTable = oBD.ObtenerTabla("SELECT DISTINCT E.cve_equipo AS cve_equipo, E.Equipo" & _
                                                        " FROM Equipo E " & _
                                                        " WHERE E.cve_equipo NOT IN  (SELECT cve_equipo FROM equipo_linea EL WHERE EL.cve_linea =" & Me.vcve_linea & ")" & _
                                                        " and E.cve_equipo IN (SELECT cve_equipo FROM equipo_linea EL join linea l on l.cve_linea=EL.cve_linea WHERE l.cve_componente =" & Obtener_CVEComponente_EN_Linea(Me.vcve_linea) & ")" & _
                                                        " Order by  E.Equipo")
                If oEq IsNot Nothing Then
                    Dim oEquipoLinea As Equipo = Nothing
                    For Each row As DataRow In oEq.Rows
                        oEquipoLinea = New Equipo
                        oEquipoLinea.Cve_Equipo = row("cve_equipo")
                        oEquipoLinea.Cargar()
                        Me.vLEquipos_Linea_NO_Asignados.Add(oEquipoLinea)
                    Next
                End If
            End If
            Return Me.vLEquipos_Linea_NO_Asignados
        End Get
        Set(ByVal value As List(Of Equipo))
            Me.vLEquipos_Linea_NO_Asignados = value
        End Set
    End Property


    Private vLEquipos_Linea_Asignados As List(Of Equipo)
    Public Property LEquipos_Linea_Asignados() As List(Of Equipo)
        Get
            If vLEquipos_Linea_Asignados Is Nothing Then
                'Cargo documentos
                Me.LEquipos_Linea_Asignados = New List(Of Equipo)
                Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
                Dim oEq As DataTable = oBD.ObtenerTabla("SELECT E.cve_equipo AS cve_equipo, E.Equipo from Equipo_Linea EL join Equipo E on EL.cve_Equipo=E.cve_Equipo Where EL.cve_linea =" & Me.vcve_linea & " Order by E.Equipo")
                If oEq IsNot Nothing Then
                    Dim oEquipoLinea As Equipo = Nothing
                    For Each row As DataRow In oEq.Rows
                        oEquipoLinea = New Equipo
                        oEquipoLinea.Cve_Equipo = row("cve_equipo")
                        oEquipoLinea.Cargar()
                        Me.vLEquipos_Linea_Asignados.Add(oEquipoLinea)
                    Next
                End If
            End If
            Return Me.vLEquipos_Linea_Asignados
        End Get
        Set(ByVal value As List(Of Equipo))
            Me.vLEquipos_Linea_Asignados = value
        End Set
    End Property


#End Region

#Region "Metodos Generales"
    Public Function Obtener_Lineas(Optional ByVal vFiltro_Modelo As Long = 0) As DataTable
        Dim vDT As DataTable
        If vFiltro_Modelo = 0 Then
            vDT = oBD.ObtenerTabla("select * from Linea where estatus='1'")
        Else
            vDT = oBD.ObtenerTabla("select * from Linea where estatus='1' and cve_componente=" & vFiltro_Modelo)
        End If
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function

    Public Function Obtener_Lineas(ByVal vFiltro As String, Optional ByVal vFiltro_Modelo As Long = 0) As DataTable
        Dim vDT As DataTable
        If vFiltro_Modelo = 0 Then
            vDT = oBD.ObtenerTabla("select * from Linea where estatus='1' and linea LIKE '%" & vFiltro & "%'")
        Else
            vDT = oBD.ObtenerTabla("select * from Linea where estatus='1' and cve_componente=" & vFiltro_Modelo & " and linea LIKE '%" & vFiltro & "%'")
        End If
        If vDT IsNot Nothing Then

        Else
            vDT = Nothing
        End If
        Return vDT
    End Function


    Public Function Obtener_CVEComponente_EN_Linea(ByVal vCve_Linea As Long) As Long
        Dim vRetorno As Long
        Dim vDR As DataRow

        vDR = oBD.ObtenerRenglon("Select cve_componente from linea where cve_linea=" & vCve_Linea, "Componente")
        If vDR IsNot Nothing Then
            vRetorno = vDR("cve_componente")
        Else
            vRetorno = 0
        End If

        Return vRetorno
    End Function

#End Region

#Region "Metodos Formulario de Produccion"
    Public Function llena_combo_lineas() As DataTable
        Dim dtTurnos As New DataTable
        Try
            dtTurnos = oBD.ObtenerTabla("select l.cve_linea,l.linea from linea l join equipo_linea el on l.cve_linea=el.cve_linea where el.cve_equipo=" & vcve_linea)
        Catch ex As Exception
            MsgBox("Error al eliminar produccion. CLineas_ERROR", vbCritical + vbOKOnly, "Error")
            dtTurnos = Nothing
        End Try
        Return dtTurnos
    End Function
#End Region
End Class
