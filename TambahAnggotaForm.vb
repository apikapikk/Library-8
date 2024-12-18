Imports System.Data.Odbc

Public Class TambahAnggotaForm
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        addData()
        clearForm()
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
            txt_id_anggota.Text = DGV1.Rows(e.RowIndex).Cells("id_anggota").Value.ToString()
            txt_nama_anggota.Text = DGV1.Rows(e.RowIndex).Cells("nama_anggota").Value.ToString()
            txt_alamat_anggota.Text = DGV1.Rows(e.RowIndex).Cells("alamat_anggota").Value.ToString()
            txt_email_anggota.Text = DGV1.Rows(e.RowIndex).Cells("email_anggota").Value.ToString()
            txt_nomor_anggota.Text = DGV1.Rows(e.RowIndex).Cells("nomor_telepon_anggota").Value.ToString()
        End If
    End Sub

    Private Sub TambahAnggotaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setId()
        LoadRakData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        searchData(txt_search.Text)
    End Sub

    Private Sub searchData(text As String)

    End Sub

    Private Sub clearForm()
        txt_nama_anggota.Clear()
        txt_alamat_anggota.Clear()
        txt_email_anggota.Clear()
        txt_nomor_anggota.Clear()
    End Sub

    Private Sub addData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_anggota.Text
                Dim namaAnggota As String = txt_nama_anggota.Text
                Dim alamatAnggota As String = txt_alamat_anggota.Text
                Dim emailAnggota As String = txt_email_anggota.Text
                Dim teleponAnggota As String = txt_nomor_anggota.Text
                Dim query As String = "INSERT INTO anggota (
                        id_anggota,
                        nama_anggota,
                        alamat_anggota,
                        email_anggota,
                        no_telepon_anggota,
                        tanggal_daftar_anggota,
                        denda_anggota) 
                        VALUES (
                            '" & newId & "',
                            '" & namaAnggota & "',
                            '" & alamatAnggota & "',
                            '" & emailAnggota & "',
                            '" & teleponAnggota & "',
                            '" & DateAndTime.Now & "',
                            '0'
                            )"
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
            Dim query As String = "SELECT id_anggota FROM anggota ORDER BY id_anggota DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "AT0000" ' Jika belum ada data, gunakan ini sebagai awal
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
            Return "AT" & number.ToString("D4")
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
                txt_id_anggota.Text = newId
                txt_id_anggota.Enabled = False
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
                        id_anggota,
                        nama_anggota,
                        alamat_anggota,
                        email_anggota,
                        no_telepon_anggota,
                        tanggal_daftar_anggota,
                        denda_anggota 
                        FROM anggota"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idAnggota As String = reader("id_anggota").ToString()
                            Dim namaAnggota As String = reader("nama_anggota").ToString()
                            Dim alamatAnggota As String = reader("alamat_anggota").ToString()
                            Dim emailAnggota As String = reader("email_anggota").ToString()
                            Dim teleponAnggota As String = reader("no_telepon_anggota").ToString()
                            Dim daftarAnggota As String = reader("tanggal_daftar_anggota").ToString()
                            Dim dendaAnggota As String = reader("denda_anggota").ToString()
                            DGV1.Rows.Add(idAnggota, namaAnggota, alamatAnggota, emailAnggota, teleponAnggota, daftarAnggota, dendaAnggota) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateData()
        If String.IsNullOrWhiteSpace(txt_id_anggota.Text) OrElse String.IsNullOrWhiteSpace(txt_nama_anggota.Text) Then
            MessageBox.Show("Pastikan ID tidak kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_anggota.Text
                Dim namaAnggota As String = txt_nama_anggota.Text
                Dim alamatAnggota As String = txt_alamat_anggota.Text
                Dim emailAnggota As String = txt_email_anggota.Text
                Dim teleponAnggota As String = txt_nomor_anggota.Text
                Dim query As String = "UPDATE anggota SET 
                            nama_anggota = '" & namaAnggota & "', 
                            alamat_anggota = '" & alamatAnggota & "',
                            email_anggota = '" & emailAnggota & "',
                            no_telepon_anggota = '" & teleponAnggota & "'
                            WHERE id_anggota = '" & newId & "'"
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
        If String.IsNullOrWhiteSpace(txt_id_anggota.Text) Then
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
                    Dim idRak As String = txt_id_anggota.Text
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




End Class