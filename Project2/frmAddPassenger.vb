Public Class frmAddPassenger
    Private Sub frmAddPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ' Load states into combo box
            Dim strSelect As String
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show("Database connection error.")
                Exit Sub
            End If

            strSelect = "SELECT intStateID, strState FROM TStates"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            cboState.Items.Clear()

            While drSourceTable.Read()
                cboState.Items.Add(drSourceTable("intStateID").ToString() & " - " & drSourceTable("strState").ToString())
            End While

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            ' Declare variables
            Dim strSelect As String = ""
            Dim strInsert As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim cmdInsert As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            Dim intNextPrimaryKey As Integer
            Dim intRowsAffected As Integer

            Dim strFirstName As String
            Dim strLastName As String
            Dim strAddress As String
            Dim strCity As String
            Dim strZip As String
            Dim strPhone As String
            Dim strEmail As String
            Dim intStateID As Integer

            ' Validation
            If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Then
                MessageBox.Show("First and Last name are required.")
                Exit Sub
            End If

            If txtAddress.Text.Trim() = "" Or txtCity.Text.Trim() = "" Or txtZip.Text.Trim() = "" Then
                MessageBox.Show("Address, City, and Zip are required.")
                Exit Sub
            End If

            If txtPhoneNumber.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Then
                MessageBox.Show("Phone and Email are required.")
                Exit Sub
            End If

            If cboState.SelectedIndex = -1 Then
                MessageBox.Show("Please select a state.")
                Exit Sub
            End If

            ' Open database
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show("Database connection error.")
                Exit Sub
            End If

            ' Assign values
            strFirstName = txtFirstName.Text.Trim()
            strLastName = txtLastName.Text.Trim()
            strAddress = txtAddress.Text.Trim()
            strCity = txtCity.Text.Trim()
            strZip = txtZip.Text.Trim()
            strPhone = txtPhoneNumber.Text.Trim()
            strEmail = txtEmail.Text.Trim()

            intStateID = CInt(cboState.Text.Split("-"c)(0).Trim())

            ' Get next primary key
            strSelect = "SELECT ISNULL(MAX(intPassengerID),0) + 1 AS intNextPrimaryKey FROM TPassengers"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()
            drSourceTable.Read()

            intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

            ' Insert record
            strInsert = "INSERT INTO TPassengers " &
                        "(intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@PassengerID", intNextPrimaryKey)
            cmdInsert.Parameters.AddWithValue("@FirstName", strFirstName)
            cmdInsert.Parameters.AddWithValue("@LastName", strLastName)
            cmdInsert.Parameters.AddWithValue("@Address", strAddress)
            cmdInsert.Parameters.AddWithValue("@City", strCity)
            cmdInsert.Parameters.AddWithValue("@StateID", intStateID)
            cmdInsert.Parameters.AddWithValue("@Zip", strZip)
            cmdInsert.Parameters.AddWithValue("@Phone", strPhone)
            cmdInsert.Parameters.AddWithValue("@Email", strEmail)

            ' Execute insert
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            If intRowsAffected > 0 Then
                MessageBox.Show("Passenger added successfully!")
            Else
                MessageBox.Show("Insert failed.")
            End If

            ' Cleanup
            drSourceTable.Close()
            CloseDatabaseConnection()

            txtFirstName.Clear()
            txtLastName.Clear()
            txtAddress.Clear()
            txtCity.Clear()
            txtZip.Clear()
            txtPhoneNumber.Clear()
            txtEmail.Clear()
            cboState.SelectedIndex = -1

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class