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

    'Si se ha establecido el texto inicial en la propiedad del control, se pondrá automáticamente en el TextBox al cargarse el control
    Private Sub ControlUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiTexto.Text = Me.TextoInicial
    End Sub

    'Al pulsar el botón se añade un ítem (no repetido y sin espacios antes o después) a la lista
    Private Sub MiBoton_Click(sender As Object, e As EventArgs) Handles MiBoton.Click, btnBorrar.Click
        If MiTexto.Text.Trim = "" Or MiLista.Items.IndexOf(MiTexto.Text) <> -1 Then Exit Sub
        MiLista.Items.Add(MiTexto.Text.Trim)
        MiTexto.Clear()
        MiTexto.Focus()
    End Sub

    'Introducir items a la lista al presionar Enter
    Private Sub MiTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiTexto.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            MiBoton.PerformClick()
        End If
    End Sub

    'Borrar todos los items de la lista
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        MiLista.Items.Clear()
    End Sub

    'Drag & drop. Inicia una operación de arrastrar y soltar
    Private Sub MiLista_MouseDown(sender As Object, e As MouseEventArgs) Handles MiLista.MouseDown
        MiLista.DoDragDrop(MiLista, DragDropEffects.Copy)

    End Sub

    'Efecto que se produce cuando se arrastra un objeto sobre los límites del control
    Private Sub MiLista_DragOver(sender As Object, e As DragEventArgs) Handles MiLista.DragOver
        e.Effect = DragDropEffects.Copy
    End Sub

    'Completa una acción de arrastrar y soltar
    Private Sub MiLista_DragDrop(sender As Object, e As DragEventArgs) Handles MiLista.DragDrop, Me.DragDrop
        Dim origen As ListBox = e.Data.GetData(MiLista.GetType) 'Crea una lista con los datos de la de origen

        If Not MiLista.Equals(origen) Then
            'Controla que no se arrastre sin pulsar sobre un ítem
            Try
                If MiLista.Items.IndexOf(origen.SelectedItem) <> -1 Then Exit Sub
                MiLista.Items.Add(origen.SelectedItem)
                origen.Items.Remove(origen.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

End Class
