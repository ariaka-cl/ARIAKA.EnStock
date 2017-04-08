Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("bdEnStock.Marca")>
Partial Public Class Marca
    Public Property ID As Integer

    <StringLength(45)>
    Public Property Nombre As String
End Class
