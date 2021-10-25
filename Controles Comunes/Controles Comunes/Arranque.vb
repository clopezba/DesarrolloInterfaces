Module Arranque
    Sub main()
        Dim Op As Integer = 0
        Dim MiPrincipal As New Principal

        Op = MessageBox.Show("Sigues? Sí o No", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Op = vbNo Then Exit Sub

        MiPrincipal.ShowDialog()
    End Sub
End Module
