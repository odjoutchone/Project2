<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotManagement
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
        Me.btnAddPilot = New System.Windows.Forms.Button()
        Me.btnAssignPilot = New System.Windows.Forms.Button()
        Me.btnUpdatePilot = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPilot
        '
        Me.btnAddPilot.Location = New System.Drawing.Point(48, 58)
        Me.btnAddPilot.Name = "btnAddPilot"
        Me.btnAddPilot.Size = New System.Drawing.Size(237, 54)
        Me.btnAddPilot.TabIndex = 0
        Me.btnAddPilot.Text = "Add Pilot"
        Me.btnAddPilot.UseVisualStyleBackColor = True
        '
        'btnAssignPilot
        '
        Me.btnAssignPilot.Location = New System.Drawing.Point(48, 236)
        Me.btnAssignPilot.Name = "btnAssignPilot"
        Me.btnAssignPilot.Size = New System.Drawing.Size(237, 54)
        Me.btnAssignPilot.TabIndex = 2
        Me.btnAssignPilot.Text = "Assign Pilot"
        Me.btnAssignPilot.UseVisualStyleBackColor = True
        '
        'btnUpdatePilot
        '
        Me.btnUpdatePilot.Location = New System.Drawing.Point(48, 149)
        Me.btnUpdatePilot.Name = "btnUpdatePilot"
        Me.btnUpdatePilot.Size = New System.Drawing.Size(237, 54)
        Me.btnUpdatePilot.TabIndex = 3
        Me.btnUpdatePilot.Text = "Update Pilot"
        Me.btnUpdatePilot.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(90, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 42)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPilotManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 393)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdatePilot)
        Me.Controls.Add(Me.btnAssignPilot)
        Me.Controls.Add(Me.btnAddPilot)
        Me.Name = "frmPilotManagement"
        Me.Text = "Pilot Management"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPilot As Button
    Friend WithEvents btnAssignPilot As Button
    Friend WithEvents btnUpdatePilot As Button
    Friend WithEvents btnExit As Button
End Class
