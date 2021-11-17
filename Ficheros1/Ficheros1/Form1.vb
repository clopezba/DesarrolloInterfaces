Imports System.IO
Public Class Form1
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim MiDialogOpen As New OpenFileDialog
        MiDialogOpen.InitialDirectory = My.Application.Info.DirectoryPath
        MiDialogOpen.ShowDialog()

        Try
            Dim MiFichero As New StreamReader(MiDialogOpen.FileName)
            txtTexto.Text = MiFichero.ReadToEnd
            'Tenemos que cerrar el flujo porque se queda abierto un tiempo
            MiFichero.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim MiDialogGuardar As New SaveFileDialog
        MiDialogGuardar.InitialDirectory = My.Application.Info.DirectoryPath
        MiDialogGuardar.ShowDialog()

        Dim MiFichero As New StreamWriter(MiDialogGuardar.FileName)
        MiFichero.Write(txtTexto.Text)
        MiFichero.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtTexto.Clear()
    End Sub

    Private Sub btnCargarVB_Click(sender As Object, e As EventArgs) Handles btnCargarVB.Click
        'Da un entero único que será un canal. Sobre ese canal abriremos el fichero
        Dim Canal As Integer = FreeFile()
        Dim MiFichero As String = "ficheros.txt"
        'MiFichero = Dir(MiFichero) 'Devuelve el nombre del  directorio, fichero o ruta 
        Dim Texto As String = ""
        Try
            FileOpen(Canal, MiFichero, OpenMode.Input, OpenAccess.Read) 'Ha cargado el fichero sobre el canal
            Do While Not EOF(Canal)
                Texto &= LineInput(Canal) & vbCrLf
            Loop
            txtTexto.Text = Texto
            FileClose(Canal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub btnGuardarVB_Click(sender As Object, e As EventArgs) Handles btnGuardarVB.Click
        Dim Canal As Integer = FreeFile()
        Dim MiFichero As String = "fichero.txt"
        FileOpen(Canal, MiFichero, OpenMode.Output, OpenAccess.Write)
        'WriteLine(Canal, txtTexto.Text) 'Añade comillas al inicio y fin de texto
        Write(Canal, txtTexto.Text) 'Nos pone además un punto al final de la línea
        FileClose(Canal)
    End Sub
End Class
