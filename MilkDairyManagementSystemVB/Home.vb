Public Class Home
    Private Sub milkDairyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles milkDairyToolStripMenuItem.Click
        MilkDairy.ShowDialog()
    End Sub

    Private Sub setFatePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles setFatePriceToolStripMenuItem.Click
        SetFatePrice.ShowDialog()
    End Sub

    Private Sub searchAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchAccountToolStripMenuItem.Click
        SearchAccount.ShowDialog()
    End Sub

    Private Sub searchMilkDairyRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles searchMilkDairyRecordToolStripMenuItem.Click
        SearchMilkDairyRecord.ShowDialog()
    End Sub

    Private Sub newAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newAccountToolStripMenuItem.Click
        NewAccount.ShowDialog()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub menuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuStrip1.ItemClicked

    End Sub

    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Form1.Show()
    End Sub
End Class