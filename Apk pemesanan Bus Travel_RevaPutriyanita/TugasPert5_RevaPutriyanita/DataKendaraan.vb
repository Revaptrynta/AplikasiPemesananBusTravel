Imports MySql.Data.MySqlClient
Public Class DataKendaraan
    Dim Con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim cmd As MySqlCommand
    Dim db As String
    Dim dr As MySqlDataReader
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=travel"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String
        sql = "insert into kendaraan values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data berhasil", vbInformation, "INFORMASI")
            tampil()
            hapus()
            Call hitung()
        Catch ex As Exception
            MsgBox("Menyimpan data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        Try
            koneksi()
            da = New MySqlDataAdapter("select *from kendaraan order by id_transaksi", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "kendaraan")
            Me.DataGridView1.DataSource = (ds.Tables("kendaraan"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub
    Private Sub DataKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampiid_transaksi()
        tampil()
        hitung()

        With Me.ComboBox2
            .Items.Add("jetbus 3+ SDD (VIP)")
            .Items.Add("Mercedes-Benz (Reguler)")
            .Items.Add("Hino AK8 (Ekonomi)")
        End With
    End Sub
    Sub hitung()
        Label9.Text = DataGridView1.RowCount - 1

        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            total += DataGridView1.Rows(i).Cells(2).Value
        Next
        Label8.Text = total
    End Sub
    Sub tampiid_transaksi()
        Call koneksi()
        cmd = New MySqlCommand("select id_transaksi from Transaksi ", Con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("id_transaksi"))
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub
    Sub hapus()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from transaksi where id_transaksi='" & ComboBox1.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr.HasRows Then
                TextBox1.Text = dr.Item("kelas")
                TextBox2.Text = dr.Item("jumlah_bus")
                TextBox4.Text = dr.Item("tanggal")
            End If
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        koneksi()
        da = New MySqlDataAdapter("select *from kendaraan where id_transaksi like '%" & TextBox5.Text & "%'", Con)
        ds = New DataSet
        da.Fill(ds, "kendaraan")
        DataGridView1.DataSource = (ds.Tables("kendaraan"))
        Call hitung()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call tampil()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data kendaraan yg dihapus belum dipilih")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan id_transaksi=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) Then
                koneksi()
                cmd = New MySqlCommand("delete from kendaraan where id_transaksi='" & a & "'", Con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data berhasil", vbInformation, "INFORMASI")
                Con.Close()
                tampil()
                Call hitung()
            End If
        End If
    End Sub

    Private Sub DataKendaraan_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button =
                        Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub
End Class