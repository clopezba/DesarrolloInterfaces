Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class crearMaterial

    Dim conexion As SqlConnection
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

        obtenerNumeroMaterial()
    End Sub

    'Recibe de la BD el número del último material registrado
    Private Sub obtenerNumeroMaterial()
        Dim ultimo As Integer = 0
        Dim consultaNum As String = "select IDENT_CURRENT('Materiales') as ultimoMat"
        Dim comando As SqlCommand = New SqlCommand(consultaNum, conexion)
        Dim num As SqlDataReader = comando.ExecuteReader()

        If num.Read() = True Then
            Try
                ultimo = num("ultimoMat")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            txtnum_mat.Text = Format(ultimo + 1, "00000000")
        End If
        num.Close()
    End Sub

    Private Sub cmbcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged
        Select Case cmbcat.SelectedIndex
            Case 0

        End Select

    End Sub



    Private Sub crearMaterial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If modificarMaterial.Visible = False And listarMateriales.Visible = False And eliminarMaterial.Visible = False Then
            inicio.Visible = True
        End If
    End Sub
    '+++++++++FUNCIONES MENÚ E ICONOS+++++++++++
    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click
        inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub menu_modif_Click(sender As Object, e As EventArgs) Handles menu_modif.Click
        Me.Visible = False
        If modificarMaterial.Visible = False Then
            modificarMaterial.Visible = True
        Else
            modificarMaterial.ShowDialog()
        End If
    End Sub

    Private Sub menu_listar_Click(sender As Object, e As EventArgs) Handles menu_listar.Click
        Me.Visible = False
        If listarMateriales.Visible = False Then
            listarMateriales.Visible = True
        Else
            listarMateriales.ShowDialog()
        End If
    End Sub
    Private Sub menu_eliminar_Click(sender As Object, e As EventArgs) Handles menu_eliminar.Click
        Me.Visible = False
        If eliminarMaterial.Visible = False Then
            eliminarMaterial.Visible = True
        Else
            eliminarMaterial.ShowDialog()
        End If
    End Sub


End Class