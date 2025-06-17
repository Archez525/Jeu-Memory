Imports System.IO

Public Class stat

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
        accueil.Show()
    End Sub

    Private players As New List(Of Joueur)

    Dim ascendingOrder As Boolean = True

    Private Sub stat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlayers()
        UpdateListBoxes()
        CmBoxJ.Items.Clear()
        For Each joueur As Joueur In players
            CmBoxJ.Items.Add(joueur.Prenom)
        Next
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxNbcarte.SelectedIndexChanged, ListBoxCumul.SelectedIndexChanged, ListBoxtemps.SelectedIndexChanged, ListBoxNbpartie.SelectedIndexChanged
        Dim selectedIndex As Integer = sender.SelectedIndex
        If selectedIndex >= 0 Then
            ListBoxNom.SelectedIndex = selectedIndex
            ListBoxNbpartie.SelectedIndex = selectedIndex
            ListBoxCumul.SelectedIndex = selectedIndex
            ListBoxNbcarte.SelectedIndex = selectedIndex
            ListBoxtemps.SelectedIndex = selectedIndex
            CmBoxJ.Text = ListBoxNom.SelectedItem
        End If
    End Sub

    Private Sub LoadPlayers()
        players.Clear()
        For i As Integer = 0 To EnregistrementJoueur.getNbPers() - 1
            Dim j As Joueur = EnregistrementJoueur.getPers(i)
            players.Add(j)
        Next
    End Sub

    Private Sub UpdateListBoxes()
        If ascendingOrder Then
            players.Sort(Function(a, b)
                             Dim compareCards = b.nbCarte.CompareTo(a.nbCarte)
                             If compareCards = 0 Then
                                 Return b.MeilleurTemps.CompareTo(a.MeilleurTemps)
                             End If
                             Return compareCards
                         End Function)
        Else
            players.Sort(Function(a, b)
                             Dim compareCards = a.nbCarte.CompareTo(b.nbCarte)
                             If compareCards = 0 Then
                                 Return a.MeilleurTemps.CompareTo(b.MeilleurTemps)
                             End If
                             Return compareCards
                         End Function)
        End If

        ListBoxNom.Items.Clear()
        ListBoxNbcarte.Items.Clear()
        ListBoxCumul.Items.Clear()
        ListBoxtemps.Items.Clear()
        ListBoxNbpartie.Items.Clear()

        For Each player In players
            ListBoxNom.Items.Add(player.Prenom)
            ListBoxNbcarte.Items.Add(player.nbCarte)
            ListBoxCumul.Items.Add(player.TempsJoue)
            ListBoxtemps.Items.Add(player.MeilleurTemps)
            ListBoxNbpartie.Items.Add(player.NbPartie)
        Next
    End Sub

    Private Sub BtnTri_Click(sender As Object, e As EventArgs) Handles BtnTri.Click
        ascendingOrder = Not ascendingOrder
        UpdateListBoxes()
    End Sub

    Private Sub BtnVal_Click(sender As Object, e As EventArgs) Handles BtnVal.Click
        Dim selectedName As String = CmBoxJ.Text.Trim()

        If selectedName.Length = 0 Then
            MsgBox("Veuillez sélectionner un joueur.")
            Exit Sub
        End If

        Dim selectedPlayer = players.FirstOrDefault(Function(p) p.Prenom.ToLower() = selectedName.ToLower())

        Dim stats As String = "Statistiques de " & selectedPlayer.Prenom & " :" & vbCrLf &
                                  "- Nombre de parties : " & selectedPlayer.NbPartie & vbCrLf &
                                  "- Meilleur score (carrés) : " & selectedPlayer.nbCarte & vbCrLf &
                                  "- Meilleur temps : " & selectedPlayer.MeilleurTemps & " s" & vbCrLf &
                                  "- Temps total de jeu : " & selectedPlayer.TempsJoue & " s"
        MsgBox(stats, MsgBoxStyle.Information, "Statistiques joueur")


    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnSupp.Click
        Dim nom As String = CmBoxJ.Text.Trim()

        If nom = "" Then
            MsgBox("Veuillez sélectionner un joueur à supprimer.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim rep = MsgBox("Voulez-vous vraiment supprimer " & nom & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmation")
        If rep = MsgBoxResult.No Then Exit Sub

        SupprimerJoueur(nom)
        SauvegarderDansFichier("joueurs.txt")

        LoadPlayers()
        UpdateListBoxes()

        CmBoxJ.Items.Clear()
        For Each joueur As Joueur In players
            CmBoxJ.Items.Add(joueur.Prenom)
        Next
        CmBoxJ.Text = ""

        MsgBox("Joueur supprimé avec succès.", MsgBoxStyle.Information)
    End Sub
End Class