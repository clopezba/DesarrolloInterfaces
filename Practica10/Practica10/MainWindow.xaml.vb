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
    Private Sub txtIzq_KeyPress(sender As Object, e As KeyEventArgs)
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
        If MiListaOrigen.SelectedItems.Count = 0 Then
            MiListaOrigen.SelectAll()
        End If
        IntercambioListas()
    End Sub
    'Al hacer doble click sobre la lista, se pasan los items seleccionados a la lista siguiente
    Private Sub ltbxIzq_DoubleClick(sender As Object, e As MouseButtonEventArgs) Handles listaCen.MouseDoubleClick, listaDer.MouseDoubleClick, listaIzq.MouseDoubleClick
        Dim MiLista As ListBox = sender
        If MiLista.SelectedItems.Count = 0 Then Exit Sub
        Select Case MiLista.Name
            Case "listaIzq"
                MiListaOrigen = listaIzq
                MiListaDestino = listaCen
            Case "listaCen"
                MiListaOrigen = listaCen
                MiListaDestino = listaDer
            Case "listaDer"
                MiListaOrigen = listaDer
                MiListaDestino = listaIzq
        End Select
        IntercambioListas()
    End Sub

    'Drag&Drop Al pulsar una lista sin soltar y arrastrar hacia otra lista, se pasan los items seleccionados
    Private Sub ltbxIzq_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles listaIzq.MouseDown, listaCen.MouseDown, listaDer.MouseDown
        MiListaOrigen = sender
        Select Case MiListaOrigen.Name
            Case "listaIzq"
                MiListaDestino = listaCen
            Case "listaCen"
                MiListaDestino = listaDer
            Case "listaDer"
                MiListaDestino = listaIzq
        End Select
        If e.ClickCount = 2 Then
            IntercambioListas()
            Exit Sub
        Else
            If MiListaOrigen.SelectedItems.Count > 0 And e.LeftButton.Pressed Then
                DragDrop.DoDragDrop(MiListaOrigen, MiListaOrigen.SelectedItem.ToString, DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub ltbxIzq_DragDrop(sender As Object, e As DragEventArgs) Handles listaIzq.Drop, listaCen.Drop, listaDer.Drop
        MiListaDestino = sender
        IntercambioListas()
    End Sub

End Class
