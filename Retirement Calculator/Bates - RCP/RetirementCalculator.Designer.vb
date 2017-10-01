<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetirementCalculator
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
        Me.txtAnnualIncome = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnnualIncome
        '
        Me.txtAnnualIncome.Location = New System.Drawing.Point(320, 86)
        Me.txtAnnualIncome.Name = "txtAnnualIncome"
        Me.txtAnnualIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualIncome.TabIndex = 0
        Me.txtAnnualIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(320, 165)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 1
        Me.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(320, 246)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestRate.TabIndex = 2
        Me.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How Much Money Per Year Would You Like to Live On:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "In How Many Years Would You Like to Retire:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Interest Rate of Your Investment:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(51, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(345, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Retirement Calculator"
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(200, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(200, 370)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "A&bout"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "(Enter as a decimal)"
        '
        'RetirementCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(475, 405)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtAnnualIncome)
        Me.Name = "RetirementCalculator"
        Me.Text = "Retirement Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnnualIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
