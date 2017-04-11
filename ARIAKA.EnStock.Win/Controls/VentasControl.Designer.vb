Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class VentasControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasControl))
            Me.TableLayoutPanel_Main = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Buttons = New System.Windows.Forms.TableLayoutPanel()
            Me.LabelControl_Total_Text = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Total_Value = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton_Guardar = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel_VentaFecha = New System.Windows.Forms.TableLayoutPanel()
            Me.DateTimePicker_Fecha = New System.Windows.Forms.DateTimePicker()
            Me.LabelControl_Fecha_text = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Venta_Text = New DevExpress.XtraEditors.LabelControl()
            Me.TextEdit_Venta_Numero = New DevExpress.XtraEditors.TextEdit()
            Me.TableLayoutPanel_Productos = New System.Windows.Forms.TableLayoutPanel()
            Me.TextEdit_Cantidad = New DevExpress.XtraEditors.TextEdit()
            Me.SearchLookUpEdit_Productos = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.ProductosDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCodigo1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTalla1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrecio1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStock1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarcaID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarca1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.LabelControl_Cantidad = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton_Add = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Delete = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTalla = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarcaID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMarca = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Main.SuspendLayout()
            Me.TableLayoutPanel_Buttons.SuspendLayout()
            Me.TableLayoutPanel_VentaFecha.SuspendLayout()
            CType(Me.TextEdit_Venta_Numero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Productos.SuspendLayout()
            CType(Me.TextEdit_Cantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEdit_Productos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Main
            '
            Me.TableLayoutPanel_Main.ColumnCount = 1
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Buttons, 0, 0)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Productos, 0, 1)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel1, 0, 2)
            Me.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Main.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main"
            Me.TableLayoutPanel_Main.RowCount = 3
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.37864!))
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.71844!))
            Me.TableLayoutPanel_Main.Size = New System.Drawing.Size(705, 412)
            Me.TableLayoutPanel_Main.TabIndex = 0
            '
            'TableLayoutPanel_Buttons
            '
            Me.TableLayoutPanel_Buttons.ColumnCount = 5
            Me.TableLayoutPanel_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.4878!))
            Me.TableLayoutPanel_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.07317!))
            Me.TableLayoutPanel_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.43902!))
            Me.TableLayoutPanel_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
            Me.TableLayoutPanel_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
            Me.TableLayoutPanel_Buttons.Controls.Add(Me.LabelControl_Total_Text, 1, 0)
            Me.TableLayoutPanel_Buttons.Controls.Add(Me.LabelControl_Total_Value, 2, 0)
            Me.TableLayoutPanel_Buttons.Controls.Add(Me.SimpleButton_Guardar, 3, 0)
            Me.TableLayoutPanel_Buttons.Controls.Add(Me.SimpleButton2, 4, 0)
            Me.TableLayoutPanel_Buttons.Controls.Add(Me.TableLayoutPanel_VentaFecha, 0, 0)
            Me.TableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Buttons.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel_Buttons.Name = "TableLayoutPanel_Buttons"
            Me.TableLayoutPanel_Buttons.RowCount = 1
            Me.TableLayoutPanel_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Buttons.Size = New System.Drawing.Size(699, 76)
            Me.TableLayoutPanel_Buttons.TabIndex = 0
            '
            'LabelControl_Total_Text
            '
            Me.LabelControl_Total_Text.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Total_Text.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total_Text.Location = New System.Drawing.Point(234, 26)
            Me.LabelControl_Total_Text.Name = "LabelControl_Total_Text"
            Me.LabelControl_Total_Text.Size = New System.Drawing.Size(76, 23)
            Me.LabelControl_Total_Text.TabIndex = 0
            Me.LabelControl_Total_Text.Text = "TOTAL: "
            '
            'LabelControl_Total_Value
            '
            Me.LabelControl_Total_Value.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.LabelControl_Total_Value.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total_Value.Location = New System.Drawing.Point(316, 26)
            Me.LabelControl_Total_Value.Name = "LabelControl_Total_Value"
            Me.LabelControl_Total_Value.Size = New System.Drawing.Size(12, 23)
            Me.LabelControl_Total_Value.TabIndex = 1
            Me.LabelControl_Total_Value.Text = "0"
            '
            'SimpleButton_Guardar
            '
            Me.SimpleButton_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton_Guardar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Guardar.Appearance.Options.UseFont = True
            Me.SimpleButton_Guardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Guardar.Image = CType(resources.GetObject("SimpleButton_Guardar.Image"), System.Drawing.Image)
            Me.SimpleButton_Guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Guardar.Location = New System.Drawing.Point(425, 8)
            Me.SimpleButton_Guardar.Name = "SimpleButton_Guardar"
            Me.SimpleButton_Guardar.Size = New System.Drawing.Size(115, 59)
            Me.SimpleButton_Guardar.TabIndex = 2
            Me.SimpleButton_Guardar.Text = "Guardar"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton2.Appearance.Options.UseFont = True
            Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
            Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton2.Location = New System.Drawing.Point(546, 8)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(115, 59)
            Me.SimpleButton2.TabIndex = 3
            Me.SimpleButton2.Text = "Pagar"
            '
            'TableLayoutPanel_VentaFecha
            '
            Me.TableLayoutPanel_VentaFecha.ColumnCount = 2
            Me.TableLayoutPanel_VentaFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel_VentaFecha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
            Me.TableLayoutPanel_VentaFecha.Controls.Add(Me.DateTimePicker_Fecha, 1, 1)
            Me.TableLayoutPanel_VentaFecha.Controls.Add(Me.LabelControl_Fecha_text, 0, 1)
            Me.TableLayoutPanel_VentaFecha.Controls.Add(Me.LabelControl_Venta_Text, 0, 0)
            Me.TableLayoutPanel_VentaFecha.Controls.Add(Me.TextEdit_Venta_Numero, 1, 0)
            Me.TableLayoutPanel_VentaFecha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_VentaFecha.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel_VentaFecha.Name = "TableLayoutPanel_VentaFecha"
            Me.TableLayoutPanel_VentaFecha.RowCount = 2
            Me.TableLayoutPanel_VentaFecha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_VentaFecha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_VentaFecha.Size = New System.Drawing.Size(198, 70)
            Me.TableLayoutPanel_VentaFecha.TabIndex = 4
            '
            'DateTimePicker_Fecha
            '
            Me.DateTimePicker_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.DateTimePicker_Fecha.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker_Fecha.Location = New System.Drawing.Point(69, 41)
            Me.DateTimePicker_Fecha.Name = "DateTimePicker_Fecha"
            Me.DateTimePicker_Fecha.Size = New System.Drawing.Size(117, 23)
            Me.DateTimePicker_Fecha.TabIndex = 2
            '
            'LabelControl_Fecha_text
            '
            Me.LabelControl_Fecha_text.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Fecha_text.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Fecha_text.Location = New System.Drawing.Point(17, 44)
            Me.LabelControl_Fecha_text.Name = "LabelControl_Fecha_text"
            Me.LabelControl_Fecha_text.Size = New System.Drawing.Size(46, 16)
            Me.LabelControl_Fecha_text.TabIndex = 1
            Me.LabelControl_Fecha_text.Text = "Fecha: "
            '
            'LabelControl_Venta_Text
            '
            Me.LabelControl_Venta_Text.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Venta_Text.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Venta_Text.Location = New System.Drawing.Point(5, 9)
            Me.LabelControl_Venta_Text.Name = "LabelControl_Venta_Text"
            Me.LabelControl_Venta_Text.Size = New System.Drawing.Size(58, 16)
            Me.LabelControl_Venta_Text.TabIndex = 0
            Me.LabelControl_Venta_Text.Text = "Venta N°"
            '
            'TextEdit_Venta_Numero
            '
            Me.TextEdit_Venta_Numero.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Venta_Numero.Enabled = False
            Me.TextEdit_Venta_Numero.Location = New System.Drawing.Point(69, 6)
            Me.TextEdit_Venta_Numero.Name = "TextEdit_Venta_Numero"
            Me.TextEdit_Venta_Numero.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Venta_Numero.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Venta_Numero.Size = New System.Drawing.Size(61, 22)
            Me.TextEdit_Venta_Numero.TabIndex = 3
            '
            'TableLayoutPanel_Productos
            '
            Me.TableLayoutPanel_Productos.ColumnCount = 5
            Me.TableLayoutPanel_Productos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47067!))
            Me.TableLayoutPanel_Productos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.72961!))
            Me.TableLayoutPanel_Productos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01717!))
            Me.TableLayoutPanel_Productos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30615!))
            Me.TableLayoutPanel_Productos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.26987!))
            Me.TableLayoutPanel_Productos.Controls.Add(Me.TextEdit_Cantidad, 2, 0)
            Me.TableLayoutPanel_Productos.Controls.Add(Me.SearchLookUpEdit_Productos, 0, 0)
            Me.TableLayoutPanel_Productos.Controls.Add(Me.LabelControl_Cantidad, 1, 0)
            Me.TableLayoutPanel_Productos.Controls.Add(Me.SimpleButton_Add, 3, 0)
            Me.TableLayoutPanel_Productos.Controls.Add(Me.SimpleButton_Delete, 4, 0)
            Me.TableLayoutPanel_Productos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Productos.Location = New System.Drawing.Point(3, 85)
            Me.TableLayoutPanel_Productos.Name = "TableLayoutPanel_Productos"
            Me.TableLayoutPanel_Productos.RowCount = 1
            Me.TableLayoutPanel_Productos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Productos.Size = New System.Drawing.Size(699, 44)
            Me.TableLayoutPanel_Productos.TabIndex = 1
            '
            'TextEdit_Cantidad
            '
            Me.TextEdit_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextEdit_Cantidad.Location = New System.Drawing.Point(284, 11)
            Me.TextEdit_Cantidad.Name = "TextEdit_Cantidad"
            Me.TextEdit_Cantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit_Cantidad.Properties.Appearance.Options.UseFont = True
            Me.TextEdit_Cantidad.Size = New System.Drawing.Size(64, 22)
            Me.TextEdit_Cantidad.TabIndex = 5
            '
            'SearchLookUpEdit_Productos
            '
            Me.SearchLookUpEdit_Productos.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SearchLookUpEdit_Productos.EditValue = "Seleccionar..."
            Me.SearchLookUpEdit_Productos.Location = New System.Drawing.Point(3, 11)
            Me.SearchLookUpEdit_Productos.Name = "SearchLookUpEdit_Productos"
            Me.SearchLookUpEdit_Productos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SearchLookUpEdit_Productos.Properties.Appearance.Options.UseFont = True
            Me.SearchLookUpEdit_Productos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.SearchLookUpEdit_Productos.Properties.DataSource = Me.ProductosDTOBindingSource
            Me.SearchLookUpEdit_Productos.Properties.DisplayMember = "Nombre"
            Me.SearchLookUpEdit_Productos.Properties.ValueMember = "ID"
            Me.SearchLookUpEdit_Productos.Properties.View = Me.SearchLookUpEdit1View
            Me.SearchLookUpEdit_Productos.Size = New System.Drawing.Size(186, 22)
            Me.SearchLookUpEdit_Productos.TabIndex = 4
            '
            'ProductosDTOBindingSource
            '
            Me.ProductosDTOBindingSource.DataSource = GetType(ARIAKA.EnStock.Win.Models.ProductosDTO)
            '
            'SearchLookUpEdit1View
            '
            Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colCodigo1, Me.colNombre1, Me.colTalla1, Me.colPrecio1, Me.colStock1, Me.colMarcaID1, Me.colMarca1})
            Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
            Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'colID1
            '
            Me.colID1.FieldName = "ID"
            Me.colID1.Name = "colID1"
            '
            'colCodigo1
            '
            Me.colCodigo1.Caption = "Codigo"
            Me.colCodigo1.FieldName = "Codigo"
            Me.colCodigo1.Name = "colCodigo1"
            Me.colCodigo1.Visible = True
            Me.colCodigo1.VisibleIndex = 0
            '
            'colNombre1
            '
            Me.colNombre1.Caption = "Nombre"
            Me.colNombre1.FieldName = "Nombre"
            Me.colNombre1.Name = "colNombre1"
            Me.colNombre1.Visible = True
            Me.colNombre1.VisibleIndex = 1
            '
            'colTalla1
            '
            Me.colTalla1.Caption = "Talla"
            Me.colTalla1.FieldName = "Talla"
            Me.colTalla1.Name = "colTalla1"
            Me.colTalla1.Visible = True
            Me.colTalla1.VisibleIndex = 2
            '
            'colPrecio1
            '
            Me.colPrecio1.Caption = "Precio"
            Me.colPrecio1.FieldName = "Precio"
            Me.colPrecio1.Name = "colPrecio1"
            Me.colPrecio1.Visible = True
            Me.colPrecio1.VisibleIndex = 3
            '
            'colStock1
            '
            Me.colStock1.Caption = "Stock"
            Me.colStock1.FieldName = "Stock"
            Me.colStock1.Name = "colStock1"
            Me.colStock1.Visible = True
            Me.colStock1.VisibleIndex = 4
            '
            'colMarcaID1
            '
            Me.colMarcaID1.FieldName = "MarcaID"
            Me.colMarcaID1.Name = "colMarcaID1"
            '
            'colMarca1
            '
            Me.colMarca1.Caption = "Marca"
            Me.colMarca1.FieldName = "Marca.Nombre"
            Me.colMarca1.Name = "colMarca1"
            Me.colMarca1.Visible = True
            Me.colMarca1.VisibleIndex = 5
            '
            'LabelControl_Cantidad
            '
            Me.LabelControl_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Cantidad.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Cantidad.Location = New System.Drawing.Point(216, 14)
            Me.LabelControl_Cantidad.Name = "LabelControl_Cantidad"
            Me.LabelControl_Cantidad.Size = New System.Drawing.Size(62, 16)
            Me.LabelControl_Cantidad.TabIndex = 6
            Me.LabelControl_Cantidad.Text = "Cantidad:"
            '
            'SimpleButton_Add
            '
            Me.SimpleButton_Add.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton_Add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Add.Image = CType(resources.GetObject("SimpleButton_Add.Image"), System.Drawing.Image)
            Me.SimpleButton_Add.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.SimpleButton_Add.Location = New System.Drawing.Point(387, 3)
            Me.SimpleButton_Add.Name = "SimpleButton_Add"
            Me.SimpleButton_Add.Size = New System.Drawing.Size(75, 38)
            Me.SimpleButton_Add.TabIndex = 7
            '
            'SimpleButton_Delete
            '
            Me.SimpleButton_Delete.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Delete.Image = CType(resources.GetObject("SimpleButton_Delete.Image"), System.Drawing.Image)
            Me.SimpleButton_Delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.SimpleButton_Delete.Location = New System.Drawing.Point(468, 3)
            Me.SimpleButton_Delete.Name = "SimpleButton_Delete"
            Me.SimpleButton_Delete.Size = New System.Drawing.Size(75, 38)
            Me.SimpleButton_Delete.TabIndex = 8
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.GridControl1, 0, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 135)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 274)
            Me.TableLayoutPanel1.TabIndex = 2
            '
            'GridControl1
            '
            Me.GridControl1.DataSource = Me.ProductosDTOBindingSource
            Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl1.Location = New System.Drawing.Point(3, 3)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(693, 268)
            Me.GridControl1.TabIndex = 0
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'GridView1
            '
            Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.DarkSeaGreen
            Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
            Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
            Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GridView1.Appearance.Row.Options.UseFont = True
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCodigo, Me.colNombre, Me.colTalla, Me.colPrecio, Me.colStock, Me.colMarcaID, Me.colMarca})
            Me.GridView1.GridControl = Me.GridControl1
            Me.GridView1.Name = "GridView1"
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
            '
            'colNombre
            '
            Me.colNombre.Caption = "Nombre"
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 0
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
            Me.colPrecio.VisibleIndex = 4
            '
            'colStock
            '
            Me.colStock.Caption = "Cantidad"
            Me.colStock.FieldName = "Stock"
            Me.colStock.Name = "colStock"
            Me.colStock.Visible = True
            Me.colStock.VisibleIndex = 3
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
            Me.colMarca.VisibleIndex = 1
            '
            'VentasControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Main)
            Me.Name = "VentasControl"
            Me.Size = New System.Drawing.Size(705, 412)
            Me.TableLayoutPanel_Main.ResumeLayout(False)
            Me.TableLayoutPanel_Buttons.ResumeLayout(False)
            Me.TableLayoutPanel_Buttons.PerformLayout()
            Me.TableLayoutPanel_VentaFecha.ResumeLayout(False)
            Me.TableLayoutPanel_VentaFecha.PerformLayout()
            CType(Me.TextEdit_Venta_Numero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Productos.ResumeLayout(False)
            Me.TableLayoutPanel_Productos.PerformLayout()
            CType(Me.TextEdit_Cantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEdit_Productos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Main As TableLayoutPanel
        Friend WithEvents TableLayoutPanel_Buttons As TableLayoutPanel
        Friend WithEvents LabelControl_Total_Text As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Total_Value As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SimpleButton_Guardar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel_Productos As TableLayoutPanel
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents LabelControl_Venta_Text As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Fecha_text As DevExpress.XtraEditors.LabelControl
        Friend WithEvents DateTimePicker_Fecha As DateTimePicker
        Friend WithEvents TextEdit_Venta_Numero As DevExpress.XtraEditors.TextEdit
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents ProductosDTOBindingSource As BindingSource
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTalla As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarcaID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarca As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents TableLayoutPanel_VentaFecha As TableLayoutPanel
        Friend WithEvents SearchLookUpEdit_Productos As DevExpress.XtraEditors.SearchLookUpEdit
        Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents TextEdit_Cantidad As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LabelControl_Cantidad As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SimpleButton_Add As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Delete As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCodigo1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTalla1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrecio1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStock1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarcaID1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMarca1 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace