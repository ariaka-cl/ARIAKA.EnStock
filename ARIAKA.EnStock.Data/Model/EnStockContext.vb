Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Data.Entity.ModelConfiguration.Conventions

Partial Public Class EnStockContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=EnStockContext")
    End Sub

    Public Overridable Property DetalleVentas As DbSet(Of DetalleVentas)
    Public Overridable Property Marca As DbSet(Of Marca)
    Public Overridable Property Productos As DbSet(Of Productos)
    Public Overridable Property Ventas As DbSet(Of Ventas)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of OneToManyCascadeDeleteConvention)()
        MyBase.OnModelCreating(modelBuilder)
        'modelBuilder.Entity(Of DetalleVentas)() _
        '    .Property(Function(e) e.FechaCreacion) _
        '    .HasPrecision(6)

        'modelBuilder.Entity(Of Marca)() _
        '    .Property(Function(e) e.Nombre) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Productos)() _
        '    .Property(Function(e) e.Codigo) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Productos)() _
        '    .Property(Function(e) e.Nombre) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Productos)() _
        '    .Property(Function(e) e.Talla) _
        '    .IsUnicode(False)

        'modelBuilder.Entity(Of Ventas)() _
        '    .Property(Function(e) e.FechaCreacion) _
        '    .HasPrecision(6)
    End Sub
End Class
