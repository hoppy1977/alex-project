Public Class ReadDataForm
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog() 
        Dim strFileName As String

        fd.Title = "Read data Dialog"
        fd.InitialDirectory = "C:\Temp"
        fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class