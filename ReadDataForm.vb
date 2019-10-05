Public Class ReadDataForm

    Dim _employees As List(Of Employee)
    Public Sub New(ByRef employees As List(Of Employee))
        InitializeComponent()
        _employees = employees
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Read data Dialog"
        fd.InitialDirectory = "C:\Dropbox\Temp\Alex"
        fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            FileNameTextBox.Text = strFileName
        End If

    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click

        Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser(FileNameTextBox.Text)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(" ")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim id = currentRow.ElementAt(0)
                    Dim lastName = currentRow.ElementAt(1)
                    Dim firstName = currentRow.ElementAt(2)
                    Dim startHour = currentRow.ElementAt(3)
                    Dim finishHour = currentRow.ElementAt(4)

                    Dim currentDay = New Day
                    currentDay.startHour = startHour
                    currentDay.finishHour = finishHour

                    Dim currentEmployeeIndex = _employees.FindIndex(Function(p) p.id = id)
                    If (currentEmployeeIndex = -1) Then
                        Dim newEmployee As New Employee
                        newEmployee.id = id
                        newEmployee.firstName = firstName
                        newEmployee.lastName = lastName
                        newEmployee.days.Add(currentDay)
                        _employees.Add(newEmployee)
                    Else
                        Dim currentEmployee = _employees.ElementAt(currentEmployeeIndex)
                        currentEmployee.days.Add(currentDay)
                    End If

                Catch ex As Microsoft.VisualBasic.
                    FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using


    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

End Class