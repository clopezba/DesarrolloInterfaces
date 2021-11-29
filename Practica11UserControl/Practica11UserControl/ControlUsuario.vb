Imports System.ComponentModel

Public Class ControlUsuario
    Private Texto As String 'El objeto no podrá acceder a este atributo, pero sí con el GET de la propiedad
    <Description("Propiedad nueva de texto")> 'Describe lo que venga después (la propiedad)
    Public Property TextoInicial() As String
        Get
            Return Texto
        End Get
        Set(value As String) 'Si la propiedad es de solo lectura, la parte SET desaparece
            Texto = value
        End Set
    End Property
    'Al pulsar el botón se añade un ítem (no repetido y sin espacios antes o después) a la lista
    Private Sub MiBoton_Click(sender As Object, e As EventArgs) Handles MiBoton.Click
        If MiTexto.Text.Trim = "" Or MiLista.Items.IndexOf(MiTexto.Text) <> -1 Then Exit Sub
        MiLista.Items.Add(MiTexto.Text.Trim)
        MiTexto.Clear()
    End Sub

    'Si se ha establecido el texto inicial en la propiedad del control, se pondrá automáticamente en el TextBox al cargarse el control
    Private Sub ControlUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiTexto.Text = Me.TextoInicial
    End Sub

    'Drag & drop. Inicia una operación de arrastrar y soltar
    Private Sub MiLista_MouseDown(sender As Object, e As MouseEventArgs) Handles MiLista.MouseDown
        MiLista.DoDragDrop(MiLista.Text, DragDropEffects.Move)
    End Sub

    'Efecto que se produce cuando se arrastra un objeto sobre los límites del control
    Private Sub MiLista_DragOver(sender As Object, e As DragEventArgs) Handles MiLista.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    'Completa una acción de arrastrar y soltar
    Private Sub MiLista_DragDrop(sender As Object, e As DragEventArgs) Handles MiLista.DragDrop
        Dim texto As Object = e.Data.GetData(DataFormats.Text)
        If texto.Trim = "" Or MiLista.Items.IndexOf(texto) <> -1 Then Exit Sub
        MiLista.Items.Add(texto)
    End Sub


End Class
