Public Class Form1
    Sub comprobacion()
        For Each control As TextBox In grPersona.Controls 'Cambiar esto
            If control.Text.Trim Is Nothing Then
                control.Tag.Text = "* Este campo es obligatorio"
            End If
        Next
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        comprobacion()
    End Sub
End Class
