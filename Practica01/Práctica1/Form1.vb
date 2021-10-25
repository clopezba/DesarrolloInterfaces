Public Class Form1
    Private Sub BtnPulsa_Click(sender As Object, e As EventArgs) Handles BtnPulsa.Click
        Dim MiBoton As Button = sender
        Static pulsado As Boolean
        If Not pulsado Then
            sender.Text = "Pulsado"
            pulsado = True
        Else
            MessageBox.Show("Ya ha sido pulsado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub

    Private Sub LblDobleClick_DoubleClick(sender As Object, e As EventArgs) Handles LblDobleClick.DoubleClick
        Dim MiLabel As Label = sender
        MiLabel.Text &= " P"
    End Sub

    Private Sub RbtOpc1_CheckedChanged(sender As Object, e As EventArgs) Handles _
        RbtOpc1.Click, RbtOpc2.Click, RbtOpc3.Click, RbtOpc4.Click
        Dim MiRadio As RadioButton = sender
        MessageBox.Show(MiRadio.Text & " seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnNum_Click(sender As Object, e As EventArgs) Handles BtnNum.Click
        Dim MiBoton As Button = sender
        Static Contador As Integer
        Contador += 1
        MiBoton.Text = Contador
    End Sub

    Private Sub BtnTexto_Click(sender As Object, e As EventArgs) Handles BtnTexto.Click
        Dim Texto As String
        Texto = Txt1.Text & " " & Txt2.Text
        Me.Text = Texto
    End Sub
End Class
