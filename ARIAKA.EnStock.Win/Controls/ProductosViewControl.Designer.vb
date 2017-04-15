Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProductosViewControl
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
            Me.SimpleButton_Eliminar = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Nombre = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Categoria = New DevExpress.XtraEditors.LabelControl()
            Me.TextBox_Codigo = New System.Windows.Forms.TextBox()
            Me.TextBox_Precio = New System.Windows.Forms.TextBox()
            Me.SimpleButton_Guardar = New DevExpress.XtraEditors.SimpleButton()
            Me.ComboBox_Marca = New System.Windows.Forms.ComboBox()
            Me.MarcaDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Talla = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Stock = New DevExpress.XtraEditors.LabelControl()
            Me.TextBox_Stock = New System.Windows.Forms.TextBox()
            Me.TextBox_Talla = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.ProductosControl1 = New ARIAKA.EnStock.Win.Controls.ProductosControl()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.MarcaDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 8
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Nombre, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton_Eliminar, 7, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl_Nombre, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl_Categoria, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Codigo, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Precio, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.SimpleButton_Guardar, 6, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.ComboBox_Marca, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl_Talla, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl_Stock, 4, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Stock, 5, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Talla, 5, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(837, 86)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'TextBox_Nombre
            '
            Me.TextBox_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox_Nombre.Location = New System.Drawing.Point(73, 52)
            Me.TextBox_Nombre.Name = "TextBox_Nombre"
            Me.TextBox_Nombre.Size = New System.Drawing.Size(112, 24)
            Me.TextBox_Nombre.TabIndex = 8
            '
            'SimpleButton_Eliminar
            '
            Me.SimpleButton_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Eliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Eliminar.Appearance.Options.UseFont = True
            Me.SimpleButton_Eliminar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Eliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Eliminar.Location = New System.Drawing.Point(716, 2)
            Me.SimpleButton_Eliminar.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton_Eliminar.Name = "SimpleButton_Eliminar"
            Me.SimpleButton_Eliminar.Size = New System.Drawing.Size(98, 39)
            Me.SimpleButton_Eliminar.TabIndex = 6
            Me.SimpleButton_Eliminar.Text = "Eliminar"
            '
            'LabelControl1
            '
            Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl1.Location = New System.Drawing.Point(17, 12)
            Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(51, 18)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "Codigo"
            '
            'LabelControl_Nombre
            '
            Me.LabelControl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Nombre.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Nombre.Location = New System.Drawing.Point(9, 55)
            Me.LabelControl_Nombre.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Nombre.Name = "LabelControl_Nombre"
            Me.LabelControl_Nombre.Size = New System.Drawing.Size(59, 18)
            Me.LabelControl_Nombre.TabIndex = 1
            Me.LabelControl_Nombre.Text = "Nombre"
            '
            'LabelControl_Categoria
            '
            Me.LabelControl_Categoria.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Categoria.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Categoria.Location = New System.Drawing.Point(201, 12)
            Me.LabelControl_Categoria.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Categoria.Name = "LabelControl_Categoria"
            Me.LabelControl_Categoria.Size = New System.Drawing.Size(95, 18)
            Me.LabelControl_Categoria.TabIndex = 2
            Me.LabelControl_Categoria.Text = "Proveedores"
            '
            'TextBox_Codigo
            '
            Me.TextBox_Codigo.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox_Codigo.Location = New System.Drawing.Point(72, 9)
            Me.TextBox_Codigo.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox_Codigo.Name = "TextBox_Codigo"
            Me.TextBox_Codigo.Size = New System.Drawing.Size(114, 24)
            Me.TextBox_Codigo.TabIndex = 0
            '
            'TextBox_Precio
            '
            Me.TextBox_Precio.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox_Precio.Location = New System.Drawing.Point(300, 52)
            Me.TextBox_Precio.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox_Precio.Name = "TextBox_Precio"
            Me.TextBox_Precio.Size = New System.Drawing.Size(114, 24)
            Me.TextBox_Precio.TabIndex = 3
            '
            'SimpleButton_Guardar
            '
            Me.SimpleButton_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton_Guardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Guardar.Appearance.Options.UseFont = True
            Me.SimpleButton_Guardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Guardar.Location = New System.Drawing.Point(615, 2)
            Me.SimpleButton_Guardar.Margin = New System.Windows.Forms.Padding(2)
            Me.SimpleButton_Guardar.Name = "SimpleButton_Guardar"
            Me.SimpleButton_Guardar.Size = New System.Drawing.Size(97, 39)
            Me.SimpleButton_Guardar.TabIndex = 5
            Me.SimpleButton_Guardar.Text = "Guardar"
            '
            'ComboBox_Marca
            '
            Me.ComboBox_Marca.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.ComboBox_Marca.DataSource = Me.MarcaDTOBindingSource
            Me.ComboBox_Marca.DisplayMember = "Nombre"
            Me.ComboBox_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ComboBox_Marca.FormattingEnabled = True
            Me.ComboBox_Marca.Location = New System.Drawing.Point(301, 8)
            Me.ComboBox_Marca.Name = "ComboBox_Marca"
            Me.ComboBox_Marca.Size = New System.Drawing.Size(112, 26)
            Me.ComboBox_Marca.TabIndex = 2
            Me.ComboBox_Marca.ValueMember = "ID"
            '
            'MarcaDTOBindingSource
            '
            Me.MarcaDTOBindingSource.DataSource = GetType(ARIAKA.EnStock.Win.Models.MarcaDTO)
            '
            'LabelControl4
            '
            Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl4.Location = New System.Drawing.Point(248, 55)
            Me.LabelControl4.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(48, 18)
            Me.LabelControl4.TabIndex = 3
            Me.LabelControl4.Text = "Precio"
            '
            'LabelControl_Talla
            '
            Me.LabelControl_Talla.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Talla.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Talla.Location = New System.Drawing.Point(446, 12)
            Me.LabelControl_Talla.Name = "LabelControl_Talla"
            Me.LabelControl_Talla.Size = New System.Drawing.Size(37, 18)
            Me.LabelControl_Talla.TabIndex = 7
            Me.LabelControl_Talla.Text = "Talla"
            '
            'LabelControl_Stock
            '
            Me.LabelControl_Stock.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Stock.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Stock.Location = New System.Drawing.Point(441, 55)
            Me.LabelControl_Stock.Margin = New System.Windows.Forms.Padding(2)
            Me.LabelControl_Stock.Name = "LabelControl_Stock"
            Me.LabelControl_Stock.Size = New System.Drawing.Size(43, 18)
            Me.LabelControl_Stock.TabIndex = 4
            Me.LabelControl_Stock.Text = "Stock"
            '
            'TextBox_Stock
            '
            Me.TextBox_Stock.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox_Stock.Location = New System.Drawing.Point(489, 52)
            Me.TextBox_Stock.Name = "TextBox_Stock"
            Me.TextBox_Stock.Size = New System.Drawing.Size(93, 24)
            Me.TextBox_Stock.TabIndex = 4
            '
            'TextBox_Talla
            '
            Me.TextBox_Talla.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.TextBox_Talla.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextBox_Talla.Location = New System.Drawing.Point(488, 9)
            Me.TextBox_Talla.Margin = New System.Windows.Forms.Padding(2)
            Me.TextBox_Talla.Name = "TextBox_Talla"
            Me.TextBox_Talla.Size = New System.Drawing.Size(95, 24)
            Me.TextBox_Talla.TabIndex = 1
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.AutoSize = True
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.ProductosControl1, 0, 1)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(841, 458)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'ProductosControl1
            '
            Me.ProductosControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProductosControl1.Location = New System.Drawing.Point(3, 93)
            Me.ProductosControl1.Name = "ProductosControl1"
            Me.ProductosControl1.Size = New System.Drawing.Size(835, 362)
            Me.ProductosControl1.TabIndex = 1
            '
            'ProductosViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel2)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "ProductosViewControl"
            Me.Size = New System.Drawing.Size(841, 458)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.MarcaDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Nombre As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Categoria As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Stock As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TextBox_Codigo As Windows.Forms.TextBox
        Friend WithEvents TextBox_Talla As Windows.Forms.TextBox
        Friend WithEvents TextBox_Precio As Windows.Forms.TextBox
        Friend WithEvents SimpleButton_Guardar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel2 As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton_Eliminar As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ProductosControl1 As ProductosControl
        Friend WithEvents ComboBox_Marca As Windows.Forms.ComboBox
        Friend WithEvents MarcaDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents TextBox_Stock As Windows.Forms.TextBox
        Friend WithEvents LabelControl_Talla As DevExpress.XtraEditors.LabelControl
        Friend WithEvents TextBox_Nombre As TextBox
    End Class
End Namespace
