Public Class VentanaP
    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click, Btn_2.Click, Lbl_1.Click
        'Dim MiBoton As Button = sender
        MessageBox.Show("Has pulsado este control: " & sender.Name & Chr(13) & "Cuyo texto es: " &
                         sender.Text & Chr(13) & "Y su tipo de clase es: " & sender.GetType.ToString)
    End Sub
End Class
