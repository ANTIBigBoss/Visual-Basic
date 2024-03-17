' Compiler got mad at me for having the class inside the form, so I made it its own file.
Public Class CashRegister

    Private Balance As Decimal

    Public Sub New()
        Balance = 0
    End Sub

    Public Function GetBalance() As Decimal
        Return Balance
    End Function

    Public Sub Add(amount As Decimal)
        Balance += amount
    End Sub

    Public Function Subtract(amount As Decimal) As Boolean
        If Balance >= amount Then
            Balance -= amount
            Return True
        Else
            Return False
        End If
    End Function

End Class