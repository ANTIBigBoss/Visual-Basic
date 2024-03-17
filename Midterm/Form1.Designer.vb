<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        CalculateButton = New Button()
        NumberInputTextbox = New TextBox()
        ResultTextbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        MathDropdown = New ComboBox()
        SuspendLayout()
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(48, 70)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(157, 40)
        CalculateButton.TabIndex = 0
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' NumberInputTextbox
        ' 
        NumberInputTextbox.Location = New Point(48, 26)
        NumberInputTextbox.Name = "NumberInputTextbox"
        NumberInputTextbox.Size = New Size(100, 23)
        NumberInputTextbox.TabIndex = 1
        ' 
        ' ResultTextbox
        ' 
        ResultTextbox.Location = New Point(48, 137)
        ResultTextbox.Name = "ResultTextbox"
        ResultTextbox.Size = New Size(100, 23)
        ResultTextbox.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(154, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 3
        Label1.Text = "Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(150, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 4
        Label2.Text = "Result"
        ' 
        ' MathDropdown
        ' 
        MathDropdown.FormattingEnabled = True
        MathDropdown.Items.AddRange(New Object() {"Square", "Square Root", "Factorial"})
        MathDropdown.Location = New Point(252, 29)
        MathDropdown.Name = "MathDropdown"
        MathDropdown.Size = New Size(121, 23)
        MathDropdown.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(405, 184)
        Controls.Add(MathDropdown)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ResultTextbox)
        Controls.Add(NumberInputTextbox)
        Controls.Add(CalculateButton)
        Name = "Form1"
        Text = "Math Operations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents NumberInputTextbox As TextBox
    Friend WithEvents ResultTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MathDropdown As ComboBox
End Class
