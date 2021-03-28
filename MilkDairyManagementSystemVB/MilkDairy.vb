Imports System.Data.SqlClient

Public Class MilkDairy
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim month As String
    Dim year As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If txtLiters.Text = "" Then
            MsgBox("Enter Liters before saving!!!")
        Else
            con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
            Dim rdr As SqlDataReader
            Dim str As String
            Try
                con.Open()
                str = "insert into dairy_data (accno,name,address,liters,ppliter,total,date,month,year) values ('" + cmbAcc.Text + "','" + lblName.Text + "','" + lblADDR.Text + "','" + txtLiters.Text + "','" + lblPrice.Text + "','" + lblTotal.Text + "','" + lblDate.Text + "','" + month + "','" + year + "')"
                com = New SqlCommand(str, con)
                rdr = com.ExecuteReader()
                MsgBox("Data saved :)")
                lblADDR.Text = ""
                lblName.Text = ""
                lblTotal.Text = ""
                txtLiters.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub MilkDairy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAcc.Items.Clear()
        account_load()
        price_load()
        lblDate.Text = DateTime.Now.ToShortDateString
        month = DateTime.Now.ToString("MMMM")
        year = Today.Year
    End Sub

    Private Sub account_load()
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

    Private Sub price_load()
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        Dim rdr As SqlDataReader
        Dim str As String
        Try
            con.Open()
            str = "select rate from rate"
            com = New SqlCommand(str, con)
            rdr = com.ExecuteReader()
            While rdr.Read
                lblPrice.Text = rdr("rate")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAcc.SelectedIndexChanged
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        Dim rdr As SqlDataReader
        Dim str As String
        Try
            con.Open()
            str = "select fname,addr from account where accno='" + cmbAcc.Text + "'"
            com = New SqlCommand(str, con)
            rdr = com.ExecuteReader()
            While rdr.Read
                lblName.Text = rdr("fname")
                lblADDR.Text = rdr("addr")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtLiters.Text = "" Then
            MsgBox("Enter liters!!")
        Else
            lblTotal.Text = lblPrice.Text * txtLiters.Text
        End If

    End Sub
End Class