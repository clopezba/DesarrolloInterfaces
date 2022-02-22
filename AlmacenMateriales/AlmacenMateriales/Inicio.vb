Public Class inicio
    Private Sub crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click, icon_crear.Click, menu_crear.Click
        Dim crear As New crearMaterial
        crear.Show()
        Me.Close()
    End Sub

    Private Sub modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click, icon_modificar.Click, menu_modif.Click
        Dim modif As New modificarMaterial
        modif.Show()
        Me.Close()
    End Sub
    Private Sub listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click, icon_listar.Click, menu_listar.Click
        Dim listar As New listarMateriales
        listar.Show()
        Me.Close()
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click, icon_eliminar.Click, menu_eliminar.Click
        Dim eliminar As New eliminarMaterial
        eliminar.Show()
        Me.Close()
    End Sub


End Class
