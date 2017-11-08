Public Class Form1

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFixedPointFormat_Click(sender As Object, e As EventArgs) Handles btnFixedPointFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult
    End Sub

    Private Sub btnExponetialFormat_Click(sender As Object, e As EventArgs) Handles btnExponetialFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("e")
        lblResult.Text = strResult
    End Sub

    Private Sub btnCurrencyFormat_Click(sender As Object, e As EventArgs) Handles btnCurrencyFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("c")
        lblResult.Text = strResult
    End Sub

    Private Sub btnPercentFormat_Click(sender As Object, e As EventArgs) Handles btnPercentFormat.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtUserEntry.Text)

        strResult = dblAnswer.ToString("p")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortDate_Click(sender As Object, e As EventArgs) Handles btnShortDate.Click
        Dim dtmAnswer As Date
        Dim strResult As String

        dtmAnswer = CDate(txtUserEntry.Text)

        strResult = dtmAnswer.ToString("d")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongDate_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        Dim dtmAnswer As Date
        Dim strResult As String

        dtmAnswer = CDate(txtUserEntry.Text)

        strResult = dtmAnswer.ToString("D")
        lblResult.Text = strResult
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dtmAnswer As Date
        Dim strResult As String

        dtmAnswer = CDate(txtUserEntry.Text)

        strResult = dtmAnswer.ToString("t")
        lblResult.Text = strResult
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim dtmAnswer As Date
        Dim strResult As String

        dtmAnswer = CDate(txtUserEntry.Text)

        strResult = dtmAnswer.ToString("T")
        lblResult.Text = strResult
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim dtmAnswer As Date
        Dim strResult As String

        dtmAnswer = CDate(txtUserEntry.Text)

        strResult = dtmAnswer.ToString("F")
        lblResult.Text = strResult
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserEntry.Clear()
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
