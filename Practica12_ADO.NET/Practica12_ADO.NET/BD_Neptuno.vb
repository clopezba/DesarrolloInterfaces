Public Class BD_Neptuno
    'Mostrar ventana con datos de Clientes y Pedidos
    Private Sub VerClientesYPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerClientesYPedidosToolStripMenuItem.Click
        Dim clientesPedidos As New ClientesPedidos
        clientesPedidos.MdiParent = Me
        clientesPedidos.Show()
    End Sub

    'Mostrar ventana con datos de Categorías y Productos
    Private Sub VerCategoríasYProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerCategoríasYProductosToolStripMenuItem.Click
        Dim categoriasProductos As New CategoriasProductos
        categoriasProductos.MdiParent = Me
        categoriasProductos.Show()
    End Sub

    'Mostrar ventana con datos de Proveedores y Productos
    Private Sub VerProveedoresYProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerProveedoresYProductosToolStripMenuItem.Click
        Dim proveedoresProductos As New ProveedeoresProductos
        proveedoresProductos.MdiParent = Me
        proveedoresProductos.Show()
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
    Private Sub CerrarVentanaActivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarVentanaActivaToolStripMenuItem.Click
        If Me.MdiChildren.Length = 0 Then Exit Sub
        ActiveMdiChild.Close()
    End Sub

    'Cerrar todas las ventanas
    Private Sub CerrarTodasLasVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodasLasVentanasToolStripMenuItem.Click
        For Each MiVentana As Form In MdiChildren
            MiVentana.Close()
        Next
    End Sub

    'Salir de la aplicación
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
