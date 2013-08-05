Imports CapaDatos

Public Class SEGURIDAD_USUARIO
    Implements IIndividual
    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
    Dim oTipo_Usuario As Tipo_Usuario

#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_USUARIO WHERE CVE_Usuario=" & vCVE_Usuario, "SEGURIDAD_USUARIO")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Usuario")) Then
                    Me.vCVE_Usuario = rDatos("CVE_Usuario")
                Else
                    Me.vCVE_Usuario = 0
                End If
                If Not IsDBNull(rDatos("Id_Usuario")) Then
                    Me.vId_Usuario = rDatos("Id_Usuario")
                Else
                    Me.vId_Usuario = ""
                End If
                If Not IsDBNull(rDatos("Pass")) Then
                    Me.vPass = rDatos("Pass")
                Else
                    Me.vPass = ""
                End If
                If Not IsDBNull(rDatos("Nombre")) Then
                    Me.vNombre = rDatos("Nombre")
                Else
                    Me.vNombre = ""
                End If
                If Not IsDBNull(rDatos("Email")) Then
                    Me.vEmail = rDatos("Email")
                Else
                    Me.vEmail = ""
                End If
                If Not IsDBNull(rDatos("CVE_TIPO_USUARIO")) Then
                    Me.vCVE_TIPO_USUARIO = rDatos("CVE_TIPO_USUARIO")
                Else
                    Me.vCVE_TIPO_USUARIO = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        'If Usuario.ChecaPermisoTarea("TELEFONO.ELIMINAR") Then
        Try
            oBD.EjecutarQuery("UPDATE SEGURIDAD_USUARIO SET Estatus='0' WHERE CVE_Usuario=" & Me.vCVE_Usuario)
            'Dim oBitacora As Bitacora = Bitacora.ObtenInstancia
            'oBitacora.RegistrarEnBitacora("Telefono.ELIMINAR", "Se eliminó el Teléfono: " & Me.m_Telefono_Id)
        Catch ex As Exception
            'Tiene relacion con otras partes del sistema
            'Throw New CustomException(Errores.Eliminar)
        End Try
        'Else
        'Throw New CustomException(Errores.Permiso)
        'End If
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        Using scope As New TransactionScope()
            Try
                Dim cmd As New SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "REGISTRAR_USUARIO"

                With cmd.Parameters
                    .Add("CVE_Usuario", SqlDbType.BigInt).Value = Me.vCVE_Usuario
                    .Add("Id_Usuario", SqlDbType.VarChar).Value = Me.vId_Usuario
                    .Add("Pass", SqlDbType.VarChar).Value = Me.vPass
                    .Add("Nombre", SqlDbType.VarChar).Value = Me.vNombre
                    .Add("Email", SqlDbType.VarChar).Value = Me.vEmail
                    .Add("CVE_TIPO_USUARIO", SqlDbType.BigInt).Value = Me.vCVE_TIPO_USUARIO
                End With

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCVE_Usuario = obj.Rows(0)(0) 'ID
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
    Private vCVE_Usuario As Long
    Private vId_Usuario As String
    Private vPass As String
    Private vNombre As String
    Private vEmail As String
    Private vCVE_TIPO_USUARIO As Long
#End Region

#Region "Propiedades"
    Public Property CVE_Usuario() As Long Implements IIndividual.Id
        Get
            Return vCVE_Usuario
        End Get
        Set(ByVal value As Long)
            vCVE_Usuario = value
        End Set
    End Property
    Public Property Id_Usuario() As String
        Get
            Return vId_Usuario
        End Get
        Set(ByVal value As String)
            vId_Usuario = value
        End Set
    End Property
    Public Property Pass() As String
        Get
            Return vPass
        End Get
        Set(ByVal value As String)
            vPass = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal value As String)
            vNombre = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return vEmail
        End Get
        Set(ByVal value As String)
            vEmail = value
        End Set
    End Property
    Public Property CVE_TIPO_USUARIO() As Long
        Get
            Return vCVE_TIPO_USUARIO
        End Get
        Set(ByVal value As Long)
            vCVE_TIPO_USUARIO = value
        End Set
    End Property

    Public ReadOnly Property Descripcion_Tipo_Usuario() As String
        Get
            If vCVE_TIPO_USUARIO <> 0 Then
                oTipo_Usuario.CVE_Tipo_Usuario = vCVE_TIPO_USUARIO
                oTipo_Usuario.Cargar()
                Return oTipo_Usuario.Nombre_Tipo_Usuario
            Else
                Return ""
            End If            
        End Get
    End Property


#End Region
End Class
