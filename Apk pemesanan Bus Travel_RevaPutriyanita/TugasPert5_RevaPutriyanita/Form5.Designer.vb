<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKendaraanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLaporanTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stlabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stlabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.DataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(104, 35)
        Me.LogOutToolStripMenuItem.Text = "Home"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Image = CType(resources.GetObject("LogOutToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(174, 36)
        Me.LogOutToolStripMenuItem1.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPelangganToolStripMenuItem, Me.DataTransaksiToolStripMenuItem, Me.DataKendaraanToolStripMenuItem})
        Me.DataToolStripMenuItem.Image = CType(resources.GetObject("DataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(89, 35)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(256, 36)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataTransaksiToolStripMenuItem
        '
        Me.DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        Me.DataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(256, 36)
        Me.DataTransaksiToolStripMenuItem.Text = "Data Transaksi"
        '
        'DataKendaraanToolStripMenuItem
        '
        Me.DataKendaraanToolStripMenuItem.Name = "DataKendaraanToolStripMenuItem"
        Me.DataKendaraanToolStripMenuItem.Size = New System.Drawing.Size(256, 36)
        Me.DataKendaraanToolStripMenuItem.Text = "Data Kendaraan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataLaporanTransaksiToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(123, 35)
        Me.LaporanToolStripMenuItem.Text = "laporan"
        '
        'DataLaporanTransaksiToolStripMenuItem
        '
        Me.DataLaporanTransaksiToolStripMenuItem.Name = "DataLaporanTransaksiToolStripMenuItem"
        Me.DataLaporanTransaksiToolStripMenuItem.Size = New System.Drawing.Size(351, 36)
        Me.DataLaporanTransaksiToolStripMenuItem.Text = "Data Laporan Transaksi"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(351, 36)
        Me.ToolStripMenuItem1.Text = "Data Laporan Kendaraan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlabel1, Me.stlabel2, Me.stlabel3, Me.stlabel4, Me.stlabel5, Me.stlabel6, Me.stlabel7, Me.stlabel8})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stlabel1
        '
        Me.stlabel1.Name = "stlabel1"
        Me.stlabel1.Size = New System.Drawing.Size(41, 17)
        Me.stlabel1.Text = "Users :"
        '
        'stlabel2
        '
        Me.stlabel2.Name = "stlabel2"
        Me.stlabel2.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel3
        '
        Me.stlabel3.Name = "stlabel3"
        Me.stlabel3.Size = New System.Drawing.Size(45, 17)
        Me.stlabel3.Text = "Status :"
        '
        'stlabel4
        '
        Me.stlabel4.Name = "stlabel4"
        Me.stlabel4.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel5
        '
        Me.stlabel5.Name = "stlabel5"
        Me.stlabel5.Size = New System.Drawing.Size(34, 17)
        Me.stlabel5.Text = "Jam :"
        '
        'stlabel6
        '
        Me.stlabel6.Name = "stlabel6"
        Me.stlabel6.Size = New System.Drawing.Size(0, 17)
        '
        'stlabel7
        '
        Me.stlabel7.Name = "stlabel7"
        Me.stlabel7.Size = New System.Drawing.Size(54, 17)
        Me.stlabel7.Text = "Tanggal :"
        '
        'stlabel8
        '
        Me.stlabel8.Name = "stlabel8"
        Me.stlabel8.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataLaporanTransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stlabel1 As ToolStripStatusLabel
    Friend WithEvents stlabel2 As ToolStripStatusLabel
    Friend WithEvents stlabel3 As ToolStripStatusLabel
    Friend WithEvents stlabel4 As ToolStripStatusLabel
    Friend WithEvents stlabel5 As ToolStripStatusLabel
    Friend WithEvents stlabel6 As ToolStripStatusLabel
    Friend WithEvents stlabel7 As ToolStripStatusLabel
    Friend WithEvents stlabel8 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
