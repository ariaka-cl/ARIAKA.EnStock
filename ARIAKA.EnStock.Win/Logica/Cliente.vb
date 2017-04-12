Imports System.Linq
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

                    Dim marcaDto As New Models.MarcaDTO With {.ID = CInt(produ.MarcaID),
                        .Nombre = listMarca.Where(Function(m) CBool(m.ID = produ.MarcaID)).
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

        Public Function GuardarDetalleVenta(ventaDetalles As List(Of Models.DetalleVentasDTO), ventaID As Integer) As List(Of Models.DetalleVentasDTO)
            Dim db As New EnStockContext
            Try
                For Each detalle As Models.DetalleVentasDTO In ventaDetalles
                    Dim detalleBD As New Data.DetalleVentas With {.VentasID = ventaID,
                                                                  .FechaCreacion = Date.Now.Date,
                                                                  .Cantidad = detalle.Cantidad,
                                                                  .ProductoID = detalle.ProductoID}
                    db.DetalleVentas.Add(detalleBD)
                Next
                db.SaveChanges()
                Dim listVentaDetalle As List(Of Data.DetalleVentas) = db.DetalleVentas.Where(Function(vd) CBool(vd.VentasID = ventaID)).ToList()
                Dim listProducts As List(Of Productos) = db.Productos.ToList()
                Dim listMarca As List(Of Marca) = db.Marca.ToList()
                Dim listVentaDetalleDto As New List(Of Models.DetalleVentasDTO)
                For Each mdetalle As Data.DetalleVentas In listVentaDetalle
                    Dim precio As Integer = CInt(listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.Precio).SingleOrDefault())
                    precio = CInt(precio * mdetalle.Cantidad)
                    Dim prod As New Models.ProductosDTO With {.ID = CInt(mdetalle.ProductoID),
                        .Nombre = listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.Nombre).SingleOrDefault(),
                        .Precio = precio,
                        .Codigo = listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.Codigo).SingleOrDefault(),
                        .Stock = listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.Stock).SingleOrDefault(),
                        .Talla = listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.Talla).SingleOrDefault(),
                        .MarcaID = listProducts.Where(Function(p) CBool(p.ID = mdetalle.ProductoID)).Select(Function(p) p.MarcaID).SingleOrDefault(),
                        .Marca = New Models.MarcaDTO With {.ID = CInt(mdetalle.Producto.MarcaID),
                                                             .Nombre = listMarca.Where(Function(c) CBool(c.ID = mdetalle.Producto.MarcaID)) _
                                                             .Select(Function(c) c.Nombre).SingleOrDefault()}}
                    listVentaDetalleDto.Add(New Models.DetalleVentasDTO With {.ID = mdetalle.ID,
                                                                           .VentasID = ventaID,
                                                                           .Cantidad = mdetalle.Cantidad,
                                                                           .ProductoID = mdetalle.ProductoID,
                                                                           .Producto = prod})
                Next

                Return listVentaDetalleDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Agregar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.DetalleVentasDTO)
            Finally
                db.Dispose()
            End Try
        End Function


        Public Function GuardarVenta(ventaModel As Models.VentasDTO) As Models.VentasDTO
            Dim db As New EnStockContext
            Try
                Dim venta As New Ventas With {.FechaCreacion = ventaModel.FechaCreacion, .Total = ventaModel.Total}
                db.Ventas.Add(venta)
                db.SaveChanges()
                ventaModel.ID = venta.ID
                Return ventaModel
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New Models.VentasDTO
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GetVentas(fInicio As Date, fFin As Date) As List(Of Models.VentasDTO)
            Dim db As New EnStockContext
            Try
                Dim listVentas As List(Of Ventas) = db.Ventas.Where(Function(v) CBool(v.FechaCreacion >= fInicio And v.FechaCreacion <= fFin)).ToList()
                Dim listVentasDto As New List(Of Models.VentasDTO)
                For Each venta As Ventas In listVentas
                    listVentasDto.Add(New Models.VentasDTO With {.ID = venta.ID,
                                                                  .FechaCreacion = venta.FechaCreacion,
                                                                  .Total = venta.Total})
                Next
                Return listVentasDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.VentasDTO)
            Finally
                db.Dispose()
            End Try
        End Function

    End Class
End Namespace