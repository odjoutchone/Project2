<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookFlight
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
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.rdoReservedSeat = New System.Windows.Forms.RadioButton()
        Me.rdoCheckInSeat = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(67, 99)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(239, 24)
        Me.cboFlights.TabIndex = 0
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(67, 372)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(239, 64)
        Me.btnBook.TabIndex = 1
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'rdoReservedSeat
        '
        Me.rdoReservedSeat.AutoSize = True
        Me.rdoReservedSeat.Location = New System.Drawing.Point(67, 154)
        Me.rdoReservedSeat.Name = "rdoReservedSeat"
        Me.rdoReservedSeat.Size = New System.Drawing.Size(119, 20)
        Me.rdoReservedSeat.TabIndex = 2
        Me.rdoReservedSeat.TabStop = True
        Me.rdoReservedSeat.Text = "Reserved Seat"
        Me.rdoReservedSeat.UseVisualStyleBackColor = True
        '
        'rdoCheckInSeat
        '
        Me.rdoCheckInSeat.AutoSize = True
        Me.rdoCheckInSeat.Location = New System.Drawing.Point(67, 196)
        Me.rdoCheckInSeat.Name = "rdoCheckInSeat"
        Me.rdoCheckInSeat.Size = New System.Drawing.Size(110, 20)
        Me.rdoCheckInSeat.TabIndex = 3
        Me.rdoCheckInSeat.TabStop = True
        Me.rdoCheckInSeat.Text = "Check In Seat"
        Me.rdoCheckInSeat.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost.Location = New System.Drawing.Point(67, 272)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(239, 57)
        Me.lblCost.TabIndex = 4
        '
        'frmBookFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 495)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.rdoCheckInSeat)
        Me.Controls.Add(Me.rdoReservedSeat)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.cboFlights)
        Me.Name = "frmBookFlight"
        Me.Text = "Book Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFlights As ComboBox
    Friend WithEvents btnBook As Button
    Friend WithEvents rdoReservedSeat As RadioButton
    Friend WithEvents rdoCheckInSeat As RadioButton
    Friend WithEvents lblCost As Label
End Class
