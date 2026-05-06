<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantAssignment
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
        Me.cboAttendant = New System.Windows.Forms.ComboBox()
        Me.cboFlight = New System.Windows.Forms.ComboBox()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboAttendant
        '
        Me.cboAttendant.FormattingEnabled = True
        Me.cboAttendant.Location = New System.Drawing.Point(34, 35)
        Me.cboAttendant.Name = "cboAttendant"
        Me.cboAttendant.Size = New System.Drawing.Size(231, 24)
        Me.cboAttendant.TabIndex = 0
        '
        'cboFlight
        '
        Me.cboFlight.FormattingEnabled = True
        Me.cboFlight.Location = New System.Drawing.Point(34, 78)
        Me.cboFlight.Name = "cboFlight"
        Me.cboFlight.Size = New System.Drawing.Size(231, 24)
        Me.cboFlight.TabIndex = 1
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(78, 134)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(141, 45)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "assign"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(84, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAttendantAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.cboFlight)
        Me.Controls.Add(Me.cboAttendant)
        Me.Name = "frmAttendantAssignment"
        Me.Text = "Attendant Assignment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboAttendant As ComboBox
    Friend WithEvents cboFlight As ComboBox
    Friend WithEvents btnAssign As Button
    Friend WithEvents btnExit As Button
End Class
