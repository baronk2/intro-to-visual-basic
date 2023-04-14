'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the prof:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Lab #4--Membership Fee Calculator
'Created by Niko Culevski
'Class: CMPSC 115
'Date: 7/12/2005, 10/8/2009
'Project Name:  Membership Fee Calculator
'Hours to Complete: 1 hours 25 minutes
'Platform: PC, VB.NET 2008, Windows XP
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Write a VB program to calculate the membership fees of teh Bay City Health
'and Fitness Club:
'
'Required input:
'   1. Type of Membership
'   2. Options
'   3. Membership Length
'Output:
'   1. Monthly Fee
'   2. Total
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
'Comments by the student:
'
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Option Explicit On 
Option Strict On

Public Class frmMembership
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents radAdult As System.Windows.Forms.RadioButton
    Friend WithEvents radChild As System.Windows.Forms.RadioButton
    Friend WithEvents radStudent As System.Windows.Forms.RadioButton
    Friend WithEvents radSenior As System.Windows.Forms.RadioButton
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkYoga As System.Windows.Forms.CheckBox
    Friend WithEvents chkKarate As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents grpLength As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonths As System.Windows.Forms.Label
    Friend WithEvents grpFees As System.Windows.Forms.GroupBox
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtMonthlyFee As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalFee As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents mnuMembershipMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnufileClear As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMembership As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMembershipAdult As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMembershipChild As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMembershipStudent As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMembershipSenior As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOption As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOptionYoga As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOptionKarate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOptionTrainer As System.Windows.Forms.MenuItem
    Friend WithEvents updMonths As System.Windows.Forms.NumericUpDown
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembership))
        Me.grpType = New System.Windows.Forms.GroupBox
        Me.radSenior = New System.Windows.Forms.RadioButton
        Me.radStudent = New System.Windows.Forms.RadioButton
        Me.radChild = New System.Windows.Forms.RadioButton
        Me.radAdult = New System.Windows.Forms.RadioButton
        Me.grpOptions = New System.Windows.Forms.GroupBox
        Me.chkTrainer = New System.Windows.Forms.CheckBox
        Me.chkKarate = New System.Windows.Forms.CheckBox
        Me.chkYoga = New System.Windows.Forms.CheckBox
        Me.grpLength = New System.Windows.Forms.GroupBox
        Me.lblMonths = New System.Windows.Forms.Label
        Me.grpFees = New System.Windows.Forms.GroupBox
        Me.txtTotalFee = New System.Windows.Forms.TextBox
        Me.txtMonthlyFee = New System.Windows.Forms.TextBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblFee = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.mnuMembershipMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnufileClear = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnuMembership = New System.Windows.Forms.MenuItem
        Me.mnuMembershipAdult = New System.Windows.Forms.MenuItem
        Me.mnuMembershipChild = New System.Windows.Forms.MenuItem
        Me.mnuMembershipStudent = New System.Windows.Forms.MenuItem
        Me.mnuMembershipSenior = New System.Windows.Forms.MenuItem
        Me.mnuOption = New System.Windows.Forms.MenuItem
        Me.mnuOptionYoga = New System.Windows.Forms.MenuItem
        Me.mnuOptionKarate = New System.Windows.Forms.MenuItem
        Me.mnuOptionTrainer = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.updMonths = New System.Windows.Forms.NumericUpDown
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.grpType.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpFees.SuspendLayout()
        CType(Me.updMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radSenior)
        Me.grpType.Controls.Add(Me.radStudent)
        Me.grpType.Controls.Add(Me.radChild)
        Me.grpType.Controls.Add(Me.radAdult)
        Me.grpType.Location = New System.Drawing.Point(24, 24)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(136, 112)
        Me.grpType.TabIndex = 0
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.Location = New System.Drawing.Point(16, 88)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(109, 24)
        Me.radSenior.TabIndex = 3
        Me.radSenior.Text = "S&enior Citizen"
        '
        'radStudent
        '
        Me.radStudent.Location = New System.Drawing.Point(16, 64)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(109, 24)
        Me.radStudent.TabIndex = 2
        Me.radStudent.Text = "&Student"
        '
        'radChild
        '
        Me.radChild.Location = New System.Drawing.Point(16, 40)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(128, 24)
        Me.radChild.TabIndex = 1
        Me.radChild.Text = "Chil&d (12 & under)"
        '
        'radAdult
        '
        Me.radAdult.Checked = True
        Me.radAdult.Location = New System.Drawing.Point(16, 16)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(109, 24)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard &Adult"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkTrainer)
        Me.grpOptions.Controls.Add(Me.chkKarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(192, 32)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(144, 96)
        Me.grpOptions.TabIndex = 2
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.Location = New System.Drawing.Point(16, 64)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(120, 24)
        Me.chkTrainer.TabIndex = 2
        Me.chkTrainer.Text = "&Personal Trainer"
        '
        'chkKarate
        '
        Me.chkKarate.Location = New System.Drawing.Point(16, 40)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(64, 24)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        '
        'chkYoga
        '
        Me.chkYoga.Location = New System.Drawing.Point(16, 16)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(64, 24)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "&Yoga"
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.updMonths)
        Me.grpLength.Controls.Add(Me.lblMonths)
        Me.grpLength.Location = New System.Drawing.Point(24, 152)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(136, 88)
        Me.grpLength.TabIndex = 1
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Membership Length"
        '
        'lblMonths
        '
        Me.lblMonths.Location = New System.Drawing.Point(16, 24)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(96, 32)
        Me.lblMonths.TabIndex = 0
        Me.lblMonths.Text = "Enter the &Number of Months"
        '
        'grpFees
        '
        Me.grpFees.Controls.Add(Me.txtTotalFee)
        Me.grpFees.Controls.Add(Me.txtMonthlyFee)
        Me.grpFees.Controls.Add(Me.lblTotal)
        Me.grpFees.Controls.Add(Me.lblFee)
        Me.grpFees.Location = New System.Drawing.Point(192, 152)
        Me.grpFees.Name = "grpFees"
        Me.grpFees.Size = New System.Drawing.Size(152, 80)
        Me.grpFees.TabIndex = 3
        Me.grpFees.TabStop = False
        Me.grpFees.Text = "Membership Fees"
        '
        'txtTotalFee
        '
        Me.txtTotalFee.Enabled = False
        Me.txtTotalFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFee.Location = New System.Drawing.Point(88, 48)
        Me.txtTotalFee.Name = "txtTotalFee"
        Me.txtTotalFee.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalFee.TabIndex = 3
        Me.txtTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonthlyFee
        '
        Me.txtMonthlyFee.Enabled = False
        Me.txtMonthlyFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyFee.Location = New System.Drawing.Point(88, 24)
        Me.txtMonthlyFee.Name = "txtMonthlyFee"
        Me.txtMonthlyFee.Size = New System.Drawing.Size(56, 20)
        Me.txtMonthlyFee.TabIndex = 2
        Me.txtMonthlyFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(24, 48)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 23)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFee
        '
        Me.lblFee.Location = New System.Drawing.Point(8, 24)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(72, 23)
        Me.lblFee.TabIndex = 0
        Me.lblFee.Text = "Monthly Fee:"
        Me.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(32, 256)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(80, 32)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(144, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 32)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(256, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'mnuMembershipMenu
        '
        Me.mnuMembershipMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuMembership, Me.mnuOption, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnufileClear, Me.MenuItem1, Me.MenuItem2, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnufileClear
        '
        Me.mnufileClear.Index = 0
        Me.mnufileClear.Text = "Clea&r"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 3
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMembership
        '
        Me.mnuMembership.Index = 1
        Me.mnuMembership.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMembershipAdult, Me.mnuMembershipChild, Me.mnuMembershipStudent, Me.mnuMembershipSenior})
        Me.mnuMembership.Text = "&Membership"
        '
        'mnuMembershipAdult
        '
        Me.mnuMembershipAdult.Checked = True
        Me.mnuMembershipAdult.Index = 0
        Me.mnuMembershipAdult.Text = "&Adult"
        '
        'mnuMembershipChild
        '
        Me.mnuMembershipChild.Index = 1
        Me.mnuMembershipChild.Text = "Chil&d"
        '
        'mnuMembershipStudent
        '
        Me.mnuMembershipStudent.Index = 2
        Me.mnuMembershipStudent.Text = "&Student"
        '
        'mnuMembershipSenior
        '
        Me.mnuMembershipSenior.Index = 3
        Me.mnuMembershipSenior.Text = "S&enior"
        '
        'mnuOption
        '
        Me.mnuOption.Index = 2
        Me.mnuOption.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOptionYoga, Me.mnuOptionKarate, Me.mnuOptionTrainer})
        Me.mnuOption.Text = "&Options"
        '
        'mnuOptionYoga
        '
        Me.mnuOptionYoga.Index = 0
        Me.mnuOptionYoga.Text = "&Yoga"
        '
        'mnuOptionKarate
        '
        Me.mnuOptionKarate.Index = 1
        Me.mnuOptionKarate.Text = "&Karate"
        '
        'mnuOptionTrainer
        '
        Me.mnuOptionTrainer.Index = 2
        Me.mnuOptionTrainer.Text = "&Trainer"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        Me.mnuHelp.Text = "&Help"
        '
        'updMonths
        '
        Me.updMonths.Location = New System.Drawing.Point(18, 55)
        Me.updMonths.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.updMonths.Name = "updMonths"
        Me.updMonths.Size = New System.Drawing.Size(42, 20)
        Me.updMonths.TabIndex = 2
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "&Print"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "&About"
        '
        'frmMembership
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 310)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpFees)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mnuMembershipMenu
        Me.Name = "frmMembership"
        Me.Text = "Membership Fee Calculator"
        Me.grpType.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpLength.ResumeLayout(False)
        Me.grpFees.ResumeLayout(False)
        Me.grpFees.PerformLayout()
        CType(Me.updMonths, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Terminate Application
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear text boxes, check boxes and set focus
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        radAdult.Checked = True
        mnuMembershipAdult.Checked = True
        mnuMembershipChild.Checked = False
        mnuMembershipStudent.Checked = False
        mnuMembershipSenior.Checked = False
        updMonths.Value = 0
        txtMonthlyFee.Clear()
        txtTotalFee.Clear()
        updMonths.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Calculate and display membership fees
        'Constants declaration
        Const DISCOUNT_4_TO_6 As Decimal = 0.05D    '4 to 6 months
        Const DISCOUNT_7_TO_9 As Decimal = 0.08D    '7 to 9 months
        Const DISCOUNT_10_OR_MORE As Decimal = 0.1D '10 or more months
        Const ADULT_FEE As Decimal = 40             'Adult base monthly fee
        Const CHILD_FEE As Decimal = 20             'Child base monthly fee
        Const STUDENT_FEE As Decimal = 25           'Student base monthly fee
        Const SENIOR_FEE As Decimal = 30            'Senior base monthly fee
        Const YOGA As Decimal = 10                  'Yoga monthly fee
        Const KARATE As Decimal = 30                'Karate monthly fee
        Const TRAINER As Decimal = 50               'Personal Trainer monthly fee
        'Const MAX_MONTHS As Byte = 24               'Maximum number of months to sign up

        'Declare local variables
        Dim intMonths As Integer        'Number of months
        Dim decBaseFee As Decimal       'Base Monthly fee
        Dim decDiscount As Decimal      'Discount
        Dim decTotalFee As Decimal      'Total Membership Fee

        'Input
        intMonths = Convert.ToInt32(updMonths.Value)

        ''Validate the number of months
        'If (intMonths < 1 Or intMonths > MAX_MONTHS) Then
        '    MessageBox.Show("Enter a value in the range of 1-" & MAX_MONTHS _
        '        & " for months.", "Input Error")
        '    updMonths.Focus()
        'Else
        'Calculatethe base monthly fee
        If radAdult.Checked Then
            decBaseFee = ADULT_FEE
        ElseIf radChild.Checked Then
            decBaseFee = CHILD_FEE
        ElseIf radStudent.Checked Then
            decBaseFee = STUDENT_FEE
        ElseIf radSenior.Checked Then
            decBaseFee = SENIOR_FEE
        End If

        'Add any aditional services
        If chkYoga.Checked Then
            decBaseFee += YOGA
        End If
        If chkKarate.Checked Then
            decBaseFee += KARATE
        End If
        If chkTrainer.Checked Then
            decBaseFee += TRAINER
        End If

        'Determine the discount.
        Select Case intMonths
            Case Is <= 3
                decDiscount = 0
            Case 4 To 6
                decDiscount = decBaseFee * DISCOUNT_4_TO_6
            Case 7 To 9
                decDiscount = decBaseFee * DISCOUNT_7_TO_9
            Case Is >= 10
                decDiscount = decBaseFee * DISCOUNT_10_OR_MORE
        End Select

        'Adjust the base fee for the any discounts
        decBaseFee -= decDiscount

        'Calculate the total membership fee
        decTotalFee = Convert.ToDecimal(decBaseFee * intMonths)

        'Display the fees
        txtMonthlyFee.Text = decBaseFee.ToString("C")
        txtTotalFee.Text = FormatCurrency(decTotalFee)
        'End If
    End Sub

    Private Sub mnufileClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufileClear.Click
        'Call btnClear event procedure
        btnClear_Click(sender, e)
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        'Call btnExit event procedure
        btnExit_Click(sender, e)
    End Sub

    Private Sub chkYoga_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkYoga.CheckStateChanged
        'Checked box Yoga clicked
        If chkYoga.Checked Then
            mnuOptionYoga.Checked = True     'synchronize with menu
        Else
            mnuOptionYoga.Checked = False    'synchronize with menu
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub chkKarate_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKarate.CheckStateChanged
        'Checked box Yoga clicked
        If chkKarate.Checked Then
            mnuOptionKarate.Checked = True     'synchronize with menu
        Else
            mnuOptionKarate.Checked = False    'synchronize with menu
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub chkTrainer_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTrainer.CheckStateChanged
        'Checked box Yoga clicked
        If chkTrainer.Checked Then
            mnuOptionTrainer.Checked = True     'synchronize with menu
        Else
            mnuOptionTrainer.Checked = False    'synchronize with menu
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuOptionYoga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionYoga.Click
        'Menu Yoga selected
        If chkYoga.Checked Then
            chkYoga.Checked = False             'synchronize with check box
            mnuOptionYoga.Checked = False
        Else
            chkYoga.Checked = True              'synchronize with check box
            mnuOptionYoga.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuOptionKarate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptionKarate.Click
        'Menu Karate selected
        If chkKarate.Checked Then
            chkKarate.Checked = False           'synchronize with check box
            mnuOptionKarate.Checked = False
        Else
            chkKarate.Checked = True            'synchronize with check box
            mnuOptionKarate.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuOptionTrainer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuOptionTrainer.Click
        'Menu Trainer selected
        If chkTrainer.Checked Then
            chkTrainer.Checked = False          'synchronize with check box
            mnuOptionTrainer.Checked = False
        Else
            chkTrainer.Checked = True           'synchronize with check box
            mnuOptionTrainer.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuMembershipAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMembershipAdult.Click
        'Menu Adult membership selected
        If mnuMembershipAdult.Checked Then
            'mnuMembershipAdult.Checked = False
            radAdult.Checked = False
        Else
            mnuMembershipAdult.Checked = True
            mnuMembershipChild.Checked = False
            mnuMembershipStudent.Checked = False
            mnuMembershipSenior.Checked = False
            radAdult.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub radAdult_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radAdult.Click
        'Call btnCalculate_Click event procedure
        mnuMembershipAdult.Checked = True
        mnuMembershipChild.Checked = False
        mnuMembershipStudent.Checked = False
        mnuMembershipSenior.Checked = False
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuMembershipChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMembershipChild.Click
        'Menu Child membership selected
        If mnuMembershipChild.Checked Then
            'mnuMembershipChild.Checked = False
            radChild.Checked = False
        Else
            mnuMembershipAdult.Checked = False
            mnuMembershipChild.Checked = True
            mnuMembershipStudent.Checked = False
            mnuMembershipSenior.Checked = False
            radChild.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub radChild_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radChild.Click
        'Call btnCalculate_Click event procedure
        mnuMembershipAdult.Checked = False
        mnuMembershipChild.Checked = True
        mnuMembershipStudent.Checked = False
        mnuMembershipSenior.Checked = False
        radChild.Checked = True
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuMembershipStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMembershipStudent.Click
        'Menu Student membership selected
        If mnuMembershipStudent.Checked Then
            'mnuMembershipStudent.Checked = False
            radStudent.Checked = False
        Else
            mnuMembershipAdult.Checked = False
            mnuMembershipChild.Checked = False
            mnuMembershipStudent.Checked = True
            mnuMembershipSenior.Checked = False
            radStudent.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub radStudent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radStudent.Click
        'Call btnCalculate_Click event procedure
        mnuMembershipAdult.Checked = False
        mnuMembershipChild.Checked = False
        mnuMembershipStudent.Checked = True
        mnuMembershipSenior.Checked = False
        radStudent.Checked = True
        btnCalculate_Click(sender, e)
    End Sub


    Private Sub radSenior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSenior.Click
        'Call btnCalculate_Click event procedure
        mnuMembershipAdult.Checked = False
        mnuMembershipChild.Checked = False
        mnuMembershipStudent.Checked = False
        mnuMembershipSenior.Checked = True
        radSenior.Checked = True
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub mnuMembershipSenior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMembershipSenior.Click
        'Menu Senior membership selected
        If mnuMembershipSenior.Checked Then
            'mnuMembershipSenior.Checked = False
            radSenior.Checked = False
        Else
            mnuMembershipAdult.Checked = False
            mnuMembershipChild.Checked = False
            mnuMembershipStudent.Checked = False
            mnuMembershipSenior.Checked = True
            radSenior.Checked = True
        End If
        btnCalculate_Click(sender, e)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Print invoice
        'Not implemented
    End Sub
End Class
