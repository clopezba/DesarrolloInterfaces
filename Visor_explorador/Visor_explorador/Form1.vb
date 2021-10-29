Public Class Form1
    Friend WithEvents MiExplorador As WebBrowser
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiExplorador = New WebBrowser
        MiExplorador.Dock = DockStyle.Fill
        Me.Controls.Add(MiExplorador)
        MiExplorador.Navigate("https://www.google.es")
    End Sub
End Class
