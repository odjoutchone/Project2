Public Class frmAddAttendant
    Private Sub frmAddAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            Dim cmdInsert As OleDb.OleDbCommand
            Dim cmdMax As OleDb.OleDbCommand
            Dim intNewID As Integer

            ' Validate
            If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtEmployeeID.Text.Trim() = "" Then
                MessageBox.Show("Please fill all required fields")
                Exit Sub
            End If

            ' Open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Get Next ID 
            cmdMax = New OleDb.OleDbCommand("SELECT ISNULL(MAX(intAttendantID),0)+1 FROM TAttendants", m_conAdministrator)
            intNewID = cmdMax.ExecuteScalar()

            ' Insert
            cmdInsert = New OleDb.OleDbCommand("INSERT INTO TAttendants VALUES (?, ?, ?, ?, ?, ?)", m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@AttendantID", intNewID)
            cmdInsert.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmdInsert.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
            cmdInsert.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim())
            cmdInsert.Parameters.AddWithValue("@HireDate", dtpHireDate.Value)

            cmdInsert.Parameters.AddWithValue("@TerminationDate", #1/1/2099#)

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Attendant added successfully!")

            ' Close DB
            CloseDatabaseConnection()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class