Public Class MainMenu

    Private Sub SwapToForm1_Click_1(sender As Object, e As EventArgs) Handles SwapToForm1.Click
        Dim frm As New Form1
        frm.Show()
    End Sub

    Private Sub SwapToForm2_Click_1(sender As Object, e As EventArgs) Handles SwapToForm2.Click
        Dim frm As New Form2
        frm.Show()
    End Sub

    Private Sub SwapToForm3_Click(sender As Object, e As EventArgs) Handles SwapToForm3.Click
        Dim frm As New Form3
        frm.Show()
    End Sub
End Class