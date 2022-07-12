Public Class Pracownik : Inherits Osoba
    Public firma As String
    Public stanowisko As String
    Public latapracy As Integer
    Public wynagrodenie As Double

    Public Sub New(imie As String, nazwisko As String, wiek As Integer, wzrost As Double, waga As Double,
                   firma As String, stanowisko As String, latapracy As Integer, wynagrodenie As Double)
        MyBase.New(imie, nazwisko, wiek, wzrost, waga)
        Me.firma = firma
        Me.stanowisko = stanowisko
        Me.latapracy = latapracy
        Me.wynagrodenie = wynagrodenie
    End Sub

    Public Function printPracownik() As String
        Console.WriteLine($"pracownik -> firma: {firma}, stanowisko: {stanowisko}, lata pracy: {latapracy}, wynagordzenie: {wynagrodenie} zł")
    End Function

    Public Overloads Function czyPracownik() As Boolean
        Return True

    End Function
End Class
