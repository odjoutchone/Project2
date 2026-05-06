Public Class frmAddPilot
    Private Sub frmAddPilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim dt As DataTable = New DataTable

            ' Open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Load Pilot Roles
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            dt.Load(drSourceTable)

            cboPilotRole.DataSource = dt
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.ValueMember = "intPilotRoleID"

            drSourceTable.Close()
            CloseDatabaseConnection()

            ' Default termination date
            dtpTerminationDate.Value = #1/1/2099#
            dtpTerminationDate.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmdInsert As OleDb.OleDbCommand

            ' Validate
            If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtEmployeeID.Text.Trim() = "" Or cboPilotRole.SelectedIndex = -1 Then
                MessageBox.Show("Please fill all required fields")
                Exit Sub
            End If

            ' Open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Get Next ID
            Dim intNextID As Integer = GetNextPilotID()

            ' Stored Procedure
            cmdInsert = New OleDb.OleDbCommand("uspAddPilot", m_conAdministrator)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.AddWithValue("", intNextID)
            cmdInsert.Parameters.AddWithValue("", txtFirstName.Text.Trim())
            cmdInsert.Parameters.AddWithValue("", txtLastName.Text.Trim())
            cmdInsert.Parameters.AddWithValue("", txtEmployeeID.Text.Trim())
            cmdInsert.Parameters.AddWithValue("", dtpHireDate.Value)


            If dtpTerminationDate.Checked Then
                cmdInsert.Parameters.AddWithValue("", dtpTerminationDate.Value)
            Else
                cmdInsert.Parameters.AddWithValue("", #1/1/2099#)
            End If

            cmdInsert.Parameters.AddWithValue("", dtpLicenceDate.Value)
            cmdInsert.Parameters.AddWithValue("", CInt(cboPilotRole.SelectedValue))

            cmdInsert.ExecuteNonQuery()

            MessageBox.Show("Pilot added successfully!")

            CloseDatabaseConnection()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private Function GetNextPilotID() As Integer

        Dim cmdSelect As OleDb.OleDbCommand
        Dim result As Object

        cmdSelect = New OleDb.OleDbCommand("SELECT ISNULL(MAX(intPilotID),0) + 1 FROM TPilots", m_conAdministrator)
        result = cmdSelect.ExecuteScalar()

        If IsDBNull(result) Then
            Return 1
        Else
            Return CInt(result)
        End If

    End Function

End Class