<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadDataForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(168, 311)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 35)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(49, 67)
        Me.BrowseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(112, 35)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Location = New System.Drawing.Point(49, 110)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.ReadOnly = True
        Me.FileNameTextBox.Size = New System.Drawing.Size(321, 26)
        Me.FileNameTextBox.TabIndex = 2
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(49, 144)
        Me.LoadButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(112, 35)
        Me.LoadButton.TabIndex = 3
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'ReadDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReadDataForm"
        Me.Text = "ReadDataForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents BrowseButton As Button
    Friend WithEvents FileNameTextBox As TextBox
    Friend WithEvents LoadButton As Button
End Class
