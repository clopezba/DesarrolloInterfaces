Imports System.ComponentModel
Public Class eliminarMaterial

    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click, menu_inicio.Click
        Dim inicio As New inicio
        inicio.Show()
        Me.Close()
    End Sub
    Private Sub menu_crear_Click(sender As Object, e As EventArgs) Handles menu_crear.Click
        Dim crear As New crearMaterial
        crear.Show()
        Me.Close()
    End Sub
    Private Sub menu_modif_Click(sender As Object, e As EventArgs) Handles menu_modif.Click
        Dim modif As New modificarMaterial
        modif.Show()
        Me.Close()
    End Sub

    Private Sub menu_listar_Click(sender As Object, e As EventArgs) Handles menu_listar.Click
        Dim listar As New listarMateriales
        listar.Show()
        Me.Close()
    End Sub


End Class