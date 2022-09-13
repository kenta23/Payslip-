<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblRatePerDay = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRatePerday = New System.Windows.Forms.TextBox()
        Me.txtOThours = New System.Windows.Forms.TextBox()
        Me.lblOThours = New System.Windows.Forms.Label()
        Me.lblWGP = New System.Windows.Forms.Label()
        Me.txtWGP = New System.Windows.Forms.TextBox()
        Me.lblDeduc = New System.Windows.Forms.Label()
        Me.lblSS = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblOvertimePay = New System.Windows.Forms.Label()
        Me.txtOvertimePay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEmployee
        '
        Me.lblEmployee.AutoSize = True
        Me.lblEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.Location = New System.Drawing.Point(12, 65)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(187, 25)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = "Employee's name:"
        '
        'lblRatePerDay
        '
        Me.lblRatePerDay.AutoSize = True
        Me.lblRatePerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatePerDay.Location = New System.Drawing.Point(12, 117)
        Me.lblRatePerDay.Name = "lblRatePerDay"
        Me.lblRatePerDay.Size = New System.Drawing.Size(146, 25)
        Me.lblRatePerDay.TabIndex = 1
        Me.lblRatePerDay.Tag = ""
        Me.lblRatePerDay.Text = "Rate Per Day:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(205, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 31)
        Me.txtName.TabIndex = 2
        '
        'txtRatePerday
        '
        Me.txtRatePerday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRatePerday.Location = New System.Drawing.Point(205, 114)
        Me.txtRatePerday.Name = "txtRatePerday"
        Me.txtRatePerday.Size = New System.Drawing.Size(134, 31)
        Me.txtRatePerday.TabIndex = 3
        '
        'txtOThours
        '
        Me.txtOThours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOThours.Location = New System.Drawing.Point(205, 173)
        Me.txtOThours.Name = "txtOThours"
        Me.txtOThours.Size = New System.Drawing.Size(134, 31)
        Me.txtOThours.TabIndex = 5
        '
        'lblOThours
        '
        Me.lblOThours.AutoSize = True
        Me.lblOThours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOThours.Location = New System.Drawing.Point(12, 173)
        Me.lblOThours.Name = "lblOThours"
        Me.lblOThours.Size = New System.Drawing.Size(167, 25)
        Me.lblOThours.TabIndex = 4
        Me.lblOThours.Tag = ""
        Me.lblOThours.Text = "Overtime Hours:"
        '
        'lblWGP
        '
        Me.lblWGP.AutoSize = True
        Me.lblWGP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWGP.Location = New System.Drawing.Point(12, 290)
        Me.lblWGP.Name = "lblWGP"
        Me.lblWGP.Size = New System.Drawing.Size(195, 25)
        Me.lblWGP.TabIndex = 6
        Me.lblWGP.Tag = ""
        Me.lblWGP.Text = "Weekly Gross Pay:"
        '
        'txtWGP
        '
        Me.txtWGP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWGP.Location = New System.Drawing.Point(205, 287)
        Me.txtWGP.Name = "txtWGP"
        Me.txtWGP.Size = New System.Drawing.Size(134, 31)
        Me.txtWGP.TabIndex = 7
        '
        'lblDeduc
        '
        Me.lblDeduc.AutoSize = True
        Me.lblDeduc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduc.Location = New System.Drawing.Point(459, 59)
        Me.lblDeduc.Name = "lblDeduc"
        Me.lblDeduc.Size = New System.Drawing.Size(126, 25)
        Me.lblDeduc.TabIndex = 8
        Me.lblDeduc.Tag = ""
        Me.lblDeduc.Text = "Deductions:"
        '
        'lblSS
        '
        Me.lblSS.AutoSize = True
        Me.lblSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSS.Location = New System.Drawing.Point(453, 133)
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(69, 24)
        Me.lblSS.TabIndex = 9
        Me.lblSS.Tag = ""
        Me.lblSS.Text = "SS: 5%"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(453, 173)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(99, 24)
        Me.lblHealth.TabIndex = 11
        Me.lblHealth.Tag = ""
        Me.lblHealth.Text = "Health: 3%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Tag = ""
        Me.Label1.Text = "Tax: 10%"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(460, 309)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 24)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Tag = ""
        Me.lblTotal.Text = "Total:  "
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(457, 260)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(97, 32)
        Me.btnCompute.TabIndex = 16
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Montserrat Subrayada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(-1, 9)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(180, 23)
        Me.lblCompany.TabIndex = 17
        Me.lblCompany.Text = "Chikadings INC."
        '
        'lblOvertimePay
        '
        Me.lblOvertimePay.AutoSize = True
        Me.lblOvertimePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvertimePay.Location = New System.Drawing.Point(12, 232)
        Me.lblOvertimePay.Name = "lblOvertimePay"
        Me.lblOvertimePay.Size = New System.Drawing.Size(147, 25)
        Me.lblOvertimePay.TabIndex = 18
        Me.lblOvertimePay.Tag = ""
        Me.lblOvertimePay.Text = "Overtime Pay:"
        '
        'txtOvertimePay
        '
        Me.txtOvertimePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOvertimePay.Location = New System.Drawing.Point(205, 229)
        Me.txtOvertimePay.Name = "txtOvertimePay"
        Me.txtOvertimePay.Size = New System.Drawing.Size(134, 31)
        Me.txtOvertimePay.TabIndex = 19
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 404)
        Me.Controls.Add(Me.txtOvertimePay)
        Me.Controls.Add(Me.lblOvertimePay)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblSS)
        Me.Controls.Add(Me.lblDeduc)
        Me.Controls.Add(Me.txtWGP)
        Me.Controls.Add(Me.lblWGP)
        Me.Controls.Add(Me.txtOThours)
        Me.Controls.Add(Me.lblOThours)
        Me.Controls.Add(Me.txtRatePerday)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRatePerDay)
        Me.Controls.Add(Me.lblEmployee)
        Me.Name = "form1"
        Me.Text = "Employee's Payslip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblRatePerDay As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRatePerday As TextBox
    Friend WithEvents txtOThours As TextBox
    Friend WithEvents lblOThours As Label
    Friend WithEvents lblWGP As Label
    Friend WithEvents txtWGP As TextBox
    Friend WithEvents lblDeduc As Label
    Friend WithEvents lblSS As Label
    Friend WithEvents lblHealth As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblOvertimePay As Label
    Friend WithEvents txtOvertimePay As TextBox
End Class
