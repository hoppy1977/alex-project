<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ReadDataButton = New System.Windows.Forms.Button()
        Me.PrintDataButton = New System.Windows.Forms.Button()
        Me.CalculateNetWagesButton = New System.Windows.Forms.Button()
        Me.DisplayPayrollResultsButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'ReadDataButton
        '
        Me.ReadDataButton.Location = New System.Drawing.Point(54, 34)
        Me.ReadDataButton.Name = "ReadDataButton"
        Me.ReadDataButton.Size = New System.Drawing.Size(202, 23)
        Me.ReadDataButton.TabIndex = 0
        Me.ReadDataButton.Text = "i. Read employee data"
        Me.ReadDataButton.UseVisualStyleBackColor = true
        '
        'PrintDataButton
        '
        Me.PrintDataButton.Location = New System.Drawing.Point(54, 63)
        Me.PrintDataButton.Name = "PrintDataButton"
        Me.PrintDataButton.Size = New System.Drawing.Size(202, 23)
        Me.PrintDataButton.TabIndex = 1
        Me.PrintDataButton.Text = "ii. Print employee data"
        Me.PrintDataButton.UseVisualStyleBackColor = true
        '
        'CalculateNetWagesButton
        '
        Me.CalculateNetWagesButton.Location = New System.Drawing.Point(54, 92)
        Me.CalculateNetWagesButton.Name = "CalculateNetWagesButton"
        Me.CalculateNetWagesButton.Size = New System.Drawing.Size(202, 23)
        Me.CalculateNetWagesButton.TabIndex = 2
        Me.CalculateNetWagesButton.Text = "iii. Calculate net wages"
        Me.CalculateNetWagesButton.UseVisualStyleBackColor = true
        '
        'DisplayPayrollResultsButton
        '
        Me.DisplayPayrollResultsButton.Location = New System.Drawing.Point(54, 121)
        Me.DisplayPayrollResultsButton.Name = "DisplayPayrollResultsButton"
        Me.DisplayPayrollResultsButton.Size = New System.Drawing.Size(202, 23)
        Me.DisplayPayrollResultsButton.TabIndex = 3
        Me.DisplayPayrollResultsButton.Text = "iv. Display payroll results"
        Me.DisplayPayrollResultsButton.UseVisualStyleBackColor = true
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(54, 150)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(202, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "v. Exit program"
        Me.ExitButton.UseVisualStyleBackColor = true
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 227)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayPayrollResultsButton)
        Me.Controls.Add(Me.CalculateNetWagesButton)
        Me.Controls.Add(Me.PrintDataButton)
        Me.Controls.Add(Me.ReadDataButton)
        Me.Name = "MainForm"
        Me.Text = "Payroll Generator Application"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents ReadDataButton As Button
    Friend WithEvents PrintDataButton As Button
    Friend WithEvents CalculateNetWagesButton As Button
    Friend WithEvents DisplayPayrollResultsButton As Button
    Friend WithEvents ExitButton As Button
End Class
