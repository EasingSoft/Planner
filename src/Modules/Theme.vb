Imports System.Windows.Forms.Control

Module Theme
    ' Define a base class for themes
    Public Class ThemeBase
        Public Property Fore As Color
        Public Property Back As Color
        Public Property Highlight As Color
        Public Property HeaderBack As Color
        Public Property HeaderFore As Color

        Public Property CalenderHeaderBack As Color
        Public Property CalenderHeaderFore As Color

        Public Property CalenderFore As Color
        Public Property CalenderBack As Color
    End Class

    ' Define the Black theme inheriting from ThemeBase
    Public Class Black
        Inherits ThemeBase
        Public Sub New()
            Me.Fore = Color.White
            ' Me.Back = Color.FromArgb(31, 31, 31)
            Me.Back = Color.FromArgb(21, 18, 31)
            Me.Highlight = Color.DeepPink
            Me.HeaderBack = Color.FromArgb(64, 64, 64)
            Me.HeaderFore = Fore
            Me.CalenderHeaderBack = Color.FromArgb(78, 68, 105)
            Me.CalenderHeaderFore = Color.Gray
            Me.CalenderBack = Fore
            Me.CalenderFore = Fore
        End Sub
    End Class

    ' Define the White theme inheriting from ThemeBase
    Public Class White
        Inherits ThemeBase
        Public Sub New()
            Me.Fore = Color.Black
            Me.Back = Color.White
            Me.Highlight = Color.FromArgb(255, 60, 99)
            Me.HeaderBack = Color.Silver
            Me.HeaderFore = Fore
            Me.CalenderHeaderBack = Color.FromArgb(78, 68, 105)
            Me.CalenderHeaderFore = Color.Gray
            Me.CalenderBack = Fore
            Me.CalenderFore = Color.White
        End Sub
    End Class

    ' Optional: Function to get a theme by name
    Public Function GetThemeByName(name As String) As ThemeBase
        Select Case name
            Case "dark"
                Return New Black()
            Case "light"
                Return New White()
            Case Else
                Return Nothing
        End Select
    End Function

    Function getCurrentTheme() As ThemeBase
        Return GetThemeByName(My.Settings.UI)
    End Function
    Sub Switch(Widget As Control, Theme As ThemeBase)
        If TypeOf Widget Is RoundButton Then Return
        If TypeOf Widget Is Form Then
            Dim F = DirectCast(Widget, Form)
            F.BackColor = Theme.Back
            F.ForeColor = Theme.Fore
        End If

        For Each W In Widget.Controls
            If TypeOf W Is Label Then
                Dim L = DirectCast(W, Label)
                L.BackColor = Theme.Back
                L.ForeColor = Theme.Fore
            ElseIf TypeOf W Is NumericUpDown Then
                Dim L = DirectCast(W, NumericUpDown)
                L.BackColor = Theme.Back
                L.ForeColor = Theme.Fore
                'ElseIf TypeOf W Is RichTextBox Then
                '    Dim L = DirectCast(W, RichTextBox)
                '    L.BackColor = Theme.Back
                '    L.ForeColor = Theme.Fore
            ElseIf TypeOf W Is RoundButton Then
                Dim L = DirectCast(W, RoundButton)
                L.BackColor = Theme.Back
                L.ForeColor = Theme.Fore
                L.InnerColor = (New SolidBrush(Theme.Back))
                L.BorderColor = Theme.HeaderBack
            ElseIf TypeOf W Is Button Then
                Dim L = DirectCast(W, Button)
                L.BackColor = Theme.Back
                L.ForeColor = Theme.Fore
                L.FlatAppearance.BorderColor = Theme.Fore
                L.FlatAppearance.MouseDownBackColor = Theme.HeaderBack
                L.FlatAppearance.MouseOverBackColor = Theme.HeaderBack
            ElseIf TypeOf W Is TextBox Then
                Dim L = DirectCast(W, TextBox)
                L.BackColor = Theme.Back
                L.ForeColor = Theme.Fore
            ElseIf TypeOf W Is DataGridView Then
                Dim G = DirectCast(W, DataGridView)
                G.BackgroundColor = Theme.Back
                G.BackColor = Theme.Back
                G.DefaultCellStyle.BackColor = Theme.Back
                G.DefaultCellStyle.ForeColor = Theme.Fore
                G.ColumnHeadersDefaultCellStyle.BackColor = Theme.HeaderBack
                G.ColumnHeadersDefaultCellStyle.ForeColor = Theme.HeaderFore
                G.GridColor = Theme.Back
            End If
            Switch(W, Theme)
        Next
    End Sub
End Module
