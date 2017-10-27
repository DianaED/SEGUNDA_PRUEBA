Public Class calendario

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        TextBox1.Text = MonthCalendar1.TodayDate

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub
End Class