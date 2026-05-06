Public Class frmPilotMainMenu
    Private Sub frmPilotMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Update Pilot Profile
    Private Sub btnUpdatePilotProfile_Click(sender As Object, e As EventArgs) Handles btnUpdatePilotProfile.Click

        Try

            Dim frm As New frmUpdatePilotProfile
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Pilot Past Flights
    Private Sub btnPilotPastFlights_Click(sender As Object, e As EventArgs) Handles btnPilotPastFlights.Click

        Try

            Dim frm As New frmPilotPastFlights
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Pilot Future Flights
    Private Sub btnPilotFutureFlight_Click(sender As Object, e As EventArgs) Handles btnPilotFutureFlight.Click

        Try

            Dim frm As New frmPilotFutureFlights
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Back to login form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Dim frm As New frmMain
            frm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class