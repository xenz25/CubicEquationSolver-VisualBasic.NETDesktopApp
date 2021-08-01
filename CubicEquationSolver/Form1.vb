Imports Microsoft.Office.Interop.Word


Public Class Form1
    Dim tbx_list As New List(Of TextBox)
    Dim decimal_precision As Integer = 9
    Dim program_started As Boolean = False
    Dim computed_from_combox As Boolean = False
    Dim saved_text As String = ""
    Dim inserted_equation As String = ""
    Dim method_description As String = "" 'for tool tip
    Public calculation_count As Integer = 0
    Dim history_object As New History
    Public history_toggle As Integer = 0
    Dim prev As String = "Upto 9 decimal place"
    Public number_of_calculation As Integer = 0
    Dim logger_file_name_main As String = ""

    Class GeneralComputations 'only for value of f g and h
        Public f, g, h As Double
        Public A, B, C, D As Double
        Public FGH_LIST As List(Of Double) = New List(Of Double)
        Public ABCD_LIST As List(Of Double) = New List(Of Double)

        Public Sub GetNumericalCoefficiets(ByVal A_in As Double, ByVal B_in As Double, ByVal C_in As Double, ByVal D_in As Double)
            A = A_in
            B = B_in
            C = C_in
            D = D_in
        End Sub

        Private Sub Compute_f()
            'formula f = ((3c/a)-(b^2/a^2))/3
            f = ((3 * C / A) - (B ^ 2 / A ^ 2)) / 3
            'MessageBox.Show(f)
        End Sub

        Private Sub Compute_g()
            'formula g = ((2b^3/a^3)-(9bc/a^2)+(27d/a))27
            g = ((2 * B ^ 3 / A ^ 3) - (9 * B * C / A ^ 2) + (27 * D / A)) / 27
            'MessageBox.Show(g)
        End Sub

        Private Sub Compute_h()
            'formula h = (g^2/4)+(f^3/27)
            h = (g ^ 2 / 4) + (f ^ 3 / 27)
            'MessageBox.Show(h)
        End Sub

        Public Sub ExecuteComputations()
            Compute_f()
            Compute_g()
            Compute_h()
        End Sub

        Public Function GetFGH()
            FGH_LIST.Add(f)
            FGH_LIST.Add(g)
            FGH_LIST.Add(h)
            Return FGH_LIST 'RETURNS A LIST
        End Function

        Public Function GetABCD()
            ABCD_LIST.Add(A)
            ABCD_LIST.Add(B)
            ABCD_LIST.Add(C)
            ABCD_LIST.Add(D)
            Return ABCD_LIST 'RETURNS A LIST
        End Function
    End Class

    Class MethodComputations
        Public MethodUse As String = Nothing
        Private f, g, h As Double
        Private A, B, C, D As Double
        Public answers As List(Of Double)
        Public answers2 As List(Of String)

        Public Sub Get_FGH_ABCD(ByVal FGH_list As List(Of Double), ByVal ABCD_list As List(Of Double))
            f = FGH_list(0)
            g = FGH_list(1)
            h = FGH_list(2)
            'MessageBox.Show(f)
            'MessageBox.Show(g)
            'MessageBox.Show(h)
            'My.Computer.Clipboard.SetText(f & " " & g & " " & h)
            A = ABCD_list(0)
            B = ABCD_list(1)
            C = ABCD_list(2)
            D = ABCD_list(3)
        End Sub
        Private Sub AssignMethod()
            If h > 0 Then
                MethodUse = "METHOD_1" 'ONE REAL ROOT OTHERS AR IMAGINARY
            ElseIf f = 0 And g = 0 And h = 0 Then 'SPECIAL CASE ALL ROOTS ARE REAL AD EQUAL
                MethodUse = "METHOD_2"
            ElseIf h <= 0 Then 'ALL ROOTS ARE REAL
                MethodUse = "METHOD_3"
            End If
        End Sub

        Public Function GetMethod()
            Return MethodUse
        End Function

        Private Function METHOD_1()
            Dim R, S, T, U
            Dim x1 As Double
            Dim x2, x3 As String
            Dim root_list As List(Of String) = New List(Of String)
            Dim REAL As Double
            Dim IMAG As Double

            'formula R = -(g/2) + (h)^1/2
            R = -(g / 2) + Math.Sqrt(h)
            'MessageBox.Show(R)
            'formula S = (R)^1/3
            If R < 0 Then
                R = Math.Abs(R)
                S = ((R) ^ (1 / 3)) * -1
            Else
                S = ((R) ^ (1 / 3))
            End If
            'S = ((R) ^ (1 / 3)) * -1
            'MessageBox.Show(S)
            'formula T = -(g/2) - (h)^1/2
            T = (-(g / 2)) - Math.Sqrt(h)
            'MessageBox.Show(T)
            'formula U = (T)^1/3
            If T < 0 Then
                T = Math.Abs(T)
                U = (T) ^ (1 / 3) * -1
            Else
                U = (T) ^ (1 / 3)
            End If

            'MessageBox.Show(U)

            'formula x1 = (S + U) - (b/3a)
            x1 = Math.Round((S + U) - (B / (3 * A)), Form1.decimal_precision)
            'My.Computer.Clipboard.SetText(S & " " & U & " " & B & " " & A)
            'MessageBox.Show(x1)
            'formula x2= -(S + U)/2 - (b/3a) + (i*(S-U)*(3)^1/2)/2

            REAL = Math.Round(-((S + U) / 2) - (B / (3 * A)), Form1.decimal_precision)
            'MessageBox.Show(REAL)
            IMAG = Math.Round(((S - U) * (Math.Sqrt(3))) / 2, Form1.decimal_precision)
            x2 = String.Format("{0} + {1}i", REAL, IMAG) 'combining the REAL and IMAGINARY part
            'MessageBox.Show(x2)
            'formula x2= -(S + U)/2 - (b/3a) - (i*(S-U)*(3)^1/2)/2

            REAL = Math.Round(-((S + U) / 2) - (B / (3 * A)), Form1.decimal_precision)
            IMAG = Math.Round(((S - U) * (Math.Sqrt(3))) / 2, Form1.decimal_precision)
            x3 = String.Format("{0} - {1}i", REAL, IMAG) 'combining the REAL and IMAGINARY part

            root_list.Add(x1.ToString)
            root_list.Add(x2)
            root_list.Add(x3)

            Return root_list
        End Function

        Private Function METHOD_2()
            Dim x1, x2, x3 As Double
            Dim root_list As List(Of Double) = New List(Of Double)
            'formula x1 = x2 = x3= (d/a)^1/3 * -1
            x1 = ((D / A) ^ (1 / 3)) * -1
            x2 = ((D / A) ^ (1 / 3)) * -1
            x3 = ((D / A) ^ (1 / 3)) * -1
            root_list.Add(x1)
            root_list.Add(x2)
            root_list.Add(x3)

            Return root_list
        End Function

        Private Function METHOD_3()
            Dim I, J, K, L, M, N, P
            Dim x1, x2, x3 As Double
            Dim root_list As List(Of Double) = New List(Of Double)

            'formula I = (((g ^ 2) / 4) - h)^1/2
            I = Math.Sqrt((((g ^ 2) / 4) - h))
            'MessageBox.Show(">>>>>>>>>>>> I: " & I)
            'formula I = J = (I)^1/3
            J = (I) ^ (1 / 3)
            'MessageBox.Show(">>>>>>>>>>>> J: " & J)
            'formula k = arc cosine (- (g / 2i)) in vb answer is automatically in RADIANS
            K = Math.Acos((-(g / (2 * I))))
            'MessageBox.Show(">>>>>>>>>>>> K: " & K)
            'formula L = J * -1
            L = J * -1
            'MessageBox.Show(">>>>>>>>>>>> L: " & L)
            'formula M = cosine(K / 3
            M = Math.Cos(K / 3)
            'MessageBox.Show(">>>>>>>>>>>> M: " & M)
            'formula N = (Square Root of 3) * sine (k/3)
            N = (Math.Sqrt(3)) * Math.Sin(K / 3)
            ' MessageBox.Show(">>>>>>>>>>>> N: " & N)
            'fomrula P = (b/3a) * -1
            P = (B / (3 * A)) * -1
            'MessageBox.Show(">>>>>>>>>>>> P: " & P)

            'formula x1 = 2j * cosine(k/3) -(b/3a)
            x1 = (2 * J) * (Math.Cos(K / 3)) - ((B / (3 * A)))
            'fornula x2 = L * (M + N) + P
            x2 = L * (M + N) + P
            'formula x3 = L * (M - N) + P
            ' MessageBox.Show(L & " " & M & " " & N & " " & P)
            'My.Computer.Clipboard.SetText(L & " " & M & " " & N & " " & P)
            x3 = L * (M - N) + P

            root_list.Add(x1)
            root_list.Add(x2)
            root_list.Add(x3)

            Return root_list
        End Function

        Public Sub ComputeRoots()
            AssignMethod() 'RUN ASSIGNMETHOD TO KNOW THE METHOD TO BE USED
            If MethodUse = "METHOD_1" Then
                answers2 = METHOD_1()
            ElseIf MethodUse = "METHOD_2" Then
                answers = METHOD_2()
            ElseIf MethodUse = "METHOD_3" Then
                answers = METHOD_3()
            End If
        End Sub
    End Class

    Public Sub HistoryToggle()
        If history_toggle Mod 2 = 0 Then
            Button_show_solution.Text = "Close History"
            History.Show()
            history_toggle += 1
        Else
            Button_show_solution.Text = "Show History"
            History.Dispose()
            history_toggle = 0
        End If

    End Sub

    Public Sub DeleteLogFile()
        Dim logger_path As String = System.IO.Path.GetFullPath(logger_file_name_main)
        System.IO.File.Delete(logger_path)
    End Sub

    Public Sub CalculationLogger(ByVal Optional text As String = "")
        Dim logger_file_number = 1
        Dim logger_file_name = "cubic_log.txt"
        logger_file_name_main = "cubic_log.txt"

        If computed_from_combox Then 'we dont want to log again the same answer in a different number of decimal place
            'pass
        Else
            If Not program_started Then
                Try
                    FileOpen(logger_file_number, logger_file_name, OpenMode.Output)
                    FileClose(logger_file_number)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    calculation_count += 1
                    FileOpen(logger_file_number, logger_file_name, OpenMode.Append)
                    PrintLine(logger_file_number, String.Format("Computation {0}:" & vbNewLine & text & vbNewLine, calculation_count))
                    FileClose(logger_file_number)
                Catch ex As Exception

                End Try
            End If
            History.LoadHistory()
        End If

    End Sub
    Public Sub ClearOutput()
        tbx_list.Clear()
        TextBox_x1.Text = "x1"
        TextBox_x2.Text = "x2"
        TextBox_x3.Text = "x3"
        Label1_method.Text = "----"
    End Sub
    Public Sub ActivateButtons()
        Button_copy.Enabled = True
        Button_save.Enabled = True
        Button_show_solution.Enabled = True
        TextBox_x1.Enabled = True
        TextBox_x2.Enabled = True
        TextBox_x3.Enabled = True
    End Sub

    Public Sub DeactivateButtons()
        program_started = False
        Status_Action.Text = "Actions: waiting..."
        Button_copy.Enabled = False
        Button_save.Enabled = False
        TextBox_x1.Enabled = False
        TextBox_x2.Enabled = False
        TextBox_x3.Enabled = False
    End Sub

    Public Sub WhenValid()
        Status_Action.Text = "Actions: Calculation Finished."
    End Sub

    Public Sub WhenInvalid()
        MessageBox.Show("Invalid input, cannot calculate", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Status_Action.Text = "Actions: Please check the inputs."
    End Sub

    Public Sub WhenInvalid2()
        MessageBox.Show("Math Error, 'a' cannot be Zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Status_Action.Text = "Actions: 'a' cannot be Zero."
    End Sub

    '======================================== Private Sub
    Private Sub Button_copy_Click(sender As Object, e As EventArgs) Handles Button_copy.Click 'COPY BUTTON
        My.Computer.Clipboard.SetText(saved_text)
        Status_Action.Text = "Actions: Successfully copied to clipboard."
    End Sub

    Private Sub Button_calculate_Click(sender As Object, e As EventArgs) Handles Button_calculate.Click 'CALCULATE BUTTON     
        ' MessageBox.Show(Math.Acos(-((4.07407) / (2 * 8.3356))))
        program_started = True
        computed_from_combox = False
        'MessageBox.Show(number_of_calculation)
        number_of_calculation += 1
        Dim tbx_index As New List(Of Integer)
        tbx_list.Add(TextBox_A)
        tbx_list.Add(TextBox_B)
        tbx_list.Add(TextBox_C)
        tbx_list.Add(TextBox_D)

        Dim zero_occured As Boolean = False
        '=========================== colorize wrong input
        For item_num = 0 To tbx_list.Count() - 1
            If tbx_list(0).Text.ToString = "0" And Not zero_occured Then
                zero_occured = True
                tbx_index.Add(0)
                Continue For
            End If
            If IsNumeric(tbx_list(item_num).Text) Then
                'do nothing
            Else
                tbx_index.Add(item_num)
            End If
        Next

        For err_item = 0 To tbx_index.Count() - 1
            tbx_list(tbx_index(err_item)).ForeColor = Color.Red
        Next
        '=========================== 
        If tbx_index.Count > 0 Then
            If zero_occured Then
                WhenInvalid2()
            End If
            WhenInvalid()
        Else
            History.clear_trigger = False
            ActivateButtons()
            WhenValid()
            DoCalculation()
        End If

    End Sub

    Public Sub SaveResults()
        'formatting the input values into a cubic equation
        Dim temp As List(Of String) = New List(Of String)
        temp.Clear()
        For tbx_items = 1 To tbx_list.Count - 1
            If tbx_list(tbx_items).Text >= 0 Then
                temp.Add(String.Format("+ {0}", tbx_list(tbx_items).Text))
            ElseIf tbx_list(tbx_items).Text Then
                temp.Add(String.Format("- {0}", tbx_list(tbx_items).Text * -1))
            End If

        Next
        'saving current calculation 
        inserted_equation = String.Format("Equation: {0}x^3 {1}x^2 {2}x {3}", TextBox_A.Text, temp(0), temp(1), temp(2))
        saved_text = String.Format("Equation: {0}x^3 {1}x^2 {2}x {3}" & vbNewLine _
            & "x1 = {4} | x2 = {5} | x3 = {6}", TextBox_A.Text, temp(0), temp(1), temp(2), TextBox_x1.Text, TextBox_x2.Text, TextBox_x3.Text)

        CalculationLogger(saved_text)
    End Sub

    Public Sub DoCalculation()
        Dim gen_comp_obj As New GeneralComputations
        gen_comp_obj.GetNumericalCoefficiets(TextBox_A.Text, TextBox_B.Text, TextBox_C.Text, TextBox_D.Text)
        gen_comp_obj.ExecuteComputations()

        Dim meth_comp_obj As New MethodComputations
        meth_comp_obj.Get_FGH_ABCD(gen_comp_obj.GetFGH(), gen_comp_obj.GetABCD())
        meth_comp_obj.ComputeRoots()
        If meth_comp_obj.GetMethod = "METHOD_1" Then
            Label1_method.Text = "One Real root and Two Imaginary root."
            method_description = "One Real root and Two Imaginary root."
        ElseIf meth_comp_obj.GetMethod = "METHOD_2" Then
            Label1_method.Text = "All roots are Real and Equal."
            method_description = "All roots are Real and Equal."
        ElseIf meth_comp_obj.GetMethod = "METHOD_3" Then
            Label1_method.Text = "All roots are Real."
            method_description = "All roots are Real."
        End If
        If meth_comp_obj.GetMethod = "METHOD_1" Then
            TextBox_x1.Text = meth_comp_obj.answers2(0)
            TextBox_x2.Text = meth_comp_obj.answers2(1)
            TextBox_x3.Text = meth_comp_obj.answers2(2)
        Else
            TextBox_x1.Text = Math.Round(meth_comp_obj.answers(0), decimal_precision)
            TextBox_x2.Text = Math.Round(meth_comp_obj.answers(1), decimal_precision)
            TextBox_x3.Text = Math.Round(meth_comp_obj.answers(2), decimal_precision)
        End If
        SaveResults()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'LOAD FORM
        CalculationLogger() 'clears out the log file before using
        DeactivateButtons()
        ClearOutput()
        AcceptButton = Button_calculate
    End Sub

    Private Sub TextBox_A_TextChanged(sender As Object, e As EventArgs) Handles TextBox_A.TextChanged
        TextBox_A.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub TextBox_B_TextChanged(sender As Object, e As EventArgs) Handles TextBox_B.TextChanged
        TextBox_B.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub TextBox_C_TextChanged(sender As Object, e As EventArgs) Handles TextBox_C.TextChanged
        TextBox_C.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub TextBox_D_TextChanged(sender As Object, e As EventArgs) Handles TextBox_D.TextChanged
        TextBox_D.ForeColor = Color.Black
        DeactivateButtons()
        ClearOutput()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "Upto 3 decimal place" Then
            decimal_precision = 3
        ElseIf ComboBox1.Text = "Upto 4 decimal place" Then
            decimal_precision = 4
        Else
            decimal_precision = 9
        End If

        If program_started And ComboBox1.Text <> prev Then
            computed_from_combox = True
            DoCalculation()
        End If
        prev = ComboBox1.Text
        'MessageBox.Show(prev)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.Text = "All 3 roots are Real" Then
            TextBox_A.Text = 2
            TextBox_B.Text = -4
            TextBox_C.Text = -22
            TextBox_D.Text = 24
        ElseIf ComboBox2.Text = "Only 1 root is Real 2 are Imaginary" Then
            TextBox_A.Text = 1
            TextBox_B.Text = 2
            TextBox_C.Text = 10
            TextBox_D.Text = -20
        ElseIf ComboBox2.Text = "All 3 roots are Real and Equal" Then
            TextBox_A.Text = 1
            TextBox_B.Text = 6
            TextBox_C.Text = 12
            TextBox_D.Text = 8
        End If
    End Sub

    Private Sub Button_clear_Click(sender As Object, e As EventArgs) Handles Button_clear.Click
        decimal_precision = 9
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox_A.Clear()
        TextBox_B.Clear()
        TextBox_C.Clear()
        TextBox_D.Clear()
        Label1_method.Text = "----"
    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click
        Try
            Dim extension_name As String = ""
            Dim complete_fname As String = ""
            SaveFileDialog1.Filter = "Text File|*.txt|Rich Text Format|*.rtf|Word Document|*.docx"
            SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            SaveFileDialog1.FileName = "cubic_computation"

            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then
                Status_Action.Text = "Actions: Saving Cancelled."
            Else
                complete_fname = System.IO.Path.GetFileName(SaveFileDialog1.FileName)
                extension_name = System.IO.Path.GetExtension(SaveFileDialog1.FileName)

                If extension_name = ".docx" Then
                    'save as a word document to make this work add reference named
                    'Microsoft word object library And Microsoft office object library
                    Dim word_application As Microsoft.Office.Interop.Word.Application 'create your application
                    Dim word_document As Microsoft.Office.Interop.Word.Document 'create your document
                    Dim word_paragraph As Microsoft.Office.Interop.Word.Paragraph 'create the paragraph container

                    word_application = CreateObject("Word.Application") 'create a reference object
                    word_application.Visible = False 'if true the word application starts up and open if you dont quit the application at the end

                    word_document = word_application.Documents.Add 'adding the document
                    word_paragraph = word_document.Content.Paragraphs.Add 'adding paragraph to the document

                    word_paragraph.Range.Text = saved_text 'getting what the paragaraph contains
                    word_document.SaveAs2(SaveFileDialog1.FileName) 'saving the file 
                    word_application.Quit() 'closing the application
                Else
                    System.IO.File.WriteAllText(SaveFileDialog1.FileName, saved_text)
                End If
                Status_Action.Text = String.Format("Actions: The File Has Been Saved. Location: {0}", SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button_show_solution_Click(sender As Object, e As EventArgs) Handles Button_show_solution.Click
        HistoryToggle()
    End Sub

    Private Sub TextBox_x1_MouseHover(sender As Object, e As EventArgs) Handles TextBox_x1.MouseHover
        ToolTip1.SetToolTip(TextBox_x1, String.Format("x1 = {0}", TextBox_x1.Text))
    End Sub

    Private Sub TextBox_x2_MouseHover(sender As Object, e As EventArgs) Handles TextBox_x2.MouseHover
        ToolTip1.SetToolTip(TextBox_x2, String.Format("x2 = {0}", TextBox_x2.Text))
    End Sub

    Private Sub TextBox_x3_MouseHover(sender As Object, e As EventArgs) Handles TextBox_x3.MouseHover
        ToolTip1.SetToolTip(TextBox_x3, String.Format("x3 = {0}", TextBox_x3.Text))
    End Sub

    Private Sub Label1_method_MouseHover(sender As Object, e As EventArgs) Handles Label1_method.MouseHover
        If program_started Then
            ToolTip1.SetToolTip(Label1_method, String.Format("The {0}  has {1}", inserted_equation, method_description))
        Else
            ToolTip1.SetToolTip(Label1_method, "Shows inputed equation attribute.")
        End If
    End Sub

    Private Sub Button_copy_MouseLeave(sender As Object, e As EventArgs) Handles Button_copy.MouseLeave
        Button_copy.BackColor = Color.White
    End Sub

    Private Sub Button_copy_MouseHover(sender As Object, e As EventArgs) Handles Button_copy.MouseHover
        Button_copy.BackColor = Color.Aquamarine
    End Sub

    Private Sub Button_save_MouseHover(sender As Object, e As EventArgs) Handles Button_save.MouseHover
        Button_save.BackColor = Color.Aquamarine
    End Sub

    Private Sub Button_save_MouseLeave(sender As Object, e As EventArgs) Handles Button_save.MouseLeave
        Button_save.BackColor = Color.White
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Do you really want to exit now?", "Exit Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            DeleteLogFile()
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub StatusStrip1_method_MouseHover(sender As Object, e As EventArgs) Handles StatusStrip1_method.MouseHover
        ToolTip1.SetToolTip(StatusStrip1_method, Status_Action.Text)
    End Sub

    Private Sub Button_show_solution_MouseHover(sender As Object, e As EventArgs) Handles Button_show_solution.MouseHover
        If Button_show_solution.Text = "Close History" Then
            ToolTip1.SetToolTip(Button_show_solution, "Close History.")
        Else
            ToolTip1.SetToolTip(Button_show_solution, "Show previous calculations.")
        End If
    End Sub
End Class
