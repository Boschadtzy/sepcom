Imports System.Data
Imports System.Data.SqlClient

Public Class SEPCOMCvViewDetails

  
    Private Sub TsExit_Click(sender As System.Object, e As System.EventArgs) Handles TsExit.Click

        Me.Hide()
    End Sub


    Private Sub SEPCOMCvViewDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        resetall()
    End Sub

    Sub resetall()
        cvprint()
        btnEdit.Enabled = False
        t1.Enabled = False
        t2.Enabled = False
        t3.Enabled = False
        t4.Enabled = False
        t5.Enabled = False
        t6.Enabled = False
        t7.Enabled = False
        t8.Enabled = False
        t9.Enabled = False
        t10.Enabled = False
        t11.Enabled = False
        t12.Enabled = False
        t13.Enabled = False
        t14.Enabled = False
        t15.Enabled = False
        t16.Enabled = False
        t17.Enabled = False
        t18.Enabled = False
        t19.Enabled = False
        t20.Enabled = False
        t21.Enabled = False
        t22.Enabled = False
        t23.Enabled = False
        t24.Enabled = False
        t25.Enabled = False
        t26.Enabled = False
        t27.Enabled = False
        t28.Enabled = False
        t29.Enabled = False
        t30.Enabled = False
        t31.Enabled = False
        t32.Enabled = False
        t33.Enabled = False
        t34.Enabled = False
        t35.Enabled = False
        t36.Enabled = False
        t37.Enabled = False
        t38.Enabled = False
        t39.Enabled = False
        t40.Enabled = False
        t41.Enabled = False
        t42.Enabled = False
        t43.Enabled = False
        t44.Enabled = False
        t45.Enabled = False
        t46.Enabled = False
        t47.Enabled = False
        t48.Enabled = False
        t49.Enabled = False
        t50.Enabled = False
        t51.Enabled = False
        t52.Enabled = False
        t53.Enabled = False
        t54.Enabled = False
        txtaddress.Enabled = False
        txtBank.Enabled = False
        txtBankNo.Enabled = False
        txtCvno.Enabled = False
        txtDate.Enabled = False
        txtPaidto.Enabled = False
        btnDelete.Enabled = False
        btnprint.Enabled = False
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
        txtaddress.Text = ""
        txtBank.Text = ""
        txtBankNo.Text = ""
        txtCvno.Text = ""
        txtDate.Text = ""
        txtPaidto.Text = ""


    End Sub
    Sub cvprint()
        Try
            connect()
            lvldata1.Items.Clear()
            SQl = "SELECT * FROM CVPrint"
            Dim cmd As New SqlCommand(SQl, con)
            dr = cmd.ExecuteReader
            While (dr.Read())
                With lvldata1.Items.Add(dr("IDno"))
                    .subitems.add(dr("Cvno"))
                    .subitems.add(dr("Date"))
                    .subitems.add(dr("Paidto"))
                    .subitems.add(dr("address"))
                    .subitems.add(dr("Bank"))
                    .subitems.add(dr("Bankno"))
                    .subitems.add(dr("CCE"))
                    .subitems.add(dr("LAR"))
                    .subitems.add(dr("INVS"))
                    .subitems.add(dr("OFALT"))
                    .subitems.add(dr("FAC"))
                    .subitems.add(dr("PE"))
                    .subitems.add(dr("SD"))
                    .subitems.add(dr("AP"))
                    .subitems.add(dr("AIP"))
                    .subitems.add(dr("MMFP"))
                    .subitems.add(dr("MBFP"))
                    .subitems.add(dr("DTFU"))
                    .subitems.add(dr("IOACPRP"))
                    .subitems.add(dr("FHIT"))
                    .subitems.add(dr("NP"))
                    .subitems.add(dr("RFP"))
                    .subitems.add(dr("MBF"))
                    .subitems.add(dr("PUSC"))
                    .subitems.add(dr("DAG"))
                    .subitems.add(dr("SF"))
                    .subitems.add(dr("AI"))
                    .subitems.add(dr("MF"))
                    .subitems.add(dr("INTINC"))
                    .subitems.add(dr("FAL"))
                    .subitems.add(dr("SAL"))
                    .subitems.add(dr("AHS"))
                    .subitems.add(dr("OHAA"))
                    .subitems.add(dr("RE"))
                    .subitems.add(dr("IA"))
                    .subitems.add(dr("RAM"))
                    .subitems.add(dr("PFPLOL"))
                    .subitems.add(dr("SOMS"))
                    .subitems.add(dr("MSDL"))
                    .subitems.add(dr("CE"))
                    .subitems.add(dr("BC"))
                    .subitems.add(dr("EB"))
                    .subitems.add(dr("LWP"))
                    .subitems.add(dr("GAME"))
                    .subitems.add(dr("TDE"))
                    .subitems.add(dr("MI"))
                    .subitems.add(dr("MMB"))
                    .subitems.add(dr("TL"))
                    .subitems.add(dr("TAT"))
                    .subitems.add(dr("AAIE"))
                    .subitems.add(dr("FAH"))
                    .subitems.add(dr("DAA"))
                    .subitems.add(dr("SEAOC"))
                    .subitems.add(dr("IE"))
                    .subitems.add(dr("RAE"))
                    .subitems.add(dr("MB"))
                    .subitems.add(dr("AF"))
                    .subitems.add(dr("PF"))
                    .subitems.add(dr("SS"))
                    .subitems.add(dr("MISC"))
                End With
            End While
            cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        On Error Resume Next
        Dim sum1 As Decimal
        Dim sum2 As Decimal
        Dim sum3 As Decimal
        Dim sum4 As Decimal
        Dim sum5 As Decimal
        Dim sum6 As Decimal
        Dim sum7 As Decimal
        Dim sum8 As Decimal
        Dim sum9 As Decimal
        Dim sum10 As Decimal

        Dim sum11 As Decimal
        Dim sum12 As Decimal
        Dim sum13 As Decimal
        Dim sum14 As Decimal
        Dim sum15 As Decimal
        Dim sum16 As Decimal
        Dim sum17 As Decimal
        Dim sum18 As Decimal
        Dim sum19 As Decimal
        Dim sum20 As Decimal

        Dim sum21 As Decimal
        Dim sum22 As Decimal
        Dim sum23 As Decimal
        Dim sum24 As Decimal
        Dim sum25 As Decimal
        Dim sum26 As Decimal
        Dim sum27 As Decimal
        Dim sum28 As Decimal
        Dim sum29 As Decimal
        Dim sum30 As Decimal

        Dim sum31 As Decimal
        Dim sum32 As Decimal
        Dim sum33 As Decimal
        Dim sum34 As Decimal
        Dim sum35 As Decimal
        Dim sum36 As Decimal
        Dim sum37 As Decimal
        Dim sum38 As Decimal
        Dim sum39 As Decimal
        Dim sum40 As Decimal

        Dim sum41 As Decimal
        Dim sum42 As Decimal
        Dim sum43 As Decimal
        Dim sum44 As Decimal
        Dim sum45 As Decimal
        Dim sum46 As Decimal
        Dim sum47 As Decimal
        Dim sum48 As Decimal
        Dim sum49 As Decimal
        Dim sum50 As Decimal

        Dim sum51 As Decimal
        Dim sum52 As Decimal
        Dim sum53 As Decimal
        Dim sum54 As Decimal
      
        For Each itemsum In lvldata1.Items
            sum1 += itemsum.Subitems.item(7).text
            sum2 += itemsum.Subitems.item(8).text
            sum3 += itemsum.Subitems.item(9).text
            sum4 += itemsum.Subitems.item(10).text
            sum5 += itemsum.Subitems.item(11).text
            sum6 += itemsum.Subitems.item(12).text
            sum7 += itemsum.Subitems.item(13).text
            sum8 += itemsum.Subitems.item(14).text
            sum9 += itemsum.Subitems.item(15).text
            sum10 += itemsum.Subitems.item(16).text

            sum11 += itemsum.Subitems.item(17).text
            sum12 += itemsum.Subitems.item(18).text
            sum13 += itemsum.Subitems.item(19).text
            sum14 += itemsum.Subitems.item(20).text
            sum15 += itemsum.Subitems.item(21).text
            sum16 += itemsum.Subitems.item(21).text
            sum17 += itemsum.Subitems.item(22).text
            sum18 += itemsum.Subitems.item(23).text
            sum19 += itemsum.Subitems.item(24).text
            sum20 += itemsum.Subitems.item(25).text

            sum21 += itemsum.Subitems.item(26).text
            sum22 += itemsum.Subitems.item(27).text
            sum23 += itemsum.Subitems.item(28).text
            sum24 += itemsum.Subitems.item(29).text
            sum25 += itemsum.Subitems.item(30).text
            sum26 += itemsum.Subitems.item(31).text
            sum27 += itemsum.Subitems.item(32).text
            sum28 += itemsum.Subitems.item(33).text
            sum29 += itemsum.Subitems.item(34).text
            sum30 += itemsum.Subitems.item(35).text

            sum31 += itemsum.Subitems.item(36).text
            sum32 += itemsum.Subitems.item(37).text
            sum33 += itemsum.Subitems.item(38).text
            sum34 += itemsum.Subitems.item(39).text
            sum35 += itemsum.Subitems.item(40).text
            sum36 += itemsum.Subitems.item(41).text
            sum37 += itemsum.Subitems.item(42).text
            sum38 += itemsum.Subitems.item(43).text
            sum39 += itemsum.Subitems.item(44).text
            sum40 += itemsum.Subitems.item(45).text

            sum41 += itemsum.Subitems.item(46).text
            sum42 += itemsum.Subitems.item(47).text
            sum43 += itemsum.Subitems.item(48).text
            sum44 += itemsum.Subitems.item(49).text
            sum45 += itemsum.Subitems.item(50).text
            sum46 += itemsum.Subitems.item(51).text
            sum47 += itemsum.Subitems.item(52).text
            sum48 += itemsum.Subitems.item(53).text
            sum49 += itemsum.Subitems.item(54).text
            sum50 += itemsum.Subitems.item(55).text

            sum51 += itemsum.Subitems.item(56).text
            sum52 += itemsum.Subitems.item(57).text
            sum53 += itemsum.Subitems.item(58).text
            sum54 += itemsum.Subitems.item(59).text
        

        Next
        t1.Text = sum1
        t2.Text = sum2
        t3.Text = sum3
        t4.Text = sum4
        t5.Text = sum5
        t6.Text = sum6
        t7.Text = sum7
        t8.Text = sum8
        t9.Text = sum9
        t10.Text = sum10

        t11.Text = sum11
        t12.Text = sum12
        t13.Text = sum13
        t14.Text = sum14
        t15.Text = sum15
        t16.Text = sum16
        t17.Text = sum17
        t18.Text = sum18
        t19.Text = sum19
        t20.Text = sum20

        t21.Text = sum21
        t22.Text = sum22
        t23.Text = sum23
        t24.Text = sum24
        t25.Text = sum25
        t26.Text = sum26
        t27.Text = sum27
        t28.Text = sum28
        t29.Text = sum29
        t30.Text = sum30

        t31.Text = sum31
        t32.Text = sum32
        t33.Text = sum33
        t34.Text = sum34
        t35.Text = sum35
        t36.Text = sum36
        t37.Text = sum37
        t38.Text = sum38
        t39.Text = sum39
        t40.Text = sum40

        t41.Text = sum41
        t42.Text = sum42
        t43.Text = sum43
        t44.Text = sum44
        t45.Text = sum45
        t46.Text = sum46
        t47.Text = sum47
        t48.Text = sum48
        t49.Text = sum49
        t50.Text = sum50

        t51.Text = sum51
        t52.Text = sum52
        t53.Text = sum53
        t54.Text = sum54


        txtTCA.Text = Val(t1.Text) + Val(t2.Text) + Val(t3.Text)
        TxtTNCA.Text = Val(t4.Text) + Val(t5.Text) + Val(t6.Text)
        txtTA.Text = Val(txtTCA.Text) + Val(TxtTNCA)
        txtTCL.Text = Val(t7.Text) + Val(t8.Text) + Val(t9.Text) + Val(t10.Text) + Val(t11.Text) + Val(t12.Text) + Val(t13.Text) + Val(t14.Text)
        txtTNCL.Text = Val(t15.Text) + Val(t16.Text) + Val(t17.Text)
        txtTL.Text = Val(txtTCL.Text) + Val(txtTNCL.Text)
        txtTE.Text = Val(t18.Text) + Val(t19.Text) + Val(t20.Text)
        txtTLE.Text = Val(txtTL.Text) + Val(txtTE.Text)
        txtTotal.Text = Val(t21.Text) + Val(t22.Text) + Val(t23.Text)
        txtTEX.Text = Val(t24.Text) + Val(t25.Text) + Val(t26.Text) + Val(t27.Text) + Val(t28.Text) + Val(t30.Text) + Val(t31.Text) + Val(t32.Text) + Val(t33.Text) + Val(t34.Text) + Val(t35.Text) + Val(t36.Text) + Val(t37.Text) + Val(t38.Text) + Val(t39.Text) + Val(t40.Text) + Val(t41.Text) + Val(t42.Text) + Val(t43.Text) + Val(t44.Text) + Val(t45.Text) + Val(t46.Text) + Val(t47.Text) + Val(t48.Text) + Val(t49.Text) + Val(t50.Text) + Val(t51.Text) + Val(t52.Text) + Val(t53.Text) + Val(t54.Text)

        btnprint.Enabled = True

       
    End Sub


    Private Sub btnshrs_Click(sender As System.Object, e As System.EventArgs) Handles btnshrs.Click
        Try


            If cb1.Checked = True Then
                connect()
                lvldata1.Items.Clear()
                SQl = "SELECT *  FROM CVPrint WHERE Date between @from and @to"
                Dim cmd As New SqlCommand(SQl, con)
                With cmd
                    Dim efrom As Date = txtfrom.Text
                    Dim eto As Date = txttoo.Text
                    .Parameters.AddWithValue("@from", efrom)
                    .Parameters.AddWithValue("@to", eto)
                End With
                dr = cmd.ExecuteReader
                While (dr.Read())
                    With lvldata1.Items.Add(dr("IDno"))
                        .subitems.add(dr("Cvno"))
                        .subitems.add(dr("Date"))
                        .subitems.add(dr("Paidto"))
                        .subitems.add(dr("address"))
                        .subitems.add(dr("Bank"))
                        .subitems.add(dr("Bankno"))

                        .subitems.add(dr("CCE"))
                        .subitems.add(dr("LAR"))
                        .subitems.add(dr("INVS"))
                        .subitems.add(dr("OFALT"))
                        .subitems.add(dr("FAC"))
                        .subitems.add(dr("PE"))
                        .subitems.add(dr("SD"))
                        .subitems.add(dr("AP"))
                        .subitems.add(dr("AIP"))
                        .subitems.add(dr("MMFP"))
                        .subitems.add(dr("MBFP"))
                        .subitems.add(dr("DTFU"))
                        .subitems.add(dr("IOACPRP"))
                        .subitems.add(dr("FHIT"))
                        .subitems.add(dr("NP"))
                        .subitems.add(dr("RFP"))
                        .subitems.add(dr("MBF"))
                        .subitems.add(dr("PUSC"))
                        .subitems.add(dr("DAG"))
                        .subitems.add(dr("SF"))
                        .subitems.add(dr("AI"))
                        .subitems.add(dr("MF"))
                        .subitems.add(dr("INTINC"))
                        .subitems.add(dr("FAL"))
                        .subitems.add(dr("SAL"))
                        .subitems.add(dr("AHS"))
                        .subitems.add(dr("OHAA"))
                        .subitems.add(dr("RE"))
                        .subitems.add(dr("IA"))
                        .subitems.add(dr("RAM"))
                        .subitems.add(dr("PFPLOL"))
                        .subitems.add(dr("SOMS"))
                        .subitems.add(dr("MSDL"))
                        .subitems.add(dr("CE"))
                        .subitems.add(dr("BC"))
                        .subitems.add(dr("EB"))
                        .subitems.add(dr("LWP"))
                        .subitems.add(dr("GAME"))
                        .subitems.add(dr("TDE"))
                        .subitems.add(dr("MI"))
                        .subitems.add(dr("MMB"))
                        .subitems.add(dr("TL"))
                        .subitems.add(dr("TAT"))
                        .subitems.add(dr("AAIE"))
                        .subitems.add(dr("FAH"))
                        .subitems.add(dr("DAA"))
                        .subitems.add(dr("SEAOC"))
                        .subitems.add(dr("IE"))
                        .subitems.add(dr("RAE"))
                        .subitems.add(dr("MB"))
                        .subitems.add(dr("AF"))
                        .subitems.add(dr("PF"))
                        .subitems.add(dr("SS"))
                        .subitems.add(dr("MISC"))
                    End With
                End While
                cmd.Dispose()
                dr.Close()
            Else
                connect()
                lvldata1.Items.Clear()
                SQl = "SELECT * FROM CVPrint WHERE [Cvno] like  '%" & txtsearch.Text & "%' or [Paidto] like '%" & txtsearch.Text & "%'"
                Dim cmd As New SqlCommand(SQl, con)
                dr = cmd.ExecuteReader
                While (dr.Read())
                    With lvldata1.Items.Add(dr("IDno"))
                        .subitems.add(dr("Cvno"))
                        .subitems.add(dr("Date"))
                        .subitems.add(dr("Paidto"))
                        .subitems.add(dr("address"))
                        .subitems.add(dr("Bank"))
                        .subitems.add(dr("Bankno"))

                        .subitems.add(dr("CCE"))
                        .subitems.add(dr("LAR"))
                        .subitems.add(dr("INVS"))
                        .subitems.add(dr("OFALT"))
                        .subitems.add(dr("FAC"))
                        .subitems.add(dr("PE"))
                        .subitems.add(dr("SD"))
                        .subitems.add(dr("AP"))
                        .subitems.add(dr("AIP"))
                        .subitems.add(dr("MMFP"))
                        .subitems.add(dr("MBFP"))
                        .subitems.add(dr("DTFU"))
                        .subitems.add(dr("IOACPRP"))
                        .subitems.add(dr("FHIT"))
                        .subitems.add(dr("NP"))
                        .subitems.add(dr("RFP"))
                        .subitems.add(dr("MBF"))
                        .subitems.add(dr("PUSC"))
                        .subitems.add(dr("DAG"))
                        .subitems.add(dr("SF"))
                        .subitems.add(dr("AI"))
                        .subitems.add(dr("MF"))
                        .subitems.add(dr("INTINC"))
                        .subitems.add(dr("FAL"))
                        .subitems.add(dr("SAL"))
                        .subitems.add(dr("AHS"))
                        .subitems.add(dr("OHAA"))
                        .subitems.add(dr("RE"))
                        .subitems.add(dr("IA"))
                        .subitems.add(dr("RAM"))
                        .subitems.add(dr("PFPLOL"))
                        .subitems.add(dr("SOMS"))
                        .subitems.add(dr("MSDL"))
                        .subitems.add(dr("CE"))
                        .subitems.add(dr("BC"))
                        .subitems.add(dr("EB"))
                        .subitems.add(dr("LWP"))
                        .subitems.add(dr("GAME"))
                        .subitems.add(dr("TDE"))
                        .subitems.add(dr("MI"))
                        .subitems.add(dr("MMB"))
                        .subitems.add(dr("TL"))
                        .subitems.add(dr("TAT"))
                        .subitems.add(dr("AAIE"))
                        .subitems.add(dr("FAH"))
                        .subitems.add(dr("DAA"))
                        .subitems.add(dr("SEAOC"))
                        .subitems.add(dr("IE"))
                        .subitems.add(dr("RAE"))
                        .subitems.add(dr("MB"))
                        .subitems.add(dr("AF"))
                        .subitems.add(dr("PF"))
                        .subitems.add(dr("SS"))
                        .subitems.add(dr("MISC"))
                    End With
                End While
                cmd.Dispose()
                dr.Close()
           

            End If
        Catch ex As Exception
            ' MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub lvldata1_Click(sender As Object, e As System.EventArgs) Handles lvldata1.Click
        On Error Resume Next
        With lvldata1.SelectedItems(0)
            txtID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtDate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            t1.Text = .SubItems(7).Text
            t2.Text = .SubItems(8).Text
            t3.Text = .SubItems(9).Text
            t4.Text = .SubItems(10).Text
            t5.Text = .SubItems(11).Text
            t6.Text = .SubItems(12).Text
            t7.Text = .SubItems(13).Text
            t8.Text = .SubItems(14).Text
            t9.Text = .SubItems(15).Text
            t10.Text = .SubItems(16).Text
            t11.Text = .SubItems(17).Text
            t12.Text = .SubItems(18).Text
            t13.Text = .SubItems(19).Text
            t14.Text = .SubItems(20).Text
            t15.Text = .SubItems(21).Text
            t16.Text = .SubItems(22).Text
            t17.Text = .SubItems(23).Text
            t18.Text = .SubItems(24).Text
            t19.Text = .SubItems(25).Text
            t20.Text = .SubItems(26).Text
            t21.Text = .SubItems(27).Text
            t22.Text = .SubItems(28).Text
            t23.Text = .SubItems(29).Text
            t24.Text = .SubItems(30).Text
            t25.Text = .SubItems(31).Text
            t26.Text = .SubItems(32).Text
            t27.Text = .SubItems(33).Text
            t28.Text = .SubItems(34).Text
            t29.Text = .SubItems(35).Text
            t30.Text = .SubItems(36).Text
            t31.Text = .SubItems(37).Text
            t32.Text = .SubItems(38).Text
            t33.Text = .SubItems(39).Text
            t34.Text = .SubItems(40).Text
            t35.Text = .SubItems(41).Text
            t36.Text = .SubItems(42).Text
            t37.Text = .SubItems(43).Text
            t38.Text = .SubItems(44).Text
            t39.Text = .SubItems(45).Text
            t40.Text = .SubItems(46).Text
            t41.Text = .SubItems(47).Text
            t42.Text = .SubItems(48).Text
            t43.Text = .SubItems(49).Text
            t44.Text = .SubItems(50).Text
            t45.Text = .SubItems(51).Text
            t46.Text = .SubItems(52).Text
            t47.Text = .SubItems(53).Text
            t48.Text = .SubItems(54).Text
            t49.Text = .SubItems(55).Text
            t50.Text = .SubItems(56).Text
            t51.Text = .SubItems(57).Text
            t52.Text = .SubItems(58).Text
            t53.Text = .SubItems(59).Text
            t54.Text = .SubItems(60).Text
        End With
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnEdit.Text = "Edit"
        btnprint.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub lvldata1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvldata1.KeyDown
        On Error Resume Next
        With lvldata1.SelectedItems(0)
            txtID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtDate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            t1.Text = .SubItems(7).Text
            t2.Text = .SubItems(8).Text
            t3.Text = .SubItems(9).Text
            t4.Text = .SubItems(10).Text
            t5.Text = .SubItems(11).Text
            t6.Text = .SubItems(12).Text
            t7.Text = .SubItems(13).Text
            t8.Text = .SubItems(14).Text
            t9.Text = .SubItems(15).Text
            t10.Text = .SubItems(16).Text
            t11.Text = .SubItems(17).Text
            t12.Text = .SubItems(18).Text
            t13.Text = .SubItems(19).Text
            t14.Text = .SubItems(20).Text
            t15.Text = .SubItems(21).Text
            t16.Text = .SubItems(22).Text
            t17.Text = .SubItems(23).Text
            t18.Text = .SubItems(24).Text
            t19.Text = .SubItems(25).Text
            t20.Text = .SubItems(26).Text
            t21.Text = .SubItems(27).Text
            t22.Text = .SubItems(28).Text
            t23.Text = .SubItems(29).Text
            t24.Text = .SubItems(30).Text
            t25.Text = .SubItems(31).Text
            t26.Text = .SubItems(32).Text
            t27.Text = .SubItems(33).Text
            t28.Text = .SubItems(34).Text
            t29.Text = .SubItems(35).Text
            t30.Text = .SubItems(36).Text
            t31.Text = .SubItems(37).Text
            t32.Text = .SubItems(38).Text
            t33.Text = .SubItems(39).Text
            t34.Text = .SubItems(40).Text
            t35.Text = .SubItems(41).Text
            t36.Text = .SubItems(42).Text
            t37.Text = .SubItems(43).Text
            t38.Text = .SubItems(44).Text
            t39.Text = .SubItems(45).Text
            t40.Text = .SubItems(46).Text
            t41.Text = .SubItems(47).Text
            t42.Text = .SubItems(48).Text
            t43.Text = .SubItems(49).Text
            t44.Text = .SubItems(50).Text
            t45.Text = .SubItems(51).Text
            t46.Text = .SubItems(52).Text
            t47.Text = .SubItems(53).Text
            t48.Text = .SubItems(54).Text
            t49.Text = .SubItems(55).Text
            t50.Text = .SubItems(56).Text
            t51.Text = .SubItems(57).Text
            t52.Text = .SubItems(58).Text
            t53.Text = .SubItems(59).Text
            t54.Text = .SubItems(60).Text
        End With
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnEdit.Text = "Edit"
        btnprint.Enabled = True
        btnClear.Enabled = True
    End Sub


    Private Sub lvldata1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvldata1.KeyUp
        On Error Resume Next
        With lvldata1.SelectedItems(0)
            txtID.Text = .SubItems(0).Text
            txtCvno.Text = .SubItems(1).Text
            txtDate.Text = .SubItems(2).Text
            txtPaidto.Text = .SubItems(3).Text
            txtaddress.Text = .SubItems(4).Text
            txtBank.Text = .SubItems(5).Text
            txtBankNo.Text = .SubItems(6).Text
            t1.Text = .SubItems(7).Text
            t2.Text = .SubItems(8).Text
            t3.Text = .SubItems(9).Text
            t4.Text = .SubItems(10).Text
            t5.Text = .SubItems(11).Text
            t6.Text = .SubItems(12).Text
            t7.Text = .SubItems(13).Text
            t8.Text = .SubItems(14).Text
            t9.Text = .SubItems(15).Text
            t10.Text = .SubItems(16).Text
            t11.Text = .SubItems(17).Text
            t12.Text = .SubItems(18).Text
            t13.Text = .SubItems(19).Text
            t14.Text = .SubItems(20).Text
            t15.Text = .SubItems(21).Text
            t16.Text = .SubItems(22).Text
            t17.Text = .SubItems(23).Text
            t18.Text = .SubItems(24).Text
            t19.Text = .SubItems(25).Text
            t20.Text = .SubItems(26).Text
            t21.Text = .SubItems(27).Text
            t22.Text = .SubItems(28).Text
            t23.Text = .SubItems(29).Text
            t24.Text = .SubItems(30).Text
            t25.Text = .SubItems(31).Text
            t26.Text = .SubItems(32).Text
            t27.Text = .SubItems(33).Text
            t28.Text = .SubItems(34).Text
            t29.Text = .SubItems(35).Text
            t30.Text = .SubItems(36).Text
            t31.Text = .SubItems(37).Text
            t32.Text = .SubItems(38).Text
            t33.Text = .SubItems(39).Text
            t34.Text = .SubItems(40).Text
            t35.Text = .SubItems(41).Text
            t36.Text = .SubItems(42).Text
            t37.Text = .SubItems(43).Text
            t38.Text = .SubItems(44).Text
            t39.Text = .SubItems(45).Text
            t40.Text = .SubItems(46).Text
            t41.Text = .SubItems(47).Text
            t42.Text = .SubItems(48).Text
            t43.Text = .SubItems(49).Text
            t44.Text = .SubItems(50).Text
            t45.Text = .SubItems(51).Text
            t46.Text = .SubItems(52).Text
            t47.Text = .SubItems(53).Text
            t48.Text = .SubItems(54).Text
            t49.Text = .SubItems(55).Text
            t50.Text = .SubItems(56).Text
            t51.Text = .SubItems(57).Text
            t52.Text = .SubItems(58).Text
            t53.Text = .SubItems(59).Text
            t54.Text = .SubItems(60).Text
        End With
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnEdit.Text = "Edit"
        btnprint.Enabled = True
        btnClear.Enabled = True
    End Sub

    Private Sub lvldata1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvldata1.SelectedIndexChanged

    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        cvprint()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        resetall()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            edit()
            txtCvno.Focus()
            Exit Sub
        ElseIf btnEdit.Text = "Update" Then
            If Cvno.Text = "" Or txtDate.Text = "" Or txtaddress.Text = "" Or txtBank.Text = "" Or txtBankNo.Text = "" Or txtPaidto.Text = "" Then
                MessageBox.Show("Complete the details !", "Missing value error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                connect()
                SQl = "UPDATE CVPrint SET [Cvno]='" & txtCvno.Text.ToString & "',[Date]='" & txtDate.Text.ToString & "',[Paidto]='" & txtPaidto.Text.ToString & "',[address]='" & txtaddress.Text.ToString & "',[Bank]='" & txtBank.Text.ToString & "',[Bankno]='" & txtBankNo.Text.ToString & "',[CCE]='" & t1.Text.ToString & "',[LAR]='" & t2.Text.ToString & "',[INVS]='" & t3.Text.ToString & "',[OFALT]='" & t4.Text.ToString & "',[FAC]='" & t5.Text.ToString & "',[PE]='" & t6.Text.ToString & "'    ,[SD]='" & t7.Text.ToString & "',[AP]='" & t8.Text.ToString & "',[AIP]='" & t9.Text.ToString & "',[MMFP]='" & t10.Text.ToString & "',[MBFP]='" & t11.Text.ToString & "',[DTFU]='" & t12.Text.ToString & "',[IOACPRP]='" & t13.Text.ToString & "',[FHIT]='" & t14.Text.ToString & "',[NP]='" & t15.Text.ToString & "',[RFP]='" & t16.Text.ToString & "',[MBF]='" & t17.Text.ToString & "',[PUSC]='" & t18.Text.ToString & "',[DAG]='" & t19.Text.ToString & "',[SF]='" & t20.Text.ToString & "',[AI]='" & t21.Text.ToString & "',[MF]='" & t22.Text.ToString & "',[INTINC]='" & t23.Text.ToString & "',[FAL]='" & t24.Text.ToString & "',[SAL]='" & t25.Text.ToString & "',[AHS]='" & t26.Text.ToString & "',[OHAA]='" & t27.Text.ToString & "',[RE]='" & t28.Text.ToString & "',[IA]='" & t29.Text.ToString & "',[RAM]='" & t30.Text.ToString & "',[PFPLOL]='" & t31.Text.ToString & "',[SOMS]='" & t32.Text.ToString & "',[MSDL]='" & t33.Text.ToString & "',[CE]='" & t34.Text.ToString & "',[BC]='" & t35.Text.ToString & "',[EB]='" & t36.Text.ToString & "',[LWP]='" & t37.Text.ToString & "',[GAME]='" & t38.Text.ToString & "',[TDE]='" & t39.Text.ToString & "',[MI]='" & t40.Text.ToString & "',[MMB]='" & t41.Text.ToString & "',[TL]='" & t42.Text.ToString & "',[TAT]='" & t43.Text.ToString & "',[AAIE]='" & t44.Text.ToString & "',[FAH]='" & t45.Text.ToString & "',[DAA]='" & t46.Text.ToString & "',[SEAOC]='" & t47.Text.ToString & "',[IE]='" & t48.Text.ToString & "',[RAE]='" & t49.Text.ToString & "',[MB]='" & t50.Text.ToString & "',[AF]='" & t51.Text.ToString & "',[PF]='" & t52.Text.ToString & "',[SS]='" & t53.Text.ToString & "',[MISC]='" & t54.Text.ToString & "' WHERE IDno=@IDno"
                Dim cmd As New SqlCommand(SQl, con)
                With cmd
                    .Parameters.AddWithValue("@IDno", txtID.Text)
                End With
                cmd.ExecuteNonQuery()
                'cmd.Dispose()
                dr.Close()
                MessageBox.Show("Information successfully updated !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                resetall()
            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Sub edit()
        btnEdit.Text = "Update"
        t1.Enabled = True
        t2.Enabled = True
        t3.Enabled = True
        t4.Enabled = True
        t5.Enabled = True
        t6.Enabled = True
        t7.Enabled = True
        t8.Enabled = True
        t9.Enabled = True
        t10.Enabled = True
        t11.Enabled = True
        t12.Enabled = True
        t13.Enabled = True
        t14.Enabled = True
        t15.Enabled = True
        t16.Enabled = True
        t17.Enabled = True
        t18.Enabled = True
        t19.Enabled = True
        t20.Enabled = True
        t21.Enabled = True
        t22.Enabled = True
        t23.Enabled = True
        t24.Enabled = True
        t25.Enabled = True
        t26.Enabled = True
        t27.Enabled = True
        t28.Enabled = True
        t29.Enabled = True
        t30.Enabled = True
        t31.Enabled = True
        t32.Enabled = True
        t33.Enabled = True
        t34.Enabled = True
        t35.Enabled = True
        t36.Enabled = True
        t37.Enabled = True
        t38.Enabled = True
        t39.Enabled = True
        t40.Enabled = True
        t41.Enabled = True
        t42.Enabled = True
        t43.Enabled = True
        t44.Enabled = True
        t45.Enabled = True
        t46.Enabled = True
        t47.Enabled = True
        t48.Enabled = True
        t49.Enabled = True
        t50.Enabled = True
        t51.Enabled = True
        t52.Enabled = True
        t53.Enabled = True
        txtaddress.Enabled = True
        txtBank.Enabled = True
        txtBankNo.Enabled = True
        txtCvno.Enabled = True
        txtDate.Enabled = True
        txtPaidto.Enabled = True
        btnDelete.Enabled = True
        btnprint.Enabled = True

    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click

        Dim num1 As Double = t1.Text
        SEPCOMVCPrintReport.lblt1.Text = num1.ToString("###,###,###.00")
        Dim num2 As Double = t2.Text
        SEPCOMVCPrintReport.lblt2.Text = num2.ToString("###,###,###.00")
        Dim num3 As Double = t3.Text
        SEPCOMVCPrintReport.lblt3.Text = num3.ToString("###,###,###.00")
        Dim num4 As Double = t4.Text
        SEPCOMVCPrintReport.lblt4.Text = num4.ToString("###,###,###.00")
        Dim num5 As Double = t5.Text
        SEPCOMVCPrintReport.lblt5.Text = num5.ToString("###,###,###.00")
        Dim num6 As Double = t6.Text
        SEPCOMVCPrintReport.lblt6.Text = num6.ToString("###,###,###.00")
        Dim num7 As Double = t7.Text
        SEPCOMVCPrintReport.lblt7.Text = num7.ToString("###,###,###.00")
        Dim num8 As Double = t8.Text
        SEPCOMVCPrintReport.lblt8.Text = num8.ToString("###,###,###.00")
        Dim num9 As Double = t9.Text
        SEPCOMVCPrintReport.lblt9.Text = num9.ToString("###,###,###.00")
        Dim num10 As Double = t10.Text
        SEPCOMVCPrintReport.lblt10.Text = num10.ToString("###,###,###.00")
        Dim num11 As Double = t11.Text
        SEPCOMVCPrintReport.lblt11.Text = num11.ToString("###,###,###.00")
        Dim num12 As Double = t12.Text
        SEPCOMVCPrintReport.lblt12.Text = num12.ToString("###,###,###.00")
        Dim num13 As Double = t13.Text
        SEPCOMVCPrintReport.lbl13.Text = num13.ToString("###,###,###.00")
        Dim num14 As Double = t14.Text
        SEPCOMVCPrintReport.lblt14.Text = num14.ToString("###,###,###.00")
        Dim num15 As Double = t15.Text
        SEPCOMVCPrintReport.lblt15.Text = num15.ToString("###,###,###.00")
        Dim num16 As Double = t16.Text
        SEPCOMVCPrintReport.lblt16.Text = num16.ToString("###,###,###.00")
        Dim num17 As Double = t17.Text
        SEPCOMVCPrintReport.lblt17.Text = num17.ToString("###,###,###.00")
        Dim num18 As Double = t18.Text
        SEPCOMVCPrintReport.lblt18.Text = num18.ToString("###,###,###.00")
        Dim num19 As Double = t19.Text
        SEPCOMVCPrintReport.lblt19.Text = num19.ToString("###,###,###.00")
        Dim num20 As Double = t20.Text
        SEPCOMVCPrintReport.lbl20.Text = num20.ToString("###,###,###.00")
        Dim num21 As Double = txtTCA.Text
        SEPCOMVCPrintReport.lblTCA.Text = num21.ToString("###,###,###.00")
        Dim num22 As Double = TxtTNCA.Text
        SEPCOMVCPrintReport.lblTNCA.Text = num22.ToString("###,###,###.00")
        Dim num23 As Double = txtTA.Text
        SEPCOMVCPrintReport.lblTA.Text = num23.ToString("###,###,###.00")
        Dim num24 As Double = txtTCL.Text
        SEPCOMVCPrintReport.lblTCL.Text = num24.ToString("###,###,###.00")
        Dim num25 As Double = txtTNCL.Text
        SEPCOMVCPrintReport.lblTNCL.Text = num25.ToString("###,###,###.00")
        Dim num26 As Double = txtTL.Text
        SEPCOMVCPrintReport.lblTL.Text = num26.ToString("###,###,###.00")
        Dim num27 As Double = txtTE.Text
        SEPCOMVCPrintReport.lblTE.Text = num27.ToString("###,###,###.00")
        Dim num28 As Double = txtTLE.Text
        SEPCOMVCPrintReport.lblTLE.Text = num28.ToString("###,###,###.00")









        SEPCOMVCPrintReport.Show()
      
    End Sub

  
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
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
                    SQl = "DELETE FROM CVPrint WHERE IDno=@userID"
                    Dim cmd As New SqlCommand(SQl, con)
                    With cmd
                        .Parameters.AddWithValue("@userID", txtID.Text)
                    End With
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    dr.Close()
                    MessageBox.Show("Information successfully deleted !", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cvprint()
                Catch ex As Exception
                    MessageBox.Show("Error : " & ex.Message & vbNewLine & vbNewLine & coner, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.TextChanged

    End Sub

    Private Sub LabelX69_Click(sender As System.Object, e As System.EventArgs) Handles LabelX69.Click

    End Sub

    Private Sub txtfrom_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtfrom.ValueChanged

    End Sub

    Private Sub txttoo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txttoo.ValueChanged

    End Sub

    Private Sub txtID_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub cb1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb1.CheckedChanged

    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub t38_TextChanged(sender As System.Object, e As System.EventArgs) Handles t38.TextChanged

    End Sub

    Private Sub t11_TextChanged(sender As System.Object, e As System.EventArgs) Handles t11.TextChanged

    End Sub

    Private Sub t12_TextChanged(sender As System.Object, e As System.EventArgs) Handles t12.TextChanged

    End Sub

    Private Sub t39_TextChanged(sender As System.Object, e As System.EventArgs) Handles t39.TextChanged

    End Sub

    Private Sub t37_TextChanged(sender As System.Object, e As System.EventArgs) Handles t37.TextChanged

    End Sub

    Private Sub t10_TextChanged(sender As System.Object, e As System.EventArgs) Handles t10.TextChanged

    End Sub

    Private Sub t13_TextChanged(sender As System.Object, e As System.EventArgs) Handles t13.TextChanged

    End Sub

    Private Sub t40_TextChanged(sender As System.Object, e As System.EventArgs) Handles t40.TextChanged

    End Sub

    Private Sub t36_TextChanged(sender As System.Object, e As System.EventArgs) Handles t36.TextChanged

    End Sub

    Private Sub t9_TextChanged(sender As System.Object, e As System.EventArgs) Handles t9.TextChanged

    End Sub

    Private Sub t15_TextChanged(sender As System.Object, e As System.EventArgs) Handles t15.TextChanged

    End Sub

    Private Sub t41_TextChanged(sender As System.Object, e As System.EventArgs) Handles t41.TextChanged

    End Sub

    Private Sub LabelX22_Click(sender As System.Object, e As System.EventArgs) Handles LabelX22.Click

    End Sub

    Private Sub t8_TextChanged(sender As System.Object, e As System.EventArgs) Handles t8.TextChanged

    End Sub

    Private Sub LabelX55_Click(sender As System.Object, e As System.EventArgs) Handles LabelX55.Click

    End Sub

    Private Sub t6_TextChanged(sender As System.Object, e As System.EventArgs) Handles t6.TextChanged

    End Sub

    Private Sub LabelX23_Click(sender As System.Object, e As System.EventArgs) Handles LabelX23.Click

    End Sub

    Private Sub LabelX54_Click(sender As System.Object, e As System.EventArgs) Handles LabelX54.Click

    End Sub

    Private Sub LabelX20_Click(sender As System.Object, e As System.EventArgs) Handles LabelX20.Click

    End Sub

    Private Sub LabelX24_Click(sender As System.Object, e As System.EventArgs) Handles LabelX24.Click

    End Sub

    Private Sub t44_TextChanged(sender As System.Object, e As System.EventArgs) Handles t44.TextChanged

    End Sub

    Private Sub LabelX53_Click(sender As System.Object, e As System.EventArgs) Handles LabelX53.Click

    End Sub

    Private Sub LabelX19_Click(sender As System.Object, e As System.EventArgs) Handles LabelX19.Click

    End Sub

    Private Sub LabelX25_Click(sender As System.Object, e As System.EventArgs) Handles LabelX25.Click

    End Sub

    Private Sub t45_TextChanged(sender As System.Object, e As System.EventArgs) Handles t45.TextChanged

    End Sub

    Private Sub LabelX52_Click(sender As System.Object, e As System.EventArgs) Handles LabelX52.Click

    End Sub

    Private Sub LabelX18_Click(sender As System.Object, e As System.EventArgs) Handles LabelX18.Click

    End Sub

    Private Sub LabelX26_Click(sender As System.Object, e As System.EventArgs) Handles LabelX26.Click

    End Sub

    Private Sub t46_TextChanged(sender As System.Object, e As System.EventArgs) Handles t46.TextChanged

    End Sub

    Private Sub LabelX51_Click(sender As System.Object, e As System.EventArgs) Handles LabelX51.Click

    End Sub

    Private Sub LabelX17_Click(sender As System.Object, e As System.EventArgs) Handles LabelX17.Click

    End Sub

    Private Sub LabelX27_Click(sender As System.Object, e As System.EventArgs) Handles LabelX27.Click

    End Sub

    Private Sub t47_TextChanged(sender As System.Object, e As System.EventArgs) Handles t47.TextChanged

    End Sub

    Private Sub LabelX50_Click(sender As System.Object, e As System.EventArgs) Handles LabelX50.Click

    End Sub

    Private Sub LabelX16_Click(sender As System.Object, e As System.EventArgs) Handles LabelX16.Click

    End Sub

    Private Sub t16_TextChanged(sender As System.Object, e As System.EventArgs) Handles t16.TextChanged

    End Sub

    Private Sub t48_TextChanged(sender As System.Object, e As System.EventArgs) Handles t48.TextChanged

    End Sub

    Private Sub t17_TextChanged(sender As System.Object, e As System.EventArgs) Handles t17.TextChanged

    End Sub

    Private Sub LabelX13_Click(sender As System.Object, e As System.EventArgs) Handles LabelX13.Click

    End Sub

    Private Sub LabelX48_Click(sender As System.Object, e As System.EventArgs) Handles LabelX48.Click

    End Sub

    Private Sub t50_TextChanged(sender As System.Object, e As System.EventArgs) Handles t50.TextChanged

    End Sub

    Private Sub t18_TextChanged(sender As System.Object, e As System.EventArgs) Handles t18.TextChanged

    End Sub

    Private Sub LabelX47_Click(sender As System.Object, e As System.EventArgs) Handles LabelX47.Click

    End Sub

    Private Sub LabelX57_Click(sender As System.Object, e As System.EventArgs) Handles LabelX57.Click

    End Sub

    Private Sub t19_TextChanged(sender As System.Object, e As System.EventArgs) Handles t19.TextChanged

    End Sub

    Private Sub LabelX8_Click(sender As System.Object, e As System.EventArgs) Handles LabelX8.Click

    End Sub

    Private Sub LabelX46_Click(sender As System.Object, e As System.EventArgs) Handles LabelX46.Click

    End Sub

    Private Sub LabelX58_Click(sender As System.Object, e As System.EventArgs) Handles LabelX58.Click

    End Sub

    Private Sub t20_TextChanged(sender As System.Object, e As System.EventArgs) Handles t20.TextChanged

    End Sub

    Private Sub LabelX21_Click(sender As System.Object, e As System.EventArgs) Handles LabelX21.Click

    End Sub

    Private Sub LabelX45_Click(sender As System.Object, e As System.EventArgs) Handles LabelX45.Click

    End Sub

    Private Sub LabelX7_Click(sender As System.Object, e As System.EventArgs) Handles LabelX7.Click

    End Sub

    Private Sub LabelX29_Click(sender As System.Object, e As System.EventArgs) Handles LabelX29.Click

    End Sub

    Private Sub t7_TextChanged(sender As System.Object, e As System.EventArgs) Handles t7.TextChanged

    End Sub

    Private Sub LabelX44_Click(sender As System.Object, e As System.EventArgs) Handles LabelX44.Click

    End Sub

    Private Sub LabelX59_Click(sender As System.Object, e As System.EventArgs) Handles LabelX59.Click

    End Sub

    Private Sub LabelX30_Click(sender As System.Object, e As System.EventArgs) Handles LabelX30.Click

    End Sub

    Private Sub t14_TextChanged(sender As System.Object, e As System.EventArgs) Handles t14.TextChanged

    End Sub

    Private Sub LabelX31_Click(sender As System.Object, e As System.EventArgs) Handles LabelX31.Click

    End Sub

    Private Sub LabelX6_Click(sender As System.Object, e As System.EventArgs) Handles LabelX6.Click

    End Sub

    Private Sub t34_TextChanged(sender As System.Object, e As System.EventArgs) Handles t34.TextChanged

    End Sub

    Private Sub LabelX28_Click(sender As System.Object, e As System.EventArgs) Handles LabelX28.Click

    End Sub

    Private Sub LabelX32_Click(sender As System.Object, e As System.EventArgs) Handles LabelX32.Click

    End Sub

    Private Sub LabelX60_Click(sender As System.Object, e As System.EventArgs) Handles LabelX60.Click

    End Sub

    Private Sub t33_TextChanged(sender As System.Object, e As System.EventArgs) Handles t33.TextChanged

    End Sub

    Private Sub LabelX35_Click(sender As System.Object, e As System.EventArgs) Handles LabelX35.Click

    End Sub

    Private Sub LabelX33_Click(sender As System.Object, e As System.EventArgs) Handles LabelX33.Click

    End Sub

    Private Sub t5_TextChanged(sender As System.Object, e As System.EventArgs) Handles t5.TextChanged

    End Sub

    Private Sub t32_TextChanged(sender As System.Object, e As System.EventArgs) Handles t32.TextChanged

    End Sub

    Private Sub t21_TextChanged(sender As System.Object, e As System.EventArgs) Handles t21.TextChanged

    End Sub

    Private Sub LabelX34_Click(sender As System.Object, e As System.EventArgs) Handles LabelX34.Click

    End Sub

    Private Sub t31_TextChanged(sender As System.Object, e As System.EventArgs) Handles t31.TextChanged

    End Sub

    Private Sub LabelX12_Click(sender As System.Object, e As System.EventArgs) Handles LabelX12.Click

    End Sub

    Private Sub t22_TextChanged(sender As System.Object, e As System.EventArgs) Handles t22.TextChanged

    End Sub

    Private Sub LabelX11_Click(sender As System.Object, e As System.EventArgs) Handles LabelX11.Click

    End Sub

    Private Sub t30_TextChanged(sender As System.Object, e As System.EventArgs) Handles t30.TextChanged

    End Sub

    Private Sub LabelX42_Click(sender As System.Object, e As System.EventArgs) Handles LabelX42.Click

    End Sub

    Private Sub t23_TextChanged(sender As System.Object, e As System.EventArgs) Handles t23.TextChanged

    End Sub

    Private Sub t4_TextChanged(sender As System.Object, e As System.EventArgs) Handles t4.TextChanged

    End Sub

    Private Sub t29_TextChanged(sender As System.Object, e As System.EventArgs) Handles t29.TextChanged

    End Sub

    Private Sub t28_TextChanged(sender As System.Object, e As System.EventArgs) Handles t28.TextChanged

    End Sub

    Private Sub t24_TextChanged(sender As System.Object, e As System.EventArgs) Handles t24.TextChanged

    End Sub

    Private Sub t51_TextChanged(sender As System.Object, e As System.EventArgs) Handles t51.TextChanged

    End Sub

    Private Sub t25_TextChanged(sender As System.Object, e As System.EventArgs) Handles t25.TextChanged

    End Sub

    Private Sub t35_TextChanged(sender As System.Object, e As System.EventArgs) Handles t35.TextChanged

    End Sub

    Private Sub t27_TextChanged(sender As System.Object, e As System.EventArgs) Handles t27.TextChanged

    End Sub

    Private Sub t3_TextChanged(sender As System.Object, e As System.EventArgs) Handles t3.TextChanged

    End Sub

    Private Sub LabelX36_Click(sender As System.Object, e As System.EventArgs) Handles LabelX36.Click

    End Sub

    Private Sub LabelX49_Click(sender As System.Object, e As System.EventArgs) Handles LabelX49.Click

    End Sub

    Private Sub t26_TextChanged(sender As System.Object, e As System.EventArgs) Handles t26.TextChanged

    End Sub

    Private Sub t52_TextChanged(sender As System.Object, e As System.EventArgs) Handles t52.TextChanged

    End Sub

    Private Sub LabelX37_Click(sender As System.Object, e As System.EventArgs) Handles LabelX37.Click

    End Sub

    Private Sub LabelX56_Click(sender As System.Object, e As System.EventArgs) Handles LabelX56.Click

    End Sub

    Private Sub LabelX43_Click(sender As System.Object, e As System.EventArgs) Handles LabelX43.Click

    End Sub

    Private Sub t2_TextChanged(sender As System.Object, e As System.EventArgs) Handles t2.TextChanged

    End Sub

    Private Sub LabelX38_Click(sender As System.Object, e As System.EventArgs) Handles LabelX38.Click

    End Sub

    Private Sub t42_TextChanged(sender As System.Object, e As System.EventArgs) Handles t42.TextChanged

    End Sub

    Private Sub LabelX39_Click(sender As System.Object, e As System.EventArgs) Handles LabelX39.Click

    End Sub

    Private Sub t53_TextChanged(sender As System.Object, e As System.EventArgs) Handles t53.TextChanged

    End Sub

    Private Sub LabelX41_Click(sender As System.Object, e As System.EventArgs) Handles LabelX41.Click

    End Sub

    Private Sub t49_TextChanged(sender As System.Object, e As System.EventArgs) Handles t49.TextChanged

    End Sub

    Private Sub LabelX40_Click(sender As System.Object, e As System.EventArgs) Handles LabelX40.Click

    End Sub

    Private Sub t1_TextChanged(sender As System.Object, e As System.EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub LabelX9_Click(sender As System.Object, e As System.EventArgs) Handles LabelX9.Click

    End Sub

    Private Sub LabelX10_Click(sender As System.Object, e As System.EventArgs) Handles LabelX10.Click

    End Sub

    Private Sub LabelX5_Click(sender As System.Object, e As System.EventArgs) Handles LabelX5.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LabelX61_Click(sender As System.Object, e As System.EventArgs) Handles LabelX61.Click

    End Sub

    Private Sub txtTCA_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTCA.TextChanged

    End Sub

    Private Sub TxtTNCA_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTNCA.TextChanged

    End Sub

    Private Sub LabelX62_Click(sender As System.Object, e As System.EventArgs) Handles LabelX62.Click

    End Sub

    Private Sub txtTA_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTA.TextChanged

    End Sub

    Private Sub LabelX65_Click(sender As System.Object, e As System.EventArgs) Handles LabelX65.Click

    End Sub

    Private Sub txtTCL_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTCL.TextChanged

    End Sub

    Private Sub txtTNCL_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTNCL.TextChanged

    End Sub

    Private Sub LabelX64_Click(sender As System.Object, e As System.EventArgs) Handles LabelX64.Click

    End Sub

    Private Sub LabelX63_Click(sender As System.Object, e As System.EventArgs) Handles LabelX63.Click

    End Sub

    Private Sub txtTL_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTL.TextChanged

    End Sub

    Private Sub LabelX66_Click(sender As System.Object, e As System.EventArgs) Handles LabelX66.Click

    End Sub

    Private Sub txtTE_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTE.TextChanged

    End Sub

    Private Sub LabelX67_Click(sender As System.Object, e As System.EventArgs) Handles LabelX67.Click

    End Sub

    Private Sub txtTLE_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTLE.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub LabelX71_Click(sender As System.Object, e As System.EventArgs) Handles LabelX71.Click

    End Sub

    Private Sub txtTEX_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTEX.TextChanged

    End Sub

    Private Sub LabelX68_Click(sender As System.Object, e As System.EventArgs) Handles LabelX68.Click

    End Sub

    Private Sub t43_TextChanged(sender As System.Object, e As System.EventArgs) Handles t43.TextChanged

    End Sub

    Private Sub LabelX1_Click(sender As System.Object, e As System.EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub txtCvno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCvno.TextChanged

    End Sub

    Private Sub LabelX2_Click(sender As System.Object, e As System.EventArgs) Handles LabelX2.Click

    End Sub

    Private Sub txtPaidto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPaidto.TextChanged

    End Sub

    Private Sub LabelX3_Click(sender As System.Object, e As System.EventArgs) Handles LabelX3.Click

    End Sub

    Private Sub LabelX4_Click(sender As System.Object, e As System.EventArgs) Handles LabelX4.Click

    End Sub

    Private Sub txtaddress_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtDate_Click(sender As System.Object, e As System.EventArgs) Handles txtDate.Click

    End Sub

    Private Sub LabelX14_Click(sender As System.Object, e As System.EventArgs) Handles LabelX14.Click

    End Sub

    Private Sub txtBank_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBank.TextChanged

    End Sub

    Private Sub txtBankNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBankNo.TextChanged

    End Sub

    Private Sub LabelX15_Click(sender As System.Object, e As System.EventArgs) Handles LabelX15.Click

    End Sub

    Private Sub ToolStripSeparator5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripSeparator5.Click

    End Sub

    Private Sub ToolStripSeparator3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripSeparator3.Click

    End Sub

    Private Sub ToolStripSeparator2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
