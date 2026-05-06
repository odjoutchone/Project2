Public Class frmPassengerMenu
    Private Sub frmPassengerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Update profile
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click

        Try

            Dim frm As New frmUpdatePassengerProfile
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Book flight
    Private Sub btnBookFlight_Click(sender As Object, e As EventArgs) Handles btnBookFlight.Click

        Try

            Dim frm As New frmBookFlight
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Past Flights
    Private Sub btnPastFlights_Click(sender As Object, e As EventArgs) Handles btnPastFlights.Click

        Try

            Dim frm As New frmPastFlights
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Future Flights
    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click

        Try

            Dim frm As New frmFutureFlights
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Back to Login form
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