Public Class frmPilotPastFlights
    Private Sub frmPilotPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim cmdMiles As OleDb.OleDbCommand
            Dim result As Object

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Load past flights
            cmdSelect = New OleDb.OleDbCommand("EXEC uspSelectPilotPastFlights ?", m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@PilotID", g_intPilotID)

            drSourceTable = cmdSelect.ExecuteReader()

            lstPilotPastFlights.Items.Clear()

            If drSourceTable.HasRows = False Then

                lstPilotPastFlights.Items.Add("No past flights found.")

            Else

                While drSourceTable.Read()

                    lstPilotPastFlights.Items.Add(
                        "Flight: " & drSourceTable("strFlightNumber").ToString() &
                        " | Date: " & Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() &
                        " | From: " & drSourceTable("FromAirport").ToString() &
                        " | To: " & drSourceTable("ToAirport").ToString() &
                        " | Miles: " & drSourceTable("intMilesFlown").ToString()
                    )

                End While

            End If

            drSourceTable.Close()

            ' Load total miles
            cmdMiles = New OleDb.OleDbCommand("EXEC uspSelectPilotPastMilesTotal ?", m_conAdministrator)
            cmdMiles.Parameters.AddWithValue("@PilotID", g_intPilotID)

            result = cmdMiles.ExecuteScalar()

            If result Is Nothing OrElse IsDBNull(result) Then
                lblPilotMiles.Text = "Total Miles: 0"
            Else
                lblPilotMiles.Text = "Total Miles: " & Convert.ToInt32(result).ToString("N0")
            End If

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Back to pilot menu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmPilotMainMenu
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class