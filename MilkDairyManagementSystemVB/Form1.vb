Imports System.Data.SqlClient
Public Class Form1
    Dim sql As New SqlConnection
    Dim password As String

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text = "" Or textBox2.Text = "" Then
            MessageBox.Show(" fields are empty")
            textBox1.Text = ""
            textBox2.Text = ""

        Else
            sql.ConnectionString = "server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True"
            Try
                sql.Open()
                Dim query As String
                query = "select * from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'"
                Dim command As New SqlCommand(query, sql)
                Dim reader As SqlDataReader
                reader = command.ExecuteReader
                Dim count As Integer = 0
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MsgBox("Awesome , Lets go..")
                    Hide()
                    Home.ShowDialog()
                Else
                    MsgBox(":( Wrong username or password")
                    textBox1.Text = ""
                    textBox2.Text = ""
                End If
                sql.Close()
            Catch ex As SqlException
                MsgBox(ex.Message)

            End Try


        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        FIrst.Show()
    End Sub
End Class
