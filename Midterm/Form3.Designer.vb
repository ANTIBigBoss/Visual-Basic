<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        NameInputTextbox = New TextBox()
        PhoneNumberInputTextbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ParseNameButton = New Button()
        EditPhoneNumberButton = New Button()
        SuspendLayout()
        ' 
        ' NameInputTextbox
        ' 
        NameInputTextbox.Location = New Point(139, 25)
        NameInputTextbox.Name = "NameInputTextbox"
        NameInputTextbox.Size = New Size(121, 23)
        NameInputTextbox.TabIndex = 0
        ' 
        ' PhoneNumberInputTextbox
        ' 
        PhoneNumberInputTextbox.Location = New Point(139, 77)
        PhoneNumberInputTextbox.Name = "PhoneNumberInputTextbox"
        PhoneNumberInputTextbox.Size = New Size(121, 23)
        PhoneNumberInputTextbox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 2
        Label1.Text = "Enter Full Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 15)
        Label2.TabIndex = 3
        Label2.Text = "Enter Phone Number:"
        ' 
        ' ParseNameButton
        ' 
        ParseNameButton.Location = New Point(293, 25)
        ParseNameButton.Name = "ParseNameButton"
        ParseNameButton.Size = New Size(134, 23)
        ParseNameButton.TabIndex = 4
        ParseNameButton.Text = "Parse Name"
        ParseNameButton.UseVisualStyleBackColor = True
        ' 
        ' EditPhoneNumberButton
        ' 
        EditPhoneNumberButton.Location = New Point(293, 76)
        EditPhoneNumberButton.Name = "EditPhoneNumberButton"
        EditPhoneNumberButton.Size = New Size(134, 23)
        EditPhoneNumberButton.TabIndex = 5
        EditPhoneNumberButton.Text = "Edit Phone Number"
        EditPhoneNumberButton.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 122)
        Controls.Add(EditPhoneNumberButton)
        Controls.Add(ParseNameButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PhoneNumberInputTextbox)
        Controls.Add(NameInputTextbox)
        Name = "Form3"
        Text = "String Handling"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameInputTextbox As TextBox
    Friend WithEvents PhoneNumberInputTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ParseNameButton As Button
    Friend WithEvents EditPhoneNumberButton As Button
End Class
