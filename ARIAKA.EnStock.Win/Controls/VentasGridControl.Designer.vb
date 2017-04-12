Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class VentasGridControl
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
            Me.TableLayoutPanel_Ventas = New System.Windows.Forms.TableLayoutPanel()
            Me.GridControl_Ventas = New DevExpress.XtraGrid.GridControl()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.VentasDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Ventas.SuspendLayout()
            CType(Me.GridControl_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VentasDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Ventas
            '
            Me.TableLayoutPanel_Ventas.ColumnCount = 1
            Me.TableLayoutPanel_Ventas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Ventas.Controls.Add(Me.GridControl_Ventas, 0, 0)
            Me.TableLayoutPanel_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Ventas.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Ventas.Name = "TableLayoutPanel_Ventas"
            Me.TableLayoutPanel_Ventas.RowCount = 1
            Me.TableLayoutPanel_Ventas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Ventas.Size = New System.Drawing.Size(711, 375)
            Me.TableLayoutPanel_Ventas.TabIndex = 0
            '
            'GridControl_Ventas
            '
            Me.GridControl_Ventas.DataSource = Me.VentasDTOBindingSource
            Me.GridControl_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Ventas.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_Ventas.MainView = Me.GridView1
            Me.GridControl_Ventas.Name = "GridControl_Ventas"
            Me.GridControl_Ventas.Size = New System.Drawing.Size(705, 369)
            Me.GridControl_Ventas.TabIndex = 0
            Me.GridControl_Ventas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFechaCreacion, Me.colTotal})
            Me.GridView1.GridControl = Me.GridControl_Ventas
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsView.ShowAutoFilterRow = True
            '
            'VentasDTOBindingSource
            '
            Me.VentasDTOBindingSource.DataSource = GetType(ARIAKA.EnStock.Win.Models.VentasDTO)
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            '
            'colFechaCreacion
            '
            Me.colFechaCreacion.Caption = "Fecha Venta"
            Me.colFechaCreacion.FieldName = "FechaCreacion"
            Me.colFechaCreacion.Name = "colFechaCreacion"
            Me.colFechaCreacion.OptionsColumn.AllowEdit = False
            Me.colFechaCreacion.Visible = True
            Me.colFechaCreacion.VisibleIndex = 0
            '
            'colTotal
            '
            Me.colTotal.Caption = "Total"
            Me.colTotal.FieldName = "Total"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.OptionsColumn.AllowEdit = False
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 1
            '
            'VentasGridControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Ventas)
            Me.Name = "VentasGridControl"
            Me.Size = New System.Drawing.Size(711, 375)
            Me.TableLayoutPanel_Ventas.ResumeLayout(False)
            CType(Me.GridControl_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VentasDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Ventas As TableLayoutPanel
        Friend WithEvents GridControl_Ventas As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents VentasDTOBindingSource As BindingSource
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
