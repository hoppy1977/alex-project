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
        Me.SuspendLayout
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(112, 202)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = true
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(81, 47)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = true
        '
        'ReadDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "ReadDataForm"
        Me.Text = "ReadDataForm"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents BrowseButton As Button
End Class
