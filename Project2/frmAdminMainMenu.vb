Public Class frmAdminMainMenu
    Private Sub frmAdminMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Pilot Management
    Private Sub btnPilotManagement_Click(sender As Object, e As EventArgs) Handles btnPilotManagement.Click

        Try

            Dim frm As New frmPilotManagement
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Attendant Management
    Private Sub btnAttendantManagement_Click(sender As Object, e As EventArgs) Handles btnAttendantManagement.Click

        Try

            Dim frm As New frmAttendantManagement
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Flight Management
    Private Sub btnFlightManagement_Click(sender As Object, e As EventArgs) Handles btnFlightManagement.Click

        Try

            Dim frm As New frmFlightManagement
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Statistics
    Private Sub btnOpenStatistics_Click(sender As Object, e As EventArgs) Handles btnOpenStatistics.Click

        Try

            Dim frm As New frmStatistics
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