Imports System.Data.Odbc

Public Class TambahPenerbitForm
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        addData()
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        updateData()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        deleteData()
    End Sub

    Private Sub btn_kosongkan_Click(sender As Object, e As EventArgs) Handles btn_kosongkan.Click
        clearForm()
        setId()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            txt_id_penerbit.Text = DGV1.Rows(e.RowIndex).Cells("id_penerbit_buku").Value.ToString()
            txt_nama_penerbit.Text = DGV1.Rows(e.RowIndex).Cells("nama_penerbit").Value.ToString()
            txt_alamat_penerbit.Text = DGV1.Rows(e.RowIndex).Cells("alamat_penerbit").Value.ToString()
            txt_email_penerbit.Text = DGV1.Rows(e.RowIndex).Cells("email_penerbit").Value.ToString()
            txt_nomor_telepon.Text = DGV1.Rows(e.RowIndex).Cells("nomor_telepon_penerbit").Value.ToString()
        End If
    End Sub

    Private Sub TambahPenerbitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setId()
        LoadRakData()
    End Sub


    Private Sub clearForm()
        txt_nomor_telepon.Clear()
        txt_alamat_penerbit.Clear()
        txt_nama_penerbit.Clear()
        txt_email_penerbit.Clear()
    End Sub

    Private Sub addData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_penerbit.Text
                Dim namaPenerbit As String = txt_nama_penerbit.Text
                Dim alamatPenerbit As String = txt_alamat_penerbit.Text
                Dim emailPenerbit As String = txt_email_penerbit.Text
                Dim teleponPenerbit As String = txt_nomor_telepon.Text
                Dim query As String = "INSERT INTO penerbit_buku (
                        id_penerbit_Buku,
                        nama_penerbit,
                        alamat_penerbit,
                        email_penerbit,
                        nomor_telepon_penerbit) 
                        VALUES (
                            '" & newId & "',
                            '" & namaPenerbit & "',
                            '" & alamatPenerbit & "',
                            '" & emailPenerbit & "',
                            '" & teleponPenerbit & "')"
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
            Dim query As String = "SELECT id_penerbit_Buku FROM penerbit_buku ORDER BY id_penerbit_Buku DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "PB0000" ' Jika belum ada data, gunakan ini sebagai awal
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
            Return "PB" & number.ToString("D4")
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
                txt_id_penerbit.Text = newId
                txt_id_penerbit.Enabled = False
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
                        id_penerbit_Buku,
                        nama_penerbit,
                        alamat_penerbit,
                        email_penerbit,
                        nomor_telepon_penerbit
                        FROM penerbit_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idPenerbit As String = reader("id_penerbit_buku").ToString()
                            Dim namaPenerbit As String = reader("nama_penerbit").ToString()
                            Dim alamatPenerbit As String = reader("alamat_penerbit").ToString()
                            Dim emailPenerbit As String = reader("email_penerbit").ToString()
                            Dim teleponPenerbit As String = reader("nomor_telepon_penerbit").ToString()
                            DGV1.Rows.Add(idPenerbit, namaPenerbit, alamatPenerbit, emailPenerbit, teleponPenerbit) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateData()
        If String.IsNullOrWhiteSpace(txt_id_penerbit.Text) OrElse String.IsNullOrWhiteSpace(txt_nama_penerbit.Text) Then
            MessageBox.Show("Pastikan ID tidak kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_penerbit.Text
                Dim namaPenerbit As String = txt_nama_penerbit.Text
                Dim alamatPenerbit As String = txt_alamat_penerbit.Text
                Dim emailPenerbit As String = txt_email_penerbit.Text
                Dim teleponPenerbit As String = txt_nomor_telepon.Text
                Dim query As String = "UPDATE penerbit_buku SET 
                            nama_penerbit = '" & namaPenerbit & "', 
                            alamat_penerbit = '" & alamatPenerbit & "',
                            email_penerbit = '" & emailPenerbit & "',
                            nomor_telepon_penerbit = '" & teleponPenerbit & "'
                            WHERE id_penerbit_Buku = '" & newId & "'"
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
        If String.IsNullOrWhiteSpace(txt_id_penerbit.Text) Then
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
                    Dim idRak As String = txt_id_penerbit.Text
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