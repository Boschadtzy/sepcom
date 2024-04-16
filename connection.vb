Imports System.Data
Imports System.Data.SqlClient
Module connection
    Public coner As String = " Error! please contact admin!"

    Public con As New SqlConnection("Data Source=DESKTOP-FEH9AER\SQLEXPRESS01;Initial Catalog=Sepcom;Integrated Security=True")

    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public dt As New DataTable
    Public SQl, astring, id, bday, e, IDno, etime, rp As String



    Sub connect()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        ElseIf con.State = ConnectionState.Closed Then
            con.Open()
        Else
            con.Close()
            con.Open()
        End If
    End Sub




End Module
