Imports System.Data.Odbc
Public Class PeminjamanForm
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        addDataToDGV()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click

    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProsesData()
    End Sub

    Private Sub PeminjamanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillComboBox()
        fillComboboxAnggota()
        fillComboboxPetugas()
        disableTextbox()
        setId()
        dt_tanggal_peminjaman.Value = DateAndTime.Now
    End Sub

    Private Function GetLastId(conn As OdbcConnection) As String
        Try
            Dim query As String = "SELECT id_peminjaman FROM peminjaman ORDER BY id_peminjaman DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "PJ0000" ' Jika belum ada data, gunakan ini sebagai awal
                End If
                Return lastId
            End Using
        Catch ex As Exception
            Throw New Exception("Gagal mendapatkan ID terakhir: " & ex.Message)
        End Try
    End Function

    Private Function GenerateNewId(lastId As String) As String
        Try
            Dim number As Integer = Integer.Parse(lastId.Substring(2))
            number += 1
            Return "PJ" & number.ToString("D4")
        Catch ex As Exception
            Throw New Exception("Gagal menghasilkan ID baru: " & ex.Message)
        End Try
    End Function

    Private Sub setId()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim lastId As String = GetLastId(conn)
                Dim newId As String = GenerateNewId(lastId)
                txt_id_peminjaman.Text = newId
                txt_id_peminjaman.Enabled = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProsesData()
        ' Periksa apakah ada data di DataGridView
        If DGV1.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk diproses!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' Koneksi ke database
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Looping setiap baris di DataGridView
                For Each row As DataGridViewRow In DGV1.Rows
                    If Not row.IsNewRow Then
                        ' Query dengan parameter
                        Dim query As String = "INSERT INTO peminjaman (
                                                id_peminjaman,
                                                id_buku,
                                                judul_buku,
                                                penulis_buku,
                                                penerbit_buku,
                                                tahun_terbit_buku,
                                                kategori_buku,
                                                rak_buku,
                                                nama_peminjam,
                                                id_peminjam,
                                                nama_petugas,
                                                id_petugas,
                                                tgl_peminjaman,
                                                jatuh_tempo
                                            ) VALUES (
                                                '" & row.Cells("id_peminjaman").Value.ToString & "',
                                                '" & row.Cells("id_buku").Value.ToString & "',
                                                '" & row.Cells("judul_buku").Value.ToString & "',
                                                '" & row.Cells("penulis_buku").Value.ToString & "',
                                                '" & row.Cells("penerbit_buku").Value.ToString & "',
                                                '" & row.Cells("tahun_terbit_buku").Value.ToString & "',
                                                '" & row.Cells("kategori_buku").Value.ToString & "',
                                                '" & row.Cells("rak_buku").Value.ToString & "',
                                                '" & row.Cells("nama_peminjam").Value.ToString & "',
                                                '" & row.Cells("id_peminjam").Value.ToString & "',
                                                '" & row.Cells("nama_petugas").Value.ToString & "',
                                                '" & row.Cells("id_petugas").Value.ToString & "',
                                                '" & row.Cells("tanggal_peminjaman").Value.ToString & "',
                                                '" & row.Cells("jatuh_tempo").Value.ToString & "'
                                            )"

                        Using cmd As New OdbcCommand(query, conn)
                            ' Tambahkan parameter ke query
                            ' Eksekusi query
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using

            ' Tampilkan pesan sukses
            MessageBox.Show("Data berhasil diproses ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kosongkan DataGridView setelah berhasil
            DGV1.Rows.Clear()

            ' Buat ID peminjaman baru
            setId()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub addDataToDGV()
        Dim timestamp As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.fff")
        DGV1.Rows.Add(
            txt_id_peminjaman.Text,
            txt_id_buku.Text,
            cb_judul_buku.Text,
            txt_tahun_terbit.Text,
            txt_penerbit.Text,
            txt_kategori.Text,
            txt_rak.Text,
            cb_anggota.Text,
            cb_petugas.Text,
            txt_id_peminjam.Text,
            txt_id_petugas.Text,
            dt_tanggal_peminjaman.Text,
            timestamp,
            txt_penulis.Text)
    End Sub

    Private Sub fillComboboxAnggota()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT id_anggota, nama_anggota FROM anggota"
                Dim adapter As New OdbcDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)

                cb_anggota.DataSource = table
                cb_anggota.DisplayMember = "nama_anggota" ' Menampilkan nama anggota di combobox
                cb_anggota.ValueMember = "id_anggota"    ' Menyimpan id anggota sebagai nilai tersembunyi
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillComboboxPetugas()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT id_petugas_buku, nama_petugas FROM petugas_buku"
                Dim adapter As New OdbcDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)

                cb_petugas.DataSource = table
                cb_petugas.DisplayMember = "nama_petugas" ' Menampilkan nama anggota di combobox
                cb_petugas.ValueMember = "id_petugas_buku"    ' Menyimpan id anggota sebagai nilai tersembunyi
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub disableTextbox()
        txt_id_buku.Enabled = False
        txt_tahun_terbit.Enabled = False
        txt_penerbit.Enabled = False
        txt_rak.Enabled = False
        txt_kategori.Enabled = False
        txt_penulis.Enabled = False
        txt_id_peminjam.Enabled = False
    End Sub

    Private Sub fillComboBox()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT id_buku, judul_buku FROM buku"
                Dim adapter As New OdbcDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)

                cb_judul_buku.DataSource = table
                cb_judul_buku.DisplayMember = "judul_buku"  ' Kolom yang ditampilkan
                cb_judul_buku.ValueMember = "id_buku"      ' Kolom unik sebagai value
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_judul_buku.SelectedIndexChanged
        If cb_judul_buku.SelectedIndex <> -1 Then
            Dim selectedId As String = cb_judul_buku.SelectedValue.ToString()
            LoadBookDetails(selectedId)
        End If
    End Sub

    Private Sub LoadBookDetails(selectedId As String)
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT
                        id_buku,
                        judul_buku,
                        tahun_terbit_buku,
                        penerbit_buku,
                        rak_buku,
                        kategori_buku,
                        penulis_buku
                        FROM buku WHERE id_buku = '" & selectedId & "' "
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            txt_id_buku.Text = reader("id_buku").ToString()
                            txt_tahun_terbit.Text = reader("tahun_terbit_buku").ToString()
                            txt_penerbit.Text = reader("penerbit_buku").ToString()
                            txt_rak.Text = reader("rak_buku").ToString()
                            txt_kategori.Text = reader("kategori_buku").ToString()
                            txt_penulis.Text = reader("penulis_buku").ToString()

                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cb_anggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_anggota.SelectedIndexChanged
        If cb_anggota.SelectedIndex <> -1 Then
            txt_id_peminjam.Text = cb_anggota.SelectedValue.ToString()
            txt_id_peminjam.Enabled = False
        End If
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub cb_petugas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_petugas.SelectedIndexChanged
        If cb_petugas.SelectedIndex <> -1 Then
            txt_id_petugas.Text = cb_petugas.SelectedValue.ToString()
            txt_id_petugas.Enabled = False
        End If
    End Sub
End Class