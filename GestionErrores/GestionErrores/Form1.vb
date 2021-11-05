Public Class Form1
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        On Error GoTo GestionErr 'Antigua forma de tratar errores | *

        'AbrirFichero.InitialDirectory = My.Application.Info.DirectoryPath 'Asignamos directorio inicial, donde se encuentra la app
        'AbrirFichero.Filter = "Todos los archivos|*.*"
        'AbrirFichero.ShowDialog() 'Exponemos el objeto OpenFileDialog

        With AbrirFichero
            .InitialDirectory = My.Application.Info.DirectoryPath
            .Filter = "Todos los archivos|*.*|Imágenes|*.bmp; *.jpg|Iconos| *.ico"
            .ShowDialog()
        End With

        '-------------------------------------------------
        'Try
        picbImagen.Image = Image.FromFile(AbrirFichero.FileName)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Devuelve el error que se produce

        'End Try

        '-------------------------------------------------
        Exit Sub 'Si no hay error, no llegará a la GestionErr | *

GestionErr: 'Etiqueta de entrada a la línea de codificación | *
        MessageBox.Show("Error en la carga del fichero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) '*
    End Sub
End Class
