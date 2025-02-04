<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEvent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEvent))
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.FileLable = New System.Windows.Forms.Label()
        Me.ArgLabel = New System.Windows.Forms.Label()
        Me.Args = New System.Windows.Forms.TextBox()
        Me.BrowseFile = New System.Windows.Forms.Button()
        Me.Templates = New System.Windows.Forms.DataGridView()
        Me.colmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmCommandLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaskName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Variables = New System.Windows.Forms.DataGridView()
        Me.colmVarName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmVarVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Once = New System.Windows.Forms.RadioButton()
        Me.Monthly = New System.Windows.Forms.RadioButton()
        Me.Weekly = New System.Windows.Forms.RadioButton()
        Me.Daily = New System.Windows.Forms.RadioButton()
        Me.Hour = New System.Windows.Forms.NumericUpDown()
        Me.Min = New System.Windows.Forms.NumericUpDown()
        Me.Cancel = New Planner.RoundButton()
        Me.OK = New Planner.RoundButton()
        CType(Me.Templates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Variables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilePath
        '
        Me.FilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilePath.Location = New System.Drawing.Point(566, 386)
        Me.FilePath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(336, 21)
        Me.FilePath.TabIndex = 0
        '
        'FileLable
        '
        Me.FileLable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileLable.AutoSize = True
        Me.FileLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileLable.Location = New System.Drawing.Point(465, 389)
        Me.FileLable.Name = "FileLable"
        Me.FileLable.Size = New System.Drawing.Size(30, 15)
        Me.FileLable.TabIndex = 1
        Me.FileLable.Text = "File:"
        '
        'ArgLabel
        '
        Me.ArgLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArgLabel.AutoSize = True
        Me.ArgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArgLabel.Location = New System.Drawing.Point(465, 420)
        Me.ArgLabel.Name = "ArgLabel"
        Me.ArgLabel.Size = New System.Drawing.Size(69, 15)
        Me.ArgLabel.TabIndex = 3
        Me.ArgLabel.Text = "Arguments:"
        '
        'Args
        '
        Me.Args.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Args.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Args.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Args.Location = New System.Drawing.Point(566, 417)
        Me.Args.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Args.Name = "Args"
        Me.Args.Size = New System.Drawing.Size(336, 21)
        Me.Args.TabIndex = 2
        '
        'BrowseFile
        '
        Me.BrowseFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseFile.BackColor = System.Drawing.Color.White
        Me.BrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BrowseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseFile.Location = New System.Drawing.Point(909, 386)
        Me.BrowseFile.Name = "BrowseFile"
        Me.BrowseFile.Size = New System.Drawing.Size(38, 21)
        Me.BrowseFile.TabIndex = 4
        Me.BrowseFile.Text = "+++"
        Me.BrowseFile.UseVisualStyleBackColor = False
        '
        'Templates
        '
        Me.Templates.AllowUserToAddRows = False
        Me.Templates.AllowUserToDeleteRows = False
        Me.Templates.AllowUserToResizeColumns = False
        Me.Templates.AllowUserToResizeRows = False
        Me.Templates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Templates.BackgroundColor = System.Drawing.Color.White
        Me.Templates.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Templates.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Templates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Templates.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Templates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Templates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmName, Me.colmCommandLine})
        Me.Templates.EnableHeadersVisualStyles = False
        Me.Templates.Location = New System.Drawing.Point(14, 15)
        Me.Templates.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Templates.MultiSelect = False
        Me.Templates.Name = "Templates"
        Me.Templates.ReadOnly = True
        Me.Templates.RowHeadersVisible = False
        Me.Templates.RowTemplate.Height = 40
        Me.Templates.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Templates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Templates.ShowCellToolTips = False
        Me.Templates.Size = New System.Drawing.Size(416, 423)
        Me.Templates.TabIndex = 8
        '
        'colmName
        '
        Me.colmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colmName.FillWeight = 186.6963!
        Me.colmName.HeaderText = "Name"
        Me.colmName.Name = "colmName"
        Me.colmName.ReadOnly = True
        Me.colmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmCommandLine
        '
        Me.colmCommandLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colmCommandLine.DefaultCellStyle = DataGridViewCellStyle2
        Me.colmCommandLine.FillWeight = 5.129018!
        Me.colmCommandLine.HeaderText = "CommandLine"
        Me.colmCommandLine.Name = "colmCommandLine"
        Me.colmCommandLine.ReadOnly = True
        Me.colmCommandLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Name:"
        '
        'TaskName
        '
        Me.TaskName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaskName.Location = New System.Drawing.Point(566, 24)
        Me.TaskName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Size = New System.Drawing.Size(336, 26)
        Me.TaskName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Time:"
        '
        'Variables
        '
        Me.Variables.AllowUserToAddRows = False
        Me.Variables.AllowUserToDeleteRows = False
        Me.Variables.AllowUserToResizeColumns = False
        Me.Variables.AllowUserToResizeRows = False
        Me.Variables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Variables.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Variables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Variables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.Variables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Variables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Variables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Variables.ColumnHeadersVisible = False
        Me.Variables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmVarName, Me.colmVarVal})
        Me.Variables.EnableHeadersVisualStyles = False
        Me.Variables.GridColor = System.Drawing.Color.Silver
        Me.Variables.Location = New System.Drawing.Point(468, 156)
        Me.Variables.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Variables.MultiSelect = False
        Me.Variables.Name = "Variables"
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Variables.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Variables.RowHeadersVisible = False
        Me.Variables.RowTemplate.Height = 40
        Me.Variables.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Variables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Variables.ShowCellToolTips = False
        Me.Variables.Size = New System.Drawing.Size(434, 159)
        Me.Variables.TabIndex = 17
        '
        'colmVarName
        '
        Me.colmVarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.colmVarName.DefaultCellStyle = DataGridViewCellStyle4
        Me.colmVarName.FillWeight = 186.6963!
        Me.colmVarName.HeaderText = "Name"
        Me.colmVarName.Name = "colmVarName"
        Me.colmVarName.ReadOnly = True
        Me.colmVarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colmVarName.Width = 5
        '
        'colmVarVal
        '
        Me.colmVarVal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colmVarVal.FillWeight = 5.129018!
        Me.colmVarVal.HeaderText = "Value"
        Me.colmVarVal.Name = "colmVarVal"
        Me.colmVarVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(464, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Run:"
        '
        'Once
        '
        Me.Once.AutoSize = True
        Me.Once.Checked = True
        Me.Once.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Once.Location = New System.Drawing.Point(566, 66)
        Me.Once.Name = "Once"
        Me.Once.Size = New System.Drawing.Size(65, 24)
        Me.Once.TabIndex = 19
        Me.Once.TabStop = True
        Me.Once.Text = "Once"
        Me.Once.UseVisualStyleBackColor = True
        '
        'Monthly
        '
        Me.Monthly.AutoSize = True
        Me.Monthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Monthly.Location = New System.Drawing.Point(788, 66)
        Me.Monthly.Name = "Monthly"
        Me.Monthly.Size = New System.Drawing.Size(82, 24)
        Me.Monthly.TabIndex = 21
        Me.Monthly.Text = "Monthly"
        Me.Monthly.UseVisualStyleBackColor = True
        '
        'Weekly
        '
        Me.Weekly.AutoSize = True
        Me.Weekly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Weekly.Location = New System.Drawing.Point(704, 66)
        Me.Weekly.Name = "Weekly"
        Me.Weekly.Size = New System.Drawing.Size(78, 24)
        Me.Weekly.TabIndex = 22
        Me.Weekly.Text = "Weekly"
        Me.Weekly.UseVisualStyleBackColor = True
        '
        'Daily
        '
        Me.Daily.AutoSize = True
        Me.Daily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Daily.Location = New System.Drawing.Point(637, 66)
        Me.Daily.Name = "Daily"
        Me.Daily.Size = New System.Drawing.Size(61, 24)
        Me.Daily.TabIndex = 23
        Me.Daily.Text = "Daily"
        Me.Daily.UseVisualStyleBackColor = True
        '
        'Hour
        '
        Me.Hour.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Hour.Location = New System.Drawing.Point(566, 112)
        Me.Hour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.Hour.Name = "Hour"
        Me.Hour.Size = New System.Drawing.Size(41, 22)
        Me.Hour.TabIndex = 24
        Me.Hour.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Min
        '
        Me.Min.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Min.Location = New System.Drawing.Point(613, 112)
        Me.Min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(41, 22)
        Me.Min.TabIndex = 25
        Me.Min.Value = New Decimal(New Integer() {10, 0, 0, 0})
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
        Me.Cancel.Location = New System.Drawing.Point(305, 441)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(125, 51)
        Me.Cancel.TabIndex = 13
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
        Me.OK.Location = New System.Drawing.Point(14, 441)
        Me.OK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(125, 51)
        Me.OK.TabIndex = 12
        '
        'AddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 506)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.Hour)
        Me.Controls.Add(Me.Daily)
        Me.Controls.Add(Me.Weekly)
        Me.Controls.Add(Me.Monthly)
        Me.Controls.Add(Me.Once)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Variables)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TaskName)
        Me.Controls.Add(Me.Templates)
        Me.Controls.Add(Me.BrowseFile)
        Me.Controls.Add(Me.ArgLabel)
        Me.Controls.Add(Me.Args)
        Me.Controls.Add(Me.FileLable)
        Me.Controls.Add(Me.FilePath)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Event"
        CType(Me.Templates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Variables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FilePath As TextBox
    Friend WithEvents FileLable As Label
    Friend WithEvents ArgLabel As Label
    Friend WithEvents Args As TextBox
    Friend WithEvents BrowseFile As Button
    Friend WithEvents Templates As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TaskName As TextBox
    Friend WithEvents Cancel As RoundButton
    Friend WithEvents OK As RoundButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Variables As DataGridView
    Friend WithEvents colmVarName As DataGridViewTextBoxColumn
    Friend WithEvents colmVarVal As DataGridViewTextBoxColumn
    Friend WithEvents colmName As DataGridViewTextBoxColumn
    Friend WithEvents colmCommandLine As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Once As RadioButton
    Friend WithEvents Monthly As RadioButton
    Friend WithEvents Weekly As RadioButton
    Friend WithEvents Daily As RadioButton
    Friend WithEvents Hour As NumericUpDown
    Friend WithEvents Min As NumericUpDown
End Class
