Public Class frmPilotFutureFlights
    Private Sub frmPilotFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            lstPilotFutureFlights.Items.Clear()

            ' Stored Procedure
            cmdSelect = New OleDb.OleDbCommand("EXEC uspSelectPilotFutureFlights ?", m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@PilotID", g_intPilotID)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.HasRows = False Then

                lstPilotFutureFlights.Items.Add("No future flights found.")

            Else

                While drSourceTable.Read()

                    Dim strDisplay As String =
                        "Flight: " & drSourceTable("strFlightNumber").ToString() &
                        " | Date: " & Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() &
                        " | From: " & drSourceTable("FromAirport").ToString() &
                        " | To: " & drSourceTable("ToAirport").ToString()

                    lstPilotFutureFlights.Items.Add(strDisplay)

                End While

            End If

            ' Cleanup
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub


    ' Back to pilot menu form
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