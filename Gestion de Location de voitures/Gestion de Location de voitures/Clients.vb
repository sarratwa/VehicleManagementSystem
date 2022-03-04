Imports System.Data.OleDb
Public Class Clients
    Dim thedatatable As New DataTable
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Private locVariable As String

    Public Property Variable() As String
        Get
            Return locVariable
        End Get
        Set(ByVal value As String)
            locVariable = value
        End Set
    End Property

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM utilisateur ;"
        rd = cmd.ExecuteReader

        With thedatatable
            .Columns.Add("CIN", System.Type.GetType("System.String"))
            .Columns.Add("NOM", System.Type.GetType("System.String"))
            .Columns.Add("AGE", System.Type.GetType("System.String"))
            .Columns.Add("VILLE", System.Type.GetType("System.String"))
            .Columns.Add("ADRESSE", System.Type.GetType("System.String"))
            .Columns.Add("EMAIL", System.Type.GetType("System.String"))
            .Columns.Add("MOT DE PASSE", System.Type.GetType("System.String"))
            .Columns.Add("STATUT", System.Type.GetType("System.String"))

            While rd.Read
                .Rows.Add(rd.GetValue(0), rd.GetValue(2), rd.GetValue(3), rd.GetValue(6), rd.GetValue(5), rd.GetValue(7), rd.GetValue(2), rd.GetValue(4))
            End While
            cn.Close()
            DataGridView1.ScrollBars = ScrollBars.Vertical
            DataGridView1.DataSource = thedatatable
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd.CommandText = "delete from utilisateur where CIN =" & Integer.Parse(TextBox2.Text) & ";"
        Dim Res As Integer = cmd.ExecuteNonQuery()
        If (Res = 0) Then
            MsgBox(" la supression à échoué", MsgBoxStyle.Information, "supprimer film")
        Else
            MsgBox("suppression effectuée avec succès", MsgBoxStyle.Information, "Supprimer film")
        End If
        cn.Close()
        Me.Hide()
        _2_PagePrincipale.Show()
    End Sub
End Class