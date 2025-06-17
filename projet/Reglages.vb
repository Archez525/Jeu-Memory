Imports System.Drawing
Public Class reglage
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        accueil.Show()
    End Sub

    Private Sub reglage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_map1.Image = My.Resources.Map_1
        lbl_map2.Image = My.Resources.Map_2
        lbl_map3.Image = My.Resources.Map_3
        lbl_map4.Image = My.Resources.Map_4
        lbl_map5.Image = My.Resources.Map_5
    End Sub
End Class