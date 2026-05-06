Public Class frmStatistics
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            ' Clear ListBox
            lstResults.Items.Clear()

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            ' Total Passengers
            strSelect = "SELECT COUNT(*) AS TotalPassengers FROM TPassengers"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            lstResults.Items.Add("Total Passengers: " & drSourceTable("TotalPassengers"))
            drSourceTable.Close()

            ' Total Flights
            strSelect = "SELECT COUNT(*) AS TotalFlights FROM TFlights"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            lstResults.Items.Add("Total Flights: " & drSourceTable("TotalFlights"))

            drSourceTable.Close()

            ' Average Miles
            strSelect = "SELECT AVG(intMilesFlown) AS AvgMiles FROM TFlights"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            lstResults.Items.Add("Average Miles: " & FormatNumber(drSourceTable("AvgMiles"), 2))
            drSourceTable.Close()

            lstResults.Items.Add("")

            ' Pilot Miles
            lstResults.Items.Add("Pilot Miles:")
            lstResults.Items.Add("------------------------")

            strSelect = "SELECT p.strFirstName, p.strLastName, SUM(f.intMilesFlown) AS TotalMiles " &
                        "FROM TPilots p " &
                        "JOIN TPilotFlights pf ON p.intPilotID = pf.intPilotID " &
                        "JOIN TFlights f ON pf.intFlightID = f.intFlightID " &
                        "GROUP BY p.strFirstName, p.strLastName"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()
                lstResults.Items.Add(drSourceTable("strFirstName") & " " &
                                     drSourceTable("strLastName") & " - " &
                                     drSourceTable("TotalMiles") & " miles")
            End While

            drSourceTable.Close()

            lstResults.Items.Add("")

            ' Attendant Miles
            lstResults.Items.Add("Attendant Miles:")
            lstResults.Items.Add("------------------------")

            strSelect = "SELECT a.strFirstName, a.strLastName, SUM(f.intMilesFlown) AS TotalMiles " &
                        "FROM TAttendants a " &
                        "JOIN TAttendantFlights af ON a.intAttendantID = af.intAttendantID " &
                        "JOIN TFlights f ON af.intFlightID = f.intFlightID " &
                        "GROUP BY a.strFirstName, a.strLastName"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()
                lstResults.Items.Add(drSourceTable("strFirstName") & " " &
                                     drSourceTable("strLastName") & " - " &
                                     drSourceTable("TotalMiles") & " miles")
            End While

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class