<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEPCOMOperator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEPCOMOperator))
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtchecked = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtprepared = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtapproved = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lvlOperator = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.txtUserID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.TsExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStrip()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PreparedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApprovedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.FontBold = True
        Me.LabelX14.ForeColor = System.Drawing.Color.White
        Me.LabelX14.Location = New System.Drawing.Point(12, 165)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(220, 23)
        Me.LabelX14.TabIndex = 71
        Me.LabelX14.Text = "APPROVED"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtchecked
        '
        '
        '
        '
        Me.txtchecked.Border.Class = "TextBoxBorder"
        Me.txtchecked.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtchecked.Location = New System.Drawing.Point(12, 139)
        Me.txtchecked.Name = "txtchecked"
        Me.txtchecked.PreventEnterBeep = True
        Me.txtchecked.Size = New System.Drawing.Size(220, 24)
        Me.txtchecked.TabIndex = 68
        Me.txtchecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.FontBold = True
        Me.LabelX4.ForeColor = System.Drawing.Color.White
        Me.LabelX4.Location = New System.Drawing.Point(12, 116)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(220, 23)
        Me.LabelX4.TabIndex = 70
        Me.LabelX4.Text = "CHECKED"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtprepared
        '
        '
        '
        '
        Me.txtprepared.Border.Class = "TextBoxBorder"
        Me.txtprepared.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtprepared.Location = New System.Drawing.Point(12, 90)
        Me.txtprepared.Name = "txtprepared"
        Me.txtprepared.PreventEnterBeep = True
        Me.txtprepared.Size = New System.Drawing.Size(220, 24)
        Me.txtprepared.TabIndex = 67
        Me.txtprepared.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.FontBold = True
        Me.LabelX2.ForeColor = System.Drawing.Color.White
        Me.LabelX2.Location = New System.Drawing.Point(12, 67)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(220, 23)
        Me.LabelX2.TabIndex = 69
        Me.LabelX2.Text = "PREPARED"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtapproved
        '
        '
        '
        '
        Me.txtapproved.Border.Class = "TextBoxBorder"
        Me.txtapproved.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtapproved.Location = New System.Drawing.Point(12, 188)
        Me.txtapproved.Name = "txtapproved"
        Me.txtapproved.PreventEnterBeep = True
        Me.txtapproved.Size = New System.Drawing.Size(220, 24)
        Me.txtapproved.TabIndex = 72
        Me.txtapproved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvlOperator
        '
        '
        '
        '
        Me.lvlOperator.Border.Class = "ListViewBorder"
        Me.lvlOperator.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvlOperator.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.PreparedBy, Me.CheckedBy, Me.ApprovedBy})
        Me.lvlOperator.DisabledBackColor = System.Drawing.Color.Empty
        Me.lvlOperator.FullRowSelect = True
        Me.lvlOperator.Location = New System.Drawing.Point(238, 66)
        Me.lvlOperator.Name = "lvlOperator"
        Me.lvlOperator.Size = New System.Drawing.Size(361, 146)
        Me.lvlOperator.TabIndex = 73
        Me.lvlOperator.UseCompatibleStateImageBehavior = False
        Me.lvlOperator.View = System.Windows.Forms.View.Details
        '
        'txtUserID
        '
        '
        '
        '
        Me.txtUserID.Border.Class = "TextBoxBorder"
        Me.txtUserID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserID.Location = New System.Drawing.Point(322, 218)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PreventEnterBeep = True
        Me.txtUserID.Size = New System.Drawing.Size(136, 24)
        Me.txtUserID.TabIndex = 74
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEdit
        '
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 36)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 36)
        Me.btnClear.Text = "Clear"
        '
        'TsExit
        '
        Me.TsExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TsExit.ForeColor = System.Drawing.Color.White
        Me.TsExit.Image = CType(resources.GetObject("TsExit.Image"), System.Drawing.Image)
        Me.TsExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsExit.Name = "TsExit"
        Me.TsExit.Size = New System.Drawing.Size(70, 36)
        Me.TsExit.Text = "Exit"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEdit, Me.ToolStripSeparator2, Me.btnClear, Me.TsExit})
        Me.btnSearch.Location = New System.Drawing.Point(0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(629, 39)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "ToolStrip1"
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 10
        '
        'PreparedBy
        '
        Me.PreparedBy.Text = "PREPAREDBY"
        Me.PreparedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PreparedBy.Width = 120
        '
        'CheckedBy
        '
        Me.CheckedBy.Text = "CHECKEDBY"
        Me.CheckedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CheckedBy.Width = 120
        '
        'ApprovedBy
        '
        Me.ApprovedBy.Text = "APPROVEBY"
        Me.ApprovedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ApprovedBy.Width = 120
        '
        'SEPCOMOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lvlOperator)
        Me.Controls.Add(Me.txtapproved)
        Me.Controls.Add(Me.LabelX14)
        Me.Controls.Add(Me.txtchecked)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtprepared)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnSearch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SEPCOMOperator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operator"
        Me.btnSearch.ResumeLayout(False)
        Me.btnSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtchecked As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtprepared As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtapproved As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lvlOperator As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents txtUserID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStrip
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents PreparedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckedBy As System.Windows.Forms.ColumnHeader
    Friend WithEvents ApprovedBy As System.Windows.Forms.ColumnHeader
End Class
