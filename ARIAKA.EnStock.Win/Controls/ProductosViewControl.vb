Namespace Controls
    Public Class ProductosViewControl
        Private Property _cliente As New Logica.Cliente

        Public Sub ProductosViewControl_Load() Handles MyBase.Load
            PopulateMarca()
            PopulateProductosGrid()
        End Sub

        Public Sub PopulateProductosGrid()
            Dim listProductDto As List(Of Models.ProductosDTO) = _cliente.GetProduc()
            If listProductDto IsNot Nothing Then
                Me.ProductosControl1.ProductoDTOBindingSource.DataSource = listProductDto
                Me.ProductosControl1.GridView_Productos.RefreshEditor(True)
            End If

        End Sub

        Private Sub PopulateMarca()
            Me.MarcaDTOBindingSource.DataSource = _cliente.GetMarca()
            Me.ComboBox_Marca.DataSource = MarcaDTOBindingSource.DataSource
        End Sub

        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            Dim codigo As String = TextBox_Codigo.Text
            Dim nombre As String = TextBox_Nombre.Text
            Dim precio As String = TextBox_Precio.Text
            Dim stock As String = TextBox_Stock.Text
            Dim talla As String = TextBox_Talla.Text
            Dim marcaId As Integer = CInt(ComboBox_Marca.SelectedValue)
            Dim cateNombre As String = ComboBox_Marca.Text

            Dim producto As New Models.ProductosDTO With {.Codigo = codigo,
                                                          .Nombre = nombre,
                                                          .Precio = CInt(precio),
                                                          .Stock = CInt(stock),
                                                          .Talla = talla,
                                                          .MarcaID = marcaId,
                                                          .Marca = New Models.MarcaDTO With {.ID = marcaId, .Nombre = cateNombre}}
            producto = _cliente.GuardarProductos(producto)
            Me.ProductosControl1.ProductoDTOBindingSource.Add(producto)
            Me.ProductosControl1.GridView_Productos.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Eliminar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Eliminar.Click
            Dim productoDto As Models.ProductosDTO = CType(ProductosControl1.ProductoDTOBindingSource.Current, Models.ProductosDTO)
            Dim id As Integer = productoDto.ID
            If id <> 0 Then _cliente.EliminarProducto(id)
            ProductosControl1.GridView_Productos.DeleteRow(ProductosControl1.GridView_Productos.FocusedRowHandle)
            Me.ProductosControl1.GridView_Productos.RefreshEditor(True)
        End Sub

    End Class
End Namespace
