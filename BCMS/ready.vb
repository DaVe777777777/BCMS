Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class ready



    Private Sub LoadReadyData()

        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

        Dim query As String = "SELECT * FROM Citizen WHERE status = 'Done'"

        Try

            Using connection As New MySqlConnection(connectionString)

                Dim adapter As New MySqlDataAdapter(query, connection)


                Dim dataTable As New DataTable()


                adapter.Fill(dataTable)


                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ready_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 1 To 6
            purokcb.Items.Add(i.ToString())
        Next

        gendercb.Items.Add("Male")
        gendercb.Items.Add("Female")

        requestcb.Items.Add("None")
        requestcb.Items.Add("Clerance")
        requestcb.Items.Add("Indigency")

        statuscb.Items.Add("None")
        statuscb.Items.Add("Pending")
        statuscb.Items.Add("Done")



        LoadReadyData()
    End Sub


    Private Sub nametb_TextChanged(sender As Object, e As EventArgs) Handles nametb.TextChanged

    End Sub

    Private Sub gendertb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub agetb_TextChanged(sender As Object, e As EventArgs) Handles agetb.TextChanged

    End Sub

    Private Sub puroktb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub contacttb_TextChanged(sender As Object, e As EventArgs) Handles contacttb.TextChanged

    End Sub

    Private Sub addbtn2_Click(sender As Object, e As EventArgs) Handles addbtn2.Click

        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="


        Dim query As String = "INSERT INTO citizen (name, gender, age, purok, contact, request, status) VALUES (@name, @gender, @age, @purok, @contact, @request, @status)"

        Try

            Using connection As New MySqlConnection(connectionString)

                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@name", nametb.Text)
                    command.Parameters.AddWithValue("@gender", gendercb.Text)
                    command.Parameters.AddWithValue("@age", agetb.Text)
                    command.Parameters.AddWithValue("@purok", purokcb.SelectedItem)
                    command.Parameters.AddWithValue("@contact", contacttb.Text)
                    command.Parameters.AddWithValue("@request", requestcb.Text)
                    command.Parameters.AddWithValue("@status", statuscb.Text)


                    connection.Open()


                    Dim result As Integer = command.ExecuteNonQuery()


                    If result > 0 Then
                        MessageBox.Show("Citizen added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        LoadReadyData()


                        nametb.Clear()
                        gendercb.SelectedIndex = -1
                        agetb.Clear()
                        purokcb.SelectedIndex = -1
                        contacttb.Clear()
                        requestcb.SelectedIndex = -1
                        statuscb.SelectedIndex = -1
                    Else
                        MessageBox.Show("Failed to add citizen. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            nametb.Text = selectedRow.Cells("name").Value.ToString()
            gendercb.Text = selectedRow.Cells("gender").Value.ToString()
            agetb.Text = selectedRow.Cells("age").Value.ToString()
            purokcb.Text = selectedRow.Cells("purok").Value.ToString()
            contacttb.Text = selectedRow.Cells("contact").Value.ToString()
            requestcb.Text = selectedRow.Cells("request").Value.ToString()
            statuscb.Text = selectedRow.Cells("status").Value.ToString()
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles requestcb.SelectedIndexChanged

    End Sub

    Private Sub updatebtn2_Click(sender As Object, e As EventArgs) Handles updatebtn2.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

        Dim query As String = "UPDATE Citizen SET name = @name, gender = @gender, age = @age, purok = @purok, contact = @contact, request = @request, status = @status WHERE id = @id"

        Try

            Using connection As New MySqlConnection(connectionString)

                Using command As New MySqlCommand(query, connection)

                    Dim selectedId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)


                    command.Parameters.AddWithValue("@name", nametb.Text)
                    command.Parameters.AddWithValue("@gender", gendercb.Text)
                    command.Parameters.AddWithValue("@age", agetb.Text)
                    command.Parameters.AddWithValue("@purok", purokcb.Text)
                    command.Parameters.AddWithValue("@contact", contacttb.Text)
                    command.Parameters.AddWithValue("@request", requestcb.Text)
                    command.Parameters.AddWithValue("@status", statuscb.Text)
                    command.Parameters.AddWithValue("@id", selectedId)

                    connection.Open()
                    Dim result As Integer = command.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadReadyData()
                    Else
                        MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub deletebtn2_Click(sender As Object, e As EventArgs) Handles deletebtn2.Click

        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If


        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

        Dim query As String = "DELETE FROM Citizen WHERE id = @id"

        Try

            Using connection As New MySqlConnection(connectionString)

                Using command As New MySqlCommand(query, connection)

                    Dim selectedId As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)


                    command.Parameters.AddWithValue("@id", selectedId)


                    connection.Open()
                    Dim result As Integer = command.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadReadyData()
                    Else
                        MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub clearbtn2_Click(sender As Object, e As EventArgs) Handles clearbtn2.Click

        nametb.Clear()
        gendercb.SelectedIndex = -1
        agetb.Clear()
        purokcb.SelectedIndex = -1
        contacttb.Clear()
        requestcb.SelectedIndex = -1
        statuscb.SelectedIndex = -1
    End Sub


    Private Sub LoadReadyData(Optional searchTerm As String = "")

        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="


        Dim query As String
        If String.IsNullOrEmpty(searchTerm) Then
            query = "SELECT * FROM Citizen"
        Else
            query = "SELECT * FROM Citizen WHERE name LIKE @searchTerm"
        End If

        Try

            Using connection As New MySqlConnection(connectionString)

                Dim adapter As New MySqlDataAdapter(query, connection)


                If Not String.IsNullOrEmpty(searchTerm) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If


                Dim dataTable As New DataTable()


                adapter.Fill(dataTable)


                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged

        LoadReadyData(searchtb.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
