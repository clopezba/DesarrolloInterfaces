Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class listarMateriales

    Dim conexion As SqlConnection
    Dim rejilla As New DataView

    Private Sub listarMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load

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
        Dim adaptador As New SqlDataAdapter("SELECT m.*, g.pas, g.sec, g.stock FROM Materiales m JOIN Gest_Materiales g ON m.num_mat = g.num_mat", conexion)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        rejilla.Table = datos.Tables(0)
        rejillaMateriales.DataSource = rejilla

    End Sub

    Private Sub filtrarRegistros()
        Dim listado As String = ""

        If Not txtnum_mat.Text.Trim = Nothing Then
            If listado = "" Then
                listado = "num_mat = " + txtnum_mat.Text
            Else
                listado &= " AND num_mat = " + txtnum_mat.Text
            End If
        End If
        If Not txtmat.Text.Trim = Nothing Then
            If listado = "" Then
                listado = "mat LIKE '%" + txtmat.Text + "%'"
            Else
                listado &= " AND mat LIKE '%" + txtmat.Text + "%'"
            End If
        End If
        If Not cmbcat.SelectedItem = Nothing Then
            If listado = "" Then
                listado = "cat LIKE '%" + cmbcat.SelectedItem.ToString + "%'"
            Else
                listado &= " AND cat LIKE '%" + cmbcat.SelectedItem.ToString + "%'"
            End If
        End If



        rejilla.RowFilter = listado
    End Sub

    Private Sub btnlistar_Click(sender As Object, e As EventArgs) Handles btnlistar.Click
        filtrarRegistros()
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        For Each control As Control In pnlFiltros.Controls
            control.ResetText()
        Next
        cmbcat.SelectedItem = Nothing
        cmbsub_cat.SelectedItem = Nothing
        cmbpasillo.SelectedItem = Nothing
        For Each radio As RadioButton In pnlsec.Controls
            radio.Checked = False
        Next
    End Sub

    'Cambiar combobox de subcategorías según categoría seleccionada
    Private Sub cmbcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged
        Select Case cmbcat.SelectedItem
            Case "Hardware"
                cmbsub_cat.ResetText()
                cmbsub_cat.Items.Clear()
                cmbsub_cat.Items.AddRange(New String() {"Equipo", "Periféricos"})
            Case "Software"
                cmbsub_cat.ResetText()
                cmbsub_cat.Items.Clear()
                cmbsub_cat.Items.AddRange(New String() {"Antivirus", "Servicio"})
        End Select
    End Sub

    '++++++++[[ ICONOS Y MENU ]]++++++++
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

    Private Sub menu_eliminar_Click(sender As Object, e As EventArgs) Handles menu_eliminar.Click
        Dim eliminar As New eliminarMaterial
        eliminar.Show()
        Me.Close()
    End Sub


End Class