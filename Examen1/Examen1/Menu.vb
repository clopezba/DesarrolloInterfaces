Public Class Menu
    'Fecha y hora
    Private Sub reloj_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        Dim fecha As Date = Date.Now
        Dim hora As String = Now().ToLongTimeString
        txtFecha.Text = fecha.ToLongDateString + " " + hora
    End Sub
    'Abrir cuadro de texto
    Private Sub AbrirTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirTextoToolStripMenuItem.Click
        Static cont As Integer = 1
        Dim MiCaja As New RichTextBox
        MiCaja.Multiline = True
        MiCaja.Dock = DockStyle.Fill

        Dim cuadroTexto As New Form
        cuadroTexto.Controls.Add(MiCaja)
        cuadroTexto.MdiParent = Me
        cuadroTexto.Text = "Formulario hijo para texto RTF -- Nº" & cont
        cuadroTexto.Show()
        cont += 1
    End Sub
    'Abrir cuadro de imagen
    Private Sub AbrirCuadroImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCuadroImagenToolStripMenuItem.Click
        Static cont As Integer = 1
        Dim MiImagen As New PictureBox
        MiImagen.Dock = DockStyle.Fill

        Dim cuadroImagen As New Form
        cuadroImagen.Controls.Add(MiImagen)
        cuadroImagen.MdiParent = Me
        cuadroImagen.Text = "Formulario hijo para imagen -- Nº" & cont
        cuadroImagen.Show()
        cont += 1
    End Sub


    'Modificar la posición de las ventanas hijas
    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub


    'Cerrar la ventana hija activa
    Private Sub CerraVentanaActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActivaToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub

    'Cerrar todas las ventanas
    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasToolStripMenuItem.Click
        For Each MiVentana As Form In MdiChildren
            MiVentana.Close()
        Next
    End Sub

    'Salir de la aplicación
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub


End Class