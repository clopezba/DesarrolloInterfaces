Public Class Login
    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Servidor = Me.TServidor.Text
        Usuario = Me.TUsuario.Text
        Password = Me.TPassword.Text
        Me.Dispose()
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        'Explorador.Close()
        End
    End Sub
End Class