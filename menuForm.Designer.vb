<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.inf_box = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_current_user_login = New System.Windows.Forms.Label()
        Me.menu_box = New System.Windows.Forms.GroupBox()
        Me.btrn_tambah_penulis = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.btn_pengembalian = New System.Windows.Forms.Button()
        Me.btn_peminjaman = New System.Windows.Forms.Button()
        Me.btn_tambah_buku = New System.Windows.Forms.Button()
        Me.box_kembali = New System.Windows.Forms.GroupBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inf_box.SuspendLayout()
        Me.menu_box.SuspendLayout()
        Me.box_kembali.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'inf_box
        '
        Me.inf_box.BackColor = System.Drawing.Color.Silver
        Me.inf_box.Controls.Add(Me.Label1)
        Me.inf_box.Controls.Add(Me.lb_current_user_login)
        Me.inf_box.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inf_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.inf_box.Location = New System.Drawing.Point(13, 13)
        Me.inf_box.Name = "inf_box"
        Me.inf_box.Size = New System.Drawing.Size(834, 101)
        Me.inf_box.TabIndex = 0
        Me.inf_box.TabStop = False
        Me.inf_box.Text = "Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF UI  Text", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login Sebagai"
        '
        'lb_current_user_login
        '
        Me.lb_current_user_login.AutoSize = True
        Me.lb_current_user_login.Font = New System.Drawing.Font("SF UI  Text", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_current_user_login.Location = New System.Drawing.Point(663, 37)
        Me.lb_current_user_login.Name = "lb_current_user_login"
        Me.lb_current_user_login.Size = New System.Drawing.Size(127, 57)
        Me.lb_current_user_login.TabIndex = 0
        Me.lb_current_user_login.Text = "Budi"
        '
        'menu_box
        '
        Me.menu_box.BackColor = System.Drawing.Color.Silver
        Me.menu_box.Controls.Add(Me.btrn_tambah_penulis)
        Me.menu_box.Controls.Add(Me.Button4)
        Me.menu_box.Controls.Add(Me.Button3)
        Me.menu_box.Controls.Add(Me.Button2)
        Me.menu_box.Controls.Add(Me.Button1)
        Me.menu_box.Controls.Add(Me.btn_data)
        Me.menu_box.Controls.Add(Me.btn_pengembalian)
        Me.menu_box.Controls.Add(Me.btn_peminjaman)
        Me.menu_box.Controls.Add(Me.btn_tambah_buku)
        Me.menu_box.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.menu_box.Location = New System.Drawing.Point(13, 120)
        Me.menu_box.Name = "menu_box"
        Me.menu_box.Size = New System.Drawing.Size(1000, 337)
        Me.menu_box.TabIndex = 1
        Me.menu_box.TabStop = False
        Me.menu_box.Text = "Menu "
        '
        'btrn_tambah_penulis
        '
        Me.btrn_tambah_penulis.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btrn_tambah_penulis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btrn_tambah_penulis.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btrn_tambah_penulis.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btrn_tambah_penulis.Location = New System.Drawing.Point(503, 181)
        Me.btrn_tambah_penulis.Name = "btrn_tambah_penulis"
        Me.btrn_tambah_penulis.Size = New System.Drawing.Size(159, 146)
        Me.btrn_tambah_penulis.TabIndex = 8
        Me.btrn_tambah_penulis.Text = "Tambah Penulis"
        Me.btrn_tambah_penulis.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(835, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 145)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Tambah Kategori"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(668, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 145)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Daftarkan Anggota"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(833, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 145)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Tambah Rak"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(668, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 145)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Daftarkan Penerbit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_data
        '
        Me.btn_data.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_data.Location = New System.Drawing.Point(503, 29)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(159, 146)
        Me.btn_data.TabIndex = 3
        Me.btn_data.Text = "Kelola Riwayat"
        Me.btn_data.UseVisualStyleBackColor = False
        '
        'btn_pengembalian
        '
        Me.btn_pengembalian.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_pengembalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pengembalian.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pengembalian.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_pengembalian.Location = New System.Drawing.Point(338, 29)
        Me.btn_pengembalian.Name = "btn_pengembalian"
        Me.btn_pengembalian.Size = New System.Drawing.Size(159, 302)
        Me.btn_pengembalian.TabIndex = 2
        Me.btn_pengembalian.Text = "Pengembalian"
        Me.btn_pengembalian.UseVisualStyleBackColor = False
        '
        'btn_peminjaman
        '
        Me.btn_peminjaman.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_peminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_peminjaman.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_peminjaman.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_peminjaman.Location = New System.Drawing.Point(173, 30)
        Me.btn_peminjaman.Name = "btn_peminjaman"
        Me.btn_peminjaman.Size = New System.Drawing.Size(159, 302)
        Me.btn_peminjaman.TabIndex = 1
        Me.btn_peminjaman.Text = "Peminjaman"
        Me.btn_peminjaman.UseVisualStyleBackColor = False
        '
        'btn_tambah_buku
        '
        Me.btn_tambah_buku.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_tambah_buku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah_buku.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah_buku.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_tambah_buku.Location = New System.Drawing.Point(8, 29)
        Me.btn_tambah_buku.Name = "btn_tambah_buku"
        Me.btn_tambah_buku.Size = New System.Drawing.Size(159, 302)
        Me.btn_tambah_buku.TabIndex = 0
        Me.btn_tambah_buku.Text = "Kelola Buku"
        Me.btn_tambah_buku.UseVisualStyleBackColor = False
        '
        'box_kembali
        '
        Me.box_kembali.BackColor = System.Drawing.Color.Silver
        Me.box_kembali.Controls.Add(Me.btn_logout)
        Me.box_kembali.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.box_kembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.box_kembali.Location = New System.Drawing.Point(854, 13)
        Me.box_kembali.Name = "box_kembali"
        Me.box_kembali.Size = New System.Drawing.Size(161, 101)
        Me.box_kembali.TabIndex = 2
        Me.box_kembali.TabStop = False
        Me.box_kembali.Text = "Logout"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("SF UI  Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_logout.Location = New System.Drawing.Point(7, 30)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(138, 64)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 464)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 37)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SF UI  Text Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(38, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dikembangkan Oleh Kelompok 3"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1027, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.box_kembali)
        Me.Controls.Add(Me.menu_box)
        Me.Controls.Add(Me.inf_box)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.inf_box.ResumeLayout(False)
        Me.inf_box.PerformLayout()
        Me.menu_box.ResumeLayout(False)
        Me.box_kembali.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inf_box As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_current_user_login As Label
    Friend WithEvents menu_box As GroupBox
    Friend WithEvents btn_data As Button
    Friend WithEvents btn_pengembalian As Button
    Friend WithEvents btn_peminjaman As Button
    Friend WithEvents btn_tambah_buku As Button
    Friend WithEvents box_kembali As GroupBox
    Friend WithEvents btn_logout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btrn_tambah_penulis As Button
End Class
