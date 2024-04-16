<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEPCOMLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEPCOMLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New DevComponents.DotNetBar.LabelX()
        Me.txtUn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnlogin = New DevComponents.DotNetBar.ButtonX()
        Me.btncancel = New DevComponents.DotNetBar.ButtonX()
        Me.lbldt = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtuname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txttype = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtupass = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.label1.Location = New System.Drawing.Point(248, 58)
        Me.label1.Margin = New System.Windows.Forms.Padding(4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(261, 32)
        Me.label1.TabIndex = 1
        Me.label1.Text = "USERNAME"
        Me.label1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtUn
        '
        '
        '
        '
        Me.txtUn.Border.Class = "TextBoxBorder"
        Me.txtUn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUn.Location = New System.Drawing.Point(248, 90)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUn.Multiline = True
        Me.txtUn.Name = "txtUn"
        Me.txtUn.PreventEnterBeep = True
        Me.txtUn.Size = New System.Drawing.Size(261, 25)
        Me.txtUn.TabIndex = 2
        Me.txtUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUn.WatermarkText = "username"
        '
        'txtup
        '
        '
        '
        '
        Me.txtup.Border.Class = "TextBoxBorder"
        Me.txtup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtup.Location = New System.Drawing.Point(248, 155)
        Me.txtup.Margin = New System.Windows.Forms.Padding(4)
        Me.txtup.Multiline = True
        Me.txtup.Name = "txtup"
        Me.txtup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtup.PreventEnterBeep = True
        Me.txtup.Size = New System.Drawing.Size(261, 25)
        Me.txtup.TabIndex = 4
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
        Me.LabelX1.Location = New System.Drawing.Point(248, 123)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(261, 32)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "PASSWORD"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnlogin
        '
        Me.btnlogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnlogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnlogin.Enabled = False
        Me.btnlogin.Location = New System.Drawing.Point(248, 200)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(126, 34)
        Me.btnlogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnlogin.Symbol = ""
        Me.btnlogin.SymbolColor = System.Drawing.Color.DarkGreen
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        '
        'btncancel
        '
        Me.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btncancel.Location = New System.Drawing.Point(383, 200)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(126, 34)
        Me.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btncancel.Symbol = ""
        Me.btncancel.SymbolColor = System.Drawing.Color.DarkGreen
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        '
        'lbldt
        '
        Me.lbldt.BackColor = System.Drawing.Color.SeaGreen
        '
        '
        '
        Me.lbldt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbldt.FontBold = True
        Me.lbldt.ForeColor = System.Drawing.Color.White
        Me.lbldt.Location = New System.Drawing.Point(22, 18)
        Me.lbldt.Margin = New System.Windows.Forms.Padding(4)
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(487, 32)
        Me.lbldt.TabIndex = 7
        Me.lbldt.Text = "Date and Time"
        Me.lbldt.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Timer1
        '
        '
        'txtuname
        '
        '
        '
        '
        Me.txtuname.Border.Class = "TextBoxBorder"
        Me.txtuname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtuname.Enabled = False
        Me.txtuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(635, 70)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuname.Multiline = True
        Me.txtuname.Name = "txtuname"
        Me.txtuname.PreventEnterBeep = True
        Me.txtuname.Size = New System.Drawing.Size(120, 25)
        Me.txtuname.TabIndex = 8
        Me.txtuname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtuname.WatermarkText = "username"
        '
        'txttype
        '
        '
        '
        '
        Me.txttype.Border.Class = "TextBoxBorder"
        Me.txttype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttype.Enabled = False
        Me.txttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.Location = New System.Drawing.Point(635, 118)
        Me.txttype.Margin = New System.Windows.Forms.Padding(4)
        Me.txttype.Multiline = True
        Me.txttype.Name = "txttype"
        Me.txttype.PreventEnterBeep = True
        Me.txttype.Size = New System.Drawing.Size(120, 25)
        Me.txttype.TabIndex = 9
        Me.txttype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttype.WatermarkText = "username"
        '
        'txtupass
        '
        '
        '
        '
        Me.txtupass.Border.Class = "TextBoxBorder"
        Me.txtupass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtupass.Enabled = False
        Me.txtupass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtupass.Location = New System.Drawing.Point(635, 160)
        Me.txtupass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtupass.Multiline = True
        Me.txtupass.Name = "txtupass"
        Me.txtupass.PreventEnterBeep = True
        Me.txtupass.Size = New System.Drawing.Size(120, 25)
        Me.txtupass.TabIndex = 10
        Me.txtupass.Text = "txt"
        Me.txtupass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtupass.WatermarkText = "username"
        '
        'SEPCOMLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtupass)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.lbldt)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtup)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SEPCOMLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents label1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnlogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btncancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbldt As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtuname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txttype As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtupass As DevComponents.DotNetBar.Controls.TextBoxX

End Class
