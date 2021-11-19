Public Class Servicios
    Dim ValoresSw() As Integer = {200, 50, 20, 80}
    Dim total As Double = 0
    Dim listaChecks() As String
    Dim totalChecks() As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        rbtnNinguno.Checked = True
        deshabilitarControles()

    End Sub

    Private Sub rdbtnNinguno_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnNinguno.CheckedChanged, rbtnWindows.CheckedChanged, rbtnChrome.CheckedChanged,
        rbtnUbuntu.CheckedChanged, rbtnMac.CheckedChanged
        Dim MiRadio As RadioButton = sender
        If MiRadio.Name = "rbtnNinguno" Then
            deshabilitarControles()
        ElseIf MiRadio.Name <> "rbtnNinguno" Then
            habilitarControles()
        End If
    End Sub

    Private Sub Btn_AgregaSW_Click(sender As Object, e As EventArgs) Handles Btn_AgregaSW.Click
        Dim MiTexto As String = txtb_swExtra.Text.Trim
        Dim MiItem As String = MiTexto & " (" & CInt(txtPrecio.Text) & "€)"

        If Not Ltbx_Apli.Items.Contains(MiItem) And Not MiTexto.Length = 0 Then
            Ltbx_Apli.Items.Add(MiItem)
            ReDim Preserve ValoresSw(ValoresSw.Count)
            ValoresSw(ValoresSw.Count - 1) = CInt(txtPrecio.Text)
            BorrarEntradas()
        End If

    End Sub
    Private Sub txtPrecio_KeyPress(sender As Object, ev As KeyPressEventArgs) Handles txtPrecio.KeyPress

        Dim Ch As Char = ev.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 And ev.KeyChar <> "." Then
            ev.Handled = True
        End If

    End Sub

    Private Sub BorrarEntradas()
        txtb_swExtra.Clear()
        txtPrecio.Text = 0
    End Sub
    Private Sub deshabilitarControles()
        For Each contr As Control In pnlDatos.Controls
            contr.Enabled = False
        Next
        For Each check As CheckBox In pnlChck.Controls
            check.Enabled = False
            check.Checked = False
        Next
        txtTotal.Clear()
        BorrarEntradas()
    End Sub
    Private Sub habilitarControles()
        For Each contr As Control In pnlDatos.Controls
            contr.Enabled = True
        Next
        For Each check As CheckBox In pnlChck.Controls
            check.Enabled = True
            check.Checked = False
        Next
    End Sub

    Private Sub chckEclipse_CheckedChanged(sender As Object, e As EventArgs) Handles chckEclipse.CheckedChanged, chckAndroid.CheckedChanged,
            chckDream.CheckedChanged, chckNet.CheckedChanged, chckVisual.CheckedChanged
        listaChecks = New String() {}
        totalChecks = New Double() {}
        For Each check In pnlChck.Controls
            If (check.Checked) Then
                ReDim Preserve listaChecks(listaChecks.Length)
                listaChecks(listaChecks.Length - 1) = check.Text
                ReDim Preserve totalChecks(totalChecks.Length)
                totalChecks(listaChecks.Length - 1) = check.Tag
            End If
        Next
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim cont As Integer = 0
        Do While Ltbx_Apli.SelectedItems.Count <> cont
            rtbResumen.Text += Ltbx_Apli.SelectedItem(cont)
            cont += 1
        Loop
        For Each checks As CheckBox In pnlChck.Controls
            If checks.Checked Then
                rtbResumen.Text += checks.Text + vbCrLf

            End If
        Next
        sumarPrecio()
    End Sub
    Private Sub sumarPrecio()
        Dim suma As Double = 0
        If totalChecks.Length >= 0 Then
            For index = 0 To totalChecks.Length - 1
                suma += totalChecks(index)
            Next
        End If
        txtTotal.Text = suma
    End Sub



End Class