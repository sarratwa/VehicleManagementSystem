<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CINtext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NomText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.motpasseText = New System.Windows.Forms.TextBox()
        Me.AdresseText = New System.Windows.Forms.TextBox()
        Me.VilleComboBox = New System.Windows.Forms.ComboBox()
        Me.CINerrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.champvideerrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MotpasseErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.emailErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ageComboBox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.CINerrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.champvideerrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotpasseErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei Light", 13.8!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(151, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SIGN UP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CIN"
        '
        'CINtext
        '
        Me.CINtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.CINtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CINtext.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.CINtext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CINtext.Location = New System.Drawing.Point(151, 28)
        Me.CINtext.Name = "CINtext"
        Me.CINtext.Size = New System.Drawing.Size(148, 31)
        Me.CINtext.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom & Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(326, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(36, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Adresse"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei Light", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Mot de Passe"
        '
        'NomText
        '
        Me.NomText.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NomText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomText.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.NomText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NomText.Location = New System.Drawing.Point(151, 81)
        Me.NomText.Name = "NomText"
        Me.NomText.Size = New System.Drawing.Size(296, 31)
        Me.NomText.TabIndex = 10
        '
        'EmailText
        '
        Me.EmailText.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailText.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.EmailText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EmailText.Location = New System.Drawing.Point(151, 174)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(296, 31)
        Me.EmailText.TabIndex = 11
        '
        'motpasseText
        '
        Me.motpasseText.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.motpasseText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.motpasseText.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.motpasseText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.motpasseText.Location = New System.Drawing.Point(151, 238)
        Me.motpasseText.Name = "motpasseText"
        Me.motpasseText.Size = New System.Drawing.Size(296, 31)
        Me.motpasseText.TabIndex = 12
        '
        'AdresseText
        '
        Me.AdresseText.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.AdresseText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdresseText.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.AdresseText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.AdresseText.Location = New System.Drawing.Point(151, 386)
        Me.AdresseText.Name = "AdresseText"
        Me.AdresseText.Size = New System.Drawing.Size(296, 31)
        Me.AdresseText.TabIndex = 14
        '
        'VilleComboBox
        '
        Me.VilleComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.VilleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VilleComboBox.Font = New System.Drawing.Font("Microsoft JhengHei Light", 10.8!)
        Me.VilleComboBox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.VilleComboBox.FormattingEnabled = True
        Me.VilleComboBox.Location = New System.Drawing.Point(151, 327)
        Me.VilleComboBox.Name = "VilleComboBox"
        Me.VilleComboBox.Size = New System.Drawing.Size(296, 31)
        Me.VilleComboBox.TabIndex = 15
        '
        'CINerrorProvider
        '
        Me.CINerrorProvider.ContainerControl = Me
        '
        'champvideerrorProvider
        '
        Me.champvideerrorProvider.ContainerControl = Me
        '
        'MotpasseErrorProvider
        '
        Me.MotpasseErrorProvider.ContainerControl = Me
        '
        'emailErrorProvider
        '
        Me.emailErrorProvider.ContainerControl = Me
        '
        'ageComboBox
        '
        Me.ageComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ageComboBox.Font = New System.Drawing.Font("Microsoft YaHei Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageComboBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.ageComboBox.FormattingEnabled = True
        Me.ageComboBox.Location = New System.Drawing.Point(368, 28)
        Me.ageComboBox.Name = "ageComboBox"
        Me.ageComboBox.Size = New System.Drawing.Size(79, 32)
        Me.ageComboBox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(40, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 47)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(472, 531)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ageComboBox)
        Me.Controls.Add(Me.VilleComboBox)
        Me.Controls.Add(Me.AdresseText)
        Me.Controls.Add(Me.motpasseText)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.NomText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CINtext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "signup"
        Me.Text = "signup"
        CType(Me.CINerrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.champvideerrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotpasseErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CINtext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NomText As System.Windows.Forms.TextBox
    Friend WithEvents EmailText As System.Windows.Forms.TextBox
    Friend WithEvents motpasseText As System.Windows.Forms.TextBox
    Friend WithEvents AdresseText As System.Windows.Forms.TextBox
    Friend WithEvents VilleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CINerrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents champvideerrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents MotpasseErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents emailErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
