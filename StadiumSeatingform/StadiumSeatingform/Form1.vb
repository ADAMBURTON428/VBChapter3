Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotal As Decimal
        Dim decClassAT As Decimal
        Dim decClassBT As Decimal
        Dim decClassCT As Decimal

        Try
            decClassAT = (txtClassA.Text) * 15
            decClassBT = (txtClassB.Text) * 12
            decClassCT = (txtClassC.Text) * 9
            decTotal = (decClassAT) + (decClassBT) + (decClassCT)

            lblClassA.Text = decClassAT.ToString("c")
            lblClassB.Text = decClassBT.ToString("c")
            lblClassC.Text = decClassCT.ToString("c")

            lblTotalRevenue.Text = decTotal.ToString("c")
        Catch
            lblStatus.Text = "All input must be vaild numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblStatus.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
