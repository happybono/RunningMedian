<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.copyButton1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clearButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.deleteButton1 = New System.Windows.Forms.Button()
        Me.pasteButton = New System.Windows.Forms.Button()
        Me.copyButton2 = New System.Windows.Forms.Button()
        Me.selectAll1 = New System.Windows.Forms.Button()
        Me.selectAll2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sClrButton1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.sClrButton2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(9, 24)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(192, 264)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(15, 24)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(192, 264)
        Me.ListBox2.TabIndex = 1
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.calcButton.Location = New System.Drawing.Point(16, 542)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(440, 54)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.Location = New System.Drawing.Point(216, 17)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(134, 24)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Middle Median"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.Location = New System.Drawing.Point(85, 17)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.Text = "All Median"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(16, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(333, 27)
        Me.TextBox1.TabIndex = 12
        '
        'addButton
        '
        Me.addButton.Enabled = False
        Me.addButton.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.addButton.Location = New System.Drawing.Point(359, 14)
        Me.addButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(100, 28)
        Me.addButton.TabIndex = 13
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'copyButton1
        '
        Me.copyButton1.Enabled = False
        Me.copyButton1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.copyButton1.Location = New System.Drawing.Point(9, 346)
        Me.copyButton1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.copyButton1.Name = "copyButton1"
        Me.copyButton1.Size = New System.Drawing.Size(88, 32)
        Me.copyButton1.TabIndex = 16
        Me.copyButton1.Text = "Copy"
        Me.copyButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 478)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(440, 53)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'clearButton1
        '
        Me.clearButton1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clearButton1.Location = New System.Drawing.Point(9, 312)
        Me.clearButton1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.clearButton1.Name = "clearButton1"
        Me.clearButton1.Size = New System.Drawing.Size(88, 32)
        Me.clearButton1.TabIndex = 18
        Me.clearButton1.Text = "Clear"
        Me.clearButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clearButton2.Location = New System.Drawing.Point(15, 312)
        Me.clearButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(193, 32)
        Me.clearButton2.TabIndex = 19
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'deleteButton1
        '
        Me.deleteButton1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.deleteButton1.Location = New System.Drawing.Point(116, 312)
        Me.deleteButton1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.deleteButton1.Name = "deleteButton1"
        Me.deleteButton1.Size = New System.Drawing.Size(88, 32)
        Me.deleteButton1.TabIndex = 22
        Me.deleteButton1.Text = "Delete"
        Me.deleteButton1.UseVisualStyleBackColor = True
        '
        'pasteButton
        '
        Me.pasteButton.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pasteButton.Location = New System.Drawing.Point(116, 346)
        Me.pasteButton.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.pasteButton.Name = "pasteButton"
        Me.pasteButton.Size = New System.Drawing.Size(88, 32)
        Me.pasteButton.TabIndex = 23
        Me.pasteButton.Text = "Paste"
        Me.pasteButton.UseVisualStyleBackColor = True
        '
        'copyButton2
        '
        Me.copyButton2.Enabled = False
        Me.copyButton2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.copyButton2.Location = New System.Drawing.Point(15, 346)
        Me.copyButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.copyButton2.Name = "copyButton2"
        Me.copyButton2.Size = New System.Drawing.Size(193, 32)
        Me.copyButton2.TabIndex = 20
        Me.copyButton2.Text = "Copy"
        Me.copyButton2.UseVisualStyleBackColor = True
        '
        'selectAll1
        '
        Me.selectAll1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.selectAll1.Location = New System.Drawing.Point(9, 381)
        Me.selectAll1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.selectAll1.Name = "selectAll1"
        Me.selectAll1.Size = New System.Drawing.Size(88, 32)
        Me.selectAll1.TabIndex = 24
        Me.selectAll1.Text = "Select All"
        Me.selectAll1.UseVisualStyleBackColor = True
        '
        'selectAll2
        '
        Me.selectAll2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.selectAll2.Location = New System.Drawing.Point(15, 381)
        Me.selectAll2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.selectAll2.Name = "selectAll2"
        Me.selectAll2.Size = New System.Drawing.Size(88, 32)
        Me.selectAll2.TabIndex = 25
        Me.selectAll2.Text = "Select All"
        Me.selectAll2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sClrButton1)
        Me.GroupBox2.Controls.Add(Me.selectAll1)
        Me.GroupBox2.Controls.Add(Me.pasteButton)
        Me.GroupBox2.Controls.Add(Me.deleteButton1)
        Me.GroupBox2.Controls.Add(Me.clearButton1)
        Me.GroupBox2.Controls.Add(Me.copyButton1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 52)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(212, 421)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Original Data"
        '
        'sClrButton1
        '
        Me.sClrButton1.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sClrButton1.Location = New System.Drawing.Point(116, 381)
        Me.sClrButton1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.sClrButton1.Name = "sClrButton1"
        Me.sClrButton1.Size = New System.Drawing.Size(88, 32)
        Me.sClrButton1.TabIndex = 25
        Me.sClrButton1.Text = "Sel. Clear"
        Me.sClrButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.sClrButton2)
        Me.GroupBox3.Controls.Add(Me.selectAll2)
        Me.GroupBox3.Controls.Add(Me.copyButton2)
        Me.GroupBox3.Controls.Add(Me.clearButton2)
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(236, 52)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(220, 421)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calibrated Data"
        '
        'sClrButton2
        '
        Me.sClrButton2.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sClrButton2.Location = New System.Drawing.Point(119, 381)
        Me.sClrButton2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.sClrButton2.Name = "sClrButton2"
        Me.sClrButton2.Size = New System.Drawing.Size(88, 32)
        Me.sClrButton2.TabIndex = 26
        Me.sClrButton2.Text = "Sel. Clear"
        Me.sClrButton2.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 608)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.calcButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "Running Median"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents calcButton As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents copyButton1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clearButton1 As Button
    Friend WithEvents clearButton2 As Button
    Friend WithEvents deleteButton1 As Button
    Friend WithEvents pasteButton As Button
    Friend WithEvents copyButton2 As Button
    Friend WithEvents selectAll1 As Button
    Friend WithEvents selectAll2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents sClrButton1 As Button
    Friend WithEvents sClrButton2 As Button
End Class
