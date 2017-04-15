Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdEnStock.DetalleVentas")>
Partial Public Class DetalleVentas
    Public Property ID As Integer

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    Public Property Cantidad As Integer?

    Public Property ProductoID As Integer?
    Public Property Producto As Productos

    Public Property VentasID As Integer?
End Class
