Public Class frmPilotManagement
    Private Sub frmPilotManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Add Pilot
    Private Sub btnAddPilot_Click(sender As Object, e As EventArgs) Handles btnAddPilot.Click

        Try

            Dim frm As New frmAddPilot
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Update Pilot 
    Private Sub btnUpdatePilot_Click(sender As Object, e As EventArgs) Handles btnUpdatePilot.Click

        Try

            Dim frm As New frmUpdatePilotProfile
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    ' Assign Pilot to Flight
    Private Sub btnAssignPilot_Click(sender As Object, e As EventArgs) Handles btnAssignPilot.Click

        Try

            Dim frm As New frmPilotAssignment
            frm.Show()
            Me.Hide()

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