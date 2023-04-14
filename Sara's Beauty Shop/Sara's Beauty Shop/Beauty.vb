'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Lab #3--Sara's Beauty Shop
'Created by Niko Culevski
'Class: CS 115
'Date: 10/7/2009
'Project Name:  Sara's Beauty Shop
'Hours to Complete: 1 hour 25 minutes
'Platform: PC, VB.NET 2008, Windows XP
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Sarah's friendly beauty shop charges $35 for a haircut. It is customary to tip 
'the beautician certain percent. Write a VB.NET program that accepts as input 
'any basic rate (and not just $35) and the percent of tip and prints out a 
'simplified bill. The customer’s name and basic fee should be entered into 
'the program via text boxes; consider a NumericUpDown control for the percent 
'of tip. When a button is clicked, the customer’s name, the basic fee, the tip, 
'the tax (8.9% of basic fee but not on tip) and the total should be displayed 
'in a list box.
'
'Required input: 
'1. Customer's Name
'2. Basic fee
'3. Tip
'Output: Invoice with all charges
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the student:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Option Explicit On
Option Strict On

Public Class frmBeauty
    Dim intInvoiceNumber As Integer = 100
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Calculates and displays bill
        'Declaration of constants and variables
        Const SALES_TAX As Single = 0.089       '8.9% Sales tax
        Const DISCOUNT As Single = 0.1          '10% discount
        Const MAX_FEE As Decimal = 1000D        'Maximum fee

        Dim strName As String           'Name of customer
        Dim decFee As Decimal           'Basic fee
        Dim bytTip As Byte              'Percent of tip
        Dim decTipAmount As Decimal     'Tip in dollars
        Dim decTotal As Decimal         'Total bill
        Dim decSalesTax As Decimal      'Sales tax amount
        Dim strFormat As String = "{0,-27}{1,16}"       'Print zone formating string
        Dim strDiscount As String = ""  'Message for discount

        'Input
        strName = txtCustomer.Text
        Try
            decFee = Convert.ToDecimal(txtFee.Text)
            If (decFee < 0 OrElse decFee > MAX_FEE) Then
                Throw New Exception
            End If

            'bytTip = CByte(updTip.Value)           'old to be abandoned
            bytTip = Convert.ToByte(updTip.Value)

            'Calculation

            'Check for discount
            If chkDiscount.Checked Then
                decFee = decFee - CDec(DISCOUNT * decFee)
                strDiscount = " (" & DISCOUNT.ToString("P1") & " applied)"
            End If

            decTipAmount = CDec((bytTip / 100) * decFee)  'Calculate tip amount
            decSalesTax = CDec(SALES_TAX * decFee)

            decTotal = decFee + decTipAmount + decSalesTax

            'Output
            With lstDisplay.Items
                .Clear()
                .Add(String.Format(strFormat, "Customer", strName))
                .Add("")
                .Add(String.Format(strFormat, "Basic Fee" & strDiscount, _
                    FormatCurrency(decFee)))
                .Add(String.Format(strFormat, "Tip", decTipAmount.ToString("C")))
                .Add(String.Format(strFormat, "Sales Tax", _
                    FormatCurrency(decSalesTax)))
                .Add("-------------------------------------------")
                .Add(String.Format(strFormat, "Total", decTotal.ToString("C")))
            End With
            'intInvoiceNumber = intInvoiceNumber + 1
            'txtFee.Text = CStr(intInvoiceNumber)
        Catch ex As Exception
            MessageBox.Show("Invalid Fee. Fee must be of numeric type in range [0," _
              & MAX_FEE & "]", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFee.Focus()
            txtFee.SelectAll()
        End Try
        
    End Sub

    Private Sub chkDiscount_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDiscount.CheckedChanged
        'recalculates the invoice
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the form

        txtCustomer.Clear()
        txtFee.Text = "0"
        updTip.Value = 0
        chkDiscount.Checked = False
        txtCustomer.Focus()
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'Close the application
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Print the invoice
        'Not implemented yet
    End Sub

    Private Sub mnuFileClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileClear.Click
        btnClear_Click(sender, e)
    End Sub

    Private Sub frmBeauty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtCustomer.Text = CStr(intInvoiceNumber)
    End Sub

End Class
