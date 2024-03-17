<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        SwapToForm1 = New Button()
        SwapToForm2 = New Button()
        SwapToForm3 = New Button()
        SuspendLayout()
        ' 
        ' SwapToForm1
        ' 
        SwapToForm1.Font = New Font("Consolas", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        SwapToForm1.Location = New Point(78, 42)
        SwapToForm1.Name = "SwapToForm1"
        SwapToForm1.Size = New Size(164, 58)
        SwapToForm1.TabIndex = 0
        SwapToForm1.Text = "Math Operations Q1"
        SwapToForm1.UseVisualStyleBackColor = True
        ' 
        ' SwapToForm2
        ' 
        SwapToForm2.Font = New Font("Consolas", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        SwapToForm2.Location = New Point(78, 137)
        SwapToForm2.Name = "SwapToForm2"
        SwapToForm2.Size = New Size(164, 58)
        SwapToForm2.TabIndex = 1
        SwapToForm2.Text = "Dice Rolling Statistics Q2"
        SwapToForm2.UseVisualStyleBackColor = True
        ' 
        ' SwapToForm3
        ' 
        SwapToForm3.Font = New Font("Consolas", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        SwapToForm3.Location = New Point(78, 232)
        SwapToForm3.Name = "SwapToForm3"
        SwapToForm3.Size = New Size(164, 58)
        SwapToForm3.TabIndex = 2
        SwapToForm3.Text = "String Handling Q3"
        SwapToForm3.UseVisualStyleBackColor = True
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(329, 321)
        Controls.Add(SwapToForm3)
        Controls.Add(SwapToForm2)
        Controls.Add(SwapToForm1)
        Name = "MainMenu"
        Text = "Midterm Main Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SwapToForm1 As Button
    Friend WithEvents SwapToForm2 As Button
    Friend WithEvents SwapToForm3 As Button

End Class
