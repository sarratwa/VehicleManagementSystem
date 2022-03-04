Imports System.Data.OleDb
Public Class signup
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim statut As String = "client"
    Private locVariable As String = ""

    Private Sub Reset()
        NomText.Text = ""
        CINtext.Text = ""
        EmailText.Text = ""
        motpasseText.Text = ""
        ageComboBox.SelectedIndex = -1
        AdresseText.Text = ""
        VilleComboBox.SelectedIndex = -1
    End Sub

    Public Property Variable() As String
        Get
            Return locVariable
        End Get
        Set(ByVal value As String)
            locVariable = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If locVariable <> "" Then
            statut = "admin"
        End If
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        Dim age As String = ageComboBox.SelectedItem.ToString()
        Dim ville As String = VilleComboBox.SelectedItem.ToString()
        Dim sqlQry As String = "INSERT INTO utilisateur ([CIN], [password], [NomP], [age], [statut], [adresse], [ville], [email]) VALUES (@CINtext.Text , @motpasseText.Text , @NomText.Text , @age , @statut , @AdresseText.Text , @ville , @EmailText.Text)"
        Using cmd As New OleDbCommand(sqlQry, cn)
            cmd.Parameters.AddWithValue("@CIN", CINtext.Text)
            cmd.Parameters.AddWithValue("@password", motpasseText.Text)
            cmd.Parameters.AddWithValue("@NomP", NomText.Text)
            cmd.Parameters.AddWithValue("@age", age)
            cmd.Parameters.AddWithValue("@statut", statut)
            cmd.Parameters.AddWithValue("@adresse", AdresseText.Text)
            cmd.Parameters.AddWithValue("@ville", ville)
            cmd.Parameters.AddWithValue("@email", EmailText.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Compte ajouté avec succès", MsgBoxStyle.Information, "Le compte est créer")
            Me.Close()
            If locVariable <> "" Then
                _2_PagePrincipale.Variable = locVariable
                _2_PagePrincipale.Show()
            Else
                _1_Login.Show()
            End If
        End Using
        'cmd.CommandText = "insert into utilisateur values(" & Integer.Parse(CINtext.Text) & ",'" & motpasseText.Text & "','" & NomText.Text & "'," & Integer.Parse(ageComboBox.SelectedItem.ToString()) & ",'" & statut & "','" & AdresseText.Text & "','" & VilleComboBox.SelectedItem.ToString() & "','" & EmailText.Text & "'); "
        cn.Close()
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        VilleComboBox.Items.Add("Megrin")
        VilleComboBox.Items.Add("Sidi Rzig")
        VilleComboBox.Items.Add("Rades")
        VilleComboBox.Items.Add("Rades Melien")
        VilleComboBox.Items.Add("Ez-zahra")
        VilleComboBox.Items.Add("Boumhal")
        VilleComboBox.Items.Add("Hamamlif")
        VilleComboBox.Items.Add("Hamem plage")
        VilleComboBox.SelectedIndex = -1
        For i As Integer = 18 To 80
            ageComboBox.Items.Add(Convert.ToString(i))
        Next
    End Sub
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        If locVariable <> "" Then
            _2_PagePrincipale.Variable = locVariable
            _2_PagePrincipale.Show()
        Else
            _1_Login.Show()
        End If
    End Sub
End Class