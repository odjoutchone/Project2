<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantPastFlights
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
        Me.lstAttendantPastFlights = New System.Windows.Forms.ListBox()
        Me.lblTotalMiles = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAttendantPastFlights
        '
        Me.lstAttendantPastFlights.FormattingEnabled = True
        Me.lstAttendantPastFlights.ItemHeight = 16
        Me.lstAttendantPastFlights.Location = New System.Drawing.Point(52, 51)
        Me.lstAttendantPastFlights.Name = "lstAttendantPastFlights"
        Me.lstAttendantPastFlights.Size = New System.Drawing.Size(429, 484)
        Me.lstAttendantPastFlights.TabIndex = 0
        '
        'lblTotalMiles
        '
        Me.lblTotalMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMiles.Location = New System.Drawing.Point(152, 562)
        Me.lblTotalMiles.Name = "lblTotalMiles"
        Me.lblTotalMiles.Size = New System.Drawing.Size(179, 53)
        Me.lblTotalMiles.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(152, 636)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 58)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAttendantPastFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 721)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalMiles)
        Me.Controls.Add(Me.lstAttendantPastFlights)
        Me.Name = "frmAttendantPastFlights"
        Me.Text = "Attendant Past Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAttendantPastFlights As ListBox
    Friend WithEvents lblTotalMiles As Label
    Friend WithEvents btnExit As Button
End Class
