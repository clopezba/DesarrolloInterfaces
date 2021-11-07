Public Class Form1
    Dim contTxt As Integer = 0
    Dim contImg As Integer = 0

    'Abrir formulario de RichTextFormat
    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click, ToolStripButton1.Click
        Dim MiTexto As New Form_RTF
        contTxt += 1
        MiTexto.MdiParent = Me
        MiTexto.Text = "Formulario Hijo para Texto RTF -- Nº" & contTxt
        MiTexto.Show()
    End Sub
    'Abrir formulario de Imagen
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click, ToolStripButton2.Click
        Dim MiImagen As New Form_Imagen
        contImg += 1
        MiImagen.MdiParent = Me
        MiImagen.Text = "Formulario Hijo para Imagen BMP -- Nº" & contImg
        MiImagen.Show()
    End Sub


    'Cerrar la ventana hija activa
    Private Sub CerrarVentanaActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActualToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub
    'Cerrar todas las ventanas
    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click, ToolStripButton3.Click
        Do While Me.MdiChildren.Length > 0
            ActiveMdiChild.Close()
        Loop
    End Sub
    'Salir de la aplicación
    Private Sub SalirDeLaAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDeLaAplicaciónToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Modificar la posición de las ventanas hijas
    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub CasacadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasacadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    'Ver formulario "Acerca de..."
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripButton4.Click
        Dim MiAbout As New About
        MiAbout.ShowDialog()
    End Sub

End Class
