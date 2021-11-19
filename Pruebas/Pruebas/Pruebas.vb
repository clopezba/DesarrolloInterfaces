Public Class Pruebas
    Private Sub btnPrueba1_Click(sender As Object, e As EventArgs) Handles btnPrueba1.Click, btnPrueba2.Click, btnPrueba3.Click
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "btnPrueba1"
                Servicios.ShowDialog()
            Case "btnPrueba2"
                Colores.ShowDialog()
            Case "btnPrueba3"
                MDI_y_Menues.ShowDialog()
        End Select

    End Sub


End Class
