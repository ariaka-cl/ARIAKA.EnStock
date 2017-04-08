Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdEnStock.Ventas")>
Partial Public Class Ventas
    Public Property ID As Integer

    <Column(TypeName:="timestamp")>
    Public Property FechaCreacion As Date?

    <Column(TypeName:="uint")>
    Public Property Total As Long?
End Class
