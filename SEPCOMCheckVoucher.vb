Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Public Class SEPCOMCheckVoucher

    Private Sub TsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsExit.Click
        Me.Hide()
    End Sub

    Private Sub SEPCOMCheckVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetall()
        Timer1.Enabled = True
        fillemp()
        cvprint()
        resetnotall()
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
    Sub cvprint()
        Try
            connect()
            lvldataprint.Items.Clear()
            SQl = "SELECT * FROM CVPrint"
            Dim cmd As New SqlCommand(SQl, con)
            dr = cmd.ExecuteReader
            While (dr.Read())
                With lvldataprint.Items.Add(dr("IDno"))
                    .subitems.add(dr("Cvno"))
                    .subitems.add(dr("Date"))
                    .subitems.add(dr("Paidto"))
                    .subitems.add(dr("address"))
                    .subitems.add(dr("Bank"))
                    .subitems.add(dr("Bankno"))
                    .subitems.add(dr("Acc1"))
                    .subitems.add(dr("Acc2"))
                    .subitems.add(dr("Acc3"))
                    .subitems.add(dr("Acc4"))
                    .subitems.add(dr("Acc5"))
                    .subitems.add(dr("Acc6"))
                    .subitems.add(dr("Acc7"))
                    .subitems.add(dr("Acc8"))
                    .subitems.add(dr("Acc9"))
                    .subitems.add(dr("Acc10"))
                    .subitems.add(dr("Acc11"))
                    .subitems.add(dr("Acc12"))
                    .subitems.add(dr("Acc13"))
                    .subitems.add(dr("Acc14"))
                    .subitems.add(dr("Acc15"))
                    .subitems.add(dr("Debit1"))
                    .subitems.add(dr("Debit2"))
                    .subitems.add(dr("Debit3"))
                    .subitems.add(dr("Debit4"))
                    .subitems.add(dr("Debit5"))
                    .subitems.add(dr("Debit6"))
                    .subitems.add(dr("Debit7"))
                    .subitems.add(dr("Debit8"))
                    .subitems.add(dr("Debit9"))
                    .subitems.add(dr("Debit10"))
                    .subitems.add(dr("Credit1"))
                    .subitems.add(dr("Credit2"))
                    .subitems.add(dr("Credit3"))
                    .subitems.add(dr("Credit4"))
                    .subitems.add(dr("Credit5"))
                    .subitems.add(dr("Explanation"))
                    .subitems.add(dr("Receive"))
                    .subitems.add(dr("Preparedby"))
                    .subitems.add(dr("Checkedby"))
                    .subitems.add(dr("ApprovedBy"))
                    .subitems.add(dr("Payee"))
                    .subitems.add(dr("Date1"))
                    .subitems.add(dr("Date2"))
                    .subitems.add(dr("Date3"))
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
        btnadd.Text = "Add"
        btnEdit.Enabled = False
        btnView.Enabled = True
        txtBankNo.Enabled = False
        btnEdit.Text = "Edit"
        btnClear.Enabled = False
        btnprint.Enabled = False
        txtaddress.Enabled = False
        txtApprove.Enabled = False
        txtBank.Enabled = False
        txtCheck.Enabled = False
        txtCredit1.Enabled = False
        txtCredit2.Enabled = False
        txtCredit3.Enabled = False
        txtCredit4.Enabled = False
        txtCredit5.Enabled = False
        txtCvno.Enabled = False
        txtDate.Enabled = False
        txtDate1.Enabled = False
        txtDate2.Enabled = False
        txtDate3.Enabled = False
        txtDebit1.Enabled = False
        txtDebit10.Enabled = False
        txtDebit2.Enabled = False
        txtDebit3.Enabled = False
        txtDebit4.Enabled = False
        txtDebit5.Enabled = False
        txtDebit6.Enabled = False
        txtDebit7.Enabled = False
        txtDebit8.Enabled = False
        txtDebit9.Enabled = False
        txtExplanation.Enabled = False
        txtPaidto.Enabled = False
        txtPayee.Enabled = False
        txtPrepared.Enabled = False
        txtReceived.Enabled = False
        cbAcc1.Enabled = False
        cbAcc2.Enabled = False
        cbAcc3.Enabled = False
        cbAcc4.Enabled = False
        cbAcc5.Enabled = False
        cbAcc6.Enabled = False
        cbAcc7.Enabled = False
        cbAcc8.Enabled = False
        cbAcc9.Enabled = False
        cbAcc10.Enabled = False
        cbAcc11.Enabled = False
        cbAcc12.Enabled = False
        cbAcc13.Enabled = False
        cbAcc14.Enabled = False
        cbAcc15.Enabled = False

        acc1.Enabled = False
        acc2.Enabled = False
        acc3.Enabled = False
        acc4.Enabled = False
        acc5.Enabled = False
        acc6.Enabled = False
        acc7.Enabled = False
        acc8.Enabled = False
        acc9.Enabled = False
        acc10.Enabled = False
        acc11.Enabled = False
        acc12.Enabled = False
        acc13.Enabled = False
        acc14.Enabled = False
        acc15.Enabled = False



        txtBankNo.Text = ""
        txtCvno.Text = ""
        txtaddress.Text = ""
        txtApprove.Text = ""
        txtBank.Text = ""
        txtBankNo.Text = ""
        txtCheck.Text = ""
        txtCredit1.Text = ""
        txtCredit2.Text = ""
        txtCredit3.Text = ""
        txtCredit4.Text = ""
        txtCredit5.Text = ""
        txtCvno.Text = ""
        txtDate.Text = ""
        txtDate3.Text = ""
        txtDate2.Text = ""
        txtDebit1.Text = ""
        txtDebit10.Text = ""
        txtDebit2.Text = ""
        txtDebit3.Text = ""
        txtDebit4.Text = ""
        txtDebit5.Text = ""
        txtDebit6.Text = ""
        txtDebit7.Text = ""
        txtDebit8.Text = ""
        txtDebit7.Text = ""
        txtExplanation.Text = ""
        txtPaidto.Text = ""
        txtPayee.Text = ""
        txtPrepared.Text = ""
        txtReceived.Text = ""
        cbAcc1.Text = ""
        cbAcc1.Text = ""
        cbAcc10.Text = ""
        cbAcc11.Text = ""
        cbAcc12.Text = ""
        cbAcc13.Text = ""
        cbAcc14.Text = ""
        cbAcc15.Text = ""
        cbAcc2.Text = ""
        cbAcc3.Text = ""
        cbAcc4.Text = ""
        cbAcc5.Text = ""
        cbAcc6.Text = ""
        cbAcc7.Text = ""
        cbAcc8.Text = ""
        cbAcc9.Text = ""
        cbAcc11.Text = ""
        cbAcc12.Text = ""
        cbAcc13.Text = ""
        cbAcc14.Text = ""
        cbAcc15.Text = ""

        acc1.Text = ""
        acc1.Text = ""
        acc10.Text = ""
        acc11.Text = ""
        acc12.Text = ""
        acc13.Text = ""
        acc14.Text = ""
        acc15.Text = ""
        acc2.Text = ""
        acc3.Text = ""
        acc4.Text = ""
        acc5.Text = ""
        acc6.Text = ""
        acc7.Text = ""
        acc8.Text = ""
        acc9.Text = ""
        acc11.Text = ""
        acc12.Text = ""
        acc13.Text = ""
        acc14.Text = ""
        acc15.Text = ""

    End Sub


    Sub add()
        txtCvno.Focus()
        btnadd.Text = "Save"
        btnEdit.Enabled = False
        btnView.Enabled = True
        btnClear.Enabled = True


        txtBankNo.Enabled = True
        txtaddress.Enabled = True
        txtApprove.Enabled = True
        txtBank.Enabled = True
        txtCheck.Enabled = True
        txtCredit1.Enabled = True
        txtCredit2.Enabled = True
        txtCredit3.Enabled = True
        txtCredit4.Enabled = True
        txtCredit5.Enabled = True
        txtCvno.Enabled = True
        txtDate.Enabled = True
        txtDate1.Enabled = True
        txtDate2.Enabled = True
        txtDate3.Enabled = True
        txtDebit1.Enabled = True
        txtDebit10.Enabled = True
        txtDebit2.Enabled = True
        txtDebit3.Enabled = True
        txtDebit4.Enabled = True
        txtDebit5.Enabled = True
        txtDebit6.Enabled = True
        txtDebit7.Enabled = True
        txtDebit8.Enabled = True
        txtDebit9.Enabled = True
        txtExplanation.Enabled = True
        txtPaidto.Enabled = True
        txtPayee.Enabled = True
        txtPrepared.Enabled = True
        txtReceived.Enabled = True
        cbAcc1.Enabled = True
        cbAcc2.Enabled = True
        cbAcc3.Enabled = True
        cbAcc4.Enabled = True
        cbAcc5.Enabled = True
        cbAcc6.Enabled = True
        cbAcc7.Enabled = True
        cbAcc8.Enabled = True
        cbAcc9.Enabled = True
        cbAcc10.Enabled = True
        cbAcc11.Enabled = True
        cbAcc12.Enabled = True
        cbAcc13.Enabled = True
        cbAcc14.Enabled = True
        cbAcc15.Enabled = True

        acc1.Enabled = True
        acc2.Enabled = True
        acc3.Enabled = True
        acc4.Enabled = True
        acc5.Enabled = True
        acc6.Enabled = True
        acc7.Enabled = True
        acc8.Enabled = True
        acc9.Enabled = True
        acc10.Enabled = True
        acc11.Enabled = True
        acc12.Enabled = True
        acc13.Enabled = True
        acc14.Enabled = True
        acc15.Enabled = True

        txtBankNo.Text = ""
        txtCvno.Text = ""
        txtaddress.Text = ""
        txtApprove.Text = ""
        txtBank.Text = ""
        txtBankNo.Text = ""
        txtCheck.Text = ""
        txtCredit1.Text = ""
        txtCredit2.Text = ""
        txtCredit3.Text = ""
        txtCredit4.Text = ""
        txtCredit5.Text = ""
        txtCvno.Text = ""
        txtDate.Text = ""
        txtDate3.Text = ""
        txtDate2.Text = ""
        txtDebit1.Text = ""
        txtDebit10.Text = ""
        txtDebit2.Text = ""
        txtDebit3.Text = ""
        txtDebit4.Text = ""
        txtDebit5.Text = ""
        txtDebit6.Text = ""
        txtDebit7.Text = ""
        txtDebit8.Text = ""
        txtDebit9.Text = ""
        txtExplanation.Text = ""
        txtPaidto.Text = ""
        txtPayee.Text = ""
        txtPrepared.Text = ""
        txtReceived.Text = ""
        cbAcc1.Text = ""
        cbAcc1.Text = ""
        cbAcc10.Text = ""
        cbAcc11.Text = ""
        cbAcc12.Text = ""
        cbAcc13.Text = ""
        cbAcc14.Text = ""
        cbAcc15.Text = ""
        cbAcc2.Text = ""
        cbAcc3.Text = ""
        cbAcc4.Text = ""
        cbAcc5.Text = ""
        cbAcc6.Text = ""
        cbAcc7.Text = ""
        cbAcc8.Text = ""
        cbAcc9.Text = ""
        cbAcc11.Text = ""
        cbAcc12.Text = ""
        cbAcc13.Text = ""
        cbAcc14.Text = ""
        cbAcc15.Text = ""

        acc1.Text = ""
        acc1.Text = ""
        acc10.Text = ""
        acc11.Text = ""
        acc12.Text = ""
        acc13.Text = ""
        acc14.Text = ""
        acc15.Text = ""
        acc2.Text = ""
        acc3.Text = ""
        acc4.Text = ""
        acc5.Text = ""
        acc6.Text = ""
        acc7.Text = ""
        acc8.Text = ""
        acc9.Text = ""
        acc11.Text = ""
        acc12.Text = ""
        acc13.Text = ""
        acc14.Text = ""
        acc15.Text = ""
    End Sub

    Sub edit()
        txtCvno.Focus()
        btnView.Enabled = True
        btnClear.Enabled = True


        txtBankNo.Enabled = True
        txtaddress.Enabled = True
        txtApprove.Enabled = True
        txtBank.Enabled = True
        txtCheck.Enabled = True
        txtCredit1.Enabled = True
        txtCredit2.Enabled = True
        txtCredit3.Enabled = True
        txtCredit4.Enabled = True
        txtCredit5.Enabled = True
        txtCvno.Enabled = True
        txtDate.Enabled = True
        txtDate1.Enabled = True
        txtDate2.Enabled = True
        txtDate3.Enabled = True
        txtDebit1.Enabled = True
        txtDebit10.Enabled = True
        txtDebit2.Enabled = True
        txtDebit3.Enabled = True
        txtDebit4.Enabled = True
        txtDebit5.Enabled = True
        txtDebit6.Enabled = True
        txtDebit7.Enabled = True
        txtDebit8.Enabled = True
        txtDebit9.Enabled = True
        txtExplanation.Enabled = True
        txtPaidto.Enabled = True
        txtPayee.Enabled = True
        txtPrepared.Enabled = True
        txtReceived.Enabled = True
        cbAcc1.Enabled = True
        cbAcc2.Enabled = True
        cbAcc3.Enabled = True
        cbAcc4.Enabled = True
        cbAcc5.Enabled = True
        cbAcc6.Enabled = True
        cbAcc7.Enabled = True
        cbAcc8.Enabled = True
        cbAcc9.Enabled = True
        cbAcc10.Enabled = True
        cbAcc11.Enabled = True
        cbAcc12.Enabled = True
        cbAcc13.Enabled = True
        cbAcc14.Enabled = True
        cbAcc15.Enabled = True

        acc1.Enabled = True
        acc2.Enabled = True
        acc3.Enabled = True
        acc4.Enabled = True
        acc5.Enabled = True
        acc6.Enabled = True
        acc7.Enabled = True
        acc8.Enabled = True
        acc9.Enabled = True
        acc10.Enabled = True
        acc11.Enabled = True
        acc12.Enabled = True
        acc13.Enabled = True
        acc14.Enabled = True
        acc15.Enabled = True

       
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If btnadd.Text = "Add" Then
            add()
            txtCvno.Focus()
            Exit Sub
        ElseIf btnadd.Text = "Save" Then
            If txtCvno.Text = "" Then
                MessageBox.Show("Complete the details !", "Missing value error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                connect()
                SQl = "INSERT INTO CVPrint(Cvno,Date,Paidto,Address,Bank,Bankno,Acc1,Acc2,Acc3,Acc4,Acc5,Acc6,Acc7,Acc8,Acc9,Acc10,Acc11,Acc12,Acc13,Acc14,Acc15,Debit1,Debit2,Debit3,Debit4,Debit5,Debit6,Debit7,Debit8,Debit9,Debit10,Credit1,Credit2,Credit3,Credit4,Credit5,Explanation,Receive,Preparedby,Checkedby,ApprovedBy,Payee,Date1,Date2,Date3,CCE,LAR,INVS,OFALT,FAC,PE,SD,AP,AIP,MMFP,MBFP,DTFU,IOACPRP,FHIT,NP,RFP,MBF,PUSC,DAG,SF,TOTALEQUITY,AI,MF,INTINC,FAL,SAL,AHS,OHAA,RE,IA,RAM,PFPLOL,SOMS,MSDL,CE,BC,EB,LWP,GAME,TDE,MI,MMB,TL,TAT,AAIE,FAH,DAA,SEAOC,IE,RAE,MB,AF,PF,SS,MISC) VALUES (@fd1,@fd2,@fd3,@fd4,@fd5,@fd6,@fd7,@fd8,@fd9,@fd10,@fd11,@fd12,@fd13,@fd14,@fd15,@fd16,@fd17,@fd18,@fd19,@fd20,@fd21,@fd22,@fd23,@fd24,@fd25,@fd26,@fd27,@fd28,@fd29,@fd30,@fd31,@fd32,@fd33,@fd34,@fd35,@fd36,@fd37,@fd38,@fd39,@fd40,@fd41,@fd42,@fd43,@fd44,@fd45,@fd46,@fd47,@fd48,@fd49,@fd50,@fd51,@fd52,@fd55,@fd56,@fd57,@fd58,@fd59,@fd60,@fd61,@fd62,@fd64,@fd65,@fd66,@fd69,@fd70,@fd71,@fd74,@fd75,@fd76,@fd78,@fd79,@fd80,@fd81,@fd82,@fd83,@fd84,@fd85,@fd86,@fd87,@fd88,@fd89,@fd90,@fd91,@fd92,@fd93,@fd94,@fd95,@fd96,@fd97,@fd98,@fd99,@fd100,@fd101,@fd102,@fd103,@fd104,@fd105,@fd106,@fd107,@fd108)"
                Dim cmd1 As New SqlCommand(SQl, con)
                With cmd1
                    .Parameters.AddWithValue("@fd1", txtCvno.Text)
                    .Parameters.AddWithValue("@fd2", txtDate.Text)
                    .Parameters.AddWithValue("@fd3", txtPaidto.Text)
                    .Parameters.AddWithValue("@fd4", txtaddress.Text)
                    .Parameters.AddWithValue("@fd5", txtBank.Text)
                    .Parameters.AddWithValue("@fd6", txtBankNo.Text)
                    .Parameters.AddWithValue("@fd7", acc1.Text)
                    .Parameters.AddWithValue("@fd8", acc2.Text)
                    .Parameters.AddWithValue("@fd9", acc3.Text)
                    .Parameters.AddWithValue("@fd10", acc4.Text)
                    .Parameters.AddWithValue("@fd11", acc5.Text)
                    .Parameters.AddWithValue("@fd12", acc6.Text)
                    .Parameters.AddWithValue("@fd13", acc7.Text)
                    .Parameters.AddWithValue("@fd14", acc8.Text)
                    .Parameters.AddWithValue("@fd15", acc9.Text)
                    .Parameters.AddWithValue("@fd16", acc10.Text)
                    .Parameters.AddWithValue("@fd17", acc11.Text)
                    .Parameters.AddWithValue("@fd18", acc12.Text)
                    .Parameters.AddWithValue("@fd19", acc13.Text)
                    .Parameters.AddWithValue("@fd20", acc14.Text)
                    .Parameters.AddWithValue("@fd21", acc15.Text)
                    .Parameters.AddWithValue("@fd22", txtDebit1.Text)
                    .Parameters.AddWithValue("@fd23", txtDebit2.Text)
                    .Parameters.AddWithValue("@fd24", txtDebit3.Text)
                    .Parameters.AddWithValue("@fd25", txtDebit4.Text)
                    .Parameters.AddWithValue("@fd26", txtDebit5.Text)
                    .Parameters.AddWithValue("@fd27", txtDebit6.Text)
                    .Parameters.AddWithValue("@fd28", txtDebit7.Text)
                    .Parameters.AddWithValue("@fd29", txtDebit8.Text)
                    .Parameters.AddWithValue("@fd30", txtDebit7.Text)
                    .Parameters.AddWithValue("@fd31", txtDebit10.Text)
                    .Parameters.AddWithValue("@fd32", txtCredit1.Text)
                    .Parameters.AddWithValue("@fd33", txtCredit2.Text)
                    .Parameters.AddWithValue("@fd34", txtCredit3.Text)
                    .Parameters.AddWithValue("@fd35", txtCredit4.Text)
                    .Parameters.AddWithValue("@fd36", txtCredit5.Text)
                    .Parameters.AddWithValue("@fd37", txtExplanation.Text)
                    .Parameters.AddWithValue("@fd38", txtReceived.Text)
                    .Parameters.AddWithValue("@fd39", txtPrepared.Text)
                    .Parameters.AddWithValue("@fd40", txtCheck.Text)
                    .Parameters.AddWithValue("@fd41", txtApprove.Text)
                    .Parameters.AddWithValue("@fd42", txtPayee.Text)
                    .Parameters.AddWithValue("@fd43", txtDate1.Text)
                    .Parameters.AddWithValue("@fd44", txtDate2.Text)
                    .Parameters.AddWithValue("@fd45", txtDate3.Text)
                    .Parameters.AddWithValue("@fd46", t1.Text)
                    .Parameters.AddWithValue("@fd47", t2.Text)
                    .Parameters.AddWithValue("@fd48", t3.Text)
                    .Parameters.AddWithValue("@fd49", txtTCA.Text)
                    .Parameters.AddWithValue("@fd50", t4.Text)
                    .Parameters.AddWithValue("@fd51", t5.Text)
                    .Parameters.AddWithValue("@fd52", t6.Text)
                   
                    .Parameters.AddWithValue("@fd55", t7.Text)
                    .Parameters.AddWithValue("@fd56", t8.Text)
                    .Parameters.AddWithValue("@fd57", t9.Text)
                    .Parameters.AddWithValue("@fd58", t10.Text)
                    .Parameters.AddWithValue("@fd59", t11.Text)
                    .Parameters.AddWithValue("@fd60", t12.Text)
                    .Parameters.AddWithValue("@fd61", t13.Text)
                    .Parameters.AddWithValue("@fd62", t14.Text)

                    .Parameters.AddWithValue("@fd64", t15.Text)
                    .Parameters.AddWithValue("@fd65", t16.Text)
                    .Parameters.AddWithValue("@fd66", t17.Text)
                 
                    .Parameters.AddWithValue("@fd69", t18.Text)
                    .Parameters.AddWithValue("@fd70", t19.Text)
                    .Parameters.AddWithValue("@fd71", t20.Text)
                  
                    .Parameters.AddWithValue("@fd74", t21.Text)
                    .Parameters.AddWithValue("@fd75", t22.Text)
                    .Parameters.AddWithValue("@fd76", t23.Text)

                    .Parameters.AddWithValue("@fd78", t24.Text)
                    .Parameters.AddWithValue("@fd79", t25.Text)
                    .Parameters.AddWithValue("@fd80", t26.Text)
                    .Parameters.AddWithValue("@fd81", t27.Text)
                    .Parameters.AddWithValue("@fd82", t28.Text)
                    .Parameters.AddWithValue("@fd83", t29.Text)
                    .Parameters.AddWithValue("@fd84", t30.Text)
                    .Parameters.AddWithValue("@fd85", t31.Text)
                    .Parameters.AddWithValue("@fd86", t32.Text)
                    .Parameters.AddWithValue("@fd87", t33.Text)
                    .Parameters.AddWithValue("@fd88", t34.Text)
                    .Parameters.AddWithValue("@fd89", t35.Text)
                    .Parameters.AddWithValue("@fd90", t36.Text)
                    .Parameters.AddWithValue("@fd91", t37.Text)
                    .Parameters.AddWithValue("@fd92", t38.Text)
                    .Parameters.AddWithValue("@fd93", t39.Text)
                    .Parameters.AddWithValue("@fd94", t40.Text)
                    .Parameters.AddWithValue("@fd95", t41.Text)
                    .Parameters.AddWithValue("@fd96", t42.Text)
                    .Parameters.AddWithValue("@fd97", t43.Text)
                    .Parameters.AddWithValue("@fd98", t44.Text)
                    .Parameters.AddWithValue("@fd99", t45.Text)
                    .Parameters.AddWithValue("@fd100", t46.Text)
                    .Parameters.AddWithValue("@fd101", t47.Text)
                    .Parameters.AddWithValue("@fd102", t48.Text)
                    .Parameters.AddWithValue("@fd103", t49.Text)
                    .Parameters.AddWithValue("@fd104", t50.Text)
                    .Parameters.AddWithValue("@fd105", t51.Text)
                    .Parameters.AddWithValue("@fd106", t52.Text)
                    .Parameters.AddWithValue("@fd107", t53.Text)
                    .Parameters.AddWithValue("@fd108", t54.Text)

                   

                End With
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

                MessageBox.Show("Information successfully added !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cvprint()
                btnprint.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



   
   
    Private Sub cbAcc1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    



    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        SEPCOMCvViewDetails.Show()

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        resetall()
        resetnotall()
    End Sub
    Sub resetnotall()
        t1.Text = "0"
        t2.Text = "0"
        t3.Text = "0"
        t4.Text = "0"
        t5.Text = "0"
        t6.Text = "0"
        t7.Text = "0"
        t8.Text = "0"
        t9.Text = "0"
        t10.Text = "0"
        t11.Text = "0"
        t12.Text = "0"
        t13.Text = "0"
        t14.Text = "0"
        t15.Text = "0"
        t16.Text = "0"
        t17.Text = "0"
        t18.Text = "0"
        t19.Text = "0"
        t20.Text = "0"
        t21.Text = "0"
        t22.Text = "0"
        t23.Text = "0"
        t24.Text = "0"
        t25.Text = "0"
        t26.Text = "0"
        t27.Text = "0"
        t28.Text = "0"
        t29.Text = "0"
        t30.Text = "0"
        t31.Text = "0"
        t32.Text = "0"
        t33.Text = "0"
        t34.Text = "0"
        t35.Text = "0"
        t36.Text = "0"
        t37.Text = "0"
        t38.Text = "0"
        t39.Text = "0"
        t40.Text = "0"
        t41.Text = "0"
        t42.Text = "0"
        t43.Text = "0"
        t44.Text = "0"
        t45.Text = "0"
        t46.Text = "0"
        t47.Text = "0"
        t48.Text = "0"
        t49.Text = "0"
        t50.Text = "0"
        t51.Text = "0"
        t52.Text = "0"
        t53.Text = "0"
        t54.Text = "0"
       
    End Sub

    Private Sub lvldataprint_Click(sender As Object, e As System.EventArgs)
        On Error Resume Next
        With lvldataprint.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtdate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            acc1.Text = .SubItems(7).Text
            acc2.Text = .SubItems(8).Text
            acc3.Text = .SubItems(9).Text
            acc4.Text = .SubItems(10).Text
            acc5.Text = .SubItems(11).Text
            acc6.Text = .SubItems(12).Text
            acc7.Text = .SubItems(13).Text
            acc8.Text = .SubItems(14).Text
            acc9.Text = .SubItems(15).Text
            acc10.Text = .SubItems(16).Text
            acc11.Text = .SubItems(17).Text
            acc12.Text = .SubItems(18).Text
            acc13.Text = .SubItems(19).Text
            acc14.Text = .SubItems(20).Text
            acc15.Text = .SubItems(21).Text
            txtDebit1.Text = .SubItems(22).Text
            txtDebit2.Text = .SubItems(23).Text
            txtDebit3.Text = .SubItems(24).Text
            txtDebit4.Text = .SubItems(25).Text
            txtDebit5.Text = .SubItems(26).Text
            txtDebit6.Text = .SubItems(27).Text
            txtDebit7.Text = .SubItems(28).Text
            txtDebit8.Text = .SubItems(29).Text
            txtDebit9.Text = .SubItems(30).Text
            txtDebit10.Text = .SubItems(31).Text
            txtCredit1.Text = .SubItems(32).Text
            txtCredit2.Text = .SubItems(33).Text
            txtCredit3.Text = .SubItems(34).Text
            txtCredit4.Text = .SubItems(35).Text
            txtCredit5.Text = .SubItems(36).Text
            txtExplanation.Text = .SubItems(37).Text
            txtReceived.Text = .SubItems(38).Text
            txtPrepared.Text = .SubItems(39).Text
            txtCheck.Text = .SubItems(40).Text
            txtApprove.Text = .SubItems(41).Text
            txtPayee.Text = .SubItems(42).Text
            txtDate1.Text = .SubItems(43).Text
            txtDate2.Text = .SubItems(44).Text
            txtDate3.Text = .SubItems(45).Text


        End With
        btnEdit.Enabled = True
        btnadd.Enabled = False
        btnEdit.Text = "Edit"
        btnClear.Enabled = True
    End Sub

    Private Sub lvldataprint_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        On Error Resume Next
        With lvldataprint.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtdate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            acc1.Text = .SubItems(7).Text
            acc2.Text = .SubItems(8).Text
            acc3.Text = .SubItems(9).Text
            acc4.Text = .SubItems(10).Text
            acc5.Text = .SubItems(11).Text
            acc6.Text = .SubItems(12).Text
            acc7.Text = .SubItems(13).Text
            acc8.Text = .SubItems(14).Text
            acc9.Text = .SubItems(15).Text
            acc10.Text = .SubItems(16).Text
            acc11.Text = .SubItems(17).Text
            acc12.Text = .SubItems(18).Text
            acc13.Text = .SubItems(19).Text
            acc14.Text = .SubItems(20).Text
            acc15.Text = .SubItems(21).Text
            txtDebit1.Text = .SubItems(22).Text
            txtDebit2.Text = .SubItems(23).Text
            txtDebit3.Text = .SubItems(24).Text
            txtDebit4.Text = .SubItems(25).Text
            txtDebit5.Text = .SubItems(26).Text
            txtDebit6.Text = .SubItems(27).Text
            txtDebit7.Text = .SubItems(28).Text
            txtDebit8.Text = .SubItems(29).Text
            txtDebit9.Text = .SubItems(30).Text
            txtDebit10.Text = .SubItems(31).Text
            txtCredit1.Text = .SubItems(32).Text
            txtCredit2.Text = .SubItems(33).Text
            txtCredit3.Text = .SubItems(34).Text
            txtCredit4.Text = .SubItems(35).Text
            txtCredit5.Text = .SubItems(36).Text
            txtExplanation.Text = .SubItems(37).Text
            txtReceived.Text = .SubItems(38).Text
            txtPrepared.Text = .SubItems(39).Text
            txtCheck.Text = .SubItems(40).Text
            txtApprove.Text = .SubItems(41).Text
            txtPayee.Text = .SubItems(42).Text
            txtDate1.Text = .SubItems(43).Text
            txtDate2.Text = .SubItems(44).Text
            txtDate3.Text = .SubItems(45).Text


        End With
        btnEdit.Enabled = True
        btnEdit.Text = "Edit"
        btnadd.Enabled = False
        btnClear.Enabled = True
    End Sub

    Private Sub lvldataprint_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
       
    End Sub

  

    Private Sub lvldataprint_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LabelX16_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
       
    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        SEPCOMCvPrint.lblcvno.Text = txtCvno.Text
        SEPCOMCvPrint.lbldate.Text = txtDate.Text
        SEPCOMCvPrint.lblpaid.Text = txtPaidto.Text
        SEPCOMCvPrint.lbladdress.Text = txtaddress.Text

        SEPCOMCvPrint.lblbank.Text = txtBank.Text
        SEPCOMCvPrint.lblbankno.Text = txtBankNo.Text
        SEPCOMCvPrint.lblacc1.Text = acc1.Text
        SEPCOMCvPrint.lblacc2.Text = acc2.Text
        SEPCOMCvPrint.lblacc3.Text = acc3.Text
        SEPCOMCvPrint.lblacc4.Text = acc4.Text
        SEPCOMCvPrint.lblacc5.Text = acc5.Text
        SEPCOMCvPrint.lblacc6.Text = acc6.Text
        SEPCOMCvPrint.lblacc7.Text = acc7.Text
        SEPCOMCvPrint.lblacc8.Text = acc8.Text
        SEPCOMCvPrint.lblacc9.Text = acc9.Text
        SEPCOMCvPrint.lblacc10.Text = acc10.Text
        SEPCOMCvPrint.lblacc11.Text = acc11.Text
        SEPCOMCvPrint.lblacc12.Text = acc12.Text
        SEPCOMCvPrint.lblacc13.Text = acc13.Text
        SEPCOMCvPrint.lblacc14.Text = acc14.Text
        SEPCOMCvPrint.lblacc15.Text = acc15.Text
        SEPCOMCvPrint.lbldebit1.Text = txtDebit1.Text
        SEPCOMCvPrint.lbldebit2.Text = txtDebit2.Text
        SEPCOMCvPrint.lbldebit3.Text = txtDebit3.Text
        SEPCOMCvPrint.lbldebit4.Text = txtDebit4.Text
        SEPCOMCvPrint.lbldebit5.Text = txtDebit5.Text
        SEPCOMCvPrint.lbldebit6.Text = txtDebit6.Text
        SEPCOMCvPrint.lbldebit7.Text = txtDebit7.Text

        SEPCOMCvPrint.lbldebit8.Text = txtDebit8.Text
        SEPCOMCvPrint.lbldebit9.Text = txtDebit9.Text
        SEPCOMCvPrint.lbldebit10.Text = txtDebit10.Text
        SEPCOMCvPrint.lblcredit1.Text = txtCredit1.Text
        SEPCOMCvPrint.lblcredit2.Text = txtCredit2.Text
        SEPCOMCvPrint.lblcredit3.Text = txtCredit3.Text
        SEPCOMCvPrint.lblcredit4.Text = txtCredit4.Text
        SEPCOMCvPrint.lblcredit5.Text = txtCredit5.Text
        SEPCOMCvPrint.lblexplanation.Text = txtExplanation.Text
        SEPCOMCvPrint.lblreceive.Text = txtReceived.Text

        SEPCOMCvPrint.lblprepared.Text = txtPrepared.Text
        SEPCOMCvPrint.lblchecked.Text = txtCheck.Text
        SEPCOMCvPrint.lblapproved.Text = txtApprove.Text
        SEPCOMCvPrint.lblpayee.Text = txtPayee.Text
        SEPCOMCvPrint.lbldate1.Text = txtDate1.Text
        SEPCOMCvPrint.lbldate2.Text = txtDate2.Text
        SEPCOMCvPrint.lbldate3.Text = txtDate3.Text

        SEPCOMCvPrint.Show()

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        edit()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try

            connect()
            lvldataprint.Items.Clear()
            SQl = "SELECT * FROM CVPrint WHERE [Cvno] like  '%" & txtsearch.Text & "%' or [Paidto] like '%" & txtsearch.Text & "%'"
            Dim cmd As New SqlCommand(SQl, con)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            While (dr.Read())
                With lvldataprint.Items.Add(dr("Cvno"))
                    .subitems.add(dr("Cvno"))
                    .subitems.add(dr("Date"))
                    .subitems.add(dr("Paidto"))
                    .subitems.add(dr("address"))
                    .subitems.add(dr("Bank"))
                    .subitems.add(dr("Bankno"))
                    .subitems.add(dr("Acc1"))
                    .subitems.add(dr("Acc2"))
                    .subitems.add(dr("Acc3"))
                    .subitems.add(dr("Acc4"))
                    .subitems.add(dr("Acc5"))
                    .subitems.add(dr("Acc6"))
                    .subitems.add(dr("Acc7"))
                    .subitems.add(dr("Acc8"))
                    .subitems.add(dr("Acc9"))
                    .subitems.add(dr("Acc10"))
                    .subitems.add(dr("Acc11"))
                    .subitems.add(dr("Acc12"))
                    .subitems.add(dr("Acc13"))
                    .subitems.add(dr("Acc14"))
                    .subitems.add(dr("Acc15"))
                    .subitems.add(dr("Debit1"))
                    .subitems.add(dr("Debit2"))
                    .subitems.add(dr("Debit3"))
                    .subitems.add(dr("Debit4"))
                    .subitems.add(dr("Debit5"))
                    .subitems.add(dr("Debit6"))
                    .subitems.add(dr("Debit7"))
                    .subitems.add(dr("Debit8"))
                    .subitems.add(dr("Debit9"))
                    .subitems.add(dr("Debit10"))
                    .subitems.add(dr("Credit1"))
                    .subitems.add(dr("Credit2"))
                    .subitems.add(dr("Credit3"))
                    .subitems.add(dr("Credit4"))
                    .subitems.add(dr("Credit5"))
                    .subitems.add(dr("Explanation"))
                    .subitems.add(dr("Receive"))
                    .subitems.add(dr("Preparedby"))
                    .subitems.add(dr("Checkedby"))
                    .subitems.add(dr("ApprovedBy"))
                    .subitems.add(dr("Payee"))
                    .subitems.add(dr("Date1"))
                    .subitems.add(dr("Date2"))
                    .subitems.add(dr("Date3"))

                End With

            End While
            'cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
  
    Private Sub lvlOperator_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub lvldataprint_Click1(sender As Object, e As System.EventArgs) Handles lvldataprint.Click
        On Error Resume Next
        With lvldataprint.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtdate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            acc1.Text = .SubItems(7).Text
            acc2.Text = .SubItems(8).Text
            acc3.Text = .SubItems(9).Text
            acc4.Text = .SubItems(10).Text
            acc5.Text = .SubItems(11).Text
            acc6.Text = .SubItems(12).Text
            acc7.Text = .SubItems(13).Text
            acc8.Text = .SubItems(14).Text
            acc9.Text = .SubItems(15).Text
            acc10.Text = .SubItems(16).Text
            acc11.Text = .SubItems(17).Text
            acc12.Text = .SubItems(18).Text
            acc13.Text = .SubItems(19).Text
            acc14.Text = .SubItems(20).Text
            acc15.Text = .SubItems(21).Text
            txtDebit1.Text = .SubItems(22).Text
            txtDebit2.Text = .SubItems(23).Text
            txtDebit3.Text = .SubItems(24).Text
            txtDebit4.Text = .SubItems(25).Text
            txtDebit5.Text = .SubItems(26).Text
            txtDebit6.Text = .SubItems(27).Text
            txtDebit7.Text = .SubItems(28).Text
            txtDebit8.Text = .SubItems(29).Text
            txtDebit9.Text = .SubItems(30).Text
            txtDebit10.Text = .SubItems(31).Text
            txtCredit1.Text = .SubItems(32).Text
            txtCredit2.Text = .SubItems(33).Text
            txtCredit3.Text = .SubItems(34).Text
            txtCredit4.Text = .SubItems(35).Text
            txtCredit5.Text = .SubItems(36).Text
            txtExplanation.Text = .SubItems(37).Text
            txtReceived.Text = .SubItems(38).Text
            txtPrepared.Text = .SubItems(39).Text
            txtCheck.Text = .SubItems(40).Text
            txtApprove.Text = .SubItems(41).Text
            txtPayee.Text = .SubItems(42).Text
            txtDate1.Text = .SubItems(43).Text
            txtDate2.Text = .SubItems(44).Text
            txtDate3.Text = .SubItems(45).Text


        End With
        btnEdit.Enabled = True
        btnadd.Enabled = False
        btnEdit.Text = "Edit"
        btnprint.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub lvldataprint_KeyDown1(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvldataprint.KeyDown
        On Error Resume Next
        With lvldataprint.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtdate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            acc1.Text = .SubItems(7).Text
            acc2.Text = .SubItems(8).Text
            acc3.Text = .SubItems(9).Text
            acc4.Text = .SubItems(10).Text
            acc5.Text = .SubItems(11).Text
            acc6.Text = .SubItems(12).Text
            acc7.Text = .SubItems(13).Text
            acc8.Text = .SubItems(14).Text
            acc9.Text = .SubItems(15).Text
            acc10.Text = .SubItems(16).Text
            acc11.Text = .SubItems(17).Text
            acc12.Text = .SubItems(18).Text
            acc13.Text = .SubItems(19).Text
            acc14.Text = .SubItems(20).Text
            acc15.Text = .SubItems(21).Text
            txtDebit1.Text = .SubItems(22).Text
            txtDebit2.Text = .SubItems(23).Text
            txtDebit3.Text = .SubItems(24).Text
            txtDebit4.Text = .SubItems(25).Text
            txtDebit5.Text = .SubItems(26).Text
            txtDebit6.Text = .SubItems(27).Text
            txtDebit7.Text = .SubItems(28).Text
            txtDebit8.Text = .SubItems(29).Text
            txtDebit9.Text = .SubItems(30).Text
            txtDebit10.Text = .SubItems(31).Text
            txtCredit1.Text = .SubItems(32).Text
            txtCredit2.Text = .SubItems(33).Text
            txtCredit3.Text = .SubItems(34).Text
            txtCredit4.Text = .SubItems(35).Text
            txtCredit5.Text = .SubItems(36).Text
            txtExplanation.Text = .SubItems(37).Text
            txtReceived.Text = .SubItems(38).Text
            txtPrepared.Text = .SubItems(39).Text
            txtCheck.Text = .SubItems(40).Text
            txtApprove.Text = .SubItems(41).Text
            txtPayee.Text = .SubItems(42).Text
            txtDate1.Text = .SubItems(43).Text
            txtDate2.Text = .SubItems(44).Text
            txtDate3.Text = .SubItems(45).Text


        End With
        btnEdit.Enabled = True
        btnadd.Enabled = False
        btnEdit.Text = "Edit"
        btnClear.Enabled = True
        btnprint.Enabled = True
    End Sub

    Private Sub lvldataprint_KeyUp1(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvldataprint.KeyUp
        On Error Resume Next
        With lvldataprint.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtdate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            acc1.Text = .SubItems(7).Text
            acc2.Text = .SubItems(8).Text
            acc3.Text = .SubItems(9).Text
            acc4.Text = .SubItems(10).Text
            acc5.Text = .SubItems(11).Text
            acc6.Text = .SubItems(12).Text
            acc7.Text = .SubItems(13).Text
            acc8.Text = .SubItems(14).Text
            acc9.Text = .SubItems(15).Text
            acc10.Text = .SubItems(16).Text
            acc11.Text = .SubItems(17).Text
            acc12.Text = .SubItems(18).Text
            acc13.Text = .SubItems(19).Text
            acc14.Text = .SubItems(20).Text
            acc15.Text = .SubItems(21).Text
            txtDebit1.Text = .SubItems(22).Text
            txtDebit2.Text = .SubItems(23).Text
            txtDebit3.Text = .SubItems(24).Text
            txtDebit4.Text = .SubItems(25).Text
            txtDebit5.Text = .SubItems(26).Text
            txtDebit6.Text = .SubItems(27).Text
            txtDebit7.Text = .SubItems(28).Text
            txtDebit8.Text = .SubItems(29).Text
            txtDebit9.Text = .SubItems(30).Text
            txtDebit10.Text = .SubItems(31).Text
            txtCredit1.Text = .SubItems(32).Text
            txtCredit2.Text = .SubItems(33).Text
            txtCredit3.Text = .SubItems(34).Text
            txtCredit4.Text = .SubItems(35).Text
            txtCredit5.Text = .SubItems(36).Text
            txtExplanation.Text = .SubItems(37).Text
            txtReceived.Text = .SubItems(38).Text
            txtPrepared.Text = .SubItems(39).Text
            txtCheck.Text = .SubItems(40).Text
            txtApprove.Text = .SubItems(41).Text
            txtPayee.Text = .SubItems(42).Text
            txtDate1.Text = .SubItems(43).Text
            txtDate2.Text = .SubItems(44).Text
            txtDate3.Text = .SubItems(45).Text


        End With
        btnEdit.Enabled = True
        btnadd.Enabled = False
        btnEdit.Text = "Edit"
        btnClear.Enabled = True
        btnprint.Enabled = True
    End Sub

    Private Sub lvldataprint_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles lvldataprint.SelectedIndexChanged

    End Sub

    Private Sub lvlOperator_Click1(sender As Object, e As System.EventArgs) Handles lvlOperator.Click
        On Error Resume Next
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtPrepared.Text = .SubItems(1).Text
            txtCheck.Text = .SubItems(2).Text
            txtApprove.Text = .SubItems(3).Text
        End With
    End Sub

    Private Sub lvlOperator_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvlOperator.KeyDown
        On Error Resume Next
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtPrepared.Text = .SubItems(1).Text
            txtCheck.Text = .SubItems(2).Text
            txtApprove.Text = .SubItems(3).Text
        End With
    End Sub

    Private Sub lvlOperator_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvlOperator.KeyUp
        On Error Resume Next
        With lvlOperator.SelectedItems(0)
            txtUserID.Text = .SubItems(0).Text
            txtPrepared.Text = .SubItems(1).Text
            txtCheck.Text = .SubItems(2).Text
            txtApprove.Text = .SubItems(3).Text
        End With
    End Sub

    Private Sub lvlOperator_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles lvlOperator.SelectedIndexChanged

    End Sub

    Private Sub cbAcc11_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc11.SelectedIndexChanged
        If cbAcc11.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Loans and Receivables" Then
            t2.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Inventory-sacks" Then
            t3.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Property and Equipment" Then
            t6.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Savings Deposit" Then
            t7.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accounts Payable" Then
            t8.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Notes Payable" Then
            t15.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Donations and Grants" Then
            t19.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Statutory Funds" Then
            t20.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Administrative Income" Then
            t21.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Memberships fees" Then
            t22.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest Income" Then
            t23.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Salaries and allowances" Then
            t25.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Expense" Then
            t28.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Communication expense" Then
            t34.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Bank Charges" Then
            t35.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Employee benefits" Then
            t36.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Light, water and power" Then
            t37.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Incentives" Then
            t40.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Travel and Transportation" Then
            t43.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Freight and handling" Then
            t45.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Insurance expense" Then
            t48.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Representation and entertainment" Then
            t49.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefits" Then
            t50.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Affliation Fees" Then
            t51.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Professional Fees" Then
            t52.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Social Services" Then
            t53.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Miscellaneous" Then
            t54.Text = txtCredit1.Text
        End If
    End Sub

  
    Private Sub txtDebit1_TextChanged_2(sender As System.Object, e As System.EventArgs) Handles txtDebit1.TextChanged
        If cbAcc1.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Loans and Receivables" Then
            t2.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Inventory-sacks" Then
            t3.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Property and Equipment" Then
            t6.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Savings Deposit" Then
            t7.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Accounts Payable" Then
            t8.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Notes Payable" Then
            t15.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Donations and Grants" Then
            t19.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Statutory Funds" Then
            t20.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Administrative Income" Then
            t21.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Memberships fees" Then
            t22.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Interest Income" Then
            t23.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Salaries and allowances" Then
            t25.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Retirement Expense" Then
            t28.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Communication expense" Then
            t34.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Bank Charges" Then
            t35.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Employee benefits" Then
            t36.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Light, water and power" Then
            t37.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Incentives" Then
            t40.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Travel and Transportation" Then
            t43.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Freight and handling" Then
            t45.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Insurance expense" Then
            t48.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Representation and entertainment" Then
            t49.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Benefits" Then
            t50.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Affliation Fees" Then
            t51.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Professional Fees" Then
            t52.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Social Services" Then
            t53.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Miscellaneous" Then
            t54.Text = txtDebit1.Text



        End If
    End Sub

    Private Sub cbAcc1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc1.SelectedIndexChanged
        If cbAcc1.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Loans and Receivables" Then
            t2.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Inventory-sacks" Then
            t3.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Property and Equipment" Then
            t6.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Savings Deposit" Then
            t7.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Accounts Payable" Then
            t8.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Notes Payable" Then
            t15.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Donations and Grants" Then
            t19.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Statutory Funds" Then
            t20.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Administrative Income" Then
            t21.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Memberships fees" Then
            t22.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Interest Income" Then
            t23.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Salaries and allowances" Then
            t25.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Retirement Expense" Then
            t28.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Communication expense" Then
            t34.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Bank Charges" Then
            t35.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Employee benefits" Then
            t36.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Light, water and power" Then
            t37.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Incentives" Then
            t40.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Travel and Transportation" Then
            t43.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Freight and handling" Then
            t45.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Insurance expense" Then
            t48.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Representation and entertainment" Then
            t49.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Members Benefits" Then
            t50.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Affliation Fees" Then
            t51.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Professional Fees" Then
            t52.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Social Services" Then
            t53.Text = txtDebit1.Text
        ElseIf cbAcc1.Text = "Miscellaneous" Then
            t54.Text = txtDebit1.Text
        End If


    End Sub

    Private Sub cbAcc2_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc2.SelectedIndexChanged
        If cbAcc2.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Loans and Receivables" Then
            t2.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Inventory-sacks" Then
            t3.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Property and Equipment" Then
            t6.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Savings Deposit" Then
            t7.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Accounts Payable" Then
            t8.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Notes Payable" Then
            t15.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Donations and Grants" Then
            t19.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Statutory Funds" Then
            t20.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Administrative Income" Then
            t21.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Memberships fees" Then
            t22.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Interest Income" Then
            t23.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Salaries and allowances" Then
            t25.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Retirement Expense" Then
            t28.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Communication expense" Then
            t34.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Bank Charges" Then
            t35.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Employee benefits" Then
            t36.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Light, water and power" Then
            t37.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Incentives" Then
            t40.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Travel and Transportation" Then
            t43.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Freight and handling" Then
            t45.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Insurance expense" Then
            t48.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Representation and entertainment" Then
            t49.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Benefits" Then
            t50.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Affliation Fees" Then
            t51.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Professional Fees" Then
            t52.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Social Services" Then
            t53.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Miscellaneous" Then
            t54.Text = txtDebit2.Text



        End If
    End Sub

    Private Sub cbAcc3_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc3.SelectedIndexChanged
        If cbAcc3.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Loans and Receivables" Then
            t2.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Inventory-sacks" Then
            t3.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Property and Equipment" Then
            t6.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Savings Deposit" Then
            t7.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Accounts Payable" Then
            t8.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Notes Payable" Then
            t15.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Donations and Grants" Then
            t19.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Statutory Funds" Then
            t20.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Administrative Income" Then
            t21.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Memberships fees" Then
            t22.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Interest Income" Then
            t23.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Salaries and allowances" Then
            t25.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Retirement Expense" Then
            t28.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Communication expense" Then
            t34.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Bank Charges" Then
            t35.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Employee benefits" Then
            t36.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Light, water and power" Then
            t37.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Members Incentives" Then
            t40.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Travel and Transportation" Then
            t43.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Freight and handling" Then
            t45.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Insurance expense" Then
            t48.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Representation and entertainment" Then
            t49.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Members Benefits" Then
            t50.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Affliation Fees" Then
            t51.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Professional Fees" Then
            t52.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Social Services" Then
            t53.Text = txtDebit3.Text
        ElseIf cbAcc3.Text = "Miscellaneous" Then
            t54.Text = txtDebit3.Text
        End If
    End Sub

    Private Sub txtDebit2_TextChanged_2(sender As System.Object, e As System.EventArgs) Handles txtDebit2.TextChanged
        If cbAcc2.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Loans and Receivables" Then
            t2.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Inventory-sacks" Then
            t3.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Property and Equipment" Then
            t6.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Savings Deposit" Then
            t7.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Accounts Payable" Then
            t8.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Notes Payable" Then
            t15.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Donations and Grants" Then
            t19.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Statutory Funds" Then
            t20.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Administrative Income" Then
            t21.Text = txtDebit1.Text
        ElseIf cbAcc2.Text = "Memberships fees" Then
            t22.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Interest Income" Then
            t23.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Salaries and allowances" Then
            t25.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Retirement Expense" Then
            t28.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Communication expense" Then
            t34.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Bank Charges" Then
            t35.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Employee benefits" Then
            t36.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Light, water and power" Then
            t37.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Incentives" Then
            t40.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Travel and Transportation" Then
            t43.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Freight and handling" Then
            t45.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Insurance expense" Then
            t48.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Representation and entertainment" Then
            t49.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Members Benefits" Then
            t50.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Affliation Fees" Then
            t51.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Professional Fees" Then
            t52.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Social Services" Then
            t53.Text = txtDebit2.Text
        ElseIf cbAcc2.Text = "Miscellaneous" Then
            t54.Text = txtDebit2.Text
        End If
    End Sub

    Private Sub cbAcc4_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc4.SelectedIndexChanged
        If cbAcc4.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Loans and Receivables" Then
            t2.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Inventory-sacks" Then
            t3.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Property and Equipment" Then
            t6.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Savings Deposit" Then
            t7.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Accounts Payable" Then
            t8.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Notes Payable" Then
            t15.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Donations and Grants" Then
            t19.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Statutory Funds" Then
            t20.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Administrative Income" Then
            t21.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Memberships fees" Then
            t22.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Interest Income" Then
            t23.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Salaries and allowances" Then
            t25.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Retirement Expense" Then
            t28.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Communication expense" Then
            t34.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Bank Charges" Then
            t35.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Employee benefits" Then
            t36.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Light, water and power" Then
            t37.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Incentives" Then
            t40.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Travel and Transportation" Then
            t43.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Freight and handling" Then
            t45.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Insurance expense" Then
            t48.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Representation and entertainment" Then
            t49.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Benefits" Then
            t50.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Affliation Fees" Then
            t51.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Professional Fees" Then
            t52.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Social Services" Then
            t53.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Miscellaneous" Then
            t54.Text = txtDebit4.Text
        End If
    End Sub

    Private Sub cbAcc5_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc5.SelectedIndexChanged
        If cbAcc5.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Loans and Receivables" Then
            t2.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Inventory-sacks" Then
            t3.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Property and Equipment" Then
            t6.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Savings Deposit" Then
            t7.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Accounts Payable" Then
            t8.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Notes Payable" Then
            t15.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Donations and Grants" Then
            t19.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Statutory Funds" Then
            t20.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Administrative Income" Then
            t21.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Memberships fees" Then
            t22.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Interest Income" Then
            t23.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Salaries and allowances" Then
            t25.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Retirement Expense" Then
            t28.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Communication expense" Then
            t34.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Bank Charges" Then
            t35.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Employee benefits" Then
            t36.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Light, water and power" Then
            t37.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Incentives" Then
            t40.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Travel and Transportation" Then
            t43.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Freight and handling" Then
            t45.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Insurance expense" Then
            t48.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Representation and entertainment" Then
            t49.Text = txtDebit5.Text
        ElseIf cbAcc2.Text = "Members Benefits" Then
            t50.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Affliation Fees" Then
            t51.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Professional Fees" Then
            t52.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Social Services" Then
            t53.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Miscellaneous" Then
            t54.Text = txtDebit5.Text
        End If
    End Sub

    Private Sub cbAcc6_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc6.SelectedIndexChanged
        If cbAcc6.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Loans and Receivables" Then
            t2.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Inventory-sacks" Then
            t3.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Property and Equipment" Then
            t6.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Savings Deposit" Then
            t7.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Accounts Payable" Then
            t8.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Notes Payable" Then
            t15.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Donations and Grants" Then
            t19.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Statutory Funds" Then
            t20.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Administrative Income" Then
            t21.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Memberships fees" Then
            t22.Text = txtDebit2.Text
        ElseIf cbAcc6.Text = "Interest Income" Then
            t23.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Salaries and allowances" Then
            t25.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Retirement Expense" Then
            t28.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Communication expense" Then
            t34.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Bank Charges" Then
            t35.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Employee benefits" Then
            t36.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Light, water and power" Then
            t37.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Incentives" Then
            t40.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Travel and Transportation" Then
            t43.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Freight and handling" Then
            t45.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Insurance expense" Then
            t48.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Representation and entertainment" Then
            t49.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Benefits" Then
            t50.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Affliation Fees" Then
            t51.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Professional Fees" Then
            t52.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Social Services" Then
            t53.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Miscellaneous" Then
            t54.Text = txtDebit6.Text
        End If
    End Sub

    Private Sub txtDebit6_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit6.TextChanged
        If cbAcc6.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Loans and Receivables" Then
            t2.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Inventory-sacks" Then
            t3.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Property and Equipment" Then
            t6.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Savings Deposit" Then
            t7.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Accounts Payable" Then
            t8.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Notes Payable" Then
            t15.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Donations and Grants" Then
            t19.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Statutory Funds" Then
            t20.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Administrative Income" Then
            t21.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Memberships fees" Then
            t22.Text = txtDebit2.Text
        ElseIf cbAcc6.Text = "Interest Income" Then
            t23.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Salaries and allowances" Then
            t25.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Retirement Expense" Then
            t28.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Communication expense" Then
            t34.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Bank Charges" Then
            t35.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Employee benefits" Then
            t36.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Light, water and power" Then
            t37.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Incentives" Then
            t40.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Travel and Transportation" Then
            t43.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Freight and handling" Then
            t45.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Insurance expense" Then
            t48.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Representation and entertainment" Then
            t49.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Members Benefits" Then
            t50.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Affliation Fees" Then
            t51.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Professional Fees" Then
            t52.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Social Services" Then
            t53.Text = txtDebit6.Text
        ElseIf cbAcc6.Text = "Miscellaneous" Then
            t54.Text = txtDebit6.Text
        End If
    End Sub

    Private Sub txtDebit5_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit5.TextChanged
        If cbAcc5.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Loans and Receivables" Then
            t2.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Inventory-sacks" Then
            t3.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Property and Equipment" Then
            t6.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Savings Deposit" Then
            t7.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Accounts Payable" Then
            t8.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Notes Payable" Then
            t15.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Donations and Grants" Then
            t19.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Statutory Funds" Then
            t20.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Administrative Income" Then
            t21.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Memberships fees" Then
            t22.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Interest Income" Then
            t23.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Salaries and allowances" Then
            t25.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Retirement Expense" Then
            t28.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Communication expense" Then
            t34.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Bank Charges" Then
            t35.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Employee benefits" Then
            t36.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Light, water and power" Then
            t37.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Incentives" Then
            t40.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Travel and Transportation" Then
            t43.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Freight and handling" Then
            t45.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Insurance expense" Then
            t48.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Representation and entertainment" Then
            t49.Text = txtDebit5.Text
        ElseIf cbAcc2.Text = "Members Benefits" Then
            t50.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Affliation Fees" Then
            t51.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Professional Fees" Then
            t52.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Social Services" Then
            t53.Text = txtDebit5.Text
        ElseIf cbAcc5.Text = "Miscellaneous" Then
            t54.Text = txtDebit5.Text
        End If
    End Sub

    Private Sub cbAcc7_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc7.SelectedIndexChanged
        If cbAcc7.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Loans and Receivables" Then
            t2.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Inventory-sacks" Then
            t3.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Property and Equipment" Then
            t6.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Savings Deposit" Then
            t7.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Accounts Payable" Then
            t8.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Notes Payable" Then
            t15.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Donations and Grants" Then
            t19.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Statutory Funds" Then
            t20.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Administrative Income" Then
            t21.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Memberships fees" Then
            t22.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Interest Income" Then
            t23.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Salaries and allowances" Then
            t25.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Retirement Expense" Then
            t28.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Communication expense" Then
            t34.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Bank Charges" Then
            t35.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Employee benefits" Then
            t36.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Light, water and power" Then
            t37.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Incentives" Then
            t40.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Travel and Transportation" Then
            t43.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Freight and handling" Then
            t45.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit2.Text
        ElseIf cbAcc7.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Insurance expense" Then
            t48.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Representation and entertainment" Then
            t49.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Benefits" Then
            t50.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Affliation Fees" Then
            t51.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Professional Fees" Then
            t52.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Social Services" Then
            t53.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Miscellaneous" Then
            t54.Text = txtDebit7.Text
        End If
    End Sub

    Private Sub txtDebit7_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit7.TextChanged
        If cbAcc7.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Loans and Receivables" Then
            t2.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Inventory-sacks" Then
            t3.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Property and Equipment" Then
            t6.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Savings Deposit" Then
            t7.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Accounts Payable" Then
            t8.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Notes Payable" Then
            t15.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Donations and Grants" Then
            t19.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Statutory Funds" Then
            t20.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Administrative Income" Then
            t21.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Memberships fees" Then
            t22.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Interest Income" Then
            t23.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Salaries and allowances" Then
            t25.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Retirement Expense" Then
            t28.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Communication expense" Then
            t34.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Bank Charges" Then
            t35.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Employee benefits" Then
            t36.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Light, water and power" Then
            t37.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Incentives" Then
            t40.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Travel and Transportation" Then
            t43.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Freight and handling" Then
            t45.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit2.Text
        ElseIf cbAcc7.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Insurance expense" Then
            t48.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Representation and entertainment" Then
            t49.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Members Benefits" Then
            t50.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Affliation Fees" Then
            t51.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Professional Fees" Then
            t52.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Social Services" Then
            t53.Text = txtDebit7.Text
        ElseIf cbAcc7.Text = "Miscellaneous" Then
            t54.Text = txtDebit7.Text
        End If
    End Sub

    Private Sub cbAcc8_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc8.SelectedIndexChanged
        If cbAcc8.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Loans and Receivables" Then
            t2.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Inventory-sacks" Then
            t3.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Property and Equipment" Then
            t6.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Savings Deposit" Then
            t7.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Accounts Payable" Then
            t8.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Notes Payable" Then
            t15.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Donations and Grants" Then
            t19.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Statutory Funds" Then
            t20.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Administrative Income" Then
            t21.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Memberships fees" Then
            t22.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Interest Income" Then
            t23.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Salaries and allowances" Then
            t25.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Retirement Expense" Then
            t28.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Communication expense" Then
            t34.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Bank Charges" Then
            t35.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Employee benefits" Then
            t36.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Light, water and power" Then
            t37.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Incentives" Then
            t40.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Travel and Transportation" Then
            t43.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Freight and handling" Then
            t45.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Insurance expense" Then
            t48.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Representation and entertainment" Then
            t49.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Benefits" Then
            t50.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Affliation Fees" Then
            t51.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Professional Fees" Then
            t52.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Social Services" Then
            t53.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Miscellaneous" Then
            t54.Text = txtDebit8.Text
        End If
    End Sub

    Private Sub txtDebit8_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit8.TextChanged
        If cbAcc8.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Loans and Receivables" Then
            t2.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Inventory-sacks" Then
            t3.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Property and Equipment" Then
            t6.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Savings Deposit" Then
            t7.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Accounts Payable" Then
            t8.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Notes Payable" Then
            t15.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Donations and Grants" Then
            t19.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Statutory Funds" Then
            t20.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Administrative Income" Then
            t21.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Memberships fees" Then
            t22.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Interest Income" Then
            t23.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Salaries and allowances" Then
            t25.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Retirement Expense" Then
            t28.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Communication expense" Then
            t34.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Bank Charges" Then
            t35.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Employee benefits" Then
            t36.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Light, water and power" Then
            t37.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Incentives" Then
            t40.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Travel and Transportation" Then
            t43.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Freight and handling" Then
            t45.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Insurance expense" Then
            t48.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Representation and entertainment" Then
            t49.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Members Benefits" Then
            t50.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Affliation Fees" Then
            t51.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Professional Fees" Then
            t52.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Social Services" Then
            t53.Text = txtDebit8.Text
        ElseIf cbAcc8.Text = "Miscellaneous" Then
            t54.Text = txtDebit8.Text
        End If
    End Sub

    Private Sub cbAcc9_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc9.SelectedIndexChanged
        If cbAcc9.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Loans and Receivables" Then
            t2.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Inventory-sacks" Then
            t3.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Property and Equipment" Then
            t6.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Savings Deposit" Then
            t7.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accounts Payable" Then
            t8.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Notes Payable" Then
            t15.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Donations and Grants" Then
            t19.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Statutory Funds" Then
            t20.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Administrative Income" Then
            t21.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Memberships fees" Then
            t22.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest Income" Then
            t23.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Salaries and allowances" Then
            t25.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Expense" Then
            t28.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Communication expense" Then
            t34.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Bank Charges" Then
            t35.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Employee benefits" Then
            t36.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Light, water and power" Then
            t37.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Incentives" Then
            t40.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Travel and Transportation" Then
            t43.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Freight and handling" Then
            t45.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Insurance expense" Then
            t48.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Representation and entertainment" Then
            t49.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefits" Then
            t50.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Affliation Fees" Then
            t51.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Professional Fees" Then
            t52.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Social Services" Then
            t53.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Miscellaneous" Then
            t54.Text = txtDebit9.Text
        End If
    End Sub

    Private Sub acc9_TextChanged(sender As System.Object, e As System.EventArgs) Handles acc9.TextChanged
        If cbAcc9.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Loans and Receivables" Then
            t2.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Inventory-sacks" Then
            t3.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Property and Equipment" Then
            t6.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Savings Deposit" Then
            t7.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accounts Payable" Then
            t8.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Notes Payable" Then
            t15.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Donations and Grants" Then
            t19.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Statutory Funds" Then
            t20.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Administrative Income" Then
            t21.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Memberships fees" Then
            t22.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest Income" Then
            t23.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Salaries and allowances" Then
            t25.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Expense" Then
            t28.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Communication expense" Then
            t34.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Bank Charges" Then
            t35.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Employee benefits" Then
            t36.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Light, water and power" Then
            t37.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Incentives" Then
            t40.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Travel and Transportation" Then
            t43.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Freight and handling" Then
            t45.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Insurance expense" Then
            t48.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Representation and entertainment" Then
            t49.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefits" Then
            t50.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Affliation Fees" Then
            t51.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Professional Fees" Then
            t52.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Social Services" Then
            t53.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Miscellaneous" Then
            t54.Text = txtDebit9.Text
        End If
    End Sub

    Private Sub cbAcc10_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc10.SelectedIndexChanged
        If cbAcc10.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Loans and Receivables" Then
            t2.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Inventory-sacks" Then
            t3.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Property and Equipment" Then
            t6.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Savings Deposit" Then
            t7.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accounts Payable" Then
            t8.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Notes Payable" Then
            t15.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Donations and Grants" Then
            t19.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Statutory Funds" Then
            t20.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Administrative Income" Then
            t21.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Memberships fees" Then
            t22.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest Income" Then
            t23.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Salaries and allowances" Then
            t25.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Expense" Then
            t28.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Communication expense" Then
            t34.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Bank Charges" Then
            t35.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Employee benefits" Then
            t36.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Light, water and power" Then
            t37.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Incentives" Then
            t40.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Travel and Transportation" Then
            t43.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Freight and handling" Then
            t45.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Insurance expense" Then
            t48.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Representation and entertainment" Then
            t49.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefits" Then
            t50.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Affliation Fees" Then
            t51.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Professional Fees" Then
            t52.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Social Services" Then
            t53.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Miscellaneous" Then
            t54.Text = txtDebit10.Text
        End If
    End Sub

    Private Sub acc10_TextChanged(sender As System.Object, e As System.EventArgs) Handles acc10.TextChanged
        If cbAcc10.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Loans and Receivables" Then
            t2.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Inventory-sacks" Then
            t3.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Property and Equipment" Then
            t6.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Savings Deposit" Then
            t7.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accounts Payable" Then
            t8.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Notes Payable" Then
            t15.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Donations and Grants" Then
            t19.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Statutory Funds" Then
            t20.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Administrative Income" Then
            t21.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Memberships fees" Then
            t22.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest Income" Then
            t23.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Salaries and allowances" Then
            t25.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Expense" Then
            t28.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Communication expense" Then
            t34.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Bank Charges" Then
            t35.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Employee benefits" Then
            t36.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Light, water and power" Then
            t37.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Incentives" Then
            t40.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Travel and Transportation" Then
            t43.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Freight and handling" Then
            t45.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Insurance expense" Then
            t48.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Representation and entertainment" Then
            t49.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefits" Then
            t50.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Affliation Fees" Then
            t51.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Professional Fees" Then
            t52.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Social Services" Then
            t53.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Miscellaneous" Then
            t54.Text = txtDebit10.Text
        End If
    End Sub

    Private Sub acc11_TextChanged(sender As System.Object, e As System.EventArgs) Handles acc11.TextChanged
        If cbAcc11.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Loans and Receivables" Then
            t2.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Inventory-sacks" Then
            t3.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Property and Equipment" Then
            t6.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Savings Deposit" Then
            t7.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accounts Payable" Then
            t8.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Notes Payable" Then
            t15.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Donations and Grants" Then
            t19.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Statutory Funds" Then
            t20.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Administrative Income" Then
            t21.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Memberships fees" Then
            t22.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest Income" Then
            t23.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Salaries and allowances" Then
            t25.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Expense" Then
            t28.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Communication expense" Then
            t34.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Bank Charges" Then
            t35.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Employee benefits" Then
            t36.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Light, water and power" Then
            t37.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Incentives" Then
            t40.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Travel and Transportation" Then
            t43.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Freight and handling" Then
            t45.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Insurance expense" Then
            t48.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Representation and entertainment" Then
            t49.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefits" Then
            t50.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Affliation Fees" Then
            t51.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Professional Fees" Then
            t52.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Social Services" Then
            t53.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Miscellaneous" Then
            t54.Text = txtCredit1.Text
        End If
    End Sub

    Private Sub txtDebit4_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit4.TextChanged
        If cbAcc4.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Loans and Receivables" Then
            t2.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Inventory-sacks" Then
            t3.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Property and Equipment" Then
            t6.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Savings Deposit" Then
            t7.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Accounts Payable" Then
            t8.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Notes Payable" Then
            t15.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Donations and Grants" Then
            t19.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Statutory Funds" Then
            t20.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Administrative Income" Then
            t21.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Memberships fees" Then
            t22.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Interest Income" Then
            t23.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Salaries and allowances" Then
            t25.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Retirement Expense" Then
            t28.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Communication expense" Then
            t34.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Bank Charges" Then
            t35.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Employee benefits" Then
            t36.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Light, water and power" Then
            t37.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Incentives" Then
            t40.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Travel and Transportation" Then
            t43.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Freight and handling" Then
            t45.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Insurance expense" Then
            t48.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Representation and entertainment" Then
            t49.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Members Benefits" Then
            t50.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Affliation Fees" Then
            t51.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Professional Fees" Then
            t52.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Social Services" Then
            t53.Text = txtDebit4.Text
        ElseIf cbAcc4.Text = "Miscellaneous" Then
            t54.Text = txtDebit4.Text
        End If
    End Sub

    Private Sub cbAcc12_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc12.SelectedIndexChanged
        If cbAcc12.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Loans and Receivables" Then
            t2.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Inventory-sacks" Then
            t3.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Property and Equipment" Then
            t6.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Savings Deposit" Then
            t7.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Accounts Payable" Then
            t8.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Notes Payable" Then
            t15.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Donations and Grants" Then
            t19.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Statutory Funds" Then
            t20.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Administrative Income" Then
            t21.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Memberships fees" Then
            t22.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Interest Income" Then
            t23.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Salaries and allowances" Then
            t25.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Retirement Expense" Then
            t28.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Communication expense" Then
            t34.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Bank Charges" Then
            t35.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Employee benefits" Then
            t36.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Light, water and power" Then
            t37.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Incentives" Then
            t40.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Travel and Transportation" Then
            t43.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Freight and handling" Then
            t45.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Insurance expense" Then
            t48.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Representation and entertainment" Then
            t49.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Benefits" Then
            t50.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Affliation Fees" Then
            t51.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Professional Fees" Then
            t52.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Social Services" Then
            t53.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Miscellaneous" Then
            t54.Text = txtCredit2.Text
        End If
    End Sub

    Private Sub txtCredit2_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCredit2.TextChanged
        If cbAcc12.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Loans and Receivables" Then
            t2.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Inventory-sacks" Then
            t3.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Property and Equipment" Then
            t6.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Savings Deposit" Then
            t7.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Accounts Payable" Then
            t8.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Notes Payable" Then
            t15.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Donations and Grants" Then
            t19.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Statutory Funds" Then
            t20.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Administrative Income" Then
            t21.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Memberships fees" Then
            t22.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Interest Income" Then
            t23.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Salaries and allowances" Then
            t25.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Retirement Expense" Then
            t28.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Communication expense" Then
            t34.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Bank Charges" Then
            t35.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Employee benefits" Then
            t36.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Light, water and power" Then
            t37.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Incentives" Then
            t40.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Travel and Transportation" Then
            t43.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Freight and handling" Then
            t45.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Insurance expense" Then
            t48.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Representation and entertainment" Then
            t49.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Members Benefits" Then
            t50.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Affliation Fees" Then
            t51.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Professional Fees" Then
            t52.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Social Services" Then
            t53.Text = txtCredit2.Text
        ElseIf cbAcc12.Text = "Miscellaneous" Then
            t54.Text = txtCredit2.Text
        End If
    End Sub

    Private Sub txtDebit10_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit10.TextChanged
        If cbAcc10.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Loans and Receivables" Then
            t2.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Inventory-sacks" Then
            t3.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Property and Equipment" Then
            t6.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Savings Deposit" Then
            t7.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accounts Payable" Then
            t8.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Notes Payable" Then
            t15.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Donations and Grants" Then
            t19.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Statutory Funds" Then
            t20.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Administrative Income" Then
            t21.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Memberships fees" Then
            t22.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Interest Income" Then
            t23.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Salaries and allowances" Then
            t25.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Retirement Expense" Then
            t28.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Communication expense" Then
            t34.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Bank Charges" Then
            t35.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Employee benefits" Then
            t36.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Light, water and power" Then
            t37.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Incentives" Then
            t40.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Travel and Transportation" Then
            t43.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Freight and handling" Then
            t45.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Insurance expense" Then
            t48.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Representation and entertainment" Then
            t49.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Members Benefits" Then
            t50.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Affliation Fees" Then
            t51.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Professional Fees" Then
            t52.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Social Services" Then
            t53.Text = txtDebit10.Text
        ElseIf cbAcc10.Text = "Miscellaneous" Then
            t54.Text = txtDebit10.Text
        End If
    End Sub

    Private Sub txtDebit9_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtDebit9.TextChanged
        If cbAcc9.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Loans and Receivables" Then
            t2.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Inventory-sacks" Then
            t3.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Financial Assets at Cost" Then
            t5.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Property and Equipment" Then
            t6.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Savings Deposit" Then
            t7.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accounts Payable" Then
            t8.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Accrued Interest Payable" Then
            t9.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Fund Payable" Then
            t10.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Due to Federation/Union" Then
            t12.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Funds Held in Trust" Then
            t14.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Notes Payable" Then
            t15.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Fund Payable" Then
            t16.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Mutual benefits fund" Then
            t17.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Paid-up Share Capital" Then
            t18.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Donations and Grants" Then
            t19.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Statutory Funds" Then
            t20.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Administrative Income" Then
            t21.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Memberships fees" Then
            t22.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Interest Income" Then
            t23.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Fuel and lubricants" Then
            t24.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Salaries and allowances" Then
            t25.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Retirement Expense" Then
            t28.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Incentives/Allowances" Then
            t29.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Repairs and maintenance" Then
            t30.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Provision for probable losses on loans" Then
            t31.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Communication expense" Then
            t34.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Bank Charges" Then
            t35.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Employee benefits" Then
            t36.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Light, water and power" Then
            t37.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Incentives" Then
            t40.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Medical Benefits" Then
            t41.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Taxes and Licenses" Then
            t42.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Travel and Transportation" Then
            t43.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Audit and Inventory expense" Then
            t44.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Freight and handling" Then
            t45.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Depreciation and amortization" Then
            t46.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "SSS, EC and other contributions" Then
            t47.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Insurance expense" Then
            t48.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Representation and entertainment" Then
            t49.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Members Benefits" Then
            t50.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Affliation Fees" Then
            t51.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Professional Fees" Then
            t52.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Social Services" Then
            t53.Text = txtDebit9.Text
        ElseIf cbAcc9.Text = "Miscellaneous" Then
            t54.Text = txtDebit9.Text
        End If
    End Sub

    Private Sub acc1_TextChanged(sender As System.Object, e As System.EventArgs) Handles acc1.TextChanged

    End Sub

    Private Sub txtCredit1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCredit1.TextChanged
        If cbAcc11.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Loans and Receivables" Then
            t2.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Inventory-sacks" Then
            t3.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Property and Equipment" Then
            t6.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Savings Deposit" Then
            t7.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accounts Payable" Then
            t8.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Notes Payable" Then
            t15.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Donations and Grants" Then
            t19.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Statutory Funds" Then
            t20.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Administrative Income" Then
            t21.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Memberships fees" Then
            t22.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Interest Income" Then
            t23.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Salaries and allowances" Then
            t25.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Retirement Expense" Then
            t28.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Communication expense" Then
            t34.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Bank Charges" Then
            t35.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Employee benefits" Then
            t36.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Light, water and power" Then
            t37.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Incentives" Then
            t40.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Travel and Transportation" Then
            t43.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Freight and handling" Then
            t45.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Insurance expense" Then
            t48.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Representation and entertainment" Then
            t49.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Members Benefits" Then
            t50.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Affliation Fees" Then
            t51.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Professional Fees" Then
            t52.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Social Services" Then
            t53.Text = txtCredit1.Text
        ElseIf cbAcc11.Text = "Miscellaneous" Then
            t54.Text = txtCredit1.Text
        End If
    End Sub

    Private Sub cbAcc13_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc13.SelectedIndexChanged
        If cbAcc13.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Loans and Receivables" Then
            t2.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Inventory-sacks" Then
            t3.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Property and Equipment" Then
            t6.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Savings Deposit" Then
            t7.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Accounts Payable" Then
            t8.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Notes Payable" Then
            t15.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Donations and Grants" Then
            t19.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Statutory Funds" Then
            t20.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Administrative Income" Then
            t21.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Memberships fees" Then
            t22.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Interest Income" Then
            t23.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Salaries and allowances" Then
            t25.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Retirement Expense" Then
            t28.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Communication expense" Then
            t34.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Bank Charges" Then
            t35.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Employee benefits" Then
            t36.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Light, water and power" Then
            t37.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Incentives" Then
            t40.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Travel and Transportation" Then
            t43.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Freight and handling" Then
            t45.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Insurance expense" Then
            t48.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Representation and entertainment" Then
            t49.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Benefits" Then
            t50.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Affliation Fees" Then
            t51.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Professional Fees" Then
            t52.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Social Services" Then
            t53.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Miscellaneous" Then
            t54.Text = txtCredit3.Text
        End If
    End Sub

    Private Sub txtCredit3_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCredit3.TextChanged
        If cbAcc13.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Loans and Receivables" Then
            t2.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Inventory-sacks" Then
            t3.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Property and Equipment" Then
            t6.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Savings Deposit" Then
            t7.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Accounts Payable" Then
            t8.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Notes Payable" Then
            t15.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Donations and Grants" Then
            t19.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Statutory Funds" Then
            t20.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Administrative Income" Then
            t21.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Memberships fees" Then
            t22.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Interest Income" Then
            t23.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Salaries and allowances" Then
            t25.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Retirement Expense" Then
            t28.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Communication expense" Then
            t34.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Bank Charges" Then
            t35.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Employee benefits" Then
            t36.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Light, water and power" Then
            t37.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Incentives" Then
            t40.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Travel and Transportation" Then
            t43.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Freight and handling" Then
            t45.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Insurance expense" Then
            t48.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Representation and entertainment" Then
            t49.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Members Benefits" Then
            t50.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Affliation Fees" Then
            t51.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Professional Fees" Then
            t52.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Social Services" Then
            t53.Text = txtCredit3.Text
        ElseIf cbAcc13.Text = "Miscellaneous" Then
            t54.Text = txtCredit3.Text
        End If
    End Sub

    Private Sub cbAcc14_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc14.SelectedIndexChanged
        If cbAcc14.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Loans and Receivables" Then
            t2.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Inventory-sacks" Then
            t3.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Property and Equipment" Then
            t6.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Savings Deposit" Then
            t7.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Accounts Payable" Then
            t8.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Notes Payable" Then
            t15.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Donations and Grants" Then
            t19.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Statutory Funds" Then
            t20.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Administrative Income" Then
            t21.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Memberships fees" Then
            t22.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Interest Income" Then
            t23.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Salaries and allowances" Then
            t25.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Retirement Expense" Then
            t28.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Communication expense" Then
            t34.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Bank Charges" Then
            t35.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Employee benefits" Then
            t36.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Light, water and power" Then
            t37.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Incentives" Then
            t40.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Travel and Transportation" Then
            t43.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Freight and handling" Then
            t45.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Insurance expense" Then
            t48.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Representation and entertainment" Then
            t49.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Benefits" Then
            t50.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Affliation Fees" Then
            t51.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Professional Fees" Then
            t52.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Social Services" Then
            t53.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Miscellaneous" Then
            t54.Text = txtCredit4.Text
        End If
    End Sub

    Private Sub txtCredit4_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCredit4.TextChanged
        If cbAcc14.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Loans and Receivables" Then
            t2.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Inventory-sacks" Then
            t3.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Property and Equipment" Then
            t6.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Savings Deposit" Then
            t7.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Accounts Payable" Then
            t8.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Notes Payable" Then
            t15.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Donations and Grants" Then
            t19.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Statutory Funds" Then
            t20.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Administrative Income" Then
            t21.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Memberships fees" Then
            t22.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Interest Income" Then
            t23.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Salaries and allowances" Then
            t25.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Retirement Expense" Then
            t28.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Communication expense" Then
            t34.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Bank Charges" Then
            t35.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Employee benefits" Then
            t36.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Light, water and power" Then
            t37.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Incentives" Then
            t40.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Travel and Transportation" Then
            t43.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Freight and handling" Then
            t45.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Insurance expense" Then
            t48.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Representation and entertainment" Then
            t49.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Members Benefits" Then
            t50.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Affliation Fees" Then
            t51.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Professional Fees" Then
            t52.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Social Services" Then
            t53.Text = txtCredit4.Text
        ElseIf cbAcc14.Text = "Miscellaneous" Then
            t54.Text = txtCredit4.Text
        End If
    End Sub

    Private Sub cbAcc15_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbAcc15.SelectedIndexChanged
        If cbAcc15.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Loans and Receivables" Then
            t2.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Inventory-sacks" Then
            t3.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Property and Equipment" Then
            t6.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Savings Deposit" Then
            t7.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Accounts Payable" Then
            t8.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Notes Payable" Then
            t15.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Donations and Grants" Then
            t19.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Statutory Funds" Then
            t20.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Administrative Income" Then
            t21.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Memberships fees" Then
            t22.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Interest Income" Then
            t23.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Salaries and allowances" Then
            t25.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Retirement Expense" Then
            t28.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Communication expense" Then
            t34.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Bank Charges" Then
            t35.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Employee benefits" Then
            t36.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Light, water and power" Then
            t37.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Incentives" Then
            t40.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Travel and Transportation" Then
            t43.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Freight and handling" Then
            t45.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Insurance expense" Then
            t48.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Representation and entertainment" Then
            t49.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Benefits" Then
            t50.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Affliation Fees" Then
            t51.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Professional Fees" Then
            t52.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Social Services" Then
            t53.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Miscellaneous" Then
            t54.Text = txtCredit5.Text
        End If
    End Sub

    Private Sub txtCredit5_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles txtCredit5.TextChanged
        If cbAcc15.Text = "Cash and Cash Equivalents" Then
            t1.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Loans and Receivables" Then
            t2.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Inventory-sacks" Then
            t3.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Other Financial Assets-Long Term" Then
            t4.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Financial Assets at Cost" Then
            t5.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Property and Equipment" Then
            t6.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Savings Deposit" Then
            t7.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Accounts Payable" Then
            t8.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Accrued Interest Payable" Then
            t9.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Medical Fund Payable" Then
            t10.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Benefit Fund Payable" Then
            t11.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Due to Federation/Union" Then
            t12.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Interest on Share Capital and Patronage Refund Payable" Then
            t13.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Funds Held in Trust" Then
            t14.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Notes Payable" Then
            t15.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Retirement Fund Payable" Then
            t16.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Mutual benefits fund" Then
            t17.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Paid-up Share Capital" Then
            t18.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Donations and Grants" Then
            t19.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Statutory Funds" Then
            t20.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Administrative Income" Then
            t21.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Memberships fees" Then
            t22.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Interest Income" Then
            t23.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Fuel and lubricants" Then
            t24.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Salaries and allowances" Then
            t25.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Allowances/honoraria/subsistence" Then
            t26.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Officers Honorarium and allowances" Then
            t27.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Retirement Expense" Then
            t28.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Incentives/Allowances" Then
            t29.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Repairs and maintenance" Then
            t30.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Provision for probable losses on loans" Then
            t31.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Store/Office and Marketing supplies" Then
            t32.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Milling/Shelling/drying/labor" Then
            t33.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Communication expense" Then
            t34.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Bank Charges" Then
            t35.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Employee benefits" Then
            t36.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Light, water and power" Then
            t37.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "General Assembly and Meeting expenses" Then
            t38.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Trucking Delivery Expenses" Then
            t39.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Incentives" Then
            t40.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Medical Benefits" Then
            t41.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Taxes and Licenses" Then
            t42.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Travel and Transportation" Then
            t43.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Audit and Inventory expense" Then
            t44.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Freight and handling" Then
            t45.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Depreciation and amortization" Then
            t46.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "SSS, EC and other contributions" Then
            t47.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Insurance expense" Then
            t48.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Representation and entertainment" Then
            t49.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Members Benefits" Then
            t50.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Affliation Fees" Then
            t51.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Professional Fees" Then
            t52.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Social Services" Then
            t53.Text = txtCredit5.Text
        ElseIf cbAcc15.Text = "Miscellaneous" Then
            t54.Text = txtCredit5.Text
        End If
    End Sub
End Class