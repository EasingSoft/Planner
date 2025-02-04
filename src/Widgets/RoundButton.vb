Imports System.ComponentModel

Public Class RoundButton



    Private _cornerRadius As Integer = 10
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Invalidate() ' Redraw control when radius changes
        End Set
    End Property

    Private _borderColor As Color = Color.FromArgb(228, 230, 234)
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate() ' Redraw control when color changes
        End Set
    End Property

    Private _InnerColor As Brush = Brushes.White
    Public Property InnerColor As Brush
        Get
            Return _InnerColor
        End Get
        Set(value As Brush)
            _InnerColor = value
            Invalidate() ' Redraw control when color changes
        End Set
    End Property

    Private _Text As String = "Button1"
    Public Property Content As String
        Get
            Return _Text
        End Get
        Set(value As String)
            _Text = value
            Invalidate()
        End Set
    End Property



    Private Property _BorderWidth As Integer = 3
    Public Property BorderWidth As Integer
        Get
            Return _BorderWidth
        End Get
        Set(value As Integer)
            _BorderWidth = value
            Invalidate() ' Redraw control when radius changes
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim rect = New Rectangle(BorderWidth, BorderWidth, Me.Width - 2 * BorderWidth - 1, Me.Height - 2 * BorderWidth - 1)
        Using pen As New Pen(BorderColor, BorderWidth)
            Dim R = rect
            R.Width -= BorderWidth * 2
            R.Height -= BorderWidth * 2
            R.X += BorderWidth
            R.Y += BorderWidth
            e.Graphics.FillRectangle(InnerColor, R)
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Using path As New Drawing2D.GraphicsPath()
                path.AddArc(rect.X, rect.Y, CornerRadius * 2, CornerRadius * 2, 180, 90)
                path.AddArc(rect.Right - CornerRadius * 2, rect.Y, CornerRadius * 2, CornerRadius * 2, 270, 90)
                path.AddArc(rect.Right - CornerRadius * 2, rect.Bottom - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 0, 90)
                path.AddArc(rect.X, rect.Bottom - CornerRadius * 2, CornerRadius * 2, CornerRadius * 2, 90, 90)
                path.CloseFigure()
                If BorderWidth > 0 Then e.Graphics.DrawPath(pen, path)
            End Using
        End Using

        Dim textSize = e.Graphics.MeasureString(Content, Font)
        Dim textLocation As New Point((Me.Width - textSize.Width) \ 2, (Me.Height - textSize.Height) \ 2)
        Using brush As New SolidBrush(ForeColor)
            e.Graphics.DrawString(Content, Font, brush, textLocation)
        End Using
    End Sub
End Class
