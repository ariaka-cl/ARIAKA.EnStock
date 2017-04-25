Namespace Controls
    Public Class VentasViewControl
        Private Property _cliente As New Logica.Cliente
        Private Sub SimpleButton_Buscar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Buscar.Click
            Me.VentasGridControl1.VentasDTOBindingSource.DataSource = _cliente.GetVentas(DateTimePicker_Desde.Value.Date, DateTimePicker_Hasta.Value.Date)
            Me.VentasGridControl1.GridView1.RefreshEditor(True)

            Dim ventasDTO As List(Of Models.VentasDTO) = TryCast(VentasGridControl1.GridView1.DataSource, BindingSource) _
                                                               .Cast(Of Models.VentasDTO).ToList()
            Dim total As Integer = 0
            For Each venta As Models.VentasDTO In ventasDTO
                total = CInt(venta.Total) + total
            Next
            LabelControl_Total_Value.Text = total.ToString()
        End Sub

        Private Sub SimpleButton_Delete_Click(sender As Object, e As EventArgs) Handles SimpleButton_Delete.Click
            Dim ventaDTO As Models.VentasDTO = CType(TryCast(Me.VentasGridControl1.VentasDTOBindingSource, BindingSource).Current, Models.VentasDTO)
            Dim totalVenta As Integer = 0
            Dim total As Integer = 0
            If ventaDTO IsNot Nothing AndAlso ventaDTO.ID <> 0 Then
                Dim answer As DialogResult = MessageBox.Show("Desea eliminar venta seleccionada", "Eliminar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If answer = DialogResult.Yes Then
                    totalVenta = CInt(ventaDTO.Total)
                    If _cliente.EliminarVenta(ventaDTO.ID) Then
                        MessageBox.Show("Se elimino venta correctamente", "Eliminar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.VentasGridControl1.GridView1.DeleteRow(Me.VentasGridControl1.GridView1.FocusedRowHandle)
                        total = CInt(Me.LabelControl_Total_Value.Text)
                        total = total - totalVenta
                        Me.LabelControl_Total_Value.Text = total.ToString()
                        Me.VentasGridControl1.GridView1.RefreshEditor(True)
                    Else
                        MessageBox.Show("Ocurrio un Error al eliminar venta", "Eliminar Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                Return
            End If
        End Sub
    End Class
End Namespace
