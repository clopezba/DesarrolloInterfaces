Imports System.Data.SqlClient
Imports System.IO

Public Class DatosPersonal
    Dim con As SqlConnection
    Dim rejilla As New DataView
    Private Sub DatosPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection
        Dim direcActual As String = Directory.GetCurrentDirectory()
        Dim directorio As String = Directory.GetParent(Directory.GetParent(direcActual).ToString()).ToString()
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & directorio & "\BDRegistro.mdf;Integrated Security=True"
        Try
            con.Open()
            Console.WriteLine("Conectado")
        Catch ex As Exception
            Console.WriteLine("No se ha podido conectar. Error: " + ex.Message)
        End Try

        Dim adaptador As New SqlDataAdapter("SELECT NumRegistro, Nombre, Apellidos, DNI, FechaNacimiento, DepAutorizador, PeriodoAcceso FROM RegPersonal", con)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        rejilla.Table = datos.Tables(0)
        RejillaDatos.DataSource = rejilla
    End Sub

    Private Sub cmbFiltrarAcceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltrarAcceso.SelectedIndexChanged
        rejilla.RowFilter = String.Format("PeriodoAcceso = '{0}'", cmbFiltrarAcceso.SelectedItem)
    End Sub

    Private Sub DatosPersonal_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Try
            con.Close()
            Console.WriteLine("Desconectado")
        Catch ex As Exception
            Console.WriteLine("No se ha podido desconectar. Error: " + ex.Message)
        End Try
    End Sub
End Class