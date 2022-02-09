Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO

Public Class RegistroPersonal
    Dim conexion As SqlConnection
    'Al cargar el formulario, se abre la conexión a la base de datos
    Private Sub RegistroPersonal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim direcActual As String = Directory.GetCurrentDirectory()
        Dim directorio As String = Directory.GetParent(Directory.GetParent(direcActual).ToString()).ToString()

        Dim conexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio & "\BDRegistro.mdf;Integrated Security=True;"
        conexion = New SqlConnection(conexionString)
        Try
            conexion.Open()
            Console.WriteLine("Conexión establecida")
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar. Error: " + ex.Message)
        End Try

        AsignarTags()
        recibirNumeroRegistro()
    End Sub

    'Asigna en tiempo de ejecución etiquetas a controles
    Private Sub AsignarTags()
        txtNombre.Tag = errNom
        txtApellidos.Tag = errApe
        txtDNI.Tag = errDNI
        cmbAcceso.Tag = errAcc
        rdbtFinanzas.Tag = 0
        rdbtRRHH.Tag = 1
        rdbtLogistica.Tag = 2
    End Sub

    'Recibe desde la base de datos el último número de registro realizado
    Private Sub recibirNumeroRegistro()
        Dim total As Integer = 0
        Dim consultaNum As String = "select IDENT_CURRENT('RegPersonal') as ultimoReg"
        Dim comando As SqlCommand
        comando = New SqlCommand(consultaNum, conexion)
        Dim registro As SqlDataReader
        registro = comando.ExecuteReader()
        If registro.Read() = True Then
            Try
                total = registro("ultimoReg")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            'Pone en el TextBox del número de registro un valor más del último registro
            txtNumReg.Text = (total + 1).ToString()
        End If
        registro.Close()
    End Sub

    'Comprueba si todos los controles que son obligatorios están completados
    Private Function comprobacion()
        Dim txtVacios As Integer = 0
        Dim cmbRellenado As Boolean = False

        For Each control In grPersona.Controls
            Dim tipo As Type = control.GetType()
            'Busca todos los controles de tipo TextBox para comprobar si están vacíos
            If tipo.FullName.Contains("TextBox") Then
                If control.Text.Trim = "" Then
                    control.Tag.Text = "* Este campo es obligatorio"
                    txtVacios += 1
                Else
                    control.Tag.Text = "*"
                End If
            End If
        Next

        'Comprueba si se ha seleccionado periodo de acceso en el ComboBox 
        If cmbAcceso.SelectedItem() Is Nothing Then
            lblAsterico.Text = ""
            cmbAcceso.Tag.Text = "* Este campo es obligatorio"
            cmbRellenado = False
        Else
            lblAsterico.Text = "*"
            cmbAcceso.Tag.Text = ""
            cmbRellenado = True
        End If

        'Si todo está rellenado, aparece un mensaje informativo y devuelve verdadero
        If txtVacios = 0 And cmbRellenado Then
            MessageBox.Show("Registro creado", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If
    End Function

    'Recoge todos los datos escritos en los controles y los graba en la base de datos
    Private Sub enviarDatos()
        Dim nombre As String = txtNombre.Text
        Dim apellidos As String = txtApellidos.Text
        Dim dni As String = txtDNI.Text
        Dim fechaNac As String = fecha.Value.ToString("MM/dd/yyyy")
        Dim dept As Integer
        Dim acceso As String = cmbAcceso.SelectedItem.ToString()

        For Each radio As RadioButton In rbPanel.Controls
            If radio.Checked Then
                dept = radio.Tag
            End If
        Next

        'Dim consulta As String = "insert into RegPersonal values ('" & nombre & "', '" & apellidos & "', '" & dni & "', '" & fechaNac & "'," & dept & ", '" & acceso & "')"
        Dim consulta As String = "insert into RegPersonal values (@nombre, @apellidos, @dni, @fechaNac, @dept, @acceso)"

        'MessageBox.Show(consulta)
        Dim command As SqlCommand
        command = New SqlCommand(consulta, conexion)
        With command.Parameters
            .AddWithValue("@nombre", nombre)
            .AddWithValue("@apellidos", apellidos)
            .AddWithValue("@dni", dni)
            .AddWithValue("@fechaNac", fechaNac)
            .AddWithValue("@dept", dept)
            .AddWithValue("@acceso", acceso)
        End With

        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Al pulsar 'Enviar' comprueba que todos los campos obligatorios estén rellenados, los envía a la BD y vacía el formulario
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If comprobacion() Then
            enviarDatos()
            vaciarCampos()
        End If
    End Sub

    'Limpia los datos introducidos en el formulario y cambia el número de registro
    Private Sub vaciarCampos()
        recibirNumeroRegistro()
        txtNombre.ResetText()
        txtApellidos.ResetText()
        txtDNI.ResetText()
        fecha.Value = fecha.MaxDate
        For Each radio As RadioButton In rbPanel.Controls
            radio.Checked = False
        Next
        cmbAcceso.SelectedItem = Nothing
    End Sub

    'Al cerrar el formulario, se cierra la conexión con la base de datos
    Private Sub RegistroPersonal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            conexion.Close()
            Console.WriteLine("Desconectado")
        Catch ex As Exception
            Console.WriteLine("No se ha podido desconectar. Error: " + ex.Message)
        End Try

    End Sub

End Class
