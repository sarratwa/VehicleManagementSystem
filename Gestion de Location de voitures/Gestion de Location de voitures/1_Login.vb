Imports System.Data.OleDb
Public Class _1_Login
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Private locVariable As String

    Private currentChildForm As Form

    Private Sub Reset()
        EmailTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            cn.Open()
        Catch ex As Exception

        End Try
        cmd.CommandText = "SELECT [password] , email FROM [utilisateur] WHERE [password] ='" + PasswordTextBox.Text + "' AND email ='" + EmailTextBox.Text + "'; "
        rd = cmd.ExecuteReader
        If (rd.Read) Then
            locVariable = EmailTextBox.Text
            _2_PagePrincipale.Variable = locVariable
            MonCompte.Variable = locVariable
            Me.Hide()
            _2_PagePrincipale.Show()
        Else
            MsgBox("Le compte n'existe pas !", MsgBoxStyle.Exclamation, "Echec")
        End If
        cn.Close()
        Reset()
    End Sub


    Private Sub _1_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        If currentChildForm Is childForm Then
            Reset()
            Exit Sub
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        OpenChildForm(signup)
    End Sub
End Class