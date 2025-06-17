<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxNbcarte = New System.Windows.Forms.ListBox()
        Me.ListBoxtemps = New System.Windows.Forms.ListBox()
        Me.ListBoxNbpartie = New System.Windows.Forms.ListBox()
        Me.ListBoxCumul = New System.Windows.Forms.ListBox()
        Me.CmBoxJ = New System.Windows.Forms.ComboBox()
        Me.BtnVal = New System.Windows.Forms.Button()
        Me.BtnTri = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(308, 471)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(193, 44)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 16
        Me.ListBoxNom.Location = New System.Drawing.Point(72, 167)
        Me.ListBoxNom.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxNom.TabIndex = 8
        '
        'ListBoxNbcarte
        '
        Me.ListBoxNbcarte.FormattingEnabled = True
        Me.ListBoxNbcarte.ItemHeight = 16
        Me.ListBoxNbcarte.Location = New System.Drawing.Point(308, 167)
        Me.ListBoxNbcarte.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxNbcarte.Name = "ListBoxNbcarte"
        Me.ListBoxNbcarte.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxNbcarte.TabIndex = 9
        '
        'ListBoxtemps
        '
        Me.ListBoxtemps.FormattingEnabled = True
        Me.ListBoxtemps.ItemHeight = 16
        Me.ListBoxtemps.Location = New System.Drawing.Point(535, 167)
        Me.ListBoxtemps.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxtemps.Name = "ListBoxtemps"
        Me.ListBoxtemps.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxtemps.TabIndex = 10
        '
        'ListBoxNbpartie
        '
        Me.ListBoxNbpartie.FormattingEnabled = True
        Me.ListBoxNbpartie.ItemHeight = 16
        Me.ListBoxNbpartie.Location = New System.Drawing.Point(779, 167)
        Me.ListBoxNbpartie.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxNbpartie.Name = "ListBoxNbpartie"
        Me.ListBoxNbpartie.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxNbpartie.TabIndex = 11
        '
        'ListBoxCumul
        '
        Me.ListBoxCumul.FormattingEnabled = True
        Me.ListBoxCumul.ItemHeight = 16
        Me.ListBoxCumul.Location = New System.Drawing.Point(1012, 167)
        Me.ListBoxCumul.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxCumul.Name = "ListBoxCumul"
        Me.ListBoxCumul.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxCumul.TabIndex = 12
        '
        'CmBoxJ
        '
        Me.CmBoxJ.FormattingEnabled = True
        Me.CmBoxJ.Location = New System.Drawing.Point(432, 368)
        Me.CmBoxJ.Margin = New System.Windows.Forms.Padding(4)
        Me.CmBoxJ.Name = "CmBoxJ"
        Me.CmBoxJ.Size = New System.Drawing.Size(177, 24)
        Me.CmBoxJ.TabIndex = 13
        '
        'BtnVal
        '
        Me.BtnVal.Location = New System.Drawing.Point(647, 368)
        Me.BtnVal.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVal.Name = "BtnVal"
        Me.BtnVal.Size = New System.Drawing.Size(139, 28)
        Me.BtnVal.TabIndex = 14
        Me.BtnVal.Text = "Validation"
        Me.BtnVal.UseVisualStyleBackColor = True
        '
        'BtnTri
        '
        Me.BtnTri.Location = New System.Drawing.Point(647, 416)
        Me.BtnTri.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTri.Name = "BtnTri"
        Me.BtnTri.Size = New System.Drawing.Size(100, 28)
        Me.BtnTri.TabIndex = 15
        Me.BtnTri.Text = "Tri"
        Me.BtnTri.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nb cartes trouvées"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Temps"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(775, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nb partie jouées"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1008, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cumul du temps de jeu "
        '
        'btnSupp
        '
        Me.btnSupp.Location = New System.Drawing.Point(817, 368)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(121, 28)
        Me.btnSupp.TabIndex = 21
        Me.btnSupp.Text = "Supprimer"
        Me.btnSupp.UseVisualStyleBackColor = True
        '
        'stat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 718)
        Me.Controls.Add(Me.btnSupp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTri)
        Me.Controls.Add(Me.BtnVal)
        Me.Controls.Add(Me.CmBoxJ)
        Me.Controls.Add(Me.ListBoxCumul)
        Me.Controls.Add(Me.ListBoxNbpartie)
        Me.Controls.Add(Me.ListBoxtemps)
        Me.Controls.Add(Me.ListBoxNbcarte)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.btnRetour)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "stat"
        Me.Text = "Stat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxNbcarte As ListBox
    Friend WithEvents ListBoxtemps As ListBox
    Friend WithEvents ListBoxNbpartie As ListBox
    Friend WithEvents ListBoxCumul As ListBox
    Friend WithEvents CmBoxJ As ComboBox
    Friend WithEvents BtnVal As Button
    Friend WithEvents BtnTri As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSupp As Button
End Class
