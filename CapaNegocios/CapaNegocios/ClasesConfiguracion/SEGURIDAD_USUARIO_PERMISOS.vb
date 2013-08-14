Imports CapaDatos

Public Class SEGURIDAD_USUARIO_PERMISOS
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)

#Region "Atributos"
    Private vCVE_Usuario_Permisos As Long
    Private vCVE_USUARIO As Long
    Private vCVE_PERMISO As Long
#End Region

#Region "Propiedades"
    Public Property CVE_Usuario_Permisos() As Long Implements IIndividual.Id
        Get
            Return vCVE_Usuario_Permisos
        End Get
        Set(ByVal value As Long)
            vCVE_Usuario_Permisos = value
        End Set
    End Property

    Public Property CVE_USUARIO() As Long
        Get
            Return vCVE_USUARIO
        End Get
        Set(ByVal value As Long)
            vCVE_USUARIO = value
        End Set
    End Property

    Public Property CVE_PERMISO() As Long
        Get
            Return vCVE_PERMISO
        End Get
        Set(ByVal value As Long)
            vCVE_PERMISO = value
        End Set
    End Property
#End Region

#Region "IIndividual"


    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_USUARIO_PERMISOS WHERE CVE_Usuario_Permisos=" & vCVE_Usuario_Permisos, "SEGURIDAD_USUARIO_PERMISOS")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Usuario_Permisos")) Then
                    Me.vCVE_Usuario_Permisos = rDatos("CVE_Usuario_Permisos")
                Else
                    Me.vCVE_Usuario_Permisos = 0
                End If               
                If Not IsDBNull(rDatos("CVE_USUARIO")) Then
                    Me.vCVE_USUARIO = rDatos("CVE_USUARIO")
                Else
                    Me.vCVE_USUARIO = 0
                End If
                If Not IsDBNull(rDatos("CVE_PERMISO")) Then
                    Me.vCVE_PERMISO = rDatos("CVE_PERMISO")
                Else
                    Me.vCVE_PERMISO = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar

    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 0
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_USUARIO_PERMISOS"

                With cmd.Parameters
                    .Add("CVE_Usuario_Permisos", SqlDbType.BigInt).Value = Me.vCVE_Usuario_Permisos
                    .Add("CVE_USUARIO", SqlDbType.BigInt).Value = Me.vCVE_USUARIO
                    .Add("CVE_PERMISO", SqlDbType.BigInt).Value = Me.vCVE_PERMISO
                End With

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCVE_USUARIO = obj.Rows(0)(0) 'ID
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



End Class
