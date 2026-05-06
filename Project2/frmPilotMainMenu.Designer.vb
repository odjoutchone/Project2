<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotMainMenu
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
        Me.btnUpdatePilotProfile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPilotFutureFlight = New System.Windows.Forms.Button()
        Me.btnPilotPastFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdatePilotProfile
        '
        Me.btnUpdatePilotProfile.Location = New System.Drawing.Point(98, 61)
        Me.btnUpdatePilotProfile.Name = "btnUpdatePilotProfile"
        Me.btnUpdatePilotProfile.Size = New System.Drawing.Size(260, 70)
        Me.btnUpdatePilotProfile.TabIndex = 0
        Me.btnUpdatePilotProfile.Text = "Update Pilot  Profile"
        Me.btnUpdatePilotProfile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(98, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(260, 70)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPilotFutureFlight
        '
        Me.btnPilotFutureFlight.Location = New System.Drawing.Point(98, 251)
        Me.btnPilotFutureFlight.Name = "btnPilotFutureFlight"
        Me.btnPilotFutureFlight.Size = New System.Drawing.Size(260, 70)
        Me.btnPilotFutureFlight.TabIndex = 2
        Me.btnPilotFutureFlight.Text = "Pilot Future Flights"
        Me.btnPilotFutureFlight.UseVisualStyleBackColor = True
        '
        'btnPilotPastFlights
        '
        Me.btnPilotPastFlights.Location = New System.Drawing.Point(98, 153)
        Me.btnPilotPastFlights.Name = "btnPilotPastFlights"
        Me.btnPilotPastFlights.Size = New System.Drawing.Size(260, 70)
        Me.btnPilotPastFlights.TabIndex = 3
        Me.btnPilotPastFlights.Text = "Pilot Past Flights"
        Me.btnPilotPastFlights.UseVisualStyleBackColor = True
        '
        'frmPilotMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 450)
        Me.Controls.Add(Me.btnPilotPastFlights)
        Me.Controls.Add(Me.btnPilotFutureFlight)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdatePilotProfile)
        Me.Name = "frmPilotMainMenu"
        Me.Text = "Pilot Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdatePilotProfile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPilotFutureFlight As Button
    Friend WithEvents btnPilotPastFlights As Button
End Class
