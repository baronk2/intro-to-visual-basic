Option Strict On

Public Class Finished
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
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnRunDemo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnModular As System.Windows.Forms.Button
    Friend WithEvents btnSubCall As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnRunDemo = New System.Windows.Forms.Button
        Me.lstOutput = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnModular = New System.Windows.Forms.Button
        Me.btnSubCall = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(106, 353)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClear.Size = New System.Drawing.Size(81, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(200, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRunDemo
        '
        Me.btnRunDemo.BackColor = System.Drawing.SystemColors.Control
        Me.btnRunDemo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRunDemo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunDemo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRunDemo.Location = New System.Drawing.Point(16, 353)
        Me.btnRunDemo.Name = "btnRunDemo"
        Me.btnRunDemo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRunDemo.Size = New System.Drawing.Size(81, 33)
        Me.btnRunDemo.TabIndex = 3
        Me.btnRunDemo.Text = "&Run Demo"
        Me.btnRunDemo.UseVisualStyleBackColor = False
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.ItemHeight = 18
        Me.lstOutput.Location = New System.Drawing.Point(16, 16)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(272, 292)
        Me.lstOutput.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Nested"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.Location = New System.Drawing.Point(347, 51)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(46, 26)
        Me.txtSize.TabIndex = 8
        Me.txtSize.Text = "2"
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Size"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(327, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 26)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Pattern"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnModular
        '
        Me.btnModular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModular.Location = New System.Drawing.Point(327, 169)
        Me.btnModular.Name = "btnModular"
        Me.btnModular.Size = New System.Drawing.Size(96, 26)
        Me.btnModular.TabIndex = 11
        Me.btnModular.Text = "Modular"
        Me.btnModular.UseVisualStyleBackColor = True
        '
        'btnSubCall
        '
        Me.btnSubCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubCall.Location = New System.Drawing.Point(327, 256)
        Me.btnSubCall.Name = "btnSubCall"
        Me.btnSubCall.Size = New System.Drawing.Size(96, 26)
        Me.btnSubCall.TabIndex = 12
        Me.btnSubCall.Text = "SubCall"
        Me.btnSubCall.UseVisualStyleBackColor = True
        '
        'Finished
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(451, 462)
        Me.Controls.Add(Me.btnSubCall)
        Me.Controls.Add(Me.btnModular)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRunDemo)
        Me.Name = "Finished"
        Me.Text = "For Next Demo 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnRunDemo_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnRunDemo.Click

        ' Demonstrate the For...Next loop.
        Dim intCount As Integer         ' Loop counter
        Dim intSquare As Integer        ' To hold squares
        Dim strTemp As String           ' To hold output

        For intCount = 1 To 10
            intSquare = CInt(intCount ^ 2)
            strTemp = "The square of " & intCount.ToString _
                & " is " & intSquare.ToString
            lstOutput.Items.Add(strTemp)
        Next intCount
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear the list box
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Demonstrate the For...Next loop.
        Dim intRows As Integer         ' Outer loop counter
        Dim intCols As Integer         ' Inner loop counter
        Dim strTemp As String = ""      ' To hold output
        Dim intSize As Integer = CInt(Val(txtSize.Text))

        strTemp = ""
        strTemp = "!"
        For intRows = 1 To intSize
            strTemp += "#"
        Next intRows
        strTemp += "!"
        lstOutput.Items.Add(strTemp)



        For intRows = 1 To intSize
            strTemp = ""
            strTemp = "!"
            For intCols = 1 To intSize
                strTemp += "0"
            Next
            strTemp += "!"

            lstOutput.Items.Add(strTemp)
        Next intRows

        strTemp = ""
        strTemp = "!"
        For intRows = 1 To intSize
            strTemp += "#"
        Next intRows
        strTemp += "!"
        lstOutput.Items.Add(strTemp)


        'lstOutput.Items.Add(strTemp)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Demonstrate the For...Next loop.
        Dim intRows As Integer         ' Outer loop counter
        Dim intCols As Integer         ' Inner loop counter
        Dim strTemp As String = ""      ' To hold output

        For intRows = 1 To 10
            For intCols = 1 To intRows
                strTemp += intRows.ToString
            Next intCols
            lstOutput.Items.Add(strTemp)
            strTemp = ""
            'lstOutput.Items.Add(strTemp)
        Next intRows

    End Sub

    Private Sub btnModular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModular.Click
        ' Dim intRows As Integer         ' Outer loop counter
        ' Dim intCols As Integer         ' Inner loop counter
        Dim strTemp As String = ""      ' To hold output
        Dim intSize As Integer = CInt(Val(txtSize.Text))

        TopBottom(intSize)
        Middle(intSize)
        TopBottom(intSize)

        'lstOutput.Items.Add(strTemp)
    End Sub

    Sub TopBottom(ByVal intS As Integer)
        Dim intRows As Integer         ' Outer loop counter
        Dim strTemp As String = ""      ' To hold output

        strTemp = ""
        strTemp = "#"
        For intRows = 1 To intS
            strTemp += "#"
        Next intRows
        strTemp += "#"
        lstOutput.Items.Add(strTemp)
    End Sub

    Sub Middle(ByVal intS As Integer)
        Dim intRows As Integer         ' Outer loop counter
        Dim intCols As Integer         ' Inner loop counter
        Dim strTemp As String = ""      ' To hold output

        For intRows = 1 To intS
            strTemp = ""
            strTemp = "#"
            For intCols = 1 To intS
                strTemp += "0"
            Next
            strTemp += "#"

            lstOutput.Items.Add(strTemp)
        Next intRows
    End Sub
End Class
