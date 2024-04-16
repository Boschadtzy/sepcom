Public Class SEPCOMMain

  

   

    Private Sub TsLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsLogout.Click
        Dim ans = MessageBox.Show("LOGOUT ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            ' astring = ""
            SEPCOMLogin.txtUn.Focus()
            SEPCOMLogin.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub TsCv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsCv.Click
        Dim f As New SEPCOMCheckVoucher
        f.MdiParent = Me
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
    End Sub

    Private Sub TsJv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsJv.Click
        Dim f As New SEPCOMJornalVoucher
        f.MdiParent = Me
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
    End Sub

    Private Sub SEPCOMMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblUtypeID.Text = "Login as:"
        lblUtypeID.Text = lblUtypeID.Text & " " & astring

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbldt.Text = " " & FormatDateTime(Date.Now, DateFormat.LongDate) & "   " & FormatDateTime(TimeOfDay, DateFormat.LongTime)
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Dim f As New SEPCOMUser
        f.MdiParent = Me
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
    End Sub

    Private Sub TsOperator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsOperator.Click
        Dim f As New SEPCOMOperator
        f.MdiParent = Me
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class