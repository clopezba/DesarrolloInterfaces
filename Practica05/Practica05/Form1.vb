Public Class Form1
    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarControles()
    End Sub

    Private Sub InicializarControles()
        txtIzq.Tag = ltbxIzq
        btnBorr_lisIzq.Tag = ltbxIzq
        txtCentro.Tag = ltbxCentro
        btnBorr_lisCentro.Tag = ltbxCentro
        txtDcha.Tag = ltbxDcha
        btnBorr_lisDcha.Tag = ltbxDcha
    End Sub

    'Introducir items a la lista al presionar Enter evitando repetir o introducir espacio en blanco
    Private Sub txtIzq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIzq.KeyPress, txtCentro.KeyPress, txtDcha.KeyPress
        Dim MiTexto As TextBox = sender
        Dim MiListaEntrada As ListBox = MiTexto.Tag
        If MiTexto.Text.Trim = "" Or MiListaEntrada.Items.IndexOf(MiTexto.Text) <> -1 Then
            MiTexto.Clear()
            Exit Sub
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True 'Quitar el sonido del sistema
            MiListaEntrada.Items.Add(MiTexto.Text.Trim)
            MiTexto.Clear()
            MiTexto.Focus() 'La posición del foco se quedará ahí
        End If
    End Sub

    'Borrar todos los items de la lista
    Private Sub btnBorr_lisIzq_Click(sender As Object, e As EventArgs) Handles btnBorr_lisIzq.Click, btnBorr_lisCentro.Click, btnBorr_lisDcha.Click
        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Clear()
    End Sub

    'Mover un item de una lista a otra
    Private Sub IntercambioListas()
        Do While MiListaOrigen.SelectedItems.Count
            If MiListaDestino.Items.IndexOf(MiListaOrigen.SelectedItems(0)) <> -1 Then Exit Sub
            MiListaDestino.Items.Add(MiListaOrigen.SelectedItems(0))
            MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems(0))
        Loop

        'Si solo se puede seleccionar un item:
        'If MiListaDestino.Items.IndexOf(MiListaOrigen.SelectedItems) <> -1 Then Exit Sub
        'MiListaDestino.Items.Add(MiListaOrigen.SelectedItems)
        'MiListaOrigen.Items.Remove(MiListaOrigen.SelectedItems)
    End Sub

    'Enviar los items seleccionados a la otra lista haciendo doble click
    Private Sub ltbxIzq_DoubleClick(sender As Object, e As EventArgs) Handles ltbxIzq.DoubleClick, ltbxCentro.DoubleClick, ltbxDcha.DoubleClick
        Dim MiLista As ListBox = sender
        If MiLista.SelectedItems.Count = 0 Then Exit Sub
        Select Case MiLista.Name
            Case "ltbxIzq"
                MiListaOrigen = ltbxIzq
                MiListaDestino = ltbxCentro
            Case "ltbxCentro"
                MiListaOrigen = ltbxCentro
                MiListaDestino = ltbxDcha
            Case "ltbxDcha"
                MiListaOrigen = ltbxDcha
                MiListaDestino = ltbxIzq
        End Select
    End Sub

    'Enviar y recibir los items seleccionados pulsando un botón de envío y otro de regreso
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click, btnRecibir.Click, btnRecibir2.Click, btnEnviar2.Click
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "btnEnviar"
                MiListaOrigen = ltbxIzq
                MiListaDestino = ltbxCentro
            Case "btnRecibir"
                MiListaOrigen = ltbxCentro
                MiListaDestino = ltbxIzq
            Case "btnEnviar2"
                MiListaOrigen = ltbxCentro
                MiListaDestino = ltbxDcha
            Case "btnRecibir2"
                MiListaOrigen = ltbxDcha
                MiListaDestino = ltbxCentro
        End Select
        If MiListaOrigen.SelectedItems.Count = 0 Then
            For i As Integer = 0 To MiListaOrigen.Items.Count - 1
                MiListaOrigen.SetSelected(i, True)
            Next i
        End If
        IntercambioListas()
    End Sub

    'Drag & drop: AllowDrop=true
    Private Sub ltbxIzq_MouseDown(sender As Object, e As MouseEventArgs) Handles ltbxIzq.MouseDown, ltbxCentro.MouseDown, ltbxDcha.MouseDown
        MiListaOrigen = sender
        Select Case MiListaOrigen.Name
            Case "ltbxIzq"
                MiListaDestino = ltbxCentro
            Case "ltbxCentro"
                MiListaDestino = ltbxDcha
            Case "ltbxDcha"
                MiListaDestino = ltbxIzq
        End Select
        'If e.Clicks = 2 Then
        '    IntercambioListas()
        '    Exit Sub
        'End If
        MiListaOrigen.DoDragDrop(MiListaOrigen.Text, DragDropEffects.Move)
    End Sub

    Private Sub ltbxIzq_DragOver(sender As Object, e As DragEventArgs) Handles ltbxIzq.DragOver, ltbxCentro.DragOver, ltbxDcha.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub ltbxIzq_DragDrop(sender As Object, e As DragEventArgs) Handles ltbxIzq.DragDrop, ltbxCentro.DragDrop, ltbxDcha.DragDrop
        MiListaDestino = sender
        IntercambioListas()
    End Sub
End Class
