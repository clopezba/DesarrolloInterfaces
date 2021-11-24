Public Class Form1

    Dim Canal As Integer = FreeFile()
    Dim Archivo As String
    Dim Nreg As Integer
    Dim AReg As Integer
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrimero.Click
        Cerrar()
        Abrir()
    End Sub
    Sub Cerrar()
        FileClose(Canal)
        Nreg = 0
    End Sub
    Sub Abrir()
        FileOpen(Canal, Archivo, OpenMode.Input)
        Mostrar()
    End Sub
    Sub Mostrar()
        If EOF(Canal) Then mensaje("Fin de fichero") : Exit Sub
        Input(Canal, Me.CNombre.Text)
        Input(Canal, Me.CApellidos.Text)
        Input(Canal, Me.CFecha.Text)
        Nreg += 1
        Me.LREG.Text = Nreg
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim MiAbrir As New OpenFileDialog
        MiAbrir.ShowDialog()
        If MiAbrir.FileName = "" Then Me.Dispose()
        Archivo = MiAbrir.FileName
        Abrir()
    End Sub

    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        Mostrar()
    End Sub
    Sub mensaje(ByVal Texto As String)
        MsgBox(Texto, MsgBoxStyle.Exclamation)
    End Sub

    Private Sub BUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUltimo.Click
        Do While Not EOF(Canal)
            Mostrar()
        Loop
    End Sub

    Private Sub BAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnterior.Click
        Dim n As Integer
        If Nreg = 1 Then mensaje("Estas en el primer registro") : Exit Sub
        AReg = Nreg - 1
        Cerrar()
        Abrir()
        For n = 1 To AReg
            Mostrar()
        Next

    End Sub
End Class
