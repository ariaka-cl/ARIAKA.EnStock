Namespace Forms
    Public Class MainForm

        Private Property _FechaIni As Date
        Public Property FechaIni As Date
            Get
                Return _FechaIni
            End Get
            Set(value As Date)
                _FechaIni = value
            End Set
        End Property

        Private Property _FechaFin As Date
        Public Property FechaFin As Date
            Get
                Return _FechaFin
            End Get
            Set(value As Date)
                _FechaFin = value
            End Set
        End Property

        Private Sub SimpleButton_Marca_Click(sender As Object, e As EventArgs) Handles SimpleButton_Marca.Click
            Me.SimpleButton_Volver.Visible = False
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim categoria As New Controls.MarcaViewControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(categoria, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub

        Private Sub SimpleButton_Productos_Click(sender As Object, e As EventArgs) Handles SimpleButton_Productos.Click
            Me.SimpleButton_Volver.Visible = False
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim productos As New Controls.ProductosViewControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(productos, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub

        Private Sub SimpleButton_Ventas_Click(sender As Object, e As EventArgs) Handles SimpleButton_Ventas.Click
            Me.SimpleButton_Volver.Visible = False
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim ventas As New Controls.VentasViewControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(ventas, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub

        Private Sub SimpleButton_AddSale_Click(sender As Object, e As EventArgs) Handles SimpleButton_AddSale.Click
            Me.SimpleButton_Volver.Visible = False
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim ventas As New Controls.VentasControl With {.Dock = DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(ventas, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub

        Private Sub SimpleButton_Volver_Click(sender As Object, e As EventArgs) Handles SimpleButton_Volver.Click
            Dim cliente As New Logica.Cliente
            Me.SimpleButton_Volver.Visible = False
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim ventas As New Controls.VentasViewControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            ventas.DateTimePicker_Desde.Value = _FechaIni
            ventas.DateTimePicker_Hasta.Value = _FechaFin
            ventas.PopulateGridVentas(_FechaIni, _FechaFin)
            Me.TableLayoutPanel_Dash.Controls.Add(ventas, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub
    End Class
End Namespace