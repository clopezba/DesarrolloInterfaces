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
        Miesquema = conexion.GetSchema("DATABASES")
        Me.VisorRejilla.DataSource = Miesquema
        Dim Tupla As DataRow
        Me.Catalogo.Items.Clear()
        For Each Tupla In Miesquema.Rows
            If Not Catalogo.Items.Contains(Tupla("DATABASE_NAME").ToString) Then 'Continue For
                'If Tupla("ENGINE") Is Nothing Then ' Línea de adición para filtrar por columna identificativa del motor generador
                Me.Catalogo.Items.Add(Tupla("DATABASE_NAME").ToString)
            End If
        Next
    End Sub
    Private Sub ListadoTablas(ByVal sender As Object, ByVal e As System.EventArgs) Handles Catalogo.SelectedIndexChanged
        Dim MiLista As ComboBox = sender
        If MiLista.SelectedIndex = -1 Then Exit Sub
        Me.Tablas.Items.Clear()
        Me.LISTA_CAMPOS.Items.Clear()
        Dim Tupla As DataRow
        InformacionTabla.Text = ""
        SQLText.Text = ""
        For Each Tupla In MiEsquema.Rows
            If Tupla("DATABASE_NAME") = MiLista.SelectedItem Then
                Try
                    conexion = New NpgsqlConnection("Host=" & Servidor & ";Database=" & Tupla("DATABASE_NAME") & ";Username=" & Usuario & ";Password=" & Password)
                    conexion.Open()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Esquema PostgreSQL")
                    Exit Sub
                End Try
                Dim MiEsquema As DataTable = conexion.GetSchema("TABLES")
                For Each Tup As DataRow In MiEsquema.Rows
                    Me.Tablas.Items.Add(Tup("TABLE_NAME").ToString)
                Next
            End If
        Next
        Me.Tablas.Text = "< Selecciona Tabla >"
    End Sub
    Private Sub ListadoCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tablas.SelectedIndexChanged
        Dim Milista As ComboBox = sender
        Dim Miesquema As DataTable = conexion.GetSchema("COLUMNS")
        Dim Tupla As DataRow
        LISTA_CAMPOS.Items.Clear()
        For Each Tupla In Miesquema.Rows
            If Tupla("TABLE_NAME") = Milista.SelectedItem Then
                Me.LISTA_CAMPOS.Items.Add(Tupla("COLUMN_NAME").ToString, True)
            End If
        Next
    End Sub

    Private Sub Consulta(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tablas.SelectedIndexChanged
        '1ª consulta de tabla selecionada
        Dim MiLista As ComboBox = sender
        SQLText.Text = "SELECT * FROM " & MiLista.SelectedItem
        If MiLista.SelectedIndex = -1 Then Exit Sub
        InformacionTabla.Text = "Tabla: " & Catalogo.SelectedItem & " <---> " & MiLista.SelectedItem
        Llenado_Rejilla(SQLText.Text)
    End Sub

    Private Sub Consulta2(ByVal sender As Object, ByVal e As System.EventArgs) Handles LISTA_CAMPOS.SelectedValueChanged, LISTA_CAMPOS.DoubleClick ' dos eventos
        ' generación y diseño automático de consulta SQL por el usuario
        Dim Lista As CheckedListBox = sender
        If Lista.CheckedItems.Count = 0 Then
            SQLText.Text = ""
            Exit Sub
        End If
        Dim Campo As String = ""
        Dim Orden As String = "SELECT "
        Dim Campos As String = ""
        Dim Tabla As String = " FROM " & Tablas.SelectedItem
        For Each Campo In Lista.CheckedItems
            Campos &= Campo & ", "
        Next
        Campos = Campos.Substring(0, Campos.Length - 2)
        SQLText.Text = Orden & Campos & Tabla
    End Sub

    Private Sub EjecutarSQL(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEjecutarSQL.Click
        If SQLText.Text <> "" Then Llenado_Rejilla(Me.SQLText.Text)
    End Sub

    Private Sub Llenado_Rejilla(ByVal Consulta As String)
        'Hay que recordarle la password si la tiene
        Dim ConexionTexto As String = conexion.ConnectionString & ";password=" & Password & ";database=" & Catalogo.SelectedItem
        Dim MiAdaptador As New NpgsqlDataAdapter(Consulta, ConexionTexto)
        MiEsquema2 = New DataTable
        Try
            MiAdaptador.Fill(MiEsquema2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.VisorRejilla.DataSource = MiEsquema2
        Me.VisorRejilla.Refresh()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFormulario.Click
    '    Datos.Show()
    'End Sub

End Class
