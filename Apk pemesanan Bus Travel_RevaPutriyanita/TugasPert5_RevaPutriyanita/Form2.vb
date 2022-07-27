Imports MySql.Data.MySqlClient
Public Class Form2
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
        Dim jk As New TextBox
        If (RadioButton1.Checked) Then
            jk.Text = "Laki-laki"
        Else
            jk.Text = "Perempuan"
        End If
        Dim sql As String
        sql = "insert into pelanggan values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & jk.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data berhasil", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KODEOTOMATIS()
        With Me.ComboBox1
            ComboBox1.Items.Add("Daerah Jakarta")
            ComboBox1.Items.Add("Daerah Jawa Barat")
            ComboBox1.Items.Add("Daerah Jawa Tengah")
            ComboBox1.Items.Add("Daerah Jawa Timur")
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tanya
        tanya = MessageBox.Show("Lanjut ke transaksi? ", "Lanjut", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Form3.Show()
            Me.Hide()
        End If
    End Sub
    Sub hapus()
        Call KODEOTOMATIS()
        CheckBox1.Checked = False
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hapus()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Form1.Show()
        Form1.GroupBox1.Visible = True
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub GroupBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseDown
        If e.Button =
                         Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position, ToolStripDropDownDirection.AboveRight)
        End If
    End Sub

    Sub KODEOTOMATIS()
        koneksi()
        cmd = New MySqlCommand("select kode_travel from pelanggan order by kode_travel desc", Con)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TextBox1.Text = "KT" + "01"
        Else
            TextBox1.Text = "KT" + Format(Microsoft.VisualBasic.Right(dr.Item("kode_travel"), 2) + 1, "00")
        End If
        TextBox1.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Daerah Jakarta" Then
            TextBox7.Text = 350000
        ElseIf ComboBox1.Text = "Daerah Jawa Barat" Then
            TextBox7.Text = 450000
        ElseIf ComboBox1.Text = "Daerah Jawa Tengah" Then
            TextBox7.Text = 550000
        ElseIf ComboBox1.Text = "Daerah Jawa Timur" Then
            TextBox7.Text = 850000
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim total As Long
        If CheckBox1.Checked = True Then
            total = Val(TextBox7.Text + 350000)
            TextBox7.Text = total
        Else
            TextBox7.Text = Val(TextBox7.Text - 350000)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call KODEOTOMATIS()
    End Sub
End Class