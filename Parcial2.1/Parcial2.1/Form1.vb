Imports Npgsql

Public Class Form1
    Dim Cantidad As Integer = 0
    Dim opcion As String
    Public cc As Integer = 0
    Public cb As Integer = 0
    Public cp As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Myconection.ConnectionString = "Server=127.0.0.1;Port=5432;Database=postgres;UserId=postgres;Password=1234;"
        If Myconection.State = ConnectionState.Open Then
            Myconection.Close()
        End If
        Myconection.Open()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        disp_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cc = Val(TextBox1.Text)
        cb = Val(TextBox2.Text)
        cp = Val(TextBox3.Text)

        Cantidad = cc + cb + cp
        Label12.Text = Cantidad

        Select Case opcion
            Case "1"
                subtotal()
            Case "2"
                subtotal()
            Case "3"
                subtotal()
        End Select

        command = Myconection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "INSERT INTO Parcial2 (subtotal, descuento, total) VALUES('" & Label8.Text.ToString & "', '" & Label9.Text.ToString & "', '" & Label10.Text.ToString & "');"
        command.ExecuteNonQuery()

        opcion = ""
        disp_data()

    End Sub

    Public Sub subtotal()
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Integer
        Dim st As Integer
        Dim desc As Integer
        Dim total As Integer

        cc = Val(TextBox1.Text)
        cb = Val(TextBox2.Text)
        cp = Val(TextBox3.Text)

        If opcion = "1" Then
            c1 = cc * 50
            c2 = cb * 35
            c3 = cp * 70
            st = c1 + c2 + c3
            Label8.Text = st
        ElseIf opcion = "2" Then
            c1 = cc * 40
            c2 = cb * 25
            c3 = cp * 55
            st = c1 + c2 + c3
            Label8.Text = st
        ElseIf opcion = "3" Then
            c1 = cc * 25
            c2 = cb * 10
            c3 = cp * 25
            st = c1 + c2 + c3
            Label8.Text = st
        End If

        If Cantidad > 10 Then
            desc = st * 0.1
        ElseIf (CheckBox1.Checked = True) And (CheckBox2.Checked = True) And (CheckBox3.Checked = True) And (opcion = "1") Then
            desc = st * 0.05

        End If
        Label9.Text = desc

        total = st - desc

        Label10.Text = total
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            opcion &= "1"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            opcion &= "2"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            opcion &= "3"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        Label12.Text = "0"

        Label8.Text = "0"
        Label9.Text = "0"
        Label10.Text = "0"

        opcion = ""



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Id As String = TextBox4.Text
        If Myconection.State = ConnectionState.Open Then
            Myconection.Close()
        End If
        Myconection.Open()

        command = Myconection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "UPDATE Parcial2 SET subtotal ='" & Label8.Text & "', descuento = '" & Label9.Text & "', total = '" & Label10.Text & "' WHERE id = '" + Id + "';"
        command.ExecuteNonQuery()
        disp_data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Id As String = TextBox4.Text
        If Myconection.State = ConnectionState.Open Then
            Myconection.Close()
        End If
        Myconection.Open()

        command = Myconection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "DELETE FROM Parcial2 WHERE id = '" + Id + "';"
        command.ExecuteNonQuery()
        disp_data()
    End Sub
End Class
