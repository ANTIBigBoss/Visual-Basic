Public Class MainForm

    Private CashRegister As New CashRegister()

    Private Sub UpdateBalance()
        'C2 is to format to two decimal places
        BalanceTextbox.Text = CashRegister.GetBalance().ToString("C2")
    End Sub

    ' Make sure we have a balance upon loading otherwise we have nothing to add the new balance to
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBalance()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim amount As Decimal
        If Decimal.TryParse(AmountTextbox.Text, amount) Then
            CashRegister.Add(amount)
            UpdateBalance()
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
        ' Once successful we clear the textbox for the next input
        ' We don't need to I just like it looking clean
        AmountTextbox.Clear()
    End Sub

    Private Sub SubtractButton_Click(sender As Object, e As EventArgs) Handles SubtractButton.Click
        Dim amount As Decimal
        If Decimal.TryParse(AmountTextbox.Text, amount) Then
            If Not CashRegister.Subtract(amount) Then
                MessageBox.Show("Insufficient funds to complete this operation.")
            End If
            UpdateBalance()
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
        AmountTextbox.Clear()
    End Sub
End Class
