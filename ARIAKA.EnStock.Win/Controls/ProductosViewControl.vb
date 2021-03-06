﻿Namespace Controls
    Public Class ProductosViewControl
        Private Property _cliente As New Logica.Cliente

        Private Property _productoID As Integer
        Public Property ProductoID As Integer
            Get
                Return _productoID
            End Get
            Set(value As Integer)
                _productoID = value
            End Set
        End Property

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
            If _productoID <> 0 Then
                producto.ID = _productoID
            End If

            producto = _cliente.GuardarProductos(producto)
            If producto.ID = _productoID Then
                'Me.ProductosControl1.ProductoDTOBindingSource.RemoveCurrent()
                ProductosControl1.GridView_Productos.DeleteRow(ProductosControl1.GridView_Productos.FocusedRowHandle)
            End If
            Me.ProductosControl1.ProductoDTOBindingSource.Add(producto)
            Me.ProductosControl1.GridView_Productos.RefreshEditor(True)
            LimpiarCampos()
        End Sub

        Private Sub SimpleButton_Eliminar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Eliminar.Click
            Dim productoDto As Models.ProductosDTO = CType(ProductosControl1.ProductoDTOBindingSource.Current, Models.ProductosDTO)
            Dim id As Integer = productoDto.ID
            If id <> 0 Then _cliente.EliminarProducto(id)
            ProductosControl1.GridView_Productos.DeleteRow(ProductosControl1.GridView_Productos.FocusedRowHandle)
            Me.ProductosControl1.GridView_Productos.RefreshEditor(True)
        End Sub

        Private Sub LimpiarCampos()
            TextBox_Codigo.Clear()
            TextBox_Nombre.Clear()
            TextBox_Precio.Clear()
            TextBox_Talla.Clear()
            TextBox_Stock.Clear()
        End Sub

    End Class
End Namespace
