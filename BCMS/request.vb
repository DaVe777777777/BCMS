Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class request


    Private Sub LoadRequestData()

        Dim connectionString As String = "server=127.0.0.1;user=root;database=bcms;password="

        Dim query As String = "SELECT * FROM citizen WHERE status = 'Pending'"

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

    Private Sub request_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        LoadRequestData()
    End Sub


    Private Sub addbtn1_Click(sender As Object, e As EventArgs) Handles addbtn1.Click

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


                        LoadRequestData()


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


    Private printRowIndex As Integer = 0
    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click

        Dim printDoc As New PrintDocument()


        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler


        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc


        printRowIndex = 0

        Try

            If printPreview.ShowDialog() = DialogResult.OK Then

                printDoc.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)

        Dim titleFont As New Font("Arial", 26, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 18, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 15)
        Dim brush As New SolidBrush(Color.Black)


        Dim marginBounds As Rectangle = e.MarginBounds
        Dim x As Integer = marginBounds.Left
        Dim y As Integer = marginBounds.Top
        Dim pageWidth As Integer = marginBounds.Width - 40


        Dim logoPath As String = "C:\Users\John Dave De Leon\Downloads\BCMS_LOGO.jpg"
        Dim headerStartX As Integer = x + 120
        Dim headerY As Integer = y

        If System.IO.File.Exists(logoPath) Then
            Try
                Dim logo As Image = Image.FromFile(logoPath)
                e.Graphics.DrawImage(logo, x, headerY, 100, 100)
            Catch ex As Exception
                e.Graphics.DrawString("[Logo Missing]", headerFont, brush, x, headerY)
            End Try
        End If


        e.Graphics.DrawString("Republic of the Philippines", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Province of Batangas", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Municipality of Mataasnakahoy", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Barangay Calingatan", titleFont, brush, headerStartX, headerY)
        headerY += 40

        e.Graphics.DrawString(New String("_"c, 46), headerFont, brush, x, headerY)
        headerY += 80


        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", headerFont, brush, x + 110, headerY)
        headerY += 40
        e.Graphics.DrawString("BARANGAY CLEARANCE", titleFont, brush, x + 115, headerY)
        headerY += 80


        e.Graphics.DrawString("TO WHOM IT MAY CONCERN:", headerFont, brush, x, headerY)
        headerY += 50


        Dim name As String = "_______________________________"
        Dim age As String = "_________"
        Dim gender As String = "_________"
        Dim issueDate As String = DateTime.Now.ToString("MMMM dd, yyyy")

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)


            Dim cellValueName = selectedRow.Cells("Name").Value
            Dim cellValueAge = selectedRow.Cells("Age").Value
            Dim cellValueGender = selectedRow.Cells("Gender").Value

            name = If(cellValueName IsNot Nothing, cellValueName.ToString(), "_______________________________")
            age = If(cellValueAge IsNot Nothing, cellValueAge.ToString(), "_________")
            gender = If(cellValueGender IsNot Nothing, cellValueGender.ToString(), "_________")
        End If


        Dim bodyText As String =
$"    This is to certify that {name}, {age} years old, {gender}, and a resident of Barangay Calingatan, Mataasnakahoy, Batangas, is known to be of good moral character and a law-abiding citizen in the community. To certify further, that he/she has no derogatory and/or criminal records filed in this barangay."


        headerY = DrawJustifiedText(e.Graphics, bodyText, regularFont, brush, x, headerY, pageWidth)


        Dim footerText As String =
