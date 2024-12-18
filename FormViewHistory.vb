Public Class FormViewHistory
    Private Sub FormViewHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer.RefreshReport()
    End Sub
End Class