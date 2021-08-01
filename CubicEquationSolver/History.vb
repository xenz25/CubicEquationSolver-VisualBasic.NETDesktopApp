Public Class History
    Public history_loaded As Boolean = False
    Public clear_trigger As Boolean = False
    Dim main_history_text As String = ""

    Public Sub ChangeHistoryDetails()
        If Form1.number_of_calculation = 1 Then
            Status_description.Text = "Description: There is " & Form1.number_of_calculation & " count of calculation in history."
        ElseIf Form1.number_of_calculation = 0 Then
            Status_description.Text = "Description: No data in History."
        Else
            Status_description.Text = "Description: There are " & Form1.number_of_calculation & " counts of calculation in history."
        End If
    End Sub
    Public Sub OpenLogFile(ByVal Optional mode As Integer = 0)
        Dim logger_file_number = 1
        Dim logger_file_name = "cubic_log.txt"
        main_history_text = "" 'clearing is necessary to remove duplicated comtent

        If mode = 0 Then
            Try
                FileOpen(logger_file_number, logger_file_name, OpenMode.Input)
                While Not EOF(logger_file_number)
                    Dim temp_string As String = LineInput(logger_file_number)
                    ListBox_history.Items.Add(temp_string)
                    main_history_text += temp_string 'concatenation to store in single string literal
                    main_history_text += vbNewLine
                End While
                FileClose(logger_file_number)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "History Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Try
                FileOpen(logger_file_number, logger_file_name, OpenMode.Output)
                FileClose(logger_file_number)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Public Sub LoadHistory()
        ChangeHistoryDetails()
        ListBox_history.Items.Clear()
        OpenLogFile()
    End Sub
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeHistoryDetails()
        ' MessageBox.Show("BEFORE LOAD" & history_loaded)
        history_loaded = True
        'MessageBox.Show("after LOAD" & history_loaded)
        LoadHistory()
        If ListBox_history.Items.Count = 0 Then
            ListBox_history.Items.Add("There are no history yet.")
        End If
    End Sub



    Private Sub Button_save_history_Click(sender As Object, e As EventArgs) Handles Button_save_history.Click
        If ListBox_history.Items.Count = 1 Then 'when no history data yet
            MessageBox.Show("There are no history yet." & vbNewLine & "Cannot save.", "Cubic Equation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim extension_name As String = ""
                Dim complete_fname As String = ""
                SaveFileDialog2.Filter = "Text File|*.txt|Rich Text Format|*.rtf|Word Document|*.docx"
                SaveFileDialog2.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                SaveFileDialog2.FileName = "Computations_History"

                If SaveFileDialog2.ShowDialog() = DialogResult.Cancel Then
                    Status_description.Text = "Actions: Saving Cancelled."
                Else
                    complete_fname = System.IO.Path.GetFileName(SaveFileDialog2.FileName)
                    extension_name = System.IO.Path.GetExtension(SaveFileDialog2.FileName)

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

                        word_paragraph.Range.Text = main_history_text  'getting what the paragaraph contains
                        word_document.SaveAs2(SaveFileDialog2.FileName) 'saving the file 
                        word_application.Quit() 'closing the application
                    Else
                        System.IO.File.WriteAllText(SaveFileDialog2.FileName, main_history_text)
                    End If
                    Status_description.Text = String.Format("Actions: The File Has Been Saved. Location: {0}", SaveFileDialog2.FileName)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button_refresh_Click(sender As Object, e As EventArgs)
        If clear_trigger Then
            'pass
        Else
            LoadHistory()
        End If

    End Sub

    Private Sub Button_clearhistory_Click(sender As Object, e As EventArgs) Handles Button_clearhistory.Click
        Form1.number_of_calculation = 0
        ChangeHistoryDetails()
        ListBox_history.Items.Clear()
        OpenLogFile(1)
        ListBox_history.Items.Add("There are no history yet.")
        Form1.calculation_count = 0
        clear_trigger = True
    End Sub

    Private Sub History_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'MessageBox.Show("BEFORE closing" & history_loaded)
        history_loaded = False
        Form1.HistoryToggle()
        'MessageBox.Show("after closimg" & history_loaded)
    End Sub

    Private Sub Button_copyhis_Click(sender As Object, e As EventArgs) Handles Button_copyhis.Click
        Try
            My.Computer.Clipboard.SetText(main_history_text)
            Status_description.Text = "Actions: Successfully copied to clipboard."
        Catch ex As Exception
            MessageBox.Show("There are no history yet." & vbNewLine & "No data copied.", "Cubic Equation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub History_Click(sender As Object, e As EventArgs) Handles Me.Click
        ChangeHistoryDetails()
    End Sub

    Private Sub ListBox_history_MouseHover(sender As Object, e As EventArgs) Handles ListBox_history.MouseHover
        ChangeHistoryDetails()
    End Sub

    Private Sub StatusStrip1_description_MouseHover(sender As Object, e As EventArgs) Handles StatusStrip1_description.MouseHover
        ToolTip1.SetToolTip(StatusStrip1_description, Status_description.Text)
    End Sub

End Class