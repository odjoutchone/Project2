Public Class frmAttendantAssignment
    Private Sub frmAttendantAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            ' Open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Load Attendants
            cmdSelect = New OleDb.OleDbCommand("SELECT intAttendantID, strFirstName + ' ' + strLastName AS FullName FROM TAttendants", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtAttendant As New DataTable
            dtAttendant.Load(drSourceTable)
            drSourceTable.Close()

            cboAttendant.DataSource = dtAttendant
            cboAttendant.DisplayMember = "FullName"
            cboAttendant.ValueMember = "intAttendantID"

            ' Load Flights
            cmdSelect = New OleDb.OleDbCommand("SELECT intFlightID, strFlightNumber FROM TFlights", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtFlight As New DataTable
            dtFlight.Load(drSourceTable)
            drSourceTable.Close()

            cboFlight.DataSource = dtFlight
            cboFlight.DisplayMember = "strFlightNumber"
            cboFlight.ValueMember = "intFlightID"

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click

        Try

            Dim cmdInsert As OleDb.OleDbCommand

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            If cboAttendant.SelectedIndex = -1 Or cboFlight.SelectedIndex = -1 Then
                MessageBox.Show("Please select both Attendant and Flight")
                CloseDatabaseConnection()
                Exit Sub
            End If

            cmdInsert = New OleDb.OleDbCommand("INSERT INTO TAttendantFlights (intAttendantFlightID, intAttendantID, intFlightID) VALUES (?, ?, ?)", m_conAdministrator)

            Dim intNextID As Integer = GetNextAttendantFlightID()

            cmdInsert.Parameters.AddWithValue("@ID", intNextID)
            cmdInsert.Parameters.AddWithValue("@AttendantID", CInt(cboAttendant.SelectedValue))
            cmdInsert.Parameters.AddWithValue("@FlightID", CInt(cboFlight.SelectedValue))

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Attendant assigned to flight successfully!")

            CloseDatabaseConnection()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetNextAttendantFlightID() As Integer

        Dim cmdSelect As OleDb.OleDbCommand
        Dim result As Object

        cmdSelect = New OleDb.OleDbCommand("SELECT ISNULL(MAX(intAttendantFlightID),0) + 1 FROM TAttendantFlights", m_conAdministrator)

        result = cmdSelect.ExecuteScalar()

        Return CInt(result)

    End Function

    ' back to menu form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmAttendantManagement
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class