﻿Imports CapaDatos

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
                If Not IsDBNull(rDatos("Estatus")) Then
                    Me.vEstatus = rDatos("Estatus")
                Else
                    Me.vEmail = ""
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
            MsgBox("La Baja de Usuario se realizo correctamente")
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
                cmd.CommandText = "REGISTRAR_SEGURIDAD_USUARIO"

                With cmd.Parameters
                    .Add("CVE_Usuario", SqlDbType.BigInt).Value = Me.vCVE_Usuario
                    .Add("Id_Usuario", SqlDbType.VarChar).Value = Me.vId_Usuario
                    .Add("Pass", SqlDbType.VarChar).Value = Me.vPass
                    .Add("Nombre", SqlDbType.VarChar).Value = Me.vNombre
                    .Add("Email", SqlDbType.VarChar).Value = Me.vEmail
                    .Add("CVE_TIPO_USUARIO", SqlDbType.BigInt).Value = Me.vCVE_TIPO_USUARIO
                    .Add("Estatus", SqlDbType.VarChar).Value = Me.vEstatus
                End With

                Dim obj As DataTable = oBD.EjecutaCommando(cmd)
                Me.vCVE_Usuario = obj.Rows(0)(0) 'ID
                MsgBox("El Usuario se registro Correctamente")
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
    Private vEstatus As String
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
                oTipo_Usuario = New Tipo_Usuario
                oTipo_Usuario.CVE_Tipo_Usuario = vCVE_TIPO_USUARIO
                oTipo_Usuario.Cargar()
                Return oTipo_Usuario.Nombre_Tipo_Usuario
            Else
                Return ""
            End If
        End Get
    End Property
    Public Property Estatus() As String
        Get
            If vEstatus = "1" Then
                Return "ACTIVO"
            ElseIf vEstatus = "0" Then
                Return "INACTIVO"
            End If
            Return vEstatus
        End Get
        Set(ByVal value As String)
            vEstatus = value
        End Set
    End Property

    Private vL_USUARIO_PERMISOS As List(Of SEGURIDAD_USUARIO_PERMISOS)
    Public Property L_USUARIO_PERMISOS() As List(Of SEGURIDAD_USUARIO_PERMISOS)
        Get
            If vL_USUARIO_PERMISOS Is Nothing Then
                'Cargo documentos
                Me.L_USUARIO_PERMISOS = New List(Of SEGURIDAD_USUARIO_PERMISOS)
                Dim oBD As New CapaDatos.CapaDatos(cadena_conexion.CadenaSicaip)
                Dim oEq As DataTable = oBD.ObtenerTabla("SELECT CVE_Usuario_Permisos FROM SEGURIDAD_USUARIO_PERMISOS WHERE CVE_USUARIO= " & vCVE_Usuario)
                If oEq IsNot Nothing Then
                    Dim oUSUARIO_PERMISOS As SEGURIDAD_USUARIO_PERMISOS = Nothing
                    For Each row As DataRow In oEq.Rows
                        oUSUARIO_PERMISOS = New SEGURIDAD_USUARIO_PERMISOS
                        oUSUARIO_PERMISOS.CVE_Usuario_Permisos = row("CVE_Usuario_Permisos")
                        oUSUARIO_PERMISOS.Cargar()
                        Me.vL_USUARIO_PERMISOS.Add(oUSUARIO_PERMISOS)
                    Next
                End If
            End If
            Return Me.vL_USUARIO_PERMISOS
        End Get
        Set(ByVal value As List(Of SEGURIDAD_USUARIO_PERMISOS))
            Me.vL_USUARIO_PERMISOS = value
        End Set
    End Property
#End Region

#Region "Metodos Generales"

