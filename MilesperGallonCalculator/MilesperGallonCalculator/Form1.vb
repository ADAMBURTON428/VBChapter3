Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decMilesperTotal As Decimal

        Try
            decMilesperTotal = (txtMiles.Text) / (txtGallons.Text)
            lblMilesPerGallon.Text = decMilesperTotal.ToString("n2")
        Catch

            lblStatus.Text = "Error: Be sure to enter nonzero" & " numeric values"


        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()
        lblMilesPerGallon.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
