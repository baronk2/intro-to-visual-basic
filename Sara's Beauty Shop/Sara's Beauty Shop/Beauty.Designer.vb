<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeauty
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeauty))
        Me.picBeauty = New System.Windows.Forms.PictureBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblFee = New System.Windows.Forms.Label
        Me.lblTip = New System.Windows.Forms.Label
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.txtFee = New System.Windows.Forms.TextBox
        Me.updTip = New System.Windows.Forms.NumericUpDown
        Me.chkDiscount = New System.Windows.Forms.CheckBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.lstDisplay = New System.Windows.Forms.ListBox
        Me.lblTanks = New System.Windows.Forms.Label
        Me.mnuBeauty = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFileClear = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileQuit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCalculate = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ttpSara = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.picBeauty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updTip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuBeauty.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBeauty
        '
        Me.picBeauty.Image = CType(resources.GetObject("picBeauty.Image"), System.Drawing.Image)
        Me.picBeauty.Location = New System.Drawing.Point(23, 48)
        Me.picBeauty.Name = "picBeauty"
        Me.picBeauty.Size = New System.Drawing.Size(56, 58)
        Me.picBeauty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBeauty.TabIndex = 0
        Me.picBeauty.TabStop = False
        Me.ttpSara.SetToolTip(Me.picBeauty, "Picture of Megan Fox")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(97, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(177, 60)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Sara's Beauty Shop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "123 Main Street" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edmonds, WA 98036"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(19, 127)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(78, 20)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Customer"
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(17, 161)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(80, 20)
        Me.lblFee.TabIndex = 3
        Me.lblFee.Text = "Basic Fee"
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTip.Location = New System.Drawing.Point(39, 195)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(58, 20)
        Me.lblTip.TabIndex = 4
        Me.lblTip.Text = "Tip (%)"
        '
        'txtCustomer
        '
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(103, 123)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(171, 26)
        Me.txtCustomer.TabIndex = 5
        '
        'txtFee
        '
        Me.txtFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.Location = New System.Drawing.Point(103, 155)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(65, 26)
        Me.txtFee.TabIndex = 6
        Me.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'updTip
        '
        Me.updTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updTip.Location = New System.Drawing.Point(103, 189)
        Me.updTip.Name = "updTip"
        Me.updTip.Size = New System.Drawing.Size(65, 26)
        Me.updTip.TabIndex = 7
        Me.updTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiscount.Location = New System.Drawing.Point(183, 157)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(91, 24)
        Me.chkDiscount.TabIndex = 8
        Me.chkDiscount.Text = "&Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Cornsilk
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(292, 48)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 32)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "&Calculate"
        Me.ttpSara.SetToolTip(Me.btnCalculate, "Click here to calculate invoice")
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Cornsilk
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(292, 93)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 32)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Cornsilk
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(292, 138)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 32)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Cornsilk
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(292, 183)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(94, 32)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(21, 231)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(365, 148)
        Me.lstDisplay.TabIndex = 13
        '
        'lblTanks
        '
        Me.lblTanks.AutoSize = True
        Me.lblTanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTanks.Location = New System.Drawing.Point(67, 392)
        Me.lblTanks.Name = "lblTanks"
        Me.lblTanks.Size = New System.Drawing.Size(277, 20)
        Me.lblTanks.TabIndex = 14
        Me.lblTanks.Text = "Thank you for being our customer"
        '
        'mnuBeauty
        '
        Me.mnuBeauty.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuCalculate, Me.mnuHelp})
        Me.mnuBeauty.Location = New System.Drawing.Point(0, 0)
        Me.mnuBeauty.Name = "mnuBeauty"
        Me.mnuBeauty.Size = New System.Drawing.Size(410, 24)
        Me.mnuBeauty.TabIndex = 15
        Me.mnuBeauty.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.ToolStripMenuItem1, Me.mnuFileClear, Me.mnuFilePrint, Me.mnuFileQuit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFileClear
        '
        Me.mnuFileClear.Name = "mnuFileClear"
        Me.mnuFileClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileClear.Text = "C&lear"
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(152, 22)
        Me.mnuFilePrint.Text = "&Print"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Name = "mnuFileQuit"
        Me.mnuFileQuit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileQuit.Text = "&Quit"
        '
        'mnuCalculate
        '
        Me.mnuCalculate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.mnuCalculate.Name = "mnuCalculate"
        Me.mnuCalculate.Size = New System.Drawing.Size(68, 20)
        Me.mnuCalculate.Text = "&Calculate"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'frmBeauty
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 424)
        Me.Controls.Add(Me.lblTanks)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.updTip)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBeauty)
        Me.Controls.Add(Me.mnuBeauty)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuBeauty
        Me.MaximizeBox = False
        Me.Name = "frmBeauty"
        Me.Text = "Sara's Beauty Shop"
        CType(Me.picBeauty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updTip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuBeauty.ResumeLayout(False)
        Me.mnuBeauty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBeauty As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents lblTip As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents updTip As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblTanks As System.Windows.Forms.Label
    Friend WithEvents mnuBeauty As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttpSara As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