$"    ISSUED this {issueDate} at Barangay Calingatan, Mataasnakahoy, Batangas upon request of the interested party for whatever legal purposes it may serve."

        headerY += 40
        headerY = DrawJustifiedText(e.Graphics, footerText, regularFont, brush, x, headerY, pageWidth)


        headerY += 60
        e.Graphics.DrawString("Jerry Hernandez", headerFont, brush, marginBounds.Right - 200, headerY)
        headerY += 20
        e.Graphics.DrawString("Barangay Captain", regularFont, brush, marginBounds.Right - 180, headerY)


        e.HasMorePages = False
    End Sub


    Private Function DrawJustifiedText(g As Graphics, text As String, font As Font, brush As Brush, x As Integer, y As Integer, width As Integer) As Integer
        Dim words() As String = text.Split(" "c)
        Dim line As String = ""
        Dim lineHeight As Integer = font.Height + 5
        Dim spaceWidth As Integer = CInt(g.MeasureString(" ", font).Width)

        For Each word As String In words
            Dim testLine As String = If(line = "", word, line & " " & word)
            Dim testLineWidth As Integer = CInt(g.MeasureString(testLine, font).Width)

            If testLineWidth > width Then

                Dim extraSpace As Integer = width - CInt(g.MeasureString(line, font).Width)
                Dim gaps As Integer = line.Split(" "c).Length - 1
                Dim extraSpacePerGap As Integer = If(gaps > 0, extraSpace \ gaps, 0)
                Dim currentX As Integer = x

                For Each segment As String In line.Split(" "c)
                    g.DrawString(segment, font, brush, currentX, y)
                    currentX += CInt(g.MeasureString(segment, font).Width) + spaceWidth + extraSpacePerGap
                Next

                line = word
                y += lineHeight
            Else
                line = testLine
            End If
        Next


        g.DrawString(line, font, brush, x, y)
        Return y + lineHeight
    End Function

    Private printRowIndex1 As Integer = 0
    Private Sub printbtn1_Click(sender As Object, e As EventArgs) Handles printbtn1.Click

        Dim printDoc As New PrintDocument()

        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler1


        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc


        printRowIndex1 = 0

        Try

            If printPreview.ShowDialog() = DialogResult.OK Then

                printDoc.Print()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintPageHandler1(sender As Object, e As PrintPageEventArgs)

        Dim titleFont As New Font("Arial", 26, FontStyle.Bold)
        Dim headerFont As New Font("Arial", 18, FontStyle.Bold)
        Dim regularFont As New Font("Arial", 15)
        Dim brush As New SolidBrush(Color.Black)


        Dim marginBounds As Rectangle = e.MarginBounds
        Dim x As Integer = marginBounds.Left
        Dim y As Integer = marginBounds.Top
        Dim pageWidth As Integer = marginBounds.Width - 40


        Dim logoPath As String = "C:\Users\John Dave De Leon\Downloads\BCMS_LOGO.jpg"
        Dim headerStartX As Integer = x + 120
        Dim headerY As Integer = y

        If System.IO.File.Exists(logoPath) Then
            Try
                Dim logo As Image = Image.FromFile(logoPath)
                e.Graphics.DrawImage(logo, x, headerY, 100, 100)
            Catch ex As Exception
                e.Graphics.DrawString("[Logo Missing]", headerFont, brush, x, headerY)
            End Try
        End If


        e.Graphics.DrawString("Republic of the Philippines", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Province of Batangas", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Municipality of Mataasnakahoy", headerFont, brush, headerStartX, headerY)
        headerY += 30
        e.Graphics.DrawString("Barangay Calingatan", titleFont, brush, headerStartX, headerY)
        headerY += 40

        e.Graphics.DrawString(New String("_"c, 46), headerFont, brush, x, headerY)
        headerY += 80


        e.Graphics.DrawString("OFFICE OF THE BARANGAY CAPTAIN", headerFont, brush, x + 110, headerY)
        headerY += 40
        e.Graphics.DrawString("CERTIFICATE OF INDIGENCY", titleFont, brush, x + 80, headerY)
        headerY += 80


        e.Graphics.DrawString("TO WHOM IT MAY CONCERN:", headerFont, brush, x, headerY)
        headerY += 50


        Dim name As String = "_______________________________"

        Dim issueDate As String = DateTime.Now.ToString("MMMM dd, yyyy")

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)


            Dim cellValueName = selectedRow.Cells("Name").Value


            name = If(cellValueName IsNot Nothing, cellValueName.ToString(), "_______________________________")

        End If


        Dim bodyText As String =
