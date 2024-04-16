<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEPCOMMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEPCOMMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsCv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsJv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsLogout = New System.Windows.Forms.ToolStripButton()
        Me.btnUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsOperator = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUtypeID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSepcomSystem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbldt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsCv, Me.ToolStripSeparator1, Me.TsJv, Me.ToolStripSeparator2, Me.TsLogout, Me.btnUser, Me.ToolStripSeparator3, Me.TsOperator})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1353, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsCv
        '
        Me.TsCv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsCv.ForeColor = System.Drawing.Color.White
        Me.TsCv.Image = CType(resources.GetObject("TsCv.Image"), System.Drawing.Image)
        Me.TsCv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsCv.Name = "TsCv"
        Me.TsCv.Size = New System.Drawing.Size(149, 36)
        Me.TsCv.Text = "Check Voucher"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'TsJv
        '
        Me.TsJv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsJv.ForeColor = System.Drawing.Color.White
        Me.TsJv.Image = CType(resources.GetObject("TsJv.Image"), System.Drawing.Image)
        Me.TsJv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsJv.Name = "TsJv"
        Me.TsJv.Size = New System.Drawing.Size(149, 36)
        Me.TsJv.Text = "Jornal Voucher"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'TsLogout
        '
        Me.TsLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TsLogout.ForeColor = System.Drawing.Color.White
        Me.TsLogout.Image = CType(resources.GetObject("TsLogout.Image"), System.Drawing.Image)
        Me.TsLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsLogout.Name = "TsLogout"
        Me.TsLogout.Size = New System.Drawing.Size(95, 36)
        Me.TsLogout.Text = "Logout"
        '
        'btnUser
        '
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageTransparentColor = System.Drawing.Color.SeaGreen
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(78, 36)
        Me.btnUser.Text = "User"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'TsOperator
        '
        Me.TsOperator.ForeColor = System.Drawing.Color.White
        Me.TsOperator.Image = CType(resources.GetObject("TsOperator.Image"), System.Drawing.Image)
        Me.TsOperator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsOperator.Name = "TsOperator"
        Me.TsOperator.Size = New System.Drawing.Size(109, 36)
        Me.TsOperator.Text = "Operator"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUtypeID, Me.lblSepcomSystem, Me.lbldt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 594)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1353, 29)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUtypeID
        '
        Me.lblUtypeID.AutoSize = False
        Me.lblUtypeID.BackColor = System.Drawing.Color.White
        Me.lblUtypeID.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblUtypeID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtypeID.Name = "lblUtypeID"
        Me.lblUtypeID.Size = New System.Drawing.Size(446, 24)
        Me.lblUtypeID.Spring = True
        Me.lblUtypeID.Text = "Login as: "
        '
        'lblSepcomSystem
        '
        Me.lblSepcomSystem.AutoSize = False
        Me.lblSepcomSystem.BackColor = System.Drawing.Color.White
        Me.lblSepcomSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblSepcomSystem.Name = "lblSepcomSystem"
        Me.lblSepcomSystem.Size = New System.Drawing.Size(446, 24)
        Me.lblSepcomSystem.Spring = True
        Me.lblSepcomSystem.Text = "SEPCOM SYSTEM"
        '
        'lbldt
        '
        Me.lbldt.AutoSize = False
        Me.lbldt.BackColor = System.Drawing.Color.White
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(446, 24)
        Me.lbldt.Spring = True
        Me.lbldt.Text = "Date and Time:"
        '
        'Timer1
        '
        '
        'SEPCOMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(1353, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "SEPCOMMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsCv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsJv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsLogout As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUtypeID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSepcomSystem As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbldt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsOperator As System.Windows.Forms.ToolStripButton
End Class
