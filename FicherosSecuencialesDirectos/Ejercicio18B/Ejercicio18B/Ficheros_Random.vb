Public Class Ficheros_Random
    'Const LRegistro As Integer = 144 'Número de posiciones que guardo para cada registro
    Structure Registro
        <VBFixedString(20)> Dim Nombre As String 'Delimitar el tamaño de un String
        <VBFixedString(20)> Dim Apellidos As String
        'Dim Nombre() As Char
        'Dim Apellidos() As Char
        Dim FechaNac As Date
    End Structure

    Dim Canal As Integer = FreeFile()
    Dim MiFicha As New Registro
    Dim Archivo As String
    Dim Numreg As Integer = 1 'No existe la posición 0 en los ficheros random

    Private Sub ExistenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenteToolStripMenuItem.Click
        Dim MiAbrir As New OpenFileDialog
        FileClose(Canal)
        MiAbrir.Title = "Abrir nuevo fichero directo..."
        MiAbrir.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        MiAbrir.ShowDialog()
        If MiAbrir.FileName = "" Then Exit Sub
        Archivo = MiAbrir.FileName
        Try
            FileOpen(Canal, Archivo, OpenMode.Random, , , Len(MiFicha)) 'Len() --> Devuelve en bytes el tamaño de la estuctura (Registro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Panel1.Enabled = True
        PBotones.Enabled = True
        Inicio()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        FileClose(canal)
        Me.Dispose()
    End Sub

    Private Sub Traspaso_A_REG()
        With MiFicha
            .Nombre = CNombre.Text.Trim
            .Apellidos = CApellidos.Text.Trim
            Try
                .FechaNac = CFecha.Text
            Catch ex As Exception
                MsgBox("Fecha Incorrecta", MsgBoxStyle.Critical, "Control de Fechas")
                CFecha.Focus()
                Exit Sub
            End Try
        End With
        EscribirRegistro(Archivo, NumReg, MiFicha)
    End Sub

    Public Function LeerRegistro(ByVal Archivo As String, ByVal NumReg As Integer) As Registro  '--> Función
        Dim Miregistro As New Registro
        Try
            FileGet(Canal, Miregistro, NumReg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return MiFicha
            Exit Function
        End Try
        If NumReg = 1 Then
            BAnterior.Enabled = False
        Else
            BAnterior.Enabled = True
        End If
        If EOF(Canal) Then
            BSiguiente.Enabled = False
        Else
            BSiguiente.Enabled = True
        End If
        Return Miregistro '--> Devuelve algo vacío
    End Function

    Public Sub EscribirRegistro(ByVal Archivo As String, ByVal NumReg As Integer, ByVal MiRegistro As Registro)

        Try
            FilePut(canal, MiRegistro, NumReg)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub

    Private Sub BRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRegistrar.Click
        Traspaso_A_REG()
    End Sub

    Private Sub Mostrar_Datos(ByVal Miregistro As Registro)
        With Miregistro
            CNombre.Text = .Nombre
            CApellidos.Text = .Apellidos
            CFecha.Text = .FechaNac
        End With
        LNREG.Text = Numreg
    End Sub

    Private Sub Ficheros_Random_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' ReDim MiFicha.Nombre(CNombre.MaxLength)
        'ReDim MiFicha.Apellidos(CApellidos.MaxLength)
    End Sub

    Private Sub BPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrimero.Click
        Inicio()

    End Sub

    Private Sub BSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSiguiente.Click
        Numreg += 1
        Mostrar_Datos(LeerRegistro(Archivo, Numreg))
    End Sub

    Private Sub BNuevoR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevoR.Click
        NuevoReg()
    End Sub

    Private Sub BAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAnterior.Click
        Numreg -= 1
        Mostrar_Datos(LeerRegistro(Archivo, Numreg))
    End Sub

    Sub Inicio()
        Numreg = 1
        Mostrar_Datos(LeerRegistro(Archivo, Numreg))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Indice As Integer = InputBox("Dame una posición...", "Direcciones")
        Dim RMem As Integer = Numreg
        Numreg = Indice
        Try
            Mostrar_Datos(LeerRegistro(Archivo, Numreg))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Numreg = RMem
            Mostrar_Datos(LeerRegistro(Archivo, Numreg))
            Exit Sub
        End Try

    End Sub

    Private Sub BUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUltimo.Click
        Numreg = LOF(Canal) / Len(MiFicha)
        Mostrar_Datos(LeerRegistro(Archivo, Numreg))
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim MiNuevoArchivo As New SaveFileDialog
        FileClose(Canal)
        With MiNuevoArchivo
            .InitialDirectory = My.Computer.FileSystem.CurrentDirectory
            .Title = "Crear nuevo archivo directo..."
            .ShowDialog()
            If .FileName = "" Then Exit Sub
            Archivo = .FileName
            With My.Computer.FileSystem
                If .FileExists(MiNuevoArchivo.FileName) Then
                    .DeleteFile(MiNuevoArchivo.FileName)
                End If
            End With
        End With
        Try
            FileOpen(Canal, Archivo, OpenMode.Random, , , Len(MiFicha))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Panel1.Enabled = True
        PBotones.Enabled = True
        NuevoReg()
    End Sub

    Private Sub NuevoReg()
        CNombre.Clear()
        CApellidos.Clear()
        CFecha.Clear()
        If LOF(Canal) Then Numreg = (LOF(Canal) / Len(MiFicha)) + 1
        LNREG.Text = Numreg
        CNombre.Focus()
    End Sub
End Class

