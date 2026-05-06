Public Class frmAttendantManagement
    Private Sub frmAttendantManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Load Attendants
            cmdSelect = New OleDb.OleDbCommand("SELECT intAttendantID, strFirstName + ' ' + strLastName AS FullName FROM TAttendants", m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            Dim dt As New DataTable
            dt.Load(drSourceTable)
            drSourceTable.Close()

            cboAttendant.DataSource = dt
            cboAttendant.DisplayMember = "FullName"
            cboAttendant.ValueMember = "intAttendantID"

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub cboAttendant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttendant.SelectedIndexChanged

        Try

            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            If cboAttendant.SelectedIndex = -1 Then Exit Sub

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            Dim intID As Integer = CInt(cboAttendant.SelectedValue)

            cmdSelect = New OleDb.OleDbCommand("SELECT * FROM TAttendants WHERE intAttendantID = ?", m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@ID", intID)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then

                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtLastName.Text = drSourceTable("strLastName").ToString()
                txtEmployeeID.Text = drSourceTable("strEmployeeID").ToString()
                dtpHireDate.Value = Convert.ToDateTime(drSourceTable("dtmDateOfHire"))

                If IsDBNull(drSourceTable("dtmDateOfTermination")) Then
                    dtpTerminationDate.Checked = False
                Else
                    dtpTerminationDate.Value = Convert.ToDateTime(drSourceTable("dtmDateOfTermination"))
                    dtpTerminationDate.Checked = True
                End If

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim cmdSelect As OleDb.OleDbCommand

            If cboAttendant.SelectedIndex = -1 Then
                MessageBox.Show("Please select an attendant")
                Exit Sub
            End If

            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            Dim intID As Integer = CInt(cboAttendant.SelectedValue)

            cmdSelect = New OleDb.OleDbCommand("UPDATE TAttendants SET " &
                                               "strFirstName = ?, " &
                                               "strLastName = ?, " &
                                               "strEmployeeID = ?, " &
                                               "dtmDateOfHire = ?, " &
                                               "dtmDateOfTermination = ? " &
                                               "WHERE intAttendantID = ?", m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmdSelect.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
            cmdSelect.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim())
            cmdSelect.Parameters.AddWithValue("@HireDate", dtpHireDate.Value)
            cmdSelect.Parameters.AddWithValue("@TerminationDate", If(dtpTerminationDate.Checked, dtpTerminationDate.Value, CType(DBNull.Value, Object)))
            cmdSelect.Parameters.AddWithValue("@ID", intID)

            cmdSelect.ExecuteNonQuery()

            MessageBox.Show("Attendant updated successfully!")

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Back to admin menu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmAdminMainMenu
            frm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class