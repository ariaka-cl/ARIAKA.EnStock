Namespace Models
    Public Class ProductosDTO
        Public Property ID As Integer
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property Talla As String
        Public Property Precio As Integer?
        Public Property Stock As Integer?
        Public Property MarcaID As Integer?
        Public Property Marca As MarcaDTO
    End Class
End Namespace
