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
    
     Private Sub btnPokaz_Click(sender As Object, e As EventArgs) Handles btnPokaz.Click
        Dim ident = InputBox("Podaj id produktu", "IDProduktu")
        Dim printRecord As Produkty =
            db.Produkty.FirstOrDefault(Function(ex) ex.IDProduktu.Equals(ident))

        tbWynik.Text = $"Produkt -> ID: {printRecord.IDProduktu}, nazwa: {printRecord.NazwaProduktu}, cena jednostkowa: {printRecord.CenaJednostkowa}"
    End Sub

End Class
