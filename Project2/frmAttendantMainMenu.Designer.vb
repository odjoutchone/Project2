<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnUpdateAttendantProfile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAttendantFutureFlights = New System.Windows.Forms.Button()
        Me.btnAttendantPastFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateAttendantProfile
        '
        Me.btnUpdateAttendantProfile.Location = New System.Drawing.Point(51, 67)
        Me.btnUpdateAttendantProfile.Name = "btnUpdateAttendantProfile"
        Me.btnUpdateAttendantProfile.Size = New System.Drawing.Size(254, 64)
        Me.btnUpdateAttendantProfile.TabIndex = 0
        Me.btnUpdateAttendantProfile.Text = "Update Attendant Profile"
        Me.btnUpdateAttendantProfile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(51, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(254, 64)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAttendantFutureFlights
        '
        Me.btnAttendantFutureFlights.Location = New System.Drawing.Point(51, 252)
        Me.btnAttendantFutureFlights.Name = "btnAttendantFutureFlights"
        Me.btnAttendantFutureFlights.Size = New System.Drawing.Size(254, 64)
        Me.btnAttendantFutureFlights.TabIndex = 2
        Me.btnAttendantFutureFlights.Text = "Attendant Future Flights"
        Me.btnAttendantFutureFlights.UseVisualStyleBackColor = True
        '
        'btnAttendantPastFlights
        '
        Me.btnAttendantPastFlights.Location = New System.Drawing.Point(51, 160)
        Me.btnAttendantPastFlights.Name = "btnAttendantPastFlights"
        Me.btnAttendantPastFlights.Size = New System.Drawing.Size(254, 64)
        Me.btnAttendantPastFlights.TabIndex = 3
        Me.btnAttendantPastFlights.Text = "Attendant Past Flights"
        Me.btnAttendantPastFlights.UseVisualStyleBackColor = True
        '
        'frmAttendantMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 450)
        Me.Controls.Add(Me.btnAttendantPastFlights)
        Me.Controls.Add(Me.btnAttendantFutureFlights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdateAttendantProfile)
        Me.Name = "frmAttendantMainMenu"
        Me.Text = "Attendant Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdateAttendantProfile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAttendantFutureFlights As Button
    Friend WithEvents btnAttendantPastFlights As Button
End Class
