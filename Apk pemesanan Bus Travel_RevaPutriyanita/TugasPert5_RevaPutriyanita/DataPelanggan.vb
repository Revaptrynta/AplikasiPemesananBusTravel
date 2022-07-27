Imports MySql.Data.MySqlClient
Public Class DataPelanggan
    Dim Con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim cmd As MySqlCommand
    Dim db As String
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=travel"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub tampil()
        Try
            koneksi()
            da = New MySqlDataAdapter("select *from pelanggan order by kode_travel", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "pelanggan")
            Me.DataGridView1.DataSource = (ds.Tables("pelanggan"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim jk As New TextBox
        If (Form2.RadioButton1.Checked) Then
            jk.Text = "Laki-laki"
        Else
            jk.Text = "Perempuan"
        End If
        Form2.TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Form2.TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Form2.TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        jk.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Form2.TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Form2.TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Form2.TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        Form2.TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
    End Sub
    Sub hitung()
        Label2.Text = DataGridView1.RowCount - 1
    End Sub
    Private Sub DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        Label2.Text = ""
        Call hitung()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        koneksi()
        da = New MySqlDataAdapter("select *from pelanggan where nama like '%" & TextBox1.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "pelanggan")
        DataGridView1.DataSource = (ds.Tables("pelanggan"))
        Call hitung()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call tampil()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data pelanggan yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kode_travel=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from pelanggan where kode_travel='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
                Form2.KODEOTOMATIS()
                Call hitung()
            End If
        End If
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        If e.Button =
                        Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub
End Class