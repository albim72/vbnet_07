'Napisz klasę Sportowiec -> wprowadż następujące Pola (imie, nazwisko, wiek, wzrost, waga) a następnie
'dopisz pola lokalne: dyscyplina, lata_uprawiania, best_wynik
'napisz metodę: infosport() -> która ma wypisyać dane lokalne: dyscyplina, lata_uprawiania, best_wynik
'Stwórz instancję tej klasy (obiekt) w module głównym i wykonaj na nim wszystkie możliwe metody
Public Class Sportowiec : Inherits Osoba
    Public dyscyplina As String
    Public lata_upr As Integer
    Public best_wynik As String

    Public Sub New(imie As String, nazwisko As String, wiek As Integer, wzrost As Double, waga As Double,
                   dyscyplina As String, lata_upr As Integer, best_wynik As String)
        MyBase.New(imie, nazwisko, wiek, wzrost, waga)
        Me.dyscyplina = dyscyplina
        Me.lata_upr = lata_upr
        Me.best_wynik = best_wynik
    End Sub

    Public Function infosport() As String
        Console.WriteLine($"Dyscyplina {dyscyplina}, lata uprawiania: {lata_upr}, życiówka: {best_wynik}")
    End Function
End Class
