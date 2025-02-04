Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Win32.TaskScheduler

Public Class AddEvent
    Private Sub BrowseFile_Click(sender As Object, e As EventArgs) Handles BrowseFile.Click
        Using diag As New OpenFileDialog
            If diag.ShowDialog = DialogResult.OK Then
                FilePath.Text = diag.FileName
            End If
        End Using
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If isTaskExists(TaskName.Text) Then
            MessageBox.Show("Task with same name already exists. Please choose another one.", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrEmpty(TaskName.Text) Then
            MessageBox.Show("Invalid task name.", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim Time = New DateTime(CurrentMonth.Year, CurrentMonth.Month, CurrentMonth.Day, Hour.Value, Min.Value, 0) 'CurrentMonth.AddHours(Hour.Value).AddMinutes(Min.Value)

        Dim Argument = Args.Text
        Dim Matches = Regex.Matches(Argument, "{.*?}")
        For index = 0 To Matches.Count - 1
            Dim VarName = Matches(index).Value
            Dim VarValue = Variables.Rows(index).Cells(colmVarVal.Index).Value
            If String.IsNullOrEmpty(VarValue) Then
                MessageBox.Show($"Value not provided for variable: {VarName.TrimStart("{").TrimEnd("}")}", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Argument = Argument.Replace(VarName, VarValue)
        Next
        Dim Trigger As Trigger
        If Once.Checked Then
            Trigger = New TimeTrigger()
        ElseIf Daily.Checked Then
            Trigger = New DailyTrigger()
        ElseIf Weekly.Checked Then
            Trigger = New WeeklyTrigger(WeekConvert(Time.DayOfWeek))
        ElseIf Monthly.Checked Then
            Trigger = New MonthlyTrigger()
        End If
        Trigger.StartBoundary = Time
        CreateTask(TaskName.Text, FilePath.Text, Argument, Trigger)
        Close()
    End Sub

    Public Function WeekConvert(day As DayOfWeek) As DaysOfTheWeek
        Select Case day
            Case DayOfWeek.Sunday
                Return DaysOfTheWeek.Sunday
            Case DayOfWeek.Monday
                Return DaysOfTheWeek.Monday
            Case DayOfWeek.Tuesday
                Return DaysOfTheWeek.Tuesday
            Case DayOfWeek.Wednesday
                Return DaysOfTheWeek.Wednesday
            Case DayOfWeek.Thursday
                Return DaysOfTheWeek.Thursday
            Case DayOfWeek.Friday
                Return DaysOfTheWeek.Friday
            Case DayOfWeek.Saturday
                Return DaysOfTheWeek.Saturday
            Case Else
                Return DaysOfTheWeek.Sunday
        End Select
    End Function


    Sub RefreshMode()
        Dim IsAdvanced = Not (My.Settings.Mode = "basic")
        colmCommandLine.Visible = IsAdvanced
        BrowseFile.Visible = IsAdvanced
        FilePath.Visible = IsAdvanced
        Args.Visible = IsAdvanced
        FileLable.Visible = IsAdvanced
        ArgLabel.Visible = IsAdvanced
        colmName.AutoSizeMode = If(IsAdvanced, DataGridViewAutoSizeColumnMode.AllCells, DataGridViewAutoSizeColumnMode.Fill)
    End Sub
    Private Sub AddEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMode
        Switch(Me, getCurrentTheme())
        If Directory.Exists("Templates") Then
            For Each T In Directory.GetFiles("Templates")
                If Not (Path.GetExtension(T) = ".bat") Then Continue For
                Templates.Rows.Add(New Object() {Path.GetFileNameWithoutExtension(T), File.ReadAllText(T)})
            Next
        End If
        Templates.ClearSelection()
        AddHandler Templates.SelectionChanged, AddressOf Templates_SelectionChanged
        Hour.Value = Date.Now.Hour
        Min.Value = Date.Now.Minute
    End Sub

    Private Sub Templates_SelectionChanged(sender As Object, e As EventArgs)
        Dim C = Templates.SelectedRows.Cast(Of DataGridViewRow).FirstOrDefault().Cells
        Dim Name As String = C(colmName.Index).Value
        Dim cmd As String = C(colmCommandLine.Index).Value
        If Not cmd.Contains(" ") Then cmd &= " "

        Dim Space = cmd.IndexOf(" ")
        Dim Filename = cmd.Substring(0, Space).Replace("""", String.Empty)
        Space += 1
        Dim Arg = cmd.Substring(Space, cmd.Length - Space)
        TaskName.Text = Name
        FilePath.Text = Filename
        Args.Text = Arg
        Variables.Rows.Clear()
        Dim Matches = Regex.Matches(Arg, "{(.*?)}")
        For index = 0 To Matches.Count - 1
            Variables.Rows.Add(New Object() {Matches(index).Groups(1).Value})
        Next
    End Sub

    Friend CurrentMonth As Date

    Private Sub Variables_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Variables.CellEnter
        If e.ColumnIndex = colmVarVal.Index Then
            Variables.BeginEdit(True)
        End If
    End Sub

    Private Sub Variables_SelectionChanged(sender As Object, e As EventArgs) Handles Variables.SelectionChanged
        Variables.ClearSelection()
    End Sub
End Class