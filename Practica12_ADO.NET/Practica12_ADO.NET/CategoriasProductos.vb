Public Class CategoriasProductos
    Private Sub CategoríasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoríasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoríasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet1)

    End Sub

    Private Sub CategoriasProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NeptunoDataSet1.Productos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Categorías' Puede moverla o quitarla según sea necesario.
        Me.CategoríasTableAdapter.Fill(Me.NeptunoDataSet1.Categorías)

    End Sub
End Class