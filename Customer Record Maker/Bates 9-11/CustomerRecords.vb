'Nathaniel Bates
'11/16/2014
'The Customer Records Creator Application
'Bates 9-11
'Create a customer record for a customer file
'This application will gather personal information about the customer, the balance that is on their account, and when the last
'payment was made by the customer.
'Splashscree image:
'http://www.bing.com/images/search?q=free+space+pictures&id=95D39743B5CFFA7A7EBA1E3D76CC624AED34BD3B&FORM=IQFRBA#view=detail&id=CAEC0C41293530CC4AE988A3D4F40DDFA6103A96&selectedIndex=65
'About Page
'http://www.bing.com/images/search?q=free+space+pictures&id=95D39743B5CFFA7A7EBA1E3D76CC624AED34BD3B&FORM=IQFRBA#view=detail&id=28B5BD7286AC7836988EFC86219C8945BF90B058&selectedIndex=17
'I recieved information about the InStr() funtion from here:
'http://www.visual-basic-tutorials.com/search-full-text-in-listbox-in-visual-basic.htm

Option Explicit On
Option Strict On

Imports System.IO
Public Class CustomerRecords
    Structure CustomerInformation
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim strState As String
        Dim strZipCode As String
        Dim strPhone As String
        Dim strCustomerNumber As String
        Dim dblAccountBalance As Double
        Dim strDate As String
    End Structure

    Dim customerInfo As CustomerInformation
    Dim strFilename As String

    Function ValidateInput() As Boolean
        If txtFirst.Text = String.Empty Then
            Return False
        End If

        If txtLast.Text = String.Empty Then
            Return False
        End If

        If txtAddress.Text = String.Empty Then
            Return False
        End If

        If txtCity.Text = String.Empty Then
            Return False
        End If

        If txtState.Text = String.Empty Then
            Return False
        End If

        If txtZip.Text = String.Empty Then
            Return False
        End If

        If txtPhone.Text = String.Empty Then
            Return False
        End If

        If txtCustNumber.Text = String.Empty Then
            Return False
        End If

        If txtAcctBalance.Text = String.Empty Then
            Return False
        End If

        If txtDateLastPymt.Text = String.Empty Then
            Return False
        End If

        Return True

    End Function
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim customerFile As StreamWriter
        Dim customerInfo As CustomerInformation

        Try

            customerInfo.strFirstName = txtFirst.Text.ToString()
            customerInfo.strLastName = txtLast.Text.ToString()
            customerInfo.strAddress = txtAddress.Text.ToString()
            customerInfo.strCity = txtCity.Text.ToString()
            customerInfo.strState = txtState.Text.ToString()
            customerInfo.strZipCode = txtZip.Text.ToString()
            customerInfo.strPhone = txtPhone.Text.ToString()
            customerInfo.strCustomerNumber = txtCustNumber.Text.ToString()
            customerInfo.dblAccountBalance = CDbl(txtAcctBalance.Text)
            customerInfo.strDate = txtDateLastPymt.Text.ToString()

            If ValidateInput() And customerInfo.dblAccountBalance > 0 Then

                strFilename = InputBox("Enter the file name for your customer information.")
                customerFile = File.AppendText(strFilename)
                customerFile.WriteLine(customerInfo.strFirstName & " " & customerInfo.strLastName)
                customerFile.WriteLine(customerInfo.strAddress)
                customerFile.WriteLine(customerInfo.strCity & ", " & customerInfo.strState & " " & customerInfo.strZipCode)
                customerFile.WriteLine("Phone Number: " & customerInfo.strPhone)
                customerFile.WriteLine("Customer Number: " & customerInfo.strCustomerNumber)
                customerFile.WriteLine("Account Balance: " & customerInfo.dblAccountBalance.ToString("c"))
                customerFile.WriteLine("Date of Last Payment: " & customerInfo.strDate)
                customerFile.WriteLine()

                customerFile.Close()
            Else
                MessageBox.Show("Please make sure all fields are entered and the account balance is positive.")
            End If

        Catch ex As Exception
            MessageBox.Show("Please make sure all fields are entered and the account balance is positive.")
        End Try


    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim customerFile As StreamReader
        Dim strOutput As String
        strFilename = InputBox("Enter the file name you wish to open.")

        Try
            customerFile = File.OpenText(strFilename)
            lstCustomers.Items.Clear()

            Do Until customerFile.EndOfStream
                strOutput = customerFile.ReadLine()
                lstCustomers.Items.Add(strOutput)
            Loop

            customerFile.Close()

        Catch ex As Exception
            MessageBox.Show("That file cannot be opened.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirst.Clear()
        txtLast.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()
        txtCustNumber.Clear()
        txtAcctBalance.Clear()
        txtDateLastPymt.Clear()
        txtSearch.Clear()

        txtFirst.Focus()
    End Sub


    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim customerFile As StreamReader
        Dim intX As Integer = 10
        Dim intY As Integer = 10

        Try
            customerFile = File.OpenText(strFilename)

            Do While Not customerFile.EndOfStream
                e.Graphics.DrawString(customerFile.ReadLine(), New Font("MS Sans Serif", 12, FontStyle.Regular), Brushes.Black, intX, intY)
                intY += 18
            Loop

            customerFile.Close()

        Catch
            MessageBox.Show("Please select a document to print.")
        End Try

    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        pdPrint.Print()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnValidateSearch As Boolean = True

        lstCustomers.SelectedIndex = -1

        If txtSearch.Text = String.Empty Then
            blnValidateSearch = False
            MessageBox.Show("Please enter a last name or customer number.")
        End If

        If blnValidateSearch = True Then
            Dim intCount As Integer = (lstCustomers.Items.Count - 1)
            Dim strSearch As String

            For a = 0 To intCount
                strSearch = lstCustomers.Items.Item(a).ToString()
                If CBool(InStr(strSearch.ToLower, txtSearch.Text.ToLower)) Then
                    lstCustomers.SelectedItem = strSearch
                End If
            Next

            If lstCustomers.SelectedIndex = -1 Then
                MessageBox.Show("Item could not be found.")
            End If

        End If

    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        lstCustomers.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub CustomerRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Threading.Thread.Sleep(3000)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
