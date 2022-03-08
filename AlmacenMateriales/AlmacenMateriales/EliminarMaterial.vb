Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class eliminarMaterial

    Dim conexion As SqlConnection
    Dim material As String

    Private Sub eliminarMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim direcActual As String = Directory.GetCurrentDirectory()
        Dim directorio As String = Directory.GetParent(Directory.GetParent(direcActual).ToString()).ToString()

        'Establecer conexión con BD
        Dim conexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio & "\AlmacenMaterialesDB.mdf;Integrated Security=True;"
        conexion = New SqlConnection(conexionString)
        Try
            conexion.Open()
            Console.WriteLine("Conexión establecida")
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar. Error: " + ex.Message)
        End Try
    End Sub


    Private Function buscarMaterial()
        Dim materiales As Boolean = False
        Dim gest_materiales As Boolean = False

        Dim consulta As String = "SELECT mat FROM Materiales WHERE num_mat=@num"
        Dim command As SqlCommand = New SqlCommand(consulta, conexion)
        command.Parameters.AddWithValue("@num", txtnum_mat.Text)
        Dim resultado As SqlDataReader = command.ExecuteReader()

        Try
            If resultado.Read() Then
                material = resultado("mat")
                resultado.Close()
                materiales = True
            Else
                resultado.Close()
                materiales = False
            End If
        Catch ex As Exception
            Console.WriteLine("Error al leer la tabla Materiales: " + ex.Message)
        End Try

        Dim consultaGest As String = "SELECT pas FROM Gest_Materiales WHERE num_mat=@num"
        Dim commandGest As SqlCommand = New SqlCommand(consultaGest, conexion)
        commandGest.Parameters.AddWithValue("@num", txtnum_mat.Text)
        Dim result As SqlDataReader = commandGest.ExecuteReader()

        Try
            If result.Read() Then
                result.Close()
                gest_materiales = True
            Else
                result.Close()
                gest_materiales = False
            End If
        Catch ex As Exception
            Console.WriteLine("Error al leer la tabla Gest_Materiales: " + ex.Message)
        End Try

        If materiales And gest_materiales Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If buscarMaterial() Then
            Dim texto As String = "¿Está seguro que desea eliminar el Material?" + vbCrLf + "Número de Material: " + txtnum_mat.Text + vbCrLf + "Material: " + material
            Dim resultado As DialogResult = MessageBox.Show(texto, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            If resultado = DialogResult.OK Then
                eliminarMaterial()
            End If

        Else
            MessageBox.Show("Debe rellenar correctamente el Número de Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub eliminarMaterial()
        Dim eliminarGest As String = "DELETE FROM Gest_Materiales WHERE num_mat = @num"
        Dim comandoGest As SqlCommand = New SqlCommand(eliminarGest, conexion)
        comandoGest.Parameters.AddWithValue("@num", txtnum_mat.Text)

        Dim eliminarMat As String = "DELETE FROM Materiales WHERE num_mat = @num"
        Dim comandoMat As SqlCommand = New SqlCommand(eliminarMat, conexion)
        comandoMat.Parameters.AddWithValue("@num", txtnum_mat.Text)

        Try
            comandoGest.ExecuteNonQuery()
            comandoMat.ExecuteNonQuery()

            MessageBox.Show("Registro eliminado correctamente", "Registro borrado", MessageBoxButtons.OK)

            txtnum_mat.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("No se ha podido eliminar el registro", "Error en el borrado", MessageBoxButtons.OK)
            Console.WriteLine("Error al borrar los datos. Error: " + ex.Message)
        End Try

    End Sub
    Private Sub eliminarMaterial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            conexion.Close()
            Console.WriteLine("Desconectado de la base de datos")
        Catch ex As Exception
            Console.WriteLine("No se ha podido desconectar. Error: " + ex.Message)
        End Try
    End Sub

    '+++++[[ ICONOS Y MENÚS ]]++++++
    Private Sub menu_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click, menu_inicio.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub
    Private Sub menu_crear_Click(sender As Object, e As EventArgs) Handles menu_crear.Click
        Dim crear As New crearMaterial
        crear.Show()
        Me.Close()
    End Sub
    Private Sub menu_modif_Click(sender As Object, e As EventArgs) Handles menu_modif.Click
        Dim modif As New modificarMaterial
        modif.Show()
        Me.Close()
    End Sub

    Private Sub menu_listar_Click(sender As Object, e As EventArgs) Handles menu_listar.Click
        Dim listar As New listarMateriales
        listar.Show()
        Me.Close()
    End Sub

    '+++++++++[ NumMat SOLO NUMEROS NATURALES ]++++++++
    Private Sub txtnum_mat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum_mat.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class