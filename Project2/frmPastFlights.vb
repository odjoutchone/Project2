Public Class frmPastFlights
    Private Sub frmPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim intTotalMiles As Integer = 0

            ' open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' build select statement 
            strSelect = "SELECT F.strFlightNumber, F.dtmFlightDate, F.intMilesFlown " &
                        "FROM TFlights F " &
                        "INNER JOIN TFlightPassengers FP ON F.intFlightID = FP.intFlightID " &
                        "WHERE FP.intPassengerID = ? " &
                        "AND F.dtmFlightDate < GETDATE()"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@PassengerID", g_intPassengerID)

            drSourceTable = cmdSelect.ExecuteReader

            lstPastFlights.Items.Clear()

            ' check for no data 
            If drSourceTable.HasRows = False Then

                lstPastFlights.Items.Add("No past flights found.")

            Else

                ' loop through records
                While drSourceTable.Read()

                    lstPastFlights.Items.Add(
                        drSourceTable("strFlightNumber").ToString() & " | " &
                        Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() & " | Miles: " &
                        drSourceTable("intMilesFlown").ToString()
                    )

                    intTotalMiles += If(IsDBNull(drSourceTable("intMilesFlown")), 0, CInt(drSourceTable("intMilesFlown")))

                End While

            End If

            ' Show total
            lblTotalMiles.Text = "Total Miles: " & intTotalMiles.ToString("N0")

            ' clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Back to Passenger Menu form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmPassengerMenu
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblTotalMiles_Click(sender As Object, e As EventArgs) Handles lblTotalMiles.Click

    End Sub

End Class