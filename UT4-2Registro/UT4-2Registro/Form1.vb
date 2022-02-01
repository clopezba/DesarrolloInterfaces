Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AsignarTags()
    End Sub
    Sub AsignarTags()
        txtNombre.Tag = errNom
        txtApellidos.Tag = errApe
        txtDNI.Tag = errDNI
        cmbAcceso.Tag = errAcc
    End Sub
    Function comprobacion()
        Dim txtRellenados As Boolean = False
        Dim cmbRellenado As Boolean = False
        Dim correcto As Boolean = False

        For Each control In grPersona.Controls 'Cambiar esto
            Dim tipo As Type = control.GetType()
            If tipo.FullName.Contains("TextBox") Then
                If control.Text.Trim = "" Then
                    control.Tag.Text = "* Este campo es obligatorio"
                    txtRellenados = False
                    Exit For
                Else
                    control.Tag.Text = "*"
                    txtRellenados = True
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
        If txtRellenados And cmbRellenado Then
            correcto = True
        End If
        Return correcto
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If comprobacion() Then
            MessageBox.Show("Registro creado", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub



End Class
