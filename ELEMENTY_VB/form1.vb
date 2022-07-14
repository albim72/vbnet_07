Public Class Form1

    Sub Metoda()
        MessageBox.Show("Pierwsza metoda")
    End Sub
    Sub Metoda(tekst As String, Optional tytul As String = "Komunikat")
        MessageBox.Show(tekst, tytul)

    End Sub
    Private Sub btnMet_Click(sender As Object, e As EventArgs) Handles btnMet.Click
        Metoda()
        Metoda("to jest druga metoda z opcjonalnym parametrem")
        Metoda("to jest jest trzecia metoda z dwoma parametrami", "Trzecia")
    End Sub
End Class
