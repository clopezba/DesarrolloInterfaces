Public Class Form1

    Private Sub TextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextoToolStripMenuItem.Click, ToolStripButton1.Click
        Dim MiTexto As New Form_RTF
        'Dim cont As Integer
        MiTexto.MdiParent = Me
        MiTexto.Text = "Formulario Hijo para Texto RTF -- Nº"
        MiTexto.Show()
    End Sub
End Class
