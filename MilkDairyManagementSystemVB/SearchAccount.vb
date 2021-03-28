Imports System.Data.SqlClient

Public Class SearchAccount
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
    Private Sub SearchAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DairyDataSet1.acnt' table. You can move, or remove it, as needed.
        Me.AcntTableAdapter.Fill(Me.DairyDataSet1.acnt)
        Using con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
            str = "select * from account"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Using con = New SqlConnection("server=DESKTOP-VN49ARL;Database=milkdiary; Integrated Security=True")
            str = "select * from account where accno='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, addmilk)
        End Using
    End Sub
End Class