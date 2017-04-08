Namespace Forms
    Public Class MainForm
        Private Sub SimpleButton_Marca_Click(sender As Object, e As EventArgs) Handles SimpleButton_Marca.Click
            Me.TableLayoutPanel_Dash.Controls.Clear()
            Dim categoria As New Controls.MarcaViewControl With {.Dock = Windows.Forms.DockStyle.Fill, .Visible = True}
            Me.TableLayoutPanel_Dash.Controls.Add(categoria, 0, 0)
            Me.TableLayoutPanel_Dash.Refresh()
        End Sub
    End Class
End Namespace