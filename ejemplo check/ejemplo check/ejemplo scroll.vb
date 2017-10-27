Public Class ejemplo_scroll

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        borrar.Enabled = True
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label7.Text = HScrollBar1.Value.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HScrollBar1.Minimum = CInt(TextBox1.Text.ToString)
        HScrollBar1.Maximum = CType(TextBox2.Text.ToString, Integer)

    End Sub


    Private Sub ajustar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ajustar.LinkClicked
        link.Text = TextBox3.Text.ToString

    End Sub

    Private Sub link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link.LinkClicked
        System.Diagnostics.Process.Start(TextBox3.Text.ToString)
    End Sub


    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        ListBox1.Items.Insert(0, tbdiasajustes.Text)
    End Sub

    Private Sub ejemplo_scroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = HScrollBar1.Minimum
        TextBox2.Text = HScrollBar1.Maximum
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.Refresh()
    End Sub
End Class