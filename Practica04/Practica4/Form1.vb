Public Class Form1
    'Añadir elementos a la lista
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) _
        Handles btnColor.Click, btnMarcas.Click, btnModelo.Click, btnPrecio.Click
        '-->No se puedan ingresar líneas en blanco, ni espacios
        'If txtColores.Text.Trim = "" Or ltbxColores.Items.IndexOf(txtColores.Text) <> -1 Then Exit Sub

        '-->Si ya está en la lista, no se pone
        'If ltbxColores.Items.IndexOf(txtColores.Text) <> -1 Then Exit Sub

        '===========================================
        '-->Agrupamos las dos líneas anteriores en un único condicional
        'If txtColores.Text.Trim = "" Or ltbxColores.Items.IndexOf(txtColores.Text) <> -1 Then Exit Sub

        '-->Añadir lo que pongamos en el cuadro de texto a la lista
        'ltbxColores.Items.Add(txtColores.Text)

        '===========================================
        '-->Mismo ejercicio con punteros y elementos relacionados
        Dim MiBoton As Button = sender
        Dim MiTexto As TextBox = MiBoton.Tag
        Dim MiLista As ListBox = MiTexto.Tag

        If MiTexto.Text.Trim = "" Or MiLista.Items.IndexOf(MiTexto.Text) <> -1 Then Exit Sub
        MiLista.Items.Add(MiTexto.Text)

        '-->Limpiar caja texto
        'MiTexto.Clear()

        '-->Limpiar caja texto 2
        MiTexto.Text = ""
        MiTexto.Focus()

    End Sub

    'Borrar el elemento seleccionado de la lista al pulsar el botón correspondiente
    Private Sub btnBorrCol_Click(sender As Object, e As EventArgs) Handles btnBorrCol.Click, btnBorrMarca.Click
        Dim MiBoton As Button = sender
        Dim MiLista As ListBox = MiBoton.Tag
        MiLista.Items.Remove(MiLista.SelectedItem)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        RelacionaListas()
    End Sub

    'Relacionamos los tres elementos de las listas entre sí para poder utilizar el mismo procedimiento
    'con todas al pulsar el botón
    Private Sub RelacionaListas()
        btnColor.Tag = txtColores
        txtColores.Tag = ltbxColores
        ltbxColores.Tag = btnColor

        btnMarcas.Tag = txtMarcas
        txtMarcas.Tag = ltbxMarcas
        ltbxMarcas.Tag = btnMarcas

        btnModelo.Tag = txtModelo
        txtModelo.Tag = ltbxModelo
        ltbxModelo.Tag = btnModelo

        btnPrecio.Tag = txtPrecio
        txtPrecio.Tag = ltbxPrecio
        ltbxPrecio.Tag = btnPrecio

        btnBorrCol.Tag = ltbxColores
        btnBorrMarca.Tag = ltbxMarcas
    End Sub

    'Ingresar item al pulsar Intro
    Private Sub txtColores_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtColores.KeyPress, txtMarcas.KeyPress, txtModelo.KeyPress, txtPrecio.KeyPress
        Dim MiTexto As TextBox = sender
        Dim MiLista As ListBox = MiTexto.Tag
        Dim MiBoton As Button = MiLista.Tag
        If e.KeyChar = Chr(13) Then
            e.Handled = True 'Quitar sonido cada vez que demos a Intro
            btnIngresar_Click(MiBoton, New EventArgs)
        End If
    End Sub
End Class
