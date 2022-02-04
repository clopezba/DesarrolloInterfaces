Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conexionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DAM2Alu10\source\repos\DesarrolloInterfaces\UT4-2Registro\UT4-2Registro\BDRegistro.mdf;Integrated Security=True"
        conexion = New SqlConnection(conexionString)
        conexion.Open()
        AsignarTags()
        recibirNumeroRegistro()
    End Sub


    Sub AsignarTags()
        txtNombre.Tag = errNom
        txtApellidos.Tag = errApe
        txtDNI.Tag = errDNI
        cmbAcceso.Tag = errAcc
        rdbtFinanzas.Tag = 0
        rdbtRRHH.Tag = 1
        rdbtLogistica.Tag = 2
    End Sub

    Function comprobacion()
        Dim txtRellenados As Integer = 0
        Dim cmbRellenado As Boolean = False
        'Dim correcto As Boolean = False

        For Each control In grPersona.Controls
            Dim tipo As Type = control.GetType()
            If tipo.FullName.Contains("TextBox") Then
                If control.Text.Trim = "" Then
                    control.Tag.Text = "* Este campo es obligatorio"
                    txtRellenados += 1
                Else
                    control.Tag.Text = "*"
                End If

            End If
        Next

        If cmbAcceso.SelectedItem() Is Nothing Then
            lblAsterico.Text = ""
            cmbAcceso.Tag.Text = "* Este campo es obligatorio"
        Else
            lblAsterico.Text = "*"
            cmbAcceso.Tag.Text = ""
            cmbRellenado = True
        End If
        If txtRellenados = 0 And cmbRellenado Then
            MessageBox.Show("Registro creado", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If

    End Function

    Sub recibirNumeroRegistro()
        Dim total As Integer = 0
        Dim consultaNum As String = "select IDENT_CURRENT('RegPersonal') as numTotal"
        Dim comando As SqlCommand
        comando = New SqlCommand(consultaNum, conexion)
        Dim registro As SqlDataReader
        registro = comando.ExecuteReader()
        If registro.Read() = True Then
            Try
                total = registro("numTotal")
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            txtNumReg.Text = (total + 1).ToString()
        End If
        registro.Close()
    End Sub

    Sub enviarDatos()
        Dim nombre As String = txtNombre.Text
        Dim apellidos As String = txtApellidos.Text
        Dim dni As String = txtDNI.Text
        Dim fechaNac As String = fecha.Value.ToShortDateString
        Dim dept As Integer
        Dim acceso As String = cmbAcceso.SelectedItem.ToString()

        For Each radio As RadioButton In rbPanel.Controls
            If radio.Checked Then
                dept = radio.Tag
            End If
        Next

        Dim consulta As String = "insert into RegPersonal values ('" & nombre & "', '" & apellidos & "', '" & dni & "', '" & fechaNac & "'," & dept & ", '" & acceso & "')"
        'MessageBox.Show(consulta)
        Dim command As SqlCommand
        command = New SqlCommand(consulta, conexion)
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If comprobacion() Then
            enviarDatos()
            vaciarCampos()
        End If
    End Sub

    Sub vaciarCampos()
        recibirNumeroRegistro()
        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtDNI.Text = ""
        fecha.Value = Date.Today
        For Each radio As RadioButton In rbPanel.Controls
            radio.Checked = False
        Next
        cmbAcceso.SelectedItem = -1
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
    End Sub
End Class
