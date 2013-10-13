Public Class conexiones
    Public Sub New()
        '"Data Source= Oscar-PC\SQLExpress; initial Catalog=GKNSICAIP; Integrated Security = True"
        vCadenaSicaip = "Data Source=PATRICIA-PC\SQLEXPRESS2008R2;Integrated Security=SSPI; Password=sistemas; User ID=sa;Initial Catalog=GKNSICAIP_V2"
        vCadenaKronos = "Data Source=PATRICIA-PC\SQLEXPRESS2008R2;Integrated Security=SSPI; Password=sistemas; User ID=sa;Initial Catalog=wtk52db"
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
