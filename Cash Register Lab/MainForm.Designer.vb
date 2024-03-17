<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        AddButton = New Button()
        SubtractButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        AmountTextbox = New TextBox()
        BalanceTextbox = New TextBox()
        SuspendLayout()
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(55, 41)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(75, 23)
        AddButton.TabIndex = 0
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractButton
        ' 
        SubtractButton.Location = New Point(136, 41)
        SubtractButton.Name = "SubtractButton"
        SubtractButton.Size = New Size(75, 23)
        SubtractButton.TabIndex = 1
        SubtractButton.Text = "Subtract"
        SubtractButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 2
        Label1.Text = "Amount:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "Balance:"
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(111, 12)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(100, 23)
        AmountTextbox.TabIndex = 4
        ' 
        ' BalanceTextbox
        ' 
        BalanceTextbox.Enabled = False
        BalanceTextbox.Location = New Point(111, 68)
        BalanceTextbox.Name = "BalanceTextbox"
        BalanceTextbox.Size = New Size(100, 23)
        BalanceTextbox.TabIndex = 5
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(268, 101)
        Controls.Add(BalanceTextbox)
        Controls.Add(AmountTextbox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(SubtractButton)
        Controls.Add(AddButton)
        Name = "MainForm"
        Text = "Cash Resgister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents SubtractButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AmountTextbox As TextBox
    Friend WithEvents BalanceTextbox As TextBox

End Class
