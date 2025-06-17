<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reglage
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
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.RB_map1 = New System.Windows.Forms.RadioButton()
        Me.RB_map2 = New System.Windows.Forms.RadioButton()
        Me.RB_map3 = New System.Windows.Forms.RadioButton()
        Me.RB_map4 = New System.Windows.Forms.RadioButton()
        Me.RB_map5 = New System.Windows.Forms.RadioButton()
        Me.lbl_map5 = New System.Windows.Forms.Label()
        Me.lbl_map4 = New System.Windows.Forms.Label()
        Me.lbl_map3 = New System.Windows.Forms.Label()
        Me.lbl_map2 = New System.Windows.Forms.Label()
        Me.lbl_map1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(356, 270)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(141, 72)
        Me.btnRetour.TabIndex = 6
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'RB_map1
        '
        Me.RB_map1.AutoSize = True
        Me.RB_map1.Checked = True
        Me.RB_map1.Location = New System.Drawing.Point(10, 79)
        Me.RB_map1.Name = "RB_map1"
        Me.RB_map1.Size = New System.Drawing.Size(55, 17)
        Me.RB_map1.TabIndex = 7
        Me.RB_map1.TabStop = True
        Me.RB_map1.Text = "Map 1"
        Me.RB_map1.UseVisualStyleBackColor = True
        '
        'RB_map2
        '
        Me.RB_map2.AutoSize = True
        Me.RB_map2.Location = New System.Drawing.Point(184, 79)
        Me.RB_map2.Name = "RB_map2"
        Me.RB_map2.Size = New System.Drawing.Size(55, 17)
        Me.RB_map2.TabIndex = 9
        Me.RB_map2.Text = "Map 2"
        Me.RB_map2.UseVisualStyleBackColor = True
        '
        'RB_map3
        '
        Me.RB_map3.AutoSize = True
        Me.RB_map3.Location = New System.Drawing.Point(356, 79)
        Me.RB_map3.Name = "RB_map3"
        Me.RB_map3.Size = New System.Drawing.Size(55, 17)
        Me.RB_map3.TabIndex = 10
        Me.RB_map3.Text = "Map 3"
        Me.RB_map3.UseVisualStyleBackColor = True
        '
        'RB_map4
        '
        Me.RB_map4.AutoSize = True
        Me.RB_map4.Location = New System.Drawing.Point(539, 79)
        Me.RB_map4.Name = "RB_map4"
        Me.RB_map4.Size = New System.Drawing.Size(55, 17)
        Me.RB_map4.TabIndex = 11
        Me.RB_map4.Text = "Map 4"
        Me.RB_map4.UseVisualStyleBackColor = True
        '
        'RB_map5
        '
        Me.RB_map5.AutoSize = True
        Me.RB_map5.Location = New System.Drawing.Point(710, 79)
        Me.RB_map5.Name = "RB_map5"
        Me.RB_map5.Size = New System.Drawing.Size(55, 17)
        Me.RB_map5.TabIndex = 12
        Me.RB_map5.Text = "Map 5"
        Me.RB_map5.UseVisualStyleBackColor = True
        '
        'lbl_map5
        '
        Me.lbl_map5.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_map5.Location = New System.Drawing.Point(707, 113)
        Me.lbl_map5.Name = "lbl_map5"
        Me.lbl_map5.Size = New System.Drawing.Size(144, 99)
        Me.lbl_map5.TabIndex = 16
        '
        'lbl_map4
        '
        Me.lbl_map4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_map4.Location = New System.Drawing.Point(536, 113)
        Me.lbl_map4.Name = "lbl_map4"
        Me.lbl_map4.Size = New System.Drawing.Size(144, 99)
        Me.lbl_map4.TabIndex = 15
        '
        'lbl_map3
        '
        Me.lbl_map3.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_map3.Location = New System.Drawing.Point(353, 113)
        Me.lbl_map3.Name = "lbl_map3"
        Me.lbl_map3.Size = New System.Drawing.Size(144, 99)
        Me.lbl_map3.TabIndex = 14
        '
        'lbl_map2
        '
        Me.lbl_map2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_map2.Location = New System.Drawing.Point(181, 113)
        Me.lbl_map2.Name = "lbl_map2"
        Me.lbl_map2.Size = New System.Drawing.Size(144, 99)
        Me.lbl_map2.TabIndex = 13
        '
        'lbl_map1
        '
        Me.lbl_map1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_map1.Location = New System.Drawing.Point(10, 113)
        Me.lbl_map1.Name = "lbl_map1"
        Me.lbl_map1.Size = New System.Drawing.Size(144, 99)
        Me.lbl_map1.TabIndex = 8
        '
        'reglage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 367)
        Me.Controls.Add(Me.lbl_map5)
        Me.Controls.Add(Me.lbl_map4)
        Me.Controls.Add(Me.lbl_map3)
        Me.Controls.Add(Me.lbl_map2)
        Me.Controls.Add(Me.RB_map5)
        Me.Controls.Add(Me.RB_map4)
        Me.Controls.Add(Me.RB_map3)
        Me.Controls.Add(Me.RB_map2)
        Me.Controls.Add(Me.lbl_map1)
        Me.Controls.Add(Me.RB_map1)
        Me.Controls.Add(Me.btnRetour)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "reglage"
        Me.Text = "Règlages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents RB_map1 As RadioButton
    Friend WithEvents lbl_map1 As Label
    Friend WithEvents RB_map2 As RadioButton
    Friend WithEvents RB_map3 As RadioButton
    Friend WithEvents RB_map4 As RadioButton
    Friend WithEvents RB_map5 As RadioButton
    Friend WithEvents lbl_map2 As Label
    Friend WithEvents lbl_map3 As Label
    Friend WithEvents lbl_map4 As Label
    Friend WithEvents lbl_map5 As Label
End Class
