Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class modificarMaterial
    Dim conexion As SqlConnection
    Dim impVenta As Single

    Private Sub modificarMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Function numValido()
        Dim existe As Boolean = False
        If Not txtmat_buscar.Text.Trim = Nothing Then
            Dim consultaNum As String = "select mat FROM Materiales where num_mat = @nummat"
            Dim comando As SqlCommand = New SqlCommand(consultaNum, conexion)
            comando.Parameters.AddWithValue("@nummat", txtmat_buscar.Text.Trim)

            Dim num As SqlDataReader = comando.ExecuteReader()

            If Not num.Read = Nothing Then
                Dim material As String = num("mat")
                existe = True
                Console.WriteLine(material)
            End If
            num.Close()
        End If

        Return existe
    End Function

    Private Sub buscarMaterial()
        limpiarCampos()
        If Not txtmat_buscar.Text.Trim = Nothing And numValido() Then
            Try
                Dim consulta As String = "select * from Materiales where num_mat = @nummat"
                Dim comando As SqlCommand = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nummat", txtmat_buscar.Text)

                Dim contador As SqlDataReader = comando.ExecuteReader()
                If contador.Read() Then
                    txtnum_mat.Text = Format(contador("num_mat"), "00000000")
                    txtmat.Text = contador("mat").ToString
                    cmbcat.SelectedItem = contador("cat").ToString
                    cmbsub_cat.Text = contador("sub_cat").ToString
                    fechafe_reg.Value = contador("fe_reg")
                    txtdesc.Text = contador("desc").ToString
                    txtimp_com.Text = String.Format("{0:C2}", contador("imp_com"))
                    txtimp_ven.Text = String.Format("{0:C2}", contador("imp_ven"))
                End If
                contador.Close()
            Catch ex As Exception
                Console.WriteLine("Error en la consulta materiales: " + ex.Message)
            End Try

            Try
                Dim cons As String = "select * from Gest_Materiales where num_mat = @nummat"
                Dim com As SqlCommand = New SqlCommand(cons, conexion)
                com.Parameters.AddWithValue("@nummat", txtmat_buscar.Text)

                Dim cont As SqlDataReader = com.ExecuteReader()
                If cont.Read() Then
                    cmbPasillo.Text = cont("pas")
                    For Each radio As RadioButton In pnlsec.Controls
                        If radio.Text.Contains(cont("sec")) Then
                            radio.Checked = True
                        End If
                    Next
                    txtstock.Text = cont("stock")
                End If
                cont.Close()
            Catch ex As Exception
                Console.WriteLine("Error en la consulta gest_materiales: " + ex.Message)
            End Try
        Else
            MessageBox.Show("No existe ese número")
        End If

    End Sub

    Private Sub limpiarCampos()
        For Each control As Control In pnlCampos.Controls
            control.ResetText()
        Next
        cmbcat.SelectedItem = Nothing
        cmbsub_cat.SelectedItem = Nothing
        cmbPasillo.SelectedItem = Nothing
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
                impVenta = 1.8
            Case "Software"
                cmbsub_cat.ResetText()
                cmbsub_cat.Items.Clear()
                cmbsub_cat.Items.AddRange(New String() {"Antivirus", "Servicio"})
                impVenta = 1.7
        End Select
        calcularPrecio()
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
        If cmbPasillo.SelectedItem() Is Nothing Then
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
        If txtimp_com.Text.Trim = Nothing Or txtimp_com.Text.Trim = "," Or txtimp_com.Text.Trim = "€" Then
            txtimp_com.Text = 0
            txtimp_ven.Text = 0
        End If

        If cadena = "" Then
            Return True
        Else
            MessageBox.Show(cadena, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        buscarMaterial()
    End Sub

    Private Sub actualizarDatos()
        Try
            Dim material As String = txtmat.Text
            Dim categoria As String = cmbcat.SelectedItem.ToString
            Dim subcategoria As String = cmbsub_cat.SelectedItem.ToString
            Dim fecha As String = fechafe_reg.Value.ToString("MM/dd/yyyy HH:mm:ss")
            Dim descripcion As String = txtdesc.Text
            Dim impCompra As Single = txtimp_com.Text
            Dim impVen As Single = txtimp_ven.Text
            Dim pasillo As Integer = cmbPasillo.SelectedItem
            Dim seccion As Char = Nothing
            Dim stock As Integer = txtstock.Text
            Dim num_mat As Integer = txtnum_mat.Text

            For Each radio As RadioButton In pnlsec.Controls
                If radio.Checked Then
                    seccion = radio.Text
                End If
            Next

            Dim consultaMat As String = "update Materiales set mat = @material, cat = @categoria, sub_cat = @subcategoria, fe_reg = @fecha, [desc] = @desc, imp_com = @impCompra, imp_ven = @impVen where num_mat = @nummat"
            Dim commandMat As SqlCommand = New SqlCommand(consultaMat, conexion)
            With commandMat.Parameters
                .AddWithValue("@material", material)
                .AddWithValue("@categoria", categoria)
                .AddWithValue("@subcategoria", subcategoria)
                .AddWithValue("@fecha", fecha)
                .AddWithValue("@desc", descripcion)
                .AddWithValue("@impCompra", impCompra)
                .AddWithValue("@impVen", impVen)
            End With
            commandMat.Parameters.AddWithValue("@nummat", num_mat)

            Dim consultaGest As String = "update Gest_Materiales set pas = @pasillo, sec = @seccion, stock = @stock where num_mat = @nummat"
            Dim commandGest As SqlCommand = New SqlCommand(consultaGest, conexion)
            With commandGest.Parameters
                .AddWithValue("@pasillo", pasillo)
                .AddWithValue("@seccion", seccion)
                .AddWithValue("@stock", stock)
            End With
            commandGest.Parameters.AddWithValue("@nummat", num_mat)

            Try
                commandMat.ExecuteNonQuery()
                commandGest.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
                Console.WriteLine(ex.Source)
                Console.WriteLine(ex.StackTrace)

            End Try
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub modificarMaterial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            conexion.Close()
            Console.WriteLine("Desconectado de la base de datos")
        Catch ex As Exception
            Console.WriteLine("No se ha podido desconectar. Error: " + ex.Message)
        End Try
    End Sub

    '+++++++++[ FUNCIONES MENÚ E ICONOS ]+++++++++++
    Private Sub icon_guardar_Click(sender As Object, e As EventArgs) Handles icon_guardar.Click
        txtimp_com_LostFocus(txtimp_com, New EventArgs)
        If comprobarObligatorios() Then
            Try
                actualizarDatos()
                limpiarCampos()

                MessageBox.Show("Material actualizado correctamente", "Modificación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

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

    Private Sub txtimp_com_LostFocus(sender As Object, e As EventArgs) Handles txtimp_com.LostFocus
        If Not txtimp_com.Text = Nothing And Not txtimp_com.Text.Trim = "€" And Not txtimp_com.Text.Trim = "," Then
            txtimp_com.Text = String.Format("{0:C2}", CDec(txtimp_com.Text))
            txtimp_ven.Text = String.Format("{0:C2}", CDec(txtimp_com.Text) * impVenta)
        Else
            txtimp_com.Text = 0
            txtimp_ven.Text = 0
        End If
    End Sub

    '+++++++++[ CALCULAR IMPORTE VENTA ]+++++++++
    Private Sub calcularPrecio()
        If Not txtimp_com.Text = Nothing And Not txtimp_com.Text.Trim = "€" And Not txtimp_com.Text.Trim = "," Then
            txtimp_ven.Text = String.Format("{0:C2}", CDec(txtimp_com.Text) * impVenta)
        End If

    End Sub

    '+++++++++[ STOCK SOLO NUMEROS NATURALES ]++++++++
    Private Sub txtstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstock.KeyPress, txtmat_buscar.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    '+++++++++[ IMPORTES SOLO NUMEROS NATURALES & UNA SOLA COMA ]++++++++
    Private Sub txtimp_com_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimp_com.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = "," And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = "," And txtimp_com.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

End Class