Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class PengembalianForm
    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            txt_id_peminjam.Text = DGV1.Rows(e.RowIndex).Cells("id_peminjam").Value.ToString()
            txt_nama_peminjam.Text = DGV1.Rows(e.RowIndex).Cells("nama_peminjam").Value.ToString()
            txt_id_anggota.Text = DGV1.Rows(e.RowIndex).Cells("id_peminjam").Value.ToString()
            txt_id_peminjaman.Text = DGV1.Rows(e.RowIndex).Cells("id_peminjaman").Value.ToString()
            txt_petugas.Text = DGV1.Rows(e.RowIndex).Cells("nama_petugas").Value.ToString()
            txt_judul_buku.Text = DGV1.Rows(e.RowIndex).Cells("judul_buku").Value.ToString()
            txt_kategori_buku.Text = DGV1.Rows(e.RowIndex).Cells("kategori_buku").Value.ToString()
            txt_penerbit_buku.Text = DGV1.Rows(e.RowIndex).Cells("penerbit_buku").Value.ToString()
            txt_penulis.Text = DGV1.Rows(e.RowIndex).Cells("penulis").Value.ToString()
            txt_rak_buku.Text = DGV1.Rows(e.RowIndex).Cells("rak_buku").Value.ToString()
            txt_id_petugas.Text = DGV1.Rows(e.RowIndex).Cells("id_petugas").Value.ToString()
            txt_nama_anggota.Text = DGV1.Rows(e.RowIndex).Cells("nama_peminjam").Value.ToString()
            txt_tahun_terbit_buku.Text = DGV1.Rows(e.RowIndex).Cells("tahun_terbit_buku").Value.ToString()
            txt_id_buku.Text = DGV1.Rows(e.RowIndex).Cells("id_buku").Value.ToString()
            txt_tempo.Text = DGV1.Rows(e.RowIndex).Cells("jatuh_tempo").Value.ToString()
        End If
    End Sub
    Private Sub PengembalianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRakData()
        LoadHistoryData()
        disableText()
    End Sub

    Private Sub disableText()
        txt_id_peminjam.Enabled = False
        txt_nama_peminjam.Enabled = False
        txt_id_anggota.Enabled = False
        txt_id_peminjaman.Enabled = False
        txt_petugas.Enabled = False
        txt_judul_buku.Enabled = False
        txt_kategori_buku.Enabled = False
        txt_penerbit_buku.Enabled = False
        txt_penulis.Enabled = False
        txt_rak_buku.Enabled = False
        txt_id_petugas.Enabled = False
        txt_nama_anggota.Enabled = False
        txt_tahun_terbit_buku.Enabled = False

    End Sub

    Private Sub LoadRakData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT
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
                            FROM peminjaman"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idPeminjaman As String = reader("id_peminjaman").ToString()
                            Dim idBuku As String = reader("id_buku").ToString()
                            Dim judulBuku As String = reader("judul_buku").ToString()
                            Dim penulisBuku As String = reader("penulis_buku").ToString()
                            Dim penerbitBuku As String = reader("penerbit_buku").ToString()
                            Dim tahunTerbitBuku As String = reader("tahun_terbit_buku").ToString()
                            Dim kategoriBuku As String = reader("kategori_buku").ToString()
                            Dim rakBuku As String = reader("rak_buku").ToString()
                            Dim namaPeminjam As String = reader("nama_peminjam").ToString()
                            Dim idPeminjam As String = reader("id_peminjam").ToString()
                            Dim namaPetugas As String = reader("nama_petugas").ToString()
                            Dim idPetugas As String = reader("id_petugas").ToString()
                            Dim tanggalPeminjam As String = reader("tgl_peminjaman").ToString()
                            Dim jatuhTempo As String = reader("jatuh_tempo").ToString()
                            DGV1.Rows.Add(
                            idPeminjam,
                            idBuku,
                            judulBuku,
                            tahunTerbitBuku,
                            penerbitBuku,
                            kategoriBuku,
                            rakBuku,
                            namaPeminjam,
                            namaPetugas,
                            idPeminjam,
                            idPetugas,
                            tanggalPeminjam,
                            jatuhTempo,
                            penulisBuku
                            ) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nama_anggota.TextChanged

    End Sub

    Private Sub dt_tanggal_peminjaman_ValueChanged(sender As Object, e As EventArgs) Handles dt_tanggal_peminjaman.ValueChanged
        HitungDenda()
    End Sub

    Private Sub HitungDenda()
        Try
            Dim tanggalPengembalian As DateTime = dt_tanggal_peminjaman.Value
            Dim jatuhTempo As DateTime = dt_jatuh_tempo.Value
            If tanggalPengembalian > jatuhTempo Then
                Dim jumlahHariTerlambat As Integer = (tanggalPengembalian - jatuhTempo).Days
                Dim denda As Integer = jumlahHariTerlambat * 30000
                txt_denda.Text = denda.ToString
                MessageBox.Show("Terlambat " & jumlahHariTerlambat & " hari. Denda: Rp" & denda.ToString("N0"), "Denda", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Tidak ada keterlambatan. Tidak ada denda.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        addDataDB()
        DeletePeminjaman()
        LoadRakData()
    End Sub

    Private Sub LoadHistoryData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT
                       `id_peminjaman`,
                       `judul_buku`,    
                        `penulis_buku`,
                        `penerbit_buku`,
                        `tahun_terbit_buku`,
                        `kategori_buku`,
                        `rak_buku`,
                        `nama_peminjam`,
                        `id_peminjam`,
                        `id_petugas`,
                        `nama_petugas`,
                        `tanggal_peminjaman`,
                        `jatuh_tempo`,
                        `denda`
                            FROM pengembalian"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV2.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idPeminjaman As String = reader("id_peminjaman").ToString()
                            Dim judulBuku As String = reader("judul_buku").ToString()
                            Dim penulisBuku As String = reader("penulis_buku").ToString()
                            Dim penerbitBuku As String = reader("penerbit_buku").ToString()
                            Dim tahunTerbitBuku As String = reader("tahun_terbit_buku").ToString()
                            Dim kategoriBuku As String = reader("kategori_buku").ToString()
                            Dim rakBuku As String = reader("rak_buku").ToString()
                            Dim namaPeminjam As String = reader("nama_peminjam").ToString()
                            Dim idPeminjam As String = reader("id_peminjam").ToString()
                            Dim namaPetugas As String = reader("nama_petugas").ToString()
                            Dim idPetugas As String = reader("id_petugas").ToString()
                            Dim tanggalPeminjam As String = reader("tanggal_peminjaman").ToString()
                            Dim jatuhTempo As String = reader("jatuh_tempo").ToString()
                            Dim denda As String = reader("denda").ToString()
                            DGV2.Rows.Add(
                            idPeminjam,
                            namaPeminjam,
                            idPeminjaman,
                            namaPetugas,
                            judulBuku,
                            kategoriBuku,
                            penerbitBuku,
                            penulisBuku,
                            rakBuku,
                            idPetugas,
                            tahunTerbitBuku,
                            tanggalPeminjam,
                            jatuhTempo,
                            denda
                            ) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub addDataDB()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim idAnggota As String = txt_id_peminjam.Text
                Dim namaPeminjam As String = txt_nama_peminjam.Text
                Dim idPeminjaman As String = txt_id_peminjaman.Text
                Dim namaPetugas As String = txt_petugas.Text
                Dim judulBuku As String = txt_judul_buku.Text
                Dim kategoriBuku As String = txt_kategori_buku.Text
                Dim penerbitBuku As String = txt_penerbit_buku.Text
                Dim penulis As String = txt_penulis.Text
                Dim rakBuku As String = txt_rak_buku.Text
                Dim idPetugas As String = txt_id_petugas.Text
                Dim petugas As String = txt_petugas.Text
                Dim namaAnggota As String = txt_nama_anggota.Text
                Dim tahunTerbit As String = txt_tahun_terbit_buku.Text
                Dim tglPengembalian As String = dt_tanggal_peminjaman.Text
                Dim jatuhTempo As String = dt_jatuh_tempo.Text
                Dim denda As String = txt_denda.Text
                Dim query As String = "INSERT INTO pengembalian (
                        `id_peminjaman`,
                       `judul_buku`,    
                        `penulis_buku`,
                        `penerbit_buku`,
                        `tahun_terbit_buku`,
                        `kategori_buku`,
                        `rak_buku`,
                        `nama_peminjam`,
                        `id_peminjam`,
                        `id_petugas`,
                        `nama_petugas`,
                        `tanggal_peminjaman`,
                        `jatuh_tempo`,
                        `denda`) VALUES (
                            '" & idPeminjaman & "',
                            '" & judulBuku & "',
                            '" & penulis & "',
                            '" & penerbitBuku & "',
                            '" & tahunTerbit & "',
                            '" & kategoriBuku & "',
                            '" & rakBuku & "',
                            '" & namaAnggota & "',
                            '" & idAnggota & "',
                            '" & idPetugas & "',
                            '" & petugas & "',
                            '" & tglPengembalian & "',
                            '" & jatuhTempo & "',
                            '" & denda & "'
                         )"
                Using cmd As New OdbcCommand(query, conn)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        LoadHistoryData()
                    Else
                        MessageBox.Show("Data gagal ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeletePeminjaman()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim deleteQuery As String = "DELETE FROM peminjaman 
                                     WHERE jatuh_tempo LIKE '" & txt_tempo.Text & "'"

                Using cmdDelete As New OdbcCommand(deleteQuery, conn)
                    cmdDelete.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data peminjaman: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataPrint As New DataTable

        dataPrint.Columns.Add("ID", GetType(String))
        dataPrint.Columns.Add("NAMAPEMINJAM", GetType(String))
        dataPrint.Columns.Add("BUKU", GetType(String))
        dataPrint.Columns.Add("TGLKEMBALI", GetType(String))
        dataPrint.Columns.Add("JATUHTEMPO", GetType(String))
        dataPrint.Columns.Add("DENDA", GetType(String))

        ' Menambahkan data dari DataGridView ke DataTable
        For Each row As DataGridViewRow In DGV2.Rows
            If Not row.IsNewRow Then
                dataPrint.Rows.Add(
                row.Cells("id_peminjaman_kembali").Value,
                row.Cells("nama_anggota_kembali").Value,
                row.Cells("judul_buku_kembali").Value,
                row.Cells("tanggal_pinjam_kembali").Value,
                row.Cells("jatuh_tempo_kembali").Value,
                row.Cells("denda_kembali").Value
            )
            End If
        Next

        FormViewHistory.ReportViewer.LocalReport.DataSources.Clear()
        FormViewHistory.ReportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dataPrint))
        FormViewHistory.ReportViewer.LocalReport.Refresh()
        FormViewHistory.ShowDialog()
    End Sub

    Private Sub searchTransactionHistory()
        Try
            Dim searchText As String = "%" & txt_search.Text & "%"
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim searchQuery As String = "SELECT
                       `id_peminjaman`,
                       `judul_buku`,    
                       `penulis_buku`,
                       `penerbit_buku`,
                       `tahun_terbit_buku`,
                       `kategori_buku`,
                       `rak_buku`,
                       `nama_peminjam`,
                       `id_peminjam`,
                       `id_petugas`,
                       `nama_petugas`,
                       `tanggal_peminjaman`,
                       `jatuh_tempo`,
                       `denda`
                    FROM pengembalian 
                    WHERE id_peminjaman LIKE '" & searchText & "' 
                    OR judul_buku LIKE '" & searchText & "'  
                    OR penulis_buku LIKE '" & searchText & "' 
                    OR penerbit_buku LIKE '" & searchText & "'  
                    OR tahun_terbit_buku LIKE '" & searchText & "'  
                    OR kategori_buku LIKE '" & searchText & "'  
                    OR rak_buku LIKE '" & searchText & "'  
                    OR nama_peminjam LIKE '" & searchText & "' 
                    OR id_peminjam LIKE '" & searchText & "'  
                    OR id_petugas LIKE '" & searchText & "'  
                    OR nama_petugas LIKE '" & searchText & "'  
                    OR tanggal_peminjaman LIKE '" & searchText & "' 
                    OR jatuh_tempo LIKE '" & searchText & "'  
                    OR denda LIKE '" & searchText & "' "

                Using cmd As New OdbcCommand(searchQuery, conn)
                    For i As Integer = 1 To 14
                        cmd.Parameters.AddWithValue("?", searchText)
                    Next

                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV2.Rows.Clear() ' Bersihkan data lama dari DataGridView

                        While reader.Read()
                            ' Ambil data dari reader dan tambahkan ke DataGridView
                            DGV2.Rows.Add(
                            reader("id_peminjaman").ToString(),
                            reader("nama_peminjam").ToString(),
                            reader("id_peminjam").ToString(),
                            reader("nama_petugas").ToString(),
                            reader("judul_buku").ToString(),
                            reader("kategori_buku").ToString(),
                            reader("penerbit_buku").ToString(),
                            reader("penulis_buku").ToString(),
                            reader("rak_buku").ToString(),
                            reader("id_petugas").ToString(),
                            reader("tahun_terbit_buku").ToString(),
                            reader("tanggal_peminjaman").ToString(),
                            reader("jatuh_tempo").ToString(),
                            reader("denda").ToString()
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If String.IsNullOrWhiteSpace(txt_search.Text) Then
            LoadHistoryData()
        Else
            searchTransactionHistory()
        End If
    End Sub
End Class