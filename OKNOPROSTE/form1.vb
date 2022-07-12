Public Class Form1
    Private Sub btnZamknij_Click(sender As Object, e As EventArgs) Handles btnZamknij.Click
        Close()
    End Sub

    Private Sub btnWeekDay_Click(sender As Object, e As EventArgs) Handles btnWeekDay.Click
        Dim r As Random = New Random()

        Dim n As Integer = r.Next(8)
        Dim opis As String

        Select Case n
            Case 1
                opis = "poniedziałek"
            Case 2
                opis = "wtorek"
            Case 3
                opis = "środa"
            Case 4
                opis = "czwartek"
            Case 5
                opis = "piątek"
            Case 6
                opis = "sobota"
            Case 7
                opis = "niedziela"
            Case Else
                opis = "błąd!"
        End Select
        MessageBox.Show($"Dzień tygodnia: {n}, {opis}")
        tbWynik.Text = opis
    End Sub
End Class
