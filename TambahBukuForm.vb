Imports System.Data.Odbc
Public Class TambahBukuForm
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        addData()
        clearForm()
        setId()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        updateData()
        LoadRakData()
        clearForm()
        setId()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        deleteData()
        LoadRakData()
        setId()
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        clearForm()
        setId()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub TambahBukuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillComboboxPenerbit()
        fillComboboxKategori()
        fillComboboxRak()
        fillComboboxPenulis()
        setId()
        loadRakData()
    End Sub

    Private Sub clearForm()
        txt_judul_buku.Clear()
        txt_judul_buku.Clear()
        txt_tahun_terbit.Clear()
    End Sub

    Private Sub addData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_buku.Text
                Dim namaBuku As String = txt_judul_buku.Text
                Dim tahunBuku As String = txt_tahun_terbit.Text
                Dim penerbitBuku As String = cb_penerbit.Text
                Dim rakBuku As String = cb_rak.Text
                Dim kategoriBuku As String = cb_kategori.Text
                Dim penulisBuku As String = cb_penulis.Text
                Dim query As String = "INSERT INTO buku (
                        id_buku,
                        judul_buku,
                        tahun_terbit_buku,
                        penerbit_buku,
                        rak_buku,
                        kategori_buku,
                        penulis_buku)
                        VALUES (
                            '" & newId & "',
                            '" & namaBuku & "',
                            '" & tahunBuku & "',
                            '" & penerbitBuku & "',
                            '" & rakBuku & "',
                            '" & kategoriBuku & "',
                            '" & penulisBuku & "')"
                Using cmd As New OdbcCommand(query, conn)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        LoadRakData()
                        MessageBox.Show("Data berhasil ditambahkan dengan ID: " & newId, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        setId()

                    Else
                        MessageBox.Show("Data gagal ditambahkan", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function GetLastId(conn As OdbcConnection) As String
        Try
            Dim query As String = "SELECT id_buku FROM buku ORDER BY id_buku DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "BK0000" ' Jika belum ada data, gunakan ini sebagai awal
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
            Return "BK" & number.ToString("D4")
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
                txt_id_buku.Text = newId
                txt_id_buku.Enabled = False
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadRakData()
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
                        FROM buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idBuku As String = reader("id_buku").ToString()
                            Dim judulBuku As String = reader("judul_buku").ToString()
                            Dim tahunBuku As String = reader("tahun_terbit_buku").ToString()
                            Dim penerbitBuku As String = reader("penerbit_buku").ToString()
                            Dim rakBuku As String = reader("rak_buku").ToString()
                            Dim kategoriBuku As String = reader("kategori_buku").ToString()
                            Dim penulisBuku As String = reader("penulis_buku").ToString()
                            DGV1.Rows.Add(idBuku, judulBuku, tahunBuku, penerbitBuku, kategoriBuku, rakBuku, penulisBuku) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateData()
        If String.IsNullOrWhiteSpace(txt_id_buku.Text) OrElse String.IsNullOrWhiteSpace(txt_judul_buku.Text) Then
            MessageBox.Show("Pastikan ID tidak kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_buku.Text
                Dim namaBuku As String = txt_judul_buku.Text
                Dim tahunBuku As String = txt_tahun_terbit.Text
                Dim penerbitBuku As String = cb_penerbit.Text
                Dim rakBuku As String = cb_rak.Text
                Dim kategoriBuku As String = cb_kategori.Text
                Dim penulisBuku As String = cb_penulis.Text
                Dim query As String = "UPDATE buku SET 
                            judul_buku = '" & namaBuku & "', 
                            tahun_terbit_buku = '" & tahunBuku & "',
                            penerbit_buku = '" & penerbitBuku & "',
                            rak_buku = '" & rakBuku & "',
                            kategori_buku = '" & kategoriBuku & "',
                            penulis_buku = '" & penulisBuku & "'
                            WHERE id_Buku = '" & newId & "'"
                Using cmd As New OdbcCommand(query, conn)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadRakData() ' Memperbarui DataGridView setelah update
                    Else
                        MessageBox.Show("Data gagal diperbarui.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub deleteData()
        If String.IsNullOrWhiteSpace(txt_id_buku.Text) Then
            MessageBox.Show("Pastikan ID Rak dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
                Using conn As OdbcConnection = dbConn.getConnection()
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim idBuku As String = txt_id_buku.Text
                    Dim query As String = "DELETE FROM penerbit_buku WHERE id_penerbit_Buku = '" & idBuku & "'"
                    Using cmd As New OdbcCommand(query, conn)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            setId()
                            LoadRakData() ' Memperbarui DataGridView setelah penghapusan
                        Else
                            MessageBox.Show("Data gagal dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub fillComboboxPenerbit()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT nama_penerbit FROM penerbit_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        cb_penerbit.Items.Clear()
                        While reader.Read()
                            cb_penerbit.Items.Add(reader("nama_penerbit").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillComboboxKategori()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT nama_kategori FROM kategori_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        cb_kategori.Items.Clear()
                        While reader.Read()
                            cb_kategori.Items.Add(reader("nama_kategori").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillComboboxRak()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT lokasi_rak_buku FROM rak_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        cb_rak.Items.Clear()
                        While reader.Read()
                            cb_rak.Items.Add(reader("lokasi_rak_buku").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fillComboboxPenulis()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim query As String = "SELECT nama_penulis FROM penulis_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        cb_penulis.Items.Clear()
                        While reader.Read()
                            cb_penulis.Items.Add(reader("nama_penulis").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            txt_id_buku.Text = DGV1.Rows(e.RowIndex).Cells("id_buku").Value.ToString()
            txt_judul_buku.Text = DGV1.Rows(e.RowIndex).Cells("judul_buku").Value.ToString()
            txt_tahun_terbit.Text = DGV1.Rows(e.RowIndex).Cells("tahun_terbit_buku").Value.ToString()
            cb_kategori.Text = DGV1.Rows(e.RowIndex).Cells("kategori_buku").Value.ToString()
            cb_penerbit.Text = DGV1.Rows(e.RowIndex).Cells("penerbit_buku").Value.ToString()
            cb_penulis.Text = DGV1.Rows(e.RowIndex).Cells("penulis_buku").Value.ToString()
            cb_rak.Text = DGV1.Rows(e.RowIndex).Cells("rak_buku").Value.ToString()
        End If
    End Sub
End Class