<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendantFutureFlights
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
        Me.lstAttendantFutureFlights = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAttendantFutureFlights
        '
        Me.lstAttendantFutureFlights.FormattingEnabled = True
        Me.lstAttendantFutureFlights.ItemHeight = 16
        Me.lstAttendantFutureFlights.Location = New System.Drawing.Point(41, 47)
        Me.lstAttendantFutureFlights.Name = "lstAttendantFutureFlights"
        Me.lstAttendantFutureFlights.Size = New System.Drawing.Size(410, 468)
        Me.lstAttendantFutureFlights.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 564)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 58)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FrmAttendantFutureFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 660)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstAttendantFutureFlights)
        Me.Name = "FrmAttendantFutureFlights"
        Me.Text = "Attendant Future Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAttendantFutureFlights As ListBox
    Friend WithEvents btnExit As Button
End Class
