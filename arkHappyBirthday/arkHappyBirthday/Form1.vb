' Birthday Game Lab
' VB 115 Week 5
' Alvin Kroon
' May 5, 2010
'
' Time: 45 minutes
' Students use stu_arkHappyBirthday project


Public Class frmBirthday

    Dim intMagicNumber As Integer = 0 'Class variable for all calcs

    Private Sub btnMultFive1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMultFive1.Click
        ' Multiply month * 5
        Dim intMonth As Integer = 0
        intMonth = CInt(txtBirthMonth.Text)

        intMagicNumber = intMonth * 5
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub

    Private Sub btnAddSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSix.Click
        ' Add 6 
        intMagicNumber += 6
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub

    Private Sub btnMultFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultFour.Click
        ' Multiply by 4
        intMagicNumber *= 4
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub

    Private Sub btnPlusNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusNine.Click
        ' Add 9 
        intMagicNumber += 9
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub

    Private Sub btnTimesFive2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimesFive2.Click
        ' Multiply by 5
        intMagicNumber *= 5
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub


    Private Sub btnWish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWish.Click
        ' Get text from txtBirthdate
        Dim intDay As Integer = 0
        intDay = CInt(txtBirthDate.Text)
        intMagicNumber = intMagicNumber + intDay
        lblMagicNumber.Text = intMagicNumber.ToString()

        'Extract month and day
        Dim intYourMonth As Integer = (intMagicNumber - 165) / 100
        Dim intYourDay As Integer = (intMagicNumber - 165) Mod 100
        lblYourMonth.Text = intYourMonth.ToString()
        lblYourDay.Text = intYourDay.ToString()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBirthDate.Text = ""
        txtBirthMonth.Text = ""
        lblMagicNumber.Text = ""
        'txtBirthMonth.Focus = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
