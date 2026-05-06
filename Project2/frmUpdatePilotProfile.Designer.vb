<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdatePilotProfile
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTerminationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpLicenceDate = New System.Windows.Forms.DateTimePicker()
        Me.cboPilotRole = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPilotLastName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPilot = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EmployeeID"
        '
        'txtLastName
        '
        Me.txtLastName.AutoSize = True
        Me.txtLastName.Location = New System.Drawing.Point(46, 88)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(72, 16)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(165, 50)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(166, 22)
        Me.txtFirstName.TabIndex = 4
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(165, 112)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(166, 22)
        Me.txtEmployeeID.TabIndex = 6
        '
        'dtpHireDate
        '
        Me.dtpHireDate.Location = New System.Drawing.Point(165, 154)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(166, 22)
        Me.dtpHireDate.TabIndex = 8
        '
        'dtpTerminationDate
        '
        Me.dtpTerminationDate.Location = New System.Drawing.Point(165, 193)
        Me.dtpTerminationDate.Name = "dtpTerminationDate"
        Me.dtpTerminationDate.Size = New System.Drawing.Size(166, 22)
        Me.dtpTerminationDate.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hire Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Termination Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Licence Date"
        '
        'dtpLicenceDate
        '
        Me.dtpLicenceDate.Location = New System.Drawing.Point(165, 231)
        Me.dtpLicenceDate.Name = "dtpLicenceDate"
        Me.dtpLicenceDate.Size = New System.Drawing.Size(166, 22)
        Me.dtpLicenceDate.TabIndex = 13
        '
        'cboPilotRole
        '
        Me.cboPilotRole.FormattingEnabled = True
        Me.cboPilotRole.Location = New System.Drawing.Point(165, 271)
        Me.cboPilotRole.Name = "cboPilotRole"
        Me.cboPilotRole.Size = New System.Drawing.Size(166, 24)
        Me.cboPilotRole.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Pilot Role"
        '
        'txtPilotLastName
        '
        Me.txtPilotLastName.Location = New System.Drawing.Point(165, 82)
        Me.txtPilotLastName.Name = "txtPilotLastName"
        Me.txtPilotLastName.Size = New System.Drawing.Size(166, 22)
        Me.txtPilotLastName.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(102, 332)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 53)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Pilot"
        '
        'cboPilot
        '
        Me.cboPilot.FormattingEnabled = True
        Me.cboPilot.Location = New System.Drawing.Point(165, 26)
        Me.cboPilot.Name = "cboPilot"
        Me.cboPilot.Size = New System.Drawing.Size(166, 24)
        Me.cboPilot.TabIndex = 19
        '
        'frmUpdatePilotProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 504)
        Me.Controls.Add(Me.cboPilot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtPilotLastName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPilotRole)
        Me.Controls.Add(Me.dtpLicenceDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpTerminationDate)
        Me.Controls.Add(Me.dtpHireDate)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUpdatePilotProfile"
        Me.Text = "Update Pliot Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents dtpHireDate As DateTimePicker
    Friend WithEvents dtpTerminationDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpLicenceDate As DateTimePicker
    Friend WithEvents cboPilotRole As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPilotLastName As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cboPilot As ComboBox
End Class
