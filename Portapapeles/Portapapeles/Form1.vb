Public Class Form1
    Private Sub pbxImagen_DoubleClick(sender As Object, e As EventArgs) Handles pbxImagen.DoubleClick
        Dim MiPictureBox As PictureBox = sender
        MiPictureBox.Image = Clipboard.GetImage()
    End Sub

    Private Sub rtbxTexto_DoubleClick(sender As Object, e As EventArgs) Handles rtbxTexto.DoubleClick
        Dim MiRTexto As RichTextBox = sender

    End Sub
End Class
