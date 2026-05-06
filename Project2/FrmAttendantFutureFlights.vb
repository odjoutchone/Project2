Public Class FrmAttendantFutureFlights
    Private Sub FrmAttendantFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Future flights
            Dim strSQL As String = "SELECT F.strFlightNumber, F.dtmFlightDate, " &
                                   "A.strAirportCode AS FromAirport, B.strAirportCode AS ToAirport " &
                                   "FROM TAttendantFlights AF " &
                                   "JOIN TFlights F ON AF.intFlightID = F.intFlightID " &
                                   "JOIN TAirports A ON F.intFromAirportID = A.intAirportID " &
                                   "JOIN TAirports B ON F.intToAirportID = B.intAirportID " &
                                   "WHERE AF.intAttendantID = ? AND F.dtmFlightDate > GETDATE()"

            cmdSelect = New OleDb.OleDbCommand(strSQL, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@AttendantID", g_intAttendantID)

            drSourceTable = cmdSelect.ExecuteReader()

            lstAttendantFutureFlights.Items.Clear()

            If drSourceTable.HasRows = False Then

                lstAttendantFutureFlights.Items.Add("No future flights found.")

            Else

                While drSourceTable.Read()

                    Dim strDisplay As String =
                        "Flight: " & drSourceTable("strFlightNumber").ToString() &
                        " | Date: " & Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() &
                        " | From: " & drSourceTable("FromAirport").ToString() &
                        " | To: " & drSourceTable("ToAirport").ToString()

                    lstAttendantFutureFlights.Items.Add(strDisplay)

                End While

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Back to menu form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmAttendantMainMenu
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class