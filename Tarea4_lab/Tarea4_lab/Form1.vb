Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, n As Integer
        Dim Esperar As Char
        n = TextBox1.Text

        Try
            j = 1
            'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
            For i = 1 To n Step 1
                j = j * i
            Next
            Label2.Text = j
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = "Resultado"

    End Sub
End Class
