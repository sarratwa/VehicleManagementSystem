Imports System.Data.OleDb

Public Class MonCompte
    Private statut As String

    Private locVariable As String

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Public Property Variable() As String
        Get
            Return locVariable
        End Get
        Set(ByVal value As String)
            locVariable = value
        End Set
    End Property

    Private Sub load()
        nomTextBox.ReadOnly() = True
        cinTextBox.ReadOnly() = True
        ageTextBox.ReadOnly() = True
        villeTextBox.ReadOnly() = True
        adresseTextBox.ReadOnly() = True
        passwordTextBox.ReadOnly() = True
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM utilisateur WHERE email ='" & locVariable & "' ;"
        rd = cmd.ExecuteReader
        If rd.Read Then
            nomTextBox.Text = rd.GetValue(2)
            cinTextBox.Text = rd.GetValue(0)
            ageTextBox.Text = rd.GetValue(3)
            villeTextBox.Text = rd.GetValue(6)
            adresseTextBox.Text = rd.GetValue(5)
            emailTextBox.Text = rd.GetValue(7)
            passwordTextBox.Text = rd.GetValue(1)
            statut = rd.GetValue(4)
        End If
        If statut = "admin" Then
            AddAgentButton.Visible = True
        End If
        cn.Close()
    End Sub

    Private Sub MonCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Private Sub AddAgentButton_Click(sender As Object, e As EventArgs) Handles AddAgentButton.Click
        signup.Variable = emailTextBox.Text
        signup.Show()
    End Sub
End Class