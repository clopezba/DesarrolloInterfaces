Imports npgsql
Public Class Explorador

    Dim conexion As NpgsqlConnection
    Public Miesquema As DataTable
    Public MiEsquema2 As DataTable

    Private Sub CargaEsquema(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ConectarMySQL()
    End Sub
    Private Sub ConectarMySQL()
        Login.ShowDialog()
        conexion = New NpgsqlConnection("Host=" & Servidor & ";Username=" & Usuario & ";Password=" & Password)
        Dim RestriccionesAdicionales() As String = {""} ' depende de la primera restricción podrá incluirse otras
        Try
            conexion.Open()
            Me.Text = " Explorador MySQL [ Versión -> " & conexion.ServerVersion & " | Host origen -> " & conexion.DataSource & " ]"
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
        Miesquema = conexion.GetSchema("TABLES")
        Me.VisorRejilla.DataSource = Miesquema
        Dim Tupla As DataRow
        Me.Catalogo.Items.Clear()
        For Each Tupla In Miesquema.Rows
            If Catalogo.Items.Contains(Tupla("INFORMATION_SCHEMA").ToString) Then Continue For
            If Tupla("ENGINE") Is Nothing Then ' Línea de adición para filtrar por columna identificativa del motor generador
                Me.Catalogo.Items.Add(Tupla("INFORMATION_SCHEMA").ToString)
            End If
        Next
    End Sub
    Private Sub ListadoTablas(ByVal sender As Object, ByVal e As System.EventArgs) Handles Catalogo.SelectedIndexChanged
        Dim MiLista As ComboBox = sender
        If MiLista.SelectedIndex = -1 Then Exit Sub
        Dim Tupla As DataRow
        Me.Tablas.Items.Clear()
        Me.LISTA_CAMPOS.Items.Clear()
        Me.VisorRejilla.DataSource = Miesquema
        InformacionTabla.Text = ""
        SQLText.Text = ""
        For Each Tupla In Miesquema.Rows
            If Tupla("TABLE_SCHEMA") = MiLista.SelectedItem Then
                Me.Tablas.Items.Add(Tupla("TABLE_NAME").ToString)
            End If
        Next
        Me.Tablas.Text = "< Selecciona Tabla >"
    End Sub


End Class
