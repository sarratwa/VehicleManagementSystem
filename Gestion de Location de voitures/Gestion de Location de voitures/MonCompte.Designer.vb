<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonCompte
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nomTextBox = New System.Windows.Forms.TextBox()
        Me.cinTextBox = New System.Windows.Forms.TextBox()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.villeTextBox = New System.Windows.Forms.TextBox()
        Me.adresseTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddAgentButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 490)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(42, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom & Prénom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(42, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(42, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(42, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adresse"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(42, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(42, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Password"
        Me.Label7.Visible = False
        '
        'nomTextBox
        '
        Me.nomTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.nomTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.nomTextBox.Location = New System.Drawing.Point(180, 51)
        Me.nomTextBox.Name = "nomTextBox"
        Me.nomTextBox.ReadOnly = True
        Me.nomTextBox.Size = New System.Drawing.Size(234, 30)
        Me.nomTextBox.TabIndex = 11
        '
        'cinTextBox
        '
        Me.cinTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cinTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.cinTextBox.Location = New System.Drawing.Point(180, 100)
        Me.cinTextBox.Name = "cinTextBox"
        Me.cinTextBox.ReadOnly = True
        Me.cinTextBox.Size = New System.Drawing.Size(234, 30)
        Me.cinTextBox.TabIndex = 12
        '
        'ageTextBox
        '
        Me.ageTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ageTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.ageTextBox.Location = New System.Drawing.Point(180, 146)
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.ReadOnly = True
        Me.ageTextBox.Size = New System.Drawing.Size(234, 30)
        Me.ageTextBox.TabIndex = 13
        '
        'villeTextBox
        '
        Me.villeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.villeTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.villeTextBox.Location = New System.Drawing.Point(180, 194)
        Me.villeTextBox.Name = "villeTextBox"
        Me.villeTextBox.ReadOnly = True
        Me.villeTextBox.Size = New System.Drawing.Size(234, 30)
        Me.villeTextBox.TabIndex = 14
        '
        'adresseTextBox
        '
        Me.adresseTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.adresseTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.adresseTextBox.Location = New System.Drawing.Point(180, 240)
        Me.adresseTextBox.Name = "adresseTextBox"
        Me.adresseTextBox.ReadOnly = True
        Me.adresseTextBox.Size = New System.Drawing.Size(234, 30)
        Me.adresseTextBox.TabIndex = 15
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.emailTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.emailTextBox.Location = New System.Drawing.Point(180, 292)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.ReadOnly = True
        Me.emailTextBox.Size = New System.Drawing.Size(234, 30)
        Me.emailTextBox.TabIndex = 16
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.0!)
        Me.passwordTextBox.Location = New System.Drawing.Point(180, 339)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.ReadOnly = True
        Me.passwordTextBox.Size = New System.Drawing.Size(234, 30)
        Me.passwordTextBox.TabIndex = 17
        Me.passwordTextBox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddAgentButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.passwordTextBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.emailTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.adresseTextBox)
        Me.Panel1.Controls.Add(Me.nomTextBox)
        Me.Panel1.Controls.Add(Me.villeTextBox)
        Me.Panel1.Controls.Add(Me.cinTextBox)
        Me.Panel1.Controls.Add(Me.ageTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 490)
        Me.Panel1.TabIndex = 18
        '
        'AddAgentButton
        '
        Me.AddAgentButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AddAgentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AddAgentButton.FlatAppearance.BorderSize = 0
        Me.AddAgentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddAgentButton.Font = New System.Drawing.Font("Microsoft JhengHei Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAgentButton.ForeColor = System.Drawing.Color.Black
        Me.AddAgentButton.Location = New System.Drawing.Point(46, 400)
        Me.AddAgentButton.Name = "AddAgentButton"
        Me.AddAgentButton.Size = New System.Drawing.Size(368, 60)
        Me.AddAgentButton.TabIndex = 3
        Me.AddAgentButton.Text = "Ajouter un Agent"
        Me.AddAgentButton.UseVisualStyleBackColor = False
        Me.AddAgentButton.Visible = False
        '
        'MonCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 490)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MonCompte"
        Me.Text = "Mon Compte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents villeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adresseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddAgentButton As System.Windows.Forms.Button
End Class
