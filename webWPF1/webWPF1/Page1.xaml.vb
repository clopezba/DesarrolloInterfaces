Class Page1
    Private Sub btnAnadir_Click(sender As Object, e As RoutedEventArgs)
        If Not String.IsNullOrEmpty(txtNombre.Text) And Not lstNombres.Items.Contains(txtNombre.Text) Then
            lstNombres.Items.Add(txtNombre.Text)
            txtNombre.Clear()
        End If
    End Sub
End Class
