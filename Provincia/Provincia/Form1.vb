Public Class Form1
    Dim A(5) As Integer
    Dim con, con1, aux As Integer
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        ltbDatos.Items.Add("----- Cuidades de la Provincia de:  ---------")
        For con = 0 To 5

            'A(con) = Val(Me.ltbDatos.Items.Add(TextBox2.Text & "-" & TextBox1.Text))
            A(con) = InputBox("Ingreso número habitantes:" & "-" & ltbDatos.Items.Add(txtProv.Text))
            'A(con) = ltbDatos.Items.Add(txtCod.Text)
            ltbDatos.Items.Add(A(con))


        Next con
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        'condicion espacios del vector uso for  
        For con1 = 0 To 5
            For con = 0 To 4
                If A(con) < A(con + 1) Then
                    aux = A(con) 'almacenamiento temp
                    A(con) = A(con + 1)
                    A(con + 1) = aux
                End If

            Next con

        Next con1
        For con = 0 To 5
            ltbMenor.Items.Add(A(con))
        Next con
    End Sub

    Private Sub btnCalMayor_Click(sender As Object, e As EventArgs) Handles btnCalMayor.Click
        'condicion espacios del vector uso for  
        For con1 = 0 To 5
            For con = 0 To 4
                If A(con) > A(con + 1) Then
                    aux = A(con) 'almacenamiento temp
                    A(con) = A(con + 1)
                    A(con + 1) = aux
                End If

            Next con

        Next con1
        For con = 0 To 5
            ltbMayor.Items.Add(A(con))
        Next con
    End Sub


End Class
