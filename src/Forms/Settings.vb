Public Class Settings
    Dim DefaultUi As String = My.Settings.UI
    Dim DefaultMode As String = My.Settings.Mode
    Sub Change()
        My.Settings.UI = If(DarkTheme.Checked, "dark", "light")
        My.Settings.Mode = If(Not AdvanceMode.Checked, "basic", "advance")
        RefreshTheme()
    End Sub

    Sub RefreshTheme()
        Switch(Me, getCurrentTheme())
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DarkTheme.Checked = My.Settings.UI = "dark"
        AdvanceMode.Checked = Not (My.Settings.Mode = "basic")
        RefreshTheme()
    End Sub


    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Change()
        My.Settings.Save()
        Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        My.Settings.UI = DefaultUi
        My.Settings.Mode = DefaultMode
        My.Settings.Save()
        Close()
    End Sub

    Private Sub DarkTheme_CheckedChanged(sender As Object, e As EventArgs) Handles DarkTheme.CheckedChanged
        Change()
    End Sub
End Class