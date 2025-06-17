<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accueil
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
        Me.cmbNom = New System.Windows.Forms.ComboBox()
        Me.btnReglage = New System.Windows.Forms.Button()
        Me.btnPartie = New System.Windows.Forms.Button()
        Me.btnStat = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNom
        '
        Me.cmbNom.FormattingEnabled = True
        Me.cmbNom.Location = New System.Drawing.Point(226, 114)
        Me.cmbNom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbNom.Name = "cmbNom"
        Me.cmbNom.Size = New System.Drawing.Size(117, 21)
        Me.cmbNom.TabIndex = 0
        '
        'btnReglage
        '
        Me.btnReglage.Location = New System.Drawing.Point(37, 190)
        Me.btnReglage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReglage.Name = "btnReglage"
        Me.btnReglage.Size = New System.Drawing.Size(117, 36)
        Me.btnReglage.TabIndex = 1
        Me.btnReglage.Text = "Réglages"
        Me.btnReglage.UseVisualStyleBackColor = True
        '
        'btnPartie
        '
        Me.btnPartie.Location = New System.Drawing.Point(226, 190)
        Me.btnPartie.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPartie.Name = "btnPartie"
        Me.btnPartie.Size = New System.Drawing.Size(117, 36)
        Me.btnPartie.TabIndex = 2
        Me.btnPartie.Text = "Nouvelle Partie"
        Me.btnPartie.UseVisualStyleBackColor = True
        '
        'btnStat
        '
        Me.btnStat.Location = New System.Drawing.Point(417, 190)
        Me.btnStat.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStat.Name = "btnStat"
        Me.btnStat.Size = New System.Drawing.Size(117, 36)
        Me.btnStat.TabIndex = 3
        Me.btnStat.Text = "Afficher le(s) score(s)"
        Me.btnStat.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(226, 295)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(117, 36)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Entrez votre nom :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.projet.My.Resources.Resources.YQgT
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'accueil
        '
        Me.AcceptButton = Me.btnPartie
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnStat)
        Me.Controls.Add(Me.btnPartie)
        Me.Controls.Add(Me.btnReglage)
        Me.Controls.Add(Me.cmbNom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "accueil"
        Me.Text = "Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbNom As ComboBox
    Friend WithEvents btnReglage As Button
    Friend WithEvents btnPartie As Button
    Friend WithEvents btnStat As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
