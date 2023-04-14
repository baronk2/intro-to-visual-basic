Option Strict On

Public Class Form1
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
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Public WithEvents btnClear As System.Windows.Forms.Button
    Public WithEvents btnRunDemo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRunDemo = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ItemHeight = 18
        Me.lstDisplay.Location = New System.Drawing.Point(16, 16)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(272, 292)
        Me.lstDisplay.TabIndex = 6
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
        'Form1
        '
        Me.AcceptButton = Me.btnRunDemo
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(451, 462)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRunDemo)
        Me.Name = "Form1"
        Me.Text = "For Next Demo 1"
        Me.ResumeLayout(False)

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
            lstDisplay.Items.Add(strTemp)
        Next intCount
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnClear.Click

        ' Clear the list box
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        ' End the application
        Me.Close()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Demonstrate the For...Next loop.
        Dim intRows As Integer         ' Outer loop counter
        Dim intCols As Integer         ' Inner loop counter
        Dim intJ As Integer            ' Second Inner loop
        Dim strTemp As String = ""      ' To hold output

        For intRows = 1 To 5
            For intCols = 1 To 5 - intRows
                strTemp &= "*"
            Next intCols

            For intJ = 1 To intRows
                strTemp &= "!"
            Next intJ


            lstDisplay.Items.Add(strTemp)
            strTemp = ""
            'lstDisplay.Items.Add(strTemp)
        Next intRows

    End Sub

End Class
