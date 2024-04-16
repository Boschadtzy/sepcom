<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEPCOMUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEPCOMUser))
        Me.btnSearch = New System.Windows.Forms.ToolStrip()
        Me.btnadd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsExit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.txtup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtUn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.label1 = New DevComponents.DotNetBar.LabelX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lvlUser = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSeepassword = New System.Windows.Forms.CheckBox()
        Me.txtUserID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.btnSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadd, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnClear, Me.ToolStripSeparator3, Me.TsExit, Me.btnDelete})
        Me.btnSearch.Location = New System.Drawing.Point(0, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(621, 39)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "ToolStrip1"
        '
        'btnadd
        '
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(74, 36)
        Me.btnadd.Text = "Add"
        Me.btnadd.ToolTipText = "add"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
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
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 36)
        Me.btnDelete.Text = "Delete"
        '
        'txtup
        '
        '
        '
        '
        Me.txtup.Border.Class = "TextBoxBorder"
        Me.txtup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtup.Location = New System.Drawing.Point(11, 219)
        Me.txtup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtup.Multiline = True
        Me.txtup.Name = "txtup"
        Me.txtup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtup.PreventEnterBeep = True
        Me.txtup.Size = New System.Drawing.Size(261, 25)
        Me.txtup.TabIndex = 3
        Me.txtup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtup.WatermarkText = "password"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.FontBold = True
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(11, 187)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(261, 32)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "PASSWORD"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtUn
        '
        '
        '
        '
        Me.txtUn.Border.Class = "TextBoxBorder"
        Me.txtUn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUn.Location = New System.Drawing.Point(11, 154)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUn.Multiline = True
        Me.txtUn.Name = "txtUn"
        Me.txtUn.PreventEnterBeep = True
        Me.txtUn.Size = New System.Drawing.Size(261, 25)
        Me.txtUn.TabIndex = 2
        Me.txtUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUn.WatermarkText = "username"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.label1.FontBold = True
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(11, 122)
        Me.label1.Margin = New System.Windows.Forms.Padding(4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(261, 32)
        Me.label1.TabIndex = 5
        Me.label1.Text = "USERNAME"
        Me.label1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(11, 92)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.PreventEnterBeep = True
        Me.txtName.Size = New System.Drawing.Size(261, 25)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtName.WatermarkText = "Name"
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
        Me.LabelX2.Location = New System.Drawing.Point(11, 60)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(261, 32)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "FULLNAME"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lvlUser
        '
        '
        '
        '
        Me.lvlUser.Border.Class = "ListViewBorder"
        Me.lvlUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvlUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.FullName, Me.Username, Me.Password})
        Me.lvlUser.DisabledBackColor = System.Drawing.Color.Empty
        Me.lvlUser.FullRowSelect = True
        Me.lvlUser.Location = New System.Drawing.Point(279, 60)
        Me.lvlUser.Name = "lvlUser"
        Me.lvlUser.Size = New System.Drawing.Size(323, 184)
        Me.lvlUser.TabIndex = 74
        Me.lvlUser.UseCompatibleStateImageBehavior = False
        Me.lvlUser.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "id"
        Me.ID.Width = 0
        '
        'FullName
        '
        Me.FullName.Text = "FullName"
        Me.FullName.Width = 200
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Username.Width = 120
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 0
        '
        'txtSeepassword
        '
        Me.txtSeepassword.AutoSize = True
        Me.txtSeepassword.Location = New System.Drawing.Point(11, 251)
        Me.txtSeepassword.Name = "txtSeepassword"
        Me.txtSeepassword.Size = New System.Drawing.Size(94, 17)
        Me.txtSeepassword.TabIndex = 75
        Me.txtSeepassword.Text = "See Password"
        Me.txtSeepassword.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        '
        '
        '
        Me.txtUserID.Border.Class = "TextBoxBorder"
        Me.txtUserID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(467, 13)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserID.Multiline = True
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PreventEnterBeep = True
        Me.txtUserID.Size = New System.Drawing.Size(10, 25)
        Me.txtUserID.TabIndex = 76
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SEPCOMUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSeepassword)
        Me.Controls.Add(Me.lvlUser)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtup)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtUserID)
        Me.Name = "SEPCOMUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEPCOMUser"
        Me.btnSearch.ResumeLayout(False)
        Me.btnSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStrip
    Friend WithEvents btnadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents label1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lvlUser As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents FullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSeepassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserID As DevComponents.DotNetBar.Controls.TextBoxX
End Class
