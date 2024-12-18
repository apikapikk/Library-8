Imports System.Data.Odbc

Public Class DatabaseConnection
    Private Shared instance As DatabaseConnection = Nothing
    Private Shared ReadOnly lockObject As New Object()

    ' Menyimpan koneksi
    Private conn As OdbcConnection
    Private connectionString As String = "DSN=dbLibrary;UID=root;PWD=;"

    ' Konstruktor privat untuk menghindari instansiasi langsung
    Private Sub New()
        ' Kosongkan koneksi untuk pertama kali
        conn = Nothing
    End Sub

    ' Singleton pattern untuk mendapatkan instance tunggal dari DatabaseConnection
    Public Shared Function getInstance() As DatabaseConnection
        SyncLock lockObject
            If instance Is Nothing Then
                instance = New DatabaseConnection()
            End If
        End SyncLock
        Return instance
    End Function

    ' Fungsi untuk membuka koneksi
    Public Function openConnection() As OdbcConnection
        Try
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                conn = New OdbcConnection(connectionString)
                conn.Open()
            End If
            Return conn
        Catch ex As Exception
            Throw New Exception("Gagal membuka koneksi ke database: " & ex.Message)
        End Try
    End Function

    ' Fungsi untuk mendapatkan koneksi yang sudah dibuka
    Public Function getConnection() As OdbcConnection
        If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
            ' Pastikan koneksi terbuka sebelum digunakan
            Return openConnection()
        End If
        Return conn
    End Function

    ' Fungsi untuk menutup koneksi
    Public Sub closeConnection()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            ' Penanganan error ketika menutup koneksi
            Throw New Exception("Gagal menutup koneksi: " & ex.Message)
        End Try
    End Sub
End Class
