Imports System.IO
Imports Diccionario_Terminado

Public Class Ventana1

    Dim list_diccionario As New List(Of String)
    'Dim imagen As String
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Dim escribir As New StreamWriter("C: \Users\dyego\OneDrive\Escritorio\prueba.txt", True)

        Dim palabra, definicion, path, dic As String
        palabra = txtPalabra.Text

        definicion = txtSgnificado.Text

        path = txtPath.Text


        dic = palabra + ":" + definicion + ":" + path
        Dim item1 As ListViewItem
        '
        Dim item2 As ListViewItem
        Dim item3 As ListViewItem
        item1 = New ListViewItem(palabra, 0)
        item1.SubItems.Add(palabra)
        '
        item2 = New ListViewItem(definicion, 0)
        item2.SubItems.Add(definicion)
        item3 = New ListViewItem(path, 0)
        item3.SubItems.Add(path)

        'cargar imagen



        Ventana2.ListPalabras.Items.Add(item1)
        '
        'Ventana2.ListPalabras.Items.Add(item2)
        Ventana2.ListPalabras.Items.Add(item3)

        Ventana2.Show()
        Me.Hide()
    End Sub

    '
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPalabra.Text = ""
        txtSgnificado.Text = ""
        txtPath.Text = ""

    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea abandonar el sistema?", MsgBoxStyle.Question + vbYesNoCancel, "Aviso") = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\dyego\Downloads"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName


            btnAgregar.Enabled = True
        End If
    End Sub

    Private Sub Ventana1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgregar.Enabled = False
        If txtPalabra.Text = "" And txtSgnificado.Text = "" Then
            MsgBox("Por favor llenar  CAMPOS")
        Else
            btnAgregar.Enabled = True
        End If
    End Sub


End Class
