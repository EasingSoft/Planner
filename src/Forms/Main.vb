Imports System.IO
Imports Microsoft.Win32.TaskScheduler

Public Class Main
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Month.CurrentMonth = Month.CurrentMonth.AddMonths(1)
        LoadMonth()
    End Sub

    Private Sub PreviousBtn_Click(sender As Object, e As EventArgs) Handles PreviousBtn.Click
        Month.CurrentMonth = Month.CurrentMonth.AddMonths(-1)
        LoadMonth()
    End Sub

    Sub RefreshTheme()
        Switch(Me, getCurrentTheme())
    End Sub

    Sub RefreshMode()
        colmArgument.Visible = Not (My.Settings.Mode = "basic")
    End Sub

    Public Sub LoadMonth()
        Events.Rows.Clear()
        RemoveHandler Month.Grid.SelectionChanged, AddressOf DaySelected
        Month.LoadMonth(Month.CurrentMonth.Month, Month.CurrentMonth.Year)
        AddHandler Month.Grid.SelectionChanged, AddressOf DaySelected
    End Sub

    Private Sub DaySelected(sender As Object, e As EventArgs)
        Dim Day = 0
        Events.Rows.Clear()

        Dim C = Month.Grid.SelectedCells.Cast(Of DataGridViewCell).FirstOrDefault
        If C Is Nothing Then Return
        If TypeOf C.Style.NullValue Is Color AndAlso Not (C.Style.NullValue = getCurrentTheme.Highlight) Then Return
        If Not Integer.TryParse(C.Value, Day) Then Return

        For Each T In getAllTasks()
            Dim Trigger = T.Definition.Triggers(0)
            Dim Time = Trigger.StartBoundary
            Dim IsValid = Time.Day = Day AndAlso Time.Month = Month.CurrentMonth.Month AndAlso Time.Year = Month.CurrentMonth.Year
            IsValid = IsValid OrElse Trigger.TriggerType = TaskTriggerType.Daily
            IsValid = IsValid OrElse (Trigger.TriggerType = TaskTriggerType.Weekly AndAlso Time.DayOfWeek = C.ColumnIndex + 1)
            IsValid = IsValid OrElse (Trigger.TriggerType = TaskTriggerType.Monthly AndAlso Time.Day = Day)
            If IsValid Then
                Dim Action = TryCast(T.Definition.Actions.First(), ExecAction)
                Events.Rows.Add(New Object() {T.Name, Time.ToString("HH:mm"), Trigger.TriggerType.ToString(), Path.GetFileNameWithoutExtension(Action.Path), Action.Arguments})
            End If
        Next
        Events.ClearSelection()
    End Sub

    Private Sub RemoveTask_Click(sender As Object, e As EventArgs) Handles RemoveTask.Click
        If Events.SelectedRows.Cast(Of DataGridViewRow).Count() = 0 Then
            MessageBox.Show("No row selected", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            For Each R In Events.SelectedRows.Cast(Of DataGridViewRow)
                Dim EventName As String = R.Cells(colmName.Index).Value
                DeleteTask(EventName)
            Next
            Dim C = Month.Grid.SelectedCells.Cast(Of DataGridViewCell).FirstOrDefault
            If C IsNot Nothing Then
                Dim Ri = C.RowIndex
                Dim Ci = C.ColumnIndex
                LoadMonth()
                Month.Grid.Rows(Ri).Cells(Ci).Selected = True
            End If
        End If
    End Sub

    Private Sub AddTask_Click(sender As Object, e As EventArgs) Handles AddTask.Click
        Dim C = Month.Grid.SelectedCells.Cast(Of DataGridViewCell).FirstOrDefault
        If C Is Nothing OrElse Not Integer.TryParse(C.Value, 0) Then
            MessageBox.Show("No day selected", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Ri = C.RowIndex
            Dim Ci = C.ColumnIndex
            Using diag As New AddEvent
                diag.CurrentMonth = New DateTime(Month.CurrentMonth.Year, Month.CurrentMonth.Month, C.Value, 0, 0, 0)
                diag.ShowDialog()
                LoadMonth()
                Month.Grid.Rows(Ri).Cells(Ci).Selected = True
            End Using
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshMode()
        RefreshTheme()
        LoadMonth()
    End Sub

    Private Sub SettingBtn_Click(sender As Object, e As EventArgs) Handles SettingBtn.Click
        Using diag As New Settings
            diag.ShowDialog()
        End Using
        Main_Load(Nothing, Nothing)
    End Sub
End Class
