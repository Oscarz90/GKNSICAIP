Imports CapaDatos
Imports System.Transactions

Public Class Match_Equipos_KRONOS_SICAIP

    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oBD_KRONOS As New CapaDatos.CapaDatos(cadena_conexion.CadenaKronos)
    Dim oEquipo As Equipo

    Dim vCveS_Equipos_En_SICAIP() As String


    Public Function Obtener_Equipos_KRONOS() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD_KRONOS.ObtenerTabla("")
        Catch ex As Exception
            vRetorno = Nothing
        End Try

        Return vRetorno
    End Function

    Public Function Obtener_Equipos_SICAIP() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("")
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

        Try
            vDT_SICAIP = Obtener_Equipos_SICAIP()
            vDT_KRONOS = Obtener_Equipos_KRONOS()

            If vDT_KRONOS.Rows.Count > vDT_SICAIP.Rows.Count Then
                ''------------------------------------------------------------------------
                ''-----Mandar mensaje de que se encontro un equipo nuevo
                ''------------------------------------------------------------------------

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

        Using scope As New TransactionScope()
            Try
                vDT_SICAIP = Obtener_Equipos_SICAIP()
                vDT_KRONOS = Obtener_Equipos_KRONOS()

                ''Recorrer Todos los equipos de SICAIP
                For Each oDR_SICAIP As DataRow In vDT_SICAIP.Rows
                    vDR_S = oDR_SICAIP
                    vCveS_Equipos_En_SICAIP.SetValue(vDR_S("cve"), vIndice)

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
                scope.Complete()
            Catch ex As Exception
                MsgBox("Error al hacer Match de Equipos con Kronos")
            End Try
        End Using
    End Sub

    Public Function CrearConsultaKronos_filtrado_Equipos() As String
        Dim vretorno As String = ""

        If vCveS_Equipos_En_SICAIP.Length > 0 Then




        Else
            'Consulta sin condiciones
            vretorno = ""
        End If



        Return vretorno
    End Function


End Class
