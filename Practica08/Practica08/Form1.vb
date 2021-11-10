Public Class Form1
    'Abrir formulario de RichTextFormat
    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click, ToolStripButton1.Click
        Static cont As Integer = 1
        Dim MiTexto As New Form_RTF
        MiTexto.MdiParent = Me
        MiTexto.Text = "Formulario Hijo para Texto RTF -- Nº" & cont
        MiTexto.Show()
        cont += 1
    End Sub
    'Abrir formulario de Imagen
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ImagenToolStripMenuItem.Click, ToolStripButton2.Click
        Static cont As Integer = 1
        Dim MiImagen As New Form_Imagen
        MiImagen.MdiParent = Me
        MiImagen.Text = "Formulario Hijo para Imagen BMP -- Nº" & cont
        MiImagen.Show()
        cont += 1
    End Sub

    'Ver formulario "Acerca de..."
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripButton4.Click
        Dim MiAbout As New About
        MiAbout.ShowDialog()
    End Sub

    'Cerrar la ventana hija activa
    Private Sub CerrarVentanaActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActualToolStripMenuItem.Click
        Try
            If Me.MdiChildren.Length > 0 Then
                ActiveMdiChild.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    'Cerrar todas las ventanas
    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click, ToolStripButton3.Click
        Try
            For Each MiVentana As Form In MdiChildren
                MiVentana.Close()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

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
End Class
