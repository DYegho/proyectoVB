Imports System.IO


Public Class Ventana2
    Dim ListDiccionario As ListView
    Dim palabra, defnicion As String
    Dim indice As String

    Public Sub New()

        InitializeComponent()

        cmbImages.DropDownStyle = ComboBoxStyle.DropDownList
        cmbImages.DrawMode = DrawMode.OwnerDrawFixed
        cmbImages.Items.AddRange(
         Enumerable.Repeat(Of String)("", listImage.Images.Count).ToArray())

    End Sub
    Private Sub cmbImages_DrawItem(sender As Object, e As DrawItemEventArgs)
        e.DrawBackground()
        e.DrawFocusRectangle()
        If e.Index >= 0 Then
            If e.Index < listImage.Images.Count Then
                Dim img As Image = New Bitmap(listImage.Images(e.Index), New Size(32, 32))
                e.Graphics.DrawImage(img, New PointF(e.Bounds.Left, e.Bounds.Top))
            End If
            e.Graphics.DrawString(String.Format("min {0}", e.Index + 1) _
                    , e.Font, New SolidBrush(e.ForeColor) _
                    , e.Bounds.Left + 32, e.Bounds.Top)
        End If
    End Sub



    Private Sub ListPalabras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPalabras.SelectedIndexChanged
        If ListPalabras.SelectedItems.Count > 0 Then

            Dim item As ListViewItem = ListPalabras.SelectedItems(0)

            Dim palabra As String = item.SubItems(1).Text
            Dim significado As String = item.SubItems(1).Text
            Dim path As String = item.SubItems(1).Text

            Ventana3.txtDescripcion.Text = palabra
            Ventana3.txtDescripcion.Text = significado


            Ventana3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Ventana1.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim item As ListViewItem = ListPalabras.SelectedItems(0)
        If (ListPalabras.SelectedIndex > -1) Then

            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            ListPalabras.Items.RemoveAt(ListPalabras.SelectedIndex)


        End If
    End Sub

    Private Sub cmbImages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbImages.SelectedIndexChanged
        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedIndex >= 0 Then
            picImage.Image = listImage.Images(combo.SelectedIndex)
        Else
            picImage.Image = Nothing
        End If
    End Sub
    Private Pasar_Datos As String

    Public Sub New(Datos As String)
        InitializeComponent()
        Pasar_Datos = Datos
        Pasar_Datos = palabra
        Pasar_Datos = significado


    End Sub
    Private Sub btnTabla_Click(sender As Object, e As EventArgs) Handles btnTabla.Click
        'TextBox.Text.Aggregate(ListPalabras.Items.Insert)
        Dim Datos As String
        InitializeComponent()
        Pasar_Datos = Datos
        Pasar_Datos = palabra
        Pasar_Datos = significado
        Pasar_Datos = path

        Ventana4.Show()
        Me.Hide()
    End Sub



    Private Sub Ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListPalabras = ListPalabras
        listImage = listImage


    End Sub
End Class