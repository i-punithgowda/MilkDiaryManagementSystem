Imports System.Data.SqlClient

Public Class SetFatePrice
    Dim con As SqlConnection
    Dim com As SqlCommand


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        con.Open()
        Dim str As String
        str = "update rate set rate= '" + textBox3.Text + "' where id='1'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Updated milk price ")
        textbox1.Text = ""
        textBox3.Text = ""
        con.Close()
        dataload()
    End Sub

    Private Sub SetFatePrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub dataload()
        con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
        Dim rdr As SqlDataReader
        Dim str As String
        Try
            con.Open()
            str = "select * from rate"
            com = New SqlCommand(str, con)
            rdr = com.ExecuteReader()
            While rdr.Read
                textbox1.Text = rdr("rate")
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class