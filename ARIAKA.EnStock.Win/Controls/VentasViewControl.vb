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
    End Class
End Namespace