#Region "Obtencion de Informacion para Arboles"
    Public Function Obtener_TIPOS_USUARIOS() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_TIPO_USUARIO")
            If vRetorno.Rows.Count = 0 Then
                vRetorno = Nothing
            End If
        Catch ex As Exception
            vRetorno = Nothing
        End Try
        Return vRetorno
    End Function

    Public Function Obtener_USUARIOS(ByVal vCVE_TIPO_USUARIO As Long) As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_USUARIO WHERE ESTATUS='1' and CVE_TIPO_USUARIO=" & vCVE_TIPO_USUARIO)
            If vRetorno.Rows.Count = 0 Then
                vRetorno = Nothing
            End If
        Catch ex As Exception
            vRetorno = Nothing
        End Try
        Return vRetorno
    End Function


    Public Function Obtener_Categoria_Permisos() As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_CATEGORIA_PERMISO WHERE Categoria_Sup_Id is null")
            If vRetorno.Rows.Count = 0 Then
                vRetorno = Nothing
            End If
        Catch ex As Exception
            vRetorno = Nothing
        End Try
        Return vRetorno
    End Function

    Public Function Obtener_HIJOS_Categoria_Permisos(ByVal vCategoria_Sup_Id As Integer) As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_CATEGORIA_PERMISO WHERE Categoria_Sup_Id= " & vCategoria_Sup_Id)
            If vRetorno.Rows.Count = 0 Then
                vRetorno = Nothing
            End If
        Catch ex As Exception
            vRetorno = Nothing
        End Try
        Return vRetorno
    End Function

    Public Function Obtener_PERMISOS(ByVal vCVE_Categoria_Permiso As Long) As DataTable
        Dim vRetorno As DataTable
        Try
            vRetorno = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_PERMISOS WHERE CVE_CATEGORIA_PERMISO=" & vCVE_Categoria_Permiso)
            If vRetorno.Rows.Count = 0 Then
                vRetorno = Nothing
            End If
        Catch ex As Exception
            vRetorno = Nothing
        End Try
        Return vRetorno
    End Function
#End Region

