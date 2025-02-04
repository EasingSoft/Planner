Imports System.Reflection
Imports Microsoft.Win32.TaskScheduler

Public Class Month
    Public CurrentMonth As Date = Date.Now
    Sub New()
        InitializeComponent()
        Grid.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).SetValue(Grid, True)
    End Sub
    Public Sub LoadMonth(Month As Integer, Year As Integer)
        Grid.Rows.Clear()

        'get current Month tasks
        Dim Tasks = getAllTasks()
        'For Each T In Tasks.ToArray
        '    Dim Time = T.Definition.Triggers(0).StartBoundary
        '    If Time.Month <> Month OrElse Time.Year <> Year Then
        '        Tasks.Remove(T)
        '    End If
        'Next

        Dim Dat = New Date(Year, Month, 1)
        Dim daysInMonth = Date.DaysInMonth(Year, Month)
        Dim MonthArr = Enumerable.Repeat(CObj(String.Empty), Dat.DayOfWeek - 1).Concat(Enumerable.Range(1, daysInMonth).Cast(Of Object)).ToList()
        Dim weeks = MonthArr.Select(Function(value, index) New With {Key value, Key index}).
                                                    GroupBy(Function(x) x.index \ 7).
                                                    Select(Function(group) group.Select(Function(x) x.value.ToString()).ToArray())



        For Each week In weeks
            Grid.Rows.Add(week)
            For index = 0 To week.Length - 1
                Dim Day = week(index)
                If Not Integer.TryParse(Day, 0) Then Continue For
                For Each task In Tasks.ToArray
                    Dim trigger = task.Definition.Triggers(0)
                    Dim Time = trigger.StartBoundary
                    Dim T = trigger.TriggerType
                    Dim C = Grid.Rows(Grid.Rows.Count - 1).Cells(index)
                    If T = TaskTriggerType.Time AndAlso Time.Day = Day AndAlso Time.Month = Month AndAlso Time.Year = Year Then
                        C.Style.NullValue = getCurrentTheme.Highlight
                    ElseIf T = TaskTriggerType.Daily Then
                        C.Style.NullValue = getCurrentTheme.Highlight
                    ElseIf T = TaskTriggerType.Weekly AndAlso Time.DayOfWeek = index + 1 Then
                        C.Style.NullValue = getCurrentTheme.Highlight
                    ElseIf T = TaskTriggerType.Monthly AndAlso Time.Day = Day Then
                        C.Style.NullValue = getCurrentTheme.Highlight
                    End If
                Next
            Next
        Next
        Grid.ClearSelection()
        '        Head.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Calibri;}}
        '{\*\generator Riched20 10.0.18362}\viewkind4\uc1 
        '\pard\sa200\sl276\slmult1\qc\fs30\b " & Dat.ToString("MMMM") & "\plain\fs30  " & Dat.Year & "\par
        '}
        '"
        Head.Tag = Dat.ToString("MMMM yyyy")
        Head.Invalidate()
    End Sub

    Public Function MeasureDisplayStringWidth(ByVal graphics As Graphics, ByVal text As String, ByVal font As Font) As Integer
        Dim format As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        Dim rect As System.Drawing.RectangleF = New System.Drawing.RectangleF(0, 0, 1000, 1000)
        Dim ranges = New System.Drawing.CharacterRange(0, text.Length)
        Dim regions As System.Drawing.Region() = New System.Drawing.Region(0) {}
        format.SetMeasurableCharacterRanges(New CharacterRange() {ranges})
        regions = graphics.MeasureCharacterRanges(text, font, rect, format)
        rect = regions(0).GetBounds(graphics)
        Return CInt((rect.Right + 1.0F))
    End Function

    Private Sub Head_Paint(sender As Object, e As PaintEventArgs) Handles Head.Paint
        Dim T = Head.Tag
        If Not String.IsNullOrEmpty(T) AndAlso T.Contains(" ") Then
            Dim Mon = T.Split(" ")(0)
            Dim Year = T.Split(" ")(1)

            ' Define fonts
            Dim BoldFont = New Font(Head.Font.FontFamily, Head.Font.SizeInPoints, FontStyle.Bold, GraphicsUnit.Point)
            Dim RegularFont = Head.Font

            ' Measure the size of each part
            Dim MonSize = TextRenderer.MeasureText(Mon, BoldFont)
            Dim YearSize = TextRenderer.MeasureText(Year, RegularFont)
            Dim MonW = MeasureDisplayStringWidth(e.Graphics, Mon, BoldFont)
            ' Calculate the position to center both texts horizontally and vertically
            Dim totalWidth = MonW + MeasureDisplayStringWidth(e.Graphics, Year, RegularFont)
            Dim maxHeight = Math.Max(MonSize.Height, YearSize.Height)
            Dim x = (Head.Width - totalWidth) / 2
            Dim y = (Head.Height - maxHeight) / 2

            ' Draw the texts
            Using b = New SolidBrush(Head.ForeColor)
                e.Graphics.DrawString(Mon, BoldFont, b, x, y)
                e.Graphics.DrawString(Year, RegularFont, b, x + MonW, y)
            End Using
        End If
    End Sub

    Private Sub Grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        e.Paint(e.ClipBounds, e.PaintParts And Not DataGridViewPaintParts.SelectionBackground)
        Dim BackColor = getCurrentTheme.Back
        Using b As New SolidBrush(BackColor)
            Dim ForColor = e.CellStyle.ForeColor
            If e.RowIndex = -1 Then ForColor = getCurrentTheme.CalenderHeaderFore

            Dim Pad = 2
            Dim R = e.CellBounds
            R.Width += Pad
            R.Height += Pad
            R.X -= Pad
            R.Y -= Pad
            e.Graphics.FillRectangle(b, R)
            TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, ForColor)
        End Using

        If Not String.IsNullOrEmpty(e.FormattedValue) AndAlso e.RowIndex >= 0 AndAlso e.Value IsNot Nothing Then
            Dim diameter As Integer = Math.Min((e.CellBounds.Width / 4) * 3, (e.CellBounds.Height / 4) * 3) ' Use the smaller dimension for the diameter
            Dim R As New Rectangle(
                    e.CellBounds.X + (e.CellBounds.Width - diameter) / 2,
                    e.CellBounds.Y + (e.CellBounds.Height - diameter) / 2,
                    diameter, diameter)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias


            If TypeOf e.CellStyle.NullValue Is Color Then
                Dim Pad = 0
                Dim smallDiameter As Integer = 10
                Dim smallCircleX As Integer = R.X + R.Width - smallDiameter - Pad
                Dim smallCircleY As Integer = R.Y + Pad
                Dim smallCircleBounds As New Rectangle(smallCircleX, smallCircleY, smallDiameter, smallDiameter)

                Using br = New SolidBrush(getCurrentTheme.CalenderHeaderBack)
                    e.Graphics.FillEllipse(br, R)
                End Using
                TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, getCurrentTheme.CalenderFore)
                Using brSmall = New SolidBrush(Color.FromArgb(255, e.CellStyle.NullValue))
                    e.Graphics.FillEllipse(brSmall, smallCircleBounds)
                End Using
            End If

            If (e.State And DataGridViewElementStates.Selected) > 0 Then
                Using br = New SolidBrush(Color.FromArgb(100, SystemColors.Highlight))
                    e.Graphics.FillEllipse(br, R)
                End Using
                TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, If(TypeOf e.CellStyle.NullValue Is Color, getCurrentTheme.CalenderFore, e.CellStyle.ForeColor))
            End If
        End If
        e.Handled = True
    End Sub


End Class
