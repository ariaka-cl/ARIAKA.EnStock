Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.DefaultLookAndFeel_Main = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.TableLayoutPanel_Main = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Dash = New System.Windows.Forms.TableLayoutPanel()
            Me.PictureBox_HomeImage = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel_Header = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton_Search = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_AddSale = New DevExpress.XtraEditors.SimpleButton()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel_LeftMenu = New System.Windows.Forms.TableLayoutPanel()
            Me.SimpleButton_Ventas = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Productos = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Marca = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel_Main.SuspendLayout()
            Me.TableLayoutPanel_Dash.SuspendLayout()
            CType(Me.PictureBox_HomeImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Header.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_LeftMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Main
            '
            Me.TableLayoutPanel_Main.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel_Main.ColumnCount = 2
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4605!))
            Me.TableLayoutPanel_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.5395!))
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Dash, 1, 1)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_Header, 1, 0)
            Me.TableLayoutPanel_Main.Controls.Add(Me.PictureBox1, 0, 0)
            Me.TableLayoutPanel_Main.Controls.Add(Me.TableLayoutPanel_LeftMenu, 0, 1)
            Me.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Main.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main"
            Me.TableLayoutPanel_Main.RowCount = 2
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77379!))
            Me.TableLayoutPanel_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22621!))
            Me.TableLayoutPanel_Main.Size = New System.Drawing.Size(1053, 651)
            Me.TableLayoutPanel_Main.TabIndex = 0
            '
            'TableLayoutPanel_Dash
            '
            Me.TableLayoutPanel_Dash.AutoSize = True
            Me.TableLayoutPanel_Dash.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel_Dash.ColumnCount = 1
            Me.TableLayoutPanel_Dash.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Controls.Add(Me.PictureBox_HomeImage, 0, 0)
            Me.TableLayoutPanel_Dash.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Dash.Location = New System.Drawing.Point(207, 118)
            Me.TableLayoutPanel_Dash.Name = "TableLayoutPanel_Dash"
            Me.TableLayoutPanel_Dash.RowCount = 1
            Me.TableLayoutPanel_Dash.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Dash.Size = New System.Drawing.Size(843, 530)
            Me.TableLayoutPanel_Dash.TabIndex = 1
            '
            'PictureBox_HomeImage
            '
            Me.PictureBox_HomeImage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox_HomeImage.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox_HomeImage.Name = "PictureBox_HomeImage"
            Me.PictureBox_HomeImage.Size = New System.Drawing.Size(837, 524)
            Me.PictureBox_HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox_HomeImage.TabIndex = 0
            Me.PictureBox_HomeImage.TabStop = False
            '
            'TableLayoutPanel_Header
            '
            Me.TableLayoutPanel_Header.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel_Header.ColumnCount = 3
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_Search, 0, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_AddSale, 0, 0)
            Me.TableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Header.Location = New System.Drawing.Point(207, 3)
            Me.TableLayoutPanel_Header.Name = "TableLayoutPanel_Header"
            Me.TableLayoutPanel_Header.RowCount = 1
            Me.TableLayoutPanel_Header.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Header.Size = New System.Drawing.Size(843, 109)
            Me.TableLayoutPanel_Header.TabIndex = 2
            '
            'SimpleButton_Search
            '
            Me.SimpleButton_Search.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.SimpleButton_Search.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Search.Appearance.Options.UseFont = True
            Me.SimpleButton_Search.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Search.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Search.Image = CType(resources.GetObject("SimpleButton_Search.Image"), System.Drawing.Image)
            Me.SimpleButton_Search.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Search.Location = New System.Drawing.Point(163, 24)
            Me.SimpleButton_Search.Name = "SimpleButton_Search"
            Me.SimpleButton_Search.Size = New System.Drawing.Size(114, 60)
            Me.SimpleButton_Search.TabIndex = 1
            Me.SimpleButton_Search.Text = "Detalle"
            '
            'SimpleButton_AddSale
            '
            Me.SimpleButton_AddSale.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.SimpleButton_AddSale.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_AddSale.Appearance.Options.UseFont = True
            Me.SimpleButton_AddSale.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_AddSale.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_AddSale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_AddSale.Image = CType(resources.GetObject("SimpleButton_AddSale.Image"), System.Drawing.Image)
            Me.SimpleButton_AddSale.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_AddSale.Location = New System.Drawing.Point(16, 24)
            Me.SimpleButton_AddSale.Name = "SimpleButton_AddSale"
            Me.SimpleButton_AddSale.Size = New System.Drawing.Size(114, 60)
            Me.SimpleButton_AddSale.TabIndex = 0
            Me.SimpleButton_AddSale.Text = "Venta"
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(198, 109)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 3
            Me.PictureBox1.TabStop = False
            '
            'TableLayoutPanel_LeftMenu
            '
            Me.TableLayoutPanel_LeftMenu.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel_LeftMenu.ColumnCount = 1
            Me.TableLayoutPanel_LeftMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Ventas, 0, 0)
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Productos, 0, 1)
            Me.TableLayoutPanel_LeftMenu.Controls.Add(Me.SimpleButton_Marca, 0, 2)
            Me.TableLayoutPanel_LeftMenu.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel_LeftMenu.Location = New System.Drawing.Point(3, 118)
            Me.TableLayoutPanel_LeftMenu.Name = "TableLayoutPanel_LeftMenu"
            Me.TableLayoutPanel_LeftMenu.RowCount = 3
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel_LeftMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel_LeftMenu.Size = New System.Drawing.Size(198, 313)
            Me.TableLayoutPanel_LeftMenu.TabIndex = 0
            '
            'SimpleButton_Ventas
            '
            Me.SimpleButton_Ventas.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Ventas.Appearance.Options.UseFont = True
            Me.SimpleButton_Ventas.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Ventas.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Ventas.AutoSize = True
            Me.SimpleButton_Ventas.AutoWidthInLayoutControl = True
            Me.SimpleButton_Ventas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Ventas.Image = CType(resources.GetObject("SimpleButton_Ventas.Image"), System.Drawing.Image)
            Me.SimpleButton_Ventas.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Ventas.Location = New System.Drawing.Point(3, 3)
            Me.SimpleButton_Ventas.Name = "SimpleButton_Ventas"
            Me.SimpleButton_Ventas.Size = New System.Drawing.Size(192, 98)
            Me.SimpleButton_Ventas.TabIndex = 0
            Me.SimpleButton_Ventas.Text = "Ventas"
            '
            'SimpleButton_Productos
            '
            Me.SimpleButton_Productos.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Productos.Appearance.Options.UseFont = True
            Me.SimpleButton_Productos.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Productos.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Productos.AutoSize = True
            Me.SimpleButton_Productos.AutoWidthInLayoutControl = True
            Me.SimpleButton_Productos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Productos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Productos.Image = CType(resources.GetObject("SimpleButton_Productos.Image"), System.Drawing.Image)
            Me.SimpleButton_Productos.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Productos.Location = New System.Drawing.Point(3, 107)
            Me.SimpleButton_Productos.Name = "SimpleButton_Productos"
            Me.SimpleButton_Productos.Size = New System.Drawing.Size(192, 98)
            Me.SimpleButton_Productos.TabIndex = 1
            Me.SimpleButton_Productos.Text = "Productos"
            '
            'SimpleButton_Marca
            '
            Me.SimpleButton_Marca.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Marca.Appearance.Options.UseFont = True
            Me.SimpleButton_Marca.AppearanceHovered.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.SimpleButton_Marca.AppearanceHovered.Options.UseBackColor = True
            Me.SimpleButton_Marca.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Marca.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SimpleButton_Marca.Image = CType(resources.GetObject("SimpleButton_Marca.Image"), System.Drawing.Image)
            Me.SimpleButton_Marca.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Marca.Location = New System.Drawing.Point(3, 211)
            Me.SimpleButton_Marca.Name = "SimpleButton_Marca"
            Me.SimpleButton_Marca.Size = New System.Drawing.Size(192, 99)
            Me.SimpleButton_Marca.TabIndex = 2
            Me.SimpleButton_Marca.Text = "Proveedores"
            '
            'MainForm
            '
            Me.ActiveGlowColor = System.Drawing.Color.Transparent
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1053, 651)
            Me.Controls.Add(Me.TableLayoutPanel_Main)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "EnStock *** BABY SHEA ***"
            Me.TableLayoutPanel_Main.ResumeLayout(False)
            Me.TableLayoutPanel_Main.PerformLayout()
            Me.TableLayoutPanel_Dash.ResumeLayout(False)
            CType(Me.PictureBox_HomeImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Header.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_LeftMenu.ResumeLayout(False)
            Me.TableLayoutPanel_LeftMenu.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DefaultLookAndFeel_Main As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents TableLayoutPanel_Main As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel_LeftMenu As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton_Ventas As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Productos As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Marca As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TableLayoutPanel_Dash As Windows.Forms.TableLayoutPanel
        Friend WithEvents TableLayoutPanel_Header As Windows.Forms.TableLayoutPanel
        Friend WithEvents SimpleButton_AddSale As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
        Friend WithEvents PictureBox_HomeImage As Windows.Forms.PictureBox
        Friend WithEvents SimpleButton_Search As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace