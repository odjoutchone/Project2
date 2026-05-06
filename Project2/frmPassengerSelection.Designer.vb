<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengerSelection
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
        Me.cboPassengers = New System.Windows.Forms.ComboBox()
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnSelectPassenger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPassengers
        '
        Me.cboPassengers.FormattingEnabled = True
        Me.cboPassengers.Location = New System.Drawing.Point(249, 48)
        Me.cboPassengers.Name = "cboPassengers"
        Me.cboPassengers.Size = New System.Drawing.Size(235, 24)
        Me.cboPassengers.TabIndex = 0
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.Location = New System.Drawing.Point(258, 164)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(226, 56)
        Me.btnAddPassenger.TabIndex = 2
        Me.btnAddPassenger.Text = "Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = True
        '
        'btnSelectPassenger
        '
        Me.btnSelectPassenger.Location = New System.Drawing.Point(258, 263)
        Me.btnSelectPassenger.Name = "btnSelectPassenger"
        Me.btnSelectPassenger.Size = New System.Drawing.Size(226, 56)
        Me.btnSelectPassenger.TabIndex = 3
        Me.btnSelectPassenger.Text = "Select Passenger"
        Me.btnSelectPassenger.UseVisualStyleBackColor = True
        '
        'frmPassengerSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSelectPassenger)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Controls.Add(Me.cboPassengers)
        Me.Name = "frmPassengerSelection"
        Me.Text = "Passenger Selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboPassengers As ComboBox
    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnSelectPassenger As Button
End Class
