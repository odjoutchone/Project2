Public Class frmUpdatePassengerProfile

    Private Sub frmUpdatePassengerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' build select 
            strSelect = "SELECT strFirstName, strLastName, strPhoneNumber " &
                        "FROM TPassengers WHERE intPassengerID = ?"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            cmdSelect.Parameters.AddWithValue("@ID", g_intPassengerID)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then

                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtLastName.Text = drSourceTable("strLastName").ToString()
                txtPhoneNumber.Text = drSourceTable("strPhoneNumber").ToString()

            End If

            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim strFirstName As String
            Dim strLastName As String
            Dim strPhone As String
            Dim intRowsAffected As Integer

            Dim cmdUpdate As OleDb.OleDbCommand

            ' validation
            If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Then
                MessageBox.Show("First and Last name are required.")
                Exit Sub
            End If

            ' open DB
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' assign values
            strFirstName = txtFirstName.Text.Trim()
            strLastName = txtLastName.Text.Trim()
            strPhone = txtPhoneNumber.Text.Trim()

            'update
            cmdUpdate = New OleDb.OleDbCommand("UPDATE TPassengers SET " &
                                               "strFirstName = ?, " &
                                               "strLastName = ?, " &
                                               "strPhoneNumber = ? " &
                                               "WHERE intPassengerID = ?", m_conAdministrator)

            cmdUpdate.Parameters.AddWithValue("@FirstName", strFirstName)
            cmdUpdate.Parameters.AddWithValue("@LastName", strLastName)
            cmdUpdate.Parameters.AddWithValue("@Phone", strPhone)
            cmdUpdate.Parameters.AddWithValue("@ID", g_intPassengerID)

            intRowsAffected = cmdUpdate.ExecuteNonQuery()

            If intRowsAffected = 1 Then
                MessageBox.Show("Update successful")
            Else
                MessageBox.Show("Update failed")
            End If

            CloseDatabaseConnection()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class