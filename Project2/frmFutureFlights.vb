Public Class frmFutureFlights
    Private Sub frmFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            ' open DB
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub

            End If

            ' build query
            strSelect = "SELECT DISTINCT F.strFlightNumber, F.dtmFlightDate, F.intMilesFlown " &
                        "FROM TFlights F " &
                        "INNER JOIN TFlightPassengers FP ON F.intFlightID = FP.intFlightID " &
                        "WHERE FP.intPassengerID = ? " &
                        "AND F.dtmFlightDate > GETDATE() " &
                        "ORDER BY F.dtmFlightDate"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@PassengerID", g_intPassengerID)

            drSourceTable = cmdSelect.ExecuteReader

            lstFutureFlights.Items.Clear()

            ' check for no data
            If drSourceTable.HasRows = False Then

                lstFutureFlights.Items.Add("No future flights found.")

            Else

                ' read data
                While drSourceTable.Read()

                    lstFutureFlights.Items.Add(
                        drSourceTable("strFlightNumber").ToString() & " | " &
                        Convert.ToDateTime(drSourceTable("dtmFlightDate")).ToShortDateString() & " | Miles: " &
                        drSourceTable("intMilesFlown").ToString())

                End While

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Back to PassengerMenu form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmPassengerMenu
            frm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class