#Region "Tablas listas para Arboles"
    Public Function Obtener_Arbol_Usuarios() As DataTable
        Dim vDT As DataTable = New DataTable("USUARIOS")
        Crear_Tabla_Arbol(vDT)

        Dim vIdetificador_Nodo As Integer = 1
        Dim vIdetificador_Padre As Integer = 1
        If Obtener_TIPOS_USUARIOS() IsNot Nothing Then
            For Each vDR_Tipos As DataRow In Obtener_TIPOS_USUARIOS.Rows
                Dim vDR_Nuevo As DataRow
                vDR_Nuevo = vDT.NewRow
                vDR_Nuevo("NombreNodo") = vDR_Tipos("Nombre_Tipo_Usuario")
                vDR_Nuevo("IdentificadorNodo") = vIdetificador_Nodo
                vDR_Nuevo("IdentificadorPadre") = 0
                vDR_Nuevo("CVE_TABLA") = vDR_Tipos("CVE_Tipo_Usuario") & ".TU"

                ''Inserta el Tipo de Usuario
                vDT.Rows.Add(vDR_Nuevo)

                vIdetificador_Padre = vDR_Nuevo("IdentificadorNodo")
                If Obtener_USUARIOS(vDR_Tipos("CVE_Tipo_Usuario")) IsNot Nothing Then
                    For Each vDR_USUARIOS As DataRow In Obtener_USUARIOS(vDR_Tipos("CVE_Tipo_Usuario")).Rows
                        ''Incrementa el Identificador del Nodo
                        vIdetificador_Nodo = vIdetificador_Nodo + 1

                        Dim vDR_Nuevo_USUARIO As DataRow
                        vDR_Nuevo_USUARIO = vDT.NewRow

                        vDR_Nuevo_USUARIO("NombreNodo") = vDR_USUARIOS("Id_Usuario")
                        vDR_Nuevo_USUARIO("IdentificadorNodo") = vIdetificador_Nodo
                        vDR_Nuevo_USUARIO("IdentificadorPadre") = vIdetificador_Padre
                        vDR_Nuevo_USUARIO("CVE_TABLA") = vDR_USUARIOS("CVE_Usuario") & ".U"
                        ''Inserta el Usuario
                        vDT.Rows.Add(vDR_Nuevo_USUARIO)
                    Next
                    ''Incrementa el Identificador del Nodo
                    vIdetificador_Nodo = vIdetificador_Nodo + 1
                Else
                    ''Incrementa el Identificador del Nodo
                    vIdetificador_Nodo = vIdetificador_Nodo + 1
                End If
            Next
        End If        
        Return vDT
    End Function

    Public Function Obtener_Arbol_Permisos() As DataTable
        Dim vDT As DataTable = New DataTable("PERMISOS")
        Crear_Tabla_Arbol(vDT)

        Dim vIdetificador_Nodo As Integer = 1
        Dim vIdetificador_Padre As Integer = 1

        If Obtener_Categoria_Permisos() IsNot Nothing Then
            For Each vDR_Categoria_Permiso As DataRow In Obtener_Categoria_Permisos.Rows
                ''En este primer ciclo se Obtienen las Categorias de Permisos con IDSuperior = Null (Nivel 1)
                Dim vDR_Nuevo As DataRow
                vDR_Nuevo = vDT.NewRow
                vDR_Nuevo("NombreNodo") = vDR_Categoria_Permiso("Nombre_Categoria")
                vDR_Nuevo("IdentificadorNodo") = vIdetificador_Nodo
                vDR_Nuevo("CVE_TABLA") = vDR_Categoria_Permiso("CVE_Categoria_Permiso") & ".CP"
                vDR_Nuevo("IdentificadorPadre") = 0
                ''Inserta el Tipo de Usuario
                vDT.Rows.Add(vDR_Nuevo)

                vIdetificador_Padre = vDR_Nuevo("IdentificadorNodo")

                For Each vDR_HIJOS_Categoria_Permiso As DataRow In Obtener_HIJOS_Categoria_Permisos(vDR_Categoria_Permiso("CVE_Categoria_Permiso")).Rows
                    ''En este ciclo se obtienen las Categorias de Permisos Anidados(Hijos) (Nivel 2)
                    ''Incrementa el Identificador del Nodo
                    vIdetificador_Nodo = vIdetificador_Nodo + 1

                    Dim vDR_Nuevo_HIJO_TIPO As DataRow
                    vDR_Nuevo_HIJO_TIPO = vDT.NewRow

                    vDR_Nuevo_HIJO_TIPO("NombreNodo") = vDR_HIJOS_Categoria_Permiso("Nombre_Categoria")
                    vDR_Nuevo_HIJO_TIPO("IdentificadorNodo") = vIdetificador_Nodo
                    vDR_Nuevo_HIJO_TIPO("IdentificadorPadre") = vDR_Nuevo("IdentificadorNodo")
                    vDR_Nuevo_HIJO_TIPO("CVE_TABLA") = vDR_HIJOS_Categoria_Permiso("CVE_Categoria_Permiso") & ".CP2"
                    ''Inserta el HIJO_TIPO_PERMISO
                    vDT.Rows.Add(vDR_Nuevo_HIJO_TIPO)

                    vIdetificador_Padre = vDR_Nuevo_HIJO_TIPO("IdentificadorNodo")

                    For Each vDR_USUARIOS As DataRow In Obtener_PERMISOS(vDR_HIJOS_Categoria_Permiso("CVE_Categoria_Permiso")).Rows
                        ''Incrementa el Identificador del Nodo
                        vIdetificador_Nodo = vIdetificador_Nodo + 1

                        Dim vDR_Nuevo_USUARIO As DataRow
                        vDR_Nuevo_USUARIO = vDT.NewRow

                        vDR_Nuevo_USUARIO("NombreNodo") = vDR_USUARIOS("Descripcion")
                        vDR_Nuevo_USUARIO("IdentificadorNodo") = vIdetificador_Nodo
                        vDR_Nuevo_USUARIO("IdentificadorPadre") = vDR_Nuevo_HIJO_TIPO("IdentificadorNodo")
                        vDR_Nuevo_USUARIO("CVE_TABLA") = vDR_USUARIOS("CVE_Permiso") & ".P"
                        ''Inserta el Usuario
                        vDT.Rows.Add(vDR_Nuevo_USUARIO)
                    Next
                    ''Incrementa el Identificador del Nodo
                    vIdetificador_Nodo = vIdetificador_Nodo + 1
                Next
                ''Incrementa el Identificador del Nodo
                vIdetificador_Nodo = vIdetificador_Nodo + 1
            Next
        End If       
        Return vDT
    End Function

    Private Sub Crear_Tabla_Arbol(ByRef vDT As DataTable)
        ' Create a DataColumn and set various properties. 
        Dim column As DataColumn = New DataColumn
        column.DataType = System.Type.GetType("System.String")
        column.AllowDBNull = False
        column.Caption = "NombreNodo"
        column.ColumnName = "NombreNodo"
        column.DefaultValue = ""

        Dim vColumn2 As DataColumn = New DataColumn
        vColumn2.DataType = System.Type.GetType("System.Int64")
        vColumn2.AllowDBNull = False
        vColumn2.Caption = "IdentificadorNodo"
        vColumn2.ColumnName = "IdentificadorNodo"
        vColumn2.DefaultValue = 0

        Dim vColumn3 As DataColumn = New DataColumn
        vColumn3.DataType = System.Type.GetType("System.Int64")
        vColumn3.AllowDBNull = False
        vColumn3.Caption = "IdentificadorPadre"
        vColumn3.ColumnName = "IdentificadorPadre"
        vColumn3.DefaultValue = 0

        Dim vColumn4 As DataColumn = New DataColumn
        vColumn4.DataType = System.Type.GetType("System.String")
        vColumn4.AllowDBNull = False
        vColumn4.Caption = "CVE_TABLA"
        vColumn4.ColumnName = "CVE_TABLA"
        vColumn4.DefaultValue = ""

        ' Add the column to the table. 
        vDT.Columns.Add(column)
        vDT.Columns.Add(vColumn2)
        vDT.Columns.Add(vColumn3)
        vDT.Columns.Add(vColumn4)
    End Sub

