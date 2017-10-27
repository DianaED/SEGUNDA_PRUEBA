<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class archivos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABRIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FUENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionBackColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlineacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IzquierdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SangriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarLIstaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.EDITARToolStripMenuItem, Me.FORMATOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 48)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem, Me.ABRIRToolStripMenuItem, Me.CERRARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.ARCHIVOToolStripMenuItem.Text = "ARCHIVO"
        '
        'NUEVOToolStripMenuItem
        '
        Me.NUEVOToolStripMenuItem.Name = "NUEVOToolStripMenuItem"
        Me.NUEVOToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.NUEVOToolStripMenuItem.Text = "NUEVO"
        '
        'ABRIRToolStripMenuItem
        '
        Me.ABRIRToolStripMenuItem.Name = "ABRIRToolStripMenuItem"
        Me.ABRIRToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ABRIRToolStripMenuItem.Text = "ABRIR"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CERRARToolStripMenuItem.Text = "GUARDAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'EDITARToolStripMenuItem
        '
        Me.EDITARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.ToolStripSeparator1, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ToolStripSeparator2, Me.SeleccionarTodoToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.EDITARToolStripMenuItem.Name = "EDITARToolStripMenuItem"
        Me.EDITARToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.EDITARToolStripMenuItem.Text = "EDITAR"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CortarToolStripMenuItem.Text = "cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.PegarToolStripMenuItem.Text = "pegar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CopiarToolStripMenuItem.Text = "copiar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'SeleccionarTodoToolStripMenuItem
        '
        Me.SeleccionarTodoToolStripMenuItem.Name = "SeleccionarTodoToolStripMenuItem"
        Me.SeleccionarTodoToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.SeleccionarTodoToolStripMenuItem.Text = "seleccionar todo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.BuscarToolStripMenuItem.Text = "buscar"
        '
        'FORMATOToolStripMenuItem
        '
        Me.FORMATOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FUENTESToolStripMenuItem, Me.SelectionBackColorToolStripMenuItem1, Me.AlineacionToolStripMenuItem, Me.SangriaToolStripMenuItem, Me.ZoomToolStripMenuItem, Me.IniciarLIstaToolStripMenuItem})
        Me.FORMATOToolStripMenuItem.Name = "FORMATOToolStripMenuItem"
        Me.FORMATOToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.FORMATOToolStripMenuItem.Text = "FORMATO"
        '
        'FUENTESToolStripMenuItem
        '
        Me.FUENTESToolStripMenuItem.Name = "FUENTESToolStripMenuItem"
        Me.FUENTESToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.FUENTESToolStripMenuItem.Text = "FUENTES"
        '
        'SelectionBackColorToolStripMenuItem1
        '
        Me.SelectionBackColorToolStripMenuItem1.Name = "SelectionBackColorToolStripMenuItem1"
        Me.SelectionBackColorToolStripMenuItem1.Size = New System.Drawing.Size(220, 26)
        Me.SelectionBackColorToolStripMenuItem1.Text = "Selection Back Color"
        '
        'AlineacionToolStripMenuItem
        '
        Me.AlineacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IzquierdaToolStripMenuItem, Me.CentroToolStripMenuItem, Me.DerechaToolStripMenuItem})
        Me.AlineacionToolStripMenuItem.Name = "AlineacionToolStripMenuItem"
        Me.AlineacionToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.AlineacionToolStripMenuItem.Text = "Alineacion"
        '
        'IzquierdaToolStripMenuItem
        '
        Me.IzquierdaToolStripMenuItem.Name = "IzquierdaToolStripMenuItem"
        Me.IzquierdaToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.IzquierdaToolStripMenuItem.Text = "izquierda"
        '
        'CentroToolStripMenuItem
        '
        Me.CentroToolStripMenuItem.Name = "CentroToolStripMenuItem"
        Me.CentroToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.CentroToolStripMenuItem.Text = "centro "
        '
        'DerechaToolStripMenuItem
        '
        Me.DerechaToolStripMenuItem.Name = "DerechaToolStripMenuItem"
        Me.DerechaToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.DerechaToolStripMenuItem.Text = "derecha"
        '
        'SangriaToolStripMenuItem
        '
        Me.SangriaToolStripMenuItem.Name = "SangriaToolStripMenuItem"
        Me.SangriaToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.SangriaToolStripMenuItem.Text = "Sangria"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'IniciarLIstaToolStripMenuItem
        '
        Me.IniciarLIstaToolStripMenuItem.Name = "IniciarLIstaToolStripMenuItem"
        Me.IniciarLIstaToolStripMenuItem.Size = New System.Drawing.Size(220, 26)
        Me.IniciarLIstaToolStripMenuItem.Text = "Iniciar LIsta"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip4.TabIndex = 3
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(101, 151)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(616, 233)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'archivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 482)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip4)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "archivos"
        Me.Text = "archivos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABRIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORMATOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip4 As System.Windows.Forms.MenuStrip
    Friend WithEvents FUENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectionBackColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlineacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SangriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarLIstaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeleccionarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents IzquierdaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DerechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
