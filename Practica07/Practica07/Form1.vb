Public Class Form1
    Dim estilo As FontStyle 'Variable global

    'Cargar formulario con las fuentes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaFuentes()
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
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)
    End Sub

    'Cambiar tamaño de fuente con un TrackBar
    Private Sub trckSize_Scroll(sender As Object, e As EventArgs) Handles trckSize.Scroll
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)
    End Sub

    'Cambiar estilo de fuente diferente a normal
    Private Sub cambioEstilo(sender As Object, e As EventArgs) _
        Handles chbxNegrita.CheckedChanged, chbxInclinada.CheckedChanged, chbxSubrayada.CheckedChanged, chbxTachada.CheckedChanged
        Dim check As CheckBox = sender
        If check.Checked Then
            estilo += check.Font.Style
            chbxNormal.Checked = False
        Else
            If estilo >= check.Font.Style Then
                estilo -= check.Font.Style
            End If
        End If
        If estilo = 0 Then
            chbxNormal.Checked = True
        End If
        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)

    End Sub

    'Resetear estilo de fuente a normal
    Private Sub chbxNormal_CheckedChanged(sender As Object, e As EventArgs) Handles chbxNormal.CheckedChanged
        If estilo = 0 Then
            chbxNormal.Checked = True
            Exit Sub
        End If
        If chbxNormal.Checked Then
            estilo = 0
            For Each check As CheckBox In pnlEstilos.Controls
                check.Checked = False
            Next
        End If

        lblSaludo.Font = New Font(cmbxFuentes.Text, trckSize.Value, estilo)
    End Sub
End Class
