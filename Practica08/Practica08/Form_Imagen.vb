Public Class Form_Imagen
    Private Sub BorrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        PicBox.Image = Nothing
    End Sub

    Private Sub InsertarDesdePortapapelesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDesdePortapapelesToolStripMenuItem.Click
        Dim MiImagen As New PictureBox
        MiImagen = PicBox
        MiImagen.Image = Clipboard.GetImage()
    End Sub
End Class