Imports MySql.Data.MySqlClient

Public Class Login
    Dim cn As New MySqlConnection
    Dim Command As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Server=localhost;Database=pos2;Uid=root;Pwd=;"
        Command.Connection = cn
        cn.Open()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Command.CommandText = "SELECT * FROM user WHERE username= '" & Username.Text & "' AND password = '" & password.Text & "' AND position = '" & Position.Text & "'"

        reader = Command.ExecuteReader

        If reader.HasRows Then
            MsgBox("Successfully Login", MsgBoxStyle.Critical, "Checkpoint")
            mainpos.Show()
            reader.Close()
            Me.Hide()
            Dashboard.MdiParent = mainpos

            Dashboard.Show()
        Else
            MsgBox("USER NOT FOUND")
            reader.Close()

            'Command.Dispose()
            'reader.Dispose()
            'Command.CommandText = "Insert into Login (Username, Password, ClientName, ClientSurname) values('" & txtusername.Text & "','" & txtpassword.Text & "','" & txtname.Text & "','" & txtsurname.Text & "')"
            'Command.ExecuteNonQuery()
            'MsgBox("Information Successfully saved!/ Account Generation Succeed!", MsgBoxStyle.Information, "Information Generation")
            'Username.Clear()
            'password.Clear()
        End If
    End Sub
End Class
