﻿Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace Controls
    Public Class VentasGridControl
        Private Sub GridControl_Ventas_DoubleClick(sender As Object, e As EventArgs) Handles GridControl_Ventas.DoubleClick

            Dim grid As GridControl = CType(sender, GridControl)
            Dim ventaID As Integer = CType(TryCast(grid.DataSource, BindingSource).Current, Models.VentasDTO).ID
            If ventaID = Nothing Then
                MessageBox.Show(String.Format("Fallo al obtener Comanda N°: {0}", ventaID), "Obtener Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            CallDetalleVenta(ventaID)
        End Sub

        Private Shared Sub CallDetalleVenta(ventaID As Integer)
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Clear()
            Dim ventas As New Controls.VentasControl With {.Dock = DockStyle.Fill, .Visible = True}
            ventas.VentaID = ventaID
            My.Forms.MainForm.TableLayoutPanel_Dash.Controls.Add(ventas, 0, 0)
            My.Forms.MainForm.TableLayoutPanel_Dash.Refresh()
            My.Forms.MainForm.SimpleButton_Volver.Visible = True
        End Sub
    End Class
End Namespace
