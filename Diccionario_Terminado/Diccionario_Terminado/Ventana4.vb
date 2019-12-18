Imports System.IO

Public Class Ventana4
    Dim save As New SaveFileDialog
    Dim imagen As String
    Dim indice As Integer
    Dim codigo As String
    Private Sub Ventana4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("ID", 20)
        ListView1.Columns.Add("Palabra", 100)
        ListView1.Columns.Add("Significado", 50)
        ListView1.Columns.Add("Path Image", 20)
        'lee linea a linea 


        REM añadir datos 
        Dim items(4) As String
        Dim item As ListViewItem

        items(0) = "001"
        items(1) = "Sistemas"
        items(2) = "Análisis de la Data"
        items(3) = "C:\Users\dyego\Downloads"
        OpenFileDialog1.InitialDirectory = "C:\Users\dyego\Downloads"
        item = New ListViewItem(items)
        ListView1.Items.Add(item)



    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        imagen = ListView1.SelectedItems.ToString


        Dim v2 As New Ventana2
        'MsgBox(ListBox2.SelectedIndex)


        'v3.PictureBox1.Image = Image.FromFile(ListView1.SelectedIndexCollection)
        'v3.P.Text = ListView1.Items(ListView1.SelectedIndices)
        'v3.S.Text = ListBox3.Items(ListBox2.SelectedIndex)
        Ventana4.ActiveForm.Hide()
        v2.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        imagen = ListView1.SelectedIndices.ToString
        MsgBox(imagen)
        ' variable global 
        indice = ListView1.FocusedItem.Index
        ' datos de las cajas de texto 
        Dim codigo As Integer
        Dim palabra, significado, path As String

        If (indice >= 0) Then
            codigo = ListView1.Items(indice).SubItems(0).Text
            palabra = ListView1.Items(indice).SubItems(1).Text
            significado = ListView1.Items(indice).SubItems(2).Text
            path = ListView1.Items(indice).SubItems(3).Text

            'pasar a la caja de texto 

            txtCod.Text = codigo
            txtPalabra.Text = palabra
            txtSignificado.Text = significado
            txtPath.Text = path
        End If



    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        'Dim save As New SaveFileDialog
        save.Filter = "Archivo.txt | *.txt"
        'condicion
        If save.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim archivo As New System.IO.StreamWriter(save.FileName)
            For Each item In ListView1.Items
                archivo.WriteLine(item.ToString())

            Next
            archivo.Close()
        End If
        'declaro respuesta 
        Dim respuesta As MsgBoxResult
        respuesta = MessageBox.Show("Desea vaciar su lista", "Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = vbYes Then
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim destino As String = ""
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Text(*.Txt*.txt)|*.Txt;txt|Todos los archivos(*.*)|*-*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                destino = .FileName
            End If
        End With
        'declarando y ciclo 
        Dim direccion As New System.IO.StreamReader(destino)
        While Not direccion.EndOfStream
            ListView1.Items.Add(direccion.ReadLine())
        End While
        direccion.Close()

    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim codigo As Integer
        Dim palabra As String
        Dim significado As String
        Dim path As String

        '
        codigo = txtCod.Text
        palabra = txtPalabra.Text
        significado = txtSignificado.Text
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName
            ListView1.Items.Add(txtPath.Text)

        End If

        path = txtPath.Text
        '
        With ListView1.Items.Add(codigo)
            .SubItems.Add(palabra)
            .SubItems.Add(significado)
            .SubItems.Add(path)


        End With
        borrarCampos()
    End Sub
    'metodo 
    Sub borrarCampos()
        txtCod.Text = ""
        txtPalabra.Text = ""
        txtSignificado.Text = ""
        txtPath.Text = ""
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'valores modificados 
        ListView1.Items(indice).SubItems(0).Text = txtCod.Text
        ListView1.Items(indice).SubItems(1).Text = txtPalabra.Text
        ListView1.Items(indice).SubItems(2).Text = txtSignificado.Text
        ListView1.Items(indice).SubItems(3).Text = txtPath.Text

        borrarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ListView1.Items.RemoveAt(indice)
        indice = -1
        borrarCampos()

    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class