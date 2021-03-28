Imports System.Data.SqlClient

Public Class NewAccount
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim addmilk As Object
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text = "" Or textBox2.Text = "" Or textBox3.Text = "" Or textBox4.Text = "" Or textBox5.Text = "" Then
            MsgBox("Few fields are empty, try again")
        Else
            con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
            con.Open()
            str = "insert into account(accno,fname,addr,mobile,lname) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox("Account Details Inserted Successfully..")
            textBox2.Text = ""
            textBox3.Text = ""
            textBox4.Text = ""
            textBox5.Text = ""
            con.Close()
            dgvload()
            accload()
        End If

    End Sub

    Private Sub NewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        accload()
    End Sub
    Private Sub accload()
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(accno)+1 from account"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dgvload()
    End Sub
    Private Sub dgvload()
        Using con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
            str = "select * from account"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        con.Open()
        Try
            str = "Select lname,addr,mobile,fname from account where accno='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then


                textBox2.Text = dr("fname")

                textBox5.Text = dr("lname")
                textBox3.Text = dr("addr")
                textBox4.Text = dr("mobile")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        con.Open()
        str = "update account set fname='" + textBox2.Text + "',addr='" + textBox3.Text + "',mobile='" + textBox4.Text + "',lname='" + textBox5.Text + "' where accno='" + textBox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox(" Account Data Updated Successfully..")
        Using con
            str = "select * from account"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using

        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox1.Text = ""
        con.Close()
        accload()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox2.Text = ""
        textBox3.Text = ""
        textBox4.Text = ""
        textBox5.Text = ""
        textBox1.Text = ""
    End Sub

    Private Sub textBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox4.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If textBox4.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox5.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ASDFGHJKLZXCVBNMQWERTYUIOPqwertyuiopasdfghjklzxcvbnm"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class