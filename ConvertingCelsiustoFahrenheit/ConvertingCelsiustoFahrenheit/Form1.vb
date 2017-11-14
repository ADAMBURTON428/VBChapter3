Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decFahrenheit As Decimal

        Try
            decFahrenheit = (txtCelsius.Text) * 1.8 + 32

            lblFahrenheit.Text = decFahrenheit.ToString & "°F"
        Catch
            lblStatus.Text = "All input must be vaild numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Clear()
        lblFahrenheit.Text = String.Empty
        lblStatus.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
