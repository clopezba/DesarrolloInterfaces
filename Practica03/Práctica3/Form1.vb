Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim MiListbox As ListBox = sender
        If MiListbox.SelectedIndex = -1 Then Exit Sub

        'Da el nombre del ítem seleccionado
        'lbl_colorSel.Text = MiListbox.SelectedItem

        'Da el número (índice) del ítem seleccionado
        'lbl_colorSel.Text = MiListbox.SelectedIndex

        'Da el nombre del ítem a través del indice del seleccionado
        'lbl_colorSel.Text = MiListbox.Items(MiListbox.SelectedIndex)

        'Mostramos todos los seleccionados en un Label
        lbl_colorSel.Text = ""
        For Each Texto As String In MiListbox.SelectedItems
            lbl_colorSel.Text &= Texto
            lbl_colorSel.Text &= Chr(10)
        Next

        'Mostramos todos los seleccionados en un TextBox (hay que activar MultiLine)
        txtItems.Text = ""
        For Each Item As String In MiListbox.SelectedItems
            txtItems.Text &= Item & vbCrLf
        Next



    End Sub
End Class
