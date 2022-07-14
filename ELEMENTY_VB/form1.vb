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
    
    Delegate Sub Uchwyt(tekst As String)

    Private Sub ShowMessage(tekst As String)
        MessageBox.Show(tekst, "Komunikat!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Event Zdarzenie As Uchwyt

    Private Sub btnDlg_Click(sender As Object, e As EventArgs) Handles btnDlg.Click

        ShowMessage("wywołanie metody bezpośrednio")
        Dim UchwytMetody As Uchwyt = AddressOf ShowMessage
        UchwytMetody("Wywołanie metody przez uchwyt")

        AddHandler Zdarzenie, UchwytMetody
        RaiseEvent Zdarzenie("wywołanie metody przez zdarzenie")

    End Sub
        
         Delegate Function DInc(n As Integer) As Integer
    Delegate Function DIsEqual(x As Double, y As Double)
    Delegate Sub DShow(o As Object)
    Private Sub btnLam_Click(sender As Object, e As EventArgs) Handles btnLam.Click
        Dim Inc As DInc = Function(n As Integer) n + 1
        Dim _Inc As Func(Of Integer, Integer) = Function(n As Integer) n + 1
        Metoda(Inc(2).ToString())
        Metoda(_Inc(100).ToString())

        Dim ISEqual As DIsEqual = Function(x, y) x = y
        Dim _ISEqual As Func(Of Integer, Integer, Boolean) = Function(x, y) x = y

        Metoda(ISEqual(1, 1.18), ToString())
        Metoda(_ISEqual(2, 2).ToString)

        Dim Show As DShow = Sub(o) Metoda(o.ToString())
        Dim _Show As Action(Of Object) = Sub(o) Metoda(o.ToString())

        Show("Blabla")
        _Show("Blabla")

        Show(1222)
        _Show(1222)


        Dim slowa As String() = {"czereśnia", "jabłko", "truskawka", "kiwi", "borówka"}
        Dim dl_najkr As Integer = slowa.Min(Function(slowo) slowo.Length)
        Show(dl_najkr)


    End Sub
End Class
