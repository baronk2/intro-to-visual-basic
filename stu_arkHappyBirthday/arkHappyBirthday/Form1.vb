Public Class frmBirthday

    Dim intMagicNumber As Integer = 0   'Class variable for all calculations

    Private Sub btnMultFive1_Click(sender As System.Object, e As System.EventArgs) Handles btnMultFive1.Click
        ' Multiply month by 5
        Dim intMonth As Integer = 0
        intMonth = CInt(txtBirthMonth.Text)

        intMagicNumber = intMonth * 5
        lblMagicNumber.Text = intMagicNumber.ToString()
    End Sub
End Class
