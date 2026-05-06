Public Class frmFlightManagement
    Private Sub frmFlightManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' From Airport
            cmdSelect = New OleDb.OleDbCommand("SELECT intAirportID, strAirportCode FROM TAirports", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtFrom As New DataTable
            dtFrom.Load(drSourceTable)
            drSourceTable.Close()

            cboFromAirport.DataSource = dtFrom
            cboFromAirport.DisplayMember = "strAirportCode"
            cboFromAirport.ValueMember = "intAirportID"

            ' To Airport
            cmdSelect = New OleDb.OleDbCommand("SELECT intAirportID, strAirportCode FROM TAirports", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtTo As New DataTable
            dtTo.Load(drSourceTable)
            drSourceTable.Close()

            cboToAirport.DataSource = dtTo
            cboToAirport.DisplayMember = "strAirportCode"
            cboToAirport.ValueMember = "intAirportID"

            ' Plane
            cmdSelect = New OleDb.OleDbCommand("SELECT intPlaneID, strPlaneNumber FROM TPlanes", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            Dim dtPlane As New DataTable
            dtPlane.Load(drSourceTable)
            drSourceTable.Close()

            cboPlane.DataSource = dtPlane
            cboPlane.DisplayMember = "strPlaneNumber"
            cboPlane.ValueMember = "intPlaneID"

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmdSelect As OleDb.OleDbCommand
            Dim intNextID As Integer

            If txtFlightNumber.Text.Trim() = "" Or txtTotalMiles.Text.Trim() = "" Or
               cboFromAirport.SelectedIndex = -1 Or cboToAirport.SelectedIndex = -1 Or cboPlane.SelectedIndex = -1 Then

                MessageBox.Show("Please fill all required fields")
                Exit Sub
            End If

            If dtpFlightDate.Value <= Date.Now Then
                MessageBox.Show("Flight date must be in the future")
                Exit Sub
            End If

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            intNextID = GetNextFlightID()

            cmdSelect = New OleDb.OleDbCommand("INSERT INTO TFlights " &
                                               "(intFlightID, strFlightNumber, dtmFlightDate, dtmTimeOfDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID) " &
                                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@ID", intNextID)
            cmdSelect.Parameters.AddWithValue("@FlightNumber", txtFlightNumber.Text.Trim())
            cmdSelect.Parameters.AddWithValue("@FlightDate", dtpFlightDate.Value)
            cmdSelect.Parameters.AddWithValue("@Departure", dtpDepartureTime.Value)
            cmdSelect.Parameters.AddWithValue("@Landing", dtpLandingTime.Value)
            cmdSelect.Parameters.AddWithValue("@FromAirport", CInt(cboFromAirport.SelectedValue))
            cmdSelect.Parameters.AddWithValue("@ToAirport", CInt(cboToAirport.SelectedValue))
            cmdSelect.Parameters.AddWithValue("@Miles", CInt(txtTotalMiles.Text))
            cmdSelect.Parameters.AddWithValue("@Plane", CInt(cboPlane.SelectedValue))

            cmdSelect.ExecuteNonQuery()

            MessageBox.Show("Flight created successfully!")

            CloseDatabaseConnection()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Function GetNextFlightID() As Integer

        Dim cmdSelect As OleDb.OleDbCommand
        Dim result As Object

        cmdSelect = New OleDb.OleDbCommand("SELECT ISNULL(MAX(intFlightID),0) + 1 FROM TFlights", m_conAdministrator)

        result = cmdSelect.ExecuteScalar()

        Return CInt(result)

    End Function

End Class