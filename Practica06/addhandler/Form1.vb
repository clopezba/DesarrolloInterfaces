Public Class Form1
    Private Sub Btn_Mxtexb_Click(sender As Object, e As EventArgs) Handles Btn_Mxtexb.Click
        Dim MitextBox As New TextBox
        Dim Etiqueta As New Label
        If (PanelTXTbx.Controls.Count / 2) > 9 Then Exit Sub

        'Márgenes
        MitextBox.Left = Etiqueta.Width + 5
        MitextBox.Top = ((PanelTXTbx.Controls.Count / 2 * (MitextBox.Height + 5)) + 10)
        Etiqueta.Top = MitextBox.Top

        AddHandler MitextBox.DoubleClick, AddressOf Mitexto
        'Añadir controles
        PanelTXTbx.Controls.Add(MitextBox)
        PanelTXTbx.Controls.Add(Etiqueta)

        'Propiedades controles
        MitextBox.Name = "TextBox_" & (PanelTXTbx.Controls.Count / 2)
        MitextBox.Width = "150"
        MitextBox.ForeColor = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))

        ContadorTXTbx.Text = "Nº de TextBox " & (PanelTXTbx.Controls.Count / 2)

        Etiqueta.Text = "Nº de TextBox " & PanelTXTbx.Controls.Count / 2
        Etiqueta.ForeColor = Color.Red
    End Sub

    Private Sub Btn_Mntexb_Click(sender As Object, e As EventArgs) Handles Btn_Mntexb.Click
        If PanelTXTbx.Controls.Count = 0 Then Exit Sub
        PanelTXTbx.Controls.RemoveAt(PanelTXTbx.Controls.Count - 1)
        PanelTXTbx.Controls.RemoveAt(PanelTXTbx.Controls.Count - 1)
        ContadorTXTbx.Text = "Nº de TextBox " & PanelTXTbx.Controls.Count / 2
    End Sub
    Private Sub Mitexto(Objeto As Object, Evento As EventArgs)
        Dim Mitexto As TextBox = Objeto
        MessageBox.Show("contenido de: " & Mitexto.Name & "-->" & Mitexto.Text)

    End Sub
End Class
