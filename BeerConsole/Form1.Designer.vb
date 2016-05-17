<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeerConsoleForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeerConsoleForm))
        Me.NoBeerLabel = New System.Windows.Forms.Label()
        Me.BeerLabel = New System.Windows.Forms.Label()
        Me.BeerIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BeerIconMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeerButton = New System.Windows.Forms.Button()
        Me.NoBeerButton = New System.Windows.Forms.Button()
        Me.NoBeerBox = New System.Windows.Forms.RichTextBox()
        Me.BeerBox = New System.Windows.Forms.RichTextBox()
        Me.BeerIconMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoBeerLabel
        '
        Me.NoBeerLabel.AutoSize = True
        Me.NoBeerLabel.Location = New System.Drawing.Point(20, 11)
        Me.NoBeerLabel.Name = "NoBeerLabel"
        Me.NoBeerLabel.Size = New System.Drawing.Size(49, 13)
        Me.NoBeerLabel.TabIndex = 2
        Me.NoBeerLabel.Text = "No Beer:"
        '
        'BeerLabel
        '
        Me.BeerLabel.AutoSize = True
        Me.BeerLabel.Location = New System.Drawing.Point(20, 294)
        Me.BeerLabel.Name = "BeerLabel"
        Me.BeerLabel.Size = New System.Drawing.Size(32, 13)
        Me.BeerLabel.TabIndex = 3
        Me.BeerLabel.Text = "Beer:"
        '
        'BeerIcon
        '
        Me.BeerIcon.ContextMenuStrip = Me.BeerIconMenu
        Me.BeerIcon.Icon = CType(resources.GetObject("BeerIcon.Icon"), System.Drawing.Icon)
        Me.BeerIcon.Text = "Beer2Beer is running fine! *burp*"
        Me.BeerIcon.Visible = True
        '
        'BeerIconMenu
        '
        Me.BeerIconMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.BeerIconMenu.Name = "BeerIconMenu"
        Me.BeerIconMenu.Size = New System.Drawing.Size(153, 76)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BeerButton
        '
        Me.BeerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BeerButton.Location = New System.Drawing.Point(23, 556)
        Me.BeerButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BeerButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BeerButton.Name = "BeerButton"
        Me.BeerButton.Size = New System.Drawing.Size(75, 23)
        Me.BeerButton.TabIndex = 4
        Me.BeerButton.Text = "Beer!"
        Me.BeerButton.UseVisualStyleBackColor = True
        '
        'NoBeerButton
        '
        Me.NoBeerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoBeerButton.Location = New System.Drawing.Point(104, 556)
        Me.NoBeerButton.MaximumSize = New System.Drawing.Size(75, 23)
        Me.NoBeerButton.MinimumSize = New System.Drawing.Size(75, 23)
        Me.NoBeerButton.Name = "NoBeerButton"
        Me.NoBeerButton.Size = New System.Drawing.Size(75, 23)
        Me.NoBeerButton.TabIndex = 5
        Me.NoBeerButton.Text = "No Beer..."
        Me.NoBeerButton.UseVisualStyleBackColor = True
        '
        'NoBeerBox
        '
        Me.NoBeerBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoBeerBox.Location = New System.Drawing.Point(23, 27)
        Me.NoBeerBox.MaxLength = 13370
        Me.NoBeerBox.MinimumSize = New System.Drawing.Size(608, 240)
        Me.NoBeerBox.Name = "NoBeerBox"
        Me.NoBeerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.NoBeerBox.Size = New System.Drawing.Size(608, 240)
        Me.NoBeerBox.TabIndex = 6
        Me.NoBeerBox.Text = ""
        '
        'BeerBox
        '
        Me.BeerBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BeerBox.Location = New System.Drawing.Point(23, 310)
        Me.BeerBox.MaxLength = 13370
        Me.BeerBox.MinimumSize = New System.Drawing.Size(608, 240)
        Me.BeerBox.Name = "BeerBox"
        Me.BeerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.BeerBox.Size = New System.Drawing.Size(608, 240)
        Me.BeerBox.TabIndex = 7
        Me.BeerBox.Text = ""
        '
        'BeerConsoleForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(641, 588)
        Me.Controls.Add(Me.BeerBox)
        Me.Controls.Add(Me.NoBeerBox)
        Me.Controls.Add(Me.NoBeerButton)
        Me.Controls.Add(Me.BeerButton)
        Me.Controls.Add(Me.BeerLabel)
        Me.Controls.Add(Me.NoBeerLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1337, 627)
        Me.MinimumSize = New System.Drawing.Size(657, 627)
        Me.Name = "BeerConsoleForm"
        Me.Text = "Beer2Beer"
        Me.BeerIconMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoBeerLabel As System.Windows.Forms.Label
    Friend WithEvents BeerLabel As System.Windows.Forms.Label
    Friend WithEvents BeerIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents BeerButton As System.Windows.Forms.Button
    Friend WithEvents NoBeerButton As System.Windows.Forms.Button
    Friend WithEvents NoBeerBox As System.Windows.Forms.RichTextBox
    Friend WithEvents BeerBox As System.Windows.Forms.RichTextBox
    Friend WithEvents BeerIconMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
