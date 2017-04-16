Imports DevExpress.XtraGrid.Views.Grid
Namespace Controls
    Public Class ProductosControl
        Sub New()
            InitializeComponent()
        End Sub

        Private Sub GridView_Productos_DoClick(sender As Object, e As EventArgs) Handles GridView_Productos.RowCellClick
            Dim productoView As ProductosViewControl = TryCast(Me.Parent.Parent, ProductosViewControl)
            If productoView Is Nothing Then
                Return
            End If
            Dim productoDto As Models.ProductosDTO = CType(productoView.ProductosControl1.ProductoDTOBindingSource.Current, Models.ProductosDTO)
            If productoDto Is Nothing Then
                Return
            End If
            productoView.TextBox_Codigo.Text = productoDto.Codigo
            productoView.TextBox_Nombre.Text = productoDto.Nombre
            productoView.TextBox_Precio.Text = productoDto.Precio.ToString
            productoView.TextBox_Talla.Text = productoDto.Talla
            productoView.TextBox_Stock.Text = productoDto.Stock.ToString
            productoView.ComboBox_Marca.Text = productoDto.Marca.Nombre
            productoView.ProductoID = productoDto.ID
        End Sub
    End Class
End Namespace
