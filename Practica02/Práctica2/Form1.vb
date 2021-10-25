Public Class Form1

    'Procedimiento que muestra en un Label el estado de los CheckBox al pulsar un botón
    Private Sub btnResumen_Click(sender As Object, e As EventArgs) Handles btnResumen.Click
        Dim Texto As String = ""
        Dim Estado As String = ""
        For Each MiCheck As CheckBox In pnlOpciones.Controls
            If MiCheck.Checked Then
                Estado = " activada"
            Else
                Estado = " desactivada"
            End If
            Texto &= "La " & MiCheck.Text & " está " & Estado
            Texto &= Chr(10)
        Next
        lblResumen.Text = Texto
    End Sub
End Class
