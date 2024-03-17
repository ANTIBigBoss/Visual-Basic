Public Class Form1
    ' Functions for all the math operations
    Function Square(ByVal number As Double) As Double
        Return number * number
    End Function

    Function SquareRoot(ByVal number As Double) As Double
        ' Round to 2 decimal places with the Math.Round otherwise the result will be a long decimal number
        Return Math.Round(Math.Sqrt(number), 2)
    End Function

    Function Factorial(ByVal number As Double) As Double
        Dim result As Double = 1
        For i As Double = 1 To number
            result *= i
        Next
        Return result
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim number As Double
        Dim result As Double
        Try
            number = Double.Parse(NumberInputTextbox.Text)
            If MathDropdown.Text = "Square" Then
                result = Square(number)
            ElseIf MathDropdown.Text = "Square Root" Then
                result = SquareRoot(number)
            ElseIf MathDropdown.Text = "Factorial" Then
                result = Factorial(number)
            End If
            ResultTextbox.Text = result.ToString()
            ' Catch non number inputs
        Catch ex As FormatException
            MessageBox.Show("Please enter a valid number")
            ' Catch numbers too large/small
        Catch ex As OverflowException
            MessageBox.Show("Please enter a valid number")
        End Try
    End Sub

End Class