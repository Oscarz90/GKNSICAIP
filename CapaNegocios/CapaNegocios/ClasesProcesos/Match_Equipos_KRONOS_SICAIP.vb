Imports CapaDatos
Imports System.Transactions

Public Class Match_Equipos_KRONOS_SICAIP

    Dim cadena_conexion As New CapaDatos.conexiones    
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)    
    Dim oBD_Kronos As New CapaDatos.CapaDatos(cadena_conexion.CadenaKronos)
    Dim oEquipo As Equipo

    Dim vDatosSICAIP As DataTable
    Dim vDatosKRONOS As DataTable

    Dim vCveS_Equipos_En_SICAIP() As String


    Public Function Obtener_Equipos_KRONOS() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD_Kronos.ObtenerTabla("SELECT name AS cve, description AS nombre FROM VR_LABORLEVEL WHERE LLDEF_SHORTNAME='EQU' AND name != '-' and name != 'Default'")
        Catch ex As Exception
            vRetorno = Nothing
        End Try

        Return vRetorno
    End Function

    Public Function Obtener_Equipos_SICAIP() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT cve_equipo_kronos AS cve, equipo AS nombre FROM Equipo")
        Catch ex As Exception
            vRetorno = Nothing
        End Try

        Return vRetorno
    End Function


    Private Sub Actualizar_Nombre_Equipo(ByVal vCve_Equipo As Integer, ByVal vNombre_Nuevo As String)
        oEquipo = New Equipo
        Try
            oEquipo.Cve_Equipo = oEquipo.Obtener_Id(vCve_Equipo.ToString)
            oEquipo.Cargar()
            oEquipo.Equipo = vNombre_Nuevo
            oEquipo.Registrar()
        Catch ex As Exception

        End Try      
    End Sub

    Private Function Nombres_Equipos_Diferentes(ByVal vName_SICAIP As String, ByVal vName_KRONOS As String) As Boolean
        Dim vRetorno As Boolean = False

        If vName_SICAIP = vName_KRONOS Then
            vRetorno = False
        Else
            vRetorno = True
        End If
        Return vRetorno
    End Function

    Private Sub Obtener_Equipos_Nuevos()
        Dim vDT_SICAIP As DataTable
        Dim vDT_KRONOS As DataTable

        vDT_KRONOS = vDatosKRONOS
        vDT_SICAIP = vDatosSICAIP

        Dim vDT_Equipos_Nuevos As DataTable

        Try
            'vDT_SICAIP = Obtener_Equipos_SICAIP()
            'vDT_KRONOS = Obtener_Equipos_KRONOS()

            If vDT_KRONOS.Rows.Count > vDT_SICAIP.Rows.Count Then
                ''------------------------------------------------------------------------
                ''-----Mandar mensaje de que se encontro un equipo nuevo
                ''------------------------------------------------------------------------
                vDT_Equipos_Nuevos = oBD_Kronos.ObtenerTabla(CrearConsultaKronos_filtrado_Equipos)
                oEquipo = New Equipo

                For Each vDR_Nuevo_Equipo As DataRow In vDT_Equipos_Nuevos.Rows
                    oEquipo.Cve_Equipo = 0
                    oEquipo.Cve_Equipo_Kronos = vDR_Nuevo_Equipo("cve")
                    oEquipo.Cve_Lider = 0
                    oEquipo.Cve_Detalle = 0
                    oEquipo.Equipo = vDR_Nuevo_Equipo("nombre")
                    oEquipo.LETT = ""
                    oEquipo.Ruta_Imagen = ""
                Next
            Else
                ''------------------------------------------------------------------------
                ''-----Mandar mensaje de que se no se encontro equipos nuevos en KRONOS
                ''------------------------------------------------------------------------
            End If
        Catch ex As Exception
            MsgBox("Error al obtener Equipos Nuevos")
        End Try
    End Sub

    

    Public Sub Hacer_Match()
        Dim vDT_SICAIP As DataTable
        Dim vDT_KRONOS As DataTable
        Dim vDR_S As DataRow
        Dim vIndice As Integer = 0

        Try
            vDT_SICAIP = Obtener_Equipos_SICAIP()
            vDT_KRONOS = Obtener_Equipos_KRONOS()

            vDatosKRONOS = vDT_KRONOS
            vDatosSICAIP = vDT_SICAIP
        Catch ex As Exception

        End Try

        Using scope As New TransactionScope()
            Try                
                If IsNothing(vDT_KRONOS) = False And IsNothing(vDT_SICAIP) = False Then
                    ''Recorrer Todos los equipos de SICAIP
                    ReDim vCveS_Equipos_En_SICAIP(vDT_SICAIP.Rows.Count)

                    For Each oDR_SICAIP As DataRow In vDT_SICAIP.Rows
                        vDR_S = oDR_SICAIP
                        vCveS_Equipos_En_SICAIP(vIndice) = vDR_S("cve").ToString
                        For Each oDR_KRONOS As DataRow In vDT_KRONOS.Rows
                            If vDR_S("cve") = oDR_KRONOS("cve") Then
                                If Nombres_Equipos_Diferentes(vDR_S("nombre"), oDR_KRONOS("nombre")) = True Then

                                    Actualizar_Nombre_Equipo(vDR_S("cve"), oDR_KRONOS("nombre"))
                                    ''------------------------------------------------------------------------
                                    ''-----Mandar mensaje de que se actualizo un equipo en SICAIP
                                    ''------------------------------------------------------------------------
                                    Exit For
                                End If
                            End If
                        Next
                        vIndice = vIndice + 1
                    Next
                    ''------------------------------------------------------------------------
                    ''-----Mandar mensaje de que se buscaran Equipos Nuevos
                    ''------------------------------------------------------------------------
                    Obtener_Equipos_Nuevos()
                End If
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al hacer Match de Equipos con Kronos")
            End Try
        End Using
    End Sub

    Public Function CrearConsultaKronos_filtrado_Equipos() As String
        Dim vretorno As String = "SELECT name AS cve, description AS nombre FROM VR_LABORLEVEL WHERE LLDEF_SHORTNAME='EQU' AND name != '-' AND name != 'Default'"

        If vCveS_Equipos_En_SICAIP.Length > 0 Then
            For Each vEmpleado As String In vCveS_Equipos_En_SICAIP
                vretorno = vretorno & " OR name != '" & vEmpleado & "' "
            Next            
        End If
        Return vretorno
    End Function


End Class
