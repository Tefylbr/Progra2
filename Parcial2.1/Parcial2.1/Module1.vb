Imports Npgsql
Module Module1
    Public datosconexion As String = "Server=127.0.0.1;Port=5432;Database=Postgres;UserId=postgres;Password=1234;"
    Public Myconection As New Npgsql.NpgsqlConnection(datosconexion)
    Public command As Npgsql.NpgsqlCommand
    Public dr As NpgsqlDataReader
    Public i As Integer


    Public Sub disp_data()
        command = Myconection.CreateCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "SELECT*FROM Parcial2;"
        command.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New NpgsqlDataAdapter(command)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt
    End Sub


End Module
