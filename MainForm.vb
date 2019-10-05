Public Class MainForm
    Private Sub ReadDataButton_Click(sender As Object, e As EventArgs) Handles ReadDataButton.Click
        Dim form = New ReadDataForm()
        form.Show()
    End Sub

    Private Sub PrintDataButton_Click(sender As Object, e As EventArgs) Handles PrintDataButton.Click

    End Sub

    Private Sub CalculateNetWagesButton_Click(sender As Object, e As EventArgs) Handles CalculateNetWagesButton.Click

    End Sub

    Private Sub DisplayPayrollResultsButton_Click(sender As Object, e As EventArgs) Handles DisplayPayrollResultsButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
