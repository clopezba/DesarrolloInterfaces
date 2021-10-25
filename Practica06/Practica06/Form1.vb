Public Class Form1
    'Para poder asignarle un evento al boton debemos poner Friend WithEvent
    'Friend WithEvents MiBoton As Button 
    Dim X As Integer = 0
    Dim Y As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim MiBoton = New Button
        Me.Controls.Add(MiBoton)
        MiBoton.Text = "Pulsa"
        MiBoton.Location = New Point(150, 100)
        MiBoton.Size = New Size(60, 25)

        'Si no creamos el objeto con "WithEvents", no podemos referenciarlo en el método,
        'tenemos que crear el manejador a mano
        AddHandler MiBoton.Click, AddressOf MiBoton_Click
    End Sub

    Private Sub MiBoton_Click(sender As Object, e As EventArgs)
        Dim MiTexto = New TextBox
        Me.Controls.Add(MiTexto)
        MiTexto.Location = New Point(X, Y)
        Y += 20
    End Sub
End Class
