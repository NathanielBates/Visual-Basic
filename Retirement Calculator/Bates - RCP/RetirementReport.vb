Public Class RetirementReport

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.Print()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAnnualIncome.Text = String.Empty
        lblInterestRate.Text = String.Empty
        lblMonthlyPayment.Text = String.Empty
        lblNumberOfPymts.Text = String.Empty

        RetirementCalculator.txtAnnualIncome.Clear()
        RetirementCalculator.txtInterestRate.Clear()
        RetirementCalculator.txtYears.Clear()

        RetirementCalculator.txtAnnualIncome.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        RetirementCalculator.Show()
    End Sub
End Class