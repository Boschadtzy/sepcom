Imports System.Data
Imports System.Data.SqlClient
Public Class SEPCOMLogin

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbldt.Text = " " & FormatDateTime(Date.Now, DateFormat.LongDate) & "   " & FormatDateTime(TimeOfDay, DateFormat.LongTime)
    End Sub

    Private Sub SEPCOMLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        txtUn.Focus()
        loading()
    End Sub

    Private Sub txtUn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUn.TextChanged
        btnenable()
    End Sub
    Sub loading()
        txtUn.Text = ""
        txtup.Text = ""
        txtUn.Focus()
    End Sub
    Sub btnenable()
        If txtUn.Text = "" Or txtup.Text = "" Then
            btnlogin.Enabled = False
        Else
            btnlogin.Enabled = True
        End If
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtup.TextChanged
        btnenable()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            connect()
            SQl = "SELECT * FROM SEPCOMUsers WHERE Username=@field1"
            Dim cmd As New sqlcommand(SQl, con)
            With cmd
                .Parameters.AddWithValue("@field1", txtun.Text)
            End With
            dr = cmd.ExecuteReader
            If (dr.Read()) Then
                txtuname.Text = (dr("Username"))
                txtupass.Text = (dr("Password"))
                txttype.Text = (dr("UtypeID"))
            End If

            'Compare Username and Password...... 
            If txtun.Text = txtuname.Text And txtup.Text = txtupass.Text Then
                connect()

                SQl = "SELECT * FROM SEPCOMUsers WHERE UtypeID=@field1"
                Dim cmd1 As New SqlCommand(SQl, con)
                With cmd1
                    .Parameters.AddWithValue("@field1", txttype.Text)
                End With
                dr = cmd1.ExecuteReader
                If (dr.Read()) Then
                    astring = (dr("Name"))
                End If


                MessageBox.Show("WELCOME " & astring, "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtuname.Text = ""
                txtupass.Text = ""
                txttype.Text = ""
                txtun.Text = ""
                txtup.Text = ""
                Me.Hide()
                SEPCOMMain.ShowDialog()
            Else
                MessageBox.Show("Invalid username or password, Please try again !", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtuname.Text = ""
                txtupass.Text = ""
                txttype.Text = ""
                txtUn.Text = ""
                txtup.Text = ""
                txtuname.Focus()
            End If
            'cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   
End Class
