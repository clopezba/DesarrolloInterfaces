
Imports System.IO


Public Class Form1
    Dim Conexion As String = "server=127.0.0.1;database=nba;user=root;password=root"
    Public Miesquema As DataTable
    Friend WithEvents MiDataSet As New DataSet
    Friend WithEvents miAdaptador As New MySqlDataAdapter
    Friend WithEvents miBindingsourceJug As New BindingSource
    Friend WithEvents miBindingsourceEqu As New BindingSource

    Private Sub CargarDatos(MiSelect As String, nomTabla As String, UnBindingSource As BindingSource)
        miAdaptador.SelectCommand = New MySqlCommand(MiSelect)
        miAdaptador.SelectCommand.Connection = New MySqlConnection(Conexion)

        Try
            miAdaptador.Fill(MiDataSet, nomTabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        UnBindingSource.DataSource = MiDataSet
        UnBindingSource.DataMember = nomTabla
    End Sub

    Sub cargarRejilla()
        RejillaJugadores.DataSource = miBindingsourceJug
        txtJugador.DataBindings.Add(New Binding("Text", miBindingsourceJug, "Nombre"))
    End Sub

    Sub cargarCombo()
        cmbEquipo.DataSource = miBindingsourceEqu
        cmbEquipo.ValueMember = "Nombre"
        cmbEquipo.DisplayMember = "Nombre"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarDatos("select * from jugadores", "jugadores", miBindingsourceJug)
        cargarRejilla()
        CargarDatos("select Nombre from equipos", "equipos", miBindingsourceEqu)
        cargarCombo()
    End Sub

    Private Sub chckTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chckTodos.CheckedChanged
        Dim miCheck As CheckBox = sender
        If miCheck.Checked Then
            miBindingsourceJug.Filter = ""
            cargarCombo()
            miBindingsourceEqu.MoveFirst()
        End If
    End Sub

    Private Sub cmbEquipo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbEquipo.SelectionChangeCommitted
        chckTodos.Checked = False
        Dim filtro As String = "Nombre_Equipo = '" & cmbEquipo.SelectedValue.ToString & "'"
        miBindingsourceJug.Filter = filtro
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        miBindingsourceJug.MoveFirst()
    End Sub
    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        miBindingsourceJug.MoveLast()
    End Sub
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        miBindingsourceJug.MoveNext()
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        miBindingsourceJug.MovePrevious()

    End Sub


    '------IMPRIMIR EN PRINTDOC-------

    Friend WithEvents MiPrint As MipreviewPrintDialog
    Friend WithEvents MiPrintDocumento As Printing.PrintDocument
    Friend WithEvents Impresoras As New PrintDialog
    Friend Logo As Image
    Dim nombreBD As String = "Jugadores NBA"

    'Cuando se pulsa Imprimir, se elige la impresora, se accede a la vista previa y se imprime
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Logo = imgNBA.Image
        MiPrint = New MipreviewPrintDialog
        MiPrintDocumento = New Printing.PrintDocument

        MiPrint.Icon = Me.Icon
        MiPrint.WindowState = FormWindowState.Maximized
        MiPrint.Document = MiPrintDocumento

        If Impresoras.ShowDialog() = DialogResult.OK Then
            MiPrintDocumento.PrinterSettings = Impresoras.PrinterSettings
            MiPrintDocumento.DefaultPageSettings.Landscape = True
            If MiPrint.ShowDialog() = DialogResult.OK Then
                MiPrint.Document.Print()
            End If
        End If
    End Sub

    '-------Imprimir DataGridView VARIABLES DE PAGINACIÓN-------

    Dim oColumnLefts As ArrayList
    Dim oColumnWidths As ArrayList
    Dim oColumnTypes As ArrayList
    Dim oStringFormat As StringFormat

    Dim TotalWidth As Int16
    Dim nRowPos As Short
    Dim RowsPerPage As Integer
    Dim pHeight As Integer
    Dim pWidth As Integer
    Dim PageNo As Integer

    'Se prepara el documento estableciendo los valores iniciales
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles MiPrintDocumento.BeginPrint
        oColumnLefts = New ArrayList
        oColumnWidths = New ArrayList
        oColumnTypes = New ArrayList
        TotalWidth = 0
        nRowPos = 0
        pHeight = 0
        pWidth = 0
        RowsPerPage = 25
        PageNo = 1
    End Sub

    'Estructuración de la página, tamaño y número de filas y columnas, posiciones, etc.
    Private Sub PrintDocument1_PrintPag(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles MiPrintDocumento.PrintPage

        Dim MifuenteCab As New Font("Arial", 8, FontStyle.Bold) 'Cabecera
        Dim MifuenteFila As New Font("Arial", 7, FontStyle.Regular) 'Fila
        Dim pHeader As String = Me.Text
        Dim i As Integer
        Dim pTop As Integer = e.MarginBounds.Top
        Dim pLeft As Integer = e.MarginBounds.Left
        Dim NewPage As Boolean = True
        TotalWidth = 0
        Dim contRows As Int16
        For Each DColumn As DataGridViewColumn In RejillaJugadores.Columns
            TotalWidth += DColumn.Width
        Next

        'Si es la primera página, calcula y establece el tamaño de las columnas de la tabla
        If PageNo = 1 Then
            For Each DColumn As DataGridViewColumn In RejillaJugadores.Columns
                pWidth = CType(Math.Floor(DColumn.Width / TotalWidth * TotalWidth * (e.MarginBounds.Width / TotalWidth)), Int16)
                pHeight = e.Graphics.MeasureString(DColumn.HeaderText, MifuenteCab, pWidth).Height + 11
                oColumnLefts.Add(pLeft)
                oColumnWidths.Add(pWidth)
                oColumnTypes.Add(DColumn.GetType)
                pLeft += pWidth
            Next
        End If

        'Si no se ha llegado al final de la lista de jugadores
        Do While nRowPos <= RejillaJugadores.Rows.Count - 2
            Dim oRow As DataGridViewRow = RejillaJugadores.Rows(nRowPos)
            contRows += 1
            If RowsPerPage = contRows Then 'Si se ha llenado la página se rellena el pie de página
                DrawFooter(e, RowsPerPage, PageNo)
                PageNo += 1
                e.HasMorePages = True 'Activa la recursividad mientras haya más páginas
                Exit Sub 'Sale del método, pero como la recursividad está activada, vuelve a ejecutarlo

            Else 'Si no se ha llenado la pag, seguimos debajo
                e.HasMorePages = False 'termina la recursividad

                'Al empezar página, rellena la cabecera
                If NewPage Then
                    pTop = e.MarginBounds.Top
                    i = 0
                    'Títulos de cabecera
                    Dim MiPen As New SolidBrush(Color.Black)
                    Dim Micall As Image.GetThumbnailImageAbort = Nothing
                    e.Graphics.DrawString(Me.lblTitulo.Text.ToString, New Font("Arial", 9, FontStyle.Bold), MiPen, New Rectangle(60, 80, 1000, 50))
                    e.Graphics.DrawString(Me.Text, New Font("Arial", 9, FontStyle.Bold), MiPen, New Rectangle(60, 60, 700, 50))
                    e.Graphics.DrawImage(Logo.GetThumbnailImage(50, 40, Micall, New IntPtr), 1000, 40)
                    'Cabecera columnas por cada newpage
                    For Each oColumn As DataGridViewColumn In RejillaJugadores.Columns
                        If Not oColumn.Visible Then Continue For
                        e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New Rectangle(oColumnLefts(i), pTop, oColumnWidths(i), pHeight))
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), pTop, oColumnWidths(i), pHeight))
                        e.Graphics.DrawString(oColumn.HeaderText, MifuenteCab, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), pTop, oColumnWidths(i), pHeight), oStringFormat)
                        i += 1
                    Next
                    NewPage = False

                End If
                pTop += pHeight
                i = 0
                ' detalle de las filas 
                For Each oCell As DataGridViewCell In oRow.Cells
                    If Not oCell.Visible Then Continue For
                    If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) Then
                        If Not oCell.Value Is Nothing Then
                            e.Graphics.DrawString(oCell.Value.ToString, MifuenteFila, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), pTop, oColumnWidths(i), pHeight), oStringFormat)
                        End If
                        'Si hubiera más tipos distintos de columnas, habría que hacer las ElseIf por cada tipo diferente
                        'ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then
                        '    Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), pTop, oColumnWidths(i), pHeight)
                        '    Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        '    e.Graphics.DrawImage(oCell.Value, New Rectangle(oColumnLefts(i) + CType(((oCellSize.Width - oImageSize.Width) / 2), Int32), pTop + CType(((oCellSize.Height - oImageSize.Height) / 2), Int32), CType(oCell.Value, Image).Width, CType(oCell.Value, Image).Height))
                    End If
                    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(oColumnLefts(i), pTop, oColumnWidths(i), pHeight))
                    i += 1
                Next

            End If
            nRowPos += 1

        Loop

        NewPage = False
        DrawFooter(e, RowsPerPage, PageNo)
        PageNo += 1

    End Sub

    'Pie de página
    Private Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowsPerPage As Int32, ByVal nPageNo As Int16)

        Dim sPageNo As String = "Página " & nPageNo.ToString + " de " + Math.Ceiling((RejillaJugadores.Rows.Count - 1) / (RowsPerPage - 1)).ToString
        Dim TEXTO As String = nombreBD.ToUpperInvariant
        ' Right Align - User Name
        e.Graphics.DrawString(TEXTO, RejillaJugadores.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(TEXTO, RejillaJugadores.Font, e.MarginBounds.Width).Width), e.MarginBounds.Top + e.MarginBounds.Height + 30)

        ' Left Align - Date/Time
        e.Graphics.DrawString(Now.ToLongDateString + " " + Now.ToShortTimeString, RejillaJugadores.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 30)

        ' Center  - Page No. Info
        e.Graphics.DrawString(sPageNo, RejillaJugadores.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 10) ''- 160 + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, RejillaProductos.Font, e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + e.MarginBounds.Height + 30)
    End Sub


    '-------GENERAR PDF -- iTextSharp ----

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Intentar generar el documento
        Try
            'Preparación de la memoria de volcado
            Dim doc_page As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 55, 20)
            Dim enMemoria As New MemoryStream()
            Dim impPDF_P As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc_page, enMemoria)

            'Preparación del archivo de volcado
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate, 10, 10, 55, 20)

            'Path que guarda el PDF (Directorio temporal de Internet)
            Dim nombreFichero As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\NBA_" + Now.ToFileTimeUtc.ToString + ".pdf"
            Dim ficheroStream As New FileStream(nombreFichero, FileMode.Create, FileAccess.Write, FileShare.ReadWrite) 'Crea un fichero con permisos, creación y ruta
            Dim impPDF As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, ficheroStream)

            Dim CabPie As New CClassPDFPage

            CabPie.Logo = imgNBA.Image
            CabPie.NombreBD = nombreBD
            CabPie.Anyo = 2008
            CabPie.ColorTinta1 = Color.Black
            CabPie.TotalRegistros = miBindingsourceJug.Count

            'Saber cuántas páginas habrá en total volvando el PDF en MEMORIA
            doc_page.Open()
            ExportPDF(doc_page, RejillaJugadores)
            CabPie.TotalPaginas = impPDF_P.PageNumber
            doc_page.Close()

            'Generación de informe PDF en ARCHIVO
            impPDF.PageEvent = CabPie
            doc.Open()

            ExportPDF(doc, RejillaJugadores)
            doc.Close()
            ficheroStream.Close()
            Process.Start(nombreFichero) 'Visualizar el PDF ya terminado

        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento en PDF" & Chr(13) & ex.Message & Chr(13) & "Puede existir otra exportación de PDF abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Crea la tabla que se mostrará en el PDF con la estructura que se le indique
    Sub ExportPDF(ByVal document As iTextSharp.text.Document, Rejilla As DataGridView)
        'Se crea un objeto PDFTable con el número de columnas del DataGridView
        Dim MiGrid As DataGridView = Rejilla
        Dim NColum As Integer = MiGrid.ColumnCount
        Dim dataTable As New iTextSharp.text.pdf.PdfPTable(NColum)

        'Se asignan algunas propiedades para el diseño del PDF
        dataTable.DefaultCell.Padding = 3
        Dim headerWidths As Single() = GetColumnaSize(Rejilla)
        With dataTable
            .SetWidths(headerWidths)
            .WidthPercentage = 100
            .DefaultCell.BorderWidth = 2
            .DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
            .DefaultCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT
        End With

        'Se crea el encabezado de la primera página del PDF
        'Se capturan los nombres de las columnas del DataGridView
        For i As Integer = 0 To NColum - 1
            dataTable.AddCell(New iTextSharp.text.Phrase(MiGrid.Columns(i).HeaderText, New iTextSharp.text.Font(Font.Name = "Arial", 7, Font.Bold)))
        Next

        dataTable.HeaderRows = 1
        dataTable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE
        dataTable.DefaultCell.BorderWidth = 1

        'Se generan las columnas del DataGridView
        For i As Integer = 0 To MiGrid.RowCount - 2
            For j As Integer = 0 To NColum - 1
                dataTable.AddCell(New iTextSharp.text.Phrase(MiGrid(j, i).Value.ToString, New iTextSharp.text.Font(Font.Name = "Arial", 7, Font.Italic)))
            Next
            dataTable.CompleteRow()
        Next

        'Se agrega el PDFTable al documento
        document.Add(dataTable)

    End Sub

    'Obtiene el tamaño de las columnas de la rejilla
    Public Function GetColumnaSize(ByVal dg As DataGridView) As Single()
        'Crea vector de valores del ancho de las columnas
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

End Class


Public Class MipreviewPrintDialog
    Inherits PrintPreviewDialog

    'Si se pulsa Esc se cierra la vista previa
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (keyData = Keys.Escape) Then
            Me.Close()
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    'Controla el movimiento que se hace con la rueda del ratón
    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        Dim Miupdown As NumericUpDown = Controls(1).Controls(0)
        Try
            Miupdown.Value -= e.Delta / 120
        Catch ex As Exception
            Miupdown.Value = 1
        End Try
        MyBase.OnMouseWheel(e)
    End Sub

    Private Sub InitialilzeComponent()
        Me.SuspendLayout()
        Me.ClientSize = New System.Drawing.Size(639, 453)
        Me.Name = "MiPreviewPrintDialog"
        Me.ResumeLayout(False)
    End Sub

End Class

