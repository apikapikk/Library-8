﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPenerbitForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahPenerbitForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_nomor_telepon = New System.Windows.Forms.TextBox()
        Me.txt_email_penerbit = New System.Windows.Forms.TextBox()
        Me.btn_kosongkan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.txt_id_penerbit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat_penerbit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama_penerbit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.id_penerbit_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomor_telepon_penerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 802)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1289, 58)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SF UI  Text Light", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(38, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dikembangkan Oleh Kelompok 3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox2.Controls.Add(Me.txt_nomor_telepon)
        Me.GroupBox2.Controls.Add(Me.txt_email_penerbit)
        Me.GroupBox2.Controls.Add(Me.btn_kosongkan)
        Me.GroupBox2.Controls.Add(Me.btn_hapus)
        Me.GroupBox2.Controls.Add(Me.btn_ubah)
        Me.GroupBox2.Controls.Add(Me.btn_tambah)
        Me.GroupBox2.Controls.Add(Me.txt_id_penerbit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_alamat_penerbit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_nama_penerbit)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 784)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETAIL PENERBIT"
        '
        'txt_nomor_telepon
        '
        Me.txt_nomor_telepon.Location = New System.Drawing.Point(16, 267)
        Me.txt_nomor_telepon.Name = "txt_nomor_telepon"
        Me.txt_nomor_telepon.Size = New System.Drawing.Size(213, 28)
        Me.txt_nomor_telepon.TabIndex = 21
        '
        'txt_email_penerbit
        '
        Me.txt_email_penerbit.Location = New System.Drawing.Point(16, 212)
        Me.txt_email_penerbit.Name = "txt_email_penerbit"
        Me.txt_email_penerbit.Size = New System.Drawing.Size(213, 28)
        Me.txt_email_penerbit.TabIndex = 20
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
        Me.btn_kosongkan.Size = New System.Drawing.Size(213, 41)
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
        Me.btn_hapus.Size = New System.Drawing.Size(213, 42)
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
        Me.btn_ubah.Size = New System.Drawing.Size(213, 42)
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
        Me.btn_tambah.Size = New System.Drawing.Size(213, 42)
        Me.btn_tambah.TabIndex = 16
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'txt_id_penerbit
        '
        Me.txt_id_penerbit.Location = New System.Drawing.Point(16, 48)
        Me.txt_id_penerbit.Name = "txt_id_penerbit"
        Me.txt_id_penerbit.Size = New System.Drawing.Size(213, 28)
        Me.txt_id_penerbit.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ID PENERBIT"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "NOMOR TELEPON"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "EMAIL PENERBIT"
        '
        'txt_alamat_penerbit
        '
        Me.txt_alamat_penerbit.Location = New System.Drawing.Point(16, 158)
        Me.txt_alamat_penerbit.Name = "txt_alamat_penerbit"
        Me.txt_alamat_penerbit.Size = New System.Drawing.Size(213, 28)
        Me.txt_alamat_penerbit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ALAMAT PENERBIT"
        '
        'txt_nama_penerbit
        '
        Me.txt_nama_penerbit.Location = New System.Drawing.Point(16, 103)
        Me.txt_nama_penerbit.Name = "txt_nama_penerbit"
        Me.txt_nama_penerbit.Size = New System.Drawing.Size(213, 28)
        Me.txt_nama_penerbit.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NAMA PENERBIT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.btn_close)
        Me.GroupBox1.Controls.Add(Me.DGV1)
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Font = New System.Drawing.Font("SF UI  Text", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(255, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 784)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMASI PENERBIT"
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(766, 18)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(235, 46)
        Me.btn_close.TabIndex = 17
        Me.btn_close.Text = "TUTUP"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_penerbit_buku, Me.nama_penerbit, Me.alamat_penerbit, Me.email_penerbit, Me.nomor_telepon_penerbit})
        Me.DGV1.Location = New System.Drawing.Point(6, 122)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(995, 656)
        Me.DGV1.TabIndex = 1
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(766, 70)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(235, 36)
        Me.btn_search.TabIndex = 15
        Me.btn_search.Text = "CARI"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Font = New System.Drawing.Font("SF UI  Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(6, 67)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(430, 40)
        Me.txt_search.TabIndex = 0
        '
        'id_penerbit_buku
        '
        Me.id_penerbit_buku.HeaderText = "ID PENERBIT"
        Me.id_penerbit_buku.MinimumWidth = 6
        Me.id_penerbit_buku.Name = "id_penerbit_buku"
        Me.id_penerbit_buku.ReadOnly = True
        Me.id_penerbit_buku.Width = 125
        '
        'nama_penerbit
        '
        Me.nama_penerbit.HeaderText = "NAMA PENERBIT"
        Me.nama_penerbit.MinimumWidth = 6
        Me.nama_penerbit.Name = "nama_penerbit"
        Me.nama_penerbit.ReadOnly = True
        Me.nama_penerbit.Width = 120
        '
        'alamat_penerbit
        '
        Me.alamat_penerbit.HeaderText = "ALAMAT PENERBIT"
        Me.alamat_penerbit.MinimumWidth = 6
        Me.alamat_penerbit.Name = "alamat_penerbit"
        Me.alamat_penerbit.ReadOnly = True
        Me.alamat_penerbit.Width = 200
        '
        'email_penerbit
        '
        Me.email_penerbit.HeaderText = "EMAIL PENERBIT"
        Me.email_penerbit.MinimumWidth = 6
        Me.email_penerbit.Name = "email_penerbit"
        Me.email_penerbit.ReadOnly = True
        Me.email_penerbit.Width = 125
        '
        'nomor_telepon_penerbit
        '
        Me.nomor_telepon_penerbit.HeaderText = "NOMOR TELEPON PENERBIT"
        Me.nomor_telepon_penerbit.MinimumWidth = 6
        Me.nomor_telepon_penerbit.Name = "nomor_telepon_penerbit"
        Me.nomor_telepon_penerbit.ReadOnly = True
        Me.nomor_telepon_penerbit.Width = 200
        '
        'TambahPenerbitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1285, 850)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TambahPenerbitForm"
        Me.Text = "TambahPenerbitForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_kosongkan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_id_penerbit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_penerbit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_penerbit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents txt_nomor_telepon As TextBox
    Friend WithEvents txt_email_penerbit As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents id_penerbit_buku As DataGridViewTextBoxColumn
    Friend WithEvents nama_penerbit As DataGridViewTextBoxColumn
    Friend WithEvents alamat_penerbit As DataGridViewTextBoxColumn
    Friend WithEvents email_penerbit As DataGridViewTextBoxColumn
    Friend WithEvents nomor_telepon_penerbit As DataGridViewTextBoxColumn
End Class
