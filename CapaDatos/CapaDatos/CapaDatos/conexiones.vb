Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient


Public Class conexiones
    Protected configuracion_SICAIP As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("Conexion_SICAIP")
    Protected configuracion_Kronos As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("Conexion_Kronos")

    Dim cn_SICAIP As New SqlConnection(configuracion_SICAIP.ConnectionString)
    Dim cn_Kronos As New SqlConnection(configuracion_Kronos.ConnectionString)

    Public Sub New()
        '"Data Source= Oscar-PC\SQLExpress; initial Catalog=GKNSICAIP; Integrated Security = True"
        'vCadenaSicaip = "Data Source=JC-PC\SQLEXP2008_R2;Integrated Security=SSPI; Password=sistemas; User ID=sa;Initial Catalog=GKN_SICAIP_V2"
        'vCadenaKronos = "Data Source=JC-PC\SQLEXP2008_R2;Integrated Security=SSPI; Password=sistemas; User ID=sa;Initial Catalog=wtk52db"
        vCadenaSicaip = cn_SICAIP.ConnectionString
        vCadenaKronos = cn_Kronos.ConnectionString
    End Sub

#Region "Propiedades Cadenas de Conexion de Sicaip y Kronos"


    Private vCadenaSicaip As String
    Public Property CadenaSicaip As String
        Get
            Return vCadenaSicaip
        End Get
        Set(ByVal value As String)
            vCadenaSicaip = value
        End Set
    End Property

    Private vCadenaKronos As String
    Public Property CadenaKronos As String
        Get
            Return vCadenaKronos
        End Get
        Set(ByVal value As String)
            vCadenaKronos = value
        End Set
    End Property
#End Region

End Class
