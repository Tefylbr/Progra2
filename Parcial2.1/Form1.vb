Imports Npgsql

Public Class Form1
    Dim subt As String
    Dim Cantidad As String
    Dim opcion As String
    Dim st As String
    Public cc As String
    Public cb As String
    Public cp As String

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

        Label8.Text = subtotal(Label8.Text)
        Label9.Text = descuento(Label9.Text)
        Label10.Text = tot(Label10.Text)


    End Sub

    Function subtotal(st As String) As String
        Dim c1 As String
        Dim c2 As String
        Dim c3 As String
        cc = Val(TextBox1.Text)
        cb = Val(TextBox2.Text)
        cp = Val(TextBox3.Text)

        Select Case opcion
            Case "1"
                c1 = cc * 50
                c2 = cb * 35
                c3 = cp * 70
                st = c1 + c2 + c3
            Case "2"
                c1 = cc * 40
                c2 = cb * 25
                c3 = cp * 55
                st = c1 + c2 + c3
            Case "3"
                c1 = cc * 25
                c2 = cb * 10
                c3 = cp * 25
                st = c1 + c2 + c3
        End Select
        Return st
    End Function


    Function descuento(desc As String) As String
        If Cantidad >= 10 Then
            desc = subt * 10%
        ElseIf (CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And opcion = "1") Then
            desc = subt * 5%
        End If
        Return desc
    End Function

    Function tot(total As String) As String
        Dim des As String
        Dim s
        des = descuento(des)
        s = subtotal(s)
        total = s - des
        Return total
    End Function

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

        Label12.Text = "--"

        Label8.Text = "--"
        Label9.Text = "--"
        Label10.Text = "--"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
