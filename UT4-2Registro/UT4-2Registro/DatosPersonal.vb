Imports System.Data.SqlClient

Public Class DatosPersonal
    Dim con As SqlConnection
    Dim rejilla As New DataView
    Private Sub DatosPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BDRegistro.mdf;Integrated Security=True"
        Dim adaptador As New SqlDataAdapter("SELECT NumRegistro, Nombre, Apellidos, DNI, FechaNacimiento, DepAutorizador, PeriodoAcceso FROM RegPersonal", con)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        rejilla.Table = datos.Tables(0)
        RejillaDatos.DataSource = rejilla
    End Sub

    Private Sub cmbFiltrarAcceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltrarAcceso.SelectedIndexChanged
        rejilla.RowFilter = String.Format("PeriodoAcceso = '{0}'", cmbFiltrarAcceso.SelectedItem)
    End Sub
End Class