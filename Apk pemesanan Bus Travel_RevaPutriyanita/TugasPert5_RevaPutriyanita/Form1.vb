Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Con As MySqlConnection
    Dim dr As MySqlDataReader
    Dim cmd As MySqlCommand
    Dim db As String

    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=travel"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub login()
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("Isi username dan password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                koneksi()
                cmd = New MySqlCommand("select * from users where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", Con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If dr("status").ToString = "ADMIN" Then
                        GroupBox1.Visible = False
                        MessageBox.Show("Berhasil Login!", "SUKSES LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form5.Show()
                        Form5.stlabel2.Text = dr("username")
                        Form5.stlabel4.Text = dr("status")
                    Else
                        GroupBox1.Visible = False
                        MessageBox.Show("Berhasil Login!", "SUKSES LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form2.Show()
                        stlabel2.Text = dr("username")
                        stlabel4.Text = dr("status")
                    End If
                Else
                    MessageBox.Show("Akun anda belum terdaftar!!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Timer1.Start()
        TextBox2.UseSystemPasswordChar = True
        stlabel8.Text = Format(Now, "dd-MMMM-yyyy")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label4.Left >= Me.Width Then
            Label4.Left = -Label4.Width
        Else
            Label4.Left = Label4.Left + 100
        End If
        stlabel6.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormDaftar.Show()
        GroupBox1.Visible = False
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles stlabel1.Click
        Format(Now, "dd-MMMM-yyyy")
    End Sub


End Class
