﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengembalianForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_id_buku = New System.Windows.Forms.Label()
        Me.txt_nama_peminjam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rak_buku = New System.Windows.Forms.TextBox()
        Me.txt_kategori_buku = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_judul_buku = New System.Windows.Forms.TextBox()
        Me.txt_penulis = New System.Windows.Forms.TextBox()
        Me.txt_penerbit_buku = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_tahun_terbit_buku = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id_peminjam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_id_petugas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_petugas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_nama_anggota = New System.Windows.Forms.TextBox()
        Me.txt_id_anggota = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dt_jatuh_tempo = New System.Windows.Forms.DateTimePicker()
        Me.dt_tanggal_peminjaman = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.id_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_terbit_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rak_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_peminjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_petugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_peminjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_petugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jatuh_tempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penulis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.txt_id_peminjaman = New System.Windows.Forms.TextBox()
        Me.txt_denda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_tempo = New System.Windows.Forms.TextBox()
        Me.id_peminjam_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_anggota_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_peminjaman_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_petugas_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.judul_buku_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori_buku_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penerbit_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.penulis_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rak_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_petugas_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_terbit_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_pinjam_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jatuh_tempo_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.denda_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox3.Controls.Add(Me.txt_id_buku)
        Me.GroupBox3.Controls.Add(Me.txt_nama_peminjam)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_rak_buku)
        Me.GroupBox3.Controls.Add(Me.txt_kategori_buku)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_judul_buku)
        Me.GroupBox3.Controls.Add(Me.txt_penulis)
        Me.GroupBox3.Controls.Add(Me.txt_penerbit_buku)
        Me.GroupBox3.Controls.Add(Me.btn_close)
        Me.GroupBox3.Controls.Add(Me.btn_kosongkan)
        Me.GroupBox3.Controls.Add(Me.btn_hapus)
        Me.GroupBox3.Controls.Add(Me.btn_ubah)
        Me.GroupBox3.Controls.Add(Me.btn_tambah)
        Me.GroupBox3.Controls.Add(Me.txt_tahun_terbit_buku)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_id_peminjam)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 826)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETAIL PEMINJAMAN"
        '
        'txt_id_buku
        '
        Me.txt_id_buku.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_buku.AutoSize = True
        Me.txt_id_buku.Location = New System.Drawing.Point(162, 148)
        Me.txt_id_buku.Name = "txt_id_buku"
        Me.txt_id_buku.Size = New System.Drawing.Size(66, 20)
        Me.txt_id_buku.TabIndex = 33
        Me.txt_id_buku.Text = "JUDUL"
        '
        'txt_nama_peminjam
        '
        Me.txt_nama_peminjam.Location = New System.Drawing.Point(15, 60)
        Me.txt_nama_peminjam.Name = "txt_nama_peminjam"
        Me.txt_nama_peminjam.Size = New System.Drawing.Size(213, 28)
        Me.txt_nama_peminjam.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "RAK"
        '
        'txt_rak_buku
        '
        Me.txt_rak_buku.Location = New System.Drawing.Point(15, 455)
        Me.txt_rak_buku.Name = "txt_rak_buku"
        Me.txt_rak_buku.Size = New System.Drawing.Size(213, 28)
        Me.txt_rak_buku.TabIndex = 30
        '
        'txt_kategori_buku
        '
        Me.txt_kategori_buku.Location = New System.Drawing.Point(15, 395)
        Me.txt_kategori_buku.Name = "txt_kategori_buku"
        Me.txt_kategori_buku.Size = New System.Drawing.Size(213, 28)
        Me.txt_kategori_buku.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "KATEGORI"
        '
        'txt_judul_buku
        '
        Me.txt_judul_buku.Location = New System.Drawing.Point(16, 171)
        Me.txt_judul_buku.Name = "txt_judul_buku"
        Me.txt_judul_buku.Size = New System.Drawing.Size(213, 28)
        Me.txt_judul_buku.TabIndex = 27
        '
        'txt_penulis
        '
        Me.txt_penulis.Location = New System.Drawing.Point(16, 224)
        Me.txt_penulis.Name = "txt_penulis"
        Me.txt_penulis.Size = New System.Drawing.Size(213, 28)
        Me.txt_penulis.TabIndex = 26
        '
        'txt_penerbit_buku
        '
        Me.txt_penerbit_buku.Location = New System.Drawing.Point(16, 281)
        Me.txt_penerbit_buku.Name = "txt_penerbit_buku"
        Me.txt_penerbit_buku.Size = New System.Drawing.Size(213, 28)
        Me.txt_penerbit_buku.TabIndex = 25
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(16, 739)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(213, 51)
        Me.btn_close.TabIndex = 24
        Me.btn_close.Text = "TUTUP"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_kosongkan
        '
        Me.btn_kosongkan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_kosongkan.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_kosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_kosongkan.ForeColor = System.Drawing.Color.White
        Me.btn_kosongkan.Location = New System.Drawing.Point(16, 682)
        Me.btn_kosongkan.Name = "btn_kosongkan"
        Me.btn_kosongkan.Size = New System.Drawing.Size(213, 51)
        Me.btn_kosongkan.TabIndex = 19
        Me.btn_kosongkan.Text = "KOSONGKAN"
        Me.btn_kosongkan.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_hapus.ForeColor = System.Drawing.Color.White
        Me.btn_hapus.Location = New System.Drawing.Point(16, 624)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(213, 52)
        Me.btn_hapus.TabIndex = 18
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_ubah
        '
        Me.btn_ubah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ubah.BackColor = System.Drawing.Color.SlateGray
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ubah.ForeColor = System.Drawing.Color.White
        Me.btn_ubah.Location = New System.Drawing.Point(16, 566)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(213, 52)
        Me.btn_ubah.TabIndex = 17
        Me.btn_ubah.Text = "UBAH"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'btn_tambah
        '
        Me.btn_tambah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_tambah.BackColor = System.Drawing.Color.DarkCyan
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_tambah.ForeColor = System.Drawing.Color.White
        Me.btn_tambah.Location = New System.Drawing.Point(16, 508)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(213, 52)
        Me.btn_tambah.TabIndex = 16
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'txt_tahun_terbit_buku
        '
        Me.txt_tahun_terbit_buku.Location = New System.Drawing.Point(16, 336)
        Me.txt_tahun_terbit_buku.Name = "txt_tahun_terbit_buku"
        Me.txt_tahun_terbit_buku.Size = New System.Drawing.Size(213, 28)
        Me.txt_tahun_terbit_buku.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "TAHUN TERBIT"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PENERBIT"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PENULIS"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "JUDUL"
        '
        'txt_id_peminjam
        '
        Me.txt_id_peminjam.Location = New System.Drawing.Point(16, 115)
        Me.txt_id_peminjam.Name = "txt_id_peminjam"
        Me.txt_id_peminjam.Size = New System.Drawing.Size(213, 28)
        Me.txt_id_peminjam.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID PEMINJAM"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "NAMA PEMINJAM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_id_petugas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_petugas)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 165)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAIL PETUGAS "
        '
        'txt_id_petugas
        '
        Me.txt_id_petugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_petugas.Location = New System.Drawing.Point(7, 63)
        Me.txt_id_petugas.Name = "txt_id_petugas"
        Me.txt_id_petugas.Size = New System.Drawing.Size(193, 38)
        Me.txt_id_petugas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAMA PETUGAS"
        '
        'txt_petugas
        '
        Me.txt_petugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petugas.Location = New System.Drawing.Point(8, 117)
        Me.txt_petugas.Name = "txt_petugas"
        Me.txt_petugas.Size = New System.Drawing.Size(193, 38)
        Me.txt_petugas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nama_anggota)
        Me.GroupBox1.Controls.Add(Me.txt_id_anggota)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(258, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 165)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETAIL PEMINJAM "
        '
        'txt_nama_anggota
        '
        Me.txt_nama_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_anggota.Location = New System.Drawing.Point(6, 109)
        Me.txt_nama_anggota.Name = "txt_nama_anggota"
        Me.txt_nama_anggota.Size = New System.Drawing.Size(193, 38)
        Me.txt_nama_anggota.TabIndex = 5
        '
        'txt_id_anggota
        '
        Me.txt_id_anggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_anggota.Location = New System.Drawing.Point(7, 63)
        Me.txt_id_anggota.Name = "txt_id_anggota"
        Me.txt_id_anggota.Size = New System.Drawing.Size(193, 38)
        Me.txt_id_anggota.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "NAMA PEMINJAM"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dt_jatuh_tempo)
        Me.GroupBox4.Controls.Add(Me.dt_tanggal_peminjaman)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(258, 355)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(199, 165)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DETAIL PEMINJAMAN"
        '
        'dt_jatuh_tempo
        '
        Me.dt_jatuh_tempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_jatuh_tempo.Location = New System.Drawing.Point(6, 123)
        Me.dt_jatuh_tempo.Name = "dt_jatuh_tempo"
        Me.dt_jatuh_tempo.Size = New System.Drawing.Size(183, 34)
        Me.dt_jatuh_tempo.TabIndex = 5
        '
        'dt_tanggal_peminjaman
        '
        Me.dt_tanggal_peminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_tanggal_peminjaman.Location = New System.Drawing.Point(6, 60)
        Me.dt_tanggal_peminjaman.Name = "dt_tanggal_peminjaman"
        Me.dt_tanggal_peminjaman.Size = New System.Drawing.Size(183, 34)
        Me.dt_tanggal_peminjaman.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "JATUH TEMPO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "TANGGAL PENGEMBALIAN"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_peminjaman, Me.id_buku, Me.judul_buku, Me.tahun_terbit_buku, Me.penerbit_buku, Me.kategori_buku, Me.rak_buku, Me.nama_peminjam, Me.nama_petugas, Me.id_peminjam, Me.id_petugas, Me.tanggal_peminjaman, Me.jatuh_tempo, Me.penulis})
        Me.DGV1.Location = New System.Drawing.Point(470, 76)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(1023, 444)
        Me.DGV1.TabIndex = 9
        '
        'id_peminjaman
        '
        Me.id_peminjaman.HeaderText = "ID PEMINJAMAN"
        Me.id_peminjaman.MinimumWidth = 6
        Me.id_peminjaman.Name = "id_peminjaman"
        Me.id_peminjaman.ReadOnly = True
        Me.id_peminjaman.Width = 125
        '
        'id_buku
        '
        Me.id_buku.HeaderText = "ID BUKU"
        Me.id_buku.MinimumWidth = 6
        Me.id_buku.Name = "id_buku"
        Me.id_buku.ReadOnly = True
        Me.id_buku.Width = 125
        '
        'judul_buku
        '
        Me.judul_buku.HeaderText = "JUDUL BUKU"
        Me.judul_buku.MinimumWidth = 6
        Me.judul_buku.Name = "judul_buku"
        Me.judul_buku.ReadOnly = True
        Me.judul_buku.Width = 120
        '
        'tahun_terbit_buku
        '
        Me.tahun_terbit_buku.HeaderText = "TAHUN TERBIT"
        Me.tahun_terbit_buku.MinimumWidth = 6
        Me.tahun_terbit_buku.Name = "tahun_terbit_buku"
        Me.tahun_terbit_buku.ReadOnly = True
        Me.tahun_terbit_buku.Width = 200
        '
        'penerbit_buku
        '
        Me.penerbit_buku.HeaderText = "PENERBIT"
        Me.penerbit_buku.MinimumWidth = 6
        Me.penerbit_buku.Name = "penerbit_buku"
        Me.penerbit_buku.ReadOnly = True
        Me.penerbit_buku.Width = 125
        '
        'kategori_buku
        '
        Me.kategori_buku.HeaderText = "KATEGORI"
        Me.kategori_buku.MinimumWidth = 6
        Me.kategori_buku.Name = "kategori_buku"
        Me.kategori_buku.ReadOnly = True
        Me.kategori_buku.Width = 200
        '
        'rak_buku
        '
        Me.rak_buku.HeaderText = "RAK"
        Me.rak_buku.MinimumWidth = 6
        Me.rak_buku.Name = "rak_buku"
        Me.rak_buku.ReadOnly = True
        Me.rak_buku.Width = 125
        '
        'nama_peminjam
        '
        Me.nama_peminjam.HeaderText = "NAMA PEMINJAM"
        Me.nama_peminjam.MinimumWidth = 6
        Me.nama_peminjam.Name = "nama_peminjam"
        Me.nama_peminjam.ReadOnly = True
        Me.nama_peminjam.Width = 125
        '
        'nama_petugas
        '
        Me.nama_petugas.HeaderText = "NAMA PETUGAS"
        Me.nama_petugas.MinimumWidth = 6
        Me.nama_petugas.Name = "nama_petugas"
        Me.nama_petugas.ReadOnly = True
        Me.nama_petugas.Width = 125
        '
        'id_peminjam
        '
        Me.id_peminjam.HeaderText = "ID PEMINJAM"
        Me.id_peminjam.MinimumWidth = 6
        Me.id_peminjam.Name = "id_peminjam"
        Me.id_peminjam.ReadOnly = True
        Me.id_peminjam.Width = 125
        '
        'id_petugas
        '
        Me.id_petugas.HeaderText = "ID PETUGAS"
        Me.id_petugas.MinimumWidth = 6
        Me.id_petugas.Name = "id_petugas"
        Me.id_petugas.ReadOnly = True
        Me.id_petugas.Width = 125
        '
        'tanggal_peminjaman
        '
        Me.tanggal_peminjaman.HeaderText = "TANGGAL PEMINJAMAN"
        Me.tanggal_peminjaman.MinimumWidth = 6
        Me.tanggal_peminjaman.Name = "tanggal_peminjaman"
        Me.tanggal_peminjaman.ReadOnly = True
        Me.tanggal_peminjaman.Width = 125
        '
        'jatuh_tempo
        '
        Me.jatuh_tempo.HeaderText = "JATUH TEMPO"
        Me.jatuh_tempo.MinimumWidth = 6
        Me.jatuh_tempo.Name = "jatuh_tempo"
        Me.jatuh_tempo.ReadOnly = True
        Me.jatuh_tempo.Width = 125
        '
        'penulis
        '
        Me.penulis.HeaderText = "PENULIS"
        Me.penulis.MinimumWidth = 6
        Me.penulis.Name = "penulis"
        Me.penulis.ReadOnly = True
        Me.penulis.Width = 125
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_peminjam_kembali, Me.nama_anggota_kembali, Me.id_peminjaman_kembali, Me.nama_petugas_kembali, Me.judul_buku_kembali, Me.kategori_buku_kembali, Me.penerbit_kembali, Me.penulis_kembali, Me.rak_kembali, Me.id_petugas_kembali, Me.tahun_terbit_kembali, Me.tanggal_pinjam_kembali, Me.jatuh_tempo_kembali, Me.denda_kembali})
        Me.DGV2.Location = New System.Drawing.Point(470, 526)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.RowHeadersWidth = 51
        Me.DGV2.RowTemplate.Height = 24
        Me.DGV2.Size = New System.Drawing.Size(1023, 312)
        Me.DGV2.TabIndex = 10
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(470, 30)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(1023, 38)
        Me.txt_search.TabIndex = 4
        '
        'txt_id_peminjaman
        '
        Me.txt_id_peminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_peminjaman.Location = New System.Drawing.Point(258, 534)
        Me.txt_id_peminjaman.Name = "txt_id_peminjaman"
        Me.txt_id_peminjaman.Size = New System.Drawing.Size(193, 38)
        Me.txt_id_peminjaman.TabIndex = 5
        '
        'txt_denda
        '
        Me.txt_denda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_denda.Location = New System.Drawing.Point(258, 592)
        Me.txt_denda.Name = "txt_denda"
        Me.txt_denda.Size = New System.Drawing.Size(193, 38)
        Me.txt_denda.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(257, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 51)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "CETAK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_tempo
        '
        Me.txt_tempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tempo.Location = New System.Drawing.Point(258, 723)
        Me.txt_tempo.Name = "txt_tempo"
        Me.txt_tempo.Size = New System.Drawing.Size(193, 38)
        Me.txt_tempo.TabIndex = 34
        '
        'id_peminjam_kembali
        '
        Me.id_peminjam_kembali.HeaderText = "ID PEMINJAM"
        Me.id_peminjam_kembali.MinimumWidth = 6
        Me.id_peminjam_kembali.Name = "id_peminjam_kembali"
        Me.id_peminjam_kembali.ReadOnly = True
        Me.id_peminjam_kembali.Width = 125
        '
        'nama_anggota_kembali
        '
        Me.nama_anggota_kembali.HeaderText = "NAMA PEMINJAM"
        Me.nama_anggota_kembali.MinimumWidth = 6
        Me.nama_anggota_kembali.Name = "nama_anggota_kembali"
        Me.nama_anggota_kembali.ReadOnly = True
        Me.nama_anggota_kembali.Width = 125
        '
        'id_peminjaman_kembali
        '
        Me.id_peminjaman_kembali.HeaderText = "ID PEMINJAMAN"
        Me.id_peminjaman_kembali.MinimumWidth = 6
        Me.id_peminjaman_kembali.Name = "id_peminjaman_kembali"
        Me.id_peminjaman_kembali.ReadOnly = True
        Me.id_peminjaman_kembali.Width = 125
        '
        'nama_petugas_kembali
        '
        Me.nama_petugas_kembali.HeaderText = "NAMA PETUGAS"
        Me.nama_petugas_kembali.MinimumWidth = 6
        Me.nama_petugas_kembali.Name = "nama_petugas_kembali"
        Me.nama_petugas_kembali.ReadOnly = True
        Me.nama_petugas_kembali.Width = 125
        '
        'judul_buku_kembali
        '
        Me.judul_buku_kembali.HeaderText = "JUDUL BUKU"
        Me.judul_buku_kembali.MinimumWidth = 6
        Me.judul_buku_kembali.Name = "judul_buku_kembali"
        Me.judul_buku_kembali.ReadOnly = True
        Me.judul_buku_kembali.Width = 120
        '
        'kategori_buku_kembali
        '
        Me.kategori_buku_kembali.HeaderText = "KATEGORI"
        Me.kategori_buku_kembali.MinimumWidth = 6
        Me.kategori_buku_kembali.Name = "kategori_buku_kembali"
        Me.kategori_buku_kembali.ReadOnly = True
        Me.kategori_buku_kembali.Width = 200
        '
        'penerbit_kembali
        '
        Me.penerbit_kembali.HeaderText = "PENERBIT"
        Me.penerbit_kembali.MinimumWidth = 6
        Me.penerbit_kembali.Name = "penerbit_kembali"
        Me.penerbit_kembali.ReadOnly = True
        Me.penerbit_kembali.Width = 125
        '
        'penulis_kembali
        '
        Me.penulis_kembali.HeaderText = "PENULIS"
        Me.penulis_kembali.MinimumWidth = 6
        Me.penulis_kembali.Name = "penulis_kembali"
        Me.penulis_kembali.ReadOnly = True
        Me.penulis_kembali.Width = 125
        '
        'rak_kembali
        '
        Me.rak_kembali.HeaderText = "RAK"
        Me.rak_kembali.MinimumWidth = 6
        Me.rak_kembali.Name = "rak_kembali"
        Me.rak_kembali.ReadOnly = True
        Me.rak_kembali.Width = 125
        '
        'id_petugas_kembali
        '
        Me.id_petugas_kembali.HeaderText = "ID PETUGAS"
        Me.id_petugas_kembali.MinimumWidth = 6
        Me.id_petugas_kembali.Name = "id_petugas_kembali"
        Me.id_petugas_kembali.ReadOnly = True
        Me.id_petugas_kembali.Width = 125
        '
        'tahun_terbit_kembali
        '
        Me.tahun_terbit_kembali.HeaderText = "TAHUN TERBIT"
        Me.tahun_terbit_kembali.MinimumWidth = 6
        Me.tahun_terbit_kembali.Name = "tahun_terbit_kembali"
        Me.tahun_terbit_kembali.ReadOnly = True
        Me.tahun_terbit_kembali.Width = 200
        '
        'tanggal_pinjam_kembali
        '
        Me.tanggal_pinjam_kembali.HeaderText = "TANGGAL PEMINJAMAN"
        Me.tanggal_pinjam_kembali.MinimumWidth = 6
        Me.tanggal_pinjam_kembali.Name = "tanggal_pinjam_kembali"
        Me.tanggal_pinjam_kembali.ReadOnly = True
        Me.tanggal_pinjam_kembali.Width = 125
        '
        'jatuh_tempo_kembali
        '
        Me.jatuh_tempo_kembali.HeaderText = "JATUH TEMPO"
        Me.jatuh_tempo_kembali.MinimumWidth = 6
        Me.jatuh_tempo_kembali.Name = "jatuh_tempo_kembali"
        Me.jatuh_tempo_kembali.ReadOnly = True
        Me.jatuh_tempo_kembali.Width = 125
        '
        'denda_kembali
        '
        Me.denda_kembali.HeaderText = "DENDA"
        Me.denda_kembali.MinimumWidth = 6
        Me.denda_kembali.Name = "denda_kembali"
        Me.denda_kembali.ReadOnly = True
        Me.denda_kembali.Width = 125
        '
        'PengembalianForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1615, 850)
        Me.Controls.Add(Me.txt_tempo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_denda)
        Me.Controls.Add(Me.txt_id_peminjaman)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PengembalianForm"
        Me.Text = "PengembalianForm"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rak_buku As TextBox
    Friend WithEvents txt_kategori_buku As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_judul_buku As TextBox
    Friend WithEvents txt_penulis As TextBox
    Friend WithEvents txt_penerbit_buku As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_tahun_terbit_buku As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_id_peminjam As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_id_petugas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_petugas As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_anggota As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dt_jatuh_tempo As DateTimePicker
    Friend WithEvents dt_tanggal_peminjaman As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_nama_peminjam As TextBox
    Friend WithEvents txt_id_peminjaman As TextBox
    Friend WithEvents id_peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents id_buku As DataGridViewTextBoxColumn
    Friend WithEvents judul_buku As DataGridViewTextBoxColumn
    Friend WithEvents tahun_terbit_buku As DataGridViewTextBoxColumn
    Friend WithEvents penerbit_buku As DataGridViewTextBoxColumn
    Friend WithEvents kategori_buku As DataGridViewTextBoxColumn
    Friend WithEvents rak_buku As DataGridViewTextBoxColumn
    Friend WithEvents nama_peminjam As DataGridViewTextBoxColumn
    Friend WithEvents nama_petugas As DataGridViewTextBoxColumn
    Friend WithEvents id_peminjam As DataGridViewTextBoxColumn
    Friend WithEvents id_petugas As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents jatuh_tempo As DataGridViewTextBoxColumn
    Friend WithEvents penulis As DataGridViewTextBoxColumn
    Friend WithEvents txt_nama_anggota As TextBox
    Friend WithEvents txt_denda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_id_buku As Label
    Friend WithEvents txt_tempo As TextBox
    Friend WithEvents id_peminjam_kembali As DataGridViewTextBoxColumn
    Friend WithEvents nama_anggota_kembali As DataGridViewTextBoxColumn
    Friend WithEvents id_peminjaman_kembali As DataGridViewTextBoxColumn
    Friend WithEvents nama_petugas_kembali As DataGridViewTextBoxColumn
    Friend WithEvents judul_buku_kembali As DataGridViewTextBoxColumn
    Friend WithEvents kategori_buku_kembali As DataGridViewTextBoxColumn
    Friend WithEvents penerbit_kembali As DataGridViewTextBoxColumn
    Friend WithEvents penulis_kembali As DataGridViewTextBoxColumn
    Friend WithEvents rak_kembali As DataGridViewTextBoxColumn
    Friend WithEvents id_petugas_kembali As DataGridViewTextBoxColumn
    Friend WithEvents tahun_terbit_kembali As DataGridViewTextBoxColumn
    Friend WithEvents tanggal_pinjam_kembali As DataGridViewTextBoxColumn
    Friend WithEvents jatuh_tempo_kembali As DataGridViewTextBoxColumn
    Friend WithEvents denda_kembali As DataGridViewTextBoxColumn
End Class
