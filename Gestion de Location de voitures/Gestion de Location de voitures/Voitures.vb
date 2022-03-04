Imports System.Data.OleDb
Public Class Voitures
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

    Private cin As String = ""

    Public Property Variable2() As String
        Get
            Return cin
        End Get
        Set(ByVal value As String)
            cin = value
        End Set
    End Property

    Private Sub Voitures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If locVariable = "admin" Then
            Panel1.Visible = True
        End If
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM voitures ;"
        rd = cmd.ExecuteReader

        With thedatatable
            .Columns.Add("REFERENCES", System.Type.GetType("System.String"))
            .Columns.Add("NOM", System.Type.GetType("System.String"))
            .Columns.Add("DESCRIPTION", System.Type.GetType("System.String"))
            .Columns.Add("STOCK", System.Type.GetType("System.String"))
            .Columns.Add("PRIX/Jour", System.Type.GetType("System.String"))

            While rd.Read
                .Rows.Add(rd.GetValue(0), rd.GetValue(1), rd.GetValue(2), rd.GetValue(3), rd.GetValue(4))
            End While
            cn.Close()
            DataGridView1.ScrollBars = ScrollBars.Vertical
            DataGridView1.DataSource = thedatatable
        End With
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        Dim sqlQry As String = "INSERT INTO voitures ([reference], [Nom], [Description], [Stock], [PrixJour]) VALUES (@TextBox1.Text , @TextBox2.Text , @TextBox3.Text , @TextBox5.Text , @TextBox4.Text )"
        Using cmd As New OleDbCommand(sqlQry, cn)
            cmd.Parameters.AddWithValue("@reference", TextBox1.Text)
            cmd.Parameters.AddWithValue("@Nom", TextBox2.Text)
            cmd.Parameters.AddWithValue("@Description", TextBox3.Text)
            cmd.Parameters.AddWithValue("@Stock", TextBox5.Text)
            cmd.Parameters.AddWithValue("@PrixJour", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Voiture ajouté avec succès", MsgBoxStyle.Information, "La Voiture est créer")
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
        cmd.CommandText = "delete from voitures where reference ='" & TextBox1.Text & "';"
        Dim Res As Integer = cmd.ExecuteNonQuery()
        If (Res = 0) Then
            MsgBox(" la supression à échoué", MsgBoxStyle.Information, "supprimer Voitures")
        Else
            MsgBox("suppression effectuée avec succès", MsgBoxStyle.Information, "Supprimer Voitures")
        End If
        cn.Close()
        Me.Hide()
        _2_PagePrincipale.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        Dim stock As String
        Dim calculer As Integer
        Dim stockinter As String = "1"
        cmd.CommandText = "Select * from voitures WHERE reference = '" & TextBox6.Text & "';"
        rd = cmd.ExecuteReader
        If rd.Read Then
            stockinter = rd.GetValue(3)
        End If
        calculer = Convert.ToInt32(stockinter) - 1
        stock = Convert.ToString(calculer)
        Dim valider As Boolean = False
        If (calculer >= 0) Then
            valider = True
        End If
        cn.Close()
        MessageBox.Show(valider)
        If valider Then
            Try
                cn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            cmd = cn.CreateCommand()
            Dim sqlqry1 As String = "update voitures set Stock = '" & stock & "' where reference = '" & TextBox6.Text & "';"
            Using cmd As New OleDbCommand(sqlqry1, cn)
                cmd.ExecuteNonQuery()
                Me.Hide()
                _2_PagePrincipale.Show()
            End Using
            cn.Close()

            Try
                cn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            cmd = cn.CreateCommand()
            Dim statut As String = "non"
            Dim dates As String = Convert.ToString(DateTimePicker1.Text)
            Dim sqlqry As String = "insert into commandes ([cinclient], [referencevoiture], [nombreheure], [datelocation], [statut]) values (@cin , @textbox6.text , @textbox7.text , @dates , @statut )"
            Using cmd As New OleDbCommand(sqlqry, cn)
                cmd.Parameters.AddWithValue("@cinclient", cin)
                cmd.Parameters.AddWithValue("@referencevoiture", TextBox6.Text)
                cmd.Parameters.AddWithValue("@nombreheure", TextBox7.Text)
                cmd.Parameters.AddWithValue("@datelocation", dates)
                cmd.Parameters.AddWithValue("@statut", statut)
                cmd.ExecuteNonQuery()
                MsgBox("voiture commandé avec succès", MsgBoxStyle.Information, "la voiture est commandé")
            End Using
            cn.Close()
            Me.Hide()
            _2_PagePrincipale.Show()
        End If
    End Sub
End Class