Public Class frmAttendantPastFlights
    Private Sub frmAttendantPastFights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Past Flights
            Dim strSQL As String = "SELECT F.strFlightNumber, F.dtmFlightDate, " &
                                   "A.strAirportCode AS FromAirport, B.strAirportCode AS ToAirport, F.intMilesFlown " &
                                   "FROM TAttendantFlights AF " &
                                   "JOIN TFlights F ON AF.intFlightID = F.intFlightID " &
                                   "JOIN TAirports A ON F.intFromAirportID = A.intAirportID " &
                                   "JOIN TAirports B ON F.intToAirportID = B.intAirportID " &
                                   "WHERE AF.intAttendantID = ? AND F.dtmFlightDate < GETDATE()"

            cmdSelect = New OleDb.OleDbCommand(strSQL, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@AttendantID", g_intAttendantID)

            drSourceTable = cmdSelect.ExecuteReader()

            lstAttendantPastFlights.Items.Clear()

            Dim intTotalMiles As Integer = 0

            If drSourceTable.HasRows = False Then

                lstAttendantPastFlights.Items.Add("No past flights found.")

            Else

                While drSourceTable.Read()

                    Dim strDisplay As String =
                        "Flight: " & drSourceTable("strFlightNumber").ToString() &
                        " | Date: " & Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() &
                        " | From: " & drSourceTable("FromAirport").ToString() &
                        " | To: " & drSourceTable("ToAirport").ToString() &
                        " | Miles: " & drSourceTable("intMilesFlown").ToString()

                    lstAttendantPastFlights.Items.Add(strDisplay)

                    intTotalMiles += If(IsDBNull(drSourceTable("intMilesFlown")), 0, CInt(drSourceTable("intMilesFlown")))

                End While

            End If

            drSourceTable.Close()

            lblTotalMiles.Text = "Total Miles: " & intTotalMiles.ToString("N0")

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Back to attendant menu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmAttendantMainMenu
            frm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class