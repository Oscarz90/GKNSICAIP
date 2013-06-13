Imports CapaDatos
Imports System.ComponentModel
Imports System.Transactions
Imports System.IO

Namespace Configuracion
    Public Class Manejo_Archivos

        ''' <summary>
        ''' Elimina un archivo fisico, con solo proporcionar la ruta del archivo
        ''' </summary>
        ''' <param name="vRuta_Archivo">Cadena de la ruta del archivo a borrar(Se requiere que en el directorio contenga el archivo a eliminar con su extencion). Ejemplo: C:\Archivo_Eliminar.txt</param>
        ''' <remarks></remarks>
        Public Sub Eliminar_Archivo_Fisico(ByVal vRuta_Archivo)
            Dim fso
            On Error Resume Next
            fso = CreateObject("Scripting.FileSystemObject")
            fso.deletefile(vRuta_Archivo)
        End Sub

        ''' <summary>
        ''' Comprueba que el directorio exista
        ''' </summary>
        ''' <param name="vRuta_Verificar">Cadena de la ruta del directorio a verificar. Ejemplo: C:\Directorio_Verificar</param>
        ''' <returns>Retorna un True si el directorio existe</returns>
        ''' <remarks></remarks>
        Public Function Existe_Directorio(ByVal vRuta_Verificar As String) As Boolean
            ' Directory  
            Dim vExiste As Boolean = False
            If Directory.Exists(vRuta_Verificar) Then
                'MsgBox("La carpeta existe", MsgBoxStyle.Information)
                vExiste = True
            Else
                'MsgBox("No existe", MsgBoxStyle.Information)
                vExiste = False
            End If
            Return vExiste
        End Function

        ''' <summary>
        ''' Comprueba que el archivo exista, mediante su direccion. Ejemplo: C:\Archivo.txt
        ''' </summary> 
        ''' (Se requiere que en el directorio contenga el archivo a eliminar con su extencion). Ejemplo: C:\Archivo_Eliminar.txt
        ''' <param name="vRuta_Archivo_Verificar">Cadena de la ruta del archivo a verificar(Se requiere que en el directorio contenga el archivo a verificar con su extencion). Ejemplo: C:\Archivo_Verificar.txt</param>
        ''' <returns>Retorna un True si el archivo existe</returns>
        ''' <remarks></remarks>
        Public Function Existe_Archivo(ByVal vRuta_Archivo_Verificar As String) As Boolean
            Dim vExiste As Boolean = False
            If File.Exists(vRuta_Archivo_Verificar) Then
                'MsgBox("Existe", MsgBoxStyle.Information)
                vExiste = True
            Else
                'MsgBox("No existe", MsgBoxStyle.Information)
                vExiste = False
            End If
            Return vExiste
        End Function

        ''' <summary>
        ''' Renombra un archivo.
        ''' </summary>
        ''' <param name="vRuta_Archivo">Cadena de la ruta del archivo a renombrar(Se requiere que en el directorio contenga el archivo a renombrar con su extencion). Ejemplo: C:\Archivo.txt</param>
        ''' <param name="vNombre_Nuevo_Archivo">Nombre nuevo para renombrar el archivo(Se requiere la extencion del archivo). Ejemplo: Nombre_Nuevo.txt</param>
        ''' <remarks></remarks>
        Public Sub Renombrar_Archivo(ByVal vRuta_Archivo As String, ByVal vNombre_Nuevo_Archivo As String)
            Try
                ' Renombrarlo con la función renameFile  
                My.Computer.FileSystem.RenameFile(vRuta_Archivo, vNombre_Nuevo_Archivo)
            Catch ex As Exception
                'MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub

        ''' <summary>
        ''' Mueve un archivo de directorio
        ''' </summary>
        ''' <param name="vRuta_Archivo_Origen">Directorio del archivo a mover(Se requiere que en el directorio contenga el archivo a mover con su extencion). Ejemplo: C:\Archivo_A_Mover.txt</param>
        ''' <param name="vRuta_Destino">Directorio destino del archivo(Se requiere que en el directorio contenga el archivo a mover con su extencion). Ejemplo: C:\Directorio_Destino\Archivo_A_Mover.txt </param>
        ''' <remarks></remarks>
        Public Sub Mover_Archivo(ByVal vRuta_Archivo_Origen As String, ByVal vRuta_Destino As String)
            Try
                ' Mover el fichero.si existe lo sobreescribe  
                My.Computer.FileSystem.MoveFile(vRuta_Archivo_Origen, vRuta_Destino, True)
                'MsgBox("Ok.", MsgBoxStyle.Information, "Mover archivo")
                ' errores  
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub

        ''' <summary>
        ''' Elimina un directorio, con opcion de cuadro de diálogo de eliminar de windows para confirmar.
        ''' </summary>
        ''' <param name="vRuta_Eliminar">Cadena del directorio a borrar. Ejemplo: C:\Directorio_Eliminar</param>
        ''' <remarks></remarks>
        Public Sub Eliminar_Directorio(ByVal vRuta_Eliminar As String)
            Try
                My.Computer.FileSystem.DeleteDirectory( _
                    vRuta_Eliminar, _
                    FileIO.UIOption.AllDialogs, _
                    FileIO.RecycleOption.SendToRecycleBin, _
                    FileIO.UICancelOption.DoNothing)
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub

        ''' <summary>
        ''' Elimina un archivo, con opcion de cuadro de diálogo de eliminar de windows para confirmar.
        ''' </summary>
        ''' <param name="vRuta_Archivo">Cadena de la ruta del archivo a borrar(Se requiere que en el directorio contenga el archivo a eliminar con su extencion). Ejemplo: C:\Archivo_Eliminar.txt</param>
        ''' <remarks></remarks>
        Public Sub Eliminar_Archivo(ByVal vRuta_Archivo As String)
            Try
                My.Computer.FileSystem.DeleteFile( _
                    vRuta_Archivo, _
                    FileIO.UIOption.AllDialogs, _
                    FileIO.RecycleOption.SendToRecycleBin, _
                    FileIO.UICancelOption.DoNothing)
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End Sub

        ''' <summary>
        ''' Obtiene la cantidad de archivos dentro de un directorio.
        ''' </summary>
        ''' <param name="vRuta_Verificar">Cadena de la ruta del directorio a verificar. Ejemplo: C:\Directorio_Verificar</param>
        ''' <returns>Objeto con la cantidad de archivos dentro de un directorio</returns>
        ''' <remarks></remarks>
        Public Function Cantidad_Archivos(ByVal vRuta_Verificar As String) As Object
            Dim vCantidad_Archivos As String = ""
            Try
                Dim ContadorDeArchivos As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
                'le indicamos el path que queremos  
                ContadorDeArchivos = My.Computer.FileSystem.GetFiles(vRuta_Verificar)
                'nos devuelve la cantidad de archivos  
                vCantidad_Archivos = (ContadorDeArchivos.Count).ToString
                'MsgBox("La Cantidad de Archivos es: " & CStr(ContadorDeArchivos.Count))
            Catch oExcep As Exception
                MsgBox("Descripción del error : " & _
                       oExcep.Message, MsgBoxStyle.Critical, "Error")
            End Try
            Return vCantidad_Archivos
        End Function

        ''' <summary>
        ''' Permite obtener la extensión de un archivo.
        ''' </summary>
        ''' <param name="vRuta_Archivo_Verificar">Cadena de la ruta del archivo a verificar(Se requiere que en el directorio contenga el archivo a verificar con su extencion). Ejemplo: C:\Archivo_Verificar.txt</param>
        ''' <returns>Extensión del archivo</returns>
        ''' <remarks></remarks>
        Public Function Obtener_Extension_Archivo(ByVal vRuta_Archivo_Verificar As String) As String
            Dim vExtension As String = ""
            Dim Caracter As String = "."
            If Caracter = "." And InStr(vRuta_Archivo_Verificar, Caracter) <> 0 Then
                vExtension = "." & Right(vRuta_Archivo_Verificar, Len(vRuta_Archivo_Verificar) - InStrRev(vRuta_Archivo_Verificar, Caracter))
            End If
            Return vExtension
        End Function

        ''' <summary>
        ''' Obtener solo la Ruta sin el fichero
        ''' </summary>
        ''' <param name="vRuta_Obtener">Ruta con X fichero. Ejemplo: C:\Directorio_Prueba\Archivo.txt</param>
        ''' <returns>Cadena con la ruta. Ejemplo C:\Directorio_Prueba</returns>
        ''' <remarks></remarks>
        Public Function Obtener_Ruta(ByVal vRuta_Obtener As String) As String
            Dim vRuta_Obtenida As String = ""
            Dim Caracter As String = "\"

            If vRuta_Obtener <> "" And Caracter <> "" Then
                vRuta_Obtenida = Left(vRuta_Obtener, InStrRev(vRuta_Obtener, Caracter))
            End If

            Return vRuta_Obtenida
        End Function

        ''' <summary>
        ''' Crea todo un directorio.
        ''' </summary>
        ''' <param name="vDirectorio_A_Crear">Directorio a crear. Ejemplo: Si en C:\ deceas crear un directorio donde contenga: Carpeta1\Carpeta2\..., seria: C:\Carpeta1\Carpeta2\...</param>
        ''' <returns>El directorio creado.</returns>
        ''' <remarks></remarks>
        Public Function Crear_Direcctorio(ByVal vDirectorio_A_Crear As String) As String
            System.IO.Directory.CreateDirectory(vDirectorio_A_Crear)
            Return vDirectorio_A_Crear
        End Function

        ''' <summary>
        ''' Crea una carpeta en el directorio especificado.
        ''' </summary>
        ''' <param name="vDirectorio_Raiz">Directorio donde se desea crear la nueva carpeta</param>
        ''' <param name="vNombre_Nueva_Carpeta">Nombre de la carpeta a crear</param>
        ''' <remarks></remarks>
        Public Sub Crear_Carpeta(ByVal vDirectorio_Raiz As String, ByVal vNombre_Nueva_Carpeta As String)
            Try
                System.IO.Directory.CreateDirectory(vNombre_Nueva_Carpeta)
            Catch ex As Exception
                MsgBox("No se puede crear la carpeta.")
            End Try
        End Sub

        ''' <summary>
        ''' Copia un archivo a una nueva direccion
        ''' </summary>
        ''' <param name="vRutaOrigen">Ruta origen del archivo(Se requiere que en el directorio contenga el archivo a verificar con su extencion). Ejemplo: C:\Carpeta_Origen\Archivo_Verificar.txt</param>
        ''' <param name="vRutaDestino">Ruta destino del archivo(Se requiere que en el directorio contenga el archivo a verificar con su extencion). Ejemplo: C:\Carpeta_Destino\Archivo_Verificar.txt</param>
        ''' <remarks></remarks>
        Public Sub CopiarArchivo(ByVal vRutaOrigen As String, ByVal vRutaDestino As String)
            Try
                System.IO.File.Copy(vRutaOrigen, vRutaDestino, True)
            Catch ex As Exception
                'MsgBox("No se puede copiar el archivo")
                MsgBox(ex.Message)
            End Try
        End Sub

    End Class
End Namespace
