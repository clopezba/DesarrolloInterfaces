Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class eliminarMaterial

    Dim conexion As SqlConnection
    Dim material As String

    Private Sub crearMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        Dim consulta As String = "SELECT mat FROM Materiales WHERE num_mat=@num"
        Dim command As SqlCommand = New SqlCommand(consulta, conexion)
        command.Parameters.AddWithValue("@num", txtnum_mat.Text)

        Dim resultado As SqlDataReader = command.ExecuteReader()
        Try
            If resultado.Read() Then
                material = resultado("mat")
                resultado.Close()
                Return True
            Else
                resultado.Close()
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return False
        End Try

    End Function

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If buscarMaterial() Then
            Dim texto As String = "Número de Material: " + txtnum_mat.Text + vbCrLf + "Material: " + material
            Dim resultado As DialogResult = MessageBox.Show(texto, "¿Está seguro que desea eliminar el Material?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = DialogResult.Yes Then
                MessageBox.Show("Bien")
            End If

        Else
            MessageBox.Show("Debe rellenar correctamente el Número de Material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub eliminarMaterial()

    End Sub


    '+++++[[ ICONOS Y MENÚS ]]++++++
    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click, menu_inicio.Click
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


End Class