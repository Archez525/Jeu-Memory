Imports System.IO
Imports System.Reflection
Imports MaterialSkin

Module EnregistrementJoueur

    Private Const FACTEUR_EXTENSION As Integer = 2
    Private Const NB_DONNEES_JOUEUR As Integer = 5
    Public Structure Joueur
        Dim Prenom As String
        Dim MeilleurTemps As Integer
        Dim NbPartie As Integer
        Dim TempsJoue As Integer
        Dim nbCarte As Integer
    End Structure

    Private tabJoueur() As Joueur = New Joueur(9) {}
    Private nbJoueur As Integer = 0

    Public Sub ajout(j As Joueur)
        Debug.Assert(Trim(j.Prenom) <> "")

        If nbJoueur >= tabJoueur.Length Then
            ReDim Preserve tabJoueur(tabJoueur.Length * FACTEUR_EXTENSION - 1)
        End If

        tabJoueur(nbJoueur) = j
        nbJoueur += 1
    End Sub

    Public Function getPers(i As Integer) As Joueur
        Debug.Assert(i >= 0 And i < nbJoueur)
        Return tabJoueur(i)
    End Function

    Public Function getPersPrenom(prenom As String) As Joueur?
        For i As Integer = 0 To nbJoueur - 1
            If tabJoueur(i).Prenom = prenom Then
                Return getPers(i)
            End If
        Next
        Return Nothing
    End Function

    Public Function getIndicePersPrenom(prenom As String) As Integer
        For i As Integer = 0 To nbJoueur - 1
            If tabJoueur(i).Prenom = prenom Then
                Return i
            End If
        Next
        Return Nothing
    End Function

    Public Function getNbPers() As Integer
        Return nbJoueur
    End Function

    Public Function Existe(prenom As String) As Boolean
        For i As Integer = 0 To nbJoueur - 1
            If tabJoueur(i).Prenom = prenom Then Return True
        Next
        Return False
    End Function

    Public Sub setTempsJoue(index As Integer, temps As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        tabJoueur(index).TempsJoue += temps
    End Sub

    Public Sub setMeilleurTemps(index As Integer, temps As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        tabJoueur(index).MeilleurTemps = temps
    End Sub

    Public Sub incrementNbPartie(index As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        tabJoueur(index).NbPartie += 1
    End Sub

    Public Sub enregistrementStat(index As Integer, temps As Integer, nbCarte As Integer)
        incrementNbPartie(index)
        If tabJoueur(index).nbCarte <= nbCarte Then
            tabJoueur(index).nbCarte = nbCarte
            setMeilleurTemps(index, temps)
            If tabJoueur(index).MeilleurTemps = 0 OrElse temps < tabJoueur(index).MeilleurTemps Then
                setMeilleurTemps(index, temps)
            End If
        End If
        setTempsJoue(index, temps)
        SauvegarderDansFichier("joueurs.txt")
    End Sub

    Public Sub SauvegarderDansFichier(chemin As String)
        Using sw As New StreamWriter(chemin, False)
            For i As Integer = 0 To nbJoueur - 1
                Dim j As Joueur = tabJoueur(i)
                Dim ligne As String = $"{j.Prenom};{j.MeilleurTemps};{j.NbPartie};{j.TempsJoue};{j.nbCarte}"
                sw.WriteLine(ligne)
            Next
        End Using
    End Sub

    Public Sub SupprimerJoueur(prenom As String)
        Dim index As Integer = getIndicePersPrenom(prenom)
        If index >= 0 AndAlso index < nbJoueur Then
            For i As Integer = index To nbJoueur - 2
                tabJoueur(i) = tabJoueur(i + 1)
            Next
            nbJoueur -= 1
        End If
    End Sub

    Public Sub ChargerDepuisFichier(chemin As String)
        If Not File.Exists(chemin) Then Exit Sub

        Dim lignes() As String = File.ReadAllLines(chemin)
        For Each ligne In lignes
            Dim donnees() As String = ligne.Split(";"c)
            If donnees.Length >= NB_DONNEES_JOUEUR Then
                Dim j As Joueur
                j.Prenom = donnees(0)
                j.MeilleurTemps = CInt(donnees(1))
                j.NbPartie = CInt(donnees(2))
                j.TempsJoue = CInt(donnees(3))
                j.nbCarte = CInt(donnees(4))

                ajout(j)
            End If
        Next
    End Sub
End Module