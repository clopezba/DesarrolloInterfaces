Public Class Form1
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
        cmbxFuentes.Text = cmbxFuentes.Items(0) 'Para que aparezca la primera por defecto seleccionada
    End Sub

    Private Sub cmbxFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxFuentes.SelectedIndexChanged
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value) 'Añade su espacio de nombres porque font entra en conflicto entre el nombre del proyecto y el Drawing.Font
    End Sub

    Private Sub trckSize_Scroll(sender As Object, e As EventArgs) Handles trckSize.Scroll
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value)
    End Sub
End Class
