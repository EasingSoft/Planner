<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Events = New System.Windows.Forms.DataGridView()
        Me.colmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmRun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmArgument = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SettingBtn = New Planner.RoundButton()
        Me.RemoveTask = New Planner.RoundButton()
        Me.AddTask = New Planner.RoundButton()
        Me.PreviousBtn = New Planner.RoundButton()
        Me.NextBtn = New Planner.RoundButton()
        Me.Month = New Planner.Month()
        CType(Me.Events, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Events
        '
        Me.Events.AllowUserToAddRows = False
        Me.Events.AllowUserToDeleteRows = False
        Me.Events.AllowUserToResizeColumns = False
        Me.Events.AllowUserToResizeRows = False
        Me.Events.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Events.BackgroundColor = System.Drawing.Color.White
        Me.Events.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Events.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Events.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Events.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Events.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmName, Me.colmTime, Me.colmRun, Me.colmFile, Me.colmArgument})
        Me.Events.EnableHeadersVisualStyles = False
        Me.Events.Location = New System.Drawing.Point(355, 52)
        Me.Events.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Events.Name = "Events"
        Me.Events.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Events.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Events.RowHeadersVisible = False
        Me.Events.RowTemplate.Height = 40
        Me.Events.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Events.ShowCellToolTips = False
        Me.Events.Size = New System.Drawing.Size(507, 385)
        Me.Events.TabIndex = 7
        '
        'colmName
        '
        Me.colmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colmName.FillWeight = 186.6963!
        Me.colmName.HeaderText = "Name"
        Me.colmName.Name = "colmName"
        Me.colmName.ReadOnly = True
        Me.colmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colmName.Width = 49
        '
        'colmTime
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colmTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.colmTime.FillWeight = 203.0457!
        Me.colmTime.HeaderText = "Time"
        Me.colmTime.Name = "colmTime"
        Me.colmTime.ReadOnly = True
        Me.colmTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colmTime.Width = 70
        '
        'colmRun
        '
        Me.colmRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colmRun.HeaderText = "Run"
        Me.colmRun.Name = "colmRun"
        Me.colmRun.ReadOnly = True
        Me.colmRun.Width = 57
        '
        'colmFile
        '
        Me.colmFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colmFile.FillWeight = 5.129018!
        Me.colmFile.HeaderText = "File"
        Me.colmFile.Name = "colmFile"
        Me.colmFile.ReadOnly = True
        Me.colmFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colmFile.Width = 34
        '
        'colmArgument
        '
        Me.colmArgument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colmArgument.DefaultCellStyle = DataGridViewCellStyle3
        Me.colmArgument.FillWeight = 5.129018!
        Me.colmArgument.HeaderText = "Event"
        Me.colmArgument.Name = "colmArgument"
        Me.colmArgument.ReadOnly = True
        Me.colmArgument.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colmArgument.Width = 48
        '
        'SettingBtn
        '
        Me.SettingBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingBtn.BackColor = System.Drawing.Color.Transparent
        Me.SettingBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.SettingBtn.BorderWidth = 3
        Me.SettingBtn.Content = "⚙"
        Me.SettingBtn.CornerRadius = 10
        Me.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingBtn.Location = New System.Drawing.Point(13, 447)
        Me.SettingBtn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(53, 51)
        Me.SettingBtn.TabIndex = 10
        '
        'RemoveTask
        '
        Me.RemoveTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemoveTask.BackColor = System.Drawing.Color.Transparent
        Me.RemoveTask.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.RemoveTask.BorderWidth = 3
        Me.RemoveTask.Content = "Remove"
        Me.RemoveTask.CornerRadius = 10
        Me.RemoveTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RemoveTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveTask.Location = New System.Drawing.Point(737, 447)
        Me.RemoveTask.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RemoveTask.Name = "RemoveTask"
        Me.RemoveTask.Size = New System.Drawing.Size(125, 51)
        Me.RemoveTask.TabIndex = 9
        '
        'AddTask
        '
        Me.AddTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddTask.BackColor = System.Drawing.Color.Transparent
        Me.AddTask.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.AddTask.BorderWidth = 3
        Me.AddTask.Content = "Add"
        Me.AddTask.CornerRadius = 10
        Me.AddTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTask.Location = New System.Drawing.Point(355, 447)
        Me.AddTask.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddTask.Name = "AddTask"
        Me.AddTask.Size = New System.Drawing.Size(125, 51)
        Me.AddTask.TabIndex = 8
        '
        'PreviousBtn
        '
        Me.PreviousBtn.BackColor = System.Drawing.Color.Transparent
        Me.PreviousBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.PreviousBtn.BorderWidth = 0
        Me.PreviousBtn.Content = "<"
        Me.PreviousBtn.CornerRadius = 10
        Me.PreviousBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PreviousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreviousBtn.ForeColor = System.Drawing.Color.Black
        Me.PreviousBtn.Location = New System.Drawing.Point(60, 14)
        Me.PreviousBtn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PreviousBtn.Name = "PreviousBtn"
        Me.PreviousBtn.Size = New System.Drawing.Size(48, 38)
        Me.PreviousBtn.TabIndex = 6
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.Color.Transparent
        Me.NextBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.NextBtn.BorderWidth = 0
        Me.NextBtn.Content = ">"
        Me.NextBtn.CornerRadius = 10
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.Black
        Me.NextBtn.Location = New System.Drawing.Point(251, 14)
        Me.NextBtn.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(48, 38)
        Me.NextBtn.TabIndex = 5
        '
        'Month
        '
        Me.Month.BackColor = System.Drawing.Color.White
        Me.Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Month.Location = New System.Drawing.Point(13, 13)
        Me.Month.Margin = New System.Windows.Forms.Padding(4)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(333, 305)
        Me.Month.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 510)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.RemoveTask)
        Me.Controls.Add(Me.AddTask)
        Me.Controls.Add(Me.Events)
        Me.Controls.Add(Me.PreviousBtn)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.Month)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan"
        CType(Me.Events, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Month As Month
    Friend WithEvents PreviousBtn As RoundButton
    Friend WithEvents NextBtn As RoundButton
    Friend WithEvents Events As DataGridView
    Friend WithEvents AddTask As RoundButton
    Friend WithEvents RemoveTask As RoundButton
    Friend WithEvents SettingBtn As RoundButton
    Friend WithEvents colmName As DataGridViewTextBoxColumn
    Friend WithEvents colmTime As DataGridViewTextBoxColumn
    Friend WithEvents colmRun As DataGridViewTextBoxColumn
    Friend WithEvents colmFile As DataGridViewTextBoxColumn
    Friend WithEvents colmArgument As DataGridViewTextBoxColumn
End Class
