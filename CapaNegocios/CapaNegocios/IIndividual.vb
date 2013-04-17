Public Interface IIndividual

    Sub Registrar()
    Sub Eliminar()
    Sub Cargar()
    Function Obtener_Id(ByVal vCadena As String) As Long
    Property Id As Long

End Interface