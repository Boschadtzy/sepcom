Imports System.Data
Imports System.Data.SqlClient
Public Class SEPCOMOperator


  
    Sub editt()
        btnEdit.Text = "&Update"
        txtprepared.Focus()
    End Sub
    Sub resetall()
        txtapproved.Enabled = False
        txtchecked.Enabled = False
        txtprepared.Enabled =False
        btnEdit.Enabled = False
        btnClear.Enabled = False
        btnEdit.Text = "&Edit"
        fillemp()
        txtapproved.Text = ""
        txtchecked.Text = ""
        txtprepared.Text = ""
        txtUserID.Text = ""
    End Sub
   

    Sub fillemp()
        Try
            connect()
            lvlOperator.Items.Clear()
            SQl = "SELECT * FROM Operator"
            Dim cmd As New SqlCommand(SQl, con)
            dr = cmd.ExecuteReader
            While (dr.Read())
                With lvlOperator.Items.Add(dr("ID"))
                    .subitems.add(dr("PreparedBy"))
                    .subitems.add(dr("CheckedBy"))
                    .subitems.add(dr("ApproveBy"))
                End With
            End While
            cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SEPCOMOperator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetall()
    End Sub

    Private Sub lvlOperator_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvlOperator.Click
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtprepared.Text = .SubItems(1).Text
            txtchecked.Text = .SubItems(2).Text
            txtapproved.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnEdit.Text = "&Edit"
    End Sub



    Private Sub lvOperator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvlOperator.KeyDown
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtprepared.Text = .SubItems(1).Text
            txtchecked.Text = .SubItems(2).Text
            txtapproved.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnEdit.Text = "&Edit"
    End Sub

    Private Sub lvOperator_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvlOperator.KeyUp
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtprepared.Text = .SubItems(1).Text
            txtchecked.Text = .SubItems(2).Text
            txtapproved.Text = .SubItems(3).Text
        End With
        btnEdit.Enabled = True
        btnClear.Enabled = True
        btnEdit.Text = "&Edit"
    End Sub

  

    Private Sub TsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsExit.Click
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        resetall()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            editt()
            txtapproved.Enabled = True
            txtchecked.Enabled = True
            txtprepared.Enabled = True
            txtprepared.Focus()
            Exit Sub
        ElseIf btnEdit.Text = "&Update" Then
           
            Try

                If txtapproved.Text = "" Or txtchecked.Text = "" Or txtprepared.Text = "" Then
                    MessageBox.Show("Complete the details !", "Missing value error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    connect()
                    SQl = "UPDATE Operator SET [PreparedBy] = '" & txtprepared.Text.ToString & "',[CheckedBy]= '" & txtchecked.Text.ToString & "',[ApproveBy]= '" & txtapproved.Text.ToString & "' WHERE ID =@userID"
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
End Class