Public Class Main
    Private Sub btnForm1_Click(sender As Object, e As EventArgs) Handles btnForm1.Click, btnMenu.Click, btnTexto.Click
        Dim MiBoton As Button = sender
        Select Case MiBoton.Name
            Case "btnForm1"
                Dim ventana As New Form1
                ventana.ShowDialog()
            Case "btnTexto"
                Dim ventana As New Texto
                ventana.ShowDialog()
            Case "btnMenu"
                Dim ventana As New Menu
                ventana.ShowDialog()
        End Select

    End Sub
End Class