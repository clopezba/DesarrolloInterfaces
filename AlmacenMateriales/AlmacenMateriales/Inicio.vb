Public Class inicio
    Private Sub crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click, icon_crear.Click, menu_crear.Click
        Me.Hide()
        crearMaterial.ShowDialog()
    End Sub

    Private Sub modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click, icon_modificar.Click, menu_modif.Click
        Me.Hide()
        modificarMaterial.ShowDialog()
    End Sub
    Private Sub listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click, icon_listar.Click, menu_listar.Click
        Me.Hide()
        listarMateriales.ShowDialog()
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click, icon_eliminar.Click, menu_eliminar.Click
        Me.Hide()
        eliminarMaterial.ShowDialog()
    End Sub


End Class
