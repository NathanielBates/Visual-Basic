'Nathaniel Bates
'11/30/2014
'The Retirement Calculator Application
'Bates - RCP
'Calculate the monthly amount to invest to reach individual retirment goals
'This application will determine the monthly amount that must be invested in order to live off a desired annual income when the user retires. 
'The annual income desired will be half of the interest that is being earned by the user at the time of retirement.
'The data is based on compounded interest, the interest rate, the number of years to retirement, and inflation.
'Splashscreen image:
'http://www.bing.com/images/search?q=free+space+pictures&id=95D39743B5CFFA7A7EBA1E3D76CC624AED34BD3B&FORM=IQFRBA#view=detail&id=CAEC0C41293530CC4AE988A3D4F40DDFA6103A96&selectedIndex=65
'About Page
'http://www.bing.com/images/search?q=free+space+pictures&id=95D39743B5CFFA7A7EBA1E3D76CC624AED34BD3B&FORM=IQFRBA#view=detail&id=28B5BD7286AC7836988EFC86219C8945BF90B058&selectedIndex=17

Option Explicit On
Option Strict On

Public Class RetirementCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim frmRetirementReport As New RetirementReport
        Dim decAnnualIncome As Decimal
        Dim decYears As Decimal
        Dim decInterestRate As Decimal
        Dim decInflationRate As Decimal = 0.04D
        Dim decCostOfLivingIncrease As Decimal
        Dim decFutureValue As Decimal
        Dim decAmountInvested As Decimal
        Dim decMonthlyPayment As Decimal
        Dim decNumberOfPymts As Decimal
        Dim blnValidateInput As Boolean = True

        If Not Decimal.TryParse(txtAnnualIncome.Text, decAnnualIncome) Then
            blnValidateInput = False
        ElseIf decAnnualIncome <= 0 Then
            blnValidateInput = False
        End If

        If Not Decimal.TryParse(txtYears.Text, decYears) Then
            blnValidateInput = False
        ElseIf decYears <= 0 Then
            blnValidateInput = False
        End If

        If Not Decimal.TryParse(txtInterestRate.Text, decInterestRate) Then
            blnValidateInput = False
        ElseIf decInterestRate <= 0 Then
            blnValidateInput = False
        ElseIf decInterestRate >= 1 Then
            blnValidateInput = False

        End If

        If blnValidateInput = False Then
            MessageBox.Show("Please enter positive numeric values in all fields. Interest Rate must be a value between 0 and 1.")

        End If

        If blnValidateInput = True Then

            decCostOfLivingIncrease = (decAnnualIncome * decInflationRate * decYears)

            decFutureValue = decCostOfLivingIncrease + decAnnualIncome

            decAmountInvested = decFutureValue / ((decInterestRate / 2) * 1)

            decMonthlyPayment = CDec(decAmountInvested / (((1 + (decInterestRate / 12)) ^ (decYears * 12) - 1) / (decInterestRate / 12)))

            decNumberOfPymts = decYears * 12

            frmRetirementReport.lblAnnualIncome.Text = decAnnualIncome.ToString("c")
            frmRetirementReport.lblMonthlyPayment.Text = decMonthlyPayment.ToString("c")
            frmRetirementReport.lblInterestRate.Text = decInterestRate.ToString("p")
            frmRetirementReport.lblNumberOfPymts.Text = decNumberOfPymts.ToString()

            frmRetirementReport.ShowDialog()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnnualIncome.Clear()
        txtInterestRate.Clear()
        txtYears.Clear()
        txtAnnualIncome.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub RetirementCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(3000)
    End Sub
End Class
