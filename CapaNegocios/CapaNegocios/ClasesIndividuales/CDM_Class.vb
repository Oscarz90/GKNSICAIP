Public Class CDM_Class
    Public CDM As Integer
    Public fecha_inicio As String
    Public fecha_final As String
    Public minutosTotales As Integer
    Public paros_detalle(7, 1) As String
    Public comentarios(8, 0) As String
    'Public modelo_afectado As Integer
    Public mejora As Double = 0
    Public costo As Double = 0
    Private Property usado As Boolean
    Public Sub New()
        set_not_used()
    End Sub
    Public Sub set_Values(ByVal m_CDM As Integer, ByVal ini As String, ByVal fin As String, ByVal m_totales As Integer, ByVal d_paros(,) As String, ByVal coment(,) As String, ByVal mej As Double, ByVal cost As Double)
        CDM = m_CDM
        fecha_inicio = ini
        fecha_final = fin
        minutosTotales = m_totales
        paros_detalle = d_paros
        comentarios = coment
        mejora = mej
        costo = cost
    End Sub
    Public Sub set_used()
        usado = True
    End Sub
    Public Sub set_not_used()
        usado = False
    End Sub
    Public Function get_if_it_was_used() As Boolean
        Return usado
    End Function
End Class
