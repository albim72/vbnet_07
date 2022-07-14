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
    
      Private Function Kwadrat(bok As Integer) As Long
        Return bok ^ 2
    End Function

    Private Function Kwadrat(bok As Double) As Double
        Return bok ^ 2
    End Function
    Private Sub btnKw_Click(sender As Object, e As EventArgs) Handles btnKw.Click
        Dim wynikL As Long = Kwadrat(23)
        Dim wynikD As Double = Kwadrat(5.89)
        Metoda($"wynik dla Long: {wynikL}, wynik dla Double: {wynikD}", "Kwadrat")
    End Sub
    Private Sub zakresDouble(ByVal min As Double, ByRef max As Double)
        min = Double.MinValue
        max = Double.MaxValue
        Metoda($"Liczby Double mają zakres od: {min} do {max}", "Typ Double")
    End Sub
    Private Sub btnBRef_Click(sender As Object, e As EventArgs) Handles btnBRef.Click
        Dim min As Double = 0, max As Double = 0
        zakresDouble(min, max)
        Metoda($"Liczby Double - lokalnie: {min} - {max}")
    End Sub
End Class
