Public Class frmBookFlight
    Private Sub frmBookFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim dt As DataTable = New DataTable

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            strSelect = "SELECT intFlightID, strFlightNumber FROM TFlights WHERE dtmFlightDate > GETDATE()"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            dt.Load(drSourceTable)

            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "strFlightNumber"
            cboFlights.DataSource = dt

            If cboFlights.Items.Count > 0 Then cboFlights.SelectedIndex = 0

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub cboFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFlights.SelectedIndexChanged
        CalculateCost()
    End Sub
    Private Sub rdoReservedSeat_CheckedChanged(sender As Object, e As EventArgs) Handles rdoReservedSeat.CheckedChanged
        CalculateCost()
    End Sub
    Private Sub rdoCheckInSeat_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCheckInSeat.CheckedChanged
        CalculateCost()
    End Sub
    Private Sub CalculateCost()

        Try

            If cboFlights.SelectedIndex = -1 Then Exit Sub

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            Dim intFlight As Integer = CInt(cboFlights.SelectedValue)

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            strSelect = "SELECT f.intMilesFlown, f.intReservedSeats, pt.strPlaneType, a.strAirportCode " &
                        "FROM TFlights f " &
                        "JOIN TPlanes p ON f.intPlaneID = p.intPlaneID " &
                        "JOIN TPlaneTypes pt ON p.intPlaneTypeID = pt.intPlaneTypeID " &
                        "JOIN TAirports a ON f.intToAirportID = a.intAirportID " &
                        "WHERE f.intFlightID = ?"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@FlightID", intFlight)

            drSourceTable = cmdSelect.ExecuteReader

            If drSourceTable.Read() Then

                Dim miles As Integer = CInt(drSourceTable("intMilesFlown"))
                Dim reservedSeats As Integer = CInt(drSourceTable("intReservedSeats"))
                Dim planeType As String = drSourceTable("strPlaneType").ToString()
                Dim destination As String = drSourceTable("strAirportCode").ToString()

                Dim cost As Decimal = 250

                If miles > 750 Then cost += 50

                If reservedSeats > 8 Then
                    cost += 100
                ElseIf reservedSeats < 4 Then
                    cost -= 50
                End If

                If planeType = "Airbus A350" Then
                    cost += 35
                ElseIf planeType = "Boeing 747-8" Then
                    cost -= 25
                End If

                If destination = "MIA" Then cost += 15

                If rdoReservedSeat.Checked Then cost += 125

                Dim strState As String = ""
                Dim intFlightsTaken As Integer = 0

                drSourceTable.Close()

                strSelect = "SELECT s.strState, COUNT(fp.intFlightPassengerID) AS TotalFlights " &
                            "FROM TPassengers p " &
                            "JOIN TStates s ON p.intStateID = s.intStateID " &
                            "LEFT JOIN TFlightPassengers fp ON p.intPassengerID = fp.intPassengerID " &
                            "WHERE p.intPassengerID = ? " &
                            "GROUP BY s.strState"

                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                cmdSelect.Parameters.AddWithValue("@PassengerID", g_intPassengerID)

                drSourceTable = cmdSelect.ExecuteReader

                If drSourceTable.Read() Then
                    strState = drSourceTable("strState").ToString()
                    intFlightsTaken = CInt(drSourceTable("TotalFlights"))
                End If

                If strState = "Ohio" Then
                    cost *= 0.9
                ElseIf strState = "Kentucky" Then
                    cost *= 0.95
                End If

                If intFlightsTaken > 10 Then
                    cost *= 0.8
                ElseIf intFlightsTaken > 5 Then
                    cost *= 0.9
                End If

                lblCost.Text = "$" & cost.ToString("F2")

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        Try

            Dim strSelect As String = ""
            Dim strInsert As String = ""
            Dim strUpdate As String = ""
            Dim intFlight As Integer
            Dim intNextPrimaryKey As Integer
            Dim intRowsAffected As Integer

            Dim cmdSelect As OleDb.OleDbCommand
            Dim cmdInsert As OleDb.OleDbCommand
            Dim cmdUpdate As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            If cboFlights.SelectedIndex = -1 Then
                MessageBox.Show("Please select a flight.")
                Exit Sub
            End If

            If rdoReservedSeat.Checked = False And rdoCheckInSeat.Checked = False Then
                MessageBox.Show("Please select a seat type.")
                Exit Sub
            End If

            intFlight = CInt(cboFlights.SelectedValue)

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            strSelect = "SELECT ISNULL(MAX(intFlightPassengerID),0) + 1 AS intNextPrimaryKey FROM TFlightPassengers"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

            Dim strSeatType As String
            If rdoReservedSeat.Checked Then
                strSeatType = "Reserved"
            Else
                strSeatType = "Check-In"
            End If

            strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat, strSeatType) " &
                        "VALUES (?, ?, ?, ?, ?)"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@ID", intNextPrimaryKey)
            cmdInsert.Parameters.AddWithValue("@FlightID", intFlight)
            cmdInsert.Parameters.AddWithValue("@PassengerID", g_intPassengerID)
            cmdInsert.Parameters.AddWithValue("@Seat", "N/A")
            cmdInsert.Parameters.AddWithValue("@SeatType", strSeatType)

            intRowsAffected = cmdInsert.ExecuteNonQuery()

            If rdoReservedSeat.Checked Then
                strUpdate = "UPDATE TFlights SET intReservedSeats = intReservedSeats + 1 WHERE intFlightID = ?"
                cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)
                cmdUpdate.Parameters.AddWithValue("@FlightID", intFlight)
                cmdUpdate.ExecuteNonQuery()
            End If

            If intRowsAffected > 0 Then
                MessageBox.Show("Flight booked successfully!")
            Else
                MessageBox.Show("Booking failed.")
            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class