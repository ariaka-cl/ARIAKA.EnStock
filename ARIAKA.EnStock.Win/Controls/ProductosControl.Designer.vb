Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProductosControl
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.GridControl_Producto = New DevExpress.XtraGrid.GridControl()
            Me.ProductoDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.GridView_Productos = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTalla = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarcaID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            CType(Me.GridControl_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'GridControl_Producto
            '
            Me.GridControl_Producto.DataSource = Me.ProductoDTOBindingSource
            Me.GridControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Producto.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_Producto.MainView = Me.GridView_Productos
            Me.GridControl_Producto.Name = "GridControl_Producto"
            Me.GridControl_Producto.Size = New System.Drawing.Size(735, 373)
            Me.GridControl_Producto.TabIndex = 0
            Me.GridControl_Producto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Productos})
            '
            'ProductoDTOBindingSource
            '
            Me.ProductoDTOBindingSource.DataSource = GetType(ARIAKA.EnStock.Win.Models.ProductosDTO)
            '
            'GridView_Productos
            '
            Me.GridView_Productos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCodigo, Me.colNombre, Me.colTalla, Me.colPrecio, Me.colStock, Me.GridColumn_Total, Me.colMarcaID, Me.colMarca})
            Me.GridView_Productos.GridControl = Me.GridControl_Producto
            Me.GridView_Productos.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio", Me.GridColumn_Total, "(Precio: SUMA={0:#.##})")})
            Me.GridView_Productos.Name = "GridView_Productos"
            Me.GridView_Productos.OptionsBehavior.Editable = False
            Me.GridView_Productos.OptionsPrint.PrintFilterInfo = True
            Me.GridView_Productos.OptionsView.ShowAutoFilterRow = True
            Me.GridView_Productos.OptionsView.ShowFooter = True
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            '
            'colCodigo
            '
            Me.colCodigo.Caption = "Codigo"
            Me.colCodigo.FieldName = "Codigo"
            Me.colCodigo.Name = "colCodigo"
            Me.colCodigo.Visible = True
            Me.colCodigo.VisibleIndex = 0
            Me.colCodigo.Width = 63
            '
            'colNombre
            '
            Me.colNombre.Caption = "Nombre"
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 1
            Me.colNombre.Width = 158
            '
            'colTalla
            '
            Me.colTalla.Caption = "Talla"
            Me.colTalla.FieldName = "Talla"
            Me.colTalla.Name = "colTalla"
            Me.colTalla.Visible = True
            Me.colTalla.VisibleIndex = 2
            Me.colTalla.Width = 60
            '
            'colPrecio
            '
            Me.colPrecio.Caption = "Precio"
            Me.colPrecio.FieldName = "Precio"
            Me.colPrecio.Name = "colPrecio"
            Me.colPrecio.Visible = True
            Me.colPrecio.VisibleIndex = 3
            Me.colPrecio.Width = 81
            '
            'colStock
            '
            Me.colStock.Caption = "Stock"
            Me.colStock.FieldName = "Stock"
            Me.colStock.Name = "colStock"
            Me.colStock.Visible = True
            Me.colStock.VisibleIndex = 4
            Me.colStock.Width = 81
            '
            'GridColumn_Total
            '
            Me.GridColumn_Total.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridColumn_Total.AppearanceCell.Options.UseFont = True
            Me.GridColumn_Total.Caption = "Total"
            Me.GridColumn_Total.FieldName = "GridColumn_Total"
            Me.GridColumn_Total.Name = "GridColumn_Total"
            Me.GridColumn_Total.ShowUnboundExpressionMenu = True
            Me.GridColumn_Total.UnboundExpression = "[Precio] * [Stock]"
            Me.GridColumn_Total.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.GridColumn_Total.Visible = True
            Me.GridColumn_Total.VisibleIndex = 5
            Me.GridColumn_Total.Width = 72
            '
            'colMarcaID
            '
            Me.colMarcaID.FieldName = "MarcaID"
            Me.colMarcaID.Name = "colMarcaID"
            '
            'colMarca
            '
            Me.colMarca.Caption = "Proveedor"
            Me.colMarca.FieldName = "Marca.Nombre"
            Me.colMarca.Name = "colMarca"
            Me.colMarca.Visible = True
            Me.colMarca.VisibleIndex = 6
            Me.colMarca.Width = 226
            '
            'TableLayoutPanel_Container
            '
            Me.TableLayoutPanel_Container.ColumnCount = 1
            Me.TableLayoutPanel_Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Controls.Add(Me.GridControl_Producto, 0, 0)
            Me.TableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Container.Name = "TableLayoutPanel_Container"
            Me.TableLayoutPanel_Container.RowCount = 1
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Size = New System.Drawing.Size(741, 379)
            Me.TableLayoutPanel_Container.TabIndex = 1
            '
            'ProductosControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Container)
            Me.Name = "ProductosControl"
            Me.Size = New System.Drawing.Size(741, 379)
            CType(Me.GridControl_Producto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Productos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents GridControl_Producto As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Productos As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ProductoDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents TableLayoutPanel_Container As Windows.Forms.TableLayoutPanel
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTalla As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarcaID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Total As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
