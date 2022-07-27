
Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        stlabel8.Text = Format(Now, "dd-MMMM-yyyy")
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click

        DataPelanggan.MdiParent = Me
        DataPelanggan.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stlabel6.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        DataTransaksi.MdiParent = Me
        DataTransaksi.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        Form1.Show()
        Form1.GroupBox1.Visible = True
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DataLaporanTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLaporanTransaksiToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub DataKendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKendaraanToolStripMenuItem.Click
        DataKendaraan.MdiParent = Me
        DataKendaraan.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form6.Show()
    End Sub
End Class