<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1_method = New System.Windows.Forms.StatusStrip()
        Me.Status_Action = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.TextBox_C = New System.Windows.Forms.TextBox()
        Me.TextBox_D = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_x3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_x2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_x1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button_show_solution = New System.Windows.Forms.Button()
        Me.Button_copy = New System.Windows.Forms.Button()
        Me.Button_save = New System.Windows.Forms.Button()
        Me.Button_calculate = New System.Windows.Forms.Button()
        Me.Label1_method = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label_precision = New System.Windows.Forms.Label()
        Me.Label_example = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button_clear = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1_method.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1_method
        '
        Me.StatusStrip1_method.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusStrip1_method.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1_method.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status_Action})
        Me.StatusStrip1_method.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1_method.Name = "StatusStrip1_method"
        Me.StatusStrip1_method.Size = New System.Drawing.Size(855, 26)
        Me.StatusStrip1_method.TabIndex = 0
        Me.StatusStrip1_method.Text = "StatusStrip1"
        '
        'Status_Action
        '
        Me.Status_Action.ForeColor = System.Drawing.Color.Navy
        Me.Status_Action.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Status_Action.Name = "Status_Action"
        Me.Status_Action.Size = New System.Drawing.Size(123, 20)
        Me.Status_Action.Text = "Actions: waiting..."
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
        'TextBox_A
        '
        Me.TextBox_A.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_A.Location = New System.Drawing.Point(88, 207)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_A.TabIndex = 2
        Me.TextBox_A.Text = "1"
        '
        'TextBox_B
        '
        Me.TextBox_B.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_B.Location = New System.Drawing.Point(88, 250)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(186, 22)
        Me.TextBox_B.TabIndex = 3
        Me.TextBox_B.Text = "2"
        '
        'TextBox_C
        '
        Me.TextBox_C.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_C.Location = New System.Drawing.Point(87, 289)
        Me.TextBox_C.Name = "TextBox_C"
        Me.TextBox_C.Size = New System.Drawing.Size(187, 22)
        Me.TextBox_C.TabIndex = 4
        Me.TextBox_C.Text = "10"
        '
        'TextBox_D
        '
        Me.TextBox_D.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_D.Location = New System.Drawing.Point(88, 330)
        Me.TextBox_D.Name = "TextBox_D"
        Me.TextBox_D.Size = New System.Drawing.Size(186, 22)
        Me.TextBox_D.TabIndex = 5
        Me.TextBox_D.Text = "-20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Values"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "a ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "b ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "d ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "c ="
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(454, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Roots"
        '
        'TextBox_x3
        '
        Me.TextBox_x3.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_x3.Location = New System.Drawing.Point(536, 288)
        Me.TextBox_x3.Name = "TextBox_x3"
        Me.TextBox_x3.ReadOnly = True
        Me.TextBox_x3.Size = New System.Drawing.Size(289, 22)
        Me.TextBox_x3.TabIndex = 17
        Me.TextBox_x3.Text = " x3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(485, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 21)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "x1 ="
        '
        'TextBox_x2
        '
        Me.TextBox_x2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_x2.Location = New System.Drawing.Point(536, 249)
        Me.TextBox_x2.Name = "TextBox_x2"
        Me.TextBox_x2.ReadOnly = True
        Me.TextBox_x2.Size = New System.Drawing.Size(289, 22)
        Me.TextBox_x2.TabIndex = 16
        Me.TextBox_x2.Text = " x2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(485, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 21)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "x2 ="
        '
        'TextBox_x1
        '
        Me.TextBox_x1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox_x1.Location = New System.Drawing.Point(536, 206)
        Me.TextBox_x1.Name = "TextBox_x1"
        Me.TextBox_x1.ReadOnly = True
        Me.TextBox_x1.Size = New System.Drawing.Size(289, 22)
        Me.TextBox_x1.TabIndex = 15
        Me.TextBox_x1.Text = " x1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(485, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "x3 ="
        '
        'Button_show_solution
        '
        Me.Button_show_solution.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_show_solution.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_show_solution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_show_solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_show_solution.ForeColor = System.Drawing.Color.White
        Me.Button_show_solution.Location = New System.Drawing.Point(713, 453)
        Me.Button_show_solution.Name = "Button_show_solution"
        Me.Button_show_solution.Size = New System.Drawing.Size(112, 35)
        Me.Button_show_solution.TabIndex = 24
        Me.Button_show_solution.Text = "Show History"
        Me.Button_show_solution.UseVisualStyleBackColor = False
        '
        'Button_copy
        '
        Me.Button_copy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_copy.Location = New System.Drawing.Point(536, 330)
        Me.Button_copy.Name = "Button_copy"
        Me.Button_copy.Size = New System.Drawing.Size(114, 31)
        Me.Button_copy.TabIndex = 25
        Me.Button_copy.Text = "Copy Output"
        Me.ToolTip1.SetToolTip(Me.Button_copy, "Copy Inputs and Outputs.")
        Me.Button_copy.UseVisualStyleBackColor = True
        '
        'Button_save
        '
        Me.Button_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_save.Location = New System.Drawing.Point(715, 330)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.Size = New System.Drawing.Size(110, 31)
        Me.Button_save.TabIndex = 26
        Me.Button_save.Text = "Save Output"
        Me.ToolTip1.SetToolTip(Me.Button_save, "Save current calculation.")
        Me.Button_save.UseVisualStyleBackColor = True
        '
        'Button_calculate
        '
        Me.Button_calculate.BackColor = System.Drawing.Color.Lime
        Me.Button_calculate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_calculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_calculate.Location = New System.Drawing.Point(188, 382)
        Me.Button_calculate.Name = "Button_calculate"
        Me.Button_calculate.Size = New System.Drawing.Size(87, 35)
        Me.Button_calculate.TabIndex = 27
        Me.Button_calculate.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.Button_calculate, "Calculate given input.")
        Me.Button_calculate.UseVisualStyleBackColor = False
        '
        'Label1_method
        '
        Me.Label1_method.AutoSize = True
        Me.Label1_method.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1_method.ForeColor = System.Drawing.Color.Green
        Me.Label1_method.Location = New System.Drawing.Point(216, 461)
        Me.Label1_method.Name = "Label1_method"
        Me.Label1_method.Size = New System.Drawing.Size(40, 18)
        Me.Label1_method.TabIndex = 29
        Me.Label1_method.Text = "----"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(26, 461)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Function Attribute:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 91)
        Me.Panel1.TabIndex = 30
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Upto 3 decimal place", "Upto 4 decimal place", "Upto 9 decimal place"})
        Me.ComboBox1.Location = New System.Drawing.Point(575, 122)
        Me.ComboBox1.MaximumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox1.MinimumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox1.TabIndex = 31
        Me.ComboBox1.Text = "Upto 9 decimal place"
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Set number of Decimal Places. Default is 9.")
        '
        'Label_precision
        '
        Me.Label_precision.AutoSize = True
        Me.Label_precision.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_precision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_precision.Location = New System.Drawing.Point(435, 125)
        Me.Label_precision.Name = "Label_precision"
        Me.Label_precision.Size = New System.Drawing.Size(99, 20)
        Me.Label_precision.TabIndex = 32
        Me.Label_precision.Text = "Precision:"
        '
        'Label_example
        '
        Me.Label_example.AutoSize = True
        Me.Label_example.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_example.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_example.Location = New System.Drawing.Point(12, 126)
        Me.Label_example.Name = "Label_example"
        Me.Label_example.Size = New System.Drawing.Size(108, 20)
        Me.Label_example.TabIndex = 34
        Me.Label_example.Text = "Example of:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All 3 roots are Real", "Only 1 root is Real 2 are Imaginary", "All 3 roots are Real and Equal"})
        Me.ComboBox2.Location = New System.Drawing.Point(142, 122)
        Me.ComboBox2.MaximumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox2.MinimumSize = New System.Drawing.Size(250, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(250, 24)
        Me.ComboBox2.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Select examples.")
        '
        'Button_clear
        '
        Me.Button_clear.BackColor = System.Drawing.Color.Maroon
        Me.Button_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_clear.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_clear.ForeColor = System.Drawing.Color.White
        Me.Button_clear.Location = New System.Drawing.Point(50, 382)
        Me.Button_clear.Name = "Button_clear"
        Me.Button_clear.Size = New System.Drawing.Size(63, 35)
        Me.Button_clear.TabIndex = 35
        Me.Button_clear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.Button_clear, "Clear all Inputs and Outputs")
        Me.Button_clear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(855, 542)
        Me.Controls.Add(Me.Button_clear)
        Me.Controls.Add(Me.Label_example)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label_precision)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1_method)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button_calculate)
        Me.Controls.Add(Me.Button_save)
        Me.Controls.Add(Me.Button_copy)
        Me.Controls.Add(Me.Button_show_solution)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox_x3)
        Me.Controls.Add(Me.TextBox_x2)
        Me.Controls.Add(Me.TextBox_x1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_D)
        Me.Controls.Add(Me.TextBox_C)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.StatusStrip1_method)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(873, 589)
        Me.MinimumSize = New System.Drawing.Size(873, 589)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cubic Equation Solver v1.0.0.0 Catacutan Zian Jolo"
        Me.StatusStrip1_method.ResumeLayout(False)
        Me.StatusStrip1_method.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1_method As StatusStrip
    Friend WithEvents Status_Action As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents TextBox_C As TextBox
    Friend WithEvents TextBox_D As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_x3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_x2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_x1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_show_solution As Button
    Friend WithEvents Button_copy As Button
    Friend WithEvents Button_save As Button
    Friend WithEvents Button_calculate As Button
    Friend WithEvents Label1_method As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label_precision As Label
    Friend WithEvents Label_example As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button_clear As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
