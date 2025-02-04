Imports Microsoft.Win32.TaskScheduler

Module Task
    Function getAllTasks() As List(Of Microsoft.Win32.TaskScheduler.Task)
        Dim Tasks As New List(Of Microsoft.Win32.TaskScheduler.Task)
        Using service As New TaskService()
            For Each task In service.AllTasks
                If task.Definition.Triggers.Count = 1 AndAlso task.Definition.RegistrationInfo.Description = "plan" Then
                    Dim T = task.Definition.Triggers(0).TriggerType
                    Dim isValid = T = TaskTriggerType.Daily
                    isValid = isValid OrElse T = TaskTriggerType.Weekly
                    isValid = isValid OrElse T = TaskTriggerType.Monthly
                    isValid = isValid OrElse T = TaskTriggerType.Time
                    If isValid Then
                        Tasks.Add(task)
                    End If
                End If
            Next
        End Using
        Return Tasks
    End Function
    Function isTaskExists(Name As String) As Boolean
        Dim Tasks As New List(Of Microsoft.Win32.TaskScheduler.Task)
        Using service As New TaskService()
            For Each task In service.AllTasks
                If task.Name = Name Then
                    Return True
                End If
            Next
        End Using
        Return False
    End Function


    Sub CreateTask(Name As String, FilePath As String, Args As String, Trigger As Trigger)
        Using ts As New TaskService()
            Dim action As New ExecAction(FilePath, Args, Nothing)
            Dim task As TaskDefinition = ts.NewTask()
            task.RegistrationInfo.Description = "plan"
            task.Actions.Add(action)
            task.Triggers.Add(trigger)
            ts.RootFolder.RegisterTaskDefinition(Name, task)
        End Using
    End Sub
    Sub DeleteTask(taskName As String)
        Using ts As New TaskService()
            Dim task = ts.FindTask(taskName)
            If task IsNot Nothing Then
                ts.RootFolder.DeleteTask(task.Name)
            End If
        End Using
    End Sub
End Module
