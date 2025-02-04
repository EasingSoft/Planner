<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cancel = New Planner.RoundButton()
        Me.OK = New Planner.RoundButton()
        Me.DarkTheme = New Planner.ToggleButton()
        Me.AdvanceMode = New Planner.ToggleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dark Theme:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Advance Mode:"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cancel.BackColor = System.Drawing.Color.Transparent
        Me.Cancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Cancel.BorderWidth = 3
        Me.Cancel.Content = "Cancel"
        Me.Cancel.CornerRadius = 10
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(181, 157)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(125, 51)
        Me.Cancel.TabIndex = 15
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OK.BackColor = System.Drawing.Color.Transparent
        Me.OK.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.OK.BorderWidth = 3
        Me.OK.Content = "OK"
        Me.OK.CornerRadius = 10
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(33, 157)
        Me.OK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(125, 51)
        Me.OK.TabIndex = 14
        '
        'DarkTheme
        '
        Me.DarkTheme.AutoSize = True
        Me.DarkTheme.Location = New System.Drawing.Point(181, 58)
        Me.DarkTheme.MinimumSize = New System.Drawing.Size(45, 22)
        Me.DarkTheme.Name = "DarkTheme"
        Me.DarkTheme.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.DarkTheme.OffToggleColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.DarkTheme.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.DarkTheme.OnToggleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.DarkTheme.Size = New System.Drawing.Size(45, 22)
        Me.DarkTheme.TabIndex = 16
        Me.DarkTheme.UseVisualStyleBackColor = True
        '
        'AdvanceMode
        '
        Me.AdvanceMode.AutoSize = True
        Me.AdvanceMode.Location = New System.Drawing.Point(181, 104)
        Me.AdvanceMode.MinimumSize = New System.Drawing.Size(45, 22)
        Me.AdvanceMode.Name = "AdvanceMode"
        Me.AdvanceMode.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.AdvanceMode.OffToggleColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.AdvanceMode.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.AdvanceMode.OnToggleColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.AdvanceMode.Size = New System.Drawing.Size(45, 22)
        Me.AdvanceMode.TabIndex = 18
        Me.AdvanceMode.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 222)
        Me.Controls.Add(Me.AdvanceMode)
        Me.Controls.Add(Me.DarkTheme)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cancel As RoundButton
    Friend WithEvents OK As RoundButton
    Friend WithEvents DarkTheme As ToggleButton
    Friend WithEvents AdvanceMode As ToggleButton
End Class
