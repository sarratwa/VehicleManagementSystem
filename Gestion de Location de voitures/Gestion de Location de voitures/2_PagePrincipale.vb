Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class _2_PagePrincipale


    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private locVariable As String
    Private locCIN As String
    Private Statut As String = ""

    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rd As OleDbDataReader

    Dim drag As Boolean = False
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub TitlePanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitlePanel.MouseClick
        If drag = False Then
            drag = True 'Sets the variable drag to true.
            mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
            mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
        Else
            drag = False
        End If
        
    End Sub

    Private Sub TitlePanel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitlePanel.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Picturebox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Public Property Variable() As String
        Get
            Return locVariable
        End Get
        Set(ByVal value As String)
            locVariable = value
        End Set
    End Property

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        ControlPanel.Controls.Add(leftBorderBtn)
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Buttons
            currentBtn = senderBtn
            currentBtn.BackColor = Color.FromArgb(47, 43, 162)
            currentBtn.ForeColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleRight
            'left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 3, 105)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form, image As Image)
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
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        TitleLabel.Text = childForm.Text
        TitlePic.Image = image
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActivateButton(sender, Color.FromArgb(172, 126, 241))
        MonCompte.Variable = locVariable
        OpenChildForm(MonCompte, PictureBox1.Image)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ActivateButton(sender, Color.FromArgb(249, 118, 176))
        If Statut = "client" Then
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
                locCIN = rd.GetValue(0)
            End If
            cn.Close()
            CommandesClient.Variable = locCIN
            OpenChildForm(CommandesClient, PictureBox2.Image)
        Else
            OpenChildForm(CommandesSociete, PictureBox2.Image)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActivateButton(sender, Color.FromArgb(253, 138, 114))
        Voitures.Variable = Statut
        Voitures.Variable2 = locCIN
        OpenChildForm(Voitures, PictureBox3.Image)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ActivateButton(sender, Color.FromArgb(95, 77, 221))
        OpenChildForm(Clients, PictureBox4.Image)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActivateButton(sender, Color.FromArgb(24, 161, 251))
        OpenChildForm(Paramétres, PictureBox5.Image)
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        TitleLabel.Text = "Page d'Accueil"
        TitlePic.Image = PictureBox1.Image
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        _1_Login.Show()
    End Sub

    Private Sub LogoLabel_Click(sender As Object, e As EventArgs) Handles LogoLabel.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ActivateButton(Button1, Color.FromArgb(172, 126, 241))
        MonCompte.Variable = locVariable
        OpenChildForm(MonCompte, PictureBox1.Image)
    End Sub

    Private Sub _2_PagePrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sarra\OneDrive\Documents\Visual Studio 2012\Projects\Gestion de Location de voitures\Gestion de Location de voitures\Location de Voitures.mdb")
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cmd = cn.CreateCommand()
        cmd.CommandText = "SELECT * FROM utilisateur WHERE email ='" + locVariable + "'; "
        rd = cmd.ExecuteReader
        If rd.Read Then
            Button7.Text = rd.GetValue(2)
            Statut = rd.GetValue(4)
        End If
        cn.Close()
        If Statut = "client" Then
            Button4.Visible = False
            PictureBox4.Visible = False
        End If
    End Sub

End Class