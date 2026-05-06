<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPilotManagement = New System.Windows.Forms.Button()
        Me.btnFlightManagement = New System.Windows.Forms.Button()
        Me.btnAttendantManagement = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOpenStatistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPilotManagement
        '
        Me.btnPilotManagement.Location = New System.Drawing.Point(27, 30)
        Me.btnPilotManagement.Name = "btnPilotManagement"
        Me.btnPilotManagement.Size = New System.Drawing.Size(248, 60)
        Me.btnPilotManagement.TabIndex = 0
        Me.btnPilotManagement.Text = "Pilot Management"
        Me.btnPilotManagement.UseVisualStyleBackColor = True
        '
        'btnFlightManagement
        '
        Me.btnFlightManagement.Location = New System.Drawing.Point(27, 235)
        Me.btnFlightManagement.Name = "btnFlightManagement"
        Me.btnFlightManagement.Size = New System.Drawing.Size(248, 60)
        Me.btnFlightManagement.TabIndex = 1
        Me.btnFlightManagement.Text = "Flight Management"
        Me.btnFlightManagement.UseVisualStyleBackColor = True
        '
        'btnAttendantManagement
        '
        Me.btnAttendantManagement.Location = New System.Drawing.Point(27, 134)
        Me.btnAttendantManagement.Name = "btnAttendantManagement"
        Me.btnAttendantManagement.Size = New System.Drawing.Size(248, 60)
        Me.btnAttendantManagement.TabIndex = 2
        Me.btnAttendantManagement.Text = "Attendant Management"
        Me.btnAttendantManagement.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(64, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 64)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOpenStatistics
        '
        Me.btnOpenStatistics.Location = New System.Drawing.Point(27, 332)
        Me.btnOpenStatistics.Name = "btnOpenStatistics"
        Me.btnOpenStatistics.Size = New System.Drawing.Size(248, 57)
        Me.btnOpenStatistics.TabIndex = 4
        Me.btnOpenStatistics.Text = "Open Statistics page"
        Me.btnOpenStatistics.UseVisualStyleBackColor = True
        '
        'frmAdminMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 540)
        Me.Controls.Add(Me.btnOpenStatistics)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAttendantManagement)
        Me.Controls.Add(Me.btnFlightManagement)
        Me.Controls.Add(Me.btnPilotManagement)
        Me.Name = "frmAdminMainMenu"
        Me.Text = "Admin Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPilotManagement As Button
    Friend WithEvents btnFlightManagement As Button
    Friend WithEvents btnAttendantManagement As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOpenStatistics As Button
End Class
