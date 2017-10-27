<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejemplo_scroll
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ajustar = New System.Windows.Forms.LinkLabel()
        Me.link = New System.Windows.Forms.LinkLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.agregar = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbdiasajustes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 3
        Me.HScrollBar1.Location = New System.Drawing.Point(25, 94)
        Me.HScrollBar1.Maximum = 15
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(356, 21)
        Me.HScrollBar1.TabIndex = 0
        Me.HScrollBar1.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "horizontal scroll bar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "minimo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "maximo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(426, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "valor"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(573, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(49, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(715, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(49, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "link label"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "list box"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Label7"
        '
        'ajustar
        '
        Me.ajustar.AutoSize = True
        Me.ajustar.Location = New System.Drawing.Point(402, 163)
        Me.ajustar.Name = "ajustar"
        Me.ajustar.Size = New System.Drawing.Size(51, 17)
        Me.ajustar.TabIndex = 10
        Me.ajustar.TabStop = True
        Me.ajustar.Text = "ajustar"
        '
        'link
        '
        Me.link.AutoSize = True
        Me.link.Location = New System.Drawing.Point(585, 162)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(29, 17)
        Me.link.TabIndex = 11
        Me.link.TabStop = True
        Me.link.Text = "link"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado"})
        Me.ListBox1.Location = New System.Drawing.Point(46, 316)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(31, 218)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(268, 22)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "http://:www.uaca.ac.cr"
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(677, 304)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(119, 23)
        Me.agregar.TabIndex = 14
        Me.agregar.Text = "agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(677, 348)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(119, 23)
        Me.borrar.TabIndex = 15
        Me.borrar.Text = "borrar"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(813, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "ajustar SB"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tbdiasajustes
        '
        Me.tbdiasajustes.Location = New System.Drawing.Point(290, 316)
        Me.tbdiasajustes.Name = "tbdiasajustes"
        Me.tbdiasajustes.Size = New System.Drawing.Size(232, 22)
        Me.tbdiasajustes.TabIndex = 17
        '
        'ejemplo_scroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 439)
        Me.Controls.Add(Me.tbdiasajustes)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.ajustar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Name = "ejemplo_scroll"
        Me.Text = "ejemplo_scroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ajustar As System.Windows.Forms.LinkLabel
    Friend WithEvents link As System.Windows.Forms.LinkLabel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tbdiasajustes As System.Windows.Forms.TextBox
End Class
