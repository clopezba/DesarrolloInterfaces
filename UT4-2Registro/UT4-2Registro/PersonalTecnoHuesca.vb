Public Class PersonalTecnoHuesca
    Private Sub btnNuevoReg_Click(sender As Object, e As EventArgs) Handles btnNuevoReg.Click
        RegistroPersonal.ShowDialog()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        DatosPersonal.ShowDialog()
    End Sub
End Class