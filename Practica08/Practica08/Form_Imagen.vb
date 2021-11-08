Public Class Form_Imagen
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        PicBox.Image = Nothing
    End Sub

    Private Sub InsertarDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDesdePortapapelesToolStripMenuItem.Click
        PicBox.Image = Clipboard.GetImage()
    End Sub
End Class