Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = Menos(Label5.Text)
    End Sub

    Function Menos(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero - 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function

    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero + 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Text = Menos(Label6.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = Aumentar(Label5.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Text = Aumentar(Label6.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim txtA = Label5.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label6.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoSuma = Suma(numeroA, numeroB)

        Label8.Text = resultadoSuma.toString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim txtA = Label5.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label6.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoResta = Resta(numeroA, numeroB)

        Label8.Text = resultadoResta.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim txtA = Label5.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label6.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoMultiplicacion = Multiplicacion(numeroA, numeroB)

        Label8.Text = resultadoMultiplicacion.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim txtA = Label5.Text
        Dim numeroA = Int32.Parse(txtA)
        Dim txtB = Label6.Text
        Dim numeroB = Int32.Parse(txtB)
        Dim resultadoDivision = Division(numeroA, numeroB)

        Label8.Text = resultadoDivision.ToString()
    End Sub

    Function Suma(numeroA As Integer, numeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA + numeroB
        Return resultado
    End Function

    Function Resta(numeroA As Integer, numeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA - numeroB
        Return resultado
    End Function

    Function Multiplicacion(numeroA As Integer, numeroB As Integer) As Integer
        Dim resultado As Integer
        resultado = numeroA * numeroB
        Return resultado
    End Function

    Function Division(numeroA As Integer, numeroB As Integer) As Double
        Dim resultado As Double
        If numeroB <> 0 Then
            resultado = numeroA / numeroB
            resultado = Format(resultado, "0.00")
        Else
            resultado = "indefinido"
        End If
        Return resultado
    End Function

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label5.Text = "0"
        Label6.Text = "0"
        Label8.Text = "--"
    End Sub
End Class
