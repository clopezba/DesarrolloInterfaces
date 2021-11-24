Public Class Texto
    'Cargar formulario con las fuentes
    Private Sub Texto_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
        For Each pnl As Panel In pnlColores.Controls
            AddHandler pnl.Click, AddressOf colores
        Next
    End Sub
    ' Cargar todas las fuentes del sistema al ComboBox
    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families
            cmbxFuentes.Items.Add(MiFuente.Name)
        Next
        cmbxFuentes.Text = cmbxFuentes.Items(0)
    End Sub
    'Cambiar tipo de fuente
    Private Sub cmbxFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFuentes.SelectedIndexChanged
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value)
    End Sub

    'Cambiar tamaño de fuente con un TrackBar
    Private Sub trckSize_Scroll(sender As Object, e As EventArgs) Handles trckSize.Scroll
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value)
    End Sub

    'Aleatorizar colores en paneles
    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        For Each pnl As Panel In pnlColores.Controls
            pnl.BackColor = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)
        Next
    End Sub

    'Poner el color seleccionado de fondo o color de fuente en la etiqueta
    Private Sub colores(sender As Object, e As EventArgs)
        Dim pnl As Panel = sender
        If rbtnBackground.Checked Then
            lblSaludo.BackColor = pnl.BackColor
        End If
        If rbtnForeground.Checked Then
            lblSaludo.ForeColor = pnl.BackColor
        End If

    End Sub
End Class
