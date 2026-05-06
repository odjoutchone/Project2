Public Class frmUpdateAttendantProfile

    Private Sub frmUpdateAttendantProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Load Attendant Data
            cmdSelect = New OleDb.OleDbCommand("SELECT * FROM TAttendants WHERE intAttendantID = ?", m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@ID", g_intAttendantID)

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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim cmdSelect As OleDb.OleDbCommand

            ' Validation
            If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtEmployeeID.Text.Trim() = "" Then
                MessageBox.Show("Please fill all required fields")
                Exit Sub
            End If

            ' Open DB
            If OpenDatabaseConnectionSQLServer() = False Then Exit Sub

            ' Update Attendant
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
            cmdSelect.Parameters.AddWithValue("@ID", g_intAttendantID)

            cmdSelect.ExecuteNonQuery()

            MessageBox.Show("Profile updated successfully!")

            CloseDatabaseConnection()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class