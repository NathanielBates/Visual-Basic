<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetirementReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RetirementReport))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnnualIncome = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumberOfPymts = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(29, 459)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(433, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back to Calculator"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(233, 459)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(113, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 4
        '
        'lblAnnualIncome
        '
        Me.lblAnnualIncome.BackColor = System.Drawing.Color.Lavender
        Me.lblAnnualIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualIncome.Location = New System.Drawing.Point(365, 105)
        Me.lblAnnualIncome.Name = "lblAnnualIncome"
        Me.lblAnnualIncome.Size = New System.Drawing.Size(181, 33)
        Me.lblAnnualIncome.TabIndex = 5
        Me.lblAnnualIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.BackColor = System.Drawing.Color.Lavender
        Me.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(365, 276)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(181, 33)
        Me.lblMonthlyPayment.TabIndex = 8
        Me.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInterestRate
        '
        Me.lblInterestRate.BackColor = System.Drawing.Color.Lavender
        Me.lblInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterestRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(365, 189)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(100, 33)
        Me.lblInterestRate.TabIndex = 11
        Me.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 33)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "The amount of money to live on per year when you retire:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "The interest rate on your principal investment:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(346, 33)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Monthly payment into your investment for that goal:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumberOfPymts
        '
        Me.lblNumberOfPymts.BackColor = System.Drawing.Color.Lavender
        Me.lblNumberOfPymts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumberOfPymts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPymts.Location = New System.Drawing.Point(365, 364)
        Me.lblNumberOfPymts.Name = "lblNumberOfPymts"
        Me.lblNumberOfPymts.Size = New System.Drawing.Size(100, 33)
        Me.lblNumberOfPymts.TabIndex = 15
        Me.lblNumberOfPymts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(346, 33)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Number of payments into your investment:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(131, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(317, 37)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Investment Summary"
        '
        'RetirementReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 512)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNumberOfPymts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.lblAnnualIncome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "RetirementReport"
        Me.Text = "Retirement Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents lblAnnualIncome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfPymts As System.Windows.Forms.Label
End Class
