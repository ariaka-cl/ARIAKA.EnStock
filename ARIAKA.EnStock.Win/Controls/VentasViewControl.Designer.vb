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
            Me.TableLayoutPanel_VentasView = New System.Windows.Forms.TableLayoutPanel()
            Me.VentasGridControl1 = New ARIAKA.EnStock.Win.Controls.VentasGridControl()
            Me.TableLayoutPanel_VentasView.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_VentasView
            '
            Me.TableLayoutPanel_VentasView.ColumnCount = 1
            Me.TableLayoutPanel_VentasView.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_VentasView.Controls.Add(Me.VentasGridControl1, 0, 1)
            Me.TableLayoutPanel_VentasView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_VentasView.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_VentasView.Name = "TableLayoutPanel_VentasView"
            Me.TableLayoutPanel_VentasView.RowCount = 3
            Me.TableLayoutPanel_VentasView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.4508!))
            Me.TableLayoutPanel_VentasView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.5492!))
            Me.TableLayoutPanel_VentasView.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
            Me.TableLayoutPanel_VentasView.Size = New System.Drawing.Size(742, 437)
            Me.TableLayoutPanel_VentasView.TabIndex = 0
            '
            'VentasGridControl1
            '
            Me.VentasGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.VentasGridControl1.Location = New System.Drawing.Point(3, 74)
            Me.VentasGridControl1.Name = "VentasGridControl1"
            Me.VentasGridControl1.Size = New System.Drawing.Size(736, 290)
            Me.VentasGridControl1.TabIndex = 0
            '
            'VentasViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_VentasView)
            Me.Name = "VentasViewControl"
            Me.Size = New System.Drawing.Size(742, 437)
            Me.TableLayoutPanel_VentasView.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_VentasView As TableLayoutPanel
        Friend WithEvents VentasGridControl1 As Controls.VentasGridControl
    End Class
End Namespace