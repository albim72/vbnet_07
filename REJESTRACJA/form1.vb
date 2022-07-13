Public Class Form1

    Public db As New osobaDataContext()

    Private Sub btnDodaj_Click(sender As Object, e As EventArgs) Handles btnDodaj.Click

        Dim imie, nazwisko, miasto, dataur, telefon As String

        imie = tbImie.Text
        nazwisko = tbNazwisko.Text
        miasto = tbMiasto.Text
        dataur = tbData.Text
        telefon = tbTel.Text

        Dim nOsoba As New osoba()

        nOsoba.imie = imie
        nOsoba.nazwisko = nazwisko
        nOsoba.data_urodzenia = dataur
        nOsoba.miasto = miasto
        nOsoba.telefon = telefon
        db.osoba.InsertOnSubmit(nOsoba)
        db.SubmitChanges()

        tbImie.Clear()
        tbNazwisko.Clear()
        tbMiasto.Clear()
        tbData.Clear()
        tbTel.Clear()

    End Sub
End Class

