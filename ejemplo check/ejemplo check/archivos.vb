Public Class archivos

    


    Private Sub NUEVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        'to save file...'
        Dim res As DialogResult
        Dim fname As String
        SaveFileDialog1.filter = "rich text format|*.rtf|text file|*.text"
        SaveFileDialog1.InitialDirectory = "C:\"
        res = SaveFileDialog1.showDialog()

        If res = Windows.Forms.DialogResult.OK Then
            fname = SaveFileDialog1.FileName
            'to save file'
            'server file metthod used to save file'

            If SaveFileDialog1.filterindex = 1 Then
                'to save a rtf content'
                RichTextBox1.SaveFile(fname)

            Else
                ' to save a plan text'
                RichTextBox1.SaveFile(fname, RichTextBoxStreamType.PlainText)

            End If
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click

    End Sub

    Private Sub ABRIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABRIRToolStripMenuItem.Click
        Dim res As DialogResult
        OpenFileDialog1.Filter = "Rich Text Format| *rtf|Text File|*.txt"

        'default directory'
        OpenFileDialog1.InitialDirectory = "C:\"

        res = OpenFileDialog1.ShowDialog
        If res = Windows.Forms.DialogResult.OK Then
            If OpenFileDialog1 = FilterIndex = 1 Then
                'rft FIle Selected'
                RichTextBox1.LoadFile(OpenFileDialog1.FileName)

            Else
                'text file selected'
                RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)

            End If



        End If
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click

    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim strFind As String
        Dim pos As Integer

        strFind = InputBox("escribe la palabra que desea buscar")
        If strFind = "" Then
            Exit Sub
        End If

        If pos = -1 Then
            MsgBox("la palabra no fue encontrada")
        End If


    End Sub

    Private Sub FUENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FUENTESToolStripMenuItem.Click
        Dim res As DialogResult
        FontDialog1.showcolor = True
        'used to open dialog box '
        res = FontDialog1.showdialog

        If res = Windows.Forms.DialogResult.OK Then
            'to get selected font
            RichTextBox1.SelectionFont = FontDialog1.Font
            'to get selected font
            RichTextBox1.SelectionColor = FontDialog1.Color

        End If


    End Sub

    Private Sub SelectionBackColorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectionBackColorToolStripMenuItem1.Click
        'to change back color of selection content 
        Dim res As DialogResult
        res = ColorDialog1.ShowDialog
        If res = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SelectionBackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub IzquierdaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IzquierdaToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CentroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

    End Sub

    Private Sub DerechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerechaToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right

    End Sub

    Private Sub SangriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SangriaToolStripMenuItem.Click
        RichTextBox1.SelectionIndent = 100

    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 1
    End Sub

    Private Sub ZoomToolStripMenuItem1Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 2
    End Sub
    Private Sub ZoomToolStripMenuItem2Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        RichTextBox1.ZoomFactor = 3
    End Sub


    Private Sub IniciarLIstaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarLIstaToolStripMenuItem.Click

    End Sub

    Private Sub FORMATOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMATOToolStripMenuItem.Click

    End Sub
End Class