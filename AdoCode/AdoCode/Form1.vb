Public Class Form1
    Dim MiAdaptador As OleDbDataAdapter 'No lo construyo todavía porque no tengo los datos que darle
    Dim MiConexionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\Neptuno.mdb" 'String de conexión
    Dim MiConexion As New OleDbConnection(MiConexionString)

    Dim MiTablaDatos As New DataTable 'Construyo la tabla con métodos y propiedades del manejo de datos. Es el source del bindingSource

    Dim MiBindingSource As New BindingSource

    Dim MiConstructor As New OleDbCommandBuilder 'Constructor que lee datos del adaptador. El adaptador puede leer del constructor lo que le de.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            MiConexion.Open() 'Comprobar que la conexión se realiza correctamente
            MessageBox.Show("Conexión exitosa")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        Dim MiSQL As String = "Select * from Productos"
        MiAdaptador = New OleDbDataAdapter(MiSQL, MiConexion)
        Try
            MiAdaptador.Fill(MiTablaDatos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MiConstructor.DataAdapter = MiAdaptador 'Genera comandos
        MiAdaptador.UpdateCommand = MiConstructor.GetUpdateCommand 'Para poder utilizar el comando Update (select ya lo tiene)
        MiAdaptador.DeleteCommand = MiConstructor.GetDeleteCommand 'Comando Delete
        MiAdaptador.InsertCommand = MiConstructor.GetInsertCommand 'Comando Insert

        'Enlazamos datos a los elementos del Form
        MiBindingSource.DataSource = MiTablaDatos
        MiBNavigator.BindingSource = MiBindingSource
        MiRejilla.DataSource = MiBindingSource
        enlaceDBControl()
    End Sub
    '
    Sub enlaceDBControl()
        txtProducto.DataBindings.Add(New Binding("Text", MiBindingSource, "NombreProducto"))
    End Sub

    'Guardar las modificaciones que se hagan en la BD
    Sub actualizar()
        Dim Nreg As Integer 'Contador de registros actualizados
        Try
            Nreg = MiAdaptador.Update(MiTablaDatos)
            MessageBox.Show("Nº de registros actualizados " & Nreg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Botón de guardado
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        actualizar()
    End Sub
End Class
