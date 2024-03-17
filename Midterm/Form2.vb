Public Class Form2

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim random As New Random
        Dim frequency(5) As Integer
        Dim roll As Integer
        Dim n As Integer
        Dim output As String

        Try
            n = Integer.Parse(NumberInputTextbox.Text)

        Catch ex As FormatException
            MessageBox.Show("Please enter a valid number")
            Exit Sub

        Catch ex As OverflowException
            MessageBox.Show("Please enter a valid number")
        End Try

        If n < 1 Then
            MessageBox.Show("Please enter a valid number")
            Exit Sub
        End If


        For i = 1 To n
            roll = random.Next(1, 7)
            frequency(roll - 1) += 1
        Next

        output = "Face" & vbTab & "Frequency" & vbTab & "%" & Environment.NewLine
        For i = 0 To 5
            output &= (i + 1) & vbTab & frequency(i) & vbTab & vbTab & Math.Round((frequency(i) / n) * 100, 1) & "%" & Environment.NewLine
        Next

        ResultsRichTextBox.Text = output

    End Sub

End Class