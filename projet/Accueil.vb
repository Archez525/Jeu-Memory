Public Class accueil
    Private Sub btnPartie_Click(sender As Object, e As EventArgs) Handles btnPartie.Click
        If (Trim(cmbNom.Text) <> "") AndAlso Trim(cmbNom.Text).Length >= 3 Then
            Dim J As New Joueur
            With J
                .Prenom = cmbNom.Text
                .NbPartie = 0
                .MeilleurTemps = 0
                .TempsJoue = 0
            End With

            If Not EnregistrementJoueur.Existe(J.Prenom) AndAlso Not String.IsNullOrEmpty(J.Prenom) Then
                EnregistrementJoueur.ajout(J)
                cmbNom.Items.Add(J.Prenom)
            End If

            If reglage.RB_map1.Checked Then
                ' Créer une instance du formulaire jeu
                Dim partie As New jeu
                partie.Show()
                partie.lblNom.Text = cmbNom.Text
                ' Cacher le formulaire accueil
                Me.Hide()

                ' Réinitialiser le champ de texte
                cmbNom.Text = String.Empty
            ElseIf reglage.RB_map2.Checked Then
                ' Créer une instance du formulaire jeu
                Dim partie As New Map_2
                partie.Show()
                partie.lblNom.Text = cmbNom.Text
                ' Cacher le formulaire accueil
                Me.Hide()

                ' Réinitialiser le champ de texte
                cmbNom.Text = String.Empty
            ElseIf reglage.RB_map3.Checked Then
                ' Créer une instance du formulaire jeu
                Dim partie As New Map_3
                partie.Show()
                partie.lblNom.Text = cmbNom.Text
                ' Cacher le formulaire accueil
                Me.Hide()

                ' Réinitialiser le champ de texte
                cmbNom.Text = String.Empty
            ElseIf reglage.RB_map4.Checked Then
                ' Créer une instance du formulaire jeu
                Dim partie As New Map_4
                partie.Show()
                partie.lblNom.Text = cmbNom.Text
                ' Cacher le formulaire accueil
                Me.Hide()

                ' Réinitialiser le champ de texte
                cmbNom.Text = String.Empty
            Else
                ' Créer une instance du formulaire jeu
                Dim partie As New Map_5
                partie.Show()
                partie.lblNom.Text = cmbNom.Text
                ' Cacher le formulaire accueil
                Me.Hide()

                ' Réinitialiser le champ de texte
                cmbNom.Text = String.Empty
            End If

        Else
            MsgBox("Veuillez saisir un nom d'au moins 3 caractères", MsgBoxStyle.OkOnly, "Erreur Prénom")
            cmbNom.Focus()
        End If

    End Sub

    Private Sub btnReglage_Click(sender As Object, e As EventArgs) Handles btnReglage.Click
        Me.Hide()
        reglage.Show()
    End Sub

    Private Sub btnStat_Click(sender As Object, e As EventArgs) Handles btnStat.Click
        Me.Hide()
        stat.Show()

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim rep As MsgBoxResult
        rep = MsgBox("Voulez vous quitter le jeu ?", vbYesNo, "Fermer le jeu")
        If rep = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerDepuisFichier("joueurs.txt")
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent



        ' Remplir la ComboBox avec les noms
        For i As Integer = 0 To getNbPers() - 1
            cmbNom.Items.Add(getPers(i).Prenom)
        Next
    End Sub
End Class
