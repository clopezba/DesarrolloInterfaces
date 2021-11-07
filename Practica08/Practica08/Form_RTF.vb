Public Class Form_RTF
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        rtbTexto.Clear()
    End Sub

    Private Sub InsertarDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDesdePortapapelesToolStripMenuItem.Click
        rtbTexto.Paste()
    End Sub
End Class