Public Class Form1
    Dim lista As String()
    Dim listaWindows() As String = {"Microsoft Office (150€)", "Antivirus Norton (60€)", "Edge (20.8€)"}
    Dim listaLinux() As String = {"Libre Office (0€)", "Antivirus McAfee (50€)", "Firefox (30.5€)"}
    Dim listaMac() As String = {"Office Mac (98.9€)", "Antivirus Panda (30€)", "Safari (15.5€)"}

    Dim listaPrecios(3) As Double
    Dim preciosWindows() As Double = {150, 60, 20.8}
    Dim preciosLinux() As Double = {0, 50, 30.5}
    Dim preciosMac() As Double = {98.9, 30, 15.5}
    Dim total() As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        rdbtnNinguno.Checked = True
    End Sub

    'RadioButton
    Private Sub rdbtnNinguno_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnNinguno.CheckedChanged, rdbtnWindows.CheckedChanged,
            rdbtnLinux.CheckedChanged, rdbtnMac.CheckedChanged
        Dim MiRadio As RadioButton = sender
        txtOtro.Enabled = True
        txtPrecio.Enabled = True
        Select Case MiRadio.Name
            Case "rdbtnNinguno"
                ltbxItems.Items.Clear()
                ltbxCompra.Items.Clear()
                txtTotal.Clear()
                txtOtro.Enabled = False
                txtPrecio.Enabled = False
                For Each check As CheckBox In pnlChck.Controls
                    check.Enabled = False
                    check.Checked = False
                Next
            Case "rdbtnWindows"
                ltbxItems.Items.Clear()
                listaPrecios = preciosWindows
                For index = 0 To (listaWindows.Length - 1)
                    ltbxItems.Items.Add(listaWindows(index))
                Next
                For Each check As CheckBox In pnlChck.Controls
                    check.Enabled = True
                    check.Checked = False
                Next
            Case "rdbtnLinux"
                ltbxItems.Items.Clear()
                listaPrecios = preciosLinux
                For index = 0 To (listaLinux.Length - 1)
                    ltbxItems.Items.Add(listaLinux(index))
                Next
                For Each check As CheckBox In pnlChck.Controls
                    check.Enabled = True
                    check.Checked = False
                Next
            Case "rdbtnMac"
                ltbxItems.Items.Clear()
                listaPrecios = preciosMac
                For index = 0 To (listaMac.Length - 1)
                    ltbxItems.Items.Add(listaMac(index))
                Next
                For Each check As CheckBox In pnlChck.Controls
                    check.Enabled = True
                    check.Checked = False
                Next
        End Select
    End Sub

    Private Sub chckProcesador_CheckedChanged(sender As Object, e As EventArgs) Handles chckProcesador.CheckedChanged, chckGPU.CheckedChanged,
            chckInstalar.CheckedChanged, chckRAM.CheckedChanged
        lista = New String() {}
        total = New Double() {}
        For Each check In pnlChck.Controls
            If (check.Checked) Then
                ReDim Preserve lista(lista.Length)
                lista(lista.Length - 1) = check.Text
                ReDim Preserve total(total.Length)
                total(lista.Length - 1) = check.Tag
            End If
        Next
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, ev As KeyPressEventArgs) Handles txtPrecio.KeyPress

        Dim Ch As Char = ev.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 And ev.KeyChar <> "." Then
            ev.Handled = True
        End If

    End Sub

    Private Sub txtOtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtro.KeyPress, txtPrecio.KeyPress
        Dim item As String = txtOtro.Text.Trim & " (" & txtPrecio.Text.Trim & "€)"
        If (txtOtro.Text.Trim = "" Or txtPrecio.Text.Trim = "") Then
            Exit Sub
        ElseIf ltbxItems.Items.IndexOf(item) <> -1 Then
            txtOtro.Clear()
            txtPrecio.Clear()
            Exit Sub
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            ltbxItems.Items.Add(item)
            anadirListas(item, txtPrecio.Text)
            txtOtro.Clear()
            txtPrecio.Clear()
        End If
    End Sub

    Private Sub anadirListas(nombre As String, precio As Double)
        For Each radio As RadioButton In pnlRbtn.Controls
            If radio.Checked Then
                Select Case radio.Name
                    Case "rbtnWindows"
                        ReDim Preserve listaWindows(listaWindows.Length)
                        listaWindows(listaWindows.Length - 1) = nombre
                        ReDim Preserve preciosWindows(preciosWindows.Length)
                        preciosWindows(listaWindows.Length - 1) = precio
                    Case "rbtnLinux"
                        ReDim Preserve listaLinux(listaLinux.Length)
                        listaLinux(listaLinux.Length - 1) = nombre
                        ReDim Preserve preciosLinux(preciosLinux.Length)
                        preciosLinux(listaLinux.Length - 1) = precio
                    Case "rbtnMac"
                        ReDim Preserve listaMac(listaMac.Length)
                        listaMac(listaMac.Length - 1) = nombre
                        ReDim Preserve preciosMac(preciosMac.Length)
                        preciosMac(listaMac.Length - 1) = precio
                End Select
            End If
        Next
        ReDim Preserve listaPrecios(listaPrecios.Length)
        listaPrecios(listaPrecios.Length - 1) = precio

    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Dim cont As Integer = 0
        Do While ltbxItems.SelectedItems.Count <> cont
            If ltbxCompra.Items.IndexOf(ltbxItems.SelectedItems(cont)) <> -1 Then
                cont += 1
            Else
                ltbxCompra.Items.Add(ltbxItems.SelectedItems(cont))
                cont += 1
            End If
        Loop
        For Each checks As CheckBox In pnlChck.Controls
            If checks.Checked And ltbxCompra.Items.IndexOf(checks.Text) = -1 Then
                ltbxCompra.Items.Add(checks.Text)
            End If
        Next
        sumarPrecio()
        'Sumar precio resto de items
        'Limpiar todo con cambio de radioButton ¿fuera?
        'Suma fuera¿?

    End Sub

    Private Sub sumarPrecio()
        Dim suma As Double = 0
        If total.Length >= 0 Then
            For index = 0 To total.Length - 1
                suma += total(index)
            Next
        End If
        For Each item In ltbxCompra.Items
            If ltbxItems.Items.IndexOf(item) <> -1 Then
                suma += listaPrecios(ltbxItems.Items.IndexOf(item))
            End If
        Next
        txtTotal.Text = suma
    End Sub

End Class
