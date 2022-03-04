Imports System.Data.OleDb
Public Class CommandesSociete
    Dim thedatatable As New DataTable
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Private Sub CommandesSociete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM commandes ;"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        Dim ref As Integer = Convert.ToInt32(RefernceTextBox.Text)
        Dim sqlqry5 As String = "update commandes set Statut = 'oui' where IDCommande = " & ref & ";"
        Using cmd As New OleDbCommand(sqlqry5, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Commande Accépté effectuée avec succès", MsgBoxStyle.Information, "Commande Accepté")
            Me.Hide()
            _2_PagePrincipale.Show()
        End Using
        cn.Close()
        Me.Hide()
        _2_PagePrincipale.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim ref As Integer = Convert.ToInt32(RefernceTextBox.Text)
        cmd.CommandText = "delete from commandes where IDCommande =" & ref & ";"
        Dim Res As Integer = cmd.ExecuteNonQuery()
        If (Res = 0) Then
            MsgBox(" Rejetter à échoué", MsgBoxStyle.Information, "erreur")
        Else
            MsgBox("Rejection effectuée avec succès", MsgBoxStyle.Information, "Commande Rejetté")
        End If
        cn.Close()
        Me.Hide()
        _2_PagePrincipale.Show()
    End Sub
End Class