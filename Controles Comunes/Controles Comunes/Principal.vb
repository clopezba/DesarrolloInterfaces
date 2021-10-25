Public Class Principal
    ''' <summary>
    ''' Lanza un saludo dependiendo de las opciones seleccionadas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSaludo.Click

        For Each Radio As RadioButton In PnlRbt.Controls
            If Radio.Checked Then Lbl_Saludo.Text = Radio.Tag & " " & Radio.Text
        Next

        For Each RadioN As RadioButton In PnlNombre.Controls
            If RadioN.Checked Then Lbl_Saludo.Text += " " & RadioN.Text
        Next

        Me.Text = Lbl_Saludo.Text

    End Sub
End Class
