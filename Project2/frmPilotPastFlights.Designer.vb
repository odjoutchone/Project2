<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotPastFlights
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
        Me.lstPilotPastFlights = New System.Windows.Forms.ListBox()
        Me.lblPilotMiles = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPilotPastFlights
        '
        Me.lstPilotPastFlights.FormattingEnabled = True
        Me.lstPilotPastFlights.ItemHeight = 16
        Me.lstPilotPastFlights.Location = New System.Drawing.Point(69, 71)
        Me.lstPilotPastFlights.Name = "lstPilotPastFlights"
        Me.lstPilotPastFlights.Size = New System.Drawing.Size(498, 404)
        Me.lstPilotPastFlights.TabIndex = 0
        '
        'lblPilotMiles
        '
        Me.lblPilotMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPilotMiles.Location = New System.Drawing.Point(174, 527)
        Me.lblPilotMiles.Name = "lblPilotMiles"
        Me.lblPilotMiles.Size = New System.Drawing.Size(291, 52)
        Me.lblPilotMiles.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 605)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 43)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPilotPastFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 714)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPilotMiles)
        Me.Controls.Add(Me.lstPilotPastFlights)
        Me.Name = "frmPilotPastFlights"
        Me.Text = "Pilot Past Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPilotPastFlights As ListBox
    Friend WithEvents lblPilotMiles As Label
    Friend WithEvents btnExit As Button
End Class
