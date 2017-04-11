Namespace Controls
    Public Class VentasControl
        Private Property _cliente As New Logica.Cliente

        Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PopulateProductos()
        End Sub
        Private Sub PopulateProductos()
            Me.ProductosDTOBindingSource.DataSource = _cliente.GetProduc()
            Me.SearchLookUpEdit_Productos.Properties.DataSource = Me.ProductosDTOBindingSource.DataSource
        End Sub

        Private Sub SimpleButton_Delete_Click(sender As Object, e As EventArgs) Handles SimpleButton_Delete.Click
            Dim productDto As Models.ProductosDTO = CType(Me.ProductosDTOBindingSource.Current, Models.ProductosDTO)
            Me.GridView1.DeleteRow(Me.GridView1.FocusedRowHandle)
            'RestarTotal(detalleMesaDto.Producto.Precio)
            Me.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Add_Click(sender As Object, e As EventArgs) Handles SimpleButton_Add.Click
            If Me.SearchLookUpEdit_Productos.EditValue Is Nothing OrElse Me.SearchLookUpEdit_Productos.EditValue.ToString.Contains("Buscar") Then
                MessageBox.Show("Debe seleccionar un producto")
                Return
            End If

            Dim idProduct As Integer = CInt(Me.SearchLookUpEdit_Productos.EditValue)
            Dim listProducts As List(Of Models.ProductosDTO) = _cliente.GetProduc()
            Dim producto As Models.ProductosDTO = listProducts.Where(Function(p) p.ID = idProduct).SingleOrDefault()
            ' SumarTotal(producto.Precio)
            Dim produDto As New Models.ProductosDTO With {.ID = idProduct, .Codigo = producto.Codigo, .Nombre = producto.Nombre,
                                                          .Talla = producto.Talla, .MarcaID = producto.MarcaID, .Precio = producto.Precio,
                                                          .Stock = producto.Stock}

            Me.ProductosDTOBindingSource.Add(produDto)
            Me.GridView1.RefreshEditor(True)
        End Sub
    End Class
End Namespace