<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotFutureFlights
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
        Me.lstPilotFutureFlights = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPilotFutureFlights
        '
        Me.lstPilotFutureFlights.FormattingEnabled = True
        Me.lstPilotFutureFlights.ItemHeight = 16
        Me.lstPilotFutureFlights.Location = New System.Drawing.Point(41, 43)
        Me.lstPilotFutureFlights.Name = "lstPilotFutureFlights"
        Me.lstPilotFutureFlights.Size = New System.Drawing.Size(449, 372)
        Me.lstPilotFutureFlights.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 476)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 53)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPilotFutureFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 565)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstPilotFutureFlights)
        Me.Name = "frmPilotFutureFlights"
        Me.Text = "Pilot Future Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPilotFutureFlights As ListBox
    Friend WithEvents btnExit As Button
End Class
