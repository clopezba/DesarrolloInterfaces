'Clase que hereda de otra clase y puedo modificar sus propiedades o funciones
Public Class CajaTexto
    Inherits TextBox
    Public Overrides Property ForeColor As Color 'Al escribir Public Overrides nos muestra los métodos que se pueden sobreescribir
        Get
            Dim MiColor As Color = Color.FromArgb(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))
            'Return MyBase.ForeColor
            'Return Color.DarkRed
            Return MiColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property
End Class
