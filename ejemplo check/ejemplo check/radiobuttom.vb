Public Class radiobuttom

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = True) Then
            ProgressBar1.Value = 10

        ElseIf (RadioButton2.Checked = 25 = True) Then
            ProgressBar1.Value = 25

        ElseIf (RadioButton3.Checked = 50 = True) Then
            ProgressBar1.Value = 50

        ElseIf (RadioButton4.Checked = 75) Then
            ProgressBar1.Value = 75

        End If
    End Sub
End Class