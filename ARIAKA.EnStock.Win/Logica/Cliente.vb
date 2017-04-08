Imports System.Windows.Forms
Imports ARIAKA.EnStock.Data
Namespace Logica
    Public Class Cliente
        Public Function GetMarca() As List(Of Models.MarcaDTO)
            Dim db As New EnStockContext
            Try
                Dim listMarca As List(Of Marca) = db.Marca.ToList()
                Dim listMarcaDto As New List(Of Models.MarcaDTO)
                For Each marca As Marca In listMarca

                    listMarcaDto.Add(New Models.MarcaDTO With {.ID = marca.ID,
                                                                   .Nombre = marca.Nombre})
                Next

                Return listMarcaDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Obtener Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New List(Of Models.MarcaDTO)
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function GuardarMarcas(marcasDto As Models.MarcaDTO) As Models.MarcaDTO
            Dim db As New EnStockContext
            Try
                Dim marca As New Marca With {.Nombre = marcasDto.Nombre}
                db.Marca.Add(marca)
                db.SaveChanges()
                marcasDto.ID = marca.ID

                Return marcasDto
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Agregar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return New Models.MarcaDTO
            Finally
                db.Dispose()
            End Try
        End Function

        Public Function EliminarMarca(id As Integer) As Boolean
            Dim db As New EnStockContext
            Try
                Dim marca As Marca = db.Marca.Where(Function(m) m.ID = id).SingleOrDefault()
                db.Marca.Remove(marca)
                db.SaveChanges()
                Return True

            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message), "Error Eliminar Marca", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                db.Dispose()
            End Try
        End Function


    End Class
End Namespace