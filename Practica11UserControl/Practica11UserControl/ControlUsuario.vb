Imports System.ComponentModel

Public Class ControlUsuario
    Private Texto As String 'El objeto no podrá acceder a este atributo, pero sí con el GET de la propiedad
    <Description("Propiedad nueva de texto")> 'Describe lo que venga después (la propiedad)
    Public Property TextoInicial() As String
        Get
            Return Texto
        End Get
        Set(value As String) 'Si la propiedad es de solo lectura, la parte SET desaparece
            Texto = value
        End Set
    End Property
    Private Sub MiBoton_Click(sender As Object, e As EventArgs) Handles MiBoton.Click
        MiLista.Items.Add(MiTexto.Text)
    End Sub
    Private Sub ControlUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        MiTexto.Text = Me.TextoInicial
    End Sub
End Class
