Public Class FormMenu
    Private Sub btn_tambah_buku_Click(sender As Object, e As EventArgs) Handles btn_tambah_buku.Click
        Dim tambahBuku As New TambahBukuForm
        tambahBuku.ShowDialog()
    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click

    End Sub

    Private Sub btn_pengembalian_Click(sender As Object, e As EventArgs) Handles btn_pengembalian.Click
        Dim pemgembalian As New PengembalianForm
        pemgembalian.ShowDialog()
    End Sub

    Private Sub btn_peminjaman_Click(sender As Object, e As EventArgs) Handles btn_peminjaman.Click
        Dim peminjaman As New PeminjamanForm
        peminjaman.ShowDialog()
    End Sub

    Private Sub btrn_tambah_penulis_Click(sender As Object, e As EventArgs) Handles btrn_tambah_penulis.Click
        Dim tambahPenulis As New TambahPenulisForm
        tambahPenulis.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim daftarkanAnggota As New TambahAnggotaForm
        daftarkanAnggota.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim daftarkanPenerbit As New TambahPenerbitForm
        daftarkanPenerbit.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tambahRak As New TambahRakForm
        tambahRak.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tambahKategori As New TambahKategoriForm
        tambahKategori.ShowDialog()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
