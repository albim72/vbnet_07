Public Class Osoba
    Public imie As String
    Public nazwisko As String
    Public wiek As Integer
    Public wzrost As Double
    Public waga As Double
    Public Sub New(imie As String, nazwisko As String, wiek As Integer, wzrost As Double, waga As Double)
        Me.imie = imie
        Me.nazwisko = nazwisko
        Me.wiek = wiek
        Me.wzrost = wzrost
        Me.waga = waga
    End Sub
    Public Function printOsoba() As String
        Console.WriteLine($"osoba -> imię: {imie} nazwisko {nazwisko}, wiek: {wiek} lat, 
wzrost: {wzrost} cm, waga: {waga} kg  ")
    End Function


    Public Function wiekza10lat() As Integer
        Return wiek + 10
    End Function

    Public Function czyPracownik() As Boolean
        Return False

    End Function
End Class
