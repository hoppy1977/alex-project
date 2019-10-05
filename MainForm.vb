Public Class MainForm

    Dim _employees As New List(Of Employee)

    Private Sub ReadDataButton_Click(sender As Object, e As EventArgs) Handles ReadDataButton.Click
        Dim form = New ReadDataForm(_employees)
        form.Show()
    End Sub

    Private Sub PrintDataButton_Click(sender As Object, e As EventArgs) Handles PrintDataButton.Click

    End Sub

    Private Sub CalculateNetWagesButton_Click(sender As Object, e As EventArgs) Handles CalculateNetWagesButton.Click

    End Sub

    Private Sub DisplayPayrollResultsButton_Click(sender As Object, e As EventArgs) Handles DisplayPayrollResultsButton.Click

        Dim messageText As String

        For Each employee As Employee In _employees
            messageText += employee.Id & vbTab &
                employee.LastName & vbTab &
                employee.FirstName & vbTab &
                employee.CalculateHoursWorked() & vbTab &
                employee.CalculateGrossPay() & vbTab &
                employee.CalculateNetPay() &
                Environment.NewLine
        Next

        MessageBox.Show(messageText)

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
