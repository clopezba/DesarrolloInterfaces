Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AbrirCajaTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaTextoToolStripMenuItem.Click
        'Dim MiCaja As New RichTextBox
        'MiCaja.Multiline = True
        'MiCaja.Top = 200
        'Me.Controls.Add(MiCaja)
        'MiCaja.Dock = DockStyle.Fill

        'RichTextBox1.Visible = True
    End Sub


    'Añadir ventanas hijas al contenedor padre
    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click
        Dim MiHijo As New Hijo
        MiHijo.MdiParent = Me
        MiHijo.Show()
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
    Private Sub CerraVentanaActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerraVentanaActivaToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub
End Class
