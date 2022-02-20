Imports System.ComponentModel

Public Class crearMaterial

    Private Sub crearMaterial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If modificarMaterial.Visible = False And listarMateriales.Visible = False And eliminarMaterial.Visible = False Then
            inicio.Visible = True
        End If
    End Sub

    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click
        inicio.Visible = True
        Me.Close()
    End Sub

    Private Sub menu_modif_Click(sender As Object, e As EventArgs) Handles menu_modif.Click
        Me.Visible = False
        If modificarMaterial.Visible = False Then
            modificarMaterial.Visible = True
        Else
            modificarMaterial.ShowDialog()
        End If
    End Sub

    Private Sub menu_listar_Click(sender As Object, e As EventArgs) Handles menu_listar.Click
        Me.Visible = False
        If listarMateriales.Visible = False Then
            listarMateriales.Visible = True
        Else
            listarMateriales.ShowDialog()
        End If
    End Sub
    Private Sub menu_eliminar_Click(sender As Object, e As EventArgs) Handles menu_eliminar.Click
        Me.Visible = False
        If eliminarMaterial.Visible = False Then
            eliminarMaterial.Visible = True
        Else
            eliminarMaterial.ShowDialog()
        End If
    End Sub
End Class