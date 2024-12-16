Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class LOGIN

    Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim connection As New MySqlConnection(connectionString)


        Dim query As String = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password"

        Try

            connection.Open()


            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username.Text)
            command.Parameters.AddWithValue("@password", password.Text)


            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())


            If result > 0 Then

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Dim homepage As New HomePage
                homepage.Show()


                Me.Hide()
            Else

                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            connection.Close()
        End Try
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class