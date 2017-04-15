Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdEnStock.Productos")>
Partial Public Class Productos
    Public Property ID As Integer

    <StringLength(45)>
    Public Property Codigo As String

    <StringLength(45)>
    Public Property Nombre As String

    <StringLength(45)>
    Public Property Talla As String

    Public Property Precio As Integer?

    Public Property Stock As Integer?

    Public Property MarcaID As Integer?
    Public Property Marca As Marca
End Class
