Namespace Models
    Public Class DetalleVentasDTO
        Public Property ID As Integer
        Public Property FechaCreacion As Date?
        Public Property Cantidad As Integer?
        Public Property ProductoID As Integer?
        Public Property Producto As ProductosDTO
        Public Property VentasID As Integer
    End Class
End Namespace
