Public Class MDI_y_Menues
    Dim contImagen As Integer = 0
    Dim contTexto As Integer = 0


    Private Sub MDI_y_Menues_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim MiReloj As New Timer
        MiReloj.Interval = 1000
        MiReloj.Enabled = True
        AddHandler MiReloj.Tick, AddressOf MiReloj_Tick
    End Sub
    Private Sub MiReloj_Tick(sender As Object, e As EventArgs)
        Dim fecha As Date = Date.Now
        Dim hora As String = Now().ToLongTimeString
        lblFecha.Text = fecha.ToLongDateString + " -- " + hora
    End Sub


    Private Sub ImágenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImágenesToolStripMenuItem.Click


        If Me.MdiChildren.Length > 0 Then
            If ActiveMdiChild.Text <> "Imagen" Then
                Dim MiImagen As New PictureBox
                MiImagen.Dock = DockStyle.Fill

                Dim cuadroImagen As New Form
                cuadroImagen.Controls.Add(MiImagen)
                cuadroImagen.MdiParent = Me
                cuadroImagen.Text = "Imagen"
                cuadroImagen.Show()

                ImágenesToolStripMenuItem.Enabled = False
            End If
        End If


    End Sub

    Private Sub TextosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextosToolStripMenuItem.Click


        If ActiveMdiChild.Text <> "Texto" Then
                Dim MiCaja As New RichTextBox
                MiCaja.Multiline = True
                MiCaja.Dock = DockStyle.Fill

                Dim cuadroTexto As New Form
                cuadroTexto.Controls.Add(MiCaja)
                cuadroTexto.MdiParent = Me
                cuadroTexto.Text = "Texto"
                cuadroTexto.Show()
                TextosToolStripMenuItem.Enabled = False
            End If


    End Sub
    Private Sub CerrarPizarraActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarPizarraActivaToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then Exit Sub
        If ActiveMdiChild.Text = "Imagen" Then
            ImágenesToolStripMenuItem.Enabled = True
            'contImagen = 0
        Else
            TextosToolStripMenuItem.Enabled = True
            'contTexto = 0
        End If
        ActiveMdiChild.Close()
    End Sub
    Private Sub CerrarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasToolStripMenuItem.Click
        For Each MiVentana As Form In MdiChildren
            MiVentana.Close()
        Next
        ImágenesToolStripMenuItem.Enabled = True
        TextosToolStripMenuItem.Enabled = True
        'contImagen = 0
        'contTexto = 0
    End Sub

    'Salir de la aplicación
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
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

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        MessageBox.Show("Ayuda sin instalar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class