Public Class Form1
    Private Sub ImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click
        Dim MiFormImagen As New Form_Imagen
        Dim MiImagen As Image = Nothing

        MiFormImagen.MdiParent = Me 'Asigno el contenedor padre
        AbrirFichero.ShowDialog() 'Lo que selecciono con este cuadro se llama FileName
        'MessageBox.Show(AbrirFichero.FileName)
        MiImagen = Image.FromFile(AbrirFichero.FileName)
        MiFormImagen.pctbxImagen.Image = MiImagen
        MiFormImagen.Show()

    End Sub

    Private Sub TextoRTFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoRTFToolStripMenuItem.Click
        Dim MiFormRTF As New Form_RTF
        MiFormRTF.MdiParent = Me
        AbrirFichero.ShowDialog() 'Abrir cuadro de diálogo para seleccionar el archivo
        MiFormRTF.rtbTexto.LoadFile(AbrirFichero.FileName) 'Cargar el archivo
        MiFormRTF.Show() 'Mostrar el formulario hijo
    End Sub
End Class
