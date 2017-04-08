Namespace Controls
    Public Class MarcaViewControl
        Private Property _cliente As New Logica.Cliente

        Public Sub MarcaViewControl_Load() Handles MyBase.Load
            PopulateMarcaGrid()
        End Sub

        Public Sub PopulateMarcaGrid()
            Dim listMarcaDto As List(Of Models.MarcaDTO) = _cliente.GetMarca()
            If listMarcaDto IsNot Nothing Then
                Me.MarcaControl.MarcaDTOBindingSource.DataSource = listMarcaDto
                Me.MarcaControl.GridView1.RefreshEditor(True)
            End If

        End Sub
        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            Dim marcaDto As New Models.MarcaDTO With {.Nombre = Me.TextEdit_Nombre.Text}
            marcaDto = _cliente.GuardarMarcas(marcaDto)
            Me.MarcaControl.MarcaDTOBindingSource.Add(marcaDto)
            Me.MarcaControl.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton_Eliminar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Eliminar.Click
            Dim categoriaDto As Models.MarcaDTO = CType(MarcaControl.MarcaDTOBindingSource.Current, Models.MarcaDTO)

            Dim id As Integer = categoriaDto.ID
            If id <> 0 Then _cliente.EliminarMarca(id)
            MarcaControl.GridView1.DeleteRow(MarcaControl.GridView1.FocusedRowHandle)
            Me.MarcaControl.GridView1.RefreshEditor(True)
        End Sub

    End Class
End Namespace
