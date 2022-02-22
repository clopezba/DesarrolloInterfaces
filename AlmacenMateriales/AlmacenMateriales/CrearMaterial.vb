Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class crearMaterial

    Dim conexion As SqlConnection
    Dim impVenta As Single

    Private Sub crearMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        fechafe_reg.Value = Date.Today
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
        Dim ultimo As Integer

        Dim consultaVacio As String = "select count(*) as cuenta from Materiales"
        Dim comandoVac As SqlCommand = New SqlCommand(consultaVacio, conexion)
        Dim contador As SqlDataReader = comandoVac.ExecuteReader()
        If contador.Read() Then
            ultimo = contador("cuenta")
            Console.WriteLine(ultimo)
        End If
        contador.Close()

        If Not ultimo = 0 Then
            Dim consultaNum As String = "select IDENT_CURRENT('Materiales') as ultimoMat"
            Dim comando As SqlCommand = New SqlCommand(consultaNum, conexion)
            Dim num As SqlDataReader = comando.ExecuteReader()

            If num.HasRows Then
                Try
                    num.Read()
                    ultimo = num("ultimoMat")
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If
            num.Close()
        End If

        txtnum_mat.Text = Format(ultimo + 1, "00000000")

    End Sub

    'Cambiar combobox de subcategorías según categoría seleccionada
    Private Sub cmbcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcat.SelectedIndexChanged
        Select Case cmbcat.SelectedItem
            Case "Hardware"
                cmbsub_cat.ResetText()
                cmbsub_cat.Items.Clear()
                cmbsub_cat.Items.AddRange(New String() {"Equipo", "Periféricos"})
                impVenta = 1.8
            Case "Software"
                cmbsub_cat.ResetText()
                cmbsub_cat.Items.Clear()
                cmbsub_cat.Items.AddRange(New String() {"Antivirus", "Servicio"})
                impVenta = 1.7
        End Select
    End Sub

    'Comprobar campos obligatorios
    Private Function comprobarObligatorios()
        Dim cadena As String = ""
        Dim radioSel As Boolean = False
        If txtmat.Text.Trim = "" Then
            cadena &= "Debes indicar el nombre del material" & vbCrLf
        End If
        If cmbcat.SelectedItem() Is Nothing Then
            cadena &= "Debes indicar la categoría" & vbCrLf
        End If
        If cmbsub_cat.SelectedItem() Is Nothing Then
            cadena &= "Debes indicar la subcategoría" & vbCrLf
        End If
        If cmbpasillo.SelectedItem() Is Nothing Then
            cadena &= "Debes indicar el pasillo" & vbCrLf
        End If

        For Each radio As RadioButton In pnlsec.Controls
            If radio.Checked Then
                radioSel = True
            End If
        Next
        If radioSel = False Then
            cadena &= "Debes seleccionar la sección" & vbCrLf
        End If

        If txtstock.Text.Trim = "" Then
            cadena &= "Debes indicar el stock" & vbCrLf
        End If

        If cadena = "" Then
            Return True
        Else
            MessageBox.Show(cadena, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function

    Private Sub enviarDatos()
        Try
            Dim material As String = txtmat.Text
            Dim categoria As String = cmbcat.SelectedItem.ToString
            Dim subcategoria As String = cmbsub_cat.SelectedItem.ToString
            Dim fecha As String = fechafe_reg.Value.ToString("MM/dd/yyyy")
            Dim descripcion As String = txtdesc.Text
            Dim impCompra As Single = txtimp_com.Text
            Dim impVen As Single = txtimp_ven.Text
            Dim pasillo As Integer = cmbpasillo.SelectedItem()
            Dim seccion As String = Nothing
            Dim stock As Integer = txtstock.Text

            For Each radio As RadioButton In pnlsec.Controls
                If radio.Checked Then
                    seccion = radio.Text
                End If
            Next

            Dim consultaMat As String = "insert into Materiales values (@material, @categoria, @subcategoria, @fecha, @descripcion, @impCompra, @impVen)"
            Dim commandMat As SqlCommand = New SqlCommand(consultaMat, conexion)
            With commandMat.Parameters
                .AddWithValue("@material", material)
                .AddWithValue("@categoria", categoria)
                .AddWithValue("@subcategoria", subcategoria)
                .AddWithValue("@fecha", fecha)
                .AddWithValue("@descripcion", descripcion)
                .AddWithValue("@impCompra", impCompra)
                .AddWithValue("@impVen", impVen)
            End With

            Dim consultaGest As String = "insert into Gest_Materiales values (@pasillo, @seccion, @stock)"
            Dim commandGest As SqlCommand = New SqlCommand(consultaGest, conexion)
            With commandGest.Parameters
                .AddWithValue("@pasillo", pasillo)
                .AddWithValue("@seccion", seccion)
                .AddWithValue("@stock", stock)
            End With

            Try
                commandMat.ExecuteNonQuery()
                commandGest.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            End Try

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try



    End Sub


    Private Sub icon_guardar_Click(sender As Object, e As EventArgs) Handles icon_guardar.Click
        If comprobarObligatorios() Then
            Try
                enviarDatos()
            Catch ex As Exception
                MessageBox.Show("Error al insertar los datos")
            End Try

        End If
    End Sub

    '+++++++++[ FUNCIONES MENÚ E ICONOS ]+++++++++++
    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click, menu_inicio.Click
        Dim inicio As New inicio
        inicio.Show()
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
    Private Sub menu_eliminar_Click(sender As Object, e As EventArgs) Handles menu_eliminar.Click
        Dim eliminar As New eliminarMaterial
        eliminar.Show()
        Me.Close()
    End Sub

    '++++++++[ FORMATEAR IMPORTES ]++++++++++
    Private Sub txtimp_com_LostFocus(sender As Object, e As EventArgs) Handles txtimp_com.LostFocus
        txtimp_com.Text = String.Format("{0:C2}", CDec(txtimp_com.Text))
        txtimp_ven.Text = String.Format("{0:C2}", CDec(txtimp_com.Text) * impVenta)
    End Sub

    '+++++++++[ STOCK SOLO NUMEROS NATURALES ]++++++++
    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '+++++++++[ IMPORTES SOLO NUMEROS NATURALES ]++++++++
    Private Sub txtimp_com_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimp_com.KeyPress
        If Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 44 Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class