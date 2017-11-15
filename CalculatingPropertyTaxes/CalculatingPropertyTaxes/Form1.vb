Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAssessment As Decimal
        Dim decPropertyTax As Decimal


        Try
            decAssessment = (txtActualProperty.Text) * 0.6
            decPropertyTax = (decAssessment / 100) * 0.64

            lblAssessment.Text = decAssessment.ToString("c")
            lblProperty.Text = decPropertyTax.ToString("c")
        Catch
            lblError.Text = "Error"

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAssessment.Text = String.Empty
        lblError.Text = String.Empty
        lblProperty.Text = String.Empty
        txtActualProperty.Clear()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
