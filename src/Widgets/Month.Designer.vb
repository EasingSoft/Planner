<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Month
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colmMo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmTu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmWe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmTh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmFr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmSa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmSu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Head = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeColumns = False
        Me.Grid.AllowUserToResizeRows = False
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmMo, Me.colmTu, Me.colmWe, Me.colmTh, Me.colmFr, Me.colmSa, Me.colmSu})
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle45
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.Color.Blue
        Me.Grid.Location = New System.Drawing.Point(0, 40)
        Me.Grid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Grid.RowTemplate.Height = 40
        Me.Grid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Grid.ShowCellToolTips = False
        Me.Grid.Size = New System.Drawing.Size(333, 204)
        Me.Grid.TabIndex = 1
        '
        'colmMo
        '
        Me.colmMo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmMo.DefaultCellStyle = DataGridViewCellStyle38
        Me.colmMo.HeaderText = "MON"
        Me.colmMo.Name = "colmMo"
        Me.colmMo.ReadOnly = True
        Me.colmMo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmTu
        '
        Me.colmTu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmTu.DefaultCellStyle = DataGridViewCellStyle39
        Me.colmTu.HeaderText = "TUE"
        Me.colmTu.Name = "colmTu"
        Me.colmTu.ReadOnly = True
        Me.colmTu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmWe
        '
        Me.colmWe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmWe.DefaultCellStyle = DataGridViewCellStyle40
        Me.colmWe.HeaderText = "WED"
        Me.colmWe.Name = "colmWe"
        Me.colmWe.ReadOnly = True
        Me.colmWe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmTh
        '
        Me.colmTh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmTh.DefaultCellStyle = DataGridViewCellStyle41
        Me.colmTh.HeaderText = "THU"
        Me.colmTh.Name = "colmTh"
        Me.colmTh.ReadOnly = True
        Me.colmTh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmFr
        '
        Me.colmFr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmFr.DefaultCellStyle = DataGridViewCellStyle42
        Me.colmFr.HeaderText = "FRI"
        Me.colmFr.Name = "colmFr"
        Me.colmFr.ReadOnly = True
        Me.colmFr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmSa
        '
        Me.colmSa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmSa.DefaultCellStyle = DataGridViewCellStyle43
        Me.colmSa.HeaderText = "SAT"
        Me.colmSa.Name = "colmSa"
        Me.colmSa.ReadOnly = True
        Me.colmSa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colmSu
        '
        Me.colmSu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colmSu.DefaultCellStyle = DataGridViewCellStyle44
        Me.colmSu.HeaderText = "SUN"
        Me.colmSu.Name = "colmSu"
        Me.colmSu.ReadOnly = True
        Me.colmSu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Head
        '
        Me.Head.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Head.Location = New System.Drawing.Point(0, 0)
        Me.Head.Name = "Head"
        Me.Head.Size = New System.Drawing.Size(333, 40)
        Me.Head.TabIndex = 2
        Me.Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Month
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Head)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Month"
        Me.Size = New System.Drawing.Size(333, 244)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Grid As DataGridView
    Friend WithEvents colmMo As DataGridViewTextBoxColumn
    Friend WithEvents colmTu As DataGridViewTextBoxColumn
    Friend WithEvents colmWe As DataGridViewTextBoxColumn
    Friend WithEvents colmTh As DataGridViewTextBoxColumn
    Friend WithEvents colmFr As DataGridViewTextBoxColumn
    Friend WithEvents colmSa As DataGridViewTextBoxColumn
    Friend WithEvents colmSu As DataGridViewTextBoxColumn
    Friend WithEvents Head As Label
End Class
