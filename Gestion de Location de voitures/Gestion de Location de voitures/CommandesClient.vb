Imports System.Data.OleDb
Public Class CommandesClient
    Dim thedatatable As New DataTable
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim locVariable As String

    Public Property Variable() As String
        Get
            Return locVariable
        End Get
        Set(ByVal value As String)
            locVariable = value
        End Set
    End Property

    Private Sub CommandesClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM commandes where CINClient ='" & locVariable & "';"
        rd = cmd.ExecuteReader

        With thedatatable
            .Columns.Add("reference", System.Type.GetType("System.String"))
            .Columns.Add("Nom", System.Type.GetType("System.String"))
            .Columns.Add("Description", System.Type.GetType("System.String"))
            .Columns.Add("Stock", System.Type.GetType("System.String"))
            .Columns.Add("PrixJour", System.Type.GetType("System.String"))
            .Columns.Add("Statut", System.Type.GetType("System.String"))

            While rd.Read
                .Rows.Add(rd.GetValue(0), rd.GetValue(1), rd.GetValue(2), rd.GetValue(3), rd.GetValue(4), rd.GetValue(5))
            End While
            cn.Close()
            DataGridView1.ScrollBars = ScrollBars.Vertical
            DataGridView1.DataSource = thedatatable
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class