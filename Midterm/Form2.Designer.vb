<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        RollButton = New Button()
        Label1 = New Label()
        NumberInputTextbox = New TextBox()
        ResultsRichTextBox = New RichTextBox()
        SuspendLayout()
        ' 
        ' RollButton
        ' 
        RollButton.Location = New Point(181, 50)
        RollButton.Name = "RollButton"
        RollButton.Size = New Size(92, 23)
        RollButton.TabIndex = 0
        RollButton.Text = "Roll"
        RollButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 1
        Label1.Text = "Number of Rolls:"
        ' 
        ' NumberInputTextbox
        ' 
        NumberInputTextbox.Location = New Point(51, 50)
        NumberInputTextbox.Name = "NumberInputTextbox"
        NumberInputTextbox.Size = New Size(100, 23)
        NumberInputTextbox.TabIndex = 2
        ' 
        ' ResultsRichTextBox
        ' 
        ResultsRichTextBox.Location = New Point(51, 79)
        ResultsRichTextBox.Name = "ResultsRichTextBox"
        ResultsRichTextBox.Size = New Size(222, 149)
        ResultsRichTextBox.TabIndex = 3
        ResultsRichTextBox.Text = ""
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 273)
        Controls.Add(ResultsRichTextBox)
        Controls.Add(NumberInputTextbox)
        Controls.Add(Label1)
        Controls.Add(RollButton)
        Name = "Form2"
        Text = "Dice Rolling Statistics"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumberInputTextbox As TextBox
    Friend WithEvents ResultsRichTextBox As RichTextBox
End Class