$"    This is to CERTIFY that Mr./Ms. {name} or married, Filipino Citizen and a resident of Barangay of legal age, single or married, Filipino Citizen and a resident of Barangay Calingatan, belongs to the Indigent Families of this barangay having an annual income not exceeding the Regional Poverty Threshold (RPT) of Php 169, 824.00 per anum as determined by the National Economic Development Authority (NEDA). This CERTIFICATION is issued upon the request of the above-mentioned individual for whatever legal purpose/s it may best serve him or her.
"


        headerY = DrawJustifiedText1(e.Graphics, bodyText, regularFont, brush, x, headerY, pageWidth)


        Dim footerText As String =
$"    ISSUED this {issueDate} at Barangay Calingatan, Mataasnakahoy, Batangas upon request of the interested party for whatever legal purposes it may serve."

        headerY += 40
        headerY = DrawJustifiedText1(e.Graphics, footerText, regularFont, brush, x, headerY, pageWidth)


        headerY += 60
        e.Graphics.DrawString("Jerry Hernandez", headerFont, brush, marginBounds.Right - 200, headerY)
        headerY += 20
        e.Graphics.DrawString("Barangay Captain", regularFont, brush, marginBounds.Right - 180, headerY)


        e.HasMorePages = False
    End Sub


    Private Function DrawJustifiedText1(g As Graphics, text As String, font As Font, brush As Brush, x As Integer, y As Integer, width As Integer) As Integer
        Dim words() As String = text.Split(" "c)
        Dim line As String = ""
        Dim lineHeight As Integer = font.Height + 5
        Dim spaceWidth As Integer = CInt(g.MeasureString(" ", font).Width)

        For Each word As String In words
            Dim testLine As String = If(line = "", word, line & " " & word)
            Dim testLineWidth As Integer = CInt(g.MeasureString(testLine, font).Width)

            If testLineWidth > width Then

                Dim extraSpace As Integer = width - CInt(g.MeasureString(line, font).Width)
                Dim gaps As Integer = line.Split(" "c).Length - 1
                Dim extraSpacePerGap As Integer = If(gaps > 0, extraSpace \ gaps, 0)
                Dim currentX As Integer = x

                For Each segment As String In line.Split(" "c)
                    g.DrawString(segment, font, brush, currentX, y)
                    currentX += CInt(g.MeasureString(segment, font).Width) + spaceWidth + extraSpacePerGap
                Next

                line = word
                y += lineHeight
            Else
                line = testLine
            End If
        Next


        g.DrawString(line, font, brush, x, y)
        Return y + lineHeight
    End Function




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

    Private Sub LoadRequestData(Optional searchTerm As String = "")

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

        LoadRequestData(searchtb.Text)
    End Sub

    Private Sub requestcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles requestcb.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub gendercb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gendercb.SelectedIndexChanged

    End Sub

    Private Sub agetb_TextChanged(sender As Object, e As EventArgs) Handles agetb.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub purokcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles purokcb.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub nametb_TextChanged(sender As Object, e As EventArgs) Handles nametb.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub contacttb_TextChanged(sender As Object, e As EventArgs) Handles contacttb.TextChanged

    End Sub

    Private Sub search_txt_Click(sender As Object, e As EventArgs) Handles search_txt.Click

    End Sub


    Private Sub updatebtn1_Click(sender As Object, e As EventArgs) Handles updatebtn1.Click

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
                        LoadRequestData()
                    Else
                        MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub deletebtn1_Click(sender As Object, e As EventArgs) Handles deletebtn1.Click

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
                        LoadRequestData()

                    Else
                        MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clearbtn1_Click(sender As Object, e As EventArgs) Handles clearbtn1.Click

        nametb.Clear()
        gendercb.SelectedIndex = -1
        agetb.Clear()
        purokcb.SelectedIndex = -1
        contacttb.Clear()
        requestcb.SelectedIndex = -1
        statuscb.SelectedIndex = -1
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
End Class
