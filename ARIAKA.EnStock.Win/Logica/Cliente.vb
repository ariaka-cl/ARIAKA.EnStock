Imports System.Windows.Forms
Imports ARIAKA.EnStock.Data
Namespace Logica
    Public Class Cliente
        Public Function GetMarca() As List(Of Models.MarcaDTO)
            Dim db As New EnStockContext
            Try
                Dim listMarca As List(Of Marca) = db.Marca.ToList()
                Dim listMarcaDto As New List(Of Models.MarcaDTO)
                For Each marca As Marca In listMarca

                    listMarcaDto.Add(New Models.MarcaDTO With {.ID = marca.ID,
                                                                   .Nombre = marca.Nombre})
                Next

                Return listMarcaDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtener Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.MarcaDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GuardarMarcas(marcasDto As Models.MarcaDTO) As Models.MarcaDTO
            Dim db As New EnStockContext
            Try
                Dim marca As New Marca With {.Nombre = marcasDto.Nombre}
                db.Marca.Add(marca)
                db.SaveChanges()
                marcasDto.ID = marca.ID

                Return marcasDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Agregar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New Models.MarcaDTO
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function EliminarMarca(id As Integer) As Boolean
            Dim db As New EnStockContext
            Try
                Dim marca As Marca = db.Marca.Where(Function(m) m.ID = id).SingleOrDefault()
                db.Marca.Remove(marca)
                db.SaveChanges()
                Return True

            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GetProduc() As List(Of Models.ProductosDTO)
            Dim db As New EnStockContext
            Try
                Dim listProductos As List(Of Productos) = db.Productos.ToList()
                Dim listMarca As List(Of Marca) = db.Marca.ToList()
                Dim listProductosDto As New List(Of Models.ProductosDTO)
                For Each produ As Productos In listProductos

                    Dim marcaDto As New Models.MarcaDTO With {.ID = produ.MarcaID,
                        .Nombre = listMarca.Where(Function(m) m.ID = produ.MarcaID).
                        Select(Function(c) c.Nombre).SingleOrDefault()}

                    listProductosDto.Add(New Models.ProductosDTO With {.ID = produ.ID,
                                                                   .Nombre = produ.Nombre,
                                                                   .Precio = produ.Precio,
                                                                   .Codigo = produ.Codigo,
                                                                   .Stock = produ.Stock,
                                                                   .Talla = produ.Talla,
                                                                   .MarcaID = produ.MarcaID,
                                                                   .Marca = marcaDto})
                Next

                Return listProductosDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtener Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.ProductosDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GuardarProductos(productoDto As Models.ProductosDTO) As Models.ProductosDTO
            Dim db As New EnStockContext
            Try
                If productoDto Is Nothing Then Return New Models.ProductosDTO
                Dim producto As New Productos With {.Codigo = productoDto.Codigo,
                                                   .Nombre = productoDto.Nombre,
                                                   .Precio = productoDto.Precio,
                                                   .Stock = productoDto.Stock,
                                                   .Talla = productoDto.Talla,
                                                   .MarcaID = productoDto.MarcaID}
                db.Productos.Add(producto)
                db.SaveChanges()
                productoDto.ID = producto.ID
                Return productoDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtener Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New Models.ProductosDTO
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function EliminarProducto(id As Integer) As Boolean
            Dim db As New EnStockContext
            Try
                Dim produ As Productos = db.Productos.Where(Function(c) c.ID = id).SingleOrDefault()
                db.Productos.Remove(produ)
                db.SaveChanges()
                Return True
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function

        'Public Function GetProductos() As List(Of Models.ProductosDTO)
        '    Dim db As New EnStockContext
        '    Try
        '        Dim listProductos As List(Of Productos) = db.Productos.ToList()
        '        Dim listProductosDto As New List(Of Models.ProductosDTO)
        '        For Each producto As Productos In listProductos
        '            listProductosDto.Add(New Models.ProductosDTO With {.ID = producto.ID, .Nombre = producto.Nombre,
        '                                                                .MarcaID = producto.MarcaID, .Codigo = producto.Codigo,
        '                                                                .Precio = producto.Precio, .Stock = producto.Stock,
        '                                                                .Marca = New Marca With {.}})
        '        Next
        '        Return listProductosDto
        '    Catch ex As Exception
        '        MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error lista productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Return New List(Of Models.ProductosDTO)
        '    Finally
        '        db.Dispose()
        '    End Try
        'End Function


    End Class
End Namespace