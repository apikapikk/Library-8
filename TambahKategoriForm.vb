Imports System.Data.Odbc

Public Class TambahKategoriForm
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
        clearForm()
        setId()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        deleteData()
        setId()
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        clearForm()
        setId()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            txt_id_kategori.Text = DGV1.Rows(e.RowIndex).Cells("id_kategori").Value.ToString()
            txt_nama_kategori.Text = DGV1.Rows(e.RowIndex).Cells("nama_kategori").Value.ToString()
            txt_deskripsi_kategori.Text = DGV1.Rows(e.RowIndex).Cells("deskripsi_kategori").Value.ToString()
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub




    Private Sub clearForm()
        txt_nama_kategori.Clear()
        txt_deskripsi_kategori.Clear()
    End Sub

    Private Sub addData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_kategori.Text
                Dim namaKategori As String = txt_nama_kategori.Text
                Dim deskripsiKategori As String = txt_deskripsi_kategori.Text
                Dim query As String = "INSERT INTO kategori_buku (
                        id_kategori_Buku,
                        nama_kategori,
                        deskripsi_kategori) 
                        VALUES (
                            '" & newId & "',
                            '" & namaKategori & "',
                            '" & deskripsiKategori & "')"
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
            Dim query As String = "SELECT id_kategori_Buku FROM kategori_buku ORDER BY id_kategori_Buku DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "KT0000" ' Jika belum ada data, gunakan ini sebagai awal
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
            Return "KT" & number.ToString("D4")
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
                txt_id_kategori.Text = newId
                txt_id_kategori.Enabled = False
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
                        id_kategori_Buku,
                        nama_kategori,
                        deskripsi_kategori
                        FROM kategori_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idKategori As String = reader("id_kategori_Buku").ToString()
                            Dim namaKategori As String = reader("nama_kategori").ToString()
                            Dim deskripsiKategori As String = reader("deskripsi_kategori").ToString()
                            DGV1.Rows.Add(idKategori, namaKategori, deskripsiKategori) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateData()
        If String.IsNullOrWhiteSpace(txt_id_kategori.Text) OrElse String.IsNullOrWhiteSpace(txt_nama_kategori.Text) Then
            MessageBox.Show("Pastikan ID tidak kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_kategori.Text
                Dim namaKategori As String = txt_nama_kategori.Text
                Dim deskripsiKategori As String = txt_deskripsi_kategori.Text
                Dim query As String = "UPDATE kategori_buku SET 
                            nama_kategori = '" & namaKategori & "', 
                            deskripsi_kategori = '" & deskripsiKategori & "'
                            WHERE id_kategori_Buku = '" & newId & "'"
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
        If String.IsNullOrWhiteSpace(txt_id_kategori.Text) Then
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
                    Dim idRak As String = txt_id_kategori.Text
                    Dim query As String = "DELETE FROM penerbit_buku WHERE id_penerbit_Buku = '" & idRak & "'"
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

    Private Sub TambahKategoriForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setId()
        LoadRakData()
    End Sub
End Class