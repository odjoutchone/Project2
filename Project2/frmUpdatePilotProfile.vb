Public Class frmUpdatePilotProfile

    Private Sub frmUpdatePilotProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Load Pilots into ComboBox 
            strSelect = "SELECT intPilotID, strFirstName + ' ' + strLastName AS FullName FROM TPilots"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            dt = New DataTable
            dt.Load(drSourceTable)

            cboPilot.DataSource = dt
            cboPilot.DisplayMember = "FullName"
            cboPilot.ValueMember = "intPilotID"

            drSourceTable.Close()

            ' Load Pilot Roles
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            dt = New DataTable
            dt.Load(drSourceTable)

            cboPilotRole.DataSource = dt
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.ValueMember = "intPilotRoleID"

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' When Pilot is Selected → Load Data
    Private Sub cboPilot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPilot.SelectedIndexChanged

        Try

            If cboPilot.SelectedValue Is Nothing Then Exit Sub

            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            cmdSelect = New OleDb.OleDbCommand("EXEC uspSelectPilot ?", m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@PilotID", cboPilot.SelectedValue)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then

                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtPilotLastName.Text = drSourceTable("strLastName").ToString()
                txtEmployeeID.Text = drSourceTable("strEmployeeID").ToString()
                dtpHireDate.Value = Convert.ToDateTime(drSourceTable("dtmDateOfHire"))

                dtpTerminationDate.Value = Convert.ToDateTime(drSourceTable("dtmDateOfTermination"))
                dtpTerminationDate.Checked = True

                dtpLicenceDate.Value = Convert.ToDateTime(drSourceTable("dtmDateOfLicense"))

                cboPilotRole.SelectedValue = CInt(drSourceTable("intPilotRoleID"))

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim cmdUpdate As OleDb.OleDbCommand

            ' Validate
            If txtFirstName.Text.Trim() = "" Or txtPilotLastName.Text.Trim() = "" Or txtEmployeeID.Text.Trim() = "" Or cboPilotRole.SelectedIndex = -1 Then
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

            ' Stored Procedure
            cmdUpdate = New OleDb.OleDbCommand("EXEC uspUpdatePilotProfile ?, ?, ?, ?, ?, ?, ?, ?", m_conAdministrator)

            cmdUpdate.Parameters.AddWithValue("@PilotID", cboPilot.SelectedValue)
            cmdUpdate.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmdUpdate.Parameters.AddWithValue("@LastName", txtPilotLastName.Text.Trim())
            cmdUpdate.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim())
            cmdUpdate.Parameters.AddWithValue("@HireDate", dtpHireDate.Value)

            cmdUpdate.Parameters.AddWithValue("@TerminationDate", dtpTerminationDate.Value)

            cmdUpdate.Parameters.AddWithValue("@LicenseDate", dtpLicenceDate.Value)
            cmdUpdate.Parameters.AddWithValue("@PilotRoleID", CInt(cboPilotRole.SelectedValue))

            cmdUpdate.ExecuteNonQuery()

            MessageBox.Show("Pilot updated successfully!")

            CloseDatabaseConnection()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class