Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class CClassPDFPage
    Inherits PdfPageEventHelper

    Public NombreBD As String
    Public Anyo As String
    Public Logo As Drawing.Image
    Public TotalPaginas As Integer
    Public TotalRegistros As Integer
    Public ColorTinta1 As Color

    Public Overrides Sub OnStartPage(writer As PdfWriter, document As iTextSharp.text.Document)
        Dim uImagen As Image
        Dim cbPie As PdfContentByte
        Dim cbPie2 As PdfContentByte
        Dim cbEncabezado As PdfContentByte
        Dim cbEncabezado2 As PdfContentByte

        '----DEFINICIÓN DEL OBJETO PdfContentByte PARA EL ENCABEZADO------
        'Encabezado parte izquierda de la página
        cbEncabezado = writer.DirectContent
        With cbEncabezado
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 9) 'Al importar iTextSharp.text no hace falta que escriba todo el espacio de nombres
            .SetColorFill(BaseColor.BLACK)
            .ShowTextAligned(PdfContentByte.ALIGN_LEFT, NombreBD, 20, 545, 0) 'Alineación del texto y posición (ALIGN_LEFT no significa izquierda de la pág)
            .EndText()
        End With

        '----Añadir imagen a la izquierda
        uImagen = Image.GetInstance(Logo, Imaging.ImageFormat.Png)
        uImagen.SetAbsolutePosition(20, 555)
        uImagen.ScaleAbsoluteHeight(30)
        uImagen.ScaleAbsoluteWidth(80)
        uImagen.BorderWidth = 3
        uImagen.BorderColor = BaseColor.BLUE
        document.Add(uImagen)

        'Encabezado parte derecha de la página
        cbEncabezado2 = writer.DirectContent
        Dim ColorInk As New BaseColor(ColorTinta1)
        With cbEncabezado2
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 6)
            .SetColorFill(ColorInk)
            .ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Anyo, 790, 543, 0)
            .EndText()
        End With

        '-------PIE DE PÁGINA------
        cbPie = writer.DirectContent
        With cbPie
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 8)
            .SetColorFill(BaseColor.BLACK)
            .ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Página: " & writer.PageNumber & " de " & TotalPaginas, 780, 8, 0)
        End With
        If writer.PageNumber = TotalPaginas Then
            cbPie.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Total Registros: " & TotalRegistros, 20, 8, 0)
        End If
        cbPie.EndText()


        cbPie2 = writer.DirectContent
        With cbPie2
            .BeginText()
            .SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, Font.DEFAULTSIZE, Font.NORMAL).BaseFont, 6)
            .SetColorFill(BaseColor.BLACK)
            .ShowTextAligned(PdfContentByte.ALIGN_LEFT, Now.ToLongDateString, 400, 8, 0)
            .EndText()
        End With
    End Sub
End Class
