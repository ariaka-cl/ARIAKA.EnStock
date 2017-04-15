Imports System.Linq

Namespace Controls
    Public Class VentasControl
        Private Property _cliente As New Logica.Cliente
        Private Property _ventaID As Integer
        Public Property VentaID As Integer
            Get
                Return _ventaID
            End Get
            Set(value As Integer)
                _ventaID = value
            End Set
        End Property

        Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PopulateProductos()
            If _ventaID <> 0 Then
                PopulateDetalleVentas()
            End If
        End Sub
        Private Sub PopulateProductos()
            SearchLookUpEdit_Productos.DataBindings.Clear()
            Me.SearchLookUpEdit_Productos.Properties.DataSource = _cliente.GetProduc()
        End Sub

        Private Sub SimpleButton_Delete_Click(sender As Object, e As EventArgs) Handles SimpleButton_Delete.Click

            If Me.GridView1.FocusedRowHandle < 0 Then Return
            Dim detalleVentaDto As Models.DetalleVentasDTO = CType(Me.DetalleVentasDTOBindingSource.Current, Models.DetalleVentasDTO)
            Me.GridView1.DeleteRow(Me.GridView1.FocusedRowHandle)
            RestarTotal(detalleVentaDto.Producto.Precio)
            If _ventaID <> 0 Then
                Dim id As Integer = detalleVentaDto.ID
                Dim totalVenta As Integer = CInt(LabelControl_Total_Value.Text)
                If id <> 0 Then _cliente.EliminarDetalleVenta(detalleVentaDto, totalVenta)
            End If
            Me.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Add_Click(sender As Object, e As EventArgs) Handles SimpleButton_Add.Click
            If Me.SearchLookUpEdit_Productos.EditValue Is Nothing OrElse Me.SearchLookUpEdit_Productos.EditValue.ToString.Contains("Buscar") Then
                MessageBox.Show("Debe seleccionar un producto", "Agregar Producto Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim idProduct As Integer = CInt(Me.SearchLookUpEdit_Productos.EditValue)
            Dim listProducts As List(Of Models.ProductosDTO) = _cliente.GetProduc()
            Dim producto As Models.ProductosDTO = listProducts.Where(Function(p) p.ID = idProduct).SingleOrDefault()

            If producto.Stock < CInt(TextEdit_Cantidad.Text) Then
                MessageBox.Show("Stock menor a cantidad solicitada", "Agregar Producto Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim produCantiPrecio As Integer = SumarPrecioCantidad(producto.Precio, CInt(TextEdit_Cantidad.Text))
            SumarTotal(produCantiPrecio)
            Dim produDto As New Models.ProductosDTO With {.ID = idProduct,
                                                        .Codigo = producto.Codigo,
                                                        .Nombre = producto.Nombre,
                                                        .Talla = producto.Talla,
                                                        .MarcaID = producto.MarcaID,
                                                        .Precio = produCantiPrecio,
                                                        .Stock = CInt(TextEdit_Cantidad.Text)}

            Dim detalleVentaDto As New Models.DetalleVentasDTO With {.Producto = produDto,
                                                                     .Cantidad = CInt(TextEdit_Cantidad.Text),
                                                                     .FechaCreacion = Date.Now.Date,
                                                                     .ProductoID = idProduct}
            Me.DetalleVentasDTOBindingSource.Add(detalleVentaDto)
            Me.GridView1.RefreshEditor(True)
        End Sub
        Private Sub SumarTotal(precio As Integer)
            Dim total As String = LabelControl_Total_Value.Text
            Dim totalInt As Integer = CInt(total)
            totalInt = precio + totalInt
            LabelControl_Total_Value.Text = totalInt.ToString()
        End Sub

        Private Function SumarPrecioCantidad(precio As Integer?, cantidad As Integer) As Integer
            Dim total As Integer = CInt(precio * cantidad)
            Return total
        End Function

        Private Sub RestarTotal(precio As Integer?)
            Dim totalInt As Integer? = CInt(LabelControl_Total_Value.Text)
            totalInt = totalInt - precio
            LabelControl_Total_Value.Text = totalInt.ToString()
        End Sub

        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            If _ventaID <> 0 Then
                Dim lisDetalle As List(Of Models.DetalleVentasDTO) = TryCast(GridControl_DetalleVenta.DataSource, BindingSource) _
                                                               .Cast(Of Models.DetalleVentasDTO).ToList()
                Dim listDetalleNuevo As List(Of Models.DetalleVentasDTO) = lisDetalle.Where(Function(v) CBool(v.VentasID = 0)).ToList()
                lisDetalle = Nothing
                If listDetalleNuevo Is Nothing OrElse listDetalleNuevo.Count = 0 Then
                    MessageBox.Show("No hay datos para guardar", "Guardar Ventas")
                    Return
                End If
                Dim venta As New Models.VentasDTO With {.FechaCreacion = Me.DateTimePicker_Fecha.Value.Date, .Total = CInt(LabelControl_Total_Value.Text), .ID = _ventaID}
                venta = _cliente.GuardarVenta(venta)
                lisDetalle = _cliente.GuardarDetalleVenta(listDetalleNuevo, _ventaID)
                If lisDetalle IsNot Nothing Then
                    DetalleVentasDTOBindingSource.Clear()
                    GridControl_DetalleVenta.DataSource = DetalleVentasDTOBindingSource.DataSource
                    For i As Integer = 0 To lisDetalle.Count - 1
                        Me.DetalleVentasDTOBindingSource.Add(lisDetalle.Item(i))
                    Next
                    Me.GridControl_DetalleVenta.DataSource = DetalleVentasDTOBindingSource.DataSource
                    Me.GridView1.RefreshEditor(True)
                End If

            Else

                Dim venta As New Models.VentasDTO With {.FechaCreacion = Me.DateTimePicker_Fecha.Value.Date, .Total = CInt(LabelControl_Total_Value.Text)}

                Dim lisDetalle As List(Of Models.DetalleVentasDTO) = TryCast(Me.GridView1.DataSource, BindingSource) _
                                                                    .Cast(Of Models.DetalleVentasDTO).ToList()
                venta = _cliente.GuardarVenta(venta)
                _ventaID = venta.ID
                lisDetalle = _cliente.GuardarDetalleVenta(lisDetalle, _ventaID)
                TextEdit_Venta_Numero.Text = _ventaID.ToString()

                DetalleVentasDTOBindingSource.Clear()
                GridControl_DetalleVenta.DataSource = DetalleVentasDTOBindingSource.DataSource
                For i As Integer = 0 To lisDetalle.Count - 1
                    Me.DetalleVentasDTOBindingSource.Add(lisDetalle.Item(i))
                Next
                GridControl_DetalleVenta.DataSource = DetalleVentasDTOBindingSource.DataSource
                Me.GridView1.RefreshEditor(True)
            End If
            MessageBox.Show("Se guardaron con éxito los registros", "Guardar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PopulateProductos()
        End Sub

        Public Sub PopulateDetalleVentas()
            Dim venta As Models.VentasDTO = _cliente.GetOneVenta(_ventaID)
            Me.TextEdit_Venta_Numero.Text = venta.ID.ToString
            Me.DateTimePicker_Fecha.Value = venta.FechaCreacion.Value.Date
            Dim total As Integer = 0
            If venta.ListaDetalleVenta IsNot Nothing Then
                GridControl_DetalleVenta.DataBindings.Clear()
                For i As Integer = 0 To venta.ListaDetalleVenta.Count - 1
                    DetalleVentasDTOBindingSource.Add(venta.ListaDetalleVenta.Item(i))
                    total = CInt(venta.ListaDetalleVenta.Item(i).Producto.Precio + total)
                Next
                Me.GridControl_DetalleVenta.DataSource = DetalleVentasDTOBindingSource.DataSource
                Me.GridView1.RefreshEditor(True)
            End If
            Me.LabelControl_Total_Value.Text = total.ToString()
        End Sub


    End Class
End Namespace