<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlightManagement
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFlightNumber = New System.Windows.Forms.TextBox()
        Me.txtTotalMiles = New System.Windows.Forms.TextBox()
        Me.dtpFlightDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpLandingTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpDepartureTime = New System.Windows.Forms.DateTimePicker()
        Me.cboFromAirport = New System.Windows.Forms.ComboBox()
        Me.cboToAirport = New System.Windows.Forms.ComboBox()
        Me.cboPlane = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Landing Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departure Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Flight Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Miles"
        '
        'txtFlightNumber
        '
        Me.txtFlightNumber.Location = New System.Drawing.Point(233, 48)
        Me.txtFlightNumber.Name = "txtFlightNumber"
        Me.txtFlightNumber.Size = New System.Drawing.Size(223, 22)
        Me.txtFlightNumber.TabIndex = 5
        '
        'txtTotalMiles
        '
        Me.txtTotalMiles.Location = New System.Drawing.Point(233, 78)
        Me.txtTotalMiles.Name = "txtTotalMiles"
        Me.txtTotalMiles.Size = New System.Drawing.Size(223, 22)
        Me.txtTotalMiles.TabIndex = 6
        '
        'dtpFlightDate
        '
        Me.dtpFlightDate.Location = New System.Drawing.Point(233, 110)
        Me.dtpFlightDate.Name = "dtpFlightDate"
        Me.dtpFlightDate.Size = New System.Drawing.Size(223, 22)
        Me.dtpFlightDate.TabIndex = 7
        '
        'dtpLandingTime
        '
        Me.dtpLandingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLandingTime.Location = New System.Drawing.Point(233, 182)
        Me.dtpLandingTime.Name = "dtpLandingTime"
        Me.dtpLandingTime.Size = New System.Drawing.Size(223, 22)
        Me.dtpLandingTime.TabIndex = 8
        '
        'dtpDepartureTime
        '
        Me.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDepartureTime.Location = New System.Drawing.Point(233, 144)
        Me.dtpDepartureTime.Name = "dtpDepartureTime"
        Me.dtpDepartureTime.Size = New System.Drawing.Size(223, 22)
        Me.dtpDepartureTime.TabIndex = 9
        '
        'cboFromAirport
        '
        Me.cboFromAirport.FormattingEnabled = True
        Me.cboFromAirport.Location = New System.Drawing.Point(233, 227)
        Me.cboFromAirport.Name = "cboFromAirport"
        Me.cboFromAirport.Size = New System.Drawing.Size(223, 24)
        Me.cboFromAirport.TabIndex = 10
        '
        'cboToAirport
        '
        Me.cboToAirport.FormattingEnabled = True
        Me.cboToAirport.Location = New System.Drawing.Point(233, 269)
        Me.cboToAirport.Name = "cboToAirport"
        Me.cboToAirport.Size = New System.Drawing.Size(223, 24)
        Me.cboToAirport.TabIndex = 11
        '
        'cboPlane
        '
        Me.cboPlane.FormattingEnabled = True
        Me.cboPlane.Location = New System.Drawing.Point(233, 317)
        Me.cboPlane.Name = "cboPlane"
        Me.cboPlane.Size = New System.Drawing.Size(223, 24)
        Me.cboPlane.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(172, 388)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(159, 51)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmFlightManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 480)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboPlane)
        Me.Controls.Add(Me.cboToAirport)
        Me.Controls.Add(Me.cboFromAirport)
        Me.Controls.Add(Me.dtpDepartureTime)
        Me.Controls.Add(Me.dtpLandingTime)
        Me.Controls.Add(Me.dtpFlightDate)
        Me.Controls.Add(Me.txtTotalMiles)
        Me.Controls.Add(Me.txtFlightNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFlightManagement"
        Me.Text = "Flight Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFlightNumber As TextBox
    Friend WithEvents txtTotalMiles As TextBox
    Friend WithEvents dtpFlightDate As DateTimePicker
    Friend WithEvents dtpLandingTime As DateTimePicker
    Friend WithEvents dtpDepartureTime As DateTimePicker
    Friend WithEvents cboFromAirport As ComboBox
    Friend WithEvents cboToAirport As ComboBox
    Friend WithEvents cboPlane As ComboBox
    Friend WithEvents btnSave As Button
End Class
