Imports MySql.Data.MySqlClient
Public Class DataTransaksi
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
            da = New MySqlDataAdapter("select *from transaksi order by id_transaksi", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "transaksi")
            Me.DataGridView1.DataSource = (ds.Tables("transaksi"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Form3.TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Form3.DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Form3.ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Form3.TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Form3.ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Form3.Label10.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Form3.Label12.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        koneksi()
        da = New MySqlDataAdapter("select *from transaksi where id_transaksi like '%" & TextBox1.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "transaksi")
        DataGridView1.DataSource = (ds.Tables("transaksi"))
        Call hitung()
    End Sub

    Private Sub DataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        hitung()
    End Sub

    Sub hitung()
        Label2.Text = DataGridView1.RowCount - 1
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call tampil()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Transaksi yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan id_transaksi=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from Transaksi where id_transaksi='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
                Form3.idtransaksiomatis()
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