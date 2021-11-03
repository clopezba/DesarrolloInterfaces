Public Class Form1
    Dim estilo As FontStyle = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
    End Sub
    ''' <summary>
    ''' Carga todas las fuentes del sistema en un ComboBox
    ''' </summary>
    Private Sub cargaFuentes()
        Dim MiFuente As FontFamily
        For Each MiFuente In FontFamily.Families
            cmbxFuentes.Items.Add(MiFuente.Name)
        Next
        cmbxFuentes.Text = cmbxFuentes.Items(0)

    End Sub

    Private Sub cmbxFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFuentes.SelectedIndexChanged
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)
    End Sub

    Private Sub trckSize_Scroll(sender As Object, e As EventArgs) Handles trckSize.Scroll
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)
    End Sub

    Private Sub chbxNormal_CheckedChanged(sender As Object, e As EventArgs) Handles chbxNormal.CheckedChanged
        If chbxNormal.Checked Then
            estilo = 0
        End If
    End Sub
    Private Sub cambioEstilo(sender As Object, e As EventArgs) _
        Handles chbxNegrita.CheckedChanged, chbxInclinada.CheckedChanged, chbxSubrayada.CheckedChanged, chbxTachada.CheckedChanged
        Dim check As CheckBox = sender


    End Sub



End Class
