Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Public Class ToggleButton
    Inherits CheckBox

    Private _onBackColor As Color = Color.MediumSlateBlue
    Private _onToggleColor As Color = Color.WhiteSmoke
    Private _offBackColor As Color = Color.Gray
    Private _offToggleColor As Color = Color.Gainsboro
    Private _solidStyle As Boolean = True

    <Category("RJ Code Advance")>
    Public Property OnBackColor As Color
        Get
            Return _onBackColor
        End Get
        Set(ByVal value As Color)
            _onBackColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OnToggleColor As Color
        Get
            Return _onToggleColor
        End Get
        Set(ByVal value As Color)
            _onToggleColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OffBackColor As Color
        Get
            Return _offBackColor
        End Get
        Set(ByVal value As Color)
            _offBackColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property OffToggleColor As Color
        Get
            Return _offToggleColor
        End Get
        Set(ByVal value As Color)
            _offToggleColor = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(False)>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    <Category("RJ Code Advance")>
    <DefaultValue(True)>
    Public Property SolidStyle As Boolean
        Get
            Return _solidStyle
        End Get
        Set(ByVal value As Boolean)
            _solidStyle = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()
        Me.MinimumSize = New Size(45, 22)
    End Sub

    Private Function GetFigurePath() As GraphicsPath
        Dim arcSize As Integer = Me.Height - 1
        Dim leftArc As Rectangle = New Rectangle(0, 0, arcSize, arcSize)
        Dim rightArc As Rectangle = New Rectangle(Me.Width - arcSize - 2, 0, arcSize, arcSize)
        Dim path As GraphicsPath = New GraphicsPath()
        path.StartFigure()
        path.AddArc(leftArc, 90, 180)
        path.AddArc(rightArc, 270, 180)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        Dim toggleSize As Integer = Me.Height - 5
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pevent.Graphics.Clear(Me.Parent.BackColor)

        If Me.Checked Then

            If _solidStyle Then
                pevent.Graphics.FillPath(New SolidBrush(_onBackColor), GetFigurePath())
            Else
                pevent.Graphics.DrawPath(New Pen(_onBackColor, 2), GetFigurePath())
            End If

            pevent.Graphics.FillEllipse(New SolidBrush(_onToggleColor), New Rectangle(Me.Width - Me.Height + 1, 2, toggleSize, toggleSize))
        Else

            If _solidStyle Then
                pevent.Graphics.FillPath(New SolidBrush(_offBackColor), GetFigurePath())
            Else
                pevent.Graphics.DrawPath(New Pen(_offBackColor, 2), GetFigurePath())
            End If

            pevent.Graphics.FillEllipse(New SolidBrush(_offToggleColor), New Rectangle(2, 2, toggleSize, toggleSize))
        End If
    End Sub
End Class
