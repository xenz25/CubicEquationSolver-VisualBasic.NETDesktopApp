<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_clearhistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox_history = New System.Windows.Forms.ListBox()
        Me.Label_history = New System.Windows.Forms.Label()
        Me.Button_save_history = New System.Windows.Forms.Button()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_copyhis = New System.Windows.Forms.Button()
        Me.StatusStrip1_description = New System.Windows.Forms.StatusStrip()
        Me.Status_description = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1_description.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button_clearhistory)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 91)
        Me.Panel1.TabIndex = 31
        '
        'Button_clearhistory
        '
        Me.Button_clearhistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_clearhistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_clearhistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_clearhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_clearhistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_clearhistory.Location = New System.Drawing.Point(727, 12)
        Me.Button_clearhistory.Name = "Button_clearhistory"
        Me.Button_clearhistory.Size = New System.Drawing.Size(90, 35)
        Me.Button_clearhistory.TabIndex = 39
        Me.Button_clearhistory.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Button_clearhistory, "Clear history data.")
        Me.Button_clearhistory.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cubic Equation Solver"
        Me.ToolTip1.SetToolTip(Me.Label1, "Cubic Equation Solver created by XE")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(374, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ax^3 + bx^2 + cx + d = 0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(125, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "cubic equation format:"
        '
        'ListBox_history
        '
        Me.ListBox_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_history.FormattingEnabled = True
        Me.ListBox_history.ItemHeight = 20
        Me.ListBox_history.Location = New System.Drawing.Point(12, 161)
        Me.ListBox_history.Name = "ListBox_history"
        Me.ListBox_history.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox_history.Size = New System.Drawing.Size(831, 344)
        Me.ListBox_history.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.ListBox_history, "History display area.")
        '
        'Label_history
        '
        Me.Label_history.AutoSize = True
        Me.Label_history.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_history.Location = New System.Drawing.Point(12, 120)
        Me.Label_history.Name = "Label_history"
        Me.Label_history.Size = New System.Drawing.Size(79, 25)
        Me.Label_history.TabIndex = 13
        Me.Label_history.Text = "History"
        Me.ToolTip1.SetToolTip(Me.Label_history, "History of calculations.")
        '
        'Button_save_history
        '
        Me.Button_save_history.BackColor = System.Drawing.Color.Lime
        Me.Button_save_history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_save_history.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_save_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_save_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_save_history.Location = New System.Drawing.Point(727, 117)
        Me.Button_save_history.Name = "Button_save_history"
        Me.Button_save_history.Size = New System.Drawing.Size(116, 35)
        Me.Button_save_history.TabIndex = 37
        Me.Button_save_history.Text = "Save History"
        Me.ToolTip1.SetToolTip(Me.Button_save_history, "Save history into a single file.")
        Me.Button_save_history.UseVisualStyleBackColor = False
        '
        'Button_copyhis
        '
        Me.Button_copyhis.BackColor = System.Drawing.Color.SkyBlue
        Me.Button_copyhis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_copyhis.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_copyhis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_copyhis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_copyhis.Location = New System.Drawing.Point(591, 117)
        Me.Button_copyhis.Name = "Button_copyhis"
        Me.Button_copyhis.Size = New System.Drawing.Size(116, 35)
        Me.Button_copyhis.TabIndex = 38
        Me.Button_copyhis.Text = "Copy History"
        Me.ToolTip1.SetToolTip(Me.Button_copyhis, "Copy entire history content.")
        Me.Button_copyhis.UseVisualStyleBackColor = False
        '
        'StatusStrip1_description
        '
        Me.StatusStrip1_description.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusStrip1_description.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1_description.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status_description})
        Me.StatusStrip1_description.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1_description.Name = "StatusStrip1_description"
        Me.StatusStrip1_description.Size = New System.Drawing.Size(855, 26)
        Me.StatusStrip1_description.TabIndex = 40
        Me.StatusStrip1_description.Text = "StatusStrip1"
        '
        'Status_description
        '
        Me.Status_description.ForeColor = System.Drawing.Color.Navy
        Me.Status_description.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Status_description.Name = "Status_description"
        Me.Status_description.Size = New System.Drawing.Size(58, 20)
        Me.Status_description.Text = "Details:"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 542)
        Me.Controls.Add(Me.StatusStrip1_description)
        Me.Controls.Add(Me.Button_copyhis)
        Me.Controls.Add(Me.Button_save_history)
        Me.Controls.Add(Me.Label_history)
        Me.Controls.Add(Me.ListBox_history)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(873, 589)
        Me.MinimumSize = New System.Drawing.Size(873, 589)
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1_description.ResumeLayout(False)
        Me.StatusStrip1_description.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label_history As Label
    Friend WithEvents Button_save_history As Button
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button_clearhistory As Button
    Public WithEvents ListBox_history As ListBox
    Friend WithEvents Button_copyhis As Button
    Friend WithEvents StatusStrip1_description As StatusStrip
    Friend WithEvents Status_description As ToolStripStatusLabel
End Class
