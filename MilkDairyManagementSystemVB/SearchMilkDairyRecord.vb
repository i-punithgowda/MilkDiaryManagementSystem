Imports System.Data.SqlClient

Public Class SearchMilkDairyRecord
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim addmilk As Object
    Dim dbdataset As New DataTable


    Private Sub SearchMilkDairyRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        account_load()
        payBtn.Enabled = False
    End Sub

    Private Sub account_load()
        cmbAcc.Items.Clear()
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        Dim rdr As SqlDataReader
        Dim str As String
        Try
            con.Open()
            str = "select accno from account"
            com = New SqlCommand(str, con)
            rdr = com.ExecuteReader()
            While rdr.Read
                Dim accno = rdr("accno")
                cmbAcc.Items.Add(accno)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcc.SelectedIndexChanged
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        dbdataset.Clear()
        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource
        Try
            con.Open()

            Dim Query As String
            Query = "select * from dairy_data where accno='" + cmbAcc.Text + "' and (month='" + cmbMonth.Text + "' And Year ='" + cmbYear.Text + "')"
            Dim command As New SqlCommand
            command = New SqlCommand(Query, con)
            SDA.SelectCommand = command
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset)


            con.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(5).Value
        Next
        lblTtl.Text = sum.ToString
        payBtn.Enabled = True
    End Sub

    Private Sub payBtn_Click(sender As Object, e As EventArgs) Handles payBtn.Click
        MsgBox("Amount was succesfully paid to the customer :) ")
    End Sub
End Class