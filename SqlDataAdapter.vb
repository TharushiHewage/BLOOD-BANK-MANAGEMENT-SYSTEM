Imports MySql.Data.MySqlClient

Friend Class SqlDataAdapter
    Private cmd As MySqlCommand

    Public Sub New(cmd As MySqlCommand)
        Me.cmd = cmd
    End Sub
End Class
