Public Class Employee
    Public Id As String
    Public LastName As String
    Public FirstName As String
    Public Days As New List(Of Day)

    Public Function CalculateHoursWorked() As Int16
        Dim totalHours As Int16

        For Each day As Day In days
            totalHours += (day.finishHour - day.startHour)
        Next

        Return totalHours
    End Function

    Public Function CalculateGrossPay() As Decimal
        Dim grossPay As Decimal

        grossPay = CalculateHoursWorked() * 9.5

        Return grossPay
    End Function

    Public Function CalculateTax() As Decimal
        Dim tax As Decimal

        tax = CalculateGrossPay() * 0.08

        Return tax
    End Function

    Public Function CalculateNetPay() As Decimal
        Dim netPay As Decimal

        netPay = CalculateGrossPay() - CalculateTax()

        Return netPay
    End Function

End Class