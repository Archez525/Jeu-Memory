Imports System.Drawing

Public Class Map_3

    Private Const DUREE_PARTIE_INITIALE As Integer = 60
    Private Const NB_CARTES_TOTAL As Integer = 20
    Private Const NB_CARTES_POUR_CARRE As Integer = 4
    Private Const INTERVAL_TIMER_RETOUR As Integer = 250
    Private Const INTERVAL_TIMER_PRINCIPAL As Integer = 1000


    Public remainingTime As Integer = DUREE_PARTIE_INITIALE
    Dim nbCarte As Integer = 0
    Dim images As New List(Of Image)
    Dim rnd As New Random()
    Private premierRetourne As Label = Nothing
    Private deuxiemeRetourne As Label = Nothing
    Private troisiemeRetourne As Label = Nothing
    Private quatriemeRetourne As Label = Nothing
    Private retournementEnCours As Boolean = False

    Dim TimerRetour As New Timer()
    Dim Timer1 As New Timer()
    Dim tempsEcoulé As Integer
    Private timerDemarre As Boolean = False


    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Préparer les images (10 paires)

        images = New List(Of Image) From {
            My.Resources.Image1, My.Resources.Image2, My.Resources.Image3,
            My.Resources.Image4, My.Resources.Image5,
            My.Resources.Image1, My.Resources.Image2, My.Resources.Image3,
            My.Resources.Image4, My.Resources.Image5,
            My.Resources.Image1, My.Resources.Image2, My.Resources.Image3,
            My.Resources.Image4, My.Resources.Image5,
            My.Resources.Image1, My.Resources.Image2, My.Resources.Image3,
            My.Resources.Image4, My.Resources.Image5
        }

        images = images.OrderBy(Function(x) rnd.Next()).ToList()

        ' Assigner les images dans le Tag des labels (mais ne pas les afficher)
        For i As Integer = 0 To NB_CARTES_TOTAL - 1
            Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
            lbl.Tag = images(i)
            lbl.Image = Nothing
            lbl.BackColor = SystemColors.ActiveCaption
            lbl.Enabled = True
        Next

        remainingTime = DUREE_PARTIE_INITIALE
        lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")

        TimerRetour.Interval = INTERVAL_TIMER_RETOUR ' délai pour cacher cartes non identiques
        AddHandler TimerRetour.Tick, AddressOf TimerRetour_Tick

        Timer1.Interval = INTERVAL_TIMER_PRINCIPAL
        lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        lblNom.Parent = PictureBox1
        lblNom.BackColor = Color.Transparent
        lblTimer.Parent = PictureBox1
        lblTimer.BackColor = Color.Transparent

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If remainingTime > 0 Then
            remainingTime -= 1
            tempsEcoulé = DUREE_PARTIE_INITIALE - remainingTime
            lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")
        Else
            Timer1.Stop()
            MessageBox.Show("Temps écoulé !")
            btnAband.Text = "Retour à l'accueil"
            nbCarte = nbCarteTrouvee()
            enregistrementStat(getIndicePersPrenom(lblNom.Text), tempsEcoulé, nbCarte)
            For i As Integer = 0 To NB_CARTES_TOTAL - 1 ' Désactive les cartes
                Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
                lbl.Enabled = False
                lbl.BackColor = Color.LightGray
            Next
        End If
    End Sub

    Public Function nbCarteTrouvee() As Integer
        Dim nbCarteTrouve As Integer = 0
        For i As Integer = 0 To NB_CARTES_TOTAL - 1
            Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
            If lbl.Tag IsNot Nothing AndAlso lbl.Enabled = False Then
                nbCarteTrouve += 1
            End If
        Next
        Return nbCarteTrouve
    End Function

    Public Function finPartie() As Boolean
        For i As Integer = 0 To NB_CARTES_TOTAL - 1
            Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
            If lbl.Enabled Then Return False
        Next
        Return True
    End Function

    Dim cartesRetournees As New List(Of Label)

    ' Variables globales nécessaires
    Dim imageDeReference As Image = Nothing

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles _
Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click,
Label6.Click, Label7.Click, Label8.Click, Label9.Click, Label10.Click,
Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click,
Label16.Click, Label17.Click, Label18.Click, Label19.Click, Label20.Click

        If Not timerDemarre Then
            Timer1.Start()
            timerDemarre = True
        End If

        If retournementEnCours Then Exit Sub

        Dim lbl As Label = CType(sender, Label)
        ' Ne rien faire si déjà retournée ou trop de cartes affichées
        If lbl.Image IsNot Nothing OrElse cartesRetournees.Count >= 4 Then Exit Sub

        ' Révéler la carte
        lbl.Image = CType(lbl.Tag, Image)
        lbl.BackColor = Color.LightGray
        cartesRetournees.Add(lbl)

        ' Si c'est la première carte, mémoriser son image
        If cartesRetournees.Count = 1 Then
            imageDeReference = lbl.Image
        Else
            ' Comparer avec l’image de référence
            If Not ImagesIdentiques(lbl.Image, imageDeReference) Then
                ' Images différentes : on retourne tout après courte pause
                retournementEnCours = True
                TimerRetour.Start()
                Exit Sub
            End If
        End If

        ' Si 4 cartes retournées et toutes identiques
        If cartesRetournees.Count = NB_CARTES_POUR_CARRE Then
            For Each c In cartesRetournees
                c.Enabled = False
                c.Tag = "trouvé"
            Next
            cartesRetournees.Clear()
            imageDeReference = Nothing

            ' Vérifie si partie finie
            If finPartie() Then
                Timer1.Stop()
                MsgBox("Partie gagnée !")
                nbCarte = NB_CARTES_TOTAL
                btnAband.Text = "Retour à l'accueil"
            End If
        End If
    End Sub


    Private Sub TimerRetour_Tick(sender As Object, e As EventArgs)
        TimerRetour.Stop() ' Stoppe le timer pour éviter plusieurs déclenchements

        ' Cache toutes les cartes retournées
        For Each carte As Label In cartesRetournees
            carte.Image = Nothing
            carte.BackColor = SystemColors.ActiveCaption ' Ou la couleur de fond initiale
            carte.Enabled = True ' Réactive les cartes pour qu'elles puissent être cliquées à nouveau
        Next

        ' Réinitialise les variables pour la prochaine série de clics
        cartesRetournees.Clear()
        imageDeReference = Nothing
        retournementEnCours = False
    End Sub



    Public Function ImagesIdentiques(img1 As Image, img2 As Image) As Boolean
        If img1 Is Nothing OrElse img2 Is Nothing Then Return False
        Using ms1 As New IO.MemoryStream(), ms2 As New IO.MemoryStream()
            img1.Save(ms1, Imaging.ImageFormat.Png)
            img2.Save(ms2, Imaging.ImageFormat.Png)
            Return ms1.ToArray().SequenceEqual(ms2.ToArray())
        End Using
    End Function

    Private Sub btnAband_Click(sender As Object, e As EventArgs) Handles btnAband.Click
        Timer1.Stop()
        Dim rep As MsgBoxResult
        nbCarte = nbCarteTrouvee()
        rep = MsgBox("Voulez vous enregistrer les stats de cette partie", vbYesNo, "Statistique")
        If rep = MsgBoxResult.Yes Then
            enregistrementStat(getIndicePersPrenom(lblNom.Text), tempsEcoulé, nbCarte)
        End If
        Me.Hide()
        accueil.Show()
    End Sub

    Private timerEnPause As Boolean = False

    Private Sub ButPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        If timerEnPause Then
            Timer1.Start()         ' Relance le timer
            For i As Integer = 0 To NB_CARTES_TOTAL - 1 ' Reactive les cartes
                Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
                If lbl.Tag IsNot Nothing AndAlso lbl.Tag.ToString() <> "trouvé" Then
                    lbl.Enabled = True
                    lbl.BackColor = SystemColors.ActiveCaption
                End If
            Next
        Else
            Timer1.Stop()          ' Met en pause
            For i As Integer = 0 To NB_CARTES_TOTAL - 1  ' Désactive les cartes
                Dim lbl As Label = CType(Me.Controls("Label" & (i + 1).ToString()), Label)
                lbl.Enabled = False
                lbl.BackColor = Color.LightGray
            Next
        End If
        timerEnPause = Not timerEnPause ' Inverse l'état
    End Sub


End Class