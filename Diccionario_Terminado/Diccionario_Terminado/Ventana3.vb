Public Class Ventana3


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Ventana2.Show()
        Me.Hide()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim palabra, definicion, path, dic As String
        palabra = txtDescripcion.Text
        definicion = txtDescripcion.Text
        path = txtPath.Text
        dic = palabra + ":" + definicion + ":" + path
        Dim item1 As ListViewItem
        Dim item2 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra & definicion)
        item2 = New ListViewItem(path, 0)
        item2.SubItems.Add(path)

        'item1.SubItems.Add(definicion)
        Ventana2.ListPalabras.Items.Add(item1)
        Ventana2.ListPalabras.Refresh()
        Ventana2.Show()
        Me.Hide()
    End Sub
End Class