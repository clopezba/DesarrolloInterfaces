Public Class Form1
    'Friend WithEvents Mireloj As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mireloj = New Timer
        Mireloj.Interval = 1000
        Mireloj.Enabled = True
    End Sub

    Private Sub Mireloj_Tick(sender As Object, e As EventArgs) Handles Mireloj.Tick
        lblReloj.Text = Now().ToLongTimeString
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        DialogoAbrir.ShowDialog()

    End Sub
End Class
