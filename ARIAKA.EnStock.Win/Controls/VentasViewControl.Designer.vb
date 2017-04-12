Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class VentasViewControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentasViewControl))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.VentasGridControl1 = New ARIAKA.EnStock.Win.Controls.VentasGridControl()
            Me.TableLayoutPanel_DateBox = New System.Windows.Forms.TableLayoutPanel()
            Me.LabelControl_Desde = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Hasta = New DevExpress.XtraEditors.LabelControl()
            Me.DateTimePicker_Desde = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker_Hasta = New System.Windows.Forms.DateTimePicker()
            Me.TableLayoutPanel_Footer = New System.Windows.Forms.TableLayoutPanel()
            Me.LabelControl_Total = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Total_Value = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton_Buscar = New DevExpress.XtraEditors.SimpleButton()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel_DateBox.SuspendLayout()
            Me.TableLayoutPanel_Footer.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.VentasGridControl1, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel_DateBox, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel_Footer, 0, 2)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 3
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.45283!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.54717!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(742, 445)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'VentasGridControl1
            '
            Me.VentasGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.VentasGridControl1.Location = New System.Drawing.Point(3, 68)
            Me.VentasGridControl1.Name = "VentasGridControl1"
            Me.VentasGridControl1.Size = New System.Drawing.Size(736, 303)
            Me.VentasGridControl1.TabIndex = 0
            '
            'TableLayoutPanel_DateBox
            '
            Me.TableLayoutPanel_DateBox.ColumnCount = 5
            Me.TableLayoutPanel_DateBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel_DateBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel_DateBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel_DateBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
            Me.TableLayoutPanel_DateBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel_DateBox.Controls.Add(Me.LabelControl_Desde, 0, 0)
            Me.TableLayoutPanel_DateBox.Controls.Add(Me.LabelControl_Hasta, 2, 0)
            Me.TableLayoutPanel_DateBox.Controls.Add(Me.DateTimePicker_Desde, 1, 0)
            Me.TableLayoutPanel_DateBox.Controls.Add(Me.DateTimePicker_Hasta, 3, 0)
            Me.TableLayoutPanel_DateBox.Controls.Add(Me.SimpleButton_Buscar, 4, 0)
            Me.TableLayoutPanel_DateBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_DateBox.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel_DateBox.Name = "TableLayoutPanel_DateBox"
            Me.TableLayoutPanel_DateBox.RowCount = 1
            Me.TableLayoutPanel_DateBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_DateBox.Size = New System.Drawing.Size(736, 59)
            Me.TableLayoutPanel_DateBox.TabIndex = 1
            '
            'LabelControl_Desde
            '
            Me.LabelControl_Desde.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Desde.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Desde.Location = New System.Drawing.Point(47, 17)
            Me.LabelControl_Desde.Name = "LabelControl_Desde"
            Me.LabelControl_Desde.Size = New System.Drawing.Size(72, 25)
            Me.LabelControl_Desde.TabIndex = 0
            Me.LabelControl_Desde.Text = "Desde:"
            '
            'LabelControl_Hasta
            '
            Me.LabelControl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Hasta.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Hasta.Location = New System.Drawing.Point(293, 17)
            Me.LabelControl_Hasta.Name = "LabelControl_Hasta"
            Me.LabelControl_Hasta.Size = New System.Drawing.Size(70, 25)
            Me.LabelControl_Hasta.TabIndex = 1
            Me.LabelControl_Hasta.Text = "Hasta:"
            '
            'DateTimePicker_Desde
            '
            Me.DateTimePicker_Desde.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.DateTimePicker_Desde.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker_Desde.Location = New System.Drawing.Point(125, 14)
            Me.DateTimePicker_Desde.Name = "DateTimePicker_Desde"
            Me.DateTimePicker_Desde.Size = New System.Drawing.Size(116, 30)
            Me.DateTimePicker_Desde.TabIndex = 2
            '
            'DateTimePicker_Hasta
            '
            Me.DateTimePicker_Hasta.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.DateTimePicker_Hasta.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker_Hasta.Location = New System.Drawing.Point(369, 14)
            Me.DateTimePicker_Hasta.Name = "DateTimePicker_Hasta"
            Me.DateTimePicker_Hasta.Size = New System.Drawing.Size(116, 30)
            Me.DateTimePicker_Hasta.TabIndex = 3
            '
            'TableLayoutPanel_Footer
            '
            Me.TableLayoutPanel_Footer.ColumnCount = 2
            Me.TableLayoutPanel_Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.02717!))
            Me.TableLayoutPanel_Footer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97283!))
            Me.TableLayoutPanel_Footer.Controls.Add(Me.LabelControl_Total, 0, 0)
            Me.TableLayoutPanel_Footer.Controls.Add(Me.LabelControl_Total_Value, 1, 0)
            Me.TableLayoutPanel_Footer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Footer.Location = New System.Drawing.Point(3, 377)
            Me.TableLayoutPanel_Footer.Name = "TableLayoutPanel_Footer"
            Me.TableLayoutPanel_Footer.RowCount = 1
            Me.TableLayoutPanel_Footer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Footer.Size = New System.Drawing.Size(736, 65)
            Me.TableLayoutPanel_Footer.TabIndex = 2
            '
            'LabelControl_Total
            '
            Me.LabelControl_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Total.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total.Location = New System.Drawing.Point(503, 20)
            Me.LabelControl_Total.Name = "LabelControl_Total"
            Me.LabelControl_Total.Size = New System.Drawing.Size(82, 25)
            Me.LabelControl_Total.TabIndex = 0
            Me.LabelControl_Total.Text = "TOTAL: "
            '
            'LabelControl_Total_Value
            '
            Me.LabelControl_Total_Value.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.LabelControl_Total_Value.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total_Value.Location = New System.Drawing.Point(591, 20)
            Me.LabelControl_Total_Value.Name = "LabelControl_Total_Value"
            Me.LabelControl_Total_Value.Size = New System.Drawing.Size(13, 25)
            Me.LabelControl_Total_Value.TabIndex = 1
            Me.LabelControl_Total_Value.Text = "0"
            '
            'SimpleButton_Buscar
            '
            Me.SimpleButton_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Buscar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Buscar.Appearance.Options.UseFont = True
            Me.SimpleButton_Buscar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Buscar.Image = CType(resources.GetObject("SimpleButton_Buscar.Image"), System.Drawing.Image)
            Me.SimpleButton_Buscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Buscar.Location = New System.Drawing.Point(491, 3)
            Me.SimpleButton_Buscar.Name = "SimpleButton_Buscar"
            Me.SimpleButton_Buscar.Size = New System.Drawing.Size(104, 53)
            Me.SimpleButton_Buscar.TabIndex = 4
            Me.SimpleButton_Buscar.Text = "Buscar"
            '
            'VentasViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "VentasViewControl"
            Me.Size = New System.Drawing.Size(742, 445)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel_DateBox.ResumeLayout(False)
            Me.TableLayoutPanel_DateBox.PerformLayout()
            Me.TableLayoutPanel_Footer.ResumeLayout(False)
            Me.TableLayoutPanel_Footer.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents VentasGridControl1 As VentasGridControl
        Friend WithEvents TableLayoutPanel_DateBox As TableLayoutPanel
        Friend WithEvents LabelControl_Desde As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Hasta As DevExpress.XtraEditors.LabelControl
        Friend WithEvents DateTimePicker_Desde As DateTimePicker
        Friend WithEvents DateTimePicker_Hasta As DateTimePicker
        Friend WithEvents TableLayoutPanel_Footer As TableLayoutPanel
        Friend WithEvents LabelControl_Total As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Total_Value As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SimpleButton_Buscar As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
