Namespace Models
    Public Class VentasDTO
        Public Property ID As Integer
        Public Property FechaCreacion As Date?
        Public Property Total As Long?
        Public Property ListaDetalleVenta As List(Of DetalleVentasDTO)
    End Class
End Namespace
