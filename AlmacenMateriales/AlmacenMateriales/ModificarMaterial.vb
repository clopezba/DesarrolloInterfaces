Imports System.ComponentModel
Public Class modificarMaterial

    Private Sub modificarMaterial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If crearMaterial.Visible = False And listarMateriales.Visible = False And eliminarMaterial.Visible = False Then
            inicio.Visible = True
        End If
    End Sub

    Private Sub icon_inicio_Click(sender As Object, e As EventArgs) Handles icon_inicio.Click
        inicio.Visible = True
        Me.Close()
    End Sub
    Private Sub menu_crear_Click(sender As Object, e As EventArgs) Handles menu_crear.Click
        Me.Visible = False
        If crearMaterial.Visible = False Then
            crearMaterial.Visible = True
        Else
            crearMaterial.ShowDialog()
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