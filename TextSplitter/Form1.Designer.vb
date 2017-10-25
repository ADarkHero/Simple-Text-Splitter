<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sourceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.destinationTextBox = New System.Windows.Forms.TextBox()
        Me.splitButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.splitTextBox = New System.Windows.Forms.TextBox()
        Me.sourceButton = New System.Windows.Forms.Button()
        Me.destinationButton = New System.Windows.Forms.Button()
        Me.keepFirstLine = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'sourceTextBox
        '
        Me.sourceTextBox.Location = New System.Drawing.Point(12, 41)
        Me.sourceTextBox.Name = "sourceTextBox"
        Me.sourceTextBox.Size = New System.Drawing.Size(214, 20)
        Me.sourceTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.TabStop = False
        Me.Button1.Text = "Source File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(12, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 23)
        Me.Button2.TabIndex = 101
        Me.Button2.TabStop = False
        Me.Button2.Text = "Destination Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'destinationTextBox
        '
        Me.destinationTextBox.Location = New System.Drawing.Point(12, 109)
        Me.destinationTextBox.Name = "destinationTextBox"
        Me.destinationTextBox.Size = New System.Drawing.Size(214, 20)
        Me.destinationTextBox.TabIndex = 1
        '
        'splitButton
        '
        Me.splitButton.Location = New System.Drawing.Point(12, 244)
        Me.splitButton.Name = "splitButton"
        Me.splitButton.Size = New System.Drawing.Size(260, 49)
        Me.splitButton.TabIndex = 4
        Me.splitButton.Text = "Split File"
        Me.splitButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(13, 150)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.TabStop = False
        Me.Button4.Text = "Split after X lines"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'splitTextBox
        '
        Me.splitTextBox.Location = New System.Drawing.Point(13, 179)
        Me.splitTextBox.Name = "splitTextBox"
        Me.splitTextBox.Size = New System.Drawing.Size(259, 20)
        Me.splitTextBox.TabIndex = 3
        '
        'sourceButton
        '
        Me.sourceButton.Location = New System.Drawing.Point(233, 41)
        Me.sourceButton.Name = "sourceButton"
        Me.sourceButton.Size = New System.Drawing.Size(39, 20)
        Me.sourceButton.TabIndex = 102
        Me.sourceButton.Text = "...."
        Me.sourceButton.UseVisualStyleBackColor = True
        '
        'destinationButton
        '
        Me.destinationButton.Location = New System.Drawing.Point(233, 109)
        Me.destinationButton.Name = "destinationButton"
        Me.destinationButton.Size = New System.Drawing.Size(39, 20)
        Me.destinationButton.TabIndex = 103
        Me.destinationButton.Text = "...."
        Me.destinationButton.UseVisualStyleBackColor = True
        '
        'keepFirstLine
        '
        Me.keepFirstLine.AutoSize = True
        Me.keepFirstLine.Checked = True
        Me.keepFirstLine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.keepFirstLine.Location = New System.Drawing.Point(13, 221)
        Me.keepFirstLine.Name = "keepFirstLine"
        Me.keepFirstLine.Size = New System.Drawing.Size(89, 17)
        Me.keepFirstLine.TabIndex = 104
        Me.keepFirstLine.Text = "Keep first line"
        Me.keepFirstLine.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 305)
        Me.Controls.Add(Me.keepFirstLine)
        Me.Controls.Add(Me.destinationButton)
        Me.Controls.Add(Me.sourceButton)
        Me.Controls.Add(Me.splitTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.splitButton)
        Me.Controls.Add(Me.destinationTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sourceTextBox)
        Me.Name = "Form1"
        Me.Text = "Simple Text Splitter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sourceTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents destinationTextBox As TextBox
    Friend WithEvents splitButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents splitTextBox As TextBox
    Friend WithEvents sourceButton As Button
    Friend WithEvents destinationButton As Button
    Friend WithEvents keepFirstLine As CheckBox
End Class
