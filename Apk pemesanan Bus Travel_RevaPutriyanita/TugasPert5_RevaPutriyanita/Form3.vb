Imports MySql.Data.MySqlClient
Public Class Form3
    Dim Con As MySqlConnection
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim db As String
    Dim jk As Object
    Dim lhr As Object

    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=travel"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String
        sql = "insert into transaksi values('" & TextBox1.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & Label10.Text & "','" & Label12.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data berhasil", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampikodetravel()
        Call koneksi()
        cmd = New MySqlCommand("select kode_travel from pelanggan ", Con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("kode_travel"))
        Loop
    End Sub
    Sub idtransaksiomatis()
        koneksi()
        cmd = New MySqlCommand("select id_transaksi from transaksi order by id_transaksi desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "IT" + "001"
        Else
            TextBox1.Text = "IT" + Format(Microsoft.VisualBasic.Right(dr.Item("id_transaksi"), 2) + 1, "000")
        End If
        TextBox1.Enabled = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        koneksi()
        cmd = New MySqlCommand("select *from pelanggan where kode_travel='" & ComboBox1.Text & "'", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item("tujuan")
            TextBox4.Text = dr.Item("harga_paket")
        Else
            MsgBox("Data tidak ada")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox3.Text = 8500000
        Label10.Text = "VIP"
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.VIP2
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox3.Text = 5500000
        Label10.Text = "Reguler"
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.REGULAR
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox3.Text = 3500000
        Label10.Text = "Ekonomi"
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.EKONOMI
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idtransaksiomatis()
        tampikodetravel()
        TextBox1.Focus()
        Panel1.Visible = False
        Label12.Text = "0"
        Label10.Text = ""
        PictureBox1.Visible = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox8.Enabled = False

    End Sub
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        Dim total As Long
        total = (CInt(TextBox4.Text) + CInt(TextBox3.Text * ComboBox2.Text)) * CInt(TextBox6.Text)
        Label12.Text = Format(total, "###,###")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()

    End Sub
    Sub bersih()
        Call idtransaksiomatis()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Panel1.Visible = False
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox2.Text = ""
        Label10.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        Label12.Text = "0"
        ListBox1.Items.Clear()
        TextBox1.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call bersih()
    End Sub
    Sub bayartagihan()
        Dim kembalian As Integer
        kembalian = Val(TextBox5.Text - Label12.Text)
        TextBox8.Text = Format(kembalian, "Rp ###,###")
        ListBox1.Items.Add("Tanggal transaksi: " & Form1.stlabel8.Text)
        ListBox1.Items.Add("ID Transaksi: " & TextBox1.Text)
        ListBox1.Items.Add("Atas Nama: " & Form2.TextBox2.Text)
        ListBox1.Items.Add("kode travel: " & ComboBox1.Text)
        ListBox1.Items.Add("Tanggal Keberangkatan: " & DateTimePicker1.Text)
        ListBox1.Items.Add("Tujuan : " & TextBox2.Text)
        ListBox1.Items.Add("Jumlah Bus : " & ComboBox2.Text)
        ListBox1.Items.Add("Alur Kegiatan: " & Form2.TextBox6.Text)
        ListBox1.Items.Add("Jumlah Tagihan: " & Label12.Text)
        ListBox1.Items.Add("Uang Anda: " & TextBox5.Text)
        ListBox1.Items.Add("Jumlah Kembalian: " & TextBox8.Text)
        ListBox1.Items.Add("---------------------------------------------------------------------------")
        ListBox1.Items.Add("   PEMBAYARAN BERHASIL!!          ")
        ListBox1.Items.Add("---------------------------------------------------------------------------")
        ListBox1.Items.Add("                                  ")
        ListBox1.Items.Add("        BUS TOUR TRAVEL            ")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox5.Text = "" Then
            MsgBox(" Masukkan uang anda ", vbOKOnly, "Perhatian")
        ElseIf Val(TextBox5.Text) < Label12.Text Then
            MsgBox("Uang Anda Kurang!")
            TextBox5.Focus()
        Else
            Call bayartagihan()
        End If
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call idtransaksiomatis()
    End Sub

    Private Sub GroupBox_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseDown, GroupBox2.MouseDown, GroupBox3.MouseDown
        If e.Button =
                         Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Form1.GroupBox1.Visible = True
        Me.Hide()
        Call Form2.hapus()
        Call bersih()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        End
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Label27.Text = Form2.TextBox2.Text
        Label28.Text = TextBox1.Text
        Label29.Text = DateTimePicker1.Text
        Label30.Text = ComboBox1.Text
        Label31.Text = TextBox2.Text
        Label32.Text = TextBox4.Text
        Label33.Text = Form2.TextBox6.Text
        Label34.Text = ComboBox2.Text
        Label35.Text = Label10.Text
        Label36.Text = Label12.Text
        Label8.Text = Form1.stlabel8.Text
        Label39.Text = Form1.stlabel6.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        koneksi()
        Call tampikodetravel()
    End Sub
End Class