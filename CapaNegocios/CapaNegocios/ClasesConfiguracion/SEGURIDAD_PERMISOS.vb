Imports CapaDatos
Public Class SEGURIDAD_PERMISOS
    Implements IIndividual

    Dim cadena_conexion As New CapaDatos.conexiones
    Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)




#Region "IIndividual"
    Public Sub Cargar() Implements IIndividual.Cargar
        Dim rDatos As DataRow = Nothing
        Try
            rDatos = oBD.ObtenerRenglon("SELECT * FROM SEGURIDAD_PERMISOS WHERE CVE_Permiso=" & vCve_Permiso, "SEGURIDAD_PERMISOS")
            If rDatos IsNot Nothing Then
                If Not IsDBNull(rDatos("CVE_Permiso")) Then
                    Me.vCve_Permiso = rDatos("CVE_Permiso")
                Else
                    Me.vCve_Permiso = 0
                End If
                If Not IsDBNull(rDatos("Descripcion")) Then
                    Me.vDescripcion = rDatos("Descripcion")
                Else
                    Me.vDescripcion = ""
                End If
                If Not IsDBNull(rDatos("Nombre_Corto")) Then
                    Me.vNombre_Corto = rDatos("Nombre_Corto")
                Else
                    Me.vNombre_Corto = ""
                End If
                If Not IsDBNull(rDatos("CVE_CATEGORIA_PERMISO")) Then
                    Me.vCVE_CATEGORIA_PERMISO = rDatos("CVE_CATEGORIA_PERMISO")
                Else
                    Me.vCVE_CATEGORIA_PERMISO = 0
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub Eliminar() Implements IIndividual.Eliminar
        ''If Usuario.ChecaPermisoTarea("TELEFONO.ELIMINAR") Then
        'Try
        '    oBD.EjecutarQuery("DELETE SEGURIDAD_PERMISOS WHERE CVE_Permiso=" & Me.vCve_Permiso)
        '    MsgBox("Se elimino correctamente el Tipo de Usuario")
        '    'Dim oBitacora As Bitacora = Bitacora.ObtenInstancia
        '    'oBitacora.RegistrarEnBitacora("Telefono.ELIMINAR", "Se eliminó el Teléfono: " & Me.m_Telefono_Id)
        'Catch ex As Exception
        '    MsgBox("No se puede eliminar este registro, el Permiso se encuentra asignado en un Usuario")
        '    'Tiene relacion con otras partes del sistema
        '    'Throw New CustomException(Errores.Eliminar)
        'End Try
        ''Else
        ''Throw New CustomException(Errores.Permiso)
        ''End If
    End Sub

    Public Function Obtener_Id(ByVal vCadena As String) As Long Implements IIndividual.Obtener_Id
        Return 1
    End Function

    Public Sub Registrar() Implements IIndividual.Registrar
        'Using scope As New TransactionScope()
        '    Try
        '        Dim cmd As New SqlClient.SqlCommand
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.CommandText = "REGISTRAR_SEGURIDAD_TIPO_USUARIO"

        '        With cmd.Parameters
        '            .Add("CVE_Tipo_Usuario", SqlDbType.BigInt).Value = Me.vCVE_Tipo_Usuario
        '            .Add("Nombre_Tipo_Usuario", SqlDbType.VarChar).Value = Me.vNombre_Tipo_Usuario
        '        End With

        '        Dim obj As DataTable = oBD.EjecutaCommando(cmd)
        '        Me.vCVE_Tipo_Usuario = obj.Rows(0)(0) 'ID
        '        'Me.RegistraDatos("DEPARTAMENTO", "Departamento_Id", Me.m_Departamento_Id)
        '        'Dim oBitacora As Bitacora = Bitacora.ObtenInstancia
        '        'oBitacora.RegistrarEnBitacora("DEPARTAMENTO.REGISTRAR", "Se registró el departamento: " & Me.m_Nombre)
        '        scope.Complete()
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    End Try
        'End Using
    End Sub
#End Region


#Region "Atributos"
    Private vCve_Permiso As Long
    Private vDescripcion As String
    Private vNombre_Corto As String
    Private vCVE_CATEGORIA_PERMISO As Integer
#End Region


#Region "Propiedades"
    Public Property Cve_Permiso() As Long Implements IIndividual.Id
        Get
            Return vCve_Permiso
        End Get
        Set(ByVal value As Long)
            vCve_Permiso = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property

    Public Property Nombre_Corto() As String
        Get
            Return vNombre_Corto
        End Get
        Set(ByVal value As String)
            vNombre_Corto = value
        End Set
    End Property

    Public Property CVE_CATEGORIA_PERMISO() As Integer
        Get
            Return vCVE_CATEGORIA_PERMISO
        End Get
        Set(ByVal value As Integer)
            vCVE_CATEGORIA_PERMISO = value
        End Set
    End Property
#End Region
End Class
