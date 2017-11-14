Public Class Form1

    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        Dim decAverage, decTotal As Decimal

        Try
            decTotal = CDec(txtTestScore1.Text) + CDec(txtTestScore2.Text) + CDec(txtTestScore3.Text) + CDec(txtTestScore4.Text) + CDec(txtTestScore5.Text)
            decAverage = decTotal / 5
            lblAverage.Text = decAverage.ToString("n2")
        Catch
            lblError.Text = ("All input must be vaild numeric values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Clear()
        txtTestScore2.Clear()
        txtTestScore3.Clear()
        txtTestScore4.Clear()
        txtTestScore5.Clear()

        lblAverage.Text = String.Empty
        lblError.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
