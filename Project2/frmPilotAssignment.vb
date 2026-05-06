Public Class frmPilotAssignment
    Private Sub frmPilotAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
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

            ' Load Pilots
            strSelect = "SELECT intPilotID, strFirstName + ' ' + strLastName AS FullName FROM TPilots"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtPilot As New DataTable
            dtPilot.Load(drSourceTable)
            drSourceTable.Close()

            cboPilot.DataSource = dtPilot
            cboPilot.DisplayMember = "FullName"
            cboPilot.ValueMember = "intPilotID"

            ' Load Flights
            strSelect = "SELECT intFlightID, strFlightNumber FROM TFlights"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtFlight As New DataTable
            dtFlight.Load(drSourceTable)
            drSourceTable.Close()

            cboFlight.DataSource = dtFlight
            cboFlight.DisplayMember = "strFlightNumber"
            cboFlight.ValueMember = "intFlightID"

            ' Close DB
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click

        Try

            Dim cmdInsert As OleDb.OleDbCommand

            ' Validate
            If cboPilot.SelectedIndex = -1 Or cboFlight.SelectedIndex = -1 Then
                MessageBox.Show("Please select both Pilot and Flight")
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
            Dim intNextID As Integer = GetNextPilotFlightID()

            ' Stored Procedure
            cmdInsert = New OleDb.OleDbCommand("EXEC uspAssignPilotToFlight ?, ?, ?", m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@PilotFlightID", intNextID)
            cmdInsert.Parameters.AddWithValue("@PilotID", CInt(cboPilot.SelectedValue))
            cmdInsert.Parameters.AddWithValue("@FlightID", CInt(cboFlight.SelectedValue))

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Pilot assigned successfully!")

            ' Close DB
            CloseDatabaseConnection()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Function GetNextPilotFlightID() As Integer

        Dim cmdSelect As OleDb.OleDbCommand
        Dim result As Object

        cmdSelect = New OleDb.OleDbCommand("SELECT ISNULL(MAX(intPilotFlightID),0) + 1 FROM TPilotFlights", m_conAdministrator)

        result = cmdSelect.ExecuteScalar()

        Return CInt(result)

    End Function


    ' Back to pilot management form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmPilotManagement
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class