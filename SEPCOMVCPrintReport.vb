Public Class SEPCOMVCPrintReport

   
    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        On Error Resume Next
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 10, 20)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        SEPCOMCvViewDetails.Show()
        Me.Hide()
    End Sub
End Class