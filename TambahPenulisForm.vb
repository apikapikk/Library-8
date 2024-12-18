Imports System.Data.Odbc

Public Class TambahPenulisForm
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
    End Sub

    Private Sub clearForm()
        txt_biografi_penulis.Clear()
        txt_nama_penulis.Clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        searchData(txt_search.Text)
    End Sub

    Private Sub updateData()
        If String.IsNullOrWhiteSpace(txt_id_penulis.Text) OrElse String.IsNullOrWhiteSpace(txt_nama_penulis.Text) Then
            MessageBox.Show("Pastikan ID tidak kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_penulis.Text
                Dim namaPenulis As String = txt_nama_penulis.Text
                Dim ttlPenulis As String = dt_ttl_penulis.Text
                Dim biografiPenulis As String = txt_biografi_penulis.Text
                Dim query As String = "UPDATE penulis_buku SET 
                            nama_penulis = '" & namaPenulis & "', 
                            ttl_penulis = '" & ttlPenulis & "',
                            biografi_penulis = '" & biografiPenulis & "'
                            WHERE id_penulis_buku = '" & newId & "'"
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
        If String.IsNullOrWhiteSpace(txt_id_penulis.Text) Then
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
                    Dim idRak As String = txt_id_penulis.Text
                    Dim query As String = "DELETE FROM penulis_buku WHERE id_penulis_buku = '" & idRak & "'"
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

    Private Sub searchData(searchTerm As String)
        If String.IsNullOrWhiteSpace(searchTerm) Then
            For Each row As DataGridViewRow In DGV1.Rows
                row.Visible = True
            Next
            Return ' Keluar dari fungsi jika pencarian kosong
        End If

        searchTerm = searchTerm.ToLower()
        For Each row As DataGridViewRow In DGV1.Rows
            If row.Cells("id_penulis_buku").Value IsNot Nothing AndAlso row.Cells("nama_penulis").Value IsNot Nothing AndAlso
                row.Cells("biografi_penulis").Value IsNot Nothing Then
                Dim idPenulis As String = row.Cells("id_penulis_buku").Value.ToString().ToLower()
                Dim namaPenulis As String = row.Cells("nama_penulis").Value.ToString().ToLower()
                Dim biografi As String = row.Cells("biografi_penulis").Value.ToString().ToLower()
                row.Visible = idPenulis.Contains(searchTerm) OrElse namaPenulis.Contains(searchTerm) OrElse biografi.Contains(searchTerm)
            Else
                row.Visible = False
            End If
        Next
    End Sub

    Private Sub TambahPenulisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setId()
        LoadRakData()
    End Sub

    Private Function GetLastId(conn As OdbcConnection) As String
        Try
            Dim query As String = "SELECT id_penulis_buku FROM penulis_buku ORDER BY id_penulis_buku DESC LIMIT 1"
            Using cmd As New OdbcCommand(query, conn)
                Dim lastId As String = cmd.ExecuteScalar()?.ToString()
                If String.IsNullOrEmpty(lastId) Then
                    Return "PN0000" ' Jika belum ada data, gunakan ini sebagai awal
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
            Return "PN" & number.ToString("D4")
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
                txt_id_penulis.Text = newId
                txt_id_penulis.Enabled = False
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
                Dim query As String = "SELECT id_penulis_buku, nama_penulis, ttl_penulis,
                        biografi_penulis FROM penulis_buku"
                Using cmd As New OdbcCommand(query, conn)
                    Using reader As OdbcDataReader = cmd.ExecuteReader()
                        DGV1.Rows.Clear() ' Bersihkan data lama dari DataGridView
                        While reader.Read()
                            Dim idPenulis As String = reader("id_penulis_buku").ToString()
                            Dim namaPenulis As String = reader("nama_penulis").ToString()
                            Dim ttlPenulis As String = reader("ttl_penulis").ToString()
                            Dim biografiPenulis As String = reader("biografi_penulis").ToString()
                            DGV1.Rows.Add(idPenulis, namaPenulis, ttlPenulis, biografiPenulis) ' Menambah row baru
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addData()
        Try
            Dim dbConn As DatabaseConnection = DatabaseConnection.getInstance()
            Using conn As OdbcConnection = dbConn.getConnection()
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim newId As String = txt_id_penulis.Text
                Dim namaPenulis As String = txt_nama_penulis.Text
                Dim ttlPenulis As String = dt_ttl_penulis.Text
                Dim biografiPenulis As String = txt_biografi_penulis.Text
                Dim query As String = "INSERT INTO penulis_buku (
                        id_penulis_buku,
                        nama_penulis,
                        ttl_penulis,
                        biografi_penulis) 
                        VALUES (
                            '" & newId & "',
                            '" & namaPenulis & "',
                            '" & ttlPenulis & "',
                            '" & biografiPenulis & "')"
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

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.RowIndex >= 0 Then
            txt_id_penulis.Text = DGV1.Rows(e.RowIndex).Cells("id_penulis_buku").Value.ToString()
            txt_nama_penulis.Text = DGV1.Rows(e.RowIndex).Cells("nama_penulis").Value.ToString()
            dt_ttl_penulis.Value = DGV1.Rows(e.RowIndex).Cells("ttl_penulis").Value.ToString()
            txt_biografi_penulis.Text = DGV1.Rows(e.RowIndex).Cells("biografi_penulis").Value.ToString()
        End If
    End Sub
End Class