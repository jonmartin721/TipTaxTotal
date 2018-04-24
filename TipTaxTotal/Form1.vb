Public Class Form1
    Private Sub bttnExit_Click(sender As Object, e As EventArgs) Handles bttnExit.Click
        Application.Exit()

    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtAmount.Clear()
        statusLabel.Text = String.Empty
        lblTaxCalcutions.Text = String.Empty
        lblTipCalculation.Text = String.Empty
        lblTotalCalculations.Text = String.Empty
        txtAmount.Focus()


    End Sub

    Private Sub bttnCalculate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnCalculate_Click_1(sender As Object, e As EventArgs) Handles bttnCalculate.Click
        Try
            Dim dblAmount As Double
            Dim dblTip As Double
            Dim dblTax As Double
            Dim dblTotal As Double
            dblAmount = CDbl(txtAmount.Text)
            dblTip = dblAmount * 0.15
            dblTax = dblAmount * 0.0825
            dblTotal = dblAmount + dblTax + dblTip

            lblTaxCalcutions.Text = dblTax.ToString("c")
            lblTipCalculation.Text = dblTip.ToString("c")
            lblTotalCalculations.Text = dblTotal.ToString("c")

        Catch ex As Exception
            statusLabel.Text = "Invalid input! Please use a number for the Amount Field."


        End Try
    End Sub
End Class
