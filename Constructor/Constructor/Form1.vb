Imports MisClases

Public Class Form1
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim MiTextBox As CajaTexto
        If pnl.Controls.Count > 9 Then Exit Sub
        MiTextBox = New CajaTexto
        MiTextBox.Top = pnl.Controls.Count * (MiTextBox.Height + 5)
        AddHandler MiTextBox.DoubleClick, AddressOf MiTexto
        pnl.Controls.Add(MiTextBox)
        MiTextBox.Name = "TextBox_" & pnl.Controls.Count
        lblContador.Text = "Nº de TextBox " & pnl.Controls.Count
    End Sub
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If pnl.Controls.Count = 0 Then Exit Sub
        pnl.Controls.RemoveAt(pnl.Controls.Count - 1)
        lblContador.Text = "Nº de TextBox " & pnl.Controls.Count
    End Sub
    Private Sub MiTexto(Objeto As Object, Evento As EventArgs)
        Dim MiTexto As TextBox = Objeto
        MessageBox.Show("Contenido de: " & MiTexto.Name & " --> " & MiTexto.Text)
    End Sub
End Class