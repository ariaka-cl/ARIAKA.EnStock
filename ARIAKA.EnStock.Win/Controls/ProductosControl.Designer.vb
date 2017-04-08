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
            Me.GridControl_Producto = New DevExpress.XtraGrid.GridControl()
            Me.ProductoDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTalla = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarcaID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            CType(Me.GridControl_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'GridControl_Producto
            '
            Me.GridControl_Producto.DataSource = Me.ProductoDTOBindingSource
            Me.GridControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Producto.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_Producto.MainView = Me.GridView1
            Me.GridControl_Producto.Name = "GridControl_Producto"
            Me.GridControl_Producto.Size = New System.Drawing.Size(735, 373)
            Me.GridControl_Producto.TabIndex = 0
            Me.GridControl_Producto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'ProductoDTOBindingSource
            '
            Me.ProductoDTOBindingSource.DataSource = GetType(ARIAKA.EnStock.Win.Models.ProductosDTO)
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCodigo, Me.colNombre, Me.colTalla, Me.colPrecio, Me.colStock, Me.colMarcaID, Me.colMarca})
            Me.GridView1.GridControl = Me.GridControl_Producto
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsBehavior.Editable = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
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
            '
            'colNombre
            '
            Me.colNombre.Caption = "Nombre"
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 1
            '
            'colTalla
            '
            Me.colTalla.Caption = "Talla"
            Me.colTalla.FieldName = "Talla"
            Me.colTalla.Name = "colTalla"
            Me.colTalla.Visible = True
            Me.colTalla.VisibleIndex = 2
            '
            'colPrecio
            '
            Me.colPrecio.Caption = "Precio"
            Me.colPrecio.FieldName = "Precio"
            Me.colPrecio.Name = "colPrecio"
            Me.colPrecio.Visible = True
            Me.colPrecio.VisibleIndex = 3
            '
            'colStock
            '
            Me.colStock.Caption = "Stock"
            Me.colStock.FieldName = "Stock"
            Me.colStock.Name = "colStock"
            Me.colStock.Visible = True
            Me.colStock.VisibleIndex = 4
            '
            'colMarcaID
            '
            Me.colMarcaID.FieldName = "MarcaID"
            Me.colMarcaID.Name = "colMarcaID"
            '
            'colMarca
            '
            Me.colMarca.Caption = "Marca"
            Me.colMarca.FieldName = "Marca.Nombre"
            Me.colMarca.Name = "colMarca"
            Me.colMarca.Visible = True
            Me.colMarca.VisibleIndex = 5
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
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents GridControl_Producto As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    End Class
End Namespace
