Imports System.ComponentModel

Public Class Registrar
    Dim Archivo As String
    Dim Canal As Integer = FreeFile()
    Dim Nreg As Integer
    'Private Sub AñadirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirToolStripMenuItem.Click
    '    Dim MiAbrir As New OpenFileDialog
    '    MiAbrir.Title = "Añadir datos en..."
    '    MiAbrir.ShowDialog()
    '    If MiAbrir.FileName = "" Then Exit Sub
    '    Archivo = MiAbrir.FileName
    '    FileOpen(Canal, Archivo, OpenMode.Append)
    '    PBotones.Visible = True

    'End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLimpiar.Click
        limpiar()
        CNombre.Focus()
    End Sub

    Private Sub BRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRegistrar.Click
        Write(Canal, CNombre.Text)
        Write(Canal, CApellidos.Text)
        Write(Canal, CFecha.Text)
        limpiar()
        CNombre.Focus()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        FileClose(Canal)
        Me.Dispose()
    End Sub
    Sub limpiar()
        CNombre.Clear()
        CApellidos.Clear()
        CFecha.Clear()
    End Sub

    'Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
    '    Dim MiAbrir As New SaveFileDialog
    '    MiAbrir.Title = "Nuevo Archivo de datos..."
    '    MiAbrir.ShowDialog()
    '    If MiAbrir.FileName = "" Then Exit Sub
    '    Archivo = MiAbrir.FileName
    '    FileOpen(Canal, Archivo, OpenMode.Output) 'Sobreescritura, borro todo y empiezo de nuevo sobre el mismo fichero
    '    PBotones.Visible = True
    'End Sub

    'Juntamos los dos métodos en uno, de una forma más limpia
    Private Sub ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirToolStripMenuItem.Click, NuevoToolStripMenuItem.Click
        Dim MiOpcion As ToolStripMenuItem = sender
        Dim Titulo As String = ""
        Select Case MiOpcion.Tag
            Case 8
                Titulo = "Añadir datos en..."
            Case 2
                Titulo = "Nuevo archivo de datos..."
        End Select
        ModoApertura(MiOpcion.Tag, Titulo)

    End Sub
    Sub ModoApertura(Modo As Integer, Texto As String)
        Dim MiAbrir As New OpenFileDialog
        MiAbrir.Title = Texto
        MiAbrir.ShowDialog()
        If MiAbrir.FileName = "" Then Exit Sub
        Archivo = MiAbrir.FileName
        FileOpen(Canal, Archivo, Modo)
        PBotones.Visible = True
    End Sub

    Private Sub Registrar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FileClose(Canal)
    End Sub
End Class