Public Class frmPassengerSelection
    Private Sub frmPassengerSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ' open DB
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub

            End If

            LoadPassengers()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Load passengers
    Private Sub LoadPassengers()

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim dt As DataTable = New DataTable

            ' build select
            strSelect = "SELECT intPassengerID, strFirstName + ' ' + strLastName AS PassengerName FROM TPassengers"

            ' execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load into table
            dt.Load(drSourceTable)

            ' bind combo
            cboPassengers.ValueMember = "intPassengerID"
            cboPassengers.DisplayMember = "PassengerName"
            cboPassengers.DataSource = dt

            ' select first item 
            If cboPassengers.Items.Count > 0 Then cboPassengers.SelectedIndex = 0

            ' cleanup
            drSourceTable.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Add passenger
    Private Sub btnAddPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click

        Try

            Dim frmAdd As New frmAddPassenger
            frmAdd.ShowDialog()

            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub

            End If

            LoadPassengers()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Select passenger
    Private Sub btnSelectPassenger_Click(sender As Object, e As EventArgs) Handles btnSelectPassenger.Click

        Try

            If cboPassengers.SelectedIndex = -1 Then
                MessageBox.Show("Please select a passenger.")
                Exit Sub
            End If

            ' store selected ID
            g_intPassengerID = CInt(cboPassengers.SelectedValue)

            ' open next form
            Dim frmMenu As New frmPassengerMenu
            frmMenu.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class