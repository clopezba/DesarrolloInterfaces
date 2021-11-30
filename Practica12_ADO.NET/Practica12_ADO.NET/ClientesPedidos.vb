Public Class ClientesPedidos
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NeptunoDataSet1)

    End Sub

    Private Sub ClientesPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.NeptunoDataSet1.Pedidos)
        'TODO: esta línea de código carga datos en la tabla 'NeptunoDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.NeptunoDataSet1.Clientes)

    End Sub
End Class