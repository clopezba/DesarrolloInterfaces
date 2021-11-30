Public Class ProveedeoresProductos
    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProveedoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet1)

    End Sub

    Private Sub ProveedeoresProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NeptunoDataSet1.Productos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.NeptunoDataSet1.Proveedores)

    End Sub
End Class