#End Region

    Public Function Obtener_Permisos_Usuario(ByVal vCve_Usuario_P As Long) As DataTable
        Dim vDT As DataTable
        Try
            vDT = oBD.ObtenerTabla("SELECT * FROM SEGURIDAD_USUARIO_PERMISOS WHERE CVE_USUARIO=" & vCve_Usuario_P)
            If vDT.Rows.Count = 0 Then
                vDT = Nothing
            End If
        Catch ex As Exception
            vDT = Nothing
        End Try

        Return vDT
    End Function

    Public Sub Registrar_Permisos()
        Using scope As New TransactionScope()
            Try
                oBD.EjecutarQuery("DELETE FROM SEGURIDAD_USUARIO_PERMISOS WHERE CVE_USUARIO=" & vCVE_Usuario)
                If vL_USUARIO_PERMISOS IsNot Nothing Then
                    For i As Integer = 0 To vL_USUARIO_PERMISOS.Count - 1
                        If vL_USUARIO_PERMISOS.Item(i).CVE_Usuario_Permisos = 0 Then
                            oBD.EjecutarQuery("INSERT INTO SEGURIDAD_USUARIO_PERMISOS(CVE_USUARIO,CVE_PERMISO) VALUES(" & vCVE_Usuario & ", " & vL_USUARIO_PERMISOS.Item(i).CVE_PERMISO & ")")
                        End If
                    Next
                End If
                scope.Complete()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Public Function Usuario_NO_Sindicalizado(ByVal vNombreUsuario_Login As String) As Boolean
        Dim vRetorno As Boolean = False
        Dim vDR As DataRow
        Try
            vDR = oBD.ObtenerRenglon("select CVE_Usuario from SEGURIDAD_USUARIO where estatus=1 and Id_Usuario ='" & vNombreUsuario_Login & "'", "SEGU_USUARIO")
            If vDR IsNot Nothing Then
                vRetorno = True
                CVE_Usuario = vDR("CVE_Usuario")
            Else
                vRetorno = False
            End If
        Catch ex As Exception
            'MsgBox("El empleado no está activo en KRONOS. Clave del Error: LIN_001", vbCritical + vbOKOnly, "Error")
        End Try
        Return vRetorno
    End Function
#End Region

End Class
