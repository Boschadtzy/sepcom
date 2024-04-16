Imports System.Data
Imports System.Data.SqlClient
Public Class SEPCOMUser

    Private Sub TsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsExit.Click
        Me.Hide()
    End Sub

    Private Sub SEPCOMUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetall()
    End Sub

    Sub addt()
       
        btnadd.Text = "&Save"
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnClear.Enabled = True
        txtName.Focus()
        txtName.Enabled = True
        txtUn.Enabled = True
        txtup.Enabled = True

    End Sub
    Sub fillemp()
        Try
            connect()
            lvlUser.Items.Clear()
            SQl = "SELECT * FROM SEPCOMUsers"
            Dim cmd As New SqlCommand(SQl, con)
            dr = cmd.ExecuteReader
            While (dr.Read())
                With lvlUser.Items.Add(dr("UtypeID"))
                    .subitems.add(dr("Name"))
                    .subitems.add(dr("Username"))
                    .subitems.add(dr("Password"))
                End With
            End While
            cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub resetall()
        btnadd.Enabled = True
        btnEdit.Enabled = False
        btnClear.Enabled = False
        btnDelete.Enabled = False
        txtName.Enabled = False
        txtUn.Enabled = False
        txtup.Enabled = False
        btnEdit.Text = "&Edit"
        btnadd.Text = "&Add"
        txtName.Focus()
        fillemp()
        txtName.Text = ""
        txtUn.Text = ""
        txtup.Text = ""
        txtUserID.Text = ""
    End Sub

    Private Sub lvlUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlUser.Click
        With lvlUser.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtName.Text = .SubItems(1).Text
            txtUn.Text = .SubItems(2).Text
            txtup.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnadd.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Text = "&Edit"
    End Sub

    Private Sub lvlUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvlUser.KeyDown
        With lvlUser.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtName.Text = .SubItems(1).Text
            txtUn.Text = .SubItems(2).Text
            txtup.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnadd.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Text = "&Edit"
    End Sub

    Private Sub lvlUser_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvlUser.KeyUp
        With lvlUser.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtName.Text = .SubItems(1).Text
            txtUn.Text = .SubItems(2).Text
            txtup.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnDelete.Enabled = True
        btnadd.Enabled = False
        btnEdit.Text = "&Edit"

    End Sub

    
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        resetall()
    End Sub

    Private Sub txtSeepassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeepassword.CheckedChanged
        If txtSeepassword.Checked = True Then

            txtup.PasswordChar = ""
        Else
            txtup.PasswordChar = "●"
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "&Add" Then
            addt()

            Exit Sub
        ElseIf btnadd.Text = "&Save" Then
            If txtName.Text = "" Or txtUn.Text = "" Or txtup.Text = "" Then
                MessageBox.Show("Complete the details !", "Missing value error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                connect()
                SQl = "SELECT * FROM SEPCOMUsers WHERE Name=@fd1"
                Dim cmd As New SqlCommand(SQl, con)
                cmd.Parameters.AddWithValue("@fd1", txtName.Text)
                dr = cmd.ExecuteReader
                If (dr.Read()) Then
                    txtName.Text = (dr("Name"))
                End If
                cmd.Dispose()
                dr.Close()

                connect()
                SQl = "INSERT INTO SEPCOMUsers(Name,Username,Password) VALUES (@empID,@fd1,@fd2)"
                Dim cmd1 As New SqlCommand(SQl, con)
                With cmd1
                    .Parameters.AddWithValue("@empID", txtName.Text)
                    .Parameters.AddWithValue("@fd1", txtUn.Text)
                    .Parameters.AddWithValue("@fd2", txtup.Text)
                End With
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

                MessageBox.Show("Information successfully added !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                resetall()
                'lvuser.Items(lvuser.Items.Count - 1).Selected = True
                'lvuser.Items(lvuser.Items.Count - 1).EnsureVisible()
                'lvuser.Focus()

            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim ans = MessageBox.Show("Delete this information ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbNo Then
            Exit Sub
        Else
            Dim anss = MessageBox.Show("Are you sure ?", "Select an option", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If anss = vbNo Then
                Exit Sub
            ElseIf anss = vbCancel Then
                Exit Sub
            ElseIf anss = vbYes Then
                Try
                    connect()
                    SQl = "DELETE FROM SEPCOMUsers WHERE UtypeID=@userID"
                    Dim cmd As New SqlCommand(SQl, con)
                    With cmd
                        .Parameters.AddWithValue("@userID", txtUserID.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    dr.Close()
                    MessageBox.Show("Information successfully deleted !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetall()
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Update"
            txtName.Enabled = True
            txtUn.Enabled = True
            txtup.Enabled = True
            txtName.Focus()
            Exit Sub
        ElseIf btnEdit.Text = "&Update" Then

            Try

                If txtName.Text = "" Or txtUn.Text = "" Or txtup.Text = "" Then
                    MessageBox.Show("Complete the details !", "Missing value error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    connect()
                    SQl = "UPDATE SEPCOMUsers SET [Name] = '" & txtName.Text.ToString & "',[Username]= '" & txtUn.Text.ToString & "',[Password]= '" & txtup.Text.ToString & "' WHERE UtypeID =@userID"
                    Dim cmd As New SqlCommand(SQl, con)
                    With cmd
                        .Parameters.AddWithValue("@userID", txtUserID.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    dr.Close()
                    MessageBox.Show("Information successfully updated !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    resetall()

                End If
            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub lvlUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlUser.SelectedIndexChanged

    End Sub
End Class