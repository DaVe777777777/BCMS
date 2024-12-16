Imports MySql.Data.MySqlClient

Public Class HomePage

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click

        Dim homePage As New HomePage()
        homePage.Show()
        Me.Hide()
    End Sub

    Private Sub citizenbtn_Click(sender As Object, e As EventArgs) Handles citizenbtn.Click

        Dim citizenPage As New Citizen()
        citizenPage.Show()
        Me.Hide()
    End Sub

    Private Sub requestbtn_Click(sender As Object, e As EventArgs) Handles requestbtn.Click

        Dim requestPage As New request()
        requestPage.Show()
        Me.Hide()
    End Sub

    Private Sub donebtn_Click(sender As Object, e As EventArgs) Handles donebtn.Click
        Dim readyPage As New ready()
        readyPage.Show()
        Me.Hide()
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click

        Dim loginPage As New LOGIN()
        loginPage.Show()
        Me.Hide()
    End Sub

    Private connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatistics()
    End Sub

    Private Sub LoadStatistics()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()


                Dim purokQuery As String = "SELECT purok, COUNT(*) AS Population FROM citizen GROUP BY purok"
                Dim purokCmd As New MySqlCommand(purokQuery, connection)
                Dim purokReader As MySqlDataReader = purokCmd.ExecuteReader()


                While purokReader.Read()
                    Dim purokName As String = purokReader("purok").ToString()
                    Dim population As Integer = Convert.ToInt32(purokReader("Population"))

                    Select Case purokName
                        Case 1
                            lblPurok1.Text = $"{population}"
                        Case 2
                            lblPurok2.Text = $"{population}"
                        Case 3
                            lblPurok3.Text = $"{population}"
                        Case 4
                            lblPurok4.Text = $"{population}"
                        Case 5
                            lblPurok5.Text = $"{population}"
                        Case 6
                            lblPurok6.Text = $"{population}"
                    End Select
                End While
                purokReader.Close()


                Dim totalCitizensQuery As String = "SELECT COUNT(*) AS TotalCitizens FROM citizen"
                Dim totalCitizensCmd As New MySqlCommand(totalCitizensQuery, connection)
                Dim totalCitizens As Integer = Convert.ToInt32(totalCitizensCmd.ExecuteScalar())
                lblTotalCitizens.Text = $"{totalCitizens}"


                Dim totalPendingQuery As String = "SELECT COUNT(*) AS TotalPending FROM citizen WHERE status = 'Pending'"
                Dim totalPendingCmd As New MySqlCommand(totalPendingQuery, connection)
                Dim totalPending As Integer = Convert.ToInt32(totalPendingCmd.ExecuteScalar())
                lblTotalPending.Text = $"{totalPending}"


                Dim totalDoneQuery As String = "SELECT COUNT(*) AS TotalDone FROM citizen WHERE status = 'Done'"
                Dim totalDoneCmd As New MySqlCommand(totalDoneQuery, connection)
                Dim totalDone As Integer = Convert.ToInt32(totalDoneCmd.ExecuteScalar())
                lblTotalDone.Text = $"{totalDone}"

            Catch ex As Exception
                MessageBox.Show("Error loading statistics: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
