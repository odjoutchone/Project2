Public Class frmAttendantMainMenu
    Private Sub frmAttendantMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Update Profile
    Private Sub btnUpdateAttendantProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendantProfile.Click

        Try

            Dim frmNext As New frmUpdateAttendantProfile
            frmNext.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Past Flights
    Private Sub btnAttendantPastFlights_Click(sender As Object, e As EventArgs) Handles btnAttendantPastFlights.Click

        Try

            Dim frmNext As New frmAttendantPastFlights
            frmNext.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Future Flights
    Private Sub btnAttendantFutureFlights_Click(sender As Object, e As EventArgs) Handles btnAttendantFutureFlights.Click

        Try

            Dim frmNext As New FrmAttendantFutureFlights
            frmNext.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '  Back to login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frmNext As New frmMain
            frmNext.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class