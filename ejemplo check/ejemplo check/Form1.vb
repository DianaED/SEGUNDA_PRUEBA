Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckedListBox1.Items.Remove(CheckedListBox1.Text)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        Dim amarilla As Boolean = CheckBox1.Checked
        Dim verde As Boolean = CheckBox2.Checked
        Dim rojo As Boolean = CheckBox3.Checked
        Dim negro As Boolean = CheckBox4.Checked

        If amarilla Then
            MsgBox("tu color favorito es amarillo")
        End If

        If verde Then
            MsgBox("tu color favorito es verde")
        End If

        If rojo Then
            MsgBox("tu color favorito es rojo")
        End If

        If negro Then
            MsgBox("tu color favorito es negro")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        PictureBox1.BackColor = Me.ColorDialog1.Color

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckedListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
End Class
