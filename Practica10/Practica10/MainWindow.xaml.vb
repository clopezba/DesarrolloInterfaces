Class MainWindow
    Dim MiListaOrigen As ListBox
    Dim MiListaDestino As ListBox
    Private Sub MainWindow_Load(sender As Object, e As RoutedEventArgs)
        InicializarControles()
    End Sub
    Private Sub InicializarControles()
        txtIzq.Tag = listaIzq
        btnIzq.Tag = listaIzq
        txtCen.Tag = listaCen
        btnCen.Tag = listaCen
        txtDer.Tag = listaDer
        btnDer.Tag = listaDer
    End Sub

    'Introducir items a la lista al presionar Enter evitando repetir o introducir espacio en blanco
    Private Sub txtIzq_KeyPress(sender As Object, e As KeyEventArgs
                                )
        Dim MiTexto As TextBox = sender
        Dim MiListaEntrada As ListBox = MiTexto.Tag
        If MiTexto.Text.Trim = "" Or MiListaEntrada.Items.IndexOf(MiTexto.Text) <> -1 Then
            MiTexto.Clear()
            Exit Sub
        End If
        If e.Key = Key.Enter Then
            'e.Handled = True 'Quitar el sonido del sistema
            MiListaEntrada.Items.Add(MiTexto.Text.Trim)
            MiTexto.Clear()
            MiTexto.Focus() 'La posición del foco se quedará ahí
        End If
    End Sub

    'Borrar todos los items de la lista
    Private Sub btnBorr_Click(sender As Object, e As RoutedEventArgs)
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
    End Sub

    'Enviar y recibir los items seleccionados pulsando un botón de envío y otro de regreso
    Private Sub btnEnviar_Click(sender As Object, e As RoutedEventArgs) Handles btnEnviar.Click, btnRecibir.Click, btnRecibir2.Click, btnEnviar2.Click
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "btnEnviar"
                MiListaOrigen = listaIzq
                MiListaDestino = listaCen
            Case "btnRecibir"
                MiListaOrigen = listaCen
                MiListaDestino = listaIzq
            Case "btnEnviar2"
                MiListaOrigen = listaCen
                MiListaDestino = listaDer
            Case "btnRecibir2"
                MiListaOrigen = listaDer
                MiListaDestino = listaCen
        End Select
        'If MiListaOrigen.SelectedItems.Count = 0 Then
        '    For i As Integer = 0 To MiListaOrigen.Items.Count - 1
        '        MiListaOrigen.SelectedItem(i)
        '    Next i
        'End If
        IntercambioListas()
    End Sub
End Class
