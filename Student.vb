Public Class Student : Inherits Pracownik
    Public nrstudenta As Integer
    Public kierunek As String
    Public rokstudiow As Integer

    Public Sub New(imie As String, nazwisko As String, wiek As Integer, wzrost As Double, waga As Double,
                   nrstudenta As Integer, kierunek As String, rokstudiow As Integer,
                   Optional firma As String = "", Optional stanowisko As String = "", Optional latapracy As Integer = 0,
                   Optional wynagrodenie As Double = 0)
        MyBase.New(imie, nazwisko, wiek, wzrost, waga, firma, stanowisko, latapracy, wynagrodenie)
        Me.nrstudenta = nrstudenta
        Me.kierunek = kierunek
        Me.rokstudiow = rokstudiow

    End Sub

    Public Function printStudent() As String
        Console.WriteLine($"Dane studenta {nrstudenta}, kierunek: {kierunek}, rok studiów: {rokstudiow}")
    End Function

    Public Overloads Function czyPracownik() As Boolean
        If firma = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
