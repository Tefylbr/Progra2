Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, n, z, k As Integer
        n = TextBox1.Text
        Dim indice = 0
        Dim resultado1 As String = ""
        Dim cantidad As String = 0
        Dim ciclo As String
        Try
            j = 1
            'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n
            For i = 1 To n Step 1
                j = j * i
            Next
            Label2.Text = j
            For z = 0 To j Step 1
                ciclo = ciclo + z.ToString + ", "
            Next
            TextBox2.Text = ciclo
            While (indice <= j)
                If (indice Mod 4 = 0) Then
                    cantidad = cantidad + 1
                End If
                indice = indice + 1
            End While
            Label4.Text = cantidad

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label2.Text = "Resultado"
        TextBox2.Text = ""
        Label4.Text = "Multiplos de 4"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

End Class
