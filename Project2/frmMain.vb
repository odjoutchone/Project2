Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUserName.Text = ""
        txtPassword.Text = ""

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            Dim strSQL As String
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            ' Validate input
            If txtUserName.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
                MessageBox.Show("Please enter username and password.")
                Exit Sub
            End If

            ' Open database
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show("Database connection failed.")
                Exit Sub
            End If

            ' SQL query
            strSQL = "SELECT strRole, intUserID FROM TUserLogins " &
                     "WHERE strUserName = ? AND strPassword = ?"

            cmdSelect = New OleDb.OleDbCommand(strSQL, m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@Username", txtUserName.Text.Trim)
            cmdSelect.Parameters.AddWithValue("@Password", txtPassword.Text.Trim)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then

                Dim strRole As String = drSourceTable("strRole").ToString().Trim()
                Dim intID As Integer = CInt(drSourceTable("intUserID"))

                If strRole = "Passenger" Then

                    g_intPassengerID = intID
                    Dim frm As New frmPassengerMenu
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Pilot" Then

                    g_intPilotID = intID
                    Dim frm As New frmPilotMainMenu
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Attendant" Then

                    g_intAttendantID = intID
                    Dim frm As New frmAttendantMainMenu
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Admin" Then

                    Dim frm As New frmAdminMainMenu
                    frm.Show()
                    Me.Hide()

                Else

                    MessageBox.Show("Invalid role detected.")
                    Exit Sub

                End If

            Else

                MessageBox.Show("Invalid username or password.")

            End If

            ' Cleanup
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class