Public Class Form1
    Public db As New gardenDataContext()
    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click
        Dim idd, name
        Dim price As Double
        idd = tbIdprod.Text
        name = tbNazwa.Text
        price = Double.Parse(tbCena.Text)

        Dim nowyProd As New Produkty()

        nowyProd.IDProduktu = idd
        nowyProd.NazwaProduktu = name
        nowyProd.CenaJednostkowa = price

        db.Produkty.InsertOnSubmit(nowyProd)
        db.SubmitChanges()

        MessageBox.Show("Dodano nowy rekord do tabeli Produkty....")

        tbIdprod.Clear()
        tbNazwa.Clear()
        tbCena.Clear()


    End Sub

End Class
