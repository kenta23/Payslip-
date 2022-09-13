Public Class form1
    Dim RatePerDay, OTrate, total, SS, health, totalDeduc, tax As Double

    'deductions total 


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblRatePerDay.Click

    End Sub

    Private Sub txtOvertimePay_TextChanged(sender As Object, e As EventArgs) Handles txtOvertimePay.TextChanged

    End Sub

    Private Sub lblHealth_Click(sender As Object, e As EventArgs) Handles lblHealth.Click

    End Sub

    Private Sub lblSS_Click(sender As Object, e As EventArgs) Handles lblSS.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lblCompany_Click(sender As Object, e As EventArgs) Handles lblCompany.Click

    End Sub

    Private Sub txtWGP_TextChanged(sender As Object, e As EventArgs) Handles txtWGP.TextChanged
        SS = Val(txtWGP.Text) * 0.05
        health = Val(txtWGP.Text) * 0.03
        tax = Val(txtWGP.Text) * 0.1

        totalDeduc = SS + health + tax
        TxtTotalDeduc.Text = totalDeduc
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalDeduc.TextChanged

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtOThours_TextChanged(sender As Object, e As EventArgs) Handles txtOThours.TextChanged
        OTrate = Val(txtOThours.Text) * 250
        RatePerDay = OTrate + Val(txtRatePerday.Text)
        txtOvertimePay.Text = OTrate
    End Sub

    Private Sub txtRatePerday_TextChanged(sender As Object, e As EventArgs) Handles txtRatePerday.TextChanged
        RatePerDay = Val(txtRatePerday.Text) * 5
        txtWGP.Text = RatePerDay
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'initialize variables
        'deductions

        SS = Val(txtWGP.Text) * 0.05
        health = Val(txtWGP.Text) * 0.03
        tax = Val(txtWGP.Text) * 0.1

        totalDeduc = SS + health + tax

        total = Val(txtWGP.Text) - Val(totalDeduc)
        lblTotal.Text = "Total: "
        lblTotal.Text = lblTotal.Text & " " & total


    End Sub

    Private Sub txtSS_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
