
Public Class Secuenciales
    Dim Canal As Integer = FreeFile() 'Nos da un canal que esté libre
    Dim Archivo As String 'Path, el literal de todos los archivos
    Dim Nreg As Integer
    Dim AReg As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrimero.Click
        Cerrar() 'El puntero de lectura se quedará el primero
        Abrir() 'Vuelve a abrir y carga desde el principio
    End Sub

    Sub Cerrar()
        FileClose(Canal)
        Nreg = 0
    End Sub

    Sub Abrir()
        Try
            FileOpen(Canal, Archivo, OpenMode.Input)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Mostrar()
    End Sub

    Sub Mostrar()
        If EOF(Canal) Then mensaje("Fin de fichero") : Exit Sub
        Try
            Input(Canal, Me.CNombre.Text)
            Input(Canal, Me.CApellidos.Text)
            Input(Canal, Me.CFecha.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Nreg += 1
        Me.LREG.Text = Nreg
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim MiAbrir As New OpenFileDialog
        MiAbrir.Filter = "Archivos de Texto (*.txt)|*.txt"
        MiAbrir.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        MiAbrir.Title = "Abrir Ficheros Secuenciales"
        MiAbrir.ShowDialog()
        If MiAbrir.FileName = "" Then Dispose() : Exit Sub
        Archivo = MiAbrir.FileName
        Abrir()
    End Sub

    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        Mostrar()
    End Sub
    Sub mensaje(ByVal Texto As String)
        MsgBox(Texto, MsgBoxStyle.Exclamation, "Mensajes del Fichero")
    End Sub

    Private Sub BUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUltimo.Click
        Do While Not EOF(Canal)
            Mostrar()
        Loop
    End Sub

    Private Sub BAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnterior.Click
        Dim n As Integer
        If Nreg = 1 Then mensaje("Estas en el primer registro") : Exit Sub
        AReg = Nreg - 2
        Cerrar()
        Abrir()
        For n = 1 To AReg
            Mostrar()
        Next
    End Sub
End Class
