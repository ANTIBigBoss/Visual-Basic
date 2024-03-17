Public Class Form3

    Private Sub ParseNameButton_Click(sender As Object, e As EventArgs) Handles ParseNameButton.Click

        Dim name As String = NameInputTextbox.Text
        Dim nameArray() As String = name.Split(" ")
        Dim firstName As String = nameArray(0)
        Dim lastName As String = nameArray(nameArray.Length - 1)
        Dim middleName As String = ""
        If nameArray.Length > 2 Then
            middleName = nameArray(1)
        End If

        If nameArray.Length = 1 Then
            MessageBox.Show("First Name: " & nameArray(0) & Environment.NewLine & "Middle Name: " & Environment.NewLine & "Last Name: ")
        Else
            MessageBox.Show("First Name: " & firstName & Environment.NewLine & "Middle Name: " & middleName & Environment.NewLine & "Last Name: " & lastName)
        End If

    End Sub

    Private Sub EditPhoneNumberButton_Click(sender As Object, e As EventArgs) Handles EditPhoneNumberButton.Click

        Dim PhoneNumber As String = PhoneNumberInputTextbox.Text

        Dim digitsOnly As String = ""

        For Each c As Char In PhoneNumber
            If Char.IsDigit(c) Then
                digitsOnly &= c
            End If
        Next

        MessageBox.Show("Entered: " & PhoneNumber & Environment.NewLine & "Digits only: " & digitsOnly & Environment.NewLine & "Standard format: " & digitsOnly.Substring(0, 3) & "-" & digitsOnly.Substring(3, 3) & "-" & digitsOnly.Substring(6, 4))

    End Sub
End Class