Imports Npgsql
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Myconection.State = ConnectionState.Open Then
                Myconection.Close()
            End If
            Myconection.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            Command = Myconection.CreateCommand()
            Command.CommandType = CommandType.Text
            command.CommandText = "SELECT*FROM Parcial2;"
            command.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New NpgsqlDataAdapter(Command)
            da.Fill(dt)
            dr = Command.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Form1.Label8.Text = dr.GetString(2).ToString()
                Form1.Label9.Text = dr.GetString(3).ToString()
                Form1.Label10.Text = dr.GetString(4).ToString()
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class