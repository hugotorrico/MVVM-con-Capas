Imports Data
Imports Entity

Public Class BCategoria

    Dim DCategoria As DCategoria

    Public Function Listar(ByVal IdCategoria As Integer) As List(Of Categoria)
        Dim categorias As List(Of Categoria) = Nothing

        Try
            DCategoria = New DCategoria()
            categorias = DCategoria.Listar(New Categoria With {
                .IdCategoria = IdCategoria
            })
        Catch ex As Exception
            Throw ex
        End Try

        Return categorias
    End Function



End Class
